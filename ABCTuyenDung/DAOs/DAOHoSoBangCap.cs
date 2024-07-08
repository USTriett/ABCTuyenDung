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
    public class DAOHoSoBangCap
    {
        private static SqlConnection _connection = new SqlConnection("Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True;");
        public static void ThemNhieu(int maUV, DTOHoSoBangCap[] hoSoBangCaps)
        {
            try
            {
                if(_connection.State != System.Data.ConnectionState.Open) 
                    _connection.Open();

                foreach (var hoSoBangCap in hoSoBangCaps)
                {
                    string enableIdentityInsertQuery = "SET IDENTITY_INSERT HoSoBangCap ON";
                    string disableIdentityInsertQuery = "SET IDENTITY_INSERT HoSoBangCap OFF";
                    string insertQuery = "INSERT INTO HoSoBangCap (MaHSBC, TenHSBC, LoaiHSBC, NgayCap, HieuLuc, DonViCap, MaUV, Url) " +
                                         "VALUES (@MaHSBC, @TenHSBC, @LoaiHSBC, @NgayCap, @HieuLuc, @DonViCap, @MaUV, @Url)";

                    try
                    {
                    

                        using (SqlTransaction transaction = _connection.BeginTransaction())
                        {
                            using (SqlCommand command = new SqlCommand(enableIdentityInsertQuery, _connection, transaction))
                            {
                                command.ExecuteNonQuery();
                            }

                            using (SqlCommand command = new SqlCommand(insertQuery, _connection, transaction))
                            {
                                command.Parameters.AddWithValue("@MaHSBC", hoSoBangCap.MaHSBC);
                                command.Parameters.AddWithValue("@TenHSBC", hoSoBangCap.TenHSBC);
                                command.Parameters.AddWithValue("@LoaiHSBC", hoSoBangCap.LoaiHSBC);
                                command.Parameters.AddWithValue("@NgayCap", hoSoBangCap.NgayCap);
                                command.Parameters.AddWithValue("@HieuLuc", hoSoBangCap.HieuLuc);
                                command.Parameters.AddWithValue("@DonViCap", hoSoBangCap.DonViCap);
                                command.Parameters.AddWithValue("@MaUV", hoSoBangCap.MaUV);
                                command.Parameters.AddWithValue("@Url", hoSoBangCap.Url);

                                command.ExecuteNonQuery();
                            }

                            using (SqlCommand command = new SqlCommand(disableIdentityInsertQuery, _connection, transaction))
                            {
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that may have occurred
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                  
                }

                Console.WriteLine("Records inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message + " Thêm thất bại");
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        public static List<DTOHoSoBangCap> LayDanhSachHSBC(int maUV)
        {
            List<DTOHoSoBangCap> hoSoBangCaps = new List<DTOHoSoBangCap>();

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();

                string query = "SELECT MaHSBC, TenHSBC, LoaiHSBC, NgayCap, HieuLuc, DonViCap, MaUV, Url FROM HoSoBangCap WHERE MaUV = @MaUV";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@MaUV", maUV);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DTOHoSoBangCap hsbc = new DTOHoSoBangCap();

                            hsbc.MaHSBC = reader.GetInt32(0);
                            hsbc.TenHSBC = reader.IsDBNull(1) ? null : reader.GetString(1);
                            hsbc.LoaiHSBC = reader.IsDBNull(2) ? null : reader.GetString(2);
                            hsbc.NgayCap = reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3);
                            hsbc.HieuLuc = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                            hsbc.DonViCap = reader.IsDBNull(5) ? null : reader.GetString(5);
                            hsbc.MaUV = maUV;
                            hsbc.Url = reader.IsDBNull(7) ? null : reader.GetString(7);

                            hoSoBangCaps.Add(hsbc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                Console.WriteLine("Error: " + ex.Message);
            }
           
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return hoSoBangCaps;
        }
    }
}
