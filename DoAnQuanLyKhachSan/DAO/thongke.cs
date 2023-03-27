using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnQuanLyKhachSan.DAO
{
    class thongke
    {
        public static DataTable ThongTinDangKy()
        {
            string sql = "Select * From PHIEUDANGKY";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable ThongTinDichVu()
        {
            string sql = "Select * From PHIEUDICHVU";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable ThongTinall()
        {
            string sql = "Select * From CHITIETPHIEU";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinReportPhong()
        {
            string sql = "select * from PHIEUDANGKY";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }


    }
}
