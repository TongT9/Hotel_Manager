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
    public partial class FormLoaiPhong : Form
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
        }
        public void hiencb()
        {
            DataTable dt = new DataTable();
            dt = LoaiPhongBUS.hiencb();
            cbloaiphong.DataSource = dt;
            cbloaiphong.DisplayMember = "MaLP";
            cbloaiphong.ValueMember = "MaLP";
        }

        public void hientt()
        {
            DataTable dt = new DataTable();
            dt = LoaiPhongBUS.hientt(cbloaiphong.SelectedValue.ToString());
            int sol = dt.Rows.Count;
            for (int i = 0; i < sol; i++)
            {
                cbloaiphong.Text = dt.Rows[0]["MaLP"].ToString();
                txtloaiphong.Text = dt.Rows[0]["TenLP"].ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnganh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbnganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbloaiphong.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                hientt();
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            LoaiPhongDTO pb = new LoaiPhongDTO();
            pb.MaLP = cbloaiphong.Text;
            pb.TenLP = txtloaiphong.Text;
            LoaiPhongBUS.capnhat(pb);
            hientt();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            LoaiPhongDTO pb = new LoaiPhongDTO();
            pb.MaLP = cbloaiphong.Text;
            LoaiPhongBUS.xoa(pb);
            hientt();
            hiencb();
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            LoaiPhongDTO pb = new LoaiPhongDTO();
            pb.MaLP = cbloaiphong.Text;
            pb.TenLP = txtloaiphong.Text;
            LoaiPhongBUS.luu(pb);
            hientt();
            hiencb();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable pb = new DataTable();
            pb = LoaiPhongBUS.mahh_tang();
            int sllp = pb.Rows.Count + 1;
            string solp = pb.Rows[0][0].ToString();
            int sl = Convert.ToInt32(solp.Substring(solp.Length - 3, 3)) + 1;
            cbloaiphong.Text = "LP" + String.Format("{0:000}", sl);
            txtloaiphong.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            hiencb();
            hientt();
        }
    }
}
