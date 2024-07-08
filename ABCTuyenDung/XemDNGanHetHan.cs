using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace ABCTuyenDung
{
    public partial class XemDNGanHetHan : UserControl
    { 
        private DoanhNghiepBUS dnBUS = new DoanhNghiepBUS();
        string conn = @"Data Source = localhost; Initial Catalog=CTY_ABC; Integrated Security=True";
        public XemDNGanHetHan()
        {
            InitializeComponent();
        }

        private void XemDNGanHetHan_Load(object sender, EventArgs e)
        {
            var dn = dnBUS.xemDSDN_BUS();
            tbDS.DataSource = dn;
            tbDS.Columns[0].HeaderText = "MÃ DN";
            tbDS.Columns[1].HeaderText = "TÊN DOANH NGHIỆP";
            tbDS.Columns[2].HeaderText = "NGƯỜI ĐẠI DIỆN";
            tbDS.Columns[3].HeaderText = "EMAIL";
            tbDS.Columns[4].HeaderText = "NGÀY HẾT HẠN";
            /**
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from DSDN", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                tbDS.DataSource = dt;
            }
            **/
        }

        private void tbDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dnHetHan = dnBUS.xemDSDNHetHan_BUS();
            tbDS.DataSource = dnHetHan;
            tbDS.Columns[0].HeaderText = "MÃ DN";
            tbDS.Columns[1].HeaderText = "TÊN DOANH NGHIỆP";
            tbDS.Columns[2].HeaderText = "NGƯỜI ĐẠI DIỆN";
            tbDS.Columns[3].HeaderText = "EMAIL";
            tbDS.Columns[4].HeaderText = "NGÀY HẾT HẠN";
            /**
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from DSDN_HETHAN", sqlconn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                tbDS.DataSource = dt;
            }
            **/
        }

        private void btXuatFile_Click(object sender, EventArgs e)
        {
            if (tbDS.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                string fixedName = "Danh sách doanh nghiệp sắp hết hạn ";
                string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
                save.FileName = $"{fixedName}{formattedDate}.pdf";

                bool error = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex) 
                        {
                            error = true;
                            MessageBox.Show("Không lưu được file\n" + ex.Message);
                        }
                    }
                    if (!error)
                    {
                        try
                        {
                            DoanhNghiepBUS.xuatFileDSDNHetHan_BUS(tbDS, save.FileName);
                            MessageBox.Show("Lưu file thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xuất file\n" + ex.Message);
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Không có dòng dữ liệu");
            }
        }
    }
}
