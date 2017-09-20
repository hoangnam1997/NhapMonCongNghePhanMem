using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoKhachHang
    {
        private static daoKhachHang instance;

        public static daoKhachHang Instance
        {
            get
            {
                if (instance == null) instance = new daoKhachHang();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoKhachHang() { }
        /// <summary>
        /// Lấy khách hàng theo cmnd
        /// </summary>
        /// <param name="CMND"></param>
        /// <returns></returns>
        public dtoKhachHang LayTheoCMNDKhachHang(string CMND)
        {
            dtoKhachHang result = null;
            string query = "USP_getKhachHangbyMAKH @MAKH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { CMND });
            foreach (DataRow item in data.Rows)
            {
                result = new dtoKhachHang(item);
            }
            return result;
        }
        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="TenKhachHang"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="SoDienThoai"></param>
        /// <param name="DiaChi"></param>
        /// <param name="MAQT"></param>
        /// <returns></returns>
        public bool themKhachHang(string CMND, string TenKhachHang, int GioiTinh, string SoDienThoai, string DiaChi, string MAQT)
        {
            string query = "USP_insertKhachHang @cmnd , @tenkhachhang , @gioitnh , @sdt , @diachi , @maqt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { CMND, TenKhachHang, GioiTinh, SoDienThoai, DiaChi, MAQT }) > 0;
        }
        /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="TenKhachHang"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="SoDienThoai"></param>
        /// <param name="DiaChi"></param>
        /// <param name="MAQT"></param>
        /// <returns></returns>
        public bool capnhatKhachHang(string CMND, string TenKhachHang, int GioiTinh, string SoDienThoai, string DiaChi, string MAQT)
        {
            string query = "USP_updateKhachHang @cmnd , @tenkhachhang , @gioitnh , @sdt , @diachi , @maqt";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { CMND, TenKhachHang, GioiTinh, SoDienThoai, DiaChi, MAQT }) > 0;
        }
        /// <summary>
        /// Xóa khách hàng
        /// </summary>
        /// <param name="CMND"></param>
        /// <returns></returns>
        public bool xoaKhachHang(string CMND)
        {
            string query = "USP_deleteKhachHang @cmnd";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { CMND}) > 0;
        }
        /// <summary>
        /// lấy tất cả danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public List<dtoKhachHang> LayTatCaKhachHang()
        {
            List<dtoKhachHang> result = new List<dtoKhachHang>() ;
            string query = "USP_getListKhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoKhachHang(item));
            }
            return result;
        }
        /// <summary>
        /// lấy theo tên khách hàng. tìm kiếm gần đúng
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public List<dtoKhachHang> LayTheoTenKhachHang(string ten)
        {
            List<dtoKhachHang> result = new List<dtoKhachHang>();
            string query = "USP_layTheoTenKhachHang @ten";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ten});
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoKhachHang(item));
            }
            return result;
        }
        /// <summary>
        /// Lấy tất cả danh sách khách hàng result: dataTable
        /// </summary>
        /// <returns></returns>
        public DataTable LayTatCaKhachHangDataTable()
        {
            string query = "USP_getListKhachHang";
            return DataProvider.Instance.ExecuteQuery(query); ;
        }
    }
}
