﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DTOs
{
    public class DTOPhieuDangTuyenAndDoanhNghiep
    {
        public int maDN { get; set; }
        public string tenDN { get; set; }
        public string nguoiDaiDien { get; set; }
        public string maPhieuDT { get; set; }
        public string viTriTD { get; set; }
        public int soLuong { get; set; }
        public DateTime ngayHetHan { get; set; }

        public static List<DTOPhieuDangTuyenAndDoanhNghiep> list = new List<DTOPhieuDangTuyenAndDoanhNghiep>();
    }
}
