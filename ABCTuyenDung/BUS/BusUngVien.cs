using ABCTuyenDung.DAOs;
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

        public static bool KiemTraThongTinDangNhap(string sdt, string matKhau)
        {
            DTOUngVien ungVien = DAOUngVien.LayUngVienBangSDT(sdt);
            if (ungVien != null)
            {
                int salt = 12;
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(matKhau, salt);
                bool correctPassword = BCrypt.Net.BCrypt.Verify(ungVien.MatKhau, passwordHash);
                return correctPassword;
            }
            return false;
        }
    }
}
