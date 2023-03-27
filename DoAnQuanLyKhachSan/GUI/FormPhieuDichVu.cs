using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.DAO;

namespace DoAnQuanLyKhachSan
{
    public partial class FormPhieuDichVu : Form
    {
        public FormPhieuDichVu()
        {
            InitializeComponent();
        }

        private void Hiendata()
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuDAO.ThongTinDichVu();
            SqlDataAdapter dap = new SqlDataAdapter();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void HienThiPhieuDVLenCombobox()
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuDAO.ThongTinDichVu();
            comboBox1.DisplayMember = "MaPDV";
            comboBox1.ValueMember = "MaPDV";
            comboBox1.DataSource = dt;
            dataGridView1.DataSource = dt;
        }

        private void FormPhieuDichVu_Load(object sender, EventArgs e)
        {
            HienThiPhieuDVLenCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuDAO.ThongTinDichVu();
            int sl = dt.Rows.Count + 1;
            comboBox1.Text = "PDV" + string.Format("{0:000}", sl);
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuDichVuDTO dv = new PhieuDichVuDTO();
            dv.MaPDV = comboBox1.Text;
            dv.TenDV = textBox2.Text;
            dv.GiaDV = textBox3.Text;
            PhieuDichVuBUS.luu(dv);
            HienThiPhieuDVLenCombobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuDAO.TTChiTietPhieuDV(comboBox1.SelectedValue.ToString());
            comboBox1.Text = dt.Rows[0]["MaPDV"].ToString();
            textBox2.Text = dt.Rows[0]["TenDV"].ToString();
            textBox3.Text = dt.Rows[0]["GiaDV"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuDichVuDTO dv = new PhieuDichVuDTO();
            dv.MaPDV = comboBox1.Text;
            dv.TenDV = textBox2.Text;
            dv.GiaDV = textBox3.Text;
            PhieuDichVuBUS.capnhat(dv);
            HienThiPhieuDVLenCombobox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhieuDichVuDTO dv = new PhieuDichVuDTO();
            dv.MaPDV = comboBox1.Text;
            PhieuDichVuBUS.xoa(dv);
            HienThiPhieuDVLenCombobox();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuBUS.TimPhieuDichVu(textBox1.Text);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Không có tên sách");
            }
            dataGridView1.DataSource = dt;
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";



            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            Hiendata();
        }
    }
}
