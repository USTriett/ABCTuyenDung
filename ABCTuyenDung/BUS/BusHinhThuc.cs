using ABCTuyenDung.DAOs;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCTuyenDung.BUS
{
    public class BusHinhThuc
    {
        public static DTOHinhThuc dTOHinhThuc = new DTOHinhThuc();
        public static List<DTOHinhThuc> listDTOHinhThuc = new List<DTOHinhThuc>();
        public static Dictionary<string, float> _priceCheck = new Dictionary<string, float>();
        public static Dictionary<string, int> _idCheck = new Dictionary<string, int>();

        public static void GetAllFormat(SqlConnection connection)
        {
            listDTOHinhThuc = DAOHinhThuc.GetFormat(connection);

            foreach (var item in listDTOHinhThuc)
            {
                if (_priceCheck.ContainsKey(item.TenHT)){
                    _priceCheck.Add(item.TenHT, item.Gia);

                }
                else
                {
                    _priceCheck[item.TenHT] = item.Gia;
                    _idCheck[item.TenHT] = item.MaHT;
                }

            }
    }
        public static List<string> GetAllName()
        {
            List<string> list = new List<string>();
            
            foreach (var item in listDTOHinhThuc)
            {
                list.Add(item.TenHT);
                
            }
         
            return list;
        }
        public static float GetPrice(string hinhthuc)
        {
            
            return _priceCheck[hinhthuc];
        }
        public static int GetId(string hinhthuc)
        {

            return _idCheck[hinhthuc];
        }
    }

}
