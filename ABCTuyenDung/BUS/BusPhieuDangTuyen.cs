using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusPhieuDangTuyen
    {
        public static DTOPhieuDangTuyen dTOPhieuDangTuyen = new DTOPhieuDangTuyen();

        public static void ThemPhieuDangTuyenMoi(DTOPhieuDangTuyen dTOPhieuDangTuyen, System.Data.SqlClient.SqlConnection _connection)
        {
            DAOs.DAOPhieuDangTuyen.Them(_connection, dTOPhieuDangTuyen);
        }
    }
}
