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
    public partial class frmHocPhi : Form
    {
        String masv;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sP_DANHSACHSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACHSINHVIENTableAdapter.Fill(this.dS.SP_DANHSACHSINHVIEN);
            // TODO: This line of code loads data into the 'dS.SP_DANHSACHLOP' table. You can move, or remove it, as needed.
            this.masv = cbkSinhVien.SelectedValue.ToString();
            btnGhi.Enabled = false;
            groupControl2.Enabled = false;
            barButtonItem2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;

            String lenh = "SELECT HO+' '+TEN AS HOTEN ,MALOP FROM SINHVIEN WHERE MASV ='" + this.masv + "'";
            Program.myReader = Program.ExecSqlDataReader(lenh);
            Program.myReader.Read();
            hovaten.Text = "HỌ TÊN : " + Program.myReader.GetString(0);
            malop.Text = "MÃ LỚP : " + Program.myReader.GetString(1);
            try
            {
                this.HocphiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HocphiTableAdapter.Fill(this.dS.SP_THONGTINDONGHOCPHI, this.masv);

                btnGhi.Enabled = true;
                barButtonItem2.Enabled = true;
                groupControl1.Enabled = false;
                groupControl2.Enabled = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void cbkSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkSinhVien.SelectedIndex < 0) return;
            this.masv = cbkSinhVien.SelectedValue.ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            String maSV = this.masv;
            int hocPhi = Int32.Parse((((DataRowView)bsdHocphi[bsdHocphi.Position])["HOCPHI"].ToString())); ;
            String nienKhoa = (((DataRowView)bsdHocphi[bsdHocphi.Position])["NIENKHOA"].ToString());
            int hocKy = Int32.Parse((((DataRowView)bsdHocphi[bsdHocphi.Position])["HOCKY"].ToString()));
            int soTienDaDong = Int32.Parse((((DataRowView)bsdHocphi[bsdHocphi.Position])["SOTIENDADONG"].ToString()));
            int soTienDong = Int32.Parse((((DataRowView)bsdHocphi[bsdHocphi.Position])["SOTIENDONG"].ToString()));
           
            if (soTienDong <= 0)
            {
                MessageBox.Show("Không thể ghi !. Số tiền không thể âm hoặc bằng 0 vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);

                return;
            }
            if (soTienDong + soTienDaDong > hocPhi)
            {
                MessageBox.Show("Số tiền bạn đóng đã quá học phí vui lòng nhập lại !!/nSố tiền bạn phải đóng còn lại là :" + (hocPhi - soTienDaDong), "Thông báo", MessageBoxButtons.OK);

                return;
            }
            if (Program.KetNoi() == 0) return;

            String lenh = "EXEC SP_DONGHOCPHI '" + maSV + "','" + nienKhoa + "','" + hocKy + "'," + soTienDong + "";
            int n = Program.ExecSqlNonQuery(lenh);
            if (n == 0)
            {
                this.HocphiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HocphiTableAdapter.Fill(this.dS.SP_THONGTINDONGHOCPHI, this.masv);
                MessageBox.Show("Đóng tiền thành công", "Thông báo", MessageBoxButtons.OK);

          
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            barButtonItem2.Enabled = false;
            btnGhi.Enabled = false;
        }

      
    }
}
