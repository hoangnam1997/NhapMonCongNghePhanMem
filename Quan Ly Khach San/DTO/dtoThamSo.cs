using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoThamSo
    {
        private double tyLePhuThuKhachThu3;
        private double tyLePhuThuKhachNuocNgoai;
        public dtoThamSo() { }
        public dtoThamSo(double TyLePhuThuKhachThu3, double TyLePhuThuKhachNuocNgoai)
        {
            this.TyLePhuThuKhachThu3 = TyLePhuThuKhachThu3;
            this.TyLePhuThuKhachNuocNgoai = TyLePhuThuKhachNuocNgoai;
        }
        public dtoThamSo(DataRow row)
        {
            this.TyLePhuThuKhachThu3 = double.Parse(row["TyLePhuThuKhachThu3"].ToString()) ;
            this.TyLePhuThuKhachNuocNgoai = double.Parse(row["TyLePhuThuKhachNuocNgoai"].ToString());
        }
        public double TyLePhuThuKhachThu3
        {
            get
            {
                return tyLePhuThuKhachThu3;
            }

            set
            {
                tyLePhuThuKhachThu3 = value;
            }
        }

        public double TyLePhuThuKhachNuocNgoai
        {
            get
            {
                return tyLePhuThuKhachNuocNgoai;
            }

            set
            {
                tyLePhuThuKhachNuocNgoai = value;
            }
        }
    }
}
