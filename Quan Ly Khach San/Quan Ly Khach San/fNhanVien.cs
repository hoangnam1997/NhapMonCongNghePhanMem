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
    public partial class fNhanVien : Form
    {
        /// <summary>
        /// Hàm khỏi tạo
        /// </summary>
        public fNhanVien()
        {
            InitializeComponent();
            dtgvNhanVien.DataSource = NhanVienSource;
            loadNhanVien(busNhanVien.Instance.LayTatCaNHANVIEN());
            loadBinDing();
            loadChucVutoCB(cbChucVu);
        }
        #region properties
        private BindingSource NhanVienSource = new BindingSource();
        #endregion
        #region method
        /// <summary>
        /// Thực hiên load các binding khi selected item trên dtgv và lấy các thông tin gán gào các controls
        /// </summary>
        void loadBinDing()
        {
            txbMANV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            lblNHanVienTemp.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txbDiachi.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            dtpkNgaySinh.DataBindings.Add(new Binding("Value", dtgvNhanVien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            lblGioiTinhtemp.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            lblChucVuTemp.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "MACV", true, DataSourceUpdateMode.Never));
        }
        /// <summary>
        /// Load danh sach chuc vu vao cb
        /// </summary>
        /// <param name="cb"></param>
        void loadChucVutoCB(ComboBox cb)
        {
            cb.DataSource = busChucVu.Instance.LayDanhSachChucVu();
        }
        /// <summary>
        /// gán danh sách nhân viên vào dtgv
        /// </summary>
        /// <param name="list"></param>
        void loadNhanVien(List<dtoNhanVien> list)
        {
            NhanVienSource.DataSource = list;
            dtgvNhanVien.Columns["MANV"].HeaderText = "Mã nhân viên";
            dtgvNhanVien.Columns["TenNV"].HeaderText = "Họ tên";
            dtgvNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dtgvNhanVien.Columns["GioiTinh"].Visible = false;
            dtgvNhanVien.Columns["NgaySinh"].Visible = false;
            dtgvNhanVien.Columns["DiaChi"].Visible = false;
            dtgvNhanVien.Columns["MatKhauDangNhap"].Visible = false;
            dtgvNhanVien.Columns["MACV"].Visible = false;
        }
        #endregion

        #region event
        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNHanVienTemp.Text)) return;
            if (MessageBox.Show("Cập nhật " + lblNHanVienTemp.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string MANV = lblNHanVienTemp.Text;
            string TenNV = Cons.xoakhoangtrang(txbHoTen.Text);
            int GioiTinh = rdNam.Checked == true ? 1 : 0;
            DateTime NgaySinh = dtpkNgaySinh.Value;
            string DiaChi = Cons.xoakhoangtrang(txbDiachi.Text);
            string SDT = Cons.xoakhoangtrang(txbSDT.Text);
            string MACV = ((dtoChucVu)cbChucVu.SelectedItem).MACV;
            if (!busNhanVien.Instance.updateNhanVien(MANV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi, MACV))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật " + lblNHanVienTemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadNhanVien(busNhanVien.Instance.LayTatCaNHANVIEN());
            return;
        }
        /// <summary>
        /// Tim theo tên nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXem_Click(object sender, EventArgs e)
        {
            string TenNV = Cons.xoakhoangtrang(txbTenNV.Text);
            loadNhanVien(busNhanVien.Instance.LayTheoTenNHANVIEN(TenNV));
        }
        /// <summary>
        /// Khong cho nhan enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnXem_Click(this, new EventArgs());
            }
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
        /// binding chuc vu vao control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChucVuTemp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblChucVuTemp.Text)) return;
            foreach (dtoChucVu item in cbChucVu.Items)
            {
                if(item.MACV==lblChucVuTemp.Text)
                {
                    cbChucVu.SelectedItem = item;
                }
            }
        }
        /// <summary>
        /// Bingding gioi tinh vao control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblGioiTinhtemp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblGioiTinhtemp.Text)) return;
            switch (lblGioiTinhtemp.Text)
            {
                case "1":
                    rdNam.Checked = true;
                    break;
                default:
                    rdNu.Checked = true;
                    break;

            }
        }
        /// <summary>
        /// Dat lai mật khẩu cho nhân viên, bass mật định là 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNHanVienTemp.Text)) return;
            if (MessageBox.Show("Đặt lại mật khẩu cho nhân viên " + lblNHanVienTemp.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string MK = Cons.hasPass("1");
            if (!busNhanVien.Instance.updateNhanVien(lblNHanVienTemp.Text, MK))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật mật khẩu " + lblNHanVienTemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadNhanVien(busNhanVien.Instance.LayTatCaNHANVIEN());
            return;
        }
        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNHanVienTemp.Text)) return;
            if (MessageBox.Show("Xóa " + lblNHanVienTemp.Text + " và tất cả thông tin liên quan ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (!busNhanVien.Instance.xoaNhanVien(lblNHanVienTemp.Text))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + lblNHanVienTemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadNhanVien(busNhanVien.Instance.LayTatCaNHANVIEN());
            return;
        }
        /// <summary>
        /// Thực hiện thêm mới nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MANV = Cons.xoakhoangtrang(txbMANV.Text);
            if (string.IsNullOrEmpty(MANV)) return;
            if (MessageBox.Show("Thêm " + MANV + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string TenNV = Cons.xoakhoangtrang(txbHoTen.Text);
            int GioiTinh = rdNam.Checked == true ? 1 : 0;
            DateTime NgaySinh = dtpkNgaySinh.Value;
            string DiaChi = Cons.xoakhoangtrang(txbDiachi.Text);
            string SDT = Cons.xoakhoangtrang(txbSDT.Text);
            string MACV = ((dtoChucVu)cbChucVu.SelectedItem).MACV;
            string MatKhau = Cons.hasPass("1");
            if (!busNhanVien.Instance.themNhanVien(MANV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi, MatKhau, MACV))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm " + MANV + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadNhanVien(busNhanVien.Instance.LayTatCaNHANVIEN());
            return;
        }
        #endregion

    }
}
