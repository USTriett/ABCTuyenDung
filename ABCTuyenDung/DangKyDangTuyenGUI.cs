using ABCTuyenDung.DTOs;
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
using Tulpep.NotificationWindow;

namespace ABCTuyenDung
{
    public partial class DangKyDangTuyenGUI : Form
    {
        private IDatePicker _startDate;
        private IDatePicker _endDate;
        private SqlConnection _dbConnector;
        private Dictionary<string, string> _fields = new Dictionary<string, string>();
        //private 
        private PopupNotifier _notifier;

        private PhieuQuangCaoGUI _phieuQuangCaoGUI;


        public DangKyDangTuyenGUI()
        {
             _startDate = new IDatePicker();
             _endDate = new IDatePicker();
            DateTime tomorrow = DateTime.Now.Date.AddDays(1);

            _startDate.MinDate = tomorrow;
            _endDate.MinDate = tomorrow;
            InitializeDatabaseConnection();
            InitializeComponent();
            InitializeCustomComponent();
            InitializeData();
        }

        private void InitializeCustomComponent()
        {
            _notifier = new PopupNotifier();
            _notifier.TitleText = "Missing Field";
            _notifier.ContentText = "Please Complete All Field";

            _fields.Add("viTriText", viTriText.Text.ToString());
            _fields.Add("moTaText", moTaText.Text.ToString());
            _fields.Add("soLuongText", soLuongText.Text.ToString());
            _fields.Add("yeuCauText", yeuCauText.Text.ToString());
            _fields.Add("hinhThucDangTuyenComboBox", hinhThucDangTuyenComboBox.Text.ToString());
            _fields.Add("_startDate", _startDate.Value.Date.ToString());
            _fields.Add("_endDate", _endDate.Value.Date.ToString());
            _fields.Add("price", "0");


            

        }

        private void SetActive(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void InitializeData()
        {
            BUS.BusHinhThuc.GetAllFormat(_dbConnector);
            string[] formats = GetFormat(); // lay hinh thuc
            AddFormat(formats);
        }

        private void AddFormat(string[] formats)
        {
            foreach (string format in formats)
            {
                this.hinhThucDangTuyenComboBox.Items.Add(format);
            }
        }

        private string[] GetFormat()
        {
            //BUS.BusHinhThuc
            
            return BUS.BusHinhThuc.GetAllName().ToArray();
        }

        private void InitializeDatabaseConnection()
        {
            _dbConnector = new SqlConnection(@"Data Source=localhost;Initial Catalog=CTY_ABC;Integrated Security=True");
              
        }

        private void dateTimePickerLayout_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)sender;

            Panel panel1 = flowLayoutPanel.Controls[0] as Panel;
            panel1.Controls.Add(_startDate);
            panel1 = flowLayoutPanel.Controls[2] as Panel;
            panel1.Controls.Add(_endDate);

        }

        private void DangKyDangTuyenGUI_Load(object sender, EventArgs e)
        {

        }
        //submit
        private void submitBtn_Click(object sender, EventArgs e)
        {
            GetAllFields();
            if (CheckValidForm())
            {
                _phieuQuangCaoGUI = new PhieuQuangCaoGUI(_dbConnector);
                _phieuQuangCaoGUI.AddClosingListener(SetActive);
                _fields["price"] = CalculatePrice().ToString();
                _phieuQuangCaoGUI.FillForm(_fields);
                this.Hide();
                _phieuQuangCaoGUI.Show();
            }
            else
            {
                _notifier.Popup();
            }

        }

        private float CalculatePrice()
        {
            return BUS.BusHinhThuc.GetPrice(hinhThucDangTuyenComboBox.Text) * (CalculateDateDiff() + 1);
            
        }

        private float CalculateDateDiff()
        {
            DateTime startDate = _startDate.Value.Date;
            DateTime endDate = _endDate.Value.Date;

            TimeSpan difference = endDate - startDate;

            return (float)difference.TotalDays;
        }

        private bool CheckValidForm()
        {
            foreach (var key in _fields.Keys)
            {
                if (_fields.TryGetValue(key, out string val))
                {
                    if (val.CompareTo("") == 0)
                    {
                       

                        return false;
                    }
                }
            }
            return true;
        }

        private void GetAllFields()
        {
            if (_fields.ContainsKey("viTriText"))
                _fields["viTriText"] = viTriText.Text.ToString();


            if (_fields.ContainsKey("moTaText"))
                _fields["moTaText"] = moTaText.Text.ToString();
           

            if (_fields.ContainsKey("soLuongText"))
                _fields["soLuongText"] = soLuongText.Text.ToString();
        

            if (_fields.ContainsKey("yeuCauText"))
                _fields["yeuCauText"] = yeuCauText.Text.ToString();
        

            if (_fields.ContainsKey("hinhThucDangTuyenComboBox"))
                _fields["hinhThucDangTuyenComboBox"] = hinhThucDangTuyenComboBox.Text.ToString();
           

            if (_fields.ContainsKey("_startDate"))
                _fields["_startDate"] = _startDate.Value.Date.ToString();
 

            if (_fields.ContainsKey("_endDate"))
                _fields["_endDate"] = _endDate.Value.Date.ToString();
         
            



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
