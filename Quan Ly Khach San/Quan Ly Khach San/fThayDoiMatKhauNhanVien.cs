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
    public partial class fThayDoiMatKhauNhanVien : Form
    {
        /// <summary>
        /// hàm khỏi tạo form
        /// </summary>
        /// <param name="NhanVienlogin"></param>
        public fThayDoiMatKhauNhanVien(dtoNhanVien NhanVienlogin)
        {
            InitializeComponent();
            this.NhanVienLogin = NhanVienlogin;
        }
        #region properties
        private dtoNhanVien NhanVienLogin;
        #endregion

        #region method
        #endregion

        #region event
        /// <summary>
        /// Thực hiện thay đổi thông mật khẩu cho nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MatKhauCu = Cons.hasPass(txbMatKhauCu.Text);
            string MatKhauMoi = Cons.hasPass(txbMatKhauMoi.Text);
            string MatKhauMoiLan2 = Cons.hasPass(txbMayKhauMoiLan2.Text);
            dtoNhanVien NhanVien = busNhanVien.Instance.LayTheoMaNHANVIEN(NhanVienLogin.MANV);
            if (MatKhauCu != NhanVien.MatKhauDangNhap)
            {
                MessageBox.Show("Mật khẩu củ sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MatKhauMoi != MatKhauMoiLan2)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!busNhanVien.Instance.updateNhanVien(NhanVien.MANV, MatKhauMoi))
            {
                MessageBox.Show("Xảy ra lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        /// <summary>
        /// Thực hiện thoát form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        

    }
}
