namespace ABCTuyenDung
{
    partial class TrangChuUngVienGui
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.recruitLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.panel3.Controls.Add(this.logoutLabel);
            this.panel3.Controls.Add(this.recruitLabel);
            this.panel3.Controls.Add(this.homeLabel);
            this.panel3.Controls.Add(this.homeLink);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 774);
            this.panel3.TabIndex = 7;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.logoutLabel.ForeColor = System.Drawing.Color.White;
            this.logoutLabel.Location = new System.Drawing.Point(1, 309);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.logoutLabel.Size = new System.Drawing.Size(264, 58);
            this.logoutLabel.TabIndex = 8;
            this.logoutLabel.Text = "↪️ Đăng Xuất";
            // 
            // recruitLabel
            // 
            this.recruitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recruitLabel.AutoSize = true;
            this.recruitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recruitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.recruitLabel.ForeColor = System.Drawing.Color.White;
            this.recruitLabel.Location = new System.Drawing.Point(3, 241);
            this.recruitLabel.Name = "recruitLabel";
            this.recruitLabel.Padding = new System.Windows.Forms.Padding(35, 10, 13, 10);
            this.recruitLabel.Size = new System.Drawing.Size(263, 58);
            this.recruitLabel.TabIndex = 8;
            this.recruitLabel.Text = "📂 Tuyển Dụng";
            this.recruitLabel.Click += new System.EventHandler(this.recruitLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.White;
            this.homeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeLabel.Location = new System.Drawing.Point(4, 172);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Padding = new System.Windows.Forms.Padding(34, 10, 34, 10);
            this.homeLabel.Size = new System.Drawing.Size(260, 58);
            this.homeLabel.TabIndex = 8;
            this.homeLabel.Text = "🏠 Trang Chủ";
            // 
            // homeLink
            // 
            this.homeLink.AutoSize = true;
            this.homeLink.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.homeLink.LinkColor = System.Drawing.Color.White;
            this.homeLink.Location = new System.Drawing.Point(80, 49);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(116, 45);
            this.homeLink.TabIndex = 3;
            this.homeLink.TabStop = true;
            this.homeLink.Text = "Home";
            // 
            // TrangChuUngVienGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 774);
            this.Controls.Add(this.panel3);
            this.Name = "TrangChuUngVienGui";
            this.Text = "Trang chủ - Ứng viên";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label recruitLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.LinkLabel homeLink;
    }
}