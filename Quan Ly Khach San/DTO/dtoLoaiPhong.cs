using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoLoaiPhong
    {
        private string mALP;
        private string tenLP;
        private Double gia;
        public dtoLoaiPhong() { }
        public dtoLoaiPhong(string MALP,string TenLP,Double Gia) {
            this.MALP = MALP;
            this.TenLP = TenLP;
            this.Gia = Gia;
        }
        public dtoLoaiPhong(DataRow row)
        {
            this.MALP = (string)row["MALP"];
            this.TenLP = (string)row["TenLP"];
            this.Gia = float.Parse(row["Gia"].ToString());
        }
        public override string ToString()
        {
            return this.TenLP + " ("+ this.Gia+")" ;
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

        public string TenLP
        {
            get
            {
                return tenLP;
            }

            set
            {
                tenLP = value;
            }
        }

        public double Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }
    }
}
