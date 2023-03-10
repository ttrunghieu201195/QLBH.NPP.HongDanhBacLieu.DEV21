using Perfect.Inventory.Core.Common.DS;

namespace Perfect.Inventory.Core.Inventory.Inventory.Details.TS
{
    partial class xucInventoryDetailWithAVGPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucInventoryDetailWithAVGPrice));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYDYNAMICAVGPRICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventory = new Perfect.Inventory.Core.Inventory.Inventory.Details.DS.dsInventory();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductGroup_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAVGUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAVGAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.plMain = new DevExpress.XtraEditors.PanelControl();
            this.colActive = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colActiveInt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYDYNAMICAVGPRICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
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
            this.plTop.Size = new System.Drawing.Size(1059, 56);
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
            this.gcList.DataSource = this.iNVENTORYDYNAMICAVGPRICEBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpUnit,
            this.rpDate,
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(1055, 461);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // iNVENTORYDYNAMICAVGPRICEBindingSource
            // 
            this.iNVENTORYDYNAMICAVGPRICEBindingSource.DataMember = "INVENTORY_DYNAMIC_AVGPRICE";
            this.iNVENTORYDYNAMICAVGPRICEBindingSource.DataSource = this.dsInventory;
            // 
            // dsInventory
            // 
            this.dsInventory.DataSetName = "dsInventory";
            this.dsInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
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
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit,
            this.colUnit_Name,
            this.colStock_ID,
            this.colStock_Name,
            this.colProductGroup_ID,
            this.colProductGroup_Name,
            this.colQuantity,
            this.colAVGUnitPrice,
            this.colAVGAmount,
            this.colActive,
            this.colActiveInt});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(539, 257, 223, 236);
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "Iif([Quantity] < 0,True  , False)";
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Silver;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colActiveInt;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "0";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFormat = "[#image]{1} {2}";
            this.gbList.GroupPanelText = "Hãy Kéo Cột và Thả Vào Đây Để Tạo Nhóm";
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AllowIncrementalSearch = true;
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsPrint.UsePrintStyles = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.PaintStyleName = "Skin";
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStock_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GbListCustomSummaryCalculate);
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 99;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 197;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Mã Đơn Vị";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.Width = 69;
            // 
            // colStock_ID
            // 
            this.colStock_ID.Caption = "Mã Kho";
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.ReadOnly = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID.Width = 118;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.Visible = true;
            this.colStock_Name.Width = 126;
            // 
            // colProductGroup_ID
            // 
            this.colProductGroup_ID.Caption = "Mã Nhóm";
            this.colProductGroup_ID.FieldName = "ProductGroup_ID";
            this.colProductGroup_ID.Name = "colProductGroup_ID";
            this.colProductGroup_ID.OptionsColumn.ReadOnly = true;
            this.colProductGroup_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.Caption = "Nhóm Hàng";
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.OptionsColumn.ReadOnly = true;
            this.colProductGroup_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProductGroup_Name.Visible = true;
            this.colProductGroup_Name.Width = 148;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 83;
            // 
            // colAVGUnitPrice
            // 
            this.colAVGUnitPrice.Caption = "Đơn Giá";
            this.colAVGUnitPrice.ColumnEdit = this.rpVal;
            this.colAVGUnitPrice.FieldName = "AVGUnitPrice";
            this.colAVGUnitPrice.Name = "colAVGUnitPrice";
            this.colAVGUnitPrice.OptionsColumn.ReadOnly = true;
            this.colAVGUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAVGUnitPrice.Visible = true;
            this.colAVGUnitPrice.Width = 96;
            // 
            // colAVGAmount
            // 
            this.colAVGAmount.Caption = "Thành Tiền";
            this.colAVGAmount.ColumnEdit = this.rpVal;
            this.colAVGAmount.FieldName = "AVGAmount";
            this.colAVGAmount.Name = "colAVGAmount";
            this.colAVGAmount.OptionsColumn.ReadOnly = true;
            this.colAVGAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAVGAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAVGAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAVGAmount.Visible = true;
            this.colAVGAmount.Width = 112;
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
            // plMain
            // 
            this.plMain.Controls.Add(this.gcList);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 56);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1059, 465);
            this.plMain.TabIndex = 19;
            // 
            // colActive
            // 
            this.colActive.Caption = "Còn Quản Lý";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.ReadOnly = true;
            this.colActive.Visible = true;
            this.colActive.Width = 81;
            // 
            // colActiveInt
            // 
            this.colActiveInt.FieldName = "ActiveInt";
            this.colActiveInt.Name = "colActiveInt";
            this.colActiveInt.OptionsColumn.ReadOnly = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colUnit_Name);
            this.gridBand1.Columns.Add(this.colStock_ID);
            this.gridBand1.Columns.Add(this.colStock_Name);
            this.gridBand1.Columns.Add(this.colProductGroup_ID);
            this.gridBand1.Columns.Add(this.colProductGroup_Name);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colAVGUnitPrice);
            this.gridBand1.Columns.Add(this.colAVGAmount);
            this.gridBand1.Columns.Add(this.colActive);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.Width = 1011;
            // 
            // xucInventoryDetailWithAVGPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Name = "xucInventoryDetailWithAVGPrice";
            this.Size = new System.Drawing.Size(1059, 521);
            this.Controls.SetChildIndex(this.plTop, 0);
            this.Controls.SetChildIndex(this.plMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYDYNAMICAVGPRICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
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
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.PanelControl plMain;
        private System.Windows.Forms.BindingSource iNVENTORYDYNAMICAVGPRICEBindingSource;
        private Perfect.Inventory.Core.Inventory.Inventory.Details.DS.dsInventory dsInventory;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductGroup_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductGroup_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAVGUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAVGAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colActive;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colActiveInt;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}
