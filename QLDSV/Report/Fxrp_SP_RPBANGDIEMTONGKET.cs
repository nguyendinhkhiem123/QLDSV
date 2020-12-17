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
    public partial class Fxrp_SP_RPBANGDIEMTONGKET : Form
    {
        private String servername;
        private BindingSource bds = new BindingSource();
        private String maLop;
        private String constr;
        public Fxrp_SP_RPBANGDIEMTONGKET()
        {
            InitializeComponent();
        }

        private void Fxrp_SP_RPBANGDIEMTONGKET_Load(object sender, EventArgs e)

        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SP_DANHSACHLOP' table. You can move, or remove it, as needed.
            this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
            this.bds = Program.bds_dspm;
            if (this.bds.Count == 3)
            {
                this.bds.RemoveAt(2);
            }


            cbkSite.DataSource = this.bds;
            this.cbkSite.DisplayMember = "description";
            this.cbkSite.ValueMember = "TENSERVER";
            cbkSite.SelectedIndex = Program.mKhoa;
            Program.servername = cbkSite.SelectedValue.ToString();
            this.servername = cbkSite.SelectedValue.ToString();

            this.maLop = this.cbkLop.SelectedValue.ToString();
            if (Program.mGroup != "PGV") cbkSite.Enabled = false;
            this.constr = Program.connstr;

        }

        private void cbkSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkSite.SelectedIndex < 0) return;
            if (cbkSite.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbkSite.SelectedValue.ToString();
            if (cbkSite.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
                if (this.sPDANHSACHLOPBindingSource.Count != 0) this.maLop = this.cbkLop.SelectedValue.ToString();
            }
        }

        private void cbkLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkLop.SelectedIndex < 0) return;
            maLop = cbkLop.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Program.servername = this.servername;
            this.maLop = "";
            Program.connstr = this.constr;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            String sql = "EXEC SP_RPBANGDIEMTONGKET '" + maLop + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null)
            {

                return;
            }

            Xtrp_SP_RPBANGDIEMTONGKET rpt = new Xtrp_SP_RPBANGDIEMTONGKET(maLop);
             rpt.label1.Text = "BẢNG ĐIỂM TỔNG KẾT CỦA LỚP " + maLop + "";
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
