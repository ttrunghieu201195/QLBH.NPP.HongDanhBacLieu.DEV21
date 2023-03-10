namespace Perfect.Inventory.Core.Inventory.Inward
{
    partial class xucDetailListA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucDetailListA));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.sTOCKINWARDDETAILByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK_INWARD_DETAIL = new Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAIL();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptxt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colRefDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colProduct_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWidth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rEFTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsREFTYPE = new Perfect.Inventory.Core.Common.DS.dsREFTYPE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colOrgin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINWARDDETAILByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_INWARD_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREFTYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lgDetail});
            this.layoutControl1.Controls.SetChildIndex(this.gcList, 0);
            // 
            // lgDetail
            // 
            this.lgDetail.Location = new System.Drawing.Point(0, 624);
            this.lgDetail.Size = new System.Drawing.Size(961, 51);
            this.lgDetail.TextVisible = false;
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Location = new System.Drawing.Point(0, 36);
            this.lgList.Size = new System.Drawing.Size(961, 588);
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sTOCKINWARDDETAILByDateBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 38);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpStock,
            this.rpType,
            this.rpVal,
            this.rpDate,
            this.rptxt});
            this.gcList.Size = new System.Drawing.Size(957, 584);
            this.gcList.TabIndex = 42;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // sTOCKINWARDDETAILByDateBindingSource
            // 
            this.sTOCKINWARDDETAILByDateBindingSource.DataMember = "STOCK_INWARD_DETAIL_ByDate";
            this.sTOCKINWARDDETAILByDateBindingSource.DataSource = this.dsSTOCK_INWARD_DETAIL;
            // 
            // dsSTOCK_INWARD_DETAIL
            // 
            this.dsSTOCK_INWARD_DETAIL.DataSetName = "dsSTOCK_INWARD_DETAIL";
            this.dsSTOCK_INWARD_DETAIL.EnforceConstraints = false;
            this.dsSTOCK_INWARD_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRefDate,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit_Name,
            this.colQuantity,
            this.colAmount,
            this.colUnitPrice,
            this.colProductGroup_Name,
            this.colStock_Name,
            this.colStock_ID,
            this.colRefType,
            this.colProduct_Group_ID,
            this.colCustomerName,
            this.colHeight,
            this.colWidth,
            this.colOrgin,
            this.colDiscount,
            this.colDiscountRate});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", this.colAmount, "{0:##,##0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Discount", this.colDiscount, "{0:##,##0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Width", this.colWidth, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.colQuantity, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.gbList_Click);
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Phiếu NK";
            this.colID.ColumnEdit = this.rptxt;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 152;
            // 
            // rptxt
            // 
            this.rptxt.AutoHeight = false;
            this.rptxt.Name = "rptxt";
            this.rptxt.DoubleClick += new System.EventHandler(this.gbList_Click);
            // 
            // colRefDate
            // 
            this.colRefDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.ColumnEdit = this.rpDate;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate.Visible = true;
            this.colRefDate.VisibleIndex = 1;
            this.colRefDate.Width = 94;
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
            this.rpDate.Mask.EditMask = "dd/MM/yyyy";
            this.rpDate.Name = "rpDate";
            this.rpDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            this.colProduct_ID.VisibleIndex = 3;
            this.colProduct_ID.Width = 132;
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
            this.colProduct_Name.VisibleIndex = 4;
            this.colProduct_Name.Width = 236;
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
            this.colUnit_Name.VisibleIndex = 5;
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
            this.colQuantity.Width = 89;
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
            // colAmount
            // 
            this.colAmount.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.colAmount.AppearanceCell.Options.UseBackColor = true;
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 10;
            this.colAmount.Width = 121;
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
            this.colUnitPrice.Width = 104;
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductGroup_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductGroup_Name.Caption = "Tên Nhóm";
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProductGroup_Name.OptionsColumn.ReadOnly = true;
            this.colProductGroup_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Tên Kho";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            // colRefType
            // 
            this.colRefType.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefType.FieldName = "RefType";
            this.colRefType.Name = "colRefType";
            this.colRefType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefType.OptionsColumn.ReadOnly = true;
            this.colRefType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colProduct_Group_ID
            // 
            this.colProduct_Group_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Group_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Group_ID.Caption = "Mã Nhóm";
            this.colProduct_Group_ID.FieldName = "Product_Group_ID";
            this.colProduct_Group_ID.Name = "colProduct_Group_ID";
            this.colProduct_Group_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Group_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_Group_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "Nhà Cung Cấp";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 209;
            // 
            // colHeight
            // 
            this.colHeight.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeight.Caption = "Trọng Lượng";
            this.colHeight.ColumnEdit = this.rpVal;
            this.colHeight.FieldName = "Height";
            this.colHeight.Name = "colHeight";
            this.colHeight.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colHeight.OptionsColumn.ReadOnly = true;
            this.colHeight.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHeight.Visible = true;
            this.colHeight.VisibleIndex = 11;
            this.colHeight.Width = 96;
            // 
            // colWidth
            // 
            this.colWidth.AppearanceHeader.Options.UseTextOptions = true;
            this.colWidth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWidth.Caption = "Tổng Trọng Lượng";
            this.colWidth.ColumnEdit = this.rpVal;
            this.colWidth.FieldName = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWidth.OptionsColumn.ReadOnly = true;
            this.colWidth.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colWidth.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colWidth.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colWidth.Visible = true;
            this.colWidth.VisibleIndex = 12;
            this.colWidth.Width = 125;
            // 
            // rpStock
            // 
            this.rpStock.AutoHeight = false;
            this.rpStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpStock.DataSource = this.sTOCKBindingSource;
            this.rpStock.DisplayMember = "Stock_Name";
            this.rpStock.Name = "rpStock";
            this.rpStock.NullText = "";
            this.rpStock.ValueMember = "Stock_ID";
            this.rpStock.View = this.repositoryItemGridLookUpEdit1View;
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
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // rpType
            // 
            this.rpType.AutoHeight = false;
            this.rpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpType.DataSource = this.rEFTYPEBindingSource;
            this.rpType.DisplayMember = "NAME";
            this.rpType.Name = "rpType";
            this.rpType.NullText = "";
            this.rpType.ValueMember = "ID";
            this.rpType.View = this.gridView1;
            // 
            // rEFTYPEBindingSource
            // 
            this.rEFTYPEBindingSource.DataMember = "REFTYPE";
            this.rEFTYPEBindingSource.DataSource = this.dsREFTYPE;
            // 
            // dsREFTYPE
            // 
            this.dsREFTYPE.DataSetName = "dsREFTYPE";
            this.dsREFTYPE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 588);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // colOrgin
            // 
            this.colOrgin.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrgin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrgin.Caption = "Ghi chú";
            this.colOrgin.FieldName = "Orgin";
            this.colOrgin.Name = "colOrgin";
            this.colOrgin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOrgin.OptionsColumn.ReadOnly = true;
            this.colOrgin.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOrgin.Visible = true;
            this.colOrgin.VisibleIndex = 13;
            // 
            // colDiscount
            // 
            this.colDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscount.Caption = "Chiết khấu";
            this.colDiscount.ColumnEdit = this.rpVal;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colDiscount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscount.OptionsColumn.ReadOnly = true;
            this.colDiscount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiscount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 9;
            this.colDiscount.Width = 123;
            // 
            // colDiscountRate
            // 
            this.colDiscountRate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscountRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscountRate.Caption = "CK (%)";
            this.colDiscountRate.ColumnEdit = this.rpVal;
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            this.colDiscountRate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscountRate.OptionsColumn.ReadOnly = true;
            this.colDiscountRate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDiscountRate.Visible = true;
            this.colDiscountRate.VisibleIndex = 8;
            this.colDiscountRate.Width = 104;
            // 
            // xucDetailListA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucDetailListA";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINWARDDETAILByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_INWARD_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREFTYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private Perfect.Inventory.Core.Common.DS.dsSTOCK dsSTOCK;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAIL dsSTOCK_INWARD_DETAIL;
        private System.Windows.Forms.BindingSource rEFTYPEBindingSource;
        private Perfect.Inventory.Core.Common.DS.dsREFTYPE dsREFTYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rptxt;
        private System.Windows.Forms.BindingSource sTOCKINWARDDETAILByDateBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRefType;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Group_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colHeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWidth;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgin;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
    }
}