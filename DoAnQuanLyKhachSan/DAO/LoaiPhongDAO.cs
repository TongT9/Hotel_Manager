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
    class LoaiPhongDAO
    {
        public static DataTable hientencb()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LOAIPHONG";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hientt(string malp)
        {
            string sql = "select * from LOAIPHONG where MaLP='" + malp + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable matang()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaLP from LOAIPHONG order by MaLP desc";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void luu(LoaiPhongDTO pb)
        {
            string sql = "Insert INTO LOAIPHONG (MaLP, TenLP, TrangThietBi) Values ('" + pb.MaLP + "',N'" + pb.TenLP + "', N'" + pb.TrangThietBi + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoa(LoaiPhongDTO pb)
        {
            string sql = "delete from LOAIPHONG where MaLP = '" + pb.MaLP + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat(LoaiPhongDTO pb)
        {
            string sql = "update LOAIPHONG set TenLP=N'" + pb.TenLP + "', TrangThietBi=N'" + pb.TrangThietBi + "' where MaLP=N'" + pb.MaLP + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
    }
}