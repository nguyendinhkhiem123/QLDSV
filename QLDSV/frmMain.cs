using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLDSV.Report;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            barStaticItem2.Caption = "MAGV : " + Program.username + " | " + " HOTEN : " + Program.mHoten + " | " + " NHOM : " + Program.mGroup;

            if (Program.mGroup == "USER")
            {
                this.btnDetail.Enabled = false;
                this.btnRestore.Enabled = false;
                this.ribKetoan.Enabled = false;
                this.ribbonPage3.Visible = false;
                this.barButtonItem13.Enabled = false;
            }
            else if (Program.mGroup == "PKT")
            {
                //this.btnDetail.Enabled = false;
                //this.btnRestore.Enabled = false;
                this.ribLop.Enabled = false;
                this.ribKhoa.Enabled = false;
                this.barButtonItem6.Enabled = false;
                this.barButtonItem8.Enabled = false;
                this.barButtonItem9.Enabled = false;
                this.barButtonItem10.Enabled = false;
                this.barButtonItem11.Enabled = false;
            }
            else if (Program.mGroup == "PGV" || Program.mGroup == "KHOA")
            {
                this.barButtonItem7.Enabled = false;
                this.ribKetoan.Enabled = false;
            }
        }


        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Visible = false;
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoang));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoang f = new frmTaoTaiKhoang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm1 = this.CheckExists(typeof(frmSinhVien));
            if (frm1 != null) frm1.Close();
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm1 = this.CheckExists(typeof(frmLop));
            if (frm1 != null) frm1.Close();

            Form frm2 = this.CheckExists(typeof(frmDiem));
            if (frm2 != null) frm2.Close();

            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChuyenLop));
            if (frm != null) frm.Activate();
            else
            {
                frmChuyenLop f = new frmChuyenLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Fxrp_SP_RPDANHSACHSINHVIEN));
            if (frm != null) frm.Activate();
            else
            {
                Fxrp_SP_RPDANHSACHSINHVIEN f = new Fxrp_SP_RPDANHSACHSINHVIEN();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(Fxrp_SP_RPDONGHOCPHI));
            if (frm != null) frm.Activate();
            else
            {
                Fxrp_SP_RPDONGHOCPHI f = new Fxrp_SP_RPDONGHOCPHI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm1 = this.CheckExists(typeof(frmSinhVien));
            if (frm1 != null) frm1.Close();
            Form frm2 = this.CheckExists(typeof(frmMonHoc));
            if (frm2 != null) frm2.Close();
            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm2 = this.CheckExists(typeof(frmDiem));
            if (frm2 != null) frm2.Close();

            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Fxrp_SP_RPBANGDIEMTONGKET));
            if (frm != null) frm.Activate();
            else
            {
                Fxrp_SP_RPBANGDIEMTONGKET f = new Fxrp_SP_RPBANGDIEMTONGKET();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(cbkLop));
            if (frm != null) frm.Activate();
            else
            {
                cbkLop f = new cbkLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(Fxrp_RP_SPBANGDIEMMONHOC));
            if (frm != null) frm.Activate();
            else
            {
                Fxrp_RP_SPBANGDIEMMONHOC f = new Fxrp_RP_SPBANGDIEMMONHOC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(cbkMon));
            if (frm != null) frm.Activate();
            else
            {
                cbkMon f = new cbkMon();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}