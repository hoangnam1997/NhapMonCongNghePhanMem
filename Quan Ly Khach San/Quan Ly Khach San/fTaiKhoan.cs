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
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan(dtoNhanVien NhanVienLogin)
        {
            InitializeComponent();
            this.NhanVienLogin = NhanVienLogin;
            loadThongTinNhanVien(NhanVienLogin);
        }
        #region properties
        private dtoNhanVien NhanVienLogin; 
        #endregion
        #region Method
        void loadThongTinNhanVien(dtoNhanVien NhanVienLogin)
        {
            txbMANV.Text = NhanVienLogin.MANV;
            txbHoTen.Text = NhanVienLogin.TenNV;
            txbDiaChi.Text = NhanVienLogin.DiaChi;
            txbSDT.Text = NhanVienLogin.SDT;
            dtoChucVu ChucVuNhanVien = busChucVu.Instance.LayTheoMaChucVu(NhanVienLogin.MACV);
            txbChucVu.Text = ChucVuNhanVien.TenChucVu;
            dtpkNgaySinh.Value = NhanVienLogin.NgaySinh;
            switch(NhanVienLogin.GioiTinh)
            {
                case 0:
                    rdNu.Checked = true;
                    break;
                case 1:
                    rdNam.Checked = true;
                    break;
            }

        }
        #endregion

        #region event
        /// <summary>
        /// hiển thì form thay đổi mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            fThayDoiMatKhauNhanVien f = new fThayDoiMatKhauNhanVien(NhanVienLogin);
            f.ShowDialog();
        }
        /// <summary>
        /// Thoát khỏi form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Cập nhật thông tin tài khoản nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            string MANV = txbMANV.Text;
            string TenNV = txbHoTen.Text;
            string DiaChi=txbDiaChi.Text;
            string SDT = txbSDT.Text;
            string ChucVu = txbChucVu.Text;
            DateTime NgaySinh=dtpkNgaySinh.Value;
            int GioiTinh = 0;
            switch (rdNam.Checked)
            {
                case false:
                    GioiTinh = 0;
                    break;
                case true:
                    GioiTinh = 1;
                    break;
            }
            if(!busNhanVien.Instance.updateNhanVien(MANV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi))
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thực hiện lại sau!", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

       
    }
}
