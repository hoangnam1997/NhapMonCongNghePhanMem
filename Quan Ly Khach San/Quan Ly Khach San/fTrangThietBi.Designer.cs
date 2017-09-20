namespace Quan_Ly_Khach_San
{
    partial class fTrangThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTrangThietBi));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongTinThietBi = new System.Windows.Forms.Label();
            this.txbTenThietBi = new System.Windows.Forms.TextBox();
            this.txbMaThietBi = new System.Windows.Forms.TextBox();
            this.dtgvDsPhong = new System.Windows.Forms.DataGridView();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTrangThietBi = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrangThietBi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(556, 342);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(470, 342);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(384, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblThongTinThietBi
            // 
            this.lblThongTinThietBi.AutoSize = true;
            this.lblThongTinThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinThietBi.Location = new System.Drawing.Point(440, 17);
            this.lblThongTinThietBi.Name = "lblThongTinThietBi";
            this.lblThongTinThietBi.Size = new System.Drawing.Size(144, 22);
            this.lblThongTinThietBi.TabIndex = 10;
            this.lblThongTinThietBi.Text = "Thông tin thiết bị";
            // 
            // txbTenThietBi
            // 
            this.txbTenThietBi.Location = new System.Drawing.Point(134, 43);
            this.txbTenThietBi.Name = "txbTenThietBi";
            this.txbTenThietBi.Size = new System.Drawing.Size(173, 20);
            this.txbTenThietBi.TabIndex = 3;
            // 
            // txbMaThietBi
            // 
            this.txbMaThietBi.Location = new System.Drawing.Point(134, 13);
            this.txbMaThietBi.Name = "txbMaThietBi";
            this.txbMaThietBi.Size = new System.Drawing.Size(173, 20);
            this.txbMaThietBi.TabIndex = 2;
            // 
            // dtgvDsPhong
            // 
            this.dtgvDsPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsPhong.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgvDsPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDsPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsPhong.Location = new System.Drawing.Point(19, 92);
            this.dtgvDsPhong.MultiSelect = false;
            this.dtgvDsPhong.Name = "dtgvDsPhong";
            this.dtgvDsPhong.ReadOnly = true;
            this.dtgvDsPhong.Size = new System.Drawing.Size(317, 198);
            this.dtgvDsPhong.TabIndex = 1;
            // 
            // txbTim
            // 
            this.txbTim.Location = new System.Drawing.Point(74, 10);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(160, 20);
            this.txbTim.TabIndex = 0;
            this.txbTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTim_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng đặt thiết bị:";
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
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thiết bị:";
            // 
            // dtgvTrangThietBi
            // 
            this.dtgvTrangThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTrangThietBi.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgvTrangThietBi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvTrangThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTrangThietBi.Location = new System.Drawing.Point(8, 39);
            this.dtgvTrangThietBi.MultiSelect = false;
            this.dtgvTrangThietBi.Name = "dtgvTrangThietBi";
            this.dtgvTrangThietBi.ReadOnly = true;
            this.dtgvTrangThietBi.Size = new System.Drawing.Size(289, 339);
            this.dtgvTrangThietBi.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(240, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(57, 23);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.txbTenThietBi);
            this.panel2.Controls.Add(this.txbMaThietBi);
            this.panel2.Controls.Add(this.dtgvDsPhong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(383, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 293);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtgvTrangThietBi);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txbTim);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 386);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thiết bị:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(642, 342);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTemp.Location = new System.Drawing.Point(333, 7);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 13);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.TextChanged += new System.EventHandler(this.lblTemp_TextChanged);
            // 
            // fTrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongTinThietBi);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fTrangThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trang thiết bị";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrangThietBi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblThongTinThietBi;
        private System.Windows.Forms.TextBox txbTenThietBi;
        private System.Windows.Forms.TextBox txbMaThietBi;
        private System.Windows.Forms.DataGridView dtgvDsPhong;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTrangThietBi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTemp;
    }
}