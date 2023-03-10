namespace Perfect.Dictionary
{
    partial class xucItemA
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
            if (_groupChanged != null) _groupChanged.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucItemA));
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.pRODUCTByFULLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Dictionary.Product.DS.dsPRODUCT();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpTxt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Type_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pRODUCTTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetail_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBonusAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThickness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pRODUCTByFULLTableAdapter = new Perfect.Dictionary.Product.DS.dsPRODUCTTableAdapters.PRODUCTByFULLTableAdapter();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.pRODUCTGROUPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCTGROUP = new Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUP();
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.pRODUCT_GROUPCTableAdapter = new Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUPTableAdapters.PRODUCT_GROUPCTableAdapter();
            this.colIndustry = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTByFULLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTGROUPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCTGROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // ucToolBar
            // 
            this.ucToolBar.Size = new System.Drawing.Size(694, 43);
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Còn Quản Lý";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.ReadOnly = true;
            this.colActive.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 87;
            // 
            // colActiveInt
            // 
            this.colActiveInt.AppearanceHeader.Options.UseTextOptions = true;
            this.colActiveInt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActiveInt.FieldName = "ActiveInt";
            this.colActiveInt.Name = "colActiveInt";
            this.colActiveInt.OptionsColumn.ReadOnly = true;
            this.colActiveInt.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.pRODUCTByFULLBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.Location = new System.Drawing.Point(0, 43);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal,
            this.rpTxt,
            this.rpType});
            this.gcList.Size = new System.Drawing.Size(694, 621);
            this.gcList.TabIndex = 2;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            this.gcList.Layout += new System.Windows.Forms.LayoutEventHandler(this.GcListLayout);
            // 
            // pRODUCTByFULLBindingSource
            // 
            this.pRODUCTByFULLBindingSource.DataMember = "PRODUCTByFULL";
            this.pRODUCTByFULLBindingSource.DataSource = this.dsPRODUCT;
            // 
            // dsPRODUCT
            // 
            this.dsPRODUCT.DataSetName = "dsPRODUCT";
            this.dsPRODUCT.EnforceConstraints = false;
            this.dsPRODUCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID,
            this.colProduct_Name,
            this.colQuantity,
            this.colProductGroup_Name,
            this.colOrg_Price,
            this.colProduct_Type_ID,
            this.colUnit_Name,
            this.colSale_Price,
            this.colMinStock,
            this.colMaxStock,
            this.colStock_Name,
            this.colRetail_Price,
            this.colActive,
            this.colActiveInt,
            this.colCurrentCost,
            this.colIsWeb,
            this.colProductBrand,
            this.colBonusAmount,
            this.colThickness,
            this.colIndustry});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1047, 499, 216, 199);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colActive;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFormat = "[#image]{1} {2}";
            this.gbList.GroupPanelText = "Kéo và Thả cột vào đây để nhóm dữ liệu";
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsLayout.StoreAllOptions = true;
            this.gbList.OptionsLayout.StoreAppearance = true;
            this.gbList.OptionsMenu.EnableColumnMenu = false;
            this.gbList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.RowAutoHeight = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductGroup_Name, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GbListKeyDown);
            this.gbList.Layout += new System.EventHandler(this.GbListLayout);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListDoubleClick);
            this.gbList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GbListRowCellClick);
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.ColumnEdit = this.rpTxt;
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.VisibleIndex = 0;
            this.colProduct_ID.Width = 112;
            // 
            // rpTxt
            // 
            this.rpTxt.AutoHeight = false;
            this.rpTxt.Name = "rpTxt";
            this.rpTxt.DoubleClick += new System.EventHandler(this.GbListDoubleClick);
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.ColumnEdit = this.rpTxt;
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 1;
            this.colProduct_Name.Width = 365;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
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
            this.rpVal.DoubleClick += new System.EventHandler(this.GbListDoubleClick);
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductGroup_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductGroup_Name.Caption = "Nhóm Hàng";
            this.colProductGroup_Name.ColumnEdit = this.rpTxt;
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.OptionsColumn.ReadOnly = true;
            this.colProductGroup_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProductGroup_Name.Width = 168;
            // 
            // colOrg_Price
            // 
            this.colOrg_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrg_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrg_Price.Caption = "Giá Mua";
            this.colOrg_Price.ColumnEdit = this.rpVal;
            this.colOrg_Price.FieldName = "Org_Price";
            this.colOrg_Price.Name = "colOrg_Price";
            this.colOrg_Price.OptionsColumn.ReadOnly = true;
            this.colOrg_Price.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOrg_Price.Visible = true;
            this.colOrg_Price.VisibleIndex = 6;
            // 
            // colProduct_Type_ID
            // 
            this.colProduct_Type_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Type_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Type_ID.Caption = "Tính Chất";
            this.colProduct_Type_ID.ColumnEdit = this.rpType;
            this.colProduct_Type_ID.FieldName = "Product_Type_ID";
            this.colProduct_Type_ID.Name = "colProduct_Type_ID";
            this.colProduct_Type_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_Type_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Type_ID.Visible = true;
            this.colProduct_Type_ID.VisibleIndex = 14;
            this.colProduct_Type_ID.Width = 121;
            // 
            // rpType
            // 
            this.rpType.AutoHeight = false;
            this.rpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpType.DataSource = this.pRODUCTTypeBindingSource;
            this.rpType.DisplayMember = "NAME";
            this.rpType.Name = "rpType";
            this.rpType.ValueMember = "ID";
            this.rpType.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // pRODUCTTypeBindingSource
            // 
            this.pRODUCTTypeBindingSource.DataMember = "PRODUCTType";
            this.pRODUCTTypeBindingSource.DataSource = this.dsPRODUCT;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.ColumnEdit = this.rpTxt;
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 5;
            this.colUnit_Name.Width = 57;
            // 
            // colSale_Price
            // 
            this.colSale_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.colSale_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSale_Price.Caption = "Giá Bán Sỉ";
            this.colSale_Price.ColumnEdit = this.rpVal;
            this.colSale_Price.FieldName = "Sale_Price";
            this.colSale_Price.Name = "colSale_Price";
            this.colSale_Price.OptionsColumn.ReadOnly = true;
            this.colSale_Price.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSale_Price.Visible = true;
            this.colSale_Price.VisibleIndex = 7;
            this.colSale_Price.Width = 87;
            // 
            // colMinStock
            // 
            this.colMinStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colMinStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMinStock.Caption = "Tối Thiểu";
            this.colMinStock.ColumnEdit = this.rpVal;
            this.colMinStock.FieldName = "MinStock";
            this.colMinStock.Name = "colMinStock";
            this.colMinStock.OptionsColumn.ReadOnly = true;
            this.colMinStock.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMinStock.Visible = true;
            this.colMinStock.VisibleIndex = 9;
            this.colMinStock.Width = 82;
            // 
            // colMaxStock
            // 
            this.colMaxStock.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaxStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaxStock.Caption = "Tối Đa";
            this.colMaxStock.ColumnEdit = this.rpVal;
            this.colMaxStock.FieldName = "MaxStock";
            this.colMaxStock.Name = "colMaxStock";
            this.colMaxStock.OptionsColumn.ReadOnly = true;
            this.colMaxStock.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Kho Mặc Định";
            this.colStock_Name.ColumnEdit = this.rpTxt;
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 15;
            this.colStock_Name.Width = 190;
            // 
            // colRetail_Price
            // 
            this.colRetail_Price.AppearanceHeader.Options.UseTextOptions = true;
            this.colRetail_Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRetail_Price.Caption = "Giá Bán Lẻ";
            this.colRetail_Price.ColumnEdit = this.rpVal;
            this.colRetail_Price.FieldName = "Retail_Price";
            this.colRetail_Price.Name = "colRetail_Price";
            this.colRetail_Price.OptionsColumn.ReadOnly = true;
            this.colRetail_Price.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRetail_Price.Visible = true;
            this.colRetail_Price.VisibleIndex = 8;
            // 
            // colCurrentCost
            // 
            this.colCurrentCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrentCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrentCost.Caption = "Trọng Lượng Riêng";
            this.colCurrentCost.ColumnEdit = this.rpVal;
            this.colCurrentCost.FieldName = "Depth";
            this.colCurrentCost.Name = "colCurrentCost";
            this.colCurrentCost.OptionsColumn.ReadOnly = true;
            this.colCurrentCost.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCurrentCost.Visible = true;
            this.colCurrentCost.VisibleIndex = 10;
            this.colCurrentCost.Width = 111;
            // 
            // colIsWeb
            // 
            this.colIsWeb.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsWeb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsWeb.Caption = "Hiển thị Website";
            this.colIsWeb.FieldName = "IsWeb";
            this.colIsWeb.Name = "colIsWeb";
            this.colIsWeb.OptionsColumn.ReadOnly = true;
            this.colIsWeb.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIsWeb.Visible = true;
            this.colIsWeb.VisibleIndex = 13;
            this.colIsWeb.Width = 101;
            // 
            // colProductBrand
            // 
            this.colProductBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductBrand.Caption = "Thương hiệu";
            this.colProductBrand.FieldName = "ProductBrand";
            this.colProductBrand.Name = "colProductBrand";
            this.colProductBrand.OptionsColumn.ReadOnly = true;
            this.colProductBrand.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProductBrand.Visible = true;
            this.colProductBrand.VisibleIndex = 3;
            this.colProductBrand.Width = 91;
            // 
            // colBonusAmount
            // 
            this.colBonusAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colBonusAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBonusAmount.Caption = "Hoa  hồng Sale (%)";
            this.colBonusAmount.ColumnEdit = this.rpVal;
            this.colBonusAmount.FieldName = "BonusAmount";
            this.colBonusAmount.Name = "colBonusAmount";
            this.colBonusAmount.OptionsColumn.ReadOnly = true;
            this.colBonusAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBonusAmount.Visible = true;
            this.colBonusAmount.VisibleIndex = 12;
            this.colBonusAmount.Width = 121;
            // 
            // colThickness
            // 
            this.colThickness.AppearanceHeader.Options.UseTextOptions = true;
            this.colThickness.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThickness.Caption = "Số khối";
            this.colThickness.ColumnEdit = this.rpVal;
            this.colThickness.FieldName = "Thickness";
            this.colThickness.Name = "colThickness";
            this.colThickness.OptionsColumn.ReadOnly = true;
            this.colThickness.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colThickness.Visible = true;
            this.colThickness.VisibleIndex = 11;
            // 
            // pRODUCTByFULLTableAdapter
            // 
            this.pRODUCTByFULLTableAdapter.ClearBeforeFill = true;
            // 
            // dm
            // 
            this.dm.DockModeVS2005FadeSpeed = 1000;
            this.dm.Form = this;
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // pRODUCTGROUPCBindingSource
            // 
            this.pRODUCTGROUPCBindingSource.DataMember = "PRODUCT_GROUPC";
            this.pRODUCTGROUPCBindingSource.DataSource = this.dsPRODUCTGROUP;
            // 
            // dsPRODUCTGROUP
            // 
            this.dsPRODUCTGROUP.DataSetName = "dsPRODUCTGROUP";
            this.dsPRODUCTGROUP.EnforceConstraints = false;
            this.dsPRODUCTGROUP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "Action_CloneMerge_Clone_Object_32x32.png");
            this.img.Images.SetKeyName(1, "Action_EditModel_32x32.png");
            this.img.Images.SetKeyName(2, "Action_Filter_32x32.png");
            this.img.Images.SetKeyName(3, "Action_SingleChoiceAction_32x32.png");
            this.img.Images.SetKeyName(4, "BO_Appointment_32x32.png");
            this.img.Images.SetKeyName(5, "BO_Category_32x32.png");
            this.img.Images.SetKeyName(6, "BO_Note_32x32.png");
            this.img.Images.SetKeyName(7, "BO_Order_Item_32x32.png");
            this.img.Images.SetKeyName(8, "BO_Organization_32x32.png");
            this.img.Images.SetKeyName(9, "BO_Product_32x32.png");
            // 
            // pRODUCT_GROUPCTableAdapter
            // 
            this.pRODUCT_GROUPCTableAdapter.ClearBeforeFill = true;
            // 
            // colIndustry
            // 
            this.colIndustry.AppearanceHeader.Options.UseTextOptions = true;
            this.colIndustry.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIndustry.Caption = "Ngành hàng";
            this.colIndustry.FieldName = "Industry";
            this.colIndustry.Name = "colIndustry";
            this.colIndustry.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIndustry.Visible = true;
            this.colIndustry.VisibleIndex = 4;
            this.colIndustry.Width = 93;
            // 
            // xucItemA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcList);
            this.Name = "xucItemA";
            this.Size = new System.Drawing.Size(694, 664);
            this.Controls.SetChildIndex(this.ucToolBar, 0);
            this.Controls.SetChildIndex(this.gcList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTByFULLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTGROUPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCTGROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private System.Windows.Forms.BindingSource pRODUCTByFULLBindingSource;
        private Perfect.Dictionary.Product.DS.dsPRODUCT dsPRODUCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Type_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSale_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStock;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxStock;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup_Name;
        private Perfect.Dictionary.Product.DS.dsPRODUCTTableAdapters.PRODUCTByFULLTableAdapter pRODUCTByFULLTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rpTxt;
        private System.Windows.Forms.BindingSource pRODUCTTypeBindingSource;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.Utils.ImageCollection img;
        private System.Windows.Forms.BindingSource pRODUCTGROUPCBindingSource;
        private Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUP dsPRODUCTGROUP;
        private Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUPTableAdapters.PRODUCT_GROUPCTableAdapter pRODUCT_GROUPCTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colRetail_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentCost;
        private DevExpress.XtraGrid.Columns.GridColumn colIsWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colProductBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colBonusAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colThickness;
        private DevExpress.XtraGrid.Columns.GridColumn colIndustry;

    }
}
