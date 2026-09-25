using System;
using System.Windows.Forms;

namespace Lab3_QLKhachSan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc())
            {
                f.ShowDialog(this);
            }
        }

        public void btnPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhongTienNghi())
            {
                f.ShowDialog(this);
            }
        }

        public void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDatPhong()) f.ShowDialog(this);
        }

        public void btnDichVu_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDichVu()) f.ShowDialog(this);
        }

        public void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong()) f.ShowDialog(this);
        }

        public void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng và giải phóng tiến trình
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}