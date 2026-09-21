using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB2
{
    public partial class FrmDocGia : Form
    {
        private string connectionString = @"Server=DESKTOP-97SL3ND;Database=QuanLyThuVienDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmDocGia()
        {
            InitializeComponent();
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

            if (cboPhai.Items.Count == 0)
            {
                cboPhai.Items.AddRange(new string[] { "Nam", "Nữ" });
                cboPhai.SelectedIndex = 0;
            }

            dtNgayCap.Value = DateTime.Now;
            dtHan.Value = DateTime.Now.AddYears(1);

            LoadDanhSachDocGia();

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnCapNhat.Click -= btnCapNhat_Click;
            btnCapNhat.Click += btnCapNhat_Click;

            btnCapthe.Click -= btnCapthe_Click;
            btnCapthe.Click += btnCapthe_Click;

            btnGiaHan.Click -= btnGiaHan_Click;
            btnGiaHan.Click += btnGiaHan_Click;
        }

        // ================= 1. NẠP DANH SÁCH ĐỘC GIẢ =================
        private void LoadDanhSachDocGia()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Đặt tên cột (AS ...) trùng khớp hoàn toàn với thuộc tính Name của các cột trên Designer
                    string query = @"SELECT 
                                dg.MaDocGia, 
                                dg.Ho, 
                                dg.Ten, 
                                dg.Phai, 
                                dg.SoDienThoai, 
                                dg.Email, 
                                tdg.HanSuDung,
                                dg.NgaySinh,
                                dg.DiaChi,
                                dg.Anh3x4,
                                tdg.NgayCap,
                                tdg.DaDongLePhi
                             FROM dbo.DocGia dg
                             LEFT JOIN dbo.TheDocGia tdg ON dg.MaDocGia = tdg.MaDocGia AND tdg.TrangThai = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bật tự động nhận diện cột
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp danh sách độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 2. CLICK DÒNG TRÊN LƯỚI ĐỔ LÊN Ô NHẬP =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMa.Text = row.Cells["MaDocGia"].Value?.ToString() ?? row.Cells[0].Value?.ToString() ?? "";
                txtHo.Text = row.Cells["Ho"].Value?.ToString() ?? "";
                txtTen.Text = row.Cells["Ten"].Value?.ToString() ?? "";
                cboPhai.SelectedItem = row.Cells["Phai"].Value?.ToString() ?? "Nam";

                if (row.Cells["NgaySinh"].Value != DBNull.Value && row.Cells["NgaySinh"].Value != null)
                    dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                txtDT.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtAnh.Text = row.Cells["Anh3x4"].Value?.ToString() ?? "";

                if (row.Cells["NgayCap"].Value != DBNull.Value && row.Cells["NgayCap"].Value != null)
                    dtNgayCap.Value = Convert.ToDateTime(row.Cells["NgayCap"].Value);

                if (row.Cells["HanSuDung"].Value != DBNull.Value && row.Cells["HanSuDung"].Value != null)
                    dtHan.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);

                if (row.Cells["DaDongLePhi"].Value != DBNull.Value && row.Cells["DaDongLePhi"].Value != null)
                    chkLePhi.Checked = Convert.ToBoolean(row.Cells["DaDongLePhi"].Value);
                else
                    chkLePhi.Checked = false;

                txtMa.Enabled = false;
            }
        }

        // ================= 3. THÊM ĐỘC GIẢ =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã độc giả và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM dbo.DocGia WHERE MaDocGia = @MaDG";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaDG", txtMa.Text.Trim());
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Mã độc giả này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = @"INSERT INTO dbo.DocGia(MaDocGia, Ho, Ten, NgaySinh, Phai, SoDienThoai, DiaChi, Email, Anh3x4)
                                           VALUES (@MaDG, @Ho, @Ten, @NgaySinh, @Phai, @SDT, @DiaChi, @Email, @Anh)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDG", txtMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ho", txtHo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@Phai", cboPhai.SelectedItem?.ToString() ?? "Nam");
                        cmd.Parameters.AddWithValue("@SDT", txtDT.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrWhiteSpace(txtDiaChi.Text) ? "Chưa cập nhật" : txtDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? "docgia@example.com" : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Anh", string.IsNullOrWhiteSpace(txtAnh.Text) ? (object)DBNull.Value : txtAnh.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDocGia();
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 4. CẬP NHẬT ĐỘC GIẢ =================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE dbo.DocGia 
                                           SET Ho = @Ho, Ten = @Ten, NgaySinh = @NgaySinh, Phai = @Phai,
                                               SoDienThoai = @SDT, DiaChi = @DiaChi, Email = @Email, Anh3x4 = @Anh
                                           WHERE MaDocGia = @MaDG";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDG", txtMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ho", txtHo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@Phai", cboPhai.SelectedItem?.ToString() ?? "Nam");
                        cmd.Parameters.AddWithValue("@SDT", txtDT.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Anh", string.IsNullOrWhiteSpace(txtAnh.Text) ? (object)DBNull.Value : txtAnh.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDocGia();
                    LamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 5. CẤP THẺ =================
        private void btnCapthe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần cấp thẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkLePhi.Checked)
            {
                MessageBox.Show("Độc giả phải đóng lệ phí trước khi cấp thẻ!", "Quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkThe = "SELECT COUNT(*) FROM dbo.TheDocGia WHERE MaDocGia = @MaDG AND TrangThai = 1";
                    using (SqlCommand checkCmd = new SqlCommand(checkThe, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaDG", txtMa.Text.Trim());
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Độc giả này đã có thẻ đang hoạt động! Dùng chức năng Gia hạn nếu cần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    string maThe = "THE_" + txtMa.Text.Trim() + "_" + DateTime.Now.Year;
                    string insertThe = @"INSERT INTO dbo.TheDocGia(MaThe, MaDocGia, NgayCap, HanSuDung, DaDongLePhi, TrangThai)
                                         VALUES (@MaThe, @MaDG, @NgayCap, @HanSuDung, @DaDongPhi, 1)";

                    using (SqlCommand cmdThe = new SqlCommand(insertThe, conn))
                    {
                        cmdThe.Parameters.AddWithValue("@MaTheo", maThe);
                        cmdThe.Parameters.AddWithValue("@MaThe", maThe);
                        cmdThe.Parameters.AddWithValue("@MaDG", txtMa.Text.Trim());
                        cmdThe.Parameters.AddWithValue("@NgayCap", dtNgayCap.Value.Date);
                        cmdThe.Parameters.AddWithValue("@HanSuDung", dtHan.Value.Date);
                        cmdThe.Parameters.AddWithValue("@DaDongPhi", chkLePhi.Checked);
                        cmdThe.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cấp thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDocGia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cấp thẻ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 6. GIA HẠN THẺ =================
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần gia hạn thẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkLePhi.Checked)
            {
                MessageBox.Show("Vui lòng xác nhận đã đóng lệ phí gia hạn!", "Quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string queryGiaHan = @"UPDATE dbo.TheDocGia 
                                           SET HanSuDung = DATEADD(year, 1, CASE WHEN HanSuDung > GETDATE() THEN HanSuDung ELSE GETDATE() END),
                                               DaDongLePhi = 1 
                                           WHERE MaDocGia = @MaDG AND TrangThai = 1";

                    using (SqlCommand cmd = new SqlCommand(queryGiaHan, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDG", txtMa.Text.Trim());
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Gia hạn thẻ thêm 1 năm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachDocGia();
                        }
                        else
                        {
                            MessageBox.Show("Độc giả này chưa có thẻ để gia hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gia hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 7. LÀM MỚI =================
        private void LamMoi()
        {
            txtMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtAnh.Clear();
            cboPhai.SelectedIndex = 0;
            chkLePhi.Checked = false;
            dtNgayCap.Value = DateTime.Now;
            dtHan.Value = DateTime.Now.AddYears(1);

            txtMa.Enabled = true;
            txtMa.Focus();
        }

        private void FrmDocGia_Load_1(object sender, EventArgs e)
        {

        }
    }
}