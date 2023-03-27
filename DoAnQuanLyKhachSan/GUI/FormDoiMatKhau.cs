using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan
{
    public partial class FormDoiMatKhau : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3M231FL\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        public FormDoiMatKhau(string MaTK)
        {
            InitializeComponent();
            lbAn.Text = MaTK;
        }

        private void btDoi_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT MatKhau FROM TAIKHOAN where MaTK ='" + lbAn.Text + "' and MatKhau = '" + txtMatKhauCu.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhauMoi.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TAIKHOAN SET MatKhau='" + txtNhapLaiMatKhauMoi.Text + "' where MatKhau='" + txtMatKhauCu.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string message = "Đổi mật khẩu thành công!";
                    MessageBox.Show(message);
                    txtMatKhauCu.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtNhapLaiMatKhauMoi.Text = "";
                }
                else
                {
                    string message = "Vui lòng nhập lại mật khẩu!";
                    MessageBox.Show(message);
                    txtMatKhauCu.Text = "";
                    txtMatKhauMoi.Text = "";
                    txtNhapLaiMatKhauMoi.Text = "";
                    txtNhapLaiMatKhauMoi.Focus();
                }

            }
            else
            {
                string message = "Sai mật khẩu cũ!";
                MessageBox.Show(message);
                txtMatKhauCu.Text = "";
                txtMatKhauMoi.Text = "";
                txtNhapLaiMatKhauMoi.Text = "";
                txtMatKhauCu.Focus();
            }
        }

        private void btQuayVe_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TAIKHOAN where MaTK = '" + lbAn.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
            }
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
