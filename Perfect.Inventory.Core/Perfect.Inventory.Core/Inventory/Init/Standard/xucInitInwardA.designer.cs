using Perfect.Inventory.Core.Common.DS;
using Perfect.Inventory.Core.Inventory.Inward;
using Perfect.Inventory.Core.Inventory.Inward;

namespace Perfect.Inventory.Core.Inventory.Init.Standard
{
    partial class XucInitInwardA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucInitInwardA));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtReciever = new DevExpress.XtraEditors.TextEdit();
            this.txtExchangeRate = new DevExpress.XtraEditors.CalcEdit();
            this.cbCurrency = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.dtCreated = new DevExpress.XtraEditors.DateEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.sTOCKINWARDDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK_INWARD_DETAIL = new Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAIL();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgProduct = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Inventory.Core.Common.DS.dsPRODUCT();
            this.rpglkProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpProductName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnit_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitConvert = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLimit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDiscount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCharge = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcList = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcCreated = new DevExpress.XtraLayout.LayoutControlItem();
            this.liCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.liExChangeRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.pROVIDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPROVIDER = new Perfect.Inventory.Core.Inventory.Inward.dsPROVIDER();
            this.sTOCKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVIDERTableAdapter = new Perfect.Inventory.Core.Inventory.Inward.dsPROVIDERTableAdapters.PROVIDERTableAdapter();
            this.colActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveInt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReciever.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINWARDDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_INWARD_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCreated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liExChangeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPROVIDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plBottom
            // 
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBottom.Location = new System.Drawing.Point(0, 0);
            this.plBottom.Size = new System.Drawing.Size(968, 31);
            // 
            // ucBarB
            // 
            this.ucBarB.Size = new System.Drawing.Size(964, 27);
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.CustomizationCaption = "Thành Tiền";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.OptionsColumn.FixedWidth = true;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.Width = 112;
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
            this.rpVal.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.rpVal.Name = "rpVal";
            this.rpVal.ShowCloseButton = true;
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "Số Lượng";
            this.colQuantity1.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 2;
            this.colQuantity1.Width = 167;
            // 
            // colQuantity2
            // 
            this.colQuantity2.Caption = "Số Lượng";
            this.colQuantity2.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity2.FieldName = "Quantity";
            this.colQuantity2.Name = "colQuantity2";
            this.colQuantity2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQuantity2.Visible = true;
            this.colQuantity2.VisibleIndex = 2;
            this.colQuantity2.Width = 180;
            // 
            // lcMain
            // 
            this.lcMain.AllowDrop = true;
            this.lcMain.Controls.Add(this.txtReciever);
            this.lcMain.Controls.Add(this.txtExchangeRate);
            this.lcMain.Controls.Add(this.cbCurrency);
            this.lcMain.Controls.Add(this.txtID);
            this.lcMain.Controls.Add(this.dtCreated);
            this.lcMain.Controls.Add(this.gcList);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 31);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsFocus.AllowFocusControlOnActivatedTabPage = true;
            this.lcMain.OptionsView.AllowHotTrack = true;
            this.lcMain.OptionsView.EnableIndentsInGroupsWithoutBorders = true;
            this.lcMain.OptionsView.HighlightDisabledItem = true;
            this.lcMain.OptionsView.HighlightFocusedItem = true;
            this.lcMain.Root = this.layoutControlGroup2;
            this.lcMain.Size = new System.Drawing.Size(968, 599);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtReciever
            // 
            this.txtReciever.Location = new System.Drawing.Point(70, 10);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.Size = new System.Drawing.Size(689, 20);
            this.txtReciever.StyleController = this.lcMain;
            this.txtReciever.TabIndex = 18;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExchangeRate.Location = new System.Drawing.Point(883, 58);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExchangeRate.Properties.Mask.BeepOnError = true;
            this.txtExchangeRate.Properties.Mask.EditMask = "n2";
            this.txtExchangeRate.Properties.ReadOnly = true;
            this.txtExchangeRate.Size = new System.Drawing.Size(75, 20);
            this.txtExchangeRate.StyleController = this.lcMain;
            this.txtExchangeRate.TabIndex = 14;
            // 
            // cbCurrency
            // 
            this.cbCurrency.EditValue = "VND";
            this.cbCurrency.Location = new System.Drawing.Point(829, 58);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCurrency.Properties.Items.AddRange(new object[] {
            "VND",
            "USD"});
            this.cbCurrency.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbCurrency.Size = new System.Drawing.Size(50, 20);
            this.cbCurrency.StyleController = this.lcMain;
            this.cbCurrency.TabIndex = 13;
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.CbCurrencySelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(829, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.StyleController = this.lcMain;
            this.txtID.TabIndex = 6;
            this.txtID.EditValueChanged += new System.EventHandler(this.TxtIDEditValueChanged);
            this.txtID.Leave += new System.EventHandler(this.TxtIDLeave);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIDKeyDown);
            // 
            // dtCreated
            // 
            this.dtCreated.EditValue = new System.DateTime(2008, 2, 8, 14, 22, 49, 437);
            this.dtCreated.Location = new System.Drawing.Point(829, 34);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCreated.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.dtCreated.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtCreated.Properties.NullDate = new System.DateTime(2008, 2, 8, 14, 23, 58, 359);
            this.dtCreated.Properties.UseParentBackground = true;
            this.dtCreated.Properties.ValidateOnEnterKey = true;
            this.dtCreated.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtCreated.Size = new System.Drawing.Size(129, 20);
            this.dtCreated.StyleController = this.lcMain;
            this.dtCreated.TabIndex = 7;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sTOCKINWARDDETAILBindingSource;
            this.gcList.Location = new System.Drawing.Point(9, 85);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpgProduct,
            this.rpgStock,
            this.rpProductName,
            this.rpUnit,
            this.rpDate,
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(956, 511);
            this.gcList.TabIndex = 12;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // sTOCKINWARDDETAILBindingSource
            // 
            this.sTOCKINWARDDETAILBindingSource.DataMember = "STOCK_INWARD_DETAIL";
            this.sTOCKINWARDDETAILBindingSource.DataSource = this.dsSTOCK_INWARD_DETAIL;
            // 
            // dsSTOCK_INWARD_DETAIL
            // 
            this.dsSTOCK_INWARD_DETAIL.DataSetName = "dsSTOCK_INWARD_DETAIL";
            this.dsSTOCK_INWARD_DETAIL.EnforceConstraints = false;
            this.dsSTOCK_INWARD_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.Row.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_ID,
            this.colProductName,
            this.colStock_ID,
            this.colVat,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colLimit,
            this.colUnit,
            this.colDiscount,
            this.colCharge,
            this.colDescription,
            this.colUnitConvert});
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colAmount;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", this.colAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.colQuantity, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 45;
            this.gbList.Name = "gbList";
            this.gbList.NewItemRowText = "(Thêm dòng mới)";
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gbList.OptionsCustomization.AllowBandMoving = false;
            this.gbList.OptionsCustomization.AllowBandResizing = false;
            this.gbList.OptionsCustomization.AllowColumnMoving = false;
            this.gbList.OptionsCustomization.AllowFilter = false;
            this.gbList.OptionsCustomization.AllowGroup = false;
            this.gbList.OptionsCustomization.AllowQuickHideColumns = false;
            this.gbList.OptionsCustomization.AllowSort = false;
            this.gbList.OptionsCustomization.ShowBandsInCustomizationForm = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gbList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.VertScrollTipFieldName = "Product_ID";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GbListCellValueChanged);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GbListKeyDown);
            this.gbList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GbListCellValueChanging);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProductName);
            this.gridBand1.Columns.Add(this.colStock_ID);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colVat);
            this.gridBand1.Columns.Add(this.colUnitConvert);
            this.gridBand1.Columns.Add(this.colQuantity);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Columns.Add(this.colLimit);
            this.gridBand1.Columns.Add(this.colDiscount);
            this.gridBand1.Columns.Add(this.colCharge);
            this.gridBand1.Columns.Add(this.colDescription);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 978;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.ColumnEdit = this.rpgProduct;
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProduct_ID.OptionsColumn.FixedWidth = true;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 142;
            // 
            // rpgProduct
            // 
            this.rpgProduct.ActionButtonIndex = 2;
            this.rpgProduct.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            serializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.rpgProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Search", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons1"))), new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject2, "", "Add", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "None", null, true)});
            this.rpgProduct.DataSource = this.pRODUCTBindingSource;
            this.rpgProduct.DisplayMember = "Product_ID";
            this.rpgProduct.ImmediatePopup = true;
            this.rpgProduct.Name = "rpgProduct";
            this.rpgProduct.NullText = "";
            this.rpgProduct.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpgProduct.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgProduct.ValidateOnEnterKey = true;
            this.rpgProduct.ValueMember = "Product_ID";
            this.rpgProduct.View = this.rpglkProduct;
            this.rpgProduct.DoubleClick += new System.EventHandler(this.RpgProductDoubleClick);
            this.rpgProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RpgProductKeyDown);
            this.rpgProduct.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.RpgProductCloseUp);
            this.rpgProduct.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RpgProductButtonClick);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dsPRODUCT;
            // 
            // dsPRODUCT
            // 
            this.dsPRODUCT.DataSetName = "dsPRODUCT";
            this.dsPRODUCT.EnforceConstraints = false;
            this.dsPRODUCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpglkProduct
            // 
            this.rpglkProduct.Appearance.FilterCloseButton.Options.UseFont = true;
            this.rpglkProduct.Appearance.GroupButton.ForeColor = System.Drawing.Color.Red;
            this.rpglkProduct.Appearance.GroupButton.Options.UseForeColor = true;
            this.rpglkProduct.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rpglkProduct.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.rpglkProduct.Appearance.GroupRow.Options.UseFont = true;
            this.rpglkProduct.Appearance.GroupRow.Options.UseForeColor = true;
            this.rpglkProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID1,
            this.colProduct_Name,
            this.colQuantity1,
            this.colStock_Name,
            this.colActiveInt});
            this.rpglkProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.rpglkProduct.OptionsBehavior.AutoExpandAllGroups = true;
            this.rpglkProduct.OptionsFilter.UseNewCustomFilterDialog = true;
            this.rpglkProduct.OptionsPrint.ExpandAllDetails = true;
            this.rpglkProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rpglkProduct.OptionsView.ShowAutoFilterRow = true;
            this.rpglkProduct.OptionsView.ShowGroupPanel = false;
            this.rpglkProduct.OptionsView.ShowIndicator = false;
            this.rpglkProduct.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.RpglkProductCustomDrawRowIndicator);
            // 
            // colProduct_ID1
            // 
            this.colProduct_ID1.Caption = "Mã Hàng";
            this.colProduct_ID1.FieldName = "Product_ID";
            this.colProduct_ID1.Name = "colProduct_ID1";
            this.colProduct_ID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID1.Visible = true;
            this.colProduct_ID1.VisibleIndex = 0;
            this.colProduct_ID1.Width = 139;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Hàng Hoá";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 1;
            this.colProduct_Name.Width = 662;
            // 
            // colStock_Name
            // 
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.Visible = true;
            this.colStock_Name.VisibleIndex = 3;
            this.colStock_Name.Width = 139;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Tên Hàng";
            this.colProductName.ColumnEdit = this.rpProductName;
            this.colProductName.FieldName = "Product_Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colProductName.OptionsColumn.FixedWidth = true;
            this.colProductName.Visible = true;
            this.colProductName.Width = 292;
            // 
            // rpProductName
            // 
            this.rpProductName.ActionButtonIndex = 2;
            this.rpProductName.AutoHeight = false;
            this.rpProductName.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpProductName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", "Search", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", "Add", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", "None", null, true)});
            this.rpProductName.DataSource = this.pRODUCTBindingSource;
            this.rpProductName.DisplayMember = "Product_Name";
            this.rpProductName.ImmediatePopup = true;
            this.rpProductName.Name = "rpProductName";
            this.rpProductName.NullText = "(Nhập vào tên hàng hoá)";
            this.rpProductName.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpProductName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpProductName.ValueMember = "Product_Name";
            this.rpProductName.View = this.gridView1;
            this.rpProductName.DoubleClick += new System.EventHandler(this.RpProductNameDoubleClick);
            this.rpProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RpgProductKeyDown);
            this.rpProductName.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.RpProductNameCloseUp);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID2,
            this.colProduct_Name1,
            this.colQuantity2,
            this.colStock_Name1,
            this.colActiveInt1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colProduct_ID2
            // 
            this.colProduct_ID2.Caption = "Mã Hàng";
            this.colProduct_ID2.FieldName = "Product_ID";
            this.colProduct_ID2.Name = "colProduct_ID2";
            this.colProduct_ID2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID2.Visible = true;
            this.colProduct_ID2.VisibleIndex = 0;
            this.colProduct_ID2.Width = 150;
            // 
            // colProduct_Name1
            // 
            this.colProduct_Name1.Caption = "Hàng Hoá";
            this.colProduct_Name1.FieldName = "Product_Name";
            this.colProduct_Name1.Name = "colProduct_Name1";
            this.colProduct_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name1.Visible = true;
            this.colProduct_Name1.VisibleIndex = 1;
            this.colProduct_Name1.Width = 591;
            // 
            // colStock_Name1
            // 
            this.colStock_Name1.Caption = "Kho Hàng";
            this.colStock_Name1.FieldName = "Stock_Name";
            this.colStock_Name1.Name = "colStock_Name1";
            this.colStock_Name1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name1.Visible = true;
            this.colStock_Name1.VisibleIndex = 3;
            this.colStock_Name1.Width = 186;
            // 
            // colStock_ID
            // 
            this.colStock_ID.Caption = "Kho Hàng";
            this.colStock_ID.ColumnEdit = this.rpgStock;
            this.colStock_ID.FieldName = "Stock_ID";
            this.colStock_ID.Name = "colStock_ID";
            this.colStock_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStock_ID.OptionsColumn.FixedWidth = true;
            this.colStock_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID.Visible = true;
            this.colStock_ID.Width = 188;
            // 
            // rpgStock
            // 
            this.rpgStock.AutoHeight = false;
            this.rpgStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpgStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpgStock.DataSource = this.sTOCKBindingSource1;
            this.rpgStock.DisplayMember = "Stock_Name";
            this.rpgStock.ImmediatePopup = true;
            this.rpgStock.Name = "rpgStock";
            this.rpgStock.NullText = "";
            this.rpgStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgStock.ValueMember = "Stock_ID";
            this.rpgStock.View = this.repositoryItemGridLookUpEdit1View;
            this.rpgStock.DoubleClick += new System.EventHandler(this.RpgStockDoubleClick);
            this.rpgStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RpgProductKeyDown);
            this.rpgStock.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.RpgStockCloseUp);
            // 
            // sTOCKBindingSource1
            // 
            this.sTOCKBindingSource1.DataMember = "STOCK";
            this.sTOCKBindingSource1.DataSource = this.dsSTOCK;
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
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Đơn Vị";
            this.colUnit.ColumnEdit = this.rpUnit;
            this.colUnit.CustomizationCaption = "Đơn Vị Tính";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnit.OptionsColumn.FixedWidth = true;
            this.colUnit.Visible = true;
            this.colUnit.Width = 82;
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
            this.rpUnit.NullText = "";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.gridView2;
            this.rpUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RpgProductKeyDown);
            this.rpUnit.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.RpUnitCloseUp);
            // 
            // uNITBindingSource
            // 
            this.uNITBindingSource.DataMember = "UNIT";
            this.uNITBindingSource.DataSource = this.dsUnit;
            // 
            // dsUnit
            // 
            this.dsUnit.DataSetName = "dsUnit";
            this.dsUnit.EnforceConstraints = false;
            this.dsUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnit_ID,
            this.colUnit_Name});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // colUnit_ID
            // 
            this.colUnit_ID.Caption = "Mã Đơn Vị";
            this.colUnit_ID.FieldName = "Unit_ID";
            this.colUnit_ID.Name = "colUnit_ID";
            this.colUnit_ID.Visible = true;
            this.colUnit_ID.VisibleIndex = 0;
            // 
            // colUnit_Name
            // 
            this.colUnit_Name.Caption = "Tên Đơn Vị";
            this.colUnit_Name.FieldName = "Unit_Name";
            this.colUnit_Name.Name = "colUnit_Name";
            this.colUnit_Name.Visible = true;
            this.colUnit_Name.VisibleIndex = 1;
            // 
            // colVat
            // 
            this.colVat.Caption = "Vat";
            this.colVat.CustomizationCaption = "Thuế VAT";
            this.colVat.FieldName = "Vat";
            this.colVat.Name = "colVat";
            this.colVat.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colVat.OptionsColumn.FixedWidth = true;
            // 
            // colUnitConvert
            // 
            this.colUnitConvert.FieldName = "UnitConvert";
            this.colUnitConvert.Name = "colUnitConvert";
            this.colUnitConvert.OptionsColumn.AllowSize = false;
            this.colUnitConvert.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số Lượng";
            this.colQuantity.ColumnEdit = this.rpVal;
            this.colQuantity.CustomizationCaption = "Số Lượng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colQuantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.FixedWidth = true;
            this.colQuantity.SummaryItem.DisplayFormat = " {0:##,##0.###}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 78;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Đơn Giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.CustomizationCaption = "Đơn Giá";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitPrice.OptionsColumn.FixedWidth = true;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.Width = 84;
            // 
            // colLimit
            // 
            this.colLimit.Caption = "Hạn Dùng";
            this.colLimit.ColumnEdit = this.rpDate;
            this.colLimit.CustomizationCaption = "Hạn Sử Dụng";
            this.colLimit.FieldName = "Limit";
            this.colLimit.Name = "colLimit";
            this.colLimit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLimit.OptionsColumn.FixedWidth = true;
            this.colLimit.Width = 71;
            // 
            // rpDate
            // 
            this.rpDate.AutoHeight = false;
            this.rpDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.rpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpDate.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            this.rpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpDate.Mask.EditMask = "dd/MM/yyyy";
            this.rpDate.Name = "rpDate";
            this.rpDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Chiết Khấu";
            this.colDiscount.CustomizationCaption = "Chiết Khấu - Khuyến Mãi";
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDiscount.OptionsColumn.FixedWidth = true;
            // 
            // colCharge
            // 
            this.colCharge.Caption = "Chi Phí";
            this.colCharge.CustomizationCaption = "Chi Phí";
            this.colCharge.FieldName = "Charge";
            this.colCharge.Name = "colCharge";
            this.colCharge.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCharge.OptionsColumn.FixedWidth = true;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi Chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsColumn.FixedWidth = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(70, 34);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(689, 44);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TabStop = false;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescriptionKeyPress);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Root";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcList,
            this.splitterItem2,
            this.layoutControlGroup1,
            this.layoutControlGroup3,
            this.splitterItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Size = new System.Drawing.Size(968, 599);
            this.layoutControlGroup2.Text = "Root";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // lcList
            // 
            this.lcList.Control = this.gcList;
            this.lcList.CustomizationFormText = "lcList";
            this.lcList.Location = new System.Drawing.Point(6, 82);
            this.lcList.Name = "lcList";
            this.lcList.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcList.Size = new System.Drawing.Size(956, 511);
            this.lcList.Text = "lcList";
            this.lcList.TextSize = new System.Drawing.Size(0, 0);
            this.lcList.TextToControlDistance = 0;
            this.lcList.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(0, 82);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(6, 511);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.lcDescription});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(763, 82);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtReciever;
            this.layoutControlItem2.CustomizationFormText = "Người Nhận";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(753, 24);
            this.layoutControlItem2.Text = "Người Nhập";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // lcDescription
            // 
            this.lcDescription.Control = this.txtDescription;
            this.lcDescription.CustomizationFormText = "Ghi Chú";
            this.lcDescription.Location = new System.Drawing.Point(0, 24);
            this.lcDescription.Name = "lcDescription";
            this.lcDescription.Size = new System.Drawing.Size(753, 48);
            this.lcDescription.Text = "Ghi Chú";
            this.lcDescription.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcID,
            this.lcCreated,
            this.liCurrency,
            this.liExChangeRate});
            this.layoutControlGroup3.Location = new System.Drawing.Point(769, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup3.ShowInCustomizationForm = false;
            this.layoutControlGroup3.ShowTabPageCloseButton = true;
            this.layoutControlGroup3.Size = new System.Drawing.Size(193, 82);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lcID
            // 
            this.lcID.Control = this.txtID;
            this.lcID.CustomizationFormText = "Phiếu";
            this.lcID.Location = new System.Drawing.Point(0, 0);
            this.lcID.MaxSize = new System.Drawing.Size(183, 24);
            this.lcID.MinSize = new System.Drawing.Size(183, 24);
            this.lcID.Name = "lcID";
            this.lcID.Size = new System.Drawing.Size(183, 24);
            this.lcID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcID.Text = "Phiếu";
            this.lcID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcID.TextSize = new System.Drawing.Size(45, 20);
            this.lcID.TextToControlDistance = 5;
            // 
            // lcCreated
            // 
            this.lcCreated.Control = this.dtCreated;
            this.lcCreated.CustomizationFormText = "Ngày";
            this.lcCreated.Location = new System.Drawing.Point(0, 24);
            this.lcCreated.MaxSize = new System.Drawing.Size(183, 24);
            this.lcCreated.MinSize = new System.Drawing.Size(183, 24);
            this.lcCreated.Name = "lcCreated";
            this.lcCreated.Size = new System.Drawing.Size(183, 24);
            this.lcCreated.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcCreated.Text = "Ngày";
            this.lcCreated.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcCreated.TextSize = new System.Drawing.Size(45, 20);
            this.lcCreated.TextToControlDistance = 5;
            // 
            // liCurrency
            // 
            this.liCurrency.Control = this.cbCurrency;
            this.liCurrency.CustomizationFormText = "Loại Tiền";
            this.liCurrency.Location = new System.Drawing.Point(0, 48);
            this.liCurrency.Name = "liCurrency";
            this.liCurrency.Size = new System.Drawing.Size(104, 24);
            this.liCurrency.Text = "Loại Tiền";
            this.liCurrency.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.liCurrency.TextSize = new System.Drawing.Size(45, 13);
            this.liCurrency.TextToControlDistance = 5;
            this.liCurrency.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // liExChangeRate
            // 
            this.liExChangeRate.Control = this.txtExchangeRate;
            this.liExChangeRate.CustomizationFormText = "liExChangeRate";
            this.liExChangeRate.Location = new System.Drawing.Point(104, 48);
            this.liExChangeRate.Name = "liExChangeRate";
            this.liExChangeRate.Size = new System.Drawing.Size(79, 24);
            this.liExChangeRate.Text = "liExChangeRate";
            this.liExChangeRate.TextSize = new System.Drawing.Size(0, 0);
            this.liExChangeRate.TextToControlDistance = 0;
            this.liExChangeRate.TextVisible = false;
            this.liExChangeRate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.CustomizationFormText = "splitterItem3";
            this.splitterItem3.Location = new System.Drawing.Point(763, 0);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(6, 82);
            // 
            // pROVIDERBindingSource
            // 
            this.pROVIDERBindingSource.DataMember = "PROVIDER";
            this.pROVIDERBindingSource.DataSource = this.dsPROVIDER;
            // 
            // dsPROVIDER
            // 
            this.dsPROVIDER.DataSetName = "dsPROVIDER";
            this.dsPROVIDER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKBindingSource2
            // 
            this.sTOCKBindingSource2.DataMember = "STOCK";
            this.sTOCKBindingSource2.DataSource = this.dsSTOCK;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.dsPRODUCT;
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsSTOCK;
            // 
            // pROVIDERTableAdapter
            // 
            this.pROVIDERTableAdapter.ClearBeforeFill = true;
            // 
            // colActiveInt
            // 
            this.colActiveInt.FieldName = "ActiveInt";
            this.colActiveInt.Name = "colActiveInt";
            // 
            // colActiveInt1
            // 
            this.colActiveInt1.FieldName = "ActiveInt";
            this.colActiveInt1.Name = "colActiveInt1";
            // 
            // XucInitInwardA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lcMain);
            this.Name = "XucInitInwardA";
            this.NotSave = true;
            this.Size = new System.Drawing.Size(968, 630);
            this.Load += new System.EventHandler(this.XucInwardsLoad);
            this.Controls.SetChildIndex(this.plBottom, 0);
            this.Controls.SetChildIndex(this.lcMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReciever.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINWARDDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_INWARD_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCreated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liExChangeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPROVIDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtCreated;
        private DevExpress.XtraEditors.TextEdit txtID;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView rpglkProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProductName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiscount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCharge;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private System.Windows.Forms.BindingSource pROVIDERBindingSource;
        private dsPROVIDER dsPROVIDER;
        private Perfect.Inventory.Core.Inventory.Inward.dsPROVIDERTableAdapters.PROVIDERTableAdapter pROVIDERTableAdapter;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        private System.Windows.Forms.BindingSource sTOCKINWARDDETAILBindingSource;
        private dsSTOCK_INWARD_DETAIL dsSTOCK_INWARD_DETAIL;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private dsPRODUCT dsPRODUCT;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private System.Windows.Forms.BindingSource sTOCKBindingSource1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLimit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private System.Windows.Forms.BindingSource sTOCKBindingSource2;
       
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lcList;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cbCurrency;
        private DevExpress.XtraEditors.CalcEdit txtExchangeRate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConvert;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity2;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit_Name;
        private DevExpress.XtraEditors.TextEdit txtReciever;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem lcDescription;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lcID;
        private DevExpress.XtraLayout.LayoutControlItem lcCreated;
        private DevExpress.XtraLayout.LayoutControlItem liCurrency;
        private DevExpress.XtraLayout.LayoutControlItem liExChangeRate;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveInt1;
    }
}
