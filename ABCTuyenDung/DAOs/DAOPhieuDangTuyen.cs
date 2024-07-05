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
    public class DAOPhieuDangTuyen
    {
        public static void Them(System.Data.SqlClient.SqlConnection connection, DTOPhieuDangTuyen dTOPhieuDangTuyen)
        {
            string query = CreateInsertQueryString();
           
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaDN", dTOPhieuDangTuyen.MaDN);
                command.Parameters.AddWithValue("@ViTri", dTOPhieuDangTuyen.ViTri);
                command.Parameters.AddWithValue("@MoTa", dTOPhieuDangTuyen.MoTaViTri);
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
        private static string CreateInsertQueryString()
        {
            string queryFormat = "INSERT INTO PHIEUDANGTUYEN (TINHTRANGXACTHUC, TINHTRANGTHANHTOAN, MADN, VITRITD, MOTAVITRITD, SOLUONG, TIEUCHI,\r\nGIA, DATHANHTOAN, NGAYDBDT, THOIGIANDT, HINHTHUCDT)" +
                                 "VALUES (0, 0, @MaDN, @ViTri, @MoTa, @SoLuong, @YeuCau, @Gia, 0, @NgayBatDau, @ThoiGian, @HinhThucDT)";

            return queryFormat;
        }
    }
    
}
