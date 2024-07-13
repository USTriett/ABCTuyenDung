namespace ABCTuyenDung
{
    partial class TrangChuDoanhNghiepUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dkdtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dkdtButton
            // 
            this.dkdtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dkdtButton.Location = new System.Drawing.Point(4, 4);
            this.dkdtButton.Name = "dkdtButton";
            this.dkdtButton.Size = new System.Drawing.Size(217, 47);
            this.dkdtButton.TabIndex = 0;
            this.dkdtButton.Text = "Đăng ký đăng tuyển";
            this.dkdtButton.UseVisualStyleBackColor = true;
            this.dkdtButton.Click += new System.EventHandler(this.dkdtButton_Click);
            // 
            // TrangChuDoanhNghiepUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dkdtButton);
            this.Name = "TrangChuDoanhNghiepUserControl";
            this.Size = new System.Drawing.Size(305, 105);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dkdtButton;
    }
}
