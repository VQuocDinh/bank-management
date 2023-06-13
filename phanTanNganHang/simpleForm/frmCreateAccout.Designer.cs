namespace phanTanNganHang.simpleForm
{
    partial class frmCreateAccout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccout));
            this.dS = new phanTanNganHang.DS();
            this.tableAdapterManager = new phanTanNganHang.DSTableAdapters.TableAdapterManager();
            this.bdsNV_X_LOGIN = new System.Windows.Forms.BindingSource(this.components);
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter = new phanTanNganHang.DSTableAdapters.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter();
            this.grFormTaoLogin = new System.Windows.Forms.GroupBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.nPass = new System.Windows.Forms.Label();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            this.nName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bds_LGINFO = new System.Windows.Forms.BindingSource(this.components);
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter = new phanTanNganHang.DSTableAdapters.frmCreateLogin_GetLoginsOfBranchTableAdapter();
            this.gc_LGINFO1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoLuuY = new DevExpress.XtraEditors.MemoEdit();
            this.panInput = new DevExpress.XtraEditors.PanelControl();
            this.gcNV_X_LOGIN = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV_X_LOGIN)).BeginInit();
            this.grFormTaoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LGINFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_LGINFO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLuuY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panInput)).BeginInit();
            this.panInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV_X_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.dsChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = phanTanNganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsNV_X_LOGIN
            // 
            this.bdsNV_X_LOGIN.DataMember = "frmCreateLogin_GetEmployeeNotHaveLogin";
            this.bdsNV_X_LOGIN.DataSource = this.dS;
            // 
            // frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter
            // 
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.ClearBeforeFill = true;
            // 
            // grFormTaoLogin
            // 
            this.grFormTaoLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.grFormTaoLogin.Controls.Add(this.txtLoginName);
            this.grFormTaoLogin.Controls.Add(this.nPass);
            this.grFormTaoLogin.Controls.Add(this.btnCreateLogin);
            this.grFormTaoLogin.Controls.Add(this.nName);
            this.grFormTaoLogin.Controls.Add(this.txtPass);
            this.grFormTaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grFormTaoLogin.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grFormTaoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grFormTaoLogin.Location = new System.Drawing.Point(614, 360);
            this.grFormTaoLogin.Name = "grFormTaoLogin";
            this.grFormTaoLogin.Size = new System.Drawing.Size(535, 220);
            this.grFormTaoLogin.TabIndex = 13;
            this.grFormTaoLogin.TabStop = false;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(161, 14);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(361, 34);
            this.txtLoginName.TabIndex = 10;
            // 
            // nPass
            // 
            this.nPass.AutoSize = true;
            this.nPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPass.ForeColor = System.Drawing.Color.Black;
            this.nPass.Location = new System.Drawing.Point(20, 98);
            this.nPass.Name = "nPass";
            this.nPass.Size = new System.Drawing.Size(103, 26);
            this.nPass.TabIndex = 10;
            this.nPass.Text = "Mật Khẩu";
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLogin.ForeColor = System.Drawing.Color.Green;
            this.btnCreateLogin.Location = new System.Drawing.Point(224, 136);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(166, 38);
            this.btnCreateLogin.TabIndex = 12;
            this.btnCreateLogin.Text = "TẠO LOGIN";
            this.btnCreateLogin.UseVisualStyleBackColor = true;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // nName
            // 
            this.nName.AutoSize = true;
            this.nName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nName.ForeColor = System.Drawing.Color.Black;
            this.nName.Location = new System.Drawing.Point(14, 23);
            this.nName.Name = "nName";
            this.nName.Size = new System.Drawing.Size(106, 26);
            this.nName.TabIndex = 8;
            this.nName.Text = "Tài khoản";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(161, 93);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(361, 34);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTrangThai);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1193, 51);
            this.panelControl1.TabIndex = 14;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(546, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTrangThai.Properties.Appearance.Options.UseFont = true;
            this.txtTrangThai.Properties.Appearance.Options.UseForeColor = true;
            this.txtTrangThai.Size = new System.Drawing.Size(470, 28);
            this.txtTrangThai.TabIndex = 3;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(148, 8);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(325, 24);
            this.cmbChiNhanh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnReload,
            this.btnExit,
            this.btnCreateAccount,
            this.btnUndo,
            this.btnXoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(1599, 35);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar1.Offset = 1098;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tải lại";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Caption = "Tạo tài khoản";
            this.btnCreateAccount.Id = 4;
            this.btnCreateAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.ImageOptions.Image")));
            this.btnCreateAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.ImageOptions.LargeImage")));
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAccount_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại trang";
            this.btnReload.Id = 2;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 3;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1193, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 725);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1193, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 695);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1193, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 695);
            // 
            // bds_LGINFO
            // 
            this.bds_LGINFO.DataMember = "frmCreateLogin_GetLoginsOfBranch";
            this.bds_LGINFO.DataSource = this.dS;
            // 
            // frmCreateLogin_GetLoginsOfBranchTableAdapter
            // 
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.ClearBeforeFill = true;
            // 
            // gc_LGINFO1
            // 
            this.gc_LGINFO1.DataSource = this.bds_LGINFO;
            this.gc_LGINFO1.Location = new System.Drawing.Point(12, 87);
            this.gc_LGINFO1.MainView = this.gridView1;
            this.gc_LGINFO1.MenuManager = this.barManager1;
            this.gc_LGINFO1.Name = "gc_LGINFO1";
            this.gc_LGINFO1.Size = new System.Drawing.Size(1051, 245);
            this.gc_LGINFO1.TabIndex = 18;
            this.gc_LGINFO1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOGIN,
            this.colMANV,
            this.colHOTEN,
            this.colROLE});
            this.gridView1.GridControl = this.gc_LGINFO1;
            this.gridView1.Name = "gridView1";
            // 
            // colTENLOGIN
            // 
            this.colTENLOGIN.FieldName = "TENLOGIN";
            this.colTENLOGIN.MinWidth = 25;
            this.colTENLOGIN.Name = "colTENLOGIN";
            this.colTENLOGIN.Visible = true;
            this.colTENLOGIN.VisibleIndex = 0;
            this.colTENLOGIN.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            this.colMANV.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            this.colHOTEN.Width = 94;
            // 
            // colROLE
            // 
            this.colROLE.FieldName = "ROLE";
            this.colROLE.MinWidth = 25;
            this.colROLE.Name = "colROLE";
            this.colROLE.Visible = true;
            this.colROLE.VisibleIndex = 3;
            this.colROLE.Width = 94;
            // 
            // memoLuuY
            // 
            this.memoLuuY.EditValue = "";
            this.memoLuuY.Enabled = false;
            this.memoLuuY.Location = new System.Drawing.Point(332, 607);
            this.memoLuuY.Name = "memoLuuY";
            this.memoLuuY.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.memoLuuY.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoLuuY.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.memoLuuY.Properties.Appearance.Options.UseBackColor = true;
            this.memoLuuY.Properties.Appearance.Options.UseFont = true;
            this.memoLuuY.Properties.Appearance.Options.UseForeColor = true;
            this.memoLuuY.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoLuuY.Size = new System.Drawing.Size(528, 92);
            this.memoLuuY.TabIndex = 19;
            // 
            // panInput
            // 
            this.panInput.Controls.Add(this.gcNV_X_LOGIN);
            this.panInput.Location = new System.Drawing.Point(0, 87);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(1193, 564);
            this.panInput.TabIndex = 20;
            // 
            // gcNV_X_LOGIN
            // 
            this.gcNV_X_LOGIN.DataSource = this.bdsNV_X_LOGIN;
            this.gcNV_X_LOGIN.Location = new System.Drawing.Point(12, 273);
            this.gcNV_X_LOGIN.MainView = this.gridView2;
            this.gcNV_X_LOGIN.MenuManager = this.barManager1;
            this.gcNV_X_LOGIN.Name = "gcNV_X_LOGIN";
            this.gcNV_X_LOGIN.Size = new System.Drawing.Size(596, 220);
            this.gcNV_X_LOGIN.TabIndex = 0;
            this.gcNV_X_LOGIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV1,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView2.GridControl = this.gcNV_X_LOGIN;
            this.gridView2.Name = "gridView2";
            // 
            // colMANV1
            // 
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 0;
            this.colMANV1.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            this.colTrangThaiXoa.Width = 94;
            // 
            // frmCreateAccout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 745);
            this.Controls.Add(this.memoLuuY);
            this.Controls.Add(this.gc_LGINFO1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grFormTaoLogin);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCreateAccout";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCreateAccout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV_X_LOGIN)).EndInit();
            this.grFormTaoLogin.ResumeLayout(false);
            this.grFormTaoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LGINFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_LGINFO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLuuY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panInput)).EndInit();
            this.panInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNV_X_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsNV_X_LOGIN;
        private DSTableAdapters.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter;
        private System.Windows.Forms.GroupBox grFormTaoLogin;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label nPass;
        private System.Windows.Forms.Button btnCreateLogin;
        private System.Windows.Forms.Label nName;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnCreateAccount;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bds_LGINFO;
        private DSTableAdapters.frmCreateLogin_GetLoginsOfBranchTableAdapter frmCreateLogin_GetLoginsOfBranchTableAdapter;
        private DevExpress.XtraGrid.GridControl gc_LGINFO1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colROLE;
        private DevExpress.XtraEditors.MemoEdit memoLuuY;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraEditors.TextEdit txtTrangThai;
        private DevExpress.XtraEditors.PanelControl panInput;
        private DevExpress.XtraGrid.GridControl gcNV_X_LOGIN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
    }
}