using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoPhieuDangKy
    {
        private static daoPhieuDangKy instance;

        public static daoPhieuDangKy Instance
        {
            get
            {
                if (instance == null) instance = new daoPhieuDangKy();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoPhieuDangKy() { }
        /// <summary>
        /// kiểm tra tồn tại phiếu đăng ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public bool isTonTaiPhieuDangKy(string MAPDK)
        {
            string query = "USP_isTonTaiPhieuDangKy @mapdk";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MAPDK }) > 0;
        }
        /// <summary>
        /// Thêm phiếu đăng ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="CMND"></param>
        /// <param name="MANV"></param>
        /// <param name="ThoiGianDen"></param>
        /// <param name="ThoiGianDi"></param>
        /// <param name="TrangThai"></param>
        /// <returns></returns>
        public bool themPhieuDangKy(string MAPDK, string CMND, string MANV, DateTime ThoiGianDen, DateTime ThoiGianDi, int TrangThai)
        {
            string query = "USP_insertPhieuDangKy @MAPDK , @CMND , @MANV , @ThoiGianDen , @ThoiGianDi , @TrangThai";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAPDK, CMND, MANV, ThoiGianDen, ThoiGianDi, TrangThai }) > 0;
        }
        /// <summary>
        /// Lấy danh sách phiếu đăng ký chưa đến theo mã phòng
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public List<dtoPhieuDangKy> LayTheoMAPdanhSachChuaDenPhieuDangKy(string MAP)
        {
            List<dtoPhieuDangKy> result=new List<dtoPhieuDangKy>();
            string query = "USP_getListPhieuDangKyChuaDenbyMAP @map";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MAP });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhieuDangKy(item));
            }
            return result;
        }
        /// <summary>
        /// lấy theo map danh sách phiêu đăng ký đã đến
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public List<dtoPhieuDangKy> LayTheoMAPdanhSachDaDenPhieuDangKy(string MAP)
        {
            List<dtoPhieuDangKy> result = new List<dtoPhieuDangKy>();
            string query = "USP_getListPhieuDangKyDaDenbyMAP @map";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MAP });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoPhieuDangKy(item));
            }
            return result;
        }
        /// <summary>
        /// update phiếu đnagư ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="ThoiGianDen"></param>
        /// <param name="ThoiGianDi"></param>
        /// <returns></returns>
        public bool updatePhieuDangKy(string MAPDK,DateTime ThoiGianDen, DateTime ThoiGianDi)
        {
            string query = "USP_updateThoiGianPhieuDangKy @maPDK , @ThoiGianDen , @thoiGianDi";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAPDK, ThoiGianDen, ThoiGianDi }) > 0;
        }
        /// <summary>
        /// update đã đến phiếu đăng ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public bool updateDaDenPhieuDangKy(string MAPDK)
        {
            string query = "USP_updateDaDenPhieuDangKy @MAPDK ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAPDK }) > 0;
        }
        /// <summary>
        /// xoa sphiêu đăng ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public bool deletePhieuDangKy(string MAPDK)
        {
            string query = "USP_deletePhieuDangKy @MAPDK ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAPDK }) > 0;
        }
    }
}
