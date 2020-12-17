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
    public partial class frmDiem : Form
    {
        private BindingSource bds = new BindingSource();
        private String constr;
        private int lanThi;
        List<int> check = new List<int>();
        List<int> soLanThi = new List<int>();
        public frmDiem()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
            {
                if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "" && this.check[i] == 0)
                {
                    MessageBox.Show("Điểm không được bỏ trống", "Thông báo !", MessageBoxButtons.OK);
                    bdsSPDIEMSV.Position = i;
                    check = true;
                    break;
                }
                else
                {
                    if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() != "")
                    {
                        float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                        if (diem < 0 || diem > 10)
                        {
                            MessageBox.Show("Điểm phải >= 0 hoặc <= 10. Vui lòng kiểm tra lại !");
                            bdsSPDIEMSV.Position = i;
                            check = true;
                            break;
                        }
                    }
                }
            }
            if (!check)
            {
                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                {
                    if (this.check[i] == 0) //update cho sv cũ
                    {
                        float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                        if (Program.KetNoi() == 0) return;

                        String sql = "EXEC SP_UPDATEDIEM '" + ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString() + "','" + txtMonHoc.Text + "'," + lanThi + "," + diem;
                        int k = Program.ExecSqlNonQuery(sql);
                        
                    }
                    else if (this.check[i] == 1 && ((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() != "")
                    {
                        float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                        if (Program.KetNoi() == 0) return;

                        String sql = "EXEC SP_INSERTDIEM '" + ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString() + "','" + txtMonHoc.Text + "'," + lanThi + "," + diem;
                        int k = Program.ExecSqlNonQuery(sql);
                        this.check[i] = 0;
                    }
                }
                MessageBox.Show("Cập nhật điểm hoàn tất", "Thông báo !", MessageBoxButtons.OK);
                btnGhi.Enabled = btnHuy.Enabled = btnCapNhat.Enabled =groupControl2.Visible= false;
                btnBatDau.Enabled = true;
                GroupControl1.Enabled = true;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkLan.SelectedIndex < 0) return;
            lanThi = Int32.Parse(cbkLan.SelectedItem.ToString());
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
         //aaaa
       
            dS.EnforceConstraints = false;
         
            this.sP_LAYMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYMONHOCTableAdapter.Fill(this.dS.SP_LAYMONHOC);
            this.sP_DANHSACHLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHLOPTableAdapter.Fill(this.dS.SP_DANHSACHLOP);
            this.txtLop.Text = cbkLop.SelectedValue.ToString();
            this.txtMonHoc.Text = cbkMon.SelectedValue.ToString();

            constr = Program.connstr;
            bds = Program.bds_dspm;
            if(bds.Count == 3)
            {
                bds.RemoveAt(2);
            }
            this.cbkSite.DataSource = bds;
            this.cbkSite.DisplayMember = "description";
            this.cbkSite.ValueMember = "TENSERVER";
            cbkSite.SelectedIndex = Program.mKhoa;
            Program.servername = cbkSite.SelectedValue.ToString();

           
          
            cbkLan.Items.Add("1");
            cbkLan.Items.Add("2");
            cbkLan.SelectedIndex = 0;
            this.lanThi = Int32.Parse(cbkLan.SelectedItem.ToString());
            btnGhi.Enabled =btnHuy.Enabled= btnCapNhat.Enabled = false;
            groupControl2.Visible = false;
            if (Program.mGroup != "PGV") cbkSite.Enabled = false;
            

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.connstr = constr;
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
                if (this.sPDANHSACHLOPBindingSource.Count != 0) this.txtLop.Text = this.cbkLop.SelectedValue.ToString();
            }
        }

        private void cbkLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkLop.SelectedIndex < 0) return;
            txtLop.Text = cbkLop.SelectedValue.ToString();
        }

        private void cbkMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkMon.SelectedIndex < 0) return;
            txtMonHoc.Text = cbkMon.SelectedValue.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            btnBatDau.Enabled = false;
            GroupControl1.Enabled = false;
            btnHuy.Enabled = btnGhi.Enabled = true;
            groupControl2.Visible = true;
            this.check = new List<int>();
            MessageBox.Show("Mã lớp: " + txtLop.Text.Trim() + ", Mã môn học: " + txtMonHoc.Text.Trim() + ", Lần thi: " + lanThi,
                                            "Xác nhận", MessageBoxButtons.OK);

            try
            {
                if (lanThi == 1)
                {
                    sP_LAYDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    sP_LAYDIEMSINHVIENTableAdapter.Fill(dS.SP_LAYDIEMSINHVIEN, txtLop.Text, txtMonHoc.Text, lanThi);
                    if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanThi) == 0)       //chọn lần thi =1, kiểm tra lần một chưa có điểm
                    {
                        
                      
                            btnGhi.Enabled = true;
                            btnCapNhat.Enabled = false;
                       

                        //btnGhi.Enabled = true;
                        //btnCapNhat.Enabled = false;
                        for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                        {
                            ((DataRowView)bdsSPDIEMSV[i])["DIEM"] = "";
                        }
                    }
                    else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanThi) == 1)      ////chọn lần thi =1, kiểm tra lần một đã có điểm
                    {
                        if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 2) == 0)            ////chọn lần thi =1, kiểm tra lần một đã có điểm, lần 2 chưa có điểm
                        {
                            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                            {
                                if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "")
                                {
                                    check.Add(1);
                                }
                                else
                                {
                                    check.Add(0);
                                }
                            }

                               btnGhi.Enabled = false;
                               btnCapNhat.Enabled = true;
                            

                            //btnGhi.Enabled = false;
                            //btnCapNhat.Enabled = true;
                        }
                        else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 2) == 1)       ////chọn lần thi =1, kiểm tra lần một đã có điểm, lần 2 đã có điểm=>ko dc sửa điểm lần 1 nữa
                        {

                            btnGhi.Enabled = false;
                            btnCapNhat.Enabled = false;
                        }
                    }
                   
                }
                else if (lanThi == 2)
                {

                    sP_LAYDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    sP_LAYDIEMSINHVIENTableAdapter.Fill(dS.SP_LAYDIEMSINHVIEN, txtLop.Text, txtMonHoc.Text, lanThi);
                    if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 1) == 0)                ////chọn lần thi =2, kiểm tra lần một chưa có điểm => phải nhập điểm lần 1 trước
                    {
                        MessageBox.Show("Sinh viên chưa có điểm lần 1 cho môn học này. Vui lòng nhập điểm lần 1 cho môn học này !", "Thông báo !", MessageBoxButtons.OK);
                        btnGhi.Enabled = false;
                        btnCapNhat.Enabled = false;
                        return;
                    }
                    else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 1) == 1)           ////chọn lần thi =2, kiểm tra lần một đã có điểm
                    {
                        sP_LAYDIEMSINHVIENTableAdapter.Fill(dS.SP_LAYDIEMSINHVIEN, txtLop.Text, txtMonHoc.Text, lanThi);

                        if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanThi) == 0)         ////chọn lần thi =2, kiểm tra lần một đã có điểm, kiểm tra lần hai chưa có điểm
                        {
                           
                           
                                btnGhi.Enabled = true;
                                btnCapNhat.Enabled = false;
                            


                            //btnGhi.Enabled = true;
                            //btnCapNhat.Enabled = false;
                            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                            {
                                ((DataRowView)bdsSPDIEMSV[i])["DIEM"] = "";
                            }
                        }
                        else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanThi) == 1)          ////chọn lần thi =2, kiểm tra lần một đã có điểm, kiểm tra lần hai đã có điểm
                        {
                            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                            {
                                if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "")
                                {
                                    check.Add(1);
                                }
                                else
                                {
                                    check.Add(0);
                                }
                            }

                          
                            
                               btnGhi.Enabled = false;
                               btnCapNhat.Enabled = true;
                            

                            //btnGhi.Enabled = false;
                            //btnCapNhat.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("NO STUDENTS"))
                {
                    MessageBox.Show("Lớp hiện không có sinh viên. Vui lòng chọn lớp khác", "Thông báo !", MessageBoxButtons.OK);
                    btnCapNhat.Enabled = btnGhi.Enabled = false;
                    return;
                }
            }
        }

        private int kiemtradiemtheolan(string malop, string mamh, int lan)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String str_sp = "dbo.SP_KIEMTRADIEMTHEOLAN";
            Program.Sqlcmd = Program.conn.CreateCommand();
            Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.Sqlcmd.CommandText = str_sp;
            Program.Sqlcmd.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = malop;
            Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = mamh;
            Program.Sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lan;
            Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.Sqlcmd.ExecuteNonQuery();
            String ret = Program.Sqlcmd.Parameters["@Ret"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có điểm
            }
            else if (ret == "0")
            {
                return 0; //chưa có điểm
            }
            return 0;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            bool check = false;
            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
            {
                if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "")
                {
                    MessageBox.Show("Điểm không được bỏ trống", "Thông báo !", MessageBoxButtons.OK);
                    bdsSPDIEMSV.Position = i;
                    check = true;
                    break;
                }
                else
                {
                    float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                    if (diem < 0 || diem > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 - 10");
                        bdsSPDIEMSV.Position = i;
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                {
                    float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                    if (Program.KetNoi() == 0) return;

                    String sql = "EXEC SP_INSERTDIEM '" + ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString() + "','" + txtMonHoc.Text + "'," + lanThi + "," + diem;
                    int k = Program.ExecSqlNonQuery(sql);
                    this.check.Add(0);
                }
                MessageBox.Show("Ghi điểm hoàn tất", "Thông báo !", MessageBoxButtons.OK);
                btnGhi.Enabled = false;
                btnCapNhat.Enabled = true;
                btnBatDau.Enabled = true;
                GroupControl1.Enabled = true;
                groupControl2.Visible = false;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GroupControl1.Enabled = true;
            btnBatDau.Enabled = true;
            btnCapNhat.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
            groupControl2.Visible = false;
        }
    }
}
