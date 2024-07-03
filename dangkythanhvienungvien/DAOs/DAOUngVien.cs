using System.Data.SqlClient;
using dangkythanhvienungvien.DTOs;

namespace dangkythanhvienungvien.DAOs
{
    public class DAOUngVien
    {
        string connectionString = "Server=DESKTOP-G6M2S90\\GRINFS;Database=CTY_ABC;Integrated Security=True;";

        public void InsertUngVien(DTOUngVien ungVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UngVien (HoTen, DiaChi, NgaySinh, Email, SDT, MatKhau) VALUES (@HoTen, @DiaChi, @NgaySinh, @Email, @SoDienThoai, @MatKhau)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", ungVien.HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", ungVien.DiaChi);
                cmd.Parameters.AddWithValue("@NgaySinh", ungVien.NgaySinh);
                cmd.Parameters.AddWithValue("@Email", ungVien.Email);
                cmd.Parameters.AddWithValue("@SoDienThoai", ungVien.SoDienThoai);
                cmd.Parameters.AddWithValue("@MatKhau", ungVien.MatKhau);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}