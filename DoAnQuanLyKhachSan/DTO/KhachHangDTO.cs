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
    class KhachHangDTO
    {
        private string _makh;
        private string _hotenkh;
        private string _gioitinh;
        private string _sdt;
        private string _diachi;
        private string _cmnd;
        private string _quoctich;

        public string MaKH
        {
            get { return _makh; }
            set { _makh = value; }
        }

        public string HoTenKH
        {
            get { return _hotenkh; }
            set { _hotenkh = value; }
        }

        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public string QuocTich
        {
            get { return _quoctich; }
            set { _quoctich = value; }
        }

        public string CMND
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }

        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }



        public KhachHangDTO()
        {
            _makh = "";
            _hotenkh = "";
            _cmnd = "";
            _quoctich = "";
            _gioitinh = "";
            _sdt = "";
            _diachi = "";
        }

        public KhachHangDTO(string MaKH, string HoTenKH, string CMND, string QuocTich, string GioiTinh, string SDT, string DiaChi)
        {
            _makh = MaKH;
            _hotenkh = HoTenKH;
            _cmnd = CMND;
            _quoctich = QuocTich;
            _gioitinh = GioiTinh;
            _sdt = SDT;
            _diachi = DiaChi;
        }
    }
}   