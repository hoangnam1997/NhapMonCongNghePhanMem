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
    public class busLoaiPhong
    {
        private static busLoaiPhong instance;

        public static busLoaiPhong Instance
        {
            get
            {
                if (instance == null) instance = new busLoaiPhong();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busLoaiPhong() { }
        /// <summary>
        /// lấy tất cả danh sách loại phòng
        /// </summary>
        /// <returns></returns>
        public List<dtoLoaiPhong> LayTatCaLoaiPhong()
        {

            return daoLoaiPhong.Instance.LayTatCaLoaiPhong() ;
        }
        /// <summary>
        /// lây loại phong theo malp
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public dtoLoaiPhong LayLoaiPhongMALP(string MALP)
        {

            return daoLoaiPhong.Instance.LayLoaiPhongMALP(MALP);
        }
        /// <summary>
        /// lấy danh sách loại phòng theo tên
        /// </summary>
        /// <param name="tenLP"></param>
        /// <returns></returns>
        public List<dtoLoaiPhong> LayTatCaLoaiPhongTheoTen(string tenLP)
        {
            return daoLoaiPhong.Instance.LayTatCaLoaiPhongTheoTen(tenLP);
        }
        /// <summary>
        /// cập nhân loiạ phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="TenLP"></param>
        /// <param name="Gia"></param>
        /// <returns></returns>
        public bool capNhatLoaiPhong(string MALP, string TenLP, double Gia)
        {
            return daoLoaiPhong.Instance.capNhatLoaiPhong(MALP, TenLP, Gia);
        }
        /// <summary>
        /// kiểm tra loại phòng đã tồn tại chưa
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool isTonTaiLoaiPhong(string MALP)
        {
            return daoLoaiPhong.Instance.isTonTaiLoaiPhong(MALP);
        }
        /// <summary>
        /// xóa loại phòng
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool xoaLoaiPhong(string MALP)
        {
            
            return daoLoaiPhong.Instance.xoaLoaiPhong( MALP ) ;
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
            if(isTonTaiLoaiPhong(MALP))
            {
                MessageBox.Show("Đã tồn tại loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return daoLoaiPhong.Instance.themLoaiPhong( MALP, TenLP, Gia );
        }
    }
}
