using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABCTuyenDung
{
    public partial class XemDNGanHetHan : UserControl
    { 
        string conn = @"Data Source = localhost; Initial Catalog=CTY_ABC; Integrated Security=True";
        public XemDNGanHetHan()
        {
            InitializeComponent();
        }

        private void XemDNGanHetHan_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from DSDN", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                tbDS.DataSource = dt;
            }

        }

       
    }
}
