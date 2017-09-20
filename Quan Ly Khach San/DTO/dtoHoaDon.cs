using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoHoaDon
    {
        private string mAHD;
        private string mAPDK;
        private string mANV;
        private double soNgay;
        private DateTime ngayThanhToan;
        private double tongTien;
        private string mAP;
        public dtoHoaDon() { }
        public dtoHoaDon(string MAHD,string MAPDK, string MANV, double SoNgay,DateTime NgayThanhToan,double TongTien,string MAP)
        {
            this.MAHD = MAHD;
            this.MAPDK = MAPDK;
            this.MANV = MANV;
            this.SoNgay = SoNgay;
            this.NgayThanhToan = NgayThanhToan;
            this.TongTien = TongTien;
            this.MAP = MAP;
        }

        public dtoHoaDon(DataRow row)
        {
            this.MAHD = (string)row["MAHD"];
            this.MAPDK = (string)row["MAPDK"];
            this.MANV = (string)row["MANV"];
            this.SoNgay = float.Parse(row["SoNgay"].ToString());
            this.NgayThanhToan = (DateTime)row["NgayThanhToan"];
            this.TongTien = float.Parse(row["TongTien"].ToString());
            this.MAP = (string)row["MAP"];
        }
        public string MAHD
        {
            get
            {
                return mAHD;
            }

            set
            {
                mAHD = value;
            }
        }

        public string MAPDK
        {
            get
            {
                return mAPDK;
            }

            set
            {
                mAPDK = value;
            }
        }

        public string MANV
        {
            get
            {
                return mANV;
            }

            set
            {
                mANV = value;
            }
        }

        public double SoNgay
        {
            get
            {
                return soNgay;
            }

            set
            {
                soNgay = value;
            }
        }

        public DateTime NgayThanhToan
        {
            get
            {
                return ngayThanhToan;
            }

            set
            {
                ngayThanhToan = value;
            }
        }

        public double TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
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
    }
}
