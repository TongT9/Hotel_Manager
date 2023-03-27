using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan
{
    public partial class FormChucVu : Form
    {
        public FormChucVu()
        {
            InitializeComponent();
        }

        public void hiencb()
        {
            DataTable dt = new DataTable();
            dt = ChucVuBUS.hiencb();
            cbmacv.DataSource = dt;
            cbmacv.DisplayMember = "MaCV";
            cbmacv.ValueMember = "MaCV";
        }

        public void hientt()
        {
            DataTable dt = new DataTable();
            dt = ChucVuBUS.hientt(cbmacv.SelectedValue.ToString());
            int sol = dt.Rows.Count;
            for (int i = 0; i < sol; i++)
            {
                cbmacv.Text = dt.Rows[0]["MaCV"].ToString();
                txttencv.Text = dt.Rows[0]["TenCV"].ToString();
            }
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            hiencb();
            hientt();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable pb = new DataTable();
            pb = ChucVuBUS.mahh_tang();
            int slhd = pb.Rows.Count + 1;
            string sohd = pb.Rows[0][0].ToString();
            int sl = Convert.ToInt32(sohd.Substring(sohd.Length - 3, 3)) + 1;
            cbmacv.Text = "CV" + String.Format("{0:000}", sl);
            txttencv.Text = "";
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            ChucVuDTO pb = new ChucVuDTO();
            pb.MaCV = cbmacv.Text;
            pb.TenCV = txttencv.Text;
            ChucVuBUS.luu(pb);
            hientt();
            hiencb();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            ChucVuDTO pb = new ChucVuDTO();
            pb.MaCV = cbmacv.Text;
            pb.TenCV = txttencv.Text;
            ChucVuBUS.capnhat(pb);
            hientt();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            ChucVuDTO pb = new ChucVuDTO();
            pb.MaCV = cbmacv.Text;
            ChucVuBUS.xoa(pb);
            hientt();
            hiencb();
        }

        private void cbmacv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbmacv.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                hientt();
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
