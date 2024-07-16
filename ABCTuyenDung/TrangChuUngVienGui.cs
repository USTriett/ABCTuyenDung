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
    public partial class TrangChuUngVienGui : Form
    {
        private int maUV;
        public TrangChuUngVienGui(int maUV)
        {
            InitializeComponent();
            this.maUV = maUV;
        }

        private void recruitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            MHDanhSachViTriTuyenDung dsTuyenDungGui = new MHDanhSachViTriTuyenDung(maUV);
            //dsTuyenDungGui.FormClosed += (s, args) => this.Close();
            dsTuyenDungGui.ShowDialog(this);

        }

        private void TrangChuUngVienGui_Load(object sender, EventArgs e)
        {

        }
    }
}
