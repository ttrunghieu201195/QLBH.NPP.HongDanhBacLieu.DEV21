using Perfect.Inventory.Core.Inventory.Inward;

namespace Perfect.Inventory.Core.Inventory.Init.Standard
{
    partial class XucInitInwardListA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucInitInwardListA));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.sTOCKINWARDGetByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInit02 = new Perfect.Inventory.Core.Inventory.Init.Ds.dsInit02();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptxt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colRefDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colStock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rEFTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sTOCK_INWARD_GetByDateTableAdapter = new Perfect.Inventory.Core.Inventory.Init.Ds.dsInit02TableAdapters.STOCK_INWARD_GetByDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINWARDGetByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInit02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.lgDetail.Location = new System.Drawing.Point(0, 649);
            this.lgDetail.Size = new System.Drawing.Size(961, 26);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(961, 610);
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sTOCKINWARDGetByDateBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpStock,
            this.rpType,
            this.rpVal,
            this.rpDate,
            this.rptxt});
            this.gcList.Size = new System.Drawing.Size(957, 606);
            this.gcList.TabIndex = 42;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // sTOCKINWARDGetByDateBindingSource
            // 
            this.sTOCKINWARDGetByDateBindingSource.DataMember = "STOCK_INWARD_GetByDate";
            this.sTOCKINWARDGetByDateBindingSource.DataSource = this.dsInit02;
            // 
            // dsInit02
            // 
            this.dsInit02.DataSetName = "dsInit02";
            this.dsInit02.EnforceConstraints = false;
            this.dsInit02.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRefDate,
            this.colStock_ID,
            this.colCustomer_ID,
            this.colStock_Name,
            this.colCustomerName,
            this.colCustomerAddress,
            this.colAmount,
            this.colDescription,
            this.colRefType});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1055, 491, 216, 199);
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", null, "=Thành Tiền :{0:##,##0.##}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.NewItemRowText = "Gỏ vào đây để tìm kiếm";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRefDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colID
            // 
            this.colID.Caption = "Chứng Từ";
            this.colID.ColumnEdit = this.rptxt;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 167;
            // 
            // rptxt
            // 
            this.rptxt.AutoHeight = false;
            this.rptxt.Name = "rptxt";
            this.rptxt.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colRefDate
            // 
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.ColumnEdit = this.rpDate;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.AllowEdit = false;
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate.Visible = true;
            this.colRefDate.VisibleIndex = 1;
            this.colRefDate.Width = 249;
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
            // colStock_ID
            // 
            this.colStock_ID.Caption = "Kho Hàng";
            this.colStock_ID.ColumnEdit = this.rpStock;
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.dsSTOCK.EnforceConstraints = false;
            this.dsSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.Caption = "Mã Khách Hàng";
            this.colCustomer_ID.ColumnEdit = this.rptxt;
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.ColumnEdit = this.rptxt;
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Khách Hàng";
            this.colCustomerName.ColumnEdit = this.rptxt;
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Width = 235;
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.Caption = "Địa Chỉ";
            this.colCustomerAddress.ColumnEdit = this.rptxt;
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerAddress.Width = 223;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Số Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 240;
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
            // colDescription
            // 
            this.colDescription.Caption = "Diễn Giải";
            this.colDescription.ColumnEdit = this.rptxt;
            this.colDescription.FieldName = "DESCRIPTION";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 211;
            // 
            // colRefType
            // 
            this.colRefType.Caption = "Loại";
            this.colRefType.ColumnEdit = this.rpType;
            this.colRefType.FieldName = "RefType";
            this.colRefType.Name = "colRefType";
            this.colRefType.OptionsColumn.ReadOnly = true;
            this.colRefType.Width = 139;
            // 
            // rpType
            // 
            this.rpType.AutoHeight = false;
            this.rpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpType.DataSource = this.rEFTYPEBindingSource;
            this.rpType.DisplayMember = "Name";
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 610);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(961, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // sTOCK_INWARD_GetByDateTableAdapter
            // 
            this.sTOCK_INWARD_GetByDateTableAdapter.ClearBeforeFill = true;
            // 
            // XucInitInwardListA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XucInitInwardListA";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINWARDGetByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInit02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private Perfect.Inventory.Core.Common.DS.dsSTOCK dsSTOCK;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rptxt;
        private System.Windows.Forms.BindingSource sTOCKINWARDGetByDateBindingSource;
        private Perfect.Inventory.Core.Inventory.Init.Ds.dsInit02 dsInit02;
        private Perfect.Inventory.Core.Inventory.Init.Ds.dsInit02TableAdapters.STOCK_INWARD_GetByDateTableAdapter sTOCK_INWARD_GetByDateTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRefType;
        private System.Windows.Forms.BindingSource rEFTYPEBindingSource;
    }
}