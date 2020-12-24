using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xtrp_SP_RPDONGHOCPHI : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_SP_RPDONGHOCPHI(String maLop, String nienKhoa , int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = nienKhoa;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = hocKy;
            this.sqlDataSource2.Fill();
        }

    }
}
