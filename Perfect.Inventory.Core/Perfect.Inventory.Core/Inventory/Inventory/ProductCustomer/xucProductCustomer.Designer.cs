using Perfect.Inventory.Core.Common.DS;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    partial class xucProductCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucProductCustomer));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.pRODUCTCUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCTCUSTOMER = new Perfect.Inventory.Core.Inventory.Inventory.ProductCustomer.DS.dsPRODUCTCUSTOMER();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCustomer_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCost = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plMain = new DevExpress.XtraEditors.PanelControl();
            this.pRODUCTCUSTOMERTableAdapter = new Perfect.Inventory.Core.Inventory.Inventory.ProductCustomer.DS.dsPRODUCTCUSTOMERTableAdapters.PRODUCTCUSTOMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCTCUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Size = new System.Drawing.Size(806, 57);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 96;
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
            this.gcList.DataSource = this.pRODUCTCUSTOMERBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpUnit,
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(802, 516);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList,
            this.gridView2});
            // 
            // pRODUCTCUSTOMERBindingSource
            // 
            this.pRODUCTCUSTOMERBindingSource.DataMember = "PRODUCTCUSTOMER";
            this.pRODUCTCUSTOMERBindingSource.DataSource = this.dsPRODUCTCUSTOMER;
            // 
            // dsPRODUCTCUSTOMER
            // 
            this.dsPRODUCTCUSTOMER.DataSetName = "dsPRODUCTCUSTOMER";
            this.dsPRODUCTCUSTOMER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
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
            this.colCustomer_ID,
            this.colCustomerName,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit,
            this.colUnit_Name,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colCost,
            this.colID,
            this.colRefDate});
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQuantity;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = "0";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colQuantity;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition2.Value1 = "-1";
            styleFormatCondition2.Value2 = "10";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupPanelText = "Kéo và Thả cột vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", null, "=  Số lượng: {0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", null, "Thành tiền: {0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsNavigation.AutoFocusNewRow = true;
            this.gbList.OptionsNavigation.AutoMoveRowFocus = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsPrint.UsePrintStyles = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.PaintStyleName = "Skin";
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gbList_CustomSummaryCalculate);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colCustomer_ID);
            this.gridBand1.Columns.Add(this.colCustomerName);
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colRefDate);
            this.gridBand1.Columns.Add(this.colUnit_Name);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Columns.Add(this.colCost);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.OptionsBand.ShowInCustomizationForm = false;
            this.gridBand1.Width = 961;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.Caption = "Mã Khách Hàng";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.Width = 124;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Khách Hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.Width = 208;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.Width = 106;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // colID
            // 
            this.colID.Caption = "Chứng Từ";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.Width = 97;
            // 
            // colRefDate
            // 
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colRefDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.Visible = true;
            this.colRefDate.Width = 101;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.Width = 88;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Đơn Giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.Width = 99;
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
            this.colAmount.Width = 124;
            // 
            // colCost
            // 
            this.colCost.Caption = "Giá Trị Vốn";
            this.colCost.ColumnEdit = this.rpVal;
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.Width = 148;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.RowIndex = 1;
            this.colProduct_Name.Width = 200;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoComplete = false;
            this.rpUnit.AutoHeight = false;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "(Chọn)";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcList;
            this.gridView2.Name = "gridView2";
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.gcList);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 57);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(806, 520);
            this.plMain.TabIndex = 26;
            // 
            // pRODUCTCUSTOMERTableAdapter
            // 
            this.pRODUCTCUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // xucProductCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Name = "xucProductCustomer";
            this.Size = new System.Drawing.Size(806, 577);
            this.Controls.SetChildIndex(this.plTop, 0);
            this.Controls.SetChildIndex(this.plMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTCUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCTCUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl plMain;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustomerName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCost;
        private System.Windows.Forms.BindingSource pRODUCTCUSTOMERBindingSource;
        private Perfect.Inventory.Core.Inventory.Inventory.ProductCustomer.DS.dsPRODUCTCUSTOMER dsPRODUCTCUSTOMER;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefDate;
        private Perfect.Inventory.Core.Inventory.Inventory.ProductCustomer.DS.dsPRODUCTCUSTOMERTableAdapters.PRODUCTCUSTOMERTableAdapter pRODUCTCUSTOMERTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}
