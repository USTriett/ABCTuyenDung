using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung.DAOs
{
    public class DAOPhieuDangKyUngTuyen
    {
        private static SqlConnection _connection = new SqlConnection("Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True;");
        public static void Them(DTOPhieuDangKyUngTuyen dTOPhieuDangKyUngTuyen)
        {
            // Define your SQL insert query here
            string query = "INSERT INTO CTY_ABC.dbo.PHIEUDKUT (TINHTRANG, MANV, MAPHIEUDT, MAUV, MOTA) VALUES (@TinhTrang, null, @MaPhieuDT, @MaUV, @MoTa)";

            
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@TinhTrang", dTOPhieuDangKyUngTuyen.TinhTrang);
       
                    command.Parameters.AddWithValue("@MaPhieuDT", dTOPhieuDangKyUngTuyen.MaPhieuDT);
                    command.Parameters.AddWithValue("@MaUV", dTOPhieuDangKyUngTuyen.MaUV);
                    command.Parameters.AddWithValue("@MoTa", dTOPhieuDangKyUngTuyen.MoTa);

                    try
                    {
                        // Open the connection
                        if(_connection.State != System.Data.ConnectionState.Open)
                            _connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                      
                        // Optionally, you can check if the insert was successful by checking rowsAffected
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Insert successful!");
                        }
                        else
                        {
                            Console.WriteLine("No rows affected.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that may have occurred
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }
        public static int GetId(int mauv, int maPhieuDT)
        {
            int id = -1; // Default value if no record is found
            string query = "SELECT MAPhieuDKUT FROM CTY_ABC.dbo.PHIEUDKUT WHERE MAUV = @MaUV AND MAPHIEUDT = @MaPhieuDT";

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@MaUV", mauv);
                    command.Parameters.AddWithValue("@MaPhieuDT", maPhieuDT);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (reader != null && reader.Read())
                        {
                            id = reader.GetInt32(0); // Assuming the ID column is the first column
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message + " Thêm thất bại");
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return id;
        }
    }   
}
