namespace Perfect.Dictionary.Customer.usercontrol.Professional
{
    partial class XucCustomer
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
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveInt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCUSTOMER = new Perfect.Dictionary.Customer.DS.dsCUSTOMER();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNickSky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNickYM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDebt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cUSTOMERTableAdapter = new Perfect.Dictionary.Customer.DS.dsCUSTOMERTableAdapters.CUSTOMERTableAdapter();
            this.colEmployee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpText)).BeginInit();
            this.SuspendLayout();
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
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 85;
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
            this.gcList.DataSource = this.cUSTOMERBindingSource;
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
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dsCUSTOMER;
            // 
            // dsCUSTOMER
            // 
            this.dsCUSTOMER.DataSetName = "dsCUSTOMER";
            this.dsCUSTOMER.EnforceConstraints = false;
            this.dsCUSTOMER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerAddress,
            this.colTax,
            this.colTel,
            this.colFax,
            this.colEmail,
            this.colMobile,
            this.colBankAccount,
            this.colBankName,
            this.colCustomer_Group_Name,
            this.colCustomer_ID,
            this.colNickSky,
            this.colNickYM,
            this.colWebsite,
            this.colActiveInt,
            this.colActive,
            this.colDescription,
            this.colIsDebt,
            this.colEmployee_Name,
            this.colDistrict});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
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
            this.gbList.OptionsBehavior.AllowIncrementalSearch = true;
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomer_Group_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.VertScrollTipFieldName = "CustomerName";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GbListCustomDrawRowIndicator);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gbList_KeyDown);
            this.gbList.Layout += new System.EventHandler(this.gbList_Layout);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.gbList_DoubleClick);
            this.gbList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gbList_RowCellClick);
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "Tên Khách Hàng";
            this.colCustomerName.ColumnEdit = this.rpText;
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.ReadOnly = true;
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 242;
            // 
            // rpText
            // 
            this.rpText.AutoHeight = false;
            this.rpText.Name = "rpText";
            this.rpText.DoubleClick += new System.EventHandler(this.gbList_DoubleClick);
            // 
            // colCustomerAddress
            // 
            this.colCustomerAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerAddress.Caption = "Địa Chỉ";
            this.colCustomerAddress.ColumnEdit = this.rpText;
            this.colCustomerAddress.FieldName = "CustomerAddress";
            this.colCustomerAddress.Name = "colCustomerAddress";
            this.colCustomerAddress.OptionsColumn.ReadOnly = true;
            this.colCustomerAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerAddress.Visible = true;
            this.colCustomerAddress.VisibleIndex = 8;
            this.colCustomerAddress.Width = 244;
            // 
            // colTax
            // 
            this.colTax.AppearanceHeader.Options.UseTextOptions = true;
            this.colTax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTax.Caption = "Mã Số Thuế";
            this.colTax.ColumnEdit = this.rpText;
            this.colTax.FieldName = "Tax";
            this.colTax.Name = "colTax";
            this.colTax.OptionsColumn.ReadOnly = true;
            this.colTax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTax.Visible = true;
            this.colTax.VisibleIndex = 15;
            this.colTax.Width = 77;
            // 
            // colTel
            // 
            this.colTel.AppearanceHeader.Options.UseTextOptions = true;
            this.colTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTel.Caption = "Điện Thoại";
            this.colTel.ColumnEdit = this.rpText;
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.OptionsColumn.ReadOnly = true;
            this.colTel.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 9;
            this.colTel.Width = 91;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.ColumnEdit = this.rpText;
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 11;
            this.colFax.Width = 88;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.ColumnEdit = this.rpText;
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 12;
            this.colEmail.Width = 114;
            // 
            // colMobile
            // 
            this.colMobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colMobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMobile.Caption = "Di Động";
            this.colMobile.ColumnEdit = this.rpText;
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.ReadOnly = true;
            this.colMobile.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 10;
            this.colMobile.Width = 85;
            // 
            // colBankAccount
            // 
            this.colBankAccount.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankAccount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankAccount.Caption = "Số Tài Khoản";
            this.colBankAccount.ColumnEdit = this.rpText;
            this.colBankAccount.FieldName = "BankAccount";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.OptionsColumn.ReadOnly = true;
            this.colBankAccount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBankAccount.Visible = true;
            this.colBankAccount.VisibleIndex = 16;
            this.colBankAccount.Width = 86;
            // 
            // colBankName
            // 
            this.colBankName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankName.Caption = "Tên Ngân Hàng";
            this.colBankName.ColumnEdit = this.rpText;
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.ReadOnly = true;
            this.colBankName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 17;
            this.colBankName.Width = 170;
            // 
            // colCustomer_Group_Name
            // 
            this.colCustomer_Group_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_Group_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_Group_Name.Caption = "Khu Vực";
            this.colCustomer_Group_Name.ColumnEdit = this.rpText;
            this.colCustomer_Group_Name.FieldName = "Customer_Group_Name";
            this.colCustomer_Group_Name.Name = "colCustomer_Group_Name";
            this.colCustomer_Group_Name.OptionsColumn.ReadOnly = true;
            this.colCustomer_Group_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_Group_Name.Width = 139;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_ID.Caption = "Mã KH";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsColumn.ReadOnly = true;
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 0;
            this.colCustomer_ID.Width = 99;
            // 
            // colNickSky
            // 
            this.colNickSky.AppearanceHeader.Options.UseTextOptions = true;
            this.colNickSky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNickSky.FieldName = "NickSky";
            this.colNickSky.Name = "colNickSky";
            this.colNickSky.OptionsColumn.ReadOnly = true;
            this.colNickSky.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNickSky.Visible = true;
            this.colNickSky.VisibleIndex = 13;
            this.colNickSky.Width = 86;
            // 
            // colNickYM
            // 
            this.colNickYM.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colNickYM.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNickYM.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colNickYM.AppearanceCell.Options.UseBackColor = true;
            this.colNickYM.AppearanceCell.Options.UseFont = true;
            this.colNickYM.AppearanceCell.Options.UseForeColor = true;
            this.colNickYM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNickYM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNickYM.Caption = "Tuyến GH";
            this.colNickYM.FieldName = "NickYM";
            this.colNickYM.Name = "colNickYM";
            this.colNickYM.OptionsColumn.ReadOnly = true;
            this.colNickYM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNickYM.Visible = true;
            this.colNickYM.VisibleIndex = 2;
            this.colNickYM.Width = 165;
            // 
            // colWebsite
            // 
            this.colWebsite.AppearanceHeader.Options.UseTextOptions = true;
            this.colWebsite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 14;
            this.colWebsite.Width = 108;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 182;
            // 
            // colIsDebt
            // 
            this.colIsDebt.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsDebt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsDebt.Caption = "Cộng Gộp Nợ";
            this.colIsDebt.FieldName = "IsDebt";
            this.colIsDebt.Name = "colIsDebt";
            this.colIsDebt.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIsDebt.Visible = true;
            this.colIsDebt.VisibleIndex = 6;
            this.colIsDebt.Width = 85;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // colEmployee_Name
            // 
            this.colEmployee_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployee_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee_Name.Caption = "NV Thu Nợ";
            this.colEmployee_Name.FieldName = "Employee_Name";
            this.colEmployee_Name.Name = "colEmployee_Name";
            this.colEmployee_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_Name.Visible = true;
            this.colEmployee_Name.VisibleIndex = 3;
            this.colEmployee_Name.Width = 178;
            // 
            // colDistrict
            // 
            this.colDistrict.AppearanceHeader.Options.UseTextOptions = true;
            this.colDistrict.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDistrict.Caption = "Ngày Thu Nợ";
            this.colDistrict.FieldName = "District";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDistrict.Visible = true;
            this.colDistrict.VisibleIndex = 4;
            this.colDistrict.Width = 84;
            // 
            // XucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.gcList);
            this.Name = "XucCustomer";
            this.Controls.SetChildIndex(this.ucToolBar, 0);
            this.Controls.SetChildIndex(this.gcList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private Perfect.Dictionary.Customer.DS.dsCUSTOMER dsCUSTOMER;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colTax;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_Name;
        private Perfect.Dictionary.Customer.DS.dsCUSTOMERTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rpText;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNickSky;
        private DevExpress.XtraGrid.Columns.GridColumn colNickYM;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveInt;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDebt;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDistrict;

    }
}