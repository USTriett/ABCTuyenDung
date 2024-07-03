using dangkythanhvienungvien.DTOs;
using dangkythanhvienungvien.DAOs;

namespace dangkythanhvienungvien.BUS
{
    public class BusUngVien
    {
        public void DangKyUngVien(DTOUngVien ungVien)
        {
            DAOUngVien daoUngVien = new DAOUngVien();
            daoUngVien.InsertUngVien(ungVien);
        }
    }
}