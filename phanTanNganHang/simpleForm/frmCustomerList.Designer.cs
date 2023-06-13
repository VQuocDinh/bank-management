namespace phanTanNganHang.simpleForm
{
    partial class frmCustomerList
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.dsChiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new phanTanNganHang.DS();
            this.lblChiNhanh = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dsChiNhanhTableAdapter = new phanTanNganHang.DSTableAdapters.dsChiNhanhTableAdapter();
            this.tableAdapterManager = new phanTanNganHang.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dsChiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(198, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Loại";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(267, 148);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(114, 35);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xem trước";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Tất cả chi nhánh",
            "Chi nhánh hiện tại"});
            this.cmbLoai.Location = new System.Drawing.Point(267, 87);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(243, 30);
            this.cmbLoai.TabIndex = 16;
            this.cmbLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLoai_SelectedIndexChanged_1);
            // 
            // cmbBranch
            // 
            this.cmbBranch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBranch.DataSource = this.dsChiNhanhBindingSource;
            this.cmbBranch.DisplayMember = "TENCN";
            this.cmbBranch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(267, 26);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(243, 30);
            this.cmbBranch.TabIndex = 18;
            this.cmbBranch.ValueMember = "MACN";
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged_1);
            // 
            // dsChiNhanhBindingSource
            // 
            this.dsChiNhanhBindingSource.DataMember = "dsChiNhanh";
            this.dsChiNhanhBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChiNhanh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNhanh.Appearance.Options.UseFont = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(166, 29);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(78, 22);
            this.lblChiNhanh.TabIndex = 17;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl1.Controls.Add(this.cmbLoai);
            this.panelControl1.Controls.Add(this.cmbBranch);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.lblChiNhanh);
            this.panelControl1.Controls.Add(this.btnXacNhan);
            this.panelControl1.Location = new System.Drawing.Point(153, 110);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(673, 201);
            this.panelControl1.TabIndex = 19;
            // 
            // dsChiNhanhTableAdapter
            // 
            this.dsChiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.dsChiNhanhTableAdapter = this.dsChiNhanhTableAdapter;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = phanTanNganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 429);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCustomerList";
            this.Text = "frmLietKeKH";
            this.Load += new System.EventHandler(this.frmLietKeKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsChiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.ComboBox cmbBranch;
        private DevExpress.XtraEditors.LabelControl lblChiNhanh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource dsChiNhanhBindingSource;
        private DSTableAdapters.dsChiNhanhTableAdapter dsChiNhanhTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}