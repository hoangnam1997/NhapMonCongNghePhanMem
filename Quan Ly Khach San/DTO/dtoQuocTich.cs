using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoQuocTich
    {
        private string mAQT;
        private string tenNuoc;
        public dtoQuocTich() { }
        public dtoQuocTich(string MAQT, string TenNuoc) {
            this.MAQT = MAQT;
            this.TenNuoc = TenNuoc;
        }
        public dtoQuocTich(DataRow row)
        {
            this.MAQT = (string)row["MAQT"];
            this.TenNuoc = (string)row["TenNuoc"];
        }
        public override string ToString()
        {
            return this.TenNuoc;
        }
        public string MAQT
        {
            get
            {
                return mAQT;
            }

            set
            {
                mAQT = value;
            }
        }

        public string TenNuoc
        {
            get
            {
                return tenNuoc;
            }

            set
            {
                tenNuoc = value;
            }
        }
    }
}
