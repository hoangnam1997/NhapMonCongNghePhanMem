using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San
{
    public partial class fDanhMucPhong : Form
    {
        /// <summary>
        /// hàm khỏi tạo
        /// </summary>
        public fDanhMucPhong()
        {
            InitializeComponent();
            LoadLoaiPhong(cbLoaiPhong);
            LoadLoaiPhong(cbLoai);
            loadDSPhong(busPhong.Instance.LayTatCaPhong());
            LoadCBTrangThai(cbTinhTrang);
        }
        #region properties
        #endregion
        #region method
        /// <summary>
        /// reset. xóa các controls trỏ về ban đầu
        /// </summary>
        void Clear()
        {
            txbMaP.Text = "";
            txbKhachToiDa.Text = "";
            txbGhiChu.Text = "";
            pnlThongTin.Tag = null;
            txbTenPhong.Text = "";
        }
        /// <summary>
        /// Lấy tât cả loại phòng vào cb
        /// </summary>
        void LoadLoaiPhong(ComboBox cb)
        {
            cb.DataSource = busLoaiPhong.Instance.LayTatCaLoaiPhong();
        }
        /// <summary>
        /// Lấy danh sách phòng vào dtgv theo list
        /// </summary>
        /// <param name="list"></param>
        void loadDSPhong(List<dtoPhong> list)
        {

            fpnlDSPhong.Controls.Clear();
            foreach (dtoPhong item in list)
            {
                Button btn = new Button();
                btn.Tag = item;
                btn.Width = 100;
                btn.Height = 100;
                switch (item.TinhTrang)
                {
                    case 0:
                        btn.BackColor = Cons.mauPhongTrong;
                        break;
                    case 1:
                        btn.BackColor = Cons.mauPhongCoNguoi;
                        break;
                }

                btn.Text = item.MAP;
                btn.Click += Btn_Click; ;
                fpnlDSPhong.Controls.Add(btn);
            }

        }
        /// <summary>
        /// Load list thiét bị vào dtgv
        /// </summary>
        /// <param name="list"></param>
        void loadThietBi(List<dtoCTPTB> list)
        {
            dtgvThietBi.DataSource = list;
            dtgvThietBi.Columns["MATB"].HeaderText = "Mã thiết bị";
            dtgvThietBi.Columns["TenTB"].HeaderText = "Tên";
            dtgvThietBi.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvThietBi.Columns["MALP"].Visible = false;
        }
        #endregion

        #region event
        /// <summary>
        /// Chi cho nhap so
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbKhachToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// ánh xạ phòng theo mục loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiPhong.SelectedItem == null) return;
            dtoLoaiPhong loaiP = (dtoLoaiPhong)cbLoaiPhong.SelectedItem;
            loadDSPhong(busPhong.Instance.LayTheoTrangThaivaMaLoaiPhong(loaiP.MALP, -1));
            Clear();
        }
        /// <summary>
        /// Load TrangThai và cb
        /// </summary>
        /// <param name="cbTrangThai"></param>
        void LoadCBTrangThai(ComboBox cbTrangThai)
        {
            List<TrangThaiPhongdto> listTrangThai = new List<TrangThaiPhongdto>();
            listTrangThai.Add(new TrangThaiPhongdto(0, "Trống"));
            listTrangThai.Add(new TrangThaiPhongdto(1, "Đã có khách"));
            cbTrangThai.DataSource = listTrangThai;
        }
        /// <summary>
        /// Ánh xạ thông tin phòng click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            dtoPhong Phong = (dtoPhong)btn.Tag;
            pnlThongTin.Tag = Phong;
            txbMaP.Text = Phong.MAP;
            txbKhachToiDa.Text = Phong.SoKhachToiDa.ToString();
            txbGhiChu.Text = Phong.GhiChu;
            txbTenPhong.Text = Phong.TenPhong;
            foreach (TrangThaiPhongdto item in cbTinhTrang.Items)
            {
                if (Phong.TinhTrang == item.Matrangthai)
                {
                    cbTinhTrang.SelectedItem = item;
                    break;
                }
            }
            foreach (dtoLoaiPhong item in cbLoai.Items)
            {
                if (Phong.MALP == item.MALP)
                {
                    cbLoai.SelectedItem = item;
                    break;
                }
            }

        }
        /// <summary>
        /// ánh xạ giá và thông tin thiết bị của loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoai.SelectedItem == null) return;
            dtoLoaiPhong loaiP = (dtoLoaiPhong)cbLoai.SelectedItem;
            CultureInfo culture = new CultureInfo("vi-VN");
            txbGia.Text = loaiP.Gia.ToString("c", culture);
            loadThietBi(busCTPTB.Instance.LayCTPTBtheoLoaiPhong(loaiP.MALP));
        }
        /// <summary>
        /// xóa phòng, thựch hiên xóa phòng đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (pnlThongTin.Tag == null) return;
            dtoPhong Phong = (dtoPhong)pnlThongTin.Tag;
            if (MessageBox.Show("Xóa phòng " + Phong.MAP + " sẽ xóa tất cả thông tin liên quan ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if (!busPhong.Instance.xoaPhong(Phong.MAP))
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbLoaiPhong_SelectedIndexChanged(this, new EventArgs());
        }
        /// <summary>
        /// Cập nhật thông tin phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (pnlThongTin.Tag == null) return;
            dtoPhong Phong = (dtoPhong)pnlThongTin.Tag;
            if (MessageBox.Show("Cập nhật thông tin phòng " + Phong.MAP + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            Phong.GhiChu = Cons.xoakhoangtrang(txbGhiChu.Text);
            Phong.MALP = ((dtoLoaiPhong)cbLoai.SelectedItem).MALP;
           
            int SL=0;
            int.TryParse(txbKhachToiDa.Text,out SL);
            Phong.SoKhachToiDa = SL;
            Phong.TenPhong = Cons.xoakhoangtrang(txbTenPhong.Text);
            Phong.TinhTrang = ((TrangThaiPhongdto)cbTinhTrang.SelectedItem).Matrangthai;
            if (!busPhong.Instance.capNhatThongTinPhong(Phong.MAP, Phong.TenPhong, Phong.TinhTrang, Phong.GhiChu, Phong.SoKhachToiDa, Phong.MALP))
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbLoaiPhong_SelectedIndexChanged(this, new EventArgs());
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
        /// Thêm mới phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cons.xoakhoangtrang(txbMaP.Text)))
            {
                MessageBox.Show("Vui lòng nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            dtoPhong Phong = new dtoPhong();
            Phong.MAP = Cons.xoakhoangtrang(txbMaP.Text);
            if (MessageBox.Show("Thêm " + Phong.MAP + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            Phong.GhiChu = Cons.xoakhoangtrang(txbGhiChu.Text);
            Phong.MALP = ((dtoLoaiPhong)cbLoai.SelectedItem).MALP;
            int SL = 0;
            int.TryParse(txbKhachToiDa.Text, out SL);
            Phong.SoKhachToiDa = SL;
            Phong.TenPhong = Cons.xoakhoangtrang(txbTenPhong.Text);
            Phong.TinhTrang = ((TrangThaiPhongdto)cbTinhTrang.SelectedItem).Matrangthai;
            if (!busPhong.Instance.themPhong(Phong.MAP, Phong.TenPhong, Phong.TinhTrang, Phong.GhiChu, Phong.SoKhachToiDa, Phong.MALP))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbLoaiPhong_SelectedIndexChanged(this, new EventArgs());
        }
        #endregion
        
    }
}
