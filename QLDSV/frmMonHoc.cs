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
    public partial class frmMonHoc : Form
    {
        int vitri;
        int trangThai; // 1 là sửa , 0 là thêm
        string mamh;
        string tenmh;
        Stack<MonHoc> undo = new Stack<MonHoc>();
        public frmMonHoc()
        {
            InitializeComponent();
        }


        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);

            btnGhi.Enabled = btnHuy.Enabled = false;
            groupControl2.Enabled = false;
            btnPhucHoi.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bsdMonHoc.Position;
            bsdMonHoc.AddNew();           // thao tác chuẩn bị thêm 1 new item/row 
            trangThai = 0;
            txtMaMH.ReadOnly = false;
            //custom từng nút lệnh
            groupControl1.Enabled = false;
            groupControl2.Enabled = true;

            btnGhi.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaMH.Focus();
            }
            else if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
               
                txtTenMH.Focus();
            }
            else
            {
                try
                {
                   
                    groupControl1.Enabled = true;
                    groupControl2.Enabled = false;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                  
                    if (trangThai == 0)
                    {
                        mamh = txtMaMH.Text;
                        tenmh = txtTenMH.Text;
                        MonHoc mh = new MonHoc(mamh, tenmh, 0);
                        undo.Push(mh);
                    }
                    else if(trangThai == 1)
                    {
                        MonHoc mh = new MonHoc(mamh,tenmh, 1);
                        undo.Push(mh);

                    }
                    btnPhucHoi.Enabled = true;
                    bsdMonHoc.EndEdit();        // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                    bsdMonHoc.ResetCurrentItem();       // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);         // cập nhật dl từ dataset về database thông qua tableadapter
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    MessageBox.Show("Ghi thành công", "Thông báo !", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã môn học bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        MessageBox.Show("Tên môn học bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        
                    }
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bsdMonHoc.CancelEdit();
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            groupControl1.Enabled = true;
            groupControl2.Enabled = false;

            btnGhi.Enabled = false;
            btnHuy.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                undo.Clear();
                btnPhucHoi.Enabled = false;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                //btnPhucHoi.Enabled = false;
            }
            catch(Exception ex)
            {

            }
        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bsdMonHoc.Position;       // thao tác chuẩn bị thêm 1 new item/row 
            trangThai = 1;
            mamh = (((DataRowView)bsdMonHoc[bsdMonHoc.Position])["MAMH"].ToString());
            tenmh = (((DataRowView)bsdMonHoc[bsdMonHoc.Position])["TENMH"].ToString());
            //custom từng nút lệnh
            groupControl1.Enabled = false;
            groupControl2.Enabled = true;
            txtMaMH.ReadOnly = true;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bsdMonHoc.Count == 0)
            {   
                 MessageBox.Show("Môn học không có, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (bsdDiem.Count > 0)
                {
                    MessageBox.Show("Môn học hiện đang có điểm sinh viên, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa Môn học ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        
                        try
                        {
                            string maMonHoc = (((DataRowView)bsdMonHoc[bsdMonHoc.Position])["MAMH"].ToString());
                            string tenMonHoc = (((DataRowView)bsdMonHoc[bsdMonHoc.Position])["TENMH"].ToString());
                            MonHoc mh = new MonHoc(maMonHoc,tenMonHoc,2);
                            undo.Push(mh);
                            bsdMonHoc.RemoveCurrent();          //xóa row đang chọn ra khỏi dataset
                            //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                            //this.bdsMONHOC.ResetCurrentItem();
                            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                            MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK);
                            btnPhucHoi.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (undo.Count == 0)
            {
                MessageBox.Show("Không thể quay lại !", "Thông báo", MessageBoxButtons.OK);
            }
            if (undo.Count > 0)
            {
                MonHoc mh = undo.Pop();
              
                if(mh.Key == 0)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "DELETE FROM MONHOC WHERE MAMH='" + mh.MaMon + "'";
                    int k = Program.ExecSqlNonQuery(s);
                    if(k == 0)
                    {
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    }
                }   
                if(mh.Key == 1)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "UPDATE MONHOC SET TENMH=N'" + mh.TenMon + "' WHERE MAMH='"+mh.MaMon+"'";
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    }
                }   
                if(mh.Key == 2)
                {
                    if (Program.KetNoi() == 0) return;
                    string s = "INSERT INTO MONHOC(MAMH,TENMH) VALUES('"+mh.MaMon+"',N'"+mh.TenMon+"')" ;
                    int k = Program.ExecSqlNonQuery(s);
                    if (k == 0)
                    {
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    }
                }    
                
            }
            if(undo.Count == 0) btnPhucHoi.Enabled = false;
        }
    }
}
