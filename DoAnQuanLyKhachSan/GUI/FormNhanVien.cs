using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.BUS;
using DoAnQuanLyKhachSan.DAO;

namespace DoAnQuanLyKhachSan
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        public void HienThiNVLenTextBox()
        {
            DataTable dt = new DataTable();
            dt = NhanVienBUS.ThongTinNhanVien();
            int sonv = dt.Rows.Count;
            for (int i = 0; i < sonv; i++)
            {
                string gioitinh = (dt.Rows[i]["GioiTinh"].ToString() == "True") ? "Nam" : "Nữ";
                lvDanhSach.Items.Add(dt.Rows[i]["MaNV"].ToString());
                lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["HoTenNV"].ToString());
                lvDanhSach.Items[i].SubItems.Add(gioitinh);
                lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["NgaySinh"].ToString());
                lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["MaCV"].ToString());
            }
        }

        public void TT_PHONGBAN()
        {
            DataTable dt = new DataTable();
            dt = NhanVienBUS.ThongTinChucVu();
            int sonv = dt.Rows.Count;
            for (int i = 0; i < sonv; i++)
            {
                cbChucVu.Items.Add(dt.Rows[i]["TenCV"].ToString());
            }
            cbChucVu.SelectedIndex = 0;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            TT_PHONGBAN();
            HienThiNVLenTextBox();
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvDanhSach.SelectedIndices.Count == 0) return;
            txtMaNV.Text = lvDanhSach.SelectedItems[0].SubItems[0].Text;
            txtHoTen.Text = lvDanhSach.SelectedItems[0].SubItems[1].Text;
            if ("Nam" == lvDanhSach.SelectedItems[0].SubItems[2].Text)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            dtpNgaySinh.Text = lvDanhSach.SelectedItems[0].SubItems[3].Text;
            txtSDT.Text = lvDanhSach.SelectedItems[0].SubItems[4].Text;
            txtDiaChi.Text = lvDanhSach.SelectedItems[0].SubItems[5].Text;
            cbChucVu.Text = NhanVienBUS.LayTenCVQuaMa(lvDanhSach.SelectedItems[0].SubItems[6].Text);
        }

        private void XoaTrangThongTin()
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = "";
            cbChucVu.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienBUS.ThongTinNhanVien();
            int sl = dt.Rows.Count + 1;
            txtMaNV.Text = "NV" + string.Format("{0:000}", sl);
            XoaTrangThongTin();
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            string MaCV = NhanVienBUS.LayMaCVQuaTen(cbChucVu.Text);
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTenNV = txtHoTen.Text;
            if (rdNam.Checked == true) nv.GioiTinh = "1";
            if (rdNu.Checked == true) nv.GioiTinh = "0";
            nv.NgaySinh = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            nv.DiaChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;
            nv.MaCV = NhanVienBUS.LayMaCVQuaTen(cbChucVu.Text);
            lvDanhSach.Items.Clear();
            NhanVienBUS.Luu_NhanVien(nv);
            HienThiNVLenTextBox();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string MaCV = NhanVienBUS.LayMaCVQuaTen(cbChucVu.Text);
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTenNV = txtHoTen.Text;
            if (rdNam.Checked == true) nv.GioiTinh = "1";
            if (rdNu.Checked == true) nv.GioiTinh = "0";
            nv.NgaySinh = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            nv.DiaChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;
            nv.MaCV = NhanVienBUS.LayMaCVQuaTen(cbChucVu.Text);
            lvDanhSach.Items.Clear();
            NhanVienBUS.capnhat_NhanVien(nv);
            HienThiNVLenTextBox();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtMaNV.Text;
            NhanVienBUS.xoa_NhanVien(nv);
            lvDanhSach.Items.Clear();
            HienThiNVLenTextBox();
            XoaTrangThongTin();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            lvDanhSach.Items.Clear();
            DataTable dt = new DataTable();
            dt = NhanVienBUS.TimKiem_NhanVien(textBox1.Text);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Không có tên nhân viên");
            }
            else
            {
                int sonv = dt.Rows.Count;
                for (int i = 0; i < sonv; i++)
                {
                    string gioitinh = (dt.Rows[i]["GioiTinh"].ToString() == "True") ? "Nam" : "Nữ";
                    lvDanhSach.Items.Add(dt.Rows[i]["MaNV"].ToString());
                    lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["HoTenNV"].ToString());
                    lvDanhSach.Items[i].SubItems.Add(gioitinh);
                    lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["NgaySinh"].ToString());
                    lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                    lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                    lvDanhSach.Items[i].SubItems.Add(dt.Rows[i]["MaCV"].ToString());
                }
            }
        }

        private void btds_Click(object sender, EventArgs e)
        {
            lvDanhSach.Items.Clear();
            HienThiNVLenTextBox();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
