using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DTOs
{
    public class DTOHoaDon
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaPhieuDangTuyen { get; set; }
        public bool TrangThai { get; set; }
        public float SoTienNop { get; set; }
        public float SoTienConLai { get; set; }
        public int MaNV { get; set; }
        public string HinhThucTT { get; set; }
        public int LanThanhToan { get; set; }
    }

}
