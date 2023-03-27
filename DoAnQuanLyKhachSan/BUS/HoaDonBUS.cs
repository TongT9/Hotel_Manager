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
    class HoaDonBUS
    {
        public static DataTable ThongTinHoaDon()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinHoaDon();
            return dt;
        }

        public static DataTable ThongTinHoaDonChiTiet(string MaHD)
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinHoaDonChiTiet(MaHD);
            return dt;
        }

        public static DataTable ThongTinNhanVien()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ThongTinNhanVien();
            return dt;
        }

        public static string LayTenNVQuaMa(string MaNV)
        {
            return HoaDonDAO.LayTenNVQuaMa(MaNV);
        }

        public static string LayTenKHQuaMa(string MaKH)
        {
            return HoaDonDAO.LayTenKHQuaMa(MaKH);
        }
        public static string LayTenPhongQuaMa(string MaPhong)
        {
            return HoaDonDAO.LayTenPhongQuaMa(MaPhong);
        }

        public static string LayTenLoaiPhongQuaMa(string MaLP)
        {
            return HoaDonDAO.LayTenLoaiPhongQuaMa(MaLP);
        }
        public static string LayTenBookingQuaMa(string Mabooking)
        {
            return HoaDonDAO.LayTenBookingQuaMa(Mabooking);
        }

      


        public static string LayMaNVQuaTen(string HoTenNV)
        {
            return HoaDonDAO.LayMaNVQuaTen(HoTenNV);
        }

        public static string LayMaKHQuaTen(string HoTenKH)
        {
            return HoaDonDAO.LayMaKHQuaTen(HoTenKH);
        }
        public static string LayMaPhongQuaTen(string TenPhong)
        {
            return HoaDonDAO.LayMaPhongQuaTen(TenPhong);
        }
        public static string LayMaLoaiPhongQuaTen(string TenLP)
        {
            return HoaDonDAO.LayMaLoaiPhongQuaTen(TenLP);
        }
        public static string LayMaBookingQuaTen(string Tenbooking)
        {
            return HoaDonDAO.LayMaBookingQuaTen(Tenbooking);
        }
        public static void luu_HoaDon(HoaDonDTO hd)
        {
            if (MessageBox.Show("Bạn Có Muốn Lưu?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    HoaDonDAO.luu_HoaDon(hd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu Không Thành Công!");
                }
            }
        }

        public static void xoa_HoaDon(HoaDonDTO hd)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    HoaDonDAO.xoa_HoaDon(hd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }

        public static void capnhat_HoaDon(HoaDonDTO hd)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật?", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    HoaDonDAO.capnhat_HoaDon(hd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }

    }
}