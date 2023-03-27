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
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.DAO;

namespace DoAnQuanLyKhachSan
{
    public partial class FormPhieuDangky : Form
    {
        public FormPhieuDangky()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void HienThiKHLenCombobox()
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.ThongTinKH();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "HoTenKH";
            comboBox2.ValueMember = "MaKH";
        }
        private void HienThiNVLenCombobox()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.ThongTinNhanVien();
            cbTenNV.DataSource = dt;
            cbTenNV.DisplayMember = "HoTenNV";
            cbTenNV.ValueMember = "MaNV";
        }
        private void HienThiMaphongLenCombobox()
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.ThongTinPhong();
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "TenPhong";
            comboBox3.ValueMember = "MaPhong";
        }
        private void HienThiPhieuDVLenCombobox()
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuDAO.ThongTinDichVu();
            cbMaPDV.DisplayMember = "TenDV";
            cbMaPDV.ValueMember = "MaPDV";
            cbMaPDV.DataSource = dt;
        }
        private void HienThiPhieuDKLenCombobox()
        {
            DataTable dt = new DataTable();
            dt = PhieuDangKyDAO.ThongTinDangKy();
            comboBox1.DisplayMember = "MaPDK";
            comboBox1.ValueMember = "MaPDK";
            comboBox1.DataSource = dt;
            dataGridView1.DataSource = dt;
        }

        private void Hiendata()
        {
            DataTable dt = new DataTable();
            dt = PhieuDangKyDAO.ThongTindata();
            SqlDataAdapter dap = new SqlDataAdapter();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void HienThiThongTin()
        {
            HienThiKHLenCombobox();
            HienThiNVLenCombobox();
            HienThiMaphongLenCombobox();
            HienThiPhieuDVLenCombobox();
            HienThiPhieuDKLenCombobox();
            HienThiNgay();
            Hiendata();
        }
        private void HienThiNgay()
        {
            dateTimePicker1.Value = System.DateTime.Now;
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
        }

        private void FormPhieuDangky_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieuDangKyDAO.TTChiTietPhieuDangKy(comboBox1.SelectedValue.ToString());
            comboBox1.Text = dt.Rows[0]["MaPDK"].ToString();
            comboBox2.Text = dt.Rows[0]["HoTenKH"].ToString();
            comboBox3.Text = dt.Rows[0]["TenPhong"].ToString();
            cbTenNV.Text = dt.Rows[0]["HoTenNV"].ToString();
            cbMaPDV.Text = dt.Rows[0]["TenDV"].ToString();
            dateTimePicker1.Text = dt.Rows[0]["NgayLap"].ToString();
            dateTimePicker2.Text = dt.Rows[0]["NgayDi"].ToString();
            textBox2.Text = dt.Rows[0]["DonVi"].ToString();
            textBox3.Text = dt.Rows[0]["TraTruoc"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieuDangKyDAO.ThongTinDangKy();
            int sl = dt.Rows.Count + 1;
            comboBox1.Text = "PDK" + string.Format("{0:000}", sl);
            comboBox2.Text = "";
            comboBox3.Text = "";
            cbMaPDV.Text = "";
            cbTenNV.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuDangKyDTO dk = new PhieuDangKyDTO();
            dk.MaPDK = comboBox1.Text;
            dk.MaKH = comboBox2.SelectedValue.ToString();
            dk.MaPhong = comboBox3.SelectedValue.ToString();
            dk.MaNV = cbTenNV.SelectedValue.ToString();
            dk.MaPDV = cbMaPDV.SelectedValue.ToString();
            string NgayLap = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            dk.NgayLap = NgayLap;
            string NgayDi = string.Format("{0:MM/dd/yyyy}", dateTimePicker2.Value);
            dk.NgayDi = NgayDi;
            dk.TraTruoc = textBox3.Text;
            dk.DonVi = textBox2.Text;
            PhieuDangKyBUS.luu(dk);
            HienThiThongTin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuDangKyDTO dk = new PhieuDangKyDTO();
            dk.MaPDK = comboBox1.Text;
            dk.MaKH = comboBox2.SelectedValue.ToString();
            dk.MaPhong = comboBox3.SelectedValue.ToString();
            dk.MaNV = cbTenNV.SelectedValue.ToString();
            dk.MaPDV = cbMaPDV.SelectedValue.ToString();
            string NgayLap = string.Format("{0:MM/dd/yyyy}", dateTimePicker1.Value);
            dk.NgayLap = NgayLap;
            string NgayDi = string.Format("{0:MM/dd/yyyy}", dateTimePicker2.Value);
            dk.NgayDi = NgayDi;
            dk.TraTruoc = textBox3.Text;
            dk.DonVi = textBox2.Text;
            PhieuDangKyBUS.capnhat(dk);
            HienThiThongTin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhieuDangKyDTO dk = new PhieuDangKyDTO();
            dk.MaPDK = comboBox1.Text;
            PhieuDangKyBUS.xoa(dk);
            HienThiThongTin();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
            dt = PhieuDangKyBUS.TimPhieuDangKy(textBox1.Text);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Không có tên sách");
            }
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            comboBox1.Text = row.Cells[0].Value.ToString();
            comboBox2.Text = row.Cells[1].Value.ToString();
            comboBox3.Text = row.Cells[2].Value.ToString();
            cbTenNV.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Text = row.Cells[4].Value.ToString();
            dateTimePicker2.Text = row.Cells[5].Value.ToString();
            cbMaPDV.Text = row.Cells[6].Value.ToString();
            textBox2.Text = row.Cells[7].Value.ToString();
            textBox3.Text = row.Cells[8].Value.ToString();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            Hiendata();
        }
    }
    }

