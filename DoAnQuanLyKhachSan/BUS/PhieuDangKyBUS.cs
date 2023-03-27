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
    class PhieuDangKyBUS
    {
        public static DataTable TimPhieuDangKy(string key)
        {
            DataTable dt = new DataTable();
            dt = PhieuDangKyDAO.TimPhieuDangKy(key);
            return dt;
        }

        public static void luu(PhieuDangKyDTO dk)
        {
            if (MessageBox.Show("Bạn Có Muốn Ghi", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhieuDangKyDAO.luu(dk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ghi Không Thành Công!");
                }
            }
        }
        public static void xoa(PhieuDangKyDTO dk)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhieuDangKyDAO.xoa(dk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }
        public static void capnhat(PhieuDangKyDTO dk)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhieuDangKyDAO.capnhat(dk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}