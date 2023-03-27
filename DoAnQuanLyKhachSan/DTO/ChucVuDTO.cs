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
    class ChucVuDTO
    {
        private string _macv;
        private string _tencv;
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
        public ChucVuDTO()
        {
            _macv = "";
            _tencv = "";
        }
        public ChucVuDTO(string MaCV, string TenCV)
        {
            _macv = MaCV;
            _tencv = TenCV;
        }
    }
}
