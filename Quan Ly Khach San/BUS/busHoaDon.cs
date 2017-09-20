using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class busHoaDon
    {
        private static busHoaDon instance;

        public static busHoaDon Instance
        {
            get
            {
                if (instance == null) instance = new busHoaDon();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busHoaDon() { }
        /// <summary>
        /// thêm hóa đơn
        /// </summary>
        /// <param name="MAHD"></param>
        /// <param name="MAPDK"></param>
        /// <param name="MANV"></param>
        /// <param name="SoNgay"></param>
        /// <param name="NgayThanhToan"></param>
        /// <param name="TongTien"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool insertHoaDon(string MAHD, string MAPDK, string MANV, double SoNgay, DateTime NgayThanhToan, double TongTien, string MAP)
        {
            if (busHoaDon.instance.tonTaiHoaDonHoaDon(MAHD))
            {
                return false;
            }
            return daoHoaDon.Instance.insertHoaDon(MAHD, MAPDK, MANV, SoNgay, NgayThanhToan, TongTien, MAP);
        }
        /// <summary>
        /// kiểm tra hóa đơn có tồn tại chưa
        /// </summary>
        /// <param name="MAHD"></param>
        /// <returns></returns>
        public bool tonTaiHoaDonHoaDon(string MAHD)
        {
            return daoHoaDon.Instance.tonTaiHoaDonHoaDon(MAHD);
        }
        /// <summary>
        /// Lấy thông tin hóa đơn
        /// </summary>
        /// <param name="MAHD"></param>
        /// <returns></returns>
        public DataTable LayThongTinHoaDon(string MAHD)
        {
            return daoHoaDon.Instance.LayThongTinHoaDon(MAHD);
        }
        /// <summary>
        /// lấy danh sach hóa đơn theo khaonr thời gian
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public List<dtoHoaDon> layDanhSachHoaDonbyKhoanThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            return daoHoaDon.Instance.layDanhSachHoaDonbyKhoanThoiGian(tuNgay, denNgay);
        }
        /// <summary>
        /// Lấy thông tin hóa đơn theo khoản thời gian
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public DataTable LayThongTinHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            return daoHoaDon.Instance.LayThongTinHoaDon(tuNgay, denNgay);
        }
        /// <summary>
        /// lấy thong tin hóa đơn loaip theo khoản thời gian
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public DataTable LayThongTinHoaDonLoaiP(DateTime tuNgay, DateTime denNgay)
        {
            return daoHoaDon.Instance.LayThongTinHoaDonLoaiP(tuNgay, denNgay);
        }
    }
}
