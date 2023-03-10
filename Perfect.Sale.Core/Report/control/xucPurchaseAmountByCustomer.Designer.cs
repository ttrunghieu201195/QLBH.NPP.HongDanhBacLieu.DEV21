namespace Perfect.Sale.Core.Report.control
{
    partial class XucPurchaseAmountByCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucPurchaseAmountByCustomer));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gbList_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDiscountRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.buyByProviderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaleAmountByCustomer = new Perfect.Sale.Core.Report.DS.dsSaleAmountByCustomer();
            this.gbList_Header = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rptxt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buy_By_Provider_HeaderTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleAmountByCustomerTableAdapters.Buy_By_Provider_HeaderTableAdapter();
            this.buyByProviderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_By_Provider_DetailTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleAmountByCustomerTableAdapters.Buy_By_Provider_DetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyByProviderHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleAmountByCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyByProviderDetailBindingSource)).BeginInit();
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
            // lgDetail
            // 
            this.lgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.lgDetail.Location = new System.Drawing.Point(0, 645);
            this.lgDetail.Size = new System.Drawing.Size(961, 30);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(961, 606);
            // 
            // gbList_Detail
            // 
            this.gbList_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRefDate,
            this.colCustomer_ID1,
            this.colVat,
            this.colVatAmount,
            this.colAmount,
            this.colDiscountRate,
            this.colDiscount});
            this.gbList_Detail.CustomizationFormBounds = new System.Drawing.Rectangle(931, 271, 216, 199);
            this.gbList_Detail.GridControl = this.gcList;
            this.gbList_Detail.Name = "gbList_Detail";
            this.gbList_Detail.OptionsView.ShowAutoFilterRow = true;
            this.gbList_Detail.OptionsView.ShowFooter = true;
            this.gbList_Detail.OptionsView.ShowGroupPanel = false;
            this.gbList_Detail.ViewCaption = "Danh Sách Chứng Từ";
            // 
            // colID
            // 
            this.colID.Caption = "Chứng Từ";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colRefDate
            // 
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.Visible = true;
            this.colRefDate.VisibleIndex = 1;
            // 
            // colCustomer_ID1
            // 
            this.colCustomer_ID1.Caption = "Mã Nhà Phân Phối";
            this.colCustomer_ID1.FieldName = "Customer_ID";
            this.colCustomer_ID1.Name = "colCustomer_ID1";
            // 
            // colVat
            // 
            this.colVat.Caption = "VAT %";
            this.colVat.FieldName = "Vat";
            this.colVat.Name = "colVat";
            // 
            // colVatAmount
            // 
            this.colVatAmount.Caption = "VAT";
            this.colVatAmount.FieldName = "VatAmount";
            this.colVatAmount.Name = "colVatAmount";
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
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
            this.colDiscountRate.Caption = "Chiết Khấu %";
            this.colDiscountRate.FieldName = "DiscountRate";
            this.colDiscountRate.Name = "colDiscountRate";
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Chiết Khấu";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            // 
            // gcList
            // 
            this.gcList.DataSource = this.buyByProviderHeaderBindingSource;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.EmbeddedNavigator.TextStringFormat = "Dòng {0} / {1}";
            gridLevelNode1.LevelTemplate = this.gbList_Detail;
            gridLevelNode1.RelationName = "Buy_By_Provider_Header_Buy_By_Provider_Detail";
            this.gcList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList_Header;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpStock,
            this.rpType,
            this.rpVal,
            this.rpDate,
            this.rptxt});
            this.gcList.Size = new System.Drawing.Size(957, 602);
            this.gcList.TabIndex = 42;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList_Header,
            this.gbList_Detail});
            // 
            // buyByProviderHeaderBindingSource
            // 
            this.buyByProviderHeaderBindingSource.DataMember = "Buy_By_Provider_Header";
            this.buyByProviderHeaderBindingSource.DataSource = this.dsSaleAmountByCustomer;
            // 
            // dsSaleAmountByCustomer
            // 
            this.dsSaleAmountByCustomer.DataSetName = "dsSaleAmountByCustomer";
            this.dsSaleAmountByCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList_Header
            // 
            this.gbList_Header.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList_Header.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList_Header.Appearance.GroupRow.Options.UseFont = true;
            this.gbList_Header.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList_Header.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer_ID,
            this.colCustomerName,
            this.colCustomer_Group_ID,
            this.colCustomer_Group_Name,
            this.colTotalAmount});
            this.gbList_Header.CustomizationFormBounds = new System.Drawing.Rectangle(392, 292, 216, 199);
            this.gbList_Header.GridControl = this.gcList;
            this.gbList_Header.GroupCount = 1;
            this.gbList_Header.GroupFormat = "[#image]{1}";
            this.gbList_Header.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList_Header.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PurchaseAmount", null, "{0:##,##0.##}")});
            this.gbList_Header.IndicatorWidth = 40;
            this.gbList_Header.Name = "gbList_Header";
            this.gbList_Header.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList_Header.OptionsPrint.ExpandAllDetails = true;
            this.gbList_Header.OptionsPrint.PrintDetails = true;
            this.gbList_Header.OptionsView.ColumnAutoWidth = false;
            this.gbList_Header.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList_Header.OptionsView.ShowAutoFilterRow = true;
            this.gbList_Header.OptionsView.ShowFooter = true;
            this.gbList_Header.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_Group_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList_Header.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList_Header.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.Caption = "Mã NCC";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsColumn.ReadOnly = true;
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 0;
            this.colCustomer_ID.Width = 149;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Nhà Cung Cấp";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 221;
            // 
            // colCustomer_Group_ID
            // 
            this.colCustomer_Group_ID.Caption = "Mã Khu Vực";
            this.colCustomer_Group_ID.FieldName = "Customer_Group_ID";
            this.colCustomer_Group_ID.Name = "colCustomer_Group_ID";
            this.colCustomer_Group_ID.OptionsColumn.ReadOnly = true;
            this.colCustomer_Group_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colCustomer_Group_Name
            // 
            this.colCustomer_Group_Name.Caption = "Khu Vực";
            this.colCustomer_Group_Name.FieldName = "Customer_Group_Name";
            this.colCustomer_Group_Name.Name = "colCustomer_Group_Name";
            this.colCustomer_Group_Name.OptionsColumn.ReadOnly = true;
            this.colCustomer_Group_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_Group_Name.Visible = true;
            this.colCustomer_Group_Name.VisibleIndex = 2;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Tổng Chi Phí";
            this.colTotalAmount.ColumnEdit = this.rpVal;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.ReadOnly = true;
            this.colTotalAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTotalAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colTotalAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 2;
            this.colTotalAmount.Width = 203;
            // 
            // rpStock
            // 
            this.rpStock.AutoHeight = false;
            this.rpStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpStock.DisplayMember = "Stock_Name";
            this.rpStock.Name = "rpStock";
            this.rpStock.NullText = "";
            this.rpStock.ValueMember = "Stock_ID";
            this.rpStock.View = this.repositoryItemGridLookUpEdit1View;
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
            this.rpType.DisplayMember = "NAME";
            this.rpType.Name = "rpType";
            this.rpType.NullText = "";
            this.rpType.ValueMember = "ID";
            this.rpType.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // rptxt
            // 
            this.rptxt.AutoHeight = false;
            this.rptxt.Name = "rptxt";
            this.rptxt.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 606);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(961, 30);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // buy_By_Provider_HeaderTableAdapter
            // 
            this.buy_By_Provider_HeaderTableAdapter.ClearBeforeFill = true;
            // 
            // buyByProviderDetailBindingSource
            // 
            this.buyByProviderDetailBindingSource.DataMember = "Buy_By_Provider_Detail";
            this.buyByProviderDetailBindingSource.DataSource = this.dsSaleAmountByCustomer;
            // 
            // buy_By_Provider_DetailTableAdapter
            // 
            this.buy_By_Provider_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // XucPurchaseAmountByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XucPurchaseAmountByCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyByProviderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleAmountByCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyByProviderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList_Header;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rptxt;
        private System.Windows.Forms.BindingSource buyByProviderHeaderBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByCustomer dsSaleAmountByCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList_Detail;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByCustomerTableAdapters.Buy_By_Provider_HeaderTableAdapter buy_By_Provider_HeaderTableAdapter;
        private System.Windows.Forms.BindingSource buyByProviderDetailBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByCustomerTableAdapters.Buy_By_Provider_DetailTableAdapter buy_By_Provider_DetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colVatAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
    }
}