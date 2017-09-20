using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoNhanVien
    {
        private string mANV;
        private string tenNV;
        private int gioiTinh;
        private DateTime ngaySinh;
        private string sDT;
        private string diaChi;
        private string matKhauDangNhap;
        private string mACV;
        public dtoNhanVien() { }
        public dtoNhanVien(string MANV,string TenNV, int GioiTinh, DateTime NgaySinh, string SDT, string DiaChi,string MatKhauDangNhap,string MACV) {
            this.MANV = MANV;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.MatKhauDangNhap = MatKhauDangNhap;
            this.MACV = MACV;
        }
        public dtoNhanVien(DataRow row)
        {
            this.MANV = (string)row["MANV"];
            this.TenNV = (string)row["TenNV"];
            this.GioiTinh = (int)row["GioiTinh"];
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.SDT = (string)row["SDT"];
            this.DiaChi = (string)row["DiaChi"];
            this.MatKhauDangNhap = (string)row["MatKhauDangNhap"];
            this.MACV = (string)row["MACV"];
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

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
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

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string SDT
        {
            get
            {
                return sDT;
            }

            set
            {
                sDT = value;
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

        public string MatKhauDangNhap
        {
            get
            {
                return matKhauDangNhap;
            }

            set
            {
                matKhauDangNhap = value;
            }
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
    }
}
