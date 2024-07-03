using ABCTuyenDung.DAOs;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusDoanhNghiep
    {
        public static DTODoanhNghiep dtoDoanhNghiep = new DTODoanhNghiep();

        public static bool KiemTraThongTinDangNhap(string email, string matKhau)
        {
            DTODoanhNghiep doanhNghiep = DAODoanhNghiep.LayDoanhNghiepBangEmail(email);
            if (doanhNghiep != null)
            {
                bool correctPassword = BCrypt.Net.BCrypt.Verify(matKhau, doanhNghiep.MatKhau);
                return correctPassword;
            }
            return false;
        }
        public static bool DangKyDoanhNghiep(DTODoanhNghiep doanhNghiep)
        {
            return DAODoanhNghiep.ThemDoanhNghiep(doanhNghiep);
        }

        public static bool KiemTraDoanhNghiepTonTai(DTODoanhNghiep doanhNghiep)
        {
            return DAODoanhNghiep.KiemTraDoanhNghiepTonTai(doanhNghiep.Email);         
        }
    }
}
