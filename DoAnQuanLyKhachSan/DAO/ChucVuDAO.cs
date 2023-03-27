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
    class ChucVuDAO
    {
        public static DataTable hientencb()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from CHUCVU";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hientt(string macv)
        {
            string sql = "select * from CHUCVU where MaCV='" + macv + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable matang()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaCV from CHUCVU order by MaCV desc";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void luu(ChucVuDTO pb)
        {
            string sql = "Insert INTO CHUCVU (MaCV, TenCV) Values ('" + pb.MaCV + "',N'" + pb.TenCV + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoa(ChucVuDTO pb)
        {
            string sql = "delete from CHUCVU where MaCV = '" + pb.MaCV + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat(ChucVuDTO pb)
        {
            string sql = "update CHUCVU set TenCV=N'" + pb.TenCV + "'where MaCV=N'" + pb.MaCV + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
    }
}