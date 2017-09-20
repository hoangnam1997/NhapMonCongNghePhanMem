namespace Quan_Ly_Khach_San
{
    partial class fThongTin_TraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThongTin_TraPhong));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.dtpkThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpkThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.txbTongNgayThue = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dtgvDanhSachKhachThue = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhachThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(342, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thông tin phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 269);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.btnTraPhong);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbTongTien);
            this.panel3.Controls.Add(this.dtpkThoiGianKetThuc);
            this.panel3.Controls.Add(this.dtpkThoiGianBatDau);
            this.panel3.Controls.Add(this.txbTongNgayThue);
            this.panel3.Location = new System.Drawing.Point(425, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 254);
            this.panel3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dự kiến trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thời gian bắt đầu thuê:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(247, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số ngày đã thuê:";
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(75, 205);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(80, 40);
            this.btnTraPhong.TabIndex = 17;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng tiền:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Location = new System.Drawing.Point(127, 116);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(200, 20);
            this.txbTongTien.TabIndex = 16;
            // 
            // dtpkThoiGianKetThuc
            // 
            this.dtpkThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkThoiGianKetThuc.Location = new System.Drawing.Point(127, 60);
            this.dtpkThoiGianKetThuc.Name = "dtpkThoiGianKetThuc";
            this.dtpkThoiGianKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dtpkThoiGianKetThuc.TabIndex = 14;
            // 
            // dtpkThoiGianBatDau
            // 
            this.dtpkThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkThoiGianBatDau.Location = new System.Drawing.Point(127, 34);
            this.dtpkThoiGianBatDau.Name = "dtpkThoiGianBatDau";
            this.dtpkThoiGianBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtpkThoiGianBatDau.TabIndex = 14;
            // 
            // txbTongNgayThue
            // 
            this.txbTongNgayThue.Location = new System.Drawing.Point(127, 86);
            this.txbTongNgayThue.Name = "txbTongNgayThue";
            this.txbTongNgayThue.ReadOnly = true;
            this.txbTongNgayThue.Size = new System.Drawing.Size(200, 20);
            this.txbTongNgayThue.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.lblDanhSach);
            this.panel2.Controls.Add(this.dtgvDanhSachKhachThue);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 248);
            this.panel2.TabIndex = 12;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(106, 9);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(189, 22);
            this.lblDanhSach.TabIndex = 11;
            this.lblDanhSach.Text = "Danh sách khách thuê";
            // 
            // dtgvDanhSachKhachThue
            // 
            this.dtgvDanhSachKhachThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachKhachThue.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgvDanhSachKhachThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDanhSachKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachKhachThue.Location = new System.Drawing.Point(4, 34);
            this.dtgvDanhSachKhachThue.Name = "dtgvDanhSachKhachThue";
            this.dtgvDanhSachKhachThue.ReadOnly = true;
            this.dtgvDanhSachKhachThue.Size = new System.Drawing.Size(391, 211);
            this.dtgvDanhSachKhachThue.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(161, 205);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // fThongTin_TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(795, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fThongTin_TraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin - Trả phòng";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachKhachThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.TextBox txbTongNgayThue;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dtgvDanhSachKhachThue;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianKetThuc;
        private System.Windows.Forms.Button btnCapNhat;
    }
}