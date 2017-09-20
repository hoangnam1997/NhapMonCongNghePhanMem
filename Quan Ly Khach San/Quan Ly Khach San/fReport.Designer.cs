namespace Quan_Ly_Khach_San
{
    partial class fReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.crystalReportViewerResult = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerResult
            // 
            this.crystalReportViewerResult.ActiveViewIndex = -1;
            this.crystalReportViewerResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerResult.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerResult.Name = "crystalReportViewerResult";
            this.crystalReportViewerResult.Size = new System.Drawing.Size(984, 514);
            this.crystalReportViewerResult.TabIndex = 0;
            this.crystalReportViewerResult.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 514);
            this.Controls.Add(this.crystalReportViewerResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerResult;
    }
}