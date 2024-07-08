using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DAOs
{
    public class DAOHinhThuc
    {
        public static List<DTOHinhThuc> GetFormat(SqlConnection connection)
        {
            string query = "SELECT MaHT, TenHT, DonViTG, Gia FROM Hinhthuc\r\n";
            List<DTOHinhThuc> result = new List<DTOHinhThuc>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tenHT = reader["TenHT"].ToString();

                        System.Diagnostics.Debug.WriteLine($"TenHT: {tenHT}");
                        DTOHinhThuc hinhThuc = new DTOHinhThuc
                        {
                            MaHT = Convert.ToInt32(reader["MaHT"]),
                            TenHT = tenHT,
                            DonViTG = reader["DonViTG"].ToString(),
                            Gia = Convert.ToSingle(reader["Gia"])
                        };
                        result.Add(hinhThuc);
                    }
                }
            }

            return result;
        }

      

        
    }
}
