

namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    partial class xucDebtTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucDebtTime));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colTuoiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gETDEBTDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDebtDetails = new Perfect.Sale.Core.dsDebtDetails();
            this.plMain = new DevExpress.XtraEditors.PanelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienDai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gET_DEBTDETAILTableAdapter = new Perfect.Sale.Core.dsDebtDetailsTableAdapters.GET_DEBTDETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETDEBTDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDebtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // layoutControl1
            // 
            this.layoutControl1.Size = new System.Drawing.Size(1059, 521);
            // 
            // lgDetail
            // 
            this.lgDetail.Location = new System.Drawing.Point(0, 518);
            this.lgDetail.Size = new System.Drawing.Size(1059, 3);
            // 
            // lgList
            // 
            this.lgList.Location = new System.Drawing.Point(0, 30);
            this.lgList.Size = new System.Drawing.Size(1059, 482);
            // 
            // colTuoiNo
            // 
            this.colTuoiNo.Caption = "Tuổi Nợ (Ngày)";
            this.colTuoiNo.FieldName = "TuoiNo";
            this.colTuoiNo.Name = "colTuoiNo";
            this.colTuoiNo.OptionsColumn.AllowEdit = false;
            this.colTuoiNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTuoiNo.OptionsColumn.ReadOnly = true;
            this.colTuoiNo.Visible = true;
            this.colTuoiNo.VisibleIndex = 2;
            this.colTuoiNo.Width = 134;
            // 
            // gETDEBTDETAILBindingSource
            // 
            this.gETDEBTDETAILBindingSource.DataMember = "GET_DEBTDETAIL";
            this.gETDEBTDETAILBindingSource.DataSource = this.dsDebtDetails;
            // 
            // dsDebtDetails
            // 
            this.dsDebtDetails.DataSetName = "dsDebtDetails";
            this.dsDebtDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.gcList);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1059, 521);
            this.plMain.TabIndex = 19;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.gETDEBTDETAILBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.AllowDrop = true;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1055, 517);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChungTu,
            this.colNgay,
            this.colCustomerName,
            this.colTuoiNo,
            this.colSoTien,
            this.colDaTra,
            this.colConLai,
            this.colDienDai});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colTuoiNo;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between;
            styleFormatCondition1.Value1 = "20";
            styleFormatCondition1.Value2 = "40";
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colTuoiNo;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition2.Value1 = "40";
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoTien", null, " - Tổng Số Tiền: {0:##,##0.###}")});
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colChungTu
            // 
            this.colChungTu.Caption = "Chứng Từ";
            this.colChungTu.FieldName = "ChungTu";
            this.colChungTu.Name = "colChungTu";
            this.colChungTu.OptionsColumn.AllowEdit = false;
            this.colChungTu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colChungTu.Visible = true;
            this.colChungTu.VisibleIndex = 0;
            this.colChungTu.Width = 109;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.OptionsColumn.AllowEdit = false;
            this.colNgay.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 149;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Khách Hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 200;
            // 
            // colSoTien
            // 
            this.colSoTien.Caption = "Số Tiền";
            this.colSoTien.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colSoTien.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.OptionsColumn.AllowEdit = false;
            this.colSoTien.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSoTien.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colSoTien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 3;
            this.colSoTien.Width = 144;
            // 
            // colDaTra
            // 
            this.colDaTra.Caption = "Đã Trả";
            this.colDaTra.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colDaTra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDaTra.FieldName = "DaTra";
            this.colDaTra.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colDaTra.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDaTra.Name = "colDaTra";
            this.colDaTra.OptionsColumn.AllowEdit = false;
            this.colDaTra.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDaTra.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDaTra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDaTra.Visible = true;
            this.colDaTra.VisibleIndex = 4;
            this.colDaTra.Width = 144;
            // 
            // colConLai
            // 
            this.colConLai.Caption = "Còn Lại";
            this.colConLai.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colConLai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colConLai.FieldName = "ConLai";
            this.colConLai.GroupFormat.FormatString = "{0:##,##0.###}";
            this.colConLai.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colConLai.Name = "colConLai";
            this.colConLai.OptionsColumn.AllowEdit = false;
            this.colConLai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colConLai.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colConLai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colConLai.Visible = true;
            this.colConLai.VisibleIndex = 5;
            this.colConLai.Width = 144;
            // 
            // colDienDai
            // 
            this.colDienDai.Caption = "Diễn Giải";
            this.colDienDai.FieldName = "DienDai";
            this.colDienDai.Name = "colDienDai";
            this.colDienDai.OptionsColumn.AllowEdit = false;
            this.colDienDai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDienDai.Visible = true;
            this.colDienDai.VisibleIndex = 6;
            this.colDienDai.Width = 210;
            // 
            // gET_DEBTDETAILTableAdapter
            // 
            this.gET_DEBTDETAILTableAdapter.ClearBeforeFill = true;
            // 
            // xucDebtTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Name = "xucDebtTime";
            this.Size = new System.Drawing.Size(1059, 521);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            this.Controls.SetChildIndex(this.plMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETDEBTDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDebtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.plMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl plMain;
        private System.Windows.Forms.BindingSource gETDEBTDETAILBindingSource;
        private dsDebtDetails dsDebtDetails;
        private Perfect.Sale.Core.dsDebtDetailsTableAdapters.GET_DEBTDETAILTableAdapter gET_DEBTDETAILTableAdapter;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraGrid.Columns.GridColumn colChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colTuoiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colDaTra;
        private DevExpress.XtraGrid.Columns.GridColumn colConLai;
        private DevExpress.XtraGrid.Columns.GridColumn colDienDai;
    }
}
