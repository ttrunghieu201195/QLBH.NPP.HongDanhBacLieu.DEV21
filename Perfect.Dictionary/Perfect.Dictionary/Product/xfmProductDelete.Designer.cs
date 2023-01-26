namespace Perfect.Dictionary.Product
{
    partial class xfmProductDelete
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvListLev1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductDel = new Perfect.Dictionary.Product.DS.dsProductDel();
            this.gvListLev2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvListLev3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pRODUCTTableAdapter = new Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.PRODUCTTableAdapter();
            this.stocK_INWARD_DETAILTableAdapter = new Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.STOCK_INWARD_DETAILTableAdapter();
            this.stocK_OUTWARD_DETAILTableAdapter = new Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.STOCK_OUTWARD_DETAILTableAdapter();
            this.inventorY_DETAILTableAdapter = new Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.INVENTORY_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLev1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLev2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLev3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListLev1
            // 
            this.gvListLev1.GridControl = this.gcList;
            this.gvListLev1.Name = "gvListLev1";
            this.gvListLev1.OptionsView.ShowColumnHeaders = false;
            this.gvListLev1.OptionsView.ShowGroupPanel = false;
            this.gvListLev1.OptionsView.ShowHorzLines = false;
            this.gvListLev1.OptionsView.ShowPreview = true;
            this.gvListLev1.ViewCaption = "Chi Tiết Tồn Kho";
            // 
            // gcList
            // 
            this.gcList.DataSource = this.pRODUCTBindingSource;
            gridLevelNode1.LevelTemplate = this.gvListLev1;
            gridLevelNode1.RelationName = "CTTK";
            gridLevelNode2.LevelTemplate = this.gvListLev2;
            gridLevelNode2.RelationName = "CTNK";
            gridLevelNode3.LevelTemplate = this.gvListLev3;
            gridLevelNode3.RelationName = "CTXK";
            this.gcList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gcList.Location = new System.Drawing.Point(12, 12);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(752, 533);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListLev2,
            this.gvListLev3,
            this.gvList,
            this.gvListLev1});
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dsProductDel;
            // 
            // dsProductDel
            // 
            this.dsProductDel.DataSetName = "dsProductDel";
            this.dsProductDel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvListLev2
            // 
            this.gvListLev2.GridControl = this.gcList;
            this.gvListLev2.Name = "gvListLev2";
            this.gvListLev2.OptionsView.ShowColumnHeaders = false;
            this.gvListLev2.OptionsView.ShowGroupPanel = false;
            this.gvListLev2.OptionsView.ShowHorzLines = false;
            this.gvListLev2.OptionsView.ShowPreview = true;
            this.gvListLev2.ViewCaption = "Chi Tiết Nhập Kho";
            // 
            // gvListLev3
            // 
            this.gvListLev3.GridControl = this.gcList;
            this.gvListLev3.Name = "gvListLev3";
            this.gvListLev3.OptionsView.ShowColumnHeaders = false;
            this.gvListLev3.OptionsView.ShowGroupPanel = false;
            this.gvListLev3.OptionsView.ShowHorzLines = false;
            this.gvListLev3.OptionsView.ShowPreview = true;
            this.gvListLev3.ViewCaption = "Chi Tiết xuất Kho";
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_ID,
            this.colProduct_Name,
            this.colQuantity});
            this.gvList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsDetail.EnableDetailToolTip = true;
            this.gvList.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.OptionsView.ShowHorzLines = false;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.VisibleIndex = 0;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(776, 557);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(776, 557);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(756, 537);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // stocK_INWARD_DETAILTableAdapter
            // 
            this.stocK_INWARD_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // stocK_OUTWARD_DETAILTableAdapter
            // 
            this.stocK_OUTWARD_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // inventorY_DETAILTableAdapter
            // 
            this.inventorY_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // xfmProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 557);
            this.Controls.Add(this.layoutControl1);
            this.Name = "xfmProductDelete";
            this.Text = "Xóa Hàng Hóa";
            this.Load += new System.EventHandler(this.xfmProductDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListLev1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLev2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListLev3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Perfect.Dictionary.Product.DS.dsProductDel dsProductDel;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.STOCK_INWARD_DETAILTableAdapter stocK_INWARD_DETAILTableAdapter;
        private Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.STOCK_OUTWARD_DETAILTableAdapter stocK_OUTWARD_DETAILTableAdapter;
        private Perfect.Dictionary.Product.DS.dsProductDelTableAdapters.INVENTORY_DETAILTableAdapter inventorY_DETAILTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListLev1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListLev2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListLev3;
       

    }
}