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
    public partial class fDatPhong : Form
    {
        /// <summary>
        /// hàm khỏi tạo đặt phòng
        /// </summary>
        /// <param name="NhanVienlogin"></param>
        public fDatPhong(dtoNhanVien NhanVienlogin)
        {
            InitializeComponent();
            this.nhanvienlogin = NhanVienlogin;
            List<dtoPhong> listPhong = busPhong.Instance.LayTatCaPhong();
            loadDSPhong(listPhong);
            loadLoaiPhongToCB(cbLoaiPhong);
            loadThongTinKhach(KhachHangSource);
        }
        #region properties
        private List<dtoKhachHang> KhachHangSource = new List<dtoKhachHang>();
        dtoNhanVien nhanvienlogin;
        #endregion
        #region method
        /// <summary>
        /// Lay danh sach tat ca phong thêm vào controls
        /// </summary>
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
                btn.Click += Btn_Click;
                fpnlDSPhong.Controls.Add(btn);
            }

        }
        /// <summary>
        /// lấy danh sách loại phong đưa vào cb
        /// </summary>
        /// <param name="cb"></param>
        void loadLoaiPhongToCB(ComboBox cb)
        {
            cb.DataSource = busLoaiPhong.Instance.LayTatCaLoaiPhong();
        }
        /// <summary>
        /// Thêm vào dtgv thông tin các khách hàng thuê phòng
        /// </summary>
        /// <param name="result"></param>
        void loadThongTinKhach(List<dtoKhachHang> result)
        {
            KhachHangSource = result;
            dtgvThongTinKhach.DataSource = KhachHangSource;
            dtgvThongTinKhach.Refresh();
            dtgvThongTinKhach.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dtgvThongTinKhach.Columns["GioiTinh"].Visible = false;
            dtgvThongTinKhach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvThongTinKhach.Columns["DiaChi"].Visible = false;
            dtgvThongTinKhach.Columns["MAQT"].Visible = false;
        }
        #endregion
        #region event
        /// <summary>
        /// Load danh sach phogn theo loai phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtoLoaiPhong loaiPhong = (dtoLoaiPhong)cbLoaiPhong.SelectedItem;
            loadDSPhong(busPhong.Instance.LayTheoTrangThaivaMaLoaiPhong(loaiPhong.MALP, -1));
            loadThongTinKhach(new List<dtoKhachHang>());
            cbMAPDK.DataSource = null;
        }
        /// <summary>
        /// Thêm khách vào phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbMAPDK.SelectedItem == null) return;
            dtoPhong Phong = (dtoPhong)pnlThongTin.Tag;
            if (KhachHangSource.Count >= Phong.SoKhachToiDa)
            {
                MessageBox.Show("Số khách đã đạt tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            fThemKhachHang f = new fThemKhachHang();
            f.sentKhachHang += F_sentKhachHang;
            f.ShowDialog();
        }
        /// <summary>
        /// Thực hiện thêm khách hàng vào dtgv nếu có sự kiên trả về từ form thêm khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_sentKhachHang(object sender, KhachHangevent e)
        {
            dtoPhong Phong = (dtoPhong)pnlThongTin.Tag;
            if (KhachHangSource.Count >= Phong.SoKhachToiDa)
            {
                MessageBox.Show("Số khách đã đạt tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            List<dtoKhachHang> Listnew = new List<dtoKhachHang>();
            foreach (dtoKhachHang item in KhachHangSource)
            {
                if (item.CMND == e.Result.CMND)
                    return;
                Listnew.Add(item);
            }
            Listnew.Add(e.Result);
            loadThongTinKhach(Listnew);
        }

        /// <summary>
        /// Hiển thị thông tin phòng chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            dtoPhong PhongClick = (dtoPhong)(sender as Button).Tag;
            loadThongTinKhach(new List<dtoKhachHang>());
            pnlThongTin.Tag = PhongClick;
            List<dtoPhieuDangKy> result = busPhieuDangKy.Instance.LayTheoMAPdanhSachChuaDenPhieuDangKy(PhongClick.MAP);
            cbMAPDK.DataSource = result;
        }
        /// <summary>
        /// Thêm phiểu đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemMoiPhieuDangKy f = new fThemMoiPhieuDangKy(this.nhanvienlogin);
            f.ShowDialog();

            loadDSPhong(busPhong.Instance.LayTatCaPhong());
        }
        /// <summary>
        /// Khi thay đổi sẽ thay đổi thông tin khách đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMAPDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMAPDK.SelectedItem == null) return;
            dtoPhieuDangKy phieuDangKy = (dtoPhieuDangKy)(cbMAPDK.SelectedItem);
            dtpkThoiGianDen.Value = phieuDangKy.ThoiGianDen;
            dtpkDuKhienTraPhong.Value = phieuDangKy.ThoiGianDi;
            List<dtoCTPDK> listCTPDK = busCTPDK.Instance.LayDanhSachChuaDenTheoPhongCTPDK(phieuDangKy.MAPDK, ((dtoPhong)pnlThongTin.Tag).MAP);
            List<dtoKhachHang> listKhachHang = new List<dtoKhachHang>();
            foreach (dtoCTPDK item in listCTPDK)
            {
                listKhachHang.Add(busKhachHang.Instance.LayTheoCMNDKhachHang(item.CMND));
            }
            loadThongTinKhach(listKhachHang);

        }
        /// <summary>
        /// xÓA KHÁCH ĐANG CHỌN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvThongTinKhach.SelectedCells.Count <= 0) return;
            List<dtoKhachHang> listNew = new List<dtoKhachHang>();
            string cmnd = (string)dtgvThongTinKhach.SelectedCells[0].OwningRow.Cells["CMND"].Value;
            foreach (dtoKhachHang item in KhachHangSource)
            {
                if (item.CMND == cmnd)
                    continue;
                listNew.Add(item);
            }
            loadThongTinKhach(listNew);
        }
        /// <summary>
        /// Cập nhật lại thông tin đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cbMAPDK.SelectedItem == null) return;
            dtoPhieuDangKy phieuDangKy = (dtoPhieuDangKy)cbMAPDK.SelectedItem;
            dtoPhong phong = (dtoPhong)pnlThongTin.Tag;
            if(KhachHangSource.Count<=0)
            {
                MessageBox.Show("Phòng phải có ít nhất một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!busPhieuDangKy.Instance.updatePhieuDangKy(phong.MAP, phieuDangKy.MAPDK, dtpkThoiGianDen.Value, dtpkDuKhienTraPhong.Value))
            {
                MessageBox.Show("Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!busCTPDK.Instance.xoaCTPDK(phieuDangKy.MAPDK, phong.MAP))
            {
                MessageBox.Show("Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (dtoKhachHang item in KhachHangSource)
            {
                if (!busCTPDK.Instance.themCTPDK(item.CMND, phieuDangKy.MAPDK, phong.MAP))
                {
                    MessageBox.Show("Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        /// <summary>
        /// Xác định khách hàng đã đến nhận phòng 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDaDen_Click(object sender, EventArgs e)
        {
            if (cbMAPDK.SelectedItem == null) return;
            if(((dtoPhong)pnlThongTin.Tag).TinhTrang==1)
            {
                MessageBox.Show("Phòng đang có khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtoPhieuDangKy phieudk = (dtoPhieuDangKy)cbMAPDK.SelectedItem;
            if (!busPhieuDangKy.Instance.updateDaDenPhieuDangKy(phieudk.MAPDK))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDSPhong(busPhong.Instance.LayTatCaPhong());
            loadThongTinKhach(new List<dtoKhachHang>());
            cbMAPDK.DataSource = null;


        }
        /// <summary>
        /// Thoát khỏi màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Hủy bỏ phiếu đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (cbMAPDK.SelectedItem == null) return;
            dtoPhieuDangKy phieudk = (dtoPhieuDangKy)cbMAPDK.SelectedItem;
            if (MessageBox.Show(string.Format("Bạn muốn xóa bỏ hóa đơn {0}!",phieudk.MAPDK), "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel) return;
            if(!busPhieuDangKy.Instance.deletePhieuDangKy(phieudk.MAPDK))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDSPhong(busPhong.Instance.LayTatCaPhong());
            loadThongTinKhach(new List<dtoKhachHang>());
            cbMAPDK.DataSource = null;
        }
        #endregion
        
    }
}
