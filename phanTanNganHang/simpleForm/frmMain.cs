using phanTanNganHang.simpleForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phanTanNganHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void barBtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSatff));
            if (frm != null) frm.Activate();
            else
            {
                frmSatff f = new frmSatff();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát ?", "", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmCreateAccout));
            if (frm != null) frm.Activate();
            else
            {
                frmCreateAccout f = new frmCreateAccout();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTransfer));
            if (frm != null) frm.Activate();
            else
            {
                frmTransfer f = new frmTransfer();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDepositAndWithdraw));
            if (frm != null) frm.Activate();
            else
            {
                frmDepositAndWithdraw f = new frmDepositAndWithdraw();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSaoKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmOpenAcountCustormer));
            if (frm != null) frm.Activate();
            else
            {
                frmOpenAcountCustormer f = new frmOpenAcountCustormer();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
            
            MANV.Text = "Mã NV = " + Program.username;
            HOTEN.Text ="Họ tên = "+ Program.mHoTen;
            NHOM.Text = "Nhóm = " + Program.mGroup;
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = btnCreateLogin.Enabled = btnLogout.Enabled = true;
            btnDangNhap.Enabled = false;
            //btnLogout.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            // còn if trên Program.mGroup để bật tắt các nút lệnh trên menu chính
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
            if(Program.mGroup == "KHACHHANG")
            {
                rib_DanhMuc.Visible = rib_NghiepVu.Visible = barButtonItem2.Enabled = barBtnLietKeKH.Enabled = false;
            }
        }

        private void MANV_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất khỏi tài khoản \n- Mã NV: " + Program.username + "\n- Tên: " + Program.mHoTen + "\n- Nhóm: " + Program.mGroup, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
                Program.frmChinh.MANV.Text = "Mã nhân viên: NULL";
                Program.frmChinh.HOTEN.Text = "Họ tên: NULL";
                Program.frmChinh.NHOM.Text = "Nhóm: NULL";
                rib_DanhMuc.Visible = rib_NghiepVu.Visible = rib_BaoCao.Visible = btnCreateLogin.Enabled = btnLogout.Enabled = false;
                btnDangNhap.Enabled = true;
            }
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barBtnLietKeKH_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmCustomerList));
            if (frm != null) frm.Activate();
            else
            {
                frmCustomerList f = new frmCustomerList();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barBtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnCustomer_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmStatement));
            if (frm != null) frm.Activate();
            else
            {
                frmStatement f = new frmStatement();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmAcountListing));
            if (frm != null) frm.Activate();
            else
            {
                frmAcountListing f = new frmAcountListing();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
