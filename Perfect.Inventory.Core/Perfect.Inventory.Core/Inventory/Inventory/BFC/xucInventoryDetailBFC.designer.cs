using Perfect.Inventory.Core.Common.DS;

namespace Perfect.Inventory
{
    partial class xucInventoryDetailBFC
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucInventoryDetailBFC));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory = new Perfect.Inventory.Core.Inventory.Inventory.Details.DS.dsInventory();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Date = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLimit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBatch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Group_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCurrency_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colExchangeRate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plTop = new DevExpress.XtraEditors.PanelControl();
            this.btReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintDetail = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.chxZero = new DevExpress.XtraEditors.CheckEdit();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsStock = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.plBottom = new DevExpress.XtraEditors.PanelControl();
            this.uhm = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.txtTotal = new DevExpress.XtraEditors.CalcEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.iNVENTORYTableAdapter = new Perfect.Inventory.Core.Inventory.Inventory.Details.DS.dsInventoryTableAdapters.INVENTORY_GetFullTableAdapter();
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
            this.bbiHistory = new DevExpress.XtraBars.BarButtonItem();
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxZero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            this.SuspendLayout();
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 55;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.iNVENTORYBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpUnit});
            this.gcList.Size = new System.Drawing.Size(1055, 450);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList,
            this.gridView2});
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY_GetFull";
            this.iNVENTORYBindingSource.DataSource = this.dsInventory;
            // 
            // dsInventory
            // 
            this.dsInventory.DataSetName = "dsInventory";
            this.dsInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colStock_ID,
            this.colStock_Name,
            this.colProduct_Group_ID,
            this.colProductGroup_Name,
            this.colStock_Date,
            this.colLimit,
            this.colProduct_ID,
            this.colProductName,
            this.colUnit,
            this.colCurrency_ID,
            this.colQuantity,
            this.colExchangeRate,
            this.colUnitPrice,
            this.colAmount,
            this.colBatch});
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQuantity;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = "0";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colQuantity;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition2.Value1 = "-1";
            styleFormatCondition2.Value2 = "10";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", null, "=  Số lượng: {0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", null, "Thành tiền: {0:##,##0.###}")});
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ColumnAutoWidth = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.PaintStyleName = "Skin";
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductGroup_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.ViewCaption = "Danh sách Nhân viên";
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gbList_CustomSummaryCalculate);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "TỒN KHO";
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProductName);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colStock_Date);
            this.gridBand1.Columns.Add(this.colLimit);
            this.gridBand1.Columns.Add(this.colBatch);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.ToolTip = "TỒN KHO";
            this.gridBand1.Width = 484;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Product_ID";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.SummaryItem.DisplayFormat = "Dòng: {0:##,##0}";
            this.colProduct_ID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 56;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ProductName";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.Width = 55;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Unit";
            this.colUnit.ColumnEdit = this.rpUnit;
            this.colUnit.FieldName = "Unit";
            this.colUnit.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.Width = 55;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoComplete = false;
            this.rpUnit.AutoHeight = false;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DataSource = this.uNITBindingSource;
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "(Chọn)";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.repositoryItemGridLookUpEdit1View;
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
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colStock_Date
            // 
            this.colStock_Date.Caption = "Stock_Date";
            this.colStock_Date.FieldName = "Stock_Date";
            this.colStock_Date.Name = "colStock_Date";
            this.colStock_Date.Visible = true;
            this.colStock_Date.Width = 55;
            // 
            // colLimit
            // 
            this.colLimit.Caption = "Limit";
            this.colLimit.FieldName = "Limit";
            this.colLimit.Name = "colLimit";
            this.colLimit.Visible = true;
            this.colLimit.Width = 55;
            // 
            // colBatch
            // 
            this.colBatch.Caption = "Batch";
            this.colBatch.FieldName = "Batch";
            this.colBatch.Name = "colBatch";
            this.colBatch.Visible = true;
            this.colBatch.Width = 43;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "UnitPrice";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colUnitPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.Width = 55;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.Width = 55;
            // 
            // colStock_ID
            // 
            this.colStock_ID.Caption = "Stock_ID";
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.Visible = true;
            this.colStock_ID.Width = 55;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Stock_Name";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.Width = 103;
            // 
            // colProduct_Group_ID
            // 
            this.colProduct_Group_ID.Caption = "Product_Group_ID";
            this.colProduct_Group_ID.FieldName = "Product_Group_ID";
            this.colProduct_Group_ID.Name = "colProduct_Group_ID";
            this.colProduct_Group_ID.Width = 55;
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.Caption = "ProductGroup_Name";
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.Width = 129;
            // 
            // colCurrency_ID
            // 
            this.colCurrency_ID.Caption = "Currency_ID";
            this.colCurrency_ID.FieldName = "Currency_ID";
            this.colCurrency_ID.Name = "colCurrency_ID";
            this.colCurrency_ID.Visible = true;
            this.colCurrency_ID.Width = 55;
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.Caption = "ExchangeRate";
            this.colExchangeRate.FieldName = "ExchangeRate";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.Visible = true;
            this.colExchangeRate.Width = 55;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcList;
            this.gridView2.Name = "gridView2";
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.btReport);
            this.plTop.Controls.Add(this.btnPrintDetail);
            this.plTop.Controls.Add(this.chxZero);
            this.plTop.Controls.Add(this.cbxStock);
            this.plTop.Controls.Add(this.lblStock);
            this.plTop.Controls.Add(this.txtProductName);
            this.plTop.Controls.Add(this.txtProductID);
            this.plTop.Controls.Add(this.btnExport);
            this.plTop.Controls.Add(this.btnView);
            this.plTop.Controls.Add(this.btnPrint);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1059, 34);
            this.plTop.TabIndex = 16;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(803, 3);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(75, 28);
            this.btReport.TabIndex = 23;
            this.btReport.Text = "Báo Cáo";
            // 
            // btnPrintDetail
            // 
            this.btnPrintDetail.ImageIndex = 9;
            this.btnPrintDetail.ImageList = this.imageCollection2;
            this.btnPrintDetail.Location = new System.Drawing.Point(724, 4);
            this.btnPrintDetail.Name = "btnPrintDetail";
            this.btnPrintDetail.Size = new System.Drawing.Size(78, 27);
            superToolTip1.FixedTooltipWidth = true;
            toolTipTitleItem1.Text = "Thông tin";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "In bảng kê hóa đơn đầu vào";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.MaxWidth = 210;
            this.btnPrintDetail.SuperTip = superToolTip1;
            this.btnPrintDetail.TabIndex = 22;
            this.btnPrintDetail.Text = "Đặt Hàng";
            this.btnPrintDetail.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnPrintDetail.Click += new System.EventHandler(this.btnPrintDetail_Click);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // chxZero
            // 
            this.chxZero.Location = new System.Drawing.Point(923, 9);
            this.chxZero.Name = "chxZero";
            this.chxZero.Properties.Caption = "Hiện số lượng =0";
            this.chxZero.Size = new System.Drawing.Size(112, 19);
            this.chxZero.TabIndex = 21;
            // 
            // cbxStock
            // 
            this.cbxStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStock.DataSource = this.sTOCKBindingSource;
            this.cbxStock.DisplayMember = "Stock_Name";
            this.cbxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.Location = new System.Drawing.Point(29, 6);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(147, 21);
            this.cbxStock.TabIndex = 19;
            this.cbxStock.ValueMember = "Stock_ID";
            this.cbxStock.SelectionChangeCommitted += new System.EventHandler(this.cbxStock_SelectionChangeCommitted);
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsStock;
            // 
            // dsStock
            // 
            this.dsStock.DataSetName = "dsStock";
            this.dsStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(6, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(18, 13);
            this.lblStock.TabIndex = 20;
            this.lblStock.Text = "Kho";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(265, 7);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 20);
            this.txtProductName.TabIndex = 18;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(178, 7);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(83, 20);
            this.txtProductID.TabIndex = 17;
            this.txtProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.ImageIndex = 51;
            this.btnExport.ImageList = this.imageCollection2;
            this.btnExport.Location = new System.Drawing.Point(581, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(70, 27);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnView
            // 
            this.btnView.ImageIndex = 36;
            this.btnView.ImageList = this.imageCollection2;
            this.btnView.Location = new System.Drawing.Point(508, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 27);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageIndex = 9;
            this.btnPrint.ImageList = this.imageCollection2;
            this.btnPrint.Location = new System.Drawing.Point(653, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 27);
            superToolTip2.FixedTooltipWidth = true;
            toolTipTitleItem2.Text = "Thông tin";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "In bảng kê hóa đơn đầu vào";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            superToolTip2.MaxWidth = 210;
            this.btnPrint.SuperTip = superToolTip2;
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "In";
            this.btnPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // plBottom
            // 
            this.plBottom.Controls.Add(this.uhm);
            this.plBottom.Controls.Add(this.txtQuantity);
            this.plBottom.Controls.Add(this.txtTotal);
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(0, 488);
            this.plBottom.Name = "plBottom";
            this.plBottom.Size = new System.Drawing.Size(1059, 33);
            this.plBottom.TabIndex = 17;
            this.plBottom.Visible = false;
            // 
            // uhm
            // 
            this.uhm.Location = new System.Drawing.Point(8, 10);
            this.uhm.Name = "uhm";
            this.uhm.Size = new System.Drawing.Size(50, 13);
            this.uhm.TabIndex = 10;
            this.uhm.Text = "Tổng cộng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(64, 7);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtQuantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.NullText = "0";
            this.txtQuantity.Properties.ReadOnly = true;
            this.txtQuantity.Properties.ShowCloseButton = true;
            this.txtQuantity.Size = new System.Drawing.Size(112, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(182, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotal.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotal.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotal.Properties.NullText = "0";
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Properties.ShowCloseButton = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1059, 454);
            this.panelControl1.TabIndex = 18;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
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
            this.bbiHistory});
            this.bm.MaxItemId = 16;
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "In";
            this.bbiPrint.Id = 3;
            this.bbiPrint.ImageIndex = 9;
            this.bbiPrint.Name = "bbiPrint";
            this.bbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiRefresh.Appearance.Options.UseFont = true;
            this.bbiRefresh.Caption = "Xem";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageIndex = 42;
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
            this.bbiProductDetail.Name = "bbiProductDetail";
            this.bbiProductDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProductDetail_ItemClick);
            // 
            // bbiProduct
            // 
            this.bbiProduct.Caption = "Hàng Hoá";
            this.bbiProduct.Id = 14;
            this.bbiProduct.ImageIndex = 24;
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
            this.bbiHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHistory_ItemClick);
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProduct, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose, true)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // xucInventoryDetailBFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.plBottom);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xucInventoryDetailBFC";
            this.Size = new System.Drawing.Size(1059, 521);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxZero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.plBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        protected DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl plTop;
        protected DevExpress.XtraEditors.SimpleButton btnExport;
        protected DevExpress.XtraEditors.SimpleButton btnView;
        protected DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.PanelControl plBottom;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        protected DevExpress.XtraEditors.CalcEdit txtQuantity;
        protected DevExpress.XtraEditors.CalcEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl uhm;
        private System.Windows.Forms.ComboBox cbxStock;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.CheckEdit chxZero;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsStock;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private Perfect.Inventory.Core.Inventory.Inventory.Details.DS.dsInventory dsInventory;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Group_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductGroup_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Date;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLimit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrency_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colExchangeRate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBatch;
        private Perfect.Inventory.Core.Inventory.Inventory.Details.DS.dsInventoryTableAdapters.INVENTORY_GetFullTableAdapter iNVENTORYTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
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
        private DevExpress.XtraBars.PopupMenu pm;
        private DevExpress.XtraBars.BarButtonItem bbiProductDetail;
        private DevExpress.XtraBars.BarSubItem bbiProduct;
        private DevExpress.XtraBars.BarButtonItem bbiHistory;
        protected DevExpress.XtraEditors.SimpleButton btnPrintDetail;
        private DevExpress.XtraEditors.SimpleButton btReport;
    }
}
