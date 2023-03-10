namespace Perfect.Inventory.Core.Inventory.Init
{
    partial class XfmInventoryInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmInventoryInit));
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpInit = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarInit = new DevExpress.XtraNavBar.NavBarControl();
            this.IGInit = new DevExpress.XtraNavBar.NavBarGroup();
            this.IInventory = new DevExpress.XtraNavBar.NavBarItem();
            this.IInventoryExcel = new DevExpress.XtraNavBar.NavBarItem();
            this.niCustomerDebtInit = new DevExpress.XtraNavBar.NavBarItem();
            this.IList = new DevExpress.XtraNavBar.NavBarGroup();
            this.IListId = new DevExpress.XtraNavBar.NavBarItem();
            this.IListProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.IGDictionary = new DevExpress.XtraNavBar.NavBarGroup();
            this.IProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.niStock = new DevExpress.XtraNavBar.NavBarItem();
            this.niTempFile = new DevExpress.XtraNavBar.NavBarItem();
            this.imgCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            this.niProviderDebtInit = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dpInit.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dm
            // 
            this.dm.DockModeVS2005FadeSpeed = 800;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpInit});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpInit
            // 
            this.dpInit.Controls.Add(this.dockPanel1_Container);
            this.dpInit.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dpInit.ID = new System.Guid("0356d8e9-3e6b-42d6-969b-c587e1f05d60");
            this.dpInit.Location = new System.Drawing.Point(0, 0);
            this.dpInit.Name = "dpInit";
            this.dpInit.OriginalSize = new System.Drawing.Size(179, 200);
            this.dpInit.Size = new System.Drawing.Size(179, 676);
            this.dpInit.Text = "Chức Năng";
            this.dpInit.Layout += new System.Windows.Forms.LayoutEventHandler(this.DpInitLayout);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarInit);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(173, 648);
            this.dockPanel1_Container.TabIndex = 0;
            this.dockPanel1_Container.Layout += new System.Windows.Forms.LayoutEventHandler(this.DockPanel1ContainerLayout);
            // 
            // navBarInit
            // 
            this.navBarInit.ActiveGroup = this.IGInit;
            this.navBarInit.ContentButtonHint = null;
            this.navBarInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarInit.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.IGInit,
            this.IList,
            this.IGDictionary});
            this.navBarInit.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.IInventory,
            this.IProduct,
            this.niStock,
            this.niTempFile,
            this.IListId,
            this.IListProduct,
            this.IInventoryExcel,
            this.niCustomerDebtInit,
            this.niProviderDebtInit});
            this.navBarInit.Location = new System.Drawing.Point(0, 0);
            this.navBarInit.Name = "navBarInit";
            this.navBarInit.OptionsNavPane.ExpandedWidth = 278;
            this.navBarInit.Size = new System.Drawing.Size(173, 648);
            this.navBarInit.SmallImages = this.imgCollection;
            this.navBarInit.TabIndex = 0;
            this.navBarInit.Text = "navBarControl1";
            this.navBarInit.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Blue");
            this.navBarInit.Layout += new System.Windows.Forms.LayoutEventHandler(this.NavBarControl1Layout);
            // 
            // IGInit
            // 
            this.IGInit.Caption = "Đầu Kỳ";
            this.IGInit.Expanded = true;
            this.IGInit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.IInventory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IInventoryExcel),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niCustomerDebtInit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProviderDebtInit)});
            this.IGInit.Name = "IGInit";
            // 
            // IInventory
            // 
            this.IInventory.Caption = "Nhập Đầu Kỳ";
            this.IInventory.Name = "IInventory";
            this.IInventory.SmallImageIndex = 1;
            this.IInventory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IInventory_LinkClicked);
            // 
            // IInventoryExcel
            // 
            this.IInventoryExcel.Caption = "Nhập Từ Excel";
            this.IInventoryExcel.Name = "IInventoryExcel";
            this.IInventoryExcel.SmallImageIndex = 10;
            this.IInventoryExcel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IInventoryExcel_LinkClicked);
            // 
            // niCustomerDebtInit
            // 
            this.niCustomerDebtInit.Caption = "Công Nợ Khách Hàng";
            this.niCustomerDebtInit.Name = "niCustomerDebtInit";
            this.niCustomerDebtInit.SmallImageIndex = 9;
            this.niCustomerDebtInit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiCustomerDebtInitLinkClicked);
            // 
            // IList
            // 
            this.IList.Caption = "Bảng Kê Đầu Kỳ";
            this.IList.Expanded = true;
            this.IList.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.IListId),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IListProduct)});
            this.IList.Name = "IList";
            // 
            // IListId
            // 
            this.IListId.Caption = "Theo Kỳ";
            this.IListId.Name = "IListId";
            this.IListId.SmallImageIndex = 11;
            this.IListId.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IListId_LinkClicked);
            // 
            // IListProduct
            // 
            this.IListProduct.Caption = "Theo Hàng Hoá";
            this.IListProduct.Name = "IListProduct";
            this.IListProduct.SmallImageIndex = 11;
            this.IListProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IListProduct_LinkClicked);
            // 
            // IGDictionary
            // 
            this.IGDictionary.Caption = "Thêm Danh Mục";
            this.IGDictionary.Expanded = true;
            this.IGDictionary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.IProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niStock),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niTempFile)});
            this.IGDictionary.Name = "IGDictionary";
            // 
            // IProduct
            // 
            this.IProduct.Caption = "Hàng Hoá";
            this.IProduct.Name = "IProduct";
            this.IProduct.SmallImageIndex = 2;
            this.IProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IProduct_LinkClicked);
            // 
            // niStock
            // 
            this.niStock.Caption = "Kho Hàng";
            this.niStock.Name = "niStock";
            this.niStock.SmallImageIndex = 4;
            this.niStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiStockLinkClicked);
            // 
            // niTempFile
            // 
            this.niTempFile.Caption = "File Excel Mẫu";
            this.niTempFile.Name = "niTempFile";
            this.niTempFile.SmallImageIndex = 8;
            this.niTempFile.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiTempFileLinkClicked);
            // 
            // imgCollection
            // 
            this.imgCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imgCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollection.ImageStream")));
            this.imgCollection.Images.SetKeyName(0, "Ket Thuc.png");
            this.imgCollection.Images.SetKeyName(1, "Ton Kho.png");
            this.imgCollection.Images.SetKeyName(2, "Hang Hoa.png");
            this.imgCollection.Images.SetKeyName(3, "Khach Hang.png");
            this.imgCollection.Images.SetKeyName(4, "Kho.png");
            this.imgCollection.Images.SetKeyName(5, "Nha Phan Phoi.png");
            this.imgCollection.Images.SetKeyName(6, "Nhan Vien.png");
            this.imgCollection.Images.SetKeyName(7, "Phieu Chi.png");
            this.imgCollection.Images.SetKeyName(8, "Phieu Thu.png");
            this.imgCollection.Images.SetKeyName(9, "Quy Tien.png");
            this.imgCollection.Images.SetKeyName(10, "Action_Export_ToExcel_32x32.png");
            this.imgCollection.Images.SetKeyName(11, "Demo_Enum_Properties_32x32.png");
            // 
            // plMain
            // 
            this.plMain.AutoSize = true;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.FireScrollEventOnMouseWheel = true;
            this.plMain.Location = new System.Drawing.Point(179, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(681, 676);
            this.plMain.TabIndex = 6;
            this.plMain.Layout += new System.Windows.Forms.LayoutEventHandler(this.GcInitLayout);
            // 
            // niProviderDebtInit
            // 
            this.niProviderDebtInit.Caption = "Công Nợ NCC";
            this.niProviderDebtInit.Name = "niProviderDebtInit";
            this.niProviderDebtInit.SmallImageIndex = 9;
            this.niProviderDebtInit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiProviderDebtInitLinkClicked);
            // 
            // XfmInventoryInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 676);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.dpInit);
            this.Name = "XfmInventoryInit";
            this.Text = "Số Dư Đầu Kỳ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XfmInventoryInit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dpInit.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.Docking.DockPanel dpInit;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarInit;
        private DevExpress.XtraNavBar.NavBarGroup IGInit;
        private DevExpress.XtraNavBar.NavBarItem IInventory;
        private DevExpress.Utils.ImageCollection imgCollection;
        private DevExpress.XtraNavBar.NavBarGroup IGDictionary;
        private DevExpress.XtraNavBar.NavBarItem IProduct;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niStock;
        private DevExpress.XtraNavBar.NavBarItem niTempFile;
        private DevExpress.XtraNavBar.NavBarGroup IList;
        private DevExpress.XtraNavBar.NavBarItem IListId;
        private DevExpress.XtraNavBar.NavBarItem IListProduct;
        private DevExpress.XtraNavBar.NavBarItem IInventoryExcel;
        private DevExpress.XtraNavBar.NavBarItem niCustomerDebtInit;
        private DevExpress.XtraNavBar.NavBarItem niProviderDebtInit;
    }
}