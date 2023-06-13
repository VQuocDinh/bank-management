using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace phanTanNganHang
{
    public partial class Xrpt_CustomerList : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_CustomerList()
        {
        }
        public Xrpt_CustomerList(string loai, string CN)
        {
            InitializeComponent();
            try
            {
                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = loai;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = CN;
                this.sqlDataSource1.Fill();
            }
            catch(Exception ex) { MessageBox.Show("Reload Error:" + ex.Message, "", MessageBoxButtons.OK); }
            
        }
    }
}
