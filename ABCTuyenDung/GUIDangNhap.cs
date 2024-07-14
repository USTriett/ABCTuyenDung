using Org.BouncyCastle.Crypto.Generators;
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
using BCrypt.Net;
using ABCTuyenDung.DAOs;
using ABCTuyenDung.BUS;
using System.IO;
using System.Reflection;

namespace ABCTuyenDung
{
    public partial class GUIDangNhap : Form
    {  
        public GUIDangNhap()
        {
            InitializeComponent();
            string ImagesDirectory =
                Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "image\\dang-nhap.png"
                );
            this.pictureBox.ImageLocation = ImagesDirectory;
        }

        private void dangNhapButton_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tenDangNhapTextBox.Text;
            string matKhau = matKhauTextBox.Text;

            if (BusUngVien.KiemTraThongTinDangNhap(tenDangNhap, matKhau))
            {
                int maUV = BusUngVien.LayMaUngVien(tenDangNhap);
                MessageBox.Show("Đăng nhập thành công với tư cách Ứng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Show new form
                this.Hide();
                TrangChuUngVienGui form1 = new TrangChuUngVienGui(maUV);
                form1.FormClosed += (s, args) => this.Close();
                form1.Show();

                return;
            }

            if (BusDoanhNghiep.KiemTraThongTinDangNhap(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công với tư cách Doanh Nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Show new form
                this.Hide();
                TrangChuDoanhNghiepGui form1 = new TrangChuDoanhNghiepGui();
                form1.FormClosed += (s, args) => this.Close();
                form1.Show();

                return;
            }

            if (BusNhanVien.KiemTraThongTinDangNhap(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công với tư cách Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Show new form
                this.Hide();
                Form1 form1 = new Form1();
                form1.FormClosed += (s, args) => this.Close();
                form1.Show();

                return;
            }

            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dangKyThanhVienDoanhNghiepLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GUIDangKyThanhVienDoanhNghiep dangKyThanhVienDoanhNghiepGUI = new GUIDangKyThanhVienDoanhNghiep();
            dangKyThanhVienDoanhNghiepGUI.FormClosed += (s, args) => this.Close();
            dangKyThanhVienDoanhNghiepGUI.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            string conn = @"Data Source=localhost; Initial Catalog=CTY_ABC; Integrated Security=True";
            DAOUngVien.Initialize(conn);
            DAODoanhNghiep.Initialize(conn);
            DAONhanVien.Initialize(conn);
        }

        private void dangKyThanhVienUngVienLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GUIDangKyThanhVienUngVien dangKyThanhVienUngVienGUI = new GUIDangKyThanhVienUngVien();
            dangKyThanhVienUngVienGUI.FormClosed += (s, args) => this.Close();
            dangKyThanhVienUngVienGUI.Show();
        }
    }
}
