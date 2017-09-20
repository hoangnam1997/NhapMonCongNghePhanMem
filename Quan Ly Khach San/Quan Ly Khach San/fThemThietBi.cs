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
    public partial class fThemThietBi : Form
    {
        public fThemThietBi()
        {
            InitializeComponent();
            LoadThietBi();
        }
        /// <summary>
        /// trả lại thông tin thiết bị khi thêm
        /// </summary>
        private event EventHandler<ThietbiEvent> _sentThietBi;
        public event EventHandler<ThietbiEvent> SentThietBi
        {
            add { _sentThietBi += value; }
            remove { _sentThietBi -= value; }
        }
        /// <summary>
        /// Lấy danh sách thiết bị và gán vào control
        /// </summary>
        void LoadThietBi()
        {
            cbThietBi.DataSource = busThietBi.Instance.LayTatCaThietBi();
        }
        /// <summary>
        /// Chi cho nhap so ở số luog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Thuc hien them thiet bi vao form và gửi sự kiện đến form trước đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cbThietBi.SelectedItem == null) return;
            int SL = 0;
            Int32.TryParse(txbSoLuong.Text, out SL);
            if(SL==0)
            {
                MessageBox.Show("Vui lòng nhập số lượng thiết bị muốn thêm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(_sentThietBi!=null)
            {
                _sentThietBi(this, new ThietbiEvent((dtoThietBi)cbThietBi.SelectedItem, SL));
            }
        }
        /// <summary>
        /// Thoát khỏi form Thêm thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class ThietbiEvent : EventArgs
    {
        private dtoThietBi thietBi;
        private int soLuong;
        public ThietbiEvent(dtoThietBi thietbi, int soLuong)
        {
            this.ThietBi = thietbi;
            this.SoLuong = soLuong;
        }

        public dtoThietBi ThietBi
        {
            get
            {
                return thietBi;
            }

            set
            {
                thietBi = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
    }
}
