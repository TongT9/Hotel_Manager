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

namespace DoAnQuanLyKhachSan.Report
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        public string MaHD;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinReportBill(MaHD);
            CrystalReportBillHD cry = new CrystalReportBillHD();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
