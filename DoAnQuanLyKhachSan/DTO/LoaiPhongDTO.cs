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
    class LoaiPhongDTO
    {
        private string _malp;
        private string _tenlp;
        private string _trangthietbi;
        public string MaLP
        {
            get { return _malp; }
            set { _malp = value; }
        }
        public string TenLP
        {
            get { return _tenlp; }
            set { _tenlp = value; }
        }
       public string TrangThietBi
        {
            get { return _trangthietbi; }
            set { _trangthietbi = value; }
        }
        public LoaiPhongDTO()
        {
            _malp = "";
            _tenlp = "";
            _trangthietbi = "";
        }
        public LoaiPhongDTO(string MaLP, string TenLP, string TrangThietBi)
        {
            _malp = MaLP;
            _tenlp = TenLP;
            _trangthietbi = TrangThietBi;
        }
    }
}
