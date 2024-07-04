using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DTOs
{
    public class DTOHinhThuc
    {
        public int MaHT { get; set; }
        public string TenHT { get; set; }
        public byte[] Ten { get; set; }
        public string DonViTG { get; set; }
        public float Gia { get; set; }
    }
}
