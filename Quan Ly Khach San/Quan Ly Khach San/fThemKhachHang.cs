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
    public partial class fThemKhachHang : Form
    {
        public fThemKhachHang()
        {
            InitializeComponent();
            LoadQuocTichtoCB(cbQuocTich);
        }
        /// <summary>
        /// hàm khởi tạo form
        /// </summary>
        /// <param name="khachHang"></param>
        public fThemKhachHang(dtoKhachHang khachHang)
        {
            InitializeComponent();
            LoadQuocTichtoCB(cbQuocTich);
            if (khachHang != null)
            {
                txbCMND.Text = khachHang.CMND;
                txbHoTen.Text = khachHang.TenKhachHang;
                txbDiachi.Text = khachHang.DiaChi;
                txbSoDienThoai.Text = khachHang.SoDienThoai;
                switch (khachHang.GioiTinh)
                {
                    case 0:
                        rdNu.Checked = true;
                        break;
                    case 1:
                        rdNam.Checked = true;
                        break;
                }
                foreach (dtoQuocTich item in cbQuocTich.Items)
                {
                    if (item.MAQT == khachHang.MAQT)
                    {
                        cbQuocTich.SelectedItem = item;
                        break;
                    }
                }
            }

        }
        #region properties
        private event EventHandler<KhachHangevent> _sentKhachHang;
        public event EventHandler<KhachHangevent> sentKhachHang
        {
            add { _sentKhachHang += value; }
            remove { _sentKhachHang -= value; }
        }
        #endregion
        #region method
        /// <summary>
        /// lấy danh sách các quốc tịch gán vào cb
        /// </summary>
        /// <param name="cb"></param>
        void LoadQuocTichtoCB(ComboBox cb)
        {
            List<dtoQuocTich> result=busQuocTich.Instance.layTatCaQuocTich();
            cbQuocTich.DataSource = result;
        }
        #endregion
        #region event
        /// <summary>
        /// Thoát khỏi màn hình thêm khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Lấy thông tin khách theo số chứng minh nhân dân nếu có
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbCMND_Leave(object sender, EventArgs e)
        {
            string cmnd = Cons.xoakhoangtrang(txbCMND.Text);
            dtoKhachHang khachhang = busKhachHang.Instance.LayTheoCMNDKhachHang(cmnd);
            if(khachhang!=null)
            {
                txbHoTen.Text = khachhang.TenKhachHang;
                txbDiachi.Text = khachhang.DiaChi;
                txbSoDienThoai.Text = khachhang.SoDienThoai;
                switch(khachhang.GioiTinh)
                {
                    case 0:
                        rdNu.Checked = true;
                        break;
                    case 1:
                        rdNam.Checked = true;
                        break;
                }
                foreach (dtoQuocTich item in cbQuocTich.Items)
                {
                    if(item.MAQT == khachhang.MAQT)
                    {
                        cbQuocTich.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// Thực hiện thêm khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            dtoKhachHang result;
            string cmnd = Cons.xoakhoangtrang(txbCMND.Text);
            if(string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập chứng minh nhân dân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            result= busKhachHang.Instance.LayTheoCMNDKhachHang(cmnd);
            //nêu chưa tồn tại khách hàng thì thực hiện thêm thông tin khác hàng vào cs dử liệu
            if (result == null)
            {
                string hoTen = Cons.xoakhoangtrang(txbHoTen.Text);
                int GioiTinh = rdNam.Checked == true ? 1 : 0;
                string sdt = Cons.xoakhoangtrang(txbSoDienThoai.Text);
                string diaChi = Cons.xoakhoangtrang(txbDiachi.Text);
                dtoQuocTich quoctich = (dtoQuocTich)cbQuocTich.SelectedItem;
                if (busKhachHang.Instance.themKhachHang(cmnd, hoTen, GioiTinh, sdt, diaChi, quoctich.MAQT))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                result = busKhachHang.Instance.LayTheoCMNDKhachHang(cmnd);
            }
            //thực hiện gửi thông tin khách hàng
            if(_sentKhachHang!=null)
            {
                _sentKhachHang(this, new KhachHangevent(result));
                
            }
            this.Close();
        }
    }
    public class KhachHangevent : EventArgs
    {
        private dtoKhachHang result;
        public KhachHangevent(dtoKhachHang khachHang)
        {
            this.Result = khachHang;
        }
        public dtoKhachHang Result
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
