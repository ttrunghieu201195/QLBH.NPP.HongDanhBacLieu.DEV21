namespace Perfect.Sale.Core.Report
{
    partial class XfmSaleAmountReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmSaleAmountReport));
            this.image = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dplOutward = new DevExpress.XtraBars.Docking.DockPanel();
            this.dplcMain = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvOutward = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgRevenue = new DevExpress.XtraNavBar.NavBarGroup();
            this.niSaleAmountByDay = new DevExpress.XtraNavBar.NavBarItem();
            this.niSaleAmountByWeek = new DevExpress.XtraNavBar.NavBarItem();
            this.niSaleAmountByCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.niSaleAmountByProvince = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgPurchase = new DevExpress.XtraNavBar.NavBarGroup();
            this.niPurchaseByDay = new DevExpress.XtraNavBar.NavBarItem();
            this.niPurchaseByProvider = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgOutwardList = new DevExpress.XtraNavBar.NavBarGroup();
            this.niOutwardList = new DevExpress.XtraNavBar.NavBarItem();
            this.niSumByProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgReceiptAndPayment = new DevExpress.XtraNavBar.NavBarGroup();
            this.niReceiptForCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.niPaymentForProvider = new DevExpress.XtraNavBar.NavBarItem();
            this.niOutwardDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.niTables = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dplOutward.SuspendLayout();
            this.dplcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvOutward)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.ImageSize = new System.Drawing.Size(32, 32);
            this.image.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("image.ImageStream")));
            this.image.Images.SetKeyName(0, "1318304491_order-1.png");
            this.image.Images.SetKeyName(1, "1318304498_list.png");
            this.image.Images.SetKeyName(2, "1318306141_customers.png");
            this.image.Images.SetKeyName(3, "1323742954_schedule.png");
            this.image.Images.SetKeyName(4, "1317087823_group_link.png");
            this.image.Images.SetKeyName(5, "1317087843_people.png");
            this.image.Images.SetKeyName(6, "Action_EditModel_32x32.png");
            this.image.Images.SetKeyName(7, "BO_Customer_32x32.png");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.plMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(175, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(817, 724);
            this.panelControl1.TabIndex = 2;
            // 
            // plMain
            // 
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(2, 2);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(813, 720);
            this.plMain.TabIndex = 0;
            // 
            // dm
            // 
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dplOutward});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dplOutward
            // 
            this.dplOutward.Controls.Add(this.dplcMain);
            this.dplOutward.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dplOutward.ID = new System.Guid("f2631645-0ef5-44c5-a57c-f1293fc924d4");
            this.dplOutward.Location = new System.Drawing.Point(0, 0);
            this.dplOutward.Name = "dplOutward";
            this.dplOutward.OriginalSize = new System.Drawing.Size(175, 200);
            this.dplOutward.Size = new System.Drawing.Size(175, 724);
            this.dplOutward.Text = "Chức Năng";
            // 
            // dplcMain
            // 
            this.dplcMain.Controls.Add(this.nvOutward);
            this.dplcMain.Location = new System.Drawing.Point(3, 29);
            this.dplcMain.Name = "dplcMain";
            this.dplcMain.Size = new System.Drawing.Size(169, 692);
            this.dplcMain.TabIndex = 0;
            // 
            // nvOutward
            // 
            this.nvOutward.ActiveGroup = this.nvgPurchase;
            this.nvOutward.ContentButtonHint = null;
            this.nvOutward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvOutward.EachGroupHasSelectedLink = true;
            this.nvOutward.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvgPurchase,
            this.nvgRevenue,
            this.nvgOutwardList,
            this.nvgReceiptAndPayment});
            this.nvOutward.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niOutwardList,
            this.niOutwardDetailList,
            this.niTables,
            this.niReceiptForCustomer,
            this.niPaymentForProvider,
            this.niSaleAmountByWeek,
            this.niSaleAmountByDay,
            this.niSaleAmountByCustomer,
            this.niSaleAmountByProvince,
            this.niPurchaseByDay,
            this.niPurchaseByProvider,
            this.niSumByProduct});
            this.nvOutward.LargeImages = this.image;
            this.nvOutward.Location = new System.Drawing.Point(0, 0);
            this.nvOutward.Name = "nvOutward";
            this.nvOutward.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.nvOutward.OptionsNavPane.ExpandedWidth = 205;
            this.nvOutward.Size = new System.Drawing.Size(169, 692);
            this.nvOutward.SmallImages = this.image;
            this.nvOutward.TabIndex = 0;
            this.nvOutward.Text = "navBarControl1";
            this.nvOutward.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            // 
            // nvgRevenue
            // 
            this.nvgRevenue.Caption = "Doanh Thu Bán Hàng";
            this.nvgRevenue.Expanded = true;
            this.nvgRevenue.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgRevenue.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niSaleAmountByDay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niSaleAmountByWeek),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niSaleAmountByCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niSaleAmountByProvince)});
            this.nvgRevenue.Name = "nvgRevenue";
            // 
            // niSaleAmountByDay
            // 
            this.niSaleAmountByDay.Caption = "Theo Ngày";
            this.niSaleAmountByDay.LargeImageIndex = 3;
            this.niSaleAmountByDay.Name = "niSaleAmountByDay";
            this.niSaleAmountByDay.SmallImageIndex = 3;
            this.niSaleAmountByDay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiSaleAmountByDayLinkClicked);
            // 
            // niSaleAmountByWeek
            // 
            this.niSaleAmountByWeek.Caption = "Theo Tuần";
            this.niSaleAmountByWeek.Name = "niSaleAmountByWeek";
            this.niSaleAmountByWeek.SmallImageIndex = 10;
            this.niSaleAmountByWeek.Visible = false;
            this.niSaleAmountByWeek.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiSaleAmountByWeekLinkClicked);
            // 
            // niSaleAmountByCustomer
            // 
            this.niSaleAmountByCustomer.Caption = "Theo Khách Hàng";
            this.niSaleAmountByCustomer.LargeImageIndex = 7;
            this.niSaleAmountByCustomer.Name = "niSaleAmountByCustomer";
            this.niSaleAmountByCustomer.SmallImageIndex = 7;
            this.niSaleAmountByCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiSaleAmountByCustomerLinkClicked);
            // 
            // niSaleAmountByProvince
            // 
            this.niSaleAmountByProvince.Caption = "Theo Khu Vực";
            this.niSaleAmountByProvince.LargeImageIndex = 4;
            this.niSaleAmountByProvince.Name = "niSaleAmountByProvince";
            this.niSaleAmountByProvince.SmallImageIndex = 4;
            this.niSaleAmountByProvince.Visible = false;
            this.niSaleAmountByProvince.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiSaleAmountByProvinceLinkClicked);
            // 
            // nvgPurchase
            // 
            this.nvgPurchase.Caption = "Chi Phí Mua Hàng";
            this.nvgPurchase.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgPurchase.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niPurchaseByDay),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niPurchaseByProvider)});
            this.nvgPurchase.Name = "nvgPurchase";
            // 
            // niPurchaseByDay
            // 
            this.niPurchaseByDay.Caption = "Theo Ngày";
            this.niPurchaseByDay.LargeImageIndex = 3;
            this.niPurchaseByDay.Name = "niPurchaseByDay";
            this.niPurchaseByDay.SmallImageIndex = 3;
            this.niPurchaseByDay.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiPurchaseByDayLinkClicked);
            // 
            // niPurchaseByProvider
            // 
            this.niPurchaseByProvider.Caption = "Theo Nhà Cung Cấp";
            this.niPurchaseByProvider.LargeImageIndex = 5;
            this.niPurchaseByProvider.Name = "niPurchaseByProvider";
            this.niPurchaseByProvider.SmallImageIndex = 5;
            this.niPurchaseByProvider.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiPurchaseByProviderLinkClicked);
            // 
            // nvgOutwardList
            // 
            this.nvgOutwardList.Caption = "Doanh Số";
            this.nvgOutwardList.Expanded = true;
            this.nvgOutwardList.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgOutwardList.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niOutwardList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niSumByProduct)});
            this.nvgOutwardList.Name = "nvgOutwardList";
            // 
            // niOutwardList
            // 
            this.niOutwardList.Caption = "Theo Nhân Viên";
            this.niOutwardList.LargeImageIndex = 2;
            this.niOutwardList.Name = "niOutwardList";
            this.niOutwardList.SmallImageIndex = 2;
            this.niOutwardList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiOutwardListLinkClicked);
            // 
            // niSumByProduct
            // 
            this.niSumByProduct.Caption = "Lợi Nhuận";
            this.niSumByProduct.LargeImageIndex = 6;
            this.niSumByProduct.Name = "niSumByProduct";
            this.niSumByProduct.SmallImageIndex = 6;
            this.niSumByProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niSumByProduct_LinkClicked);
            // 
            // nvgReceiptAndPayment
            // 
            this.nvgReceiptAndPayment.Caption = "Thu - Chi";
            this.nvgReceiptAndPayment.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niReceiptForCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niPaymentForProvider)});
            this.nvgReceiptAndPayment.Name = "nvgReceiptAndPayment";
            this.nvgReceiptAndPayment.Visible = false;
            // 
            // niReceiptForCustomer
            // 
            this.niReceiptForCustomer.Caption = "Chi Tiết Tiền Thu Công Nợ";
            this.niReceiptForCustomer.Name = "niReceiptForCustomer";
            this.niReceiptForCustomer.SmallImageIndex = 10;
            this.niReceiptForCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiDebitListLinkClicked);
            // 
            // niPaymentForProvider
            // 
            this.niPaymentForProvider.Caption = "Chi Tiết Tiền Chi Công Nợ";
            this.niPaymentForProvider.Name = "niPaymentForProvider";
            this.niPaymentForProvider.SmallImageIndex = 10;
            this.niPaymentForProvider.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiSummaryLinkClicked);
            // 
            // niOutwardDetailList
            // 
            this.niOutwardDetailList.Caption = "Theo Hàng Hoá";
            this.niOutwardDetailList.Name = "niOutwardDetailList";
            this.niOutwardDetailList.SmallImageIndex = 13;
            this.niOutwardDetailList.Visible = false;
            // 
            // niTables
            // 
            this.niTables.Caption = "Danh Sách Bàn";
            this.niTables.Name = "niTables";
            this.niTables.SmallImageIndex = 9;
            this.niTables.Visible = false;
            // 
            // XfmSaleAmountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 724);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dplOutward);
            this.Name = "XfmSaleAmountReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Bán Hàng";
            this.Activated += new System.EventHandler(this.XfmOutwardActivated);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dplOutward.ResumeLayout(false);
            this.dplcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvOutward)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        //private Perfect.Inventory.Core.Inventory.Outward.xucOutwardA _ucOutwardB;
        
        protected DevExpress.Utils.ImageCollection image;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.Docking.DockPanel dplOutward;
        private DevExpress.XtraBars.Docking.ControlContainer dplcMain;
        private DevExpress.XtraNavBar.NavBarControl nvOutward;
        private DevExpress.XtraNavBar.NavBarGroup nvgRevenue;
        private DevExpress.XtraNavBar.NavBarGroup nvgOutwardList;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niOutwardList;
        private DevExpress.XtraNavBar.NavBarItem niOutwardDetailList;
        private DevExpress.XtraNavBar.NavBarItem niTables;
        private DevExpress.XtraNavBar.NavBarGroup nvgReceiptAndPayment;
        private DevExpress.XtraNavBar.NavBarItem niReceiptForCustomer;
        private DevExpress.XtraNavBar.NavBarItem niPaymentForProvider;
        private DevExpress.XtraNavBar.NavBarItem niSaleAmountByWeek;
        private DevExpress.XtraNavBar.NavBarItem niSaleAmountByDay;
        private DevExpress.XtraNavBar.NavBarItem niSaleAmountByCustomer;
        private DevExpress.XtraNavBar.NavBarItem niSaleAmountByProvince;
        private DevExpress.XtraNavBar.NavBarGroup nvgPurchase;
        private DevExpress.XtraNavBar.NavBarItem niPurchaseByDay;
        private DevExpress.XtraNavBar.NavBarItem niPurchaseByProvider;
        private DevExpress.XtraNavBar.NavBarItem niSumByProduct;
        
    }
}