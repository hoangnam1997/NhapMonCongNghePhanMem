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
    public partial class fTrangThietBi : Form
    {
        public fTrangThietBi()
        {
            InitializeComponent();
            loadPhong(new List<dtoPhong>());
            dtgvTrangThietBi.DataSource = ThietBiSource;
            LoadThietbi(busThietBi.Instance.LayTatCaThietBi());
            addBinDing();
        }
        #region properyies
        BindingSource ThietBiSource = new BindingSource();
        #endregion
        #region method
        /// <summary>
        /// Add bindings thay đổi khi chọn items tren datagridview
        /// </summary>
        void addBinDing()
        {
            txbMaThietBi.DataBindings.Add(new Binding("Text", dtgvTrangThietBi.DataSource, "MATB", true, DataSourceUpdateMode.Never));
            lblTemp.DataBindings.Add(new Binding("Text", dtgvTrangThietBi.DataSource, "MATB", true, DataSourceUpdateMode.Never));
            txbTenThietBi.DataBindings.Add(new Binding("Text", dtgvTrangThietBi.DataSource, "TenTB", true, DataSourceUpdateMode.Never));
        }
        /// <summary>
        /// Gan danh sach thiet bi vao dtgv
        /// </summary>
        /// <param name="list"></param>
        void LoadThietbi(List<dtoThietBi> list)
        {
            ThietBiSource.DataSource = list;
            dtgvTrangThietBi.Columns["MATB"].HeaderText = "Mã thiết bị";
            dtgvTrangThietBi.Columns["TenTB"].HeaderText = "Tên";
        }
        /// <summary>
        /// gan danh sach phong vao dtgv
        /// </summary>
        void loadPhong(List<dtoPhong> list)
        {
            dtgvDsPhong.DataSource = list;
            dtgvDsPhong.Columns["MAP"].HeaderText = "Mã phòng";
            dtgvDsPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            dtgvDsPhong.Columns["TinhTrang"].Visible = false;
            dtgvDsPhong.Columns["GhiChu"].Visible = false;
            dtgvDsPhong.Columns["soKhachToiDa"].Visible = false;
            dtgvDsPhong.Columns["MaLP"].Visible = false;
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
        /// Lấy thông tin các phong đặt thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTemp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                loadPhong(new List<dtoPhong>());
                return;
            }
            loadPhong(busPhong.Instance.LayTheoThietBiCoTrongPhong(lblTemp.Text));
        }
        /// <summary>
        /// Tìm kiếm thiết bị theo tên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            string TenTB = Cons.xoakhoangtrang(txbTim.Text);
            LoadThietbi(busThietBi.Instance.LayTheoTenThietBi(TenTB));
        }
        /// <summary>
        /// Xóa thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTemp.Text)) return;
            if (!busThietBi.Instance.xoaThietBi(lblTemp.Text))
            {
                MessageBox.Show("vui long thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + lblTemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadThietbi(busThietBi.Instance.LayTatCaThietBi());

        }
        /// <summary>
        /// Cập nhật thông tin thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string TenTB = Cons.xoakhoangtrang(txbTenThietBi.Text);
            if(!busThietBi.Instance.capNhatThietBi(lblTemp.Text,TenTB))
            {
                MessageBox.Show("vui long thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật " + lblTemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadThietbi(busThietBi.Instance.LayTatCaThietBi());
        }
        /// <summary>
        /// Thực hiện thêm mới thiết bị.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MATB = Cons.xoakhoangtrang(txbMaThietBi.Text);
            if (string.IsNullOrEmpty(MATB))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            string TenTB = Cons.xoakhoangtrang(txbTenThietBi.Text);
            if (!busThietBi.Instance.themThietBi(MATB, TenTB))
            {
                MessageBox.Show("vui long thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm " + MATB + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadThietbi(busThietBi.Instance.LayTatCaThietBi());
            
        }
        /// <summary>
        /// Khong cho nhap enter ở txbTim và gọi sự kiện click
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
