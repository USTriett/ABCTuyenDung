using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ABCTuyenDung.DAOs
{
    public class DAOPhieuDangTuyenAndDoanhNghiep
    {
        public void findAllBySearchKey(string key, List<DTOPhieuDangTuyenAndDoanhNghiep> list)
        {
            list.Clear();
            string connString = ConfigurationManager.ConnectionStrings["ABCTuyenDung.Properties.Settings.CTY_ABCConnectionString"]?.ConnectionString;
            Console.WriteLine(connString);
            if (connString.Length > 0)
            {
                // Tạo đối tượng SqlConnection
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    // Mở kết nối
                    sqlCon.Open();

                    // Tạo đối tượng SqlCommand với truy vấn tham số trong khối using
                    using (SqlCommand sqlCommand = new SqlCommand(
                        "SELECT PDT.MAPHIEUDT, DN.TENDN, VITRITD, DN.NGUOIDAIDIEN, PDT.SOLUONG, (PDT.NGAYDBDT + PDT.THOIGIANDT) AS NGAYHETHAN " +
                        "FROM PHIEUDANGTUYEN PDT JOIN DOANHNGHIEP DN ON DN.MADN = PDT.MADN " +
                        "WHERE TINHTRANGTHANHTOAN = 1 AND (VITRITD LIKE @key OR DN.TENDN LIKE @key)", sqlCon))
                    {
                        // Thêm tham số vào SqlCommand
                        sqlCommand.Parameters.AddWithValue("@key", "%" + key + "%");

                        // Thực hiện câu lệnh và lấy SqlDataReader trong khối using
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            // Kiểm tra nếu có hàng nào được trả về
                            if (reader.HasRows)
                            {
                                // Đọc từng hàng
                                while (reader.Read())
                                {
                                    // Lấy dữ liệu từ từng cột
                                    DTOPhieuDangTuyenAndDoanhNghiep dao = new DTOPhieuDangTuyenAndDoanhNghiep
                                    {
                                        maPhieuDT = reader["MAPHIEUDT"].ToString(),
                                        tenDN = reader["TENDN"].ToString(),
                                        nguoiDaiDien = reader["NGUOIDAIDIEN"].ToString(),
                                        viTriTD = reader["VITRITD"].ToString(),
                                        ngayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"]),
                                        soLuong = int.Parse(reader["SOLUONG"].ToString())
                                    };
                                    list.Add(dao);
                                }
                            }
                        }
                    }
                }

            }
        }
            public List<DTOPhieuDangTuyenAndDoanhNghiep> findAll()
        {
            List<DTOPhieuDangTuyenAndDoanhNghiep> list = new List<DTOPhieuDangTuyenAndDoanhNghiep>();
            string connString = ConfigurationManager.ConnectionStrings["ABCTuyenDung.Properties.Settings.CTY_ABCConnectionString"]?.ConnectionString;
            Console.WriteLine(connString);
            if (connString.Length > 0)
            {
                // Tạo đối tượng SqlConnection
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    // Tạo đối tượng SqlCommand
                    SqlCommand sqlCommand = new SqlCommand("SELECT MAPHIEUDT, TENDN, VITRITD, SOLUONG, NGUIODAIDIEN, (PDT.NGAYBDDT + THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN " +
                        "DOANHNGHIEP DN WHERE PDT.MADN = DN.MADN WHERE PDT.TINHTRANGTHANHTOAN = 1", sqlCon);
                    // Mở kết nối
                    sqlCon.Open();
                    // Thực hiện câu lệnh và lấy SqlDataReader
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    // Kiểm tra nếu có hàng nào được trả về
                    if (reader.HasRows)
                    {
                        // Đọc từng hàng
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ từng cột
                            DTOPhieuDangTuyenAndDoanhNghiep dao = new DTOPhieuDangTuyenAndDoanhNghiep
                            {
                                maPhieuDT = reader["MAPHIEUDT"].ToString(),
                                tenDN = reader["TENDN"].ToString(),
                                nguoiDaiDien = reader["NGUOIDAIDIEN"].ToString(),
                                viTriTD = reader["VITRITD"].ToString(),
                                soLuong = int.Parse(reader["SOLUONG"].ToString()),
                                ngayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"])
                            };
                            list.Add(dao);
                        }
                    }
                    reader.Dispose();
                    sqlCon.Dispose();
                    sqlCommand.Dispose();
                }
            }
            return list;
        }

        public SqlDataAdapter layDanhSachViTriTD(string query, SqlConnection sqlCon)
        {
            return new SqlDataAdapter(query, sqlCon);
        }

    }
}
