using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyKhachSan.DAO;
using DoAnQuanLyKhachSan.DTO;
using DoAnQuanLyKhachSan;

namespace DoAnQuanLyKhachSan.GUI
{
    public partial class frmbooking : Form
    {

        public frmbooking()
        {
            InitializeComponent();
        }
        public void SetBookingRoom()
        {

        }

        private void cmbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong1.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong1.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong1.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong1.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong2.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong2.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong2.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong2.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong3.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong3.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong3.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong3.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong4.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong4.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong4.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong4.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong5.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong5.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong5.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong5.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong6.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong6.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong6.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong6.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong6.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong7.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong7.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong7.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong7.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong7.BackColor = Color.Gray;
                    break;
            }
        }

        private void cmbPhong8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cmbPhong8.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    lblPhong8.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    lblPhong8.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    lblPhong8.BackColor = Color.IndianRed;
                    break;
                case "Phòng Đang Dọn":
                    lblPhong8.BackColor = Color.Gray;
                    break;
            }
        }
        public static string tenbooking { get; set; }
        public static string tenkhach { get; set; }
        public static string sokhach { get; set; }
        public static string quoctich { get; set; }
        public static string ngayden { get; set; }
        public static string ngaydi { get; set; }

        public static string trangthai { get; set; }
        private void btnChiTiet1_Click(object sender, EventArgs e)
        {
             btnChiTiet1.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking1.Text = tenbooking;
                    lblNoiDungTenKhach1.Text = tenkhach;
                    lblNoiDungSoKhach1.Text = sokhach;
                    lblNoiDungQuocTich1.Text = quoctich;
                    lblNoiDungNgayDen1.Text = ngayden;
                    lblNoiDungNgayDi1.Text = ngaydi;
                    cmbPhong1.Text = trangthai;
                }
            }
        }

        private void btnCheckOut1_Click(object sender, EventArgs e)
        {
            btnCheckOut1.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking1.Text = ".........................................";
            lblNoiDungTenKhach1.Text = ".........................................";
            lblNoiDungSoKhach1.Text = ".........................................";
            lblNoiDungQuocTich1.Text = ".........................................";
            lblNoiDungNgayDen1.Text = ".........................................";
            lblNoiDungNgayDi1.Text = ".........................................";
            lblPhong1.BackColor = Color.Gray;
            cmbPhong1.Text = "";
        }

        private void btnCheckOut2_Click(object sender, EventArgs e)
        {
            btnCheckOut2.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking2.Text = ".........................................";
            lblNoiDungTenKhach2.Text = ".........................................";
            lblNoiDungSoKhach2.Text = ".........................................";
            lblNoiDungQuocTich2.Text = ".........................................";
            lblNoiDungNgayDen2.Text = ".........................................";
            lblNoiDungNgayDi2.Text = ".........................................";
            //lblNoiDungTien2.Text = ".........................................";
            lblPhong2.BackColor = Color.Gray;
        }

        private void btnCheckOut3_Click(object sender, EventArgs e)
        {
            btnCheckOut3.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking3.Text = ".........................................";
            lblNoiDungTenKhach3.Text = ".........................................";
            lblNoiDungSoKhach3.Text = ".........................................";
            lblNoiDungQuocTich3.Text = ".........................................";
            lblNoiDungNgayDen3.Text = ".........................................";
            lblNoiDungNgayDi3.Text = ".........................................";
            //lblNoiDungTien3.Text = ".........................................";
            lblPhong3.BackColor = Color.Gray;
        }

        private void btnCheckOut4_Click(object sender, EventArgs e)
        {
            btnCheckOut4.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking4.Text = ".........................................";
            lblNoiDungTenKhach4.Text = ".........................................";
            lblNoiDungSoKhach4.Text = ".........................................";
            lblNoiDungQuocTich4.Text = ".........................................";
            lblNoiDungNgayDen4.Text = ".........................................";
            lblNoiDungNgayDi4.Text = ".........................................";
            //lblNoiDungTien4.Text = ".........................................";
            lblPhong4.BackColor = Color.Gray;
        }

        private void btnCheckOut5_Click(object sender, EventArgs e)
        {
            btnCheckOut5.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking5.Text = ".........................................";
            lblNoiDungTenKhach5.Text = ".........................................";
            lblNoiDungSoKhach5.Text = ".........................................";
            lblNoiDungQuocTich5.Text = ".........................................";
            lblNoiDungNgayDen5.Text = ".........................................";
            lblNoiDungNgayDi5.Text = ".........................................";
            //lblNoiDungTien5.Text = ".........................................";
            lblPhong5.BackColor = Color.Gray;
        }

        private void btnCheckOut6_Click(object sender, EventArgs e)
        {
            btnCheckOut6.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking6.Text = ".........................................";
            lblNoiDungTenKhach6.Text = ".........................................";
            lblNoiDungSoKhach6.Text = ".........................................";
            lblNoiDungQuocTich6.Text = ".........................................";
            lblNoiDungNgayDen6.Text = ".........................................";
            lblNoiDungNgayDi6.Text = ".........................................";
            //lblNoiDungTien6.Text = ".........................................";
            lblPhong6.BackColor = Color.Gray;
        }

        private void btnCheckOut7_Click(object sender, EventArgs e)
        {
            btnCheckOut7.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking7.Text = ".........................................";
            lblNoiDungTenKhach7.Text = ".........................................";
            lblNoiDungSoKhach7.Text = ".........................................";
            lblNoiDungQuocTich7.Text = ".........................................";
            lblNoiDungNgayDen7.Text = ".........................................";
            lblNoiDungNgayDi7.Text = ".........................................";
            //lblNoiDungTien7.Text = ".........................................";
            lblPhong7.BackColor = Color.Gray;
        }

        private void btnCheckOut8_Click(object sender, EventArgs e)
        {
            btnCheckOut8.BackColor = Color.YellowGreen;
            lblNoiDungTenBooking8.Text = ".........................................";
            lblNoiDungTenKhach8.Text = ".........................................";
            lblNoiDungSoKhach8.Text = ".........................................";
            lblNoiDungQuocTich8.Text = ".........................................";
            lblNoiDungNgayDen8.Text = ".........................................";
            lblNoiDungNgayDi8.Text = ".........................................";
            //lblNoiDungTien8.Text = ".........................................";
            lblPhong8.BackColor = Color.Gray;
        }


        private void frmbooking_Load(object sender, EventArgs e)
        {

        }

        private void btnChiTiet2_Click(object sender, EventArgs e)
        {
            btnChiTiet2.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking2.Text = tenbooking;
                    lblNoiDungTenKhach2.Text = tenkhach;
                    lblNoiDungSoKhach2.Text = sokhach;
                    lblNoiDungQuocTich2.Text = quoctich;
                    lblNoiDungNgayDen2.Text = ngayden;
                    lblNoiDungNgayDi2.Text = ngaydi;
                    cmbPhong2.Text = trangthai;
                }
            }
        }

        private void btnChiTiet3_Click(object sender, EventArgs e)
        {
            btnChiTiet3.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking3.Text = tenbooking;
                    lblNoiDungTenKhach3.Text = tenkhach;
                    lblNoiDungSoKhach3.Text = sokhach;
                    lblNoiDungQuocTich3.Text = quoctich;
                    lblNoiDungNgayDen3.Text = ngayden;
                    lblNoiDungNgayDi3.Text = ngaydi;
                    cmbPhong3.Text = trangthai;
                }
            }
        }

        private void btnChiTiet4_Click(object sender, EventArgs e)
        {
            btnChiTiet4.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking4.Text = tenbooking;
                    lblNoiDungTenKhach4.Text = tenkhach;
                    lblNoiDungSoKhach4.Text = sokhach;
                    lblNoiDungQuocTich4.Text = quoctich;
                    lblNoiDungNgayDen4.Text = ngayden;
                    lblNoiDungNgayDi4.Text = ngaydi;
                    cmbPhong4.Text = trangthai;
                }
            }
        }

        private void btnChiTiet5_Click(object sender, EventArgs e)
        {
            btnChiTiet5.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking5.Text = tenbooking;
                    lblNoiDungTenKhach5.Text = tenkhach;
                    lblNoiDungSoKhach5.Text = sokhach;
                    lblNoiDungQuocTich5.Text = quoctich;
                    lblNoiDungNgayDen5.Text = ngayden;
                    lblNoiDungNgayDi5.Text = ngaydi;
                    cmbPhong5.Text = trangthai;
                }
            }
        }

        private void btnChiTiet6_Click(object sender, EventArgs e)
        {
            btnChiTiet6.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking6.Text = tenbooking;
                    lblNoiDungTenKhach6.Text = tenkhach;
                    lblNoiDungSoKhach6.Text = sokhach;
                    lblNoiDungQuocTich6.Text = quoctich;
                    lblNoiDungNgayDen6.Text = ngayden;
                    lblNoiDungNgayDi6.Text = ngaydi;
                    cmbPhong6.Text = trangthai;
                }
            }
        }

        private void btnChiTiet7_Click(object sender, EventArgs e)
        {
            btnChiTiet7.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking7.Text = tenbooking;
                    lblNoiDungTenKhach7.Text = tenkhach;
                    lblNoiDungSoKhach7.Text = sokhach;
                    lblNoiDungQuocTich7.Text = quoctich;
                    lblNoiDungNgayDen7.Text = ngayden;
                    lblNoiDungNgayDi7.Text = ngaydi;
                    cmbPhong7.Text = trangthai;
                }
            }
        }

        private void btnChitiet8_Click(object sender, EventArgs e)
        {
            btnChitiet8.BackColor = Color.Red;
            using (var form = new frmchitietphong())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tenbooking = form.tenbooking;
                    tenkhach = form.tenkhach;
                    sokhach = form.sokhach;
                    quoctich = form.quoctich;
                    ngayden = form.ngayden;
                    ngaydi = form.ngaydi;
                    trangthai = form.trangthai;

                    lblNoiDungTenBooking8.Text = tenbooking;
                    lblNoiDungTenKhach8.Text = tenkhach;
                    lblNoiDungSoKhach8.Text = sokhach;
                    lblNoiDungQuocTich8.Text = quoctich;
                    lblNoiDungNgayDen8.Text = ngayden;
                    lblNoiDungNgayDi8.Text = ngaydi;
                    cmbPhong8.Text = trangthai;
                }
            }
        }

        private void pnlPhong1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btquayve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
