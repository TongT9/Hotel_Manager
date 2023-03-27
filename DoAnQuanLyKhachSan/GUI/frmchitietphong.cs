using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;
using DoAnQuanLyKhachSan.DAO;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.Report;


namespace DoAnQuanLyKhachSan.GUI
{
    public partial class frmchitietphong : Form
    {
        public frmbooking objManHinhChinh;
        public frmchitietphong()
        {
            InitializeComponent();
        }

        public frmchitietphong(frmbooking frm)
        {
            InitializeComponent();
            frmbooking objbooking = frm;
        }

        public void hiencbTenKH()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.hiencbTenKH();
            cbTenKH.DataSource = dt;
            cbTenKH.DisplayMember = "HoTenKH";
            cbTenKH.ValueMember = "MaKH";
        }
        public void hiencbloaiphong()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.hiencbphong();
            cmbLoaiPhong.DataSource = dt;
            cmbLoaiPhong.DisplayMember = "TenLP";
            cmbLoaiPhong.ValueMember = "MaLP";
        }
        public void hiencbmaphieu()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.TTPhong();
            cbMaPhieu.DataSource = dt;
            cbMaPhieu.DisplayMember = "maphieu";
            cbMaPhieu.ValueMember = "maphieu";
        }
        public void hiencbbooking()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.hiencbbooking();
            cmbTenBooking.DataSource = dt;
            cmbTenBooking.DisplayMember = "TenBooking";
            cmbTenBooking.ValueMember = "MaBooking";
        }
        public void hiencbsophong()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.hiencbsophong();
            cmbSoPhong.DataSource = dt;
            cmbSoPhong.DisplayMember = "TenPhong";
            cmbSoPhong.ValueMember = "MaPhong";
        }
        public void hiencbdv()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.hiencbdv();
            cmbTenDichVu.DataSource = dt;
            cmbTenDichVu.DisplayMember = "TenDV";
            cmbTenDichVu.ValueMember = "MaPDV";
        }

        public void hiencbtinhtrang()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.hiencbtrinhtrang();
            cbTinhTrang.DataSource = dt;
            cbTinhTrang.DisplayMember = "TinhTrang";
            cbTinhTrang.ValueMember = "TinhTrang";
        }
        
        //bindgrid khi chương trình tắt đi mở lên vẫn còn dl
        private void BindGrid(List<chitietphieuDTO> listDichVu)
        {
            dgvChiTietDichVu.Rows.Clear();
            foreach (var item in listDichVu)
            {
                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value =item.maphieu;
                dgvChiTietDichVu.Rows[index].Cells[1].Value = item.mapdv;
                dgvChiTietDichVu.Rows[index].Cells[2].Value = item.giadv;
                dgvChiTietDichVu.Rows[index].Cells[3].Value = item.giaphong;
                dgvChiTietDichVu.Rows[index].Cells[4].Value = item.makh;
                dgvChiTietDichVu.Rows[index].Cells[5].Value = item.ngaydi;
                dgvChiTietDichVu.Rows[index].Cells[6].Value = item.ngayvao;
                dgvChiTietDichVu.Rows[index].Cells[7].Value = item.quoctich;
                dgvChiTietDichVu.Rows[index].Cells[8].Value = item.sodem;
                dgvChiTietDichVu.Rows[index].Cells[9].Value = item.sokhach;
                dgvChiTietDichVu.Rows[index].Cells[10].Value = item.soluong;
                dgvChiTietDichVu.Rows[index].Cells[11].Value = item.sophong;
                dgvChiTietDichVu.Rows[index].Cells[12].Value = item.tenbooking;
                dgvChiTietDichVu.Rows[index].Cells[13].Value = item.tendv;
                dgvChiTietDichVu.Rows[index].Cells[14].Value = item.tenlp;
                dgvChiTietDichVu.Rows[index].Cells[15].Value = item.thanhtien;
                dgvChiTietDichVu.Rows[index].Cells[16].Value = item.thanhtiendv;
            }
        }

        private void Hiendata()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.ThongTinHD();
            SqlDataAdapter dap = new SqlDataAdapter();
            dgvChiTietDichVu.DataSource = dt;
            dgvChiTietDichVu.Refresh();
        }


        private void HienThiThongTin()
        {
            hiencbmaphieu();
            Hiendata();
            hiencbsophong();
            hiencbloaiphong();
            hiencbdv();
            hiencbtinhtrang();
            hiencbTenKH();
        }
        private void frmchitietphong_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void btnThemCuaCTPP_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = chitietphieuBUS.tangmaphieudangky();
            int sl = dt.Rows.Count + 1;
            cbMaPhieu.Text = "CTP" + string.Format("{0:000}", sl);
            cmbTenDichVu.Text = "";
            txtChiTietSoDem.Text = "";
            txtChiTietGiaPhong.Text = "";
            txtChiTietQuocTich.Text = "";
            cbTenKH.Text = "";
            txtgiadv.Text = "";
            txtSoLuong.Text = "";
            txtsokhach.Text = "";
            cbTinhTrang.Text = "";
            cmbLoaiPhong.Text = "";
            cmbTenBooking.Text = "";
            cmbSoPhong.Text = "";
           
        }

        private void btnXoaCuaCTPP_Click(object sender, EventArgs e)
        { 
            chitietphieuDTO ct = new chitietphieuDTO();
            ct.maphieu = cbMaPhieu.Text;
            chitietphieuBUS.xoaphieu(ct);
            HienThiThongTin();
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuuCuaCTPP_Click(object sender, EventArgs e)
        {
            string MaPhong = chitietphieuBUS.LayMaPhongQuaTen(cmbSoPhong.Text);
            string MaLP = chitietphieuBUS.LayMaLPQuaTen(cmbLoaiPhong.Text);
            string MaPDV = chitietphieuBUS.LayMaDichVuQuaTen(cmbTenDichVu.Text);
            string Mabooking = chitietphieuBUS.LayMabookingQuaTen(cmbTenBooking.Text);
            string MaKH = chitietphieuBUS.LayMaKhachHangQuaTen(cbTenKH.Text);
            chitietphieuDTO ct = new chitietphieuDTO();
            ct.maphieu = cbMaPhieu.Text;
            ct.mapdv = chitietphieuBUS.LayMaDichVuQuaTen(cmbTenDichVu.Text);
            ct.soluong = txtSoLuong.Text;
            ct.giadv = txtgiadv.Text;
            ct.thanhtiendv = lbthanhtiendv.Text;
            ct.malp = chitietphieuBUS.LayMaLPQuaTen(cmbLoaiPhong.Text);
            ct.maphong = chitietphieuBUS.LayMaPhongQuaTen(cmbSoPhong.Text);
            ct.mabooking = chitietphieuBUS.LayMabookingQuaTen(cmbTenBooking.Text);
            ct.sokhach = txtsokhach.Text;
            ct.giaphong = txtChiTietGiaPhong.Text;
            ct.makh = chitietphieuBUS.LayMaKhachHangQuaTen(cbTenKH.Text);
            ct.quoctich = txtChiTietQuocTich.Text;
            ct.sodem = txtChiTietSoDem.Text;
            ct.thanhtien = lblThanhTien.Text;
            ct.tinhtrang = cbTinhTrang.SelectedValue.ToString();
            string ngayvao = string.Format("{0:MM/dd/yyyy}", dtpNgayDen.Value);
            ct.ngayvao = ngayvao;
            string ngaydii = string.Format("{0:MM/dd/yyyy}", dtpNgayDi.Value);
            ct.ngaydi = ngaydii;

            chitietphieuBUS.them(ct);
            HienThiThongTin();
        }
           

        private void lblThanhTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblThanhTien.Text = (int.Parse(txtChiTietGiaPhong.Text) * int.Parse(txtChiTietSoDem.Text)).ToString();
            }
            catch
            {
                lblThanhTien.Text = "";
            }
        }

        private void cmbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSoPhong.SelectedValue != null)
                {
                    PhongDTO objPHong = new PhongDTO();
                    if (objPHong != null)
                    {
                        txtChiTietGiaPhong.Text = objPHong.GiaPhong.ToString();
                    }
                }
            }
            catch { }
        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtChiTietGiaPhong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblThanhTien.Text = (int.Parse(txtChiTietGiaPhong.Text) * int.Parse(txtChiTietSoDem.Text)).ToString();
            }
            catch
            {
                lblThanhTien.Text = "";
            }
        }

        private void txtgiadv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbthanhtiendv.Text = (int.Parse(txtgiadv.Text) * int.Parse(txtSoLuong.Text)).ToString();
            }
            catch
            {
                lbthanhtiendv.Text = "";
            }
        }

        private void txttongcong_TextChanged(object sender, EventArgs e)
        {
            
        }
        public bool checkObject()
        {
            if (string.IsNullOrWhiteSpace(txtChiTietGiaPhong.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiTietGiaPhong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtgiadv.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiadv.Focus();
                return false;
            }
            return true;
        }

        private void btnTTCuaCTPP_Click(object sender, EventArgs e)
        {
            if (checkObject())
            {
                if (checkObject()==true)
                {
                    try
                    {
                        lbTongThanhToan.Text = (int.Parse(lblThanhTien.Text) + int.Parse(lbthanhtiendv.Text)).ToString();
                    }
                    catch
                    {
                        lbTongThanhToan.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thết!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

       private void dgvChiTietDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvChiTietDichVu.Rows[e.RowIndex];
            cbMaPhieu.Text = row.Cells[0].Value.ToString();
            cmbTenDichVu.Text = row.Cells[1].Value.ToString();
         
            txtSoLuong.Text = row.Cells[2].Value.ToString();
            txtgiadv.Text = row.Cells[3].Value.ToString();
            lblThanhTien.Text = row.Cells[4].Value.ToString();
            cmbSoPhong.Text = row.Cells[5].Value.ToString();
            cmbTenBooking.Text = row.Cells[6].Value.ToString();
            txtsokhach.Text = row.Cells[7].Value.ToString();
            dtpNgayDen.Text = row.Cells[8].Value.ToString();
            txtChiTietGiaPhong.Text = row.Cells[9].Value.ToString();
            cmbLoaiPhong.Text = row.Cells[10].Value.ToString();
            cbTenKH.Text = row.Cells[11].Value.ToString();
            txtChiTietQuocTich.Text = row.Cells[12].Value.ToString();
            dtpNgayDi.Text = row.Cells[13].Value.ToString();
            txtChiTietSoDem.Text = row.Cells[14].Value.ToString();
            lbthanhtiendv.Text = row.Cells[15].Value.ToString();
            cbTinhTrang.Text = row.Cells[16].Value.ToString();
        }

        private void btnTTCuaCTPP_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btquayve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string tenbooking { get; set; }
        public  string tenkhach { get; set; }
        public string sokhach { get; set; }
        public string quoctich { get; set; }
        public string ngayden { get; set; }
        public string ngaydi { get; set; }
        public string trangthai { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            tenbooking = cmbTenBooking.Text;
            tenkhach = cbTenKH.Text;
            sokhach = txtsokhach.Text;
            quoctich = txtChiTietQuocTich.Text;
            ngayden = String.Format("{0:MM/dd/yyyy}", dtpNgayDen.Value);
            ngaydi = String.Format("{0:MM/dd/yyyy}", dtpNgayDi.Value);
            trangthai = cbTinhTrang.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();           
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

        }

        private void btnInCuaCTPP_Click(object sender, EventArgs e)
        {
            btnInCuaCTPP.BackColor = Color.Red;
            FormReportHoaDon rpnv = new FormReportHoaDon();
            rpnv.ShowDialog();
        }

        private void cbMaPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            string MaPhong = chitietphieuBUS.LayMaPhongQuaTen(cmbSoPhong.Text);
            string MaLP = chitietphieuBUS.LayMaLPQuaTen(cmbLoaiPhong.Text);
            string MaPDV = chitietphieuBUS.LayMaDichVuQuaTen(cmbTenDichVu.Text);
            string Mabooking = chitietphieuBUS.LayMabookingQuaTen(cmbTenBooking.Text);
            string MaKH = chitietphieuBUS.LayMaKhachHangQuaTen(cbTenKH.Text);
            chitietphieuDTO ct = new chitietphieuDTO();
            ct.maphieu = cbMaPhieu.Text;
            ct.mapdv = chitietphieuBUS.LayMaDichVuQuaTen(cmbTenDichVu.Text);
            ct.soluong = txtSoLuong.Text;
            ct.giadv = txtgiadv.Text;
            ct.thanhtiendv = lbthanhtiendv.Text;
            ct.malp = chitietphieuBUS.LayMaLPQuaTen(cmbLoaiPhong.Text);
            ct.maphong = chitietphieuBUS.LayMaPhongQuaTen(cmbSoPhong.Text);
            ct.mabooking = chitietphieuBUS.LayMabookingQuaTen(cmbTenBooking.Text);
            ct.sokhach = txtsokhach.Text;
            ct.giaphong = txtChiTietGiaPhong.Text;
            ct.makh = chitietphieuBUS.LayMaKhachHangQuaTen(cbTenKH.Text);
            ct.quoctich = txtChiTietQuocTich.Text;
            ct.sodem = txtChiTietSoDem.Text;
            ct.thanhtien = lblThanhTien.Text;
            ct.tinhtrang = cbTinhTrang.SelectedValue.ToString();
            string ngayvao = string.Format("{0:MM/dd/yyyy}", dtpNgayDen.Value);
            ct.ngayvao = ngayvao;
            string ngaydii = string.Format("{0:MM/dd/yyyy}", dtpNgayDi.Value);
            ct.ngaydi = ngaydii;

            chitietphieuBUS.capnhat(ct);
            HienThiThongTin();
        }
    }
}
