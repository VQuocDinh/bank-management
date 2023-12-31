﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace phanTanNganHang
{
    public partial class XtraLietKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraLietKeTaiKhoan(DateTime batdau, DateTime ketthuc, string loai, string macn)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = batdau;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ketthuc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = macn;
            this.sqlDataSource1.Fill();
        }
    }
}
