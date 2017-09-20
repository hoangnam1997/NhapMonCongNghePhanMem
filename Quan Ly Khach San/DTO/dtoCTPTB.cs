using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoCTPTB
    {
        private string mALP;
        private string mATB;
        private string tenTB;
        private int soLuong;
        public dtoCTPTB() { }
        public dtoCTPTB(string MALP, string MATB, string TenTB,int SoLuong) {
            this.MALP = MALP;
            this.MATB = MATB;
            this.TenTB = TenTB;
            this.SoLuong = SoLuong;
        }
        public dtoCTPTB(DataRow row)
        {
            this.MALP = (string)row["MALP"];
            this.MATB = (string)row["MATB"];
            this.TenTB = (string)row["TenTB"];
            this.SoLuong = (int)row["SoLuong"];
        }


        public string MALP
        {
            get
            {
                return mALP;
            }

            set
            {
                mALP = value;
            }
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

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }
    }
}
