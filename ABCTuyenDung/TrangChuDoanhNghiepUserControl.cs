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
        public TrangChuDoanhNghiepUserControl()
        {
            InitializeComponent();
        }

        private void dkdtButton_Click(object sender, EventArgs e)
        {
            DangKyDangTuyenGUI form1 = new DangKyDangTuyenGUI();
            form1.Show();
        }
    }
}
