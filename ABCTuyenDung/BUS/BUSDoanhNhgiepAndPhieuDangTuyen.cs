using ABCTuyenDung.DAOs;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BUSDoanhNhgiepAndPhieuDangTuyen
    {
        private static DAOPhieuDangTuyenAndDoanhNghiep dao = new DAOPhieuDangTuyenAndDoanhNghiep();

        public static List<DTOPhieuDangTuyenAndDoanhNghiep> searhResult = new List<DTOPhieuDangTuyenAndDoanhNghiep>();


        public void handleTextSearchChanged(string key)
        {
            string connString = ConfigurationManager.AppSettings["ABCTuyenDung.Properties.Settings.CTY_ABCConnectionString"];
            Console.WriteLine(connString);
            if (connString.Length > 0)
            {
                // Tạo đối tượng SqlConnection
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    // Tạo đối tượng SqlCommand
                    SqlCommand sqlCommand = new SqlCommand("SELECT MAPHIEUDT, TENDN, VITRITD, NGUIODAIDIEN, (PDT.NGAYBDDT + THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN " +
                        "DOANHNGHIEP DN WHERE PDT.MADN = DN.MADN WHERE PDT.TINHTRANGTHANHTOAN = 1 AND VITRITD LIKE '%" + key + "%'", sqlCon);
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
                            DTOPhieuDangTuyenAndDoanhNghiep dto = new DTOPhieuDangTuyenAndDoanhNghiep
                            {
                                maPhieuDT = reader["MAPHIEUDT"].ToString(),
                                tenDN = reader["TENDN"].ToString(),
                                nguoiDaiDien = reader["NGUOIDAIDIEN"].ToString(),
                                viTriTD = reader["VITRITD"].ToString(),
                                ngayHetHan = Convert.ToDateTime(reader["NGAYHETHAN"])
                            };
                            searhResult.Add(dto);
                        }
                    }
                    reader.Dispose();
                    sqlCon.Dispose();
                    sqlCommand.Dispose();
                }
            }
        }


    }
}
