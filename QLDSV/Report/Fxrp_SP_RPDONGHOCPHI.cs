using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Report
{
    public partial class Fxrp_SP_RPDONGHOCPHI : Form
    {
        String maLop;
        String nienKhoa;
        int hocKy;
        public Fxrp_SP_RPDONGHOCPHI()
        {
            InitializeComponent();
        }

        private void Fxrp_SP_RPDONGHOCPHI_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
            maLop = cbkMalop.SelectedValue.ToString();

            this.sP_LAYNIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYNIENKHOATableAdapter.Fill(this.dS.SP_LAYNIENKHOA, maLop);
            if (this.sPLAYNIENKHOABindingSource.Count != 0) this.nienKhoa = this.cbkNienkhoa.SelectedValue.ToString();

            this.sP_LAYHOCKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYHOCKYTableAdapter.Fill(this.dS.SP_LAYHOCKY, maLop, nienKhoa);
            if (this.sPLAYHOCKYBindingSource.Count != 0) this.hocKy = Int32.Parse(this.cbkHocky.SelectedValue.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Xtrp_SP_RPDONGHOCPHI rpt = new Xtrp_SP_RPDONGHOCPHI(maLop, nienKhoa, hocKy);
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.xrLabel1.Text = "DANH SÁCH HỌC PHÍ MÃ LỚP " + maLop + " NIÊN KHÓA " + nienKhoa + " HỌC KỲ " + hocKy;
            print.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbkMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkMalop.SelectedIndex < 0) return;
            maLop = cbkMalop.SelectedValue.ToString();

            this.sP_LAYNIENKHOATableAdapter.Fill(this.dS.SP_LAYNIENKHOA, maLop);
            nienKhoa = cbkNienkhoa.SelectedValue.ToString();
            if (this.sPLAYNIENKHOABindingSource.Count != 0) this.nienKhoa = this.cbkNienkhoa.SelectedValue.ToString();

            this.sP_LAYHOCKYTableAdapter.Fill(this.dS.SP_LAYHOCKY, maLop, nienKhoa);
            hocKy = Int32.Parse(cbkHocky.SelectedValue.ToString());
            if (this.sPLAYHOCKYBindingSource.Count != 0) this.hocKy = Int32.Parse(this.cbkHocky.SelectedValue.ToString());
        }

        private void cbkNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkNienkhoa.SelectedIndex < 0) return;
            nienKhoa = cbkNienkhoa.SelectedValue.ToString();
            this.sP_LAYHOCKYTableAdapter.Fill(this.dS.SP_LAYHOCKY, maLop, nienKhoa);
            if (this.sPLAYHOCKYBindingSource.Count != 0) hocKy = Int32.Parse(cbkHocky.SelectedValue.ToString());
        }

        private void cbkHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkHocky.SelectedIndex < 0) return;
            hocKy = Int32.Parse(cbkHocky.SelectedValue.ToString());
        }
    }
}
