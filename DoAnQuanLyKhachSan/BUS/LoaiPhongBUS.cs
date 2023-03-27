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
    class LoaiPhongBUS
    {
        public static DataTable hiencb()
        {
            DataTable dt = new DataTable();
            dt = LoaiPhongDAO.hientencb();
            return dt;
        }
        public static DataTable hientt(string malp)
        {
            DataTable dt = new DataTable();
            dt = LoaiPhongDAO.hientt(malp);
            return dt;
        }
        public static DataTable mahh_tang()
        {
            DataTable dt = new DataTable();
            dt = LoaiPhongDAO.matang();
            return dt;

        }
        public static void luu(LoaiPhongDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Ghi", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LoaiPhongDAO.luu(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ghi Không Thành Công!");
                }
            }
        }
        public static void xoa(LoaiPhongDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LoaiPhongDAO.xoa(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }
        public static void capnhat(LoaiPhongDTO pb)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LoaiPhongDAO.capnhat(pb);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}