using Perfect.Dictionary.UI.UBarcode;
using Perfect.Inventory.Core.Common.DS;

namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    partial class XucTranferA
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucTranferA));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.tRASFERDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTRANSFER_DETAIL = new Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAIL();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgProduct = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Inventory.Core.Common.DS.dsPRODUCT();
            this.rpglkProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpProductName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg_Price1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPActiveInt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOutStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpToStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTActiveInt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colLev1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLev2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLev3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLev4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitConvert = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBatch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Type_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQtyConvert = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dtCreated = new DevExpress.XtraEditors.DateEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.chxBarcode = new DevExpress.XtraEditors.CheckEdit();
            this.chxIsPrint = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmployeeName = new DevExpress.XtraEditors.GridLookUpEdit();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmployee = new Perfect.Inventory.Core.Inventory.Transfer.dsEmployee();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmployeeID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmployeeSender = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcBarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcEmployeeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcID = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.lcEmployeeID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sTOCKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters.PRODUCTTableAdapter();
            this.tRASFER_DETAILTableAdapter = new Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters.STOCK_TRANSFER_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRASFERDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRANSFER_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpToStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxIsPrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeSender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plBottom
            // 
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBottom.Location = new System.Drawing.Point(0, 0);
            this.plBottom.Size = new System.Drawing.Size(923, 31);
            // 
            // ucBarB
            // 
            this.ucBarB.Size = new System.Drawing.Size(919, 27);
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "SL Tồn";
            this.colQuantity1.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.OptionsColumn.ReadOnly = true;
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 3;
            this.colQuantity1.Width = 146;
            // 
            // colQuantity2
            // 
            this.colQuantity2.Caption = "Số Lượng";
            this.colQuantity2.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity2.FieldName = "Quantity";
            this.colQuantity2.Name = "colQuantity2";
            this.colQuantity2.OptionsColumn.ReadOnly = true;
            this.colQuantity2.Visible = true;
            this.colQuantity2.VisibleIndex = 3;
            this.colQuantity2.Width = 153;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.gcList);
            this.lcMain.Controls.Add(this.dtCreated);
            this.lcMain.Controls.Add(this.txtID);
            this.lcMain.Controls.Add(this.chxBarcode);
            this.lcMain.Controls.Add(this.chxIsPrint);
            this.lcMain.Controls.Add(this.txtEmployeeName);
            this.lcMain.Controls.Add(this.txtEmployeeID);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.txtEmployeeSender);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 31);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(923, 567);
            this.lcMain.TabIndex = 2;
            this.lcMain.Text = "layoutControl1";
            // 
            // gcList
            // 
            this.gcList.DataSource = this.tRASFERDETAILBindingSource;
            this.gcList.Location = new System.Drawing.Point(227, 81);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpgProduct,
            this.rpgStock,
            this.rpProductName,
            this.rpUnit,
            this.rpToStock,
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(693, 453);
            this.gcList.TabIndex = 38;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // tRASFERDETAILBindingSource
            // 
            this.tRASFERDETAILBindingSource.DataMember = "STOCK_TRANSFER_DETAIL";
            this.tRASFERDETAILBindingSource.DataSource = this.dsTRANSFER_DETAIL;
            // 
            // dsTRANSFER_DETAIL
            // 
            this.dsTRANSFER_DETAIL.DataSetName = "dsTRANSFER_DETAIL";
            this.dsTRANSFER_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.Row.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_ID,
            this.colItemID,
            this.colProduct_Name,
            this.colUnit,
            this.colUnitConvert,
            this.colOutStock,
            this.colInStock,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colBatch,
            this.colDescription,
            this.colProduct_Type_ID,
            this.colLev1,
            this.colLev2,
            this.colLev3,
            this.colLev4,
            this.colQtyConvert});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(385, 280, 223, 214);
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", this.colAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.colQuantity, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 45;
            this.gbList.Name = "gbList";
            this.gbList.OptionsCustomization.AllowFilter = false;
            this.gbList.OptionsCustomization.AllowSort = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gbList.OptionsView.EnableAppearanceEvenRow = true;
            this.gbList.OptionsView.EnableAppearanceOddRow = true;
            this.gbList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.VertScrollTipFieldName = "Product_ID";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanged);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gbList_KeyDown);
            this.gbList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanging);
            this.gbList.Layout += new System.EventHandler(this.gbList_Layout);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gbList_CustomSummaryCalculate);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colItemID);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colDescription);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colOutStock);
            this.gridBand1.Columns.Add(this.colInStock);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colLev1);
            this.gridBand1.Columns.Add(this.colLev2);
            this.gridBand1.Columns.Add(this.colLev3);
            this.gridBand1.Columns.Add(this.colLev4);
            this.gridBand1.Columns.Add(this.colUnitConvert);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Columns.Add(this.colBatch);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 1141;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.ColumnEdit = this.rpgProduct;
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_ID.OptionsColumn.FixedWidth = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 111;
            // 
            // rpgProduct
            // 
            this.rpgProduct.ActionButtonIndex = 2;
            this.rpgProduct.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            serializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.rpgProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Search", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons1"))), new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject2, "", "Add", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "None", null, true)});
            this.rpgProduct.DataSource = this.pRODUCTBindingSource;
            this.rpgProduct.DisplayMember = "Product_ID";
            this.rpgProduct.ImmediatePopup = true;
            this.rpgProduct.Name = "rpgProduct";
            this.rpgProduct.NullText = "";
            this.rpgProduct.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpgProduct.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgProduct.ValueMember = "Product_ID";
            this.rpgProduct.View = this.rpglkProduct;
            this.rpgProduct.DoubleClick += new System.EventHandler(this.rpgProduct_DoubleClick);
            this.rpgProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rpgProduct_KeyDown);
            this.rpgProduct.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.rpgProduct_CloseUp);
            this.rpgProduct.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rpgProduct_ButtonClick);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dsPRODUCT;
            // 
            // dsPRODUCT
            // 
            this.dsPRODUCT.DataSetName = "dsPRODUCT";
            this.dsPRODUCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpglkProduct
            // 
            this.rpglkProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID1,
            this.colProduct_Name1,
            this.colStock_Name,
            this.colQuantity1,
            this.colOrg_Price,
            this.colPActiveInt});
            this.rpglkProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colQuantity1;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rpglkProduct.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.rpglkProduct.Name = "rpglkProduct";
            this.rpglkProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rpglkProduct.OptionsView.ShowAutoFilterRow = true;
            this.rpglkProduct.OptionsView.ShowGroupPanel = false;
            this.rpglkProduct.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_Name1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProduct_ID1
            // 
            this.colProduct_ID1.Caption = "Mã Hàng";
            this.colProduct_ID1.FieldName = "Product_ID";
            this.colProduct_ID1.Name = "colProduct_ID1";
            this.colProduct_ID1.Visible = true;
            this.colProduct_ID1.VisibleIndex = 0;
            this.colProduct_ID1.Width = 118;
            // 
            // colProduct_Name1
            // 
            this.colProduct_Name1.Caption = "Tên Hàng";
            this.colProduct_Name1.FieldName = "Product_Name";
            this.colProduct_Name1.Name = "colProduct_Name1";
            this.colProduct_Name1.Visible = true;
            this.colProduct_Name1.VisibleIndex = 1;
            this.colProduct_Name1.Width = 292;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 4;
            this.colStock_Name.Width = 367;
            // 
            // colOrg_Price
            // 
            this.colOrg_Price.Caption = "Giá";
            this.colOrg_Price.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colOrg_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOrg_Price.FieldName = "Org_Price";
            this.colOrg_Price.Name = "colOrg_Price";
            this.colOrg_Price.OptionsColumn.ReadOnly = true;
            this.colOrg_Price.Visible = true;
            this.colOrg_Price.VisibleIndex = 2;
            this.colOrg_Price.Width = 167;
            // 
            // colPActiveInt
            // 
            this.colPActiveInt.FieldName = "ActiveInt";
            this.colPActiveInt.Name = "colPActiveInt";
            this.colPActiveInt.OptionsColumn.ReadOnly = true;
            // 
            // colItemID
            // 
            this.colItemID.Caption = "Hàng Hoá";
            this.colItemID.ColumnEdit = this.rpProductName;
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colItemID.OptionsColumn.FixedWidth = true;
            this.colItemID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colItemID.Visible = true;
            this.colItemID.Width = 238;
            // 
            // rpProductName
            // 
            this.rpProductName.ActionButtonIndex = 2;
            this.rpProductName.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpProductName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "Search", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", "Add", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", "None", null, true)});
            this.rpProductName.DataSource = this.pRODUCTBindingSource;
            this.rpProductName.DisplayMember = "Product_Name";
            this.rpProductName.ImmediatePopup = true;
            this.rpProductName.Name = "rpProductName";
            this.rpProductName.NullText = "(Gõ vào đây)";
            this.rpProductName.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpProductName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpProductName.ValueMember = "Product_ID";
            this.rpProductName.View = this.gridView1;
            this.rpProductName.DoubleClick += new System.EventHandler(this.rpgProduct_DoubleClick);
            this.rpProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rpgProduct_KeyDown);
            this.rpProductName.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.rpProductName_CloseUp);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID2,
            this.colProduct_Name2,
            this.colStock_Name1,
            this.colQuantity2,
            this.colOrg_Price1,
            this.colPActiveInt1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colQuantity2;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProduct_Name2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProduct_ID2
            // 
            this.colProduct_ID2.Caption = "Mã Hàng";
            this.colProduct_ID2.FieldName = "Product_ID";
            this.colProduct_ID2.Name = "colProduct_ID2";
            this.colProduct_ID2.Visible = true;
            this.colProduct_ID2.VisibleIndex = 0;
            this.colProduct_ID2.Width = 111;
            // 
            // colProduct_Name2
            // 
            this.colProduct_Name2.Caption = "Hàng Hóa";
            this.colProduct_Name2.FieldName = "Product_Name";
            this.colProduct_Name2.Name = "colProduct_Name2";
            this.colProduct_Name2.Visible = true;
            this.colProduct_Name2.VisibleIndex = 1;
            this.colProduct_Name2.Width = 328;
            // 
            // colStock_Name1
            // 
            this.colStock_Name1.Caption = "Kho Hàng";
            this.colStock_Name1.FieldName = "Stock_Name";
            this.colStock_Name1.Name = "colStock_Name1";
            this.colStock_Name1.Visible = true;
            this.colStock_Name1.VisibleIndex = 4;
            this.colStock_Name1.Width = 340;
            // 
            // colOrg_Price1
            // 
            this.colOrg_Price1.Caption = "Giá";
            this.colOrg_Price1.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colOrg_Price1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colOrg_Price1.FieldName = "Org_Price";
            this.colOrg_Price1.Name = "colOrg_Price1";
            this.colOrg_Price1.OptionsColumn.ReadOnly = true;
            this.colOrg_Price1.Visible = true;
            this.colOrg_Price1.VisibleIndex = 2;
            this.colOrg_Price1.Width = 158;
            // 
            // colPActiveInt1
            // 
            this.colPActiveInt1.FieldName = "ActiveInt";
            this.colPActiveInt1.Name = "colPActiveInt1";
            this.colPActiveInt1.OptionsColumn.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Đơn Vị";
            this.colUnit.ColumnEdit = this.rpUnit;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.OptionsColumn.FixedWidth = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Visible = true;
            this.colUnit.Width = 68;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoHeight = false;
            this.rpUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DataSource = this.uNITBindingSource;
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.ImmediatePopup = true;
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "(Chọn)";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.gridView2;
            this.rpUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rpgProduct_KeyDown);
            this.rpUnit.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.rpUnit_CloseUp);
            // 
            // uNITBindingSource
            // 
            this.uNITBindingSource.DataMember = "UNIT";
            this.uNITBindingSource.DataSource = this.dsUnit;
            // 
            // dsUnit
            // 
            this.dsUnit.DataSetName = "dsUnit";
            this.dsUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qui Cách";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsColumn.FixedWidth = true;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.Width = 103;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Diễn Giải";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_Name.OptionsColumn.FixedWidth = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colOutStock
            // 
            this.colOutStock.Caption = "Từ Kho";
            this.colOutStock.ColumnEdit = this.rpgStock;
            this.colOutStock.CustomizationCaption = "Kho Xuất";
            this.colOutStock.FieldName = "OutStock";
            this.colOutStock.Name = "colOutStock";
            this.colOutStock.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOutStock.OptionsColumn.FixedWidth = true;
            this.colOutStock.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOutStock.Visible = true;
            this.colOutStock.Width = 188;
            // 
            // rpgStock
            // 
            this.rpgStock.AutoHeight = false;
            this.rpgStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpgStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpgStock.DataSource = this.sTOCKBindingSource4;
            this.rpgStock.DisplayMember = "Stock_Name";
            this.rpgStock.ImmediatePopup = true;
            this.rpgStock.Name = "rpgStock";
            this.rpgStock.NullText = "(Chọn)";
            this.rpgStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgStock.ValueMember = "Stock_ID";
            this.rpgStock.View = this.repositoryItemGridLookUpEdit1View;
            this.rpgStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rpgProduct_KeyDown);
            this.rpgStock.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.rpStocks_CloseUp);
            // 
            // sTOCKBindingSource4
            // 
            this.sTOCKBindingSource4.DataMember = "STOCK";
            this.sTOCKBindingSource4.DataSource = this.dsSTOCK;
            // 
            // dsSTOCK
            // 
            this.dsSTOCK.DataSetName = "dsSTOCK";
            this.dsSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStock_Name3,
            this.colStock_ID1,
            this.colSTActiveInt});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colStock_Name3
            // 
            this.colStock_Name3.Caption = "Kho Hàng";
            this.colStock_Name3.FieldName = "Stock_Name";
            this.colStock_Name3.Name = "colStock_Name3";
            this.colStock_Name3.Visible = true;
            this.colStock_Name3.VisibleIndex = 0;
            // 
            // colStock_ID1
            // 
            this.colStock_ID1.Caption = "Mã Kho";
            this.colStock_ID1.FieldName = "Stock_ID";
            this.colStock_ID1.Name = "colStock_ID1";
            this.colStock_ID1.Visible = true;
            this.colStock_ID1.VisibleIndex = 1;
            // 
            // colSTActiveInt
            // 
            this.colSTActiveInt.FieldName = "ActiveInt";
            this.colSTActiveInt.Name = "colSTActiveInt";
            this.colSTActiveInt.OptionsColumn.ReadOnly = true;
            // 
            // colInStock
            // 
            this.colInStock.Caption = "Đến Kho";
            this.colInStock.ColumnEdit = this.rpToStock;
            this.colInStock.CustomizationCaption = "Kho Nhập";
            this.colInStock.FieldName = "InStock";
            this.colInStock.Name = "colInStock";
            this.colInStock.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInStock.OptionsColumn.FixedWidth = true;
            this.colInStock.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colInStock.Visible = true;
            this.colInStock.Width = 166;
            // 
            // rpToStock
            // 
            this.rpToStock.AutoHeight = false;
            this.rpToStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpToStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpToStock.DataSource = this.sTOCKBindingSource3;
            this.rpToStock.DisplayMember = "Stock_Name";
            this.rpToStock.ImmediatePopup = true;
            this.rpToStock.Name = "rpToStock";
            this.rpToStock.NullText = "(Chọn)";
            this.rpToStock.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpToStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpToStock.ValueMember = "Stock_ID";
            this.rpToStock.View = this.gridView5;
            this.rpToStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rpgProduct_KeyDown);
            this.rpToStock.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.rpToStock_CloseUp);
            // 
            // sTOCKBindingSource3
            // 
            this.sTOCKBindingSource3.DataMember = "STOCK";
            this.sTOCKBindingSource3.DataSource = this.dsSTOCK;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStock_Name2,
            this.colStock_ID,
            this.colSTActiveInt1});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colStock_Name2
            // 
            this.colStock_Name2.Caption = "Kho Hàng";
            this.colStock_Name2.FieldName = "Stock_Name";
            this.colStock_Name2.Name = "colStock_Name2";
            this.colStock_Name2.Visible = true;
            this.colStock_Name2.VisibleIndex = 0;
            // 
            // colStock_ID
            // 
            this.colStock_ID.Caption = "Mã Kho";
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.Visible = true;
            this.colStock_ID.VisibleIndex = 1;
            // 
            // colSTActiveInt1
            // 
            this.colSTActiveInt1.FieldName = "ActiveInt";
            this.colSTActiveInt1.Name = "colSTActiveInt1";
            this.colSTActiveInt1.OptionsColumn.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.FixedWidth = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 65;
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
            // colLev1
            // 
            this.colLev1.Caption = "SL Thùng";
            this.colLev1.ColumnEdit = this.rpVal;
            this.colLev1.FieldName = "Lev1";
            this.colLev1.Name = "colLev1";
            // 
            // colLev2
            // 
            this.colLev2.Caption = "SL Vỉ";
            this.colLev2.ColumnEdit = this.rpVal;
            this.colLev2.FieldName = "Lev2";
            this.colLev2.Name = "colLev2";
            // 
            // colLev3
            // 
            this.colLev3.Caption = "TL Vỉ";
            this.colLev3.ColumnEdit = this.rpVal;
            this.colLev3.FieldName = "Lev3";
            this.colLev3.Name = "colLev3";
            // 
            // colLev4
            // 
            this.colLev4.Caption = "SL Lẻ";
            this.colLev4.ColumnEdit = this.rpVal;
            this.colLev4.FieldName = "Lev4";
            this.colLev4.Name = "colLev4";
            // 
            // colUnitConvert
            // 
            this.colUnitConvert.Caption = "Quy Đổi";
            this.colUnitConvert.CustomizationCaption = "Tỷ Lệ Quy Đổi";
            this.colUnitConvert.FieldName = "UnitConvert";
            this.colUnitConvert.Name = "colUnitConvert";
            this.colUnitConvert.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitConvert.OptionsColumn.FixedWidth = true;
            this.colUnitConvert.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Đơn Giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice.OptionsColumn.FixedWidth = true;
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.Width = 89;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsColumn.FixedWidth = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.Width = 113;
            // 
            // colBatch
            // 
            this.colBatch.Caption = "Lô";
            this.colBatch.CustomizationCaption = "Lô Hàng";
            this.colBatch.FieldName = "Batch";
            this.colBatch.Name = "colBatch";
            this.colBatch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBatch.OptionsColumn.FixedWidth = true;
            this.colBatch.Width = 80;
            // 
            // colProduct_Type_ID
            // 
            this.colProduct_Type_ID.FieldName = "Product_Type_ID";
            this.colProduct_Type_ID.Name = "colProduct_Type_ID";
            this.colProduct_Type_ID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colQtyConvert
            // 
            this.colQtyConvert.Caption = "Tổng C";
            this.colQtyConvert.FieldName = "QtyConvert";
            this.colQtyConvert.Name = "colQtyConvert";
            // 
            // dtCreated
            // 
            this.dtCreated.EditValue = new System.DateTime(2008, 2, 8, 14, 22, 49, 437);
            this.dtCreated.Location = new System.Drawing.Point(767, 29);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCreated.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtCreated.Properties.NullDate = new System.DateTime(2008, 2, 8, 14, 23, 58, 359);
            this.dtCreated.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtCreated.Size = new System.Drawing.Size(151, 20);
            this.dtCreated.StyleController = this.lcMain;
            this.dtCreated.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(767, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.StyleController = this.lcMain;
            this.txtID.TabIndex = 22;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // chxBarcode
            // 
            this.chxBarcode.Location = new System.Drawing.Point(103, 536);
            this.chxBarcode.Name = "chxBarcode";
            this.chxBarcode.Properties.Caption = "Sử dụng mã vạch";
            this.chxBarcode.Size = new System.Drawing.Size(815, 19);
            this.chxBarcode.StyleController = this.lcMain;
            this.chxBarcode.TabIndex = 31;
            this.chxBarcode.CheckedChanged += new System.EventHandler(this.chxBarcode_CheckedChanged);
            // 
            // chxIsPrint
            // 
            this.chxIsPrint.Location = new System.Drawing.Point(5, 536);
            this.chxIsPrint.Name = "chxIsPrint";
            this.chxIsPrint.Properties.Caption = "In sau khi lưu";
            this.chxIsPrint.Size = new System.Drawing.Size(94, 19);
            this.chxIsPrint.StyleController = this.lcMain;
            this.chxIsPrint.TabIndex = 30;
            // 
            // txtEmployeeName
            // 
            this.Err.SetIconAlignment(this.txtEmployeeName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtEmployeeName.Location = new System.Drawing.Point(314, 5);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Properties.ActionButtonIndex = 2;
            this.txtEmployeeName.Properties.AutoComplete = false;
            this.txtEmployeeName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            toolTipItem1.Text = "Nếu khách hàng chưa tồn tại, bạn có thể nhấn nút này để thêm khách hàng mới này v" +
                "ào.";
            superToolTip1.Items.Add(toolTipItem1);
            this.txtEmployeeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Tìm", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("txtEmployeeName.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", "Search", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Tạo", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("txtEmployeeName.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", "Add", superToolTip1, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", "None", null, true)});
            this.txtEmployeeName.Properties.DataSource = this.eMPLOYEEBindingSource;
            this.txtEmployeeName.Properties.DisplayMember = "Employee_Name";
            this.txtEmployeeName.Properties.NullText = "";
            this.txtEmployeeName.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtEmployeeName.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtEmployeeName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEmployeeName.Properties.UseParentBackground = true;
            this.txtEmployeeName.Properties.ValidateOnEnterKey = true;
            this.txtEmployeeName.Properties.ValueMember = "Employee_ID";
            this.txtEmployeeName.Properties.View = this.gridLookUpEdit1View;
            this.txtEmployeeName.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCustomerName_Properties_ButtonClick);
            this.txtEmployeeName.Size = new System.Drawing.Size(388, 20);
            this.txtEmployeeName.StyleController = this.lcMain;
            this.txtEmployeeName.TabIndex = 25;
            this.txtEmployeeName.EditValueChanged += new System.EventHandler(this.txtEmployeeName_EditValueChanged);
            this.txtEmployeeName.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.txtEmployeeName_CloseUp);
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dsEmployee;
            // 
            // dsEmployee
            // 
            this.dsEmployee.DataSetName = "dsEmployee";
            this.dsEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee_Name,
            this.colEmployee_ID});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployee_Name
            // 
            this.colEmployee_Name.Caption = "Nhân Viên";
            this.colEmployee_Name.FieldName = "Employee_Name";
            this.colEmployee_Name.Name = "colEmployee_Name";
            this.colEmployee_Name.OptionsColumn.FixedWidth = true;
            this.colEmployee_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_Name.Visible = true;
            this.colEmployee_Name.VisibleIndex = 0;
            this.colEmployee_Name.Width = 200;
            // 
            // colEmployee_ID
            // 
            this.colEmployee_ID.Caption = "Mã";
            this.colEmployee_ID.FieldName = "Employee_ID";
            this.colEmployee_ID.Name = "colEmployee_ID";
            this.colEmployee_ID.OptionsColumn.FixedWidth = true;
            this.colEmployee_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_ID.Visible = true;
            this.colEmployee_ID.VisibleIndex = 1;
            this.colEmployee_ID.Width = 100;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.EditValue = "";
            this.txtEmployeeID.Location = new System.Drawing.Point(99, 5);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmployeeID.Properties.DataSource = this.eMPLOYEEBindingSource;
            this.txtEmployeeID.Properties.DisplayMember = "Employee_ID";
            this.txtEmployeeID.Properties.NullText = "";
            this.txtEmployeeID.Properties.ValueMember = "Employee_ID";
            this.txtEmployeeID.Properties.View = this.gridView3;
            this.txtEmployeeID.Size = new System.Drawing.Size(117, 20);
            this.txtEmployeeID.StyleController = this.lcMain;
            this.txtEmployeeID.TabIndex = 8;
            this.txtEmployeeID.TabStop = false;
            this.txtEmployeeID.EditValueChanged += new System.EventHandler(this.txtEmployeeID_EditValueChanged);
            this.txtEmployeeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyDown);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee_Name1,
            this.colEmployee_ID1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.VertScrollTipFieldName = "Employee_ID";
            // 
            // colEmployee_Name1
            // 
            this.colEmployee_Name1.Caption = "Tên";
            this.colEmployee_Name1.FieldName = "Employee_Name";
            this.colEmployee_Name1.Name = "colEmployee_Name1";
            this.colEmployee_Name1.Visible = true;
            this.colEmployee_Name1.VisibleIndex = 1;
            this.colEmployee_Name1.Width = 847;
            // 
            // colEmployee_ID1
            // 
            this.colEmployee_ID1.Caption = "Mã";
            this.colEmployee_ID1.FieldName = "Employee_ID";
            this.colEmployee_ID1.Name = "colEmployee_ID1";
            this.colEmployee_ID1.Visible = true;
            this.colEmployee_ID1.VisibleIndex = 0;
            this.colEmployee_ID1.Width = 243;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 29);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(603, 44);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 22;
            this.txtDescription.TabStop = false;
            // 
            // txtEmployeeSender
            // 
            this.txtEmployeeSender.Location = new System.Drawing.Point(767, 53);
            this.txtEmployeeSender.Name = "txtEmployeeSender";
            this.txtEmployeeSender.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtEmployeeSender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmployeeSender.Properties.DataSource = this.eMPLOYEEBindingSource;
            this.txtEmployeeSender.Properties.DisplayMember = "Employee_Name";
            this.txtEmployeeSender.Properties.NullText = "";
            this.txtEmployeeSender.Properties.ValueMember = "Employee_ID";
            this.txtEmployeeSender.Properties.View = this.gridView4;
            this.txtEmployeeSender.Size = new System.Drawing.Size(151, 20);
            this.txtEmployeeSender.StyleController = this.lcMain;
            this.txtEmployeeSender.TabIndex = 39;
            this.txtEmployeeSender.TabStop = false;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee_Name2,
            this.colEmployee_ID2});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployee_Name2
            // 
            this.colEmployee_Name2.Caption = "Tên NV";
            this.colEmployee_Name2.FieldName = "Employee_Name";
            this.colEmployee_Name2.Name = "colEmployee_Name2";
            this.colEmployee_Name2.OptionsColumn.AllowEdit = false;
            this.colEmployee_Name2.OptionsColumn.ReadOnly = true;
            this.colEmployee_Name2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_Name2.Visible = true;
            this.colEmployee_Name2.VisibleIndex = 0;
            // 
            // colEmployee_ID2
            // 
            this.colEmployee_ID2.Caption = "Mã NV";
            this.colEmployee_ID2.FieldName = "Employee_ID";
            this.colEmployee_ID2.Name = "colEmployee_ID2";
            this.colEmployee_ID2.OptionsColumn.AllowEdit = false;
            this.colEmployee_ID2.OptionsColumn.ReadOnly = true;
            this.colEmployee_ID2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_ID2.Visible = true;
            this.colEmployee_ID2.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcDetail,
            this.lcBarcode,
            this.splitterItem1,
            this.splitterItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.lcEmployeeName,
            this.layoutControlItem6,
            this.lcID,
            this.splitterItem3,
            this.lcEmployeeID,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(923, 567);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcDetail
            // 
            this.lcDetail.Control = this.gcList;
            this.lcDetail.CustomizationFormText = "lcDetail";
            this.lcDetail.Location = new System.Drawing.Point(224, 78);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcDetail.Size = new System.Drawing.Size(693, 453);
            this.lcDetail.Text = "lcDetail";
            this.lcDetail.TextSize = new System.Drawing.Size(0, 0);
            this.lcDetail.TextToControlDistance = 0;
            this.lcDetail.TextVisible = false;
            // 
            // lcBarcode
            // 
            this.lcBarcode.CustomizationFormText = "lcBarcode";
            this.lcBarcode.Location = new System.Drawing.Point(0, 78);
            this.lcBarcode.Name = "lcBarcode";
            this.lcBarcode.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcBarcode.Size = new System.Drawing.Size(218, 453);
            this.lcBarcode.Text = "lcBarcode";
            this.lcBarcode.TextSize = new System.Drawing.Size(0, 0);
            this.lcBarcode.TextToControlDistance = 0;
            this.lcBarcode.TextVisible = false;
            this.lcBarcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(218, 78);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 453);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(0, 72);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(917, 6);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chxIsPrint;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 531);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(98, 30);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(98, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(98, 30);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chxBarcode;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(98, 531);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(819, 30);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // lcEmployeeName
            // 
            this.lcEmployeeName.Control = this.txtEmployeeName;
            this.lcEmployeeName.CustomizationFormText = "Tên";
            this.lcEmployeeName.Location = new System.Drawing.Point(215, 0);
            this.lcEmployeeName.Name = "lcEmployeeName";
            this.lcEmployeeName.Size = new System.Drawing.Size(486, 24);
            this.lcEmployeeName.Text = "Tên NV Nhận Hàng";
            this.lcEmployeeName.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtDescription;
            this.layoutControlItem6.CustomizationFormText = "Ghi Chú";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(701, 48);
            this.layoutControlItem6.Text = "Ghi Chú";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(90, 13);
            // 
            // lcID
            // 
            this.lcID.Control = this.txtID;
            this.lcID.CustomizationFormText = "Phiếu";
            this.lcID.Location = new System.Drawing.Point(707, 0);
            this.lcID.MaxSize = new System.Drawing.Size(210, 24);
            this.lcID.MinSize = new System.Drawing.Size(210, 24);
            this.lcID.Name = "lcID";
            this.lcID.Size = new System.Drawing.Size(210, 24);
            this.lcID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcID.Text = "Phiếu";
            this.lcID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcID.TextSize = new System.Drawing.Size(50, 13);
            this.lcID.TextToControlDistance = 5;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.CustomizationFormText = "splitterItem3";
            this.splitterItem3.Location = new System.Drawing.Point(701, 0);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(6, 72);
            // 
            // lcEmployeeID
            // 
            this.lcEmployeeID.Control = this.txtEmployeeID;
            this.lcEmployeeID.CustomizationFormText = "Mã";
            this.lcEmployeeID.Location = new System.Drawing.Point(0, 0);
            this.lcEmployeeID.Name = "lcEmployeeID";
            this.lcEmployeeID.Size = new System.Drawing.Size(215, 24);
            this.lcEmployeeID.Text = "Mã NV";
            this.lcEmployeeID.TextSize = new System.Drawing.Size(90, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtEmployeeSender;
            this.layoutControlItem4.CustomizationFormText = "Nhâ Viên";
            this.layoutControlItem4.Location = new System.Drawing.Point(707, 48);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Nhân Viên";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtCreated;
            this.layoutControlItem2.CustomizationFormText = "Ngày";
            this.layoutControlItem2.Location = new System.Drawing.Point(707, 24);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(210, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Ngày";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // sTOCKBindingSource2
            // 
            this.sTOCKBindingSource2.DataMember = "STOCK";
            this.sTOCKBindingSource2.DataSource = this.dsSTOCK;
            // 
            // sTOCKBindingSource1
            // 
            this.sTOCKBindingSource1.DataMember = "STOCK";
            this.sTOCKBindingSource1.DataSource = this.dsSTOCK;
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsSTOCK;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tRASFER_DETAILTableAdapter
            // 
            this.tRASFER_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // XucTranferA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "XucTranferA";
            this.NotSave = true;
            this.Size = new System.Drawing.Size(923, 598);
            this.Controls.SetChildIndex(this.plBottom, 0);
            this.Controls.SetChildIndex(this.lcMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRASFERDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTRANSFER_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpToStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxIsPrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeSender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.GridLookUpEdit txtEmployeeName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit chxBarcode;
        private DevExpress.XtraEditors.CheckEdit chxIsPrint;
        private DevExpress.XtraEditors.DateEdit dtCreated;
        private DevExpress.XtraEditors.TextEdit txtID;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView rpglkProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private dsEmployee dsEmployee;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        private System.Windows.Forms.BindingSource sTOCKBindingSource1;
        private System.Windows.Forms.BindingSource sTOCKBindingSource2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOutStock;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colInStock;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConvert;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private System.Windows.Forms.BindingSource sTOCKBindingSource4;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpToStock;
        private System.Windows.Forms.BindingSource sTOCKBindingSource3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBatch;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraLayout.LayoutControlItem lcDetail;
        private XucBaseBarcode ucBarcode;
        private DevExpress.XtraLayout.LayoutControlItem lcBarcode;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private dsPRODUCT dsPRODUCT;
        private Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit txtEmployeeID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Type_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLev1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLev2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLev3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLev4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg_Price1;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.GridLookUpEdit txtEmployeeSender;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID2;
        private DevExpress.XtraLayout.LayoutControlItem lcEmployeeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem lcID;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
        private DevExpress.XtraLayout.LayoutControlItem lcEmployeeID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource tRASFERDETAILBindingSource;
        private Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAIL dsTRANSFER_DETAIL;
        //private Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters.TRASFER_DETAILTableAdapter tRASFER_DETAILTableAdapter;

        private Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters.STOCK_TRANSFER_DETAILTableAdapter tRASFER_DETAILTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name3;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colSTActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colPActiveInt1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTActiveInt1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQtyConvert;
    }
}
