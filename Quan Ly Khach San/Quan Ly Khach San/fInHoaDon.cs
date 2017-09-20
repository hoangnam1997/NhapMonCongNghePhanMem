using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San
{
    public partial class fInHoaDon : Form
    {
        /// <summary>
        /// hàm khỏi tạo
        /// </summary>
        public fInHoaDon()
        {
            InitializeComponent();
            
        }
        #region properties
        #endregion
        #region method
        /// <summary>
        /// lấy danh sách hóa đơn đã thanh toán trong ngyà đưa vào dtgv
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <param name="denNgay"></param>
        void loadDSHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            double TongTien = 0;
            List<dtoHoaDon> list=busHoaDon.Instance.layDanhSachHoaDonbyKhoanThoiGian(tuNgay, denNgay);
            dtgvHoaDon.DataSource = list;
            foreach (dtoHoaDon item in list)
            {
                TongTien += item.TongTien;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTongTien.Text = TongTien.ToString("c", culture);
            dtgvHoaDon.Columns["MAHD"].HeaderText = "Mã hóa đơn";
            dtgvHoaDon.Columns["MANV"].HeaderText = "Nhân viên";
            dtgvHoaDon.Columns["SoNgay"].HeaderText = "Số ngày thuê";
            dtgvHoaDon.Columns["SoNgay"].DefaultCellStyle.Format = "0.##";
            dtgvHoaDon.Columns["NgayThanhToan"].HeaderText = "Thời gian";
            dtgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            dtgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "0.##";
            dtgvHoaDon.Columns["MAPDK"].Visible = false ;
            dtgvHoaDon.Columns["MAP"].HeaderText = "Phòng";
        }
        #endregion
        #region event
        /// <summary>
        /// Thoát khỏi form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Load theo ngày danh sách hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fInHoaDon_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dtpkTuNgay.Value = new DateTime(date.Year, date.Month, date.Day, 0, 0, 1);
            dtpkDenNgay.Value = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0).AddDays(1).AddSeconds(-1);
            loadDSHoaDon(dtpkTuNgay.Value, dtpkDenNgay.Value);
        }
        /// <summary>
        /// thực hiện load danh sách hóa đơn khi ấn click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXem_Click(object sender, EventArgs e)
        {
            loadDSHoaDon(dtpkTuNgay.Value, dtpkDenNgay.Value);

        }
        /// <summary>
        /// In hóa đơn đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dtgvHoaDon.SelectedCells.Count <= 0) return;
            string MAHD = (string)dtgvHoaDon.SelectedCells[0].OwningRow.Cells["MAHD"].Value;
            crHoaDonTraPhong cr = new crHoaDonTraPhong();
            cr.SetDataSource(busHoaDon.Instance.LayThongTinHoaDon(MAHD));
            fReport f = new fReport(cr);
            f.ShowDialog();
        }
        /// <summary>
        /// Báo cáo tất cả hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXuat_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpkTuNgay.Value;
            DateTime denNgay = dtpkDenNgay.Value;
            crHoaDon cr = new crHoaDon();
            cr.SetDataSource(busHoaDon.Instance.LayThongTinHoaDon(tuNgay, denNgay));
            fReport f = new fReport(cr);
            f.ShowDialog();
        }
        #endregion

    }
}
