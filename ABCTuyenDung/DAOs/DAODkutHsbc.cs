using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung.DAOs
{
    public class DAODkutHsbc
    {
        private static SqlConnection _connection = new SqlConnection("Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True;");
        public static void Them(List<int> hsbc, int maPhieuDKUT)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();

                string query = "INSERT INTO DKUT_HSBC (MaPhieuDKUT, MaHSBC) VALUES (@MaPhieuDKUT, @MaHSBC)";

                foreach (int hs in hsbc)
                {
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        command.Parameters.AddWithValue("@MaPhieuDKUT", maPhieuDKUT);
                        command.Parameters.AddWithValue("@MaHSBC", hs);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm thành công");

            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show("Lỗi:" + "Hồ sơ đã được đăng ký" + " Thêm thất bại");
            }
            finally
            {

                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        public static List<int> GetAllHSBC(int maPhieuut)
        {
            List<int> hsbcIds = new List<int>();

            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();

                string query = "SELECT MaHSBC FROM DkutHsbc WHERE MaPhieuDKUT = @MaPhieuDangTuyen";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@MaPhieuDangTuyen", maPhieuut);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hsbcIds.Add(reader.GetInt32(0));
                        }
                    }
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show("Lỗi:" + ex.Message + " Thêm thất bại");
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return hsbcIds;
        }
    }
}
