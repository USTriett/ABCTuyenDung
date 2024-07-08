using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusPhieuDangKyUngTuyen
    {
        public static DTOPhieuDangKyUngTuyen dTOPhieuDangKyUngTuyen = new DTOPhieuDangKyUngTuyen();

        public static void ThemPhieu(DTOPhieuDangKyUngTuyen dTOPhieuDangKyUngTuyen)
        {
            DAOs.DAOPhieuDangKyUngTuyen.Them(dTOPhieuDangKyUngTuyen);
        }

        public static int LayMa(int maUV, int maPhieuDT)
        {
            return DAOs.DAOPhieuDangKyUngTuyen.GetId(maUV, maPhieuDT);
        }
    }
}
