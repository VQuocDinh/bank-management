using DevExpress.XtraReports.UI;
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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (cmbLoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn loại báo cáo!!", "", MessageBoxButtons.OK);
                cmbLoai.Focus();
                return;
            }
            Xrpt_CustomerList rpt = new Xrpt_CustomerList(cmbLoai.Text.Substring(0, 1), cmbBranch.Text);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void frmLietKeKH_Load(object sender, EventArgs e)
        {
          
            this.dsChiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsChiNhanhTableAdapter.Fill(this.dS.dsChiNhanh);
            cmbBranch.SelectedIndex = Program.mChiNhanh;
            cmbBranch.Enabled = false;
            Xrpt_CustomerList rpt = new Xrpt_CustomerList(cmbLoai.Text,cmbBranch.Text);
            //rpt.xrLblChiNhanh.Text = cmbBranch.Text;
            if (Program.mGroup == "NGANHANG")
            {
                //cmbBranch.Enabled = true;
                cmbLoai.Enabled = true;
            }
            else
            {
                cmbLoai.Enabled = false;
                cmbLoai.Text = "Chi nhánh hiện tại";
            }

        }

        private void dsChiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
     
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*if (cmbBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbBranch.SelectedValue.ToString();
            if (cmbBranch.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                cmbLoai.Enabled = true;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0) MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);*/
        }

        private void dsChiNhanhBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dsChiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void cmbLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
