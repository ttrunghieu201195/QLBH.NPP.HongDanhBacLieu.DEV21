using Perfect.Inventory.Core.Common.DS;
using Perfect.Inventory.Core.Inventory.Adjustment02; 
using Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustmentManaTableAdapters;
using Perfect.Inventory.Core.Inventory.Adjustment02.DS;
using Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustmentTableAdapters;

namespace Perfect.Inventory.Core.Inventory.Adjustment
{
    partial class XucInventoryAdjustment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucInventoryAdjustment));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbxStock = new Perfect.Common.xucLookEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.bttLoadAgain = new DevExpress.XtraEditors.SimpleButton();
            this.bttView = new DevExpress.XtraEditors.SimpleButton();
            this.gcList01 = new DevExpress.XtraGrid.GridControl();
            this.aDJUSTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjustmentMana1 = new Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustmentMana();
            this.gbList01 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colStock_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bttDelete = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lc01 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProductDetail = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProduct = new DevExpress.XtraBars.BarSubItem();
            this.bbiHistory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInit = new DevExpress.XtraBars.BarButtonItem();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYGetListAdjustmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjustment1 = new Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustment();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgProduct = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Inventory.Core.Common.DS.dsPRODUCT();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpProductName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCurrentQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNewQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colQtyDiff = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpVal01 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            this.iNVENTORY_GetList_AdjustmentTableAdapter = new Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustmentTableAdapters.INVENTORY_GetList_AdjustmentTableAdapter();
            this.aDJUSTMENTTableAdapter1 = new Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustmentManaTableAdapters.ADJUSTMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJUSTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustmentMana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYGetListAdjustmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.cbxStock);
            this.panelControl2.Controls.Add(this.btnSearch);
            this.panelControl2.Controls.Add(this.btnClose);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(710, 32);
            this.panelControl2.TabIndex = 2;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 91;
            this.labelControl1.Text = "Chọn kho hàng";
            // 
            // cbxStock
            // 
            this.cbxStock.DefaultText = "Kho Hàng";
            this.cbxStock.EditValue = "";
            this.cbxStock.Location = new System.Drawing.Point(92, 5);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.cbxStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbxStock.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cbxStock.Properties.Appearance.Options.UseBackColor = true;
            this.cbxStock.Properties.Appearance.Options.UseFont = true;
            this.cbxStock.Properties.Appearance.Options.UseForeColor = true;
            this.cbxStock.Properties.AutoComplete = false;
            this.cbxStock.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbxStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStock.Properties.DataSource = this.sTOCKBindingSource;
            this.cbxStock.Properties.DisplayMember = "Stock_Name";
            this.cbxStock.Properties.NullText = "Kho Hàng";
            this.cbxStock.Properties.NullValuePrompt = "Kho Hàng";
            this.cbxStock.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbxStock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxStock.Properties.ValueMember = "Stock_ID";
            this.cbxStock.Properties.View = this.gridView2;
            this.cbxStock.Size = new System.Drawing.Size(215, 23);
            this.cbxStock.TabIndex = 90;
            this.cbxStock.EditValueChanged += new System.EventHandler(this.cbxStock_EditValueChanged);
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsSTOCK;
            // 
            // dsSTOCK
            // 
            this.dsSTOCK.DataSetName = "dsSTOCK";
            this.dsSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStock_Name,
            this.colStock_ID1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 0;
            this.colStock_Name.Width = 200;
            // 
            // colStock_ID1
            // 
            this.colStock_ID1.Caption = "Mã Kho";
            this.colStock_ID1.FieldName = "Stock_ID";
            this.colStock_ID1.Name = "colStock_ID1";
            this.colStock_ID1.Visible = true;
            this.colStock_ID1.VisibleIndex = 1;
            this.colStock_ID1.Width = 120;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageIndex = 35;
            this.btnSearch.ImageList = this.imageCollection2;
            this.btnSearch.Location = new System.Drawing.Point(319, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(36, "reload321.png");
            this.imageCollection2.Images.SetKeyName(37, "Xuat.png");
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 13;
            this.btnClose.ImageList = this.imageCollection2;
            this.btnClose.Location = new System.Drawing.Point(471, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageCollection2;
            this.btnSave.Location = new System.Drawing.Point(395, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // bm
            // 
            this.bm.AutoSaveInRegistry = true;
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.DockManager = this.dockManager1;
            this.bm.Form = this;
            this.bm.Images = this.imageCollection2;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPrint,
            this.bbiRefresh,
            this.bbiExport,
            this.bbiHelp,
            this.bbiClose,
            this.bbiProductDetail,
            this.bbiProduct,
            this.bbiHistory,
            this.bbiImport,
            this.bbiInit});
            this.bm.MaxItemId = 18;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("c1d22d0f-5533-415c-8de3-e0b3d747364f");
            this.dockPanel1.Location = new System.Drawing.Point(710, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(372, 200);
            this.dockPanel1.Size = new System.Drawing.Size(372, 494);
            this.dockPanel1.Text = "Lịch sử Kiểm Kê";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(366, 466);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bttLoadAgain);
            this.layoutControl1.Controls.Add(this.bttView);
            this.layoutControl1.Controls.Add(this.gcList01);
            this.layoutControl1.Controls.Add(this.bttDelete);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(366, 466);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bttLoadAgain
            // 
            this.bttLoadAgain.ImageIndex = 33;
            this.bttLoadAgain.ImageList = this.imageCollection2;
            this.bttLoadAgain.Location = new System.Drawing.Point(128, 2);
            this.bttLoadAgain.Name = "bttLoadAgain";
            this.bttLoadAgain.Size = new System.Drawing.Size(121, 22);
            this.bttLoadAgain.StyleController = this.layoutControl1;
            this.bttLoadAgain.TabIndex = 6;
            this.bttLoadAgain.Text = "Nạp";
            this.bttLoadAgain.Click += new System.EventHandler(this.BttLoadAgainClick);
            // 
            // bttView
            // 
            this.bttView.ImageIndex = 34;
            this.bttView.ImageList = this.imageCollection2;
            this.bttView.Location = new System.Drawing.Point(2, 2);
            this.bttView.Name = "bttView";
            this.bttView.Size = new System.Drawing.Size(122, 22);
            this.bttView.StyleController = this.layoutControl1;
            this.bttView.TabIndex = 5;
            this.bttView.Text = "Xem";
            this.bttView.Click += new System.EventHandler(this.BttViewClick);
            // 
            // gcList01
            // 
            this.gcList01.DataSource = this.aDJUSTMENTBindingSource;
            this.gcList01.Location = new System.Drawing.Point(2, 28);
            this.gcList01.MainView = this.gbList01;
            this.gcList01.MenuManager = this.bm;
            this.gcList01.Name = "gcList01";
            this.gcList01.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpDate});
            this.gcList01.Size = new System.Drawing.Size(362, 436);
            this.gcList01.TabIndex = 4;
            this.gcList01.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList01});
            // 
            // aDJUSTMENTBindingSource
            // 
            this.aDJUSTMENTBindingSource.DataMember = "ADJUSTMENT";
            this.aDJUSTMENTBindingSource.DataSource = this.dsAdjustmentMana1;
            // 
            // dsAdjustmentMana1
            // 
            this.dsAdjustmentMana1.DataSetName = "dsAdjustmentMana";
            this.dsAdjustmentMana1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList01
            // 
            this.gbList01.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRefDate,
            this.colStock_Name1});
            this.gbList01.GridControl = this.gcList01;
            this.gbList01.IndicatorWidth = 40;
            this.gbList01.Name = "gbList01";
            this.gbList01.OptionsBehavior.Editable = false;
            this.gbList01.OptionsBehavior.ReadOnly = true;
            this.gbList01.OptionsSelection.InvertSelection = true;
            this.gbList01.OptionsView.ShowAutoFilterRow = true;
            this.gbList01.OptionsView.ShowGroupPanel = false;
            this.gbList01.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRefDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gbList01.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList01_CustomDrawRowIndicator);
            this.gbList01.DoubleClick += new System.EventHandler(this.GbList01DoubleClick);
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Mã Kiểm Kê";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 122;
            // 
            // colRefDate
            // 
            this.colRefDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.ColumnEdit = this.rpDate;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate.Visible = true;
            this.colRefDate.VisibleIndex = 1;
            // 
            // rpDate
            // 
            this.rpDate.AutoHeight = false;
            this.rpDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.rpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rpDate.EditFormat.FormatString = "dd/MM/yyyy";
            this.rpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rpDate.Name = "rpDate";
            this.rpDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colStock_Name1
            // 
            this.colStock_Name1.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name1.Caption = "Kho hàng";
            this.colStock_Name1.FieldName = "Stock_Name";
            this.colStock_Name1.Name = "colStock_Name1";
            this.colStock_Name1.OptionsColumn.ReadOnly = true;
            this.colStock_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name1.Visible = true;
            this.colStock_Name1.VisibleIndex = 2;
            this.colStock_Name1.Width = 121;
            // 
            // bttDelete
            // 
            this.bttDelete.ImageIndex = 4;
            this.bttDelete.ImageList = this.imageCollection2;
            this.bttDelete.Location = new System.Drawing.Point(253, 2);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(111, 22);
            this.bttDelete.StyleController = this.layoutControl1;
            this.bttDelete.TabIndex = 7;
            this.bttDelete.Text = "Xoá";
            this.bttDelete.Click += new System.EventHandler(this.BttDeleteClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lc01,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(366, 466);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lc01
            // 
            this.lc01.Control = this.gcList01;
            this.lc01.CustomizationFormText = "lc01";
            this.lc01.Location = new System.Drawing.Point(0, 26);
            this.lc01.Name = "lc01";
            this.lc01.Size = new System.Drawing.Size(366, 440);
            this.lc01.Text = "lc01";
            this.lc01.TextSize = new System.Drawing.Size(0, 0);
            this.lc01.TextToControlDistance = 0;
            this.lc01.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bttView;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(126, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.bttLoadAgain;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(126, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bttDelete;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(115, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "In";
            this.bbiPrint.Id = 3;
            this.bbiPrint.ImageIndex = 9;
            this.bbiPrint.Name = "bbiPrint";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiRefresh.Appearance.Options.UseFont = true;
            this.bbiRefresh.Caption = "Xem";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageIndex = 35;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiRefreshItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Xuất";
            this.bbiExport.Id = 5;
            this.bbiExport.ImageIndex = 37;
            this.bbiExport.LargeImageIndex = 19;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiExportItemClick);
            // 
            // bbiHelp
            // 
            this.bbiHelp.Caption = "Trợ Giúp";
            this.bbiHelp.Id = 6;
            this.bbiHelp.ImageIndex = 16;
            this.bbiHelp.Name = "bbiHelp";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Đóng";
            this.bbiClose.Id = 10;
            this.bbiClose.ImageIndex = 13;
            this.bbiClose.LargeImageIndex = 1;
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCloseItemClick);
            // 
            // bbiProductDetail
            // 
            this.bbiProductDetail.Caption = "Chi Tiết";
            this.bbiProductDetail.Id = 13;
            this.bbiProductDetail.Name = "bbiProductDetail";
            this.bbiProductDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiProductDetailItemClick);
            // 
            // bbiProduct
            // 
            this.bbiProduct.Caption = "Hàng Hoá";
            this.bbiProduct.Id = 14;
            this.bbiProduct.ImageIndex = 15;
            this.bbiProduct.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductDetail),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHistory)});
            this.bbiProduct.Name = "bbiProduct";
            // 
            // bbiHistory
            // 
            this.bbiHistory.Caption = "Lịch Sử";
            this.bbiHistory.Id = 15;
            this.bbiHistory.Name = "bbiHistory";
            this.bbiHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiHistoryItemClick);
            // 
            // bbiImport
            // 
            this.bbiImport.Caption = "Kiểm Kê Từ Tập Tin";
            this.bbiImport.Id = 16;
            this.bbiImport.ImageIndex = 3;
            this.bbiImport.Name = "bbiImport";
            toolTipItem1.Text = "Chuyển dữ Liệu Từ Excel vào Phần Mềm";
            superToolTip1.Items.Add(toolTipItem1);
            this.bbiImport.SuperTip = superToolTip1;
            this.bbiImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiImportItemClick);
            // 
            // bbiInit
            // 
            this.bbiInit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bbiInit.Appearance.Options.UseFont = true;
            this.bbiInit.Caption = "Lưu";
            this.bbiInit.Id = 17;
            this.bbiInit.ImageIndex = 1;
            this.bbiInit.Name = "bbiInit";
            this.bbiInit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiInitItemClick);
            // 
            // gcList
            // 
            this.gcList.DataSource = this.iNVENTORYGetListAdjustmentBindingSource1;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal,
            this.rpgProduct,
            this.rpUnit,
            this.rpProductName,
            this.rpStock,
            this.rpVal01});
            this.gcList.Size = new System.Drawing.Size(706, 458);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // iNVENTORYGetListAdjustmentBindingSource1
            // 
            this.iNVENTORYGetListAdjustmentBindingSource1.DataMember = "INVENTORY_GetList_Adjustment";
            this.iNVENTORYGetListAdjustmentBindingSource1.DataSource = this.dsAdjustment1;
            // 
            // dsAdjustment1
            // 
            this.dsAdjustment1.DataSetName = "dsAdjustment";
            this.dsAdjustment1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.gbList.Appearance.Row.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand6,
            this.gridBand5,
            this.gridBand4,
            this.gridBand2,
            this.gridBand3});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_ID,
            this.colItemID,
            this.colStock_ID,
            this.colUnit,
            this.colCurrentQty,
            this.colQtyDiff,
            this.colUnitPrice,
            this.colAmount,
            this.colNewQty});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1048, 355, 223, 235);
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gbList.IndicatorWidth = 35;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsDetail.AutoZoomDetail = true;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.PaintStyleName = "Skin";
            this.gbList.PreviewFieldName = "ItemID";
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.ViewCaption = "Bảng Kế Kiểm Kê";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GbListCellValueChanged);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GbListKeyDown);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.gbList_DoubleClick);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GbListCustomSummaryCalculate);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colItemID);
            this.gridBand1.Columns.Add(this.colStock_ID);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.Width = 564;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.ColumnEdit = this.rpgProduct;
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 138;
            // 
            // rpgProduct
            // 
            this.rpgProduct.AutoHeight = false;
            this.rpgProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpgProduct.DataSource = this.pRODUCTBindingSource;
            this.rpgProduct.DisplayMember = "Product_ID";
            this.rpgProduct.ImmediatePopup = true;
            this.rpgProduct.Name = "rpgProduct";
            this.rpgProduct.NullText = "";
            this.rpgProduct.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpgProduct.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgProduct.ValueMember = "Product_ID";
            this.rpgProduct.View = this.gridView3;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dsPRODUCT;
            // 
            // dsPRODUCT
            // 
            this.dsPRODUCT.DataSetName = "dsPRODUCT";
            this.dsPRODUCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID2,
            this.colProduct_Name1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct_ID2
            // 
            this.colProduct_ID2.FieldName = "Product_ID";
            this.colProduct_ID2.Name = "colProduct_ID2";
            this.colProduct_ID2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID2.Visible = true;
            this.colProduct_ID2.VisibleIndex = 0;
            // 
            // colProduct_Name1
            // 
            this.colProduct_Name1.Caption = "Tên hàng";
            this.colProduct_Name1.FieldName = "Product_Name";
            this.colProduct_Name1.Name = "colProduct_Name1";
            this.colProduct_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name1.Visible = true;
            this.colProduct_Name1.VisibleIndex = 1;
            // 
            // colItemID
            // 
            this.colItemID.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemID.Caption = "Hàng Hoá";
            this.colItemID.ColumnEdit = this.rpProductName;
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.OptionsColumn.ReadOnly = true;
            this.colItemID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colItemID.Visible = true;
            this.colItemID.Width = 355;
            // 
            // rpProductName
            // 
            this.rpProductName.AutoHeight = false;
            this.rpProductName.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.rpProductName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpProductName.DataSource = this.pRODUCTBindingSource;
            this.rpProductName.DisplayMember = "Product_Name";
            this.rpProductName.ImmediatePopup = true;
            this.rpProductName.Name = "rpProductName";
            this.rpProductName.NullText = "(Gõ vào đây)";
            this.rpProductName.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpProductName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpProductName.ValueMember = "Product_ID";
            this.rpProductName.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID1,
            this.colProduct_Name});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct_ID1
            // 
            this.colProduct_ID1.Caption = "Mã số";
            this.colProduct_ID1.FieldName = "Product_ID";
            this.colProduct_ID1.Name = "colProduct_ID1";
            this.colProduct_ID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID1.Visible = true;
            this.colProduct_ID1.VisibleIndex = 0;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Tên";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 1;
            // 
            // colStock_ID
            // 
            this.colStock_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID.Caption = "Kho Hàng";
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.ReadOnly = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID.Width = 226;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.Caption = "Đơn vị";
            this.colUnit.ColumnEdit = this.rpUnit;
            this.colUnit.FieldName = "Unit";
            this.colUnit.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Visible = true;
            this.colUnit.Width = 71;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoHeight = false;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DataSource = this.uNITBindingSource;
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.ImmediatePopup = true;
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "";
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.gridView1;
            // 
            // uNITBindingSource
            // 
            this.uNITBindingSource.DataMember = "UNIT";
            this.uNITBindingSource.DataSource = this.dsUnit;
            // 
            // dsUnit
            // 
            this.dsUnit.DataSetName = "dsUnit";
            this.dsUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "gridBand6";
            this.gridBand6.Columns.Add(this.colCurrentQty);
            this.gridBand6.MinWidth = 20;
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 103;
            // 
            // colCurrentQty
            // 
            this.colCurrentQty.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colCurrentQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCurrentQty.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colCurrentQty.AppearanceCell.Options.UseBackColor = true;
            this.colCurrentQty.AppearanceCell.Options.UseFont = true;
            this.colCurrentQty.AppearanceCell.Options.UseForeColor = true;
            this.colCurrentQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrentQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrentQty.Caption = "SL Tồn";
            this.colCurrentQty.ColumnEdit = this.rpVal;
            this.colCurrentQty.FieldName = "CurrentQty";
            this.colCurrentQty.Name = "colCurrentQty";
            this.colCurrentQty.OptionsColumn.ReadOnly = true;
            this.colCurrentQty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCurrentQty.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colCurrentQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCurrentQty.Visible = true;
            this.colCurrentQty.Width = 103;
            // 
            // rpVal
            // 
            this.rpVal.AutoHeight = false;
            this.rpVal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.Name = "rpVal";
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "gridBand5";
            this.gridBand5.Columns.Add(this.colNewQty);
            this.gridBand5.MinWidth = 20;
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 99;
            // 
            // colNewQty
            // 
            this.colNewQty.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colNewQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNewQty.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colNewQty.AppearanceCell.Options.UseBackColor = true;
            this.colNewQty.AppearanceCell.Options.UseFont = true;
            this.colNewQty.AppearanceCell.Options.UseForeColor = true;
            this.colNewQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colNewQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewQty.Caption = "SL Kiểm Kê";
            this.colNewQty.ColumnEdit = this.rpVal;
            this.colNewQty.FieldName = "NewQty";
            this.colNewQty.Name = "colNewQty";
            this.colNewQty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNewQty.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colNewQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNewQty.Visible = true;
            this.colNewQty.Width = 99;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "gridBand4";
            this.gridBand4.Columns.Add(this.colQtyDiff);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 106;
            // 
            // colQtyDiff
            // 
            this.colQtyDiff.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colQtyDiff.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQtyDiff.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colQtyDiff.AppearanceCell.Options.UseBackColor = true;
            this.colQtyDiff.AppearanceCell.Options.UseFont = true;
            this.colQtyDiff.AppearanceCell.Options.UseForeColor = true;
            this.colQtyDiff.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyDiff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyDiff.Caption = "Chênh Lệch";
            this.colQtyDiff.ColumnEdit = this.rpVal;
            this.colQtyDiff.FieldName = "QtyDiff";
            this.colQtyDiff.Name = "colQtyDiff";
            this.colQtyDiff.OptionsColumn.ReadOnly = true;
            this.colQtyDiff.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQtyDiff.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQtyDiff.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQtyDiff.Visible = true;
            this.colQtyDiff.Width = 106;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.colUnitPrice);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 109;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "Đơn giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.Width = 109;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "gridBand3";
            this.gridBand3.Columns.Add(this.colAmount);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 121;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Thành tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.Width = 121;
            // 
            // rpStock
            // 
            this.rpStock.AutoHeight = false;
            this.rpStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpStock.DataSource = this.sTOCKBindingSource;
            this.rpStock.DisplayMember = "Stock_Name";
            this.rpStock.ImmediatePopup = true;
            this.rpStock.Name = "rpStock";
            this.rpStock.NullText = "";
            this.rpStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpStock.ValueMember = "Stock_ID";
            this.rpStock.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // rpVal01
            // 
            this.rpVal01.AutoHeight = false;
            this.rpVal01.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVal01.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpVal01.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal01.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpVal01.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal01.Name = "rpVal01";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gcList);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 32);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(710, 462);
            this.panelControl4.TabIndex = 6;
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiInit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiImport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProduct, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose, true)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // iNVENTORY_GetList_AdjustmentTableAdapter
            // 
            this.iNVENTORY_GetList_AdjustmentTableAdapter.ClearBeforeFill = true;
            // 
            // aDJUSTMENTTableAdapter1
            // 
            this.aDJUSTMENTTableAdapter1.ClearBeforeFill = true;
            // 
            // XucInventoryAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XucInventoryAdjustment";
            this.Size = new System.Drawing.Size(1082, 494);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJUSTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustmentMana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYGetListAdjustmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.Utils.ImageCollection imageCollection2;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgProduct;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private dsPRODUCT dsPRODUCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiHelp;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiProductDetail;
        private DevExpress.XtraBars.BarSubItem bbiProduct;
        private DevExpress.XtraBars.BarButtonItem bbiHistory;
        private DevExpress.XtraBars.PopupMenu pm;
        private DevExpress.XtraBars.BarButtonItem bbiImport;
        private DevExpress.XtraBars.BarButtonItem bbiInit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Perfect.Common.xucLookEdit cbxStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private dsAdjustment dsAdjustment;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrentQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQtyDiff;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal01;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewQty;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcList01;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList01;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lc01;
        private dsAdjustmentMana dsAdjustmentMana;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate;
        private ADJUSTMENTTableAdapter aDJUSTMENTTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.SimpleButton bttView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton bttLoadAgain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton bttDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource iNVENTORYGetListAdjustmentBindingSource1;
        private dsAdjustment dsAdjustment1;
        private INVENTORY_GetList_AdjustmentTableAdapter iNVENTORY_GetList_AdjustmentTableAdapter;
        private System.Windows.Forms.BindingSource aDJUSTMENTBindingSource;
        private dsAdjustmentMana dsAdjustmentMana1;
        private ADJUSTMENTTableAdapter aDJUSTMENTTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
