using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoPhong
    {
        private static daoPhong instance;

        public static daoPhong Instance
        {
            get
            {
                if (instance == null) instance = new daoPhong();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoPhong() { }
        /// <summary>
        /// lấy tất cả danh sách phòng
        /// </summary>
        /// <returns></returns>
        public List<dtoPhong> LayTatCaPhong()
        {
            List<dtoPhong> result = new List<dtoPhong>();
            string query = "USP_getListPhong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhong(item));
            }
            return result;
        }
        /// <summary>
        /// lấy theo mã phòng
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public dtoPhong LayTheoMaPhong(string MAP)
        {
            dtoPhong result = new dtoPhong();
            string query = "USP_getListPhongbyMAP @maP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { MAP});
            foreach (DataRow item in data.Rows)
            {
                result=new dtoPhong(item);
            }
            return result;
        }
        /// <summary>
        /// lấy theo trạng thái và mã phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="trangThai"></param>
        /// <returns></returns>
        public List<dtoPhong> LayTheoTrangThaivaMaLoaiPhong(string MALP,int trangThai)
        {
            List < dtoPhong> result = new List<dtoPhong>();
            string query = "USP_getListPhongbyMALPvsTrangThai @malp , @TrangThai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MALP, trangThai });
            foreach (DataRow item in data.Rows)
            {
                result.Add( new dtoPhong(item));
            }
            return result;
        }
        /// <summary>
        /// lấy danh sach phòng có thể thue trong khoản thời gian
        /// </summary>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <returns></returns>
        public List<dtoPhong> LayDanhSachPhongHopLe(DateTime TuNgay, DateTime DenNgay)
        {
            List<dtoPhong> result = new List<dtoPhong>();
            string query = "USP_LayDanhSachPhongHopLe @tungay , @denngay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TuNgay, DenNgay });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhong(item));
            }
            return result;
        }
        /// <summary>
        /// lấy danh sách hợp lệ theo mp
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="TuNgay"></param>
        /// <param name="DenNgay"></param>
        /// <returns></returns>
        public List<dtoPhong> LayDanhSachPhongHopLe(string MAP,DateTime TuNgay, DateTime DenNgay)
        {
            List<dtoPhong> result = new List<dtoPhong>();
            string query = "USP_LayDanhSachPhongHopLeKhacPhong @MAP , @tungay , @denngay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MAP, TuNgay, DenNgay });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhong(item));
            }
            return result;
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
        public bool capNhatThongTinPhong(string MAP,string TenPhong,int TinhTrang, string GhiChu, int SoKhachToiDa, string MALP)
        {
            string query = "USP_updatePhong @MAP , @TenPhong , @TinhTrang , @GhiChu , @SoKhachToiDa , @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAP, TenPhong, TinhTrang, GhiChu, SoKhachToiDa, MALP }) > 0;
        }
        /// <summary>
        /// thêm phòng
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
            string query = "USP_insertPhong @MAP , @TenPhong , @TinhTrang , @GhiChu , @SoKhachToiDa , @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAP, TenPhong, TinhTrang, GhiChu, SoKhachToiDa, MALP }) > 0;
        }
        
        /// <summary>
        /// Xoa phong
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool xoaPhong(string MAP)
        {
            string query = "USP_deletePhong @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAP}) > 0;
        }
        /// <summary>
        /// Kiem tra phong co ton tai hay khong
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool isTonTaiPhong(string MAP)
        {
            string query = "USP_isTonTaiPhong @MAP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MAP }) > 0;
        }
        /// <summary>
        /// lấy danh sách phòng theo matp có trong phòng
        /// </summary>
        /// <param name="MATB"></param>
        /// <returns></returns>
        public List<dtoPhong>LayTheoThietBiCoTrongPhong(string MATB)
        {
            List<dtoPhong> result = new List<dtoPhong>();
            string query = "USP_layTheoThietBiPhong @MATB";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MATB});
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhong(item));
            }
            return result;
        }
        /// <summary>
        /// lấy dah sách phòng theo mapdk
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public List<dtoPhong> LayTheoMAPDK(string MAPDK)
        {
            List<dtoPhong> result = new List<dtoPhong>();
            string query = "USP_getDanhSachPhongTheoHoaDon @MADK";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MAPDK });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhong(item));
            }
            return result;
        }
    }
}
