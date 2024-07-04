using System;

namespace ABCTuyenDung
{
    partial class DangKyDangTuyenGUI
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.hinhThucDangTuyenComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.startDatePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.endDatePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.yeuCauText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soLuongText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viTriLabels = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            this.moTaText = new System.Windows.Forms.TextBox();
            this.viTriText = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.dateTimePickerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.mainPanel.Controls.Add(this.hinhThucDangTuyenComboBox);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.submitBtn);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.dateTimePickerLayout);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.yeuCauText);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.soLuongText);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.viTriLabels);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.formLabel);
            this.mainPanel.Controls.Add(this.moTaText);
            this.mainPanel.Controls.Add(this.viTriText);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(18, 20, 0, 50);
            this.mainPanel.Size = new System.Drawing.Size(700, 450);
            this.mainPanel.TabIndex = 2;
            // 
            // hinhThucDangTuyenComboBox
            // 
            this.hinhThucDangTuyenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hinhThucDangTuyenComboBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.hinhThucDangTuyenComboBox.FormattingEnabled = true;
            this.hinhThucDangTuyenComboBox.Location = new System.Drawing.Point(74, 850);
            this.hinhThucDangTuyenComboBox.Name = "hinhThucDangTuyenComboBox";
            this.hinhThucDangTuyenComboBox.Size = new System.Drawing.Size(594, 24);
            this.hinhThucDangTuyenComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 831);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hình thức Đăng tuyển";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(312, 893);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(166, 43);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Hoàn tất";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thời gian tuyển dụng";
            // 
            // dateTimePickerLayout
            // 
            this.dateTimePickerLayout.Controls.Add(this.startDatePanel);
            this.dateTimePickerLayout.Controls.Add(this.panel3);
            this.dateTimePickerLayout.Controls.Add(this.endDatePanel);
            this.dateTimePickerLayout.Location = new System.Drawing.Point(68, 166);
            this.dateTimePickerLayout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dateTimePickerLayout.Name = "dateTimePickerLayout";
            this.dateTimePickerLayout.Size = new System.Drawing.Size(598, 56);
            this.dateTimePickerLayout.TabIndex = 12;
            this.dateTimePickerLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.dateTimePickerLayout_Paint);
            // 
            // startDatePanel
            // 
            this.startDatePanel.Location = new System.Drawing.Point(3, 3);
            this.startDatePanel.Name = "startDatePanel";
            this.startDatePanel.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.startDatePanel.Size = new System.Drawing.Size(236, 50);
            this.startDatePanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(245, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 53);
            this.panel3.TabIndex = 1;
            // 
            // endDatePanel
            // 
            this.endDatePanel.Location = new System.Drawing.Point(359, 3);
            this.endDatePanel.Name = "endDatePanel";
            this.endDatePanel.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.endDatePanel.Size = new System.Drawing.Size(236, 50);
            this.endDatePanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thông tin yêu cầu từ ứng viên";
            // 
            // yeuCauText
            // 
            this.yeuCauText.Location = new System.Drawing.Point(69, 575);
            this.yeuCauText.Multiline = true;
            this.yeuCauText.Name = "yeuCauText";
            this.yeuCauText.Size = new System.Drawing.Size(598, 235);
            this.yeuCauText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng tuyển dụng";
            // 
            // soLuongText
            // 
            this.soLuongText.Location = new System.Drawing.Point(69, 522);
            this.soLuongText.MaxLength = 3;
            this.soLuongText.Name = "soLuongText";
            this.soLuongText.Size = new System.Drawing.Size(598, 22);
            this.soLuongText.TabIndex = 7;
            this.soLuongText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.soLuongText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mô tả vị trí tuyển dụng";
            // 
            // viTriLabels
            // 
            this.viTriLabels.AutoSize = true;
            this.viTriLabels.Location = new System.Drawing.Point(66, 94);
            this.viTriLabels.Name = "viTriLabels";
            this.viTriLabels.Size = new System.Drawing.Size(102, 16);
            this.viTriLabels.TabIndex = 5;
            this.viTriLabels.Text = "Vị trí tuyển dụng";
            this.viTriLabels.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(556, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(28, 46);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(280, 36);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Đăng ký đăng tuyển";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moTaText
            // 
            this.moTaText.AcceptsTab = true;
            this.moTaText.Location = new System.Drawing.Point(69, 241);
            this.moTaText.Multiline = true;
            this.moTaText.Name = "moTaText";
            this.moTaText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.moTaText.Size = new System.Drawing.Size(598, 235);
            this.moTaText.TabIndex = 1;
            // 
            // viTriText
            // 
            this.viTriText.Location = new System.Drawing.Point(68, 113);
            this.viTriText.Name = "viTriText";
            this.viTriText.Size = new System.Drawing.Size(599, 22);
            this.viTriText.TabIndex = 0;
            // 
            // DangKyDangTuyenGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "DangKyDangTuyenGUI";
            this.Text = "DangKyDangTuyenGUI";
            this.Load += new System.EventHandler(this.DangKyDangTuyenGUI_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.dateTimePickerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel dateTimePickerLayout;
        private System.Windows.Forms.Panel startDatePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel endDatePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yeuCauText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soLuongText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label viTriLabels;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.TextBox moTaText;
        private System.Windows.Forms.TextBox viTriText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox hinhThucDangTuyenComboBox;
    }
}