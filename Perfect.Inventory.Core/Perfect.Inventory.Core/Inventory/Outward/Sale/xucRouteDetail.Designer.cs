namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    partial class xucRouteDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucRouteDetail));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.sanLuongTuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK_OUTWARD_DETAIL = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAIL();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityConvert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitConvert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConvertValues = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sanLuongTuyenTableAdapter = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.SanLuongTuyenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanLuongTuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).BeginInit();
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
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lgDetail});
            this.layoutControl1.Controls.SetChildIndex(this.gcList, 0);
            // 
            // lgDetail
            // 
            this.lgDetail.Location = new System.Drawing.Point(0, 674);
            this.lgDetail.Size = new System.Drawing.Size(961, 1);
            this.lgDetail.TextVisible = false;
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sanLuongTuyenBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(957, 631);
            this.gcList.TabIndex = 42;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // sanLuongTuyenBindingSource
            // 
            this.sanLuongTuyenBindingSource.DataMember = "SanLuongTuyen";
            this.sanLuongTuyenBindingSource.DataSource = this.dsSTOCK_OUTWARD_DETAIL;
            // 
            // dsSTOCK_OUTWARD_DETAIL
            // 
            this.dsSTOCK_OUTWARD_DETAIL.DataSetName = "dsSTOCK_OUTWARD_DETAIL";
            this.dsSTOCK_OUTWARD_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit,
            this.colQuantity,
            this.colStock_Name,
            this.colRouteName,
            this.colGroupName,
            this.colQuantityConvert,
            this.colUnitConvert,
            this.colConvertValues,
            this.colTotalQuantity});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(765, 284, 216, 199);
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFormat = "[#image]{1} {2}";
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.colQuantity, "{0:##,##0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityConvert", this.colQuantityConvert, "{0:##,##0.##}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRouteName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.VisibleIndex = 0;
            this.colProduct_ID.Width = 144;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Tên hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 1;
            this.colProduct_Name.Width = 288;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colUnit.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUnit.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.colUnit.AppearanceCell.Options.UseBackColor = true;
            this.colUnit.AppearanceCell.Options.UseFont = true;
            this.colUnit.AppearanceCell.Options.UseForeColor = true;
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.Caption = "ĐVT";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 6;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.colQuantity.AppearanceCell.Options.UseBackColor = true;
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceCell.Options.UseForeColor = true;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 84;
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
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Kho";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 8;
            this.colStock_Name.Width = 141;
            // 
            // colRouteName
            // 
            this.colRouteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteName.Caption = "Tuyến";
            this.colRouteName.FieldName = "RouteName";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.OptionsColumn.ReadOnly = true;
            this.colRouteName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colGroupName
            // 
            this.colGroupName.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroupName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroupName.Caption = "Nhóm hàng";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.ReadOnly = true;
            this.colGroupName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 7;
            this.colGroupName.Width = 138;
            // 
            // colQuantityConvert
            // 
            this.colQuantityConvert.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colQuantityConvert.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQuantityConvert.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.colQuantityConvert.AppearanceCell.Options.UseBackColor = true;
            this.colQuantityConvert.AppearanceCell.Options.UseFont = true;
            this.colQuantityConvert.AppearanceCell.Options.UseForeColor = true;
            this.colQuantityConvert.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantityConvert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantityConvert.Caption = "Số lượng";
            this.colQuantityConvert.ColumnEdit = this.rpVal;
            this.colQuantityConvert.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQuantityConvert.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantityConvert.FieldName = "QuantityConvert";
            this.colQuantityConvert.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colQuantityConvert.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantityConvert.Name = "colQuantityConvert";
            this.colQuantityConvert.OptionsColumn.ReadOnly = true;
            this.colQuantityConvert.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantityConvert.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantityConvert.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantityConvert.Visible = true;
            this.colQuantityConvert.VisibleIndex = 3;
            this.colQuantityConvert.Width = 89;
            // 
            // colUnitConvert
            // 
            this.colUnitConvert.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colUnitConvert.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUnitConvert.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.colUnitConvert.AppearanceCell.Options.UseBackColor = true;
            this.colUnitConvert.AppearanceCell.Options.UseFont = true;
            this.colUnitConvert.AppearanceCell.Options.UseForeColor = true;
            this.colUnitConvert.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitConvert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitConvert.Caption = "ĐVT";
            this.colUnitConvert.FieldName = "UnitConvert";
            this.colUnitConvert.Name = "colUnitConvert";
            this.colUnitConvert.OptionsColumn.ReadOnly = true;
            this.colUnitConvert.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitConvert.Visible = true;
            this.colUnitConvert.VisibleIndex = 4;
            this.colUnitConvert.Width = 77;
            // 
            // colConvertValues
            // 
            this.colConvertValues.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colConvertValues.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colConvertValues.AppearanceCell.Options.UseFont = true;
            this.colConvertValues.AppearanceCell.Options.UseForeColor = true;
            this.colConvertValues.AppearanceHeader.Options.UseTextOptions = true;
            this.colConvertValues.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colConvertValues.Caption = "Quy cách";
            this.colConvertValues.ColumnEdit = this.rpVal;
            this.colConvertValues.FieldName = "ConvertValues";
            this.colConvertValues.Name = "colConvertValues";
            this.colConvertValues.OptionsColumn.ReadOnly = true;
            this.colConvertValues.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colConvertValues.Width = 87;
            // 
            // colTotalQuantity
            // 
            this.colTotalQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalQuantity.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colTotalQuantity.AppearanceCell.Options.UseFont = true;
            this.colTotalQuantity.AppearanceCell.Options.UseForeColor = true;
            this.colTotalQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalQuantity.Caption = "Tổng số lượng";
            this.colTotalQuantity.ColumnEdit = this.rpVal;
            this.colTotalQuantity.FieldName = "TotalQuantity";
            this.colTotalQuantity.Name = "colTotalQuantity";
            this.colTotalQuantity.Visible = true;
            this.colTotalQuantity.VisibleIndex = 2;
            this.colTotalQuantity.Width = 98;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 635);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // sanLuongTuyenTableAdapter
            // 
            this.sanLuongTuyenTableAdapter.ClearBeforeFill = true;
            // 
            // xucRouteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucRouteDetail";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanLuongTuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private System.Windows.Forms.BindingSource sanLuongTuyenBindingSource;
        private dsSTOCK_OUTWARD_DETAIL dsSTOCK_OUTWARD_DETAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.SanLuongTuyenTableAdapter sanLuongTuyenTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityConvert;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitConvert;
        private DevExpress.XtraGrid.Columns.GridColumn colConvertValues;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQuantity;
    }
}
