using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DAOs
{
    public class DAOUngVien
    {
        private static SqlConnection _connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True;");
        public static DTOUngVien Lay(int maUV)
        {
            DTOUngVien ungVien = null;

            string query = "SELECT * FROM UngVien WHERE MaUV = @MaUV";

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@MaUV", maUV);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ungVien = new DTOUngVien
                            {
                                MaUV = maUV,
                                HoTen = reader.GetString(1),
                                GioiTinh = reader.GetString(2),
                                Sdt = reader.GetString(3),
                                NgaySinh = reader.GetDateTime(4),
                                DiaChi = reader.GetString(5),
                                Email = reader.GetString(6),
                                Kqkd = reader.GetBoolean(7)
                            };
                            return ungVien;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ, ví dụ ghi log hoặc thông báo lỗi
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                _connection.Close();
            }

            return ungVien;
        }
        private static string connectionString;

        public static void Initialize(string conn)
        {
            connectionString = conn;
        }

        public static DTOUngVien LayUngVienBangSDT(string sdt)
        {
            string query = "SELECT SDT, MATKHAU FROM UNGVIEN WHERE SDT = @sdt";
          
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                    {
                        cmd.Parameters.AddWithValue("@sdt", sdt);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new DTOUngVien
                                {
                                    Sdt = reader.GetString(0),
                                    MatKhau = reader.GetString(1)
                                };
                            }
                        }
                    }
                }
            return null;
           
        }

        public static bool ThemUngVien(DTOUngVien ungVien)
        {
            string query = @"
            INSERT INTO UNGVIEN(HOTEN, SDT, NGAYSINH, DIACHI, EMAIL, KQKD, MATKHAU)
            VALUES (@TenUV, @Sdt, @NgaySinh, @DiaChi, @Email, @Kqkd, @MatKhau)";

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@TenUV", ungVien.HoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", ungVien.DiaChi);
                    cmd.Parameters.AddWithValue("@Email", ungVien.Email);
                    cmd.Parameters.AddWithValue("@NgaySinh", ungVien.NgaySinh);
                    cmd.Parameters.AddWithValue("@Kqkd", ungVien.Kqkd);
                    cmd.Parameters.AddWithValue("@Sdt", ungVien.Sdt);
                    cmd.Parameters.AddWithValue("@MatKhau", ungVien.MatKhau);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

         public static bool KiemTraUngVienTonTai(string sdt)
        {
            string query = @"
            SELECT COUNT(*)
            FROM UNGVIEN
            WHERE SDT = @Sdt";

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@Sdt", sdt);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
