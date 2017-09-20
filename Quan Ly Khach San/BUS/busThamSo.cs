using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class busThamSo
    {
        private static busThamSo instance;

        public static busThamSo Instance
        {
            get
            {
                if (instance == null) instance = new busThamSo();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busThamSo() { }
        /// <summary>
        /// láy tham số
        /// </summary>
        /// <returns></returns>
        public dtoThamSo layThamSo()
        {
            return daoThamSo.Instance.layThamSo();
        }
        /// <summary>
        /// cập nhật thông tin tham số
        /// </summary>
        /// <param name="TLNNN"></param>
        /// <param name="TLNT3"></param>
        /// <returns></returns>
        public bool capNhatThamSo(double TLNNN, double TLNT3)
        {
            return daoThamSo.Instance.capNhatThamSo(TLNNN, TLNT3);
        }
    }
}
