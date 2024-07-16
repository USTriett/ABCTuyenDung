using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ABCTuyenDung
{
    public class DoanhNghiepDAO
    {
        string conn = @"Data Source = localhost; Initial Catalog=CTY_ABC; Integrated Security=True";
        public List<DoanhNghiepDTO> xemDSDN_DAO()
        {
            List<DoanhNghiepDTO> DoanhNghiep = new List<DoanhNghiepDTO>();
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("select * from DOANHNGHIEP", sqlconn);
                sqlconn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoanhNghiep.Add(new DoanhNghiepDTO
                    {
                        ID = Convert.ToInt32(reader["MADN"]),
                        Ten = reader["TENDN"].ToString(),
                        DaiDien = reader["NGUOIDAIDIEN"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        NgayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"])
                    });
                }
            }
            return DoanhNghiep;
        }
        public List<DoanhNghiepDTO> xemDSDNHetHan_DAO()
        {
            List<DoanhNghiepDTO> DoanhNghiep = new List<DoanhNghiepDTO>();
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("select * from DOANHNGHIEP where NGAYHETHAN <= DATEADD(day, 7, GETDATE())", sqlconn);
                sqlconn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoanhNghiep.Add(new DoanhNghiepDTO
                    {
                        ID = (int)reader["MADN"],
                        Ten = reader["TENDN"].ToString(),
                        DaiDien = reader["NGUOIDAIDIEN"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        NgayHetHan = (DateTime)reader["NGAYHETHAN"]
                    });
                }
            }
            return DoanhNghiep;
        }
    }
}
