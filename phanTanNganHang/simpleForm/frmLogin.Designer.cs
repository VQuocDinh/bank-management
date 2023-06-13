namespace phanTanNganHang
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.nPass = new System.Windows.Forms.Label();
            this.nName = new System.Windows.Forms.Label();
            this.ChiNhanh = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDNThanhCong = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(943, 436);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblDNThanhCong);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.cmbChiNhanh);
            this.groupBox1.Controls.Add(this.nPass);
            this.groupBox1.Controls.Add(this.nName);
            this.groupBox1.Controls.Add(this.ChiNhanh);
            this.groupBox1.Location = new System.Drawing.Point(80, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 483);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(411, 268);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(361, 27);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(411, 213);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(361, 27);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(411, 157);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(361, 28);
            this.cmbChiNhanh.TabIndex = 3;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // nPass
            // 
            this.nPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nPass.AutoSize = true;
            this.nPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPass.Location = new System.Drawing.Point(295, 269);
            this.nPass.Name = "nPass";
            this.nPass.Size = new System.Drawing.Size(94, 23);
            this.nPass.TabIndex = 2;
            this.nPass.Text = "Mật Khẩu";
            // 
            // nName
            // 
            this.nName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nName.AutoSize = true;
            this.nName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nName.Location = new System.Drawing.Point(293, 214);
            this.nName.Name = "nName";
            this.nName.Size = new System.Drawing.Size(94, 23);
            this.nName.TabIndex = 1;
            this.nName.Text = "Tài khoản";
            // 
            // ChiNhanh
            // 
            this.ChiNhanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChiNhanh.AutoSize = true;
            this.ChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChiNhanh.Location = new System.Drawing.Point(293, 158);
            this.ChiNhanh.Name = "ChiNhanh";
            this.ChiNhanh.Size = new System.Drawing.Size(94, 23);
            this.ChiNhanh.TabIndex = 0;
            this.ChiNhanh.Text = "Chi nhánh";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDNThanhCong
            // 
            this.lblDNThanhCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDNThanhCong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNThanhCong.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDNThanhCong.Appearance.Options.UseFont = true;
            this.lblDNThanhCong.Appearance.Options.UseForeColor = true;
            this.lblDNThanhCong.Location = new System.Drawing.Point(490, 29);
            this.lblDNThanhCong.Margin = new System.Windows.Forms.Padding(4);
            this.lblDNThanhCong.Name = "lblDNThanhCong";
            this.lblDNThanhCong.Size = new System.Drawing.Size(185, 23);
            this.lblDNThanhCong.TabIndex = 6;
            this.lblDNThanhCong.Text = "Đăng nhập thành công";
            this.lblDNThanhCong.Visible = false;
            this.lblDNThanhCong.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 606);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label nPass;
        private System.Windows.Forms.Label nName;
        private System.Windows.Forms.Label ChiNhanh;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl lblDNThanhCong;
    }
}