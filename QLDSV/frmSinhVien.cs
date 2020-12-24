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
    public partial class frmSinhVien : Form
    {
        public BindingSource bds = new BindingSource();
        public String maKH = "";
        public String servername;
        private int vitri;
        private int vitri2;
        private String maLopT; // Malop ban đầu khi chưa bấm sửa; ,// Nếu mà MALOPT ="" thì có nghĩ đó là thêm
        private String maSinhVienT; // MaSinhVien ban đầu khi chưa bấm sửa; 
        private String constr;
        Stack<SubClass> undo = new Stack<SubClass>();
        private SubClass sC;
        private int trangThaiLop;
        private int trangThaiSinhVien;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            sC = new SubClass(1, "", "", "", " ", false, new DateTime(), "", "", "", false, textMaLop.Text, textTen.Text, textMaKH.Text);
            trangThaiLop = 1;
            textMaLop.Enabled = false;
            this.maLopT = textMaLop.Text;
            btnSua.Enabled = btnThem.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled =true;
            groupControl1.Enabled = false;
            groupControl3.Enabled = true;
            groupControl2.Enabled = false;
            gcSinhVien.Enabled = false;

            contextMenuStrip1.Enabled = false;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.HOCPHITableAdapter.Fill(this.dS.HOCPHI);

            this.DIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DIEMTableAdapter.Fill(this.dS.DIEM);
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.bds = Program.bds_dspm;
            if (bds.Count == 3)
            {
                bds.RemoveAt(2);
            }
            cbkSite.DataSource = this.bds;
            cbkSite.DisplayMember = "description";
            cbkSite.ValueMember = "TENSERVER";
            cbkSite.SelectedIndex = Program.mKhoa;
            if (cbkSite.SelectedIndex == 0) this.maKH = "CNTT";
            else this.maKH = "VT";
            Program.servername = cbkSite.SelectedValue.ToString();
            this.servername = Program.servername;

            if (Program.mGroup != "PGV") cbkSite.Enabled = false;
            else cbkSite.Enabled = true;
            btnHuy.Enabled = false;
            textMaKH.Enabled = false;
            btnGhi.Enabled = false;
            btnUndo.Enabled = false;
            groupControl3.Enabled = false;
            toolGhi.Enabled = false;
            toolHuy.Enabled = false;
          
            this.constr = Program.connstr;

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
                undo.Clear();
                btnUndo.Enabled = false;
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dS.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.DIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DIEMTableAdapter.Fill(this.dS.DIEM);

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
              
                btnUndo.Enabled = false;
                undo.Clear();
                this.LOPTableAdapter.Fill(dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới" + ex.Message, "LỖI", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            trangThaiLop = 0;
            this.maLopT = "";
            bdsLop.AddNew();
            textMaLop.Enabled = true;
            textMaKH.Text = this.maKH;
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gcLop.Enabled = groupControl1.Enabled = false;
            groupControl3.Enabled = true;
            gcSinhVien.Enabled = false;

            contextMenuStrip1.Enabled = false;
        }

        private void textMaLop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((((DataRowView)bdsLop[bdsLop.Count - 1])["MALOP"].ToString()) == "") bdsLop.RemoveAt(bdsLop.Count - 1);
            bdsLop.CancelEdit();
            LOPTableAdapter.Fill(dS.LOP);
            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = gcLop.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled= false;
            groupControl3.Enabled = false;
            groupControl1.Enabled = true;
            groupControl2.Enabled = true;
            gcSinhVien.Enabled = true;
            contextMenuStrip1.Enabled = true;
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
            String sql = "EXEC SP_KIEMTRAMALOP '" + this.maLopT + "','" + textMaLop.Text + "'";
            int k = Program.ExecSqlNonQuery(sql);
            if (k == 0)
            {
                try
                {
                    String maLop = textMaLop.Text.Trim();
                    String tenLop = textTen.Text.Trim();
                    String maKha = textMaKH.Text.Trim();

                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.dS.LOP);
                    MessageBox.Show("GHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(dS.SINHVIEN);

                    if (trangThaiLop == 0)
                    {

                        sC = new SubClass(0, "", "", "", " ", false, new DateTime(), "", "", "", false, maLop,tenLop, maKH);
                        undo.Push(sC);
                    }
                    else if (trangThaiLop == 1)
                    {

                        undo.Push(sC);
                    }
                    btnUndo.Enabled = true;
                    btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = groupControl1.Enabled = gcLop.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled= false;
                    groupControl3.Enabled = false;
                    groupControl2.Enabled = true;
                    gcSinhVien.Enabled = true;
                    btnUndo.Enabled = true;

                    contextMenuStrip1.Enabled = true;
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

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.servername = this.servername;
            this.constr = Program.connstr;
            this.Close();
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
                    //maLop = (((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString());
                    string ma = (((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString());
                    string tenLop = (((DataRowView)bdsLop[bdsLop.Position])["TENLOP"].ToString());
                    string maKhoa = (((DataRowView)bdsLop[bdsLop.Position])["MAKH"].ToString());
                   
                  
                    bdsLop.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Update(this.dS.LOP);
                    sC = new SubClass(2, "", "", "", " ", false, new DateTime(), "", "", "", false, ma, tenLop, maKhoa);
                    undo.Push(sC);
                    btnUndo.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp" + ex.Message, "LỖI", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(dS.LOP);
                    //  bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
          
        }

        private void toolThem_Click(object sender, EventArgs e)
        {
            trangThaiSinhVien = 0;
            colMASV.Visible = true;
            this.maSinhVienT = " ";
            bdsSinhVien.AddNew();
            toolGhi.Enabled = true;
            toolHuy.Enabled = true;
            toolThem.Enabled = false;
            toolXoa.Enabled = false;
            toolSua.Enabled = false;
            toolLammoi.Enabled = false;
          

            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnThoat.Enabled = false;
            gcLop.Enabled = groupControl1.Enabled = false;
            groupControl3.Enabled = false;
        }

        private void toolGhi_Click(object sender, EventArgs e)
        {
            String maSV = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString());
            String ho = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["HO"].ToString());
            String ten = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["TEN"].ToString());
            String noiSinh = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NOISINH"].ToString());
            String diaChi = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["DIACHI"].ToString());
            String phai = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["PHAI"].ToString());
            String nghiHoc = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGHIHOC"].ToString());
            String date = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGAYSINH"].ToString());

      
            if (maSV.Trim() == "")
            {
                MessageBox.Show("MÃ SINH VIÊN KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);

                return;
            }
            if (ho.Trim() == "")
            {
                MessageBox.Show("HỌ KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);

                return;
            }
            if (ten.Trim() == "")
            {
                MessageBox.Show("HỌ KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);

                return;
            }
            if (phai == "")
            {
                MessageBox.Show("HÃY CHỌN GIỚI TÍNH", "THÔNG BÁO", MessageBoxButtons.OK);

                return;
            }
            if(date == "")
            {
                MessageBox.Show("HÃY CHỌN NGÀY SINH", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if(nghiHoc == "")
            {
                MessageBox.Show("NGHỈ HỌC KHÔNG ĐƯỢC CHỌN HOẶC BỎ TRỐNG !. VUI LÒNG CHỌN KHÔNG TÍCH VÀO", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else if (nghiHoc.Trim() == "True")
            {
                MessageBox.Show("SINH VIÊN MỚI ĐƯỢC THÊM VÀO KHÔNG ĐƯỢC TÍCH VÀO Ô NGHỈ HỌC", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            if (noiSinh.Trim() == "")
            {
                MessageBox.Show("NƠI SINH KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);

                return;
            }
            if (diaChi.Trim() == "")
            {
                MessageBox.Show("ĐỊA CHỈ KHÔNG ĐƯỢC BỎ TRỐNG", "THÔNG BÁO", MessageBoxButtons.OK);
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
            String sql = "EXEC SP_KIEMTRAMASINHVIEN '" + this.maSinhVienT + "','" + maSV + "'";
            int k = Program.ExecSqlNonQuery(sql);
            if (k == 0)
            {
                try
                {
                    String maSV1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString());
                    String ho1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["HO"].ToString());
                    String ten1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["TEN"].ToString());
                    String noiSinh1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NOISINH"].ToString());
                    String diaChi1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["DIACHI"].ToString());
                    bool phai1 = Boolean.Parse((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["PHAI"].ToString()));
                    bool nghiHoc1 = Boolean.Parse((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGHIHOC"].ToString()));
                    DateTime date1 = Convert.ToDateTime((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGAYSINH"].ToString()));
                    String maLop1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MALOP"].ToString());
                    String ghiChu1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["GHICHU"].ToString());
                    bdsSinhVien.EndEdit();
                    bdsSinhVien.ResetCurrentItem();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    MessageBox.Show("GHI THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);

                    if (trangThaiSinhVien == 0)
                    {
                       
                        sC = new SubClass(3, maSV1, ho1, ten1, maLop1, phai1, date1, noiSinh1, diaChi1, ghiChu1, nghiHoc1, "", "", "");
                        undo.Push(sC);
                    }
                    else if (trangThaiSinhVien == 1)
                    {
                        undo.Push(sC);
                    }
                    toolGhi.Enabled = false;
                    toolHuy.Enabled = false;
                    toolThem.Enabled = true;
                    toolXoa.Enabled = true;
                    toolSua.Enabled = true;
                    toolLammoi.Enabled = true;

                    btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                    btnGhi.Enabled = btnHuy.Enabled = false;
                    gcLop.Enabled = groupControl1.Enabled = true;
                    groupControl3.Enabled = true;
                    vitri2 = 0;
                    this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    colMASV.Visible = true;
                    btnUndo.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖI SINH VIÊN " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void toolSua_Click(object sender, EventArgs e)
        {

            String maSV = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString());
            String ho = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["HO"].ToString());
            String ten = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["TEN"].ToString());
            String noiSinh = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NOISINH"].ToString());
            String diaChi = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["DIACHI"].ToString());
            bool phai = Boolean.Parse((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["PHAI"].ToString()));
            bool nghiHoc =Boolean.Parse((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGHIHOC"].ToString()));
            DateTime date =Convert.ToDateTime((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGAYSINH"].ToString()));
            String maLop = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MALOP"].ToString());
            String ghiChu = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["GHICHU"].ToString());
            trangThaiSinhVien = 1;
            sC = new SubClass(4,maSV,ho,ten,maLop,phai,date,noiSinh,diaChi,ghiChu,nghiHoc,"","","");
            colMASV.Visible = false;
            vitri2 = bdsSinhVien.Position;
            this.maSinhVienT = (((DataRowView)bdsSinhVien[vitri2])["MASV"].ToString());
            toolGhi.Enabled = true;
            toolHuy.Enabled = true;
            toolThem.Enabled = false;
            toolXoa.Enabled = false;
            toolSua.Enabled = false;
            toolLammoi.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnThoat.Enabled = false;
            gcLop.Enabled = groupControl1.Enabled = false;
            groupControl3.Enabled = false;
        }

        private void toolXoa_Click(object sender, EventArgs e)
        {
            if (bdsSinhVien.Count == 0)
            {
                MessageBox.Show("LỚP KHÔNG CÓ SINH VIÊN ĐỂ XÓA", "CẢNH BÁO", MessageBoxButtons.OK);
                return;
            }
            if (Program.KetNoi() == 0) return;
            string sql = "EXEC SP_KIEMTRAMASVTRONGHOCPHI_SINHVIEN '" + (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString())+"'";
            int n = Program.ExecSqlNonQuery(sql);
            if (n != 0) return; 
            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("KHÔNG THỂ XÓA SINH VIÊN NÀY VÌ ĐÃ CÓ ĐIỂM", "CẢNH BÁO", MessageBoxButtons.OK);
                return;
            }
            else if (MessageBox.Show("BẠN CÓ CHẮC CHẮN XÓA KHÔNG", "XÁC NHẬN", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                btnUndo.Enabled = true;
                try
                {
                    // maLop = (((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString());
                    String maSV1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MASV"].ToString());
                    String ho1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["HO"].ToString());
                    String ten1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["TEN"].ToString());
                    String noiSinh1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NOISINH"].ToString());
                    String diaChi1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["DIACHI"].ToString());
                    bool phai1 = Boolean.Parse((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["PHAI"].ToString()));
                    bool nghiHoc1 = Boolean.Parse((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGHIHOC"].ToString()));
                    DateTime date1 = Convert.ToDateTime((((DataRowView)bdsSinhVien[bdsSinhVien.Position])["NGAYSINH"].ToString()), System.Globalization.CultureInfo.InvariantCulture);
                    String maLop1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["MALOP"].ToString());
                    String ghiChu1 = (((DataRowView)bdsSinhVien[bdsSinhVien.Position])["GHICHU"].ToString());
                   
                    bdsSinhVien.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    this.SINHVIENTableAdapter.Fill(dS.SINHVIEN);
                    btnUndo.Enabled = true;
                    sC = new SubClass(5, maSV1, ho1, ten1, maLop1, phai1, date1, noiSinh1, diaChi1, ghiChu1, nghiHoc1, "", "", "");
                    undo.Push(sC);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp" + ex.Message, "LỖI", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(dS.SINHVIEN);
                    //  bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }

            }
         
        }

        private void toolLammoi_Click(object sender, EventArgs e)
        {
            try
            {
              
                this.SINHVIENTableAdapter.Fill(dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới" + ex.Message, "LỖI", MessageBoxButtons.OK);
                return;
            }
        }

        private void toolHuy_Click(object sender, EventArgs e)
        {
            if (((DataRowView)bdsSinhVien[bdsSinhVien.Count - 1])["MASV"].ToString() == "") bdsSinhVien.RemoveAt(bdsSinhVien.Count - 1);
            bdsSinhVien.CancelEdit();
            SINHVIENTableAdapter.Fill(dS.SINHVIEN);
            toolGhi.Enabled = false;
            toolHuy.Enabled = false;
            toolThem.Enabled = true;
            toolXoa.Enabled = true;
            toolSua.Enabled = true;
            toolLammoi.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnReload.Enabled = btnBaoCao.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = btnUndo.Enabled = btnThoat.Enabled = true;
            gcLop.Enabled = groupControl1.Enabled = true;
            groupControl3.Enabled = false;
            vitri2 = 0;
            this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            colMASV.Visible = true;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (undo.Count == 0)
            {
                MessageBox.Show("Không thể quay lại !", "Thông báo", MessageBoxButtons.OK);
            }
            if (undo.Count > 0)
            {
                SubClass mh = undo.Pop();

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
                if (mh.Key == 3)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "DELETE FROM SINHVIEN WHERE MASV='" + mh.MaSv + "'";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {


                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    }
                }
                if (mh.Key == 4)
                {
                    if (Program.KetNoi() == 0) return;
                    int phai;
                    int nghihoc;
                    if (mh.Phai == true) phai = 1;
                    else phai = 0;
                    
                    if (mh.Nghihoc == true) nghihoc = 1;
                    else nghihoc = 0;
                    string s = "UPDATE SINHVIEN SET HO=N'" + mh.Ho + "',TEN=N'" + mh.Ten + "',PHAI=" + phai + ",NOISINH=N'" + mh.Noisinh + "',DIACHI=N'" + mh.Diachi + "',GHICHU=N'" + mh.Ghichu + "',NGHIHOC=" + nghihoc + ",NGAYSINH=" + mh.Ngaysinh.ToString("mm-dd-yyyy") + " WHERE MASV='" + mh.MaSv + "'";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {

                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    }
                }
                if (mh.Key == 5)
                {
                    if (Program.KetNoi() == 0) return;
                    DateTime time = Convert.ToDateTime(mh.Ngaysinh.ToString("yyyy-MM-dd HH:mm:ss"));

                    int phai;
                    int nghihoc;
                    if (mh.Phai == true) phai = 1;
                    else phai = 0;

                    if (mh.Nghihoc == true) nghihoc = 1;
                    else nghihoc = 0;
                    string s = "INSERT INTO SINHVIEN(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC) VALUES('" + mh.MaSv + "',N'" + mh.Ho + "',N'" + mh.Ten + "','" + mh.Malop + "'," + phai + "," + mh.Ngaysinh.ToString("mm-dd-yyyy") + ",N'" + mh.Noisinh + "',N'" + mh.Diachi + "',N'" + mh.Ghichu + "'," + nghihoc + ")";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {

                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                    }

                }

            }
            if (undo.Count == 0) btnUndo.Enabled = false;
        }
    }
}
