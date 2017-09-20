using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoThietBi
    {
        private static daoThietBi instance;

        public static daoThietBi Instance
        {
            get
            {
                if (instance == null) instance = new daoThietBi();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoThietBi() { }
        /// <summary>
        /// lấy tất cả danh sách thiết bị
        /// </summary>
        /// <returns></returns>
        public List<dtoThietBi> LayTatCaThietBi()
        {
            List<dtoThietBi> result = new List<dtoThietBi>();
            string query = "USP_LayTatCaThietBi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoThietBi(item));
            }
            return result;
        }
        /// <summary>
        /// 
        /// lấy theo tên thiết bị, tìm kiếm gần đúng
        /// </summary>
        /// <param name="TenTB"></param>
        /// <returns></returns>
        
        public List<dtoThietBi> LayTheoTenThietBi(string TenTB)
        {
            List<dtoThietBi> result = new List<dtoThietBi>();
            string query = "USP_LayTheoTenThietBi @TenTB";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTB});
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoThietBi(item));
            }
            return result;
        }
        /// <summary>
        /// xóa thiết bị
        /// </summary>
        /// <param name="MATB"></param>
        /// <returns></returns>
        public bool xoaThietBi(string MATB)
        {
            string query = "USP_deleteThietBi @MATB";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MATB }) > 0;
        }
        /// <summary>
        /// cập nhật thiết bị
        /// </summary>
        /// <param name="MATB"></param>
        /// <param name="TenTB"></param>
        /// <returns></returns>
        public bool capNhatThietBi(string MATB, string TenTB)
        {
            string query = "USP_updateThietBi @MATB , @TenTB";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MATB,TenTB }) > 0;
        }
        /// <summary>
        /// thêm thiết bị
        /// </summary>
        /// <param name="MATB"></param>
        /// <param name="TenTB"></param>
        /// <returns></returns>
        public bool themThietBi(string MATB, string TenTB)
        {
            string query = "USP_insertThietBi @MATB , @TenTB";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MATB, TenTB }) > 0;
        }
        /// <summary>
        /// kiểm tra thiết bị có tồn tại không
        /// </summary>
        /// <param name="MATB"></param>
        /// <returns></returns>
        public bool isTonTaiThietBi(string MATB)
        {
            string query = "USP_isTonTaiThietBi @MATB";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MATB }) > 0;
        }
    }
}
