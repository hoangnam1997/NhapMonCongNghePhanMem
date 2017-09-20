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
    public partial class fManhinhChinh : Form
    {
        /// <summary>
        /// hàm khỏi tạo form
        /// </summary>
        /// <param name="nhanvien"></param>
        public fManhinhChinh(dtoNhanVien nhanvien)
        {
            InitializeComponent();
            this.NhanVienLogin = nhanvien;
            phanQuyenDangNhap(nhanvien);
        }
        #region Properties
        private dtoNhanVien NhanVienLogin;
        #endregion
        #region method
        /// <summary>
        /// hiệu ứng chuột rê ra
        /// </summary>
        /// <param name="ptb"></param>
        /// <param name="lbl"></param>
        void loadMouseLeave(PictureBox ptb,Label lbl,Panel pnl)
        {
            ptb.Width -= Cons.sizeLeave;
            ptb.Height -= Cons.sizeLeave;
            ptb.Location = new Point((pnl.Width - ptb.Width) / 2, ptb.Location.Y);
            lbl.ForeColor = Color.Black;
        }
        /// <summary>
        /// hiệu ứng chuột rê vào
        /// </summary>
        /// <param name="ptb"></param>
        /// <param name="lbl"></param>
        void loadMouseenter(PictureBox ptb, Label lbl, Panel pnl)
        {
            ptb.Width += Cons.sizeLeave;
            ptb.Height += Cons.sizeLeave;
            ptb.Location = new Point((pnl.Width - ptb.Width) / 2, ptb.Location.Y);
            //lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size + Cons.sizeoFont);
            lbl.ForeColor = Color.Blue;
        }
        /// <summary>
        /// Xác định tài khoản đăng nhập là ai
        /// </summary>
        void phanQuyenDangNhap(dtoNhanVien nhanvien)
        {
            switch (nhanvien.MACV)
            {
                case "ADMIN":
                    break;
                case "NHANVIEN":
                    tabControlMangHinhChinh.TabPages.Remove(tabPageQuanLy);
                    break;
            }
        }
        /// <summary>
        /// Lấy danh sách loại phòng
        /// </summary>
        /// <param name="cbLoai"></param>
        void LoadCBLoaiPhong(ComboBox cbLoai)
        {
            List<dtoLoaiPhong> listLoaiPhong = busLoaiPhong.Instance.LayTatCaLoaiPhong();
            cbLoai.DataSource = listLoaiPhong;
        }
       
        /// <summary>
        /// Tạo danh sách trạng thái phòng
        /// </summary>
        /// <param name="cbTrangThai"></param>
        void LoadCBTrangThai(ComboBox cbTrangThai)
        {
            List<TrangThaiPhongdto> listTrangThai = new List<TrangThaiPhongdto>();
            listTrangThai.Add(new TrangThaiPhongdto(-1, "Tất cả"));
            listTrangThai.Add(new TrangThaiPhongdto(0, "Trống"));
            listTrangThai.Add(new TrangThaiPhongdto(1, "Đã có khách"));
            cbTrangThai.DataSource = listTrangThai;
        }
        /// <summary>
        /// Load danh sach theo malp va tinh trang
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="TinhTrang"></param>
        List<dtoPhong> loadDSPhongtheoLoaivsTinhTrang(string MALP, int TinhTrang)
        {
            List<dtoPhong> result = new List<dtoPhong>();
            result = busPhong.Instance.LayTheoTrangThaivaMaLoaiPhong(MALP, TinhTrang);
            return result;
        }
        /// <summary>
        /// Lấy danh sách tất cả phòng gán vào controls
        /// </summary>
        void loadDSPhong()
        {
            fpnlDSPhong.Controls.Clear();
            List<dtoPhong> listPhong = busPhong.Instance.LayTatCaPhong();
            foreach (dtoPhong item in listPhong)
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
        /// load danh sách phog vs list gán vào controls
        /// </summary>
        /// <param name="list"></param>
        void loadDSPhong(List<dtoPhong>list)
        {
            fpnlDSPhong.Controls.Clear();
            foreach (dtoPhong item in list)
            {
                Button btn = new Button();
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
                btn.Tag = item;
                btn.Text = item.MAP;
                btn.Click += Btn_Click;
                fpnlDSPhong.Controls.Add(btn);
            }
        }
        /// <summary>
        /// thực hiện xem thông tin phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            fThongTin_TraPhong f = new fThongTin_TraPhong((dtoPhong)(sender as Button).Tag,NhanVienLogin);
            f.ShowDialog();
            loadDSPhong();
        }
        #endregion

        #region event
        /// <summary>
        /// xem danh sách phòng theo thông tin từ cb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbLoaiPhong.SelectedItem == null || cbTrangThai.SelectedItem == null) return;
            dtoLoaiPhong LP = ((dtoLoaiPhong)cbLoaiPhong.SelectedItem);
            TrangThaiPhongdto trangThai = ((TrangThaiPhongdto)cbTrangThai.SelectedItem);
            loadDSPhong(loadDSPhongtheoLoaivsTinhTrang(LP.MALP, trangThai.Matrangthai));

        }
        /// <summary>
        /// In hóa đơn, hiển thị form in hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbInHoaDon_Click(object sender, EventArgs e)
        {
            fInHoaDon f = new fInHoaDon();
            f.ShowDialog();
        }
        /// <summary>
        /// Đặt phòng trước
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbDatPhong_Click(object sender, EventArgs e)
        {
            fDatPhong f = new fDatPhong(NhanVienLogin);
            f.ShowDialog();
            loadDSPhong();
        }
        /// <summary>
        /// Thông tin tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbTaiKhoan_Click(object sender, EventArgs e)
        {
            
            fTaiKhoan f = new fTaiKhoan(busNhanVien.Instance.LayTheoMaNHANVIEN(this.NhanVienLogin.MANV));
            f.ShowDialog();
        }
        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Lập phòng, danh mục phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbDanhMucPhong_Click(object sender, EventArgs e)
        {
            fDanhMucPhong f = new fDanhMucPhong();
            f.ShowDialog();
            loadDSPhong();
        }
        /// <summary>
        /// Loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbLoaiPhong_Click(object sender, EventArgs e)
        {
            fLoaiPhong f = new fLoaiPhong();
            f.ShowDialog();
            loadDSPhong();
            LoadCBLoaiPhong(cbLoaiPhong);
        }
        /// <summary>
        /// Quản lý trang thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbTrangThietBi_Click(object sender, EventArgs e)
        {
            fTrangThietBi f = new fTrangThietBi();
            f.ShowDialog();
        }
        /// <summary>
        /// Quản lý thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            f.ShowDialog();
        }
        /// <summary>
        /// Thay đổi quy định
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbQuyDinh_Click(object sender, EventArgs e)
        {
            fQuyDinh f = new fQuyDinh();
            f.ShowDialog();
        }
        /// <summary>
        /// Báo cáo theo phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbBaoCaoPhong_Click(object sender, EventArgs e)
        {
            fBaoCao f = new fBaoCao(0);
            f.ShowDialog();
        }
        /// <summary>
        /// Báo cáo theo loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbBaoCaoLoaiPhong_Click(object sender, EventArgs e)
        {
            fBaoCao f = new fBaoCao(1);
            f.ShowDialog();
        }
        /// <summary>
        /// Thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            f.ShowDialog();
        }
        /// <summary>
        /// Thay đổi số lượng loại khách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptbLoaiKhach_Click(object sender, EventArgs e)
        {
            fLoaiKhach f = new fLoaiKhach();
            f.ShowDialog();
        }
        /// <summary>
        /// Load fomr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fManhinhChinh_Load(object sender, EventArgs e)
        {
            loadDSPhong();
            LoadCBLoaiPhong(cbLoaiPhong);
            LoadCBTrangThai(cbTrangThai);
        }
        /// <summary>
        /// Xem Tất cả loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            loadDSPhong();
        }
        #endregion
        #region setcolor
        private void ptbQuyDinh_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbQuyDinh, lblQuyDinh, pnlQuyDinh);
        }

        private void ptbQuyDinh_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbQuyDinh, lblQuyDinh, pnlQuyDinh);
        }
        private void ptbInHoaDon_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbInHoaDon, lblInHoaDon,pnlInHoaDon);
        }

        private void ptbInHoaDon_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbInHoaDon, lblInHoaDon,pnlInHoaDon);
        }

        private void ptbDatPhong_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbDatPhong, lblDatPhong, pnlDatPhong);
        }

        private void ptbDatPhong_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbDatPhong, lblDatPhong, pnlDatPhong);
        }

        private void ptbTaiKhoan_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbTaiKhoan, lblTaiKhoan, pnlTaiKhoan);
        }

        private void ptbTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbTaiKhoan, lblTaiKhoan, pnlTaiKhoan);
        }

        private void ptbDangXuat_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbDangXuat, lblDangXuat, pnlDangXuat);
        }

        private void ptbDangXuat_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbDangXuat, lblDangXuat, pnlDangXuat);
        }

        private void ptbDanhMucPhong_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbDanhMucPhong, lblDanhMucPhong, pnlDanhMucPhong);
        }

        private void ptbDanhMucPhong_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbDanhMucPhong, lblDanhMucPhong, pnlDanhMucPhong);
        }

        private void ptbLoaiPhong_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbLoaiPhong, lblLoaiPhong, pnlLoaiPhong);
        }

        private void ptbLoaiPhong_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbLoaiPhong, lblLoaiPhong, pnlLoaiPhong);
        }

        private void ptbTrangThietBi_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbTrangThietBi, lblTrangThietBi, pnlTrangThietBi);
        }

        private void ptbTrangThietBi_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbTrangThietBi, lblTrangThietBi, pnlTrangThietBi);
        }

        private void ptbNhanVien_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbNhanVien, lblNhanVien, pnlNhanVien);
        }

        private void ptbNhanVien_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbNhanVien, lblNhanVien, pnlNhanVien);
        }

        private void ptbBaoCaoPhong_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbBaoCaoPhong, lblBaoCaoPhong, pnlBaoCaoPhong);
        }

        private void ptbBaoCaoPhong_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbBaoCaoPhong, lblBaoCaoPhong, pnlBaoCaoPhong);
        }

        private void ptbBaoCaoLoaiPhong_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbBaoCaoLoaiPhong, lblBaoCaoLoaiPhong, pnlBaoCaoPhong);
        }

        private void ptbBaoCaoLoaiPhong_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbBaoCaoLoaiPhong, lblBaoCaoLoaiPhong, pnlBaoCaoPhong);
        }

        private void ptbKhachHang_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbKhachHang, lblKhachHang, pnlKhachHang);
        }

        private void ptbKhachHang_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbKhachHang, lblKhachHang, pnlKhachHang);
        }
        private void ptbLoaiKhach_MouseEnter(object sender, EventArgs e)
        {
            loadMouseenter(ptbLoaiKhach, lblLoaiKhach, pnlLoaiKhach);
        }

        private void ptbLoaiKhach_MouseLeave(object sender, EventArgs e)
        {
            loadMouseLeave(ptbLoaiKhach, lblLoaiKhach, pnlLoaiKhach);
        }

        #endregion

        
    }
}
