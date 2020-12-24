using QLDSV.Class;
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
    public partial class frmLop : Form
    {
        private String maLopT; // Malop ban đầu khi chưa bấm sửa;
        private String servername;
        private int vitri;
        private String maKH;
        private BindingSource bds = new BindingSource();
        private String constr;
        private int Co = -1; // co =1 là thêm , co = 0 là sửa

        Stack<Lop> undo = new Stack<Lop>();
        private int trangthai; // 0 la them, 1 la sua , 2 la xoa
        private string maLop;
        private string tenLop;
        private string maKhoa;
        public frmLop()
        {
            InitializeComponent();
        }


        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.

            dS.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS.LOP);
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.bds = Program.bds_dspm;
            if (this.bds.Count == 3)
            {
                this.bds.RemoveAt(2);
            }

            cbkSite.DataSource = this.bds;
            this.cbkSite.DisplayMember = "description";
            this.cbkSite.ValueMember = "TENSERVER";
            cbkSite.SelectedIndex = Program.mKhoa;
            if (cbkSite.SelectedIndex == 0) this.maKH = "CNTT";
            else this.maKH = "VT";
            Program.servername = cbkSite.SelectedValue.ToString();
            this.servername = cbkSite.SelectedValue.ToString();

            if (Program.mGroup != "PGV")
            {
                cbkSite.Enabled = false;
            }
            else cbkSite.Enabled = true;
            this.constr = Program.connstr;
            btnHuy.Enabled = false;
            textMaKH.Enabled = false;
            btnGhi.Enabled = false;
            btnUndo.Enabled = false;
            groupControl3.Enabled = false;

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((((DataRowView)bdsLop[bdsLop.Count - 1])["MALOP"].ToString()) == "") bdsLop.RemoveAt(bdsLop.Count - 1);
            bdsLop.CancelEdit();
            LOPTableAdapter.Fill(dS.LOP);
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = groupControl1.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled= false;
            groupControl3.Enabled = false;
            groupControl2.Enabled = true;
          


        }

        private void cbkSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkSite.SelectedIndex < 0) return;
            if (cbkSite.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbkSite.SelectedValue.ToString();
            if (cbkSite.SelectedIndex == 0) this.maKH = "CNTT";
            else this.maKH = "VT";
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
                btnUndo.Enabled = false;
                undo.Clear();
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dS.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthai = 0;
            this.maLopT = "";
            vitri = bdsLop.Position;
            bdsLop.AddNew();
            textMaKH.Text = this.maKH;
            textMaLop.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled =true;
            groupControl3.Enabled = true;
            groupControl1.Enabled = groupControl2.Enabled = false;
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.servername = this.servername;
            Program.connstr = this.constr;
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textMaLop.Text.Trim() == "")
            {
                MessageBox.Show("MÃ LỚP KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);
                textMaLop.Focus();
                return;
            }
            if (textTen.Text.Trim() == "")
            {
                MessageBox.Show("TÊN LỚP KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);
                textTen.Focus();
                return;
            }

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
            String sql = "EXEC SP_KIEMTRAMALOP '" + this.maLopT + "'" + ",'" + textMaLop.Text + "'";
            int k = Program.ExecSqlNonQuery(sql);
            if (k == 0)
            {
                try
                {

                    String malop = textMaLop.Text.Trim();
                    String tenlop = textTen.Text.Trim();
                    String makhoa = textMaKH.Text.Trim();
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.dS.LOP);
                    MessageBox.Show("GHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(dS.SINHVIEN);

                    if (trangthai == 0)
                    {
                        this.maLop = malop;
                        this.tenLop = tenlop;
                        this.maKhoa = makhoa;
                        Lop lop = new Lop(0, maLop, tenLop, maKhoa);
                        undo.Push(lop);
                    }
                    else if (trangthai == 1)
                    {
                        Lop lop = new Lop(1, maLop, tenLop, maKhoa);
                        undo.Push(lop);
                    }
                    btnUndo.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = groupControl1.Enabled = groupControl2.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = false;
                    groupControl3.Enabled = false;
                    btnUndo.Enabled = true;

                }

                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        MessageBox.Show("Tên lớp học bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("LỖI GHI LỚP " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                    }

                }
            }


        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthai = 1;
            this.maLop = textMaLop.Text; // dung undo
            this.tenLop = textTen.Text; // dung undo
            this.maKhoa = textMaKH.Text;// dung undo
            this.maLopT = textMaLop.Text;
            this.Co = 0;
            textMaLop.Enabled = false;
            vitri = bdsLop.Position;
            btnSua.Enabled = btnThem.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            groupControl3.Enabled = true;
            groupControl2.Enabled = false;
            groupControl1.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("KHÔNG CÓ LỚP ĐỂ XÓA", "CẢNH BÁO", MessageBoxButtons.OK);
                return;
            }
             if (bdsSinhVien.Count > 0)
             {
                  MessageBox.Show("KHÔNG THỂ XÓA LỚP NÀY VÌ ĐÃ CÓ SINH VIÊN", "CẢNH BÁO", MessageBoxButtons.OK);
             }
              else if (MessageBox.Show("BẠN CÓ CHẮC CHẮN XÓA KHÔNG", "XÁC NHẬN", MessageBoxButtons.OKCancel) == DialogResult.OK)
              {
                 
                     try
                     {
                            this.maLop = (((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString());
                            this.tenLop = (((DataRowView)bdsLop[bdsLop.Position])["TENLOP"].ToString());
                            this.maKhoa = (((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString());
                            bdsLop.RemoveCurrent();
                            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.LOPTableAdapter.Update(this.dS.LOP);
                            Lop lop = new Lop(2, maLop, tenLop, maKhoa);
                            undo.Push(lop);
                            btnUndo.Enabled = true;

                }
                      catch (Exception ex)
                      {
                            MessageBox.Show("Lỗi xóa lớp" + ex.Message, "LỖI", MessageBoxButtons.OK);
                            this.LOPTableAdapter.Fill(dS.LOP);
                            // bdsLop.Position = bdsLop.Find("MALOP", maLop);
                            return;
                      }

               }
                   
                  
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnUndo.Enabled = false;
                undo.Clear();
                this.LOPTableAdapter.Fill(dS.LOP);
                this.SINHVIENTableAdapter.Fill(dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới" + ex.Message, "LỖI", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(undo.Count == 0)
            {
                MessageBox.Show("Không thể quay lại !", "Thông báo", MessageBoxButtons.OK);
            }
            if (undo.Count > 0)
            {
                Lop mh = undo.Pop();

                if (mh.Key == 0)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "DELETE FROM LOP WHERE MALOP='" + mh.MaLop + "'";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {

                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Fill(this.dS.LOP);
                        this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    }
                }
                if (mh.Key == 1)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "UPDATE LOP SET TENLOP=N'" + mh.TenLop + "' WHERE MALOP='" + mh.MaLop + "'";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Fill(this.dS.LOP);
                        this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    }
                }
                if (mh.Key == 2)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "INSERT INTO LOP(MALOP,TENLOP,MAKH) VALUES('" + mh.MaLop + "',N'" + mh.TenLop + "','" + mh.MaKhoa + "')";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {
                        this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LOPTableAdapter.Fill(this.dS.LOP);
                        this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                    }

                }
            }
            if (undo.Count == 0) btnUndo.Enabled = false;
        }
    }
}