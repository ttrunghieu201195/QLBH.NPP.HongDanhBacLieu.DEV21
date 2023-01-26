using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Perfect.Dictionary;
using Perfect.Dictionary.Customer;
using Perfect.Dictionary.Department;
using Perfect.Dictionary.Stock;
using Perfect.Inventory.Core.Inventory.Init;
using Perfect.Inventory.Core.Inventory.Inward.SALE;
using Perfect.Inventory.Core.Inventory.Outward.Sale;
using Perfect.Inventory.Core.Inventory.Transfer.SALE;
using Perfect.Security;
using Perfect.Sale.Core.PAYMENT;
using Perfect.Sale.Core.REICEIPT;
using Perfect.Sale.Core.Report;

namespace Perfect.Inventory
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        [DebuggerNonUserCode()]
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
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel_sale;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip13 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip14 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem13 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip15 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem14 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip16 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem15 = new DevExpress.Utils.ToolTipItem();
            this.rbcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.bbiUsers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProvider = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.bbiItemGroup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStock = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiContract = new DevExpress.XtraBars.BarButtonItem();
            this.bbiWebsite = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRegsiter = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCustomerGroup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInward = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOutward = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAdjustment = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCurrency = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInventory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPacket = new DevExpress.XtraBars.BarButtonItem();
            this.btnAuthor = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBackup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRestore = new DevExpress.XtraBars.BarButtonItem();
            this.bbiVideo = new DevExpress.XtraBars.BarButtonItem();
            this.lblAccount = new DevExpress.XtraBars.BarStaticItem();
            this.lblServer = new DevExpress.XtraBars.BarStaticItem();
            this.lblDay = new DevExpress.XtraBars.BarStaticItem();
            this.bbiHistory = new DevExpress.XtraBars.BarButtonItem();
            this.lblDatabase = new DevExpress.XtraBars.BarStaticItem();
            this.bbiFix = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSysLog = new DevExpress.XtraBars.BarButtonItem();
            this.bbiVoucherManager = new DevExpress.XtraBars.BarButtonItem();
            this.ISystem = new DevExpress.XtraBars.BarButtonItem();
            this.IInit = new DevExpress.XtraBars.BarButtonItem();
            this.IInward = new DevExpress.XtraBars.BarButtonItem();
            this.IOutward = new DevExpress.XtraBars.BarButtonItem();
            this.ITransfer = new DevExpress.XtraBars.BarButtonItem();
            this.IAdjustment = new DevExpress.XtraBars.BarButtonItem();
            this.IInventory = new DevExpress.XtraBars.BarButtonItem();
            this.IPacket = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrintBarcode = new DevExpress.XtraBars.BarButtonItem();
            this.lblVersion = new DevExpress.XtraBars.BarStaticItem();
            this.bbiSaleReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInventorySummary = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangepassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInventoryOrder = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUnit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLocks = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSale = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRevenue = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReciept = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPayment = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDebt = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInitInventory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.pmCommand = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.pmSave = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPageSetup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bbiVaildate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFilterStock = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bbiFilterCustomer = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bbiView = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCustom = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTask = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChange = new DevExpress.XtraBars.BarButtonItem();
            this.lblTime = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRevenueGenaralReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReportSale = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPurchaseReturn = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpiredReport = new DevExpress.XtraBars.BarButtonItem();
            this.lblDatabases = new DevExpress.XtraBars.BarStaticItem();
            this.lblServers = new DevExpress.XtraBars.BarStaticItem();
            this.lblAccounts = new DevExpress.XtraBars.BarStaticItem();
            this.bbiPermission = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpire = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExchangeRate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.lblInfo = new DevExpress.XtraBars.BarStaticItem();
            this.bbSkin = new DevExpress.XtraBars.BarSubItem();
            this.bsiHelp = new DevExpress.XtraBars.BarSubItem();
            this.bbiHelpDoc = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelpVideo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportDic = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCompanyInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeliveryStreet = new DevExpress.XtraBars.BarCheckItem();
            this.bbiProductBrand = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIndustry = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSalesOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.rbpDictionary = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgImportDic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgPartner = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgDicStock = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDeparment = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpStock = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgSale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgDebt = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgInvoice = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTool = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgSecurity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgDatabase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.rbsMain = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabMdi = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ImgSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.Skin = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            defaultLookAndFeel_sale = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcMain
            // 
            this.rbcMain.ApplicationButtonImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbcMain.ApplicationButtonImageOptions.Image")));
            this.rbcMain.ApplicationCaption = "Phần Mềm Quản Lý Bán Hàng";
            this.rbcMain.AutoSizeItems = true;
            this.rbcMain.ExpandCollapseItem.Id = 371;
            this.rbcMain.Images = this.imgCollection;
            this.rbcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMain.ExpandCollapseItem,
            this.rbcMain.SearchEditItem,
            this.bbiUsers,
            this.bbiProvider,
            this.bbiMaterial,
            this.bbiItemGroup,
            this.bbiStock,
            this.bbiHelp,
            this.bbiContract,
            this.bbiWebsite,
            this.bbiRegsiter,
            this.bbiUpdate,
            this.bbiCustomerGroup,
            this.bbiInward,
            this.bbiOutward,
            this.bbiTransfer,
            this.bbiAdjustment,
            this.bbiCurrency,
            this.bbiInventory,
            this.bbiDepartment,
            this.bbiEmployee,
            this.bbiPacket,
            this.btnAuthor,
            this.bbiBackup,
            this.bbiRestore,
            this.bbiVideo,
            this.lblAccount,
            this.lblServer,
            this.lblDay,
            this.bbiHistory,
            this.lblDatabase,
            this.bbiFix,
            this.bbiSysLog,
            this.bbiVoucherManager,
            this.ISystem,
            this.IInit,
            this.IInward,
            this.IOutward,
            this.ITransfer,
            this.IAdjustment,
            this.IInventory,
            this.IPacket,
            this.bbiPrintBarcode,
            this.lblVersion,
            this.bbiSaleReport,
            this.bbiInventorySummary,
            this.bbiExit,
            this.bbiLogout,
            this.bbiChangepassword,
            this.bbiInventoryOrder,
            this.bbiUnit,
            this.bbiLocks,
            this.bbiPurchase,
            this.bbiSale,
            this.bbiRevenue,
            this.bbiReciept,
            this.bbiPayment,
            this.bbiDebt,
            this.bbiInitInventory,
            this.bbiNew,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiCancel,
            this.bbiDelete,
            this.bbiRefresh,
            this.bbiPageSetup,
            this.bbiPrint,
            this.bbiPrintPreview,
            this.bbiVaildate,
            this.bbiClose,
            this.bbiFilterStock,
            this.bbiFilterCustomer,
            this.bbiView,
            this.bbiCustom,
            this.bbiTask,
            this.bbiExport,
            this.bbiImport,
            this.bbiChange,
            this.lblTime,
            this.barButtonItem1,
            this.bbiReport,
            this.bbiRevenueGenaralReport,
            this.bbiReportSale,
            this.bbiPurchaseReturn,
            this.bbiExpiredReport,
            this.lblDatabases,
            this.lblServers,
            this.lblAccounts,
            this.bbiPermission,
            this.bbiCustomer,
            this.bbiExpire,
            this.bbiExchangeRate,
            this.bbiData,
            this.barButtonItem2,
            this.lblInfo,
            this.bbSkin,
            this.bsiHelp,
            this.bbiHelpDoc,
            this.bbiHelpVideo,
            this.barButtonItem3,
            this.barButtonItem4,
            this.bbiImportDic,
            this.bbiCompanyInfo,
            this.barButtonItem5,
            this.bbiDeliveryStreet,
            this.bbiProductBrand,
            this.bbiCar,
            this.bbiIndustry,
            this.bbiSalesOrder,
            this.barButtonGroup1,
            this.barButtonItem6,
            this.ribbonGalleryBarItem1});
            this.rbcMain.LargeImages = this.imgCollection;
            this.rbcMain.Location = new System.Drawing.Point(0, 0);
            this.rbcMain.MaxItemId = 375;
            this.rbcMain.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.rbcMain.Name = "rbcMain";
            this.rbcMain.OptionsPageCategories.ShowCaptions = false;
            this.rbcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpDictionary,
            this.rbpStock,
            this.ribbonPage1,
            this.rbpSystem,
            this.rbpHelp});
            this.rbcMain.QuickToolbarItemLinks.Add(this.bbSkin);
            this.rbcMain.QuickToolbarItemLinks.Add(this.ribbonGalleryBarItem1);
            this.rbcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemProgressBar1,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemRadioGroup1,
            this.repositoryItemRadioGroup2});
            this.rbcMain.Size = new System.Drawing.Size(1689, 158);
            this.rbcMain.StatusBar = this.rbsMain;
            this.rbcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            this.rbcMain.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            this.rbcMain.Click += new System.EventHandler(this.rbcMain_Click);
            this.rbcMain.Layout += new System.Windows.Forms.LayoutEventHandler(this.RbcMainLayout);
            // 
            // imgCollection
            // 
            this.imgCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imgCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollection.ImageStream")));
            this.imgCollection.Images.SetKeyName(0, "Ket Thuc.png");
            this.imgCollection.Images.SetKeyName(1, "Nguoi Dung.png");
            this.imgCollection.Images.SetKeyName(2, "Phan Quyen.png");
            this.imgCollection.Images.SetKeyName(3, "Thay Doi Mat Khau.png");
            this.imgCollection.Images.SetKeyName(4, "Thong Tin.png");
            this.imgCollection.Images.SetKeyName(5, "Ton Kho.png");
            this.imgCollection.Images.SetKeyName(6, "Tuy Chon.png");
            this.imgCollection.Images.SetKeyName(7, "Import.png");
            this.imgCollection.Images.SetKeyName(8, "Khoa So.png");
            this.imgCollection.Images.SetKeyName(9, "Bo Phan.png");
            this.imgCollection.Images.SetKeyName(10, "Dinh Muc.png");
            this.imgCollection.Images.SetKeyName(11, "Don Vi Tinh.png");
            this.imgCollection.Images.SetKeyName(12, "Hang Hoa.png");
            this.imgCollection.Images.SetKeyName(13, "Khach Hang.png");
            this.imgCollection.Images.SetKeyName(14, "Kho.png");
            this.imgCollection.Images.SetKeyName(15, "Nha Phan Phoi.png");
            this.imgCollection.Images.SetKeyName(16, "Nhan Vien.png");
            this.imgCollection.Images.SetKeyName(17, "Nhom Hang.png");
            this.imgCollection.Images.SetKeyName(18, "Loai Doi Tac.png");
            this.imgCollection.Images.SetKeyName(19, "Nhom Doi Tac.png");
            this.imgCollection.Images.SetKeyName(20, "Bang Ke Chuyen Kho.png");
            this.imgCollection.Images.SetKeyName(21, "Bang Ke Kiem Ke.png");
            this.imgCollection.Images.SetKeyName(22, "Bang Ke Xuat Kho.png");
            this.imgCollection.Images.SetKeyName(23, "Bang KeNhap Kho.png");
            this.imgCollection.Images.SetKeyName(24, "Canh Bao Ton Kho.png");
            this.imgCollection.Images.SetKeyName(25, "Chuyen Kho.png");
            this.imgCollection.Images.SetKeyName(26, "Dong Goi BTP.png");
            this.imgCollection.Images.SetKeyName(27, "Kiem Ke.png");
            this.imgCollection.Images.SetKeyName(28, "Nhap Kho.png");
            this.imgCollection.Images.SetKeyName(29, "ReportWithChart256.png");
            this.imgCollection.Images.SetKeyName(30, "Ton Kho.png");
            this.imgCollection.Images.SetKeyName(31, "Xuat Kho.png");
            this.imgCollection.Images.SetKeyName(32, "Xuat Va Dong Goi.png");
            this.imgCollection.Images.SetKeyName(33, "Yeu Cau Dat Hang.png");
            this.imgCollection.Images.SetKeyName(34, "Yeu Cau Dat Hang.png");
            this.imgCollection.Images.SetKeyName(35, "Bang Ke Lap Rap.png");
            this.imgCollection.Images.SetKeyName(36, "Bang Len Ke Hoach.png");
            this.imgCollection.Images.SetKeyName(37, "Ke Hoach.png");
            this.imgCollection.Images.SetKeyName(38, "Lap Rap.png");
            this.imgCollection.Images.SetKeyName(39, "Tinh Gia Ban.png");
            this.imgCollection.Images.SetKeyName(40, "Bao Cao The Kho.png");
            this.imgCollection.Images.SetKeyName(41, "Bao Cao Ton Kho.png");
            this.imgCollection.Images.SetKeyName(42, "Duoi Dinh Muc.png");
            this.imgCollection.Images.SetKeyName(43, "Khac.png");
            this.imgCollection.Images.SetKeyName(44, "So Chi Tiet.png");
            this.imgCollection.Images.SetKeyName(45, "Vuot Dinh Muc.png");
            this.imgCollection.Images.SetKeyName(46, "Han Su Dung.png");
            this.imgCollection.Images.SetKeyName(47, "Dong Goi Thanh Pham.png");
            this.imgCollection.Images.SetKeyName(48, "Cap Nhat.png");
            this.imgCollection.Images.SetKeyName(49, "Dang Ky.png");
            this.imgCollection.Images.SetKeyName(50, "Huong Dan Su Dung.png");
            this.imgCollection.Images.SetKeyName(51, "Lien He.png");
            this.imgCollection.Images.SetKeyName(52, "Thong Tin.png");
            this.imgCollection.Images.SetKeyName(53, "Trang Chu.png");
            this.imgCollection.Images.SetKeyName(54, "Dang Ky.png");
            this.imgCollection.Images.SetKeyName(55, "databasebackup.png");
            this.imgCollection.Images.SetKeyName(56, "databaserestore.png");
            this.imgCollection.Images.SetKeyName(57, "Ban Ke Xuat Kho.png");
            this.imgCollection.Images.SetKeyName(58, "Bang Ke Nhap Kho.png");
            this.imgCollection.Images.SetKeyName(59, "Bang Ke Chuyen kho1.png");
            this.imgCollection.Images.SetKeyName(60, "Trang Chu.ico");
            this.imgCollection.Images.SetKeyName(61, "Cap Nhap Truc Tuyen.ico");
            this.imgCollection.Images.SetKeyName(62, "Huong Dan Su Dung.ico");
            this.imgCollection.Images.SetKeyName(63, "Lien He.ico");
            this.imgCollection.Images.SetKeyName(64, "Dang Xuat.png");
            this.imgCollection.Images.SetKeyName(65, "Copy of Stop.png");
            this.imgCollection.Images.SetKeyName(66, "Copy of Sync.png");
            this.imgCollection.Images.SetKeyName(67, "SuaChua.png");
            this.imgCollection.Images.SetKeyName(68, "NhatKyHeThong.png");
            this.imgCollection.Images.SetKeyName(69, "TimKiemChungTu.png");
            this.imgCollection.Images.SetKeyName(70, "16.ico");
            this.imgCollection.Images.SetKeyName(71, "database.ico");
            this.imgCollection.Images.SetKeyName(72, "StockPNG.png");
            this.imgCollection.Images.SetKeyName(73, "RibbonPrintPreview_DocumentMapLarge.png");
            this.imgCollection.Images.SetKeyName(74, "RibbonPrintPreview_CustomizeLarge.png");
            this.imgCollection.Images.SetKeyName(75, "plugin.ico");
            this.imgCollection.Images.SetKeyName(76, "Cau Hinh.png");
            this.imgCollection.Images.SetKeyName(77, "Sua Chua.png");
            this.imgCollection.Images.SetKeyName(78, "System868632.png");
            this.imgCollection.Images.SetKeyName(79, "Dossier fichier compressé32.png");
            this.imgCollection.Images.SetKeyName(80, "Barcode32.png");
            this.imgCollection.Images.SetKeyName(81, "Action_AboutInfo_32x32.png");
            this.imgCollection.Images.SetKeyName(82, "Action_Cancel_32x32.png");
            this.imgCollection.Images.SetKeyName(83, "Action_Chart_Printing_Preview_32x32.png");
            this.imgCollection.Images.SetKeyName(84, "Action_Chart_ShowDesigner_32x32.png");
            this.imgCollection.Images.SetKeyName(85, "Action_ChooseSkin_32x32.png");
            this.imgCollection.Images.SetKeyName(86, "Action_Clear_32x32.png");
            this.imgCollection.Images.SetKeyName(87, "Action_CloneMerge_Clone_Object_32x32.png");
            this.imgCollection.Images.SetKeyName(88, "Action_CloneMerge_Merge_Object_32x32.png");
            this.imgCollection.Images.SetKeyName(89, "Action_Close_32x32.png");
            this.imgCollection.Images.SetKeyName(90, "Action_Copy_32x32.png");
            this.imgCollection.Images.SetKeyName(91, "Action_Delete_32x32.png");
            this.imgCollection.Images.SetKeyName(92, "Action_Edit_32x32.png");
            this.imgCollection.Images.SetKeyName(93, "Action_EditModel_32x32.png");
            this.imgCollection.Images.SetKeyName(94, "Action_Exit_32x32.png");
            this.imgCollection.Images.SetKeyName(95, "Action_Export_32x32.png");
            this.imgCollection.Images.SetKeyName(96, "Action_Export_Chart_32x32.png");
            this.imgCollection.Images.SetKeyName(97, "Action_Export_Pivot_32x32.png");
            this.imgCollection.Images.SetKeyName(98, "Action_Export_ToExcel_32x32.png");
            this.imgCollection.Images.SetKeyName(99, "Action_Export_ToHTML_32x32.png");
            this.imgCollection.Images.SetKeyName(100, "Action_Export_ToImage_32x32.png");
            this.imgCollection.Images.SetKeyName(101, "Action_Export_ToMHT_32x32.png");
            this.imgCollection.Images.SetKeyName(102, "Action_Export_ToPDF_32x32.png");
            this.imgCollection.Images.SetKeyName(103, "Action_Export_ToRTF_32x32.png");
            this.imgCollection.Images.SetKeyName(104, "Action_Export_ToText_32x32.png");
            this.imgCollection.Images.SetKeyName(105, "Action_Export_ToXML_32x32.png");
            this.imgCollection.Images.SetKeyName(106, "Action_FileAttachment_Attach_32x32.png");
            this.imgCollection.Images.SetKeyName(107, "Action_Filter_32x32.png");
            this.imgCollection.Images.SetKeyName(108, "Action_Inline_Edit_32x32.png");
            this.imgCollection.Images.SetKeyName(109, "Action_Inline_New_32x32.png");
            this.imgCollection.Images.SetKeyName(110, "Action_LinkUnlink_Link_32x32.png");
            this.imgCollection.Images.SetKeyName(111, "Action_LinkUnlink_Unlink_32x32.png");
            this.imgCollection.Images.SetKeyName(112, "Action_Logoff_32x32.png");
            this.imgCollection.Images.SetKeyName(113, "Action_Navigation_History_Back_32x32.png");
            this.imgCollection.Images.SetKeyName(114, "Action_Navigation_History_Forward_32x32.png");
            this.imgCollection.Images.SetKeyName(115, "Action_Navigation_Next_Object_32x32.png");
            this.imgCollection.Images.SetKeyName(116, "Action_Navigation_Previous_Object_32x32.png");
            this.imgCollection.Images.SetKeyName(117, "Action_NavigationBar_32x32.png");
            this.imgCollection.Images.SetKeyName(118, "Action_New_32x32.png");
            this.imgCollection.Images.SetKeyName(119, "Action_New_32x32_2.png");
            this.imgCollection.Images.SetKeyName(120, "Action_Open_32x32.png");
            this.imgCollection.Images.SetKeyName(121, "Action_Open_Object_32x32.png");
            this.imgCollection.Images.SetKeyName(122, "Action_ParametrizedAction_32x32.png");
            this.imgCollection.Images.SetKeyName(123, "Action_Paste_32x32.png");
            this.imgCollection.Images.SetKeyName(124, "Action_Pivot_Printing_Preview_32x32.png");
            this.imgCollection.Images.SetKeyName(125, "Action_PivotChart_Data_Bind_32x32.png");
            this.imgCollection.Images.SetKeyName(126, "Action_PivotChart_Data_Unbind_32x32.png");
            this.imgCollection.Images.SetKeyName(127, "Action_PopupWindowShowAction_32x32.png");
            this.imgCollection.Images.SetKeyName(128, "Action_Printing_PageSetup_32x32.png");
            this.imgCollection.Images.SetKeyName(129, "Action_Printing_Preview_32x32.png");
            this.imgCollection.Images.SetKeyName(130, "Action_Printing_Print_32x32.png");
            this.imgCollection.Images.SetKeyName(131, "Action_Refresh_32x32.png");
            this.imgCollection.Images.SetKeyName(132, "Action_Report_Object_Inplace_Preview_32x32.png");
            this.imgCollection.Images.SetKeyName(133, "Action_Report_ShowDesigner_32x32.png");
            this.imgCollection.Images.SetKeyName(134, "Action_Report_ShowDesigner_32x32_2.png");
            this.imgCollection.Images.SetKeyName(135, "Action_Save_32x32.png");
            this.imgCollection.Images.SetKeyName(136, "Action_Save_Close_32x32.png");
            this.imgCollection.Images.SetKeyName(137, "Action_Save_New_32x32.png");
            this.imgCollection.Images.SetKeyName(138, "Action_Save_To_32x32.png");
            this.imgCollection.Images.SetKeyName(139, "Action_Search_32x32.png");
            this.imgCollection.Images.SetKeyName(140, "Action_Search_Object_FindObjectByID_32x32.png");
            this.imgCollection.Images.SetKeyName(141, "Action_Security_ChangePassword_32x32.png");
            this.imgCollection.Images.SetKeyName(142, "Action_SimpleAction_32x32.png");
            this.imgCollection.Images.SetKeyName(143, "Action_SingleChoiceAction_32x32.png");
            this.imgCollection.Images.SetKeyName(144, "BO_Address_32x32.png");
            this.imgCollection.Images.SetKeyName(145, "BO_Appointment_32x32.png");
            this.imgCollection.Images.SetKeyName(146, "BO_Attention_32x32.png");
            this.imgCollection.Images.SetKeyName(147, "BO_Category_32x32.png");
            this.imgCollection.Images.SetKeyName(148, "BO_Contact_32x32.png");
            this.imgCollection.Images.SetKeyName(149, "BO_Contract_32x32.png");
            this.imgCollection.Images.SetKeyName(150, "BO_Country_32x32.png");
            this.imgCollection.Images.SetKeyName(151, "BO_Country_v92_32x32.png");
            this.imgCollection.Images.SetKeyName(152, "BO_Customer_32x32.png");
            this.imgCollection.Images.SetKeyName(153, "BO_Department_32x32.png");
            this.imgCollection.Images.SetKeyName(154, "BO_Employee_32x32.png");
            this.imgCollection.Images.SetKeyName(155, "BO_FileAttachment_32x32.png");
            this.imgCollection.Images.SetKeyName(156, "BO_Folder_32x32.png");
            this.imgCollection.Images.SetKeyName(157, "BO_Localization_32x32.png");
            this.imgCollection.Images.SetKeyName(158, "BO_MyDetails_32x32.png");
            this.imgCollection.Images.SetKeyName(159, "BO_Note_32x32.png");
            this.imgCollection.Images.SetKeyName(160, "BO_Order_32x32.png");
            this.imgCollection.Images.SetKeyName(161, "BO_Order_Item_32x32.png");
            this.imgCollection.Images.SetKeyName(162, "BO_Organization_32x32.png");
            this.imgCollection.Images.SetKeyName(163, "BO_Person_32x32.png");
            this.imgCollection.Images.SetKeyName(164, "BO_Phone_32x32.png");
            this.imgCollection.Images.SetKeyName(165, "BO_PivotChart_32x32.png");
            this.imgCollection.Images.SetKeyName(166, "BO_Position_32x32.png");
            this.imgCollection.Images.SetKeyName(167, "BO_Position_v92_32x32.png");
            this.imgCollection.Images.SetKeyName(168, "BO_Product_32x32.png");
            this.imgCollection.Images.SetKeyName(169, "BO_Product_Group_32x32.png");
            this.imgCollection.Images.SetKeyName(170, "BO_Report_32x32.png");
            this.imgCollection.Images.SetKeyName(171, "BO_Resume_32x32.png");
            this.imgCollection.Images.SetKeyName(172, "BO_Role_32x32.png");
            this.imgCollection.Images.SetKeyName(173, "BO_Rules_32x32.png");
            this.imgCollection.Images.SetKeyName(174, "BO_Sale_32x32.png");
            this.imgCollection.Images.SetKeyName(175, "BO_Sale_Item_32x32.png");
            this.imgCollection.Images.SetKeyName(176, "BO_Sale_Item_v92_32x32.png");
            this.imgCollection.Images.SetKeyName(177, "BO_Sale_v92_32x32.png");
            this.imgCollection.Images.SetKeyName(178, "BO_Scheduler_32x32.png");
            this.imgCollection.Images.SetKeyName(179, "BO_Task_32x32.png");
            this.imgCollection.Images.SetKeyName(180, "BO_Unknown_32x32.png");
            this.imgCollection.Images.SetKeyName(181, "BO_User_32x32.png");
            this.imgCollection.Images.SetKeyName(182, "BO_Validation_32x32.png");
            this.imgCollection.Images.SetKeyName(183, "BO_Vendor_32x32.png");
            this.imgCollection.Images.SetKeyName(184, "RibbonPrintPreview_ZoomOutLarge.png");
            this.imgCollection.Images.SetKeyName(185, "RibbonPrintPreview_FillBackgroundLarge.png");
            this.imgCollection.Images.SetKeyName(186, "RibbonPrintPreview_ParametersLarge.png");
            this.imgCollection.Images.SetKeyName(187, "RibbonPrintPreview_PrintDirectLarge.png");
            this.imgCollection.Images.SetKeyName(188, "RibbonPrintPreview_PrintLarge.png");
            this.imgCollection.Images.SetKeyName(189, "RibbonPrintPreview_PrintSetupLarge.png");
            this.imgCollection.Images.SetKeyName(190, "RibbonPrintPreview_SaveLarge.png");
            this.imgCollection.Images.SetKeyName(191, "RibbonPrintPreview_ScaleLarge.png");
            this.imgCollection.Images.SetKeyName(192, "RibbonPrintPreview_SendCsvLarge.png");
            this.imgCollection.Images.SetKeyName(193, "RibbonPrintPreview_SendFileLarge.png");
            this.imgCollection.Images.SetKeyName(194, "RibbonPrintPreview_SendGraphicLarge.png");
            this.imgCollection.Images.SetKeyName(195, "RibbonPrintPreview_SendMhtLarge.png");
            this.imgCollection.Images.SetKeyName(196, "RibbonPrintPreview_SendPdfLarge.png");
            this.imgCollection.Images.SetKeyName(197, "RibbonPrintPreview_SendRtfLarge.png");
            this.imgCollection.Images.SetKeyName(198, "RibbonPrintPreview_SendTxtLarge.png");
            this.imgCollection.Images.SetKeyName(199, "RibbonPrintPreview_SendXlsLarge.png");
            this.imgCollection.Images.SetKeyName(200, "RibbonPrintPreview_SendXlsxLarge.png");
            this.imgCollection.Images.SetKeyName(201, "RibbonPrintPreview_ShowFirstPageLarge.png");
            this.imgCollection.Images.SetKeyName(202, "RibbonPrintPreview_ShowLastPageLarge.png");
            this.imgCollection.Images.SetKeyName(203, "RibbonPrintPreview_ShowNextPageLarge.png");
            this.imgCollection.Images.SetKeyName(204, "RibbonPrintPreview_ShowPrevPageLarge.png");
            this.imgCollection.Images.SetKeyName(205, "RibbonPrintPreview_ZoomInLarge.png");
            this.imgCollection.Images.SetKeyName(206, "RibbonPrintPreview_ZoomLarge.png");
            this.imgCollection.Images.SetKeyName(207, "RibbonUserDesigner_HtmlHomeLarge.png");
            this.imgCollection.Images.SetKeyName(208, "RibbonUserDesigner_HtmlRefreshLarge.png");
            this.imgCollection.Images.SetKeyName(209, "RibbonUserDesigner_HtmlStopLarge.png");
            this.imgCollection.Images.SetKeyName(210, "RibbonUserDesigner_NewReportWizardLarge.png");
            this.imgCollection.Images.SetKeyName(211, "RibbonUserDesigner_PasteLarge.png");
            this.imgCollection.Images.SetKeyName(212, "RibbonUserDesigner_RedoLarge.png");
            this.imgCollection.Images.SetKeyName(213, "RibbonUserDesigner_ScriptsLarge.png");
            this.imgCollection.Images.SetKeyName(214, "RibbonUserDesigner_UndoLarge.png");
            this.imgCollection.Images.SetKeyName(215, "RibbonUserDesigner_WindowsLarge.png");
            this.imgCollection.Images.SetKeyName(216, "RibbonUserDesigner_CopyLarge.png");
            this.imgCollection.Images.SetKeyName(217, "RibbonUserDesigner_CutLarge.png");
            this.imgCollection.Images.SetKeyName(218, "RibbonUserDesigner_HtmlBackwardLarge.png");
            this.imgCollection.Images.SetKeyName(219, "RibbonUserDesigner_HtmlFindLarge.png");
            this.imgCollection.Images.SetKeyName(220, "RibbonUserDesigner_HtmlForwardLarge.png");
            this.imgCollection.Images.SetKeyName(221, "system_help.png");
            this.imgCollection.Images.SetKeyName(222, "preferences_contact_list.png");
            this.imgCollection.Images.SetKeyName(223, "đổi mật khẩu2.png");
            this.imgCollection.Images.SetKeyName(224, "thong tin 2.png");
            this.imgCollection.Images.SetKeyName(225, "Standby2.png");
            this.imgCollection.Images.SetKeyName(226, "Copy (2) of exit.png");
            this.imgCollection.Images.SetKeyName(227, "Nhật ký hệ thống.png");
            this.imgCollection.Images.SetKeyName(228, "Sao lưu.png");
            this.imgCollection.Images.SetKeyName(229, "Sửa chữa.png");
            this.imgCollection.Images.SetKeyName(230, "Copy of document_revert(2).png");
            this.imgCollection.Images.SetKeyName(231, "Kết chuyển.png");
            this.imgCollection.Images.SetKeyName(232, "Nhà phân phối.png");
            this.imgCollection.Images.SetKeyName(233, "khachHang.png");
            this.imgCollection.Images.SetKeyName(234, "Khu vực.png");
            this.imgCollection.Images.SetKeyName(235, "palet-01-icon.png");
            this.imgCollection.Images.SetKeyName(236, "Wood-2-icon.png");
            this.imgCollection.Images.SetKeyName(237, "bộ phận.png");
            this.imgCollection.Images.SetKeyName(238, "desktop-icon.png");
            this.imgCollection.Images.SetKeyName(239, "Rank-History-icon.png");
            this.imgCollection.Images.SetKeyName(240, "quản lý chứng từ.png");
            this.imgCollection.Images.SetKeyName(241, "order-history-icon.png");
            this.imgCollection.Images.SetKeyName(242, "báo cáo 2.png");
            this.imgCollection.Images.SetKeyName(243, "Báo cáo.png");
            this.imgCollection.Images.SetKeyName(244, "TongHopTonKho.png");
            this.imgCollection.Images.SetKeyName(245, "File-History-icon.png");
            this.imgCollection.Images.SetKeyName(246, "Nhap Kho.png");
            this.imgCollection.Images.SetKeyName(247, "Xuat Kho.png");
            this.imgCollection.Images.SetKeyName(248, "Untitled-4.png");
            this.imgCollection.Images.SetKeyName(249, "vn.png");
            this.imgCollection.Images.SetKeyName(250, "eng.png");
            this.imgCollection.Images.SetKeyName(251, "Report1.png");
            this.imgCollection.Images.SetKeyName(252, "BOOYAOSX ICON 60.png");
            this.imgCollection.Images.SetKeyName(253, "report.png");
            this.imgCollection.Images.SetKeyName(254, "Report1.png");
            this.imgCollection.Images.SetKeyName(255, "SKINS.png");
            this.imgCollection.Images.SetKeyName(256, "EXCEL.png");
            this.imgCollection.Images.SetKeyName(257, "Ty-Gia.png");
            this.imgCollection.Images.SetKeyName(258, "doc.png");
            this.imgCollection.Images.SetKeyName(259, "1280810178_stock_task-assigned.png");
            this.imgCollection.Images.SetKeyName(260, "1280810258_stock_certificate.png");
            this.imgCollection.Images.SetKeyName(261, "1280810664_stock_task-recurring.png");
            this.imgCollection.Images.SetKeyName(262, "historys.png");
            this.imgCollection.Images.SetKeyName(263, "Invoi.png");
            this.imgCollection.Images.SetKeyName(264, "aaaa.png");
            this.imgCollection.Images.SetKeyName(265, "createuser.png");
            this.imgCollection.Images.SetKeyName(266, "user.png");
            this.imgCollection.Images.SetKeyName(267, "Action_ChooseSkin.png");
            this.imgCollection.Images.SetKeyName(268, "Document.png");
            this.imgCollection.Images.SetKeyName(269, "Video.png");
            this.imgCollection.Images.SetKeyName(270, "Excel.png");
            this.imgCollection.Images.SetKeyName(274, "Nhom Doi Tac.png");
            this.imgCollection.Images.SetKeyName(275, "Action_AboutInfo_32x32.png");
            this.imgCollection.Images.SetKeyName(277, "BO_Employee_32x32.png");
            this.imgCollection.Images.SetKeyName(278, "categories.png");
            this.imgCollection.Images.SetKeyName(279, "Crate.png");
            this.imgCollection.Images.SetKeyName(280, "Don Vi Tinh.png");
            this.imgCollection.Images.SetKeyName(281, "1329275815_wire_transfer.png");
            this.imgCollection.Images.SetKeyName(282, "1329790850_customer_service.png");
            // 
            // bbiUsers
            // 
            this.bbiUsers.Caption = "Người Dùng";
            this.bbiUsers.Id = 1;
            this.bbiUsers.ImageOptions.ImageIndex = 1;
            this.bbiUsers.ImageOptions.LargeImageIndex = 1;
            this.bbiUsers.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.bbiUsers.Name = "bbiUsers";
            toolTipItem1.Text = "Quản lý người dùng";
            superToolTip1.Items.Add(toolTipItem1);
            this.bbiUsers.SuperTip = superToolTip1;
            this.bbiUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiUsersItemClick);
            // 
            // bbiProvider
            // 
            this.bbiProvider.Caption = "Nhà C.Cấp";
            this.bbiProvider.Id = 26;
            this.bbiProvider.ImageOptions.ImageIndex = 232;
            this.bbiProvider.ImageOptions.LargeImageIndex = 232;
            this.bbiProvider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiProvider.ImageOptions.SvgImage")));
            this.bbiProvider.Name = "bbiProvider";
            this.bbiProvider.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem2.Text = "Quản lý nhà phân phối";
            superToolTip2.Items.Add(toolTipItem2);
            this.bbiProvider.SuperTip = superToolTip2;
            this.bbiProvider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSupplierItemClick);
            // 
            // bbiMaterial
            // 
            this.bbiMaterial.Caption = "Hàng Hoá";
            this.bbiMaterial.Id = 27;
            this.bbiMaterial.ImageOptions.ImageIndex = 279;
            this.bbiMaterial.ImageOptions.LargeImageIndex = 279;
            this.bbiMaterial.Name = "bbiMaterial";
            toolTipItem3.Text = "Quản lý hàng hoá, dịch vụ";
            superToolTip3.Items.Add(toolTipItem3);
            this.bbiMaterial.SuperTip = superToolTip3;
            this.bbiMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiMaterialItemClick);
            // 
            // bbiItemGroup
            // 
            this.bbiItemGroup.Caption = "Nhóm Hàng";
            this.bbiItemGroup.Id = 29;
            this.bbiItemGroup.ImageOptions.ImageIndex = 278;
            this.bbiItemGroup.ImageOptions.LargeImageIndex = 278;
            this.bbiItemGroup.Name = "bbiItemGroup";
            toolTipItem4.Text = "Nhóm sản phẩm";
            superToolTip4.Items.Add(toolTipItem4);
            this.bbiItemGroup.SuperTip = superToolTip4;
            this.bbiItemGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiItemGroupItemClick);
            // 
            // bbiStock
            // 
            this.bbiStock.Caption = "Kho Hàng";
            this.bbiStock.Id = 30;
            this.bbiStock.ImageOptions.ImageIndex = 14;
            this.bbiStock.ImageOptions.LargeImageIndex = 14;
            this.bbiStock.Name = "bbiStock";
            toolTipItem5.Text = "Quản lý kho hàng";
            superToolTip5.Items.Add(toolTipItem5);
            this.bbiStock.SuperTip = superToolTip5;
            this.bbiStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiStockItemClick);
            // 
            // bbiHelp
            // 
            this.bbiHelp.Caption = "Hướng Dẫn Sử Dụng";
            this.bbiHelp.Id = 39;
            this.bbiHelp.ImageOptions.ImageIndex = 221;
            this.bbiHelp.ImageOptions.LargeImageIndex = 221;
            this.bbiHelp.LargeWidth = 65;
            this.bbiHelp.Name = "bbiHelp";
            this.bbiHelp.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiHelpItemClick);
            // 
            // bbiContract
            // 
            this.bbiContract.Caption = "Liên Hệ";
            this.bbiContract.Id = 40;
            this.bbiContract.ImageOptions.ImageIndex = 222;
            this.bbiContract.ImageOptions.LargeImageIndex = 222;
            this.bbiContract.Name = "bbiContract";
            this.bbiContract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiContractItemClick);
            // 
            // bbiWebsite
            // 
            this.bbiWebsite.Caption = "Website";
            this.bbiWebsite.Id = 41;
            this.bbiWebsite.ImageOptions.ImageIndex = 60;
            this.bbiWebsite.ImageOptions.LargeImageIndex = 60;
            this.bbiWebsite.Name = "bbiWebsite";
            this.bbiWebsite.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiWebsite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiWebsiteItemClick);
            // 
            // bbiRegsiter
            // 
            this.bbiRegsiter.Caption = "Đăng Ký";
            this.bbiRegsiter.Id = 42;
            this.bbiRegsiter.ImageOptions.ImageIndex = 54;
            this.bbiRegsiter.ImageOptions.LargeImageIndex = 54;
            this.bbiRegsiter.Name = "bbiRegsiter";
            toolTipItem6.Text = "Đăng ký bản quyền phần mềm, sau khi đăng ký bạn sẽ có được những tính năng đầy đủ" +
    " của phần mềm";
            superToolTip6.Items.Add(toolTipItem6);
            this.bbiRegsiter.SuperTip = superToolTip6;
            this.bbiRegsiter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiRegsiterItemClick);
            // 
            // bbiUpdate
            // 
            this.bbiUpdate.Caption = "Cập Nhật";
            this.bbiUpdate.Id = 43;
            this.bbiUpdate.ImageOptions.ImageIndex = 48;
            this.bbiUpdate.ImageOptions.LargeImageIndex = 48;
            this.bbiUpdate.Name = "bbiUpdate";
            toolTipItem7.Text = "Cập nhật cho phần mềm, để phần mềm luôn chạy ổn định";
            superToolTip7.Items.Add(toolTipItem7);
            this.bbiUpdate.SuperTip = superToolTip7;
            this.bbiUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiUpdateItemClick);
            // 
            // bbiCustomerGroup
            // 
            this.bbiCustomerGroup.Caption = "Khu Vực";
            this.bbiCustomerGroup.Id = 133;
            this.bbiCustomerGroup.ImageOptions.ImageIndex = 234;
            this.bbiCustomerGroup.ImageOptions.LargeImageIndex = 234;
            this.bbiCustomerGroup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCustomerGroup.ImageOptions.SvgImage")));
            this.bbiCustomerGroup.Name = "bbiCustomerGroup";
            this.bbiCustomerGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCustomerGroupItemClick);
            // 
            // bbiInward
            // 
            this.bbiInward.Caption = "Nhập Kho";
            this.bbiInward.Description = "Quản lý nhập kho";
            this.bbiInward.Hint = "Quản lý nhập kho";
            this.bbiInward.Id = 136;
            this.bbiInward.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiInward.ImageOptions.Image")));
            this.bbiInward.ImageOptions.LargeImageIndex = 28;
            this.bbiInward.Name = "bbiInward";
            toolTipItem8.Text = "Quản lý nhập kho";
            superToolTip8.Items.Add(toolTipItem8);
            this.bbiInward.SuperTip = superToolTip8;
            this.bbiInward.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiInwardItemClick);
            // 
            // bbiOutward
            // 
            this.bbiOutward.Caption = "Xuất Kho";
            this.bbiOutward.Description = "Quản lý xuất kho";
            this.bbiOutward.Hint = "Quản lý xuất kho";
            this.bbiOutward.Id = 138;
            this.bbiOutward.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiOutward.ImageOptions.Image")));
            this.bbiOutward.ImageOptions.LargeImageIndex = 31;
            this.bbiOutward.Name = "bbiOutward";
            toolTipItem9.Text = "Quản lý xuất kho\r\n";
            superToolTip9.Items.Add(toolTipItem9);
            this.bbiOutward.SuperTip = superToolTip9;
            this.bbiOutward.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiOutwardItemClick);
            // 
            // bbiTransfer
            // 
            this.bbiTransfer.AccessibleDescription = "r";
            this.bbiTransfer.Caption = "Chuyển Kho             ";
            this.bbiTransfer.Description = "Quản lý chuyển kho";
            this.bbiTransfer.Hint = "Quản lý chuyển kho";
            this.bbiTransfer.Id = 140;
            this.bbiTransfer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiTransfer.ImageOptions.Image")));
            this.bbiTransfer.ImageOptions.ImageIndex = 281;
            this.bbiTransfer.ImageOptions.LargeImageIndex = 281;
            this.bbiTransfer.Name = "bbiTransfer";
            toolTipItem10.Text = "Quản lý chuyển kho";
            superToolTip10.Items.Add(toolTipItem10);
            this.bbiTransfer.SuperTip = superToolTip10;
            this.bbiTransfer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiTransferItemClick);
            // 
            // bbiAdjustment
            // 
            this.bbiAdjustment.Caption = "Kiểm Kê";
            this.bbiAdjustment.Id = 15;
            this.bbiAdjustment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAdjustment.ImageOptions.Image")));
            this.bbiAdjustment.ImageOptions.LargeImageIndex = 27;
            this.bbiAdjustment.Name = "bbiAdjustment";
            toolTipItem11.Text = "Kiểm kê hàng hoá trong kho";
            superToolTip11.Items.Add(toolTipItem11);
            this.bbiAdjustment.SuperTip = superToolTip11;
            this.bbiAdjustment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiAdjustmentItemClick);
            // 
            // bbiCurrency
            // 
            this.bbiCurrency.Caption = "Tiền tệ";
            this.bbiCurrency.Id = 148;
            this.bbiCurrency.ImageOptions.ImageIndex = 40;
            this.bbiCurrency.ImageOptions.LargeImageIndex = 40;
            this.bbiCurrency.Name = "bbiCurrency";
            this.bbiCurrency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCurrencyItemClick);
            // 
            // bbiInventory
            // 
            this.bbiInventory.Caption = "Tồn Kho";
            this.bbiInventory.Id = 187;
            this.bbiInventory.ImageOptions.ImageIndex = 30;
            this.bbiInventory.ImageOptions.LargeImageIndex = 30;
            this.bbiInventory.Name = "bbiInventory";
            this.bbiInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiInventoryItemClick);
            // 
            // bbiDepartment
            // 
            this.bbiDepartment.Caption = "Bộ Phận";
            this.bbiDepartment.Id = 199;
            this.bbiDepartment.ImageOptions.ImageIndex = 276;
            this.bbiDepartment.ImageOptions.LargeImageIndex = 276;
            this.bbiDepartment.Name = "bbiDepartment";
            this.bbiDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDepartmentItemClick);
            // 
            // bbiEmployee
            // 
            this.bbiEmployee.Caption = "Nhân Viên";
            this.bbiEmployee.Id = 200;
            this.bbiEmployee.ImageOptions.ImageIndex = 277;
            this.bbiEmployee.ImageOptions.LargeImageIndex = 277;
            this.bbiEmployee.Name = "bbiEmployee";
            this.bbiEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiEmployeeItemClick);
            // 
            // bbiPacket
            // 
            this.bbiPacket.Caption = "Đóng Gói";
            this.bbiPacket.Description = "Thực hiện lắp ráp sản phẩm theo cấu tạo";
            this.bbiPacket.Id = 210;
            this.bbiPacket.ImageOptions.ImageIndex = 26;
            this.bbiPacket.ImageOptions.LargeImageIndex = 26;
            this.bbiPacket.Name = "bbiPacket";
            this.bbiPacket.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiPacket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiTransOutItemClick);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Caption = "Thông Tin";
            this.btnAuthor.Id = 215;
            this.btnAuthor.ImageOptions.ImageIndex = 52;
            this.btnAuthor.ImageOptions.LargeImageIndex = 52;
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAuthorItemClick);
            // 
            // bbiBackup
            // 
            this.bbiBackup.Caption = "Sao Lưu";
            this.bbiBackup.Description = "Sao lưu dữ liệu";
            this.bbiBackup.Hint = "Sao lưu dữ liệu";
            this.bbiBackup.Id = 217;
            this.bbiBackup.ImageOptions.ImageIndex = 228;
            this.bbiBackup.ImageOptions.LargeImageIndex = 228;
            this.bbiBackup.Name = "bbiBackup";
            toolTipItem12.Text = "Sao lưu dữ liệu";
            superToolTip12.Items.Add(toolTipItem12);
            this.bbiBackup.SuperTip = superToolTip12;
            this.bbiBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiBackupItemClick);
            // 
            // bbiRestore
            // 
            this.bbiRestore.Caption = "Phục Hồi";
            this.bbiRestore.Id = 218;
            this.bbiRestore.ImageOptions.ImageIndex = 272;
            this.bbiRestore.ImageOptions.LargeImageIndex = 272;
            this.bbiRestore.Name = "bbiRestore";
            this.bbiRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiRestoreItemClick);
            // 
            // bbiVideo
            // 
            this.bbiVideo.Caption = "Hướng Dẫn Video";
            this.bbiVideo.Id = 219;
            this.bbiVideo.ImageOptions.ImageIndex = 51;
            this.bbiVideo.ImageOptions.LargeImageIndex = 51;
            this.bbiVideo.Name = "bbiVideo";
            // 
            // lblAccount
            // 
            this.lblAccount.Caption = "Người Sử Dụng: ";
            this.lblAccount.Id = 226;
            this.lblAccount.ImageOptions.ImageIndex = 13;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Nhấn đúp chuột vào đây để mở quản lý người dùng";
            superToolTip13.Items.Add(toolTipTitleItem1);
            this.lblAccount.SuperTip = superToolTip13;
            this.lblAccount.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.lblAccount.ItemDoubleClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LblAccountItemClick);
            // 
            // lblServer
            // 
            this.lblServer.Caption = "Máy Chủ: ";
            this.lblServer.Id = 227;
            this.lblServer.ImageOptions.ImageIndex = 70;
            this.lblServer.Name = "lblServer";
            this.lblServer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Nhấn đúp chuột vào để mở phần mềm quản lý cơ sở dữ liệu";
            toolTipItem13.LeftIndent = 6;
            toolTipItem13.Text = "Chú ý: mọi thao tác trên trên phần mềm quản lý cơ sở dữ liệu đều phải sao lưu dữ " +
    "liệu trước, phòng trường hợp thao tác nhằm, hoặc lỗi do sự cố ngoài ý muốn...";
            superToolTip14.Items.Add(toolTipTitleItem2);
            superToolTip14.Items.Add(toolTipItem13);
            this.lblServer.SuperTip = superToolTip14;
            this.lblServer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.lblServer.ItemDoubleClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LblServerItemClick);
            // 
            // lblDay
            // 
            this.lblDay.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblDay.Caption = "Thời gian:";
            this.lblDay.Id = 229;
            this.lblDay.Name = "lblDay";
            this.lblDay.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // bbiHistory
            // 
            this.bbiHistory.Caption = "Lịch Sử Hàng Hoá";
            this.bbiHistory.Id = 231;
            this.bbiHistory.ImageOptions.ImageIndex = 33;
            this.bbiHistory.ImageOptions.LargeImageIndex = 63;
            this.bbiHistory.Name = "bbiHistory";
            this.bbiHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiHistoryItemClick);
            // 
            // lblDatabase
            // 
            this.lblDatabase.Caption = "CSDL";
            this.lblDatabase.Id = 237;
            this.lblDatabase.ImageOptions.ImageIndex = 72;
            this.lblDatabase.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDatabase.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lblDatabase.ItemAppearance.Normal.Options.UseFont = true;
            this.lblDatabase.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem3.Text = "Nhấn đúp chuột vào đây để sử dụng một cơ sở dữ liệu khác.";
            toolTipItem14.LeftIndent = 6;
            toolTipItem14.Text = "Chú ý: Sau khi cấu hình thành công, khởi động lại phần mềm để nạp cấu hình mới.";
            superToolTip15.Items.Add(toolTipTitleItem3);
            superToolTip15.Items.Add(toolTipItem14);
            this.lblDatabase.SuperTip = superToolTip15;
            this.lblDatabase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.lblDatabase.ItemDoubleClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LblDatabaseItemClick);
            // 
            // bbiFix
            // 
            this.bbiFix.Caption = "Sửa Chữa";
            this.bbiFix.Id = 238;
            this.bbiFix.ImageOptions.ImageIndex = 229;
            this.bbiFix.ImageOptions.LargeImageIndex = 229;
            this.bbiFix.Name = "bbiFix";
            this.bbiFix.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiFix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiFixItemClick);
            // 
            // bbiSysLog
            // 
            this.bbiSysLog.Caption = "Nhật Ký Hệ Thống";
            this.bbiSysLog.Description = "Ghi nhận những thao tác của người dụng";
            this.bbiSysLog.Id = 239;
            this.bbiSysLog.ImageOptions.ImageIndex = 227;
            this.bbiSysLog.ImageOptions.LargeImageIndex = 227;
            this.bbiSysLog.Name = "bbiSysLog";
            this.bbiSysLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSysLogItemClick);
            // 
            // bbiVoucherManager
            // 
            this.bbiVoucherManager.Caption = "Chứng Từ";
            this.bbiVoucherManager.Id = 243;
            this.bbiVoucherManager.ImageOptions.ImageIndex = 210;
            this.bbiVoucherManager.ImageOptions.LargeImageIndex = 210;
            this.bbiVoucherManager.Name = "bbiVoucherManager";
            this.bbiVoucherManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiManagerItemClick);
            // 
            // ISystem
            // 
            this.ISystem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ISystem.Caption = "Hệ Thống";
            this.ISystem.Id = 255;
            this.ISystem.ImageOptions.ImageIndex = 78;
            this.ISystem.ImageOptions.LargeImageIndex = 78;
            this.ISystem.Name = "ISystem";
            this.ISystem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // IInit
            // 
            this.IInit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.IInit.Caption = "Nhập Số Dư Ban Đầu";
            this.IInit.Id = 256;
            this.IInit.ImageOptions.ImageIndex = 79;
            this.IInit.ImageOptions.LargeImageIndex = 79;
            this.IInit.Name = "IInit";
            this.IInit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // IInward
            // 
            this.IInward.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.IInward.Caption = "Nhập Kho";
            this.IInward.Id = 257;
            this.IInward.ImageOptions.ImageIndex = 28;
            this.IInward.ImageOptions.LargeImageIndex = 28;
            this.IInward.Name = "IInward";
            this.IInward.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // IOutward
            // 
            this.IOutward.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.IOutward.Caption = "Xuất Kho";
            this.IOutward.Id = 258;
            this.IOutward.ImageOptions.ImageIndex = 31;
            this.IOutward.ImageOptions.LargeImageIndex = 31;
            this.IOutward.Name = "IOutward";
            this.IOutward.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ITransfer
            // 
            this.ITransfer.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ITransfer.Caption = "Chuyển Kho";
            this.ITransfer.Id = 259;
            this.ITransfer.ImageOptions.ImageIndex = 25;
            this.ITransfer.ImageOptions.LargeImageIndex = 25;
            this.ITransfer.Name = "ITransfer";
            this.ITransfer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // IAdjustment
            // 
            this.IAdjustment.Caption = "Kiểm Kê";
            this.IAdjustment.Id = 260;
            this.IAdjustment.ImageOptions.ImageIndex = 170;
            this.IAdjustment.ImageOptions.LargeImageIndex = 179;
            this.IAdjustment.Name = "IAdjustment";
            this.IAdjustment.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.IAdjustment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiAdjustmentItemClick);
            // 
            // IInventory
            // 
            this.IInventory.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.IInventory.Caption = "Tồn Kho";
            this.IInventory.Id = 261;
            this.IInventory.ImageOptions.ImageIndex = 30;
            this.IInventory.ImageOptions.LargeImageIndex = 30;
            this.IInventory.Name = "IInventory";
            this.IInventory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // IPacket
            // 
            this.IPacket.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.IPacket.Caption = "Đóng Gói";
            this.IPacket.Id = 264;
            this.IPacket.ImageOptions.ImageIndex = 26;
            this.IPacket.ImageOptions.LargeImageIndex = 26;
            this.IPacket.Name = "IPacket";
            // 
            // bbiPrintBarcode
            // 
            this.bbiPrintBarcode.Caption = "Barcode   ";
            this.bbiPrintBarcode.Id = 266;
            this.bbiPrintBarcode.ImageOptions.LargeImageIndex = 80;
            this.bbiPrintBarcode.Name = "bbiPrintBarcode";
            this.bbiPrintBarcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiPrintBarcodeItemClick);
            // 
            // lblVersion
            // 
            this.lblVersion.Id = 267;
            this.lblVersion.Name = "lblVersion";
            // 
            // bbiSaleReport
            // 
            this.bbiSaleReport.Caption = "Theo Sản Phẩm";
            this.bbiSaleReport.Id = 272;
            this.bbiSaleReport.ImageOptions.LargeImageIndex = 255;
            this.bbiSaleReport.Name = "bbiSaleReport";
            this.bbiSaleReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiReportItemClick);
            // 
            // bbiInventorySummary
            // 
            this.bbiInventorySummary.Caption = "Nhập Xuất Tồn";
            this.bbiInventorySummary.Id = 273;
            this.bbiInventorySummary.ImageOptions.ImageIndex = 121;
            this.bbiInventorySummary.ImageOptions.LargeImageIndex = 121;
            this.bbiInventorySummary.Name = "bbiInventorySummary";
            this.bbiInventorySummary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiInventorySummaryItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "Kết Thúc";
            this.bbiExit.Description = "Kết thúc";
            this.bbiExit.Hint = "Kết thúc";
            this.bbiExit.Id = 132;
            this.bbiExit.ImageOptions.ImageIndex = 226;
            this.bbiExit.ImageOptions.LargeImageIndex = 226;
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCloseItemClick);
            // 
            // bbiLogout
            // 
            this.bbiLogout.Caption = "Đăng Xuất";
            this.bbiLogout.Id = 221;
            this.bbiLogout.ImageOptions.ImageIndex = 225;
            this.bbiLogout.ImageOptions.LargeImageIndex = 225;
            this.bbiLogout.Name = "bbiLogout";
            this.bbiLogout.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLogoutItemClick);
            // 
            // bbiChangepassword
            // 
            this.bbiChangepassword.Caption = "Đổi Mật Khẩu         ";
            this.bbiChangepassword.Description = "Đổi Mật Khẩu";
            this.bbiChangepassword.Hint = "Đổi Mật Khẩu";
            this.bbiChangepassword.Id = 8;
            this.bbiChangepassword.ImageOptions.ImageIndex = 3;
            this.bbiChangepassword.ImageOptions.LargeImageIndex = 3;
            this.bbiChangepassword.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.C));
            this.bbiChangepassword.Name = "bbiChangepassword";
            toolTipItem15.Text = "Thay đổi mật khẩu người sử dụng";
            superToolTip16.Items.Add(toolTipItem15);
            this.bbiChangepassword.SuperTip = superToolTip16;
            this.bbiChangepassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiChangepasswordItemClick);
            // 
            // bbiInventoryOrder
            // 
            this.bbiInventoryOrder.Caption = "Đặt Hàng";
            this.bbiInventoryOrder.Id = 275;
            this.bbiInventoryOrder.ImageOptions.ImageIndex = 24;
            this.bbiInventoryOrder.ImageOptions.LargeImageIndex = 24;
            this.bbiInventoryOrder.Name = "bbiInventoryOrder";
            this.bbiInventoryOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiInventoryOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiInventoryOrderItemClick);
            // 
            // bbiUnit
            // 
            this.bbiUnit.Caption = "Đơn Vị Tính         ";
            this.bbiUnit.Id = 276;
            this.bbiUnit.ImageOptions.ImageIndex = 11;
            this.bbiUnit.ImageOptions.LargeImageIndex = 11;
            this.bbiUnit.Name = "bbiUnit";
            this.bbiUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiUnitItemClick);
            // 
            // bbiLocks
            // 
            this.bbiLocks.Caption = "Kết Chuyển";
            this.bbiLocks.Id = 277;
            this.bbiLocks.ImageOptions.ImageIndex = 231;
            this.bbiLocks.ImageOptions.LargeImageIndex = 231;
            this.bbiLocks.Name = "bbiLocks";
            this.bbiLocks.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiLocks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiLockItemClick);
            // 
            // bbiPurchase
            // 
            this.bbiPurchase.Caption = "Mua Hàng";
            this.bbiPurchase.Id = 278;
            this.bbiPurchase.ImageOptions.LargeImageIndex = 161;
            this.bbiPurchase.Name = "bbiPurchase";
            this.bbiPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiPurchaseItemClick);
            // 
            // bbiSale
            // 
            this.bbiSale.Caption = "Bán Hàng ";
            this.bbiSale.Id = 279;
            this.bbiSale.ImageOptions.LargeImageIndex = 161;
            this.bbiSale.Name = "bbiSale";
            this.bbiSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSaleItemClick);
            // 
            // bbiRevenue
            // 
            this.bbiRevenue.Caption = "Doanh Thu";
            this.bbiRevenue.Id = 281;
            this.bbiRevenue.ImageOptions.LargeImageIndex = 78;
            this.bbiRevenue.Name = "bbiRevenue";
            // 
            // bbiReciept
            // 
            this.bbiReciept.Caption = "Thu Tiền";
            this.bbiReciept.Id = 282;
            this.bbiReciept.ImageOptions.LargeImageIndex = 264;
            this.bbiReciept.Name = "bbiReciept";
            this.bbiReciept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCustomerReceiptItemClick);
            // 
            // bbiPayment
            // 
            this.bbiPayment.Caption = "Trả Tiền";
            this.bbiPayment.Id = 283;
            this.bbiPayment.ImageOptions.LargeImageIndex = 264;
            this.bbiPayment.Name = "bbiPayment";
            this.bbiPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCustomerPaymentItemClick);
            // 
            // bbiDebt
            // 
            this.bbiDebt.Caption = "Công Nợ";
            this.bbiDebt.Id = 284;
            this.bbiDebt.ImageOptions.LargeImageIndex = 63;
            this.bbiDebt.Name = "bbiDebt";
            // 
            // bbiInitInventory
            // 
            this.bbiInitInventory.Caption = "Nhập Số Dư Đầu Kỳ";
            this.bbiInitInventory.Id = 285;
            this.bbiInitInventory.ImageOptions.ImageIndex = 242;
            this.bbiInitInventory.ImageOptions.LargeImageIndex = 242;
            this.bbiInitInventory.Name = "bbiInitInventory";
            this.bbiInitInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSaleInitItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiNew.Caption = "Tạo Mới";
            this.bbiNew.DropDownControl = this.pmCommand;
            this.bbiNew.Id = 286;
            this.bbiNew.ImageOptions.ImageIndex = 118;
            this.bbiNew.ImageOptions.LargeImageIndex = 118;
            this.bbiNew.Name = "bbiNew";
            // 
            // pmCommand
            // 
            this.pmCommand.ItemLinks.Add(this.bbiStock);
            this.pmCommand.ItemLinks.Add(this.bbiProvider);
            this.pmCommand.ItemLinks.Add(this.bbiMaterial);
            this.pmCommand.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText;
            this.pmCommand.Name = "pmCommand";
            this.pmCommand.Ribbon = this.rbcMain;
            // 
            // bbiSave
            // 
            this.bbiSave.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiSave.Caption = "Lưu";
            this.bbiSave.DropDownControl = this.pmSave;
            this.bbiSave.Id = 287;
            this.bbiSave.ImageOptions.ImageIndex = 135;
            this.bbiSave.ImageOptions.LargeImageIndex = 135;
            this.bbiSave.Name = "bbiSave";
            // 
            // pmSave
            // 
            this.pmSave.ItemLinks.Add(this.bbiSaveAndNew);
            this.pmSave.ItemLinks.Add(this.bbiSaveAndClose);
            this.pmSave.Name = "pmSave";
            this.pmSave.Ribbon = this.rbcMain;
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Lưu và Tạo Mới";
            this.bbiSaveAndNew.Id = 289;
            this.bbiSaveAndNew.ImageOptions.ImageIndex = 137;
            this.bbiSaveAndNew.ImageOptions.LargeImageIndex = 137;
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Lưu và Đóng";
            this.bbiSaveAndClose.Id = 288;
            this.bbiSaveAndClose.ImageOptions.ImageIndex = 136;
            this.bbiSaveAndClose.ImageOptions.LargeImageIndex = 136;
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Bỏ Qua";
            this.bbiCancel.Id = 290;
            this.bbiCancel.ImageOptions.ImageIndex = 131;
            this.bbiCancel.ImageOptions.LargeImageIndex = 131;
            this.bbiCancel.Name = "bbiCancel";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 291;
            this.bbiDelete.ImageOptions.ImageIndex = 91;
            this.bbiDelete.ImageOptions.LargeImageIndex = 91;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Nạp Lại";
            this.bbiRefresh.Id = 292;
            this.bbiRefresh.ImageOptions.ImageIndex = 208;
            this.bbiRefresh.ImageOptions.LargeImageIndex = 208;
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // bbiPageSetup
            // 
            this.bbiPageSetup.Caption = "Cài Đặt Trang In";
            this.bbiPageSetup.Id = 295;
            this.bbiPageSetup.ImageOptions.ImageIndex = 128;
            this.bbiPageSetup.ImageOptions.LargeImageIndex = 128;
            this.bbiPageSetup.Name = "bbiPageSetup";
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "In";
            this.bbiPrint.Id = 296;
            this.bbiPrint.ImageOptions.ImageIndex = 130;
            this.bbiPrint.ImageOptions.LargeImageIndex = 130;
            this.bbiPrint.Name = "bbiPrint";
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Xem Trước Khi In";
            this.bbiPrintPreview.Id = 297;
            this.bbiPrintPreview.ImageOptions.ImageIndex = 129;
            this.bbiPrintPreview.ImageOptions.LargeImageIndex = 129;
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bbiVaildate
            // 
            this.bbiVaildate.Caption = "Kiểm Tra Dữ Liệu";
            this.bbiVaildate.Id = 298;
            this.bbiVaildate.ImageOptions.ImageIndex = 182;
            this.bbiVaildate.ImageOptions.LargeImageIndex = 182;
            this.bbiVaildate.Name = "bbiVaildate";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Đóng";
            this.bbiClose.Id = 299;
            this.bbiClose.ImageOptions.ImageIndex = 209;
            this.bbiClose.ImageOptions.LargeImageIndex = 209;
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiFilterStock
            // 
            this.bbiFilterStock.Caption = "Kho";
            this.bbiFilterStock.Edit = this.repositoryItemGridLookUpEdit1;
            this.bbiFilterStock.EditWidth = 180;
            this.bbiFilterStock.Id = 303;
            this.bbiFilterStock.Name = "bbiFilterStock";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.ImmediatePopup = true;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // bbiFilterCustomer
            // 
            this.bbiFilterCustomer.Caption = "Khách Hàng";
            this.bbiFilterCustomer.Edit = this.repositoryItemGridLookUpEdit2;
            this.bbiFilterCustomer.EditWidth = 180;
            this.bbiFilterCustomer.Id = 304;
            this.bbiFilterCustomer.Name = "bbiFilterCustomer";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.NullText = "";
            this.repositoryItemGridLookUpEdit2.PopupView = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // bbiView
            // 
            this.bbiView.Caption = "Xem";
            this.bbiView.Id = 305;
            this.bbiView.ImageOptions.ImageIndex = 206;
            this.bbiView.ImageOptions.LargeImageIndex = 206;
            this.bbiView.Name = "bbiView";
            // 
            // bbiCustom
            // 
            this.bbiCustom.Caption = "Hiệu Chỉnh";
            this.bbiCustom.Id = 311;
            this.bbiCustom.ImageOptions.ImageIndex = 93;
            this.bbiCustom.ImageOptions.LargeImageIndex = 93;
            this.bbiCustom.Name = "bbiCustom";
            // 
            // bbiTask
            // 
            this.bbiTask.Caption = "Hiện Thanh Điều Khiển";
            this.bbiTask.Id = 312;
            this.bbiTask.ImageOptions.ImageIndex = 117;
            this.bbiTask.ImageOptions.LargeImageIndex = 117;
            this.bbiTask.Name = "bbiTask";
            // 
            // bbiExport
            // 
            this.bbiExport.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiExport.Caption = "Xuất Dữ Liệu";
            this.bbiExport.Id = 314;
            this.bbiExport.ImageOptions.ImageIndex = 191;
            this.bbiExport.ImageOptions.LargeImageIndex = 191;
            this.bbiExport.Name = "bbiExport";
            // 
            // bbiImport
            // 
            this.bbiImport.Caption = "Nhập Dữ Liệu Từ Tập Tin";
            this.bbiImport.Id = 315;
            this.bbiImport.ImageOptions.LargeImageIndex = 210;
            this.bbiImport.Name = "bbiImport";
            // 
            // bbiChange
            // 
            this.bbiChange.Caption = "Thay Đổi";
            this.bbiChange.Id = 316;
            this.bbiChange.ImageOptions.ImageIndex = 213;
            this.bbiChange.ImageOptions.LargeImageIndex = 213;
            this.bbiChange.Name = "bbiChange";
            // 
            // lblTime
            // 
            this.lblTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblTime.Id = 321;
            this.lblTime.Name = "lblTime";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Quản Lý  Nợ";
            this.barButtonItem1.Id = 323;
            this.barButtonItem1.ImageOptions.LargeImageIndex = 36;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1ItemClick);
            // 
            // bbiReport
            // 
            this.bbiReport.Caption = "Báo Cáo Kho Hàng";
            this.bbiReport.Id = 325;
            this.bbiReport.ImageOptions.DisabledLargeImageIndex = 121;
            this.bbiReport.ImageOptions.LargeImageIndex = 121;
            this.bbiReport.Name = "bbiReport";
            this.bbiReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiPurchaseReportItemClick);
            // 
            // bbiRevenueGenaralReport
            // 
            this.bbiRevenueGenaralReport.Caption = "Theo Khu Vực";
            this.bbiRevenueGenaralReport.Id = 326;
            this.bbiRevenueGenaralReport.ImageOptions.LargeImageIndex = 255;
            this.bbiRevenueGenaralReport.Name = "bbiRevenueGenaralReport";
            // 
            // bbiReportSale
            // 
            this.bbiReportSale.Caption = "Báo Cáo Bán Hàng";
            this.bbiReportSale.Id = 327;
            this.bbiReportSale.ImageOptions.ImageIndex = 46;
            this.bbiReportSale.ImageOptions.LargeImageIndex = 121;
            this.bbiReportSale.Name = "bbiReportSale";
            this.bbiReportSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiSaleAmountReportItemClick);
            // 
            // bbiPurchaseReturn
            // 
            this.bbiPurchaseReturn.Caption = "Trả Hàng";
            this.bbiPurchaseReturn.Id = 329;
            this.bbiPurchaseReturn.ImageOptions.LargeImageIndex = 247;
            this.bbiPurchaseReturn.Name = "bbiPurchaseReturn";
            this.bbiPurchaseReturn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiPurchaseReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem2ItemClick);
            // 
            // bbiExpiredReport
            // 
            this.bbiExpiredReport.Caption = "Danh Sách Mặt Hàng Sắp Hết Hạn";
            this.bbiExpiredReport.Id = 330;
            this.bbiExpiredReport.ImageOptions.LargeImageIndex = 227;
            this.bbiExpiredReport.Name = "bbiExpiredReport";
            this.bbiExpiredReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // lblDatabases
            // 
            this.lblDatabases.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblDatabases.Caption = "CSDL: ";
            this.lblDatabases.Id = 332;
            this.lblDatabases.ImageOptions.ImageIndex = 72;
            this.lblDatabases.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDatabases.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.lblDatabases.ItemAppearance.Normal.Options.UseFont = true;
            this.lblDatabases.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // lblServers
            // 
            this.lblServers.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblServers.Caption = "Máy Chủ: ";
            this.lblServers.Id = 333;
            this.lblServers.ImageOptions.ImageIndex = 70;
            this.lblServers.Name = "lblServers";
            this.lblServers.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // lblAccounts
            // 
            this.lblAccounts.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblAccounts.Caption = "Người Sử Dụng: ";
            this.lblAccounts.Id = 334;
            this.lblAccounts.ImageOptions.ImageIndex = 13;
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiPermission
            // 
            this.bbiPermission.Caption = "Phân Quyền";
            this.bbiPermission.Id = 341;
            this.bbiPermission.ImageOptions.ImageIndex = 2;
            this.bbiPermission.ImageOptions.LargeImageIndex = 2;
            this.bbiPermission.Name = "bbiPermission";
            this.bbiPermission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem4ItemClick);
            // 
            // bbiCustomer
            // 
            this.bbiCustomer.Caption = "Khách Hàng          ";
            this.bbiCustomer.Id = 342;
            this.bbiCustomer.ImageOptions.ImageIndex = 233;
            this.bbiCustomer.ImageOptions.LargeImageIndex = 233;
            this.bbiCustomer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCustomer.ImageOptions.SvgImage")));
            this.bbiCustomer.Name = "bbiCustomer";
            this.bbiCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCustomerItemClick1);
            // 
            // bbiExpire
            // 
            this.bbiExpire.Caption = "Luân Chuyển";
            this.bbiExpire.Id = 343;
            this.bbiExpire.ImageOptions.LargeImageIndex = 66;
            this.bbiExpire.Name = "bbiExpire";
            this.bbiExpire.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiExpire.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiExpireItemClick);
            // 
            // bbiExchangeRate
            // 
            this.bbiExchangeRate.Caption = "Trạng Thái Đơn Hàng";
            this.bbiExchangeRate.Id = 344;
            this.bbiExchangeRate.ImageOptions.ImageIndex = 267;
            this.bbiExchangeRate.ImageOptions.LargeImageIndex = 85;
            this.bbiExchangeRate.Name = "bbiExchangeRate";
            this.bbiExchangeRate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiRateItemClick);
            // 
            // bbiData
            // 
            this.bbiData.Caption = "Quản Lý Dữ Liệu";
            this.bbiData.Id = 345;
            this.bbiData.ImageOptions.LargeImageIndex = 70;
            this.bbiData.Name = "bbiData";
            this.bbiData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDataItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 346;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // lblInfo
            // 
            this.lblInfo.Id = 347;
            this.lblInfo.LeftIndent = 20;
            this.lblInfo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.lblInfo.Name = "lblInfo";
            // 
            // bbSkin
            // 
            this.bbSkin.Caption = "barSubItem1";
            this.bbSkin.Id = 349;
            this.bbSkin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbSkin.ImageOptions.Image")));
            this.bbSkin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbSkin.ImageOptions.LargeImage")));
            this.bbSkin.ImageOptions.LargeImageIndex = 267;
            this.bbSkin.Name = "bbSkin";
            this.bbSkin.Popup += new System.EventHandler(this.BbSkinPopup);
            // 
            // bsiHelp
            // 
            this.bsiHelp.Caption = "Hướng Dẫn Sử Dụng";
            this.bsiHelp.Id = 353;
            this.bsiHelp.ImageOptions.LargeImageIndex = 221;
            this.bsiHelp.LargeWidth = 75;
            this.bsiHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiHelpDoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelpVideo)});
            this.bsiHelp.Name = "bsiHelp";
            // 
            // bbiHelpDoc
            // 
            this.bbiHelpDoc.Caption = "Tài Liệu Hướng Dẫn";
            this.bbiHelpDoc.Id = 354;
            this.bbiHelpDoc.ImageOptions.ImageIndex = 268;
            this.bbiHelpDoc.ImageOptions.LargeImageIndex = 268;
            this.bbiHelpDoc.Name = "bbiHelpDoc";
            this.bbiHelpDoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiHelpDocItemClick);
            // 
            // bbiHelpVideo
            // 
            this.bbiHelpVideo.Caption = "Video Hướng Dẫn";
            this.bbiHelpVideo.Id = 355;
            this.bbiHelpVideo.ImageOptions.ImageIndex = 269;
            this.bbiHelpVideo.ImageOptions.LargeImageIndex = 269;
            this.bbiHelpVideo.Name = "bbiHelpVideo";
            this.bbiHelpVideo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiHelpVideoItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 357;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 358;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bbiImportDic
            // 
            this.bbiImportDic.Caption = "Nhập Danh Mục Từ Excel";
            this.bbiImportDic.Id = 359;
            this.bbiImportDic.ImageOptions.ImageIndex = 272;
            this.bbiImportDic.ImageOptions.LargeImageIndex = 272;
            this.bbiImportDic.Name = "bbiImportDic";
            this.bbiImportDic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiImportDicItemClick);
            // 
            // bbiCompanyInfo
            // 
            this.bbiCompanyInfo.Caption = "Thông Tin";
            this.bbiCompanyInfo.Id = 360;
            this.bbiCompanyInfo.ImageOptions.ImageIndex = 275;
            this.bbiCompanyInfo.ImageOptions.LargeImageIndex = 275;
            this.bbiCompanyInfo.Name = "bbiCompanyInfo";
            this.bbiCompanyInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiOptionItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hỗ Trợ Trực Tuyến";
            this.barButtonItem5.Id = 361;
            this.barButtonItem5.ImageOptions.ImageIndex = 282;
            this.barButtonItem5.ImageOptions.LargeImageIndex = 282;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem5ItemClick);
            // 
            // bbiDeliveryStreet
            // 
            this.bbiDeliveryStreet.Caption = "Tuyến giao hàng";
            this.bbiDeliveryStreet.Id = 364;
            this.bbiDeliveryStreet.ImageOptions.ImageIndex = 157;
            this.bbiDeliveryStreet.ImageOptions.LargeImageIndex = 157;
            this.bbiDeliveryStreet.Name = "bbiDeliveryStreet";
            this.bbiDeliveryStreet.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeliveryStreet_CheckedChanged);
            // 
            // bbiProductBrand
            // 
            this.bbiProductBrand.Caption = "Thương Hiệu";
            this.bbiProductBrand.Id = 365;
            this.bbiProductBrand.ImageOptions.LargeImageIndex = 38;
            this.bbiProductBrand.Name = "bbiProductBrand";
            this.bbiProductBrand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProductBrand_ItemClick);
            // 
            // bbiCar
            // 
            this.bbiCar.Caption = "Danh Sách Xe";
            this.bbiCar.Id = 366;
            this.bbiCar.ImageOptions.ImageIndex = 183;
            this.bbiCar.ImageOptions.LargeImageIndex = 183;
            this.bbiCar.Name = "bbiCar";
            this.bbiCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCar_ItemClick);
            // 
            // bbiIndustry
            // 
            this.bbiIndustry.Caption = "Ngành Hàng";
            this.bbiIndustry.Id = 367;
            this.bbiIndustry.ImageOptions.LargeImageIndex = 87;
            this.bbiIndustry.Name = "bbiIndustry";
            this.bbiIndustry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiIndustry_ItemClick);
            // 
            // bbiSalesOrder
            // 
            this.bbiSalesOrder.Caption = "Đặt Hàng";
            this.bbiSalesOrder.Id = 370;
            this.bbiSalesOrder.ImageOptions.LargeImageIndex = 263;
            this.bbiSalesOrder.Name = "bbiSalesOrder";
            this.bbiSalesOrder.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiSalesOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSalesOrder_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 372;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Doanh Số Ngày";
            this.barButtonItem6.Id = 373;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // rbpDictionary
            // 
            this.rbpDictionary.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgImportDic,
            this.rbpgPartner,
            this.rbpgDicStock,
            this.rpgDeparment});
            this.rbpDictionary.Name = "rbpDictionary";
            this.rbpDictionary.Text = "Danh Mục";
            // 
            // rpgImportDic
            // 
            this.rpgImportDic.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgImportDic.ItemLinks.Add(this.bbiImportDic);
            this.rpgImportDic.Name = "rpgImportDic";
            this.rpgImportDic.Text = "Excel";
            // 
            // rbpgPartner
            // 
            this.rbpgPartner.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbpgPartner.ItemLinks.Add(this.bbiCustomerGroup);
            this.rbpgPartner.ItemLinks.Add(this.bbiCustomer);
            this.rbpgPartner.ItemLinks.Add(this.bbiProvider);
            this.rbpgPartner.Name = "rbpgPartner";
            this.rbpgPartner.Text = "Đối Tác";
            // 
            // rbpgDicStock
            // 
            this.rbpgDicStock.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbpgDicStock.ItemLinks.Add(this.bbiStock);
            this.rbpgDicStock.ItemLinks.Add(this.bbiIndustry, true);
            this.rbpgDicStock.ItemLinks.Add(this.bbiProductBrand);
            this.rbpgDicStock.ItemLinks.Add(this.bbiItemGroup);
            this.rbpgDicStock.ItemLinks.Add(this.bbiUnit);
            this.rbpgDicStock.ItemLinks.Add(this.bbiMaterial);
            this.rbpgDicStock.ItemLinks.Add(this.bbiPrintBarcode, true);
            this.rbpgDicStock.Name = "rbpgDicStock";
            this.rbpgDicStock.Text = "Kho Hàng";
            // 
            // rpgDeparment
            // 
            this.rpgDeparment.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgDeparment.ItemLinks.Add(this.bbiDepartment);
            this.rpgDeparment.ItemLinks.Add(this.bbiEmployee);
            this.rpgDeparment.ItemLinks.Add(this.bbiCar);
            this.rpgDeparment.ItemLinks.Add(this.bbiDeliveryStreet);
            this.rpgDeparment.ItemLinks.Add(this.bbiExchangeRate);
            this.rpgDeparment.Name = "rpgDeparment";
            this.rpgDeparment.Text = "Tổ Chức";
            // 
            // rbpStock
            // 
            this.rbpStock.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgSale,
            this.rpgDebt,
            this.rpgReport,
            this.rpgInvoice,
            this.rpgTool});
            this.rbpStock.Name = "rbpStock";
            this.rbpStock.Text = "Chức Năng";
            // 
            // rbpgSale
            // 
            this.rbpgSale.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbpgSale.ItemLinks.Add(this.bbiPurchase);
            this.rbpgSale.ItemLinks.Add(this.bbiSalesOrder, true);
            this.rbpgSale.ItemLinks.Add(this.bbiSale);
            this.rbpgSale.ItemLinks.Add(this.bbiTransfer, true);
            this.rbpgSale.ItemLinks.Add(this.IAdjustment);
            this.rbpgSale.ItemLinks.Add(this.bbiInventory, true);
            this.rbpgSale.Name = "rbpgSale";
            this.rbpgSale.Text = "Quản Lý Bán Hàng";
            // 
            // rpgDebt
            // 
            this.rpgDebt.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgDebt.ItemLinks.Add(this.bbiReciept);
            this.rpgDebt.ItemLinks.Add(this.bbiPayment);
            this.rpgDebt.Name = "rpgDebt";
            this.rpgDebt.Text = "Công Nợ";
            // 
            // rpgReport
            // 
            this.rpgReport.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgReport.ItemLinks.Add(this.bbiInventorySummary);
            this.rpgReport.ItemLinks.Add(this.bbiReport);
            this.rpgReport.ItemLinks.Add(this.bbiReportSale);
            this.rpgReport.Name = "rpgReport";
            this.rpgReport.Text = "Báo cáo";
            // 
            // rpgInvoice
            // 
            this.rpgInvoice.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgInvoice.ItemLinks.Add(this.bbiVoucherManager);
            this.rpgInvoice.Name = "rpgInvoice";
            this.rpgInvoice.Text = "Chứng Từ";
            // 
            // rpgTool
            // 
            this.rpgTool.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rpgTool.ItemLinks.Add(this.bbiInitInventory);
            this.rpgTool.ItemLinks.Add(this.bbiHistory);
            this.rpgTool.Name = "rpgTool";
            this.rpgTool.Text = "Công Cụ";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Doanh Số";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbpSystem
            // 
            this.rbpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgClose,
            this.rbpgSecurity,
            this.rbpgDatabase});
            this.rbpSystem.Name = "rbpSystem";
            this.rbpSystem.Text = "Hệ Thống";
            // 
            // rbpgClose
            // 
            this.rbpgClose.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbpgClose.ItemLinks.Add(this.bbiExit);
            this.rbpgClose.ItemLinks.Add(this.bbiLogout);
            this.rbpgClose.ItemLinks.Add(this.bbiCompanyInfo);
            this.rbpgClose.Name = "rbpgClose";
            this.rbpgClose.Text = "Hệ Thống";
            // 
            // rbpgSecurity
            // 
            this.rbpgSecurity.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbpgSecurity.ItemLinks.Add(this.bbiPermission);
            this.rbpgSecurity.ItemLinks.Add(this.bbiChangepassword);
            this.rbpgSecurity.ItemLinks.Add(this.bbiSysLog);
            this.rbpgSecurity.Name = "rbpgSecurity";
            this.rbpgSecurity.Text = "Bảo Mật";
            // 
            // rbpgDatabase
            // 
            this.rbpgDatabase.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.rbpgDatabase.ItemLinks.Add(this.bbiBackup);
            this.rbpgDatabase.ItemLinks.Add(this.bbiRestore);
            this.rbpgDatabase.ItemLinks.Add(this.bbiFix);
            this.rbpgDatabase.ItemLinks.Add(this.bbiLocks);
            this.rbpgDatabase.Name = "rbpgDatabase";
            this.rbpgDatabase.Text = "Dữ Liệu";
            // 
            // rbpHelp
            // 
            this.rbpHelp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rbpHelp.Name = "rbpHelp";
            this.rbpHelp.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.bsiHelp);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiContract);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiWebsite);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiRegsiter);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAuthor);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiUpdate);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông Tin";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.AutoHeight = true;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.PopupView = this.repositoryItemGridLookUpEdit3View;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // rbsMain
            // 
            this.rbsMain.ItemLinks.Add(this.lblAccounts, true);
            this.rbsMain.ItemLinks.Add(this.lblServers, true);
            this.rbsMain.ItemLinks.Add(this.lblDatabases);
            this.rbsMain.ItemLinks.Add(this.lblTime);
            this.rbsMain.ItemLinks.Add(this.lblDay, true);
            this.rbsMain.ItemLinks.Add(this.lblVersion, true);
            this.rbsMain.ItemLinks.Add(this.lblInfo);
            this.rbsMain.Location = new System.Drawing.Point(0, 648);
            this.rbsMain.Name = "rbsMain";
            this.rbsMain.Ribbon = this.rbcMain;
            this.rbsMain.Size = new System.Drawing.Size(1689, 24);
            // 
            // tabMdi
            // 
            this.tabMdi.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.tabMdi.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Close) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.tabMdi.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Always;
            this.tabMdi.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabMdi.MdiParent = this;
            this.tabMdi.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows;
            this.tabMdi.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            this.tabMdi.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // ImgSmall
            // 
            this.ImgSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImgSmall.ImageStream")));
            this.ImgSmall.Images.SetKeyName(0, "Ket Thuc.png");
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 374;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1689, 672);
            this.Controls.Add(this.rbsMain);
            this.Controls.Add(this.rbcMain);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.rbcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.rbsMain;
            this.Text = "Phần Mềm Quản Lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainFormClosing);
            this.Load += new System.EventHandler(this.FrmMainLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rbcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbsMain;
        private DevExpress.XtraBars.BarButtonItem bbiUsers;
        private DevExpress.XtraBars.BarButtonItem bbiProvider;
        private DevExpress.XtraBars.BarButtonItem bbiMaterial;
        private DevExpress.XtraBars.BarButtonItem bbiItemGroup;
        private DevExpress.XtraBars.BarButtonItem bbiStock;
        private DevExpress.XtraBars.BarButtonItem bbiHelp;
        private DevExpress.XtraBars.BarButtonItem bbiContract;
        private DevExpress.XtraBars.BarButtonItem bbiWebsite;
        private DevExpress.XtraBars.BarButtonItem bbiRegsiter;
        private DevExpress.XtraBars.BarButtonItem bbiUpdate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgSecurity;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgClose;
        private DevExpress.XtraBars.BarButtonItem bbiCustomerGroup;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdi;
        private DevExpress.XtraBars.BarButtonItem bbiInward;
        private DevExpress.XtraBars.BarButtonItem bbiOutward;
        private DevExpress.Utils.ImageCollection imgCollection;
        private DevExpress.XtraBars.BarButtonItem bbiTransfer;
        private DevExpress.XtraBars.BarButtonItem bbiAdjustment;
        private DevExpress.XtraBars.BarButtonItem bbiCurrency;
        private DevExpress.XtraBars.BarButtonItem bbiInventory;
        private DevExpress.XtraBars.BarButtonItem bbiDepartment;
        private DevExpress.XtraBars.BarButtonItem bbiEmployee;
        private DevExpress.XtraBars.BarButtonItem bbiPacket;
        private DevExpress.XtraBars.BarButtonItem btnAuthor;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDictionary;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgPartner;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgDicStock;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDeparment;

        private XfmInward _xfmInward;
        private XfmOutward _xfmOutward;
        private XfmTransfer _xfmTransfer;
        private xfmInventoryDetail xfmInventoryDetail;
        private xfmInventorySummary xfmInventorySummary;
        private xfmPacket _xfmPacket;
        private xfmProducts xfmProducts;
        private XfmInventoryInit xfmInventoryInit;
        private xfmUsers xfmUsers;
        private xfmGroups xfmGroups;
        private XfmCustomers xfmCustomers;
        private xfmProviders xfmProviders;
        private XfmStocks xfmStocks;
        private xfmProductGroups xfmProductGroups;
        private xfmEmployees xfmEmployees;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgDatabase;
        private DevExpress.XtraBars.BarButtonItem bbiBackup;
        private DevExpress.XtraBars.BarButtonItem bbiRestore;
        private DevExpress.XtraBars.BarButtonItem bbiVideo;
        private DevExpress.XtraBars.BarStaticItem lblAccount;
        private DevExpress.XtraBars.BarStaticItem lblServer;
        private DevExpress.XtraBars.BarStaticItem lblDay;
        private Timer timer;


        private XfmPayment _xfmPayment;
        private XfmReiceipt _xfmReiceipt;
        private XfmSaleAmountReport _xfmSaleAmountReport;

        private DevExpress.XtraBars.BarButtonItem bbiHistory;
        private xfmHistory _xfmHistory;
        private xfmSearch _xfmSearch;
        private DevExpress.XtraBars.BarStaticItem lblDatabase;
        private DevExpress.XtraBars.BarButtonItem bbiFix;
        private DevExpress.XtraBars.BarButtonItem bbiSysLog;
        private xfmSysLog xfmSysLog;
        private xfmUnits _xfmUnits;
        private XfmDepartments _xfmDepartments;
        private DevExpress.XtraBars.BarButtonItem bbiVoucherManager;
        private xfmManagers _xfmManagers;
        private xfmInventoryOrders _xfmInventoryOrders;
        private xfmInventoryDetailSummary _xfmInventoryDetailSummary;
        private xfmPacket xfmSale2;
        private DevExpress.XtraBars.BarButtonItem ISystem;
        private DevExpress.XtraBars.BarButtonItem IInit;
        private DevExpress.XtraBars.BarButtonItem IInward;
        private DevExpress.XtraBars.BarButtonItem IOutward;
        private DevExpress.XtraBars.BarButtonItem ITransfer;
        private DevExpress.XtraBars.BarButtonItem IAdjustment;
        private DevExpress.XtraBars.BarButtonItem IPacket;
        private DevExpress.XtraBars.BarButtonItem IInventory;
        private DevExpress.Utils.ImageCollection ImgSmall;
        private DevExpress.XtraBars.BarButtonItem bbiPrintBarcode;
        private DevExpress.XtraBars.BarStaticItem lblVersion;
        private DevExpress.XtraBars.BarButtonItem bbiChangepassword;
        private DevExpress.XtraBars.BarButtonItem bbiLogout;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        private DevExpress.XtraBars.BarButtonItem bbiSaleReport;
        private DevExpress.XtraBars.BarButtonItem bbiInventorySummary;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTool;
        private DevExpress.XtraBars.BarButtonItem bbiInventoryOrder;
        private DevExpress.XtraBars.BarButtonItem bbiUnit;
        private DevExpress.XtraBars.BarButtonItem bbiLocks;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpStock;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgSale;
        private DevExpress.XtraBars.BarButtonItem bbiPurchase;
        private DevExpress.XtraBars.BarButtonItem bbiSale;
        private DevExpress.XtraBars.BarButtonItem bbiRevenue;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDebt;
        private DevExpress.XtraBars.BarButtonItem bbiReciept;
        private DevExpress.XtraBars.BarButtonItem bbiPayment;
        private DevExpress.XtraBars.BarButtonItem bbiDebt;
        private DevExpress.XtraBars.BarButtonItem bbiInitInventory;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiPageSetup;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarButtonItem bbiVaildate;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarEditItem bbiFilterStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarEditItem bbiFilterCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraBars.BarButtonItem bbiView;
        private DevExpress.XtraBars.BarButtonItem bbiCustom;
        private DevExpress.XtraBars.BarButtonItem bbiTask;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiImport;
        private DevExpress.XtraBars.BarButtonItem bbiChange;
        private DevExpress.XtraBars.PopupMenu pmCommand;
        private DevExpress.XtraBars.PopupMenu pmSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private DevExpress.XtraBars.BarStaticItem lblTime;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbiReport;
        private DevExpress.XtraBars.BarButtonItem bbiRevenueGenaralReport;
        private DevExpress.XtraBars.BarButtonItem bbiReportSale;
        private DevExpress.XtraBars.BarButtonItem bbiPurchaseReturn;
        private DevExpress.XtraBars.BarButtonItem bbiExpiredReport;
        private DevExpress.XtraBars.BarStaticItem lblDatabases;
        private DevExpress.XtraBars.BarStaticItem lblServers;
        private DevExpress.XtraBars.BarStaticItem lblAccounts;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiPermission;
        private DevExpress.XtraBars.BarButtonItem bbiCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReport;
        private DevExpress.XtraBars.BarButtonItem bbiExpire;
        private DevExpress.XtraBars.BarButtonItem bbiExchangeRate;
        private DevExpress.XtraBars.BarButtonItem bbiData;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgInvoice;
        private DevExpress.XtraBars.BarStaticItem lblInfo;
        private DevExpress.XtraBars.BarSubItem bbSkin;
        private DevExpress.LookAndFeel.DefaultLookAndFeel Skin;
        private DevExpress.XtraBars.BarSubItem bsiHelp;
        private DevExpress.XtraBars.BarButtonItem bbiHelpDoc;
        private DevExpress.XtraBars.BarButtonItem bbiHelpVideo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgImportDic;
        private DevExpress.XtraBars.BarButtonItem bbiImportDic;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHelp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiCompanyInfo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarCheckItem bbiDeliveryStreet;
        private DevExpress.XtraBars.BarButtonItem bbiProductBrand;
        private DevExpress.XtraBars.BarButtonItem bbiCar;
        private DevExpress.XtraBars.BarButtonItem bbiIndustry;
        private DevExpress.XtraBars.BarButtonItem bbiSalesOrder;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
    }
}