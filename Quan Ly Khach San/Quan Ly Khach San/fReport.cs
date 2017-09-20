using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San
{
    public partial class fReport : Form
    {
        /// <summary>
        /// hàm khỏi tạo
        /// </summary>
        /// <param name="CrystalReport"></param>
        public fReport(object CrystalReport)
        {
            InitializeComponent();
            crystalReportViewerResult.ReportSource = CrystalReport;
            crystalReportViewerResult.Refresh();
        }
    }
}
