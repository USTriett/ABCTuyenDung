using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.DAOs
{
    public class DAOPhieuDangTuyen
    {
        private static System.Data.SqlClient.SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True;");
        public static void Them(DTOPhieuDangTuyen dTOPhieuDangTuyen)
        {
            string query = CreateInsertQueryString();
           
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaDN", dTOPhieuDangTuyen.MaDN);
                command.Parameters.AddWithValue("@ViTri", dTOPhieuDangTuyen.ViTriTD);
                command.Parameters.AddWithValue("@MoTa", dTOPhieuDangTuyen.MoTaViTriTD);
                command.Parameters.AddWithValue("@SoLuong", dTOPhieuDangTuyen.SoLuong);
                command.Parameters.AddWithValue("@YeuCau", dTOPhieuDangTuyen.TieuChi);
                command.Parameters.AddWithValue("@Gia", dTOPhieuDangTuyen.Gia);
                command.Parameters.AddWithValue("@HinhThucDT", dTOPhieuDangTuyen.HinhThucDT);
                command.Parameters.AddWithValue("@NgayBatDau", dTOPhieuDangTuyen.NgayBatDauDT);
                command.Parameters.AddWithValue("@ThoiGian", dTOPhieuDangTuyen.ThoiGianDangTuyen);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
            }
    }

        public static DTOPhieuDangTuyen Lay(int maPhieuDangTuyen)
        {

            if (connection.State != ConnectionState.Open)
                connection.Open();
            string sql = "SELECT * FROM PhieuDangTuyen WHERE MaPhieuDT = @MaPhieuDT";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MaPhieuDT", maPhieuDangTuyen);

                // Thực hiện câu lệnh và lấy SqlDataReader trong khối using
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("reader create : " + reader.FieldCount);

                    if (reader.Read())
                    {
                        DTOPhieuDangTuyen dTOphieuDangTuyen = new DTOPhieuDangTuyen
                        {
                            MaPhieuDT = maPhieuDangTuyen,
                            TinhTrangXacThuc = Convert.ToBoolean(reader["TinhTrangXacThuc"]),
                            TinhTrangThanhToan = Convert.ToBoolean(reader["TinhTrangThanhToan"]),
                            MaNV = Convert.ToInt32(reader["MaNV"]),
                            MaDN = Convert.ToInt32(reader["MaDN"]),
                            ViTriTD = reader["ViTriTD"].ToString(),
                            MoTaViTriTD = reader["MoTaViTriTD"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            TieuChi = reader["TieuChi"].ToString(),
                            Gia = Convert.ToSingle(reader["Gia"]),
                            HinhThucTT = reader["HinhThucTT"].ToString(),
                            DaThanhToan = Convert.ToBoolean(reader["DaThanhToan"]),
                            NgayBatDauDT = Convert.ToDateTime(reader["NgayDBDT"]),
                            ThoiGianDangTuyen = Convert.ToInt32(reader["ThoiGianDT"]),
                            HinhThucDT = Convert.ToInt32(reader["HinhThucDT"])
                        };

                        return dTOphieuDangTuyen;
                    }

                    // reader is closed and disposed of here automatically
                }

                // command is disposed of here automatically
            }
            return null;
        }
        

        private static string CreateInsertQueryString()
        {
            string queryFormat = "INSERT INTO PHIEUDANGTUYEN (TINHTRANGXACTHUC, TINHTRANGTHANHTOAN, MADN, VITRITD, MOTAVITRITD, SOLUONG, TIEUCHI,\r\nGIA, DATHANHTOAN, NGAYDBDT, THOIGIANDT, HINHTHUCDT)" +
                                 "VALUES (0, 0, @MaDN, @ViTri, @MoTa, @SoLuong, @YeuCau, @Gia, 0, @NgayBatDau, @ThoiGian, @HinhThucDT)";

            return queryFormat;
        }
    }
    
}
