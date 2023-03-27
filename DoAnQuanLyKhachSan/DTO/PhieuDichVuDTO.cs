using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyKhachSan.DTO
{
    class PhieuDichVuDTO
    {
        private string _mapdv;
        private string _tendv;
        private string _giadv;

        public string MaPDV
        {
            get { return _mapdv; }
            set { _mapdv = value; }
        }
        public string TenDV
        {
            get { return _tendv; }
            set { _tendv = value; }
        }
        public string GiaDV
        {
            get { return _giadv; }
            set { _giadv = value; }
        }

        public PhieuDichVuDTO()
        {
            _mapdv = "";
            _tendv = "";
            _giadv = "";
        }

        public PhieuDichVuDTO(string MaPDV, string TenDV, string GiaDV)
        {
            _mapdv = MaPDV;
            _tendv = TenDV;
            _giadv = GiaDV;
        }
    }
}
