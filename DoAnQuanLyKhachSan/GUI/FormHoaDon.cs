using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.DAO;
using DoAnQuanLyKhachSan.Report;

namespace DoAnQuanLyKhachSan
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        public void tthd()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinHoaDon();
            dtgvhoadon.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btIn_Click(object sender, EventArgs e)
        {
            FormBill frm = new FormBill();
            frm.MaHD = lbHoaDon.SelectedValue.ToString();
            frm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = txtMaHD.Text;
            HoaDonBUS.xoa_HoaDon(hd);
            tthd();
            HienThiNhanVienLenLB();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string MaNV = HoaDonBUS.LayMaNVQuaTen(cbTenNV.Text);
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = txtMaHD.Text;
            hd.MaNV = HoaDonBUS.LayMaNVQuaTen(cbTenNV.Text);
            hd.makh = HoaDonBUS.LayMaKHQuaTen(cbTenKH.Text);
            hd.maphong = HoaDonBUS.LayMaPhongQuaTen(cbTenPhong.Text);
            hd.malp = HoaDonBUS.LayMaLoaiPhongQuaTen(cbTenLoaiPhong.Text);
            hd.MaBooking = HoaDonBUS.LayMaBookingQuaTen(cbTenBooking.Text);
            hd.NgayThanhToan = String.Format("{0:MM/dd/yyyy}", dtpNgayThanhToan.Value);
            hd.SoTienDatTruoc = txtSoTienDatTruoc.Text;
            hd.DonVi = txtDonVi.Text;
            hd.tongtien = txtTongTien.Text;
            HoaDonBUS.capnhat_HoaDon(hd);
            tthd();
            HienThiNhanVienLenLB();
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            string MaNV = HoaDonBUS.LayMaNVQuaTen(cbTenNV.Text);
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaHD = txtMaHD.Text;
            hd.MaNV = HoaDonBUS.LayMaNVQuaTen(cbTenNV.Text);
            hd.makh = HoaDonBUS.LayMaKHQuaTen(cbTenKH.Text);
            hd.maphong = HoaDonBUS.LayMaPhongQuaTen(cbTenPhong.Text);
            hd.malp = HoaDonBUS.LayMaLoaiPhongQuaTen(cbTenLoaiPhong.Text);
            hd.MaBooking = HoaDonBUS.LayMaBookingQuaTen(cbTenBooking.Text);
            hd.NgayThanhToan = String.Format("{0:MM/dd/yyyy}", dtpNgayThanhToan.Value);
            hd.SoTienDatTruoc = txtSoTienDatTruoc.Text;
            hd.DonVi = txtDonVi.Text;
            hd.tongtien = txtTongTien.Text;
            HoaDonBUS.luu_HoaDon(hd);
            tthd();
            HienThiNhanVienLenLB();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sohd = (lbHoaDon.Items.Count + 1).ToString("#000");
            txtMaHD.Text = "HD" + sohd;
            cbTenNV.Text = "";
            dtpNgayThanhToan.Text = "";
            txtSoTienDatTruoc.Text = "";
            txtDonVi.Text = "";
            cbTenKH.Text = "";
            cbTenPhong.Text = "";
            cbTenLoaiPhong.Text = "";
            cbTenBooking.Text = "";
            txtTongTien.Text = "";
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HienThiNhanVienLenLB()
        {
            DataTable dt = new DataTable();
            dt = HoaDonBUS.ThongTinHoaDon();
            lbHoaDon.DataSource = dt;
            int soluong = dt.Rows.Count + 1;
            lbHoaDon.ValueMember = "MaHD";
            txtMaHD.Text = "HD00" + soluong;
        }

        public void TT_NhanVien()
        {
            DataTable dt = new DataTable();
            dt = HoaDonBUS.ThongTinNhanVien();
            int sonv = dt.Rows.Count;
            for (int i = 0; i < sonv; i++)
            {
                cbTenNV.Items.Add(dt.Rows[i]["HoTenNV"].ToString());
            }
            cbTenNV.SelectedIndex = 0;
        }

        private void HienThiNhanVienLenTextBox()
        {
            DataTable dt = new DataTable();
            dt = HoaDonBUS.ThongTinHoaDonChiTiet(lbHoaDon.SelectedValue.ToString());
            txtMaHD.Text = dt.Rows[0]["MaHD"].ToString();
            cbTenNV.Text = HoaDonBUS.LayTenNVQuaMa(dt.Rows[0]["MaNV"].ToString());
            cbTenKH.Text = HoaDonBUS.LayTenKHQuaMa(dt.Rows[0]["MaKH"].ToString());
            cbTenPhong.Text = HoaDonBUS.LayTenPhongQuaMa(dt.Rows[0]["MaPhong"].ToString());
            cbTenLoaiPhong.Text = HoaDonBUS.LayTenLoaiPhongQuaMa(dt.Rows[0]["MaLP"].ToString());
            cbTenBooking.Text = HoaDonBUS.LayTenBookingQuaMa(dt.Rows[0]["Mabooking"].ToString());
            dtpNgayThanhToan.Text = dt.Rows[0]["NgayThanhToan"].ToString();
            txtSoTienDatTruoc.Text = dt.Rows[0]["SoTienDatTruoc"].ToString();
            txtDonVi.Text = dt.Rows[0]["DonVi"].ToString();
            txtTongTien.Text = dt.Rows[0]["tongtien"].ToString();
        }
      

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            HienThiNhanVienLenLB();
            HienThiNhanVienLenTextBox();
            TT_NhanVien();
            tthd();
            HienThiKhachhang();
            HienThiTenPhong();
            HienThiLoaiPhong();
            HienThiBooking();
        }

        private void lbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHoaDon.SelectedValue.ToString() != "System.Data.DataRowView")
                HienThiNhanVienLenTextBox();
        }

        private void dtgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sd = e.RowIndex;
            txtMaHD.Text = dtgvhoadon.Rows[sd].Cells[0].Value.ToString();
            cbTenNV.Text = dtgvhoadon.Rows[sd].Cells[1].Value.ToString();
            dtpNgayThanhToan.Text = dtgvhoadon.Rows[sd].Cells[2].Value.ToString();
            txtSoTienDatTruoc.Text = dtgvhoadon.Rows[sd].Cells[3].Value.ToString();
            txtDonVi.Text = dtgvhoadon.Rows[sd].Cells[4].Value.ToString();
            cbTenKH.Text = dtgvhoadon.Rows[sd].Cells[5].Value.ToString();
            cbTenPhong.Text = dtgvhoadon.Rows[sd].Cells[6].Value.ToString();
            cbTenLoaiPhong.Text = dtgvhoadon.Rows[sd].Cells[7].Value.ToString();
            cbTenBooking.Text = dtgvhoadon.Rows[sd].Cells[8].Value.ToString();
            txtTongTien.Text = dtgvhoadon.Rows[sd].Cells[9].Value.ToString();
        }

        private void bntxuatexcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Columns.ColumnWidth = 25;
            for(int i=1;i<dtgvhoadon.Columns.Count + 1;i++)
            {
                app.Cells[1, i] = dtgvhoadon.Columns[i -1].HeaderText;
            }    

            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";



            for (int i = 0; i < dtgvhoadon.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgvhoadon.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtgvhoadon.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
        public void HienThiKhachhang()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinKhachHang();
            cbTenKH.DataSource = dt;
            cbTenKH.DisplayMember = "HoTenKH";
            cbTenKH.ValueMember = "MaKH";
        }

        public void HienThiLoaiPhong()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinLoaiPhong();
            cbTenLoaiPhong.DataSource = dt;
            cbTenLoaiPhong.DisplayMember = "TenLP";
            cbTenLoaiPhong.ValueMember = "MaLP";
        }

        public void HienThiBooking()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinBooking();
            cbTenBooking.DataSource = dt;
            cbTenBooking.DisplayMember = "Tenbooking";
            cbTenBooking.ValueMember = "Mabooking";
        }
        public void HienThiTenPhong()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinTenPhong();
            cbTenPhong.DataSource = dt;
            cbTenPhong.DisplayMember = "TenPhong";
            cbTenPhong.ValueMember = "MaPhong";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
