using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class busCTPTB
    {
        private static busCTPTB instance;

        public static busCTPTB Instance
        {
            get
            {
                if (instance == null) instance = new busCTPTB();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busCTPTB() { }
        /// <summary>
        /// lấy ctptb theo malp
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public List<dtoCTPTB> LayCTPTBtheoLoaiPhong(string MALP)
        {
            
            return daoCTPTB.Instance.LayCTPTBtheoLoaiPhong(MALP);

        }
        /// <summary>
        /// xóa
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public bool xoaCTPTBtheoMALP(string MALP)
        {
            if (busCTPTB.instance.laySoLuongCTTBtheoLP(MALP) <= 0)
                return true;
            return daoCTPTB.Instance.xoaCTPTBtheoMALP(MALP);
        }
        /// <summary>
        /// thêm ctptb
        /// </summary>
        /// <param name="MALP"></param>
        /// <param name="MATB"></param>
        /// <param name="SL"></param>
        /// <returns></returns>
        public bool themCTPTBtheoMALP(string MALP, string MATB, int SL)
        {
            return daoCTPTB.Instance.themCTPTBtheoMALP(MALP, MATB, SL);
        }
        /// <summary>
        /// lấy số lượng các thiết bị trong phog
        /// </summary>
        /// <param name="MALP"></param>
        /// <returns></returns>
        public int laySoLuongCTTBtheoLP(string MALP)
        {
            return daoCTPTB.Instance.laySoLuongCTTBtheoLP( MALP);
        }
    }
}
