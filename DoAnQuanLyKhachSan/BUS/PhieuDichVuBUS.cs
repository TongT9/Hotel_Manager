using DoAnQuanLyKhachSan.DAO;
using DoAnQuanLyKhachSan.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan.BUS
{
    class PhieuDichVuBUS
    {
        public static DataTable TimPhieuDichVu(string key)
        {
            DataTable dt = new DataTable();
            dt = PhieuDichVuDAO.TimPhieuDichVu(key);
            return dt;
        }

        public static void luu(PhieuDichVuDTO dv)
        {
            if (MessageBox.Show("Bạn Có Muốn Ghi", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhieuDichVuDAO.luu(dv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ghi Không Thành Công!");
                }
            }
        }
        public static void xoa(PhieuDichVuDTO dv)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhieuDichVuDAO.xoa(dv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
        }
        public static void capnhat(PhieuDichVuDTO dv)
        {
            if (MessageBox.Show("Bạn Có Muốn Cập Nhật", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhieuDichVuDAO.capnhat(dv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                }
            }
        }
    }
}