namespace Perfect.Inventory.Core.Inventory.Inward.SALE
{
    partial class XfmInward
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmInward));
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.image = new DevExpress.Utils.ImageCollection(this.components);
            this.dplInward = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvInward = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgInward = new DevExpress.XtraNavBar.NavBarGroup();
            this.niInward = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgList = new DevExpress.XtraNavBar.NavBarGroup();
            this.niInwardList = new DevExpress.XtraNavBar.NavBarItem();
            this.niInwardDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgDictionary = new DevExpress.XtraNavBar.NavBarGroup();
            this.niProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.niCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.niStock = new DevExpress.XtraNavBar.NavBarItem();
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.dplInward.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvInward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dm
            // 
            this.dm.DockingOptions.CloseActiveTabOnly = false;
            this.dm.DockingOptions.FloatOnDblClick = false;
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.DockingOptions.ShowMaximizeButton = false;
            this.dm.DockModeVS2005FadeSpeed = 1500;
            this.dm.Form = this;
            this.dm.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dm.Images = this.image;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dplInward});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(100, 60);
            this.dockPanel1.ID = new System.Guid("8a44a12b-9680-4fe3-8d78-97264fcad19a");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 1;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(2, 24);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(196, 174);
            this.controlContainer1.TabIndex = 0;
            // 
            // image
            // 
            this.image.ImageSize = new System.Drawing.Size(32, 32);
            this.image.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("image.ImageStream")));
            this.image.Images.SetKeyName(0, "1318304491_order-1.png");
            this.image.Images.SetKeyName(1, "1318304498_list.png");
            this.image.Images.SetKeyName(2, "1318319147_Download_Crate.png");
            this.image.Images.SetKeyName(3, "1318306141_customers.png");
            this.image.Images.SetKeyName(4, "BO_Contract_32x32.png");
            this.image.Images.SetKeyName(5, "BO_Address_32x32.png");
            // 
            // dplInward
            // 
            this.dplInward.Controls.Add(this.dockPanel1_Container);
            this.dplInward.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dplInward.ID = new System.Guid("4811b77b-16dc-47d5-a21c-f4f3c87a9e98");
            this.dplInward.Location = new System.Drawing.Point(0, 0);
            this.dplInward.Name = "dplInward";
            this.dplInward.OriginalSize = new System.Drawing.Size(152, 200);
            this.dplInward.Size = new System.Drawing.Size(152, 728);
            this.dplInward.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nvInward);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(146, 700);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // nvInward
            // 
            this.nvInward.ActiveGroup = this.nvgInward;
            this.nvInward.ContentButtonHint = null;
            this.nvInward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvInward.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvgInward,
            this.nvgList,
            this.nvgDictionary});
            this.nvInward.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niInward,
            this.niInwardList,
            this.niProduct,
            this.niCustomer,
            this.niInwardDetailList,
            this.niStock});
            this.nvInward.LargeImages = this.image;
            this.nvInward.Location = new System.Drawing.Point(0, 0);
            this.nvInward.Name = "nvInward";
            this.nvInward.OptionsNavPane.ExpandedWidth = 297;
            this.nvInward.Size = new System.Drawing.Size(146, 700);
            this.nvInward.SmallImages = this.image;
            this.nvInward.TabIndex = 0;
            this.nvInward.Text = "navBarControl1";
            // 
            // nvgInward
            // 
            this.nvgInward.Caption = "Nhập Hàng";
            this.nvgInward.Expanded = true;
            this.nvgInward.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgInward.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInward)});
            this.nvgInward.Name = "nvgInward";
            // 
            // niInward
            // 
            this.niInward.Caption = "Phiếu Nhập Hàng";
            this.niInward.LargeImageIndex = 4;
            this.niInward.Name = "niInward";
            this.niInward.SmallImageIndex = 4;
            this.niInward.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInwardLinkClicked);
            // 
            // nvgList
            // 
            this.nvgList.Caption = "Bảng Kê";
            this.nvgList.Expanded = true;
            this.nvgList.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgList.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInwardList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInwardDetailList)});
            this.nvgList.Name = "nvgList";
            // 
            // niInwardList
            // 
            this.niInwardList.Caption = "Theo Chứng Từ";
            this.niInwardList.LargeImageIndex = 1;
            this.niInwardList.Name = "niInwardList";
            this.niInwardList.SmallImageIndex = 9;
            this.niInwardList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInwardListLinkClicked);
            // 
            // niInwardDetailList
            // 
            this.niInwardDetailList.Caption = "Theo Hàng Hoá";
            this.niInwardDetailList.LargeImageIndex = 1;
            this.niInwardDetailList.Name = "niInwardDetailList";
            this.niInwardDetailList.SmallImageIndex = 9;
            this.niInwardDetailList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInwardDetailListLinkClicked);
            // 
            // nvgDictionary
            // 
            this.nvgDictionary.Caption = "Thêm Danh Mục";
            this.nvgDictionary.Expanded = true;
            this.nvgDictionary.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgDictionary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niStock)});
            this.nvgDictionary.Name = "nvgDictionary";
            // 
            // niProduct
            // 
            this.niProduct.Caption = "Hàng Hoá";
            this.niProduct.LargeImageIndex = 2;
            this.niProduct.Name = "niProduct";
            this.niProduct.SmallImageIndex = 2;
            this.niProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiProductLinkClicked);
            // 
            // niCustomer
            // 
            this.niCustomer.Caption = "Khách Hàng";
            this.niCustomer.LargeImageIndex = 3;
            this.niCustomer.Name = "niCustomer";
            this.niCustomer.SmallImageIndex = 3;
            this.niCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiCustomerLinkClicked);
            // 
            // niStock
            // 
            this.niStock.Caption = "Kho Hàng";
            this.niStock.LargeImageIndex = 5;
            this.niStock.Name = "niStock";
            this.niStock.SmallImageIndex = 5;
            this.niStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiStockLinkClicked);
            // 
            // plMain
            // 
            this.plMain.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.plMain.AppearanceCaption.Options.UseForeColor = true;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(152, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(862, 728);
            this.plMain.TabIndex = 3;
            // 
            // XfmInward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 728);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.dplInward);
            this.Name = "XfmInward";
            this.Text = "Mua Hàng";
            this.Activated += new System.EventHandler(this.XfmInwardActivated);
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.dplInward.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvInward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private DevExpress.XtraBars.Docking.DockManager dm;
        protected DevExpress.Utils.ImageCollection image;
        private DevExpress.XtraBars.Docking.DockPanel dplInward;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl nvInward;
        private DevExpress.XtraNavBar.NavBarGroup nvgInward;
        private DevExpress.XtraNavBar.NavBarItem niInward;
        private DevExpress.XtraNavBar.NavBarItem niInwardList;
        private DevExpress.XtraNavBar.NavBarGroup nvgDictionary;
        private DevExpress.XtraNavBar.NavBarItem niProduct;
        private DevExpress.XtraNavBar.NavBarItem niCustomer;
        private DevExpress.XtraNavBar.NavBarItem niInwardDetailList;
        private DevExpress.XtraNavBar.NavBarItem niStock;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarGroup nvgList;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
    }
}