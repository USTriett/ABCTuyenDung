using ABCTuyenDung.BUS;
using ABCTuyenDung.DTOs;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ABCTuyenDung
{
    public partial class DangKyUngTuyenGUI : Form
    {
        private List<Control> controlsHolder = new List<Control>();
        private List<Label> labels = new List<Label>();
        private List<String> imageUrls = new List<String>();
        
        private int maUV = 1;
        private int maPhieuDT = 1;
        
        public DangKyUngTuyenGUI(int mauv, int maPDT)
        {
            maUV = mauv;
            maPhieuDT = maPDT;
            
            InitializeComponent();
            LoadData();
            InitializeCustomComponent();

        }

        private void InitializeCustomComponent()
        {
   

            controlsHolder.Add(hoTenText);
            controlsHolder.Add(moTaText);
            controlsHolder.Add(gioiTinhBox);
            controlsHolder.Add(emailText);
            controlsHolder.Add(sdtText);
            controlsHolder.Add(diaChiText);
            int len = BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count;
            for (int i = 0; i < len; i++) {
                //button
                ThemHoSo(null, null);
                hoSoPanel.GetControlFromPosition(0, i + 1).Text = BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].TenHSBC;
                hoSoPanel.GetControlFromPosition(1, i + 1).Text = BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].LoaiHSBC;
                hoSoPanel.GetControlFromPosition(2, i + 1).Text = BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].NgayCap.ToString();
                hoSoPanel.GetControlFromPosition(4, i + 1).Text = BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].TenHSBC.ToString();
                hoSoPanel.GetControlFromPosition(3, i + 1).Text = BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].DonViCap;
                hoSoPanel.GetControlFromPosition(5, i + 1).Enabled = false;

                hoSoPanel.GetControlFromPosition(6, i + 1).Text = BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].Url;

            }


        }



        private void LoadData()
        {
            BUS.BusUngVien.LayThongTin(maUV);
            hoTenText.Text = BusUngVien.dTOUngVien.HoTen;
            gioiTinhBox.Text = BusUngVien.dTOUngVien.GioiTinh;
            emailText.Text = BusUngVien.dTOUngVien.Email;
            sdtText.Text = BusUngVien.dTOUngVien.Sdt;
            diaChiText.Text = BusUngVien.dTOUngVien.DiaChi;
            ngaySinhPicker.Text = BusUngVien.dTOUngVien.NgaySinh.ToString();

            BUS.BusHoSoBangCap.LayDanhSachHSBC(maUV);
            


        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DangKyUngTuyenGUI_Load(object sender, EventArgs e)
        {
                                                  
        }

        public void AddCloseEventListener(FormClosedEventHandler action)
        {
            FormClosed += action;
        }

        private void ThemHoSo(object sender, EventArgs e)
        {

  
            hoSoPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
            hoSoPanel.RowCount +=1;
            
            int rowIndex = hoSoPanel.RowCount - 1;

            TextBox[] boxes = new TextBox[4];
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new TextBox();
                boxes[i].Multiline = true;
                boxes[i].Size = new Size(125, 35);
                boxes[i].Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);

            }

            DateTimePicker datePicker = new DateTimePicker();
            datePicker.Size = new Size(125, 35);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.MinimumSize = new Size(4, 35);
            datePicker.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            string ImagesDirectory =
                Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "Resources"
               );
            Guna2ImageButton guna2ImageButton = new Guna2ImageButton();
            guna2ImageButton.Size = new Size(35, 35);
            guna2ImageButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            guna2ImageButton.Image = ABCTuyenDung.Properties.Resources.Upload;
            guna2ImageButton.ImageSize = new Size(20,20);
            //guna2ImageButton.MouseHover
            guna2ImageButton.HoverState.ImageSize = new Size(20, 20);
            guna2ImageButton.Click += BrowseImage;
            guna2ImageButton.Text = rowIndex.ToString();

            hoSoPanel.Controls.Add(boxes[0], 0, rowIndex);
            hoSoPanel.Controls.Add(boxes[1], 1, rowIndex);
            hoSoPanel.Controls.Add(datePicker, 2, rowIndex);
            hoSoPanel.Controls.Add(boxes[2], 3, rowIndex);
            hoSoPanel.Controls.Add(boxes[3], 4, rowIndex);
            hoSoPanel.Controls.Add(guna2ImageButton, 5, rowIndex);
            Label label = new Label();
            label.AutoEllipsis = true;
            labels.Add(label);
            hoSoPanel.Controls.Add(label, 6, rowIndex);

            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            hoSoPanel.Controls.Add(checkBox, 7, rowIndex);

        }

        private void BrowseImage(object sender, EventArgs e)
        {
            try
            {
                // Create and configure an OpenFileDialog instance
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    // Combine the base directory path with the "image" subdirectory
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, maUV.ToString());

                    // Check if the directory exists; if not, create it
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    // Get the file name of the selected file
                    var fileName = Path.GetFileName(dialog.FileName);

                    // Combine the directory path with the file name
                    string destinationPath = Path.Combine(path, fileName);
                    // Copy the selected file to the new destination

                    File.Copy(dialog.FileName, destinationPath, true);
                    Console.WriteLine(((Guna2ImageButton)sender).Text.ToString());
                    int index = int.Parse(((Guna2ImageButton)sender).Text.ToString());
                    if (index - 1 >= imageUrls.Count)
                    {
                        imageUrls.Add(maUV.ToString() + "/" + dialog.FileName);
                    }
                    else
                    {
                        imageUrls[index-1] = destinationPath;
                    }

                    labels[index - 1].Text = fileName;

                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void HoanTat_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                DTOs.DTOPhieuDangKyUngTuyen dTOPhieuDangKyUngTuyen = new DTOs.DTOPhieuDangKyUngTuyen
                {
                    MaUV = maUV,
                    MaPhieuDT = maPhieuDT,
                    MoTa = moTaText.Text,
                    TinhTrang = false,
                    MaNV = 0,

                };
                this.Enabled = false;
                DTOHoSoBangCap[] hs = new DTOHoSoBangCap[imageUrls.Count];
                for (int i = 0; i < hs.Length; i++)
                {
                    bool ngayCapIsValid = DateTime.TryParse(hoSoPanel.GetControlFromPosition(2, i + 1 + BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count).Text, out DateTime ngayCap);
                    bool hieuLucIsValid = DateTime.TryParse(hoSoPanel.GetControlFromPosition(4, i + 1 + BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count).Text, out DateTime hieuLuc);
                    hs[i] = new DTOHoSoBangCap
                    {
                        MaHSBC = BUS.BusHoSoBangCap.getMaxID() + 1,
                        TenHSBC = hoSoPanel.GetControlFromPosition(0, i+1 + BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count).Text,
                        LoaiHSBC = hoSoPanel.GetControlFromPosition(1, i+1 + BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count).Text,
                        NgayCap = ngayCapIsValid?ngayCap:DateTime.Now,
                        HieuLuc = hieuLucIsValid?hieuLuc: DateTime.Now,
                        DonViCap = hoSoPanel.GetControlFromPosition(3, i+1 + BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count).Text,
                        MaUV = maUV,
                        Url = imageUrls[i]
                    };
                }
                List<int> maHSBCs = new List<int>();
                int len = BUS.BusHoSoBangCap.dTOHoSoBangCaps.Count;
                for (int i = 0; i < len; i++)
                {
                    CheckBox b = (CheckBox)hoSoPanel.GetControlFromPosition(7, i + 1);
                    if (b.Checked)
                    {
                        maHSBCs.Add(BUS.BusHoSoBangCap.dTOHoSoBangCaps[i].MaHSBC);
                    }
                }
                for (int i = 0; i < hs.Length; i++)
                {
                    CheckBox b = (CheckBox)hoSoPanel.GetControlFromPosition(7, i + 1 + len);
                    if (b.Checked)
                    {
                        Console.WriteLine(i);
                        maHSBCs.Add(hs[i].MaHSBC);
                    }
                }
                BUS.BusPhieuDangKyUngTuyen.ThemPhieu(dTOPhieuDangKyUngTuyen);
                int id = BUS.BusPhieuDangKyUngTuyen.LayMa(dTOPhieuDangKyUngTuyen.MaUV, dTOPhieuDangKyUngTuyen.MaPhieuDT);
                BUS.BusHoSoBangCap.ThemNhieuHoSo(maUV, hs);

                BUS.BusDkutHsbc.ThemHSBC(maHSBCs, id);
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show("Unvalid");
            }

            this.Close();
            
        }

        private bool IsValid()
        {
            bool isValid = true;
            if (moTaText.Text == string.Empty)
            {

                isValid = false; 
            }
            return isValid;
        }

        private void diaChiText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
