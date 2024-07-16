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
    public partial class TrangChuDoanhNghiepUserControl : UserControl
    {
        private string email;
        public TrangChuDoanhNghiepUserControl(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void dkdtButton_Click(object sender, EventArgs e)
        {
            int id = BUS.BusDoanhNghiep.GetId(email);
            DangKyDangTuyenGUI form1 = new DangKyDangTuyenGUI(id);
            form1.Show();
        }
    }
}
