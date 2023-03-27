using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan.DAO
{
    class KNCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void moketnoi()
        {
            try
            {
                string sqlcon = @"Data Source=DESKTOP-3M231FL\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
                cnn.ConnectionString = sqlcon;

                //kiểm tra sql đóng hay mở
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("ket noi khong thanh cong");
            }
        }
        public static void dongketnoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable ExcuteQuery(string sql)
        {
            moketnoi();
            //tạo ra đối tượng thực thi sql
            SqlCommand cd = new SqlCommand(sql, cnn);
            //đọc dữ liệu từ cơ sở dữ liệu
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dongketnoi();
            return dt;
        }

        //truy vấn không cần trả về dữ liệu, thực hiện các truy vấn như update, delete,...
        public static void ExcuteNonQuery(string sql)
        {
            moketnoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongketnoi();
        }
    }
}
