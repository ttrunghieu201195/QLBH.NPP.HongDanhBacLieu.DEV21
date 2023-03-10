using Perfect.Sale.Core.Report.control;

namespace Perfect.Sale.Core.Report.SaleQuantity
{
    partial class XucSaleQuantityByEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucSaleQuantityByEmp));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gbList_Buy_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCharge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.eMPLOYEEHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaleQuantity = new Perfect.Sale.Core.Report.DS.dsSaleQuantity();
            this.gbList_Sale_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_Name3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCharge1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumBuyAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumSaleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpEmp = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpValPercent = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.eMPLOYEE_HeaderTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleQuantityTableAdapters.EMPLOYEE_HeaderTableAdapter();
            this.buyDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_DetailTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleQuantityTableAdapters.Buy_DetailTableAdapter();
            this.saleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale_DetailTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleQuantityTableAdapters.Sale_DetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Buy_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Sale_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpValPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailBindingSource)).BeginInit();
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
            // gbList_Buy_Detail
            // 
            this.gbList_Buy_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRefDate,
            this.colEmployee_ID2,
            this.colStock_ID,
            this.colVat,
            this.colVatAmount,
            this.colAmount,
            this.colDiscountRate,
            this.colDiscount,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit,
            this.colUnit_Name,
            this.colStock_Name,
            this.colQuantity,
            this.colUnitPrice,
            this.colEmployee_Name2,
            this.colCharge});
            this.gbList_Buy_Detail.CustomizationFormBounds = new System.Drawing.Rectangle(831, 275, 216, 199);
            this.gbList_Buy_Detail.GridControl = this.gcList;
            this.gbList_Buy_Detail.GroupPanelText = "Kéo Cột Và Thả Vào Đây Để Nhóm Dữ Liệu";
            this.gbList_Buy_Detail.IndicatorWidth = 40;
            this.gbList_Buy_Detail.Name = "gbList_Buy_Detail";
            this.gbList_Buy_Detail.OptionsView.ColumnAutoWidth = false;
            this.gbList_Buy_Detail.OptionsView.ShowAutoFilterRow = true;
            this.gbList_Buy_Detail.OptionsView.ShowFooter = true;
            this.gbList_Buy_Detail.ViewCaption = "Chi Phí Mua Hàng";
            this.gbList_Buy_Detail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_Buy_Detail_CustomDrawRowIndicator);
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Chứng Từ";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 123;
            // 
            // colRefDate
            // 
            this.colRefDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate.Visible = true;
            this.colRefDate.VisibleIndex = 1;
            this.colRefDate.Width = 85;
            // 
            // colEmployee_ID2
            // 
            this.colEmployee_ID2.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_ID2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_ID2.Caption = "Mã Nhân Viên";
            this.colEmployee_ID2.FieldName = "Employee_ID";
            this.colEmployee_ID2.Name = "colEmployee_ID2";
            this.colEmployee_ID2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee_ID2.OptionsColumn.ReadOnly = true;
            this.colEmployee_ID2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_ID
            // 
            this.colStock_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID.Caption = "Mã Kho";
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_ID.OptionsColumn.ReadOnly = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colVat
            // 
            this.colVat.AppearanceHeader.Options.UseTextOptions = true;
            this.colVat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVat.Caption = "VAT (%)";
            this.colVat.FieldName = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colVat.OptionsColumn.ReadOnly = true;
            this.colVat.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colVatAmount
            // 
            this.colVatAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colVatAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVatAmount.Caption = "Thuế";
            this.colVatAmount.FieldName = "VatAmount";
            this.colVatAmount.Name = "colVatAmount";
            this.colVatAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colVatAmount.OptionsColumn.ReadOnly = true;
            this.colVatAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            this.colAmount.Width = 119;
            // 
            // rpVal
            // 
            this.rpVal.AutoHeight = false;
            this.rpVal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVal.DisplayFormat.FormatString = "##,##0.###";
            this.rpVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rpVal.EditFormat.FormatString = "##,##0.###";
            this.rpVal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rpVal.Name = "rpVal";
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscountRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscountRate.Caption = "Chiết Khấu (%)";
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscountRate.OptionsColumn.ReadOnly = true;
            this.colDiscountRate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colDiscount
            // 
            this.colDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscount.Caption = "Chiết Khấu";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscount.OptionsColumn.ReadOnly = true;
            this.colDiscount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiscount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.VisibleIndex = 2;
            this.colProduct_ID.Width = 81;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 3;
            this.colProduct_Name.Width = 294;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.Caption = "Mã Đơn Vị";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 4;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 5;
            this.colStock_Name.Width = 146;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 6;
            this.colQuantity.Width = 94;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "Đơn Giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 7;
            this.colUnitPrice.Width = 98;
            // 
            // colEmployee_Name2
            // 
            this.colEmployee_Name2.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_Name2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_Name2.Caption = "Nhân Viên";
            this.colEmployee_Name2.FieldName = "Employee_Name";
            this.colEmployee_Name2.Name = "colEmployee_Name2";
            this.colEmployee_Name2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee_Name2.OptionsColumn.ReadOnly = true;
            this.colEmployee_Name2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colCharge
            // 
            this.colCharge.AppearanceHeader.Options.UseTextOptions = true;
            this.colCharge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCharge.FieldName = "Charge";
            this.colCharge.Name = "colCharge";
            this.colCharge.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCharge.OptionsColumn.ReadOnly = true;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.eMPLOYEEHeaderBindingSource;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.EmbeddedNavigator.TextStringFormat = "Dòng {0} / {1}";
            gridLevelNode1.LevelTemplate = this.gbList_Buy_Detail;
            gridLevelNode1.RelationName = "EMPLOYEE_Header_Buy_Detail";
            gridLevelNode2.LevelTemplate = this.gbList_Sale_Detail;
            gridLevelNode2.RelationName = "EMPLOYEE_Header_Sale_Detail";
            this.gcList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal,
            this.rpEmp,
            this.rpValPercent});
            this.gcList.Size = new System.Drawing.Size(937, 608);
            this.gcList.TabIndex = 42;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList_Sale_Detail,
            this.gbList,
            this.gbList_Buy_Detail});
            // 
            // eMPLOYEEHeaderBindingSource
            // 
            this.eMPLOYEEHeaderBindingSource.DataMember = "EMPLOYEE_Header";
            this.eMPLOYEEHeaderBindingSource.DataSource = this.dsSaleQuantity;
            // 
            // dsSaleQuantity
            // 
            this.dsSaleQuantity.DataSetName = "dsSaleQuantity";
            this.dsSaleQuantity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList_Sale_Detail
            // 
            this.gbList_Sale_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colRefDate1,
            this.colEmployee_ID3,
            this.colVat1,
            this.colVatAmount1,
            this.colAmount1,
            this.colDiscountRate1,
            this.colDiscount1,
            this.colProduct_ID1,
            this.colProduct_Name1,
            this.colUnit1,
            this.colUnit_Name1,
            this.colQuantity1,
            this.colUnitPrice1,
            this.colEmployee_Name3,
            this.colStock_ID1,
            this.colStock_Name1,
            this.colCharge1});
            this.gbList_Sale_Detail.CustomizationFormBounds = new System.Drawing.Rectangle(673, 268, 216, 199);
            this.gbList_Sale_Detail.GridControl = this.gcList;
            this.gbList_Sale_Detail.GroupPanelText = "Kéo Cột Và Thả Vào Đây Để Nhóm Dữ Liệu";
            this.gbList_Sale_Detail.IndicatorWidth = 40;
            this.gbList_Sale_Detail.Name = "gbList_Sale_Detail";
            this.gbList_Sale_Detail.OptionsView.ColumnAutoWidth = false;
            this.gbList_Sale_Detail.OptionsView.ShowAutoFilterRow = true;
            this.gbList_Sale_Detail.OptionsView.ShowFooter = true;
            this.gbList_Sale_Detail.ViewCaption = "Doanh Thu Bán Hàng";
            this.gbList_Sale_Detail.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_Sale_Detail_CustomDrawRowIndicator);
            // 
            // colID1
            // 
            this.colID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID1.Caption = "Chứng Từ";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 121;
            // 
            // colRefDate1
            // 
            this.colRefDate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate1.Caption = "Ngày";
            this.colRefDate1.FieldName = "RefDate";
            this.colRefDate1.Name = "colRefDate1";
            this.colRefDate1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colRefDate1.OptionsColumn.ReadOnly = true;
            this.colRefDate1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate1.Visible = true;
            this.colRefDate1.VisibleIndex = 1;
            // 
            // colEmployee_ID3
            // 
            this.colEmployee_ID3.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_ID3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_ID3.Caption = "Mã Nhân Viên";
            this.colEmployee_ID3.FieldName = "Employee_ID";
            this.colEmployee_ID3.Name = "colEmployee_ID3";
            this.colEmployee_ID3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee_ID3.OptionsColumn.ReadOnly = true;
            this.colEmployee_ID3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colVat1
            // 
            this.colVat1.AppearanceHeader.Options.UseTextOptions = true;
            this.colVat1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVat1.Caption = "VAT (%)";
            this.colVat1.FieldName = "Vat";
            this.colVat1.Name = "colVat1";
            this.colVat1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colVat1.OptionsColumn.ReadOnly = true;
            this.colVat1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colVatAmount1
            // 
            this.colVatAmount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colVatAmount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVatAmount1.Caption = "Thuế";
            this.colVatAmount1.FieldName = "VatAmount";
            this.colVatAmount1.Name = "colVatAmount1";
            this.colVatAmount1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colVatAmount1.OptionsColumn.ReadOnly = true;
            this.colVatAmount1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colAmount1
            // 
            this.colAmount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount1.Caption = "Thanh Toán";
            this.colAmount1.ColumnEdit = this.rpVal;
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount1.OptionsColumn.ReadOnly = true;
            this.colAmount1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount1.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 11;
            this.colAmount1.Width = 120;
            // 
            // colDiscountRate1
            // 
            this.colDiscountRate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscountRate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscountRate1.Caption = "Chiết Khấu (%)";
            this.colDiscountRate1.ColumnEdit = this.rpVal;
            this.colDiscountRate1.FieldName = "DiscountRate";
            this.colDiscountRate1.Name = "colDiscountRate1";
            this.colDiscountRate1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscountRate1.OptionsColumn.ReadOnly = true;
            this.colDiscountRate1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiscountRate1.Visible = true;
            this.colDiscountRate1.VisibleIndex = 9;
            this.colDiscountRate1.Width = 95;
            // 
            // colDiscount1
            // 
            this.colDiscount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscount1.Caption = "Chiết Khấu";
            this.colDiscount1.ColumnEdit = this.rpVal;
            this.colDiscount1.FieldName = "Discount";
            this.colDiscount1.Name = "colDiscount1";
            this.colDiscount1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscount1.OptionsColumn.ReadOnly = true;
            this.colDiscount1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiscount1.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDiscount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDiscount1.Visible = true;
            this.colDiscount1.VisibleIndex = 10;
            this.colDiscount1.Width = 87;
            // 
            // colProduct_ID1
            // 
            this.colProduct_ID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID1.Caption = "Mã Hàng";
            this.colProduct_ID1.FieldName = "Product_ID";
            this.colProduct_ID1.Name = "colProduct_ID1";
            this.colProduct_ID1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_ID1.OptionsColumn.ReadOnly = true;
            this.colProduct_ID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID1.Visible = true;
            this.colProduct_ID1.VisibleIndex = 2;
            this.colProduct_ID1.Width = 86;
            // 
            // colProduct_Name1
            // 
            this.colProduct_Name1.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name1.Caption = "Tên Hàng";
            this.colProduct_Name1.FieldName = "Product_Name";
            this.colProduct_Name1.Name = "colProduct_Name1";
            this.colProduct_Name1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Name1.OptionsColumn.ReadOnly = true;
            this.colProduct_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name1.Visible = true;
            this.colProduct_Name1.VisibleIndex = 3;
            this.colProduct_Name1.Width = 232;
            // 
            // colUnit1
            // 
            this.colUnit1.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit1.Caption = "Mã Đơn Vị";
            this.colUnit1.FieldName = "Unit";
            this.colUnit1.Name = "colUnit1";
            this.colUnit1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit1.OptionsColumn.ReadOnly = true;
            this.colUnit1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colUnit_Name1
            // 
            this.colUnit_Name1.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit_Name1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit_Name1.Caption = "Đơn Vị";
            this.colUnit_Name1.FieldName = "Unit_Name";
            this.colUnit_Name1.Name = "colUnit_Name1";
            this.colUnit_Name1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit_Name1.OptionsColumn.ReadOnly = true;
            this.colUnit_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit_Name1.Visible = true;
            this.colUnit_Name1.VisibleIndex = 4;
            this.colUnit_Name1.Width = 69;
            // 
            // colQuantity1
            // 
            this.colQuantity1.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity1.Caption = "Số Lượng";
            this.colQuantity1.ColumnEdit = this.rpVal;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity1.OptionsColumn.ReadOnly = true;
            this.colQuantity1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity1.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 6;
            this.colQuantity1.Width = 77;
            // 
            // colUnitPrice1
            // 
            this.colUnitPrice1.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice1.Caption = "Đơn Giá";
            this.colUnitPrice1.ColumnEdit = this.rpVal;
            this.colUnitPrice1.FieldName = "UnitPrice";
            this.colUnitPrice1.Name = "colUnitPrice1";
            this.colUnitPrice1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice1.OptionsColumn.ReadOnly = true;
            this.colUnitPrice1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice1.Visible = true;
            this.colUnitPrice1.VisibleIndex = 7;
            this.colUnitPrice1.Width = 74;
            // 
            // colEmployee_Name3
            // 
            this.colEmployee_Name3.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_Name3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_Name3.Caption = "Tên Nhân Viên";
            this.colEmployee_Name3.FieldName = "Employee_Name";
            this.colEmployee_Name3.Name = "colEmployee_Name3";
            this.colEmployee_Name3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee_Name3.OptionsColumn.ReadOnly = true;
            this.colEmployee_Name3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_ID1
            // 
            this.colStock_ID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID1.Caption = "Mã Kho";
            this.colStock_ID1.FieldName = "Stock_ID";
            this.colStock_ID1.Name = "colStock_ID1";
            this.colStock_ID1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_ID1.OptionsColumn.ReadOnly = true;
            this.colStock_ID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_Name1
            // 
            this.colStock_Name1.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name1.Caption = "Kho Hàng";
            this.colStock_Name1.FieldName = "Stock_Name";
            this.colStock_Name1.Name = "colStock_Name1";
            this.colStock_Name1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_Name1.OptionsColumn.ReadOnly = true;
            this.colStock_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name1.Visible = true;
            this.colStock_Name1.VisibleIndex = 5;
            this.colStock_Name1.Width = 98;
            // 
            // colCharge1
            // 
            this.colCharge1.AppearanceHeader.Options.UseTextOptions = true;
            this.colCharge1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCharge1.Caption = "Thành Tiền";
            this.colCharge1.ColumnEdit = this.rpVal;
            this.colCharge1.FieldName = "Charge";
            this.colCharge1.Name = "colCharge1";
            this.colCharge1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCharge1.OptionsColumn.ReadOnly = true;
            this.colCharge1.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colCharge1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCharge1.Visible = true;
            this.colCharge1.VisibleIndex = 8;
            this.colCharge1.Width = 89;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee_ID,
            this.colEmployee_Name1,
            this.colAddress,
            this.colMobile,
            this.colSumBuyAmount,
            this.colSumSaleAmount});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(387, 260, 216, 199);
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupFormat = "[#image]{1}";
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", null, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiscountAmount", null, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VatAmount", null, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", null, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsView.AllowCellMerge = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colEmployee_ID
            // 
            this.colEmployee_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_ID.Caption = "Mã Nhân Viên";
            this.colEmployee_ID.FieldName = "Employee_ID";
            this.colEmployee_ID.Name = "colEmployee_ID";
            this.colEmployee_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee_ID.OptionsColumn.ReadOnly = true;
            this.colEmployee_ID.Visible = true;
            this.colEmployee_ID.VisibleIndex = 0;
            this.colEmployee_ID.Width = 123;
            // 
            // colEmployee_Name1
            // 
            this.colEmployee_Name1.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_Name1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_Name1.Caption = "Tên Nhân Viên";
            this.colEmployee_Name1.FieldName = "Employee_Name";
            this.colEmployee_Name1.Name = "colEmployee_Name1";
            this.colEmployee_Name1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee_Name1.OptionsColumn.ReadOnly = true;
            this.colEmployee_Name1.Visible = true;
            this.colEmployee_Name1.VisibleIndex = 1;
            this.colEmployee_Name1.Width = 160;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.Caption = "Địa Chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 283;
            // 
            // colMobile
            // 
            this.colMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMobile.Caption = "Điện Thoại";
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMobile.OptionsColumn.ReadOnly = true;
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 3;
            this.colMobile.Width = 158;
            // 
            // colSumBuyAmount
            // 
            this.colSumBuyAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumBuyAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumBuyAmount.Caption = "Tổng Số Mua Hàng";
            this.colSumBuyAmount.ColumnEdit = this.rpVal;
            this.colSumBuyAmount.FieldName = "SumBuyAmount";
            this.colSumBuyAmount.Name = "colSumBuyAmount";
            this.colSumBuyAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSumBuyAmount.OptionsColumn.ReadOnly = true;
            this.colSumBuyAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colSumBuyAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSumBuyAmount.Visible = true;
            this.colSumBuyAmount.VisibleIndex = 4;
            this.colSumBuyAmount.Width = 138;
            // 
            // colSumSaleAmount
            // 
            this.colSumSaleAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSumSaleAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSumSaleAmount.Caption = "Tổng Số Bán Hàng";
            this.colSumSaleAmount.ColumnEdit = this.rpVal;
            this.colSumSaleAmount.FieldName = "SumSaleAmount";
            this.colSumSaleAmount.Name = "colSumSaleAmount";
            this.colSumSaleAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSumSaleAmount.OptionsColumn.ReadOnly = true;
            this.colSumSaleAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colSumSaleAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSumSaleAmount.Visible = true;
            this.colSumSaleAmount.VisibleIndex = 5;
            this.colSumSaleAmount.Width = 148;
            // 
            // rpEmp
            // 
            this.rpEmp.AutoHeight = false;
            this.rpEmp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpEmp.DisplayMember = "Employee_Name";
            this.rpEmp.Name = "rpEmp";
            this.rpEmp.NullText = "";
            this.rpEmp.ValueMember = "Employee_ID";
            this.rpEmp.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee_ID1,
            this.colEmployee_Name});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployee_ID1
            // 
            this.colEmployee_ID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_ID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_ID1.Caption = "Mã NV";
            this.colEmployee_ID1.FieldName = "Employee_ID";
            this.colEmployee_ID1.Name = "colEmployee_ID1";
            this.colEmployee_ID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_ID1.Visible = true;
            this.colEmployee_ID1.VisibleIndex = 0;
            // 
            // colEmployee_Name
            // 
            this.colEmployee_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_Name.Caption = "Tên NV";
            this.colEmployee_Name.FieldName = "Employee_Name";
            this.colEmployee_Name.Name = "colEmployee_Name";
            this.colEmployee_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_Name.Visible = true;
            this.colEmployee_Name.VisibleIndex = 1;
            // 
            // rpValPercent
            // 
            this.rpValPercent.AutoHeight = false;
            this.rpValPercent.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpValPercent.DisplayFormat.FormatString = "{0:##,##0.###} %";
            this.rpValPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rpValPercent.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpValPercent.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rpValPercent.Name = "rpValPercent";
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
            // eMPLOYEE_HeaderTableAdapter
            // 
            this.eMPLOYEE_HeaderTableAdapter.ClearBeforeFill = true;
            // 
            // buyDetailBindingSource
            // 
            this.buyDetailBindingSource.DataMember = "Buy_Detail";
            this.buyDetailBindingSource.DataSource = this.dsSaleQuantity;
            // 
            // buy_DetailTableAdapter
            // 
            this.buy_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // saleDetailBindingSource
            // 
            this.saleDetailBindingSource.DataMember = "Sale_Detail";
            this.saleDetailBindingSource.DataSource = this.dsSaleQuantity;
            // 
            // sale_DetailTableAdapter
            // 
            this.sale_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // XucSaleQuantityByEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XucSaleQuantityByEmp";
            this.Size = new System.Drawing.Size(941, 681);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Buy_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Sale_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpValPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpEmp;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name;
        private System.Windows.Forms.BindingSource eMPLOYEEHeaderBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleQuantity dsSaleQuantity;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList_Buy_Detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList_Sale_Detail;
        private Perfect.Sale.Core.Report.DS.dsSaleQuantityTableAdapters.EMPLOYEE_HeaderTableAdapter eMPLOYEE_HeaderTableAdapter;
        private System.Windows.Forms.BindingSource buyDetailBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleQuantityTableAdapters.Buy_DetailTableAdapter buy_DetailTableAdapter;
        private System.Windows.Forms.BindingSource saleDetailBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleQuantityTableAdapters.Sale_DetailTableAdapter sale_DetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colVatAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID3;
        private DevExpress.XtraGrid.Columns.GridColumn colVat1;
        private DevExpress.XtraGrid.Columns.GridColumn colVatAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate1;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name3;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colSumBuyAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSumSaleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCharge;
        private DevExpress.XtraGrid.Columns.GridColumn colCharge1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpValPercent;
    }
}