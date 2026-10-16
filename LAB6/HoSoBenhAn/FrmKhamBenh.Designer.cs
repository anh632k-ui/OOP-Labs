namespace HoSoBenhAnPrototype
{
    partial class FrmKhamBenh
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
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblLoaiKham = new System.Windows.Forms.Label();
            this.cboLoaiKham = new System.Windows.Forms.ComboBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.dtKham = new System.Windows.Forms.DateTimePicker();
            this.lblThanNhiet = new System.Windows.Forms.Label();
            this.numThanNhiet = new System.Windows.Forms.NumericUpDown();
            this.lblHuyetAp = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.lblXnTitle = new System.Windows.Forms.Label();
            this.lblXn = new System.Windows.Forms.Label();
            this.cboXetNghiem = new System.Windows.Forms.ComboBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQuaXn = new System.Windows.Forms.TextBox();
            this.btnThemXn = new System.Windows.Forms.Button();
            this.btnXoaXn = new System.Windows.Forms.Button();
            this.listXn = new System.Windows.Forms.ListBox();
            this.lblToaTitle = new System.Windows.Forms.Label();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.gridThuoc = new System.Windows.Forms.DataGridView();
            this.lblVienPhi = new System.Windows.Forms.Label();
            this.numVienPhi = new System.Windows.Forms.NumericUpDown();
            this.ckXuatVien = new System.Windows.Forms.CheckBox();
            this.ckThanhToan = new System.Windows.Forms.CheckBox();
            this.lblXuatVien = new System.Windows.Forms.Label();
            this.dtXuatVien = new System.Windows.Forms.DateTimePicker();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.dtThanhToan = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.lblLichSuTitle = new System.Windows.Forms.Label();
            this.gridLichSu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numThanNhiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVienPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1080, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GHI NHẬN KHÁM BỆNH VÀ TOA THUỐC - Bùi Thế Anh - 1250080004";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblMaHoSo
            // 
            this.lblMaHoSo.Location = new System.Drawing.Point(20, 65);
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Size = new System.Drawing.Size(90, 24);
            this.lblMaHoSo.TabIndex = 1;
            this.lblMaHoSo.Text = "Mã hồ sơ (*)";
            this.lblMaHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(115, 62);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(174, 27);
            this.txtMaHoSo.TabIndex = 2;
            // 
            // lblBacSi
            // 
            this.lblBacSi.Location = new System.Drawing.Point(311, 65);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(68, 24);
            this.lblBacSi.TabIndex = 3;
            this.lblBacSi.Text = "Bác sĩ (*)";
            this.lblBacSi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.Location = new System.Drawing.Point(383, 62);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(272, 28);
            this.cboBacSi.TabIndex = 4;
            // 
            // lblLoaiKham
            // 
            this.lblLoaiKham.Location = new System.Drawing.Point(676, 65);
            this.lblLoaiKham.Name = "lblLoaiKham";
            this.lblLoaiKham.Size = new System.Drawing.Size(84, 24);
            this.lblLoaiKham.TabIndex = 5;
            this.lblLoaiKham.Text = "Loại khám";
            this.lblLoaiKham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboLoaiKham
            // 
            this.cboLoaiKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKham.Items.AddRange(new object[] {
            "DieuTri",
            "DinhKy"});
            this.cboLoaiKham.Location = new System.Drawing.Point(765, 62);
            this.cboLoaiKham.Name = "cboLoaiKham";
            this.cboLoaiKham.Size = new System.Drawing.Size(326, 28);
            this.cboLoaiKham.TabIndex = 6;
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.Location = new System.Drawing.Point(20, 103);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(90, 24);
            this.lblNgayKham.TabIndex = 7;
            this.lblNgayKham.Text = "Ngày khám";
            this.lblNgayKham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtKham
            // 
            this.dtKham.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtKham.Location = new System.Drawing.Point(115, 100);
            this.dtKham.Name = "dtKham";
            this.dtKham.ShowUpDown = true;
            this.dtKham.Size = new System.Drawing.Size(205, 27);
            this.dtKham.TabIndex = 8;
            // 
            // lblThanNhiet
            // 
            this.lblThanNhiet.Location = new System.Drawing.Point(346, 103);
            this.lblThanNhiet.Name = "lblThanNhiet";
            this.lblThanNhiet.Size = new System.Drawing.Size(84, 24);
            this.lblThanNhiet.TabIndex = 9;
            this.lblThanNhiet.Text = "Thân nhiệt";
            this.lblThanNhiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numThanNhiet
            // 
            this.numThanNhiet.DecimalPlaces = 1;
            this.numThanNhiet.Location = new System.Drawing.Point(431, 100);
            this.numThanNhiet.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numThanNhiet.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numThanNhiet.Name = "numThanNhiet";
            this.numThanNhiet.Size = new System.Drawing.Size(95, 27);
            this.numThanNhiet.TabIndex = 10;
            this.numThanNhiet.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // lblHuyetAp
            // 
            this.lblHuyetAp.Location = new System.Drawing.Point(548, 103);
            this.lblHuyetAp.Name = "lblHuyetAp";
            this.lblHuyetAp.Size = new System.Drawing.Size(84, 24);
            this.lblHuyetAp.TabIndex = 11;
            this.lblHuyetAp.Text = "Huyết áp";
            this.lblHuyetAp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Location = new System.Drawing.Point(637, 100);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(152, 27);
            this.txtHuyetAp.TabIndex = 12;
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.Location = new System.Drawing.Point(20, 141);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(98, 24);
            this.lblTrieuChung.TabIndex = 13;
            this.lblTrieuChung.Text = "Triệu chứng (*)";
            this.lblTrieuChung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(124, 138);
            this.txtTrieuChung.MaxLength = 1000;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(400, 27);
            this.txtTrieuChung.TabIndex = 14;
            // 
            // lblChanDoan
            // 
            this.lblChanDoan.Location = new System.Drawing.Point(548, 141);
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Size = new System.Drawing.Size(102, 24);
            this.lblChanDoan.TabIndex = 15;
            this.lblChanDoan.Text = "Chẩn đoán (*)";
            this.lblChanDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Location = new System.Drawing.Point(653, 138);
            this.txtChanDoan.MaxLength = 1000;
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new System.Drawing.Size(438, 27);
            this.txtChanDoan.TabIndex = 16;
            // 
            // lblXnTitle
            // 
            this.lblXnTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblXnTitle.Location = new System.Drawing.Point(20, 178);
            this.lblXnTitle.Name = "lblXnTitle";
            this.lblXnTitle.Size = new System.Drawing.Size(200, 24);
            this.lblXnTitle.TabIndex = 17;
            this.lblXnTitle.Text = "XÉT NGHIỆM";
            this.lblXnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblXn
            // 
            this.lblXn.Location = new System.Drawing.Point(20, 208);
            this.lblXn.Name = "lblXn";
            this.lblXn.Size = new System.Drawing.Size(92, 24);
            this.lblXn.TabIndex = 18;
            this.lblXn.Text = "Xét nghiệm";
            this.lblXn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboXetNghiem
            // 
            this.cboXetNghiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXetNghiem.Location = new System.Drawing.Point(115, 205);
            this.cboXetNghiem.Name = "cboXetNghiem";
            this.cboXetNghiem.Size = new System.Drawing.Size(244, 28);
            this.cboXetNghiem.TabIndex = 19;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(380, 208);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(70, 24);
            this.lblKetQua.TabIndex = 20;
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKetQuaXn
            // 
            this.txtKetQuaXn.Location = new System.Drawing.Point(455, 205);
            this.txtKetQuaXn.Name = "txtKetQuaXn";
            this.txtKetQuaXn.Size = new System.Drawing.Size(294, 27);
            this.txtKetQuaXn.TabIndex = 21;
            // 
            // btnThemXn
            // 
            this.btnThemXn.Location = new System.Drawing.Point(761, 203);
            this.btnThemXn.Name = "btnThemXn";
            this.btnThemXn.Size = new System.Drawing.Size(147, 32);
            this.btnThemXn.TabIndex = 22;
            this.btnThemXn.Text = "Thêm xét nghiệm";
            this.btnThemXn.UseVisualStyleBackColor = true;
            // 
            // btnXoaXn
            // 
            this.btnXoaXn.Location = new System.Drawing.Point(919, 203);
            this.btnXoaXn.Name = "btnXoaXn";
            this.btnXoaXn.Size = new System.Drawing.Size(172, 32);
            this.btnXoaXn.TabIndex = 23;
            this.btnXoaXn.Text = "Xóa xét nghiệm";
            this.btnXoaXn.UseVisualStyleBackColor = true;
            // 
            // listXn
            // 
            this.listXn.ItemHeight = 20;
            this.listXn.Location = new System.Drawing.Point(20, 242);
            this.listXn.Name = "listXn";
            this.listXn.Size = new System.Drawing.Size(1071, 44);
            this.listXn.TabIndex = 24;
            // 
            // lblToaTitle
            // 
            this.lblToaTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblToaTitle.Location = new System.Drawing.Point(20, 299);
            this.lblToaTitle.Name = "lblToaTitle";
            this.lblToaTitle.Size = new System.Drawing.Size(200, 24);
            this.lblToaTitle.TabIndex = 25;
            this.lblToaTitle.Text = "TOA THUỐC";
            this.lblToaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThuoc
            // 
            this.lblThuoc.Location = new System.Drawing.Point(20, 329);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(52, 24);
            this.lblThuoc.TabIndex = 26;
            this.lblThuoc.Text = "Thuốc";
            this.lblThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboThuoc
            // 
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.Location = new System.Drawing.Point(74, 326);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(314, 28);
            this.cboThuoc.TabIndex = 27;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(408, 329);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(77, 24);
            this.lblSoLuong.TabIndex = 28;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(490, 326);
            this.numSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(88, 27);
            this.numSoLuong.TabIndex = 29;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLieuDung
            // 
            this.lblLieuDung.Location = new System.Drawing.Point(594, 329);
            this.lblLieuDung.Name = "lblLieuDung";
            this.lblLieuDung.Size = new System.Drawing.Size(84, 24);
            this.lblLieuDung.TabIndex = 30;
            this.lblLieuDung.Text = "Liều dùng";
            this.lblLieuDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(681, 326);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(200, 27);
            this.txtLieuDung.TabIndex = 31;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(893, 324);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(98, 32);
            this.btnThemThuoc.TabIndex = 32;
            this.btnThemThuoc.Text = "Thêm thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Location = new System.Drawing.Point(1000, 324);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(91, 32);
            this.btnXoaThuoc.TabIndex = 33;
            this.btnXoaThuoc.Text = "Xóa thuốc";
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            // 
            // gridThuoc
            // 
            this.gridThuoc.AllowUserToAddRows = false;
            this.gridThuoc.AllowUserToDeleteRows = false;
            this.gridThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridThuoc.ColumnHeadersHeight = 29;
            this.gridThuoc.Location = new System.Drawing.Point(20, 365);
            this.gridThuoc.Name = "gridThuoc";
            this.gridThuoc.ReadOnly = true;
            this.gridThuoc.RowHeadersVisible = false;
            this.gridThuoc.RowHeadersWidth = 51;
            this.gridThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridThuoc.Size = new System.Drawing.Size(1071, 77);
            this.gridThuoc.TabIndex = 34;
            // 
            // lblVienPhi
            // 
            this.lblVienPhi.Location = new System.Drawing.Point(20, 460);
            this.lblVienPhi.Name = "lblVienPhi";
            this.lblVienPhi.Size = new System.Drawing.Size(95, 24);
            this.lblVienPhi.TabIndex = 35;
            this.lblVienPhi.Text = "Viện phí";
            this.lblVienPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numVienPhi
            // 
            this.numVienPhi.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVienPhi.Location = new System.Drawing.Point(115, 457);
            this.numVienPhi.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numVienPhi.Name = "numVienPhi";
            this.numVienPhi.Size = new System.Drawing.Size(188, 27);
            this.numVienPhi.TabIndex = 36;
            this.numVienPhi.ThousandsSeparator = true;
            // 
            // ckXuatVien
            // 
            this.ckXuatVien.Location = new System.Drawing.Point(349, 460);
            this.ckXuatVien.Name = "ckXuatVien";
            this.ckXuatVien.Size = new System.Drawing.Size(145, 27);
            this.ckXuatVien.TabIndex = 37;
            this.ckXuatVien.Text = "Đã xuất viện";
            // 
            // ckThanhToan
            // 
            this.ckThanhToan.Location = new System.Drawing.Point(529, 460);
            this.ckThanhToan.Name = "ckThanhToan";
            this.ckThanhToan.Size = new System.Drawing.Size(175, 27);
            this.ckThanhToan.TabIndex = 38;
            this.ckThanhToan.Text = "Đã thanh toán";
            // 
            // lblXuatVien
            // 
            this.lblXuatVien.Location = new System.Drawing.Point(20, 499);
            this.lblXuatVien.Name = "lblXuatVien";
            this.lblXuatVien.Size = new System.Drawing.Size(101, 24);
            this.lblXuatVien.TabIndex = 39;
            this.lblXuatVien.Text = "Ngày xuất viện";
            this.lblXuatVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtXuatVien
            // 
            this.dtXuatVien.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtXuatVien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtXuatVien.Location = new System.Drawing.Point(126, 496);
            this.dtXuatVien.Name = "dtXuatVien";
            this.dtXuatVien.ShowUpDown = true;
            this.dtXuatVien.Size = new System.Drawing.Size(208, 27);
            this.dtXuatVien.TabIndex = 40;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.Location = new System.Drawing.Point(359, 499);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(111, 24);
            this.lblThanhToan.TabIndex = 41;
            this.lblThanhToan.Text = "Ngày thanh toán";
            this.lblThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtThanhToan
            // 
            this.dtThanhToan.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThanhToan.Location = new System.Drawing.Point(478, 496);
            this.dtThanhToan.Name = "dtThanhToan";
            this.dtThanhToan.ShowUpDown = true;
            this.dtThanhToan.Size = new System.Drawing.Size(208, 27);
            this.dtThanhToan.TabIndex = 42;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(20, 539);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(185, 34);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Ghi nhận hồ sơ";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(219, 539);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(200, 34);
            this.btnLichSu.TabIndex = 44;
            this.btnLichSu.Text = "Xem lịch sử hồ sơ";
            this.btnLichSu.UseVisualStyleBackColor = true;
            // 
            // lblLichSuTitle
            // 
            this.lblLichSuTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLichSuTitle.Location = new System.Drawing.Point(20, 589);
            this.lblLichSuTitle.Name = "lblLichSuTitle";
            this.lblLichSuTitle.Size = new System.Drawing.Size(280, 24);
            this.lblLichSuTitle.TabIndex = 45;
            this.lblLichSuTitle.Text = "LỊCH SỬ KHÁM BỆNH";
            this.lblLichSuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridLichSu
            // 
            this.gridLichSu.AllowUserToAddRows = false;
            this.gridLichSu.AllowUserToDeleteRows = false;
            this.gridLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLichSu.ColumnHeadersHeight = 29;
            this.gridLichSu.Location = new System.Drawing.Point(20, 615);
            this.gridLichSu.Name = "gridLichSu";
            this.gridLichSu.ReadOnly = true;
            this.gridLichSu.RowHeadersVisible = false;
            this.gridLichSu.RowHeadersWidth = 51;
            this.gridLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLichSu.Size = new System.Drawing.Size(1071, 75);
            this.gridLichSu.TabIndex = 46;
            // 
            // FrmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 704);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaHoSo);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.lblBacSi);
            this.Controls.Add(this.cboBacSi);
            this.Controls.Add(this.lblLoaiKham);
            this.Controls.Add(this.cboLoaiKham);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.dtKham);
            this.Controls.Add(this.lblThanNhiet);
            this.Controls.Add(this.numThanNhiet);
            this.Controls.Add(this.lblHuyetAp);
            this.Controls.Add(this.txtHuyetAp);
            this.Controls.Add(this.lblTrieuChung);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.lblChanDoan);
            this.Controls.Add(this.txtChanDoan);
            this.Controls.Add(this.lblXnTitle);
            this.Controls.Add(this.lblXn);
            this.Controls.Add(this.cboXetNghiem);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQuaXn);
            this.Controls.Add(this.btnThemXn);
            this.Controls.Add(this.btnXoaXn);
            this.Controls.Add(this.listXn);
            this.Controls.Add(this.lblToaTitle);
            this.Controls.Add(this.lblThuoc);
            this.Controls.Add(this.cboThuoc);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.lblLieuDung);
            this.Controls.Add(this.txtLieuDung);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.gridThuoc);
            this.Controls.Add(this.lblVienPhi);
            this.Controls.Add(this.numVienPhi);
            this.Controls.Add(this.ckXuatVien);
            this.Controls.Add(this.ckThanhToan);
            this.Controls.Add(this.lblXuatVien);
            this.Controls.Add(this.dtXuatVien);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.dtThanhToan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.lblLichSuTitle);
            this.Controls.Add(this.gridLichSu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 5 - GHI NHẬN KHÁM BỆNH";
            ((System.ComponentModel.ISupportInitialize)(this.numThanNhiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVienPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblLoaiKham;
        private System.Windows.Forms.ComboBox cboLoaiKham;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.DateTimePicker dtKham;
        private System.Windows.Forms.Label lblThanNhiet;
        private System.Windows.Forms.NumericUpDown numThanNhiet;
        private System.Windows.Forms.Label lblHuyetAp;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Label lblXnTitle;
        private System.Windows.Forms.Label lblXn;
        private System.Windows.Forms.ComboBox cboXetNghiem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQuaXn;
        private System.Windows.Forms.Button btnThemXn;
        private System.Windows.Forms.Button btnXoaXn;
        private System.Windows.Forms.ListBox listXn;
        private System.Windows.Forms.Label lblToaTitle;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblLieuDung;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.DataGridView gridThuoc;
        private System.Windows.Forms.Label lblVienPhi;
        private System.Windows.Forms.NumericUpDown numVienPhi;
        private System.Windows.Forms.CheckBox ckXuatVien;
        private System.Windows.Forms.CheckBox ckThanhToan;
        private System.Windows.Forms.Label lblXuatVien;
        private System.Windows.Forms.DateTimePicker dtXuatVien;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.DateTimePicker dtThanhToan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Label lblLichSuTitle;
        private System.Windows.Forms.DataGridView gridLichSu;
    }
}
