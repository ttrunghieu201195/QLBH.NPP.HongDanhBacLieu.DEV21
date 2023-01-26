namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    partial class xfmAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmTransfer));
            this.image = new DevExpress.Utils.ImageCollection(this.components);
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dplTransfer = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvTransfer = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgTransfer = new DevExpress.XtraNavBar.NavBarGroup();
            this.niTransfer = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgList = new DevExpress.XtraNavBar.NavBarGroup();
            this.niTransferList = new DevExpress.XtraNavBar.NavBarItem();
            this.niDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgDictionary = new DevExpress.XtraNavBar.NavBarGroup();
            this.niProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.niStock = new DevExpress.XtraNavBar.NavBarItem();
            this.niEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dplTransfer.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.ImageSize = new System.Drawing.Size(32, 32);
            this.image.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("image.ImageStream")));
            this.image.Images.SetKeyName(0, "1318304491_order-1.png");
            this.image.Images.SetKeyName(1, "1318304498_list.png");
            this.image.Images.SetKeyName(2, "1318306141_customers.png");
            this.image.Images.SetKeyName(3, "1318319147_Download_Crate.png");
            this.image.Images.SetKeyName(4, "BO_Address_32x32.png");
            this.image.Images.SetKeyName(5, "BO_Contract_32x32.png");
            // 
            // dm
            // 
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.DockModeVS2005FadeSpeed = 1000;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dplTransfer});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dplTransfer
            // 
            this.dplTransfer.Controls.Add(this.dockPanel1_Container);
            this.dplTransfer.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dplTransfer.ID = new System.Guid("eedb657c-dad2-42ff-9d38-2a7119214c06");
            this.dplTransfer.Location = new System.Drawing.Point(0, 0);
            this.dplTransfer.Name = "dplTransfer";
            this.dplTransfer.OriginalSize = new System.Drawing.Size(155, 200);
            this.dplTransfer.Size = new System.Drawing.Size(155, 726);
            this.dplTransfer.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nvTransfer);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(149, 694);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // nvTransfer
            // 
            this.nvTransfer.ActiveGroup = this.nvgTransfer;
            this.nvTransfer.ContentButtonHint = null;
            this.nvTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvTransfer.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvgTransfer,
            this.nvgList,
            this.nvgDictionary});
            this.nvTransfer.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niTransfer,
            this.niTransferList,
            this.niDetailList,
            this.niProduct,
            this.niStock,
            this.niEmployee});
            this.nvTransfer.LargeImages = this.image;
            this.nvTransfer.Location = new System.Drawing.Point(0, 0);
            this.nvTransfer.Name = "nvTransfer";
            this.nvTransfer.OptionsNavPane.ExpandedWidth = 199;
            this.nvTransfer.Size = new System.Drawing.Size(149, 694);
            this.nvTransfer.SmallImages = this.image;
            this.nvTransfer.TabIndex = 0;
            this.nvTransfer.Text = "navBarControl1";
            // 
            // nvgTransfer
            // 
            this.nvgTransfer.Caption = "Chuyển Kho";
            this.nvgTransfer.Expanded = true;
            this.nvgTransfer.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgTransfer.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niTransfer)});
            this.nvgTransfer.Name = "nvgTransfer";
            // 
            // niTransfer
            // 
            this.niTransfer.Caption = "Phiếu Chuyển Kho";
            this.niTransfer.LargeImageIndex = 5;
            this.niTransfer.Name = "niTransfer";
            this.niTransfer.SmallImageIndex = 11;
            this.niTransfer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiTransferLinkClicked);
            // 
            // nvgList
            // 
            this.nvgList.Caption = "Bảng Kê";
            this.nvgList.Expanded = true;
            this.nvgList.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgList.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niTransferList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niDetailList)});
            this.nvgList.Name = "nvgList";
            // 
            // niTransferList
            // 
            this.niTransferList.Caption = "Theo Chứng Từ";
            this.niTransferList.LargeImageIndex = 1;
            this.niTransferList.Name = "niTransferList";
            this.niTransferList.SmallImageIndex = 1;
            this.niTransferList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiTransferListLinkClicked);
            // 
            // niDetailList
            // 
            this.niDetailList.Caption = "Theo Hàng Hoá";
            this.niDetailList.LargeImageIndex = 1;
            this.niDetailList.Name = "niDetailList";
            this.niDetailList.SmallImageIndex = 1;
            this.niDetailList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiDetailListLinkClicked);
            // 
            // nvgDictionary
            // 
            this.nvgDictionary.Caption = "Thêm Danh Mục";
            this.nvgDictionary.Expanded = true;
            this.nvgDictionary.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgDictionary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niStock),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niEmployee)});
            this.nvgDictionary.Name = "nvgDictionary";
            // 
            // niProduct
            // 
            this.niProduct.Caption = "Hàng Hoá";
            this.niProduct.LargeImageIndex = 3;
            this.niProduct.Name = "niProduct";
            this.niProduct.SmallImageIndex = 3;
            this.niProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiProductLinkClicked);
            // 
            // niStock
            // 
            this.niStock.Caption = "Kho Hàng";
            this.niStock.LargeImageIndex = 4;
            this.niStock.Name = "niStock";
            this.niStock.SmallImageIndex = 4;
            this.niStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiStockLinkClicked);
            // 
            // niEmployee
            // 
            this.niEmployee.Caption = "Nhân Viên";
            this.niEmployee.LargeImageIndex = 2;
            this.niEmployee.Name = "niEmployee";
            this.niEmployee.SmallImageIndex = 2;
            this.niEmployee.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiEmployeeLinkClicked);
            // 
            // plMain
            // 
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(155, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(841, 726);
            this.plMain.TabIndex = 1;
            // 
            // XfmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 726);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.dplTransfer);
            this.Name = "XfmTransfer";
            this.Text = "Chuyển Kho";
            this.Activated += new System.EventHandler(this.XfmTransferActivated);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dplTransfer.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.Utils.ImageCollection image;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.Docking.DockPanel dplTransfer;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl nvTransfer;
        private DevExpress.XtraNavBar.NavBarGroup nvgTransfer;
        private DevExpress.XtraNavBar.NavBarItem niTransfer;
        private DevExpress.XtraNavBar.NavBarGroup nvgList;
        private DevExpress.XtraNavBar.NavBarItem niTransferList;
        private DevExpress.XtraNavBar.NavBarItem niDetailList;
        private DevExpress.XtraNavBar.NavBarGroup nvgDictionary;
        private DevExpress.XtraNavBar.NavBarItem niProduct;
        private DevExpress.XtraNavBar.NavBarItem niStock;
        private DevExpress.XtraNavBar.NavBarItem niEmployee;
        private DevExpress.XtraEditors.GroupControl plMain;
    }
}