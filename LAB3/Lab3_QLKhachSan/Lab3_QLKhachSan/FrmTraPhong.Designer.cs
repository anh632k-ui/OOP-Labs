namespace Lab3_QLKhachSan
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblDat = new System.Windows.Forms.Label();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblNV2 = new System.Windows.Forms.Label();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.lblHT = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblTienTT = new System.Windows.Forms.Label();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.lblMaTT = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDat.Location = new System.Drawing.Point(12, 12);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(84, 15);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Phiếu đang ở:";
            // 
            // cboDat
            // 
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboDat.FormattingEnabled = true;
            this.cboDat.Location = new System.Drawing.Point(100, 9);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(160, 23);
            this.cboDat.TabIndex = 1;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(12, 38);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(248, 120);
            this.dgvPhong.TabIndex = 2;
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(268, 38);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.Size = new System.Drawing.Size(280, 120);
            this.dgvTN.TabIndex = 3;
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Location = new System.Drawing.Point(556, 38);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.ReadOnly = true;
            this.dgvDBChon.Size = new System.Drawing.Size(286, 120);
            this.dgvDBChon.TabIndex = 4;
            // 
            // lblSoDB
            // 
            this.lblSoDB.AutoSize = true;
            this.lblSoDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDB.Location = new System.Drawing.Point(12, 169);
            this.lblSoDB.Name = "lblSoDB";
            this.lblSoDB.Size = new System.Drawing.Size(43, 15);
            this.lblSoDB.TabIndex = 5;
            this.lblSoDB.Text = "Số ĐB:";
            // 
            // txtSoDB
            // 
            this.txtSoDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDB.Location = new System.Drawing.Point(58, 166);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(85, 23);
            this.txtSoDB.TabIndex = 6;
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMucDo.Location = new System.Drawing.Point(148, 169);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(51, 15);
            this.lblMucDo.TabIndex = 7;
            this.lblMucDo.Text = "Mức độ:";
            // 
            // txtMucDo
            // 
            this.txtMucDo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMucDo.Location = new System.Drawing.Point(202, 166);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(100, 23);
            this.txtMucDo.TabIndex = 8;
            this.txtMucDo.Text = "Hư hỏng nhẹ";
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDenBu.Location = new System.Drawing.Point(308, 169);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(46, 15);
            this.lblDenBu.TabIndex = 9;
            this.lblDenBu.Text = "Số tiền:";
            // 
            // numDenBu
            // 
            this.numDenBu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDenBu.Location = new System.Drawing.Point(358, 166);
            this.numDenBu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(105, 23);
            this.numDenBu.TabIndex = 10;
            // 
            // btnThemDB
            // 
            this.btnThemDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemDB.Location = new System.Drawing.Point(470, 164);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(125, 27);
            this.btnThemDB.TabIndex = 11;
            this.btnThemDB.Text = "Chọn vào phiếu ĐB";
            this.btnThemDB.UseVisualStyleBackColor = true;
            // 
            // btnLapDB
            // 
            this.btnLapDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLapDB.Location = new System.Drawing.Point(702, 164);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(140, 27);
            this.btnLapDB.TabIndex = 12;
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.UseVisualStyleBackColor = true;
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoHD.Location = new System.Drawing.Point(12, 206);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(44, 15);
            this.lblSoHD.TabIndex = 13;
            this.lblSoHD.Text = "Số HĐ:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoHD.Location = new System.Drawing.Point(58, 203);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(85, 23);
            this.txtSoHD.TabIndex = 14;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoNgay.Location = new System.Drawing.Point(148, 206);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(89, 15);
            this.lblSoNgay.TabIndex = 15;
            this.lblSoNgay.Text = "Số ngày tính tiền:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoNgay.Location = new System.Drawing.Point(240, 203);
            this.numSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(55, 23);
            this.numSoNgay.TabIndex = 16;
            this.numSoNgay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNV2
            // 
            this.lblNV2.AutoSize = true;
            this.lblNV2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNV2.Location = new System.Drawing.Point(308, 206);
            this.lblNV2.Name = "lblNV2";
            this.lblNV2.Size = new System.Drawing.Size(46, 15);
            this.lblNV2.TabIndex = 17;
            this.lblNV2.Text = "NV lập:";
            // 
            // cboNV2
            // 
            this.cboNV2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNV2.FormattingEnabled = true;
            this.cboNV2.Location = new System.Drawing.Point(358, 203);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(120, 23);
            this.cboNV2.TabIndex = 18;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLapHD.Location = new System.Drawing.Point(490, 201);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(105, 27);
            this.btnLapHD.TabIndex = 19;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(12, 235);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.Size = new System.Drawing.Size(830, 160);
            this.dgvHD.TabIndex = 20;
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHT.Location = new System.Drawing.Point(12, 412);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(63, 15);
            this.lblHT.TabIndex = 21;
            this.lblHT.Text = "Hình thức:";
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Location = new System.Drawing.Point(78, 408);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(110, 23);
            this.cboHT.TabIndex = 22;
            // 
            // lblTienTT
            // 
            this.lblTienTT.AutoSize = true;
            this.lblTienTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienTT.Location = new System.Drawing.Point(195, 412);
            this.lblTienTT.Name = "lblTienTT";
            this.lblTienTT.Size = new System.Drawing.Size(46, 15);
            this.lblTienTT.TabIndex = 23;
            this.lblTienTT.Text = "Số tiền:";
            // 
            // numTienTT
            // 
            this.numTienTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numTienTT.Location = new System.Drawing.Point(245, 408);
            this.numTienTT.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(110, 23);
            this.numTienTT.TabIndex = 24;
            // 
            // lblMaTT
            // 
            this.lblMaTT.AutoSize = true;
            this.lblMaTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaTT.Location = new System.Drawing.Point(365, 412);
            this.lblMaTT.Name = "lblMaTT";
            this.lblMaTT.Size = new System.Drawing.Size(45, 15);
            this.lblMaTT.TabIndex = 25;
            this.lblMaTT.Text = "Mã GD:";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTT.Location = new System.Drawing.Point(412, 408);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(85, 23);
            this.txtMaTT.TabIndex = 26;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Location = new System.Drawing.Point(505, 405);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(95, 29);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraPhong.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTraPhong.Location = new System.Drawing.Point(608, 405);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(130, 29);
            this.btnTraPhong.TabIndex = 28;
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.Location = new System.Drawing.Point(745, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 29);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(0, 0);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(1, 20);
            this.txtPhong.TabIndex = 30;
            this.txtPhong.Visible = false;
            // 
            // txtHDChon
            // 
            this.txtHDChon.Location = new System.Drawing.Point(0, 0);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.Size = new System.Drawing.Size(1, 20);
            this.txtHDChon.TabIndex = 31;
            this.txtHDChon.Visible = false;
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 448);
            this.Controls.Add(this.txtHDChon);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.lblMaTT);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.lblTienTT);
            this.Controls.Add(this.cboHT);
            this.Controls.Add(this.lblHT);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.cboNV2);
            this.Controls.Add(this.lblNV2);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.btnLapDB);
            this.Controls.Add(this.btnThemDB);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.lblMucDo);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.lblSoDB);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.lblDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.Label lblSoDB;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnThemDB;
        private System.Windows.Forms.Button btnLapDB;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label lblNV2;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblTienTT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Label lblMaTT;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtHDChon;
    }
}