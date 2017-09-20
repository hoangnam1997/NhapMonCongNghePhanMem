using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoKhachHang
    {
        private string cMND;
        private string tenKhachHang;
        private int gioiTinh;
        private string soDienThoai;
        private string diaChi;
        private string mAQT;
        public dtoKhachHang() { }
        public dtoKhachHang(string CMND,string TenKhachHang, int GioiTinh, string SoDienThoai,string DiaChi,string MAQT) {
            this.CMND = CMND;
            this.TenKhachHang = TenKhachHang;
            this.GioiTinh = GioiTinh;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
            this.MAQT = MAQT;
        }
        public dtoKhachHang(DataRow row)
        {
            this.CMND = (string)row["CMND"];
            this.TenKhachHang = (string)row["TenKhachHang"];
            this.GioiTinh = (int)row["GioiTinh"];
            this.SoDienThoai = (string)row["SoDienThoai"];
            this.DiaChi = (string)row["DiaChi"];
            this.MAQT = (string)row["MAQT"];
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

        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
            }
        }

        public int GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
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
    }
}
