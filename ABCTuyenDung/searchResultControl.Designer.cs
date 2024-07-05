namespace ABCTuyenDung
{
    partial class searchResultControl
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
            this.title = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(30, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(70, 28);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.BackColor = System.Drawing.SystemColors.Control;
            this.company.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.Color.Gray;
            this.company.Location = new System.Drawing.Point(31, 33);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(58, 23);
            this.company.TabIndex = 1;
            this.company.Text = "label2";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.Color.DarkGray;
            this.number.Location = new System.Drawing.Point(32, 62);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(43, 17);
            this.number.TabIndex = 2;
            this.number.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(35, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 2);
            this.panel1.TabIndex = 3;
            // 
            // searchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.company);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "searchResultControl";
            this.Size = new System.Drawing.Size(948, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Panel panel1;
    }
}
