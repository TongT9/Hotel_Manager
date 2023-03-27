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
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }

        public void LoadComBoBox()
        {
            cbLoaiPhong.DataSource = PhongBUS.ThongTinLP();
            cbLoaiPhong.DisplayMember = "TenLP";
            cbLoaiPhong.ValueMember = "MaLP";


            cbTinhTrang.Items.Add("Đầy");
            cbTinhTrang.Items.Add("Trống");
        }

        public void LoadTreeView(TreeView tree)
        {
            treeViewThongTin.Nodes.Clear();
            TreeNode nodeCha = new TreeNode();
            DataTable dtphong = new DataTable();
            dtphong = PhongBUS.ThongTinPhong();
            DataTable dtloaiphong = new DataTable();
            dtloaiphong = PhongBUS.ThongTinLP();
            int slphong = dtphong.Rows.Count;
            int sloaiphong = dtloaiphong.Rows.Count;
            for (int i = 0; i < sloaiphong; i++)
            {
                nodeCha = tree.Nodes.Add(dtloaiphong.Rows[i]["TenLP"].ToString());
                nodeCha.Tag = dtloaiphong.Rows[i]["MaLP"].ToString();
                for (int j = 0; j < slphong; j++)
                {
                    if (dtloaiphong.Rows[i]["MaLP"].ToString() == dtphong.Rows[j]["MaLP"].ToString())
                    {
                        TreeNode nodeCon = new TreeNode();
                        nodeCon.Text = "Tên Phòng:" + dtphong.Rows[j]["TenPhong"].ToString();
                        nodeCon.Tag = dtphong.Rows[j]["MaPhong"].ToString();
                        nodeCha.Nodes.Add(nodeCon);
                    }
                }
            }
        }

        public void LoadGridView(string MaLP)
        {
            DataTable dt = new DataTable();
            dt = PhongBUS.ThongTinPhongLoaiPhong(MaLP);
            DataThongTin.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            LoadTreeView(treeViewThongTin);
            LoadComBoBox();
        }

        private void treeViewThongTin_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtphong = new DataTable();
            string MaPhong;
            if (treeViewThongTin.SelectedNode.Parent == null)
            {
                string MaLP = treeViewThongTin.SelectedNode.Tag.ToString();
                LoadGridView(MaLP);
                cbLoaiPhong.Text = treeViewThongTin.SelectedNode.Text;
            }
            else
            {
                MaPhong = treeViewThongTin.SelectedNode.Tag.ToString();
                dtphong = PhongBUS.TTPhongChiTiet(MaPhong);
                txtMaPhong.Text = dtphong.Rows[0]["MaPhong"].ToString();
                txtTenPhong.Text = dtphong.Rows[0]["TenPhong"].ToString();
                string TinhTrang = (dtphong.Rows[0]["TinhTrang"].ToString() == "True") ? "Đầy" : "Trống";
                cbTinhTrang.Text = (TinhTrang);
                txtGiaPhong.Text = dtphong.Rows[0]["GiaPhong"].ToString();
                txtDonVi.Text = dtphong.Rows[0]["DonVi"].ToString();
                cbLoaiPhong.Text = treeViewThongTin.SelectedNode.Parent.Text;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhongBUS.ThongTinPhong();
            int sl = dt.Rows.Count + 1;
            txtMaPhong.Text = "MP" + string.Format("{0:000}", sl);
            txtTenPhong.Text = "";
            txtGiaPhong.Text = "";
            cbTinhTrang.Text = "";
            txtDonVi.Text = "";
            cbLoaiPhong.Text = "";
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            string MaLP = PhongBUS.LayMaLPQuaTen(cbLoaiPhong.Text);
            PhongDTO phong = new PhongDTO();
            phong.MaPhong = txtMaPhong.Text;
            phong.TenPhong = txtTenPhong.Text;
            phong.MaLP = PhongBUS.LayMaLPQuaTen(cbLoaiPhong.Text);
            phong.GiaPhong = txtGiaPhong.Text;
            phong.TinhTrang = cbTinhTrang.Text == "Đầy" ? "1" : "0";
            phong.DonVi = txtDonVi.Text;
            PhongBUS.luu_Phong(phong);
            LoadGridView(treeViewThongTin.SelectedNode.Tag.ToString());
            LoadTreeView(treeViewThongTin);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            PhongDTO phong = new PhongDTO();
            phong.MaPhong = txtMaPhong.Text;
            PhongBUS.xoa_Phong(phong);
            LoadGridView(treeViewThongTin.SelectedNode.Tag.ToString());
            LoadTreeView(treeViewThongTin);
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string MaLP = PhongBUS.LayMaLPQuaTen(cbLoaiPhong.Text);
            PhongDTO phong = new PhongDTO();
            phong.MaPhong = txtMaPhong.Text;
            phong.TenPhong = txtTenPhong.Text;
            phong.MaLP = PhongBUS.LayMaLPQuaTen(cbLoaiPhong.Text);
            phong.GiaPhong = txtGiaPhong.Text;
            phong.TinhTrang = cbTinhTrang.Text == "Đầy" ? "1" : "0";
            phong.DonVi = txtDonVi.Text;
            PhongBUS.capnhat_Phong(phong);
            LoadGridView(treeViewThongTin.SelectedNode.Tag.ToString());
            LoadTreeView(treeViewThongTin);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = DataThongTin.Rows[e.RowIndex];
            txtMaPhong.Text = row.Cells[0].Value.ToString();
            txtTenPhong.Text = row.Cells[2].Value.ToString();
            cbTinhTrang.Text = row.Cells[4].Value.ToString() == "True" ? "Đầy" : "Trống";
            txtGiaPhong.Text = row.Cells[3].Value.ToString();
            txtDonVi.Text = row.Cells[3].Value.ToString();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PhongBUS.TimKiem_Phong(txtTimKiem.Text);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Không có tên phòng");
            }
            DataThongTin.DataSource = dt;
        }
    }
}
