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
    public partial class cbkMon : Form
    {
        String maMon;
        String maLop;
        int lan;
        String constr;
        BindingSource bds = new BindingSource();
        String Date="";
        String month = "";
        String day = "";
        String year = "";
        public cbkMon()
        {
            InitializeComponent();
        }

        private void Fxrp_SP_RPBANGDIEMTHI_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SP_LAYMONHOC' table. You can move, or remove it, as needed.
            this.sP_LAYMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYMONHOCTableAdapter.Fill(this.dS.SP_LAYMONHOC);
            maMon = cbkMH.SelectedValue.ToString();
            // TODO: This line of code loads data into the 'dS.SP_DANHSACHLOP' table. You can move, or remove it, as needed.
            this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
            maLop = cbkLop.SelectedValue.ToString();

            constr = Program.connstr;
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

            if (Program.mGroup != "PGV") cbkSite.Enabled = false;

            cbkLan.Items.Add("1");
            cbkLan.Items.Add("2");
            cbkLan.SelectedIndex = 0;
            lan = Int32.Parse(cbkLan.SelectedItem.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.connstr = this.constr;
            this.Close();
        }

        private void cbkLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkLop.SelectedIndex < 0) return;
            maLop = cbkLop.SelectedValue.ToString();
        }

        private void cbkMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkMH.SelectedIndex < 0) return;
            maMon = cbkMH.SelectedValue.ToString();
        }

        private void cbkLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkLan.SelectedIndex < 0) return;
            lan = Int32.Parse(cbkLan.SelectedItem.ToString());
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

        private void date_EditValueChanged(object sender, EventArgs e)
        {
            this.Date =date.DateTime.ToString();
            this.day = date.DateTime.Day.ToString();
            this.year = date.DateTime.Year.ToString();
            this.month = date.DateTime.Month.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Date == "")
            {
                MessageBox.Show("VUI LÒNG LỰA CHỌN NGÀY THÁNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (Program.KetNoi() == 0) return;
            String sql = "EXEC SP_RPBANGDIEMTHI " + lan + ",'" + maMon + "','" + maLop + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null)
            {
                return;
            }

            if (Program.KetNoi() == 0) return;
            String hql = "SELECT TENLOP FROM LOP WHERE MALOP='" + maLop + "'";
            Program.myReader = Program.ExecSqlDataReader(hql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String tenLop = Program.myReader.GetString(0);
            Program.myReader.Close();
            Program.conn.Close();

            if (Program.KetNoi() == 0) return;
            String hql1 = "SELECT TENMH FROM MONHOC WHERE MAMH='" + maMon + "'";
            Program.myReader = Program.ExecSqlDataReader(hql1);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String tenMon = Program.myReader.GetString(0);
            Program.myReader.Close();
            Program.conn.Close();


            Xtrp_SP_RPBANGDIEMTHI rpt = new Xtrp_SP_RPBANGDIEMTHI(maLop, maMon, lan);
            rpt.xrlabelLan.Text = lan.ToString();
            rpt.xrlabelMon.Text = tenMon;
            rpt.xrlabelLop.Text = tenLop;
            rpt.xrlabelNgay.Text = day+"/"+month+"/"+year;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
