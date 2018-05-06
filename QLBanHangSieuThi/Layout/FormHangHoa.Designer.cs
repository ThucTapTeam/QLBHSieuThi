namespace QLBanHangSieuThi.Layout
{
    partial class FormHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataHangHoa = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mASANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIANHAPVAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABANRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sieuThiDataSet_HangHoa = new QLBanHangSieuThi.SieuThiDataSet_HangHoa();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inputSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ddSearch = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.DPngNhap = new System.Windows.Forms.DateTimePicker();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.hANGHOATableAdapter = new QLBanHangSieuThi.SieuThiDataSet_HangHoaTableAdapters.HANGHOATableAdapter();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_HangHoa)).BeginInit();
            this.txtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHangHoa
            // 
            this.dataHangHoa.AllowUserToAddRows = false;
            this.dataHangHoa.AllowUserToDeleteRows = false;
            this.dataHangHoa.AllowUserToResizeColumns = false;
            this.dataHangHoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataHangHoa.AutoGenerateColumns = false;
            this.dataHangHoa.BackgroundColor = System.Drawing.Color.White;
            this.dataHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHangHoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASANPHAMDataGridViewTextBoxColumn,
            this.tENSANPHAMDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.gIANHAPVAODataGridViewTextBoxColumn,
            this.gIABANRADataGridViewTextBoxColumn,
            this.nGAYNHAPDataGridViewTextBoxColumn,
            this.isDelDataGridViewCheckBoxColumn});
            this.dataHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataHangHoa.DataSource = this.hANGHOABindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataHangHoa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataHangHoa.DoubleBuffered = true;
            this.dataHangHoa.EnableHeadersVisualStyles = false;
            this.dataHangHoa.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.dataHangHoa.HeaderForeColor = System.Drawing.Color.White;
            this.dataHangHoa.Location = new System.Drawing.Point(58, 106);
            this.dataHangHoa.Name = "dataHangHoa";
            this.dataHangHoa.ReadOnly = true;
            this.dataHangHoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataHangHoa.RowHeadersVisible = false;
            this.dataHangHoa.RowTemplate.Height = 20;
            this.dataHangHoa.Size = new System.Drawing.Size(933, 262);
            this.dataHangHoa.TabIndex = 13;
            this.dataHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangHoa_CellClick);
            // 
            // mASANPHAMDataGridViewTextBoxColumn
            // 
            this.mASANPHAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mASANPHAMDataGridViewTextBoxColumn.DataPropertyName = "MASANPHAM";
            this.mASANPHAMDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.mASANPHAMDataGridViewTextBoxColumn.Name = "mASANPHAMDataGridViewTextBoxColumn";
            this.mASANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENSANPHAMDataGridViewTextBoxColumn
            // 
            this.tENSANPHAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tENSANPHAMDataGridViewTextBoxColumn.DataPropertyName = "TENSANPHAM";
            this.tENSANPHAMDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tENSANPHAMDataGridViewTextBoxColumn.Name = "tENSANPHAMDataGridViewTextBoxColumn";
            this.tENSANPHAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIANHAPVAODataGridViewTextBoxColumn
            // 
            this.gIANHAPVAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIANHAPVAODataGridViewTextBoxColumn.DataPropertyName = "GIANHAPVAO";
            this.gIANHAPVAODataGridViewTextBoxColumn.HeaderText = "Giá nhập vào";
            this.gIANHAPVAODataGridViewTextBoxColumn.Name = "gIANHAPVAODataGridViewTextBoxColumn";
            this.gIANHAPVAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIABANRADataGridViewTextBoxColumn
            // 
            this.gIABANRADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIABANRADataGridViewTextBoxColumn.DataPropertyName = "GIABANRA";
            this.gIABANRADataGridViewTextBoxColumn.HeaderText = "Giá bán ra";
            this.gIABANRADataGridViewTextBoxColumn.Name = "gIABANRADataGridViewTextBoxColumn";
            this.gIABANRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYNHAPDataGridViewTextBoxColumn
            // 
            this.nGAYNHAPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYNHAPDataGridViewTextBoxColumn.DataPropertyName = "NGAYNHAP";
            this.nGAYNHAPDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.nGAYNHAPDataGridViewTextBoxColumn.Name = "nGAYNHAPDataGridViewTextBoxColumn";
            this.nGAYNHAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDelDataGridViewCheckBoxColumn
            // 
            this.isDelDataGridViewCheckBoxColumn.DataPropertyName = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.HeaderText = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.Name = "isDelDataGridViewCheckBoxColumn";
            this.isDelDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDelDataGridViewCheckBoxColumn.Width = 40;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.sieuThiDataSet_HangHoa;
            // 
            // sieuThiDataSet_HangHoa
            // 
            this.sieuThiDataSet_HangHoa.DataSetName = "SieuThiDataSet_HangHoa";
            this.sieuThiDataSet_HangHoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.dataHangHoa;
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
            this.btnSearch.Location = new System.Drawing.Point(604, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(155, 48);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.inputSearch.Location = new System.Drawing.Point(293, 35);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(4);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(261, 43);
            this.inputSearch.TabIndex = 18;
            this.inputSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
        "Tên hàng hoá",
        "Số lượng",
        "Giá nhập",
        "Giá bán",
        "Ngày nhập"};
            this.ddSearch.Location = new System.Drawing.Point(58, 35);
            this.ddSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddSearch.Name = "ddSearch";
            this.ddSearch.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.ddSearch.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.ddSearch.selectedIndex = 1;
            this.ddSearch.Size = new System.Drawing.Size(185, 48);
            this.ddSearch.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tìm kiếm theo mục";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 12;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Tải lại danh sách";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(809, 35);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(155, 48);
            this.bunifuFlatButton1.TabIndex = 31;
            this.bunifuFlatButton1.Text = "Tải lại danh sách";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.btnSave.Location = new System.Drawing.Point(836, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(155, 48);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(636, 419);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(155, 48);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "Thêm mới";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(3, 3);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(160, 20);
            this.txtMaSP.TabIndex = 34;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(601, 3);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(162, 20);
            this.txtGiaBan.TabIndex = 35;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(435, 3);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(160, 20);
            this.txtGiaNhap.TabIndex = 36;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(336, 3);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(93, 20);
            this.txtSL.TabIndex = 37;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(169, 3);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(161, 20);
            this.txtTenSP.TabIndex = 38;
            // 
            // DPngNhap
            // 
            this.DPngNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPngNhap.Location = new System.Drawing.Point(769, 3);
            this.DPngNhap.Name = "DPngNhap";
            this.DPngNhap.Size = new System.Drawing.Size(129, 20);
            this.DPngNhap.TabIndex = 39;
            // 
            // txtPanel
            // 
            this.txtPanel.Controls.Add(this.txtGiaBan);
            this.txtPanel.Controls.Add(this.txtTenSP);
            this.txtPanel.Controls.Add(this.txtSL);
            this.txtPanel.Controls.Add(this.txtMaSP);
            this.txtPanel.Controls.Add(this.txtGiaNhap);
            this.txtPanel.Controls.Add(this.DPngNhap);
            this.txtPanel.Location = new System.Drawing.Point(55, 380);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(933, 38);
            this.txtPanel.TabIndex = 40;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Hủy bỏ";
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
            this.btnCancel.Location = new System.Drawing.Point(636, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(155, 48);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Cập nhật";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(836, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(155, 48);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.ddSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataHangHoa);
            this.Name = "FormHangHoa";
            this.Size = new System.Drawing.Size(1045, 470);
            this.Load += new System.EventHandler(this.FomHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_HangHoa)).EndInit();
            this.txtPanel.ResumeLayout(false);
            this.txtPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataHangHoa;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputSearch;
        private Bunifu.Framework.UI.BunifuDropdown ddSearch;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DateTimePicker DPngNhap;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private SieuThiDataSet_HangHoa sieuThiDataSet_HangHoa;
        private SieuThiDataSet_HangHoaTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIANHAPVAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABANRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDelDataGridViewCheckBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
    }
}
