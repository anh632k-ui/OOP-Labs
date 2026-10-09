// Giao diện WinForms tạo bằng các control và container chuẩn để Visual Studio Designer hiển thị.
// Có thể chỉnh trực tiếp vị trí, kích thước, Text trong tab Design.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnDanhMuc;
        private Button btnTour;
        private Button btnChuyenLe;
        private Button btnDangKyLe;
        private Button btnDangKyDoan;
        private Button btnPhanCong;
        private Button btnKetThuc;
        private Button btnThongKe;
        private Button btnThoat;
        private Button btnKiemTraCSDL;
        private TableLayoutPanel mainLayout;
        private Label lblTieuDe;
        private TableLayoutPanel menuLayout;
        private FlowLayoutPanel footerLayout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null) this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnChuyenLe = new System.Windows.Forms.Button();
            this.btnDangKyLe = new System.Windows.Forms.Button();
            this.btnDangKyDoan = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKiemTraCSDL = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.footerLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mainLayout.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.footerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDanhMuc.Location = new System.Drawing.Point(61, 21);
            this.btnDanhMuc.Margin = new System.Windows.Forms.Padding(13);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(471, 120);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnTour
            // 
            this.btnTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTour.Location = new System.Drawing.Point(558, 21);
            this.btnTour.Margin = new System.Windows.Forms.Padding(13);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(471, 120);
            this.btnTour.TabIndex = 1;
            this.btnTour.Text = "Tour - hành trình";
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnChuyenLe
            // 
            this.btnChuyenLe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChuyenLe.Location = new System.Drawing.Point(61, 167);
            this.btnChuyenLe.Margin = new System.Windows.Forms.Padding(13);
            this.btnChuyenLe.Name = "btnChuyenLe";
            this.btnChuyenLe.Size = new System.Drawing.Size(471, 120);
            this.btnChuyenLe.TabIndex = 2;
            this.btnChuyenLe.Text = "Lịch chuyến khách lẻ";
            this.btnChuyenLe.Click += new System.EventHandler(this.btnChuyenLe_Click);
            // 
            // btnDangKyLe
            // 
            this.btnDangKyLe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDangKyLe.Location = new System.Drawing.Point(558, 167);
            this.btnDangKyLe.Margin = new System.Windows.Forms.Padding(13);
            this.btnDangKyLe.Name = "btnDangKyLe";
            this.btnDangKyLe.Size = new System.Drawing.Size(471, 120);
            this.btnDangKyLe.TabIndex = 3;
            this.btnDangKyLe.Text = "Đăng ký khách lẻ";
            this.btnDangKyLe.Click += new System.EventHandler(this.btnDangKyLe_Click);
            // 
            // btnDangKyDoan
            // 
            this.btnDangKyDoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDangKyDoan.Location = new System.Drawing.Point(61, 313);
            this.btnDangKyDoan.Margin = new System.Windows.Forms.Padding(13);
            this.btnDangKyDoan.Name = "btnDangKyDoan";
            this.btnDangKyDoan.Size = new System.Drawing.Size(471, 120);
            this.btnDangKyDoan.TabIndex = 4;
            this.btnDangKyDoan.Text = "Đăng ký theo đoàn";
            this.btnDangKyDoan.Click += new System.EventHandler(this.btnDangKyDoan_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhanCong.Location = new System.Drawing.Point(558, 313);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(13);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(471, 120);
            this.btnPhanCong.TabIndex = 5;
            this.btnPhanCong.Text = "Phân công hướng dẫn viên";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKetThuc.Location = new System.Drawing.Point(61, 459);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(13);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(471, 121);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết thúc tour - khảo sát";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongKe.Location = new System.Drawing.Point(558, 459);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(13);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(471, 121);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Lương - thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(962, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 35);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKiemTraCSDL
            // 
            this.btnKiemTraCSDL.Location = new System.Drawing.Point(751, 8);
            this.btnKiemTraCSDL.Name = "btnKiemTraCSDL";
            this.btnKiemTraCSDL.Size = new System.Drawing.Size(205, 35);
            this.btnKiemTraCSDL.TabIndex = 1;
            this.btnKiemTraCSDL.Text = "Bùi Thế Anh - 1250080004";
            this.btnKiemTraCSDL.Click += new System.EventHandler(this.btnKiemTraCSDL_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.lblTieuDe, 0, 0);
            this.mainLayout.Controls.Add(this.menuLayout, 0, 1);
            this.mainLayout.Controls.Add(this.footerLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(12);
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.mainLayout.Size = new System.Drawing.Size(1120, 760);
            this.mainLayout.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.lblTieuDe.Location = new System.Drawing.Point(15, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1090, 74);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuLayout
            // 
            this.menuLayout.ColumnCount = 2;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuLayout.Controls.Add(this.btnDanhMuc, 0, 0);
            this.menuLayout.Controls.Add(this.btnTour, 1, 0);
            this.menuLayout.Controls.Add(this.btnChuyenLe, 0, 1);
            this.menuLayout.Controls.Add(this.btnDangKyLe, 1, 1);
            this.menuLayout.Controls.Add(this.btnDangKyDoan, 0, 2);
            this.menuLayout.Controls.Add(this.btnPhanCong, 1, 2);
            this.menuLayout.Controls.Add(this.btnKetThuc, 0, 3);
            this.menuLayout.Controls.Add(this.btnThongKe, 1, 3);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.Location = new System.Drawing.Point(15, 89);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Padding = new System.Windows.Forms.Padding(48, 8, 48, 8);
            this.menuLayout.RowCount = 4;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayout.Size = new System.Drawing.Size(1090, 601);
            this.menuLayout.TabIndex = 1;
            // 
            // footerLayout
            // 
            this.footerLayout.Controls.Add(this.btnThoat);
            this.footerLayout.Controls.Add(this.btnKiemTraCSDL);
            this.footerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.footerLayout.Location = new System.Drawing.Point(15, 696);
            this.footerLayout.Name = "footerLayout";
            this.footerLayout.Padding = new System.Windows.Forms.Padding(5);
            this.footerLayout.Size = new System.Drawing.Size(1090, 49);
            this.footerLayout.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 760);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT";
            this.mainLayout.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.footerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
