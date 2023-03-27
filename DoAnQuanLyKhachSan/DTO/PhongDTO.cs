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
    class PhongDTO
    {
        private string _maphong;
        private string _malp;
        private string _tenphong;
        private string _giaphong;
        private string _tinhtrang;
        private string _donvi;

        public string MaPhong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }

        public string MaLP
        {
            get { return _malp; }
            set { _malp = value; }
        }

        public string TenPhong
        {
            get { return _tenphong; }
            set { _tenphong = value; }
        }

        public string GiaPhong
        {
            get { return _giaphong; }
            set { _giaphong = value; }
        }

        public string DonVi
        {
            get { return _donvi; }
            set { _donvi = value; }
        }

        public string TinhTrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        public PhongDTO()
        {
            _maphong = "";
            _malp = "";
            _tenphong = "";
            _giaphong = "";
            _donvi = "";
            _tinhtrang = "";
        }

        public PhongDTO(string MaPhong, string MaLP, string TenPhong, string GiaPhong, string DonVi, string TinhTrang)
        {
            _maphong = MaPhong;
            _malp = MaLP;
            _tenphong = TenPhong;
            _giaphong = GiaPhong;
            _donvi = DonVi;
            _tinhtrang = TinhTrang;
        }
    }
}


