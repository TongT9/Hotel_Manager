using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.BUS;

namespace DoAnQuanLyKhachSan.DAO
{
    class NhanVienDAO
    {
        public static DataTable TimNhanVien(string key)
        {
            string sql = "select * from NHANVIEN where HoTenNV like N'%" + key + "%'";
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

        public static DataTable ThongTinChucVu()
        {
            string sql = "select * from CHUCVU";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable TTCVQuaMaCV(string MaCV)
        {
            string sql = "select * from NHANVIEN where MaCV='" + MaCV + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static string LayTenCVQuaMa(string MaCV)
        {
            string sql = "select TenCV, MaCV from CHUCVU where MaCV = '" + MaCV + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["TenCV"].ToString();
        }

        public static string LayMaCVQuaTen(string TenCV)
        {
            string sql = "select TenCV, MaCV from CHUCVU where TenCV = N'" + TenCV + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaCV"].ToString();
        }

        public static void xoa_NhanVien(NhanVienDTO nv)
        {
            string sql = "delete from NHANVIEN where MaNV='" + nv.MaNV + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void Luu_NhanVien(NhanVienDTO nv)
        {
            string sql = "INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV) VALUES('" + nv.MaNV + "', N'"
             + nv.HoTenNV + "', '" + nv.GioiTinh + "','" + nv.NgaySinh + "', '" + nv.SDT + "', N'" + nv.DiaChi + "', '" + nv.MaCV + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat_NhanVien(NhanVienDTO nv)
        {
            string sql = "Update NHANVIEN set HoTenNV=N'" + nv.HoTenNV + "', GioiTinh='" + nv.GioiTinh + "', NgaySinh='" + nv.NgaySinh + "', SDT='" + nv.SDT + "', DiaChi=N'" + nv.DiaChi + "', MaCV='" + nv.MaCV + "' where MaNV = '" + nv.MaNV + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
    }
}
