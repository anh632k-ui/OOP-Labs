namespace Lab3_QLKhachSan
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongHop = new System.Windows.Forms.Label();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.lblDV = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTu.Location = new System.Drawing.Point(12, 18);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(52, 15);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(70, 15);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(110, 23);
            this.dtTu.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDen.Location = new System.Drawing.Point(195, 18);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(60, 15);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(260, 15);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(110, 23);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTK.Location = new System.Drawing.Point(385, 12);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(95, 29);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.Location = new System.Drawing.Point(490, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblTongHop
            // 
            this.lblTongHop.AutoSize = true;
            this.lblTongHop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongHop.Location = new System.Drawing.Point(12, 55);
            this.lblTongHop.Name = "lblTongHop";
            this.lblTongHop.Size = new System.Drawing.Size(96, 15);
            this.lblTongHop.TabIndex = 6;
            this.lblTongHop.Text = "Số liệu tổng hợp:";
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Location = new System.Drawing.Point(12, 75);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.ReadOnly = true;
            this.dgvTongHop.Size = new System.Drawing.Size(660, 75);
            this.dgvTongHop.TabIndex = 7;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDV.Location = new System.Drawing.Point(12, 165);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(98, 15);
            this.lblDV.TabIndex = 8;
            this.lblDV.Text = "Dịch vụ sử dụng:";
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(12, 185);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.Size = new System.Drawing.Size(660, 220);
            this.dgvDV.TabIndex = 9;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 420);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.lblTongHop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongHop;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.DataGridView dgvDV;
    }
}