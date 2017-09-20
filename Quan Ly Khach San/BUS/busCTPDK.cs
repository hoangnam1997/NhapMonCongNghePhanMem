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
    public class busCTPDK
    {
        private static busCTPDK instance;

        public static busCTPDK Instance
        {
            get
            {
                if (instance == null) instance = new busCTPDK();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busCTPDK() { }
        /// <summary>
        /// kiểm tra ctpdk đã tồn tại chưa
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool isTonTaiCTPDK(string CMND, string MAPDK, string MAP)
        {
            return daoCTPDK.Instance.isTonTaiCTPDK(CMND, MAPDK, MAP);
        }
        /// <summary>
        /// thêm ctpdk
        /// </summary>
        /// <param name="CMND"></param>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool themCTPDK(string CMND, string MAPDK, string MAP)
        {
            if (busCTPDK.instance.isTonTaiCTPDK(CMND, MAPDK, MAP))
            {
                MessageBox.Show("Đã tồn tại CTPDK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return daoCTPDK.Instance.themCTPDK(CMND, MAPDK, MAP);
        }
        /// <summary>
        /// lấy danh sách ctpdk theo phong. chua đến
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public List<dtoCTPDK> LayDanhSachChuaDenTheoPhongCTPDK(string MAPDK, string MAP)
        {          
            return daoCTPDK.Instance.LayDanhSachTheoPhongvaMAPDKCTPDK(MAPDK,MAP);
        }
        /// <summary>
        /// xóa ctpdk
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public bool xoaCTPDK(string MAPDK, string MAP)
        {           
            return daoCTPDK.Instance.xoaCTPDK( MAPDK, MAP );
        }
    }
}
