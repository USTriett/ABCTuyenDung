using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DTOs
{
    public class DTODoanhNghiep
    {
        public int MaDN { get; set; }
        public string TenDN { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string NguoiDaiDien { get; set; }
        public DateTime NgayHetHan { get; set; }
        public bool TiemNang { get; set; }
        public bool Kqkd { get; set; }
        public string SdtDN { get; set; }
        public string MatKhau { get; set; }

    }
}
