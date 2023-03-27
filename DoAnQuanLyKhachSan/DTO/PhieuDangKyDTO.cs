using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSan.DTO
{
    class PhieuDangKyDTO
    {
        private string _mapdk;
        private string _makh;
        private string _manv;
        private string _maphong;
        private string _mapdv;
        private string _ngaylap;
        private string _ngaydi;
        private string _tratruoc;
        private string _donvi;

        public string MaPDK
        {
            get { return _mapdk; }
            set { _mapdk = value; }
        }
        public string MaKH
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }
        public string MaPhong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }
        public string MaPDV
        {
            get { return _mapdv; }
            set { _mapdv = value; }
        }
        public string NgayLap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }
        public string NgayDi
        {
            get { return _ngaydi; }
            set { _ngaydi = value; }
        }
        public string TraTruoc
        {
            get { return _tratruoc; }
            set { _tratruoc = value; }
        }
        public string DonVi
        {
            get { return _donvi; }
            set { _donvi = value; }
        }

        public PhieuDangKyDTO()
        {
             _mapdk = "";
             _makh = "";
             _manv = "";
             _maphong = "";
             _mapdv = "";
             _ngaylap = "";
             _ngaydi = "";
             _tratruoc = "";
             _donvi = "";

        }

        public PhieuDangKyDTO(string MaPDK, string MaKH, string MaNV, string MaPhong, string MaPDV, string NgayLap, string NgayDi, string TraTruoc, string DonVi)
        {
            _mapdk = MaPDK;
            _makh = MaKH;
            _manv = MaNV;
            _maphong = MaPhong;
            _mapdv = MaPDV;
            _ngaylap = NgayLap;
            _ngaydi = NgayDi;
            _tratruoc = TraTruoc;
            _donvi = DonVi;

        }
    }
}

