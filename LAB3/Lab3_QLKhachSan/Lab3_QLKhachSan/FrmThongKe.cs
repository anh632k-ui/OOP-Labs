using System;
using System.Windows.Forms;
using Lab3_QLKhachSan.Services;

namespace Lab3_QLKhachSan
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();

            this.btnTK.Click += btnTK_Click;
            this.btnThoat.Click += btnThoat_Click;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.");
                return;
            }
            dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}