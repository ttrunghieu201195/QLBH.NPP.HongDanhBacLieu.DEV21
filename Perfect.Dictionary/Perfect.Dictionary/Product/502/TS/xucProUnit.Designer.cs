namespace Perfect.Dictionary.Product._502.TS
{
    partial class xucProUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucProUnit));
            this.LC01 = new DevExpress.XtraLayout.LayoutControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.pRODUCTUNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProUnit = new Perfect.Dictionary.Product._502.TS.DS.dsProUnit();
            this.gdList = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitConvert_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.glkUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnit = new Perfect.Dictionary.Product._502.TS.DS.dsUnit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnitConvert = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pRODUCT_UNITTableAdapter = new Perfect.Dictionary.Product._502.TS.DS.dsProUnitTableAdapters.PRODUCT_UNITTableAdapter();
            this.uNITTableAdapter = new Perfect.Dictionary.Product._502.TS.DS.dsUnitTableAdapters.UNITTableAdapter();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LC01)).BeginInit();
            this.LC01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTUNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            this.SuspendLayout();
            // 
            // LC01
            // 
            this.LC01.Controls.Add(this.gcList);
            this.LC01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LC01.Location = new System.Drawing.Point(0, 0);
            this.LC01.Name = "LC01";
            this.LC01.Root = this.layoutControlGroup1;
            this.LC01.Size = new System.Drawing.Size(366, 242);
            this.LC01.TabIndex = 0;
            this.LC01.Text = "layoutControl1";
            // 
            // gcList
            // 
            this.gcList.DataSource = this.pRODUCTUNITBindingSource;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gdList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.glkUnit,
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(366, 242);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdList});
            // 
            // pRODUCTUNITBindingSource
            // 
            this.pRODUCTUNITBindingSource.DataMember = "PRODUCT_UNIT";
            this.pRODUCTUNITBindingSource.DataSource = this.dsProUnit;
            // 
            // dsProUnit
            // 
            this.dsProUnit.DataSetName = "dsProUnit";
            this.dsProUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gdList
            // 
            this.gdList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gdList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colProduct_ID,
            this.colUnit_ID,
            this.colUnitConvert,
            this.colUnitConvert_ID});
            this.gdList.GridControl = this.gcList;
            this.gdList.Name = "gdList";
            this.gdList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gdList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gdList.OptionsView.ShowBands = false;
            this.gdList.OptionsView.ShowGroupPanel = false;
            this.gdList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUnitConvert, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gdList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gdList_CellValueChanged);
            this.gdList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gdList_KeyPress);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colUnitConvert_ID);
            this.gridBand1.Columns.Add(this.colUnitConvert);
            this.gridBand1.Columns.Add(this.colUnit_ID);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 225;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            // 
            // colUnitConvert_ID
            // 
            this.colUnitConvert_ID.Caption = "Đơn Vị Phụ";
            this.colUnitConvert_ID.ColumnEdit = this.glkUnit;
            this.colUnitConvert_ID.FieldName = "UnitConvert_ID";
            this.colUnitConvert_ID.Name = "colUnitConvert_ID";
            this.colUnitConvert_ID.Visible = true;
            // 
            // glkUnit
            // 
            this.glkUnit.AutoHeight = false;
            this.glkUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glkUnit.DataSource = this.uNITBindingSource;
            this.glkUnit.DisplayMember = "Unit_Name";
            this.glkUnit.Name = "glkUnit";
            this.glkUnit.NullText = "(Chọn)";
            this.glkUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.glkUnit.ValidateOnEnterKey = true;
            this.glkUnit.ValueMember = "Unit_ID";
            this.glkUnit.View = this.repositoryItemGridLookUpEdit1View;
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
            // colUnitConvert
            // 
            this.colUnitConvert.Caption = "Đơn Vị Quy Đổi";
            this.colUnitConvert.ColumnEdit = this.rpVal;
            this.colUnitConvert.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colUnitConvert.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colUnitConvert.FieldName = "UnitConvert";
            this.colUnitConvert.Name = "colUnitConvert";
            this.colUnitConvert.Visible = true;
            // 
            // colUnit_ID
            // 
            this.colUnit_ID.Caption = "Đơn Vị Gốc";
            this.colUnit_ID.ColumnEdit = this.glkUnit;
            this.colUnit_ID.FieldName = "Unit_ID";
            this.colUnit_ID.Name = "colUnit_ID";
            this.colUnit_ID.Visible = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(366, 242);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "lc01";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(366, 242);
            this.layoutControlItem1.Text = "lc01";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSave,
            this.bbiCancel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.FloatLocation = new System.Drawing.Point(126, 386);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCancel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Lưu";
            this.bbiSave.Id = 0;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Bỏ Qua";
            this.bbiCancel.Id = 2;
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // pRODUCT_UNITTableAdapter
            // 
            this.pRODUCT_UNITTableAdapter.ClearBeforeFill = true;
            // 
            // uNITTableAdapter
            // 
            this.uNITTableAdapter.ClearBeforeFill = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
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
            // xucProUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LC01);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xucProUnit";
            this.Size = new System.Drawing.Size(366, 266);
            ((System.ComponentModel.ISupportInitialize)(this.LC01)).EndInit();
            this.LC01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTUNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glkUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl LC01;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private System.Windows.Forms.BindingSource pRODUCTUNITBindingSource;
        private Perfect.Dictionary.Product._502.TS.DS.dsProUnit dsProUnit;
        private Perfect.Dictionary.Product._502.TS.DS.dsProUnitTableAdapters.PRODUCT_UNITTableAdapter pRODUCT_UNITTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glkUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private Perfect.Dictionary.Product._502.TS.DS.dsUnit dsUnit;
        private Perfect.Dictionary.Product._502.TS.DS.dsUnitTableAdapters.UNITTableAdapter uNITTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gdList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConvert_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConvert;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;

    }
}
