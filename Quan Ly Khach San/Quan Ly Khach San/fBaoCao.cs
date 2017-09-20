using BUS;
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
    public partial class fBaoCao : Form
    {
        /// <summary>
        /// hàm khỏi tạo bao cáo
        /// </summary>
        /// <param name="LoaiBaoCao"></param>
        public fBaoCao(int LoaiBaoCao)
        {
            InitializeComponent();
            this.LoaiBaoCao = LoaiBaoCao;
            LoadTime();
            ptbTim_Click(this, new EventArgs());
        }
        #region properties
        private int LoaiBaoCao;
        #endregion
        #region method
        /// <summary>
        /// Chỉnh thời gian đầu tháng đến cuối tháng
        /// </summary>
        void LoadTime()
        {
            DateTime dateNow = DateTime.Now;
            dtpkTuNgay.Value = new DateTime(dateNow.Year, dateNow.Month, 1, 0, 0, 1);
            dtpkDenNgay.Value = dtpkTuNgay.Value.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(58);
        }

        #endregion


        #region Event
        /// <summary>
        /// Thực hiện load báo cáo dựa vào khoản thời gian do người dung chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbTim_Click(object sender, EventArgs e)
        {
            switch (LoaiBaoCao)
            {
                case 0:
                    crHoaDon cr = new crHoaDon();
                    cr.SetDataSource(busHoaDon.Instance.LayThongTinHoaDon(dtpkTuNgay.Value, dtpkDenNgay.Value));
                    crvBaoCao.ReportSource = cr;
                    crvBaoCao.Refresh();
                    break;
                case 1:
                    crHoaDonLoaiPhong crLP = new crHoaDonLoaiPhong();
                    crLP.SetDataSource(busHoaDon.Instance.LayThongTinHoaDonLoaiP(dtpkTuNgay.Value, dtpkDenNgay.Value));
                    crvBaoCao.ReportSource = crLP;
                    crvBaoCao.Refresh();
                    break;
            }
        }
        /// <summary>
        /// thay đổi màu nên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbTim_MouseEnter(object sender, EventArgs e)
        {
            ptbTim.BackColor = Color.LightCyan;
        }
        /// <summary>
        /// thay đổi màu nên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbTim_MouseLeave(object sender, EventArgs e)
        {
            ptbTim.BackColor = this.BackColor;
        }
        #endregion


    }
}
