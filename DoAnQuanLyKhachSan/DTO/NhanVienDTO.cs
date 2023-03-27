using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSan.DTO
{
    class NhanVienDTO
    {
        private string _manv;
        private string _hotennv;
        private string _gioitinh;
        private string _ngaysinh;
        private string _sdt;
        private string _diachi;
        private string _macv;
        private string _tencv;

        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }

        public string HoTenNV
        {
            get { return _hotennv; }
            set { _hotennv = value; }
        }

        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public string NgaySinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        public string MaCV
        {
            get { return _macv; }
            set { _macv = value; }
        }

        public string TenCV
        {
            get { return _tencv; }
            set { _tencv = value; }
        }

        public NhanVienDTO()
        {
            _manv = "";
            _hotennv = "";
            _gioitinh = "";
            _ngaysinh = "";
            _diachi = "";
            _sdt = "";
            _macv = "";
            _tencv = "";
        }

        public NhanVienDTO(string MaNV, string HoTenNV, string GioiTinh, string NgaySinh, string SDT, string DiaChi, string MaCV, string TenCV)
        {
            _manv = MaNV;
            _hotennv = HoTenNV;
            _gioitinh = GioiTinh;
            _ngaysinh = NgaySinh;
            _sdt = SDT;
            _diachi = DiaChi;
            _macv = MaCV;
            _tencv = TenCV;
        }
    }
}