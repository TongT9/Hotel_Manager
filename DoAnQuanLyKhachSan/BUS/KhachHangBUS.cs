using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.DAO;

namespace DoAnQuanLyKhachSan.BUS
{
    class KhachHangBUS
    {
        public static DataTable TimKiem_KhachHang(string key)
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.TimKhachHang(key);
            return dt;
        }

        public static DataTable ThongTinKH()
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.ThongTinKH();
            return dt;
        }

        public static DataTable ThongTinChiTietKH(string MaKH)
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.ThongTinChiTietKH(MaKH);
            return dt;
        }


        public static void luu_KhachHang(KhachHangDTO kh)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachHangDAO.luu_KhachHang(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu Không Thành Công!");
                }
            }
        }

        public static void xoa_KhachHang(KhachHangDTO kh)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachHangDAO.xoa_KhachHang(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }

        public static void capnhat_KhachHang(KhachHangDTO kh)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachHangDAO.capnhat_KhachHang(kh);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}