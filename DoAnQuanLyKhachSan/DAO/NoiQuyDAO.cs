using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan.DAO
{
    class NoiQuyDAO
    {
        public static DataTable ThongTinNoiQuy()
        {
            string sql = "select * from NOIQUY";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
