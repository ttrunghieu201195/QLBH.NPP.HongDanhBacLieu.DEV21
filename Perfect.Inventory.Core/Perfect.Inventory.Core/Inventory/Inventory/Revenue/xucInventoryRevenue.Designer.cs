namespace Perfect.Inventory.Core.Inventory.Inventory
{
    partial class xucInventoryRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucInventoryRevenue));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYSummaryRevenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventoryRevenue = new Perfect.Inventory.Core.Inventory.Inventory.Revenue.dsInventoryRevenue();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.BandInfo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFromDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colToDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colE_Qty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colInQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOutQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOpenAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colInAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOutAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSaleAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProfit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colE_Amt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOpenQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.iNVENTORY_Summary_RevenueTableAdapter = new Perfect.Inventory.Core.Inventory.Inventory.Revenue.dsInventoryRevenueTableAdapters.INVENTORY_Summary_RevenueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYSummaryRevenueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Size = new System.Drawing.Size(971, 55);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
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
            // gcList
            // 
            this.gcList.DataSource = this.iNVENTORYSummaryRevenueBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpUnit,
            this.rpVal,
            this.rpDate});
            this.gcList.Size = new System.Drawing.Size(967, 411);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // iNVENTORYSummaryRevenueBindingSource
            // 
            this.iNVENTORYSummaryRevenueBindingSource.DataMember = "INVENTORY_Summary_Revenue";
            this.iNVENTORYSummaryRevenueBindingSource.DataSource = this.dsInventoryRevenue;
            // 
            // dsInventoryRevenue
            // 
            this.dsInventoryRevenue.DataSetName = "dsInventoryRevenue";
            this.dsInventoryRevenue.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.BandInfo});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colFromDate,
            this.colToDate,
            this.colOpenQuantity,
            this.colOpenAmount,
            this.colInQuantity,
            this.colOutQuantity,
            this.colInAmount,
            this.colOutAmount,
            this.colSaleAmount,
            this.colProfit,
            this.colE_Qty,
            this.colUnitPrice,
            this.colE_Amt});
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition1.Value1 = "-1";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Orchid;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition2.Value1 = "0.0";
            styleFormatCondition2.Value2 = "10";
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition3.Value1 = "10";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", null, "=  Số lượng: {0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", null, "Thành tiền: {0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsNavigation.AutoFocusNewRow = true;
            this.gbList.OptionsNavigation.AutoMoveRowFocus = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsPrint.AutoWidth = false;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.ViewCaption = "Danh sách Nhân viên";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gbList_RowCellClick);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gbList_CustomSummaryCalculate);
            // 
            // BandInfo
            // 
            this.BandInfo.AppearanceHeader.Options.UseTextOptions = true;
            this.BandInfo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BandInfo.Caption = "HIỆU QUẢ KINH DOANH";
            this.BandInfo.Columns.Add(this.colFromDate);
            this.BandInfo.Columns.Add(this.colToDate);
            this.BandInfo.Columns.Add(this.colE_Qty);
            this.BandInfo.Columns.Add(this.colInQuantity);
            this.BandInfo.Columns.Add(this.colOutQuantity);
            this.BandInfo.Columns.Add(this.colOpenAmount);
            this.BandInfo.Columns.Add(this.colInAmount);
            this.BandInfo.Columns.Add(this.colOutAmount);
            this.BandInfo.Columns.Add(this.colSaleAmount);
            this.BandInfo.Columns.Add(this.colProfit);
            this.BandInfo.Columns.Add(this.colE_Amt);
            this.BandInfo.MinWidth = 20;
            this.BandInfo.Name = "BandInfo";
            this.BandInfo.Width = 896;
            // 
            // colFromDate
            // 
            this.colFromDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colFromDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFromDate.Caption = "Từ Ngày";
            this.colFromDate.ColumnEdit = this.rpDate;
            this.colFromDate.FieldName = "FromDate";
            this.colFromDate.Name = "colFromDate";
            this.colFromDate.OptionsColumn.FixedWidth = true;
            this.colFromDate.OptionsColumn.ReadOnly = true;
            this.colFromDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFromDate.Visible = true;
            this.colFromDate.Width = 100;
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
            // colToDate
            // 
            this.colToDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colToDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colToDate.Caption = "Đến Ngày";
            this.colToDate.ColumnEdit = this.rpDate;
            this.colToDate.FieldName = "ToDate";
            this.colToDate.Name = "colToDate";
            this.colToDate.OptionsColumn.FixedWidth = true;
            this.colToDate.OptionsColumn.ReadOnly = true;
            this.colToDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colToDate.Visible = true;
            this.colToDate.Width = 101;
            // 
            // colE_Qty
            // 
            this.colE_Qty.AppearanceHeader.Options.UseTextOptions = true;
            this.colE_Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colE_Qty.ColumnEdit = this.rpVal;
            this.colE_Qty.FieldName = "E_Qty";
            this.colE_Qty.Name = "colE_Qty";
            this.colE_Qty.OptionsColumn.FixedWidth = true;
            this.colE_Qty.OptionsColumn.ReadOnly = true;
            this.colE_Qty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colE_Qty.Width = 90;
            // 
            // colInQuantity
            // 
            this.colInQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colInQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInQuantity.ColumnEdit = this.rpVal;
            this.colInQuantity.FieldName = "InQuantity";
            this.colInQuantity.Name = "colInQuantity";
            this.colInQuantity.OptionsColumn.FixedWidth = true;
            this.colInQuantity.OptionsColumn.ReadOnly = true;
            this.colInQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInQuantity.Width = 90;
            // 
            // colOutQuantity
            // 
            this.colOutQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutQuantity.ColumnEdit = this.rpVal;
            this.colOutQuantity.FieldName = "OutQuantity";
            this.colOutQuantity.Name = "colOutQuantity";
            this.colOutQuantity.OptionsColumn.FixedWidth = true;
            this.colOutQuantity.OptionsColumn.ReadOnly = true;
            this.colOutQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutQuantity.Width = 90;
            // 
            // colOpenAmount
            // 
            this.colOpenAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colOpenAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOpenAmount.Caption = "Đầu Kỳ";
            this.colOpenAmount.ColumnEdit = this.rpVal;
            this.colOpenAmount.FieldName = "OpenAmount";
            this.colOpenAmount.Name = "colOpenAmount";
            this.colOpenAmount.OptionsColumn.FixedWidth = true;
            this.colOpenAmount.OptionsColumn.ReadOnly = true;
            this.colOpenAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOpenAmount.Visible = true;
            this.colOpenAmount.Width = 123;
            // 
            // colInAmount
            // 
            this.colInAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colInAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInAmount.Caption = "Nhập";
            this.colInAmount.ColumnEdit = this.rpVal;
            this.colInAmount.FieldName = "InAmount";
            this.colInAmount.Name = "colInAmount";
            this.colInAmount.OptionsColumn.FixedWidth = true;
            this.colInAmount.OptionsColumn.ReadOnly = true;
            this.colInAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInAmount.Visible = true;
            this.colInAmount.Width = 105;
            // 
            // colOutAmount
            // 
            this.colOutAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutAmount.Caption = "Xuất";
            this.colOutAmount.ColumnEdit = this.rpVal;
            this.colOutAmount.FieldName = "OutAmount";
            this.colOutAmount.Name = "colOutAmount";
            this.colOutAmount.OptionsColumn.FixedWidth = true;
            this.colOutAmount.OptionsColumn.ReadOnly = true;
            this.colOutAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutAmount.Visible = true;
            this.colOutAmount.Width = 114;
            // 
            // colSaleAmount
            // 
            this.colSaleAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaleAmount.Caption = "Doanh Số";
            this.colSaleAmount.ColumnEdit = this.rpVal;
            this.colSaleAmount.FieldName = "SaleAmount";
            this.colSaleAmount.Name = "colSaleAmount";
            this.colSaleAmount.OptionsColumn.FixedWidth = true;
            this.colSaleAmount.OptionsColumn.ReadOnly = true;
            this.colSaleAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSaleAmount.Visible = true;
            this.colSaleAmount.Width = 112;
            // 
            // colProfit
            // 
            this.colProfit.AppearanceHeader.Options.UseTextOptions = true;
            this.colProfit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProfit.Caption = "Lợi Nhuận";
            this.colProfit.ColumnEdit = this.rpVal;
            this.colProfit.FieldName = "Profit";
            this.colProfit.Name = "colProfit";
            this.colProfit.OptionsColumn.FixedWidth = true;
            this.colProfit.OptionsColumn.ReadOnly = true;
            this.colProfit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProfit.Visible = true;
            this.colProfit.Width = 109;
            // 
            // colE_Amt
            // 
            this.colE_Amt.AppearanceHeader.Options.UseTextOptions = true;
            this.colE_Amt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colE_Amt.Caption = "Cuối Kỳ";
            this.colE_Amt.ColumnEdit = this.rpVal;
            this.colE_Amt.FieldName = "E_Amt";
            this.colE_Amt.Name = "colE_Amt";
            this.colE_Amt.OptionsColumn.FixedWidth = true;
            this.colE_Amt.OptionsColumn.ReadOnly = true;
            this.colE_Amt.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colE_Amt.Visible = true;
            this.colE_Amt.Width = 132;
            // 
            // colOpenQuantity
            // 
            this.colOpenQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colOpenQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOpenQuantity.Caption = "Số Lượng";
            this.colOpenQuantity.ColumnEdit = this.rpVal;
            this.colOpenQuantity.FieldName = "OpenQuantity";
            this.colOpenQuantity.Name = "colOpenQuantity";
            this.colOpenQuantity.OptionsColumn.FixedWidth = true;
            this.colOpenQuantity.OptionsColumn.ReadOnly = true;
            this.colOpenQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOpenQuantity.Width = 90;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.FixedWidth = true;
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Width = 90;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoComplete = false;
            this.rpUnit.AutoHeight = false;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "(Chọn)";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 415);
            this.panelControl1.TabIndex = 26;
            // 
            // iNVENTORY_Summary_RevenueTableAdapter
            // 
            this.iNVENTORY_Summary_RevenueTableAdapter.ClearBeforeFill = true;
            // 
            // xucInventoryRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "xucInventoryRevenue";
            this.Size = new System.Drawing.Size(971, 470);
            this.Controls.SetChildIndex(this.plTop, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYSummaryRevenueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BandInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource iNVENTORYSummaryRevenueBindingSource;
        private Perfect.Inventory.Core.Inventory.Inventory.Revenue.dsInventoryRevenue dsInventoryRevenue;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFromDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colToDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOpenAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colE_Amt;
        private Perfect.Inventory.Core.Inventory.Inventory.Revenue.dsInventoryRevenueTableAdapters.INVENTORY_Summary_RevenueTableAdapter iNVENTORY_Summary_RevenueTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOpenQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSaleAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colE_Qty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProfit;
    }
}
