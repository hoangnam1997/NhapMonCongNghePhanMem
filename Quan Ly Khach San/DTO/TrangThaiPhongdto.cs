using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiPhongdto
    {
        private int matrangthai;
        private string tenTrangThai;
        public TrangThaiPhongdto(int ma,string ten)
        {
            this.Matrangthai = ma;
            this.TenTrangThai = ten;
        }
        public override string ToString()
        {
            return this.TenTrangThai;
        }
        public int Matrangthai
        {
            get
            {
                return matrangthai;
            }

            set
            {
                matrangthai = value;
            }
        }

        public string TenTrangThai
        {
            get
            {
                return tenTrangThai;
            }

            set
            {
                tenTrangThai = value;
            }
        }
    }
}
