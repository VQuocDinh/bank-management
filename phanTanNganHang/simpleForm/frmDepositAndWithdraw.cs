using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanTanNganHang.simpleForm
{
    public partial class frmDepositAndWithdraw : Form
    {
        int vitri = 0;
        public frmDepositAndWithdraw()
        {
            InitializeComponent();
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDepositAndWithdraw_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            cmbBranch.DataSource = Program.bds_dspm;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.mChiNhanh;
            pnlGD.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                cmbBranch.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                cmbBranch.Enabled = false;
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void lOAIGDLabel_Click(object sender, EventArgs e)
        {

        }

        private void lOAIGDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbBranch.SelectedValue.ToString();
            if (cmbBranch.SelectedIndex != Program.mChiNhanh)
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
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = btnAdd.Enabled = false;
            pnlGD.Enabled = true;
            txtMaNV.EditValue = Program.username;
           // txtSOTK.EditValue = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            vitri = bdsTK.Position;
        }

        private void gD_GOIRUTGridControl_Click(object sender, EventArgs e)
        {

        }

        private void txtSoTK_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.CancelEdit();
            if (btnAdd.Enabled == false) bdsTK.Position = vitri;
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = true;
            pnlGD.Enabled = false;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // txtSOTK.EditValue = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();

            String dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            String loaiGD = (cmbLoaiGD.SelectedIndex == 0) ? "GT" : "RT";
            if (loaiGD == "")
            {
                MessageBox.Show("Bạn chưa chọn loại giao dịch", "", MessageBoxButtons.OK);
            }
            if (txtSoTien.Value < 100000)
            {
                MessageBox.Show("Số tiền giao dịch thấp nhất là 100.000vnđ\nBạn hãy nhập lại...", "", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }

            if (loaiGD == "RT" && Convert.ToDecimal(sODUTextBox.Text) - txtSoTien.Value < 50000)
            {
                MessageBox.Show("Số dư trong tài khoản không đủ", "", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }

            Program.ExecSqlNoneQuery("EXEC spGuiRutTien '" + txtSoTK.Text + "','" + loaiGD + "','" + dt + "','" + txtSoTien.Text + "','" + txtMaNV.Text + "'");
            MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dS.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = btnAdd.Enabled = true;
            pnlGD.Enabled = false;
            bdsTK.Position = vitri;
        
            
        }
    }
}
