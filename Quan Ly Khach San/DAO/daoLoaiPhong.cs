using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class daoLoaiPhong
    {
        private static daoLoaiPhong instance;

        public static daoLoaiPhong Instance
        {
            get
            {
                if (instance == null) instance = new daoLoaiPhong();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private daoLoaiPhong() { }
        /// <summary>
        /// lấy tất cả danh sách loại phòng
        /// </summary>
        /// <returns></returns>
        public List<dtoLoaiPhong>LayTatCaLoaiPhong()
        {
            List<dtoLoaiPhong> result = new List<dtoLoaiPhong>();
            string query = "USP_getListLoaiPhong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoLoaiPhong(item));
            }
            return result;
        }
        /// <summary>
        /// lấy danh sách loại phòng theo tên, tìm kiếm gần đug
        /// </summary>
        /// <param name="tenLP"></param>
        /// <returns></returns>
        public List<dtoLoaiPhong> LayTatCaLoaiPhongTheoTen(string tenLP)
        {
            List<dtoLoaiPhong> result = new List<dtoLoaiPhong>();
            string query = "USP_getListLoaiPhongTheoTen @Ten";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLP });
            foreach (DataRow item in data.Rows)
            {
                result.Add(new dtoLoaiPhong(item));
            }
            return result;
        }
        /// <summary>
        /// Lấy loại phòng theo malp
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public dtoLoaiPhong LayLoaiPhongMALP(string MALP)
        {
            dtoLoaiPhong result = new dtoLoaiPhong();
            string query = "USP_getLoaiPhongbyMALP @MALP";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MALP });
            foreach (DataRow item in data.Rows)
            {
                result=(new dtoLoaiPhong(item));
            }
            return result;
        }
        /// <summary>
        /// cập nhật thông tin loại phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="TenLP"></param>
        /// <param name="Gia"></param>
        /// <returns></returns>
        public bool capNhatLoaiPhong(string MALP,string TenLP,double Gia)
        {
            string query = "USP_updateLoaiPhong @MALP , @TenLP , @Gia";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MALP, TenLP, Gia })>0;
        }
        /// <summary>
        /// them loại phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="TenLP"></param>
        /// <param name="Gia"></param>
        /// <returns></returns>
        public bool themLoaiPhong(string MALP, string TenLP, double Gia)
        {
            string query = "USP_insertLoaiPhong @MALP , @TenLP , @Gia";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MALP, TenLP, Gia }) > 0;
        }
        /// <summary>
        /// Kiểm tra có tồn tai loai p hay không
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool isTonTaiLoaiPhong(string MALP)
        {
            string query = "USP_isTonTaiLoaiPhong @MALP";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { MALP}) > 0;
        }
        /// <summary>
        /// xoa loai phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool xoaLoaiPhong(string MALP)
        {
            string query = "USP_deleteLoaiPhong @MALP";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MALP}) > 0;
        }
    }
}
