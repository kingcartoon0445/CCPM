using System;

namespace _01_CCPTPM_Tuan8.Models
{
    public class Binhluan
    {
        private string IDBinhLuan { get; set; }
        private string NoiDung { get; set; }
        private DateTime NgayGio { get; set; }
        private int Trangthai { get; set; }

        public bool ThemBinhLuan()
        {
            return true;
        }

        public bool capNhatBinhLuan(Binhluan bl, string noidung, int trangthai)
        {
            return true;
        }

        public bool XoaBinhLuan(Binhluan bl)
        {
            return true;
        }

    }
}
