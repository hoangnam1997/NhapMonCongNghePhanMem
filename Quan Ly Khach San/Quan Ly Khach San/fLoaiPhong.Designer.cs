namespace Quan_Ly_Khach_San
{
    partial class fLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoaiPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbMaLoai = new System.Windows.Forms.TextBox();
            this.dtgvThietBi = new System.Windows.Forms.DataGridView();
            this.ctmsCTPTB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThongtinPhong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMALPtemp = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiPhong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThietBi)).BeginInit();
            this.ctmsCTPTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtgvLoaiPhong);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txbTim);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 386);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên loại:";
            // 
            // dtgvLoaiPhong
            // 
            this.dtgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoaiPhong.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiPhong.Location = new System.Drawing.Point(8, 39);
            this.dtgvLoaiPhong.MultiSelect = false;
            this.dtgvLoaiPhong.Name = "dtgvLoaiPhong";
            this.dtgvLoaiPhong.ReadOnly = true;
            this.dtgvLoaiPhong.Size = new System.Drawing.Size(289, 339);
            this.dtgvLoaiPhong.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(240, 10);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(57, 23);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbTim
            // 
            this.txbTim.AllowDrop = true;
            this.txbTim.Location = new System.Drawing.Point(66, 10);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(168, 20);
            this.txbTim.TabIndex = 0;
            this.txbTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTim_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.txbGia);
            this.panel2.Controls.Add(this.txbTen);
            this.panel2.Controls.Add(this.txbMaLoai);
            this.panel2.Controls.Add(this.dtgvThietBi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(383, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 293);
            this.panel2.TabIndex = 1;
            // 
            // txbGia
            // 
            this.txbGia.Location = new System.Drawing.Point(134, 73);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(173, 20);
            this.txbGia.TabIndex = 4;
            this.txbGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMaLoai_KeyDown);
            this.txbGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbGia_KeyPress);
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(134, 43);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(173, 20);
            this.txbTen.TabIndex = 3;
            this.txbTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMaLoai_KeyDown);
            // 
            // txbMaLoai
            // 
            this.txbMaLoai.Location = new System.Drawing.Point(134, 13);
            this.txbMaLoai.Name = "txbMaLoai";
            this.txbMaLoai.Size = new System.Drawing.Size(173, 20);
            this.txbMaLoai.TabIndex = 2;
            this.txbMaLoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMaLoai_KeyDown);
            // 
            // dtgvThietBi
            // 
            this.dtgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThietBi.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgvThietBi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThietBi.ContextMenuStrip = this.ctmsCTPTB;
            this.dtgvThietBi.Location = new System.Drawing.Point(19, 122);
            this.dtgvThietBi.MultiSelect = false;
            this.dtgvThietBi.Name = "dtgvThietBi";
            this.dtgvThietBi.ReadOnly = true;
            this.dtgvThietBi.Size = new System.Drawing.Size(317, 164);
            this.dtgvThietBi.TabIndex = 1;
            // 
            // ctmsCTPTB
            // 
            this.ctmsCTPTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemToolStripMenuItem,
            this.XoaToolStripMenuItem});
            this.ctmsCTPTB.Name = "ctmsCTPTB";
            this.ctmsCTPTB.Size = new System.Drawing.Size(106, 48);
            // 
            // ThemToolStripMenuItem
            // 
            this.ThemToolStripMenuItem.Name = "ThemToolStripMenuItem";
            this.ThemToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ThemToolStripMenuItem.Text = "Thêm";
            this.ThemToolStripMenuItem.Click += new System.EventHandler(this.ThemToolStripMenuItem_Click);
            // 
            // XoaToolStripMenuItem
            // 
            this.XoaToolStripMenuItem.Name = "XoaToolStripMenuItem";
            this.XoaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.XoaToolStripMenuItem.Text = "Xóa";
            this.XoaToolStripMenuItem.Click += new System.EventHandler(this.XoaToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thiết bị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại phòng:";
            // 
            // lblThongtinPhong
            // 
            this.lblThongtinPhong.AutoSize = true;
            this.lblThongtinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinPhong.Location = new System.Drawing.Point(440, 22);
            this.lblThongtinPhong.Name = "lblThongtinPhong";
            this.lblThongtinPhong.Size = new System.Drawing.Size(174, 22);
            this.lblThongtinPhong.TabIndex = 3;
            this.lblThongtinPhong.Text = "Thông tin loại phòng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(384, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(470, 350);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(556, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMALPtemp
            // 
            this.lblMALPtemp.AutoSize = true;
            this.lblMALPtemp.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblMALPtemp.Location = new System.Drawing.Point(337, 12);
            this.lblMALPtemp.Name = "lblMALPtemp";
            this.lblMALPtemp.Size = new System.Drawing.Size(0, 13);
            this.lblMALPtemp.TabIndex = 8;
            this.lblMALPtemp.TextChanged += new System.EventHandler(this.lblMALPtemp_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(642, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.lblMALPtemp);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongtinPhong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loại phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThietBi)).EndInit();
            this.ctmsCTPTB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvLoaiPhong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThongtinPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMALPtemp;
        private System.Windows.Forms.ContextMenuStrip ctmsCTPTB;
        private System.Windows.Forms.ToolStripMenuItem ThemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaToolStripMenuItem;
        private System.Windows.Forms.Button btnThoat;
    }
}