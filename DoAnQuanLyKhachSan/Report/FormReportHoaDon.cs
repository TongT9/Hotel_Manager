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
    public partial class FormReportHoaDon : Form
    {
        public FormReportHoaDon()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.ThongTinReport();
            CrystalReportHoaDon cry = new CrystalReportHoaDon();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
