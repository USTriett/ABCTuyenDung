using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusUngVien
    {
        public static DTOUngVien dTOUngVien = new DTOUngVien();

        public static void LayThongTin(int maUV)
        {
           dTOUngVien = DAOs.DAOUngVien.Lay(maUV);
        }

    }
}
