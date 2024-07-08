using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusHoSoBangCap
    {
        public static DTOHoSoBangCap dTOHoSoBangCap = new DTOHoSoBangCap();

        public static List<DTOHoSoBangCap> dTOHoSoBangCaps = new List<DTOHoSoBangCap>();

        public static void ThemNhieuHoSo(int maUV, DTOHoSoBangCap[] hoSoBangCaps)
        {
            if (hoSoBangCaps.Length == 0)
            {
                return;
            }


            DAOs.DAOHoSoBangCap.ThemNhieu(maUV, hoSoBangCaps);
            foreach(var hs in hoSoBangCaps)
            {
                dTOHoSoBangCaps.Add(hs);
            }
        }

        public static int getMaxID()
        {
            int max = 0;
            foreach (var hs in dTOHoSoBangCaps) { 
                if(max < hs.MaHSBC) {  max = hs.MaHSBC; }
            }
            return max;
        }
        public static void LayDanhSachHSBC(int maUV)
        {
            dTOHoSoBangCaps = DAOs.DAOHoSoBangCap.LayDanhSachHSBC(maUV);

        }


    }
}
