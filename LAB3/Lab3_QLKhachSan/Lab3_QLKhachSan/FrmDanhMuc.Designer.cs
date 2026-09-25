namespace Lab3_QLKhachSan
{
    partial class FrmDanhMuc
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
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.lblLoaiMa = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.lblLoaiTen = new System.Windows.Forms.Label();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.lblDVMa = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.lblDVGia = new System.Windows.Forms.Label();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.tabQuyDinh = new System.Windows.Forms.TabPage();
            this.lblQDMa = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.lblQDMucDo = new System.Windows.Forms.Label();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.lblQDTien = new System.Windows.Forms.Label();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabLoaiTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.tabQuyDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKhuVuc);
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabLoaiTN);
            this.tabControl1.Controls.Add(this.tabDichVu);
            this.tabControl1.Controls.Add(this.tabQuyDinh);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKhuVuc
            // 
            this.tabKhuVuc.Controls.Add(this.btnThemKhu);
            this.tabKhuVuc.Controls.Add(this.txtKhuTen);
            this.tabKhuVuc.Controls.Add(this.lblKhuTen);
            this.tabKhuVuc.Controls.Add(this.txtKhuMa);
            this.tabKhuVuc.Controls.Add(this.lblKhuMa);
            this.tabKhuVuc.Controls.Add(this.dgvKhu);
            this.tabKhuVuc.Location = new System.Drawing.Point(4, 24);
            this.tabKhuVuc.Name = "tabKhuVuc";
            this.tabKhuVuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhuVuc.Size = new System.Drawing.Size(772, 382);
            this.tabKhuVuc.TabIndex = 0;
            this.tabKhuVuc.Text = "Khu vực";
            this.tabKhuVuc.UseVisualStyleBackColor = true;
            // 
            // lblKhuMa
            // 
            this.lblKhuMa.AutoSize = true;
            this.lblKhuMa.Location = new System.Drawing.Point(15, 18);
            this.lblKhuMa.Name = "lblKhuMa";
            this.lblKhuMa.Size = new System.Drawing.Size(50, 15);
            this.lblKhuMa.TabIndex = 0;
            this.lblKhuMa.Text = "Mã khu:";
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(75, 15);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(140, 23);
            this.txtKhuMa.TabIndex = 1;
            // 
            // lblKhuTen
            // 
            this.lblKhuTen.AutoSize = true;
            this.lblKhuTen.Location = new System.Drawing.Point(235, 18);
            this.lblKhuTen.Name = "lblKhuTen";
            this.lblKhuTen.Size = new System.Drawing.Size(52, 15);
            this.lblKhuTen.TabIndex = 2;
            this.lblKhuTen.Text = "Tên khu:";
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(295, 15);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(200, 23);
            this.txtKhuTen.TabIndex = 3;
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(520, 13);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(85, 27);
            this.btnThemKhu.TabIndex = 4;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            // 
            // dgvKhu
            // 
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Location = new System.Drawing.Point(10, 55);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.ReadOnly = true;
            this.dgvKhu.Size = new System.Drawing.Size(750, 315);
            this.dgvKhu.TabIndex = 5;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.txtNVSDT);
            this.tabNhanVien.Controls.Add(this.lblNVSDT);
            this.tabNhanVien.Controls.Add(this.txtNVVaiTro);
            this.tabNhanVien.Controls.Add(this.lblNVVaiTro);
            this.tabNhanVien.Controls.Add(this.txtNVTen);
            this.tabNhanVien.Controls.Add(this.lblNVTen);
            this.tabNhanVien.Controls.Add(this.txtNVMa);
            this.tabNhanVien.Controls.Add(this.lblNVMa);
            this.tabNhanVien.Controls.Add(this.dgvNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 24);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(772, 382);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(6, 18);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(46, 15);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã NV:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(54, 15);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(70, 23);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(130, 18);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(30, 15);
            this.lblNVTen.TabIndex = 2;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(165, 15);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(130, 23);
            this.txtNVTen.TabIndex = 3;
            // 
            // lblNVVaiTro
            // 
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location = new System.Drawing.Point(305, 18);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.Size = new System.Drawing.Size(43, 15);
            this.lblNVVaiTro.TabIndex = 4;
            this.lblNVVaiTro.Text = "Vai trò:";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(350, 15);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(100, 23);
            this.txtNVVaiTro.TabIndex = 5;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(460, 18);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(30, 15);
            this.lblNVSDT.TabIndex = 6;
            this.lblNVSDT.Text = "SĐT:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(495, 15);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(105, 23);
            this.txtNVSDT.TabIndex = 7;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(620, 13);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(80, 27);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(10, 55);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.Size = new System.Drawing.Size(750, 315);
            this.dgvNV.TabIndex = 9;
            // 
            // tabLoaiTN
            // 
            this.tabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTN.Controls.Add(this.lblLoaiTen);
            this.tabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTN.Controls.Add(this.lblLoaiMa);
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTN.Location = new System.Drawing.Point(4, 24);
            this.tabLoaiTN.Name = "tabLoaiTN";
            this.tabLoaiTN.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiTN.Size = new System.Drawing.Size(772, 382);
            this.tabLoaiTN.TabIndex = 2;
            this.tabLoaiTN.Text = "Loại tiện nghi";
            this.tabLoaiTN.UseVisualStyleBackColor = true;
            // 
            // lblLoaiMa
            // 
            this.lblLoaiMa.AutoSize = true;
            this.lblLoaiMa.Location = new System.Drawing.Point(15, 18);
            this.lblLoaiMa.Name = "lblLoaiMa";
            this.lblLoaiMa.Size = new System.Drawing.Size(50, 15);
            this.lblLoaiMa.TabIndex = 0;
            this.lblLoaiMa.Text = "Mã loại:";
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(75, 15);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(140, 23);
            this.txtLoaiMa.TabIndex = 1;
            // 
            // lblLoaiTen
            // 
            this.lblLoaiTen.AutoSize = true;
            this.lblLoaiTen.Location = new System.Drawing.Point(235, 18);
            this.lblLoaiTen.Name = "lblLoaiTen";
            this.lblLoaiTen.Size = new System.Drawing.Size(52, 15);
            this.lblLoaiTen.TabIndex = 2;
            this.lblLoaiTen.Text = "Tên loại:";
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(295, 15);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(200, 23);
            this.txtLoaiTen.TabIndex = 3;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(520, 13);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(85, 27);
            this.btnThemLoaiTN.TabIndex = 4;
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Location = new System.Drawing.Point(10, 55);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.ReadOnly = true;
            this.dgvLoaiTN.Size = new System.Drawing.Size(750, 315);
            this.dgvLoaiTN.TabIndex = 5;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.btnThemDV);
            this.tabDichVu.Controls.Add(this.numDVGia);
            this.tabDichVu.Controls.Add(this.lblDVGia);
            this.tabDichVu.Controls.Add(this.txtDVDVT);
            this.tabDichVu.Controls.Add(this.lblDVDVT);
            this.tabDichVu.Controls.Add(this.txtDVTen);
            this.tabDichVu.Controls.Add(this.lblDVTen);
            this.tabDichVu.Controls.Add(this.txtDVMa);
            this.tabDichVu.Controls.Add(this.lblDVMa);
            this.tabDichVu.Controls.Add(this.dgvDV);
            this.tabDichVu.Location = new System.Drawing.Point(4, 24);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(772, 382);
            this.tabDichVu.TabIndex = 3;
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // lblDVMa
            // 
            this.lblDVMa.AutoSize = true;
            this.lblDVMa.Location = new System.Drawing.Point(6, 18);
            this.lblDVMa.Name = "lblDVMa";
            this.lblDVMa.Size = new System.Drawing.Size(46, 15);
            this.lblDVMa.TabIndex = 0;
            this.lblDVMa.Text = "Mã DV:";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(55, 15);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(75, 23);
            this.txtDVMa.TabIndex = 1;
            // 
            // lblDVTen
            // 
            this.lblDVTen.AutoSize = true;
            this.lblDVTen.Location = new System.Drawing.Point(135, 18);
            this.lblDVTen.Name = "lblDVTen";
            this.lblDVTen.Size = new System.Drawing.Size(28, 15);
            this.lblDVTen.TabIndex = 2;
            this.lblDVTen.Text = "Tên:";
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(168, 15);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(130, 23);
            this.txtDVTen.TabIndex = 3;
            // 
            // lblDVDVT
            // 
            this.lblDVDVT.AutoSize = true;
            this.lblDVDVT.Location = new System.Drawing.Point(305, 18);
            this.lblDVDVT.Name = "lblDVDVT";
            this.lblDVDVT.Size = new System.Drawing.Size(32, 15);
            this.lblDVDVT.TabIndex = 4;
            this.lblDVDVT.Text = "ĐVT:";
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(340, 15);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(70, 23);
            this.txtDVDVT.TabIndex = 5;
            // 
            // lblDVGia
            // 
            this.lblDVGia.AutoSize = true;
            this.lblDVGia.Location = new System.Drawing.Point(420, 18);
            this.lblDVGia.Name = "lblDVGia";
            this.lblDVGia.Size = new System.Drawing.Size(27, 15);
            this.lblDVGia.TabIndex = 6;
            this.lblDVGia.Text = "Giá:";
            // 
            // numDVGia
            // 
            this.numDVGia.Location = new System.Drawing.Point(452, 15);
            this.numDVGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(120, 23);
            this.numDVGia.TabIndex = 7;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(600, 13);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(80, 27);
            this.btnThemDV.TabIndex = 8;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(10, 55);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.Size = new System.Drawing.Size(750, 315);
            this.dgvDV.TabIndex = 9;
            // 
            // tabQuyDinh
            // 
            this.tabQuyDinh.Controls.Add(this.btnThemQD);
            this.tabQuyDinh.Controls.Add(this.numQDTien);
            this.tabQuyDinh.Controls.Add(this.lblQDTien);
            this.tabQuyDinh.Controls.Add(this.txtQDMucDo);
            this.tabQuyDinh.Controls.Add(this.lblQDMucDo);
            this.tabQuyDinh.Controls.Add(this.cboQDLoai);
            this.tabQuyDinh.Controls.Add(this.lblQDLoai);
            this.tabQuyDinh.Controls.Add(this.txtQDMa);
            this.tabQuyDinh.Controls.Add(this.lblQDMa);
            this.tabQuyDinh.Controls.Add(this.dgvQD);
            this.tabQuyDinh.Location = new System.Drawing.Point(4, 24);
            this.tabQuyDinh.Name = "tabQuyDinh";
            this.tabQuyDinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuyDinh.Size = new System.Drawing.Size(772, 382);
            this.tabQuyDinh.TabIndex = 4;
            this.tabQuyDinh.Text = "Quy định đền bù";
            this.tabQuyDinh.UseVisualStyleBackColor = true;
            // 
            // lblQDMa
            // 
            this.lblQDMa.AutoSize = true;
            this.lblQDMa.Location = new System.Drawing.Point(6, 18);
            this.lblQDMa.Name = "lblQDMa";
            this.lblQDMa.Size = new System.Drawing.Size(47, 15);
            this.lblQDMa.TabIndex = 0;
            this.lblQDMa.Text = "Mã QĐ:";
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(55, 15);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(75, 23);
            this.txtQDMa.TabIndex = 1;
            // 
            // lblQDLoai
            // 
            this.lblQDLoai.AutoSize = true;
            this.lblQDLoai.Location = new System.Drawing.Point(135, 18);
            this.lblQDLoai.Name = "lblQDLoai";
            this.lblQDLoai.Size = new System.Drawing.Size(32, 15);
            this.lblQDLoai.TabIndex = 2;
            this.lblQDLoai.Text = "Loại:";
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(170, 15);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(100, 23);
            this.cboQDLoai.TabIndex = 3;
            // 
            // lblQDMucDo
            // 
            this.lblQDMucDo.AutoSize = true;
            this.lblQDMucDo.Location = new System.Drawing.Point(280, 18);
            this.lblQDMucDo.Name = "lblQDMucDo";
            this.lblQDMucDo.Size = new System.Drawing.Size(51, 15);
            this.lblQDMucDo.TabIndex = 4;
            this.lblQDMucDo.Text = "Mức độ:";
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(335, 15);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(105, 23);
            this.txtQDMucDo.TabIndex = 5;
            // 
            // lblQDTien
            // 
            this.lblQDTien.AutoSize = true;
            this.lblQDTien.Location = new System.Drawing.Point(448, 18);
            this.lblQDTien.Name = "lblQDTien";
            this.lblQDTien.Size = new System.Drawing.Size(52, 15);
            this.lblQDTien.TabIndex = 6;
            this.lblQDTien.Text = "Mức tiền:";
            // 
            // numQDTien
            // 
            this.numQDTien.Location = new System.Drawing.Point(503, 15);
            this.numQDTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(110, 23);
            this.numQDTien.TabIndex = 7;
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(630, 13);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(80, 27);
            this.btnThemQD.TabIndex = 8;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = true;
            // 
            // dgvQD
            // 
            this.dgvQD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Location = new System.Drawing.Point(10, 55);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.ReadOnly = true;
            this.dgvQD.Size = new System.Drawing.Size(750, 315);
            this.dgvQD.TabIndex = 9;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(695, 430);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 470);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục khách sạn";
            this.tabControl1.ResumeLayout(false);
            this.tabKhuVuc.ResumeLayout(false);
            this.tabKhuVuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabLoaiTN.ResumeLayout(false);
            this.tabLoaiTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            this.tabDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.tabQuyDinh.ResumeLayout(false);
            this.tabQuyDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKhuVuc;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabLoaiTN;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.TabPage tabQuyDinh;
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridView dgvQD;
        private System.Windows.Forms.Label lblKhuMa;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Label lblKhuTen;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label lblLoaiMa;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Label lblLoaiTen;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.Label lblDVMa;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label lblDVTen;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label lblDVDVT;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label lblDVGia;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label lblQDMa;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label lblQDLoai;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.Label lblQDMucDo;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label lblQDTien;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.Button btnDong;
    }
}