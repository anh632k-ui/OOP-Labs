using System;
using System.Windows.Forms;
using Lab3_QLKhachSan.Data;
using Lab3_QLKhachSan.Services;

namespace Lab3_QLKhachSan
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();

            // Gán sự kiện cho Form và các nút bấm
            this.Load += FrmDanhMuc_Load;
            this.btnThemKhu.Click += btnThemKhu_Click;
            this.btnThemNV.Click += btnThemNV_Click;
            this.btnThemLoaiTN.Click += btnThemLoaiTN_Click;
            this.btnThemDV.Click += btnThemDV_Click;
            this.btnThemQD.Click += btnThemQD_Click;
            this.btnDong.Click += btnDong_Click;
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            Tai();
        }

        void Tai()
        {
            dgvKhu.DataSource = s.LayKhuVuc();
            dgvNV.DataSource = s.LayNhanVien();
            dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
            dgvDV.DataSource = s.LayDichVu();
            dgvQD.DataSource = s.LayQuyDinhDenBu();

            cboQDLoai.DataSource = s.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            H(s.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim()));
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            H(s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            H(s.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim()));
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            H(s.ThemDichVu(txtDVMa.Text.Trim(), txtDVTen.Text.Trim(), txtDVDVT.Text.Trim(), numDVGia.Value));
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string loai = cboQDLoai.SelectedValue == null ? "" : cboQDLoai.SelectedValue.ToString();
            H(s.ThemQuyDinh(txtQDMa.Text.Trim(), loai, txtQDMucDo.Text.Trim(), numQDTien.Value));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}