namespace LAB2
{
    public partial class FrmQLThuVien : Form
    {
        public FrmQLThuVien()
        {
            InitializeComponent();
        }

        private void button_Danhmuc_NhanVien_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.ShowDialog();
        }

        private void button_Thoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_DocGiavaThe_Click(object sender, EventArgs e)
        {
            FrmDocGia frm = new FrmDocGia();
            frm.ShowDialog();
        }

        private void button_MuonTraSach_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FrmMuonTra frm = new FrmMuonTra();
            //    frm.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi mở form Mượn Trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            FrmMuonTra frm = new FrmMuonTra();
            frm.ShowDialog();
        }

        private void FrmQLThuVien_Load(object sender, EventArgs e)
        {

        }

        private void button_QLDauSach_Click(object sender, EventArgs e)
        {
            FrmSach frm = new FrmSach();
            frm.ShowDialog();
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.ShowDialog();
        }
    }
}
