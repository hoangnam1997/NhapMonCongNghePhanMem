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
    public partial class fThongTin_TraPhong : Form
    {
        /// <summary>
        /// Hàm khỏi tạo
        /// </summary>
        /// <param name="Phong"></param>
        /// <param name="NhanVien"></param>
        public fThongTin_TraPhong(dtoPhong Phong,dtoNhanVien NhanVien)
        {
            InitializeComponent();
            this.Phong = Phong;
            this.NhanVienLogin = NhanVien;
            loadThongTinPhong(Phong);
        }
        #region properties
        private dtoNhanVien NhanVienLogin;
        private double TongNgay=0;
        private double TongTien=0;
        private dtoPhieuDangKy PhieuDangKy = null;
        private dtoPhong Phong;
        #endregion
        #region method
        /// <summary>
        /// Load các thông tin trả phòng của phòng được truyền vào form
        /// </summary>
        /// <param name="Phong"></param>
        void loadThongTinPhong(dtoPhong Phong)
        {
            dtoThamSo ThamSo = busThamSo.Instance.layThamSo();
            //Thông tin phiếu đăng ký
            if (Phong == null) return;
            List<dtoPhieuDangKy> listphieudk = busPhieuDangKy.Instance.LayTheoMAPdanhSachDaDenPhieuDangKy(Phong.MAP);
            if (listphieudk.Count <= 0) return;
            PhieuDangKy = listphieudk.ToArray()[0];
            dtpkThoiGianBatDau.Value = PhieuDangKy.ThoiGianDen;
            dtpkThoiGianKetThuc.Value = PhieuDangKy.ThoiGianDi;
            //Thông tin khách hàng
            List<dtoCTPDK> dskhach = busCTPDK.Instance.LayDanhSachChuaDenTheoPhongCTPDK(PhieuDangKy.MAPDK, Phong.MAP);
            List<dtoKhachHang> dsKhachHang = new List<dtoKhachHang>(); ;
            foreach (dtoCTPDK item in dskhach)
            {
                dsKhachHang.Add(busKhachHang.Instance.LayTheoCMNDKhachHang(item.CMND));
            }
            dtgvDanhSachKhachThue.DataSource = dsKhachHang;
            dtgvDanhSachKhachThue.Columns["TenKhachHang"].HeaderText="Tên khách hàng";
            dtgvDanhSachKhachThue.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvDanhSachKhachThue.Columns["DiaChi"].Visible = false;
            dtgvDanhSachKhachThue.Columns["GioiTinh"].Visible = false;
            //thông tin số ngày ở và số tièn phải trả
            DateTime dateNow = DateTime.Now;
            TimeSpan timeDaO = dateNow.Subtract(PhieuDangKy.ThoiGianDen);
            TongNgay = timeDaO.TotalDays;
            if (TongNgay <= 0) TongNgay = 0;
            txbTongNgayThue.Text = string.Format("{0:0.##}",TongNgay);

            bool isKhachNuocNgoai = false;
            foreach (dtoKhachHang item in dsKhachHang)
            {
                if(item.MAQT!="Vi")
                {
                    isKhachNuocNgoai = true;
                    break;
                }
            }
            dtoLoaiPhong LoaiPhong = busLoaiPhong.Instance.LayLoaiPhongMALP(Phong.MALP);
            if(isKhachNuocNgoai)
            {
                if(dsKhachHang.Count>=3)
                {
                    TongTien = LoaiPhong.Gia * TongNgay * ThamSo.TyLePhuThuKhachNuocNgoai;
                    TongTien += TongTien * ThamSo.TyLePhuThuKhachThu3 / 100;
                }
                else
                {
                    TongTien = LoaiPhong.Gia * TongNgay * ThamSo.TyLePhuThuKhachNuocNgoai;
                }
            }
            else
            {
                if (dsKhachHang.Count >= 3)
                {
                    TongTien = LoaiPhong.Gia * TongNgay ;
                    TongTien += TongTien * ThamSo.TyLePhuThuKhachThu3 / 100;
                }
                else
                {
                    TongTien = LoaiPhong.Gia * TongNgay;
                }
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            
            if (TongTien <= 0) TongTien = 0;
            txbTongTien.Text =  TongTien.ToString("c",culture);
        }
        #endregion

        #region event
        /// <summary>
        /// Thoát form thongtin_traphong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Trả phòng cho hóa đơn. thực hiện chức năng trả phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            
            CultureInfo culture = new CultureInfo("vi-VN");
            if (PhieuDangKy == null) return;
            
            if (MessageBox.Show("Thanh toán hóa đơn với "+ TongTien.ToString("c", culture), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            string MAHD = Cons.Random(10);
            if(!(busHoaDon.Instance.insertHoaDon(MAHD, PhieuDangKy.MAPDK, NhanVienLogin.MANV, TongNgay, DateTime.Now, TongTien, Phong.MAP)
                &&(busPhieuDangKy.Instance.updatePhieuDangKy(Phong.MAP,PhieuDangKy.MAPDK,PhieuDangKy.ThoiGianDen,DateTime.Now))))
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn in hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                crHoaDonTraPhong crhoaDon = new crHoaDonTraPhong();
                crhoaDon.SetDataSource(busHoaDon.Instance.LayThongTinHoaDon(MAHD));
                fReport f = new fReport(crhoaDon);
                f.ShowDialog();
            }
            this.Close();
        }
        /// <summary>
        /// Cập nhật thời gian đi của phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (PhieuDangKy == null) return;

            if (!busPhieuDangKy.Instance.updatePhieuDangKy(Phong.MAP, PhieuDangKy.MAPDK, PhieuDangKy.ThoiGianDen, dtpkThoiGianKetThuc.Value))
            {
                MessageBox.Show("Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Câp nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

    }
}
