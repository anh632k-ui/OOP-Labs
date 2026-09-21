using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB2
{
    public partial class FrmSach : Form
    {
        private string connectionString = @"Server=DESKTOP-97SL3ND;Database=QuanLyThuVienDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

            // 1. Cấu hình giới hạn cho NumericUpDown để không bị lỗi quá 100
            if (numNamXB != null)
            {
                numNamXB.Minimum = 1900;
                numNamXB.Maximum = 3000;
                numNamXB.Value = DateTime.Now.Year;
            }

            if (numSoLuong != null)
            {
                numSoLuong.Minimum = 0;
                numSoLuong.Maximum = 100000;
                numSoLuong.Value = 1;
            }

            // 2. Nạp dữ liệu vào ComboBox và DataGridView
            LoadComboBoxTheLoai();
            LoadComboBoxNXB();
            LoadDanhSachDauSach();

            // 3. Đăng ký sự kiện Click DataGridView và các nút (tránh trùng lặp)
            dgvSach.CellClick -= dgvSach_CellClick;
            dgvSach.CellClick += dgvSach_CellClick;

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnSua.Click -= btnSua_Click;
            btnSua.Click += btnSua_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.Click -= btnLamMoi_Click;
            btnLamMoi.Click += btnLamMoi_Click;


        }

        // ================= 1. NẠP COMBOBOX THỂ LOẠI & NXB =================
        private void LoadComboBoxTheLoai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaTheLoai, TenTheLoai FROM dbo.TheLoai";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboTheLoai.DataSource = dt;
                cboTheLoai.DisplayMember = "TenTheLoai";
                cboTheLoai.ValueMember = "MaTheLoai";
            }
        }

        private void LoadComboBoxNXB()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MaNhaXuatBan FROM dbo.NhaXuatBan";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboNXB.DataSource = dt;
                cboNXB.DisplayMember = "MaNhaXuatBan";
                cboNXB.ValueMember = "MaNhaXuatBan";
            }
        }

        // ================= 2. NẠP DANH SÁCH ĐẦU SÁCH =================
        private void LoadDanhSachDauSach()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        ds.MaDauSach, 
                                        ds.TenSach, 
                                        ds.NamXuatBan, 
                                        ds.SoLuongHienCo, 
                                        tl.TenTheLoai, 
                                        ds.MaTheLoai,
                                        ds.MaNhaXuatBan
                                     FROM dbo.DauSach ds
                                     INNER JOIN dbo.TheLoai tl ON ds.MaTheLoai = tl.MaTheLoai";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSach.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp danh sách sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 3. CHỌN DÒNG TRÊN LƯỚI ĐỔ LÊN Ô NHẬP =================
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSach.Rows[e.RowIndex].Cells["MaDauSach"].Value != null)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaDauSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();

                // Gán năm xuất bản và số lượng (hỗ trợ cả NumericUpDown lẫn TextBox)
                if (numNamXB != null)
                    numNamXB.Value = Convert.ToDecimal(row.Cells["NamXuatBan"].Value);

                if (numSoLuong != null)
                    numSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuongHienCo"].Value);

                cboTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value.ToString();
                cboNXB.SelectedValue = row.Cells["MaNhaXuatBan"].Value.ToString();

                // Khóa ô Mã sách khi đang cập nhật
                txtMaSach.Enabled = false;
            }
        }

        // ================= 4. THÊM ĐẦU SÁCH =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sách và Tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trùng khóa chính MaDauSach
                    string checkQuery = "SELECT COUNT(*) FROM dbo.DauSach WHERE MaDauSach = @MaSach";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Mã đầu sách này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    int namXB = (int)numNamXB.Value;
                    int soLuong = (int)numSoLuong.Value;

                    string insertQuery = @"INSERT INTO dbo.DauSach(MaDauSach, TenSach, NamXuatBan, SoLuongHienCo, MaTheLoai, MaNhaXuatBan)
                                           VALUES (@MaSach, @TenSach, @NamXB, @SoLuong, @MaTL, @MaNXB)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim());
                        cmd.Parameters.AddWithValue("@NamXB", namXB);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@MaTL", cboTheLoai.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@MaNXB", cboNXB.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm đầu sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    LoadDanhSachDauSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 5. CẬP NHẬT / SỬA ĐẦU SÁCH =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn đầu sách cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int namXB = (int)numNamXB.Value;
                    int soLuong = (int)numSoLuong.Value;

                    string updateQuery = @"UPDATE dbo.DauSach 
                                           SET TenSach = @TenSach, NamXuatBan = @NamXB, SoLuongHienCo = @SoLuong, 
                                               MaTheLoai = @MaTL, MaNhaXuatBan = @MaNXB
                                           WHERE MaDauSach = @MaSach";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim());
                        cmd.Parameters.AddWithValue("@NamXB", namXB);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@MaTL", cboTheLoai.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@MaNXB", cboNXB.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thông tin đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    LoadDanhSachDauSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 6. XÓA ĐẦU SÁCH =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn đầu sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa đầu sách {txtMaSach.Text} không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // RÀNG BUỘC TOÀN VẸN: Kiểm tra sách đã từng được mượn trong ChiTietPhieuMuon chưa
                    string checkFK = "SELECT COUNT(*) FROM dbo.ChiTietPhieuMuon WHERE MaDauSach = @MaSach";
                    using (SqlCommand cmdFK = new SqlCommand(checkFK, conn))
                    {
                        cmdFK.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                        if (Convert.ToInt32(cmdFK.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Không thể xóa đầu sách này vì đã có dữ liệu phiếu mượn liên quan!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM dbo.DauSach WHERE MaDauSach = @MaSach";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    LoadDanhSachDauSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 7. LÀM MỚI FORM =================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            if (numNamXB != null) numNamXB.Value = DateTime.Now.Year;
            if (numSoLuong != null) numSoLuong.Value = 1;
            if (cboTheLoai.Items.Count > 0) cboTheLoai.SelectedIndex = 0;
            if (cboNXB.Items.Count > 0) cboNXB.SelectedIndex = 0;

            txtMaSach.Enabled = true;
            txtMaSach.Focus();
        }
    }
}