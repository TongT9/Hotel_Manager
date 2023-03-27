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
    class PhongDAO
    {
        public static DataTable TimKiemPhong(string key)
        {
            string sql = "select * from PHONG where TenPhong like N'%" + key + "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinPhong()
        {
            string sql = "Select *From PHONG";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinLP()
        {
            string sql = "select * from LOAIPHONG";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinPhongThuocLoaiPhong(string MaPhong)
        {
            string sql = "Select *From PHONG where MaPhong='" + MaPhong + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinPhongLoaiPhong(string MaLP)
        {
            string sql = "select * from PHONG a where a.MaLP='" + MaLP + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable TTPhongChiTiet(string MaPhong)
        {
            string sql = "select MaPhong, TenPhong, GiaPhong, DonVi, TinhTrang, b.MaLP from PHONG a, LOAIPHONG b where a.MaLP=b.MaLP and a.MaPhong= '" + MaPhong + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static string LayMaLPQuaTen(string TenLP)
        {
            string sql = "select TenLP, MaLP from LOAIPHONG where TenLP = N'" + TenLP + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaLP"].ToString();
        }

        public static void luu_Phong(PhongDTO phong)
        {
            string sql = "INSERT INTO PHONG(MaPhong, TenPhong, GiaPhong, DonVi, TinhTrang,  MaLP) VALUES('" + phong.MaPhong + "',N'"
              + phong.TenPhong + "', '" + phong.GiaPhong + "', N'" + phong.DonVi + "','" + phong.TinhTrang + "', '" + phong.MaLP + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat_Phong(PhongDTO phong)
        {
            string sql = "Update PHONG set TenPhong=N'" + phong.TenPhong + "', GiaPhong='" + phong.GiaPhong + "', DonVi=N'" + phong.DonVi + "', TinhTrang='" + phong.TinhTrang + "', MaLP='" + phong.MaLP + "' where MaPhong = '" + phong.MaPhong + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoa_Phong(PhongDTO phong)
        {
            string sql = "Delete From PHONG where MaPhong='" + phong.MaPhong + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
    }
}
