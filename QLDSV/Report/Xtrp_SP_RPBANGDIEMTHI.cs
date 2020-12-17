using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xtrp_SP_RPBANGDIEMTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_SP_RPBANGDIEMTHI(String maLop, String maMon, int Lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = Lan;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMon;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maLop;
            this.sqlDataSource1.Fill();
        }

    }
}
