using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB2
{
    public partial class FrmDanhMuc : Form
    {
        private string connectionString = @"Server=DESKTOP-97SL3ND;Database=QuanLyThuVienDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

            // ================= 1. TAB NHÂN VIÊN =================
            if (cboNVPhai != null && cboNVPhai.Items.Count == 0)
            {
                cboNVPhai.Items.AddRange(new string[] { "Nam", "Nữ" });
                cboNVPhai.SelectedIndex = 0;
            }
            LoadDanhSachNhanVien();

            if (dgvNV != null)
            {
                dgvNV.CellClick -= dgvNV_CellClick;
                dgvNV.CellClick += dgvNV_CellClick;
            }

            // ================= 2. TAB THỂ LOẠI =================
            LoadDanhSachTheLoai();

            if (dgvTL != null)
            {
                dgvTL.CellClick -= dgvTL_CellClick;
                dgvTL.CellClick += dgvTL_CellClick;
            }
            if (btnTLThem != null)
            {
                btnTLThem.Click -= btnTLThem_Click;
                btnTLThem.Click += btnTLThem_Click;
            }
            if (btnTLSua != null)
            {
                btnTLSua.Click -= btnTLSua_Click;
                btnTLSua.Click += btnTLSua_Click;
            }
            if (btnTLXoa != null)
            {
                btnTLXoa.Click -= btnTLXoa_Click;
                btnTLXoa.Click += btnTLXoa_Click;
            }
            if (btnTLLamMoi != null)
            {
                btnTLLamMoi.Click -= btnTLLamMoi_Click;
                btnTLLamMoi.Click += btnTLLamMoi_Click;
            }

            // ================= 3. TAB NHÀ XUẤT BẢN =================
            LoadDanhSachNhaXuatBan();

            if (dgvNXB != null)
            {
                dgvNXB.CellClick -= dgvNXB_CellClick;
                dgvNXB.CellClick += dgvNXB_CellClick;
            }
            if (btnNXBThem != null)
            {
                btnNXBThem.Click -= btnNXBThem_Click;
                btnNXBThem.Click += btnNXBThem_Click;
            }
            if (btnNXBSua != null)
            {
                btnNXBSua.Click -= btnNXBSua_Click;
                btnNXBSua.Click += btnNXBSua_Click;
            }
            if (btnNXBXoa != null)
            {
                btnNXBXoa.Click -= btnNXBXoa_Click;
                btnNXBXoa.Click += btnNXBXoa_Click;
            }
            if (btnNXBLamMoi != null)
            {
                btnNXBLamMoi.Click -= btnNXBLamMoi_Click;
                btnNXBLamMoi.Click += btnNXBLamMoi_Click;
            }
        }

        // =============================================================
        //                     PHẦN 1: TAB NHÂN VIÊN
        // =============================================================

        private void LoadDanhSachNhanVien()
        {
            if (dgvNV == null) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaNhanVien, Ho, Ten, Phai, NgaySinh, ChucVu, SoDienThoai FROM dbo.NhanVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNV.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNV.Rows[e.RowIndex].Cells["MaNhanVien"].Value != null)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtNVMa.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHo.Text = row.Cells["Ho"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                cboNVPhai.SelectedItem = row.Cells["Phai"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtNVNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtNVMa.Enabled = false;
            }
        }

        public void btnNVThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM dbo.NhanVien WHERE MaNhanVien = @MaNV";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaNV", txtNVMa.Text.Trim());
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Mã nhân viên này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = @"INSERT INTO dbo.NhanVien(MaNhanVien, Ho, Ten, Phai, NgaySinh, ChucVu, SoDienThoai)
                                           VALUES (@MaNV, @Ho, @Ten, @Phai, @NgaySinh, @ChucVu, NULL)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtNVMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ho", txtHo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phai", cboNVPhai.SelectedItem?.ToString() ?? "Nam");
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNVNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiNV();
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnNVSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE dbo.NhanVien 
                                           SET Ho = @Ho, Ten = @Ten, Phai = @Phai, NgaySinh = @NgaySinh, ChucVu = @ChucVu 
                                           WHERE MaNhanVien = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtNVMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ho", txtHo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phai", cboNVPhai.SelectedItem?.ToString() ?? "Nam");
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNVNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiNV();
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnNVXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {txtNVMa.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkFK = "SELECT COUNT(*) FROM dbo.PhieuMuon WHERE MaNhanVien = @MaNV";
                    using (SqlCommand cmdFK = new SqlCommand(checkFK, conn))
                    {
                        cmdFK.Parameters.AddWithValue("@MaNV", txtNVMa.Text.Trim());
                        if (Convert.ToInt32(cmdFK.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Không thể xóa nhân viên đã lập phiếu mượn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM dbo.NhanVien WHERE MaNhanVien = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtNVMa.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiNV();
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnNVLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiNV();
        }

        private void LamMoiNV()
        {
            txtNVMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtChucVu.Clear();
            if (cboNVPhai != null && cboNVPhai.Items.Count > 0) cboNVPhai.SelectedIndex = 0;
            dtNVNgaySinh.Value = DateTime.Now;
            txtNVMa.Enabled = true;
            txtNVMa.Focus();
        }

        // =============================================================
        //                     PHẦN 2: TAB THỂ LOẠI
        // =============================================================

        private void LoadDanhSachTheLoai()
        {
            if (dgvTL == null) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaTheLoai AS [Mã Thể Loại], TenTheLoai AS [Tên Thể Loại] FROM dbo.TheLoai";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTL.Columns.Clear();
                    dgvTL.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTL.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvTL.Rows[e.RowIndex];
                txtTLMa.Text = row.Cells[0].Value.ToString();
                txtTLTen.Text = row.Cells[1].Value.ToString();
                txtTLMa.Enabled = false;
            }
        }

        private void btnTLThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text) || string.IsNullOrWhiteSpace(txtTLTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã thể loại và Tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkMa = "SELECT COUNT(*) FROM dbo.TheLoai WHERE MaTheLoai = @MaTL";
                    using (SqlCommand cmdCheck = new SqlCommand(checkMa, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@MaTL", txtTLMa.Text.Trim());
                        if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Mã thể loại này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string checkTen = "SELECT COUNT(*) FROM dbo.TheLoai WHERE TenTheLoai = @TenTL";
                    using (SqlCommand cmdCheckTen = new SqlCommand(checkTen, conn))
                    {
                        cmdCheckTen.Parameters.AddWithValue("@TenTL", txtTLTen.Text.Trim());
                        if (Convert.ToInt32(cmdCheckTen.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Tên thể loại này đã có trong danh mục!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO dbo.TheLoai(MaTheLoai, TenTheLoai) VALUES (@MaTL, @TenTL)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTL", txtTLMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenTL", txtTLTen.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiTL();
                    LoadDanhSachTheLoai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTLSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkTen = "SELECT COUNT(*) FROM dbo.TheLoai WHERE TenTheLoai = @TenTL AND MaTheLoai <> @MaTL";
                    using (SqlCommand cmdCheck = new SqlCommand(checkTen, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@TenTL", txtTLTen.Text.Trim());
                        cmdCheck.Parameters.AddWithValue("@MaTL", txtTLMa.Text.Trim());
                        if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Tên thể loại này đã trùng với thể loại khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string updateQuery = "UPDATE dbo.TheLoai SET TenTheLoai = @TenTL WHERE MaTheLoai = @MaTL";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTL", txtTLTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaTL", txtTLMa.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiTL();
                    LoadDanhSachTheLoai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTLXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTLMa.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa thể loại {txtTLMa.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkFK = "SELECT COUNT(*) FROM dbo.DauSach WHERE MaTheLoai = @MaTL";
                    using (SqlCommand cmdFK = new SqlCommand(checkFK, conn))
                    {
                        cmdFK.Parameters.AddWithValue("@MaTL", txtTLMa.Text.Trim());
                        if (Convert.ToInt32(cmdFK.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Không thể xóa thể loại này vì đang có đầu sách liên kết!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM dbo.TheLoai WHERE MaTheLoai = @MaTL";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTL", txtTLMa.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiTL();
                    LoadDanhSachTheLoai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTLLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiTL();
        }

        private void LamMoiTL()
        {
            txtTLMa.Clear();
            txtTLTen.Clear();
            txtTLMa.Enabled = true;
            txtTLMa.Focus();
        }

        // =============================================================
        //                     PHẦN 3: TAB NHÀ XUẤT BẢN
        // =============================================================

        private void LoadDanhSachNhaXuatBan()
        {
            if (dgvNXB == null) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        MaNhaXuatBan AS [Mã NXB], 
                                        DiaChi AS [Địa chỉ], 
                                        SoDienThoai AS [Số điện thoại] 
                                     FROM dbo.NhaXuatBan";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvNXB.Columns.Clear();
                    dgvNXB.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp danh sách NXB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNXB.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvNXB.Rows[e.RowIndex];
                txtNXBMa.Text = row.Cells[0].Value?.ToString() ?? "";
                txtNXBDiaChi.Text = row.Cells[1].Value?.ToString() ?? "";
                txtNXBDT.Text = row.Cells[2].Value?.ToString() ?? "";

                txtNXBMa.Enabled = false;
            }
        }

        private void btnNXBThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trùng khóa chính MaNhaXuatBan
                    string checkQuery = "SELECT COUNT(*) FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = @MaNXB";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@MaNXB", txtNXBMa.Text.Trim());
                        if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Mã nhà xuất bản này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = @"INSERT INTO dbo.NhaXuatBan(MaNhaXuatBan, DiaChi, SoDienThoai)
                                           VALUES (@MaNXB, @DiaChi, @SDT)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNXB", txtNXBMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrWhiteSpace(txtNXBDiaChi.Text) ? (object)DBNull.Value : txtNXBDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", string.IsNullOrWhiteSpace(txtNXBDT.Text) ? (object)DBNull.Value : txtNXBDT.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiNXB();
                    LoadDanhSachNhaXuatBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm NXB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNXBSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE dbo.NhaXuatBan 
                                           SET DiaChi = @DiaChi, SoDienThoai = @SDT 
                                           WHERE MaNhaXuatBan = @MaNXB";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNXB", txtNXBMa.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrWhiteSpace(txtNXBDiaChi.Text) ? (object)DBNull.Value : txtNXBDiaChi.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", string.IsNullOrWhiteSpace(txtNXBDT.Text) ? (object)DBNull.Value : txtNXBDT.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiNXB();
                    LoadDanhSachNhaXuatBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật NXB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNXBXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNXBMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhà xuất bản {txtNXBMa.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Ràng buộc toàn vẹn: Kiểm tra có đầu sách nào thuộc NXB này không
                    string checkFK = "SELECT COUNT(*) FROM dbo.DauSach WHERE MaNhaXuatBan = @MaNXB";
                    using (SqlCommand cmdFK = new SqlCommand(checkFK, conn))
                    {
                        cmdFK.Parameters.AddWithValue("@MaNXB", txtNXBMa.Text.Trim());
                        if (Convert.ToInt32(cmdFK.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Không thể xóa nhà xuất bản này vì đang có các đầu sách liên kết!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string deleteQuery = "DELETE FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = @MaNXB";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNXB", txtNXBMa.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiNXB();
                    LoadDanhSachNhaXuatBan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa NXB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNXBLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiNXB();
        }

        private void LamMoiNXB()
        {
            txtNXBMa.Clear();
            txtNXBDiaChi.Clear();
            txtNXBDT.Clear();
            txtNXBMa.Enabled = true;
            txtNXBMa.Focus();
        }
    }
}