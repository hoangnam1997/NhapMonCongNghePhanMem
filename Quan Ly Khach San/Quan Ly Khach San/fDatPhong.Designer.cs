namespace Quan_Ly_Khach_San
{
    partial class fDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDatPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.cbMAPDK = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDaDen = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.dtgvThongTinKhach = new System.Windows.Forms.DataGridView();
            this.contextMenuStripThongTin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemKhachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaKhachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpkDuKhienTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpkThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblThongTinDatPhong = new System.Windows.Forms.Label();
            this.lblDanhSachPhong = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.fpnlDSPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinKhach)).BeginInit();
            this.contextMenuStripThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.pnlThongTin);
            this.panel1.Controls.Add(this.lblThongTinDatPhong);
            this.panel1.Controls.Add(this.lblDanhSachPhong);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.fpnlDSPhong);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 462);
            this.panel1.TabIndex = 0;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.BackColor = System.Drawing.Color.Honeydew;
            this.pnlThongTin.Controls.Add(this.cbMAPDK);
            this.pnlThongTin.Controls.Add(this.btnCapNhat);
            this.pnlThongTin.Controls.Add(this.btnDaDen);
            this.pnlThongTin.Controls.Add(this.btnThem);
            this.pnlThongTin.Controls.Add(this.btnThoat);
            this.pnlThongTin.Controls.Add(this.btnHuyBo);
            this.pnlThongTin.Controls.Add(this.dtgvThongTinKhach);
            this.pnlThongTin.Controls.Add(this.dtpkDuKhienTraPhong);
            this.pnlThongTin.Controls.Add(this.dtpkThoiGianDen);
            this.pnlThongTin.Controls.Add(this.label3);
            this.pnlThongTin.Controls.Add(this.label10);
            this.pnlThongTin.Controls.Add(this.label9);
            this.pnlThongTin.Location = new System.Drawing.Point(447, 61);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(525, 388);
            this.pnlThongTin.TabIndex = 1;
            // 
            // cbMAPDK
            // 
            this.cbMAPDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMAPDK.FormattingEnabled = true;
            this.cbMAPDK.Location = new System.Drawing.Point(359, 6);
            this.cbMAPDK.Name = "cbMAPDK";
            this.cbMAPDK.Size = new System.Drawing.Size(146, 21);
            this.cbMAPDK.TabIndex = 1;
            this.cbMAPDK.SelectedIndexChanged += new System.EventHandler(this.cbMAPDK_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(253, 324);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDaDen
            // 
            this.btnDaDen.Location = new System.Drawing.Point(167, 324);
            this.btnDaDen.Name = "btnDaDen";
            this.btnDaDen.Size = new System.Drawing.Size(80, 40);
            this.btnDaDen.TabIndex = 5;
            this.btnDaDen.Text = "Đã đến";
            this.btnDaDen.UseVisualStyleBackColor = true;
            this.btnDaDen.Click += new System.EventHandler(this.btnDaDen_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 324);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(425, 324);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(339, 324);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(80, 40);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // dtgvThongTinKhach
            // 
            this.dtgvThongTinKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongTinKhach.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgvThongTinKhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvThongTinKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTinKhach.ContextMenuStrip = this.contextMenuStripThongTin;
            this.dtgvThongTinKhach.Location = new System.Drawing.Point(27, 86);
            this.dtgvThongTinKhach.MultiSelect = false;
            this.dtgvThongTinKhach.Name = "dtgvThongTinKhach";
            this.dtgvThongTinKhach.Size = new System.Drawing.Size(478, 221);
            this.dtgvThongTinKhach.TabIndex = 3;
            // 
            // contextMenuStripThongTin
            // 
            this.contextMenuStripThongTin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemKhachToolStripMenuItem,
            this.XoaKhachToolStripMenuItem});
            this.contextMenuStripThongTin.Name = "contextMenuStripThongTin";
            this.contextMenuStripThongTin.Size = new System.Drawing.Size(194, 48);
            // 
            // ThemKhachToolStripMenuItem
            // 
            this.ThemKhachToolStripMenuItem.Name = "ThemKhachToolStripMenuItem";
            this.ThemKhachToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ThemKhachToolStripMenuItem.Text = "Thêm khách";
            this.ThemKhachToolStripMenuItem.Click += new System.EventHandler(this.ThemKhachToolStripMenuItem_Click);
            // 
            // XoaKhachToolStripMenuItem
            // 
            this.XoaKhachToolStripMenuItem.Name = "XoaKhachToolStripMenuItem";
            this.XoaKhachToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.XoaKhachToolStripMenuItem.Text = "Xóa khách khỏi phòng";
            this.XoaKhachToolStripMenuItem.Click += new System.EventHandler(this.XoaKhachToolStripMenuItem_Click);
            // 
            // dtpkDuKhienTraPhong
            // 
            this.dtpkDuKhienTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkDuKhienTraPhong.Location = new System.Drawing.Point(359, 48);
            this.dtpkDuKhienTraPhong.Name = "dtpkDuKhienTraPhong";
            this.dtpkDuKhienTraPhong.Size = new System.Drawing.Size(146, 20);
            this.dtpkDuKhienTraPhong.TabIndex = 3;
            // 
            // dtpkThoiGianDen
            // 
            this.dtpkThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkThoiGianDen.Location = new System.Drawing.Point(106, 48);
            this.dtpkThoiGianDen.Name = "dtpkThoiGianDen";
            this.dtpkThoiGianDen.Size = new System.Drawing.Size(146, 20);
            this.dtpkThoiGianDen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phiếu đăng ký";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dự kiến trả phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thời gian đến:";
            // 
            // lblThongTinDatPhong
            // 
            this.lblThongTinDatPhong.AutoSize = true;
            this.lblThongTinDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinDatPhong.Location = new System.Drawing.Point(619, 33);
            this.lblThongTinDatPhong.Name = "lblThongTinDatPhong";
            this.lblThongTinDatPhong.Size = new System.Drawing.Size(171, 22);
            this.lblThongTinDatPhong.TabIndex = 2;
            this.lblThongTinDatPhong.Text = "Thông tin đặt phòng";
            // 
            // lblDanhSachPhong
            // 
            this.lblDanhSachPhong.AutoSize = true;
            this.lblDanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachPhong.Location = new System.Drawing.Point(3, 27);
            this.lblDanhSachPhong.Name = "lblDanhSachPhong";
            this.lblDanhSachPhong.Size = new System.Drawing.Size(151, 22);
            this.lblDanhSachPhong.TabIndex = 2;
            this.lblDanhSachPhong.Text = "Danh sách phòng";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(232, 27);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(192, 28);
            this.cbLoaiPhong.TabIndex = 0;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // fpnlDSPhong
            // 
            this.fpnlDSPhong.AutoScroll = true;
            this.fpnlDSPhong.BackColor = System.Drawing.Color.Honeydew;
            this.fpnlDSPhong.Location = new System.Drawing.Point(3, 61);
            this.fpnlDSPhong.Name = "fpnlDSPhong";
            this.fpnlDSPhong.Size = new System.Drawing.Size(430, 388);
            this.fpnlDSPhong.TabIndex = 0;
            // 
            // fDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinKhach)).EndInit();
            this.contextMenuStripThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.DataGridView dtgvThongTinKhach;
        private System.Windows.Forms.DateTimePicker dtpkDuKhienTraPhong;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianDen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThongTinDatPhong;
        private System.Windows.Forms.Label lblDanhSachPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.FlowLayoutPanel fpnlDSPhong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripThongTin;
        private System.Windows.Forms.ComboBox cbMAPDK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ThemKhachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaKhachToolStripMenuItem;
        private System.Windows.Forms.Button btnDaDen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}