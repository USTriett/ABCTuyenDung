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

namespace ABCTuyenDung
{
    public partial class TuyenDungGUI : Form
    {
        private int _id = 1;
        private int _maPhieuDangTuyen;

        private DangKyUngTuyenGUI dangKyUngTuyenGUI;
        public TuyenDungGUI(int idDoanhNghiep, int maPhieuDangTuyen)
        {
            _id = idDoanhNghiep;
            _maPhieuDangTuyen = maPhieuDangTuyen;
            InitializeComponent();
            LoadDoanhNghiepData();
            LoadThongTinCongViec();
            FillData();
        }

        private void LoadThongTinCongViec()
        {
            BUS.BusPhieuDangTuyen.LayPhieuDangTuyen(_maPhieuDangTuyen);
        }

        private void FillData()
        {
            doanhNghiepText.Text = BUS.BusDoanhNghiep.GetTenDN(_id);
            maSoThueText.Text = BUS.BusDoanhNghiep.GetMaSoThue(_id);
            nguoiDaiDienText.Text = BUS.BusDoanhNghiep.GetNguoiDaiDien(_id);
            diaChiText.Text = BUS.BusDoanhNghiep.GetDiaChi(_id);
            emailText.Text = BUS.BusDoanhNghiep.GetEmail(_id);
            sdtText.Text = BUS.BusDoanhNghiep.GetSdtDN(_id);
            Console.WriteLine(BUS.BusPhieuDangTuyen.dTOPhieuDangTuyen.MoTaViTriTD.
                    ToString().
                    Split(
                        new[] { '\n', '.', '\t' },
                        StringSplitOptions.RemoveEmptyEntries


                    ).Select(s => s.Trim()));
            moTaText.Text = String.Join(
                "\n",
                BUS.BusPhieuDangTuyen.dTOPhieuDangTuyen.MoTaViTriTD.
                    ToString().
                    Split(
                        new[] { '\n', '.', '\t' },
                        StringSplitOptions.RemoveEmptyEntries


                    ).Select(s=> s.Trim())

            );
            viTriText.Text = BUS.BusPhieuDangTuyen.dTOPhieuDangTuyen.ViTriTD.ToString();
            yeuCauText.Text = String.Join(
                            "\n",
                            BUS.BusPhieuDangTuyen.dTOPhieuDangTuyen.TieuChi.
                                ToString().
                                Split(
                                    new[] { '\n', '.', '\t' },
                                    StringSplitOptions.RemoveEmptyEntries
                                ).Select(s => s.Trim())

                        );
            soLuongText.Text = BUS.BusPhieuDangTuyen.dTOPhieuDangTuyen.SoLuong.ToString();
        }

        private void LoadDoanhNghiepData()
        {
            BUS.BusDoanhNghiep.GetDoanhNghiep(_id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void diaChiText_Click(object sender, EventArgs e)
        {

        }

        private void TuyenDungGUI_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            
            dangKyUngTuyenGUI = new DangKyUngTuyenGUI(1, _maPhieuDangTuyen);
            dangKyUngTuyenGUI.AddCloseEventListener(Enable);
            dangKyUngTuyenGUI.Show();
        }

        private void Enable(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;

        }
    }
}
