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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        public void hiencb()
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanBUS.hiencb();
            cbtaikhoan.DataSource = dt;
            cbtaikhoan.DisplayMember = "MaTK";
            cbtaikhoan.ValueMember = "MaTK";
        }

        public void hienlist()
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanDAO.hientt();
            listdanhsach.DataSource = dt;
            listdanhsach.DisplayMember = "TenDangNhap";
            listdanhsach.ValueMember = "MaTK";
        }

        public void TTlistds()
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanBUS.hienlistds(listdanhsach.SelectedValue.ToString());
            cbtaikhoan.Text = dt.Rows[0]["MaTK"].ToString();
            txtdangnhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
            txtmatkhau.Text = dt.Rows[0]["MatKhau"].ToString();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            hiencb();
            hienlist();
        }

        private void listdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (listdanhsach.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                TTlistds();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable pb = new DataTable();
            pb = TaiKhoanBUS.mahh_tang();
            int slhh = pb.Rows.Count + 1;
            string matk = pb.Rows[0][0].ToString();
            int sl = Convert.ToInt32(matk.Substring(matk.Length - 2, 2)) + 1;
            cbtaikhoan.Text = "TK" + String.Format("{0:000}", sl);
            txtdangnhap.Text = "";
            txtmatkhau.Text = "";
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO pb = new TaiKhoanDTO();
            pb.MaTK = cbtaikhoan.Text;
            pb.TenDangNhap = txtdangnhap.Text;
            pb.MatKhau = txtmatkhau.Text;
            TaiKhoanBUS.luu(pb);
            hiencb();
            hienlist();
            TTlistds();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            TaiKhoanDTO pb = new TaiKhoanDTO();
            pb.MaTK = cbtaikhoan.Text;
            pb.TenDangNhap = txtdangnhap.Text;
            pb.MatKhau = txtmatkhau.Text;
            TaiKhoanBUS.capnhat(pb);
            hiencb();
            hienlist();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            TaiKhoanDTO pb = new TaiKhoanDTO();
            pb.MaTK = cbtaikhoan.Text;
            TaiKhoanBUS.xoa(pb);
            hiencb();
            hienlist();
        }

        private void btquayve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
