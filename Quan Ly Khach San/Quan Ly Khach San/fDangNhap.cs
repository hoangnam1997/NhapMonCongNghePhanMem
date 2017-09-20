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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thực hiện đăng nhập, nếu đúng mật khẩu cho đăng nhập, không thì thông báo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = Cons.xoakhoangtrang(txbTenDangNhap.Text.ToUpper());
            string matKhau = Cons.hasPass(txbMatKhau.Text);
            dtoNhanVien NhanVienLogin = busNhanVien.Instance.LayTheoMaNHANVIEN(tenDangNhap);
            if (NhanVienLogin != null && matKhau == NhanVienLogin.MatKhauDangNhap)
            {
                this.Hide();
                fManhinhChinh f = new fManhinhChinh(NhanVienLogin);
                f.ShowDialog();
                txbMatKhau.Text = "";
                txbTenDangNhap.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Thoát khỏi chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
