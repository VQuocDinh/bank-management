using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanTanNganHang.simpleForm
{
    public partial class frmSatff : Form
    {
        string macn = "";
        int vitri = 0;
        bool btnAddClicked = false;
        bool btnUpdateClick = false;
        public frmSatff()
        {
            InitializeComponent();
        }


        private void frmSatff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.dsChiNhanh' table. You can move, or remove it, as needed.
            this.dsChiNhanhTableAdapter.Fill(this.dS.dsChiNhanh);
            dS.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            if (bdsNV.Count > 0)
            {
                macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
            else
            {
                macn = cbbBranch.Text;
            }
            
            cbbBranch.DataSource = Program.bds_dspm;
            cbbBranch.DisplayMember = "TENCN";
            cbbBranch.ValueMember = "TENSERVER";
            cbbBranch.SelectedIndex = Program.mChiNhanh;


            
            panelControl2.Enabled = btnUndo.Enabled = btnSave.Enabled = cmbCNChuyen.Enabled = btnMoveEmployee.Enabled = txtMaNVMoi.Enabled =btnChuyen.Enabled = false;
            if (Program.mGroup == "NGANHANG")
            {
                cbbBranch.Enabled = true;
                btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnMoveEmployee.Enabled = false;

                
            }
            else
            {

                cbbBranch.Enabled = false;
                btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnMoveEmployee.Enabled = true;

            }
        }


        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void cMNDLabel_Click(object sender, EventArgs e)
        {

        }

        private void cbTrangThaiXoa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            bdsNV.AddNew();
            txtMaCN.Text = macn;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcNV.Enabled = false;
            btnAddClicked = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnAdd.Enabled == false) bdsNV.Position = vitri;
            gcNV.Enabled = true;
            panelControl2.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            btnAddClicked = false;
            cmbCNChuyen.Enabled = btnChuyen.Enabled = txtMaNVMoi.Enabled = false;

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            gcNV.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnUpdateClick = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reload Error:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)

        {
            String manv = "";
            if (bdsGR.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên, vì đã thực hiện giao dịch gửi rút tiền cho khách hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCT.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên, vì đã thực hiện giao dịch chuyển tiền cho khách hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá nhân viên " + manv + " ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString().TrimEnd();
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    MessageBox.Show("Xoá thành công nhân viên " + manv, "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá nhân viên. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnDelete.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString().TrimEnd();
            
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được trống", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được trống", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được trống", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (!txtSoDT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "", MessageBoxButtons.OK);
                txtSoDT.Focus();
                return;
            }
            if (txtSoDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại nhân viên không đúng 10 chữ số", "", MessageBoxButtons.OK);
                txtSoDT.Focus();
                return;
            }
            if (cmbPhai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phái", "", MessageBoxButtons.OK);
                cmbPhai.Focus();
                return;
            }
            if (btnUpdateClick == true && manv != txtMaNV.Text.TrimEnd())
            {
                MessageBox.Show("Không được thay đổi mã nhân viên", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (btnAddClicked == true)
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC spDuplicateMaNV '" + txtMaNV.Text.TrimEnd() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
            }
            try
            {
                bdsNV.EndEdit(); //kết thúc quá trình hiệu chỉnh (ghi vào datasource)
                bdsNV.ResetCurrentItem();//đưa thông tin lên lưới
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                MessageBox.Show("Lưu thành công!!", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNV.Enabled = true;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnMoveEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            btnUndo.Enabled = btnExit.Enabled = cmbCNChuyen.Enabled = btnChuyen.Enabled = txtMaNVMoi.Enabled = true;
            panelControl2.Enabled = btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnSave.Enabled = gcNV.Enabled = false;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            vitri = bdsNV.Position;
            string manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString().TrimEnd();
            string trangthaixoa = ((DataRowView)bdsNV[bdsNV.Position])["TrangThaiXoa"].ToString().TrimEnd();
            string MACN = cmbCNChuyen.SelectedValue.ToString();

            if(trangthaixoa == "1")
            {
                MessageBox.Show("Nhân viên này đã xóa", "", MessageBoxButtons.OK);
       
                return;
            }
            if (cmbCNChuyen.SelectedIndex == Program.mChiNhanh)
            {
                MessageBox.Show("Chi nhánh chuyển đi phải khác chi nhánh ban đầu", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMaNVMoi.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            else
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC spDuplicateMaNV '" + txtMaNVMoi.Text.TrimEnd() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
            }
            
            if (manv.ToString().TrimEnd().Equals(Program.username.TrimEnd()))
            {
                MessageBox.Show("Không thể chuyển chính bạn sang chi nhánh khác, hãy nhờ nhân viên khác", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn muốn chuyển nhân viên " + manv + " sang chi nhánh " + MACN + "??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.ExecSqlNoneQuery("EXEC spChuyenNV '" + manv + "','" + MACN + "','" + txtMaNVMoi.Text.TrimEnd() + "'");
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = gcNV.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = cmbCNChuyen.Enabled = btnChuyen.Enabled = txtMaNVMoi.Enabled = false;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

        }

        private void cmbCNChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCNChuyen_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }


}



