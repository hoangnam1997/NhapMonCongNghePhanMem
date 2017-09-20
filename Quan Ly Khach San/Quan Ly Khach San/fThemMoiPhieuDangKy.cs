using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San
{
    public partial class fThemMoiPhieuDangKy : Form
    {
        /// <summary>
        /// hàm khỏi tạo phiếu dăng ký
        /// </summary>
        /// <param name="nhanVienLogin"></param>
        public fThemMoiPhieuDangKy(dtoNhanVien nhanVienLogin)
        {
            InitializeComponent();
            this.NhanVienLogin = nhanVienLogin;
            dtgvDSPhong.DataSource = PhongSource;
            LoadDSPhong(DanhSachPhongSource);
            lblTemp.DataBindings.Add(new Binding("Text", dtgvDSPhong.DataSource, "MAP", true, DataSourceUpdateMode.Never));
            loadDSKhachHang(DanhSachKhachSource);
        }
        #region properties
        dtoNhanVien NhanVienLogin;
        List<dtoPhong> DanhSachPhongSource = new List<dtoPhong>();
        List<dtoKhachHang> DanhSachKhachSource = new List<dtoKhachHang>();
        List<dtoCTPDK> DanhSachCTPDK = new List<dtoCTPDK>();
        BindingSource PhongSource = new BindingSource();
        private dtoKhachHang khachHangDangKy = null;
        #endregion
        #region method
        /// <summary>
        /// Load danh sách phòng, lấy dánh sách phòng và trạng thái của phong lên dtgv
        /// </summary>
        /// <param name="result"></param>
        void LoadDSPhong(List<dtoPhong> result)
        {
            PhongSource.DataSource = result;
            dtgvDSPhong.Columns["MAP"].Visible = false;
            dtgvDSPhong.Columns["MALP"].Visible = false;
            dtgvDSPhong.Columns["TinhTrang"].Visible = false;
            dtgvDSPhong.Columns["SoKhachToiDa"].HeaderText = "Số khách tối đa";
            dtgvDSPhong.Columns["TenPhong"].HeaderText = "Tên phòng";
            dtgvDSPhong.Columns["GhiChu"].HeaderText = "Ghi chú";
            dtgvDSPhong.Refresh();
        }
        /// <summary>
        /// Load danh sách khách len dtgv
        /// </summary>
        /// <param name="result"></param>
        void loadDSKhachHang(List<dtoKhachHang> result)
        {
            dtgvDSKhach.DataSource = result;
            dtgvDSKhach.Columns["CMND"].HeaderText = "Chứng minh nhân dân";
            dtgvDSKhach.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dtgvDSKhach.Columns["GioiTinh"].Visible = false;
            dtgvDSKhach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgvDSKhach.Columns["DiaChi"].Visible = false;
            dtgvDSKhach.Columns["MAQT"].Visible = false;
            dtgvDSKhach.Refresh();
        }
        #endregion
        #region event
        /// <summary>
        /// Thoát khỏi form thêm mới phiếu đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Thực hiện thêm phòng, mở giao diện thêm phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemPhongDangKy f = new fThemPhongDangKy(dtpkThoiGianDen.Value, dtpkDuKhienTraPhong.Value);
            f.SentPhong += F_SentPhong;
            f.ShowDialog();
        }
        /// <summary>
        /// Thêm vào phòng khi có sự kiên gửi phòng về
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_SentPhong(object sender, PhongEvent e)
        {
            dtgvDSPhong.ClearSelection();
            dtgvDSPhong.CurrentCell = null;
            if (dtgvDSPhong.Rows.Count > 1)
            {
                dtgvDSPhong.CurrentCell = dtgvDSPhong.Rows[0].Cells["TenPhong"];
            }
            List<dtoPhong> dsNew = new List<dtoPhong>();
            foreach (dtoPhong item in DanhSachPhongSource)
            {
                if (item.MAP == e.Result.MAP) return;
                dsNew.Add(item);
            }
            DanhSachPhongSource.Clear();
            dsNew.Add(e.Result);
            DanhSachPhongSource = dsNew;
            PhongSource.DataSource = DanhSachPhongSource;
            dtgvDSPhong.Refresh();
        }
        /// <summary>
        /// Xoa danh sách phòng đã chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaPhongDangChonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dtgvDSPhong.SelectedCells.Count <= 0) return;
            List<string> map = new List<string>();
            for (int i = 0; i < dtgvDSPhong.SelectedCells.Count; i++)
            {
                map.Add((string)dtgvDSPhong.SelectedCells[i].OwningRow.Cells["MAP"].Value);
            }
            List<dtoPhong> listNew = new List<dtoPhong>();
            //Loai bo nhung dtoPhong
            foreach (dtoPhong item in DanhSachPhongSource)
            {
                bool isTrung = false;
                foreach (string items in map)
                {
                    if (item.MAP == items)
                    {
                        isTrung = true;
                        break;
                    }
                }
                if (!isTrung)
                {
                    listNew.Add(item);
                }
            }
            DanhSachPhongSource.Clear();
            DanhSachPhongSource = listNew;
            PhongSource.DataSource = DanhSachPhongSource;
            dtgvDSPhong.Refresh();

        }
        /// <summary>
        /// Xoa tat ca danh sachphong dang trong list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaTatCaPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachPhongSource.Clear();
            DanhSachPhongSource = new List<dtoPhong>();
            PhongSource.DataSource = DanhSachPhongSource;
            dtgvDSPhong.Refresh();
        }
        /// <summary>
        /// Them khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemKhachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần thêm khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtoPhong phong = busPhong.Instance.LayTheoMaPhong(lblTemp.Text);
            int count = 0;
            foreach (dtoCTPDK item in DanhSachCTPDK)
            {
                if (item.MAP == phong.MAP)
                {
                    count++;
                }
            }
            if (count >= phong.SoKhachToiDa)
            {
                MessageBox.Show("Phòng đã đạt số khách tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fThemKhachHang f = new fThemKhachHang();
            f.sentKhachHang += F_sentKhachHang;
            f.ShowDialog();
        }
        /// <summary>
        /// Them khách hàng khi có sự kiện gửi về
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_sentKhachHang(object sender, KhachHangevent e)
        {
            if (e.Result == null) return;
            dtgvDSKhach.ClearSelection();
            dtgvDSKhach.CurrentCell = null;
            if (string.IsNullOrEmpty(lblTemp.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtoPhong phong = busPhong.Instance.LayTheoMaPhong(lblTemp.Text);
            int count = 0;
            foreach (dtoCTPDK item in DanhSachCTPDK)
            {
                if (item.MAP == phong.MAP)
                {
                    count++;
                }
            }
            if (count >= phong.SoKhachToiDa)
            {
                MessageBox.Show("Phòng đã đạt số khách tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<dtoKhachHang> listNew = new List<dtoKhachHang>();
            foreach (dtoKhachHang item in DanhSachKhachSource)
            {
                if (item.CMND == e.Result.CMND)
                    return;
                listNew.Add(item);

            }
            listNew.Add(e.Result);
            DanhSachCTPDK.Add(new dtoCTPDK(e.Result.CMND, null, lblTemp.Text));
            DanhSachKhachSource = listNew;
            dtgvDSKhach.DataSource = DanhSachKhachSource;
            dtgvDSKhach.Refresh();
        }
        /// <summary>
        /// Xóa danh sách khách đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaKhachDangChonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvDSKhach.SelectedCells.Count <= 0) return;
            string MAP = lblTemp.Text;
            string cmnd = (string)dtgvDSKhach.SelectedCells[0].OwningRow.Cells["CMND"].Value;
            List<dtoCTPDK> listNew = new List<dtoCTPDK>();
            foreach (dtoCTPDK item in DanhSachCTPDK)
            {
                if (item.CMND == cmnd && item.MAP == MAP)
                {
                    continue;
                }
                listNew.Add(item);
            }
            DanhSachCTPDK = listNew;
            lblTemp_TextChanged(this, new EventArgs());
        }
        /// <summary>
        /// Xóa tất cả khách hàng củ phòng đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaTatCaKhachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtgvDSKhach.SelectedCells.Count <= 0) return;
            string MAP = lblTemp.Text;
            foreach (dtoCTPDK item in DanhSachCTPDK)
            {
                if (item.MAP == MAP)
                {
                    DanhSachCTPDK.Remove(item);
                    if (DanhSachCTPDK.Count <= 0)
                        break;
                }

            }
            lblTemp_TextChanged(this, new EventArgs());
        }
        /// <summary>
        /// Load thông tin khách hàng trong phong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTemp_TextChanged(object sender, EventArgs e)
        {
            dtgvDSKhach.DataSource = null;
            DanhSachKhachSource = new List<dtoKhachHang>();
            if (string.IsNullOrEmpty(lblTemp.Text)) return;
            DanhSachKhachSource.Clear();
            DanhSachKhachSource = new List<dtoKhachHang>();
            foreach (dtoCTPDK item in DanhSachCTPDK)
            {
                if (lblTemp.Text == item.MAP)
                {
                    DanhSachKhachSource.Add(busKhachHang.Instance.LayTheoCMNDKhachHang(item.CMND));
                }
            }
            loadDSKhachHang(DanhSachKhachSource);
        }
        /// <summary>
        /// Thực hiện thêm mới phiếu đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (khachHangDangKy == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime TuNgay = dtpkThoiGianDen.Value;
            DateTime DenNgay = dtpkDuKhienTraPhong.Value;
            string MAPDK = Cons.Random(10);
            int trangThai = 0;
            dtoNhanVien NhanVien = this.NhanVienLogin;
            dtoKhachHang khachhangdk = khachHangDangKy;
            //kiem tra so luong phong
            if (DanhSachPhongSource.Count <= 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại, phải có ít nhất một phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // kiem tra tat ca cac phong phai co it nhat 1 khach, kiem tra phong co hop le khong
            List<dtoPhong> listResult = busPhong.Instance.LayDanhSachPhongHopLe(TuNgay, DenNgay);
            int countPhongHopLe = DanhSachPhongSource.Count;
            foreach (dtoPhong item in DanhSachPhongSource)
            {
                int countKhach = 0;
                bool isHopLe = false;
                foreach (dtoPhong itemPhong in listResult)
                {
                    if (item.MAP == itemPhong.MAP)
                    {
                        isHopLe = true;
                    }
                }
                if (!isHopLe)
                {
                    MessageBox.Show("Phòng " + item.MAP + " đã có khách huê trong thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (dtoCTPDK itemKhach in DanhSachCTPDK)
                {
                    if (item.MAP == itemKhach.MAP)
                        countKhach++;
                }
                if (countKhach == 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại, tất cả phòng phải có ít nhất một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (!busPhieuDangKy.Instance.themPhieuDangKy(MAPDK, khachhangdk.CMND, NhanVien.MANV, TuNgay, DenNgay, trangThai))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (dtoCTPDK item in DanhSachCTPDK)
            {
                if (!busCTPDK.Instance.themCTPDK(item.CMND, MAPDK, item.MAP))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (MessageBox.Show("Xác nhận khách đã đến?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                List<dtoPhong> Lphong = busPhong.Instance.LayTheoMAPDK(MAPDK);
                bool isHople = true;
                foreach (dtoPhong item in Lphong)
                {
                    if (item.TinhTrang != 0)
                    {
                        isHople = false;
                    }
                }
                if (isHople)
                {
                    if (!busPhieuDangKy.Instance.updateDaDenPhieuDangKy(MAPDK))
                    {
                        MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Phòng đang trong trạng thái không thể thêm khách hàng ở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDSPhong(new List<dtoPhong>());
            loadDSKhachHang(new List<dtoKhachHang>());
            khachHangDangKy = null;

        }
        /// <summary>
        /// Thêm thông tin khách đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKhachDangKy_Click(object sender, EventArgs e)
        {
            fThemKhachHang f = new fThemKhachHang(khachHangDangKy);
            f.sentKhachHang += F_sentKhachHangDangKy;
            f.ShowDialog();
        }
        /// <summary>
        /// Thêm thông tin khách đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_sentKhachHangDangKy(object sender, KhachHangevent e)
        {
            this.khachHangDangKy = e.Result;
        }
        #endregion

    }
}
