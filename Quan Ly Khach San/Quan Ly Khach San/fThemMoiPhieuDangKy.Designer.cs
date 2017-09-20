namespace Quan_Ly_Khach_San
{
    partial class fThemMoiPhieuDangKy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemMoiPhieuDangKy));
            this.dtpkDuKhienTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpkThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvDSPhong = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDanhSachPhong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaPhongDangChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaTatCaPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvDSKhach = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDanhSachKhach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemKhachToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaKhachDangChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaTatCaKhachToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.btnKhachDangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhong)).BeginInit();
            this.contextMenuStripDanhSachPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKhach)).BeginInit();
            this.contextMenuStripDanhSachKhach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkDuKhienTraPhong
            // 
            this.dtpkDuKhienTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkDuKhienTraPhong.Location = new System.Drawing.Point(126, 48);
            this.dtpkDuKhienTraPhong.Name = "dtpkDuKhienTraPhong";
            this.dtpkDuKhienTraPhong.Size = new System.Drawing.Size(146, 20);
            this.dtpkDuKhienTraPhong.TabIndex = 7;
            // 
            // dtpkThoiGianDen
            // 
            this.dtpkThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkThoiGianDen.Location = new System.Drawing.Point(126, 13);
            this.dtpkThoiGianDen.Name = "dtpkThoiGianDen";
            this.dtpkThoiGianDen.Size = new System.Drawing.Size(146, 20);
            this.dtpkThoiGianDen.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Dự kiến trả phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Thời gian đến:";
            // 
            // dtgvDSPhong
            // 
            this.dtgvDSPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvDSPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPhong.ContextMenuStrip = this.contextMenuStripDanhSachPhong;
            this.dtgvDSPhong.Location = new System.Drawing.Point(0, 36);
            this.dtgvDSPhong.MultiSelect = false;
            this.dtgvDSPhong.Name = "dtgvDSPhong";
            this.dtgvDSPhong.ReadOnly = true;
            this.dtgvDSPhong.Size = new System.Drawing.Size(450, 278);
            this.dtgvDSPhong.TabIndex = 8;
            // 
            // contextMenuStripDanhSachPhong
            // 
            this.contextMenuStripDanhSachPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemPhongToolStripMenuItem,
            this.XoaPhongDangChonToolStripMenuItem,
            this.XoaTatCaPhongToolStripMenuItem});
            this.contextMenuStripDanhSachPhong.Name = "contextMenuStripDanhSachPhong";
            this.contextMenuStripDanhSachPhong.Size = new System.Drawing.Size(193, 70);
            // 
            // ThemPhongToolStripMenuItem
            // 
            this.ThemPhongToolStripMenuItem.Name = "ThemPhongToolStripMenuItem";
            this.ThemPhongToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ThemPhongToolStripMenuItem.Text = "Thêm";
            this.ThemPhongToolStripMenuItem.Click += new System.EventHandler(this.ThemPhongToolStripMenuItem_Click);
            // 
            // XoaPhongDangChonToolStripMenuItem
            // 
            this.XoaPhongDangChonToolStripMenuItem.Name = "XoaPhongDangChonToolStripMenuItem";
            this.XoaPhongDangChonToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.XoaPhongDangChonToolStripMenuItem.Text = "Xóa phòng đang chọn";
            this.XoaPhongDangChonToolStripMenuItem.Click += new System.EventHandler(this.XoaPhongDangChonToolStripMenuItem_Click);
            // 
            // XoaTatCaPhongToolStripMenuItem
            // 
            this.XoaTatCaPhongToolStripMenuItem.Name = "XoaTatCaPhongToolStripMenuItem";
            this.XoaTatCaPhongToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.XoaTatCaPhongToolStripMenuItem.Text = "Xóa tất cả";
            this.XoaTatCaPhongToolStripMenuItem.Click += new System.EventHandler(this.XoaTatCaPhongToolStripMenuItem_Click);
            // 
            // dtgvDSKhach
            // 
            this.dtgvDSKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSKhach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvDSKhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDSKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSKhach.ContextMenuStrip = this.contextMenuStripDanhSachKhach;
            this.dtgvDSKhach.Location = new System.Drawing.Point(478, 36);
            this.dtgvDSKhach.MultiSelect = false;
            this.dtgvDSKhach.Name = "dtgvDSKhach";
            this.dtgvDSKhach.ReadOnly = true;
            this.dtgvDSKhach.Size = new System.Drawing.Size(450, 278);
            this.dtgvDSKhach.TabIndex = 8;
            // 
            // contextMenuStripDanhSachKhach
            // 
            this.contextMenuStripDanhSachKhach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemKhachToolStripMenuItem1,
            this.XoaKhachDangChonToolStripMenuItem,
            this.XoaTatCaKhachToolStripMenuItem1});
            this.contextMenuStripDanhSachKhach.Name = "contextMenuStripDanhSachKhach";
            this.contextMenuStripDanhSachKhach.Size = new System.Drawing.Size(190, 70);
            // 
            // ThemKhachToolStripMenuItem1
            // 
            this.ThemKhachToolStripMenuItem1.Name = "ThemKhachToolStripMenuItem1";
            this.ThemKhachToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.ThemKhachToolStripMenuItem1.Text = "Thêm";
            this.ThemKhachToolStripMenuItem1.Click += new System.EventHandler(this.ThemKhachToolStripMenuItem1_Click);
            // 
            // XoaKhachDangChonToolStripMenuItem
            // 
            this.XoaKhachDangChonToolStripMenuItem.Name = "XoaKhachDangChonToolStripMenuItem";
            this.XoaKhachDangChonToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.XoaKhachDangChonToolStripMenuItem.Text = "Xóa khách đang chọn";
            this.XoaKhachDangChonToolStripMenuItem.Click += new System.EventHandler(this.XoaKhachDangChonToolStripMenuItem_Click);
            // 
            // XoaTatCaKhachToolStripMenuItem1
            // 
            this.XoaTatCaKhachToolStripMenuItem1.Name = "XoaTatCaKhachToolStripMenuItem1";
            this.XoaTatCaKhachToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.XoaTatCaKhachToolStripMenuItem1.Text = "Xóa tất cả";
            this.XoaTatCaKhachToolStripMenuItem1.Click += new System.EventHandler(this.XoaTatCaKhachToolStripMenuItem1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(868, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(782, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.dtgvDSPhong);
            this.panel1.Controls.Add(this.dtgvDSKhach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 318);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách phòng";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTemp.Location = new System.Drawing.Point(455, 48);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 13);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.TextChanged += new System.EventHandler(this.lblTemp_TextChanged);
            // 
            // btnKhachDangKy
            // 
            this.btnKhachDangKy.Location = new System.Drawing.Point(291, 12);
            this.btnKhachDangKy.Name = "btnKhachDangKy";
            this.btnKhachDangKy.Size = new System.Drawing.Size(90, 21);
            this.btnKhachDangKy.TabIndex = 9;
            this.btnKhachDangKy.Text = "Khách đăng ký";
            this.btnKhachDangKy.UseVisualStyleBackColor = true;
            this.btnKhachDangKy.Click += new System.EventHandler(this.btnKhachDangKy_Click);
            // 
            // fThemMoiPhieuDangKy
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhachDangKy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpkDuKhienTraPhong);
            this.Controls.Add(this.dtpkThoiGianDen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThemMoiPhieuDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Phiếu Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhong)).EndInit();
            this.contextMenuStripDanhSachPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSKhach)).EndInit();
            this.contextMenuStripDanhSachKhach.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkDuKhienTraPhong;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgvDSPhong;
        private System.Windows.Forms.DataGridView dtgvDSKhach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDanhSachPhong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDanhSachKhach;
        private System.Windows.Forms.ToolStripMenuItem ThemPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaPhongDangChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaTatCaPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemKhachToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem XoaKhachDangChonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaTatCaKhachToolStripMenuItem1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Button btnKhachDangKy;
    }
}