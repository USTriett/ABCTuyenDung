using System.IO;
using System.Reflection;

namespace ABCTuyenDung
{
    partial class GUIDangKyThanhVienDoanhNghiep
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
            this.dangKyThanhVienDoanhNghiepLabel = new System.Windows.Forms.Label();
            this.tenDoanhNghiepLabel = new System.Windows.Forms.Label();
            this.tenDoanhNghiepTextBox = new System.Windows.Forms.TextBox();
            this.maSoThueTextBox = new System.Windows.Forms.TextBox();
            this.nguoiDaiDienTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.maSoThueLabel = new System.Windows.Forms.Label();
            this.nguoiDaiDienLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.sdtLabel = new System.Windows.Forms.Label();
            this.matKhauLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dangNhapLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dangKyButton = new System.Windows.Forms.Button();
            this.chuYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.ImageLocation = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\PrivateAssemb" +
    "lies\\image\\dang-ky-dn.png";
            this.pictureBox.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(20);
            this.pictureBox.Size = new System.Drawing.Size(422, 548);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // dangKyThanhVienDoanhNghiepLabel
            // 
            this.dangKyThanhVienDoanhNghiepLabel.AutoSize = true;
            this.dangKyThanhVienDoanhNghiepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangKyThanhVienDoanhNghiepLabel.Location = new System.Drawing.Point(474, 15);
            this.dangKyThanhVienDoanhNghiepLabel.Name = "dangKyThanhVienDoanhNghiepLabel";
            this.dangKyThanhVienDoanhNghiepLabel.Size = new System.Drawing.Size(357, 20);
            this.dangKyThanhVienDoanhNghiepLabel.TabIndex = 1;
            this.dangKyThanhVienDoanhNghiepLabel.Text = "ĐĂNG KÝ THÀNH VIÊN DOANH NGHIỆP";
            // 
            // tenDoanhNghiepLabel
            // 
            this.tenDoanhNghiepLabel.AutoSize = true;
            this.tenDoanhNghiepLabel.Location = new System.Drawing.Point(475, 72);
            this.tenDoanhNghiepLabel.Name = "tenDoanhNghiepLabel";
            this.tenDoanhNghiepLabel.Size = new System.Drawing.Size(132, 16);
            this.tenDoanhNghiepLabel.TabIndex = 2;
            this.tenDoanhNghiepLabel.Text = "Tên doanh nghiệp (*)";
            // 
            // tenDoanhNghiepTextBox
            // 
            this.tenDoanhNghiepTextBox.Location = new System.Drawing.Point(478, 91);
            this.tenDoanhNghiepTextBox.Name = "tenDoanhNghiepTextBox";
            this.tenDoanhNghiepTextBox.Size = new System.Drawing.Size(340, 22);
            this.tenDoanhNghiepTextBox.TabIndex = 3;
            // 
            // maSoThueTextBox
            // 
            this.maSoThueTextBox.Location = new System.Drawing.Point(478, 145);
            this.maSoThueTextBox.Name = "maSoThueTextBox";
            this.maSoThueTextBox.Size = new System.Drawing.Size(340, 22);
            this.maSoThueTextBox.TabIndex = 4;
            // 
            // nguoiDaiDienTextBox
            // 
            this.nguoiDaiDienTextBox.Location = new System.Drawing.Point(478, 203);
            this.nguoiDaiDienTextBox.Name = "nguoiDaiDienTextBox";
            this.nguoiDaiDienTextBox.Size = new System.Drawing.Size(340, 22);
            this.nguoiDaiDienTextBox.TabIndex = 5;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(478, 261);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(340, 22);
            this.diaChiTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(478, 382);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(340, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.Location = new System.Drawing.Point(478, 321);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(340, 22);
            this.sdtTextBox.TabIndex = 8;
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.Location = new System.Drawing.Point(478, 441);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.Size = new System.Drawing.Size(340, 22);
            this.matKhauTextBox.TabIndex = 9;
            // 
            // maSoThueLabel
            // 
            this.maSoThueLabel.AutoSize = true;
            this.maSoThueLabel.Location = new System.Drawing.Point(475, 126);
            this.maSoThueLabel.Name = "maSoThueLabel";
            this.maSoThueLabel.Size = new System.Drawing.Size(72, 16);
            this.maSoThueLabel.TabIndex = 10;
            this.maSoThueLabel.Text = "Mã số thuế";
            // 
            // nguoiDaiDienLabel
            // 
            this.nguoiDaiDienLabel.AutoSize = true;
            this.nguoiDaiDienLabel.Location = new System.Drawing.Point(475, 184);
            this.nguoiDaiDienLabel.Name = "nguoiDaiDienLabel";
            this.nguoiDaiDienLabel.Size = new System.Drawing.Size(94, 16);
            this.nguoiDaiDienLabel.TabIndex = 11;
            this.nguoiDaiDienLabel.Text = "Người đại diện";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Location = new System.Drawing.Point(475, 242);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(47, 16);
            this.diaChiLabel.TabIndex = 12;
            this.diaChiLabel.Text = "Địa chỉ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(475, 363);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(184, 16);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email (dùng để đăng nhập) (*)";
            // 
            // sdtLabel
            // 
            this.sdtLabel.AutoSize = true;
            this.sdtLabel.Location = new System.Drawing.Point(475, 302);
            this.sdtLabel.Name = "sdtLabel";
            this.sdtLabel.Size = new System.Drawing.Size(85, 16);
            this.sdtLabel.TabIndex = 14;
            this.sdtLabel.Text = "Số điện thoại";
            // 
            // matKhauLabel
            // 
            this.matKhauLabel.AutoSize = true;
            this.matKhauLabel.Location = new System.Drawing.Point(475, 422);
            this.matKhauLabel.Name = "matKhauLabel";
            this.matKhauLabel.Size = new System.Drawing.Size(77, 16);
            this.matKhauLabel.TabIndex = 15;
            this.matKhauLabel.Text = "Mật khẩu (*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Đã có tài khoản?";
            // 
            // dangNhapLinkLabel
            // 
            this.dangNhapLinkLabel.AutoSize = true;
            this.dangNhapLinkLabel.Location = new System.Drawing.Point(587, 482);
            this.dangNhapLinkLabel.Name = "dangNhapLinkLabel";
            this.dangNhapLinkLabel.Size = new System.Drawing.Size(72, 16);
            this.dangNhapLinkLabel.TabIndex = 17;
            this.dangNhapLinkLabel.TabStop = true;
            this.dangNhapLinkLabel.Text = "Đăng nhập";
            this.dangNhapLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dangNhapLinkLabel_LinkClicked);
            // 
            // dangKyButton
            // 
            this.dangKyButton.Location = new System.Drawing.Point(630, 508);
            this.dangKyButton.Name = "dangKyButton";
            this.dangKyButton.Size = new System.Drawing.Size(75, 35);
            this.dangKyButton.TabIndex = 18;
            this.dangKyButton.Text = "Đăng ký";
            this.dangKyButton.UseVisualStyleBackColor = true;
            this.dangKyButton.Click += new System.EventHandler(this.dangKyButton_Click);
            // 
            // chuYLabel
            // 
            this.chuYLabel.AutoSize = true;
            this.chuYLabel.Location = new System.Drawing.Point(713, 46);
            this.chuYLabel.Name = "chuYLabel";
            this.chuYLabel.Size = new System.Drawing.Size(118, 16);
            this.chuYLabel.TabIndex = 19;
            this.chuYLabel.Text = "(*): trường bắt buộc";
            // 
            // GUIDangKyThanhVienDoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 548);
            this.Controls.Add(this.chuYLabel);
            this.Controls.Add(this.dangKyButton);
            this.Controls.Add(this.dangNhapLinkLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.matKhauLabel);
            this.Controls.Add(this.sdtLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.diaChiLabel);
            this.Controls.Add(this.nguoiDaiDienLabel);
            this.Controls.Add(this.maSoThueLabel);
            this.Controls.Add(this.matKhauTextBox);
            this.Controls.Add(this.sdtTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(this.nguoiDaiDienTextBox);
            this.Controls.Add(this.maSoThueTextBox);
            this.Controls.Add(this.tenDoanhNghiepTextBox);
            this.Controls.Add(this.tenDoanhNghiepLabel);
            this.Controls.Add(this.dangKyThanhVienDoanhNghiepLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "GUIDangKyThanhVienDoanhNghiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý hồ sơ ứng tuyển Công ty ABC - Đăng ký thành viên cho doanh nghiệ" +
    "p";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label dangKyThanhVienDoanhNghiepLabel;
        private System.Windows.Forms.Label tenDoanhNghiepLabel;
        private System.Windows.Forms.TextBox tenDoanhNghiepTextBox;
        private System.Windows.Forms.TextBox maSoThueTextBox;
        private System.Windows.Forms.TextBox nguoiDaiDienTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.Label maSoThueLabel;
        private System.Windows.Forms.Label nguoiDaiDienLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label sdtLabel;
        private System.Windows.Forms.Label matKhauLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel dangNhapLinkLabel;
        private System.Windows.Forms.Button dangKyButton;
        private System.Windows.Forms.Label chuYLabel;
    }
}