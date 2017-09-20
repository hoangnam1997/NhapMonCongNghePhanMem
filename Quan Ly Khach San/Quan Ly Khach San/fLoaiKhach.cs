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
    public partial class fLoaiKhach : Form
    {
        /// <summary>
        /// hàm khỏi tạo
        /// </summary>
        public fLoaiKhach()
        {
            InitializeComponent();
            dtgvLoaiKhach.DataSource = LoaiKhachSource;
            loadLoaiKhach(busQuocTich.Instance.layTatCaQuocTich());
            loadBinDing();
        }
        #region properties
        BindingSource LoaiKhachSource = new BindingSource();
        #endregion
        #region method
        /// <summary>
        /// thực hiện load binding thay đổi thog tin các controls khi thay đổi selected item in dtgv
        /// </summary>
        void loadBinDing()
        {
            txbMAL.DataBindings.Add(new Binding("Text", dtgvLoaiKhach.DataSource, "MAQT", true, DataSourceUpdateMode.Never));
            lblLoaitemp.DataBindings.Add(new Binding("Text", dtgvLoaiKhach.DataSource, "MAQT", true, DataSourceUpdateMode.Never));
            txbTen.DataBindings.Add(new Binding("Text", dtgvLoaiKhach.DataSource, "TenNuoc", true, DataSourceUpdateMode.Never));
        }
        /// <summary>
        /// gán list loại khách vào dtgv
        /// </summary>
        /// <param name="list"></param>
        void loadLoaiKhach(List<dtoQuocTich> list)
        {
            LoaiKhachSource.DataSource = list;
            dtgvLoaiKhach.Columns["MAQT"].HeaderText = "Mã nước";
            dtgvLoaiKhach.Columns["TenNuoc"].HeaderText = "Tên nước";
        }
        #endregion

        #region event
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
        /// Lấy danh sách theo tên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            string Ten = Cons.xoakhoangtrang(txbTim.Text);
            loadLoaiKhach(busQuocTich.Instance.layTheoTenQuocTich(Ten));
        }
        /// <summary>
        /// Xóa Loại khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MAL = lblLoaitemp.Text;
            if (string.IsNullOrEmpty(MAL)) return;
            if (MessageBox.Show("Xóa " + MAL + " và tất cả khách liên quan? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if(!busQuocTich.Instance.xoaQuocTich(MAL))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            MessageBox.Show("Xóa "+ MAL+" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadLoaiKhach(busQuocTich.Instance.layTatCaQuocTich());
        }
        /// <summary>
        /// Cập nhật thông tin loại khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MAL = lblLoaitemp.Text;
            if (string.IsNullOrEmpty(MAL)) return;
            string Ten = Cons.xoakhoangtrang(txbTen.Text);
            if (MessageBox.Show("Cập nhật " + MAL + " ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (!busQuocTich.Instance.CapnhatQuocTich(MAL, Ten))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + MAL + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadLoaiKhach(busQuocTich.Instance.layTatCaQuocTich());
        }
        /// <summary>
        /// Thực hiện thêm mới loại khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MAL = Cons.xoakhoangtrang(txbMAL.Text);
            if (string.IsNullOrEmpty(MAL))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Ten = Cons.xoakhoangtrang(txbTen.Text);
            if (MessageBox.Show("Thêm " + MAL + " ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (!busQuocTich.Instance.themQuocTich(MAL, Ten))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm " + MAL + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadLoaiKhach(busQuocTich.Instance.layTatCaQuocTich());
        }
        /// <summary>
        /// Khong cho nhap enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTim_Click(this, new EventArgs());
            }
        }
        #endregion

    }
}
