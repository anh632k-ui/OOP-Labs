using System;
using System.Data;
using System.Windows.Forms;
using Lab3_QLKhachSan.Data;
using Lab3_QLKhachSan.Services;

namespace Lab3_QLKhachSan
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService s = new DichVuService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmDichVu()
        {
            InitializeComponent();

            this.Load += Frm_Load;
            this.cboLuot.SelectedIndexChanged += cboLuot_SelectedIndexChanged;
            this.btnGhi.Click += btnGhi_Click;
            this.btnDong.Click += btnDong_Click;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            cboLuot.DataSource = s.LayPhieuDangO();
            cboLuot.DisplayMember = "SoPhieuDat";
            cboLuot.ValueMember = "SoPhieuDat";

            cboDV.DataSource = s.LayDichVu();
            cboDV.DisplayMember = "TenDV";
            cboDV.ValueMember = "MaDV";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            Tai();
        }

        void Tai()
        {
            if (cboLuot.SelectedValue != null)
                dgvLichSu.DataSource = s.LayLichSu(cboLuot.SelectedValue.ToString());
        }

        string V(ComboBox c) => c.SelectedValue == null ? "" : c.SelectedValue.ToString();

        private void cboLuot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuot.SelectedItem is DataRowView r)
                txtPhong.Text = Convert.ToString(r["SoPhong"]);
            Tai();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var k = s.GhiNhan(V(cboLuot), txtPhong.Text.Trim(), dtNgay.Value, V(cboNV), V(cboDV), (int)numSL.Value);
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}