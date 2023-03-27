using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnQuanLyKhachSan.DTO
{
    public partial class bookingDTO
    {
        private string _mabooking;
        private string _tenbooking;
        public string MaBooking
        {
            get { return _mabooking; }
            set { _mabooking = value; }
        }
        public string TenBooking
        {
            get { return _tenbooking; }
            set { _tenbooking = value; }
        }

        internal static bookingDTO GetBooking(object value)
        {
            throw new NotImplementedException();
        }
    }
}
