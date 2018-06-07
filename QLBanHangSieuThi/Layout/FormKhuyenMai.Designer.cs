namespace QLBanHangSieuThi.Layout
{
    partial class FormKhuyenMai
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
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.DPngayBDKM = new System.Windows.Forms.DateTimePicker();
            this.DPngayKTKM = new System.Windows.Forms.DateTimePicker();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inputSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ddSearch = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataKM = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mAKHUYENMAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHUYENMAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHANTRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYBATDAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYKETTHUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kHUYENMAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sieuThiDataSet_KM = new QLBanHangSieuThi.SieuThiDataSet_KM();
            this.kHUYENMAITableAdapter = new QLBanHangSieuThi.SieuThiDataSet_KMTableAdapters.KHUYENMAITableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhanTram = new System.Windows.Forms.NumericUpDown();
            this.txtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_KM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhanTram)).BeginInit();
            this.SuspendLayout();
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
            this.btnUpdate.Location = new System.Drawing.Point(836, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(155, 37);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPanel
            // 
            this.txtPanel.Controls.Add(this.txtPhanTram);
            this.txtPanel.Controls.Add(this.label6);
            this.txtPanel.Controls.Add(this.label5);
            this.txtPanel.Controls.Add(this.label4);
            this.txtPanel.Controls.Add(this.label3);
            this.txtPanel.Controls.Add(this.label2);
            this.txtPanel.Controls.Add(this.DPngayBDKM);
            this.txtPanel.Controls.Add(this.DPngayKTKM);
            this.txtPanel.Controls.Add(this.txtTenKM);
            this.txtPanel.Controls.Add(this.txtMaKM);
            this.txtPanel.Location = new System.Drawing.Point(55, 362);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(933, 51);
            this.txtPanel.TabIndex = 51;
            // 
            // DPngayBDKM
            // 
            this.DPngayBDKM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPngayBDKM.Location = new System.Drawing.Point(581, 26);
            this.DPngayBDKM.Name = "DPngayBDKM";
            this.DPngayBDKM.Size = new System.Drawing.Size(160, 20);
            this.DPngayBDKM.TabIndex = 3;
            // 
            // DPngayKTKM
            // 
            this.DPngayKTKM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPngayKTKM.Location = new System.Drawing.Point(768, 26);
            this.DPngayKTKM.Name = "DPngayKTKM";
            this.DPngayKTKM.Size = new System.Drawing.Size(160, 20);
            this.DPngayKTKM.TabIndex = 4;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(206, 25);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(161, 20);
            this.txtTenKM.TabIndex = 1;
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(19, 25);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(160, 20);
            this.txtMaKM.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(636, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(155, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(637, 420);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(155, 37);
            this.btnInsert.TabIndex = 50;
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
            this.btnSave.Location = new System.Drawing.Point(837, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(155, 37);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 0;
            this.btnReload.ButtonText = "Tải lại danh sách";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = null;
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 90D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(836, 36);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(155, 37);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Tải lại danh sách";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(612, 36);
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
            this.inputSearch.Location = new System.Drawing.Point(282, 36);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(4);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(261, 37);
            this.inputSearch.TabIndex = 1;
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
        "Mã KM",
        "Tên KM"};
            this.ddSearch.Location = new System.Drawing.Point(58, 36);
            this.ddSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddSearch.Name = "ddSearch";
            this.ddSearch.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.ddSearch.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.ddSearch.selectedIndex = 1;
            this.ddSearch.Size = new System.Drawing.Size(155, 37);
            this.ddSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tìm kiếm theo mục";
            // 
            // dataKM
            // 
            this.dataKM.AllowUserToAddRows = false;
            this.dataKM.AllowUserToDeleteRows = false;
            this.dataKM.AllowUserToResizeColumns = false;
            this.dataKM.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataKM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKM.AutoGenerateColumns = false;
            this.dataKM.BackgroundColor = System.Drawing.Color.White;
            this.dataKM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHUYENMAIDataGridViewTextBoxColumn,
            this.tENKHUYENMAIDataGridViewTextBoxColumn,
            this.pHANTRAMDataGridViewTextBoxColumn,
            this.nGAYBATDAUDataGridViewTextBoxColumn,
            this.nGAYKETTHUCDataGridViewTextBoxColumn,
            this.delDataGridViewCheckBoxColumn});
            this.dataKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataKM.DataSource = this.kHUYENMAIBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataKM.DoubleBuffered = true;
            this.dataKM.EnableHeadersVisualStyles = false;
            this.dataKM.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.dataKM.HeaderForeColor = System.Drawing.Color.White;
            this.dataKM.Location = new System.Drawing.Point(58, 94);
            this.dataKM.Name = "dataKM";
            this.dataKM.ReadOnly = true;
            this.dataKM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataKM.RowHeadersVisible = false;
            this.dataKM.RowTemplate.Height = 20;
            this.dataKM.Size = new System.Drawing.Size(933, 262);
            this.dataKM.TabIndex = 43;
            this.dataKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangHoa_CellClick);
            // 
            // mAKHUYENMAIDataGridViewTextBoxColumn
            // 
            this.mAKHUYENMAIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mAKHUYENMAIDataGridViewTextBoxColumn.DataPropertyName = "MAKHUYENMAI";
            this.mAKHUYENMAIDataGridViewTextBoxColumn.HeaderText = "Mã khuyến mại";
            this.mAKHUYENMAIDataGridViewTextBoxColumn.Name = "mAKHUYENMAIDataGridViewTextBoxColumn";
            this.mAKHUYENMAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENKHUYENMAIDataGridViewTextBoxColumn
            // 
            this.tENKHUYENMAIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tENKHUYENMAIDataGridViewTextBoxColumn.DataPropertyName = "TENKHUYENMAI";
            this.tENKHUYENMAIDataGridViewTextBoxColumn.HeaderText = "Tên khuyến mại";
            this.tENKHUYENMAIDataGridViewTextBoxColumn.Name = "tENKHUYENMAIDataGridViewTextBoxColumn";
            this.tENKHUYENMAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHANTRAMDataGridViewTextBoxColumn
            // 
            this.pHANTRAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pHANTRAMDataGridViewTextBoxColumn.DataPropertyName = "PHANTRAM";
            this.pHANTRAMDataGridViewTextBoxColumn.HeaderText = "Mức khuyến mại (%)";
            this.pHANTRAMDataGridViewTextBoxColumn.Name = "pHANTRAMDataGridViewTextBoxColumn";
            this.pHANTRAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYBATDAUDataGridViewTextBoxColumn
            // 
            this.nGAYBATDAUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYBATDAUDataGridViewTextBoxColumn.DataPropertyName = "NGAYBATDAU";
            this.nGAYBATDAUDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.nGAYBATDAUDataGridViewTextBoxColumn.Name = "nGAYBATDAUDataGridViewTextBoxColumn";
            this.nGAYBATDAUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYKETTHUCDataGridViewTextBoxColumn
            // 
            this.nGAYKETTHUCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYKETTHUCDataGridViewTextBoxColumn.DataPropertyName = "NGAYKETTHUC";
            this.nGAYKETTHUCDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.nGAYKETTHUCDataGridViewTextBoxColumn.Name = "nGAYKETTHUCDataGridViewTextBoxColumn";
            this.nGAYKETTHUCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delDataGridViewCheckBoxColumn
            // 
            this.delDataGridViewCheckBoxColumn.DataPropertyName = "Del";
            this.delDataGridViewCheckBoxColumn.HeaderText = "Del";
            this.delDataGridViewCheckBoxColumn.Name = "delDataGridViewCheckBoxColumn";
            this.delDataGridViewCheckBoxColumn.ReadOnly = true;
            this.delDataGridViewCheckBoxColumn.Width = 35;
            // 
            // kHUYENMAIBindingSource
            // 
            this.kHUYENMAIBindingSource.DataMember = "KHUYENMAI";
            this.kHUYENMAIBindingSource.DataSource = this.sieuThiDataSet_KM;
            // 
            // sieuThiDataSet_KM
            // 
            this.sieuThiDataSet_KM.DataSetName = "SieuThiDataSet_KM";
            this.sieuThiDataSet_KM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUYENMAITableAdapter
            // 
            this.kHUYENMAITableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã KM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mức KM (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tên KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(765, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Ngày kết thúc";
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(394, 26);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(161, 20);
            this.txtPhanTram.TabIndex = 50;
            // 
            // FormKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.ddSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKM);
            this.Name = "FormKhuyenMai";
            this.Size = new System.Drawing.Size(1045, 470);
            this.Load += new System.EventHandler(this.FomKhuyenMai_Load);
            this.txtPanel.ResumeLayout(false);
            this.txtPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sieuThiDataSet_KM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhanTram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.TextBox txtMaKM;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputSearch;
        private Bunifu.Framework.UI.BunifuDropdown ddSearch;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataKM;
        private System.Windows.Forms.DateTimePicker DPngayKTKM;
        private System.Windows.Forms.DateTimePicker DPngayBDKM;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource;
        private SieuThiDataSet_KM sieuThiDataSet_KM;
        private SieuThiDataSet_KMTableAdapters.KHUYENMAITableAdapter kHUYENMAITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHUYENMAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHUYENMAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHANTRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYBATDAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYKETTHUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delDataGridViewCheckBoxColumn;
        private System.Windows.Forms.NumericUpDown txtPhanTram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
