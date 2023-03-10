

namespace Perfect.Sale.Core.PAYMENT
{
    partial class xucSaleAmountByDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucSaleAmountByDay));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colTuoiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plMain = new DevExpress.XtraEditors.PanelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.spDEBTGetInfoForProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDebtTime = new Perfect.Sale.Core.dsDebtTime();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienDai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_DEBT_GetInfoForProviderTableAdapter = new Perfect.Sale.Core.dsDebtTimeTableAdapters.sp_DEBT_GetInfoForProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDEBTGetInfoForProviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDebtTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Size = new System.Drawing.Size(1059, 29);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
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
            this.colTuoiNo.VisibleIndex = 3;
            this.colTuoiNo.Width = 124;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.gcList);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 29);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1059, 492);
            this.plMain.TabIndex = 19;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.spDEBTGetInfoForProviderBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.AllowDrop = true;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1055, 488);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // spDEBTGetInfoForProviderBindingSource
            // 
            this.spDEBTGetInfoForProviderBindingSource.DataMember = "sp_DEBT_GetInfoForProvider";
            this.spDEBTGetInfoForProviderBindingSource.DataSource = this.dsDebtTime;
            // 
            // dsDebtTime
            // 
            this.dsDebtTime.DataSetName = "dsDebtTime";
            this.dsDebtTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoTien", null, " - Tổng Số Tiền: {0:##,##0.###}")});
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsView.ShowFooter = true;
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
            this.colChungTu.Width = 90;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.OptionsColumn.AllowEdit = false;
            this.colNgay.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 132;
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
            this.colCustomerName.Width = 295;
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
            this.colSoTien.SummaryItem.DisplayFormat = "{0:##,##0.###} ";
            this.colSoTien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 4;
            this.colSoTien.Width = 118;
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
            this.colDaTra.VisibleIndex = 5;
            this.colDaTra.Width = 113;
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
            this.colConLai.SummaryItem.DisplayFormat = "{0:##,##0.###} ";
            this.colConLai.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colConLai.Visible = true;
            this.colConLai.VisibleIndex = 6;
            this.colConLai.Width = 117;
            // 
            // colDienDai
            // 
            this.colDienDai.Caption = "Diễn Giải";
            this.colDienDai.FieldName = "DienDai";
            this.colDienDai.Name = "colDienDai";
            this.colDienDai.OptionsColumn.AllowEdit = false;
            this.colDienDai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDienDai.Visible = true;
            this.colDienDai.VisibleIndex = 7;
            this.colDienDai.Width = 45;
            // 
            // sp_DEBT_GetInfoForProviderTableAdapter
            // 
            this.sp_DEBT_GetInfoForProviderTableAdapter.ClearBeforeFill = true;
            // 
            // xucSaleAmountByDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plMain);
            this.Name = "xucSaleAmountByDay";
            this.Size = new System.Drawing.Size(1059, 521);
            this.Controls.SetChildIndex(this.plTop, 0);
            this.Controls.SetChildIndex(this.plMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.plMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDEBTGetInfoForProviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDebtTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl plMain;
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
        private System.Windows.Forms.BindingSource spDEBTGetInfoForProviderBindingSource;
        private dsDebtTime dsDebtTime;
        private Perfect.Sale.Core.dsDebtTimeTableAdapters.sp_DEBT_GetInfoForProviderTableAdapter sp_DEBT_GetInfoForProviderTableAdapter;
    }
}
