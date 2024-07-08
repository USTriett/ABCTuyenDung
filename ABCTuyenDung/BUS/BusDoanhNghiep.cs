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
    }


}
