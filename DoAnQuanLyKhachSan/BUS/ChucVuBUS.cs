using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan.DAO;

namespace DoAnQuanLyKhachSan.BUS
{
    class ChucVuBUS
    {
        public static DataTable hiencb()
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.hientencb();
            return dt;
        }
        public static DataTable hientt(string macv)
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.hientt(macv);
            return dt;
        }
        public static DataTable mahh_tang()
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.matang();
            return dt;

        }
        public static void luu(ChucVuDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Ghi", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChucVuDAO.luu(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ghi Không Thành Công!");
                }
            }
        }
        public static void xoa(ChucVuDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChucVuDAO.xoa(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }
        public static void capnhat(ChucVuDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChucVuDAO.capnhat(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}