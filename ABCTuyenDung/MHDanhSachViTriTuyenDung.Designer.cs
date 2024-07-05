namespace ABCTuyenDung
{
    partial class MHDanhSachViTriTuyenDung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MHDanhSachViTriTuyenDung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.PictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.danhSachTD = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.resultContainer = new System.Windows.Forms.Panel();
            this.cTY_ABCDataSet = new ABCTuyenDung.CTY_ABCDataSet();
            this.dSDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDNTableAdapter = new ABCTuyenDung.CTY_ABCDataSetTableAdapters.DSDNTableAdapter();
            this.TENDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOIDAIDIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEUDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VITRITD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHETHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTD)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTY_ABCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Location = new System.Drawing.Point(362, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 53);
            this.panel1.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.Teal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBox.Image = ((System.Drawing.Image)(resources.GetObject("searchBox.Image")));
            this.searchBox.Location = new System.Drawing.Point(910, 0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(60, 53);
            this.searchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchBox.TabIndex = 2;
            this.searchBox.TabStop = false;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(27, 12);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(884, 27);
            this.textSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.danhSachTD);
            this.panel2.Location = new System.Drawing.Point(362, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 543);
            this.panel2.TabIndex = 5;
            // 
            // danhSachTD
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            this.danhSachTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.danhSachTD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danhSachTD.BackgroundColor = System.Drawing.Color.White;
            this.danhSachTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.danhSachTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENDN,
            this.NGUOIDAIDIEN,
            this.MAPHIEUDT,
            this.VITRITD,
            this.NGAYHETHAN});
            this.danhSachTD.Location = new System.Drawing.Point(3, 3);
            this.danhSachTD.Name = "danhSachTD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachTD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.danhSachTD.RowHeadersWidth = 51;
            this.danhSachTD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachTD.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.danhSachTD.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.danhSachTD.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.danhSachTD.RowTemplate.Height = 24;
            this.danhSachTD.Size = new System.Drawing.Size(964, 543);
            this.danhSachTD.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.panel3.Controls.Add(this.homeLink);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 774);
            this.panel3.TabIndex = 6;
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
            // resultContainer
            // 
            this.resultContainer.Location = new System.Drawing.Point(362, 124);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(970, 16);
            this.resultContainer.TabIndex = 7;
            // 
            // cTY_ABCDataSet
            // 
            this.cTY_ABCDataSet.DataSetName = "CTY_ABCDataSet";
            this.cTY_ABCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSDNBindingSource
            // 
            this.dSDNBindingSource.DataMember = "DSDN";
            this.dSDNBindingSource.DataSource = this.cTY_ABCDataSet;
            // 
            // dSDNTableAdapter
            // 
            this.dSDNTableAdapter.ClearBeforeFill = true;
            // 
            // TENDN
            // 
            this.TENDN.DataPropertyName = "TENDN";
            this.TENDN.HeaderText = "Tên Doanh Nghiệp";
            this.TENDN.MinimumWidth = 6;
            this.TENDN.Name = "TENDN";
            this.TENDN.ReadOnly = true;
            this.TENDN.Width = 250;
            // 
            // NGUOIDAIDIEN
            // 
            this.NGUOIDAIDIEN.DataPropertyName = "NGUOIDAIDIEN";
            this.NGUOIDAIDIEN.HeaderText = "Người Đại Diện";
            this.NGUOIDAIDIEN.MinimumWidth = 6;
            this.NGUOIDAIDIEN.Name = "NGUOIDAIDIEN";
            this.NGUOIDAIDIEN.ReadOnly = true;
            this.NGUOIDAIDIEN.Width = 250;
            // 
            // MAPHIEUDT
            // 
            this.MAPHIEUDT.DataPropertyName = "MAPHIEUDT";
            this.MAPHIEUDT.HeaderText = "Mã Đăng Tuyển";
            this.MAPHIEUDT.MinimumWidth = 6;
            this.MAPHIEUDT.Name = "MAPHIEUDT";
            this.MAPHIEUDT.ReadOnly = true;
            this.MAPHIEUDT.Width = 250;
            // 
            // VITRITD
            // 
            this.VITRITD.DataPropertyName = "VITRITD";
            this.VITRITD.HeaderText = "Vị Trí Tuyển Dụng";
            this.VITRITD.MinimumWidth = 6;
            this.VITRITD.Name = "VITRITD";
            this.VITRITD.ReadOnly = true;
            this.VITRITD.Width = 250;
            // 
            // NGAYHETHAN
            // 
            this.NGAYHETHAN.DataPropertyName = "NGAYHETHAN";
            this.NGAYHETHAN.HeaderText = "Ngày Hết Hạn";
            this.NGAYHETHAN.MinimumWidth = 6;
            this.NGAYHETHAN.Name = "NGAYHETHAN";
            this.NGAYHETHAN.ReadOnly = true;
            this.NGAYHETHAN.Width = 250;
            // 
            // MHDanhSachViTriTuyenDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.resultContainer);
            this.Name = "MHDanhSachViTriTuyenDung";
            this.Text = "MHDanhSachViTriTuyenDung";
            this.Load += new System.EventHandler(this.MHDanhSachViTriTuyenDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTY_ABCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchBox;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView danhSachTD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel homeLink;
        private System.Windows.Forms.Panel resultContainer;
        private CTY_ABCDataSet cTY_ABCDataSet;
        private System.Windows.Forms.BindingSource dSDNBindingSource;
        private CTY_ABCDataSetTableAdapters.DSDNTableAdapter dSDNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOIDAIDIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VITRITD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHETHAN;
    }
}