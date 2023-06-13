namespace phanTanNganHang.simpleForm
{
    partial class frmTransfer
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label sOTKLabel1;
            System.Windows.Forms.Label cMNDLabel1;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.lblChiNhanh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dS = new phanTanNganHang.DS();
            this.bdsKh = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new phanTanNganHang.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new phanTanNganHang.DSTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new phanTanNganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlGD = new DevExpress.XtraEditors.PanelControl();
            this.txtMaCNNhan = new DevExpress.XtraEditors.TextEdit();
            this.spSoTKNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoveEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintStaff = new DevExpress.XtraBars.BarCheckItem();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCMNDNhan = new DevExpress.XtraEditors.TextEdit();
            this.soTKNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTenNhan = new DevExpress.XtraEditors.TextEdit();
            this.sODUTextBox = new System.Windows.Forms.TextBox();
            this.cMNDTextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.txtSoTKChuyen = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNgayGD = new DevExpress.XtraEditors.DateEdit();
            this.nuSoTien = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spSoTKNhanTableAdapter = new phanTanNganHang.DSTableAdapters.spSoTKNhanTableAdapter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            label1 = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            sOTKLabel1 = new System.Windows.Forms.Label();
            cMNDLabel1 = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGD)).BeginInit();
            this.pnlGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoTKNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMNDNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTKNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(69, 172);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 22);
            label1.TabIndex = 6;
            label1.Text = "Họ và Tên:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(13, 303);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(71, 22);
            sOTIENLabel.TabIndex = 19;
            sOTIENLabel.Text = "Số tiền:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYGDLabel.Location = new System.Drawing.Point(13, 339);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(135, 22);
            nGAYGDLabel.TabIndex = 20;
            nGAYGDLabel.Text = "Ngày giao dịch:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(342, 303);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(122, 22);
            mANVLabel.TabIndex = 24;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(69, 140);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(113, 22);
            sOTKLabel.TabIndex = 29;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(94, 208);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(74, 22);
            cMNDLabel.TabIndex = 32;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(94, 244);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(63, 22);
            sODULabel.TabIndex = 33;
            sODULabel.Text = "Số dư:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(623, 176);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(86, 22);
            hOTENLabel.TabIndex = 34;
            hOTENLabel.Text = "Họ và tên";
            // 
            // sOTKLabel1
            // 
            sOTKLabel1.AutoSize = true;
            sOTKLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel1.Location = new System.Drawing.Point(592, 142);
            sOTKLabel1.Name = "sOTKLabel1";
            sOTKLabel1.Size = new System.Drawing.Size(113, 22);
            sOTKLabel1.TabIndex = 35;
            sOTKLabel1.Text = "Số tài khoản:";
            // 
            // cMNDLabel1
            // 
            cMNDLabel1.AutoSize = true;
            cMNDLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel1.Location = new System.Drawing.Point(631, 210);
            cMNDLabel1.Name = "cMNDLabel1";
            cMNDLabel1.Size = new System.Drawing.Size(74, 22);
            cMNDLabel1.TabIndex = 36;
            cMNDLabel1.Text = "CMND:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(588, 244);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(121, 22);
            mACNLabel.TabIndex = 37;
            mACNLabel.Text = "Mã chi nhánh:";
            mACNLabel.Click += new System.EventHandler(this.mACNLabel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cbbBranch);
            this.panelControl1.Controls.Add(this.lblChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1499, 54);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // cbbBranch
            // 
            this.cbbBranch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(120, 15);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(147, 30);
            this.cbbBranch.TabIndex = 1;
            this.cbbBranch.SelectedIndexChanged += new System.EventHandler(this.cbbBranch_SelectedIndexChanged);
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Appearance.Options.UseFont = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(12, 18);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(78, 22);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 23);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Chọn khách hàng";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 23);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Chọn tài khoản";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKh
            // 
            this.bdsKh.DataMember = "KhachHang";
            this.bdsKh.DataSource = this.dS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.dsChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = phanTanNganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.khachHangGridControl.DataSource = this.bdsKh;
            this.khachHangGridControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachHangGridControl.Location = new System.Drawing.Point(47, 49);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1447, 203);
            this.khachHangGridControl.TabIndex = 8;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.khachHangGridControl.Click += new System.EventHandler(this.khachHangGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
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
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsFilter.AllowFilter = false;
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKh;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taiKhoanGridControl.DataSource = this.bdsTK;
            this.taiKhoanGridControl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taiKhoanGridControl.Location = new System.Drawing.Point(21, 53);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(402, 318);
            this.taiKhoanGridControl.TabIndex = 8;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.taiKhoanGridControl.Click += new System.EventHandler(this.taiKhoanGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND1,
            this.colSODU,
            this.colMACN1});
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 25;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            this.colCMND1.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN1
            // 
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 25;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            this.colMACN1.Width = 94;
            // 
            // pnlGD
            // 
            this.pnlGD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGD.Controls.Add(mACNLabel);
            this.pnlGD.Controls.Add(this.txtMaCNNhan);
            this.pnlGD.Controls.Add(this.labelControl3);
            this.pnlGD.Controls.Add(cMNDLabel1);
            this.pnlGD.Controls.Add(this.txtCMNDNhan);
            this.pnlGD.Controls.Add(sOTKLabel1);
            this.pnlGD.Controls.Add(this.soTKNhan);
            this.pnlGD.Controls.Add(hOTENLabel);
            this.pnlGD.Controls.Add(this.txtHoTenNhan);
            this.pnlGD.Controls.Add(sODULabel);
            this.pnlGD.Controls.Add(this.sODUTextBox);
            this.pnlGD.Controls.Add(cMNDLabel);
            this.pnlGD.Controls.Add(this.cMNDTextBox);
            this.pnlGD.Controls.Add(this.tENTextBox);
            this.pnlGD.Controls.Add(this.hOTextBox);
            this.pnlGD.Controls.Add(sOTKLabel);
            this.pnlGD.Controls.Add(this.txtSoTKChuyen);
            this.pnlGD.Controls.Add(this.button2);
            this.pnlGD.Controls.Add(this.txtSoTKNhan);
            this.pnlGD.Controls.Add(this.labelControl6);
            this.pnlGD.Controls.Add(this.btnChuyen);
            this.pnlGD.Controls.Add(mANVLabel);
            this.pnlGD.Controls.Add(this.txtMaNV);
            this.pnlGD.Controls.Add(nGAYGDLabel);
            this.pnlGD.Controls.Add(this.txtNgayGD);
            this.pnlGD.Controls.Add(sOTIENLabel);
            this.pnlGD.Controls.Add(this.nuSoTien);
            this.pnlGD.Controls.Add(label1);
            this.pnlGD.Controls.Add(this.labelControl5);
            this.pnlGD.Controls.Add(this.labelControl4);
            this.pnlGD.Location = new System.Drawing.Point(497, 285);
            this.pnlGD.Name = "pnlGD";
            this.pnlGD.Size = new System.Drawing.Size(997, 371);
            this.pnlGD.TabIndex = 9;
            // 
            // txtMaCNNhan
            // 
            this.txtMaCNNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSoTKNhanBindingSource, "MACN", true));
            this.txtMaCNNhan.Location = new System.Drawing.Point(732, 241);
            this.txtMaCNNhan.MenuManager = this.barManager1;
            this.txtMaCNNhan.Name = "txtMaCNNhan";
            this.txtMaCNNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCNNhan.Properties.Appearance.Options.UseFont = true;
            this.txtMaCNNhan.Properties.ReadOnly = true;
            this.txtMaCNNhan.Size = new System.Drawing.Size(179, 28);
            this.txtMaCNNhan.TabIndex = 38;
            // 
            // spSoTKNhanBindingSource
            // 
            this.spSoTKNhanBindingSource.DataMember = "spSoTKNhan";
            this.spSoTKNhanBindingSource.DataSource = this.dS;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5,
            this.bar6,
            this.bar7});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.btnReload,
            this.btnUndo,
            this.btnExit,
            this.btnUpdate,
            this.btnChuyenNV,
            this.btnMoveEmployee,
            this.btnPrintStaff});
            this.barManager1.MainMenu = this.bar6;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar7;
            // 
            // bar5
            // 
            this.bar5.BarName = "Tools";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.FloatLocation = new System.Drawing.Point(181, 895);
            this.bar5.FloatSize = new System.Drawing.Size(46, 31);
            this.bar5.Offset = 460;
            this.bar5.Text = "Tools";
            this.bar5.Visible = false;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Id = 3;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 5;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar7
            // 
            this.bar7.BarName = "Status bar";
            this.bar7.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.DrawDragBorder = false;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Status bar";
            this.bar7.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1499, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 797);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1499, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 767);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1499, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 767);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Hiệu chỉnh";
            this.btnUpdate.Id = 6;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnChuyenNV
            // 
            this.btnChuyenNV.Caption = "Chuyển nhân viên";
            this.btnChuyenNV.Id = 7;
            this.btnChuyenNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenNV.ImageOptions.Image")));
            this.btnChuyenNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenNV.ImageOptions.LargeImage")));
            this.btnChuyenNV.Name = "btnChuyenNV";
            // 
            // btnMoveEmployee
            // 
            this.btnMoveEmployee.Caption = "Chuyển Nhân Viên";
            this.btnMoveEmployee.Id = 8;
            this.btnMoveEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveEmployee.ImageOptions.Image")));
            this.btnMoveEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoveEmployee.ImageOptions.LargeImage")));
            this.btnMoveEmployee.Name = "btnMoveEmployee";
            // 
            // btnPrintStaff
            // 
            this.btnPrintStaff.Caption = "In danh sách nhân viên";
            this.btnPrintStaff.Id = 9;
            this.btnPrintStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintStaff.ImageOptions.Image")));
            this.btnPrintStaff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintStaff.ImageOptions.LargeImage")));
            this.btnPrintStaff.Name = "btnPrintStaff";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 23);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Chuyển tiền";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtCMNDNhan
            // 
            this.txtCMNDNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSoTKNhanBindingSource, "CMND", true));
            this.txtCMNDNhan.Location = new System.Drawing.Point(732, 207);
            this.txtCMNDNhan.MenuManager = this.barManager1;
            this.txtCMNDNhan.Name = "txtCMNDNhan";
            this.txtCMNDNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDNhan.Properties.Appearance.Options.UseFont = true;
            this.txtCMNDNhan.Properties.ReadOnly = true;
            this.txtCMNDNhan.Size = new System.Drawing.Size(179, 28);
            this.txtCMNDNhan.TabIndex = 37;
            // 
            // soTKNhan
            // 
            this.soTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSoTKNhanBindingSource, "SOTK", true));
            this.soTKNhan.Location = new System.Drawing.Point(732, 139);
            this.soTKNhan.MenuManager = this.barManager1;
            this.soTKNhan.Name = "soTKNhan";
            this.soTKNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTKNhan.Properties.Appearance.Options.UseFont = true;
            this.soTKNhan.Properties.ReadOnly = true;
            this.soTKNhan.Size = new System.Drawing.Size(179, 28);
            this.soTKNhan.TabIndex = 36;
            // 
            // txtHoTenNhan
            // 
            this.txtHoTenNhan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSoTKNhanBindingSource, "HOTEN", true));
            this.txtHoTenNhan.Location = new System.Drawing.Point(732, 173);
            this.txtHoTenNhan.MenuManager = this.barManager1;
            this.txtHoTenNhan.Name = "txtHoTenNhan";
            this.txtHoTenNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNhan.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenNhan.Properties.ReadOnly = true;
            this.txtHoTenNhan.Size = new System.Drawing.Size(179, 28);
            this.txtHoTenNhan.TabIndex = 35;
            // 
            // sODUTextBox
            // 
            this.sODUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SODU", true));
            this.sODUTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sODUTextBox.Location = new System.Drawing.Point(193, 241);
            this.sODUTextBox.Name = "sODUTextBox";
            this.sODUTextBox.ReadOnly = true;
            this.sODUTextBox.Size = new System.Drawing.Size(125, 30);
            this.sODUTextBox.TabIndex = 34;
            // 
            // cMNDTextBox
            // 
            this.cMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKh, "CMND", true));
            this.cMNDTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDTextBox.Location = new System.Drawing.Point(193, 205);
            this.cMNDTextBox.Name = "cMNDTextBox";
            this.cMNDTextBox.ReadOnly = true;
            this.cMNDTextBox.Size = new System.Drawing.Size(125, 30);
            this.cMNDTextBox.TabIndex = 33;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKh, "TEN", true));
            this.tENTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENTextBox.Location = new System.Drawing.Point(256, 169);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.ReadOnly = true;
            this.tENTextBox.Size = new System.Drawing.Size(62, 30);
            this.tENTextBox.TabIndex = 32;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKh, "HO", true));
            this.hOTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTextBox.Location = new System.Drawing.Point(193, 169);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.ReadOnly = true;
            this.hOTextBox.Size = new System.Drawing.Size(57, 30);
            this.hOTextBox.TabIndex = 31;
            // 
            // txtSoTKChuyen
            // 
            this.txtSoTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.txtSoTKChuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTKChuyen.Location = new System.Drawing.Point(193, 137);
            this.txtSoTKChuyen.Name = "txtSoTKChuyen";
            this.txtSoTKChuyen.ReadOnly = true;
            this.txtSoTKChuyen.Size = new System.Drawing.Size(125, 30);
            this.txtSoTKChuyen.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(827, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTKNhan.Location = new System.Drawing.Point(611, 14);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.Size = new System.Drawing.Size(198, 30);
            this.txtSoTKNhan.TabIndex = 28;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(324, 17);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(233, 22);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Nhập số tài khoản người nhận";
            // 
            // btnChuyen
            // 
            this.btnChuyen.Enabled = false;
            this.btnChuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.Location = new System.Drawing.Point(802, 332);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(109, 34);
            this.btnChuyen.TabIndex = 26;
            this.btnChuyen.Text = "Chuyển tiền";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(491, 300);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(87, 30);
            this.txtMaNV.TabIndex = 25;
            // 
            // txtNgayGD
            // 
            this.txtNgayGD.EditValue = null;
            this.txtNgayGD.Location = new System.Drawing.Point(171, 336);
            this.txtNgayGD.Name = "txtNgayGD";
            this.txtNgayGD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGD.Properties.Appearance.Options.UseFont = true;
            this.txtNgayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayGD.Properties.ReadOnly = true;
            this.txtNgayGD.Size = new System.Drawing.Size(386, 28);
            this.txtNgayGD.TabIndex = 21;
            // 
            // nuSoTien
            // 
            this.nuSoTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nuSoTien.Location = new System.Drawing.Point(171, 300);
            this.nuSoTien.Name = "nuSoTien";
            this.nuSoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuSoTien.Properties.Appearance.Options.UseFont = true;
            this.nuSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nuSoTien.Size = new System.Drawing.Size(142, 28);
            this.nuSoTien.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(584, 99);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(166, 22);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Thông tin người nhận";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(70, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(184, 22);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Thông tin người chuyển";
            // 
            // spSoTKNhanTableAdapter
            // 
            this.spSoTKNhanTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pnlGD);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.khachHangGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 84);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1499, 713);
            this.panelControl2.TabIndex = 20;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl3.Controls.Add(this.taiKhoanGridControl);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Location = new System.Drawing.Point(47, 285);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(444, 378);
            this.panelControl3.TabIndex = 21;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 817);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGD)).EndInit();
            this.pnlGD.ResumeLayout(false);
            this.pnlGD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCNNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoTKNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMNDNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTKNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbBranch;
        private DevExpress.XtraEditors.LabelControl lblChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsKh;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraEditors.PanelControl pnlGD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraEditors.DateEdit txtNgayGD;
        private DevExpress.XtraEditors.SpinEdit nuSoTien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSoTKNhan;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtSoTKChuyen;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox sODUTextBox;
        private System.Windows.Forms.TextBox cMNDTextBox;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnMoveEmployee;
        private DevExpress.XtraBars.BarCheckItem btnPrintStaff;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnChuyenNV;
        private DSTableAdapters.NguoiNhanTienTableAdapter nguoiNhanTienTableAdapter;
        private System.Windows.Forms.BindingSource spSoTKNhanBindingSource;
        private DSTableAdapters.spSoTKNhanTableAdapter spSoTKNhanTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaCNNhan;
        private DevExpress.XtraEditors.TextEdit txtCMNDNhan;
        private DevExpress.XtraEditors.TextEdit soTKNhan;
        private DevExpress.XtraEditors.TextEdit txtHoTenNhan;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}