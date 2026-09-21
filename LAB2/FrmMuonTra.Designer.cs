namespace LAB2
{
    partial class FrmMuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLapPhieu = new Button();
            btnBoSach = new Button();
            btnThemSach = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtHenTra = new DateTimePicker();
            lblTrangThai = new Label();
            btnKiemTra = new Button();
            label3 = new Label();
            txtMaNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvSachChon = new DataGridView();
            dgvSachCon = new DataGridView();
            dtNgayMuon = new DateTimePicker();
            cboDocGia = new ComboBox();
            tabPage2 = new TabPage();
            label8 = new Label();
            label4 = new Label();
            btnTraSach = new Button();
            numPhiPhat = new NumericUpDown();
            cboTinhTrang = new ComboBox();
            dgvDangMuon = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachChon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSachCon).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPhiPhat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDangMuon).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(48, 17);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 509);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLapPhieu);
            tabPage1.Controls.Add(btnBoSach);
            tabPage1.Controls.Add(btnThemSach);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dtHenTra);
            tabPage1.Controls.Add(lblTrangThai);
            tabPage1.Controls.Add(btnKiemTra);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtMaNV);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvSachChon);
            tabPage1.Controls.Add(dgvSachCon);
            tabPage1.Controls.Add(dtNgayMuon);
            tabPage1.Controls.Add(cboDocGia);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mượn sách";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieu
            // 
            btnLapPhieu.Location = new Point(448, 426);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(130, 36);
            btnLapPhieu.TabIndex = 25;
            btnLapPhieu.Text = "Lập phiếu mượn";
            btnLapPhieu.UseVisualStyleBackColor = true;
            btnLapPhieu.Click += btnLapPhieu_Click_1;
            // 
            // btnBoSach
            // 
            btnBoSach.Location = new Point(460, 301);
            btnBoSach.Name = "btnBoSach";
            btnBoSach.Size = new Size(97, 36);
            btnBoSach.TabIndex = 24;
            btnBoSach.Text = "<<Bỏ";
            btnBoSach.UseVisualStyleBackColor = true;
            btnBoSach.Click += btnBoSach_Click_1;
            // 
            // btnThemSach
            // 
            btnThemSach.Location = new Point(460, 223);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(97, 36);
            btnThemSach.TabIndex = 23;
            btnThemSach.Text = "Thêm >>";
            btnThemSach.UseVisualStyleBackColor = true;
            btnThemSach.Click += btnThemSach_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 131);
            label7.Name = "label7";
            label7.Size = new Size(162, 20);
            label7.TabIndex = 22;
            label7.Text = "Sách đã chọn (tối đa 3)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 131);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 21;
            label6.Text = "Sách còn trong kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 64);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 20;
            label5.Text = "Hẹn trả:";
            // 
            // dtHenTra
            // 
            dtHenTra.Location = new Point(716, 59);
            dtHenTra.Name = "dtHenTra";
            dtHenTra.Size = new Size(150, 27);
            dtHenTra.TabIndex = 19;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(512, 22);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(139, 20);
            lblTrangThai.TabIndex = 18;
            lblTrangThai.Text = "Trạng thái điều kiện";
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(337, 11);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(141, 36);
            btnKiemTra.TabIndex = 17;
            btnKiemTra.Text = "Kiểm tra điều kiện";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 66);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 16;
            label3.Text = "Ngày mượn:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(178, 63);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(129, 27);
            txtMaNV.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 14;
            label2.Text = "NV lập phiếu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 11;
            label1.Text = "Độc giả:";
            // 
            // dgvSachChon
            // 
            dgvSachChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachChon.Location = new Point(582, 175);
            dgvSachChon.Name = "dgvSachChon";
            dgvSachChon.RowHeadersWidth = 51;
            dgvSachChon.Size = new Size(304, 255);
            dgvSachChon.TabIndex = 4;
            // 
            // dgvSachCon
            // 
            dgvSachCon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachCon.Location = new Point(32, 175);
            dgvSachCon.Name = "dgvSachCon";
            dgvSachCon.RowHeadersWidth = 51;
            dgvSachCon.Size = new Size(410, 255);
            dgvSachCon.TabIndex = 3;
            // 
            // dtNgayMuon
            // 
            dtNgayMuon.Location = new Point(433, 61);
            dtNgayMuon.Name = "dtNgayMuon";
            dtNgayMuon.Size = new Size(150, 27);
            dtNgayMuon.TabIndex = 1;
            // 
            // cboDocGia
            // 
            cboDocGia.FormattingEnabled = true;
            cboDocGia.Location = new Point(147, 19);
            cboDocGia.Name = "cboDocGia";
            cboDocGia.Size = new Size(160, 28);
            cboDocGia.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnTraSach);
            tabPage2.Controls.Add(numPhiPhat);
            tabPage2.Controls.Add(cboTinhTrang);
            tabPage2.Controls.Add(dgvDangMuon);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Trả sách";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(520, 23);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 5;
            label8.Text = "Số tiền phạt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 16);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 4;
            label4.Text = "Tình trạng sách:";
            // 
            // btnTraSach
            // 
            btnTraSach.Location = new Point(638, 145);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(198, 39);
            btnTraSach.TabIndex = 3;
            btnTraSach.Text = "Trả sách";
            btnTraSach.UseVisualStyleBackColor = true;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // numPhiPhat
            // 
            numPhiPhat.Location = new Point(638, 16);
            numPhiPhat.Name = "numPhiPhat";
            numPhiPhat.Size = new Size(187, 27);
            numPhiPhat.TabIndex = 2;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Location = new Point(232, 13);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(193, 28);
            cboTinhTrang.TabIndex = 1;
            // 
            // dgvDangMuon
            // 
            dgvDangMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDangMuon.Location = new Point(36, 201);
            dgvDangMuon.Name = "dgvDangMuon";
            dgvDangMuon.RowHeadersWidth = 51;
            dgvDangMuon.Size = new Size(844, 252);
            dgvDangMuon.TabIndex = 0;
            // 
            // FrmMuonTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 550);
            Controls.Add(tabControl1);
            Name = "FrmMuonTra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMuonTra";
            Load += FrmMuonTra_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachChon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSachCon).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPhiPhat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDangMuon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvSachChon;
        private DataGridView dgvSachCon;
        private DateTimePicker dtNgayMuon;
        private ComboBox cboDocGia;
        private Label label1;
        private Label lblTrangThai;
        private Button btnKiemTra;
        private Label label3;
        private TextBox txtMaNV;
        private Label label2;
        private Button btnLapPhieu;
        private Button btnBoSach;
        private Button btnThemSach;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtHenTra;
        private Label label8;
        private Label label4;
        private Button btnTraSach;
        private NumericUpDown numPhiPhat;
        private ComboBox cboTinhTrang;
        private DataGridView dgvDangMuon;
    }
}