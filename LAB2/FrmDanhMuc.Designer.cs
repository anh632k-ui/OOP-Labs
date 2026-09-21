namespace LAB2
{
    partial class FrmDanhMuc
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
            dtNVNgaySinh = new DateTimePicker();
            cboNVPhai = new ComboBox();
            dgvNV = new DataGridView();
            btnNVLamMoi = new Button();
            btnNVXoa = new Button();
            btnNVSua = new Button();
            btnNVThem = new Button();
            txtChucVu = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTen = new TextBox();
            txtHo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNVMa = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(64, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 420);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtNVNgaySinh);
            tabPage1.Controls.Add(cboNVPhai);
            tabPage1.Controls.Add(dgvNV);
            tabPage1.Controls.Add(btnNVLamMoi);
            tabPage1.Controls.Add(btnNVXoa);
            tabPage1.Controls.Add(btnNVSua);
            tabPage1.Controls.Add(btnNVThem);
            tabPage1.Controls.Add(txtChucVu);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtTen);
            tabPage1.Controls.Add(txtHo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNVMa);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(780, 387);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtNVNgaySinh
            // 
            dtNVNgaySinh.Location = new Point(426, 73);
            dtNVNgaySinh.Name = "dtNVNgaySinh";
            dtNVNgaySinh.Size = new Size(141, 27);
            dtNVNgaySinh.TabIndex = 18;
            // 
            // cboNVPhai
            // 
            cboNVPhai.FormattingEnabled = true;
            cboNVPhai.Location = new Point(427, 38);
            cboNVPhai.Name = "cboNVPhai";
            cboNVPhai.Size = new Size(139, 28);
            cboNVPhai.TabIndex = 17;
            // 
            // dgvNV
            // 
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Location = new Point(38, 163);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 51;
            dgvNV.Size = new Size(699, 204);
            dgvNV.TabIndex = 16;
            // 
            // btnNVLamMoi
            // 
            btnNVLamMoi.Location = new Point(659, 74);
            btnNVLamMoi.Name = "btnNVLamMoi";
            btnNVLamMoi.Size = new Size(105, 28);
            btnNVLamMoi.TabIndex = 15;
            btnNVLamMoi.Text = "Làm mới";
            btnNVLamMoi.UseVisualStyleBackColor = true;
            btnNVLamMoi.Click += btnNVLamMoi_Click;
            // 
            // btnNVXoa
            // 
            btnNVXoa.Location = new Point(587, 74);
            btnNVXoa.Name = "btnNVXoa";
            btnNVXoa.Size = new Size(66, 28);
            btnNVXoa.TabIndex = 14;
            btnNVXoa.Text = "Xóa";
            btnNVXoa.UseVisualStyleBackColor = true;
            btnNVXoa.Click += btnNVXoa_Click;
            // 
            // btnNVSua
            // 
            btnNVSua.Location = new Point(659, 33);
            btnNVSua.Name = "btnNVSua";
            btnNVSua.Size = new Size(105, 28);
            btnNVSua.TabIndex = 13;
            btnNVSua.Text = "Cập nhật";
            btnNVSua.UseVisualStyleBackColor = true;
            btnNVSua.Click += btnNVSua_Click;
            // 
            // btnNVThem
            // 
            btnNVThem.Location = new Point(587, 33);
            btnNVThem.Name = "btnNVThem";
            btnNVThem.Size = new Size(66, 28);
            btnNVThem.TabIndex = 12;
            btnNVThem.Text = "Thêm";
            btnNVThem.UseVisualStyleBackColor = true;
            btnNVThem.Click += btnNVThem_Click;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(426, 109);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(139, 27);
            txtChucVu.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 109);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 9;
            label4.Text = "Chức vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 74);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 37);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 6;
            label6.Text = "Phái:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(137, 106);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(139, 27);
            txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(137, 71);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(139, 27);
            txtHo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 106);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 71);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ:";
            // 
            // txtNVMa
            // 
            txtNVMa.Location = new Point(137, 31);
            txtNVMa.Name = "txtNVMa";
            txtNVMa.Size = new Size(139, 27);
            txtNVMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(780, 387);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thể loại";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(780, 387);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Nhà xuất bản";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 521);
            Controls.Add(tabControl1);
            Name = "FrmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục và nhân viên";
            Load += FrmDanhMuc_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private Button btnNVLamMoi;
        private Button btnNVXoa;
        private Button btnNVSua;
        private Button btnNVThem;
        private TextBox txtChucVu;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTen;
        private TextBox txtHo;
        private Label label3;
        private Label label2;
        private TextBox txtNVMa;
        private Label label1;
        private DataGridView dgvNV;
        private DateTimePicker dtNVNgaySinh;
        private ComboBox cboNVPhai;
    }
}