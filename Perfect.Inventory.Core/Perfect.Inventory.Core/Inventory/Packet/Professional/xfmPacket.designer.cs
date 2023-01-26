using Perfect.Inventory;

namespace Perfect.Inventory
{
    partial class xfmPacket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmPacket));
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dplPacket = new DevExpress.XtraBars.Docking.DockPanel();
            this.dpcMain = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvList = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgPacket = new DevExpress.XtraNavBar.NavBarGroup();
            this.niPackBTP = new DevExpress.XtraNavBar.NavBarItem();
            this.niPacketTP = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgList = new DevExpress.XtraNavBar.NavBarGroup();
            this.niList = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.niMerrialList = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgDictionary = new DevExpress.XtraNavBar.NavBarGroup();
            this.niProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.niEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.niStock = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dplPacket.SuspendLayout();
            this.dpcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dm
            // 
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.DockModeVS2005FadeSpeed = 1000;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dplPacket});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dplPacket
            // 
            this.dplPacket.Controls.Add(this.dpcMain);
            this.dplPacket.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dplPacket.ID = new System.Guid("6a3e5b5c-94a6-499b-b2c4-2e10e7263317");
            this.dplPacket.Location = new System.Drawing.Point(0, 0);
            this.dplPacket.Name = "dplPacket";
            this.dplPacket.OriginalSize = new System.Drawing.Size(165, 200);
            this.dplPacket.Size = new System.Drawing.Size(165, 624);
            this.dplPacket.Text = "Chức Năng";
            this.dplPacket.Layout += new System.Windows.Forms.LayoutEventHandler(this.dplPacket_Layout);
            // 
            // dpcMain
            // 
            this.dpcMain.Controls.Add(this.nvList);
            this.dpcMain.Location = new System.Drawing.Point(3, 25);
            this.dpcMain.Name = "dpcMain";
            this.dpcMain.Size = new System.Drawing.Size(159, 596);
            this.dpcMain.TabIndex = 0;
            this.dpcMain.Layout += new System.Windows.Forms.LayoutEventHandler(this.dplPacket_Layout);
            // 
            // nvList
            // 
            this.nvList.ActiveGroup = this.nvgPacket;
            this.nvList.ContentButtonHint = null;
            this.nvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvList.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvgPacket,
            this.nvgList,
            this.nvgDictionary});
            this.nvList.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niPackBTP,
            this.niPacketTP,
            this.niList,
            this.nvgDetailList,
            this.niProduct,
            this.niEmployee,
            this.niStock,
            this.niMerrialList});
            this.nvList.LargeImages = this.imageCollection2;
            this.nvList.Location = new System.Drawing.Point(0, 0);
            this.nvList.Name = "nvList";
            this.nvList.OptionsNavPane.ExpandedWidth = 189;
            this.nvList.Size = new System.Drawing.Size(159, 596);
            this.nvList.SmallImages = this.imageCollection2;
            this.nvList.TabIndex = 0;
            this.nvList.Text = "navBarControl1";
            // 
            // nvgPacket
            // 
            this.nvgPacket.Caption = "Đóng Gói - Lắp Ráp";
            this.nvgPacket.Expanded = true;
            this.nvgPacket.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niPackBTP),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niPacketTP)});
            this.nvgPacket.Name = "nvgPacket";
            // 
            // niPackBTP
            // 
            this.niPackBTP.Caption = "Bán Thành Phẩm";
            this.niPackBTP.LargeImageIndex = 18;
            this.niPackBTP.Name = "niPackBTP";
            this.niPackBTP.SmallImageIndex = 18;
            this.niPackBTP.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niPackBTP_LinkClicked);
            // 
            // niPacketTP
            // 
            this.niPacketTP.Caption = "Thành Phẩm";
            this.niPacketTP.Name = "niPacketTP";
            this.niPacketTP.SmallImageIndex = 19;
            this.niPacketTP.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niPacketTP_LinkClicked);
            // 
            // nvgList
            // 
            this.nvgList.Caption = "Bảng Kê Đóng Gói";
            this.nvgList.Expanded = true;
            this.nvgList.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvgDetailList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niMerrialList)});
            this.nvgList.Name = "nvgList";
            // 
            // niList
            // 
            this.niList.Caption = "Theo Chứng Từ";
            this.niList.Name = "niList";
            this.niList.SmallImageIndex = 9;
            this.niList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niList_LinkClicked);
            // 
            // nvgDetailList
            // 
            this.nvgDetailList.Caption = "Theo Hàng Nhập";
            this.nvgDetailList.Name = "nvgDetailList";
            this.nvgDetailList.SmallImageIndex = 9;
            this.nvgDetailList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvgDetailList_LinkClicked);
            // 
            // niMerrialList
            // 
            this.niMerrialList.Caption = "Theo Hàng Xuất";
            this.niMerrialList.Name = "niMerrialList";
            this.niMerrialList.SmallImageIndex = 9;
            this.niMerrialList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niMerrialList_LinkClicked);
            // 
            // nvgDictionary
            // 
            this.nvgDictionary.Caption = "Thêm Danh Mục";
            this.nvgDictionary.Expanded = true;
            this.nvgDictionary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niEmployee),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niStock)});
            this.nvgDictionary.Name = "nvgDictionary";
            // 
            // niProduct
            // 
            this.niProduct.Caption = "Hàng Hoá, Vật Tư";
            this.niProduct.Name = "niProduct";
            this.niProduct.SmallImageIndex = 15;
            this.niProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niProduct_LinkClicked);
            // 
            // niEmployee
            // 
            this.niEmployee.Caption = "Nhân Viên";
            this.niEmployee.Name = "niEmployee";
            this.niEmployee.SmallImageIndex = 17;
            this.niEmployee.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niEmployee_LinkClicked);
            // 
            // niStock
            // 
            this.niStock.Caption = "Kho Hàng";
            this.niStock.Name = "niStock";
            this.niStock.SmallImageIndex = 16;
            this.niStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niStock_LinkClicked);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(9, "table.ico");
            this.imageCollection2.Images.SetKeyName(10, "blank2.ico");
            this.imageCollection2.Images.SetKeyName(11, "blank.ico");
            this.imageCollection2.Images.SetKeyName(12, "database table.ico");
            this.imageCollection2.Images.SetKeyName(13, "list.ico");
            this.imageCollection2.Images.SetKeyName(14, "pro.ico");
            this.imageCollection2.Images.SetKeyName(15, "Hang Hoa.png");
            this.imageCollection2.Images.SetKeyName(16, "Kho.png");
            this.imageCollection2.Images.SetKeyName(17, "Nhan Vien.png");
            this.imageCollection2.Images.SetKeyName(18, "Dong Goi BTP.png");
            this.imageCollection2.Images.SetKeyName(19, "Dong Goi Thanh Pham.png");
            this.imageCollection2.Images.SetKeyName(20, "Bang Ke Lap Rap.png");
            // 
            // plMain
            // 
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(165, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(836, 624);
            this.plMain.TabIndex = 1;
            // 
            // xfmPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 624);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.dplPacket);
            this.Name = "xfmPacket";
            this.Text = "Đóng Gói - Lắp Ráp";
            this.Activated += new System.EventHandler(this.xfmPacket_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfmSale_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dplPacket.ResumeLayout(false);
            this.dpcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.Docking.DockPanel dplPacket;
        private DevExpress.XtraBars.Docking.ControlContainer dpcMain;
        private DevExpress.XtraNavBar.NavBarControl nvList;
        private DevExpress.XtraNavBar.NavBarGroup nvgPacket;
        private DevExpress.XtraNavBar.NavBarItem niPackBTP;
        private DevExpress.XtraNavBar.NavBarItem niPacketTP;
        private DevExpress.XtraNavBar.NavBarGroup nvgList;
        private DevExpress.XtraNavBar.NavBarItem niList;
        private DevExpress.XtraNavBar.NavBarItem nvgDetailList;
        private DevExpress.XtraNavBar.NavBarGroup nvgDictionary;
        private DevExpress.XtraNavBar.NavBarItem niProduct;
        private DevExpress.XtraNavBar.NavBarItem niEmployee;
        private DevExpress.XtraNavBar.NavBarItem niStock;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niMerrialList;
    }
}