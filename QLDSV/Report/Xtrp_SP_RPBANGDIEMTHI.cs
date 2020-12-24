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
            this.sqlDataSource3.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource3.Queries[0].Parameters[0].Value = Lan;
            this.sqlDataSource3.Queries[0].Parameters[1].Value = maMon;
            this.sqlDataSource3.Queries[0].Parameters[2].Value = maLop;
            this.sqlDataSource3.Fill();
        }

    }
}
