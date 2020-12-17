using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            change();
        }
        private void change()
        {
            textPass.UseSystemPasswordChar = true;

        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.VIEWS_DANHSACHSERVER' table. You can move, or remove it, as needed.
            this.vIEWS_DANHSACHSERVERTableAdapter.Fill(this.dS.VIEWS_DANHSACHSERVER);
            Program.servername = comboxSite.SelectedValue.ToString();

        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = ckbShowPass.Checked ? false : true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          if (textLogin.Text.Trim() == "" || textPass.Text.Trim() == "")

            {
                MessageBox.Show("Không được để trống xin vui lòng nhập lại !", "THÔNG BÁO", MessageBoxButtons.OK);
                textLogin.Focus();
                return;

            }

            Program.mlogin = textLogin.Text;
            Program.password = textPass.Text;

            if (Program.KetNoi() == 0)
            {
                return;
            }

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.mKhoa = comboxSite.SelectedIndex; // 0 cntt , 1 vt , 2 kt
            Program.bds_dspm = this.vIEWSDANHSACHSERVERBindingSource;

            String len = "exec SP_THONGTINDANGNHAP '" + Program.mlogin.Trim() + "'";

            Program.myReader = Program.ExecSqlDataReader(len);
            if (Program.myReader == null)
            {
                return;
            }
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0); // lấy username

            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);

            Program.conn.Close();
            Program.myReader.Close();



            frmMain main = new frmMain();
            main.Show();
            this.Hide();

        }

        private void comboxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxSite.SelectedIndex != -1)
            {
                Program.servername = comboxSite.SelectedValue.ToString();
            }
        }
    }
}
