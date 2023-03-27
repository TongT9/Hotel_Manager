using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DAO;
using DoAnQuanLyKhachSan.Report;

namespace DoAnQuanLyKhachSan.Thống_Kê
{
    public partial class frm_thongkedoanhthu : Form
    {
        public frm_thongkedoanhthu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rdbtphong.Checked)
            {
                Excelphong();
                return;
            }
            if (rdbtdv.Checked)
            {
                ExcelDV();
                return;
            }
            if (rdbtall.Checked)
            {
                Excelall();
                return;
            }
        }

        private void TTPhong()
        {
            DataTable dt = new DataTable();
            dt = thongke.ThongTinDangKy();
            dataGridView1.DataSource = dt;
        }
        private void TTDV()
        {
            DataTable dt = new DataTable();
            dt = thongke.ThongTinDichVu();
            dataGridView1.DataSource = dt;
        }
        private void TTall()
        {
            DataTable dt = new DataTable();
            dt = thongke.ThongTinall();
            dataGridView1.DataSource = dt;
        }
        private void Excelphong()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Columns.ColumnWidth = 25;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

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
        private void ExcelDV()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Columns.ColumnWidth = 25;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

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
        private void Excelall()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Columns.ColumnWidth = 25;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

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
        public void click_radio()
        {
            
        }

        private void frm_thongkedoanhthu_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            dateTimePicker2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtphong.Checked)
            {
                TTPhong();
                return;
            }
            if (rdbtdv.Checked)
            {
                TTDV();
                return;
            }
            if (rdbtall.Checked)
            {
                TTall();
                return;
            }
        }

        private void rdbtall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtdv_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtall.Checked)
            {
                cbchung.Enabled = false;
                cbchung.SelectedIndex = -1;//khong chon thang nao
            }
            else
            {
                cbchung.Enabled = true;
                if (rdbtdv.Checked)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = thongke.ThongTinDichVu();
                    cbchung.DataSource = dt1;
                    cbchung.DisplayMember = "TenDV";
                    cbchung.ValueMember = "MaPDV";
                }
                else if (rdbtphong.Checked)
                {
                    DataTable dt = new DataTable();
                    dt = thongke.ThongTinDangKy();
                    cbchung.DataSource = dt;
                    cbchung.DisplayMember = "MaPhong";
                    cbchung.ValueMember = "MaPDK";
                }
                cbchung.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btquayve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
