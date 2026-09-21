using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB2
{
    public partial class FrmMuonTra : Form
    {
        private string connectionString = @"Server=DESKTOP-97SL3ND;Database=QuanLyThuVienDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private DataTable dtSachChon = new DataTable();

        public FrmMuonTra()
        {
            InitializeComponent();
        }

        private void FrmMuonTra_Load(object sender, EventArgs e)
        {
            try
            {
                // Cấu hình bảng tạm cho dgvSachChon
                if (dtSachChon.Columns.Count == 0)
                {
                    dtSachChon.Columns.Add("MaDauSach", typeof(string));
                    dtSachChon.Columns.Add("TenSach", typeof(string));
                    dgvSachChon.DataSource = dtSachChon;
                }

                dtNgayMuon.Value = DateTime.Now;
                dtHenTra.Value = DateTime.Now.AddDays(7);

                LoadComboBoxDocGia();
                LoadSachConTrongKho();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu ban đầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Thêm các lựa chọn tình trạng sách trả theo kịch bản của thầy
            if (cboTinhTrang.Items.Count == 0)
            {
                cboTinhTrang.Items.AddRange(new string[] { "Bình thường", "Rách - Hư", "Mất" });
                cboTinhTrang.SelectedIndex = 0;
            }

            // Bắt sự kiện khi đổi độc giả ở ComboBox thì tự động tải sách đang mượn qua tab Trả
            //cboDocGia.SelectedIndexChanged += (s, ev) => LoadSachDangMuon();
        }

        // 1. Đổ danh sách độc giả (Ghép Ho + Ten chuẩn SQL)
        private void LoadComboBoxDocGia()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaDocGia, (Ho + ' ' + Ten) AS HoTen FROM DocGia";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboDocGia.DataSource = dt;
                cboDocGia.DisplayMember = "HoTen";
                cboDocGia.ValueMember = "MaDocGia";
            }
        }

        // 2. Load sách có SoLuongHienCo > 0
        private void LoadSachConTrongKho()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaDauSach, TenSach, NamXuatBan, SoLuongHienCo FROM DauSach WHERE SoLuongHienCo > 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSachCon.DataSource = dt;
            }
        }

        // 3. Nghiệp vụ: Kiểm tra điều kiện độc giả mượn sách
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả để kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDocGia = cboDocGia.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // A. Kiểm tra thẻ độc giả: TrangThai = 1, Đã đóng lệ phí, HanSuDung >= Hiện tại
                    string queryThe = @"SELECT HanSuDung, DaDongLePhi 
                                       FROM TheDocGia 
                                       WHERE MaDocGia = @MaDG AND TrangThai = 1";

                    using (SqlCommand cmdThe = new SqlCommand(queryThe, conn))
                    {
                        cmdThe.Parameters.AddWithValue("@MaDG", maDocGia);
                        using (SqlDataReader reader = cmdThe.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                lblTrangThai.Text = "Chưa có thẻ hoặc thẻ bị khóa!";
                                lblTrangThai.ForeColor = System.Drawing.Color.Red;
                                return;
                            }

                            bool daDongPhi = Convert.ToBoolean(reader["DaDongLePhi"]);
                            DateTime hanSuDung = Convert.ToDateTime(reader["HanSuDung"]);

                            if (!daDongPhi)
                            {
                                lblTrangThai.Text = "Chưa đóng lệ phí thẻ!";
                                lblTrangThai.ForeColor = System.Drawing.Color.Red;
                                return;
                            }

                            if (hanSuDung < DateTime.Now.Date)
                            {
                                lblTrangThai.Text = "Thẻ độc giả đã hết hạn!";
                                lblTrangThai.ForeColor = System.Drawing.Color.Red;
                                return;
                            }
                        }
                    }

                    // B. Kiểm tra sách nợ quá hạn (ChiTietPhieuMuon chưa trả mà NgayHenTra < Hiện tại)
                    string queryNoSach = @"SELECT COUNT(*) 
                                           FROM PhieuMuon pm
                                           INNER JOIN ChiTietPhieuMuon ct ON pm.MaPhieuMuon = ct.MaPhieuMuon
                                           WHERE pm.MaDocGia = @MaDG 
                                             AND ct.NgayTraThucTe IS NULL 
                                             AND pm.NgayHenTra < CAST(GETDATE() AS DATE)";

                    using (SqlCommand cmdNo = new SqlCommand(queryNoSach, conn))
                    {
                        cmdNo.Parameters.AddWithValue("@MaDG", maDocGia);
                        int quaHan = Convert.ToInt32(cmdNo.ExecuteScalar());
                        if (quaHan > 0)
                        {
                            lblTrangThai.Text = "Đang giữ sách mượn quá hạn!";
                            lblTrangThai.ForeColor = System.Drawing.Color.Red;
                            return;
                        }
                    }

                    lblTrangThai.Text = "Đủ điều kiện mượn sách";
                    lblTrangThai.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. Nghiệp vụ: Chuyển sách từ kho sang bảng chọn (Tối đa 3 cuốn)
        private void btnThemSach_Click(object sender, EventArgs e) => ThemSachVaoBangChon();
        private void btnThemSach_Click_1(object sender, EventArgs e) => ThemSachVaoBangChon();

        private void ThemSachVaoBangChon()
        {
            if (dgvSachCon.CurrentRow == null) return;

            if (dtSachChon.Rows.Count >= 3)
            {
                MessageBox.Show("Mỗi lần chỉ được mượn tối đa 3 cuốn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSach = dgvSachCon.CurrentRow.Cells[0].Value.ToString();
            string tenSach = dgvSachCon.CurrentRow.Cells[1].Value.ToString();

            foreach (DataRow r in dtSachChon.Rows)
            {
                if (r["MaDauSach"].ToString() == maSach)
                {
                    MessageBox.Show("Đầu sách này đã được thêm vào danh sách chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            dtSachChon.Rows.Add(maSach, tenSach);
        }

        // 5. Nghiệp vụ: Bỏ chọn sách
        private void btnBoSach_Click(object sender, EventArgs e) => BoSachKhoiBangChon();
        private void btnBoSach_Click_1(object sender, EventArgs e) => BoSachKhoiBangChon();

        private void BoSachKhoiBangChon()
        {
            if (dgvSachChon.CurrentRow != null && dgvSachChon.CurrentRow.Index < dtSachChon.Rows.Count)
            {
                dtSachChon.Rows.RemoveAt(dgvSachChon.CurrentRow.Index);
            }
        }

        // 6. Nghiệp vụ: Lập phiếu mượn (Lưu bảng PhieuMuon, ChiTietPhieuMuon, trừ SoLuongHienCo ở DauSach)
        private void btnLapPhieu_Click(object sender, EventArgs e) => ThucHienLapPhieu();
        private void btnLapPhieu_Click_1(object sender, EventArgs e) => ThucHienLapPhieu();

        private void ThucHienLapPhieu()
        {
            if (dtSachChon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 cuốn sách để mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDocGia = cboDocGia.SelectedValue.ToString();
            string maNV = string.IsNullOrWhiteSpace(txtMaNV.Text) ? "NV001" : txtMaNV.Text.Trim();
            string maPhieuMuon = "PM" + DateTime.Now.ToString("yyyyMMddHHmmss");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // A. Lưu bảng PhieuMuon (các cột: MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, NgayHenTra)
                    string insertPM = @"INSERT INTO dbo.PhieuMuon(MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, NgayHenTra) 
                                        VALUES (@MaPM, @MaDG, @MaNV, @NgayMuon, @NgayHenTra)";
                    using (SqlCommand cmdPM = new SqlCommand(insertPM, conn, trans))
                    {
                        cmdPM.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                        cmdPM.Parameters.AddWithValue("@MaDG", maDocGia);
                        cmdPM.Parameters.AddWithValue("@MaNV", maNV);
                        cmdPM.Parameters.AddWithValue("@NgayMuon", dtNgayMuon.Value.Date);
                        cmdPM.Parameters.AddWithValue("@NgayHenTra", dtHenTra.Value.Date);
                        cmdPM.ExecuteNonQuery();
                    }

                    // B. Lưu từng dòng vào ChiTietPhieuMuon và trừ SoLuongHienCo trong DauSach
                    int stt = 1;
                    foreach (DataRow row in dtSachChon.Rows)
                    {
                        string maSach = row["MaDauSach"].ToString();
                        string maChiTiet = maPhieuMuon + "_" + stt;

                        string insertCT = @"INSERT INTO dbo.ChiTietPhieuMuon(MaChiTiet, MaPhieuMuon, MaDauSach, NgayTraThucTe, TinhTrangTra) 
                                            VALUES (@MaCT, @MaPM, @MaDauSach, NULL, NULL)";
                        using (SqlCommand cmdCT = new SqlCommand(insertCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaCT", maChiTiet);
                            cmdCT.Parameters.AddWithValue("@MaPM", maPhieuMuon);
                            cmdCT.Parameters.AddWithValue("@MaDauSach", maSach);
                            cmdCT.ExecuteNonQuery();
                        }

                        string updateKho = @"UPDATE dbo.DauSach 
                                             SET SoLuongHienCo = SoLuongHienCo - 1 
                                             WHERE MaDauSach = @MaDauSach";
                        using (SqlCommand cmdKho = new SqlCommand(updateKho, conn, trans))
                        {
                            cmdKho.Parameters.AddWithValue("@MaDauSach", maSach);
                            cmdKho.ExecuteNonQuery();
                        }

                        stt++;
                    }

                    trans.Commit();
                    MessageBox.Show("Lập phiếu mượn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtSachChon.Clear();
                    LoadSachConTrongKho();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi lập phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng trả sách đang cập nhật!");
        }

        
    }
}