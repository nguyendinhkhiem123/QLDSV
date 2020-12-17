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
    public partial class frmTaoTaiKhoang : Form
    {
        private String servername = "";
        public String tUsername = "";
        public String ROLE = "";//Dung de gan gia tri trong tai khoan tusername
        private String constr;
        SqlConnection con;
        public frmTaoTaiKhoang()
        {
            InitializeComponent();
        }
        private DataTable ketNoi()
        {
            string conStr = "Data Source=" + servername + ";Initial Catalog=QLDSV" + ";Integrated Security=True";
             con = new SqlConnection(conStr);
            con.Open();
            String lenh = "EXEC SP_LAYUSERTRONG";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(lenh, con);
            da.Fill(dt);

            con.Close();
            return dt;
        }
        private SqlDataReader fullName(String s)
        {
            string conStr = "Data Source=" + servername + ";Initial Catalog=QLDSV" + ";Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            String len = "SELECT CONCAT(HO,' ',TEN) AS HOTEN FROM GIANGVIEN WHERE MAGV='" + s + "'";
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
        private void frmTaoTaiKhoang_Load(object sender, EventArgs e)
        {
            this.cbkSite.DataSource = Program.bds_dspm;
            this.cbkSite.DisplayMember = "description";
            this.cbkSite.ValueMember = "TENSERVER";
            cbkSite.SelectedIndex = Program.mKhoa;
            Program.servername = cbkSite.SelectedValue.ToString();
            this.servername = cbkSite.SelectedValue.ToString();
            if (Program.mGroup == "PGV")
            {
                this.cbkSite.Enabled = false;
                cbkRole.Items.Add("PGV");
                cbkRole.Items.Add("KHOA");
                cbkRole.Items.Add("USER");
            }
            if (Program.mGroup == "KHOA")
            {
                this.cbkSite.Enabled = false;
                cbkRole.Items.Add("KHOA");
                cbkRole.Items.Add("USER");
            }
            if (Program.mGroup == "PKT")
            {
                this.cbkSite.Enabled = false;
                cbkRole.Items.Add("PKT");

            }
            cbkRole.SelectedIndex = 0;
            this.ROLE = cbkRole.SelectedItem.ToString();
            this.cbkUser.DataSource = ketNoi();
            this.cbkUser.DisplayMember = "MAGV";
            this.cbkUser.ValueMember = "MAGV";
            if (cbkUser.SelectedItem != null)
            {
                this.tUsername = cbkUser.SelectedValue.ToString();
                Program.myReader = fullName(this.tUsername);
                if (Program.myReader == null)
                {
                    return;
                }
                Program.myReader.Read();
                txtName.Text = Program.myReader.GetString(0);
                Program.myReader.Close();
                con.Close();
            }
          
            this.constr = Program.connstr;
        }

        private void cbkSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkSite.SelectedIndex != -1)
            {
                Program.servername = cbkSite.SelectedValue.ToString();
            }
        }

        private void cbkRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkRole.SelectedIndex != -1)
            {
                this.ROLE = cbkRole.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text.Trim() == "" || textPass.Text.Trim() == "" || cbkRole.SelectedItem == null)
            {
                MessageBox.Show("Lưu ý nhập đầy đủ vào login ,Password và phải chọn ROLE ", "Lỗi đăng nhập", MessageBoxButtons.OK);
                textLogin.Focus();
                return;
            }
            if (cbkUser.SelectedItem == null)
            {

                MessageBox.Show("Không còn nhân viên nào để tạo tài khoản", "Thôn báo", MessageBoxButtons.OK);
            }
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;

            if (Program.KetNoi() == 0)
            {
                return;
            }

            string len = "exec SP_TAOTAIKHOAN '" + textLogin.Text + "','" + textPass.Text + "','"
                + this.tUsername + "','" + this.ROLE + "'";

            int k = Program.ExecSqlNonQuery(len);
            if (k == 0)
            {
                Program.servername = this.servername;
                MessageBox.Show("Tạo thành công", "Thông báo");
            }
        }

        private void cbkUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkUser.SelectedIndex != -1)
            {
                this.tUsername = cbkUser.SelectedValue.ToString(); 
                Program.myReader = fullName(this.tUsername);
                if (Program.myReader.Read())
                {
                  
                    txtName.Text = Program.myReader.GetString(0);
                    

                }

                Program.myReader.Close();
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.servername = this.servername;
            Program.connstr = this.constr;
            this.Close();
        }
    }
}
