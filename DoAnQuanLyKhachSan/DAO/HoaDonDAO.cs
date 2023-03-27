using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;

namespace DoAnQuanLyKhachSan.DAO
{
    class HoaDonDAO
    {
        public static DataTable ThongTinHoaDon()
        {
            string sql = "select MaHD, HoTenNV, NgayThanhToan, SoTienDatTruoc, hd.DonVi, HoTenKH, TenPhong, TenLP, Tenbooking, tongtien from NHANVIEN nv, HOADON hd, Booking bk, PHONG p, LOAIPHONG lp, KHACHHANG kh where nv.MaNV = hd.MaNV  and kh.MaKH = hd.MaKH and p.MaPhong = hd.MaPhong and lp.MaLP = hd.MaLP and bk.Mabooking = hd.MaBooking";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinNhanVien()
        {
            string sql = "select * from NHANVIEN";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinKhachHang()
        {
            string sql = "select * from KHACHHANG";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinTenPhong()
        {
            string sql = "select * from PHONG";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinLoaiPhong()
        {
            string sql = "select * from LOAIPHONG";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinBooking()
        {
            string sql = "select * from Booking";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static string LayTenNVQuaMa(string MaNV)
        {
            string sql = "select HoTenNV, MaNV from NHANVIEN where MaNV = '" + MaNV + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["HoTenNV"].ToString();
        }

        public static string LayTenKHQuaMa(string MaKH)
        {
            string sql = "select HoTenKH, MaKH from KHACHHANG where MaKH = '" + MaKH + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["HoTenKH"].ToString();
        }

        public static string LayTenPhongQuaMa(string MaPhong)
        {
            string sql = "select TenPhong, MaPhong from PHONG where MaPhong = '" + MaPhong + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["TenPhong"].ToString();
        }

        public static string LayTenLoaiPhongQuaMa(string MaLP)
        {
            string sql = "select TenLP, MaLP from LOAIPHONG where MaLP = '" + MaLP + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["TenLP"].ToString();
        }

        public static string LayTenBookingQuaMa(string Mabooking)
        {
            string sql = "select Tenbooking, Mabooking from Booking where Mabooking = '" + Mabooking + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["Tenbooking"].ToString();
        }



        public static string LayMaNVQuaTen(string HoTenNV)
        {
            string sql = "select HoTenNV, MaNV from NHANVIEN where HoTenNV = N'" + HoTenNV + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaNV"].ToString();
        }

        public static string LayMaKHQuaTen(string HoTenKH)
        {
            string sql = "select HoTenKH, MaKH from KHACHHANG where HoTenKH = N'" + HoTenKH + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaKH"].ToString();
        }

        public static string LayMaPhongQuaTen(string TenPhong)
        {
            string sql = "select TenPhong, MaPhong from PHONG where TenPhong = N'" + TenPhong + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaPhong"].ToString();
        }

        public static string LayMaLoaiPhongQuaTen(string TenLP)
        {
            string sql = "select TenLP, MaLP from LOAIPHONG where TenLP = N'" + TenLP + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaLP"].ToString();
        }

        public static string LayMaBookingQuaTen(string Tenbooking)
        {
            string sql = "select Tenbooking, Mabooking from Booking where Tenbooking = N'" + Tenbooking + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["Mabooking"].ToString();
        }


        public static DataTable ThongTinHoaDonChiTiet(string MaHD)
        {
            string sql = "Select *From HOADON where MaHD='" + MaHD + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void luu_HoaDon(HoaDonDTO hd)
        {
            string sql = "INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('" + hd.MaHD + "', '"
              + hd.MaNV + "', '" + hd.makh + "', '" + hd.maphong + "', '" + hd.malp + "', '" + hd.MaBooking + "','" + hd.NgayThanhToan + "', '" + hd.SoTienDatTruoc + "', '" + hd.tongtien + "', '" + hd.DonVi + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoa_HoaDon(HoaDonDTO hd)
        {
            string sql = "Delete From HOADON where MaHD='" + hd.MaHD + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat_HoaDon(HoaDonDTO hd)
        {
            string sql = "Update HOADON set MaNV='" + hd.MaNV + "', MaKH='" + hd.makh + "', MaPhong='" + hd.maphong + "', MaLP='" + hd.malp + "', MaBooking='" + hd.MaBooking + "',NgayThanhToan='" + hd.NgayThanhToan + "', SoTienDatTruoc='" + hd.SoTienDatTruoc + "', tongtien='" + hd.tongtien + "', DonVi='" + hd.DonVi + "' where MaHD = '" + hd.MaHD + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static DataTable ThongTinReportBill(string MaHD)
        {
            string sql = "select MaHD, TenBooking, HoTenKH, TenPhong, TenLP, NgayThanhToan, SoTienDatTruoc, tongtien, hd.DonVi from HOADON hd, Booking bk, KHACHHANG kh, PHONG p, LOAIPHONG lp where hd.MaBooking=bk.Mabooking and hd.MaKH=kh.MaKH and hd.MaPhong = p.MaPhong and lp.MaLP=hd.MaLP and MaHD = '"+ MaHD +"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
