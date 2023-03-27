using DoAnQuanLyKhachSan.DTO;
using System;
using System.Data;
using System.Linq;

namespace DoAnQuanLyKhachSan.DAO
{
    class chitietphieuphongDAO
    {

        public static DataTable tangmaphieudangky()
        {
            string sql = "select * from CHITIETPHIEU";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable hiencbphong()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LOAIPHONG";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hiencbtrinhtrang()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from CHITIETPHIEU";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinHD()
        {
            string sql = "select c.maphieu, TenDV,  soluong, c.giadv, thanhtien, TenPhong,  Tenbooking, sokhach, ngayvao, c.GiaPhong, TenLP, HoTenKH, f.QuocTich, ngaydi, sodem, thanhtiendv, c.TinhTrang   from PHONG a , PHIEUDICHVU b , CHITIETPHIEU c, Booking d, LOAIPHONG e, KHACHHANG f   where f.MaKH=c.MaKH and  a.MaPhong=c.MaPhong and b.MaPDV=c.MaPDV and e.MaLP=c.MaLP and d.Mabooking=c.Mabooking";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hientt(string maphieu)
        {
            string sql = "select * from CHITIETPHIEU where maphieu='" + maphieu + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hiencbbooking()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Booking";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable hiencbTenKH()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from KHACHHANG";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable hiencbsophong()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from PHONG";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
        public static DataTable hiencbdv()
        {
            DataTable dt = new DataTable();
            string sql = "Select * from PHIEUDICHVU";
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static string LayMaKhachHangQuaTen(string HoTenKH)
        {
            string sql = "select HoTenKH, MaKH from KHACHHANG where HoTenKH = N'" + HoTenKH + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaKH"].ToString();
        }
        public static string LayMaPhongQuaTen(string tenphong)
        {
            string sql = "select TenPhong, MaPhong from PHONG where TenPhong = N'" + tenphong + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaPhong"].ToString();
        }

        public static string LayMabookingQuaTen(string tenbooking)
        {
            string sql = "select Tenbooking, Mabooking from Booking where Tenbooking = N'" + tenbooking + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["Mabooking"].ToString();
        }

        public static string LayMaDichVuQuaTen(string tendv)
        {
            string sql = "select TenDV, MaPDV from PHIEUDICHVU where TenDV = N'" + tendv + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaPDV"].ToString();
        }
        public static string LayMaLPQuaTen(string tenlp)
        {
            string sql = "select TenLP, MaLP from LOAIPHONG where TenLP = N'" + tenlp + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt.Rows[0]["MaLP"].ToString();
        }
        public static void them(chitietphieuDTO ct)
        {
            string sql = "INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('" + ct.maphieu + "','" + ct.mapdv + "','" + ct.soluong + "','" + ct.giadv + "','" + ct.thanhtiendv + "','" + ct.malp + "','" + ct.mabooking + "','" + ct.sokhach + "','" + ct.ngayvao + "','" + ct.giaphong + "',N'" + ct.maphong + "','" + ct.makh + "',N'" + ct.quoctich + "','" + ct.ngaydi + "','" + ct.sodem + "','" + ct.thanhtien + "', N'" + ct.tinhtrang + "')";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void capnhat(chitietphieuDTO ct)
        {
            string sql = "update CHITIETPHIEU set MaPDV='" + ct.mapdv + "',soluong='" + ct.soluong + "',giadv='" + ct.giadv + "',thanhtiendv='" + ct.thanhtiendv + "',MaLP='" + ct.malp + "',Mabooking='" + ct.mabooking + "',sokhach='" + ct.sokhach + "',ngayvao='" + ct.ngayvao + "',GiaPhong='" + ct.giaphong + "',MaPhong=N'" + ct.maphong + "',MaKH='" + ct.makh + "',QuocTich=N'" + ct.quoctich + "',ngaydi='" + ct.ngaydi + "',sodem='" + ct.sodem + "',thanhtien='" + ct.thanhtien + "',TinhTrang= N'" + ct.tinhtrang + "' where maphieu = '" + ct.maphieu + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }

        public static void xoaphieu(chitietphieuDTO ct)
        {
            string sql = "delete from CHITIETPHIEU where maphieu='" + ct.maphieu + "'";
            KNCSDL.ExcuteNonQuery(sql);
        }
        public static DataTable ttcthd()
        {
            string sql = "select * from CHITIETPHIEU";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }

        public static DataTable ThongTinReport()
        {
            string sql = "select c.maphieu, HoTenKH, a.TenPhong  , sodem, b.TenDV, soluong, thanhtien from PHONG a , PHIEUDICHVU b , CHITIETPHIEU c, KHACHHANG d  where d.MaKH=c.MaKH and   a.MaPhong=c.MaPhong and b.MaPDV=c.MaPDV";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }



        public static DataTable TTPhong()
        {
            string sql = "select* from CHITIETPHIEU";
            DataTable dt = new DataTable();
            dt = KNCSDL.ExcuteQuery(sql);
            return dt;
        }
    }
}
