using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DTOs
{
    public class DTOPhieuDangTuyen
    {
        public int MaPhieuDT { get; set; }
        public bool TinhTrangXacThuc { get; set; }
        public bool TinhTrangThanhToan { get; set; }
        public int MaNV { get; set; }
        public int MaDN { get; set; }
        public string ViTri { get; set; }
        public string MoTaViTri { get; set; }
        public int SoLuong { get; set; }
        public string TieuChi { get; set; }
        public float Gia { get; set; }
        public string HinhThucTT { get; set; }
        public bool DaThanhToan { get; set; }
        public DateTime NgayBatDauDT { get; set; }
        public int ThoiGianDangTuyen { get; set; }
        public int HinhThucDT { get; set; }

    }
}
