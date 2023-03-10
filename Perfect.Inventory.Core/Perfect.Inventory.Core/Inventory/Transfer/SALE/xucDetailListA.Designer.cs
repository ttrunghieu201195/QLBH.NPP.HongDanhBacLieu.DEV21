namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    partial class XucDetailListA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucDetailListA));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.tRANSFERDETAILByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTRANSFER_DETAIL = new Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAIL();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptxt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransfer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rEFTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsREFTYPE = new Perfect.Inventory.Core.Common.DS.dsREFTYPE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tRANSFER_DETAIL_ByDateTableAdapter = new Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters.TRANSFER_DETAIL_ByDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSFERDETAILByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRANSFER_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREFTYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
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
            this.layoutControl1.Controls.SetChildIndex(this.gcList, 0);
            // 
            // lgDetail
            // 
            this.lgDetail.Location = new System.Drawing.Point(0, 660);
            this.lgDetail.Size = new System.Drawing.Size(961, 15);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(961, 621);
            // 
            // gcList
            // 
            this.gcList.DataSource = this.tRANSFERDETAILByDateBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpStock,
            this.rpType,
            this.rpVal,
            this.rpDate,
            this.rptxt});
            this.gcList.Size = new System.Drawing.Size(957, 617);
            this.gcList.TabIndex = 44;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // tRANSFERDETAILByDateBindingSource
            // 
            this.tRANSFERDETAILByDateBindingSource.DataMember = "TRANSFER_DETAIL_ByDate";
            this.tRANSFERDETAILByDateBindingSource.DataSource = this.dsTRANSFER_DETAIL;
            // 
            // dsTRANSFER_DETAIL
            // 
            this.dsTRANSFER_DETAIL.DataSetName = "dsTRANSFER_DETAIL";
            this.dsTRANSFER_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnitPrice,
            this.colQuantity,
            this.colAmount,
            this.colTransfer_ID,
            this.colRefType,
            this.colUnit_Name,
            this.colInStock_Name,
            this.colOutStock_Name,
            this.colRefDate});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", null, "{0:##,##0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Amount", this.colRefDate, "{0:##,##0.##}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.AllowCellMerge = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTransfer_ID, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.ColumnEdit = this.rptxt;
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.VisibleIndex = 4;
            this.colProduct_ID.Width = 120;
            // 
            // rptxt
            // 
            this.rptxt.AutoHeight = false;
            this.rptxt.Name = "rptxt";
            this.rptxt.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.ColumnEdit = this.rptxt;
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 5;
            this.colProduct_Name.Width = 232;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Đơn Giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 8;
            this.colUnitPrice.Width = 81;
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
            this.rpVal.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colQuantity
            // 
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
            this.colQuantity.VisibleIndex = 7;
            this.colQuantity.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.colAmount.AppearanceCell.Options.UseBackColor = true;
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
            this.colAmount.VisibleIndex = 9;
            this.colAmount.Width = 115;
            // 
            // colTransfer_ID
            // 
            this.colTransfer_ID.Caption = "Chứng Từ";
            this.colTransfer_ID.ColumnEdit = this.rptxt;
            this.colTransfer_ID.FieldName = "Transfer_ID";
            this.colTransfer_ID.Name = "colTransfer_ID";
            this.colTransfer_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTransfer_ID.OptionsColumn.ReadOnly = true;
            this.colTransfer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTransfer_ID.Visible = true;
            this.colTransfer_ID.VisibleIndex = 0;
            this.colTransfer_ID.Width = 110;
            // 
            // colRefType
            // 
            this.colRefType.Caption = "Loại";
            this.colRefType.ColumnEdit = this.rpType;
            this.colRefType.FieldName = "RefType";
            this.colRefType.Name = "colRefType";
            this.colRefType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRefType.OptionsColumn.ReadOnly = true;
            this.colRefType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.rpType.DoubleClick += new System.EventHandler(this.GbListClick);
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
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.ColumnEdit = this.rptxt;
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit_Name.OptionsColumn.ReadOnly = true;
            this.colUnit_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 6;
            // 
            // colInStock_Name
            // 
            this.colInStock_Name.Caption = "Đến Kho";
            this.colInStock_Name.ColumnEdit = this.rptxt;
            this.colInStock_Name.FieldName = "InStock_Name";
            this.colInStock_Name.Name = "colInStock_Name";
            this.colInStock_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colInStock_Name.OptionsColumn.ReadOnly = true;
            this.colInStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInStock_Name.Visible = true;
            this.colInStock_Name.VisibleIndex = 3;
            this.colInStock_Name.Width = 185;
            // 
            // colOutStock_Name
            // 
            this.colOutStock_Name.Caption = "Từ Kho";
            this.colOutStock_Name.ColumnEdit = this.rptxt;
            this.colOutStock_Name.FieldName = "OutStock_Name";
            this.colOutStock_Name.Name = "colOutStock_Name";
            this.colOutStock_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOutStock_Name.OptionsColumn.ReadOnly = true;
            this.colOutStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutStock_Name.Visible = true;
            this.colOutStock_Name.VisibleIndex = 2;
            this.colOutStock_Name.Width = 180;
            // 
            // colRefDate
            // 
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.ColumnEdit = this.rpDate;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRefDate.Visible = true;
            this.colRefDate.VisibleIndex = 1;
            this.colRefDate.Width = 100;
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
            this.rpDate.DoubleClick += new System.EventHandler(this.GbListClick);
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
            this.rpStock.DoubleClick += new System.EventHandler(this.GbListClick);
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 621);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // tRANSFER_DETAIL_ByDateTableAdapter
            // 
            this.tRANSFER_DETAIL_ByDateTableAdapter.ClearBeforeFill = true;
            // 
            // XucDetailListA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XucDetailListA";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSFERDETAILByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRANSFER_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREFTYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rptxt;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private Perfect.Inventory.Core.Common.DS.dsSTOCK dsSTOCK;
        private System.Windows.Forms.BindingSource rEFTYPEBindingSource;
        private Perfect.Inventory.Core.Common.DS.dsREFTYPE dsREFTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTransfer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRefType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colInStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colOutStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRefDate;
        private System.Windows.Forms.BindingSource tRANSFERDETAILByDateBindingSource;
        private Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAIL dsTRANSFER_DETAIL;
        private Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters.TRANSFER_DETAIL_ByDateTableAdapter tRANSFER_DETAIL_ByDateTableAdapter;
    }
}
