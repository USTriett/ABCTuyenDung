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


        public void handleTextSearchChanged(string key)
        {
            // Lấy toàn bộ những vị trí tuyển dụng hợp lệ rồi trả dưới dạng danh sách.
            dao.findAllBySearchKey(key, DTOPhieuDangTuyenAndDoanhNghiep.list);
        }


        public SqlDataAdapter layDanhSachViTriTD(string query, SqlConnection sqlCon)
        {
            return dao.layDanhSachViTriTD(query, sqlCon);
        }
    }
}
