using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class busThietBi
    {
        private static busThietBi instance;

        public static busThietBi Instance
        {
            get
            {
                if (instance == null) instance = new busThietBi();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busThietBi() { }
        /// <summary>
        /// Lấy tất cả dah sách thiết bị
        /// </summary>
        /// <returns></returns>
        public List<dtoThietBi> LayTatCaThietBi()
        {
            
            return daoThietBi.Instance.LayTatCaThietBi();
        }
        /// <summary>
        /// Lấy theo tên thiết bị
        /// </summary>
        /// <param name="Ten"></param>
        /// <returns></returns>
        public List<dtoThietBi> LayTheoTenThietBi(string Ten)
        {

            return daoThietBi.Instance.LayTheoTenThietBi(Ten);
        }
        /// <summary>
        /// xoa thiết bị
        /// </summary>
        /// <param name="MATB"></param>
        /// <returns></returns>
        public bool xoaThietBi(string MATB)
        {
            return daoThietBi.Instance.xoaThietBi( MATB);
        }
        /// <summary>
        /// cập nhật thông tin thiết bị
        /// </summary>
        /// <param name="MATB"></param>
        /// <param name="TenTB"></param>
        /// <returns></returns>
        public bool capNhatThietBi(string MATB, string TenTB)
        {
            return daoThietBi.Instance.capNhatThietBi(MATB, TenTB) ;
        }
        /// <summary>
        /// kiểm tra thiết bị đã tôn tại chưa
        /// </summary>
        /// <param name="MATB"></param>
        /// <returns></returns>
        public bool isTonTaiThietBi(string MATB)
        {
            return daoThietBi.Instance.isTonTaiThietBi( MATB );
        }
        /// <summary>
        /// thêm thiết bị
        /// </summary>
        /// <param name="MATB"></param>
        /// <param name="TenTB"></param>
        /// <returns></returns>
        public bool themThietBi(string MATB, string TenTB)
        {
            if(busThietBi.Instance.isTonTaiThietBi(MATB))
            {
                MessageBox.Show("Đã tồn tại MATB!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return daoThietBi.Instance.themThietBi( MATB, TenTB );
        }
    }
}
