using ABCTuyenDung.BUS;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung
{
    public partial class MHDanhSachViTriTuyenDung : Form
    {
        public static BUSDoanhNhgiepAndPhieuDangTuyen bus = new BUSDoanhNhgiepAndPhieuDangTuyen();
        public MHDanhSachViTriTuyenDung()
        {
            InitializeComponent();
        }

        public void StyleDataGridView(DataGridView dgv)
        {
            // Set the background color for the DataGridView
            dgv.BackgroundColor = Color.White;
            // Set the border style for the DataGridView
            dgv.BorderStyle = BorderStyle.Fixed3D;
            // Set the color for the grid lines
            dgv.GridColor = Color.LightGray;

            // Set the default cell style
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Arial", 13, FontStyle.Regular);

            // Set the column header style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Màu header là đen
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Teal;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            // Set the row header style
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgv.RowHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Regular);

            // Set alternating row styles
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Set the row template height (increase the row height here)
            dgv.RowTemplate.Height = 40; // Adjust this value as needed

            // Set auto size columns mode
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set the read-only property
            dgv.ReadOnly = true;

            // Disable user to add or delete rows
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            // Set the row header width
            dgv.RowHeadersWidth = 50;
        }

        public void MHDanhSachViTriTuyenDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cTY_ABCDataSet.DSDN' table. You can move, or remove it, as needed.
            // Liên kết dữ liệu của table với database.
            string connString = ConfigurationManager.ConnectionStrings["ABCTuyenDung.Properties.Settings.CTY_ABCConnectionString"]?.ConnectionString;
            if (connString.Length > 0)
            {
                // Tạo đối tượng SqlConnection
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    sqlCon.Open();
                    // Tạo đối tượng SqlCommand
                    SqlDataAdapter sqlDataAdapter = bus.generateSqlDataAdapter("SELECT TENDN, DN.NGUOIDAIDIEN, PDT.MAPHIEUDT, PDT.VITRITD, (PDT.NGAYDBDT + PDT.THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN DOANHNGHIEP DN ON PDT.MADN = DN.MADN WHERE TINHTRANGTHANHTOAN = 1;", sqlCon);
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    danhSachTD.DataSource = table;
                    StyleDataGridView(danhSachTD);
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách vị trí tuyển dụng. Vui lòng thử lại sau!");
                return;
            }
        }

        public void loadDetails()
        {
            for (int i = 0; i < DTOPhieuDangTuyenAndDoanhNghiep.list.Count; i++)
            {
                if (i <= 4)
                {
                    searchResultControl res = new searchResultControl();
                    res.setDataFromDTO(DTOPhieuDangTuyenAndDoanhNghiep.list[i]);
                    resultContainer.Controls.Add(res);
                }
                else break;
            }
            
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.TextLength > 0)
            {
                resultContainer.Controls.Clear();
                bus.handleTextSearchChanged(textSearch.Text);
                loadDetails();
                resultContainer.Height = (resultContainer.Controls.Count > 5 ? 5: resultContainer.Controls.Count) * 75;
                placeholder.Visible = false;
            }
            else
            {
                resultContainer.Height = 0;
                placeholder.Visible = true;
            }
        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            MessageBox.Show(textSearch.Text);
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Người dùng nhấn Enter để bắt đầu tìm kiếm.
                string key = textSearch.Text;
                // TODO: This line of code loads data into the 'cTY_ABCDataSet.DSDN' table. You can move, or remove it, as needed.
                // Liên kết dữ liệu của table với database.
                string connString = ConfigurationManager.ConnectionStrings["ABCTuyenDung.Properties.Settings.CTY_ABCConnectionString"]?.ConnectionString;
                if (connString.Length > 0)
                {
                    // Tạo đối tượng SqlConnection
                    using (SqlConnection sqlCon = new SqlConnection(connString))
                    {
                        if (key.Length > 0)
                        {
                            sqlCon.Open();
                            // Tạo đối tượng SqlCommand
                            SqlDataAdapter sqlAdapter = bus.generateSqlDataAdapter("SELECT DN.TENDN, DN.NGUOIDAIDIEN, PDT.MAPHIEUDT, PDT.VITRITD, (PDT.NGAYDBDT + PDT.THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN DOANHNGHIEP DN ON PDT.MADN = DN.MADN WHERE TINHTRANGTHANHTOAN = 1 AND (VITRITD LIKE '%" + key + "%' OR DN.TENDN LIKE '%" + key + "%')", sqlCon);
                            DataTable table = new DataTable();
                            sqlAdapter.Fill(table);
                            danhSachTD.DataSource = table;
                            StyleDataGridView(danhSachTD);

                            // remove resultContaner.
                            resultContainer.Height = 0;
                        }
                        else
                        {
                            sqlCon.Open();
                            // Tạo đối tượng SqlCommand
                            SqlDataAdapter sqlAdapter = bus.generateSqlDataAdapter("SELECT DN.TENDN, DN.NGUOIDAIDIEN, PDT.MAPHIEUDT, PDT.VITRITD, (PDT.NGAYDBDT + PDT.THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN DOANHNGHIEP DN ON PDT.MADN = DN.MADN WHERE TINHTRANGTHANHTOAN = 1", sqlCon);
                            DataTable table = new DataTable();
                            sqlAdapter.Fill(table);
                            danhSachTD.DataSource = table;
                            StyleDataGridView(danhSachTD);

                            // remove resultContaner.
                            resultContainer.Height = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tải được danh sách vị trí tuyển dụng. Vui lòng thử lại sau!");
                    return;
                }
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            // Người dùng nhấn Enter để bắt đầu tìm kiếm.
            string key = textSearch.Text;
            // TODO: This line of code loads data into the 'cTY_ABCDataSet.DSDN' table. You can move, or remove it, as needed.
            // Liên kết dữ liệu của table với database.
            string connString = ConfigurationManager.ConnectionStrings["ABCTuyenDung.Properties.Settings.CTY_ABCConnectionString"]?.ConnectionString;
            if (connString.Length > 0)
            {
                // Tạo đối tượng SqlConnection
                using (SqlConnection sqlCon = new SqlConnection(connString))
                {
                    if (key.Length > 0)
                    {
                        sqlCon.Open();
                        // Tạo đối tượng SqlCommand
                        SqlDataAdapter sqlAdapter = bus.generateSqlDataAdapter("SELECT DN.TENDN, DN.NGUOIDAIDIEN, PDT.MAPHIEUDT, PDT.VITRITD, (PDT.NGAYDBDT + PDT.THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN DOANHNGHIEP DN ON PDT.MADN = DN.MADN WHERE TINHTRANGTHANHTOAN = 1 AND (VITRITD LIKE '%" + key + "%' OR DN.TENDN LIKE '%" + key + "%')", sqlCon);
                        DataTable table = new DataTable();
                        sqlAdapter.Fill(table);
                        danhSachTD.DataSource = table;
                        StyleDataGridView(danhSachTD);
                        // remove resultContaner.
                        resultContainer.Height = 0;
                    }
                    else
                    {
                        sqlCon.Open();
                        // Tạo đối tượng SqlCommand
                        SqlDataAdapter sqlAdapter = bus.generateSqlDataAdapter("SELECT DN.TENDN, DN.NGUOIDAIDIEN, PDT.MAPHIEUDT, PDT.VITRITD, (PDT.NGAYDBDT + PDT.THOIGIANDT) AS NGAYHETHAN FROM PHIEUDANGTUYEN PDT JOIN DOANHNGHIEP DN ON PDT.MADN = DN.MADN WHERE TINHTRANGTHANHTOAN = 1", sqlCon);
                        DataTable table = new DataTable();
                        sqlAdapter.Fill(table);
                        danhSachTD.DataSource = table;
                        StyleDataGridView(danhSachTD);
                        // remove resultContaner.
                        resultContainer.Height = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tải được danh sách vị trí tuyển dụng. Vui lòng thử lại sau!");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            placeholder.Visible = false;
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            placeholder.Visible = false;
        }

        private void homeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
