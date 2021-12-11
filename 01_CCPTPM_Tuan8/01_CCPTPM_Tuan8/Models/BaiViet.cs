using System;
using System.Collections.Generic;

namespace _01_CCPTPM_Tuan8.Models
{
    public class BaiViet
    {
        private string MaBaiViet { get; set; }
        private string TenBaiViet { get; set; }
        private DateTime NgayGio { get; set; }
        private int TrangThai { get; set; }

        public bool ThemBaiViet(BaiViet baiviet)
        {
            return true;
        }

        public bool capNhatBaiViet(BaiViet baivietm, string tenbaiviet)
        {
            return true;
        }

        public bool HuyBaiViet(BaiViet baiviet)
        {
            return true;
        }

        public List<BaiViet> TraCuuBaiVietTheoLoai(string tenloaibaiviet)
        {
            return new List<BaiViet>();
        }

        public List<BaiViet> TraCuuBaiVietTheoTacGia(string tenTacGia)
        {
            return new List<BaiViet>();
        }


    }
}
