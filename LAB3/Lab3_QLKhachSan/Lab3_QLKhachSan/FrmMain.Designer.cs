namespace Lab3_QLKhachSan
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnDanhMuc = new Button();
            btnPhong = new Button();
            btnDatPhong = new Button();
            btnDichVu = new Button();
            btnTraPhong = new Button();
            btnThongKe = new Button();
            btnThoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(16, 44, 87);
            lblTitle.Location = new Point(313, 54);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(495, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.FromArgb(245, 247, 250);
            btnDanhMuc.Cursor = Cursors.Hand;
            btnDanhMuc.FlatStyle = FlatStyle.System;
            btnDanhMuc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDanhMuc.Location = new Point(80, 177);
            btnDanhMuc.Margin = new Padding(4, 5, 4, 5);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(300, 95);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnPhong
            // 
            btnPhong.BackColor = Color.FromArgb(245, 247, 250);
            btnPhong.Cursor = Cursors.Hand;
            btnPhong.FlatStyle = FlatStyle.System;
            btnPhong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhong.Location = new Point(420, 177);
            btnPhong.Margin = new Padding(4, 5, 4, 5);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(300, 95);
            btnPhong.TabIndex = 2;
            btnPhong.Text = "Phòng - Tiện nghi";
            btnPhong.UseVisualStyleBackColor = false;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.FromArgb(245, 247, 250);
            btnDatPhong.Cursor = Cursors.Hand;
            btnDatPhong.FlatStyle = FlatStyle.System;
            btnDatPhong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatPhong.Location = new Point(760, 177);
            btnDatPhong.Margin = new Padding(4, 5, 4, 5);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(300, 95);
            btnDatPhong.TabIndex = 3;
            btnDatPhong.Text = "Đặt / Nhận phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // btnDichVu
            // 
            btnDichVu.BackColor = Color.FromArgb(245, 247, 250);
            btnDichVu.Cursor = Cursors.Hand;
            btnDichVu.FlatStyle = FlatStyle.System;
            btnDichVu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDichVu.Location = new Point(80, 315);
            btnDichVu.Margin = new Padding(4, 5, 4, 5);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(300, 95);
            btnDichVu.TabIndex = 4;
            btnDichVu.Text = "Sử dụng dịch vụ";
            btnDichVu.UseVisualStyleBackColor = false;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // btnTraPhong
            // 
            btnTraPhong.BackColor = Color.FromArgb(245, 247, 250);
            btnTraPhong.Cursor = Cursors.Hand;
            btnTraPhong.FlatStyle = FlatStyle.System;
            btnTraPhong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTraPhong.Location = new Point(420, 315);
            btnTraPhong.Margin = new Padding(4, 5, 4, 5);
            btnTraPhong.Name = "btnTraPhong";
            btnTraPhong.Size = new Size(300, 95);
            btnTraPhong.TabIndex = 5;
            btnTraPhong.Text = "Trả phòng - Thanh toán";
            btnTraPhong.UseVisualStyleBackColor = false;
            btnTraPhong.Click += btnTraPhong_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(245, 247, 250);
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatStyle = FlatStyle.System;
            btnThongKe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(760, 315);
            btnThongKe.Margin = new Padding(4, 5, 4, 5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(300, 95);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(245, 247, 250);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.System;
            btnThoat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(420, 454);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(300, 95);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 109);
            label1.Name = "label1";
            label1.Size = new Size(345, 38);
            label1.TabIndex = 8;
            label1.Text = "Bùi Thế Anh - 1250080004";
            label1.Click += label1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1139, 615);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnThongKe);
            Controls.Add(btnTraPhong);
            Controls.Add(btnDichVu);
            Controls.Add(btnDatPhong);
            Controls.Add(btnPhong);
            Controls.Add(btnDanhMuc);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách sạn";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private Label label1;
    }
}