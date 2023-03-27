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
    class TaiKhoanDTO
    {
        private string _matk;
        private string _tendangnhap;
        private string _matkhau;
        public string MaTK
        {
            get { return _matk; }
            set { _matk = value; }
        }
        public string TenDangNhap
        {
            get { return _tendangnhap; }
            set { _tendangnhap = value; }
        }
        public string MatKhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        public TaiKhoanDTO()
        {
            _matk = "";
            _tendangnhap = "";
            _matkhau = "";
        }
        public TaiKhoanDTO(string MaTK, string TenDangNhap, string MatKhau)
        {
            _matk = MaTK;
            _tendangnhap = TenDangNhap;
            _matkhau = MatKhau;
        }

    }
}
