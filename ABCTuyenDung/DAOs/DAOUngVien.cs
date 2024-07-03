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
    }
}
