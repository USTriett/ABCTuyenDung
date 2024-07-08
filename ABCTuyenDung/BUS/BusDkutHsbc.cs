using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusDkutHsbc
    {
        public static DTODkutHsbc dTODkutHsbc = new DTODkutHsbc();
       
        public static void ThemHSBC(List<int> hsbcs, int maPhieuUT)
        {
            if (hsbcs.Count == 0) { return; }
            DAOs.DAODkutHsbc.Them(hsbcs, maPhieuUT);
        }
    }
}
