using Perfect.Dictionary.UI.UBarcode;
using Perfect.Inventory.Core.Common.DS;

namespace Perfect.Inventory.Core.Inventory.Transfer.SALE
{
    partial class xucAdjustment
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucAdjustment));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtProductGroup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Inventory.Core.Common.DS.dsSTOCK();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtStockID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.aDJUSTMENTDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjust = new Perfect.Inventory.Core.Inventory.Adjusment.DS.dsAdjust();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAdjustment_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStock_ID3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitConvert = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colWidth = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHeight = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrgin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQtyConvert = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStoreID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBatch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSerial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSorted = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCurrentQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNewQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colQtyDiff = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgProduct = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Inventory.Core.Common.DS.dsPRODUCT();
            this.rpglkProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpgStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpProductName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg_Price1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPActiveInt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Inventory.Core.Common.DS.dsUnit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpToStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTActiveInt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.txtCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtEmployee = new DevExpress.XtraEditors.GridLookUpEdit();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmployee = new Perfect.Inventory.Core.Inventory.Transfer.dsEmployee();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCreatedBy = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.lcID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcEmployeeName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pRODUCTTableAdapter = new Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters.PRODUCTTableAdapter();
            this.aDJUSTMENT_DETAILTableAdapter = new Perfect.Inventory.Core.Inventory.Adjusment.DS.dsAdjustTableAdapters.ADJUSTMENT_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJUSTMENTDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpToStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // plBottom
            // 
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBottom.Location = new System.Drawing.Point(0, 0);
            this.plBottom.Size = new System.Drawing.Size(1000, 31);
            // 
            // ucBarB
            // 
            this.ucBarB.Size = new System.Drawing.Size(996, 27);
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
            this.lcMain.Controls.Add(this.txtProductGroup);
            this.lcMain.Controls.Add(this.txtStockID);
            this.lcMain.Controls.Add(this.gcList);
            this.lcMain.Controls.Add(this.txtCreatedDate);
            this.lcMain.Controls.Add(this.txtID);
            this.lcMain.Controls.Add(this.txtEmployee);
            this.lcMain.Controls.Add(this.txtCreatedBy);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 31);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.layoutControlGroup1;
            this.lcMain.Size = new System.Drawing.Size(1000, 567);
            this.lcMain.TabIndex = 2;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtProductGroup
            // 
            this.Err.SetIconAlignment(this.txtProductGroup, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtProductGroup.Location = new System.Drawing.Point(90, 29);
            this.txtProductGroup.Name = "txtProductGroup";
            this.txtProductGroup.Properties.ActionButtonIndex = 2;
            this.txtProductGroup.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtProductGroup.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtProductGroup.Properties.Appearance.Options.UseBackColor = true;
            this.txtProductGroup.Properties.Appearance.Options.UseFont = true;
            this.txtProductGroup.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductGroup.Properties.AutoComplete = false;
            this.txtProductGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtProductGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "None", null, true)});
            this.txtProductGroup.Properties.DataSource = this.sTOCKBindingSource;
            this.txtProductGroup.Properties.DisplayMember = "Stock_Name";
            this.txtProductGroup.Properties.NullText = "";
            this.txtProductGroup.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtProductGroup.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtProductGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtProductGroup.Properties.UseParentBackground = true;
            this.txtProductGroup.Properties.ValidateOnEnterKey = true;
            this.txtProductGroup.Properties.ValueMember = "Stock_ID";
            this.txtProductGroup.Properties.View = this.gridView6; 
            this.txtProductGroup.Size = new System.Drawing.Size(282, 20);
            this.txtProductGroup.StyleController = this.lcMain;
            this.txtProductGroup.TabIndex = 41;
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
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Tên kho";
            this.gridColumn1.FieldName = "Stock_Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Mã số";
            this.gridColumn2.FieldName = "Stock_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // txtStockID
            // 
            this.Err.SetIconAlignment(this.txtStockID, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtStockID.Location = new System.Drawing.Point(90, 5);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Properties.ActionButtonIndex = 2;
            this.txtStockID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtStockID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStockID.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtStockID.Properties.Appearance.Options.UseBackColor = true;
            this.txtStockID.Properties.Appearance.Options.UseFont = true;
            this.txtStockID.Properties.Appearance.Options.UseForeColor = true;
            this.txtStockID.Properties.AutoComplete = false;
            this.txtStockID.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "None", null, true)});
            this.txtStockID.Properties.DataSource = this.sTOCKBindingSource;
            this.txtStockID.Properties.DisplayMember = "Stock_Name";
            this.txtStockID.Properties.NullText = "";
            this.txtStockID.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtStockID.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtStockID.Properties.UseParentBackground = true;
            this.txtStockID.Properties.ValidateOnEnterKey = true;
            this.txtStockID.Properties.ValueMember = "Stock_ID";
            this.txtStockID.Properties.View = this.gridView3; 
            this.txtStockID.Size = new System.Drawing.Size(282, 20);
            this.txtStockID.StyleController = this.lcMain;
            this.txtStockID.TabIndex = 40;
            this.txtStockID.EditValueChanged += new System.EventHandler(this.txtStockID_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStock_Name4,
            this.colStock_ID2});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStock_ID2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colStock_Name4
            // 
            this.colStock_Name4.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name4.Caption = "Tên kho";
            this.colStock_Name4.FieldName = "Stock_Name";
            this.colStock_Name4.Name = "colStock_Name4";
            this.colStock_Name4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name4.Visible = true;
            this.colStock_Name4.VisibleIndex = 1;
            // 
            // colStock_ID2
            // 
            this.colStock_ID2.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID2.Caption = "Mã số";
            this.colStock_ID2.FieldName = "Stock_ID";
            this.colStock_ID2.Name = "colStock_ID2";
            this.colStock_ID2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_ID2.Visible = true;
            this.colStock_ID2.VisibleIndex = 0;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.aDJUSTMENTDETAILBindingSource;
            this.gcList.Location = new System.Drawing.Point(3, 81);
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
            this.gcList.Size = new System.Drawing.Size(994, 483);
            this.gcList.TabIndex = 38;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // aDJUSTMENTDETAILBindingSource
            // 
            this.aDJUSTMENTDETAILBindingSource.DataMember = "ADJUSTMENT_DETAIL";
            this.aDJUSTMENTDETAILBindingSource.DataSource = this.dsAdjust;
            // 
            // dsAdjust
            // 
            this.dsAdjust.DataSetName = "dsAdjust";
            this.dsAdjust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.Row.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand1,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colAdjustment_ID,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colStock_ID3,
            this.colCurrentQty,
            this.colWidth,
            this.colUnit,
            this.colHeight,
            this.colUnitConvert,
            this.colOrgin,
            this.colNewQty,
            this.colQtyDiff,
            this.colUnitPrice,
            this.colAmount,
            this.colQtyConvert,
            this.colDescription,
            this.colStoreID,
            this.colBatch,
            this.colSerial,
            this.colSorted});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(385, 280, 223, 214);
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", this.colAmount, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", null, "{0:##,##0.###}")});
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
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.colProduct_ID);
            this.gridBand2.Columns.Add(this.colProduct_Name);
            this.gridBand2.Columns.Add(this.colUnit);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 482;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 140;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Tên hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 269;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.Caption = "ĐVT";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.Width = 73;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colAdjustment_ID);
            this.gridBand1.Columns.Add(this.colStock_ID3);
            this.gridBand1.Columns.Add(this.colUnitConvert);
            this.gridBand1.Columns.Add(this.colWidth);
            this.gridBand1.Columns.Add(this.colHeight);
            this.gridBand1.Columns.Add(this.colOrgin);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.Columns.Add(this.colQtyConvert);
            this.gridBand1.Columns.Add(this.colStoreID);
            this.gridBand1.Columns.Add(this.colBatch);
            this.gridBand1.Columns.Add(this.colSerial);
            this.gridBand1.Columns.Add(this.colSorted);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 80;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 22;
            // 
            // colAdjustment_ID
            // 
            this.colAdjustment_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdjustment_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdjustment_ID.FieldName = "Adjustment_ID";
            this.colAdjustment_ID.Name = "colAdjustment_ID";
            this.colAdjustment_ID.Width = 83;
            // 
            // colStock_ID3
            // 
            this.colStock_ID3.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_ID3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_ID3.FieldName = "Stock_ID";
            this.colStock_ID3.Name = "colStock_ID3";
            this.colStock_ID3.Width = 54;
            // 
            // colUnitConvert
            // 
            this.colUnitConvert.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitConvert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitConvert.Caption = "Quy cách";
            this.colUnitConvert.FieldName = "UnitConvert";
            this.colUnitConvert.Name = "colUnitConvert";
            this.colUnitConvert.Visible = true;
            this.colUnitConvert.Width = 80;
            // 
            // colWidth
            // 
            this.colWidth.AppearanceHeader.Options.UseTextOptions = true;
            this.colWidth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWidth.FieldName = "Width";
            this.colWidth.Name = "colWidth";
            this.colWidth.Width = 39;
            // 
            // colHeight
            // 
            this.colHeight.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeight.FieldName = "Height";
            this.colHeight.Name = "colHeight";
            this.colHeight.Width = 42;
            // 
            // colOrgin
            // 
            this.colOrgin.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrgin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrgin.FieldName = "Orgin";
            this.colOrgin.Name = "colOrgin";
            this.colOrgin.Width = 37;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "Đơn giá";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 48;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Thành tiền";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 62;
            // 
            // colQtyConvert
            // 
            this.colQtyConvert.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyConvert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyConvert.FieldName = "QtyConvert";
            this.colQtyConvert.Name = "colQtyConvert";
            this.colQtyConvert.Width = 26;
            // 
            // colStoreID
            // 
            this.colStoreID.AppearanceHeader.Options.UseTextOptions = true;
            this.colStoreID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStoreID.FieldName = "StoreID";
            this.colStoreID.Name = "colStoreID";
            this.colStoreID.Width = 51;
            // 
            // colBatch
            // 
            this.colBatch.AppearanceHeader.Options.UseTextOptions = true;
            this.colBatch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBatch.FieldName = "Batch";
            this.colBatch.Name = "colBatch";
            this.colBatch.Width = 38;
            // 
            // colSerial
            // 
            this.colSerial.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerial.FieldName = "Serial";
            this.colSerial.Name = "colSerial";
            this.colSerial.Width = 37;
            // 
            // colSorted
            // 
            this.colSorted.AppearanceHeader.Options.UseTextOptions = true;
            this.colSorted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSorted.FieldName = "Sorted";
            this.colSorted.Name = "colSorted";
            this.colSorted.Width = 43;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "gridBand3";
            this.gridBand3.Columns.Add(this.colCurrentQty);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 92;
            // 
            // colCurrentQty
            // 
            this.colCurrentQty.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colCurrentQty.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colCurrentQty.AppearanceCell.Options.UseBackColor = true;
            this.colCurrentQty.AppearanceCell.Options.UseForeColor = true;
            this.colCurrentQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrentQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrentQty.Caption = "Tồn kho";
            this.colCurrentQty.FieldName = "CurrentQty";
            this.colCurrentQty.Name = "colCurrentQty";
            this.colCurrentQty.Visible = true;
            this.colCurrentQty.Width = 92;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "gridBand4";
            this.gridBand4.Columns.Add(this.colNewQty);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 91;
            // 
            // colNewQty
            // 
            this.colNewQty.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colNewQty.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colNewQty.AppearanceCell.Options.UseBackColor = true;
            this.colNewQty.AppearanceCell.Options.UseForeColor = true;
            this.colNewQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colNewQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewQty.Caption = "Kiểm kê";
            this.colNewQty.FieldName = "NewQty";
            this.colNewQty.Name = "colNewQty";
            this.colNewQty.Visible = true;
            this.colNewQty.Width = 91;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "gridBand5";
            this.gridBand5.Columns.Add(this.colQtyDiff);
            this.gridBand5.MinWidth = 20;
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 102;
            // 
            // colQtyDiff
            // 
            this.colQtyDiff.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colQtyDiff.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colQtyDiff.AppearanceCell.Options.UseBackColor = true;
            this.colQtyDiff.AppearanceCell.Options.UseForeColor = true;
            this.colQtyDiff.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyDiff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyDiff.Caption = "Chênh lệch";
            this.colQtyDiff.FieldName = "QtyDiff";
            this.colQtyDiff.Name = "colQtyDiff";
            this.colQtyDiff.Visible = true;
            this.colQtyDiff.Width = 102;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "gridBand6";
            this.gridBand6.Columns.Add(this.colDescription);
            this.gridBand6.MinWidth = 20;
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.Width = 179;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.Width = 179;
            // 
            // rpgProduct
            // 
            this.rpgProduct.ActionButtonIndex = 2;
            this.rpgProduct.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            serializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.rpgProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "Search", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons1"))), new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject4, "", "Add", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", "None", null, true)});
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
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colQuantity1;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rpglkProduct.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
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
            // rpgStock
            // 
            this.rpgStock.AutoHeight = false;
            this.rpgStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpgStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            // rpProductName
            // 
            this.rpProductName.ActionButtonIndex = 2;
            this.rpProductName.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpProductName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", "Search", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", "Add", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", "None", null, true)});
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
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colQuantity2;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual;
            styleFormatCondition3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
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
            // rpToStock
            // 
            this.rpToStock.AutoHeight = false;
            this.rpToStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpToStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            // txtCreatedDate
            // 
            this.txtCreatedDate.EditValue = new System.DateTime(2008, 2, 8, 14, 22, 49, 437);
            this.txtCreatedDate.Location = new System.Drawing.Point(832, 53);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreatedDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtCreatedDate.Properties.NullDate = new System.DateTime(2008, 2, 8, 14, 23, 58, 359);
            this.txtCreatedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCreatedDate.Size = new System.Drawing.Size(163, 20);
            this.txtCreatedDate.StyleController = this.lcMain;
            this.txtCreatedDate.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(832, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 20);
            this.txtID.StyleController = this.lcMain;
            this.txtID.TabIndex = 22;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // txtEmployee
            // 
            this.Err.SetIconAlignment(this.txtEmployee, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtEmployee.Location = new System.Drawing.Point(90, 53);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Properties.ActionButtonIndex = 2;
            this.txtEmployee.Properties.AutoComplete = false;
            this.txtEmployee.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", "None", null, true)});
            this.txtEmployee.Properties.DataSource = this.eMPLOYEEBindingSource;
            this.txtEmployee.Properties.DisplayMember = "Employee_Name";
            this.txtEmployee.Properties.NullText = "";
            this.txtEmployee.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtEmployee.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtEmployee.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEmployee.Properties.UseParentBackground = true;
            this.txtEmployee.Properties.ValidateOnEnterKey = true;
            this.txtEmployee.Properties.ValueMember = "Employee_ID";
            this.txtEmployee.Properties.View = this.gridLookUpEdit1View; 
            this.txtEmployee.Size = new System.Drawing.Size(282, 20);
            this.txtEmployee.StyleController = this.lcMain;
            this.txtEmployee.TabIndex = 25;
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
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(832, 29);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtCreatedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreatedBy.Properties.DataSource = this.eMPLOYEEBindingSource;
            this.txtCreatedBy.Properties.DisplayMember = "Employee_Name";
            this.txtCreatedBy.Properties.NullText = "";
            this.txtCreatedBy.Properties.ValueMember = "Employee_ID";
            this.txtCreatedBy.Properties.View = this.gridView4;
            this.txtCreatedBy.Size = new System.Drawing.Size(163, 20);
            this.txtCreatedBy.StyleController = this.lcMain;
            this.txtCreatedBy.TabIndex = 39;
            this.txtCreatedBy.TabStop = false;
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(461, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(282, 68);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 22;
            this.txtDescription.TabStop = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcDetail,
            this.splitterItem2,
            this.lcID,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.lcEmployeeName,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1000, 567);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcDetail
            // 
            this.lcDetail.Control = this.gcList;
            this.lcDetail.CustomizationFormText = "lcDetail";
            this.lcDetail.Location = new System.Drawing.Point(0, 78);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcDetail.Size = new System.Drawing.Size(994, 483);
            this.lcDetail.Text = "lcDetail";
            this.lcDetail.TextSize = new System.Drawing.Size(0, 0);
            this.lcDetail.TextToControlDistance = 0;
            this.lcDetail.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(0, 72);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(994, 6);
            // 
            // lcID
            // 
            this.lcID.Control = this.txtID;
            this.lcID.CustomizationFormText = "Phiếu";
            this.lcID.Location = new System.Drawing.Point(742, 0);
            this.lcID.MaxSize = new System.Drawing.Size(252, 24);
            this.lcID.MinSize = new System.Drawing.Size(252, 24);
            this.lcID.Name = "lcID";
            this.lcID.Size = new System.Drawing.Size(252, 24);
            this.lcID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcID.Text = "Số phiếu";
            this.lcID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcID.TextSize = new System.Drawing.Size(80, 13);
            this.lcID.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtStockID;
            this.layoutControlItem1.CustomizationFormText = "Kho kiểm kê";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(371, 24);
            this.layoutControlItem1.Text = "Kho kiểm kê";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtDescription;
            this.layoutControlItem6.CustomizationFormText = "Ghi Chú";
            this.layoutControlItem6.Location = new System.Drawing.Point(371, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(371, 72);
            this.layoutControlItem6.Text = "Ghi chú";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtProductGroup;
            this.layoutControlItem3.CustomizationFormText = "Nhóm hàng";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(371, 24);
            this.layoutControlItem3.Text = "Nhóm hàng";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCreatedBy;
            this.layoutControlItem4.CustomizationFormText = "Nhâ Viên";
            this.layoutControlItem4.Location = new System.Drawing.Point(742, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(252, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(252, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(252, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Người lập";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // lcEmployeeName
            // 
            this.lcEmployeeName.Control = this.txtEmployee;
            this.lcEmployeeName.CustomizationFormText = "Tên";
            this.lcEmployeeName.Location = new System.Drawing.Point(0, 48);
            this.lcEmployeeName.Name = "lcEmployeeName";
            this.lcEmployeeName.Size = new System.Drawing.Size(371, 24);
            this.lcEmployeeName.Text = "Nhân viên";
            this.lcEmployeeName.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcEmployeeName.TextSize = new System.Drawing.Size(80, 13);
            this.lcEmployeeName.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCreatedDate;
            this.layoutControlItem2.CustomizationFormText = "Ngày";
            this.layoutControlItem2.Location = new System.Drawing.Point(742, 48);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(252, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(252, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(252, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Ngày lập";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // aDJUSTMENT_DETAILTableAdapter
            // 
            this.aDJUSTMENT_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // xucAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "xucAdjustment";
            this.NotSave = true;
            this.Size = new System.Drawing.Size(1000, 598);
            this.Controls.SetChildIndex(this.plBottom, 0);
            this.Controls.SetChildIndex(this.lcMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDJUSTMENTDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpToStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraEditors.GridLookUpEdit txtEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit txtCreatedDate;
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
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUnit dsUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpToStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraLayout.LayoutControlItem lcDetail;
        private XucBaseBarcode ucBarcode;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private dsPRODUCT dsPRODUCT;
        private Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
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
        private DevExpress.XtraEditors.GridLookUpEdit txtCreatedBy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID2;
        private DevExpress.XtraLayout.LayoutControlItem lcEmployeeName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem lcID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        //private Perfect.Inventory.Core.Inventory.Transfer.DS.dsTRANSFER_DETAILTableAdapters.TRASFER_DETAILTableAdapter tRASFER_DETAILTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name3;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colSTActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colPActiveInt1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTActiveInt1;
        private System.Windows.Forms.BindingSource aDJUSTMENTDETAILBindingSource;
        private Perfect.Inventory.Core.Inventory.Adjusment.DS.dsAdjust dsAdjust;
        private Perfect.Inventory.Core.Inventory.Adjusment.DS.dsAdjustTableAdapters.ADJUSTMENT_DETAILTableAdapter aDJUSTMENT_DETAILTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit txtStockID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Name4;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_ID2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAdjustment_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_ID3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConvert;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colWidth;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHeight;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrgin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrentQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQtyDiff;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQtyConvert;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStoreID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBatch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSerial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSorted;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraEditors.GridLookUpEdit txtProductGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
