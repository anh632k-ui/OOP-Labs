using System;
using System.Data;
using System.Drawing;
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
            // 1. Cấu hình ComboBox giới tính
            if (cboNVPhai.Items.Count == 0)
            {
                cboNVPhai.Items.AddRange(new string[] { "Nam", "Nữ" });
                cboNVPhai.SelectedIndex = 0;
            }

            // 2. Tải danh sách nhân viên lên DataGridView
            LoadDanhSachNhanVien();

            // 3. Đăng ký sự kiện click DataGridView và các nút thao tác
            dgvNV.CellClick -= dgvNV_CellClick;
            dgvNV.CellClick += dgvNV_CellClick;

        
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnNVThem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnNVSua_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnNVXoa_Click(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnNVLamMoi_Click(sender, e);
        }

        // ================= 1. NẠP DỮ LIỆU TỪ SQL =================
        private void LoadDanhSachNhanVien()
        {
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

        // ================= 2. CHỌN DÒNG TRÊN BẢNG ĐỔ LÊN Ô NHẬP =================
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
                {
                    dtNVNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }

                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();

                // Khóa ô Mã nhân viên không cho sửa khi đang chọn cập nhật
                txtNVMa.Enabled = false;
            }
        }

        // ================= 3. CHỨC NĂNG THÊM NHÂN VIÊN =================
        private void btnNVThem_Click(object sender, EventArgs e)
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

                    // Kiểm tra trùng khóa chính MaNhanVien
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
                    LamMoiForm();
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 4. CHỨC NĂNG CẬP NHẬT / SỬA =================
        private void btnNVSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoiForm();
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 5. CHỨC NĂNG XÓA NHÂN VIÊN =================
        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {txtNVMa.Text} không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // RÀNG BUỘC TOÀN VẸN: Kiểm tra nhân viên đã từng lập phiếu mượn/phạt chưa
                    string checkFK = "SELECT COUNT(*) FROM dbo.PhieuMuon WHERE MaNhanVien = @MaNV";
                    using (SqlCommand cmdFK = new SqlCommand(checkFK, conn))
                    {
                        cmdFK.Parameters.AddWithValue("@MaNV", txtNVMa.Text.Trim());
                        if (Convert.ToInt32(cmdFK.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Không thể xóa nhân viên này vì đã có dữ liệu lập phiếu mượn trong hệ thống!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    LamMoiForm();
                    LoadDanhSachNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ================= 6. LÀM MỚI FORM =================
        private void btnNVLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtNVMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtChucVu.Clear();
            cboNVPhai.SelectedIndex = 0;
            dtNVNgaySinh.Value = DateTime.Now;
            txtNVMa.Enabled = true;
            txtNVMa.Focus();
        }
    }
}