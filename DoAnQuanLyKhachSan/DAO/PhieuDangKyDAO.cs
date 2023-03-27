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
    class PhieuDangKyDAO
    {
        public static DataTable TimPhieuDangKy(string key)
        {
            string sql = "select * from PHIEUDANGKY where MaPDK like N'%" + key + "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTindata()
        {
            string sql = "select MaPDK, HoTenKH, TenPhong, HoTenNV, NgayLap , NgayDi , TenDV , pdk.DonVi, TraTruoc from PHIEUDANGKY pdk, KHACHHANG kh, PHIEUDICHVU dv, NHANVIEN nv, PHONG p where kh.MaKH=pdk.MaKH and p.MaPhong=pdk.MaPhong and nv.MaNV=pdk.MaNV and dv.MaPDV=pdk.MaPDV";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinDangKy()
        {
            string sql = "Select * From PHIEUDANGKY";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
      
        public static DataTable TTChiTietPhieuDangKy(string MaPDK)
        {
            string sql = "select * from KHACHHANG kh,PHONG p, NHANVIEN n, PHIEUDICHVU dv, PHIEUDANGKY dk where n.MaNV=dk.MaNV and p.MaPhong=dk.MaPhong and kh.MaKH=dk.MaKH and dv.MaPDV=dk.MaPDV and MaPDK ='" + MaPDK + "' ";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static void luu(PhieuDangKyDTO dk)
        {
            string sql = "insert into PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi) values ('" + dk.MaPDK + "','" + dk.MaPDV + "','" + dk.MaKH + "','" + dk.MaNV + "','" + dk.NgayLap + "','" + dk.NgayDi + "', '" + dk.MaPhong + "', '" + dk.TraTruoc + "','" + dk.DonVi + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }
        public static void capnhat(PhieuDangKyDTO dk)
        {
            string sql = "update PHIEUDANGKY set MaPDV='" + dk.MaPDV + "', MaKH='" + dk.MaKH + "',MaNV='" + dk.MaNV + "',NgayLap='" + dk.NgayLap + "',NgayDi='" + dk.NgayDi + "',MaPhong='" + dk.MaPhong + "' ,TraTruoc='" + dk.TraTruoc + "' ,DonVi='" + dk.DonVi + "' where MaPDK ='" + dk.MaPDK + "' ";
            KNCSDL.ExcuteNonQuery(sql);
        }
        public static void xoa(PhieuDangKyDTO dk)
        {
            string sql = "delete from PHIEUDANGKY where MaPDK='" + dk.MaPDK + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

    }
}