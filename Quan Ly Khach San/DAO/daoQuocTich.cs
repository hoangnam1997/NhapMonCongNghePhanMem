using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoQuocTich
    {
        private static daoQuocTich instance;

        public static daoQuocTich Instance
        {
            get
            {
                if (instance == null) instance = new daoQuocTich();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoQuocTich() { }
        /// <summary>
        /// lấy tất cả danh sách quốc tịch
        /// </summary>
        /// <returns></returns>
        public List<dtoQuocTich> layTatCaQuocTich()
        {
            List<dtoQuocTich> result = new List<dtoQuocTich>();
            string query = "USP_getListQuocTich";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoQuocTich(item));
            }
            return result;
        }
        /// <summary>
        /// lấy theo tên quốc tịch
        /// </summary>
        /// <param name="TenNuoc"></param>
        /// <returns></returns>
        public List<dtoQuocTich> layTheoTenQuocTich(string TenNuoc)
        {
            List<dtoQuocTich> result = new List<dtoQuocTich>();
            string query = "USP_getListQuocTichtheoTen @Ten";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenNuoc});
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoQuocTich(item));
            }
            return result;
        }
        /// <summary>
        /// xóa quốc tịch
        /// </summary>
        /// <param name="MAQT"></param>
        /// <returns></returns>
        public bool xoaQuocTich(string MAQT)
        {

            string query = "USP_deleteQucTich @MAQT";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAQT }) > 0;
        }
        /// <summary>
        /// cập nhật quốc tịch
        /// </summary>
        /// <param name="MAQT"></param>
        /// <param name="TenNuoc"></param>
        /// <returns></returns>
        public bool CapnhatQuocTich(string MAQT,string TenNuoc)
        {

            string query = "USP_updateQuocTich @MAQT , @TenNuoc";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAQT,TenNuoc }) > 0;
        }
        /// <summary>
        /// thêm quốc tịch
        /// </summary>
        /// <param name="MAQT"></param>
        /// <param name="TenNuoc"></param>
        /// <returns></returns>
        public bool themQuocTich(string MAQT, string TenNuoc)
        {

            string query = "USP_themQuocTich @MAQT , @TenNuoc";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAQT, TenNuoc }) > 0;
        }
        /// <summary>
        /// kiêm tra phòng có tồn tại không
        /// </summary>
        /// <param name="MAQT"></param>
        /// <returns></returns>
        public bool isTonTaiQuocTich(string MAQT)
        {

            string query = "USP_isTonTaiQuocTich @MAQT";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MAQT }) > 0;
        }
    }
}
