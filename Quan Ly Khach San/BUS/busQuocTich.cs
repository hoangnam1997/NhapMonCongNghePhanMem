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
    public class busQuocTich
    {
        private static busQuocTich instance;

        public static busQuocTich Instance
        {
            get
            {
                if (instance == null) instance = new busQuocTich();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busQuocTich() { }
        /// <summary>
        /// lấy tất cả quốc tịch
        /// </summary>
        /// <returns></returns>
        public List<dtoQuocTich> layTatCaQuocTich()
        {
            return daoQuocTich.Instance.layTatCaQuocTich() ;
        }
        /// <summary>
        /// láy theo tên quốc tịch
        /// </summary>
        /// <param name="TenNuoc"></param>
        /// <returns></returns>
        public List<dtoQuocTich> layTheoTenQuocTich(string TenNuoc)
        {
            return daoQuocTich.Instance.layTheoTenQuocTich(TenNuoc);
        }
        /// <summary>
        /// xóa quốc tịch
        /// </summary>
        /// <param name="MAQT"></param>
        /// <returns></returns>
        public bool xoaQuocTich(string MAQT)
        {
            return daoQuocTich.Instance.xoaQuocTich( MAQT );
        }
        /// <summary>
        /// cập nhật quốc tịch
        /// </summary>
        /// <param name="MAQT"></param>
        /// <param name="TenNuoc"></param>
        /// <returns></returns>
        public bool CapnhatQuocTich(string MAQT, string TenNuoc)
        {

            return daoQuocTich.Instance.CapnhatQuocTich(MAQT, TenNuoc );
        }
        /// <summary>
        /// thêm quốc tịch
        /// </summary>
        /// <param name="MAQT"></param>
        /// <param name="TenNuoc"></param>
        /// <returns></returns>
        public bool themQuocTich(string MAQT, string TenNuoc)
        {
            if(busQuocTich.instance.isTonTaiQuocTich(MAQT))
            {
                MessageBox.Show("Đã tồn tại " + MAQT, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return daoQuocTich.Instance.themQuocTich(MAQT, TenNuoc);
            
        }
        public bool isTonTaiQuocTich(string MAQT)
        {
            return daoQuocTich.Instance.isTonTaiQuocTich(MAQT);
        }
    }
}
