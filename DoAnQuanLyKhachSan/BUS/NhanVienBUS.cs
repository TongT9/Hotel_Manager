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
    class NhanVienBUS
    {
        public static DataTable TimKiem_NhanVien(string key)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TimNhanVien(key);
            return dt;
        }

        public static DataTable ThongTinNhanVien()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.ThongTinNhanVien();
            return dt;
        }

        public static DataTable ThongTinChucVu()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.ThongTinChucVu();
            return dt;
        }

        public static DataTable TTCVQuaMaCV(string MaCV)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTCVQuaMaCV(MaCV);
            return dt;
        }

        public static string LayTenCVQuaMa(string MaCV)
        {
            return NhanVienDAO.LayTenCVQuaMa(MaCV);
        }

        public static string LayMaCVQuaTen(string TenCV)
        {
            return NhanVienDAO.LayMaCVQuaTen(TenCV);
        }

        public static void Luu_NhanVien(NhanVienDTO nv)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhanVienDAO.Luu_NhanVien(nv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu Không Thành Công!");
                }
            }
        }

        public static void xoa_NhanVien(NhanVienDTO nv)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhanVienDAO.xoa_NhanVien(nv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }

        public static void capnhat_NhanVien(NhanVienDTO nv)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhanVienDAO.capnhat_NhanVien(nv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}
