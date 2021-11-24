using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_CCPTPM_Tuan8.Models
{
    public class CTaiKhoan
    {
        string TenTaiKhoan;
        String MatKhau;
        String HoTen;
        DateTime NgaySinh;
        String Email;
        String Phai;
        String DiaChi;
        int Trangthai;

        bool ThemTaiKhoan()
        {
            return true;
        }
        bool CapNhatTaiKhoan(string HoTen, DateTime NgaySinh, string email)
        {
            return true;
        }
        bool CapNhatMatKhau(String mk)
        {
            return true;
        }
    }
}
