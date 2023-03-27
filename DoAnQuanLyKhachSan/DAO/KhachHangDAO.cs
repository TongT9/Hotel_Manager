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
    class KhachHangDAO
    {
        public static DataTable TimKhachHang(string key)
        {
            string sql = "select * from KHACHHANG where HoTenKH like N'%" + key + "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinKH()
        {
            string sql = "Select *From KHACHHANG";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinChiTietKH(string MaKH)
        {
            string sql = "Select *From KHACHHANG where MaKH='" + MaKH + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void luu_KhachHang(KhachHangDTO kh)
        {
            string sql = "INSERT INTO KHACHHANG(MaKH, HoTenKH, DiaChi, GioiTinh, CMND ,SDT, QuocTich) VALUES('" + kh.MaKH + "',N'"
              + kh.HoTenKH + "', N'" + kh.DiaChi + "', '" + kh.GioiTinh + "', '" + kh.CMND + "', '" + kh.SDT + "', N'" + kh.QuocTich + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoa_KhachHang(KhachHangDTO kh)
        {
            string sql = "Delete From KHACHHANG where MaKH='" + kh.MaKH + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat_KhachHang(KhachHangDTO kh)
        {
            string sql = "Update KHACHHANG set HoTenKH=N'" + kh.HoTenKH + "',  DiaChi=N'" + kh.DiaChi + "',  GioiTinh='" + kh.GioiTinh + "', CMND='" + kh.CMND + "',  SDT='" + kh.SDT + "', QuocTich=N'" + kh.QuocTich + "' where MaKH = '" + kh.MaKH + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
    }
}