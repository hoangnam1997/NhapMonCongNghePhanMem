using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoCTPDK
    {
        private static daoCTPDK instance;

        public static daoCTPDK Instance
        {
            get
            {
                if (instance == null) instance = new daoCTPDK();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoCTPDK() { }
        /// <summary>
        /// Kiểm tra CTPDK có tồn tại không
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool isTonTaiCTPDK(string CMND, string MAPDK, string MAP)
        {
            string query = "USP_isTonTaiCTPDK @@CMND , @MAPDK , @MAP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { CMND, MAPDK , MAP }) > 0;
        }
        /// <summary>
        /// Thêm phiếu đăng ký
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool themCTPDK(string CMND,string MAPDK,string MAP)
        {
            string query = "USP_insertCTPDK @CMND , @MAPDK , @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { CMND, MAPDK, MAP }) > 0;
        }
        /// <summary>
        /// Lấy danh sách ctpdk theo mã phiếu đăng ký và mã phòng
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public List<dtoCTPDK> LayDanhSachTheoPhongvaMAPDKCTPDK(string MAPDK,string MAP)
        {
            List<dtoCTPDK> result = new List<dtoCTPDK>();
            string query = "USP_getListCTPDKbyMAPandMAPDK @MAP , @mapdk";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MAP,MAPDK });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoCTPDK(item));
            }
            return result;
        }
        /// <summary>
        /// Xoa phiếu đăng ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool xoaCTPDK(string MAPDK,string MAP)
        {
            string query = "USP_deleteCTPDKbyMAPDKvaMAP  @MAPDK , @MAP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MAPDK, MAP }) > 0;
        }
    }
}
