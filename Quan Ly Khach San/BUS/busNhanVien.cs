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
    public class busNhanVien
    {
        private static busNhanVien instance;

        public static busNhanVien Instance
        {
            get
            {
                if (instance == null) instance = new busNhanVien();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busNhanVien() { }
        /// <summary>
        /// lấy thong tin nhân viên theo mã nv
        /// </summary>
        /// <param name="MANV"></param>
        /// <returns></returns>
        public dtoNhanVien LayTheoMaNHANVIEN(string MANV)
        {
            return daoNhanVien.Instance.LayTheoMaNHANVIEN(MANV);
        }
        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        public List<dtoNhanVien> LayTatCaNHANVIEN()
        {
            return daoNhanVien.Instance.LayTatCaNHANVIEN();
        }
        /// <summary>
        /// update nhân viên
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="tennv"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="SDT"></param>
        /// <param name="DiaChi"></param>
        /// <returns></returns>
        public bool updateNhanVien(string manv, string tennv, int gioiTinh, DateTime NgaySinh, string SDT, string DiaChi)
        {
            return daoNhanVien.Instance.updateNhanVien(manv, tennv, gioiTinh, NgaySinh, SDT, DiaChi);
        }
        /// <summary>
        /// update nhân viên
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
            return daoNhanVien.Instance.updateNhanVien(manv, tennv, gioiTinh, NgaySinh, SDT, DiaChi,MACV);
        }
        /// <summary>
        /// update nhahan viên
        /// </summary>
        /// <param name="MANV"></param>
        /// <param name="MatKhauMoi"></param>
        /// <returns></returns>
        public bool updateNhanVien(string MANV, string MatKhauMoi)
        {

            return daoNhanVien.Instance.updateNhanVien(MANV, MatKhauMoi);
        }
        /// <summary>
        /// lấy danh sách nhân vien theo tên
        /// </summary>
        /// <param name="TenNV"></param>
        /// <returns></returns>
        public List<dtoNhanVien> LayTheoTenNHANVIEN(string TenNV)
        {
            return daoNhanVien.Instance.LayTheoTenNHANVIEN(TenNV);
        }
        /// <summary>
        /// xoa nhân viên
        /// </summary>
        /// <param name="MANV"></param>
        /// <returns></returns>
        public bool xoaNhanVien(string MANV)
        {
            return daoNhanVien.Instance.xoaNhanVien(MANV );
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
        public bool themNhanVien(string manv, string tennv, int gioiTinh, DateTime NgaySinh, string SDT, string DiaChi, string Matkhau, string MACV)
        {
            if(busNhanVien.instance.LayTheoMaNHANVIEN(manv)!=null)
            {
                MessageBox.Show("Đã tồn tại "+ manv,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return daoNhanVien.Instance.themNhanVien(manv, tennv, gioiTinh, NgaySinh, SDT, DiaChi, Matkhau, MACV);
        }
    }
}
