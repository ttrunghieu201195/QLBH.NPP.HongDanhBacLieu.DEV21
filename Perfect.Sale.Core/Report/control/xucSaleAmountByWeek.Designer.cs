namespace Perfect.Sale.Core.Report.control
{
    partial class XucSaleAmountByWeek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucSaleAmountByWeek));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.sALESaleAmountByWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaleAmountByWeek = new Perfect.Sale.Core.Report.DS.dsSaleAmountByWeek();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sALE_SaleAmountByWeekTableAdapter = new Perfect.Sale.Core.Report.DS.dsSaleAmountByWeekTableAdapters.SALE_SaleAmountByWeekTableAdapter();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSalesWeek = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSalesAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESaleAmountByWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleAmountByWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
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
            this.lgDetail.Location = new System.Drawing.Point(0, 639);
            this.lgDetail.Size = new System.Drawing.Size(961, 36);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(961, 600);
            // 
            // gcList
            // 
            this.gcList.DataSource = this.sALESaleAmountByWeekBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(957, 596);
            this.gcList.TabIndex = 42;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // sALESaleAmountByWeekBindingSource
            // 
            this.sALESaleAmountByWeekBindingSource.DataMember = "SALE_SaleAmountByWeek";
            this.sALESaleAmountByWeekBindingSource.DataSource = this.dsSaleAmountByWeek;
            // 
            // dsSaleAmountByWeek
            // 
            this.dsSaleAmountByWeek.DataSetName = "dsSaleAmountByWeek";
            this.dsSaleAmountByWeek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 600);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // sALE_SaleAmountByWeekTableAdapter
            // 
            this.sALE_SaleAmountByWeekTableAdapter.ClearBeforeFill = true;
            // 
            // gbList
            // 
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSalesWeek,
            this.colSalesAmount});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo Cột Và Thả Vào Đây Để Phân Loại Dữ Liệu";
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colSalesWeek);
            this.gridBand1.Columns.Add(this.colSalesAmount);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 374;
            // 
            // colSalesWeek
            // 
            this.colSalesWeek.Caption = "Tuần Thứ";
            this.colSalesWeek.DisplayFormat.FormatString = "Tuần Thứ {0:##,##0.###}";
            this.colSalesWeek.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSalesWeek.FieldName = "SalesWeek";
            this.colSalesWeek.Name = "colSalesWeek";
            this.colSalesWeek.OptionsColumn.AllowEdit = false;
            this.colSalesWeek.OptionsColumn.ReadOnly = true;
            this.colSalesWeek.Visible = true;
            this.colSalesWeek.Width = 187;
            // 
            // colSalesAmount
            // 
            this.colSalesAmount.Caption = "Tổng Doanh Thu";
            this.colSalesAmount.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colSalesAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSalesAmount.FieldName = "SalesAmount";
            this.colSalesAmount.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colSalesAmount.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSalesAmount.Name = "colSalesAmount";
            this.colSalesAmount.OptionsColumn.AllowEdit = false;
            this.colSalesAmount.OptionsColumn.ReadOnly = true;
            this.colSalesAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colSalesAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSalesAmount.Visible = true;
            this.colSalesAmount.Width = 187;
            // 
            // xucSaleAmountByWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XucSaleAmountByWeek";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESaleAmountByWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaleAmountByWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource sALESaleAmountByWeekBindingSource;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByWeek dsSaleAmountByWeek;
        private Perfect.Sale.Core.Report.DS.dsSaleAmountByWeekTableAdapters.SALE_SaleAmountByWeekTableAdapter sALE_SaleAmountByWeekTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSalesWeek;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSalesAmount;
    }
}
