using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.DAO;

namespace DoAnQuanLyKhachSan.BUS
{
    class PhongBUS
    {
        public static DataTable TimKiem_Phong(string key)
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.TimKiemPhong(key);
            return dt;
        }

        public static DataTable ThongTinPhong()
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.ThongTinPhong();
            return dt;
        }

        public static DataTable ThongTinLP()
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.ThongTinLP();
            return dt;
        }

        public static DataTable ThongTinPhongThuocLoaiPhong(string MaPhong)
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.ThongTinPhongThuocLoaiPhong(MaPhong);
            return dt;
        }

        public static DataTable ThongTinPhongLoaiPhong(string MaLP)
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.ThongTinPhongLoaiPhong(MaLP);
            return dt;
        }

        public static DataTable TTPhongChiTiet(string MaPhong)
        {
            DataTable dt = new DataTable();
            dt = PhongDAO.TTPhongChiTiet(MaPhong);
            return dt;
        }

        public static string LayMaLPQuaTen(string TenLP)
        {
            return PhongDAO.LayMaLPQuaTen(TenLP);
        }

        public static void luu_Phong(PhongDTO phong)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhongDAO.luu_Phong(phong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu Không Thành Công!");
                }
            }
        }

        public static void capnhat_Phong(PhongDTO phong)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhongDAO.capnhat_Phong(phong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu Không Thành Công!");
                }
            }
        }

        public static void xoa_Phong(PhongDTO phong)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhongDAO.xoa_Phong(phong);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }
    }
}
