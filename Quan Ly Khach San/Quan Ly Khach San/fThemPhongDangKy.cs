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
    public partial class fThemPhongDangKy : Form
    {
        public fThemPhongDangKy(DateTime TuNgay, DateTime DenNgay)
        {
            InitializeComponent();
            this.TuNgay = TuNgay;
            this.DenNgay = DenNgay;
            loadDanhSachPhongHopLe(TuNgay, DenNgay);
        }
        #region properties
        /// <summary>
        /// event sent phòng
        /// </summary>
        private event EventHandler<PhongEvent> _sentPhong;
        public event EventHandler<PhongEvent> SentPhong
        {
            add { _sentPhong += value; }
            remove { _sentPhong -= value; }
        }
        private DateTime TuNgay;
        private DateTime DenNgay;
        #endregion
        #region method
        /// <summary>
        /// Lấy tất cả danh sách phòng hợp lệ vào 
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="DenNgay"></param>
        void loadDanhSachPhongHopLe(DateTime tungay, DateTime DenNgay)
        {
            List<dtoPhong> listResult = busPhong.Instance.LayDanhSachPhongHopLe(tungay, DenNgay);
            cbDanhSachPhong.DataSource = listResult;
        }
        #endregion

        #region event
        /// <summary>
        /// Gui phong da chon sang form khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbDanhSachPhong.SelectedItem == null) return;
            dtoPhong result = (dtoPhong)(cbDanhSachPhong.SelectedItem);
            if(_sentPhong!=null)
            {
                _sentPhong(this, new PhongEvent(result));
            }
        }
        #endregion


    }
    public class PhongEvent : EventArgs
    {
        private dtoPhong result;
        public PhongEvent(dtoPhong result)
        {
            this.Result = result;
        }

        public dtoPhong Result
        {
            get
            {
                return result;
            }
            private set
            {
                result = value;
            }
        }
    }
}
