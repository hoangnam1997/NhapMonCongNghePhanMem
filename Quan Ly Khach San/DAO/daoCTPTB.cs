using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoCTPTB
    {
        private static daoCTPTB instance;

        public static daoCTPTB Instance
        {
            get
            {
                if (instance == null) instance = new daoCTPTB();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoCTPTB() { }

        /// <summary>
        /// lấy CTPTB theo loại phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public List<dtoCTPTB> LayCTPTBtheoLoaiPhong(string MALP)
        {
            List<dtoCTPTB> result = new List<dtoCTPTB>();
            string query = "USP_getListCTPTBbyMALP @MALP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MALP });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoCTPTB(item));
            }
            return result;
         
        }
        /// <summary>
        /// Lấy số lương cttb theo loại phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public int laySoLuongCTTBtheoLP(string MALP)
        {
            string query = "USP_soLuongCTPTBtheoMALP @MALP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MALP });
        }
        /// <summary>
        /// xóa ctptb
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool xoaCTPTBtheoMALP(string MALP)
        {
            string query = "USP_deleteCTPTBtheoMALP @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MALP }) > 0;
        }
        /// <summary>
        /// thêm ctptb
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="MATB"></param>
        /// <param name="SL"></param>
        /// <returns></returns>
        public bool themCTPTBtheoMALP(string MALP,string MATB,int SL)
        {
            string query = "USP_insertCTPTB @MALP , @MATB , @SL";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MALP,MATB,SL }) > 0;
        }
    }
}
