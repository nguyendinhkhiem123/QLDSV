﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xtrp_SP_RPDANHSACHSINHVIEN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_SP_RPDANHSACHSINHVIEN(String malop)
        {
            InitializeComponent();
            this.sqlDataSource3.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource3.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource3.Fill();
        }

    }
}
