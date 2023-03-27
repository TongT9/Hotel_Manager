using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSan.DTO
{
    class chitietphieuDTO
    {
        private string _maphieu;
        private string _mapdv;
        private string _tendv;
        private string _soluong;
        private string _giadv;
        private string _thanhtien;
        private string _tenlp;
        private string _tenbooking;
        private string _sokhach;
        private string _ngayvao;
        private string _giaphong;
        private string _sophong;
        private string _cmnd;
        private string _makh;
        private string _quoctich;
        private string _ngaydi;
        private string _sodem;
        private string _thanhtiendv;
        private string _tinhtrang;
        private string _tenphong;
        private string _mabooking;
        private string _malp;
        private string _maphong;
        public string maphieu
        {
            get { return _maphieu; }
            set { _maphieu = value; }
        }
        public string mapdv
        {
            get { return _mapdv; }
            set { _mapdv = value; }
        }
        public string tendv
        {
            get { return _tendv; }
            set { _tendv = value; }
        }
        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string giadv
        {
            get { return _giadv; }
            set { _giadv = value; }
        }
        public string ngayvao
        {
            get { return _ngayvao; }
            set { _ngayvao = value; }
        }
        public string thanhtiendv
        {
            get { return _thanhtiendv; }
            set { _thanhtiendv = value; }
        }
        public string tenlp
        {
            get { return _tenlp; }
            set { _tenlp = value; }
        }
        public string tenbooking
        {
            get { return _tenbooking; }
            set { _tenbooking = value; }
        }
        public string sokhach
        {
            get { return _sokhach; }
            set { _sokhach = value; }
        }
        public string giaphong
        {
            get { return _giaphong; }
            set { _giaphong = value; }
        }
        public string sophong
        {
            get { return _sophong; }
            set { _sophong = value; }
        }
        public string cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }
        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string quoctich
        {
            get { return _quoctich; }
            set { _quoctich = value; }
        }
        public string ngaydi
        {
            get { return _ngaydi; }
            set { _ngaydi = value; }
        }
        public string sodem
        {
            get { return _sodem; }
            set { _sodem = value; }
        }
        public string thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }

        public string tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        public string tenphong
        {
            get { return _tenphong; }
            set { _tenphong = value; }
        }

        public string mabooking
        {
            get { return _mabooking; }
            set { _mabooking = value; }
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
        public chitietphieuDTO()

        {
            _cmnd = "";
            _giadv = "";
            _giaphong = "";
            _makh = "";
            _mapdv = "";
            _maphieu = "";
            _ngaydi = "";
            _ngayvao = "";
            _quoctich = "";
            _sodem = "";
            _sokhach = "";
            _soluong = "";
            _sophong = "";
            _tenbooking = "";
            _tendv = "";
            _tenlp = "";
            _thanhtien = "";
            _thanhtiendv = "";
            _tinhtrang = "";
            _tenphong = "";
            _mabooking = "";
            _malp = "";
            _maphong = "";
        }
        public chitietphieuDTO(string maphieu, string mapdv,string tendv,string soluong, string giadv,string thanhtiendv,string mahd, string tenlp,string tenbooking, string sokhach, string ngayvao, string giaphong,string sophong,string cmnd, string makh, string quoctich, string ngaydi, string sodem, string thanhtien, string tinhtrang, string tenphong, string mabooking, string malp, string maphong)
        {
            maphieu = _maphieu;
            mapdv = _mapdv;
            tendv = _tendv;
            soluong = _soluong;
            giadv = _giadv;
            thanhtiendv = _thanhtiendv;
            tenlp = _tenlp;
            malp = _malp;
            mabooking = _mabooking;
            tenbooking = _tenbooking;
            sokhach = _sokhach;
            ngayvao = _ngayvao;
            giaphong = _giaphong;
            sophong = _sophong;
            cmnd = _cmnd;
            makh = _makh;
            quoctich = _quoctich;
            ngaydi = _ngaydi;
            sodem = _sodem;
            thanhtien = _thanhtien;
            tinhtrang = _tinhtrang;
            tenphong = _tenphong;
            maphong = _maphong;
        }
    }
}
