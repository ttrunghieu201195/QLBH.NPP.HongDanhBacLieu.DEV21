namespace Perfect.Sale.Core.INITS
{
    partial class XfmSaleInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmSaleInit));
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpInit = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarInit = new DevExpress.XtraNavBar.NavBarControl();
            this.IGInit = new DevExpress.XtraNavBar.NavBarGroup();
            this.ICustomerInit = new DevExpress.XtraNavBar.NavBarItem();
            this.IProviderInit = new DevExpress.XtraNavBar.NavBarItem();
            this.IEmployeeInit = new DevExpress.XtraNavBar.NavBarItem();
            this.ICashInit = new DevExpress.XtraNavBar.NavBarItem();
            this.navInventoryInit = new DevExpress.XtraNavBar.NavBarGroup();
            this.niProductInit = new DevExpress.XtraNavBar.NavBarItem();
            this.IInventory = new DevExpress.XtraNavBar.NavBarItem();
            this.niImportExcel = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.niList = new DevExpress.XtraNavBar.NavBarItem();
            this.niListProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.IGDictionary = new DevExpress.XtraNavBar.NavBarGroup();
            this.IProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.ICustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.IProvider = new DevExpress.XtraNavBar.NavBarItem();
            this.IEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.ICash = new DevExpress.XtraNavBar.NavBarItem();
            this.niExcelFile = new DevExpress.XtraNavBar.NavBarItem();
            this.imgCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.plMain = new DevExpress.XtraEditors.GroupControl();
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
            this.dm.DockingOptions.ShowCloseButton = false;
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
            this.dpInit.OriginalSize = new System.Drawing.Size(165, 200);
            this.dpInit.Size = new System.Drawing.Size(165, 676);
            this.dpInit.Text = "Chức Năng";
            this.dpInit.Layout += new System.Windows.Forms.LayoutEventHandler(this.DpInitLayout);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarInit);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(159, 644);
            this.dockPanel1_Container.TabIndex = 0;
            this.dockPanel1_Container.Layout += new System.Windows.Forms.LayoutEventHandler(this.DockPanel1ContainerLayout);
            // 
            // navBarInit
            // 
            this.navBarInit.ActiveGroup = this.navInventoryInit;
            this.navBarInit.ContentButtonHint = null;
            this.navBarInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarInit.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navInventoryInit,
            this.navBarGroup1,
            this.IGInit,
            this.IGDictionary});
            this.navBarInit.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.IInventory,
            this.ICustomerInit,
            this.IProviderInit,
            this.IEmployeeInit,
            this.ICashInit,
            this.IProduct,
            this.ICustomer,
            this.IProvider,
            this.IEmployee,
            this.ICash,
            this.niProductInit,
            this.niImportExcel,
            this.niList,
            this.niListProduct,
            this.niExcelFile});
            this.navBarInit.Location = new System.Drawing.Point(0, 0);
            this.navBarInit.Name = "navBarInit";
            this.navBarInit.OptionsNavPane.ExpandedWidth = 278;
            this.navBarInit.Size = new System.Drawing.Size(159, 644);
            this.navBarInit.SmallImages = this.imgCollection;
            this.navBarInit.TabIndex = 0;
            this.navBarInit.Text = "navBarControl1";
            this.navBarInit.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            this.navBarInit.Layout += new System.Windows.Forms.LayoutEventHandler(this.NavBarControl1Layout);
            // 
            // IGInit
            // 
            this.IGInit.Caption = "Công Nợ Đầu Kỳ";
            this.IGInit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.ICustomerInit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IProviderInit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IEmployeeInit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ICashInit)});
            this.IGInit.Name = "IGInit";
            // 
            // ICustomerInit
            // 
            this.ICustomerInit.Caption = "Khách Hàng";
            this.ICustomerInit.Name = "ICustomerInit";
            this.ICustomerInit.SmallImageIndex = 9;
            this.ICustomerInit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ICustomerInit_LinkClicked);
            // 
            // IProviderInit
            // 
            this.IProviderInit.Caption = "Nhà Cung Cấp";
            this.IProviderInit.Name = "IProviderInit";
            this.IProviderInit.SmallImageIndex = 9;
            this.IProviderInit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IProviderInit_LinkClicked);
            // 
            // IEmployeeInit
            // 
            this.IEmployeeInit.Caption = "Nhân Viên";
            this.IEmployeeInit.Enabled = false;
            this.IEmployeeInit.Name = "IEmployeeInit";
            this.IEmployeeInit.SmallImageIndex = 6;
            this.IEmployeeInit.Visible = false;
            // 
            // ICashInit
            // 
            this.ICashInit.Caption = "Quỹ Tiền";
            this.ICashInit.Enabled = false;
            this.ICashInit.Name = "ICashInit";
            this.ICashInit.SmallImageIndex = 9;
            this.ICashInit.Visible = false;
            // 
            // navInventoryInit
            // 
            this.navInventoryInit.Caption = "Tồn Kho Đầu Kỳ";
            this.navInventoryInit.Expanded = true;
            this.navInventoryInit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProductInit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IInventory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niImportExcel)});
            this.navInventoryInit.Name = "navInventoryInit";
            // 
            // niProductInit
            // 
            this.niProductInit.Caption = "Tồn Kho";
            this.niProductInit.Name = "niProductInit";
            this.niProductInit.SmallImageIndex = 4;
            this.niProductInit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IInventory_LinkClicked);
            // 
            // IInventory
            // 
            this.IInventory.Caption = "Tồn Kho";
            this.IInventory.Name = "IInventory";
            this.IInventory.SmallImageIndex = 1;
            this.IInventory.Visible = false;
            this.IInventory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IInventory_LinkClicked);
            // 
            // niImportExcel
            // 
            this.niImportExcel.Caption = "Nhập từ Excel";
            this.niImportExcel.Name = "niImportExcel";
            this.niImportExcel.SmallImageIndex = 12;
            this.niImportExcel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiImportExcelLinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Bảng Kê";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niListProduct)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // niList
            // 
            this.niList.Caption = "Theo Kỳ";
            this.niList.Name = "niList";
            this.niList.SmallImageIndex = 11;
            this.niList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiListLinkClicked);
            // 
            // niListProduct
            // 
            this.niListProduct.Caption = "Theo Hàng Hoá";
            this.niListProduct.Name = "niListProduct";
            this.niListProduct.SmallImageIndex = 11;
            this.niListProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiListProductLinkClicked);
            // 
            // IGDictionary
            // 
            this.IGDictionary.Caption = "Thêm Danh Mục";
            this.IGDictionary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.IProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ICustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IProvider),
            new DevExpress.XtraNavBar.NavBarItemLink(this.IEmployee),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ICash),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niExcelFile)});
            this.IGDictionary.Name = "IGDictionary";
            // 
            // IProduct
            // 
            this.IProduct.Caption = "Hàng Hoá";
            this.IProduct.Name = "IProduct";
            this.IProduct.SmallImageIndex = 2;
            this.IProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IProduct_LinkClicked);
            // 
            // ICustomer
            // 
            this.ICustomer.Caption = "Khách Hàng";
            this.ICustomer.Name = "ICustomer";
            this.ICustomer.SmallImageIndex = 3;
            this.ICustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ICustomer_LinkClicked);
            // 
            // IProvider
            // 
            this.IProvider.Caption = "Nhà Cung Cấp";
            this.IProvider.Name = "IProvider";
            this.IProvider.SmallImageIndex = 5;
            this.IProvider.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.IProvider_LinkClicked);
            // 
            // IEmployee
            // 
            this.IEmployee.Caption = "Thêm Nhân Viên";
            this.IEmployee.Enabled = false;
            this.IEmployee.Hint = "New Verion";
            this.IEmployee.Name = "IEmployee";
            this.IEmployee.SmallImageIndex = 6;
            this.IEmployee.Visible = false;
            // 
            // ICash
            // 
            this.ICash.Caption = "Thêm Quỹ Tiền";
            this.ICash.Enabled = false;
            this.ICash.Name = "ICash";
            this.ICash.SmallImageIndex = 9;
            this.ICash.Visible = false;
            // 
            // niExcelFile
            // 
            this.niExcelFile.Caption = "File Excel Mẫu";
            this.niExcelFile.Name = "niExcelFile";
            this.niExcelFile.SmallImageIndex = 10;
            this.niExcelFile.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiExcelFileLinkClicked);
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
            this.imgCollection.Images.SetKeyName(10, "Excel.png");
            this.imgCollection.Images.SetKeyName(11, "List (1).png");
            this.imgCollection.Images.SetKeyName(12, "Excel.png");
            this.imgCollection.Images.SetKeyName(13, "page_excel.png");
            // 
            // plMain
            // 
            this.plMain.AutoSize = true;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.FireScrollEventOnMouseWheel = true;
            this.plMain.Location = new System.Drawing.Point(165, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(791, 676);
            this.plMain.TabIndex = 6;
            this.plMain.Layout += new System.Windows.Forms.LayoutEventHandler(this.GcInitLayout);
            // 
            // XfmSaleInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 676);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.dpInit);
            this.Name = "XfmSaleInit";
            this.Text = "Số Dư Đầu Kỳ";
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
        private DevExpress.XtraNavBar.NavBarItem ICustomerInit;
        private DevExpress.XtraNavBar.NavBarItem IProviderInit;
        private DevExpress.XtraNavBar.NavBarItem IEmployeeInit;
        private DevExpress.Utils.ImageCollection imgCollection;
        private DevExpress.XtraNavBar.NavBarItem ICashInit;
        private DevExpress.XtraNavBar.NavBarGroup IGDictionary;
        private DevExpress.XtraNavBar.NavBarItem IProduct;
        private DevExpress.XtraNavBar.NavBarItem ICustomer;
        private DevExpress.XtraNavBar.NavBarItem IProvider;
        private DevExpress.XtraNavBar.NavBarItem IEmployee;
        private DevExpress.XtraNavBar.NavBarItem ICash;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niProductInit;
        private DevExpress.XtraNavBar.NavBarItem niImportExcel;
        private DevExpress.XtraNavBar.NavBarGroup navInventoryInit;
        private DevExpress.XtraNavBar.NavBarItem niList;
        private DevExpress.XtraNavBar.NavBarItem niListProduct;
        private DevExpress.XtraNavBar.NavBarItem niExcelFile;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    }
}