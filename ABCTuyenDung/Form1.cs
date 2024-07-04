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

        private void dateTimePickerLayout_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)sender;

            Panel panel1 = flowLayoutPanel.Controls[0] as Panel;
            panel1.Controls.Add(_startDate);
            panel1 = flowLayoutPanel.Controls[2] as Panel;
            panel1.Controls.Add(_endDate);

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
