using DevExpress.XtraCharts.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanTanNganHang.simpleForm
{
    public partial class frmTransfer : Form
    {
        int vitri = 0;
        string macn = "";
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbBranch.SelectedValue.ToString();
            if (cbbBranch.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0) MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);

                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKh.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);

            String dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            txtMaNV.Text = Program.username;
            txtNgayGD.Text = dt;


            macn = ((DataRowView)bdsKh[0])["MACN"].ToString();
            cbbBranch.DataSource = Program.bds_dspm;
            cbbBranch.DisplayMember = "TENCN";
            cbbBranch.ValueMember = "TENSERVER";
            cbbBranch.SelectedIndex = Program.mChiNhanh;
            pnlGD.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                cbbBranch.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                cbbBranch.Enabled = false;
            }
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if(nuSoTien.Value < 100000)
            {
                MessageBox.Show("Số tiền giao dịch thấp nhất là 100.000vnđ\nBạn hãy nhập lại...", "", MessageBoxButtons.OK);
                nuSoTien.Focus();
                return;
            }

            if (Convert.ToDecimal(sODUTextBox.Text) - nuSoTien.Value < 50000)
            {
                MessageBox.Show("Số dư trong tài khoản không đủ", "", MessageBoxButtons.OK);
                nuSoTien.Focus();
                return;
            }

            String dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            if (txtSoTKChuyen.Text == soTKNhan.Text)
            {
                MessageBox.Show("Số tài khoản nhận phải khác số tài khoản chuyển \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Xác nhận thực hiện giao dịch", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.ExecSqlNoneQuery("EXEC SP_Chuyen_Tien '" + txtSoTKChuyen.Text + "','" + soTKNhan.Text + "','" + nuSoTien.Value + "','" + dt + "','" + Program.username + "'");
                    MessageBox.Show("Chuyển tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            dS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = true;
            txtHoTenNhan.Text = txtCMNDNhan.Text = txtSoTKNhan.Text = txtMaCNNhan.Text = "";
            pnlGD.Enabled = false;
            bdsTK.Position = vitri;



        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                this.spSoTKNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.spSoTKNhanTableAdapter.Fill(this.dS.spSoTKNhan, txtSoTKNhan.Text);
                btnChuyen.Enabled = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = false;
            pnlGD.Enabled = true;
            txtMaNV.Text = Program.username;
            //txtSoTKChuyen.Text = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            vitri = bdsTK.Position;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.Position = vitri;
            bdsTK.CancelEdit();//hai trường hợp: đang thêm bỏ thêm, đang sửa bỏ sửa
            pnlGD.Enabled = false;
            khachHangGridControl.Enabled = taiKhoanGridControl.Enabled = true;
            txtHoTenNhan.Text = cMNDTextBox.Text = txtSoTKNhan.Text = txtMaCNNhan.Text = "";
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
