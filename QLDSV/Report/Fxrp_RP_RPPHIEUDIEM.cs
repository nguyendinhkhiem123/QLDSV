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
    public partial class cbkLop : Form
    {
        String maLop;
        String maSV;
        String constr;
        BindingSource bds = new BindingSource();
        public cbkLop()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkSV.SelectedIndex < 0) return;
            maSV = cbkSV.SelectedValue.ToString();
             
        }

        private void cbkLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SP_DANHSACHLOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
            maLop = cbkL.SelectedValue.ToString();

            this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIENTHEOLOP,maLop);
            if(cbkSV.SelectedIndex !=-1) maSV = cbkSV.SelectedValue.ToString();

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
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.connstr = this.constr;
            this.Close();
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
                if (this.sPDANHSACHLOPBindingSource.Count != 0) this.maLop = this.cbkL.SelectedValue.ToString();

                this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIENTHEOLOP, maLop);
                if (cbkSV.SelectedIndex != -1) maSV = cbkSV.SelectedValue.ToString();

            }
        }

        private void cbkL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkL.SelectedIndex < 0) return;
            maLop = cbkL.SelectedValue.ToString();

            this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHSINHVIENTHEOLOPTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIENTHEOLOP, maLop);
            if (cbkSV.SelectedIndex != -1) maSV = cbkSV.SelectedValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            String sql = "EXEC SP_RPPHIEUDIEM '" + maSV + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null)
            {
              
                return;
            }
      
       

            if (Program.KetNoi() == 0) return;
            String hql = "SELECT CONCAT(HO,' ',TEN) AS HOTEN FROM SINHVIEN WHERE MASV='"+maSV+"'";
            Program.myReader = Program.ExecSqlDataReader(hql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            String hoTen = Program.myReader.GetString(0);
            Program.myReader.Close();
            Program.conn.Close();

            Xtrp_SP_RPPHIEUDIEM1 rpt = new Xtrp_SP_RPPHIEUDIEM1(maSV);
            rpt.xrLabel1.Text = " BẢNG ĐIỂM SINH VIÊN " + hoTen;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
