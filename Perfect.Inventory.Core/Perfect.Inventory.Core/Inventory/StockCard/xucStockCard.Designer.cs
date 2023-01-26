namespace Perfect.Inventory.Core.Inventory.StockCard
{
    partial class xucStockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucStockCard));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefDateShow = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colInRefNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOutRefNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colReftypeName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBatch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSerial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSorted = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRealQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colInQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOutQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colE_Quantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefDate1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsStock_Card = new Perfect.Inventory.Core.Inventory.StockCard.DS.dsStock_Card();
            this.sTOCKCARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCK_CARDTableAdapter1 = new Perfect.Inventory.Core.Inventory.StockCard.DS.dsStock_CardTableAdapters.STOCK_CARDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStock_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKCARDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Controls.SetChildIndex(this.gcList, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sTOCKCARDBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 57);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(957, 616);
            this.gcList.TabIndex = 42;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand5,
            this.gridBand1,
            this.gridBand2,
            this.gridBand4});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colRefNo,
            this.colRefDate,
            this.colStock_ID,
            this.colProduct_ID,
            this.colBatch,
            this.colSerial,
            this.colUnit,
            this.colPrice,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colSorted,
            this.colRefType,
            this.colRefStatus,
            this.colInQuantity,
            this.colOutQuantity,
            this.colRealQuantity,
            this.colE_Quantity,
            this.colRefDate1,
            this.colDescription,
            this.colInRefNo,
            this.colOutRefNo,
            this.colProduct_Name,
            this.colUnit_Name,
            this.colStock_Name,
            this.colRefDateShow,
            this.colReftypeName});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(763, 272, 223, 236);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "Iif([E_Quantity] < 0, True , False)";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để nhóm dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InQuantity", this.colInQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutQuantity", this.colOutQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RealQuantity", this.colE_Quantity, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 50;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Columns.Add(this.colProduct_ID);
            this.gridBand5.Columns.Add(this.colRefDate);
            this.gridBand5.Columns.Add(this.colProduct_Name);
            this.gridBand5.Columns.Add(this.colRefDateShow);
            this.gridBand5.MinWidth = 20;
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 344;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 99;
            // 
            // colRefDate
            // 
            this.colRefDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.colRefDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.AllowEdit = false;
            this.colRefDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate.Width = 149;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Hàng Hóa";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 147;
            // 
            // colRefDateShow
            // 
            this.colRefDateShow.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDateShow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDateShow.Caption = "Ngày Tháng";
            this.colRefDateShow.FieldName = "RefDateShow";
            this.colRefDateShow.Name = "colRefDateShow";
            this.colRefDateShow.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDateShow.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDateShow.OptionsColumn.ReadOnly = true;
            this.colRefDateShow.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDateShow.Visible = true;
            this.colRefDateShow.Width = 98;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Chứng Từ";
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colInRefNo);
            this.gridBand1.Columns.Add(this.colOutRefNo);
            this.gridBand1.Columns.Add(this.colReftypeName);
            this.gridBand1.Columns.Add(this.colRefType);
            this.gridBand1.Columns.Add(this.colRefNo);
            this.gridBand1.Columns.Add(this.colStock_ID);
            this.gridBand1.Columns.Add(this.colBatch);
            this.gridBand1.Columns.Add(this.colSerial);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Columns.Add(this.colSorted);
            this.gridBand1.Columns.Add(this.colRefStatus);
            this.gridBand1.Columns.Add(this.colRealQuantity);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 220;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colInRefNo
            // 
            this.colInRefNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInRefNo.Caption = "Nhập";
            this.colInRefNo.FieldName = "InRefNo";
            this.colInRefNo.Name = "colInRefNo";
            this.colInRefNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colInRefNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInRefNo.OptionsColumn.ReadOnly = true;
            this.colInRefNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInRefNo.Visible = true;
            this.colInRefNo.Width = 76;
            // 
            // colOutRefNo
            // 
            this.colOutRefNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutRefNo.Caption = "Xuất";
            this.colOutRefNo.FieldName = "OutRefNo";
            this.colOutRefNo.Name = "colOutRefNo";
            this.colOutRefNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOutRefNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOutRefNo.OptionsColumn.ReadOnly = true;
            this.colOutRefNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutRefNo.Visible = true;
            this.colOutRefNo.Width = 69;
            // 
            // colReftypeName
            // 
            this.colReftypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colReftypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReftypeName.Caption = "Loại";
            this.colReftypeName.FieldName = "ReftypeName";
            this.colReftypeName.Name = "colReftypeName";
            this.colReftypeName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colReftypeName.OptionsColumn.ReadOnly = true;
            this.colReftypeName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colReftypeName.Visible = true;
            // 
            // colRefType
            // 
            this.colRefType.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefType.Caption = "Mã Loại";
            this.colRefType.FieldName = "RefType";
            this.colRefType.Name = "colRefType";
            this.colRefType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRefType.OptionsColumn.ReadOnly = true;
            this.colRefType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefType.Width = 82;
            // 
            // colRefNo
            // 
            this.colRefNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefNo.Caption = "Chứng Từ";
            this.colRefNo.FieldName = "RefNo";
            this.colRefNo.Name = "colRefNo";
            this.colRefNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRefNo.OptionsColumn.ReadOnly = true;
            this.colRefNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefNo.Width = 170;
            // 
            // colStock_ID
            // 
            this.colStock_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_ID.OptionsColumn.ReadOnly = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID.Width = 93;
            // 
            // colBatch
            // 
            this.colBatch.AppearanceHeader.Options.UseTextOptions = true;
            this.colBatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBatch.FieldName = "Batch";
            this.colBatch.Name = "colBatch";
            this.colBatch.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBatch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBatch.OptionsColumn.ReadOnly = true;
            this.colBatch.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBatch.Width = 54;
            // 
            // colSerial
            // 
            this.colSerial.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerial.FieldName = "Serial";
            this.colSerial.Name = "colSerial";
            this.colSerial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSerial.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSerial.OptionsColumn.ReadOnly = true;
            this.colSerial.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSerial.Width = 66;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Width = 65;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.Width = 78;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Width = 56;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.Width = 67;
            // 
            // colSorted
            // 
            this.colSorted.AppearanceHeader.Options.UseTextOptions = true;
            this.colSorted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSorted.FieldName = "Sorted";
            this.colSorted.Name = "colSorted";
            this.colSorted.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSorted.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSorted.OptionsColumn.ReadOnly = true;
            this.colSorted.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSorted.Width = 83;
            // 
            // colRefStatus
            // 
            this.colRefStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefStatus.FieldName = "RefStatus";
            this.colRefStatus.Name = "colRefStatus";
            this.colRefStatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRefStatus.OptionsColumn.ReadOnly = true;
            this.colRefStatus.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefStatus.Width = 85;
            // 
            // colRealQuantity
            // 
            this.colRealQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealQuantity.FieldName = "RealQuantity";
            this.colRealQuantity.Name = "colRealQuantity";
            this.colRealQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRealQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRealQuantity.OptionsColumn.ReadOnly = true;
            this.colRealQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRealQuantity.Width = 43;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Columns.Add(this.colDescription);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 209;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Diễn Giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.Width = 209;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Số Lượng";
            this.gridBand4.Columns.Add(this.colInQuantity);
            this.gridBand4.Columns.Add(this.colOutQuantity);
            this.gridBand4.Columns.Add(this.colE_Quantity);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 249;
            // 
            // colInQuantity
            // 
            this.colInQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colInQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInQuantity.Caption = "Nhập";
            this.colInQuantity.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colInQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInQuantity.FieldName = "InQuantity";
            this.colInQuantity.Name = "colInQuantity";
            this.colInQuantity.OptionsColumn.AllowEdit = false;
            this.colInQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colInQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInQuantity.OptionsColumn.ReadOnly = true;
            this.colInQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colInQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInQuantity.Visible = true;
            this.colInQuantity.Width = 81;
            // 
            // colOutQuantity
            // 
            this.colOutQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutQuantity.Caption = "Xuất";
            this.colOutQuantity.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colOutQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOutQuantity.FieldName = "OutQuantity";
            this.colOutQuantity.Name = "colOutQuantity";
            this.colOutQuantity.OptionsColumn.AllowEdit = false;
            this.colOutQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOutQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOutQuantity.OptionsColumn.ReadOnly = true;
            this.colOutQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOutQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutQuantity.Visible = true;
            // 
            // colE_Quantity
            // 
            this.colE_Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colE_Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colE_Quantity.Caption = "Tồn";
            this.colE_Quantity.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colE_Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colE_Quantity.FieldName = "E_Quantity";
            this.colE_Quantity.Name = "colE_Quantity";
            this.colE_Quantity.OptionsColumn.AllowEdit = false;
            this.colE_Quantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colE_Quantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colE_Quantity.OptionsColumn.ReadOnly = true;
            this.colE_Quantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colE_Quantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colE_Quantity.SummaryItem.FieldName = "RealQuantity";
            this.colE_Quantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colE_Quantity.Visible = true;
            this.colE_Quantity.Width = 93;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsColumn.ReadOnly = true;
            this.colPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPrice.Width = 138;
            // 
            // colRefDate1
            // 
            this.colRefDate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate1.Caption = "Ngày Nhập Xuất";
            this.colRefDate1.FieldName = "RefDateShow";
            this.colRefDate1.Name = "colRefDate1";
            this.colRefDate1.OptionsColumn.AllowEdit = false;
            this.colRefDate1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDate1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDate1.OptionsColumn.ReadOnly = true;
            this.colRefDate1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate1.Width = 103;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 620);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // dsStock_Card
            // 
            this.dsStock_Card.DataSetName = "dsStock_Card";
            this.dsStock_Card.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKCARDBindingSource
            // 
            this.sTOCKCARDBindingSource.DataMember = "STOCK_CARD";
            this.sTOCKCARDBindingSource.DataSource = this.dsStock_Card;
            // 
            // sTOCK_CARDTableAdapter1
            // 
            this.sTOCK_CARDTableAdapter1.ClearBeforeFill = true;
            // 
            // xucStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucStockCard";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStock_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKCARDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBatch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSerial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSorted;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefType;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRealQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colE_Quantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefDate1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInRefNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutRefNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefDateShow;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colReftypeName;
        private System.Windows.Forms.BindingSource sTOCKCARDBindingSource;
        private Perfect.Inventory.Core.Inventory.StockCard.DS.dsStock_Card dsStock_Card;
        private Perfect.Inventory.Core.Inventory.StockCard.DS.dsStock_CardTableAdapters.STOCK_CARDTableAdapter sTOCK_CARDTableAdapter1;
    }
}
