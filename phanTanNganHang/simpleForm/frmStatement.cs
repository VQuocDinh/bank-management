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
    public partial class frmStatement : DevExpress.XtraEditors.XtraForm
    {
        string SoTKSaoKe = "";
        public frmStatement()
        {
            InitializeComponent();
        }



        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                //this.thongTinKH_TKSaoKeTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.thongTinKH_TKSaoKeTableAdapter.Fill(this.DS.ThongTinKH_TKSaoKe);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSoTaiKhoanKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được trống", "", MessageBoxButtons.OK);
                txtSoTaiKhoanKhachHang.Focus();
                textHoTenKhSk.Text = "";
                return;
            }
            if (Program.KetNoi() == 0) return;
            string strlenh = "EXEC frmStatement_TimTKSaoKe '" + txtSoTaiKhoanKhachHang.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("Số tài khoản không tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }
            textHoTenKhSk.Text = Program.myReader.GetString(0);
            teCMND.Text = Program.myReader.GetString(1);
            SoTKSaoKe = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
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
            XtraSaoKeTaiKhoan rpt = new XtraSaoKeTaiKhoan(SoTKSaoKe, batdau.DateTime, ketthuc.DateTime);
            rpt.batdau.Text = batdau.DateTime.ToString("dd/MM/yyyy");
            rpt.ketthuc.Text = ketthuc.DateTime.ToString("dd/MM/yyyy");
            rpt.XrName.Text = textHoTenKhSk.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            textHoTenKhSk.Text = teCMND.Text = txtSoTaiKhoanKhachHang.Text = batdau.Text = ketthuc.Text = "";
        }

        private void frmStatement_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "NGANHANG")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}