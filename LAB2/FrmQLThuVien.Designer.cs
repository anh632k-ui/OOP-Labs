namespace LAB2
{
    partial class FrmQLThuVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_DanhMuc_NhanVien = new Button();
            button_DocGiavaThe = new Button();
            button_ThongKe = new Button();
            button_QLDauSach = new Button();
            button_MuonTraSach = new Button();
            button_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 31);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // button_DanhMuc_NhanVien
            // 
            button_DanhMuc_NhanVien.Location = new Point(77, 142);
            button_DanhMuc_NhanVien.Name = "button_DanhMuc_NhanVien";
            button_DanhMuc_NhanVien.Size = new Size(201, 42);
            button_DanhMuc_NhanVien.TabIndex = 1;
            button_DanhMuc_NhanVien.Text = "Danh mục / Nhân viên";
            button_DanhMuc_NhanVien.UseVisualStyleBackColor = true;
            button_DanhMuc_NhanVien.Click += button_Danhmuc_NhanVien_Click;
            // 
            // button_DocGiavaThe
            // 
            button_DocGiavaThe.Location = new Point(77, 233);
            button_DocGiavaThe.Name = "button_DocGiavaThe";
            button_DocGiavaThe.Size = new Size(201, 42);
            button_DocGiavaThe.TabIndex = 2;
            button_DocGiavaThe.Text = "Độc giả và Thẻ";
            button_DocGiavaThe.UseVisualStyleBackColor = true;
            button_DocGiavaThe.Click += button_DocGiavaThe_Click;
            // 
            // button_ThongKe
            // 
            button_ThongKe.Location = new Point(77, 319);
            button_ThongKe.Name = "button_ThongKe";
            button_ThongKe.Size = new Size(201, 42);
            button_ThongKe.TabIndex = 3;
            button_ThongKe.Text = "Thống kê";
            button_ThongKe.UseVisualStyleBackColor = true;
            button_ThongKe.Click += button_ThongKe_Click;
            // 
            // button_QLDauSach
            // 
            button_QLDauSach.Location = new Point(437, 142);
            button_QLDauSach.Name = "button_QLDauSach";
            button_QLDauSach.Size = new Size(201, 42);
            button_QLDauSach.TabIndex = 4;
            button_QLDauSach.Text = "Quản lý đầu sách";
            button_QLDauSach.UseVisualStyleBackColor = true;
            button_QLDauSach.Click += button_QLDauSach_Click;
            // 
            // button_MuonTraSach
            // 
            button_MuonTraSach.Location = new Point(437, 224);
            button_MuonTraSach.Name = "button_MuonTraSach";
            button_MuonTraSach.Size = new Size(201, 42);
            button_MuonTraSach.TabIndex = 5;
            button_MuonTraSach.Text = "Mượn - trả sách";
            button_MuonTraSach.UseVisualStyleBackColor = true;
            button_MuonTraSach.Click += button_MuonTraSach_Click;
            // 
            // button_Thoat
            // 
            button_Thoat.Location = new Point(437, 319);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(201, 42);
            button_Thoat.TabIndex = 6;
            button_Thoat.Text = "Thoát";
            button_Thoat.UseVisualStyleBackColor = true;
            button_Thoat.Click += button_Thoat_Click_1;
            // 
            // FrmQLThuVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Thoat);
            Controls.Add(button_MuonTraSach);
            Controls.Add(button_QLDauSach);
            Controls.Add(button_ThongKe);
            Controls.Add(button_DocGiavaThe);
            Controls.Add(button_DanhMuc_NhanVien);
            Controls.Add(label1);
            Name = "FrmQLThuVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            Load += FrmQLThuVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_DanhMuc_NhanVien;
        private Button button_DocGiavaThe;
        private Button button_ThongKe;
        private Button button_QLDauSach;
        private Button button_MuonTraSach;
        private Button button_Thoat;
    }
}
