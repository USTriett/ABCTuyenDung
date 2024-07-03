using System;
using System.Windows.Forms;

namespace dangkythanhvienungvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string matKhau = txtMatKhau.Text;

            // Validate input...

            // Create new candidate
            DTOs.DTOUngVien ungVien = new DTOs.DTOUngVien
            {
                HoTen = hoTen,
                DiaChi = diaChi,
                NgaySinh = ngaySinh,
                Email = email,
                SoDienThoai = soDienThoai,
                MatKhau = matKhau
            };

            // Save to database
            BUS.BusUngVien busUngVien = new BUS.BusUngVien();
            busUngVien.DangKyUngVien(ungVien);

            MessageBox.Show("Đăng ký thành công!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}