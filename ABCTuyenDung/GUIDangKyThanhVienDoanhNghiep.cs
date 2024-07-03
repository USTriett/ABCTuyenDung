using ABCTuyenDung.BUS;
using ABCTuyenDung.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung
{
    public partial class GUIDangKyThanhVienDoanhNghiep : Form
    {
        string conn = @"Data Source = localhost; Initial Catalog=CTY_ABC; Integrated Security=True";

        public GUIDangKyThanhVienDoanhNghiep()
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
            string tenDN = tenDoanhNghiepTextBox.Text;
            string email = emailTextBox.Text;
            string diaChi = diaChiTextBox.Text;
            string maSoThue = maSoThueTextBox.Text;
            string nguoiDaiDien = nguoiDaiDienTextBox.Text;
            string sdtDN = sdtTextBox.Text;
            string matKhau = matKhauTextBox.Text;

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the password
            string hashedMatKhau = BCrypt.Net.BCrypt.HashPassword(matKhau, 12);

            DTODoanhNghiep doanhNghiep = new DTODoanhNghiep
            {
                TenDN = tenDN,
                Email = email,
                DiaChi = diaChi,
                MaSoThue = maSoThue,
                NguoiDaiDien = nguoiDaiDien,
                NgayHetHan = DateTime.Now, // Mac dinh ngay het han luc dau la luc dang ky
                TiemNang = false, 
                Kqkd = false, 
                SdtDN = sdtDN,
                MatKhau = hashedMatKhau
            };

            bool isExisted = BusDoanhNghiep.KiemTraDoanhNghiepTonTai(doanhNghiep);
            if (isExisted)
            {
                MessageBox.Show("Doanh nghiệp đã tồn tại.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isRegistered = BusDoanhNghiep.DangKyDoanhNghiep(doanhNghiep);

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
