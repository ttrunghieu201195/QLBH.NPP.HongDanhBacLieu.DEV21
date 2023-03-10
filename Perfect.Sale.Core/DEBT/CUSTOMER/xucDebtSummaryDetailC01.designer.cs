namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    partial class xucDebtSummaryDetailC01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucDebtSummaryDetailC01));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colTotalDebt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.cUSTOMERDEBTSUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDebtSummaryDetail = new Perfect.Sale.Core.DEBT.CUSTOMER.DS.dsDebtSummaryDetail();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebtInitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebtIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDEBTSUMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDebtSummaryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.lgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.lgDetail.Location = new System.Drawing.Point(0, 651);
            this.lgDetail.Size = new System.Drawing.Size(961, 24);
            // 
            // lgList
            // 
            this.lgList.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lgList.Size = new System.Drawing.Size(961, 612);
            // 
            // colTotalDebt
            // 
            this.colTotalDebt.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colTotalDebt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalDebt.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colTotalDebt.AppearanceCell.Options.UseBackColor = true;
            this.colTotalDebt.AppearanceCell.Options.UseFont = true;
            this.colTotalDebt.AppearanceCell.Options.UseForeColor = true;
            this.colTotalDebt.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalDebt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalDebt.Caption = "Công Nợ";
            this.colTotalDebt.ColumnEdit = this.rpVal;
            this.colTotalDebt.FieldName = "TotalDebt";
            this.colTotalDebt.Name = "colTotalDebt";
            this.colTotalDebt.OptionsColumn.ReadOnly = true;
            this.colTotalDebt.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTotalDebt.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colTotalDebt.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalDebt.Visible = true;
            this.colTotalDebt.VisibleIndex = 5;
            this.colTotalDebt.Width = 109;
            // 
            // rpVal
            // 
            this.rpVal.AutoHeight = false;
            this.rpVal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVal.DisplayFormat.FormatString = "##,##0.###";
            this.rpVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rpVal.EditFormat.FormatString = "##,##0.###";
            this.rpVal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rpVal.Name = "rpVal";
            // 
            // gcList
            // 
            this.gcList.DataSource = this.cUSTOMERDEBTSUMBindingSource;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.EmbeddedNavigator.TextStringFormat = "Dòng {0} / {1}";
            this.gcList.Location = new System.Drawing.Point(2, 41);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(957, 608);
            this.gcList.TabIndex = 42;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // cUSTOMERDEBTSUMBindingSource
            // 
            this.cUSTOMERDEBTSUMBindingSource.DataMember = "CUSTOMER_DEBT_SUM";
            this.cUSTOMERDEBTSUMBindingSource.DataSource = this.dsDebtSummaryDetail;
            // 
            // dsDebtSummaryDetail
            // 
            this.dsDebtSummaryDetail.DataSetName = "dsDebtSummaryDetail";
            this.dsDebtSummaryDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCustomerName,
            this.colCustomer_Group_Name,
            this.colDebtInitAmount,
            this.colDebtIn,
            this.colReceiptIn,
            this.colTotalDebt,
            this.colCreditLimit});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1063, 517, 208, 191);
            styleFormatCondition1.Appearance.BackColor = System.Drawing.SystemColors.Info;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colTotalDebt;
            styleFormatCondition1.Expression = "Iif([TotalDebt] > [CreditLimit], 1 ,0 )";
            styleFormatCondition1.Value1 = 1;
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFormat = "[#image]{1} {2}";
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để phân loại dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalDebt", this.colTotalDebt, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReceiptIn", this.colReceiptIn, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DebtIn", this.colDebtIn, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DebtInitAmount", this.colDebtInitAmount, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_Group_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GbListKeyPress);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListClick);
            // 
            // colCustomerID
            // 
            this.colCustomerID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerID.Caption = "Mã KH";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.OptionsColumn.ReadOnly = true;
            this.colCustomerID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            this.colCustomerID.Width = 120;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCustomerName.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colCustomerName.AppearanceCell.Options.UseFont = true;
            this.colCustomerName.AppearanceCell.Options.UseForeColor = true;
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "Khách Hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 263;
            // 
            // colCustomer_Group_Name
            // 
            this.colCustomer_Group_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_Group_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_Group_Name.Caption = "Khu Vực";
            this.colCustomer_Group_Name.FieldName = "Customer_Group_Name";
            this.colCustomer_Group_Name.Name = "colCustomer_Group_Name";
            this.colCustomer_Group_Name.OptionsColumn.ReadOnly = true;
            this.colCustomer_Group_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_Group_Name.Width = 129;
            // 
            // colDebtInitAmount
            // 
            this.colDebtInitAmount.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colDebtInitAmount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDebtInitAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colDebtInitAmount.AppearanceCell.Options.UseBackColor = true;
            this.colDebtInitAmount.AppearanceCell.Options.UseFont = true;
            this.colDebtInitAmount.AppearanceCell.Options.UseForeColor = true;
            this.colDebtInitAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebtInitAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebtInitAmount.Caption = "Đầu Kỳ";
            this.colDebtInitAmount.ColumnEdit = this.rpVal;
            this.colDebtInitAmount.FieldName = "DebtInitAmount";
            this.colDebtInitAmount.Name = "colDebtInitAmount";
            this.colDebtInitAmount.OptionsColumn.ReadOnly = true;
            this.colDebtInitAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDebtInitAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDebtInitAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDebtInitAmount.Visible = true;
            this.colDebtInitAmount.VisibleIndex = 2;
            this.colDebtInitAmount.Width = 109;
            // 
            // colDebtIn
            // 
            this.colDebtIn.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colDebtIn.AppearanceCell.Options.UseBackColor = true;
            this.colDebtIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebtIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebtIn.Caption = "Phát Sinh";
            this.colDebtIn.ColumnEdit = this.rpVal;
            this.colDebtIn.FieldName = "DebtIn";
            this.colDebtIn.Name = "colDebtIn";
            this.colDebtIn.OptionsColumn.ReadOnly = true;
            this.colDebtIn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDebtIn.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDebtIn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDebtIn.Visible = true;
            this.colDebtIn.VisibleIndex = 3;
            this.colDebtIn.Width = 130;
            // 
            // colReceiptIn
            // 
            this.colReceiptIn.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colReceiptIn.AppearanceCell.Options.UseBackColor = true;
            this.colReceiptIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colReceiptIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReceiptIn.Caption = "Thu Tiền";
            this.colReceiptIn.ColumnEdit = this.rpVal;
            this.colReceiptIn.FieldName = "ReceiptIn";
            this.colReceiptIn.Name = "colReceiptIn";
            this.colReceiptIn.OptionsColumn.ReadOnly = true;
            this.colReceiptIn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colReceiptIn.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colReceiptIn.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colReceiptIn.Visible = true;
            this.colReceiptIn.VisibleIndex = 4;
            this.colReceiptIn.Width = 106;
            // 
            // colCreditLimit
            // 
            this.colCreditLimit.Caption = "Giới hạn nợ";
            this.colCreditLimit.ColumnEdit = this.rpVal;
            this.colCreditLimit.FieldName = "CreditLimit";
            this.colCreditLimit.Name = "colCreditLimit";
            this.colCreditLimit.Visible = true;
            this.colCreditLimit.VisibleIndex = 6;
            this.colCreditLimit.Width = 120;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(961, 612);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(961, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // xucDebtSummaryDetailC01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucDebtSummaryDetailC01";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDEBTSUMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDebtSummaryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtInitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtIn;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptIn;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDebt;
        private System.Windows.Forms.BindingSource cUSTOMERDEBTSUMBindingSource;
        private Perfect.Sale.Core.DEBT.CUSTOMER.DS.dsDebtSummaryDetail dsDebtSummaryDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditLimit;
    }
}