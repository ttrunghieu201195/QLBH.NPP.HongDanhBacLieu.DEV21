namespace Perfect.Sale.Core.Report.control
{
    partial class XucSaleAmountByProvince
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucSaleAmountByProvince));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.sALESaleAmountByProvinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaleAmountByProvince = new Perfect.Sale.Core.Report.DS.dsSaleAmountByProvince();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer_Group_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rEFTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsREFTYPE = new Perfect.Sale.Core.Common.DS.dsREFTYPE();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rptxt = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sALE_SaleAmountByProvinceTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleAmountByProvinceTableAdapters.SALE_SaleAmountByProvinceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESaleAmountByProvinceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleAmountByProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREFTYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).BeginInit();
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
            this.lgDetail.Location = new System.Drawing.Point(0, 651);
            this.lgDetail.Size = new System.Drawing.Size(961, 24);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(961, 612);
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sALESaleAmountByProvinceBindingSource;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.EmbeddedNavigator.TextStringFormat = "Dòng {0} / {1}";
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpStock,
            this.rpType,
            this.rpVal,
            this.rpDate,
            this.rptxt});
            this.gcList.Size = new System.Drawing.Size(957, 608);
            this.gcList.TabIndex = 42;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // sALESaleAmountByProvinceBindingSource
            // 
            this.sALESaleAmountByProvinceBindingSource.DataMember = "SALE_SaleAmountByProvince";
            this.sALESaleAmountByProvinceBindingSource.DataSource = this.dsSaleAmountByProvince;
            // 
            // dsSaleAmountByProvince
            // 
            this.dsSaleAmountByProvince.DataSetName = "dsSaleAmountByProvince";
            this.dsSaleAmountByProvince.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer_Group_ID,
            this.colSalesAmount,
            this.colCustomer_Group_Name});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1055, 626, 216, 199);
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupFormat = "{0}: [#image]  {1}  - Doanh Số: {2}";
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colCustomer_Group_ID
            // 
            this.colCustomer_Group_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_Group_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_Group_ID.Caption = "Mã KV";
            this.colCustomer_Group_ID.FieldName = "Customer_Group_ID";
            this.colCustomer_Group_ID.Name = "colCustomer_Group_ID";
            this.colCustomer_Group_ID.OptionsColumn.AllowEdit = false;
            this.colCustomer_Group_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_Group_ID.Visible = true;
            this.colCustomer_Group_ID.VisibleIndex = 0;
            this.colCustomer_Group_ID.Width = 131;
            // 
            // colSalesAmount
            // 
            this.colSalesAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesAmount.Caption = "Tổng Doanh Thu";
            this.colSalesAmount.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colSalesAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSalesAmount.FieldName = "SalesAmount";
            this.colSalesAmount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colSalesAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSalesAmount.Name = "colSalesAmount";
            this.colSalesAmount.OptionsColumn.AllowEdit = false;
            this.colSalesAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSalesAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colSalesAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSalesAmount.Visible = true;
            this.colSalesAmount.VisibleIndex = 2;
            this.colSalesAmount.Width = 171;
            // 
            // colCustomer_Group_Name
            // 
            this.colCustomer_Group_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_Group_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_Group_Name.Caption = "Khu Vực";
            this.colCustomer_Group_Name.FieldName = "Customer_Group_Name";
            this.colCustomer_Group_Name.Name = "colCustomer_Group_Name";
            this.colCustomer_Group_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_Group_Name.Visible = true;
            this.colCustomer_Group_Name.VisibleIndex = 1;
            this.colCustomer_Group_Name.Width = 211;
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
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 612);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(961, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // sALE_SaleAmountByProvinceTableAdapter
            // 
            this.sALE_SaleAmountByProvinceTableAdapter.ClearBeforeFill = true;
            // 
            // xucSaleAmountByProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XucSaleAmountByProvince";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESaleAmountByProvinceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleAmountByProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEFTYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsREFTYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rptxt;
        private System.Windows.Forms.BindingSource rEFTYPEBindingSource;
        private Perfect.Sale.Core.Common.DS.dsREFTYPE dsREFTYPE;
        private System.Windows.Forms.BindingSource sALESaleAmountByProvinceBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByProvince dsSaleAmountByProvince;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_ID;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByProvinceTableAdapters.SALE_SaleAmountByProvinceTableAdapter sALE_SaleAmountByProvinceTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_Name;
    }
}