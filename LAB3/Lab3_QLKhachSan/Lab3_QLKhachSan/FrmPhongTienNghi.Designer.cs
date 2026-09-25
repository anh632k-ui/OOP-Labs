namespace Lab3_QLKhachSan
{
    partial class FrmPhongTienNghi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblKhu = new System.Windows.Forms.Label();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.tabTienNghi = new System.Windows.Forms.TabPage();
            this.lblMaTN = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.tabLapDat = new System.Windows.Forms.TabPage();
            this.lblSoLD = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.lblTN = new System.Windows.Forms.Label();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.lblPhongLD = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTTLD = new System.Windows.Forms.Label();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.tabLapDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhong);
            this.tabControl1.Controls.Add(this.tabTienNghi);
            this.tabControl1.Controls.Add(this.tabLapDat);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.numGia);
            this.tabPhong.Controls.Add(this.lblGia);
            this.tabPhong.Controls.Add(this.numMax);
            this.tabPhong.Controls.Add(this.lblMax);
            this.tabPhong.Controls.Add(this.cboKhu);
            this.tabPhong.Controls.Add(this.lblKhu);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.lblPhong);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 24);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(802, 402);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(8, 18);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(61, 15);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Số phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(72, 15);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(85, 23);
            this.txtPhong.TabIndex = 1;
            // 
            // lblKhu
            // 
            this.lblKhu.AutoSize = true;
            this.lblKhu.Location = new System.Drawing.Point(165, 18);
            this.lblKhu.Name = "lblKhu";
            this.lblKhu.Size = new System.Drawing.Size(53, 15);
            this.lblKhu.TabIndex = 2;
            this.lblKhu.Text = "Khu vực:";
            // 
            // cboKhu
            // 
            this.cboKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(220, 15);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(110, 23);
            this.cboKhu.TabIndex = 3;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(340, 18);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(58, 15);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Sức chứa:";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(400, 15);
            this.numMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(55, 23);
            this.numMax.TabIndex = 5;
            this.numMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(465, 18);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(81, 15);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Đơn giá/ngày:";
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(548, 15);
            this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(125, 23);
            this.numGia.TabIndex = 7;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(690, 13);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(85, 27);
            this.btnThemPhong.TabIndex = 8;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(10, 55);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(780, 335);
            this.dgvPhong.TabIndex = 9;
            // 
            // tabTienNghi
            // 
            this.tabTienNghi.Controls.Add(this.btnThemTN);
            this.tabTienNghi.Controls.Add(this.txtTinhTrang);
            this.tabTienNghi.Controls.Add(this.lblTinhTrang);
            this.tabTienNghi.Controls.Add(this.numSTT);
            this.tabTienNghi.Controls.Add(this.lblSTT);
            this.tabTienNghi.Controls.Add(this.cboLoai);
            this.tabTienNghi.Controls.Add(this.lblLoai);
            this.tabTienNghi.Controls.Add(this.txtMaTN);
            this.tabTienNghi.Controls.Add(this.lblMaTN);
            this.tabTienNghi.Controls.Add(this.dgvTN);
            this.tabTienNghi.Location = new System.Drawing.Point(4, 24);
            this.tabTienNghi.Name = "tabTienNghi";
            this.tabTienNghi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTienNghi.Size = new System.Drawing.Size(802, 402);
            this.tabTienNghi.TabIndex = 1;
            this.tabTienNghi.Text = "Tiện nghi";
            this.tabTienNghi.UseVisualStyleBackColor = true;
            // 
            // lblMaTN
            // 
            this.lblMaTN.AutoSize = true;
            this.lblMaTN.Location = new System.Drawing.Point(8, 18);
            this.lblMaTN.Name = "lblMaTN";
            this.lblMaTN.Size = new System.Drawing.Size(46, 15);
            this.lblMaTN.TabIndex = 0;
            this.lblMaTN.Text = "Mã TN:";
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(58, 15);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(90, 23);
            this.txtMaTN.TabIndex = 1;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(160, 18);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(52, 15);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "Loại TN:";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(215, 15);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(120, 23);
            this.cboLoai.TabIndex = 3;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(345, 18);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(29, 15);
            this.lblSTT.TabIndex = 4;
            this.lblSTT.Text = "STT:";
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(380, 15);
            this.numSTT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(55, 23);
            this.numSTT.TabIndex = 5;
            this.numSTT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(448, 18);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(64, 15);
            this.lblTinhTrang.TabIndex = 6;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(515, 15);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(140, 23);
            this.txtTinhTrang.TabIndex = 7;
            this.txtTinhTrang.Text = "Tốt";
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(680, 13);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(85, 27);
            this.btnThemTN.TabIndex = 8;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = true;
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(10, 55);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.Size = new System.Drawing.Size(780, 335);
            this.dgvTN.TabIndex = 9;
            // 
            // tabLapDat
            // 
            this.tabLapDat.Controls.Add(this.btnLapDat);
            this.tabLapDat.Controls.Add(this.txtGhiChu);
            this.tabLapDat.Controls.Add(this.lblGhiChu);
            this.tabLapDat.Controls.Add(this.cboNV);
            this.tabLapDat.Controls.Add(this.lblNV);
            this.tabLapDat.Controls.Add(this.txtTTLD);
            this.tabLapDat.Controls.Add(this.lblTTLD);
            this.tabLapDat.Controls.Add(this.dtNgay);
            this.tabLapDat.Controls.Add(this.lblNgay);
            this.tabLapDat.Controls.Add(this.cboPhong);
            this.tabLapDat.Controls.Add(this.lblPhongLD);
            this.tabLapDat.Controls.Add(this.cboTN);
            this.tabLapDat.Controls.Add(this.lblTN);
            this.tabLapDat.Controls.Add(this.txtSoLD);
            this.tabLapDat.Controls.Add(this.lblSoLD);
            this.tabLapDat.Controls.Add(this.dgvLD);
            this.tabLapDat.Location = new System.Drawing.Point(4, 24);
            this.tabLapDat.Name = "tabLapDat";
            this.tabLapDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLapDat.Size = new System.Drawing.Size(802, 402);
            this.tabLapDat.TabIndex = 2;
            this.tabLapDat.Text = "Lắp đặt / luân chuyển";
            this.tabLapDat.UseVisualStyleBackColor = true;
            // 
            // lblSoLD
            // 
            this.lblSoLD.AutoSize = true;
            this.lblSoLD.Location = new System.Drawing.Point(8, 15);
            this.lblSoLD.Name = "lblSoLD";
            this.lblSoLD.Size = new System.Drawing.Size(56, 15);
            this.lblSoLD.TabIndex = 0;
            this.lblSoLD.Text = "Số phiếu:";
            // 
            // txtSoLD
            // 
            this.txtSoLD.Location = new System.Drawing.Point(68, 12);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(85, 23);
            this.txtSoLD.TabIndex = 1;
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(162, 15);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(60, 15);
            this.lblTN.TabIndex = 2;
            this.lblTN.Text = "Tiện nghi:";
            // 
            // cboTN
            // 
            this.cboTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTN.FormattingEnabled = true;
            this.cboTN.Location = new System.Drawing.Point(225, 12);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(100, 23);
            this.cboTN.TabIndex = 3;
            // 
            // lblPhongLD
            // 
            this.lblPhongLD.AutoSize = true;
            this.lblPhongLD.Location = new System.Drawing.Point(335, 15);
            this.lblPhongLD.Name = "lblPhongLD";
            this.lblPhongLD.Size = new System.Drawing.Size(45, 15);
            this.lblPhongLD.TabIndex = 4;
            this.lblPhongLD.Text = "Phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(382, 12);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(90, 23);
            this.cboPhong.TabIndex = 5;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(482, 15);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(38, 15);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(525, 12);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(100, 23);
            this.dtNgay.TabIndex = 7;
            // 
            // lblTTLD
            // 
            this.lblTTLD.AutoSize = true;
            this.lblTTLD.Location = new System.Drawing.Point(8, 48);
            this.lblTTLD.Name = "lblTTLD";
            this.lblTTLD.Size = new System.Drawing.Size(64, 15);
            this.lblTTLD.TabIndex = 8;
            this.lblTTLD.Text = "Tình trạng:";
            // 
            // txtTTLD
            // 
            this.txtTTLD.Location = new System.Drawing.Point(75, 45);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(110, 23);
            this.txtTTLD.TabIndex = 9;
            this.txtTTLD.Text = "Tốt";
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(200, 48);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(63, 15);
            this.lblNV.TabIndex = 10;
            this.lblNV.Text = "Nhân viên:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(265, 45);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(130, 23);
            this.cboNV.TabIndex = 11;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(410, 48);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(465, 45);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 23);
            this.txtGhiChu.TabIndex = 13;
            // 
            // btnLapDat
            // 
            this.btnLapDat.Location = new System.Drawing.Point(680, 43);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(95, 27);
            this.btnLapDat.TabIndex = 14;
            this.btnLapDat.Text = "Lập phiếu";
            this.btnLapDat.UseVisualStyleBackColor = true;
            // 
            // dgvLD
            // 
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Location = new System.Drawing.Point(10, 85);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.ReadOnly = true;
            this.dgvLD.Size = new System.Drawing.Size(780, 305);
            this.dgvLD.TabIndex = 15;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(725, 450);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 490);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.tabControl1.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabTienNghi.ResumeLayout(false);
            this.tabTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.tabLapDat.ResumeLayout(false);
            this.tabLapDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabTienNghi;
        private System.Windows.Forms.TabPage tabLapDat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblKhu;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label lblMaTN;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.Label lblSoLD;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.Label lblPhongLD;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblTTLD;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.Button btnDong;
    }
}