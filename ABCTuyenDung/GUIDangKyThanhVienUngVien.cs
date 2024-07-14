using ABCTuyenDung.BUS;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ABCTuyenDung
{
    public partial class GUIDangKyThanhVienUngVien : Form
    {
        public GUIDangKyThanhVienUngVien()
        {
            InitializeComponent();
            string ImagesDirectory =
                Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "image\\dang-ky-dn.png"
                );
            this.pictureBox.ImageLocation = ImagesDirectory;
        }

        private void dangKyButton_Click(object sender, EventArgs e)
        {
            string tenUV = hoTenTextBox.Text;
            string diaChi = diaChiTextBox.Text;
            string email = emailTextBox.Text;
            DateTime ngaySinh = dateTimePicker.Value;

            string sdt = sdtTextBox.Text;
            string matKhau = matKhauTextBox.Text;

            if (string.IsNullOrEmpty(tenUV) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the password
            string hashedMatKhau = BCrypt.Net.BCrypt.HashPassword(matKhau, 12);

            DTOUngVien ungVien = new DTOUngVien
            {
                HoTen = tenUV,
                DiaChi = diaChi,
                Email = email,
                NgaySinh = ngaySinh,
                Sdt = sdt,
                MatKhau = hashedMatKhau,
                Kqkd = false
            };

            bool isExisted = BusUngVien.KiemTraUngVienTonTai(ungVien);
            if (isExisted)
            {
                MessageBox.Show("Ứng viên đã tồn tại.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isRegistered = BusUngVien.DangKyUngVien(ungVien);

            if (isRegistered)
            {
                MessageBox.Show("Đăng ký thành công", "Thông bảo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Redirect to the login form
                this.Hide();
                GUIDangNhap dangNhapGUI = new GUIDangNhap();
                dangNhapGUI.FormClosed += (s, args) => this.Close();
                dangNhapGUI.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dangNhapLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GUIDangNhap dangNhapGUI = new GUIDangNhap();
            dangNhapGUI.FormClosed += (s, args) => this.Close();
            dangNhapGUI.Show();
        }
    }
}
