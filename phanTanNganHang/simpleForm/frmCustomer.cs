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
    public partial class frmCustomer : Form
    {
        string macn = "";
        int vitri = 0;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnPrintStaff_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            cbbBranch.DataSource = Program.bds_dspm;
            cbbBranch.DisplayMember = "TENCN";
            cbbBranch.ValueMember = "TENSERVER";
            cbbBranch.SelectedIndex = Program.mChiNhanh;
            this.khachhangTableAdapter.Connection.ConnectionString = Program.connstr;

            this.khachhangTableAdapter.Fill(this.dS.KhachHang);

        }

        private void hOTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Int32 manv = 0;
            if (bdsKH.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên, vì đã thực hiện giao dịch gửi rút tiền cho khách hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsKH.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên, vì đã thực hiện giao dịch chuyển tiền cho khách hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá nhân viên " + manv + " ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsKH[bdsKH.Position])["MANV"].ToString().TrimEnd());
                    bdsKH.RemoveCurrent();
                    this.khachhangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachhangTableAdapter.Update(this.dS.KhachHang);
                    MessageBox.Show("Xoá thành công nhân viên " + manv, "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá nhân viên. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khachhangTableAdapter.Fill(this.dS.KhachHang);
                    bdsKH.Position = bdsKH.Find("MANV", manv);
                    return;
                }
            }
            if (bdsKH.Count == 0) btnDelete.Enabled = false;
        }



        private void sODTTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bdsKH_CurrentChanged(object sender, EventArgs e)
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
                this.khachhangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachhangTableAdapter.Fill(this.dS.KhachHang);

                this.khachhangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachhangTableAdapter.Fill(this.dS.KhachHang);

                this.khachhangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachhangTableAdapter.Fill(this.dS.KhachHang);
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void nGAYCAPDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            panelControl2.Enabled = true;
            bdsKH.AddNew();

            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            khachHangGridControl.Enabled = false;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            panelControl2.Enabled = true;
            khachHangGridControl.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String CMND = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            if (cMNDTextBox.Text.Length != 10)
            {
                MessageBox.Show("CMND của khách hàng không đúng định dạng (10 số)", "", MessageBoxButtons.OK);
                cMNDTextBox.Focus();
                return;
            }
            if (cMNDTextBox.Text.Trim() == "")
            {
                MessageBox.Show("CMND của khách hàng không được trống", "", MessageBoxButtons.OK);
                cMNDTextBox.Focus();
                return;
            }
            if (nGAYCAPDateEdit.DateTime > DateTime.Now || nGAYCAPDateEdit.Text.Trim() == "")
            {
                MessageBox.Show("Ngày cấp CMND khách hàng trống hoặc mốc thời gian là trước hiện tại", "", MessageBoxButtons.OK);
                nGAYCAPDateEdit.Focus();
                return;
            }
            if (hOTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng  không được trống", "", MessageBoxButtons.OK);
                hOTextEdit.Focus();
                return;
            }
            if (tENTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được trống", "", MessageBoxButtons.OK);
                tENTextEdit.Focus();
                return;
            }
            if (tENTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "", MessageBoxButtons.OK);
                dIACHITextEdit.Focus();
                return;
            }
            if (!sODTTextEdit.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "", MessageBoxButtons.OK);
                sODTTextEdit.Focus();
                return;
            }
            if (sODTTextEdit.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại khách hàng  không đúng 10 chữ số", "", MessageBoxButtons.OK);
                sODTTextEdit.Focus();
                return;
            }
            bool btnAdd = false;
            // Kiểm tra cmnd tồn tại trên site chủ
            //viết 1 SP kiểm tra mã trùng. gọi SP đó thông qua hàm ExecSqlDataReader dưới dạng có hay không!! 
            if (btnAdd == true || CMND != cMNDTextBox.Text)//khi click update, MANV mới khác với MANV cũ thì kiểm tra có trùng MANV không
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC frmKhachHang_DuplicateCMND '" + cMNDTextBox.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("CMND khách hàng đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();
            }
        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pHAITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btnAdd.Enabled == false) bdsKH.Position = vitri;
            khachHangGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachhangTableAdapter.Fill(this.dS.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reload Error:" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}