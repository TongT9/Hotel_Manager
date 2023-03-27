using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DoAnQuanLyKhachSan.DTO
{
    class HoaDonDTO
    {
        private string _mahd;
        private string _manv;
        private string _makh;
        private string _maphong;
        private string _malp;
        private string _sodem;
        private string _sokhach;
        private string _ngaythanhtoan;
        private string _sotiendattruoc;
        private string _donvi;
        private string _hotennv;
        private string _mabooking;
        private string _tongtien;


        public string tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        public string sokhach
        {
            get { return _sokhach; }
            set { _sokhach = value; }
        }
        public string sodem
        {
            get { return _sodem; }
            set { _sodem = value; }
        }
        public string malp
        {
            get { return _malp; }
            set { _malp = value; }
        }
        public string maphong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }
        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string MaHD
        {
            get { return _mahd; }
            set { _mahd = value; }
        }

        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }

        public string NgayThanhToan
        {
            get { return _ngaythanhtoan; }
            set { _ngaythanhtoan = value; }
        }

        public string SoTienDatTruoc
        {
            get { return _sotiendattruoc; }
            set { _sotiendattruoc = value; }
        }

         public string DonVi
        {
            get { return _donvi; }
            set { _donvi = value; }
        }

        public string HoTenNV
        {
            get { return _hotennv; }
            set { _hotennv = value; }
        }

        public string MaBooking
        {
            get { return _mabooking; }
            set { _mabooking = value; }
        }

        public HoaDonDTO()
        {
            _mahd = "";
            _manv = "";
            _ngaythanhtoan = "";
            _sotiendattruoc = "";
            _donvi = "";
            _hotennv = "";
            _tongtien = "";
            _sokhach = "";
            _sodem = "";
            _malp = "";
            _makh = "";
            _maphong = "";
            _mabooking = "";
        }

        public HoaDonDTO(string MaHD, string tongtien,string sokhach, string sodem, string malp, string makh, string maphong, string MaNV, string NgayThanhToan, string SoTienDatTruoc, string DonVi, string HoTenNV, string MaBooking)
        {
            _mahd = MaHD;
            _manv = MaNV;
            _ngaythanhtoan = NgayThanhToan;
            _sotiendattruoc = SoTienDatTruoc;
            _donvi = DonVi;
            _hotennv = HoTenNV;
            _tongtien = tongtien;
            _sokhach = sokhach;
            _sodem = sodem;
            _malp = malp;
            _makh = makh;
            _maphong = maphong;
            _mabooking = MaBooking;
        }
    }
}
