using Perfect.Inventory.Core.Common.DS;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    partial class xucInventorySummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucInventorySummary));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colTotalIOQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYDETAILSUMMARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSummary = new Perfect.Inventory.Core.Inventory.Inventory.Summary.DS.dsSummary();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProductID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOpenQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOpenAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colInQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colInAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colOutQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOutAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTotalIOAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.plMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYDETAILSUMMARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Size = new System.Drawing.Size(1152, 56);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            // 
            // colTotalIOQuantity
            // 
            this.colTotalIOQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalIOQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalIOQuantity.Caption = "Số Lượng";
            this.colTotalIOQuantity.ColumnEdit = this.rpVal;
            this.colTotalIOQuantity.FieldName = "TotalIOQuantity";
            this.colTotalIOQuantity.Name = "colTotalIOQuantity";
            this.colTotalIOQuantity.OptionsColumn.ReadOnly = true;
            this.colTotalIOQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTotalIOQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colTotalIOQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalIOQuantity.Visible = true;
            this.colTotalIOQuantity.Width = 86;
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
            this.gcList.DataSource = this.iNVENTORYDETAILSUMMARYBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpUnit,
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(1148, 485);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList,
            this.gridView2});
            // 
            // iNVENTORYDETAILSUMMARYBindingSource
            // 
            this.iNVENTORYDETAILSUMMARYBindingSource.DataMember = "INVENTORY_DETAIL_SUMMARY";
            this.iNVENTORYDETAILSUMMARYBindingSource.DataSource = this.dsSummary;
            // 
            // dsSummary
            // 
            this.dsSummary.DataSetName = "dsSummary";
            this.dsSummary.EnforceConstraints = false;
            this.dsSummary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbList.AppearancePrint.BandPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbList.AppearancePrint.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gbList.AppearancePrint.GroupRow.Options.UseForeColor = true;
            this.gbList.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbList.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProductID,
            this.colProduct_Name,
            this.colUnitName,
            this.colOpenQuantity,
            this.colOpenAmount,
            this.colInQuantity,
            this.colInAmount,
            this.colOutQuantity,
            this.colOutAmount,
            this.colTotalIOQuantity,
            this.colTotalIOAmount,
            this.colStock_Name});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1134, 402, 223, 241);
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colTotalIOQuantity;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFormat = "[#image]{1} {2}";
            this.gbList.GroupPanelText = "Kéo và Thả cột vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OpenQuantity", this.colOpenQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OpenAmount", this.colOpenAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InQuantity", this.colInQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InAmount", this.colInAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutQuantity", this.colOutQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutAmount", this.colOutAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIOQuantity", this.colTotalIOQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalIOAmount", this.colTotalIOAmount, "{0:##,##0.###}")});
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
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsPrint.UsePrintStyles = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.PaintStyleName = "Skin";
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStock_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gbList_CustomSummaryCalculate);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colProductID);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colUnitName);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.OptionsBand.ShowInCustomizationForm = false;
            this.gridBand1.Width = 413;
            // 
            // colProductID
            // 
            this.colProductID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductID.Caption = "Mã hàng";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.ReadOnly = true;
            this.colProductID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProductID.Visible = true;
            this.colProductID.Width = 119;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Hàng Hoá";
            this.colProduct_Name.FieldName = "ProductName";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 235;
            // 
            // colUnitName
            // 
            this.colUnitName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitName.Caption = "ĐVT";
            this.colUnitName.FieldName = "Unit_Name";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.OptionsColumn.ReadOnly = true;
            this.colUnitName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitName.Visible = true;
            this.colUnitName.Width = 59;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Đầu Kỳ";
            this.gridBand2.Columns.Add(this.colOpenQuantity);
            this.gridBand2.Columns.Add(this.colOpenAmount);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 180;
            // 
            // colOpenQuantity
            // 
            this.colOpenQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colOpenQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOpenQuantity.Caption = "Số Lượng";
            this.colOpenQuantity.ColumnEdit = this.rpVal;
            this.colOpenQuantity.FieldName = "OpenQuantity";
            this.colOpenQuantity.Name = "colOpenQuantity";
            this.colOpenQuantity.OptionsColumn.ReadOnly = true;
            this.colOpenQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOpenQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOpenQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOpenQuantity.Visible = true;
            this.colOpenQuantity.Width = 77;
            // 
            // colOpenAmount
            // 
            this.colOpenAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colOpenAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOpenAmount.Caption = "Thành Tiền";
            this.colOpenAmount.ColumnEdit = this.rpVal;
            this.colOpenAmount.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colOpenAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOpenAmount.FieldName = "OpenAmount";
            this.colOpenAmount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colOpenAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOpenAmount.Name = "colOpenAmount";
            this.colOpenAmount.OptionsColumn.ReadOnly = true;
            this.colOpenAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOpenAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOpenAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOpenAmount.Visible = true;
            this.colOpenAmount.Width = 103;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Nhập Kho";
            this.gridBand3.Columns.Add(this.colInQuantity);
            this.gridBand3.Columns.Add(this.colInAmount);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 180;
            // 
            // colInQuantity
            // 
            this.colInQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colInQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInQuantity.Caption = "Số Lượng";
            this.colInQuantity.ColumnEdit = this.rpVal;
            this.colInQuantity.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colInQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInQuantity.FieldName = "InQuantity";
            this.colInQuantity.Name = "colInQuantity";
            this.colInQuantity.OptionsColumn.ReadOnly = true;
            this.colInQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colInQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInQuantity.Visible = true;
            this.colInQuantity.Width = 78;
            // 
            // colInAmount
            // 
            this.colInAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colInAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInAmount.Caption = "Thành Tiền";
            this.colInAmount.ColumnEdit = this.rpVal;
            this.colInAmount.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colInAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInAmount.FieldName = "InAmount";
            this.colInAmount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colInAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInAmount.Name = "colInAmount";
            this.colInAmount.OptionsColumn.ReadOnly = true;
            this.colInAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colInAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInAmount.Visible = true;
            this.colInAmount.Width = 102;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Xuất Kho";
            this.gridBand4.Columns.Add(this.colOutQuantity);
            this.gridBand4.Columns.Add(this.colOutAmount);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 180;
            // 
            // colOutQuantity
            // 
            this.colOutQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutQuantity.Caption = "Số Lượng";
            this.colOutQuantity.ColumnEdit = this.rpVal;
            this.colOutQuantity.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colOutQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOutQuantity.FieldName = "OutQuantity";
            this.colOutQuantity.Name = "colOutQuantity";
            this.colOutQuantity.OptionsColumn.ReadOnly = true;
            this.colOutQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOutQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutQuantity.Visible = true;
            this.colOutQuantity.Width = 82;
            // 
            // colOutAmount
            // 
            this.colOutAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colOutAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOutAmount.Caption = "Thành Tiền";
            this.colOutAmount.ColumnEdit = this.rpVal;
            this.colOutAmount.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colOutAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOutAmount.FieldName = "OutAmount";
            this.colOutAmount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colOutAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOutAmount.Name = "colOutAmount";
            this.colOutAmount.OptionsColumn.ReadOnly = true;
            this.colOutAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOutAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutAmount.Visible = true;
            this.colOutAmount.Width = 98;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Cuối Kỳ";
            this.gridBand5.Columns.Add(this.colTotalIOQuantity);
            this.gridBand5.Columns.Add(this.colTotalIOAmount);
            this.gridBand5.MinWidth = 20;
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 191;
            // 
            // colTotalIOAmount
            // 
            this.colTotalIOAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalIOAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalIOAmount.Caption = "Thành Tiền";
            this.colTotalIOAmount.ColumnEdit = this.rpVal;
            this.colTotalIOAmount.FieldName = "TotalIOAmount";
            this.colTotalIOAmount.Name = "colTotalIOAmount";
            this.colTotalIOAmount.OptionsColumn.ReadOnly = true;
            this.colTotalIOAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTotalIOAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colTotalIOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalIOAmount.Visible = true;
            this.colTotalIOAmount.Width = 105;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.Visible = true;
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
            this.dsUnit.EnforceConstraints = false;
            this.dsUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcList;
            this.gridView2.Name = "gridView2";
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsSTOCK;
            // 
            // dsSTOCK
            // 
            this.dsSTOCK.DataSetName = "dsSTOCK";
            this.dsSTOCK.EnforceConstraints = false;
            this.dsSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.gcList);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 56);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1152, 489);
            this.plMain.TabIndex = 26;
            // 
            // xucInventorySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Name = "xucInventorySummary";
            this.Size = new System.Drawing.Size(1152, 545);
            this.Controls.SetChildIndex(this.plTop, 0);
            this.Controls.SetChildIndex(this.plMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYDETAILSUMMARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOpenQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOpenAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutAmount;
        private DevExpress.XtraEditors.PanelControl plMain;
        private System.Windows.Forms.BindingSource iNVENTORYDETAILSUMMARYBindingSource;
        private Perfect.Inventory.Core.Inventory.Inventory.Summary.DS.dsSummary dsSummary;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalIOQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTotalIOAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
    }
}
