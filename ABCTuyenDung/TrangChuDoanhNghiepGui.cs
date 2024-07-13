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
    public partial class TrangChuDoanhNghiepGui : Form
    {
        public TrangChuDoanhNghiepGui()
        {
            InitializeComponent();
        }

        private void recruitLabel_Click(object sender, EventArgs e)
        {
            var trangChuUC = new TrangChuDoanhNghiepUserControl();
            panel1.Controls.Add(trangChuUC);
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
