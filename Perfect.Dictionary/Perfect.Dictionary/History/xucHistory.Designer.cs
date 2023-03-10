namespace Perfect.Dictionary.History
{
    partial class XucHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucHistory));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.btView = new DevExpress.XtraEditors.SimpleButton();
            this.txtProductID = new Perfect.Common.xucTextEdit();
            this.txtProductName = new Perfect.Common.xucTextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.productHistoryDynamicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHistory = new Perfect.Dictionary.History.dsHistory();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRefDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colRefNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rEFTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Dictionary.Stock.DS.dsSTOCK();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rgCal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustomer_ID1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEmployee_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colAVGPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAVGAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colE_Quantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colE_Amount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.pRODUCTHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pRODUCT_HistoryTableAdapter = new Perfect.Dictionary.History.dsHistoryTableAdapters.PRODUCT_HistoryTableAdapter();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProductDetail = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProduct = new DevExpress.XtraBars.BarSubItem();
            this.bbiInventory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHistory = new DevExpress.XtraBars.BarButtonItem();
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            this.sTOCKTableAdapter = new Perfect.Dictionary.Stock.DS.dsSTOCKTableAdapters.STOCKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHistoryDynamicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btClose);
            this.panelControl1.Controls.Add(this.btView);
            this.panelControl1.Controls.Add(this.txtProductID);
            this.panelControl1.Controls.Add(this.txtProductName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(944, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // btClose
            // 
            this.btClose.ImageIndex = 22;
            this.btClose.ImageList = this.imageCollection2;
            this.btClose.Location = new System.Drawing.Point(441, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 25);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Thoát";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btView
            // 
            this.btView.ImageIndex = 44;
            this.btView.ImageList = this.imageCollection2;
            this.btView.Location = new System.Drawing.Point(362, 3);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 25);
            this.btView.TabIndex = 2;
            this.btView.Text = "Tìm";
            this.btView.Click += new System.EventHandler(this.BtViewClick);
            // 
            // txtProductID
            // 
            this.txtProductID.DefaultText = "Mã Hàng";
            this.txtProductID.EditValue = "Mã Hàng";
            this.txtProductID.Location = new System.Drawing.Point(5, 6);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProductID.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductID.Properties.NullText = "Mã Hàng";
            this.txtProductID.Properties.NullValuePrompt = "Mã Hàng";
            this.txtProductID.Size = new System.Drawing.Size(110, 20);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductID_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.DefaultText = "Hàng Hoá";
            this.txtProductName.EditValue = "Hàng Hoá";
            this.txtProductName.Location = new System.Drawing.Point(120, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProductName.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductName.Properties.NullText = "Hàng Hoá";
            this.txtProductName.Properties.NullValuePrompt = "Hàng Hoá";
            this.txtProductName.Size = new System.Drawing.Size(236, 20);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 32);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(944, 509);
            this.panelControl2.TabIndex = 1;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.productHistoryDynamicBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rgCal,
            this.rpDate,
            this.rpType,
            this.rpStock});
            this.gcList.Size = new System.Drawing.Size(940, 505);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            this.gcList.Click += new System.EventHandler(this.gcList_Click);
            // 
            // productHistoryDynamicBindingSource
            // 
            this.productHistoryDynamicBindingSource.DataMember = "Product_History_Dynamic";
            this.productHistoryDynamicBindingSource.DataSource = this.dsHistory;
            // 
            // dsHistory
            // 
            this.dsHistory.DataSetName = "dsHistory";
            this.dsHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colRefDate,
            this.colRefNo,
            this.colRefType,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit_Name,
            this.colQuantity,
            this.colAVGPrice,
            this.colAVGAmount,
            this.colDescription,
            this.colStock_ID,
            this.colCustomer_ID1,
            this.colEmployee_ID,
            this.colPrice,
            this.colE_Amount,
            this.colE_Quantity,
            this.colStock_Name,
            this.colAmount});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(978, 245, 215, 228);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "Iif([E_Quantity] < 0, True  , False)";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.gbList_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colRefDate);
            this.gridBand1.Columns.Add(this.colRefNo);
            this.gridBand1.Columns.Add(this.colRefType);
            this.gridBand1.Columns.Add(this.colStock_Name);
            this.gridBand1.Columns.Add(this.colStock_ID);
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colUnit_Name);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Columns.Add(this.colCustomer_ID1);
            this.gridBand1.Columns.Add(this.colEmployee_ID);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 1229;
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
            this.colRefDate.Width = 91;
            // 
            // rpDate
            // 
            this.rpDate.AutoHeight = false;
            this.rpDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.rpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpDate.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            this.rpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpDate.Mask.EditMask = "dd/MM/yyyy";
            this.rpDate.Name = "rpDate";
            this.rpDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colRefNo
            // 
            this.colRefNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefNo.Caption = "Chứng Từ";
            this.colRefNo.FieldName = "RefNo";
            this.colRefNo.Name = "colRefNo";
            this.colRefNo.OptionsColumn.ReadOnly = true;
            this.colRefNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefNo.Visible = true;
            this.colRefNo.Width = 91;
            // 
            // colRefType
            // 
            this.colRefType.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefType.Caption = "Loại";
            this.colRefType.ColumnEdit = this.rpType;
            this.colRefType.FieldName = "RefType";
            this.colRefType.Name = "colRefType";
            this.colRefType.OptionsColumn.ReadOnly = true;
            this.colRefType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefType.Visible = true;
            this.colRefType.Width = 122;
            // 
            // rpType
            // 
            this.rpType.AutoHeight = false;
            this.rpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpType.DataSource = this.rEFTYPEBindingSource;
            this.rpType.DisplayMember = "Name";
            this.rpType.Name = "rpType";
            this.rpType.NullText = "";
            this.rpType.ValueMember = "ID";
            this.rpType.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // rEFTYPEBindingSource
            // 
            this.rEFTYPEBindingSource.DataMember = "REFTYPE";
            this.rEFTYPEBindingSource.DataSource = this.dsHistory;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.Visible = true;
            this.colStock_Name.Width = 176;
            // 
            // colStock_ID
            // 
            this.colStock_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID.Caption = "Mã Kho";
            this.colStock_ID.ColumnEdit = this.rpStock;
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.ReadOnly = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID.Width = 171;
            // 
            // rpStock
            // 
            this.rpStock.AutoHeight = false;
            this.rpStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.rpStock.DataSource = this.sTOCKBindingSource;
            this.rpStock.DisplayMember = "Stock_Name";
            this.rpStock.Name = "rpStock";
            this.rpStock.NullText = "";
            this.rpStock.ValueMember = "Stock_ID";
            this.rpStock.View = this.gridView1;
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
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 132;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 217;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.Width = 83;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rgCal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 94;
            // 
            // rgCal
            // 
            this.rgCal.AutoHeight = false;
            this.rgCal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rgCal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rgCal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rgCal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rgCal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rgCal.Name = "rgCal";
            // 
            // colPrice
            // 
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.Caption = "Đơn Giá";
            this.colPrice.ColumnEdit = this.rgCal;
            this.colPrice.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.ReadOnly = true;
            this.colPrice.Visible = true;
            this.colPrice.Width = 106;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rgCal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.Width = 117;
            // 
            // colCustomer_ID1
            // 
            this.colCustomer_ID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_ID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_ID1.Caption = "Khách Hàng";
            this.colCustomer_ID1.FieldName = "Customer_ID";
            this.colCustomer_ID1.Name = "colCustomer_ID1";
            this.colCustomer_ID1.OptionsColumn.ReadOnly = true;
            this.colCustomer_ID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID1.Width = 221;
            // 
            // colEmployee_ID
            // 
            this.colEmployee_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_ID.Caption = "Nhân Viên";
            this.colEmployee_ID.FieldName = "Employee_ID";
            this.colEmployee_ID.Name = "colEmployee_ID";
            this.colEmployee_ID.OptionsColumn.ReadOnly = true;
            this.colEmployee_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_ID.Width = 176;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Bình Quân";
            this.gridBand2.Columns.Add(this.colAVGPrice);
            this.gridBand2.Columns.Add(this.colAVGAmount);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 214;
            // 
            // colAVGPrice
            // 
            this.colAVGPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colAVGPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAVGPrice.Caption = "Đơn Giá";
            this.colAVGPrice.ColumnEdit = this.rgCal;
            this.colAVGPrice.FieldName = "AVG_Price";
            this.colAVGPrice.Name = "colAVGPrice";
            this.colAVGPrice.OptionsColumn.ReadOnly = true;
            this.colAVGPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAVGPrice.Visible = true;
            this.colAVGPrice.Width = 89;
            // 
            // colAVGAmount
            // 
            this.colAVGAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAVGAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAVGAmount.Caption = "Thành Tiền";
            this.colAVGAmount.ColumnEdit = this.rgCal;
            this.colAVGAmount.FieldName = "AVG_Amount";
            this.colAVGAmount.Name = "colAVGAmount";
            this.colAVGAmount.OptionsColumn.ReadOnly = true;
            this.colAVGAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAVGAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAVGAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAVGAmount.Visible = true;
            this.colAVGAmount.Width = 125;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Tồn Cuối";
            this.gridBand3.Columns.Add(this.colE_Quantity);
            this.gridBand3.Columns.Add(this.colE_Amount);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 240;
            // 
            // colE_Quantity
            // 
            this.colE_Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colE_Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colE_Quantity.Caption = "Số Lượng";
            this.colE_Quantity.ColumnEdit = this.rgCal;
            this.colE_Quantity.FieldName = "E_Quantity";
            this.colE_Quantity.Name = "colE_Quantity";
            this.colE_Quantity.OptionsColumn.ReadOnly = true;
            this.colE_Quantity.Visible = true;
            this.colE_Quantity.Width = 111;
            // 
            // colE_Amount
            // 
            this.colE_Amount.AppearanceHeader.Options.UseTextOptions = true;
            this.colE_Amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colE_Amount.Caption = "Thành Tiền";
            this.colE_Amount.ColumnEdit = this.rgCal;
            this.colE_Amount.FieldName = "E_Amount";
            this.colE_Amount.Name = "colE_Amount";
            this.colE_Amount.OptionsColumn.ReadOnly = true;
            this.colE_Amount.Visible = true;
            this.colE_Amount.Width = 129;
            // 
            // gridBand4
            // 
            this.gridBand4.Columns.Add(this.colDescription);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 162;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Ghi Chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.Width = 162;
            // 
            // pRODUCTHistoryBindingSource
            // 
            this.pRODUCTHistoryBindingSource.DataMember = "PRODUCT_History";
            this.pRODUCTHistoryBindingSource.DataSource = this.dsHistory;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.Caption = "Mã khách hàng";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 0;
            this.colCustomer_ID.Width = 70;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Tên khách hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 200;
            // 
            // pRODUCT_HistoryTableAdapter
            // 
            this.pRODUCT_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // bm
            // 
            this.bm.AutoSaveInRegistry = true;
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
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
            this.bbiInventory});
            this.bm.LargeImages = this.imageCollection2;
            this.bm.MaxItemId = 23;
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
            this.bbiRefresh.Caption = "Tìm";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageIndex = 44;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Xuất";
            this.bbiExport.Id = 5;
            this.bbiExport.ImageIndex = 51;
            this.bbiExport.LargeImageIndex = 19;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bbiHelp
            // 
            this.bbiHelp.Caption = "Trợ Giúp";
            this.bbiHelp.Id = 6;
            this.bbiHelp.ImageIndex = 25;
            this.bbiHelp.Name = "bbiHelp";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Đóng";
            this.bbiClose.Id = 10;
            this.bbiClose.ImageIndex = 22;
            this.bbiClose.LargeImageIndex = 1;
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiProductDetail
            // 
            this.bbiProductDetail.Caption = "Chi Tiết";
            this.bbiProductDetail.Id = 13;
            this.bbiProductDetail.ImageIndex = 59;
            this.bbiProductDetail.Name = "bbiProductDetail";
            this.bbiProductDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiProductDetailItemClick);
            // 
            // bbiProduct
            // 
            this.bbiProduct.Caption = "Hàng Hoá";
            this.bbiProduct.Id = 14;
            this.bbiProduct.ImageIndex = 24;
            this.bbiProduct.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiInventory),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductDetail)});
            this.bbiProduct.Name = "bbiProduct";
            // 
            // bbiInventory
            // 
            this.bbiInventory.Caption = "Tồn Kho";
            this.bbiInventory.Id = 22;
            this.bbiInventory.Name = "bbiInventory";
            this.bbiInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInventory_ItemClick);
            // 
            // bbiHistory
            // 
            this.bbiHistory.Caption = "Lịch Sử";
            this.bbiHistory.Id = 15;
            this.bbiHistory.ImageIndex = 61;
            this.bbiHistory.Name = "bbiHistory";
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProduct, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose, true)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // XucHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XucHistory";
            this.Size = new System.Drawing.Size(944, 541);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHistoryDynamicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btView;
        private Perfect.Common.xucTextEdit txtProductName;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private Perfect.Common.xucTextEdit txtProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private System.Windows.Forms.BindingSource pRODUCTHistoryBindingSource;
        private Perfect.Dictionary.History.dsHistory dsHistory;
        private Perfect.Dictionary.History.dsHistoryTableAdapters.PRODUCT_HistoryTableAdapter pRODUCT_HistoryTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rgCal;
        protected DevExpress.Utils.ImageCollection imageCollection2;
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
        private DevExpress.XtraBars.BarButtonItem bbiInventory;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private System.Windows.Forms.BindingSource rEFTYPEBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefType;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAVGPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAVGAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomer_ID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEmployee_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private Perfect.Dictionary.Stock.DS.dsSTOCK dsSTOCK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Perfect.Dictionary.Stock.DS.dsSTOCKTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colE_Amount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colE_Quantity;
        private System.Windows.Forms.BindingSource productHistoryDynamicBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}
