using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoThietBi
    {
        private string mATB;
        private string tenTB;
        public dtoThietBi() { }
        public dtoThietBi(string MATB,string TenTB) {
            this.MATB = MATB;
            this.TenTB = TenTB;
        }
        public dtoThietBi(DataRow row)
        {
            this.MATB = (string)row["MATB"];
            this.TenTB = (string)row["TenTB"];
        }
        public override string ToString()
        {
            return this.TenTB +"("+this.MATB+")";
        }
        public string MATB
        {
            get
            {
                return mATB;
            }

            set
            {
                mATB = value;
            }
        }

        public string TenTB
        {
            get
            {
                return tenTB;
            }

            set
            {
                tenTB = value;
            }
        }
    }
}
