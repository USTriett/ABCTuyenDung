﻿using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DAOs
{
    public class DAODoanhNghiep
    {
        private static string connectionString;

        public static void Initialize(string conn)
        {
            connectionString = conn;
        }

        public static DTODoanhNghiep LayDoanhNghiepBangEmail(string email)
        {
            string query = "SELECT EMAIL, MATKHAU FROM DOANHNGHIEP WHERE EMAIL = @email";
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DTODoanhNghiep
                            {
                                Email = reader.GetString(0),
                                MatKhau = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static bool ThemDoanhNghiep(DTODoanhNghiep doanhNghiep)
        {
            string query = @"
            INSERT INTO DOANHNGHIEP (TENDN, EMAIL, DIACHI, MASOTHUE, NGUOIDAIDIEN, NGAYHETHAN, TIEMNANG, KQKD, SDTDN, MATKHAU)
            VALUES (@TenDN, @Email, @DiaChi, @MaSoThue, @NguoiDaiDien, @NgayHetHan, @TiemNang, @Kqkd, @SdtDN, @MatKhau)";

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@TenDN", doanhNghiep.TenDN);
                    cmd.Parameters.AddWithValue("@Email", doanhNghiep.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", doanhNghiep.DiaChi);
                    cmd.Parameters.AddWithValue("@MaSoThue", doanhNghiep.MaSoThue);
                    cmd.Parameters.AddWithValue("@NguoiDaiDien", doanhNghiep.NguoiDaiDien);
                    cmd.Parameters.AddWithValue("@NgayHetHan", doanhNghiep.NgayHetHan);
                    cmd.Parameters.AddWithValue("@TiemNang", doanhNghiep.TiemNang);
                    cmd.Parameters.AddWithValue("@Kqkd", doanhNghiep.Kqkd);
                    cmd.Parameters.AddWithValue("@SdtDN", doanhNghiep.SdtDN);
                    cmd.Parameters.AddWithValue("@MatKhau", doanhNghiep.MatKhau);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Kiểm tra doanh nghiệp đã tồn tại/đăng ký chưa bằng cách kiểm tra email 
        // public static bool KiemTraDoanhNghiepTonTai(string email, string tenDN)
        public static bool KiemTraDoanhNghiepTonTai(string email)
        {
            // string query = @"
            // SELECT COUNT(*)
            // FROM DOANHNGHIEP
            // WHERE EMAIL = @Email AND TENDN = @TenDN";

            string query = @"
            SELECT COUNT(*)
            FROM DOANHNGHIEP
            WHERE EMAIL = @Email";

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    // cmd.Parameters.AddWithValue("@TenDN", tenDN);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
