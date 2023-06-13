using DevExpress.XtraEditors;
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
    public partial class AcountListing : DevExpress.XtraEditors.XtraForm
    {
        public AcountListing()
        {
            InitializeComponent();
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCN.SelectedValue.ToString();
            if (cmbCN.SelectedIndex != Program.mChiNhanh)
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
        }

        private void AcountListing_Load(object sender, EventArgs e)
        {
            cmbCN.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmbCN.Enabled = true;
            }
            else
            {
                cmbLoai.Text = "Chi nhánh hiện tại";
                cmbLoai.Enabled = false;
                cmbCN.Enabled = false;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (batdau.DateTime > DateTime.Now || batdau.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu trống hoặc mốc thời gian là trước hiện tại", "", MessageBoxButtons.OK);
                batdau.Focus();
                return;
            }
            if (ketthuc.DateTime > DateTime.Now || ketthuc.Text.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc trống hoặc mốc thời gian là trước hiện tại", "", MessageBoxButtons.OK);
                ketthuc.Focus();
                return;
            }
            XtraLietKeTaiKhoan rpt = new XtraLietKeTaiKhoan(batdau.DateTime, ketthuc.DateTime, cmbLoai.Text.Substring(0, 1), cmbCN.Text);
            rpt.batdau.Text = batdau.DateTime.ToString("dd/MM/yyyy");
            rpt.ketthuc.Text = ketthuc.DateTime.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batdau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ketthuc_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}