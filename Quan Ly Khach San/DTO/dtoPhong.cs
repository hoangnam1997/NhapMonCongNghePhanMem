using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class dtoPhong
    {
        private string mAP;
        private string tenPhong;
        private int tinhTrang;
        private string ghiChu;
        private int soKhachToiDa;
        private string mALP;
        public dtoPhong() { }
        public dtoPhong(string MAP,string TenPhong,int TinhTrang,string GhiChu,int SoKhachToiDa,string MALP)
        {
            this.MAP = MAP;
            this.TenPhong = TenPhong;
            this.TinhTrang = TinhTrang;
            this.GhiChu = GhiChu;
            this.SoKhachToiDa = SoKhachToiDa;
            this.MALP = MALP;
        }
        public dtoPhong(DataRow row)
        {
            this.MAP = (string)row["MAP"];
            this.TenPhong = (string)row["TenPhong"];
            this.TinhTrang = (int)row["TinhTrang"];
            this.GhiChu = (string)row["GhiChu"];
            this.SoKhachToiDa = (int)row["SoKhachToiDa"];
            this.MALP = (string)row["MALP"];
        }
        public override string ToString()
        {
            return this.TenPhong;
        }
        public string MAP
        {
            get
            {
                return mAP;
            }

            set
            {
                mAP = value;
            }
        }

        public string TenPhong
        {
            get
            {
                return tenPhong;
            }

            set
            {
                tenPhong = value;
            }
        }

        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public int SoKhachToiDa
        {
            get
            {
                return soKhachToiDa;
            }

            set
            {
                soKhachToiDa = value;
            }
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
    }
}
