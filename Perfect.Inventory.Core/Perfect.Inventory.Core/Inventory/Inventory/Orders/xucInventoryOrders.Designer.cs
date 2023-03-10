using Perfect.Inventory.Core.Common.DS;
using Perfect.Inventory.Core.Inventory.Inventory.Orders.DS;
using Perfect.Inventory.Core.Inventory.Inventory.Orders.DS.dsInventoryOrderTableAdapters;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    partial class xucInventoryOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucInventoryOrders));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colRate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYOrderWarningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventoryOrder = new Perfect.Inventory.Core.Inventory.Inventory.Orders.DS.dsInventoryOrder();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMinStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrder = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rpGroup = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.iNVENTORY_Order_WarningTableAdapter = new Perfect.Inventory.Core.Inventory.Inventory.Orders.DS.dsInventoryOrderTableAdapters.INVENTORY_Order_WarningTableAdapter();
            this.plMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYOrderWarningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Size = new System.Drawing.Size(723, 56);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            // 
            // colRate
            // 
            this.colRate.Caption = "Tỷ lệ";
            this.colRate.ColumnEdit = this.rpVal;
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.OptionsColumn.FixedWidth = true;
            this.colRate.OptionsColumn.ReadOnly = true;
            this.colRate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRate.Visible = true;
            this.colRate.Width = 93;
            // 
            // rpVal
            // 
            this.rpVal.AutoHeight = false;
            this.rpVal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.Name = "rpVal";
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
            // gcList
            // 
            this.gcList.DataSource = this.iNVENTORYOrderWarningBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpType,
            this.rpGroup,
            this.rpVal,
            this.rpDate,
            this.rpUnit});
            this.gcList.Size = new System.Drawing.Size(719, 412);
            this.gcList.TabIndex = 20;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            this.gcList.Click += new System.EventHandler(this.gcList_Click);
            // 
            // iNVENTORYOrderWarningBindingSource
            // 
            this.iNVENTORYOrderWarningBindingSource.DataMember = "INVENTORY_Order_Warning";
            this.iNVENTORYOrderWarningBindingSource.DataSource = this.dsInventoryOrder;
            // 
            // dsInventoryOrder
            // 
            this.dsInventoryOrder.DataSetName = "dsInventoryOrder";
            this.dsInventoryOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_ID,
            this.colProductGroup_Name,
            this.colProduct_Name,
            this.colUnit,
            this.colQuantity,
            this.colMinStock,
            this.colRate,
            this.colOrder});
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colRate;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = 1;
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Gold;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colRate;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition2.Value1 = "1";
            styleFormatCondition2.Value2 = "2";
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.LightSkyBlue;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colRate;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition3.Value1 = "2";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ColumnAutoWidth = true;
            this.gbList.OptionsView.EnableAppearanceEvenRow = true;
            this.gbList.OptionsView.EnableAppearanceOddRow = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductGroup_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.ViewCaption = "Danh sách Nhân viên";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProductGroup_Name);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colMinStock);
            this.gridBand1.Columns.Add(this.colRate);
            this.gridBand1.Columns.Add(this.colOrder);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.Width = 859;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.FixedWidth = true;
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 141;
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.Caption = "Nhóm";
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.OptionsColumn.FixedWidth = true;
            this.colProductGroup_Name.OptionsColumn.ReadOnly = true;
            this.colProductGroup_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Hàng hoá";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.FixedWidth = true;
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 247;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Đơn vị";
            this.colUnit.ColumnEdit = this.rpUnit;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.FixedWidth = true;
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Visible = true;
            this.colUnit.Width = 80;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoHeight = false;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DataSource = this.uNITBindingSource;
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.gridView3;
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
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.FixedWidth = true;
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 99;
            // 
            // colMinStock
            // 
            this.colMinStock.Caption = "Định mức";
            this.colMinStock.ColumnEdit = this.rpVal;
            this.colMinStock.FieldName = "MinStock";
            this.colMinStock.Name = "colMinStock";
            this.colMinStock.OptionsColumn.FixedWidth = true;
            this.colMinStock.OptionsColumn.ReadOnly = true;
            this.colMinStock.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMinStock.Visible = true;
            this.colMinStock.Width = 99;
            // 
            // colOrder
            // 
            this.colOrder.Caption = "Đặt hàng";
            this.colOrder.ColumnEdit = this.rpVal;
            this.colOrder.FieldName = "Order";
            this.colOrder.Name = "colOrder";
            this.colOrder.OptionsColumn.FixedWidth = true;
            this.colOrder.OptionsColumn.ReadOnly = true;
            this.colOrder.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOrder.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOrder.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOrder.Visible = true;
            this.colOrder.Width = 100;
            // 
            // rpType
            // 
            this.rpType.AutoHeight = false;
            this.rpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpType.Name = "rpType";
            // 
            // rpGroup
            // 
            this.rpGroup.AutoHeight = false;
            this.rpGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpGroup.DisplayMember = "ProductGroup_ID";
            this.rpGroup.Name = "rpGroup";
            this.rpGroup.ValueMember = "ProductGroup_ID";
            this.rpGroup.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.rpDate.Name = "rpDate";
            this.rpDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // iNVENTORY_Order_WarningTableAdapter
            // 
            this.iNVENTORY_Order_WarningTableAdapter.ClearBeforeFill = true;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.gcList);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 56);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(723, 416);
            this.plMain.TabIndex = 22;
            // 
            // xucInventoryOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Name = "xucInventoryOrders";
            this.Size = new System.Drawing.Size(723, 472);
            this.Controls.SetChildIndex(this.plTop, 0);
            this.Controls.SetChildIndex(this.plMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYOrderWarningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        protected DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpType;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMinStock;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrder;
        private dsInventoryOrder dsInventoryOrder;
        private System.Windows.Forms.BindingSource iNVENTORYOrderWarningBindingSource;
        private INVENTORY_Order_WarningTableAdapter iNVENTORY_Order_WarningTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductGroup_Name;
        private DevExpress.XtraEditors.PanelControl plMain;
    }
}
