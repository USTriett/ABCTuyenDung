using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung
{
    public partial class PhieuQuangCaoGUI : Form
    {
        private IDatePicker _startDate;
        private IDatePicker _endDate;
        private SqlConnection _connection;
        public PhieuQuangCaoGUI(SqlConnection sqlConnection)
        {

            _startDate = new IDatePicker();
            _endDate = new IDatePicker();
            InitializeComponent();
            startDatePanel.Controls.Add(_startDate);
            endDatePanel.Controls.Add(_endDate);
            _connection = sqlConnection;
            
        }

        public void AddClosingListener(FormClosedEventHandler action) {
            this.FormClosed += action;
        }

        public void FillForm(Dictionary<string, string> _fields)
        {
            viTriText.Text = _fields["viTriText"];
            viTriText.Text = _fields["viTriText"];
            moTaText.Text = _fields["moTaText"];
            soLuongText.Text = _fields["soLuongText"];
            yeuCauText.Text = _fields["yeuCauText"];
            hinhThucDangTuyenComboBox.Text = _fields["hinhThucDangTuyenComboBox"];
            _startDate.Value = DateTime.Parse(_fields["_startDate"]);
            _endDate.Value = DateTime.Parse(_fields["_endDate"]);
            priceTextBox.Text = _fields["price"];
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //
            DTOPhieuDangTuyen dTOPhieuDangTuyen = new DTOPhieuDangTuyen
            {
                MaDN = 1,
                ViTriTD = viTriText.Text.ToString(),
                SoLuong = int.Parse(soLuongText.Text.ToString()),
                MoTaViTriTD = moTaText.Text.ToString(),
                TieuChi = yeuCauText.Text.ToString(),
                Gia = float.Parse(priceTextBox.Text.ToString()),
                NgayBatDauDT = _startDate.Value,
                ThoiGianDangTuyen = int.Parse((_endDate.Value - _startDate.Value).TotalDays.ToString()) + 1,
                HinhThucDT = BUS.BusHinhThuc.GetId(hinhThucDangTuyenComboBox.Text.ToString()),

            };

            BUS.BusPhieuDangTuyen.ThemPhieuDangTuyenMoi(dTOPhieuDangTuyen);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void AddClosingListener(Form activeForm)
        {
            throw new NotImplementedException();
        }

        private void PhieuQuangCaoGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
