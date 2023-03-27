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
    class TaiKhoanBUS
    {
        public static DataTable hienlistds(string matk)
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanDAO.hienlistds(matk);
            return dt;
        }
        public static DataTable hiencb()
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanDAO.hientencb();
            return dt;
        }
        public static DataTable hientt()
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanDAO.hientt();
            return dt;
        }
        public static DataTable mahh_tang()
        {
            DataTable dt = new DataTable();
            dt = TaiKhoanDAO.matang();
            return dt;

        }
        public static void luu(TaiKhoanDTO pc)
        {
            if (MessageBox.Show("Bạn Có Muốn Ghi", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    TaiKhoanDAO.luu(pc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ghi Không Thành Công!");
                }
            }
        }
        public static void xoa(TaiKhoanDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    TaiKhoanDAO.xoa(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }
        public static void capnhat(TaiKhoanDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    TaiKhoanDAO.capnhat(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}