using System;
using System.Windows.Forms;

namespace HoSoBenhAnPrototype
{
    public partial class FrmBenhNhan : Form
    {
        private readonly BenhNhanService service = new BenhNhanService();

        public FrmBenhNhan()
        {
            InitializeComponent();
            btnChonAnh.Click += ChonAnh;
            btnDangKy.Click += DangKy;
            btnNhapLai.Click += NhapLai;
            btnTim.Click += (s, e) => TaiDanhSach();
            btnMoKham.Click += (s, e) => new FrmKhamBenh().ShowDialog(this);
            Shown += (s, e) => TaiDanhSach();
        }

        private void ChonAnh(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    txtAnh.Text = dialog.FileName;
        }

        private void NhapLai(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtAnh.Clear();
            ckDaDongPhi.Checked = false;
            dtNgaySinh.Value = DateTime.Today;
        }

        private void DangKy(object sender, EventArgs e)
        {
            try
            {
                var data = new BenhNhanData
                {
                    HoTen = txtHoTen.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    NgaySinh = dtNgaySinh.Value.Date,
                    DienThoai = txtDienThoai.Text.Trim(),
                    DuongDanAnh = txtAnh.Text.Trim(),
                    PhiNam = numPhi.Value
                };
                int id = service.DangKy(data, ckDaDongPhi.Checked);
                string maHoSo = "HS" + id.ToString("000000");
                MessageBox.Show(this, "Đã cấp hồ sơ: " + maHoSo, "Thành công");
                txtTim.Text = maHoSo;
                TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Không thể đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TaiDanhSach()
        {
            try
            {
                grid.DataSource = service.TimKiem(txtTim.Text);
                if (grid.Columns.Contains("MaHoSo"))
                    grid.Columns["MaHoSo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Lỗi truy vấn");
            }
        }
    }
}
