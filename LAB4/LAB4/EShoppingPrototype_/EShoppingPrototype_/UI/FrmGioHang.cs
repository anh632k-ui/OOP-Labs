using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EShoppingPrototype.Services;

namespace EShoppingPrototype.UI
{
    public class FrmGioHang : Form
    {
        private int maKH;

        private GioHangService service =
            new GioHangService();

        private DataGridView dgv;
        private Label lblTong;

        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThanhToan;

        public FrmGioHang(int maKH)
        {
            this.maKH = maKH;

            TaoGiaoDien();

            Load += FrmGioHang_Load;
        }

        private void TaoGiaoDien()
        {
            Text = "e-SHOPPING - Giỏ hàng";

            StartPosition =
                FormStartPosition.CenterScreen;

            ClientSize =
                new Size(950, 560);

            Font =
                new Font("Segoe UI", 10);


            Label title = new Label();

            title.Text = "GIỎ HÀNG";

            title.Font =
                new Font(
                    "Segoe UI",
                    20,
                    FontStyle.Bold
                );

            title.Location =
                new Point(25, 20);

            title.AutoSize = true;

            Controls.Add(title);


            dgv = new DataGridView();

            dgv.Location =
                new Point(25, 75);

            dgv.Size =
                new Size(900, 340);

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;

            Controls.Add(dgv);


            lblTong = new Label();

            lblTong.Location =
                new Point(25, 435);

            lblTong.AutoSize = true;

            lblTong.Font =
                new Font(
                    "Segoe UI",
                    14,
                    FontStyle.Bold
                );

            Controls.Add(lblTong);


            // ===========================
            // 4 NÚT
            // ===========================

            btnThem =
                TaoButton(
                    "Thêm sản phẩm",
                    25,
                    490,
                    170
                );

            btnCapNhat =
                TaoButton(
                    "Cập nhật số lượng",
                    210,
                    490,
                    185
                );

            btnXoa =
                TaoButton(
                    "Xóa sản phẩm",
                    410,
                    490,
                    165
                );

            btnThanhToan =
                TaoButton(
                    "Thanh toán",
                    755,
                    490,
                    170
                );


            btnThem.Click +=
                BtnThem_Click;

            btnCapNhat.Click +=
                BtnCapNhat_Click;

            btnXoa.Click +=
                BtnXoa_Click;

            btnThanhToan.Click +=
                BtnThanhToan_Click;
        }

        private Button TaoButton(
            string text,
            int x,
            int y,
            int width)
        {
            Button btn =
                new Button();

            btn.Text = text;

            btn.Location =
                new Point(x, y);

            btn.Size =
                new Size(width, 42);

            Controls.Add(btn);

            return btn;
        }

        private void FrmGioHang_Load(
            object sender,
            EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            try
            {
                DataTable table =
                    service.LayGioHang(maKH);

                dgv.DataSource = table;

                if (dgv.Columns["MaSP"] != null)
                {
                    dgv.Columns["MaSP"]
                        .Visible = false;
                }

                if (dgv.Columns["TenSP"] != null)
                {
                    dgv.Columns["TenSP"]
                        .HeaderText =
                        "Sản phẩm";
                }

                if (dgv.Columns["GiaHienHanh"] != null)
                {
                    dgv.Columns["GiaHienHanh"]
                        .HeaderText =
                        "Đơn giá";

                    dgv.Columns["GiaHienHanh"]
                        .DefaultCellStyle
                        .Format = "N0";
                }

                if (dgv.Columns["SoLuong"] != null)
                {
                    dgv.Columns["SoLuong"]
                        .HeaderText =
                        "Số lượng";
                }

                if (dgv.Columns["ThanhTien"] != null)
                {
                    dgv.Columns["ThanhTien"]
                        .HeaderText =
                        "Thành tiền";

                    dgv.Columns["ThanhTien"]
                        .DefaultCellStyle
                        .Format = "N0";
                }

                decimal tong =
                    service.TinhTongTien(maKH);

                lblTong.Text =
                    "Tổng tiền: " +
                    tong.ToString("N0") +
                    " đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi"
                );
            }
        }

        // ==========================================
        // THÊM SẢN PHẨM
        // ==========================================

        private void BtnThem_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Form frmThem =
                    new Form();

                frmThem.Text =
                    "Thêm sản phẩm vào giỏ";

                frmThem.StartPosition =
                    FormStartPosition.CenterParent;

                frmThem.ClientSize =
                    new Size(500, 250);

                frmThem.Font =
                    new Font(
                        "Segoe UI",
                        10
                    );


                Label lblSP =
                    new Label();

                lblSP.Text =
                    "Sản phẩm:";

                lblSP.Location =
                    new Point(25, 40);

                lblSP.Size =
                    new Size(100, 30);

                frmThem.Controls.Add(
                    lblSP
                );


                ComboBox cboSP =
                    new ComboBox();

                cboSP.Location =
                    new Point(135, 35);

                cboSP.Size =
                    new Size(330, 30);

                cboSP.DropDownStyle =
                    ComboBoxStyle.DropDownList;


                DataTable danhSach =
                    service
                    .LayDanhSachSanPham();

                cboSP.DataSource =
                    danhSach;

                cboSP.DisplayMember =
                    "TenSP";

                cboSP.ValueMember =
                    "MaSP";

                frmThem.Controls.Add(
                    cboSP
                );


                Label lblSL =
                    new Label();

                lblSL.Text =
                    "Số lượng:";

                lblSL.Location =
                    new Point(25, 95);

                lblSL.Size =
                    new Size(100, 30);

                frmThem.Controls.Add(
                    lblSL
                );


                NumericUpDown numSL =
                    new NumericUpDown();

                numSL.Location =
                    new Point(135, 90);

                numSL.Size =
                    new Size(120, 30);

                numSL.Minimum = 1;
                numSL.Maximum = 100;
                numSL.Value = 1;

                frmThem.Controls.Add(
                    numSL
                );


                Button btnDongY =
                    new Button();

                btnDongY.Text =
                    "Thêm vào giỏ";

                btnDongY.Location =
                    new Point(300, 165);

                btnDongY.Size =
                    new Size(165, 45);

                frmThem.Controls.Add(
                    btnDongY
                );


                btnDongY.Click +=
                    delegate
                    {
                        try
                        {
                            if (
                                cboSP.SelectedValue
                                == null
                            )
                            {
                                MessageBox.Show(
                                    "Không có sản phẩm."
                                );

                                return;
                            }

                            int maSP =
                                Convert.ToInt32(
                                    cboSP
                                    .SelectedValue
                                );

                            int soLuong =
                                Convert.ToInt32(
                                    numSL.Value
                                );

                            service.ThemSanPham(
                                maKH,
                                maSP,
                                soLuong
                            );

                            frmThem.DialogResult =
                                DialogResult.OK;

                            frmThem.Close();
                        }
                        catch (
                            Exception ex
                        )
                        {
                            MessageBox.Show(
                                ex.Message
                            );
                        }
                    };


                if (
                    frmThem.ShowDialog(this)
                    ==
                    DialogResult.OK
                )
                {
                    LoadDuLieu();

                    MessageBox.Show(
                        "Đã thêm sản phẩm vào giỏ."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        // ==========================================
        // CẬP NHẬT
        // ==========================================

        private void BtnCapNhat_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Hãy chọn sản phẩm."
                    );

                    return;
                }

                int maSP =
                    Convert.ToInt32(
                        dgv.CurrentRow
                        .Cells["MaSP"]
                        .Value
                    );

                int soLuong =
                    Convert.ToInt32(
                        dgv.CurrentRow
                        .Cells["SoLuong"]
                        .Value
                    );

                service.CapNhatSoLuong(
                    maKH,
                    maSP,
                    soLuong
                );

                LoadDuLieu();

                MessageBox.Show(
                    "Cập nhật thành công."
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        // ==========================================
        // XÓA
        // ==========================================

        private void BtnXoa_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Hãy chọn sản phẩm."
                    );

                    return;
                }

                int maSP =
                    Convert.ToInt32(
                        dgv.CurrentRow
                        .Cells["MaSP"]
                        .Value
                    );

                string tenSP =
                    Convert.ToString(
                        dgv.CurrentRow
                        .Cells["TenSP"]
                        .Value
                    );

                DialogResult result =
                    MessageBox.Show(
                        "Xóa " +
                        tenSP +
                        " khỏi giỏ?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo
                    );

                if (
                    result !=
                    DialogResult.Yes
                )
                {
                    return;
                }

                service.XoaSanPham(
                    maKH,
                    maSP
                );

                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        // ==========================================
        // THANH TOÁN
        // ==========================================

        private void BtnThanhToan_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (
                    service.TinhTongTien(
                        maKH
                    )
                    <= 0
                )
                {
                    MessageBox.Show(
                        "Giỏ hàng đang trống."
                    );

                    return;
                }

                FrmThanhToan frm =
                    new FrmThanhToan(
                        maKH
                    );

                if (
                    frm.ShowDialog(this)
                    ==
                    DialogResult.OK
                )
                {
                    LoadDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }
    }
}