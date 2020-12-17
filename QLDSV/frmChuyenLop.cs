using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmChuyenLop : Form
    {
        private String contr;
        private String masv;
        private BindingSource bds11 = new BindingSource();
        private String servername;
        private String malopsau = "";
        private int ketqua = 0;
        SqlConnection con;
        public frmChuyenLop()
        {
            InitializeComponent();
        }
        private SqlDataReader Ketnoi(String s)
        {
            string conStr = "Data Source=" + servername + ";Initial Catalog=QLDSV" + ";Integrated Security=True";
            con = new SqlConnection(conStr);
            con.Open();
            String len = "exec SP_LAYTHONGTINSINHVIEN '" + s + "'";
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(len, con);
            sqlcmd.CommandType = CommandType.Text;
            if (con.State == ConnectionState.Closed) con.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                this.sP_DANHSACHSINHVIENTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIEN);
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChuyenLop_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            this.sP_DANHSACHSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHSINHVIENTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIEN);
            this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
            this.bds11 = Program.bds_dspm;
            if (this.bds11.Count == 3)
            {
                this.bds11.RemoveAt(2);
            }
            this.cbkKhoa.DataSource = this.bds11;
            this.cbkKhoa.DisplayMember = "description";
            this.cbkKhoa.ValueMember = "TENSERVER";
            this.cbkKhoa.SelectedIndex = Program.mKhoa;
            Program.servername = cbkKhoa.SelectedValue.ToString();
            this.servername = cbkKhoa.SelectedValue.ToString();


            masv = cbkMasv.SelectedValue.ToString();
            Program.myReader = Ketnoi(masv);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            textHo.Text = Program.myReader.GetString(0);
            textTen.Text = Program.myReader.GetString(1);
            textMalop.Text = Program.myReader.GetString(2);
            Program.myReader.Close();
            con.Close();
            this.contr = Program.connstr;
            this.groupControl2.Visible = false;
            this.malopsau = cbkLop.SelectedValue.ToString();

            if (Program.mGroup != "PGV") cbkKhoa.Enabled = false;

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbkMasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkMasv.SelectedIndex < 0) return;
            masv = cbkMasv.SelectedValue.ToString();
            if (Program.myReader == null) return;
            else
            {
                Program.myReader = Ketnoi(masv);
                Program.myReader.Read();
                textHo.Text = Program.myReader.GetString(0);
                textTen.Text = Program.myReader.GetString(1);
                textMalop.Text = Program.myReader.GetString(2);
                Program.conn.Close();
                Program.myReader.Close();
            }
        }

        private void cbkKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkKhoa.SelectedIndex < 0) return;
            if (cbkKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbkKhoa.SelectedValue.ToString();


            if (cbkKhoa.SelectedIndex == Program.mKhoa)
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            else
            {

                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("LỖI KẾT NỐI", "THôNG Báo", MessageBoxButtons.OK);
            }
            else
            {
                this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
                if (sPDANHSACHLOPBindingSource.Count != 0) this.malopsau = cbkLop.SelectedValue.ToString();
             


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textMalop.Text.Equals(this.malopsau))
            {
                MessageBox.Show("SINH VIÊN ĐÃ Ở TRONG LỚP NÀY !", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {

                String sql1 = "exec SP_KIEMTRASINHVIENCOTRONGLOP_VEC#'" + this.malopsau + "','" + textHo.Text + "','" + textTen.Text + "'";
                ketqua = Program.ExecSqlNonQuery(sql1);
                if (ketqua == 0)
                {

                    label3.Visible = true;
                    textBox1.Visible = true;
                    MessageBox.Show("HÃY NHẬP MÃ SINH VIÊN !", "THÔNG BÁO", MessageBoxButtons.OK);


                }

                cbkKhoa.Enabled = false;
                cbkLop.Enabled = false;
                button1.Enabled = false;
                btnChuyen.Enabled = true;
            }
        }

        private void cbkLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkLop.SelectedIndex < 0) return;
            this.malopsau = cbkLop.SelectedValue.ToString();
        
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (ketqua == 0)
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ SINH VIÊN !", "THÔNG BÁO", MessageBoxButtons.OK);
                    textBox1.Focus();
                    return;
                }

            }
            else textBox1.Text = "";
            if (Program.KetNoi() == 0) return;
            String len = "EXEC SP_CHUYENLOP '" + textMalop.Text + "','" + this.malopsau + "','" + textHo.Text + "','" + textTen.Text + "','" + this.masv + "','" + textBox1.Text + "'";
            int k = Program.ExecSqlNonQuery(len);
            if (k == 0)
            {
                MessageBox.Show("CHUYỂN LỚP THÀNH CÔNG ", "THÔNG BÁO", MessageBoxButtons.OK);
                this.groupControl2.Visible = false;
              //  this.textMasvmoi.Enabled = true;
                barButtonItem2.Enabled = true;
                cbkKhoa.Enabled = true;
                cbkLop.Enabled = true;
                button1.Enabled = true;
                barButtonItem3.Enabled = true;
                groupControl1.Enabled = true;

            }

            Program.servername = this.servername;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.connstr = this.contr;
            this.sP_DANHSACHSINHVIENTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIEN);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.servername = this.servername;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.connstr = this.contr;
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             barButtonItem2.Enabled = false;
            this.groupControl2.Visible = true;
          //  this.textMasvmoi.Enabled = false;
            this.btnChuyen.Enabled = false;
            label3.Visible = false;
            textBox1.Visible = false;
            barButtonItem3.Enabled = false;
            this.groupControl1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupControl2.Visible = false;
            //this.textMasvmoi.Enabled = true;
            barButtonItem2.Enabled = true;
            cbkKhoa.Enabled = true;
            cbkLop.Enabled = true;
            button1.Enabled = true;
            barButtonItem3.Enabled = true;
            groupControl1.Enabled = true;
            Program.servername = this.servername;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.connstr = this.contr;
            this.sP_DANHSACHSINHVIENTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIEN);
        }
    }
}
