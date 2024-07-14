using System.IO;
using System.Reflection;

namespace ABCTuyenDung
{
    partial class GUIDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dangNhapLabel = new System.Windows.Forms.Label();
            this.emailDangNhapLabel = new System.Windows.Forms.Label();
            this.tenDangNhapTextBox = new System.Windows.Forms.TextBox();
            this.matKhauLabel = new System.Windows.Forms.Label();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.chuaCoTaiKhoanLabel = new System.Windows.Forms.Label();
            this.dangKyThanhVienUngVienLinkButton = new System.Windows.Forms.LinkLabel();
            this.dangKyThanhVienDoanhNghiepLinkButton = new System.Windows.Forms.LinkLabel();
            this.dangNhapButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.ImageLocation = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\PrivateAssemb" +
    "lies\\image\\dang-nhap.png";
            this.pictureBox.Location = new System.Drawing.Point(392, 1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox.Size = new System.Drawing.Size(409, 453);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // dangNhapLabel
            // 
            this.dangNhapLabel.AutoSize = true;
            this.dangNhapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangNhapLabel.Location = new System.Drawing.Point(135, 73);
            this.dangNhapLabel.Name = "dangNhapLabel";
            this.dangNhapLabel.Size = new System.Drawing.Size(118, 20);
            this.dangNhapLabel.TabIndex = 1;
            this.dangNhapLabel.Text = "ĐĂNG NHẬP";
            // 
            // emailDangNhapLabel
            // 
            this.emailDangNhapLabel.AutoSize = true;
            this.emailDangNhapLabel.Location = new System.Drawing.Point(65, 142);
            this.emailDangNhapLabel.Name = "emailDangNhapLabel";
            this.emailDangNhapLabel.Size = new System.Drawing.Size(98, 16);
            this.emailDangNhapLabel.TabIndex = 2;
            this.emailDangNhapLabel.Text = "Tên đăng nhập";
            // 
            // tenDangNhapTextBox
            // 
            this.tenDangNhapTextBox.Location = new System.Drawing.Point(65, 161);
            this.tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            this.tenDangNhapTextBox.Size = new System.Drawing.Size(270, 22);
            this.tenDangNhapTextBox.TabIndex = 3;
            // 
            // matKhauLabel
            // 
            this.matKhauLabel.AutoSize = true;
            this.matKhauLabel.Location = new System.Drawing.Point(65, 203);
            this.matKhauLabel.Name = "matKhauLabel";
            this.matKhauLabel.Size = new System.Drawing.Size(61, 16);
            this.matKhauLabel.TabIndex = 4;
            this.matKhauLabel.Text = "Mật khẩu";
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.Location = new System.Drawing.Point(65, 222);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.PasswordChar = '●';
            this.matKhauTextBox.Size = new System.Drawing.Size(270, 22);
            this.matKhauTextBox.TabIndex = 5;
            // 
            // chuaCoTaiKhoanLabel
            // 
            this.chuaCoTaiKhoanLabel.AutoSize = true;
            this.chuaCoTaiKhoanLabel.Location = new System.Drawing.Point(65, 267);
            this.chuaCoTaiKhoanLabel.Name = "chuaCoTaiKhoanLabel";
            this.chuaCoTaiKhoanLabel.Size = new System.Drawing.Size(145, 16);
            this.chuaCoTaiKhoanLabel.TabIndex = 6;
            this.chuaCoTaiKhoanLabel.Text = "Bạn chưa có tài khoản?";
            // 
            // dangKyThanhVienUngVienLinkButton
            // 
            this.dangKyThanhVienUngVienLinkButton.AutoSize = true;
            this.dangKyThanhVienUngVienLinkButton.Location = new System.Drawing.Point(81, 292);
            this.dangKyThanhVienUngVienLinkButton.Name = "dangKyThanhVienUngVienLinkButton";
            this.dangKyThanhVienUngVienLinkButton.Size = new System.Drawing.Size(172, 16);
            this.dangKyThanhVienUngVienLinkButton.TabIndex = 7;
            this.dangKyThanhVienUngVienLinkButton.TabStop = true;
            this.dangKyThanhVienUngVienLinkButton.Text = "Đăng ký thành viên ứng viên";
            this.dangKyThanhVienUngVienLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dangKyThanhVienUngVienLinkButton_LinkClicked);
            // 
            // dangKyThanhVienDoanhNghiepLinkButton
            // 
            this.dangKyThanhVienDoanhNghiepLinkButton.AutoSize = true;
            this.dangKyThanhVienDoanhNghiepLinkButton.Location = new System.Drawing.Point(81, 317);
            this.dangKyThanhVienDoanhNghiepLinkButton.Name = "dangKyThanhVienDoanhNghiepLinkButton";
            this.dangKyThanhVienDoanhNghiepLinkButton.Size = new System.Drawing.Size(204, 16);
            this.dangKyThanhVienDoanhNghiepLinkButton.TabIndex = 8;
            this.dangKyThanhVienDoanhNghiepLinkButton.TabStop = true;
            this.dangKyThanhVienDoanhNghiepLinkButton.Text = "Đăng ký thành viên doanh nghiệp";
            this.dangKyThanhVienDoanhNghiepLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dangKyThanhVienDoanhNghiepLinkButton_LinkClicked);
            // 
            // dangNhapButton
            // 
            this.dangNhapButton.Location = new System.Drawing.Point(153, 369);
            this.dangNhapButton.Name = "dangNhapButton";
            this.dangNhapButton.Size = new System.Drawing.Size(100, 27);
            this.dangNhapButton.TabIndex = 9;
            this.dangNhapButton.Text = "Đăng nhập";
            this.dangNhapButton.UseVisualStyleBackColor = true;
            this.dangNhapButton.Click += new System.EventHandler(this.dangNhapButton_Click);
            // 
            // GUIDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dangNhapButton);
            this.Controls.Add(this.dangKyThanhVienDoanhNghiepLinkButton);
            this.Controls.Add(this.dangKyThanhVienUngVienLinkButton);
            this.Controls.Add(this.chuaCoTaiKhoanLabel);
            this.Controls.Add(this.matKhauTextBox);
            this.Controls.Add(this.matKhauLabel);
            this.Controls.Add(this.tenDangNhapTextBox);
            this.Controls.Add(this.emailDangNhapLabel);
            this.Controls.Add(this.dangNhapLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "GUIDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý hồ sơ ứng tuyển Công ty ABC - Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label dangNhapLabel;
        private System.Windows.Forms.Label emailDangNhapLabel;
        private System.Windows.Forms.TextBox tenDangNhapTextBox;
        private System.Windows.Forms.Label matKhauLabel;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.Label chuaCoTaiKhoanLabel;
        private System.Windows.Forms.LinkLabel dangKyThanhVienUngVienLinkButton;
        private System.Windows.Forms.LinkLabel dangKyThanhVienDoanhNghiepLinkButton;
        private System.Windows.Forms.Button dangNhapButton;
    }
}