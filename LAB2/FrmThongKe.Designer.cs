namespace LAB2
{
    partial class FrmThongKe
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
            label3 = new Label();
            dtTu = new DateTimePicker();
            label1 = new Label();
            dtDen = new DateTimePicker();
            btnThongKe = new Button();
            lblMuon = new Label();
            lblMat = new Label();
            lblHuHong = new Label();
            lblQuaHan = new Label();
            lblPhiPhat = new Label();
            dgvPhat = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhat).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 17);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 18;
            label3.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            dtTu.Location = new Point(107, 12);
            dtTu.Name = "dtTu";
            dtTu.Size = new Size(150, 27);
            dtTu.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 20;
            label1.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            dtDen.Location = new Point(359, 12);
            dtDen.Name = "dtDen";
            dtDen.Size = new Size(150, 27);
            dtDen.TabIndex = 19;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(569, 12);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(115, 30);
            btnThongKe.TabIndex = 21;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // lblMuon
            // 
            lblMuon.AutoSize = true;
            lblMuon.Location = new Point(36, 53);
            lblMuon.Name = "lblMuon";
            lblMuon.Size = new Size(122, 20);
            lblMuon.TabIndex = 22;
            lblMuon.Text = "Lượt sách mượn: ";
            // 
            // lblMat
            // 
            lblMat.AutoSize = true;
            lblMat.Location = new Point(36, 97);
            lblMat.Name = "lblMat";
            lblMat.Size = new Size(77, 20);
            lblMat.TabIndex = 23;
            lblMat.Text = "Sách mất: ";
            // 
            // lblHuHong
            // 
            lblHuHong.AutoSize = true;
            lblHuHong.Location = new Point(318, 97);
            lblHuHong.Name = "lblHuHong";
            lblHuHong.Size = new Size(102, 20);
            lblHuHong.TabIndex = 25;
            lblHuHong.Text = "Sách hư hỏng:";
            // 
            // lblQuaHan
            // 
            lblQuaHan.AutoSize = true;
            lblQuaHan.Location = new Point(318, 53);
            lblQuaHan.Name = "lblQuaHan";
            lblQuaHan.Size = new Size(100, 20);
            lblQuaHan.TabIndex = 24;
            lblQuaHan.Text = "Sách quá hạn:";
            // 
            // lblPhiPhat
            // 
            lblPhiPhat.AutoSize = true;
            lblPhiPhat.Location = new Point(36, 142);
            lblPhiPhat.Name = "lblPhiPhat";
            lblPhiPhat.Size = new Size(105, 20);
            lblPhiPhat.TabIndex = 26;
            lblPhiPhat.Text = "Tổng phí phạt:";
            //lblPhiPhat.Click += label7_Click;
            // 
            // dgvPhat
            // 
            dgvPhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhat.Location = new Point(12, 219);
            dgvPhat.Name = "dgvPhat";
            dgvPhat.RowHeadersWidth = 51;
            dgvPhat.Size = new Size(776, 219);
            dgvPhat.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 182);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 28;
            label8.Text = "Chi tiết phí phạt:";
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(dgvPhat);
            Controls.Add(lblPhiPhat);
            Controls.Add(lblHuHong);
            Controls.Add(lblQuaHan);
            Controls.Add(lblMat);
            Controls.Add(lblMuon);
            Controls.Add(btnThongKe);
            Controls.Add(label1);
            Controls.Add(dtDen);
            Controls.Add(label3);
            Controls.Add(dtTu);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            Load += FrmThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DateTimePicker dtTu;
        private Label label1;
        private DateTimePicker dtDen;
        private Button btnThongKe;
        private Label lblMuon;
        private Label lblMat;
        private Label lblHuHong;
        private Label lblQuaHan;
        private Label lblPhiPhat;
        private DataGridView dgvPhat;
        private Label label8;
    }
}