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
    public partial class Form1 : Form
    {
        private IDatePicker _startDate;
        private IDatePicker _endDate;
        public Form1()
        {
            _startDate = new IDatePicker();
            _endDate = new IDatePicker();

            InitializeComponent();


        }
        public void TestSqlConnector(string connector)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnUC.Controls.Clear();
            XemDNGanHetHan uc = new XemDNGanHetHan();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            uc.Focus();
            pnUC.Controls.Add(uc);
        }
    }
}
