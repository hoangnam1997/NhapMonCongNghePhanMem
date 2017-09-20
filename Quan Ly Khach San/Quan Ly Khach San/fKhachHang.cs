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
    public partial class fKhachHang : Form
    {
        /// <summary>
        /// hàm khỏi tạo form khách hàng
        /// </summary>
        public fKhachHang()
        {
            InitializeComponent();
            dtgvKhachHang.DataSource = KhachHangSource;
            loadLoaiKhachToCB(cbLoai);
            loadKhachHang(busKhachHang.Instance.LayTatCaKhachHang());
            loadBinding();
        }
        #region properties 
        BindingSource KhachHangSource = new BindingSource();
        #endregion
        #region Method
        /// <summary>
        /// lấy danh sách loiạ khách hàng gán vào dtgv
        /// </summary>
        /// <param name="cb"></param>
        void loadLoaiKhachToCB(ComboBox cb)
        {
            cb.DataSource = busQuocTich.Instance.layTatCaQuocTich();
        }
        /// <summary>
        /// ánh xạ qua các control khi thay đổi click item in dtgv
        /// </summary>
        void loadBinding()
        {
            txbCMND.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            lblTemp.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "TenKhachHang", true, DataSourceUpdateMode.Never));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbSDt.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never));
            lblGioiTinhTemp.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            lblLoaiKhachTemp.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "MAQT", true, DataSourceUpdateMode.Never));
        }
        /// <summary>
        /// Lay danh sach khach hang gan vao dtgv
        /// </summary>
        /// <param name="list"></param>
        void loadKhachHang(List<dtoKhachHang> list)
        {
            KhachHangSource.DataSource = list;
            dtgvKhachHang.Columns["CMND"].HeaderText = "Chứng minh nhân dân";
            dtgvKhachHang.Columns["TenKhachHang"].HeaderText = "Họ tên";
            dtgvKhachHang.Columns["GioiTinh"].Visible = false;
            dtgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvKhachHang.Columns["DiaChi"].Visible =false;
            dtgvKhachHang.Columns["MAQT"].Visible = false;
        }

        #endregion

        #region event
        /// <summary>
        /// Xuat file excel danh sach khach hang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            DataTable dsKhach = busKhachHang.Instance.LayTatCaKhachHangDataTable();
            dsKhach.Columns["CMND"].ColumnName = "Chứng minh nhân dân";
            dsKhach.Columns["TenKhachHang"].ColumnName = "Họ tên";
            dsKhach.Columns["GioiTinh"].ColumnName = "Giới tính";
            dsKhach.Columns["SoDienThoai"].ColumnName = "Số điện thoại";
            dsKhach.Columns["DiaChi"].ColumnName = "Địa chỉ";
            dsKhach.Columns["MAQT"].ColumnName = "Quốc tịch";
            Cons.exportDataToExcel("DANH SÁCH KHÁCH HÀNG", dsKhach);
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
        /// Không cho nhập enter và ấn nút tìm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTim_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTim_Click(this, new EventArgs());
            }
        }
        /// <summary>
        /// Tim khach hàng theo tên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = Cons.xoakhoangtrang(txbTim.Text);
            loadKhachHang(busKhachHang.Instance.LayTheoTenKhachHang(ten));
        }
        /// <summary>
        /// ánh xạ loại khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLoaiKhachTemp_TextChanged(object sender, EventArgs e)
        {
            foreach (dtoQuocTich item in cbLoai.Items)
            {
                if(item.MAQT==lblLoaiKhachTemp.Text)
                {
                    cbLoai.SelectedItem = item;
                    return;
                }
            }
        }
        /// <summary>
        /// anh xạ giới tính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblGioiTinhTemp_TextChanged(object sender, EventArgs e)
        {
            switch(lblGioiTinhTemp.Text)
            {
                case "0":
                    rdNu.Checked = true;
                    break;
                default:
                    rdNam.Checked = true;
                    break;
            }
        }
        /// <summary>
        /// Xóa khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string CMND = lblTemp.Text;
            if (string.IsNullOrEmpty(CMND)) return;
            if (MessageBox.Show("Xóa " + CMND + " và thông tin liên quan ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if(!busKhachHang.Instance.xoaKhachHang(CMND))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + CMND + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadKhachHang(busKhachHang.Instance.LayTatCaKhachHang());
        }
        /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string CMND = Cons.xoakhoangtrang(lblTemp.Text);
            if (string.IsNullOrEmpty(CMND))
            {
                return;
            }
            if (MessageBox.Show("Cập nhật " + CMND +" ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string TenKhachHang = Cons.xoakhoangtrang(txbHoTen.Text);
            int gioiTinh = rdNam.Checked == true ? 1 : 0;

            string DiaChi = Cons.xoakhoangtrang(txbDiaChi.Text);
            string SDT = Cons.xoakhoangtrang(txbSDt.Text);
            string LoaiKhach = ((dtoQuocTich)cbLoai.SelectedItem).MAQT;
            if (!busKhachHang.Instance.capNhatKhachHang(CMND, TenKhachHang, gioiTinh, SDT, DiaChi, LoaiKhach))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật " + CMND + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadKhachHang(busKhachHang.Instance.LayTatCaKhachHang());
        }
        /// <summary>
        /// Thêm mới khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string CMND = Cons.xoakhoangtrang(txbCMND.Text);
            if(string.IsNullOrEmpty(CMND))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Thêm " + CMND + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string TenKhachHang = Cons.xoakhoangtrang(txbHoTen.Text);
            int gioiTinh = rdNam.Checked == true ? 1 : 0;

            string DiaChi = Cons.xoakhoangtrang(txbDiaChi.Text);
            string SDT = Cons.xoakhoangtrang(txbSDt.Text);
            string LoaiKhach = ((dtoQuocTich)cbLoai.SelectedItem).MAQT;
            if (!busKhachHang.Instance.themKhachHang(CMND,TenKhachHang,gioiTinh,SDT,DiaChi,LoaiKhach))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm " + CMND + " thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            loadKhachHang(busKhachHang.Instance.LayTatCaKhachHang());
        }
        #endregion

        

    }
}
