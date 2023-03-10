
namespace Perfect.Inventory.Core.Inventory.Report
{
    partial class XfmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmReports));
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiPrinted = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiQuickPrint = new DevExpress.XtraBars.BarButtonItem();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dplReport = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvReport = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgInventory = new DevExpress.XtraNavBar.NavBarGroup();
            this.niInventoryAverage = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryByGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryAllStock = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventorySumary = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryQuantitySummary = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventorySummaryBasic = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryDateSummary = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryLedger = new DevExpress.XtraNavBar.NavBarItem();
            this.niStockCard = new DevExpress.XtraNavBar.NavBarItem();
            this.niCustomerProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.niProductCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryAdjustment = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryExceedLimit = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryLowerlimit = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventoryOrder = new DevExpress.XtraNavBar.NavBarItem();
            this.niTotal = new DevExpress.XtraNavBar.NavBarItem();
            this.niInventorySummaryAVGUnitPrice = new DevExpress.XtraNavBar.NavBarItem();
            this.niDetailProductBook = new DevExpress.XtraNavBar.NavBarItem();
            this.niInwardSummaryList = new DevExpress.XtraNavBar.NavBarItem();
            this.niInwardDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.niOutwardSummaryList = new DevExpress.XtraNavBar.NavBarItem();
            this.niOutwardDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.niTransferList = new DevExpress.XtraNavBar.NavBarItem();
            this.niTransferDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.imgLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dplReport.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // bm
            // 
            this.bm.DockControls.Add(this.barDockControl1);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.imageCollection2;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPrinted,
            this.bbiRefresh,
            this.bbiClose,
            this.bbiHelp,
            this.bbiQuickPrint});
            this.bm.LargeImages = this.imageCollection2;
            this.bm.MaxItemId = 38;
            // 
            // bbiPrinted
            // 
            resources.ApplyResources(this.bbiPrinted, "bbiPrinted");
            this.bbiPrinted.Id = 27;
            this.bbiPrinted.ImageIndex = 0;
            this.bbiPrinted.Name = "bbiPrinted";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.AllowAllUp = true;
            this.bbiRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiRefresh.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.bbiRefresh.Appearance.Options.UseFont = true;
            this.bbiRefresh.Appearance.Options.UseForeColor = true;
            this.bbiRefresh.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            resources.ApplyResources(this.bbiRefresh, "bbiRefresh");
            this.bbiRefresh.Id = 28;
            this.bbiRefresh.ImageIndex = 30;
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // bbiClose
            // 
            resources.ApplyResources(this.bbiClose, "bbiClose");
            this.bbiClose.Id = 33;
            this.bbiClose.ImageIndex = 13;
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiHelp
            // 
            resources.ApplyResources(this.bbiHelp, "bbiHelp");
            this.bbiHelp.Id = 36;
            this.bbiHelp.ImageIndex = 16;
            this.bbiHelp.Name = "bbiHelp";
            // 
            // bbiQuickPrint
            // 
            resources.ApplyResources(this.bbiQuickPrint, "bbiQuickPrint");
            this.bbiQuickPrint.Id = 37;
            this.bbiQuickPrint.Name = "bbiQuickPrint";
            // 
            // dm
            // 
            this.dm.DockingOptions.FloatOnDblClick = false;
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.DockModeVS2005FadeFramesCount = 5;
            this.dm.DockModeVS2005FadeSpeed = 500;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dplReport});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dplReport
            // 
            this.dplReport.Controls.Add(this.dockPanel1_Container);
            this.dplReport.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dplReport.ID = new System.Guid("daea88e7-fbdb-45ec-8fb8-f8c6c5f798f5");
            resources.ApplyResources(this.dplReport, "dplReport");
            this.dplReport.Name = "dplReport";
            this.dplReport.OriginalSize = new System.Drawing.Size(192, 200);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nvReport);
            resources.ApplyResources(this.dockPanel1_Container, "dockPanel1_Container");
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            // 
            // nvReport
            // 
            this.nvReport.ActiveGroup = this.nvgInventory;
            this.nvReport.ContentButtonHint = null;
            resources.ApplyResources(this.nvReport, "nvReport");
            this.nvReport.DragDropFlags = ((DevExpress.XtraNavBar.NavBarDragDrop)(((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag | DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop)
                        | DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop)));
            this.nvReport.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvgInventory});
            this.nvReport.HideGroupCaptions = true;
            this.nvReport.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niInwardSummaryList,
            this.niInwardDetailList,
            this.niOutwardSummaryList,
            this.niOutwardDetailList,
            this.niInventoryAverage,
            this.niInventorySumary,
            this.niInventoryQuantitySummary,
            this.niInventorySummaryBasic,
            this.niInventoryLedger,
            this.niStockCard,
            this.niTransferList,
            this.niInventoryAdjustment,
            this.niTransferDetailList,
            this.niInventoryOrder,
            this.niInventoryLowerlimit,
            this.niInventoryExceedLimit,
            this.niInventoryAllStock,
            this.niTotal,
            this.niInventoryDateSummary,
            this.niCustomerProduct,
            this.niProductCustomer,
            this.niInventoryByGroup,
            this.niInventorySummaryAVGUnitPrice,
            this.niDetailProductBook});
            this.nvReport.LargeImages = this.imgLarge;
            this.nvReport.Name = "nvReport";
            this.nvReport.OptionsNavPane.ExpandedWidth = 234;
            this.nvReport.OptionsNavPane.ShowExpandButton = false;
            this.nvReport.OptionsNavPane.ShowOverflowPanel = false;
            this.nvReport.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.Buttons;
            this.nvReport.SmallImages = this.imageCollection2;
            this.nvReport.StoreDefaultPaintStyleName = true;
            // 
            // nvgInventory
            // 
            resources.ApplyResources(this.nvgInventory, "nvgInventory");
            this.nvgInventory.DragDropFlags = ((DevExpress.XtraNavBar.NavBarDragDrop)((((DevExpress.XtraNavBar.NavBarDragDrop.Default | DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag)
                        | DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop)
                        | DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop)));
            this.nvgInventory.Expanded = true;
            this.nvgInventory.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryAverage),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryByGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryAllStock),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventorySumary),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryQuantitySummary),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventorySummaryBasic),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryDateSummary),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryLedger),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niStockCard),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niCustomerProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProductCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryAdjustment),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryExceedLimit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryLowerlimit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventoryOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niTotal),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niInventorySummaryAVGUnitPrice),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niDetailProductBook)});
            this.nvgInventory.Name = "nvgInventory";
            // 
            // niInventoryAverage
            // 
            resources.ApplyResources(this.niInventoryAverage, "niInventoryAverage");
            this.niInventoryAverage.Name = "niInventoryAverage";
            this.niInventoryAverage.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryAverageLinkClicked);
            // 
            // niInventoryByGroup
            // 
            resources.ApplyResources(this.niInventoryByGroup, "niInventoryByGroup");
            this.niInventoryByGroup.Name = "niInventoryByGroup";
            this.niInventoryByGroup.Visible = false;
            this.niInventoryByGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryByGroupLinkClicked);
            // 
            // niInventoryAllStock
            // 
            resources.ApplyResources(this.niInventoryAllStock, "niInventoryAllStock");
            this.niInventoryAllStock.Name = "niInventoryAllStock";
            this.niInventoryAllStock.Visible = false;
            this.niInventoryAllStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryAllStockLinkClicked);
            // 
            // niInventorySumary
            // 
            resources.ApplyResources(this.niInventorySumary, "niInventorySumary");
            this.niInventorySumary.Name = "niInventorySumary";
            this.niInventorySumary.Visible = false;
            this.niInventorySumary.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventorySumaryLinkClicked);
            // 
            // niInventoryQuantitySummary
            // 
            resources.ApplyResources(this.niInventoryQuantitySummary, "niInventoryQuantitySummary");
            this.niInventoryQuantitySummary.Name = "niInventoryQuantitySummary";
            this.niInventoryQuantitySummary.Visible = false;
            this.niInventoryQuantitySummary.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryQuantitySummaryLinkClicked);
            // 
            // niInventorySummaryBasic
            // 
            resources.ApplyResources(this.niInventorySummaryBasic, "niInventorySummaryBasic");
            this.niInventorySummaryBasic.Name = "niInventorySummaryBasic";
            this.niInventorySummaryBasic.Visible = false;
            // 
            // niInventoryDateSummary
            // 
            resources.ApplyResources(this.niInventoryDateSummary, "niInventoryDateSummary");
            this.niInventoryDateSummary.Name = "niInventoryDateSummary";
            this.niInventoryDateSummary.Visible = false;
            this.niInventoryDateSummary.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryDateSummaryLinkClicked);
            // 
            // niInventoryLedger
            // 
            resources.ApplyResources(this.niInventoryLedger, "niInventoryLedger");
            this.niInventoryLedger.Name = "niInventoryLedger";
            this.niInventoryLedger.Visible = false;
            this.niInventoryLedger.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryLedgerLinkClicked);
            // 
            // niStockCard
            // 
            resources.ApplyResources(this.niStockCard, "niStockCard");
            this.niStockCard.Name = "niStockCard";
            this.niStockCard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiStockCardLinkClicked);
            // 
            // niCustomerProduct
            // 
            resources.ApplyResources(this.niCustomerProduct, "niCustomerProduct");
            this.niCustomerProduct.Name = "niCustomerProduct";
            this.niCustomerProduct.Visible = false;
            this.niCustomerProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiCustomerProductLinkClicked);
            // 
            // niProductCustomer
            // 
            resources.ApplyResources(this.niProductCustomer, "niProductCustomer");
            this.niProductCustomer.Name = "niProductCustomer";
            this.niProductCustomer.Visible = false;
            this.niProductCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiProductCustomerLinkClicked);
            // 
            // niInventoryAdjustment
            // 
            resources.ApplyResources(this.niInventoryAdjustment, "niInventoryAdjustment");
            this.niInventoryAdjustment.Name = "niInventoryAdjustment";
            this.niInventoryAdjustment.Visible = false;
            // 
            // niInventoryExceedLimit
            // 
            resources.ApplyResources(this.niInventoryExceedLimit, "niInventoryExceedLimit");
            this.niInventoryExceedLimit.Name = "niInventoryExceedLimit";
            this.niInventoryExceedLimit.Visible = false;
            this.niInventoryExceedLimit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryExceedLimitLinkClicked);
            // 
            // niInventoryLowerlimit
            // 
            resources.ApplyResources(this.niInventoryLowerlimit, "niInventoryLowerlimit");
            this.niInventoryLowerlimit.Name = "niInventoryLowerlimit";
            this.niInventoryLowerlimit.Visible = false;
            this.niInventoryLowerlimit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryLowerlimitLinkClicked);
            // 
            // niInventoryOrder
            // 
            resources.ApplyResources(this.niInventoryOrder, "niInventoryOrder");
            this.niInventoryOrder.Name = "niInventoryOrder";
            this.niInventoryOrder.Visible = false;
            this.niInventoryOrder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiInventoryOrderLinkClicked);
            // 
            // niTotal
            // 
            resources.ApplyResources(this.niTotal, "niTotal");
            this.niTotal.Name = "niTotal";
            this.niTotal.Visible = false;
            this.niTotal.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiTotalLinkClicked);
            // 
            // niInventorySummaryAVGUnitPrice
            // 
            resources.ApplyResources(this.niInventorySummaryAVGUnitPrice, "niInventorySummaryAVGUnitPrice");
            this.niInventorySummaryAVGUnitPrice.Name = "niInventorySummaryAVGUnitPrice";
            this.niInventorySummaryAVGUnitPrice.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niInventorySummaryAVGUnitPrice_LinkClicked);
            // 
            // niDetailProductBook
            // 
            resources.ApplyResources(this.niDetailProductBook, "niDetailProductBook");
            this.niDetailProductBook.Name = "niDetailProductBook";
            this.niDetailProductBook.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niDetailProductBook_LinkClicked);
            // 
            // niInwardSummaryList
            // 
            resources.ApplyResources(this.niInwardSummaryList, "niInwardSummaryList");
            this.niInwardSummaryList.Name = "niInwardSummaryList";
            // 
            // niInwardDetailList
            // 
            resources.ApplyResources(this.niInwardDetailList, "niInwardDetailList");
            this.niInwardDetailList.Name = "niInwardDetailList";
            // 
            // niOutwardSummaryList
            // 
            resources.ApplyResources(this.niOutwardSummaryList, "niOutwardSummaryList");
            this.niOutwardSummaryList.Name = "niOutwardSummaryList";
            // 
            // niOutwardDetailList
            // 
            resources.ApplyResources(this.niOutwardDetailList, "niOutwardDetailList");
            this.niOutwardDetailList.Name = "niOutwardDetailList";
            // 
            // niTransferList
            // 
            resources.ApplyResources(this.niTransferList, "niTransferList");
            this.niTransferList.Name = "niTransferList";
            // 
            // niTransferDetailList
            // 
            resources.ApplyResources(this.niTransferDetailList, "niTransferDetailList");
            this.niTransferDetailList.Name = "niTransferDetailList";
            // 
            // imgLarge
            // 
            resources.ApplyResources(this.imgLarge, "imgLarge");
            this.imgLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgLarge.ImageStream")));
            this.imgLarge.Images.SetKeyName(0, "Action_Chart_Printing_Preview_32x32.png");
            this.imgLarge.Images.SetKeyName(1, "Action_Chart_ShowDesigner_32x32.png");
            this.imgLarge.Images.SetKeyName(2, "Action_ChooseSkin_32x32.png");
            this.imgLarge.Images.SetKeyName(3, "Action_Clear_32x32.png");
            this.imgLarge.Images.SetKeyName(4, "Action_CloneMerge_Clone_Object_32x32.png");
            this.imgLarge.Images.SetKeyName(5, "Action_CloneMerge_Merge_Object_32x32.png");
            this.imgLarge.Images.SetKeyName(6, "Action_EditModel_32x32.png");
            this.imgLarge.Images.SetKeyName(7, "Action_FileAttachment_Attach_32x32.png");
            this.imgLarge.Images.SetKeyName(8, "Action_Inline_New_32x32.png");
            this.imgLarge.Images.SetKeyName(9, "Action_LinkUnlink_Link_32x32.png");
            this.imgLarge.Images.SetKeyName(10, "Action_NavigationBar_32x32.png");
            this.imgLarge.Images.SetKeyName(11, "Action_New_32x32.png");
            this.imgLarge.Images.SetKeyName(12, "Action_New_32x32_2.png");
            this.imgLarge.Images.SetKeyName(13, "Action_Open_32x32.png");
            this.imgLarge.Images.SetKeyName(14, "Action_Open_Object_32x32.png");
            this.imgLarge.Images.SetKeyName(15, "Action_ParametrizedAction_32x32.png");
            this.imgLarge.Images.SetKeyName(16, "Action_Paste_32x32.png");
            this.imgLarge.Images.SetKeyName(17, "Action_Pivot_Printing_Preview_32x32.png");
            this.imgLarge.Images.SetKeyName(18, "Action_PivotChart_Data_Bind_32x32.png");
            this.imgLarge.Images.SetKeyName(19, "Action_PivotChart_Data_Unbind_32x32.png");
            this.imgLarge.Images.SetKeyName(20, "Action_Printing_Preview_32x32.png");
            this.imgLarge.Images.SetKeyName(21, "Action_Refresh_32x32.png");
            this.imgLarge.Images.SetKeyName(22, "Action_Report_Object_Inplace_Preview_32x32.png");
            this.imgLarge.Images.SetKeyName(23, "Action_Report_ShowDesigner_32x32.png");
            this.imgLarge.Images.SetKeyName(24, "Action_Report_ShowDesigner_32x32_2.png");
            this.imgLarge.Images.SetKeyName(25, "Action_Search_Object_FindObjectByID_32x32.png");
            this.imgLarge.Images.SetKeyName(26, "Action_Security_ChangePassword_32x32.png");
            this.imgLarge.Images.SetKeyName(27, "Action_SimpleAction_32x32.png");
            this.imgLarge.Images.SetKeyName(28, "Action_SingleChoiceAction_32x32.png");
            this.imgLarge.Images.SetKeyName(29, "BO_Address_32x32.png");
            this.imgLarge.Images.SetKeyName(30, "BO_Appointment_32x32.png");
            this.imgLarge.Images.SetKeyName(31, "BO_Attention_32x32.png");
            this.imgLarge.Images.SetKeyName(32, "BO_Category_32x32.png");
            this.imgLarge.Images.SetKeyName(33, "BO_Contact_32x32.png");
            this.imgLarge.Images.SetKeyName(34, "BO_Contract_32x32.png");
            this.imgLarge.Images.SetKeyName(35, "BO_Country_v92_32x32.png");
            this.imgLarge.Images.SetKeyName(36, "BO_Customer_32x32.png");
            this.imgLarge.Images.SetKeyName(37, "BO_Department_32x32.png");
            this.imgLarge.Images.SetKeyName(38, "BO_Employee_32x32.png");
            this.imgLarge.Images.SetKeyName(39, "BO_FileAttachment_32x32.png");
            this.imgLarge.Images.SetKeyName(40, "BO_Folder_32x32.png");
            this.imgLarge.Images.SetKeyName(41, "BO_Localization_32x32.png");
            this.imgLarge.Images.SetKeyName(42, "BO_MyDetails_32x32.png");
            this.imgLarge.Images.SetKeyName(43, "BO_Note_32x32.png");
            this.imgLarge.Images.SetKeyName(44, "BO_Order_32x32.png");
            this.imgLarge.Images.SetKeyName(45, "BO_Order_Item_32x32.png");
            this.imgLarge.Images.SetKeyName(46, "BO_Organization_32x32.png");
            this.imgLarge.Images.SetKeyName(47, "BO_Person_32x32.png");
            this.imgLarge.Images.SetKeyName(48, "BO_Phone_32x32.png");
            this.imgLarge.Images.SetKeyName(49, "BO_PivotChart_32x32.png");
            this.imgLarge.Images.SetKeyName(50, "BO_Position_32x32.png");
            this.imgLarge.Images.SetKeyName(51, "BO_Position_v92_32x32.png");
            this.imgLarge.Images.SetKeyName(52, "BO_Product_32x32.png");
            this.imgLarge.Images.SetKeyName(53, "BO_Product_Group_32x32.png");
            this.imgLarge.Images.SetKeyName(54, "BO_Report_32x32.png");
            this.imgLarge.Images.SetKeyName(55, "BO_Resume_32x32.png");
            this.imgLarge.Images.SetKeyName(56, "BO_Role_32x32.png");
            this.imgLarge.Images.SetKeyName(57, "BO_Rules_32x32.png");
            this.imgLarge.Images.SetKeyName(58, "BO_Sale_32x32.png");
            this.imgLarge.Images.SetKeyName(59, "BO_Sale_Item_32x32.png");
            this.imgLarge.Images.SetKeyName(60, "BO_Sale_Item_v92_32x32.png");
            this.imgLarge.Images.SetKeyName(61, "BO_Sale_v92_32x32.png");
            this.imgLarge.Images.SetKeyName(62, "BO_Scheduler_32x32.png");
            this.imgLarge.Images.SetKeyName(63, "BO_Task_32x32.png");
            this.imgLarge.Images.SetKeyName(64, "BO_Unknown_32x32.png");
            this.imgLarge.Images.SetKeyName(65, "BO_User_32x32.png");
            this.imgLarge.Images.SetKeyName(66, "BO_Vendor_32x32.png");
            this.imgLarge.Images.SetKeyName(67, "BO_Attention_72x72.png");
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrinted, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose, true)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // plMain
            // 
            resources.ApplyResources(this.plMain, "plMain");
            this.plMain.Name = "plMain";
            // 
            // XfmReports
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.dplReport);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "XfmReports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.XfmReportManagersLoad);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dplReport.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        protected DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.BarButtonItem bbiPrinted;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        protected DevExpress.XtraBars.PopupMenu pm;
        private DevExpress.XtraBars.BarButtonItem bbiHelp;
        private DevExpress.XtraBars.BarButtonItem bbiQuickPrint;
        private DevExpress.XtraBars.Docking.DockPanel dplReport;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl nvReport;
        private DevExpress.XtraNavBar.NavBarGroup nvgInventory;
        private DevExpress.XtraNavBar.NavBarItem niInwardSummaryList;
        private DevExpress.XtraNavBar.NavBarItem niInwardDetailList;
        private DevExpress.XtraNavBar.NavBarItem niOutwardSummaryList;
        private DevExpress.XtraNavBar.NavBarItem niOutwardDetailList;
        private DevExpress.XtraNavBar.NavBarItem niInventoryAverage;
        private DevExpress.XtraNavBar.NavBarItem niInventorySumary;
        private DevExpress.XtraNavBar.NavBarItem niInventoryQuantitySummary;
        private DevExpress.XtraNavBar.NavBarItem niInventorySummaryBasic;
        private DevExpress.XtraNavBar.NavBarItem niInventoryLedger;
        private DevExpress.XtraNavBar.NavBarItem niStockCard;
        private DevExpress.XtraNavBar.NavBarItem niInventoryAdjustment;
        private DevExpress.XtraNavBar.NavBarItem niTransferList;
        private DevExpress.XtraNavBar.NavBarItem niTransferDetailList;
        private DevExpress.XtraNavBar.NavBarItem niInventoryOrder;
        private DevExpress.XtraNavBar.NavBarItem niInventoryLowerlimit;
        private DevExpress.XtraNavBar.NavBarItem niInventoryExceedLimit;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niInventoryAllStock;
        private DevExpress.XtraNavBar.NavBarItem niTotal;
        private DevExpress.XtraNavBar.NavBarItem niInventoryDateSummary;
        private DevExpress.XtraNavBar.NavBarItem niCustomerProduct;
        private DevExpress.XtraNavBar.NavBarItem niProductCustomer;
        protected DevExpress.Utils.ImageCollection imgLarge;
        private DevExpress.XtraNavBar.NavBarItem niInventoryByGroup;
        private DevExpress.XtraNavBar.NavBarItem niInventorySummaryAVGUnitPrice;
        private DevExpress.XtraNavBar.NavBarItem niDetailProductBook;
    }
}