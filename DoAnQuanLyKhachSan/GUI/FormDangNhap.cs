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
using DoAnQuanLyKhachSan.GUI;


namespace DoAnQuanLyKhachSan
{
    public partial class FormDangNhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3M231FL\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MaTK FROM TAIKHOAN where TenDangNhap = '" + txtTenDangNhap.Text + "' and MatKhau = '" + txtMatKhau.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                FormMeNu ss = new FormMeNu(dt.Rows[0][0].ToString());
                ss.Show();
            }
            else
            {
                string message = "Sai tài khoản mật khẩu Vui lòng nhập lại!";
                MessageBox.Show(message);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
            }
        }
            

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
