namespace Quan_Ly_Khach_San
{
    partial class fQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuyDinh));
            this.txbTLNC = new System.Windows.Forms.TextBox();
            this.txbTLNT3 = new System.Windows.Forms.TextBox();
            this.lblTLNC = new System.Windows.Forms.Label();
            this.lblTLNT3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTLNC
            // 
            this.txbTLNC.Location = new System.Drawing.Point(179, 59);
            this.txbTLNC.Name = "txbTLNC";
            this.txbTLNC.Size = new System.Drawing.Size(186, 20);
            this.txbTLNC.TabIndex = 1;
            this.txbTLNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTLNT3_KeyPress);
            // 
            // txbTLNT3
            // 
            this.txbTLNT3.Location = new System.Drawing.Point(179, 18);
            this.txbTLNT3.Name = "txbTLNT3";
            this.txbTLNT3.Size = new System.Drawing.Size(186, 20);
            this.txbTLNT3.TabIndex = 0;
            this.txbTLNT3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTLNT3_KeyPress);
            // 
            // lblTLNC
            // 
            this.lblTLNC.AutoSize = true;
            this.lblTLNC.Location = new System.Drawing.Point(22, 62);
            this.lblTLNC.Name = "lblTLNC";
            this.lblTLNC.Size = new System.Drawing.Size(151, 13);
            this.lblTLNC.TabIndex = 3;
            this.lblTLNC.Text = "Tỉ lệ khi có khách nước ngoài:";
            // 
            // lblTLNT3
            // 
            this.lblTLNT3.AutoSize = true;
            this.lblTLNT3.Location = new System.Drawing.Point(22, 21);
            this.lblTLNT3.Name = "lblTLNT3";
            this.lblTLNT3.Size = new System.Drawing.Size(148, 13);
            this.lblTLNT3.TabIndex = 4;
            this.lblTLNT3.Text = "Tỉ lệ phụ thu người thứ ba (%):";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(285, 97);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(199, 97);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // fQuyDinh
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(384, 154);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txbTLNC);
            this.Controls.Add(this.txbTLNT3);
            this.Controls.Add(this.lblTLNC);
            this.Controls.Add(this.lblTLNT3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quy Định";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTLNC;
        private System.Windows.Forms.TextBox txbTLNT3;
        private System.Windows.Forms.Label lblTLNC;
        private System.Windows.Forms.Label lblTLNT3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
    }
}