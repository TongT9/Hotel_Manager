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

namespace DoAnQuanLyKhachSan.GUI
{
    public partial class FormNoiQuy : Form
    {
        public FormNoiQuy()
        {
            InitializeComponent();
        }

        public void HienThiNoiQuyLenTextBox()
        {
            DataTable dt = new DataTable();
            dt = NoiQuyDAO.ThongTinNoiQuy();
            lb1.Text = dt.Rows[0]["NQ1"].ToString();
            lb2.Text = dt.Rows[0]["NQ2"].ToString();
            lb3.Text = dt.Rows[0]["NQ3"].ToString();
            lb4.Text = dt.Rows[0]["NQ4"].ToString();
            lb5.Text = dt.Rows[0]["NQ5"].ToString();
        }
        private void FormNoiQuy_Load(object sender, EventArgs e)
        {
            HienThiNoiQuyLenTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
