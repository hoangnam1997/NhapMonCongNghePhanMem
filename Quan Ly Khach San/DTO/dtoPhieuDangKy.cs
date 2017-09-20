using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoPhieuDangKy
    {
        private string mAPDK;
        private string cMND;
        private string mANV;
        private DateTime thoiGianDen;
        private DateTime thoiGianDi;
        private int trangThai;
        public dtoPhieuDangKy() { }
        public override string ToString()
        {
            return this.MAPDK;
        }
        public dtoPhieuDangKy(string MAPDK, string CMND,string MANV,DateTime ThoiGianDen,DateTime ThoiGianDi,int TrangThai) {
            this.MAPDK = MAPDK;
            this.CMND = CMND;
            this.MANV = MANV;
            this.ThoiGianDen = ThoiGianDen;
            this.ThoiGianDi = ThoiGianDi;
            this.TrangThai = TrangThai;
        }
        public dtoPhieuDangKy(DataRow row)
        {
            this.MAPDK = (string)row["MAPDK"];
            this.CMND = (string)row["CMND"];
            this.MANV = (string)row["MANV"];
            this.ThoiGianDen = (DateTime)row["ThoiGianDen"];
            this.ThoiGianDi = (DateTime)row["ThoiGianDi"];
            this.TrangThai = (int)row["TrangThai"];
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

        public string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
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

        public DateTime ThoiGianDen
        {
            get
            {
                return thoiGianDen;
            }

            set
            {
                thoiGianDen = value;
            }
        }

        public DateTime ThoiGianDi
        {
            get
            {
                return thoiGianDi;
            }

            set
            {
                thoiGianDi = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }
    }
}
