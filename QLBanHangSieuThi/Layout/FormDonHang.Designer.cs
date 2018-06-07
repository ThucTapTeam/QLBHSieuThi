namespace QLBanHangSieuThi.Layout
{
    partial class FormDonHang
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
            this.dataDonHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.ddSearch = new Bunifu.Framework.UI.BunifuDropdown();
            this.inputSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Reload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sieuThiDataSet_DONHANG = new QLBanHangSieuThi.SieuThiDataSet_DONHANG();
            this.vIEWDONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_DONHANGTableAdapter = new QLBanHangSieuThi.SieuThiDataSet_DONHANGTableAdapters.VIEW_DONHANGTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABANRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENGIAODICHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_DONHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWDONHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDonHang
            // 
            this.dataDonHang.AllowUserToAddRows = false;
            this.dataDonHang.AllowUserToDeleteRows = false;
            this.dataDonHang.AllowUserToResizeColumns = false;
            this.dataDonHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDonHang.AutoGenerateColumns = false;
            this.dataDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dataDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDonHang.ColumnHeadersHeight = 38;
            this.dataDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.hOTENDataGridViewTextBoxColumn,
            this.mASANPHAMDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.gIABANRADataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.nHANVIENGIAODICHDataGridViewTextBoxColumn});
            this.dataDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataDonHang.DataSource = this.vIEWDONHANGBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDonHang.DoubleBuffered = true;
            this.dataDonHang.EnableHeadersVisualStyles = false;
            this.dataDonHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.dataDonHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataDonHang.Location = new System.Drawing.Point(58, 96);
            this.dataDonHang.Name = "dataDonHang";
            this.dataDonHang.ReadOnly = true;
            this.dataDonHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDonHang.RowHeadersVisible = false;
            this.dataDonHang.RowTemplate.Height = 20;
            this.dataDonHang.ShowEditingIcon = false;
            this.dataDonHang.Size = new System.Drawing.Size(933, 351);
            this.dataDonHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo mục";
            // 
            // ddSearch
            // 
            this.ddSearch.BackColor = System.Drawing.Color.Transparent;
            this.ddSearch.BorderRadius = 3;
            this.ddSearch.DisabledColor = System.Drawing.Color.Gray;
            this.ddSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddSearch.ForeColor = System.Drawing.Color.White;
            this.ddSearch.Items = new string[] {
        "Mã đơn hàng",
        "Mã sản phẩm",
        "UserName",
        "Tên đơn hàng",
        "Mã khuyến mại",
        "Ngày đặt",
        "Ngày giao hàng"};
            this.ddSearch.Location = new System.Drawing.Point(238, 35);
            this.ddSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddSearch.Name = "ddSearch";
            this.ddSearch.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.ddSearch.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.ddSearch.selectedIndex = 0;
            this.ddSearch.Size = new System.Drawing.Size(155, 37);
            this.ddSearch.TabIndex = 0;
            // 
            // inputSearch
            // 
            this.inputSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputSearch.ForeColor = System.Drawing.Color.Black;
            this.inputSearch.HintForeColor = System.Drawing.Color.Empty;
            this.inputSearch.HintText = "Nhập giá trị cần tìm kiếm";
            this.inputSearch.isPassword = false;
            this.inputSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.inputSearch.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.inputSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.inputSearch.LineThickness = 3;
            this.inputSearch.Location = new System.Drawing.Point(407, 35);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(4);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(261, 37);
            this.inputSearch.TabIndex = 1;
            this.inputSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Tìm kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(675, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(155, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Reload
            // 
            this.Reload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reload.BorderRadius = 0;
            this.Reload.ButtonText = "Tải lại danh sách";
            this.Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reload.DisabledColor = System.Drawing.Color.Gray;
            this.Reload.Iconcolor = System.Drawing.Color.Transparent;
            this.Reload.Iconimage = null;
            this.Reload.Iconimage_right = null;
            this.Reload.Iconimage_right_Selected = null;
            this.Reload.Iconimage_Selected = null;
            this.Reload.IconMarginLeft = 0;
            this.Reload.IconMarginRight = 0;
            this.Reload.IconRightVisible = true;
            this.Reload.IconRightZoom = 0D;
            this.Reload.IconVisible = true;
            this.Reload.IconZoom = 90D;
            this.Reload.IsTab = false;
            this.Reload.Location = new System.Drawing.Point(836, 35);
            this.Reload.Name = "Reload";
            this.Reload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.Reload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.Reload.OnHoverTextColor = System.Drawing.Color.White;
            this.Reload.selected = false;
            this.Reload.Size = new System.Drawing.Size(155, 37);
            this.Reload.TabIndex = 3;
            this.Reload.Text = "Tải lại danh sách";
            this.Reload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Reload.Textcolor = System.Drawing.Color.White;
            this.Reload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "Thêm mới";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsert.Iconimage = null;
            this.btnInsert.Iconimage_right = null;
            this.btnInsert.Iconimage_right_Selected = null;
            this.btnInsert.Iconimage_Selected = null;
            this.btnInsert.IconMarginLeft = 0;
            this.btnInsert.IconMarginRight = 0;
            this.btnInsert.IconRightVisible = true;
            this.btnInsert.IconRightZoom = 0D;
            this.btnInsert.IconVisible = true;
            this.btnInsert.IconZoom = 90D;
            this.btnInsert.IsTab = false;
            this.btnInsert.Location = new System.Drawing.Point(58, 35);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(155, 37);
            this.btnInsert.TabIndex = 55;
            this.btnInsert.Text = "Thêm mới";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // sieuThiDataSet_DONHANG
            // 
            this.sieuThiDataSet_DONHANG.DataSetName = "SieuThiDataSet_DONHANG";
            this.sieuThiDataSet_DONHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWDONHANGBindingSource
            // 
            this.vIEWDONHANGBindingSource.DataMember = "VIEW_DONHANG";
            this.vIEWDONHANGBindingSource.DataSource = this.sieuThiDataSet_DONHANG;
            // 
            // vIEW_DONHANGTableAdapter
            // 
            this.vIEW_DONHANGTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADONHANG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mASANPHAMDataGridViewTextBoxColumn
            // 
            this.mASANPHAMDataGridViewTextBoxColumn.DataPropertyName = "MASANPHAM";
            this.mASANPHAMDataGridViewTextBoxColumn.HeaderText = "MASANPHAM";
            this.mASANPHAMDataGridViewTextBoxColumn.Name = "mASANPHAMDataGridViewTextBoxColumn";
            this.mASANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENSANPHAM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Thiết bị";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "S.Lượng";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOLUONGDataGridViewTextBoxColumn.Width = 65;
            // 
            // gIABANRADataGridViewTextBoxColumn
            // 
            this.gIABANRADataGridViewTextBoxColumn.DataPropertyName = "GIABANRA";
            this.gIABANRADataGridViewTextBoxColumn.HeaderText = "Giá";
            this.gIABANRADataGridViewTextBoxColumn.Name = "gIABANRADataGridViewTextBoxColumn";
            this.gIABANRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAKHUYENMAI";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã KM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYDAT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày đặt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYGIAOHANG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày giao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // nHANVIENGIAODICHDataGridViewTextBoxColumn
            // 
            this.nHANVIENGIAODICHDataGridViewTextBoxColumn.DataPropertyName = "NHANVIENGIAODICH";
            this.nHANVIENGIAODICHDataGridViewTextBoxColumn.HeaderText = "Nhân viên";
            this.nHANVIENGIAODICHDataGridViewTextBoxColumn.Name = "nHANVIENGIAODICHDataGridViewTextBoxColumn";
            this.nHANVIENGIAODICHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.ddSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDonHang);
            this.Name = "FormDonHang";
            this.Size = new System.Drawing.Size(1045, 470);
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_DONHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWDONHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataDonHang;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown ddSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton Reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADONHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDONHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHUYENMAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xACNHANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYGIAOHANGDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private System.Windows.Forms.BindingSource vIEWDONHANGBindingSource;
        private SieuThiDataSet_DONHANG sieuThiDataSet_DONHANG;
        private SieuThiDataSet_DONHANGTableAdapters.VIEW_DONHANGTableAdapter vIEW_DONHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABANRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHANVIENGIAODICHDataGridViewTextBoxColumn;
    }
}
