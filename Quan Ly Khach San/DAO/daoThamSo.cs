using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoThamSo
    {
        private static daoThamSo instance;

        public static daoThamSo Instance
        {
            get
            {
                if (instance == null) instance = new daoThamSo();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoThamSo() { }
        /// <summary>
        /// lấy danh sách tham số
        /// </summary>
        /// <returns></returns>
        public dtoThamSo layThamSo()
        {
            dtoThamSo result = null;
            string query = "USP_getThamSo";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result = new dtoThamSo(item);
            }
            return result;
        }
        /// <summary>
        /// cập nhật tham số
        /// </summary>
        /// <param name="TLNNN"></param>
        /// <param name="TLNT3"></param>
        /// <returns></returns>
        public bool capNhatThamSo(double TLNNN, double TLNT3)
        {
            string query = "USP_updateThamSo @TLNNN , @TLNT3";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { TLNNN, TLNT3 }) > 0;
        }
    }
}
