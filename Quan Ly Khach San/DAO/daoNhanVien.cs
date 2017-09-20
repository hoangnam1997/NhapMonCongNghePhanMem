using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoNhanVien
    {
        private static daoNhanVien instance;
        public static daoNhanVien Instance
        {
            get
            {
                if (instance == null) instance = new daoNhanVien();
                return instance;
            }

           private set
            {
                instance = value;
            }
        }
        private daoNhanVien() { }
        /// <summary>
        /// lấy thông tin nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="MANV"></param>
        /// <returns></returns>
        public dtoNhanVien LayTheoMaNHANVIEN(string MANV)
        {
            dtoNhanVien result = null;
            string query = "USP_getNhanVienbyMANV @manv";
            DataTable data=DataProvider.Instance.ExecuteQuery(query,new object[] { MANV });
            foreach (DataRow item in data.Rows)
            {
                result = new dtoNhanVien(item);
            }
            return result;
        }
        /// <summary>
        /// Lấy tất cả danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        public List<dtoNhanVien> LayTatCaNHANVIEN()
        {
            List<dtoNhanVien> result = new List<dtoNhanVien>() ;
            string query = "USP_getListNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoNhanVien(item));
            }
            return result;
        }
        /// <summary>
        /// lấy danh sách nhân viên theo tên, tìm kiếm gần đúng
        /// </summary>
        /// <param name="TenNV"></param>
        /// <returns></returns>
        public List<dtoNhanVien> LayTheoTenNHANVIEN(string TenNV)
        {
            List<dtoNhanVien> result = new List<dtoNhanVien>();
            string query = "USP_getListNhanVientheoTen @TenNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenNV});
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoNhanVien(item));
            }
            return result;
        }
        /// <summary>
        /// update thông tin nhân viên
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="SDT"></param>
        /// <param name="DiaChi"></param>
        /// <returns></returns>
        public bool updateNhanVien(string manv,string tennv,int gioiTinh,DateTime NgaySinh,string SDT,string DiaChi)
        {
            string query = "USP_updateNhanVien @manv , @TenNV , @GioiTinh , @ngaysinh , @SDT , @diaChi";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, gioiTinh, NgaySinh, SDT, DiaChi }) > 0;
        }
        /// <summary>
        /// update thông tin nhân viên
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="SDT"></param>
        /// <param name="DiaChi"></param>
        /// <param name="MACV"></param>
        /// <returns></returns>
        public bool updateNhanVien(string manv, string tennv, int gioiTinh, DateTime NgaySinh, string SDT, string DiaChi,string MACV)
        {
            string query = "USP_updateNhanVienAll @manv , @TenNV , @GioiTinh , @ngaysinh , @SDT , @diaChi , @macv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, gioiTinh, NgaySinh, SDT, DiaChi,MACV }) > 0;
        }
        /// <summary>
        /// thêm nhân viên
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="SDT"></param>
        /// <param name="DiaChi"></param>
        /// <param name="Matkhau"></param>
        /// <param name="MACV"></param>
        /// <returns></returns>
        public bool themNhanVien(string manv, string tennv, int gioiTinh, DateTime NgaySinh, string SDT, string DiaChi, string Matkhau,string MACV)
        {
            string query = "USP_insertNhanVien @MANV , @TenNV , @Gioitinh , @NgaySinh , @SDT , @DiaChi , @MatKhau , @MACV";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, gioiTinh, NgaySinh, SDT, DiaChi, Matkhau, MACV }) > 0;
        }
        /// <summary>
        /// update nhân viên
        /// </summary>
        /// <param name="MANV"></param>
        /// <param name="MatKhauMoi"></param>
        /// <returns></returns>
        public bool updateNhanVien(string MANV,string MatKhauMoi)
        {
            string query = "USP_updateMatKhauNhanVien @manv , @matkhau";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MANV,MatKhauMoi }) > 0;
        }
        /// <summary>
        /// xóa nhân viên với manv
        /// </summary>
        /// <param name="MANV"></param>
        /// <returns></returns>
        public bool xoaNhanVien(string MANV)
        {
            string query = "USP_deleteNhanVien @manv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MANV }) > 0;
        }
    }
}
