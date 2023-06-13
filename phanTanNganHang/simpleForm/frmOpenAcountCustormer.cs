using DevExpress.XtraEditors;
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
    public partial class frmOpenAcountCustormer : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        bool btn_Edit_clicked = false;
        public frmOpenAcountCustormer()
        {
            InitializeComponent();
        }

        private void frmOpenAcountCustormer_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            btnMoveEmployee.Enabled = btnPrintStaff.Enabled = btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled  = btnSave.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtCMNDKhachHang.Text.Trim() == "" || txtCMNDKhachHang.Text.Trim().Length < 10)
            {
                MessageBox.Show("Số chứng minh nhân dân không được trống và đủ 10 số", "", MessageBoxButtons.OK);
                txtCMNDKhachHang.Focus();
                txtCMND.Text = "";
                return;
            }
            if (Program.KetNoi() == 0) return;
            string strlenh = "EXEC frmOpenAcountCustormer_ThongTinKhachHang '" + txtCMNDKhachHang.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("Số tài khoản không tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }
            txtCMND.Text = Program.myReader.GetString(0);
            txtHOTEN.Text = Program.myReader.GetString(1);
            txtMACN.Text = Program.myReader.GetString(2);
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
            pnlThongTinTaiKhoan.Enabled = grbThongTinKH.Enabled = true;
            this.frmOpenAcountCustormer_DSTKKHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.frmOpenAcountCustormer_DSTKKHTableAdapter.Fill(this.dS.frmOpenAcountCustormer_DSTKKH,txtCMNDKhachHang.Text, cmbChiNhanh.Text);
            if (Bds_DSTKKH.Count == 0) btnDelete.Enabled = false;
            Program.myReader.Close();
            Program.conn.Close();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String SOTK = ((DataRowView)Bds_DSTKKH[Bds_DSTKKH.Position])["SOTK"].ToString().TrimEnd();
            if (Bds_GR.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản ngân hàng, vì đã thực hiện giao dịch gửi rút tiền ", "", MessageBoxButtons.OK);
                return;
            }
            if (Bds_TK_NC.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản ngân hàng, vì đã thực hiện giao dịch chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (Bds_TK_NN.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản ngân hàng, vì đã thực hiện giao dịch nhận tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá tài khoản " + SOTK + " ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.myReader.Close();
                    Program.ExecSqlNoneQuery("EXEC frmOpenAcountCustormer_XoaTKKhachHang  '" + SOTK + "'");
                    this.frmOpenAcountCustormer_DSTKKHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.frmOpenAcountCustormer_DSTKKHTableAdapter.Fill(this.dS.frmOpenAcountCustormer_DSTKKH, txtCMNDKhachHang.Text, cmbChiNhanh.Text);
                    MessageBox.Show("Bạn đã xoá tài khoản " + SOTK + " thành công" , "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá tài khoản. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.frmOpenAcountCustormer_DSTKKHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.frmOpenAcountCustormer_DSTKKHTableAdapter.Fill(this.dS.frmOpenAcountCustormer_DSTKKH, txtCMNDKhachHang.Text, cmbChiNhanh.Text);
                    return;
                }
            }
            if (Bds_DSTKKH.Count == 0) btnDelete.Enabled = false; //hết tài khoản rồi thì k xoá đc nữa

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.frmOpenAcountCustormer_DSTKKHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmOpenAcountCustormer_DSTKKHTableAdapter.Fill(this.dS.frmOpenAcountCustormer_DSTKKH, txtCMNDKhachHang.Text, cmbChiNhanh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            pnlThongTinTaiKhoan.Enabled = DSTKKH.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = btnExit.Enabled = true;
            txtMACNSet.Text = cmbChiNhanh.Text;
            teCMND.Text = txtCMNDKhachHang.Text;
            grMoTK.Enabled = true;
            Program.myReader.Close();
            Program.conn.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btn_Edit_clicked == true)
            {
                if (sOTK.Text.Trim() == "" || sOTK.Text.Length < 9)
                {
                    MessageBox.Show("Số tài khoản không được trống và đủ 9 số", "", MessageBoxButtons.OK);
                    sOTK.Focus();
                    return;
                }
                if (sODU.Value <= 0)
                {
                    MessageBox.Show("Số dư không được trống hoặc bằng 0", "", MessageBoxButtons.OK);
                    sODU.Focus();
                    return;
                }
                Program.ExecSqlNoneQuery("EXEC frmOpenAcountCustormer_MoTKKH '" + this.sOTK.Text.TrimEnd() + "','" + cMND.Text + "','" + sODU.Value + "','" + mACN.Text + "'");
                this.frmOpenAcountCustormer_ThongTinKhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmOpenAcountCustormer_ThongTinKhachHangTableAdapter.Fill(this.dS.frmOpenAcountCustormer_ThongTinKhachHang, txtCMNDKhachHang.Text);
                btn_Edit_clicked = false;
            }
            else
            {
                if (txtSOTK.Text.Trim() == "" || txtSOTK.Text.Length < 9)
                {
                    MessageBox.Show("Số tài khoản không được trống", "", MessageBoxButtons.OK);
                    txtSOTK.Focus();
                    return;
                }
                if (numbSODU.Value < 50000)
                {
                    MessageBox.Show("Số dư không được dưới 50000", "", MessageBoxButtons.OK);
                    numbSODU.Focus();
                    return;
                }
                Program.myReader.Close();
                string strlenh1 = "EXEC frmOpenAcountCustormer_HasAcount '" + txtSOTK.Text.TrimEnd() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();
                Program.ExecSqlNoneQuery("EXEC frmOpenAcountCustormer_MoTKKH '" + txtSOTK.Text.TrimEnd() + "','" + teCMND.Text + "','" + numbSODU.Value + "','" + txtMACNSet.Text + "'");
                this.frmOpenAcountCustormer_ThongTinKhachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmOpenAcountCustormer_ThongTinKhachHangTableAdapter.Fill(this.dS.frmOpenAcountCustormer_ThongTinKhachHang, txtCMNDKhachHang.Text);
            }
            txtSOTK.Text = teCMND.Text = txtMACNSet.Text = "";
            numbSODU.Value = 0;
            DSTKKH.Enabled = btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = grMoTK.Enabled = false;
            pnlThongTinTaiKhoan.Enabled = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            Bds_TT_KH.Position = vitri;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = Bds_TT_KH.Position;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled  = true;
            sODU.ReadOnly = false;
            pnlThongTinTaiKhoan.Enabled = true;
            btn_Edit_clicked = true;
            DSTKKH.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bds_TK.CancelEdit();//hai trường hợp: đang thêm bỏ thêm, đang sửa bỏ sửa
            if (btnAdd.Enabled == false) Bds_TK.Position = vitri;
            DSTKKH.Enabled = true;
            grMoTK.Enabled = pnlThongTinTaiKhoan.Enabled = false;
            if (Bds_TK.Count > 0)
            {
                btnUndo.Enabled = btnAdd.Enabled =  btnSave.Enabled = false;
                btnAdd.Enabled = btnReload.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnExit.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = btnReload.Enabled = true;
                btnUpdate.Enabled = btnDelete.Enabled = btnExit.Enabled = btnUndo.Enabled = btnSave.Enabled = false;
            }
            DSTKKH.Enabled = true;
        }
    }
}