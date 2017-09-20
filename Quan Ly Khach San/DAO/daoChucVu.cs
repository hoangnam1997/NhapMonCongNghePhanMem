using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoChucVu
    {
        private static daoChucVu instance;

        public static daoChucVu Instance
        {
            get
            {
                if (instance == null) instance = new daoChucVu();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoChucVu() { }

        /// <summary>
        /// Lấy tất cả danh sách chức vụ
        /// </summary>
        /// <returns></returns>
        public List<dtoChucVu> LayDanhSachChucVu()
        {
            List<dtoChucVu> result = new List<dtoChucVu>();
            string query = "USP_layDanhSachChucvu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoChucVu(item));
            }
            return result;
        }
        /// <summary>
        /// Lấy chức vụ theo mã chức vụ
        /// </summary>
        /// <param name="macv"></param>
        /// <returns></returns>
        public dtoChucVu LayTheoMaChucVu(string macv)
        {
            dtoChucVu result = new dtoChucVu();
            string query = "USP_LayTheoMaChucvu @macv";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { macv});
            foreach (DataRow item in data.Rows)
            {
                result=(new dtoChucVu(item));
            }
            return result;
        }
    }
}
