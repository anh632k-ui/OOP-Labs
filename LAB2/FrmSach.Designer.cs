namespace LAB2
{
    partial class FrmSach
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
            txtMaSach = new TextBox();
            label1 = new Label();
            txtTenSach = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvSach = new DataGridView();
            numNamXB = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboTheLoai = new ComboBox();
            cboNXB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNamXB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(162, 38);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(139, 27);
            txtMaSach.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã đầu sách:";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(162, 82);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(139, 27);
            txtTenSach.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 85);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 127);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 6;
            label3.Text = "Năm xuất bản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 169);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "Số lượng hiện có:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 41);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "Thể loại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 85);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 12;
            label6.Text = "Nhà xuất bản:";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(731, 161);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 28);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(731, 119);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 28);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(731, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 28);
            btnSua.TabIndex = 17;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(731, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 28);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(35, 217);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(801, 206);
            dgvSach.TabIndex = 20;
            // 
            // numNamXB
            // 
            numNamXB.Location = new Point(163, 128);
            numNamXB.Name = "numNamXB";
            numNamXB.Size = new Size(138, 27);
            numNamXB.TabIndex = 21;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(163, 163);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(138, 27);
            numSoLuong.TabIndex = 22;
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(505, 37);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(153, 28);
            cboTheLoai.TabIndex = 23;
            // 
            // cboNXB
            // 
            cboNXB.FormattingEnabled = true;
            cboNXB.Location = new Point(505, 84);
            cboNXB.Name = "cboNXB";
            cboNXB.Size = new Size(151, 28);
            cboNXB.TabIndex = 24;
            // 
            // FrmSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 465);
            Controls.Add(cboNXB);
            Controls.Add(cboTheLoai);
            Controls.Add(numSoLuong);
            Controls.Add(numNamXB);
            Controls.Add(dgvSach);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTenSach);
            Controls.Add(label2);
            Controls.Add(txtMaSach);
            Controls.Add(label1);
            Name = "FrmSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đầu sách";
            Load += FrmSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNamXB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSach;
        private Label label1;
        private TextBox txtTenSach;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvSach;
        private NumericUpDown numNamXB;
        private NumericUpDown numSoLuong;
        private ComboBox cboTheLoai;
        private ComboBox cboNXB;
    }
}