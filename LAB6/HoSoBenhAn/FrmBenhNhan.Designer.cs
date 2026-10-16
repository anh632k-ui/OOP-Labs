namespace HoSoBenhAnPrototype
{
    partial class FrmBenhNhan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.lblGhiChuAnh = new System.Windows.Forms.Label();
            this.lblPhi = new System.Windows.Forms.Label();
            this.numPhi = new System.Windows.Forms.NumericUpDown();
            this.ckDaDongPhi = new System.Windows.Forms.CheckBox();
            this.lblLuuY = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnMoKham = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(930, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ BỆNH NHÂN VÀ CẤP HỒ SƠ - Bùi Thế Anh - 1250080004";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(22, 72);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(106, 24);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên (*)";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 69);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(323, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(486, 72);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(92, 24);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh (*)";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(589, 69);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(348, 27);
            this.dtNgaySinh.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(22, 112);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(106, 24);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ (*)";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(323, 27);
            this.txtDiaChi.TabIndex = 6;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Location = new System.Drawing.Point(486, 112);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(92, 24);
            this.lblDienThoai.TabIndex = 7;
            this.lblDienThoai.Text = "Điện thoại (*)";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(589, 109);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(348, 27);
            this.txtDienThoai.TabIndex = 8;
            // 
            // lblAnh
            // 
            this.lblAnh.Location = new System.Drawing.Point(22, 152);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(106, 24);
            this.lblAnh.TabIndex = 9;
            this.lblAnh.Text = "Ảnh 3x4 (*)";
            this.lblAnh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(132, 149);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.ReadOnly = true;
            this.txtAnh.Size = new System.Drawing.Size(323, 27);
            this.txtAnh.TabIndex = 10;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(486, 147);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(125, 32);
            this.btnChonAnh.TabIndex = 11;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // lblGhiChuAnh
            // 
            this.lblGhiChuAnh.ForeColor = System.Drawing.Color.DimGray;
            this.lblGhiChuAnh.Location = new System.Drawing.Point(630, 152);
            this.lblGhiChuAnh.Name = "lblGhiChuAnh";
            this.lblGhiChuAnh.Size = new System.Drawing.Size(280, 24);
            this.lblGhiChuAnh.TabIndex = 12;
            this.lblGhiChuAnh.Text = "Chọn ảnh lưu trên máy";
            this.lblGhiChuAnh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhi
            // 
            this.lblPhi.Location = new System.Drawing.Point(22, 196);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(106, 24);
            this.lblPhi.TabIndex = 13;
            this.lblPhi.Text = "Phí năm (*)";
            this.lblPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPhi
            // 
            this.numPhi.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPhi.Location = new System.Drawing.Point(132, 193);
            this.numPhi.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPhi.Name = "numPhi";
            this.numPhi.Size = new System.Drawing.Size(175, 27);
            this.numPhi.TabIndex = 14;
            this.numPhi.ThousandsSeparator = true;
            this.numPhi.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // ckDaDongPhi
            // 
            this.ckDaDongPhi.Location = new System.Drawing.Point(486, 196);
            this.ckDaDongPhi.Name = "ckDaDongPhi";
            this.ckDaDongPhi.Size = new System.Drawing.Size(250, 26);
            this.ckDaDongPhi.TabIndex = 15;
            this.ckDaDongPhi.Text = "Đã thu lệ phí năm";
            // 
            // lblLuuY
            // 
            this.lblLuuY.ForeColor = System.Drawing.Color.DimGray;
            this.lblLuuY.Location = new System.Drawing.Point(22, 229);
            this.lblLuuY.Name = "lblLuuY";
            this.lblLuuY.Size = new System.Drawing.Size(920, 24);
            this.lblLuuY.TabIndex = 16;
            this.lblLuuY.Text = "(*) Thông tin bắt buộc. Mức phí trên Form chỉ để nhập thử.";
            this.lblLuuY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(22, 267);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(220, 36);
            this.btnDangKy.TabIndex = 17;
            this.btnDangKy.Text = "Đăng ký + cấp hồ sơ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(254, 267);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(125, 36);
            this.btnNhapLai.TabIndex = 18;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnMoKham
            // 
            this.btnMoKham.Location = new System.Drawing.Point(391, 267);
            this.btnMoKham.Name = "btnMoKham";
            this.btnMoKham.Size = new System.Drawing.Size(270, 36);
            this.btnMoKham.TabIndex = 19;
            this.btnMoKham.Text = "Mở Form ghi nhận khám";
            this.btnMoKham.UseVisualStyleBackColor = true;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Location = new System.Drawing.Point(22, 338);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(208, 25);
            this.lblTimKiem.TabIndex = 20;
            this.lblTimKiem.Text = "Tìm mã hồ sơ / tên / SĐT:";
            this.lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(235, 337);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(545, 27);
            this.txtTim.TabIndex = 21;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(794, 335);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(143, 33);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tra cứu";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeight = 29;
            this.grid.Location = new System.Drawing.Point(22, 384);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 51;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(916, 196);
            this.grid.TabIndex = 23;
            // 
            // FrmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 607);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.lblGhiChuAnh);
            this.Controls.Add(this.lblPhi);
            this.Controls.Add(this.numPhi);
            this.Controls.Add(this.ckDaDongPhi);
            this.Controls.Add(this.lblLuuY);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnMoKham);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 5 - ĐĂNG KÝ HỒ SƠ BỆNH ÁN";
            ((System.ComponentModel.ISupportInitialize)(this.numPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label lblGhiChuAnh;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.NumericUpDown numPhi;
        private System.Windows.Forms.CheckBox ckDaDongPhi;
        private System.Windows.Forms.Label lblLuuY;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnMoKham;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView grid;
    }
}
