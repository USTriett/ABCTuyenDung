using ABCTuyenDung.DAOs;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusDoanhNghiep
    {
        private static DTODoanhNghiep _dTODoanhNghiep;

        public static DTODoanhNghiep GetDoanhNghiep(int id)
        {
            _dTODoanhNghiep =  DAOs.DAODoanhNghiep.GetDoanhNghiepId(id);

            return _dTODoanhNghiep;
        }
        public static int GetId(string email)
        {
            return DAODoanhNghiep.LayDoanhNghiepBangEmail(email).MaDN;
        }

        public static int GetMaDN(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.MaDN ?? 0;
        }

        public static string GetTenDN(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.TenDN;
        }

        public static string GetEmail(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.Email;
        }

        public static string GetDiaChi(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.DiaChi;
        }

        public static string GetMaSoThue(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.MaSoThue;
        }

        public static string GetNguoiDaiDien(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.NguoiDaiDien;
        }

        public static DateTime? GetNgayHetHan(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.NgayHetHan;
        }

        public static bool? GetTiemNang(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.TiemNang;
        }

        public static bool? GetKqkd(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.Kqkd;
        }

        public static string GetSdtDN(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.SdtDN;
        }

        public static string GetMatKhau(int id)
        {
            _dTODoanhNghiep = GetDoanhNghiep(id);
            return _dTODoanhNghiep?.MatKhau;
        }
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
