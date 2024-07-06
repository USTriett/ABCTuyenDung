using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung
{
    public class DoanhNghiepBUS
    {
        private DoanhNghiepDAO dnDAO = new DoanhNghiepDAO();

        public List<DoanhNghiepDTO> xemDSDN_BUS()
        {
            return dnDAO.xemDSDN_DAO();
        }

        public List<DoanhNghiepDTO> xemDSDNHetHan_BUS()
        {
            return dnDAO.xemDSDNHetHan_DAO();
        }
    }
}
