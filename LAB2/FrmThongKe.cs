using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB2
{
    public partial class FrmThongKe : Form
    {
        private string connectionString = @"Server=DESKTOP-97SL3ND;Database=QuanLyThuVienDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

            // Mặc định khoảng thời gian: ngày đầu tháng hiện tại đến ngày hôm nay
            dtTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDen.Value = DateTime.Now;

            // Đăng ký sự kiện click cho duy nhất 1 nút Thống kê
            btnThongKe.Click -= btnThongKe_Click;
            btnThongKe.Click += btnThongKe_Click;

            // Tải dữ liệu thống kê ban đầu
            ThucHienThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            DateTime tuNgay = dtTu.Value.Date;
            DateTime denNgay = dtDen.Value.Date;

            // KỊCH BẢN VALIDATION CỦA THẦY: Đổi thứ tự mốc nếu người dùng nhập ngược
            if (tuNgay > denNgay)
            {
                DateTime temp = tuNgay;
                tuNgay = denNgay;
                denNgay = temp;

                // Cập nhật lại giao diện hiển thị đúng thứ tự
                dtTu.Value = tuNgay;
                dtDen.Value = denNgay;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. KPI: LƯỢT SÁCH MƯỢN (Số lượng ChiTietPhieuMuon phát sinh trong khoảng thời gian)
                    string sqlMuon = @"SELECT COUNT(*) 
                                       FROM dbo.ChiTietPhieuMuon ct
                                       INNER JOIN dbo.PhieuMuon pm ON ct.MaPhieuMuon = pm.MaPhieuMuon
                                       WHERE pm.NgayMuon BETWEEN @TuNgay AND @DenNgay";
                    using (SqlCommand cmd = new SqlCommand(sqlMuon, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        int countMuon = Convert.ToInt32(cmd.ExecuteScalar());
                        lblMuon.Text = "Lượt sách mượn: " + countMuon;
                    }

                    // 2. KPI: SÁCH QUÁ HẠN (Sách chưa trả mà ngày hẹn trả < ngày hiện tại, hoặc trả sau ngày hẹn)
                    string sqlQuaHan = @"SELECT COUNT(*) 
                                         FROM dbo.ChiTietPhieuMuon ct
                                         INNER JOIN dbo.PhieuMuon pm ON ct.MaPhieuMuon = pm.MaPhieuMuon
                                         WHERE pm.NgayMuon BETWEEN @TuNgay AND @DenNgay
                                           AND ((ct.NgayTraThucTe IS NULL AND pm.NgayHenTra < CAST(GETDATE() AS DATE))
                                                OR (ct.NgayTraThucTe IS NOT NULL AND ct.NgayTraThucTe > pm.NgayHenTra))";
                    using (SqlCommand cmd = new SqlCommand(sqlQuaHan, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        int countQuaHan = Convert.ToInt32(cmd.ExecuteScalar());
                        lblQuaHan.Text = "Sách quá hạn: " + countQuaHan;
                    }

                    // 3. KPI: SÁCH MẤT (TinhTrangTra = N'Mất')
                    string sqlMat = @"SELECT COUNT(*) 
                                      FROM dbo.ChiTietPhieuMuon ct
                                      INNER JOIN dbo.PhieuMuon pm ON ct.MaPhieuMuon = pm.MaPhieuMuon
                                      WHERE pm.NgayMuon BETWEEN @TuNgay AND @DenNgay 
                                        AND ct.TinhTrangTra = N'Mất'";
                    using (SqlCommand cmd = new SqlCommand(sqlMat, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        int countMat = Convert.ToInt32(cmd.ExecuteScalar());
                        lblMat.Text = "Sách mất: " + countMat;
                    }

                    // 4. KPI: SÁCH HƯ HỎNG (TinhTrangTra = N'Rách - Hư')
                    string sqlHuHong = @"SELECT COUNT(*) 
                                         FROM dbo.ChiTietPhieuMuon ct
                                         INNER JOIN dbo.PhieuMuon pm ON ct.MaPhieuMuon = pm.MaPhieuMuon
                                         WHERE pm.NgayMuon BETWEEN @TuNgay AND @DenNgay 
                                           AND ct.TinhTrangTra = N'Rách - Hư'";
                    using (SqlCommand cmd = new SqlCommand(sqlHuHong, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        int countHuHong = Convert.ToInt32(cmd.ExecuteScalar());
                        lblHuHong.Text = "Sách hư hỏng: " + countHuHong;
                    }

                    // 5. KPI: TỔNG PHÍ PHẠT
                    string sqlTongPhat = @"SELECT ISNULL(SUM(PhiPhat), 0) 
                                           FROM dbo.PhieuPhat 
                                           WHERE NgayPhat BETWEEN @TuNgay AND @DenNgay";
                    using (SqlCommand cmd = new SqlCommand(sqlTongPhat, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        decimal tongPhat = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblPhiPhat.Text = "Tổng phí phạt: " + string.Format("{0:N0}", tongPhat) + " đ";
                    }

                    // 6. BẢNG CHI TIẾT PHIẾU PHẠT (Đổ vào dgvPhat)
                    // Cột hiển thị theo bảng thiết kế: Mã phiếu, Ngày, Độc giả, Mã sách, Lý do, Phí phạt
                    string sqlDgv = @"SELECT 
                                        pp.MaPhieuPhat AS [Mã phiếu],
                                        pp.NgayPhat AS [Ngày],
                                        (dg.Ho + ' ' + dg.Ten) AS [Độc giả],
                                        ct.MaDauSach AS [Mã sách],
                                        pp.LyDo AS [Lý do],
                                        pp.PhiPhat AS [Phí phạt]
                                      FROM dbo.PhieuPhat pp
                                      INNER JOIN dbo.ChiTietPhieuMuon ct ON pp.MaChiTiet = ct.MaChiTiet
                                      INNER JOIN dbo.PhieuMuon pm ON ct.MaPhieuMuon = pm.MaPhieuMuon
                                      INNER JOIN dbo.DocGia dg ON pm.MaDocGia = dg.MaDocGia
                                      WHERE pp.NgayPhat BETWEEN @TuNgay AND @DenNgay";

                    using (SqlCommand cmd = new SqlCommand(sqlDgv, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                        cmd.Parameters.AddWithValue("@DenNgay", denNgay);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvPhat.Columns.Clear();
                        dgvPhat.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}