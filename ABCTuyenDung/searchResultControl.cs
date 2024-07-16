using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung
{
    public partial class searchResultControl : UserControl
    {
        public int maDoanhNghiep;
        public string maPhieuDangTuyen;
        public searchResultControl()
        {
            InitializeComponent();
            
        }

        

        public void setDataFromDTO(DTOPhieuDangTuyenAndDoanhNghiep dto)
        {
            this.maDoanhNghiep = dto.maDN;
            this.title.Text = dto.viTriTD;
            this.company.Text = dto.tenDN;
            maPhieuDangTuyen = dto.maPhieuDT;
            this.number.Text = "Số lượng: " + dto.soLuong.ToString();
        }

        

    }
}
