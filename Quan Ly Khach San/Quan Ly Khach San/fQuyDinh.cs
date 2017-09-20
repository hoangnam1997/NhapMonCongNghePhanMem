using BUS;
using DTO;
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
    public partial class fQuyDinh : Form
    {
        public fQuyDinh()
        {
            InitializeComponent();
            loadQuyDinh();
        }
        #region properties
        #endregion
        #region Method
        /// <summary>
        /// Lấy thông tin quy định gán vào các controls
        /// </summary>
        void loadQuyDinh()
        {
            dtoThamSo thamSo = busThamSo.Instance.layThamSo();
            txbTLNT3.Text = thamSo.TyLePhuThuKhachThu3.ToString();
            txbTLNC.Text = thamSo.TyLePhuThuKhachNuocNgoai.ToString();
        }
        #endregion
        #region event
        /// <summary>
        /// Chi Cho nhap so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTLNT3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Thoat khoi form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Cap nhat quy dinh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbTLNC.Text) || string.IsNullOrEmpty(txbTLNT3.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            float TLNNN = float.Parse(txbTLNC.Text);
            float TLNT3 = float.Parse(txbTLNT3.Text);
            if (!busThamSo.Instance.capNhatThamSo(TLNNN, TLNT3))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }
        }
        #endregion

    }
}
