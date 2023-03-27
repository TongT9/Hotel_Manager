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
using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.Thống_Kê;
using DoAnQuanLyKhachSan.GUI;



namespace DoAnQuanLyKhachSan
{
    public partial class FormMeNu : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3M231FL\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");

        public FormMeNu(string MaTK)
        {
            InitializeComponent();
            lbChucVu.Text = MaTK;
        }

      //  public FormMeNu(string p)
        //{
           
        //}

        private void FormMeNu_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CHUCVU c,TAIKHOAN t,NHANVIEN n where c.MaCV = n.MaCV and t.MaTK=n.MaTK and t.MaTK = '" + lbChucVu.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    lbMaTaiKhoan.Text = dr["TenCV"].ToString();
                }
            }
            if (lbMaTaiKhoan.Text != "Admin")
            {
                taiToolStripMenuItem.Enabled = false;
                DoiMatKhauTool.Enabled = false;
                chiTiếtHóaĐơnToolStripMenuItem.Enabled = false;

            }
        }

        private void DoiMatKhauTool_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TAIKHOAN where MaTK = '" + lbChucVu.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                FormDoiMatKhau ss = new FormDoiMatKhau(dt.Rows[0][0].ToString());
                ss.ShowDialog();
                this.Show();
            }
        }

        private void DangXuatTool_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap ss = new FormDangNhap();
            ss.Show();
        }

        private void thôngTinChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChucVu ss = new FormChucVu();
            ss.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaiKhoan ss = new FormTaiKhoan();
            ss.Show();
        }

        private void ThongTinNhanVienTool_Click(object sender, EventArgs e)
        {
            FormNhanVien ss = new FormNhanVien();
            ss.Show();
        }

        private void ThongTinSachTool_Click(object sender, EventArgs e)
        {
            FormKhachHang ss = new FormKhachHang();
            ss.Show();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon ss = new FormHoaDon();
            ss.Show();
        }

        private void thôngTinLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiPhong ss = new FormLoaiPhong();
            ss.Show();
        }

        private void ThongTinDocGiaTool_Click(object sender, EventArgs e)
        {
            FormPhong ss = new FormPhong();
            ss.Show();
        }

        private void btPhieuMuon_Click(object sender, EventArgs e)
        {
            FormPhieuDangky ss = new FormPhieuDangky();
            ss.Show();
        }

        private void btTheThuVien_Click(object sender, EventArgs e)
        {
            FormPhieuDichVu ss = new FormPhieuDichVu();
            ss.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thongkedoanhthu dthu = new frm_thongkedoanhthu();
            dthu.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitietphong ctpp = new frmchitietphong();
            ctpp.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbooking ctpp = new frmbooking();
            ctpp.Show();
        }

        private void nộiQuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoiQuy ctpp = new FormNoiQuy();
            ctpp.Show();
        }

        private void nộiQuyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormNoiQuy ctpp = new FormNoiQuy();
            ctpp.Show();
        }
    }
}
