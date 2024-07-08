using ABCTuyenDung.DTOs;
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
        private static SqlConnection _connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True");

        public static DTODoanhNghiep GetDoanhNghiepId(int id)
        {

            if(_connection.State != System.Data.ConnectionState.Open)
                _connection.Open();

            string sql = "SELECT * FROM DoanhNghiep WHERE MaDN = @MaDN";

            using (SqlCommand command = new SqlCommand(sql, _connection))
            {
                command.Parameters.AddWithValue("@MaDN", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DTODoanhNghiep dTODoanhNghiep = new DTODoanhNghiep
                        {
                            MaDN = id,
                            TenDN = reader["TenDN"].ToString(),
                            Email = reader["Email"].ToString(),
                            SdtDN = reader["SdtDN"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            NguoiDaiDien = reader["NguoiDaiDien"].ToString(),
                            MaSoThue = reader["MaSoThue"].ToString(),
                            NgayHetHan = Convert.ToDateTime(reader["NgayHetHan"]),
                            TiemNang = Convert.ToBoolean(reader["TiemNang"]),
                            Kqkd = Convert.ToBoolean(reader["Kqkd"]),
                            MatKhau = reader["MatKhau"].ToString()

                        };
                        return dTODoanhNghiep;
                    }
                }
            }

            return null;
        }
    }
}
