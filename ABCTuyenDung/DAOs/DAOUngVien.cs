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
                if(_connection.State != System.Data.ConnectionState.Open)
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
    }
}
