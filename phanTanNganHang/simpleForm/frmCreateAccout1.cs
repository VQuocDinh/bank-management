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
   

    public partial class frmCreateAccout1 : Form




    {
        int vitri = 0; string macn = "";bool btn_Add_clicked = false;


        public frmCreateAccout1()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmCreateAccout_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            {
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.DS.frmCreateLogin_GetEmployeeNotHaveLogin);
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.DS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
                //macn = ((DataRowView)bdsNV_X_LOGIN[0])["MACN"].ToString();
                cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
                cmbChiNhanh.DisplayMember = "TENCN";
                cmbChiNhanh.ValueMember = "TENSERVER";
                cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
                //gc_LGINFO1.Enabled = true;
                grFormTaoLogin.Enabled = false;
                cmbChiNhanh.Enabled = false;
                /*if (Program.mGroup == "NganHang")
                {
                    memoLuuY.EditValue += "Tài khoản có thể: \r\n";
                    memoLuuY.EditValue += "- Xem các báo cáo trên tất cả chi nhánh\r\n";
                    memoLuuY.EditValue += "- Tra cứu dữ liệu trên tất cả chi nhánh\r\n";
                    memoLuuY.EditValue += "- Tạo tài khoản đăng nhập hệ thống thuộc cùng nhóm (NGANHANG)";
                }
                else
                {
                    btnCreateAccount.Enabled = cmsXOA.Enabled = true;
                    memoLuuY.EditValue += "Tài khoản có thể: \r\n";
                    memoLuuY.EditValue += "- Toàn quyền cập nhật dữ liệu trên chi nhánh thuộc về\r\n";
                    memoLuuY.EditValue += "- Tra cứu dữ liệu trên chi nhánh thuộc về\r\n";
                    memoLuuY.EditValue += "- Tạo tài khoản đăng nhập hệ thống thuộc cùng nhóm (CHINHANH)";
                }*/
                //Reload();
            }

        }
        

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool CHECK_LOGIN_TRUNG(string txtLoginName)
        {
            Program.myReader.Close();
            string strlenh1 = "EXEC frmCreateLogin_DuplicateLOGIN '" + txtLoginName + "','" + Program.mGroup + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh1);
            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {
                return true;
            }
            return false;
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {
            string MANV = ((DataRowView)bdsNV_X_LOGIN[bdsNV_X_LOGIN.Position])["MANV"].ToString();
            if (txtLoginName.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (CHECK_LOGIN_TRUNG(txtLoginName.Text))
            {
                MessageBox.Show("TÊN LOGIN đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();
            string cmd = "EXEC frmCreateLogin_CreateLoginForEmployee '" + txtLoginName.Text + "','" + txtPass.Text + "','" + MANV + "','" + Program.mGroup + "'";
            Program.ExecSqlNoneQuery(cmd);

            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.DS.frmCreateLogin_GetEmployeeNotHaveLogin);
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.DS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
            grFormTaoLogin.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grFormTaoLogin_Enter(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV_X_LOGIN.CancelEdit();
            if (btnAdd.Enabled == false) bdsNV_X_LOGIN.Position = vitri;
            nhanVienGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)bdsNV_X_LOGIN[bdsNV_X_LOGIN.Position])["MANV"].ToString().TrimEnd();
            if (txtLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được trống", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            if (btn_Add_clicked == true || manv != txtLoginName.Text.TrimEnd())
             {
                 Program.myReader.Close();
                 string strlenh1 = "EXEC frmNhanVien_duplicateMANV '" + txtLoginName.Text.TrimEnd() + "'";
                 Program.myReader = Program.ExecSqlDataReader(strlenh1);
                 Program.myReader.Read();
                 if (Program.myReader.HasRows)
                 {
                     MessageBox.Show("Mã nhân viên đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                     return;
                 }
             }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsNV_X_LOGIN.Position;
            panelControl2.Enabled = true;
            nhanVienGridControl.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsNV_X_LOGIN.Position;
            panelControl2.Enabled = true;
            bdsNV_X_LOGIN.AddNew();
            txtLoginName.Text = macn;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            nhanVienGridControl.Enabled = false;

        }

        private void bdsNV_X_LOGIN_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateLoginGetLoginsOfBranchBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reload Error:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void frmCreateLogin_GetEmployeeNotHaveLogin1GridControl_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateLogin_GetEmployeeNotHaveLogin1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void nName_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateLogin_GetEmployeeNotHaveLoginGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
