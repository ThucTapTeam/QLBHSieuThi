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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataDonHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ddSearch = new Bunifu.Framework.UI.BunifuDropdown();
            this.inputSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Reload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.ComboBox();
            this.cmbMaSp = new System.Windows.Forms.ComboBox();
            this.dateGiao = new System.Windows.Forms.DateTimePicker();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.cmbMaKhuyenMai = new System.Windows.Forms.ComboBox();
            this.txtTenDonHang = new System.Windows.Forms.TextBox();
            this.dateDat = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sieuThiDataSet_DonHang = new QLBanHangSieuThi.SieuThiDataSet_DonHang();
            this.vIEWDONHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_DONHANGTableAdapter = new QLBanHangSieuThi.SieuThiDataSet_DonHangTableAdapters.VIEW_DONHANGTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonHang)).BeginInit();
            this.txtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_DonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWDONHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDonHang
            // 
            this.dataDonHang.AllowUserToAddRows = false;
            this.dataDonHang.AllowUserToDeleteRows = false;
            this.dataDonHang.AllowUserToResizeColumns = false;
            this.dataDonHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataDonHang.AutoGenerateColumns = false;
            this.dataDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dataDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataDonHang.DataSource = this.vIEWDONHANGBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDonHang.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataDonHang.DoubleBuffered = true;
            this.dataDonHang.EnableHeadersVisualStyles = false;
            this.dataDonHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.dataDonHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataDonHang.Location = new System.Drawing.Point(56, 98);
            this.dataDonHang.Name = "dataDonHang";
            this.dataDonHang.ReadOnly = true;
            this.dataDonHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDonHang.RowHeadersVisible = false;
            this.dataDonHang.RowTemplate.Height = 20;
            this.dataDonHang.ShowEditingIcon = false;
            this.dataDonHang.Size = new System.Drawing.Size(933, 263);
            this.dataDonHang.TabIndex = 0;
            this.dataDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDonHang_CellClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.dataDonHang;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, -1);
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
            this.ddSearch.Location = new System.Drawing.Point(56, 29);
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
            this.inputSearch.Location = new System.Drawing.Point(265, 30);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(4);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(261, 37);
            this.inputSearch.TabIndex = 1;
            this.inputSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.btnSearch.Location = new System.Drawing.Point(594, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
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
            this.Reload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.Reload.Location = new System.Drawing.Point(834, 29);
            this.Reload.Name = "Reload";
            this.Reload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Reload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
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
            this.btnInsert.Location = new System.Drawing.Point(617, 430);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(155, 37);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Thêm mới";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(834, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(155, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPanel
            // 
            this.txtPanel.Controls.Add(this.label9);
            this.txtPanel.Controls.Add(this.label8);
            this.txtPanel.Controls.Add(this.label7);
            this.txtPanel.Controls.Add(this.label5);
            this.txtPanel.Controls.Add(this.label4);
            this.txtPanel.Controls.Add(this.label3);
            this.txtPanel.Controls.Add(this.label2);
            this.txtPanel.Controls.Add(this.txtMaDon);
            this.txtPanel.Controls.Add(this.cmbMaSp);
            this.txtPanel.Controls.Add(this.dateGiao);
            this.txtPanel.Controls.Add(this.cmbUserName);
            this.txtPanel.Controls.Add(this.cmbMaKhuyenMai);
            this.txtPanel.Controls.Add(this.txtTenDonHang);
            this.txtPanel.Controls.Add(this.dateDat);
            this.txtPanel.Location = new System.Drawing.Point(56, 365);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(933, 57);
            this.txtPanel.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Người mua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(813, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Ngày giao";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tên đơn hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mã khuyến mại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã đơn hàng";
            // 
            // txtMaDon
            // 
            this.txtMaDon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaDon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMaDon.FormattingEnabled = true;
            this.txtMaDon.Location = new System.Drawing.Point(0, 29);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(110, 21);
            this.txtMaDon.TabIndex = 0;
            // 
            // cmbMaSp
            // 
            this.cmbMaSp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaSp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaSp.FormattingEnabled = true;
            this.cmbMaSp.Location = new System.Drawing.Point(135, 29);
            this.cmbMaSp.Name = "cmbMaSp";
            this.cmbMaSp.Size = new System.Drawing.Size(110, 21);
            this.cmbMaSp.TabIndex = 1;
            // 
            // dateGiao
            // 
            this.dateGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiao.Location = new System.Drawing.Point(813, 29);
            this.dateGiao.Name = "dateGiao";
            this.dateGiao.Size = new System.Drawing.Size(102, 20);
            this.dateGiao.TabIndex = 7;
            // 
            // cmbUserName
            // 
            this.cmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(270, 29);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(111, 21);
            this.cmbUserName.TabIndex = 2;
            // 
            // cmbMaKhuyenMai
            // 
            this.cmbMaKhuyenMai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaKhuyenMai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaKhuyenMai.FormattingEnabled = true;
            this.cmbMaKhuyenMai.Location = new System.Drawing.Point(541, 29);
            this.cmbMaKhuyenMai.Name = "cmbMaKhuyenMai";
            this.cmbMaKhuyenMai.Size = new System.Drawing.Size(111, 21);
            this.cmbMaKhuyenMai.TabIndex = 4;
            // 
            // txtTenDonHang
            // 
            this.txtTenDonHang.Location = new System.Drawing.Point(406, 29);
            this.txtTenDonHang.Name = "txtTenDonHang";
            this.txtTenDonHang.Size = new System.Drawing.Size(110, 20);
            this.txtTenDonHang.TabIndex = 3;
            // 
            // dateDat
            // 
            this.dateDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDat.Location = new System.Drawing.Point(677, 30);
            this.dateDat.Name = "dateDat";
            this.dateDat.Size = new System.Drawing.Size(111, 20);
            this.dateDat.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "SuggestID";
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Huỷ bỏ";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(617, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(155, 37);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sieuThiDataSet_DonHang
            // 
            this.sieuThiDataSet_DonHang.DataSetName = "SieuThiDataSet_DonHang";
            this.sieuThiDataSet_DonHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWDONHANGBindingSource
            // 
            this.vIEWDONHANGBindingSource.DataMember = "VIEW_DONHANG";
            this.vIEWDONHANGBindingSource.DataSource = this.sieuThiDataSet_DonHang;
            // 
            // vIEW_DONHANGTableAdapter
            // 
            this.vIEW_DONHANGTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADONHANG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã đơn hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENSANPHAM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "Người mua";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENDONHANG";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên đơn hàng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAKHUYENMAI";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã khuyến mại";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NGAYDAT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày đặt";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NGAYGIAOHANG";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngày giao hàng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.btnSave);
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
            this.txtPanel.ResumeLayout(false);
            this.txtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_DonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWDONHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataDonHang;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown ddSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton Reload;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.TextBox txtTenDonHang;
        private System.Windows.Forms.DateTimePicker dateDat;
        private System.Windows.Forms.DateTimePicker dateGiao;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.ComboBox cmbMaKhuyenMai;
        private System.Windows.Forms.ComboBox cmbMaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADONHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDONHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHUYENMAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xACNHANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYGIAOHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtMaDon;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource vIEWDONHANGBindingSource;
        private SieuThiDataSet_DonHang sieuThiDataSet_DonHang;
        private SieuThiDataSet_DonHangTableAdapters.VIEW_DONHANGTableAdapter vIEW_DONHANGTableAdapter;
    }
}
