using Perfect.Sale.Core.Report.control;

namespace Perfect.Sale.Core.Report.SaleQuantity
{
    partial class xucSaleQuantityByPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucSaleQuantityByPro));
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.saleByProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaleQuantity = new Perfect.Sale.Core.Report.DS.dsSaleQuantity();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colOpenAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutAmountReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIOQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIOAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVGPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleByProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Size = new System.Drawing.Size(941, 681);
            this.layoutControl1.Controls.SetChildIndex(this.gcList, 0);
            // 
            // lgDetail
            // 
            this.lgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.lgDetail.Location = new System.Drawing.Point(0, 651);
            this.lgDetail.Size = new System.Drawing.Size(941, 24);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(941, 612);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(941, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.saleByProductBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(937, 608);
            this.gcList.TabIndex = 42;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // saleByProductBindingSource
            // 
            this.saleByProductBindingSource.DataMember = "SaleByProduct";
            this.saleByProductBindingSource.DataSource = this.dsSaleQuantity;
            // 
            // dsSaleQuantity
            // 
            this.dsSaleQuantity.DataSetName = "dsSaleQuantity";
            this.dsSaleQuantity.EnforceConstraints = false;
            this.dsSaleQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductName,
            this.colUnit,
            this.colUnit_Name,
            this.colProductGroupID,
            this.colProductGroup_Name,
            this.colStockID,
            this.colStock_Name,
            this.colOpenQuantity,
            this.colOpenAmount,
            this.colInQuantity,
            this.colInAmount,
            this.colOutQuantity,
            this.colOutAmount,
            this.colOutAmountReal,
            this.colTotalIOQuantity,
            this.colTotalIOAmount,
            this.colProfitAmount,
            this.colAVGPrice});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutQuantity", this.colOutQuantity, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutAmountReal", this.colOutAmountReal, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OutAmount", this.colOutAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProfitAmount", this.colProfitAmount, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 45;
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStock_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            // 
            // colProductID
            // 
            this.colProductID.Caption = "Mã Hàng";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.ReadOnly = true;
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            this.colProductID.Width = 137;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Tên Hàng";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 263;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.ReadOnly = true;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 2;
            // 
            // colProductGroupID
            // 
            this.colProductGroupID.FieldName = "ProductGroupID";
            this.colProductGroupID.Name = "colProductGroupID";
            this.colProductGroupID.OptionsColumn.ReadOnly = true;
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.OptionsColumn.ReadOnly = true;
            // 
            // colStockID
            // 
            this.colStockID.FieldName = "StockID";
            this.colStockID.Name = "colStockID";
            this.colStockID.OptionsColumn.ReadOnly = true;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 0;
            this.colStock_Name.Width = 150;
            // 
            // colOpenQuantity
            // 
            this.colOpenQuantity.ColumnEdit = this.rpVal;
            this.colOpenQuantity.FieldName = "OpenQuantity";
            this.colOpenQuantity.Name = "colOpenQuantity";
            this.colOpenQuantity.OptionsColumn.ReadOnly = true;
            this.colOpenQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOpenQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // rpVal
            // 
            this.rpVal.AutoHeight = false;
            this.rpVal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.Name = "rpVal";
            // 
            // colOpenAmount
            // 
            this.colOpenAmount.ColumnEdit = this.rpVal;
            this.colOpenAmount.FieldName = "OpenAmount";
            this.colOpenAmount.Name = "colOpenAmount";
            this.colOpenAmount.OptionsColumn.ReadOnly = true;
            this.colOpenAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOpenAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colInQuantity
            // 
            this.colInQuantity.ColumnEdit = this.rpVal;
            this.colInQuantity.FieldName = "InQuantity";
            this.colInQuantity.Name = "colInQuantity";
            this.colInQuantity.OptionsColumn.ReadOnly = true;
            this.colInQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colInQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colInAmount
            // 
            this.colInAmount.ColumnEdit = this.rpVal;
            this.colInAmount.FieldName = "InAmount";
            this.colInAmount.Name = "colInAmount";
            this.colInAmount.OptionsColumn.ReadOnly = true;
            this.colInAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colInAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colOutQuantity
            // 
            this.colOutQuantity.Caption = "SL Xuất";
            this.colOutQuantity.ColumnEdit = this.rpVal;
            this.colOutQuantity.FieldName = "OutQuantity";
            this.colOutQuantity.Name = "colOutQuantity";
            this.colOutQuantity.OptionsColumn.ReadOnly = true;
            this.colOutQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOutQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutQuantity.Visible = true;
            this.colOutQuantity.VisibleIndex = 4;
            this.colOutQuantity.Width = 69;
            // 
            // colOutAmount
            // 
            this.colOutAmount.Caption = "Giá Trị Xuất";
            this.colOutAmount.ColumnEdit = this.rpVal;
            this.colOutAmount.FieldName = "OutAmount";
            this.colOutAmount.Name = "colOutAmount";
            this.colOutAmount.OptionsColumn.ReadOnly = true;
            this.colOutAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOutAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutAmount.Visible = true;
            this.colOutAmount.VisibleIndex = 6;
            this.colOutAmount.Width = 125;
            // 
            // colOutAmountReal
            // 
            this.colOutAmountReal.Caption = "Doanh Số";
            this.colOutAmountReal.ColumnEdit = this.rpVal;
            this.colOutAmountReal.FieldName = "OutAmountReal";
            this.colOutAmountReal.Name = "colOutAmountReal";
            this.colOutAmountReal.OptionsColumn.ReadOnly = true;
            this.colOutAmountReal.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colOutAmountReal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutAmountReal.Visible = true;
            this.colOutAmountReal.VisibleIndex = 5;
            this.colOutAmountReal.Width = 136;
            // 
            // colTotalIOQuantity
            // 
            this.colTotalIOQuantity.ColumnEdit = this.rpVal;
            this.colTotalIOQuantity.FieldName = "TotalIOQuantity";
            this.colTotalIOQuantity.Name = "colTotalIOQuantity";
            this.colTotalIOQuantity.OptionsColumn.ReadOnly = true;
            this.colTotalIOQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colTotalIOQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colTotalIOAmount
            // 
            this.colTotalIOAmount.ColumnEdit = this.rpVal;
            this.colTotalIOAmount.FieldName = "TotalIOAmount";
            this.colTotalIOAmount.Name = "colTotalIOAmount";
            this.colTotalIOAmount.OptionsColumn.ReadOnly = true;
            this.colTotalIOAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colTotalIOAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colProfitAmount
            // 
            this.colProfitAmount.Caption = "Chênh Lệch";
            this.colProfitAmount.ColumnEdit = this.rpVal;
            this.colProfitAmount.FieldName = "ProfitAmount";
            this.colProfitAmount.Name = "colProfitAmount";
            this.colProfitAmount.OptionsColumn.ReadOnly = true;
            this.colProfitAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colProfitAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colProfitAmount.Visible = true;
            this.colProfitAmount.VisibleIndex = 7;
            this.colProfitAmount.Width = 118;
            // 
            // colAVGPrice
            // 
            this.colAVGPrice.Caption = "Giá Gốc";
            this.colAVGPrice.ColumnEdit = this.rpVal;
            this.colAVGPrice.FieldName = "AVGPrice";
            this.colAVGPrice.Name = "colAVGPrice";
            this.colAVGPrice.OptionsColumn.ReadOnly = true;
            this.colAVGPrice.Visible = true;
            this.colAVGPrice.VisibleIndex = 3;
            this.colAVGPrice.Width = 107;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(941, 612);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // xucSaleQuantityByPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucSaleQuantityByPro";
            this.Size = new System.Drawing.Size(941, 681);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleByProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private System.Windows.Forms.BindingSource saleByProductBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleQuantity dsSaleQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colStockID;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colInQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colInAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOutAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutAmountReal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIOQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIOAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colProfitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAVGPrice;
    }
}