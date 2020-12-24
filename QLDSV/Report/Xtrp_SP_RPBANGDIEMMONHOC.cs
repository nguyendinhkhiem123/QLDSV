using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xtrp_SP_RPBANGDIEMMONHOC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_SP_RPBANGDIEMMONHOC(String maLop, String maMon,int Lan)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = Lan;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = maMon;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = maLop;
            this.sqlDataSource2.Fill();
        }

    }
}
