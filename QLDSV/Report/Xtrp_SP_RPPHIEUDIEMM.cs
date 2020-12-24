using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xtrp_SP_RPPHIEUDIEMM : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_SP_RPPHIEUDIEMM(String masv)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource2.Fill();
        }

    }
}
