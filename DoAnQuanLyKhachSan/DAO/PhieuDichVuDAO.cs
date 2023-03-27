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
    class PhieuDichVuDAO
    {
        public static DataTable giadv(string gia)
        {
            string sql = "Select * From PHIEUDICHVU where GiaDV='"+gia+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }


        public static DataTable TimPhieuDichVu(string key)
        {
            string sql = "select * from PHIEUDICHVU where MaPDV like N'%" + key + "%'";
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

        public static DataTable TTChiTietPhieuDV(string MaPDV)
        {
            string sql = "select * from PHIEUDICHVU where MaPDV ='" + MaPDV + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static void luu(PhieuDichVuDTO dv)
        {
            string sql = "insert into PHIEUDICHVU(MaPDV , TenDV , GiaDV) values ('" + dv.MaPDV + "',N'" + dv.TenDV + "','" + dv.GiaDV + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }
        public static void capnhat(PhieuDichVuDTO dv)
        {
            string sql = "update PHIEUDICHVU set TenDV=N'" + dv.TenDV + "', GiaDV='" + dv.GiaDV + "' where MaPDV ='" + dv.MaPDV + "' ";
            KNCSDL.ExcuteNonQuery(sql);
        }
        public static void xoa(PhieuDichVuDTO dv)
        {
            string sql = "delete from PHIEUDICHVU where MaPDV='" + dv.MaPDV + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

    }
}