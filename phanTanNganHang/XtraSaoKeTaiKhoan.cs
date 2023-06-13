using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace phanTanNganHang
{
    public partial class XtraSaoKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraSaoKeTaiKhoan(String SOTK, DateTime batdau, DateTime ketthuc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = SOTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = batdau;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ketthuc;
            this.sqlDataSource1.Fill();
        }

    }
}
