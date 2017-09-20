using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class busKhachHang
    {
        private static busKhachHang instance;

        public static busKhachHang Instance
        {
            get
            {
                if (instance == null) instance = new busKhachHang();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busKhachHang() { }
        /// <summary>
        /// Lấy theo cmnd khách hàng
        /// </summary>
        /// <param name="CMND"></param>
        /// <returns></returns>
        public dtoKhachHang LayTheoCMNDKhachHang(string CMND)
        {
            return daoKhachHang.Instance.LayTheoCMNDKhachHang(CMND);
        }
        /// <summary>
        /// them khach hàng
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
            if(daoKhachHang.Instance.LayTheoCMNDKhachHang(CMND)!=null)
            {
                MessageBox.Show("Đã tồn tại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return daoKhachHang.Instance.themKhachHang(CMND, TenKhachHang, GioiTinh, SoDienThoai, DiaChi, MAQT);
        }
        /// <summary>
        /// cập nhật thong otin khách hàng
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="TenKhachHang"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="SoDienThoai"></param>
        /// <param name="DiaChi"></param>
        /// <param name="MAQT"></param>
        /// <returns></returns>
        public bool capNhatKhachHang(string CMND, string TenKhachHang, int GioiTinh, string SoDienThoai, string DiaChi, string MAQT)
        {
            return daoKhachHang.Instance.capnhatKhachHang(CMND, TenKhachHang, GioiTinh, SoDienThoai, DiaChi, MAQT);
        }
        /// <summary>
        /// lấy tất cả danh sachkhácha hàng
        /// </summary>
        /// <returns></returns>
        public List<dtoKhachHang> LayTatCaKhachHang()
        {
            return daoKhachHang.Instance.LayTatCaKhachHang();
        }
        /// <summary>
        /// lây danh sách khach hàng
        /// </summary>
        /// <returns></returns>
        public DataTable LayTatCaKhachHangDataTable()
        {

            return daoKhachHang.Instance.LayTatCaKhachHangDataTable();
        }
        /// <summary>
        /// Lấy theo tên khách hàng
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public List<dtoKhachHang> LayTheoTenKhachHang(string ten)
        {
            return daoKhachHang.Instance.LayTheoTenKhachHang(ten);
        }
        /// <summary>
        /// xóa khách hàng
        /// </summary>
        /// <param name="CMND"></param>
        /// <returns></returns>
        public bool xoaKhachHang(string CMND)
        {
            return daoKhachHang.Instance.xoaKhachHang(CMND);
        }
    }
}
