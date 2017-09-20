using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class busChucVu
    {
        private static busChucVu instance;

        public static busChucVu Instance
        {
            get
            {
                if (instance == null) instance = new busChucVu();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busChucVu() { }
        /// <summary>
        /// lấy danh sách chức vụ
        /// </summary>
        /// <returns></returns>
        public List<dtoChucVu> LayDanhSachChucVu()
        {
            return daoChucVu.Instance.LayDanhSachChucVu();
        }
        /// <summary>
        /// lấy danh sách theo mã chức vụ
        /// </summary>
        /// <param name="macv"></param>
        /// <returns></returns>
        public dtoChucVu LayTheoMaChucVu(string macv)
        {
            return daoChucVu.Instance.LayTheoMaChucVu(macv);

        }
    }
}
