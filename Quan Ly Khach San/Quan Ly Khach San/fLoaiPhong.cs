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
    public partial class fLoaiPhong : Form
    {
        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        public fLoaiPhong()
        {
            InitializeComponent();
            dtgvLoaiPhong.DataSource = LoaiPhongSource;
            LoadLoaiPhong(busLoaiPhong.Instance.LayTatCaLoaiPhong());
            loadCTPTB(CTPTBsource);
            loadBinDing();
        }
        #region properties
        private List<dtoCTPTB> CTPTBsource = new List<dtoCTPTB>();
        BindingSource LoaiPhongSource = new BindingSource();
        #endregion
        #region method
        /// <summary>
        /// Load bnding vào các controls khi item selected in dtgv thay đổi thì thong tin các control thay đổi theo
        /// </summary>
        void loadBinDing()
        {
            txbMaLoai.DataBindings.Add(new Binding("Text", dtgvLoaiPhong.DataSource, "MALP", true, DataSourceUpdateMode.Never));
            lblMALPtemp.DataBindings.Add(new Binding("Text", dtgvLoaiPhong.DataSource, "MALP", true, DataSourceUpdateMode.Never));
            txbTen.DataBindings.Add(new Binding("Text", dtgvLoaiPhong.DataSource, "TenLP", true, DataSourceUpdateMode.Never));
            txbGia.DataBindings.Add(new Binding("Text", dtgvLoaiPhong.DataSource, "Gia", true, DataSourceUpdateMode.Never));
        }
        /// <summary>
        /// Load danh sach loại phòng vào dtgv
        /// </summary>
        /// <param name="list"></param>
        void LoadLoaiPhong(List<dtoLoaiPhong> list)
        {
            LoaiPhongSource.DataSource = list;
            dtgvLoaiPhong.Columns["Gia"].Visible = false;
            dtgvLoaiPhong.Columns["TenLP"].HeaderText = "Tên loại phòng";
            dtgvLoaiPhong.Columns["MALP"].HeaderText = "Mã loại phòng";
        }
        /// <summary>
        /// load danh sách thiết bị vào phòng
        /// </summary>
        /// <param name="list"></param>
        void loadCTPTB(List<dtoCTPTB> list)
        {
            dtgvThietBi.DataSource = list;
            dtgvThietBi.Columns["MALP"].Visible = false;
            dtgvThietBi.Columns["MATB"].Visible = false;
            dtgvThietBi.Columns["TenTB"].HeaderText = "Tên thiết bị";
            dtgvThietBi.Columns["SoLuong"].HeaderText = "Số Lượng";
        }
        #endregion

        #region event
        /// <summary>
        /// Thực hiện xóa loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMALPtemp.Text)) return;
            if (MessageBox.Show("Xóa loại phòng " + lblMALPtemp.Text + " sẽ xóa tất cả thông tin liên quan?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            if(!busLoaiPhong.Instance.xoaLoaiPhong(lblMALPtemp.Text))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Xóa " + lblMALPtemp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLoaiPhong(busLoaiPhong.Instance.LayTatCaLoaiPhong());
            loadCTPTB(new List<dtoCTPTB>());
            lblMALPtemp.Text = "";
        }
        /// <summary>
        /// Tìm kiếm loại phòng theo tên gần đúng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = Cons.xoakhoangtrang(txbTim.Text);
            LoadLoaiPhong(busLoaiPhong.Instance.LayTatCaLoaiPhongTheoTen(ten));
        }
        /// <summary>
        /// tim khi nhấn enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTim_Click(this, new EventArgs());
            }
        }
        /// <summary>
        /// chỉ cho nhập số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbGia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        /// <summary>
        /// binDing CTPTB theo MALP được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMALPtemp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMALPtemp.Text))
            {
                txbGia.Text = "";
                txbMaLoai.Text = "";
                txbTen.Text = "";
                return;
            }
            CTPTBsource = busCTPTB.Instance.LayCTPTBtheoLoaiPhong(lblMALPtemp.Text);
            loadCTPTB(CTPTBsource);
        }
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
        /// Xóa thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgvThietBi.SelectedCells.Count <= 0) return;
            string MATB = (string)dtgvThietBi.SelectedCells[0].OwningRow.Cells["MATB"].Value;
            List<dtoCTPTB> listNew = new List<dtoCTPTB>();
            foreach (dtoCTPTB item in CTPTBsource)
            {
                if (item.MATB == MATB)
                    continue;
                listNew.Add(item);
            }
            CTPTBsource.Clear();
            CTPTBsource = listNew;
            loadCTPTB(CTPTBsource);
        }
        /// <summary>
        /// Them thông tin thiết bị vào phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemThietBi f = new fThemThietBi();
            f.SentThietBi += F_SentThietBi;
            f.ShowDialog();
        }
        /// <summary>
        /// Thực hiện thêm thiết bị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_SentThietBi(object sender, ThietbiEvent e)
        {
            dtoThietBi ThietBi = e.ThietBi;
            int SoLuong = e.SoLuong;
            List<dtoCTPTB> listThietBi = new List<dtoCTPTB>();
            bool isTrung = false;
            foreach (dtoCTPTB item in CTPTBsource)
            {
                if(ThietBi.MATB==item.MATB)
                {
                    item.SoLuong += SoLuong;
                    isTrung = true;
                }
                listThietBi.Add(item);
            }
            if(!isTrung)
            {
                listThietBi.Add(new dtoCTPTB(lblMALPtemp.Text, ThietBi.MATB, ThietBi.TenTB, SoLuong));
            }
            CTPTBsource.Clear();
            CTPTBsource = listThietBi;
            loadCTPTB(CTPTBsource);
        }
        /// <summary>
        /// Cập nhật loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMALPtemp.Text)) return;
            string MALP = Cons.xoakhoangtrang(lblMALPtemp.Text);
            string TenLP = Cons.xoakhoangtrang(txbTen.Text);
            double Gia = 0;
            double.TryParse(Cons.xoakhoangtrang(txbGia.Text), out Gia);
            if (!busLoaiPhong.Instance.capNhatLoaiPhong(MALP,TenLP,Gia))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!busCTPTB.Instance.xoaCTPTBtheoMALP(MALP))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (dtoCTPTB item in CTPTBsource)
            {
                if (!busCTPTB.Instance.themCTPTBtheoMALP(MALP, item.MATB,item.SoLuong))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Cập nhật "+MALP+" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLoaiPhong(busLoaiPhong.Instance.LayTatCaLoaiPhong());
            loadCTPTB(new List<dtoCTPTB>());
            lblMALPtemp.Text = "";
        }
        /// <summary>
        /// Thêm mới loại phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MALP = Cons.xoakhoangtrang(txbMaLoai.Text);
            if (string.IsNullOrEmpty(MALP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string TenLP = Cons.xoakhoangtrang(txbTen.Text);
            double Gia = 0;
            double.TryParse(Cons.xoakhoangtrang(txbGia.Text),out Gia);
            if (!busLoaiPhong.Instance.themLoaiPhong(MALP, TenLP, Gia))
            {
                MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (dtoCTPTB item in CTPTBsource)
            {
                if (!busCTPTB.Instance.themCTPTBtheoMALP(MALP, item.MATB, item.SoLuong))
                {
                    MessageBox.Show("Vui lòng thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Thêm " + MALP + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLoaiPhong(busLoaiPhong.Instance.LayTatCaLoaiPhong());
            loadCTPTB(new List<dtoCTPTB>());
            lblMALPtemp.Text = "";
        }
        /// <summary>
        /// Không cho nhập enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbMaLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        #endregion
        
    }
}
