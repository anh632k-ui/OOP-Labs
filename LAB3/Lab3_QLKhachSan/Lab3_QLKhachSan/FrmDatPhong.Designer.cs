namespace Lab3_QLKhachSan
{
    partial class FrmDatPhong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKhach = new System.Windows.Forms.TabPage();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.tabDat = new System.Windows.Forms.TabPage();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.lblCoc = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblKenh = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.lblTra = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNhan = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.lblLap = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.tabNhan = new System.Windows.Forms.TabPage();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.lblNguoiQT = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.lblNguoiCMND = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.lblNguoiTen = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.lblNguoiPhong = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.lblPhieuChon = new System.Windows.Forms.Label();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tabDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            this.tabNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKhach);
            this.tabControl1.Controls.Add(this.tabDat);
            this.tabControl1.Controls.Add(this.tabNhan);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKhach
            // 
            this.tabKhach.Controls.Add(this.dgvKhach);
            this.tabKhach.Controls.Add(this.txtSDT);
            this.tabKhach.Controls.Add(this.lblSDT);
            this.tabKhach.Controls.Add(this.txtQT);
            this.tabKhach.Controls.Add(this.lblQT);
            this.tabKhach.Controls.Add(this.txtCMND);
            this.tabKhach.Controls.Add(this.lblCMND);
            this.tabKhach.Controls.Add(this.txtTenKH);
            this.tabKhach.Controls.Add(this.lblTenKH);
            this.tabKhach.Controls.Add(this.txtMaKH);
            this.tabKhach.Controls.Add(this.lblMaKH);
            this.tabKhach.Controls.Add(this.btnThemKhach);
            this.tabKhach.Location = new System.Drawing.Point(4, 24);
            this.tabKhach.Name = "tabKhach";
            this.tabKhach.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhach.Size = new System.Drawing.Size(852, 452);
            this.tabKhach.TabIndex = 0;
            this.tabKhach.Text = "Khách hàng";
            this.tabKhach.UseVisualStyleBackColor = true;
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(10, 50);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.Size = new System.Drawing.Size(830, 390);
            this.dgvKhach.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(620, 15);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 23);
            this.txtSDT.TabIndex = 9;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(585, 18);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(30, 15);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "SĐT:";
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(495, 15);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(80, 23);
            this.txtQT.TabIndex = 7;
            this.txtQT.Text = "Việt Nam";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(465, 18);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(26, 15);
            this.lblQT.TabIndex = 6;
            this.lblQT.Text = "QT:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(355, 15);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 23);
            this.txtCMND.TabIndex = 5;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(305, 18);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(46, 15);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CCCD:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(170, 15);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(125, 23);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(138, 18);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(28, 15);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(60, 15);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(70, 23);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(10, 18);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(46, 15);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(740, 13);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(85, 27);
            this.btnThemKhach.TabIndex = 10;
            this.btnThemKhach.Text = "Thêm KH";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            // 
            // tabDat
            // 
            this.tabDat.Controls.Add(this.btnBoPhong);
            this.tabDat.Controls.Add(this.btnThemPhong);
            this.tabDat.Controls.Add(this.numSoNguoi);
            this.tabDat.Controls.Add(this.lblSoNguoi);
            this.tabDat.Controls.Add(this.dgvChon);
            this.tabDat.Controls.Add(this.dgvPhong);
            this.tabDat.Controls.Add(this.btnLapPhieu);
            this.tabDat.Controls.Add(this.numCoc);
            this.tabDat.Controls.Add(this.lblCoc);
            this.tabDat.Controls.Add(this.cboKenh);
            this.tabDat.Controls.Add(this.lblKenh);
            this.tabDat.Controls.Add(this.dtTra);
            this.tabDat.Controls.Add(this.lblTra);
            this.tabDat.Controls.Add(this.dtNhan);
            this.tabDat.Controls.Add(this.lblNhan);
            this.tabDat.Controls.Add(this.dtLap);
            this.tabDat.Controls.Add(this.lblLap);
            this.tabDat.Controls.Add(this.cboNV);
            this.tabDat.Controls.Add(this.lblNV);
            this.tabDat.Controls.Add(this.cboKhach);
            this.tabDat.Controls.Add(this.lblKhach);
            this.tabDat.Controls.Add(this.txtSoPhieu);
            this.tabDat.Controls.Add(this.lblSoPhieu);
            this.tabDat.Location = new System.Drawing.Point(4, 24);
            this.tabDat.Name = "tabDat";
            this.tabDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDat.Size = new System.Drawing.Size(852, 452);
            this.tabDat.TabIndex = 1;
            this.tabDat.Text = "Đặt phòng";
            this.tabDat.UseVisualStyleBackColor = true;
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(415, 230);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(40, 30);
            this.btnBoPhong.TabIndex = 22;
            this.btnBoPhong.Text = "<";
            this.btnBoPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(415, 185);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(40, 30);
            this.btnThemPhong.TabIndex = 21;
            this.btnThemPhong.Text = ">";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(412, 145);
            this.numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(48, 23);
            this.numSoNguoi.TabIndex = 20;
            this.numSoNguoi.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(415, 125);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(43, 15);
            this.lblSoNguoi.TabIndex = 19;
            this.lblSoNguoi.Text = "Số ng:";
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Location = new System.Drawing.Point(468, 85);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.ReadOnly = true;
            this.dgvChon.Size = new System.Drawing.Size(370, 315);
            this.dgvChon.TabIndex = 18;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(10, 85);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(395, 315);
            this.dgvPhong.TabIndex = 17;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieu.Location = new System.Drawing.Point(715, 410);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(125, 32);
            this.btnLapPhieu.TabIndex = 16;
            this.btnLapPhieu.Text = "Lập phiếu đặt";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // numCoc
            // 
            this.numCoc.Location = new System.Drawing.Point(735, 45);
            this.numCoc.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(100, 23);
            this.numCoc.TabIndex = 15;
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(680, 48);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(54, 15);
            this.lblCoc.TabIndex = 14;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // cboKenh
            // 
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(555, 45);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(110, 23);
            this.cboKenh.TabIndex = 13;
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Location = new System.Drawing.Point(515, 48);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(37, 15);
            this.lblKenh.TabIndex = 12;
            this.lblKenh.Text = "Kênh:";
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(405, 45);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(95, 23);
            this.dtTra.TabIndex = 11;
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(348, 48);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(54, 15);
            this.lblTra.TabIndex = 10;
            this.lblTra.Text = "Ngày trả:";
            // 
            // dtNhan
            // 
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNhan.Location = new System.Drawing.Point(235, 45);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(95, 23);
            this.dtNhan.TabIndex = 9;
            // 
            // lblNhan
            // 
            this.lblNhan.AutoSize = true;
            this.lblNhan.Location = new System.Drawing.Point(165, 48);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(68, 15);
            this.lblNhan.TabIndex = 8;
            this.lblNhan.Text = "Ngày nhận:";
            // 
            // dtLap
            // 
            this.dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLap.Location = new System.Drawing.Point(62, 45);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(90, 23);
            this.dtLap.TabIndex = 7;
            // 
            // lblLap
            // 
            this.lblLap.AutoSize = true;
            this.lblLap.Location = new System.Drawing.Point(6, 48);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(57, 15);
            this.lblLap.TabIndex = 6;
            this.lblLap.Text = "Ngày lập:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(545, 12);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(140, 23);
            this.cboNV.TabIndex = 5;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(500, 15);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(41, 15);
            this.lblNV.TabIndex = 4;
            this.lblNV.Text = "Lễ tân:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(265, 12);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(210, 23);
            this.cboKhach.TabIndex = 3;
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(220, 15);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(43, 15);
            this.lblKhach.TabIndex = 2;
            this.lblKhach.Text = "Khách:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(75, 12);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(120, 23);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(6, 15);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(56, 15);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu:";
            // 
            // tabNhan
            // 
            this.tabNhan.Controls.Add(this.btnNoShow);
            this.tabNhan.Controls.Add(this.btnNhanPhong);
            this.tabNhan.Controls.Add(this.btnThemNguoi);
            this.tabNhan.Controls.Add(this.txtNguoiQT);
            this.tabNhan.Controls.Add(this.lblNguoiQT);
            this.tabNhan.Controls.Add(this.txtNguoiCMND);
            this.tabNhan.Controls.Add(this.lblNguoiCMND);
            this.tabNhan.Controls.Add(this.txtNguoiTen);
            this.tabNhan.Controls.Add(this.lblNguoiTen);
            this.tabNhan.Controls.Add(this.txtNguoiPhong);
            this.tabNhan.Controls.Add(this.lblNguoiPhong);
            this.tabNhan.Controls.Add(this.txtPhieuChon);
            this.tabNhan.Controls.Add(this.lblPhieuChon);
            this.tabNhan.Controls.Add(this.dgvNguoi);
            this.tabNhan.Controls.Add(this.dgvCT);
            this.tabNhan.Controls.Add(this.dgvPhieu);
            this.tabNhan.Location = new System.Drawing.Point(4, 24);
            this.tabNhan.Name = "tabNhan";
            this.tabNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhan.Size = new System.Drawing.Size(852, 452);
            this.tabNhan.TabIndex = 2;
            this.tabNhan.Text = "Nhận phòng / Người lưu trú";
            this.tabNhan.UseVisualStyleBackColor = true;
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(740, 412);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(95, 30);
            this.btnNoShow.TabIndex = 15;
            this.btnNoShow.Text = "No-show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNhanPhong.Location = new System.Drawing.Point(615, 412);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(115, 30);
            this.btnNhanPhong.TabIndex = 14;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(755, 205);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(85, 27);
            this.btnThemNguoi.TabIndex = 13;
            this.btnThemNguoi.Text = "Thêm người";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(670, 207);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(75, 23);
            this.txtNguoiQT.TabIndex = 12;
            this.txtNguoiQT.Text = "Việt Nam";
            // 
            // lblNguoiQT
            // 
            this.lblNguoiQT.AutoSize = true;
            this.lblNguoiQT.Location = new System.Drawing.Point(640, 210);
            this.lblNguoiQT.Name = "lblNguoiQT";
            this.lblNguoiQT.Size = new System.Drawing.Size(26, 15);
            this.lblNguoiQT.TabIndex = 11;
            this.lblNguoiQT.Text = "QT:";
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(535, 207);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(95, 23);
            this.txtNguoiCMND.TabIndex = 10;
            // 
            // lblNguoiCMND
            // 
            this.lblNguoiCMND.AutoSize = true;
            this.lblNguoiCMND.Location = new System.Drawing.Point(485, 210);
            this.lblNguoiCMND.Name = "lblNguoiCMND";
            this.lblNguoiCMND.Size = new System.Drawing.Size(46, 15);
            this.lblNguoiCMND.TabIndex = 9;
            this.lblNguoiCMND.Text = "CCCD:";
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(365, 207);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(110, 23);
            this.txtNguoiTen.TabIndex = 8;
            // 
            // lblNguoiTen
            // 
            this.lblNguoiTen.AutoSize = true;
            this.lblNguoiTen.Location = new System.Drawing.Point(335, 210);
            this.lblNguoiTen.Name = "lblNguoiTen";
            this.lblNguoiTen.Size = new System.Drawing.Size(28, 15);
            this.lblNguoiTen.TabIndex = 7;
            this.lblNguoiTen.Text = "Tên:";
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(260, 207);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(65, 23);
            this.txtNguoiPhong.TabIndex = 6;
            // 
            // lblNguoiPhong
            // 
            this.lblNguoiPhong.AutoSize = true;
            this.lblNguoiPhong.Location = new System.Drawing.Point(212, 210);
            this.lblNguoiPhong.Name = "lblNguoiPhong";
            this.lblNguoiPhong.Size = new System.Drawing.Size(45, 15);
            this.lblNguoiPhong.TabIndex = 5;
            this.lblNguoiPhong.Text = "Phòng:";
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.Location = new System.Drawing.Point(90, 207);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(110, 23);
            this.txtPhieuChon.TabIndex = 4;
            // 
            // lblPhieuChon
            // 
            this.lblPhieuChon.AutoSize = true;
            this.lblPhieuChon.Location = new System.Drawing.Point(10, 210);
            this.lblPhieuChon.Name = "lblPhieuChon";
            this.lblPhieuChon.Size = new System.Drawing.Size(74, 15);
            this.lblPhieuChon.TabIndex = 3;
            this.lblPhieuChon.Text = "Phiếu chọn:";
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoi.Location = new System.Drawing.Point(340, 240);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.ReadOnly = true;
            this.dgvNguoi.Size = new System.Drawing.Size(500, 160);
            this.dgvNguoi.TabIndex = 2;
            // 
            // dgvCT
            // 
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(10, 240);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.ReadOnly = true;
            this.dgvCT.Size = new System.Drawing.Size(315, 160);
            this.dgvCT.TabIndex = 1;
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(10, 10);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.Size = new System.Drawing.Size(830, 180);
            this.dgvPhieu.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(775, 498);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.tabControl1.ResumeLayout(false);
            this.tabKhach.ResumeLayout(false);
            this.tabKhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tabDat.ResumeLayout(false);
            this.tabDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            this.tabNhan.ResumeLayout(false);
            this.tabNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKhach;
        private System.Windows.Forms.TabPage tabDat;
        private System.Windows.Forms.TabPage tabNhan;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.Label lblLap;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Button btnNoShow;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Label lblNguoiQT;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.Label lblNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.Label lblNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.Label lblNguoiPhong;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.Label lblPhieuChon;
        private System.Windows.Forms.DataGridView dgvNguoi;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}