using Perfect.Inventory.Core.Common.DS;
using Perfect.Inventory.Core.Inventory.Inventory.Orders.DS;
using Perfect.Inventory.Core.Inventory.Inventory.Orders.DS.dsInventoryOrderTableAdapters;

namespace Perfect.Inventory
{
    partial class xucInventoryOrdersBFC
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucInventoryOrdersBFC));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.colRate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVENTORYORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventoryOrder = new dsInventoryOrder();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new dsSTOCK();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new dsUnit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMinStock = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrder = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpProductGroup = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plBottom = new DevExpress.XtraEditors.PanelControl();
            this.uhm = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.txtTotal = new DevExpress.XtraEditors.CalcEdit();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.plTop = new DevExpress.XtraEditors.PanelControl();
            this.cbxStock = new System.Windows.Forms.ComboBox();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.iNVENTORY_ORDERTableAdapter = new INVENTORY_ORDERTableAdapter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProductDetail = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProduct = new DevExpress.XtraBars.BarSubItem();
            this.bbiHistory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOtherView = new DevExpress.XtraBars.BarSubItem();
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            this.SuspendLayout();
            // 
            // colRate
            // 
            this.colRate.Caption = "Tỷ lệ";
            this.colRate.ColumnEdit = this.rpVal;
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.OptionsColumn.AllowEdit = false;
            this.colRate.OptionsColumn.FixedWidth = true;
            this.colRate.OptionsColumn.ReadOnly = true;
            this.colRate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRate.Visible = true;
            this.colRate.Width = 107;
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
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsSTOCK;
            // 
            // dsStock
            // 
           
            // 
            // gcList
            // 
            this.gcList.DataSource = this.iNVENTORYORDERBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal,
            this.rpUnit,
            this.rpStock,
            this.rpProductGroup});
            this.gcList.Size = new System.Drawing.Size(963, 398);
            this.gcList.TabIndex = 15;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList,
            this.gridView2});
            // 
            // iNVENTORYORDERBindingSource
            // 
            this.iNVENTORYORDERBindingSource.DataMember = "INVENTORY_ORDER";
            this.iNVENTORYORDERBindingSource.DataSource = this.dsInventoryOrder;
            // 
            // dsInventoryOrder
            // 
            this.dsInventoryOrder.DataSetName = "dsInventoryOrder";
            this.dsInventoryOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colStock_ID,
            this.colStock_Name,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colUnit,
            this.colQuantity,
            this.colMinStock,
            this.colRate,
            this.colOrder});
            this.gbList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colRate;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition1.Value1 = "1";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Purple;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colRate;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition2.Value1 = "1";
            styleFormatCondition2.Value2 = "2";
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colRate;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition3.Value1 = "2";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ColumnAutoWidth = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.ViewCaption = "Danh sách Nhân viên";
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "";
            this.gridBand1.Columns.Add(this.colStock_ID);
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colMinStock);
            this.gridBand1.Columns.Add(this.colRate);
            this.gridBand1.Columns.Add(this.colOrder);
            this.gridBand1.Columns.Add(this.colStock_Name);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.ToolTip = "";
            this.gridBand1.Width = 748;
            // 
            // colStock_ID
            // 
            this.colStock_ID.Caption = "Kho Hàng";
            this.colStock_ID.ColumnEdit = this.rpStock;
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.AllowEdit = false;
            this.colStock_ID.OptionsColumn.FixedWidth = true;
            this.colStock_ID.OptionsColumn.ReadOnly = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID.Width = 80;
            // 
            // rpStock
            // 
            this.rpStock.AutoComplete = false;
            this.rpStock.AutoHeight = false;
            this.rpStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpStock.DataSource = this.sTOCKBindingSource1;
            this.rpStock.DisplayMember = "Stock_Name";
            this.rpStock.Name = "rpStock";
            this.rpStock.NullText = "";
            this.rpStock.ValueMember = "Stock_ID";
            this.rpStock.View = this.gridView1;
            // 
            // sTOCKBindingSource1
            // 
            this.sTOCKBindingSource1.DataMember = "STOCK";
            this.sTOCKBindingSource1.DataSource = this.dsSTOCK;
            // 
            // dsSTOCK1
            // 
            this.dsSTOCK.DataSetName = "dsSTOCK";
            this.dsSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã hàng hóa";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.FixedWidth = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 80;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Hàng hóa";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.FixedWidth = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 180;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Đơn vị";
            this.colUnit.ColumnEdit = this.rpUnit;
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.FixedWidth = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Visible = true;
            this.colUnit.Width = 80;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoHeight = false;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DataSource = this.uNITBindingSource;
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.repositoryItemGridLookUpEdit1View;
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
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Tồn";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.FixedWidth = true;
            this.colQuantity.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 80;
            // 
            // colMinStock
            // 
            this.colMinStock.Caption = "Định Mức";
            this.colMinStock.ColumnEdit = this.rpVal;
            this.colMinStock.FieldName = "MinStock";
            this.colMinStock.Name = "colMinStock";
            this.colMinStock.OptionsColumn.FixedWidth = true;
            this.colMinStock.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMinStock.Visible = true;
            this.colMinStock.Width = 80;
            // 
            // colOrder
            // 
            this.colOrder.Caption = "Yêu Cầu Đặt Hàng";
            this.colOrder.ColumnEdit = this.rpVal;
            this.colOrder.FieldName = "Order";
            this.colOrder.Name = "colOrder";
            this.colOrder.OptionsColumn.FixedWidth = true;
            this.colOrder.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOrder.Visible = true;
            this.colOrder.Width = 141;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.AllowEdit = false;
            this.colStock_Name.OptionsColumn.FixedWidth = true;
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.RowIndex = 1;
            this.colStock_Name.Width = 140;
            // 
            // rpProductGroup
            // 
            this.rpProductGroup.AutoHeight = false;
            this.rpProductGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpProductGroup.Name = "rpProductGroup";
            this.rpProductGroup.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcList;
            this.gridView2.Name = "gridView2";
            // 
            // plBottom
            // 
            this.plBottom.Controls.Add(this.uhm);
            this.plBottom.Controls.Add(this.txtQuantity);
            this.plBottom.Controls.Add(this.txtTotal);
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(0, 436);
            this.plBottom.Name = "plBottom";
            this.plBottom.Size = new System.Drawing.Size(967, 33);
            this.plBottom.TabIndex = 20;
            this.plBottom.Visible = false;
            // 
            // uhm
            // 
            this.uhm.Location = new System.Drawing.Point(8, 10);
            this.uhm.Name = "uhm";
            this.uhm.Size = new System.Drawing.Size(50, 13);
            this.uhm.TabIndex = 10;
            this.uhm.Text = "Tổng cộng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(64, 7);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtQuantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.NullText = "0";
            this.txtQuantity.Properties.ReadOnly = true;
            this.txtQuantity.Properties.ShowCloseButton = true;
            this.txtQuantity.Size = new System.Drawing.Size(112, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(182, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotal.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotal.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotal.Properties.NullText = "0";
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Properties.ShowCloseButton = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(52, "point_yellow.ico");
            this.imageCollection2.Images.SetKeyName(53, "point_blue.ico");
            this.imageCollection2.Images.SetKeyName(54, "point_cyan.ico");
            this.imageCollection2.Images.SetKeyName(55, "point_green.ico");
            this.imageCollection2.Images.SetKeyName(56, "point_red.ico");
            this.imageCollection2.Images.SetKeyName(57, "calculator.ico");
            this.imageCollection2.Images.SetKeyName(58, "4520.ico");
            this.imageCollection2.Images.SetKeyName(59, "4522.ico");
            this.imageCollection2.Images.SetKeyName(60, "4544.ico");
            this.imageCollection2.Images.SetKeyName(61, "4557.ico");
            this.imageCollection2.Images.SetKeyName(62, "4562.ico");
            this.imageCollection2.Images.SetKeyName(63, "4563.ico");
            this.imageCollection2.Images.SetKeyName(64, "4577.ico");
            this.imageCollection2.Images.SetKeyName(65, "app.ico");
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(321, 7);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 20);
            this.txtProductName.TabIndex = 18;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(222, 7);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(95, 20);
            this.txtProductID.TabIndex = 17;
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.cbxStock);
            this.plTop.Controls.Add(this.lblStock);
            this.plTop.Controls.Add(this.txtProductName);
            this.plTop.Controls.Add(this.txtProductID);
            this.plTop.Controls.Add(this.btnExport);
            this.plTop.Controls.Add(this.btnView);
            this.plTop.Controls.Add(this.btnPrint);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(967, 34);
            this.plTop.TabIndex = 19;
            // 
            // cbxStock
            // 
            this.cbxStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStock.DataSource = this.sTOCKBindingSource;
            this.cbxStock.DisplayMember = "Stock_Name";
            this.cbxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStock.FormattingEnabled = true;
            this.cbxStock.Location = new System.Drawing.Point(28, 6);
            this.cbxStock.Name = "cbxStock";
            this.cbxStock.Size = new System.Drawing.Size(188, 21);
            this.cbxStock.TabIndex = 22;
            this.cbxStock.ValueMember = "Stock_ID";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(5, 10);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(18, 13);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "Kho";
            // 
            // btnExport
            // 
            this.btnExport.ImageIndex = 51;
            this.btnExport.ImageList = this.imageCollection2;
            this.btnExport.Location = new System.Drawing.Point(642, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(70, 27);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnView
            // 
            this.btnView.ImageIndex = 44;
            this.btnView.ImageList = this.imageCollection2;
            this.btnView.Location = new System.Drawing.Point(570, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 27);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageIndex = 9;
            this.btnPrint.ImageList = this.imageCollection2;
            this.btnPrint.Location = new System.Drawing.Point(714, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 27);
            superToolTip1.FixedTooltipWidth = true;
            toolTipTitleItem1.Text = "Thông tin";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "In bảng kê hóa đơn đầu vào";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.MaxWidth = 210;
            this.btnPrint.SuperTip = superToolTip1;
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "In";
            this.btnPrint.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // STOCKAdapter
            // 
            
            // 
            // iNVENTORY_ORDERTableAdapter
            // 
            this.iNVENTORY_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(967, 402);
            this.panelControl2.TabIndex = 17;
            // 
            // uNITTableAdapter
            // 
         
            // 
            // bm
            // 
            this.bm.AutoSaveInRegistry = true;
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.imageCollection2;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPrint,
            this.bbiRefresh,
            this.bbiExport,
            this.bbiHelp,
            this.bbiClose,
            this.bbiProductDetail,
            this.bbiProduct,
            this.bbiHistory,
            this.bbiImport,
            this.bbiOtherView});
            this.bm.MaxItemId = 22;
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "In";
            this.bbiPrint.Id = 3;
            this.bbiPrint.ImageIndex = 9;
            this.bbiPrint.Name = "bbiPrint";
            this.bbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiRefresh.Appearance.Options.UseFont = true;
            this.bbiRefresh.Caption = "Xem";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageIndex = 44;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Xuất";
            this.bbiExport.Id = 5;
            this.bbiExport.ImageIndex = 51;
            this.bbiExport.LargeImageIndex = 19;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bbiHelp
            // 
            this.bbiHelp.Caption = "Trợ Giúp";
            this.bbiHelp.Id = 6;
            this.bbiHelp.ImageIndex = 25;
            this.bbiHelp.Name = "bbiHelp";
            this.bbiHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHelp_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Đóng";
            this.bbiClose.Id = 10;
            this.bbiClose.ImageIndex = 22;
            this.bbiClose.LargeImageIndex = 1;
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiProductDetail
            // 
            this.bbiProductDetail.Caption = "Chi Tiết";
            this.bbiProductDetail.Id = 13;
            this.bbiProductDetail.ImageIndex = 59;
            this.bbiProductDetail.Name = "bbiProductDetail";
            this.bbiProductDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProductDetail_ItemClick);
            // 
            // bbiProduct
            // 
            this.bbiProduct.Caption = "Hàng Hoá";
            this.bbiProduct.Id = 14;
            this.bbiProduct.ImageIndex = 24;
            this.bbiProduct.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHistory),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductDetail)});
            this.bbiProduct.Name = "bbiProduct";
            // 
            // bbiHistory
            // 
            this.bbiHistory.Caption = "Lịch Sử";
            this.bbiHistory.Id = 15;
            this.bbiHistory.ImageIndex = 61;
            this.bbiHistory.Name = "bbiHistory";
            this.bbiHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHistory_ItemClick);
            // 
            // bbiImport
            // 
            this.bbiImport.Caption = "Nhập...";
            this.bbiImport.Id = 16;
            this.bbiImport.ImageIndex = 3;
            this.bbiImport.Name = "bbiImport";
            toolTipItem2.Text = "Chuyển dữ Liệu Từ Excel vào Phần Mềm";
            superToolTip2.Items.Add(toolTipItem2);
            this.bbiImport.SuperTip = superToolTip2;
            // 
            // bbiOtherView
            // 
            this.bbiOtherView.Caption = "Xem Khác...";
            this.bbiOtherView.Id = 17;
            this.bbiOtherView.ImageIndex = 0;
            this.bbiOtherView.Name = "bbiOtherView";
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiProduct, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose, true)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // sTOCKTableAdapter
            // 
          
            // 
            // xucInventoryBelower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.plBottom);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xucInventoryBelower";
            this.Size = new System.Drawing.Size(967, 469);
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventoryOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.plBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        protected DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl plBottom;
        private DevExpress.XtraEditors.LabelControl uhm;
        protected DevExpress.XtraEditors.CalcEdit txtQuantity;
        protected DevExpress.XtraEditors.CalcEdit txtTotal;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.PanelControl plTop;
        protected DevExpress.XtraEditors.SimpleButton btnExport;
        protected DevExpress.XtraEditors.SimpleButton btnView;
        protected DevExpress.XtraEditors.SimpleButton btnPrint;
        private dsInventoryOrder dsInventoryOrder;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private INVENTORY_ORDERTableAdapter iNVENTORY_ORDERTableAdapter;
        private System.Windows.Forms.BindingSource iNVENTORYORDERBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrder;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiHelp;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiProductDetail;
        private DevExpress.XtraBars.BarSubItem bbiProduct;
        private DevExpress.XtraBars.BarButtonItem bbiHistory;
        private DevExpress.XtraBars.BarButtonItem bbiImport;
        private DevExpress.XtraBars.PopupMenu pm;
        private DevExpress.XtraBars.BarSubItem bbiOtherView;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpStock;
        private System.Windows.Forms.BindingSource sTOCKBindingSource1;
        private dsSTOCK dsSTOCK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpProductGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.ComboBox cbxStock;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMinStock;
    }
}
