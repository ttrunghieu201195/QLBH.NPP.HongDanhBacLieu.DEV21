namespace Perfect.Dictionary.Provider.usercontrol.Professional
{
    partial class XucProvider
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.pROVIDERFULLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPROVIDER = new Perfect.Dictionary.Provider.DS.dsPROVIDER();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.pROVIDERFULLTableAdapter = new Perfect.Dictionary.Provider.DS.dsPROVIDERTableAdapters.PROVIDERFULLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERFULLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPROVIDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpText)).BeginInit();
            this.SuspendLayout();
            // 
            // colActiveInt
            // 
            this.colActiveInt.AppearanceHeader.Options.UseTextOptions = true;
            this.colActiveInt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActiveInt.FieldName = "ActiveInt";
            this.colActiveInt.Name = "colActiveInt";
            this.colActiveInt.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.pROVIDERFULLBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcList.Location = new System.Drawing.Point(0, 43);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpText});
            this.gcList.Size = new System.Drawing.Size(761, 621);
            this.gcList.TabIndex = 2;
            this.gcList.UseEmbeddedNavigator = true;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // pROVIDERFULLBindingSource
            // 
            this.pROVIDERFULLBindingSource.DataMember = "PROVIDERFULL";
            this.pROVIDERFULLBindingSource.DataSource = this.dsPROVIDER;
            // 
            // dsPROVIDER
            // 
            this.dsPROVIDER.DataSetName = "dsPROVIDER";
            this.dsPROVIDER.EnforceConstraints = false;
            this.dsPROVIDER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colTax,
            this.colTel,
            this.colFax,
            this.colEmail,
            this.colMobile,
            this.colBankAccount,
            this.colBankName,
            this.colCustomer_Group_Name,
            this.colCustomerAddress,
            this.colCustomer_ID,
            this.colActive,
            this.colActiveInt});
            this.gbList.CustomizationFormBounds = new System.Drawing.Rectangle(1055, 491, 216, 199);
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colActive;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupFormat = "[#image]{1} {2}";
            this.gbList.IndicatorWidth = 45;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.PreviewFieldName = "CustomerName";
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_Group_Name, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_ID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.VertScrollTipFieldName = "CustomerName";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GbListKeyDown);
            this.gbList.Layout += new System.EventHandler(this.GbListLayout);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GbListMouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.GbListDoubleClick);
            this.gbList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GbListRowCellClick);
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "Tên Cung Cấp";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 246;
            // 
            // colTax
            // 
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.Caption = "Mã Số Thuế";
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.ReadOnly = true;
            this.colTax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 8;
            this.colTax.Width = 85;
            // 
            // colTel
            // 
            this.colTel.AppearanceHeader.Options.UseTextOptions = true;
            this.colTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTel.Caption = "Điện Thoại";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.OptionsColumn.ReadOnly = true;
            this.colTel.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 4;
            this.colTel.Width = 84;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 5;
            this.colFax.Width = 59;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 69;
            // 
            // colMobile
            // 
            this.colMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMobile.Caption = "Di Động";
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.ReadOnly = true;
            this.colMobile.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMobile.Width = 58;
            // 
            // colBankAccount
            // 
            this.colBankAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankAccount.Caption = "Số Tài Khoản";
            this.colBankAccount.FieldName = "BankAccount";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.OptionsColumn.ReadOnly = true;
            this.colBankAccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBankAccount.Visible = true;
            this.colBankAccount.VisibleIndex = 9;
            this.colBankAccount.Width = 128;
            // 
            // colBankName
            // 
            this.colBankName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankName.Caption = "Ngân Hàng";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.ReadOnly = true;
            this.colBankName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 7;
            this.colBankName.Width = 85;
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
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerAddress.Caption = "Địa Chỉ";
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.OptionsColumn.ReadOnly = true;
            this.colCustomerAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 3;
            this.colCustomerAddress.Width = 199;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_ID.Caption = "Mã";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsColumn.ReadOnly = true;
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 0;
            this.colCustomer_ID.Width = 96;
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Còn Quản Lý";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.ReadOnly = true;
            this.colActive.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 97;
            // 
            // rpText
            // 
            this.rpText.AutoHeight = false;
            this.rpText.Name = "rpText";
            this.rpText.DoubleClick += new System.EventHandler(this.GbListDoubleClick);
            // 
            // pROVIDERFULLTableAdapter
            // 
            this.pROVIDERFULLTableAdapter.ClearBeforeFill = true;
            // 
            // XucProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.gcList);
            this.Name = "XucProvider";
            this.Controls.SetChildIndex(this.ucToolBar, 0);
            this.Controls.SetChildIndex(this.gcList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERFULLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPROVIDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private Perfect.Dictionary.Provider.DS.dsPROVIDER dsPROVIDER;
        private System.Windows.Forms.BindingSource pROVIDERFULLBindingSource;
        private Perfect.Dictionary.Provider.DS.dsPROVIDERTableAdapters.PROVIDERFULLTableAdapter pROVIDERFULLTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rpText;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveInt;

    }
}
