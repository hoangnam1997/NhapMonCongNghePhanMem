using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class busPhong
    {
        private static busPhong instance;

        public static busPhong Instance
        {
            get
            {
                if (instance == null) instance = new busPhong();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busPhong() { }
        /// <summary>
        /// lấy tất cả danh sách phòng
        /// </summary>
        /// <returns></returns>
        public List<dtoPhong> LayTatCaPhong()
        {

            return daoPhong.Instance.LayTatCaPhong();
        }
        /// <summary>
        /// lấy danh sách phog theo map
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public dtoPhong LayTheoMaPhong(string MAP)
        {
            return daoPhong.Instance.LayTheoMaPhong(MAP);
        }
        /// <summary>
        /// -1: tất cả , 0: trống , 1: đã có khách
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="trangThai"></param>
        /// <returns></returns>
        public List<dtoPhong> LayTheoTrangThaivaMaLoaiPhong(string MALP, int trangThai)
        {

            return daoPhong.Instance.LayTheoTrangThaivaMaLoaiPhong(MALP, trangThai);
        }
        /// <summary>
        /// Lấy dnah sách phog không có phieuDK trùng với khoản thời gian
        /// </summary>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <returns></returns>
        public List<dtoPhong> LayDanhSachPhongHopLe(DateTime TuNgay, DateTime DenNgay)
        {
            return daoPhong.Instance.LayDanhSachPhongHopLe(TuNgay, DenNgay);
        }
        /// <summary>
        /// Cập nhật phòng
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TenPhong"></param>
        /// <param name="TinhTrang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="SoKhachToiDa"></param>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool capNhatThongTinPhong(string MAP, string TenPhong, int TinhTrang, string GhiChu, int SoKhachToiDa, string MALP)
        {
            return daoPhong.Instance.capNhatThongTinPhong(MAP, TenPhong, TinhTrang, GhiChu, SoKhachToiDa, MALP);
        }
        /// <summary>
        /// them phong với các thông tin
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TenPhong"></param>
        /// <param name="TinhTrang"></param>
        /// <param name="GhiChu"></param>
        /// <param name="SoKhachToiDa"></param>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool themPhong(string MAP, string TenPhong, int TinhTrang, string GhiChu, int SoKhachToiDa, string MALP)
        {
            if (daoPhong.Instance.isTonTaiPhong(MAP))
            {
                MessageBox.Show("Đã tồn tại phòng " + MAP + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return daoPhong.Instance.themPhong(MAP, TenPhong, TinhTrang, GhiChu, SoKhachToiDa, MALP);
        }
        /// <summary>
        /// Kiểm tra phòng cóa tồn tại không
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool isTonTaiPhong(string MAP)
        {

            return daoPhong.Instance.isTonTaiPhong(MAP);
        }
        /// <summary>
        /// xóa phong với map
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool xoaPhong(string MAP)
        {
            return daoPhong.Instance.xoaPhong(MAP);
        }
        /// <summary>
        /// lấy dnah sách phong theo matb có trong phòng
        /// </summary>
        /// <param name="MATB"></param>
        /// <returns></returns>
        public List<dtoPhong> LayTheoThietBiCoTrongPhong(string MATB)
        {
            return daoPhong.Instance.LayTheoThietBiCoTrongPhong(MATB);
        }
        /// <summary>
        /// lấy dánh sách phòng theo mapdk
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public List<dtoPhong> LayTheoMAPDK(string MAPDK)
        {
            return daoPhong.Instance.LayTheoMAPDK(MAPDK);
        }
    }
}
