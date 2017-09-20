using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoChucVu
    {
        private string mACV;
        private string tenChucVu;
        public dtoChucVu() { }
        public dtoChucVu(string MACV, string TenChucCu) {
            this.MACV = MACV;
            this.TenChucVu = TenChucVu;
        }
        public dtoChucVu(DataRow row)
        {
            this.MACV = (string)row["MACV"];
            this.TenChucVu = (string)row["TenChucVu"];
        }
        public override string ToString()
        {
            return TenChucVu;
        }
        public string MACV
        {
            get
            {
                return mACV;
            }

            set
            {
                mACV = value;
            }
        }

        public string TenChucVu
        {
            get
            {
                return tenChucVu;
            }

            set
            {
                tenChucVu = value;
            }
        }
    }
}
