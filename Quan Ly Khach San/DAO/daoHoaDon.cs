using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoHoaDon
    {
        private static daoHoaDon instance;

        public static daoHoaDon Instance
        {
            get
            {
                if (instance == null) instance = new daoHoaDon();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoHoaDon() { }
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
            string query = "USP_insertHoaDon @MAHD , @MAPDK , @MANV , @SoNgay , @NgayThanhToan , @TongTien , @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAHD, MAPDK, MANV, SoNgay, NgayThanhToan, TongTien, MAP }) > 0;
        }
        /// <summary>
        /// Kiểm tra mahd có tồn tại không
        /// </summary>
        /// <param name="MAHD"></param>
        /// <returns></returns>
        public bool tonTaiHoaDonHoaDon(string MAHD)
        {
            string query = "USP_isTonTaiHoaDon @mahd";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MAHD }) > 0;
        }
        /// <summary>
        /// Lấy thông tin hóa đơn them mahd
        /// </summary>
        /// <param name="MAHD"></param>
        /// <returns></returns>
        public DataTable LayThongTinHoaDon(string MAHD)
        {
            string query = "USP_getThongTinHoaDon @MAHD";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { MAHD });
        }
        /// <summary>
        /// lấy thông tin hóa đơn từ ngày đến ngày để báo cáo thống kê
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public DataTable LayThongTinHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            string query = "USP_getThongTinHoaDonThoiGian @tuNgay , @denNgay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
        }
        /// <summary>
        /// Láy thog tin hóa đơn theo loại phòng để báo cáo thống kê
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public DataTable LayThongTinHoaDonLoaiP(DateTime tuNgay, DateTime denNgay)
        {
            string query = "USP_getThongTinHoaDonThoiGianLoaiP @tuNgay , @denNgay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
        }
        /// <summary>
        /// lấy danh sach hóa đơn theo khaonr thời gian
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        /// <returns></returns>
        public List<dtoHoaDon> layDanhSachHoaDonbyKhoanThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            List<dtoHoaDon> result = new List<dtoHoaDon>();
            string query = "USP_getListHoaDonKhoanThoiGian @tuNgay , @denNgay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tuNgay, denNgay });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoHoaDon(item));
            }
            return result;
        }
    }
}
