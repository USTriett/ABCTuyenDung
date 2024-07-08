using ABCTuyenDung.DAOs;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusNhanVien
    {
        public static DTOs.DTONhanVien dtoNhanVien = new DTOs.DTONhanVien();

        public static bool KiemTraThongTinDangNhap(string sdt, string matKhau)
        {
            DTONhanVien nhanVien = DAONhanVien.LayNhanVienBangSdt(sdt);
            if (nhanVien != null)
            {
                bool correctPassword = BCrypt.Net.BCrypt.Verify(matKhau, nhanVien.MatKhau);
                return correctPassword;
            }
            return false;
        }
    }

}
