namespace ABCTuyenDung
{
    partial class XemDNGanHetHan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.Label();
            this.cbLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbDS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dSDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTY_ABCDataSet = new ABCTuyenDung.CTY_ABCDataSet();
            this.btXuatFile = new Guna.UI2.WinForms.Guna2Button();
            this.dSDNTableAdapter = new ABCTuyenDung.CTY_ABCDataSetTableAdapters.DSDNTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mÃDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTY_ABCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.AutoSize = true;
            this.txtTieuDe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(105, 60);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(683, 37);
            this.txtTieuDe.TabIndex = 0;
            this.txtTieuDe.Text = "DOANH NGHIỆP CÓ ĐĂNG KÝ ĐĂNG TUYỂN";
            // 
            // txtLoc
            // 
            this.txtLoc.AutoSize = true;
            this.txtLoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtLoc.Location = new System.Drawing.Point(839, 137);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(157, 32);
            this.txtLoc.TabIndex = 1;
            this.txtLoc.Text = "LỌC THEO";
            // 
            // cbLoc
            // 
            this.cbLoc.AutoRoundedCorners = true;
            this.cbLoc.BackColor = System.Drawing.Color.Transparent;
            this.cbLoc.BorderRadius = 17;
            this.cbLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoc.ItemHeight = 30;
            this.cbLoc.Items.AddRange(new object[] {
            "SẮP HẾT HẠN"});
            this.cbLoc.Location = new System.Drawing.Point(1002, 117);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(278, 36);
            this.cbLoc.TabIndex = 4;
            // 
            // tbDS
            // 
            this.tbDS.AllowUserToAddRows = false;
            this.tbDS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tbDS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbDS.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbDS.ColumnHeadersHeight = 46;
            this.tbDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.mÃDNDataGridViewTextBoxColumn,
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn,
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn});
            this.tbDS.DataSource = this.dSDNBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbDS.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.tbDS.Location = new System.Drawing.Point(51, 197);
            this.tbDS.Name = "tbDS";
            this.tbDS.ReadOnly = true;
            this.tbDS.RowHeadersVisible = false;
            this.tbDS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tbDS.RowTemplate.Height = 33;
            this.tbDS.Size = new System.Drawing.Size(1267, 620);
            this.tbDS.TabIndex = 5;
            this.tbDS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.tbDS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tbDS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tbDS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tbDS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tbDS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tbDS.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tbDS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.tbDS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.tbDS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tbDS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.tbDS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tbDS.ThemeStyle.HeaderStyle.Height = 46;
            this.tbDS.ThemeStyle.ReadOnly = true;
            this.tbDS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.tbDS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tbDS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tbDS.ThemeStyle.RowsStyle.Height = 33;
            this.tbDS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.tbDS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tbDS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbDS_CellContentClick);
            // 
            // dSDNBindingSource
            // 
            this.dSDNBindingSource.DataMember = "DSDN";
            this.dSDNBindingSource.DataSource = this.cTY_ABCDataSet;
            // 
            // cTY_ABCDataSet
            // 
            this.cTY_ABCDataSet.DataSetName = "CTY_ABCDataSet";
            this.cTY_ABCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btXuatFile
            // 
            this.btXuatFile.AutoRoundedCorners = true;
            this.btXuatFile.BorderRadius = 21;
            this.btXuatFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btXuatFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btXuatFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btXuatFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btXuatFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatFile.ForeColor = System.Drawing.Color.White;
            this.btXuatFile.Location = new System.Drawing.Point(1100, 830);
            this.btXuatFile.Name = "btXuatFile";
            this.btXuatFile.Size = new System.Drawing.Size(180, 45);
            this.btXuatFile.TabIndex = 6;
            this.btXuatFile.Text = "XUẤT FILE";
            // 
            // dSDNTableAdapter
            // 
            this.dSDNTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "     ";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 41;
            // 
            // mÃDNDataGridViewTextBoxColumn
            // 
            this.mÃDNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mÃDNDataGridViewTextBoxColumn.DataPropertyName = "MÃ DN";
            this.mÃDNDataGridViewTextBoxColumn.HeaderText = "MÃ DN";
            this.mÃDNDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.mÃDNDataGridViewTextBoxColumn.Name = "mÃDNDataGridViewTextBoxColumn";
            this.mÃDNDataGridViewTextBoxColumn.ReadOnly = true;
            this.mÃDNDataGridViewTextBoxColumn.Width = 123;
            // 
            // tÊNDOANHNGHIỆPDataGridViewTextBoxColumn
            // 
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn.DataPropertyName = "TÊN DOANH NGHIỆP";
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn.HeaderText = "TÊN DOANH NGHIỆP";
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn.Name = "tÊNDOANHNGHIỆPDataGridViewTextBoxColumn";
            this.tÊNDOANHNGHIỆPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn
            // 
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn.DataPropertyName = "NGƯỜI ĐẠI DIỆN";
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn.HeaderText = "NGƯỜI ĐẠI DIỆN";
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn.Name = "nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn";
            this.nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGÀYHẾTHẠNDataGridViewTextBoxColumn
            // 
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn.DataPropertyName = "NGÀY HẾT HẠN";
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn.HeaderText = "NGÀY HẾT HẠN";
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn.Name = "nGÀYHẾTHẠNDataGridViewTextBoxColumn";
            this.nGÀYHẾTHẠNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // XemDNGanHetHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btXuatFile);
            this.Controls.Add(this.tbDS);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtTieuDe);
            this.Name = "XemDNGanHetHan";
            this.Size = new System.Drawing.Size(1374, 900);
            this.Load += new System.EventHandler(this.XemDNGanHetHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTY_ABCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.Label txtLoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoc;
        private Guna.UI2.WinForms.Guna2DataGridView tbDS;
        private Guna.UI2.WinForms.Guna2Button btXuatFile;
        private System.Windows.Forms.BindingSource dSDNBindingSource;
        private CTY_ABCDataSet cTY_ABCDataSet;
        private CTY_ABCDataSetTableAdapters.DSDNTableAdapter dSDNTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÃDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tÊNDOANHNGHIỆPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGƯỜIĐẠIDIỆNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGÀYHẾTHẠNDataGridViewTextBoxColumn;
    }
}
