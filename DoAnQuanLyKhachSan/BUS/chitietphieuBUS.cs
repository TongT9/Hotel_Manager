using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnQuanLyKhachSan.DAO;
using DoAnQuanLyKhachSan.DTO;
using System.Windows.Forms;

namespace DoAnQuanLyKhachSan.BUS
{
    class chitietphieuBUS
    {
        public static DataTable tangmaphieudangky()
        {
            DataTable dt = new DataTable();
            dt = chitietphieuphongDAO.tangmaphieudangky();
            return dt;
        }

        public static string LayMaKhachHangQuaTen(string MaKH)
        {
            return chitietphieuphongDAO.LayMaKhachHangQuaTen(MaKH);
        }

        public static string LayMaPhongQuaTen(string tenphong)
        {
            return chitietphieuphongDAO.LayMaPhongQuaTen(tenphong);
        }

        public static string LayMaDichVuQuaTen(string tendv)
        {
            return chitietphieuphongDAO.LayMaDichVuQuaTen(tendv);
        }

        public static string LayMaLPQuaTen(string tenlp)
        {
            return chitietphieuphongDAO.LayMaLPQuaTen(tenlp);
        }

        public static string LayMabookingQuaTen(string tenbooking)
        {
            return chitietphieuphongDAO.LayMabookingQuaTen(tenbooking);
        }
        public static void them(chitietphieuDTO ct)
        {
            try
            {
                chitietphieuphongDAO.them(ct);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        public static void capnhat(chitietphieuDTO ct)
        {
            try
            {
                chitietphieuphongDAO.capnhat(ct);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }

        public static void xoaphieu(chitietphieuDTO ct)
        {
            try
            {
                chitietphieuphongDAO.xoaphieu(ct);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
    }
}
