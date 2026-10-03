using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EShoppingPrototype.Services;

namespace EShoppingPrototype.UI
{
    public class FrmThanhToan : Form
    {
        private int maKH;

        private DatHangService service =
            new DatHangService();

        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtEmail;

        private ComboBox cboLoai;

        private Label lblTamTinh;
        private Label lblPhi;
        private Label lblTong;

        private decimal tamTinh;
        private decimal phi;

        public FrmThanhToan(int maKH)
        {
            this.maKH = maKH;

            TaoGiaoDien();

            Load += FrmThanhToan_Load;
        }

        private void TaoGiaoDien()
        {
            Text =
                "e-SHOPPING - Thanh toán";

            StartPosition =
                FormStartPosition.CenterParent;

            ClientSize =
                new Size(650, 590);

            Font =
                new Font("Segoe UI", 10);


            Label title = new Label();

            title.Text =
                "ĐẶT HÀNG / THANH TOÁN";

            title.Font =
                new Font(
                    "Segoe UI",
                    18,
                    FontStyle.Bold);

            title.Location =
                new Point(25, 20);

            title.AutoSize = true;

            Controls.Add(title);


            int y = 85;

            txtHoTen =
                ThemTextBox(
                    "Họ tên người nhận:",
                    ref y);

            txtDiaChi =
                ThemTextBox(
                    "Địa chỉ:",
                    ref y);

            txtDienThoai =
                ThemTextBox(
                    "Điện thoại:",
                    ref y);

            txtEmail =
                ThemTextBox(
                    "Email:",
                    ref y);


            Label lblLoai =
                new Label();

            lblLoai.Text =
                "Loại giao hàng:";

            lblLoai.Location =
                new Point(25, y + 5);

            lblLoai.Size =
                new Size(160, 30);

            Controls.Add(lblLoai);


            cboLoai =
                new ComboBox();

            cboLoai.Location =
                new Point(190, y);

            cboLoai.Size =
                new Size(420, 30);

            cboLoai.DropDownStyle =
                ComboBoxStyle.DropDownList;

            Controls.Add(cboLoai);

            cboLoai.SelectedIndexChanged +=
                delegate
                {
                    TinhTien();
                };


            y += 60;

            lblTamTinh =
                ThemLabelTien(
                    "Tạm tính:",
                    ref y);

            lblPhi =
                ThemLabelTien(
                    "Phí giao hàng:",
                    ref y);

            lblTong =
                ThemLabelTien(
                    "Tổng thanh toán:",
                    ref y);

            lblTong.Font =
                new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold);


            Button btnDatHang =
                new Button();

            btnDatHang.Text =
                "Xác nhận đặt hàng";

            btnDatHang.Location =
                new Point(400, 515);

            btnDatHang.Size =
                new Size(210, 45);

            btnDatHang.Click +=
                BtnDatHang_Click;

            Controls.Add(btnDatHang);
        }

        private TextBox ThemTextBox(
            string caption,
            ref int y)
        {
            Label lbl =
                new Label();

            lbl.Text = caption;
            lbl.Location =
                new Point(25, y + 5);

            lbl.Size =
                new Size(160, 30);

            Controls.Add(lbl);


            TextBox txt =
                new TextBox();

            txt.Location =
                new Point(190, y);

            txt.Size =
                new Size(420, 30);

            Controls.Add(txt);

            y += 55;

            return txt;
        }

        private Label ThemLabelTien(
            string caption,
            ref int y)
        {
            Label lbl =
                new Label();

            lbl.Text = caption;

            lbl.Location =
                new Point(25, y);

            lbl.Size =
                new Size(180, 30);

            Controls.Add(lbl);


            Label value =
                new Label();

            value.Location =
                new Point(350, y);

            value.Size =
                new Size(260, 30);

            value.TextAlign =
                ContentAlignment.MiddleRight;

            Controls.Add(value);

            y += 40;

            return value;
        }

        private void FrmThanhToan_Load(
            object sender,
            EventArgs e)
        {
            DataRow kh =
                service.LayKhachHang(maKH);

            if (kh != null)
            {
                txtHoTen.Text =
                    kh["HoTen"].ToString();

                txtDiaChi.Text =
                    kh["DiaChi"].ToString();

                txtDienThoai.Text =
                    kh["DienThoai"].ToString();

                txtEmail.Text =
                    kh["Email"].ToString();
            }


            cboLoai.DataSource =
                service.LayLoaiGiaoHang();

            cboLoai.DisplayMember =
                "TenLoai";

            cboLoai.ValueMember =
                "MaLoai";


            tamTinh =
                service.LayTamTinh(maKH);

            TinhTien();
        }

        private void TinhTien()
        {
            if (cboLoai.SelectedItem == null)
                return;

            DataRowView row =
                cboLoai.SelectedItem
                as DataRowView;

            if (row == null)
                return;

            int maLoai =
                Convert.ToInt32(
                    row["MaLoai"]);

            decimal phiCoBan =
                Convert.ToDecimal(
                    row["PhiCoBan"]);

            phi =
                service.TinhPhiGiaoHang(
                    maLoai,
                    phiCoBan,
                    tamTinh);

            lblTamTinh.Text =
                tamTinh.ToString("N0") +
                " đ";

            lblPhi.Text =
                phi.ToString("N0") +
                " đ";

            lblTong.Text =
                (tamTinh + phi)
                .ToString("N0") +
                " đ";
        }

        private void BtnDatHang_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                int maLoai =
                    Convert.ToInt32(
                        cboLoai.SelectedValue);

                int maDH =
                    service.DatHang(
                        maKH,
                        maLoai,
                        txtHoTen.Text,
                        txtDiaChi.Text,
                        txtDienThoai.Text,
                        txtEmail.Text,
                        phi);

                MessageBox.Show(
                    "Đặt hàng thành công!\n" +
                    "Mã đơn: " +
                    maDH);

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}