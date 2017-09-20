using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class busPhieuDangKy
    {
        private static busPhieuDangKy instance;

        public static busPhieuDangKy Instance
        {
            get
            {
                if (instance == null) instance = new busPhieuDangKy();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private busPhieuDangKy() { }
        /// <summary>
        /// kiểm tra phiếu đăng ký đã tồn tại chưa
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public bool isTonTaiPhieuDangKy(string MAPDK)
        {
            return daoPhieuDangKy.Instance.isTonTaiPhieuDangKy(MAPDK);
        }
        /// <summary>
        /// thêm phiêu đăng ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <param name="CMND"></param>
        /// <param name="MANV"></param>
        /// <param name="ThoiGianDen"></param>
        /// <param name="ThoiGianDi"></param>
        /// <param name="TrangThai"></param>
        /// <returns></returns>
        public bool themPhieuDangKy(string MAPDK, string CMND, string MANV, DateTime ThoiGianDen, DateTime ThoiGianDi, int TrangThai)
        {
            bool isHopLe = true;
            if (ThoiGianDen > ThoiGianDi)
                isHopLe = false;
            if(!isHopLe)
            {
                MessageBox.Show("Thời gian không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (busPhieuDangKy.instance.isTonTaiPhieuDangKy(MAPDK))
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phiếu đăng ký! vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return daoPhieuDangKy.Instance.themPhieuDangKy(MAPDK, CMND, MANV, ThoiGianDen, ThoiGianDi, TrangThai);
        }
        /// <summary>
        /// lấy danh sach phiêu đnag ký theo map chưa đến.
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public List<dtoPhieuDangKy> LayTheoMAPdanhSachChuaDenPhieuDangKy(string MAP)
        {
            return daoPhieuDangKy.Instance.LayTheoMAPdanhSachChuaDenPhieuDangKy(MAP);
        }
        /// <summary>
        /// update vừa ktra có hợp lệ không
        /// </summary>
        /// <param name="MAP"></param>
        /// <param name="MAPDK"></param>
        /// <param name="ThoiGianDen"></param>
        /// <param name="ThoiGianDi"></param>
        /// <returns></returns>
        public bool updatePhieuDangKy(string MAP, string MAPDK, DateTime ThoiGianDen, DateTime ThoiGianDi)
        {

            List<dtoPhong> list = daoPhong.Instance.LayDanhSachPhongHopLe(MAP,ThoiGianDen, ThoiGianDi);
            bool isHopLe = false;
           
            foreach (dtoPhong item in list)
            {
                if (MAP == item.MAP)
                {
                    isHopLe = true;
                }
            }
            if (ThoiGianDen > ThoiGianDi)
                isHopLe = false;
            if (isHopLe)
            {
                return daoPhieuDangKy.Instance.updatePhieuDangKy(MAPDK, ThoiGianDen, ThoiGianDi);
            }
            else
            {
                MessageBox.Show("Thời gian cập nhật bị trùng với phiếu đăng ký khác hoặc thời gian đến lớn hơn thời gian dự kiến đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        /// <summary>
        /// cập nhật đã đến phiêu dnag ky
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public bool updateDaDenPhieuDangKy(string MAPDK)
        {
            
            return daoPhieuDangKy.Instance.updateDaDenPhieuDangKy( MAPDK ) ;
        }
        /// <summary>
        /// xóa phiếu đnagư ký
        /// </summary>
        /// <param name="MAPDK"></param>
        /// <returns></returns>
        public bool deletePhieuDangKy(string MAPDK)
        {
            return daoPhieuDangKy.Instance.deletePhieuDangKy(MAPDK);
        }
        /// <summary>
        /// lấy theo map dnah sách đã đến
        /// </summary>
        /// <param name="MAP"></param>
        /// <returns></returns>
        public List<dtoPhieuDangKy> LayTheoMAPdanhSachDaDenPhieuDangKy(string MAP)
        {
            
            return daoPhieuDangKy.Instance.LayTheoMAPdanhSachDaDenPhieuDangKy(MAP);
        }
    }
}
