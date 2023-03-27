using DoAnQuanLyKhachSan.DTO;
using System;
using System.Data;
using System.Linq;

namespace DoAnQuanLyKhachSan.DAO
{
    class TaiKhoanDAO
    {
        public static DataTable hienlistds(string matk)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from TAIKHOAN where MaTK ='" + matk + "'";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hientencb()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from TAIKHOAN";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hientt()
        {
            DataTable dt = new DataTable();
            string sql = "Select *from TAIKHOAN";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable matang()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaTK from TAIKHOAN order by MaTK desc";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void luu(TaiKhoanDTO pc)
        {
            string sql = "INSERT INTO TAIKHOAN(MaTK, TenDangNhap, MatKhau) VALUES('" + pc.MaTK + "',N'" + pc.TenDangNhap + "', '" + pc.MatKhau + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoa(TaiKhoanDTO pb)
        {
            string sql = "delete from TAIKHOAN where MaTK = '" + pb.MaTK + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat(TaiKhoanDTO pb)
        {
            string sql = "update TAIKHOAN set TenDangNhap=N'" + pb.TenDangNhap + "',MatKhau='" + pb.MatKhau + "'where MaTK=N'" + pb.MaTK + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
    }
}
