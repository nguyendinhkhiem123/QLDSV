namespace QLDSV
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.System = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Action = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribKhoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribLop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribKetoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDetail,
            this.btnLogOut,
            this.btnBackup,
            this.btnRestore,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barStaticItem2,
            this.barButtonItem13});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.System,
            this.Action,
            this.ribbonPage3});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.ribbon.Size = new System.Drawing.Size(869, 231);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "Tạo Tài Khoản";
            this.btnDetail.Id = 1;
            this.btnDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.ImageOptions.Image")));
            this.btnDetail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDetail.ImageOptions.LargeImage")));
            this.btnDetail.ImageOptions.LargeImageIndex = 1;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 3;
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.Image")));
            this.btnLogOut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ImageOptions.LargeImage")));
            this.btnLogOut.ImageOptions.LargeImageIndex = 3;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Đổi Mật Khẩu";
            this.btnBackup.Id = 4;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Xóa Tài Khoản";
            this.btnRestore.Id = 5;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh Sách Lớp";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Điểm";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh Sách Sinh Viên";
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Môn Học";
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Đóng Học Phí";
            this.barButtonItem5.Id = 13;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Danh Sách Sinh Viên";
            this.barButtonItem6.Id = 14;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Danh Sách Đóng Học Phí";
            this.barButtonItem7.Id = 15;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Bảng Điểm Thi";
            this.barButtonItem8.Id = 16;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Bảng Điểm Môn Học";
            this.barButtonItem9.Id = 17;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Phiếu Điểm";
            this.barButtonItem10.Id = 18;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Bảng Điểm Tổng Kết";
            this.barButtonItem11.Id = 19;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "barButtonItem12";
            this.barButtonItem12.Id = 20;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = 21;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Chuyển lớp";
            this.barButtonItem13.Id = 22;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // System
            // 
            this.System.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ri,
            this.ribbonPageGroup3});
            this.System.Name = "System";
            this.System.Text = "HỆ THỐNG";
            // 
            // ri
            // 
            this.ri.ItemLinks.Add(this.btnDetail);
            this.ri.ItemLinks.Add(this.btnLogOut);
            this.ri.Name = "ri";
            this.ri.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Giao diện";
            // 
            // Action
            // 
            this.Action.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribKhoa,
            this.ribLop,
            this.ribKetoan});
            this.Action.Name = "Action";
            this.Action.Text = "DANH SÁCH";
            // 
            // ribKhoa
            // 
            this.ribKhoa.ItemLinks.Add(this.barButtonItem1);
            this.ribKhoa.ItemLinks.Add(this.barButtonItem2);
            this.ribKhoa.Name = "ribKhoa";
            this.ribKhoa.Text = "Khoa";
            // 
            // ribLop
            // 
            this.ribLop.ItemLinks.Add(this.barButtonItem3);
            this.ribLop.ItemLinks.Add(this.barButtonItem4);
            this.ribLop.ItemLinks.Add(this.barButtonItem13);
            this.ribLop.Name = "ribLop";
            this.ribLop.Text = "Lớp";
            // 
            // ribKetoan
            // 
            this.ribKetoan.ItemLinks.Add(this.barButtonItem5);
            this.ribKetoan.Name = "ribKetoan";
            this.ribKetoan.Text = "Kế Toán";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup8});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Hồ Sơ Khoa";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Hồ Sơ Sinh Viên";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 473);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(869, 36);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(869, 509);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Điểm Sinh Viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage System;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ri;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage Action;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribKhoa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribLop;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribKetoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
    }
}