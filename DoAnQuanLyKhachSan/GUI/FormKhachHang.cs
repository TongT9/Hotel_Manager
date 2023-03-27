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

namespace DoAnQuanLyKhachSan
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HienThiKHLenCB()
        {
            DataTable dt = new DataTable();
            dt = KhachHangBUS.ThongTinKH();
            cbKhachHang.DataSource = dt;
            int soluong = dt.Rows.Count + 1;
            cbKhachHang.DisplayMember = "HoTenKH";
            cbKhachHang.ValueMember = "MaKH";
            txtMaKH.Text = "KH00" + soluong;
        }

        private void HienThiKHLenTextBox()
        {
            DataTable dt = new DataTable();
            dt = KhachHangBUS.ThongTinChiTietKH(cbKhachHang.SelectedValue.ToString());
            txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
            txtHoTen.Text = dt.Rows[0]["HoTenKH"].ToString();
            if ("True" == dt.Rows[0]["GioiTinh"].ToString())
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            txtQuocTich.Text = dt.Rows[0]["QuocTich"].ToString();
            txtCMND.Text = dt.Rows[0]["CMND"].ToString();

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            HienThiKHLenCB();
            HienThiKHLenTextBox();
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhachHang.SelectedValue.ToString() != "System.Data.DataRowView")
                HienThiKHLenTextBox();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sokh = (cbKhachHang.Items.Count + 1).ToString("#000");
            txtMaKH.Text = "KH" + sokh;
            cbKhachHang.Text = "";
            txtHoTen.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtQuocTich.Text = "";
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txtMaKH.Text;
            kh.HoTenKH = txtHoTen.Text;
            if (rdNam.Checked == true) kh.GioiTinh = "1";
            if (rdNu.Checked == true) kh.GioiTinh = "0";
            kh.SDT = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.CMND = txtCMND.Text;
            kh.QuocTich = txtQuocTich.Text;
            KhachHangBUS.luu_KhachHang(kh);
            HienThiKHLenCB();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txtMaKH.Text;
            KhachHangBUS.xoa_KhachHang(kh);
            HienThiKHLenCB();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH = txtMaKH.Text;
            kh.HoTenKH = txtHoTen.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            if (rdNam.Checked == true) kh.GioiTinh = "1";
            if (rdNu.Checked == true) kh.GioiTinh = "0";
            kh.CMND = txtCMND.Text;
            kh.QuocTich = txtQuocTich.Text;
            KhachHangBUS.capnhat_KhachHang(kh);
            HienThiKHLenCB();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
            dt = KhachHangBUS.TimKiem_KhachHang(textBox1.Text);
            if (dt.Rows.Count > 0)
            {
                cbKhachHang.Text = dt.Rows[0]["HoTenKH"].ToString();
                txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
                txtHoTen.Text = dt.Rows[0]["HoTenKH"].ToString();
                if ("True" == dt.Rows[0]["GioiTinh"].ToString())
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtQuocTich.Text = dt.Rows[0]["QuocTich"].ToString();
                txtCMND.Text = dt.Rows[0]["CMND"].ToString();
            }
            else
            {
                MessageBox.Show("Không có khách hàng!");
            }
        }
        }
}

