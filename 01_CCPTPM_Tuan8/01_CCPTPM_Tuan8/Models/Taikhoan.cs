using System;

namespace _01_CCPTPM_Tuan8.Models
{
    public class Taikhoan
    {
        private string TenTaiKhoan { get; set; }
        private string MatKhau { get; set; }
        private string HoTen { get; set; }
        private DateTime NgaySinh { get; set; }
        private string Email { get; set; }
        private string Phai { get; set; }
        private string DiaChi { get; set; }
        private int PhanQuyen { get; set; }
        private int TrangThai { get; set; }

        public bool ThemTaiKhoan(Taikhoan tk)
        {
            return true;
        }

        public bool capNhatTaiKhoan(Taikhoan tk, string oldpass, int trangthai)
        {
            return true;
        }

        public bool XoaTaiKhoan(Taikhoan tk)
        {
            return true;
        }

        public bool KhoaTaiKhoan(Taikhoan tk)
        {
            return true;
        }

    }
}
