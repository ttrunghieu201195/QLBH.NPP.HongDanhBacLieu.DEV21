namespace Perfect.Dictionary.Product
{
    partial class xfmReplicationSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmReplicationSales));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nOTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK_OUTWARD_DETAIL = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAIL();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nOTESTableAdapter = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.NOTESTableAdapter();
            this.txtCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCUSTOMERS = new Perfect.Inventory.Core.Inventory.Outward.dsCUSTOMERS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRouteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Group_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cUSTOMERTableAdapter = new Perfect.Inventory.Core.Inventory.Outward.dsCUSTOMERSTableAdapters.CUSTOMERTableAdapter();
            this.txtSaleID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCUSTOMERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(353, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(272, 125);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Thực Hiện";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(18, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 24);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Trạng thái";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.EditValue = null;
            this.txtCreatedDate.Location = new System.Drawing.Point(85, 43);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreatedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCreatedDate.Size = new System.Drawing.Size(170, 20);
            this.txtCreatedDate.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Ngày lập";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(85, 69);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.Appearance.Options.UseForeColor = true;
            this.txtStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStatus.Properties.DataSource = this.nOTESBindingSource;
            this.txtStatus.Properties.DisplayMember = "Name";
            this.txtStatus.Properties.NullText = "";
            this.txtStatus.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtStatus.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtStatus.Properties.ValueMember = "ID";
            this.txtStatus.Properties.View = this.gridLookUpEdit1View;
            this.txtStatus.Size = new System.Drawing.Size(344, 22);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.TabStop = false;
            // 
            // nOTESBindingSource
            // 
            this.nOTESBindingSource.DataMember = "NOTES";
            this.nOTESBindingSource.DataSource = this.dsSTOCK_OUTWARD_DETAIL;
            // 
            // dsSTOCK_OUTWARD_DETAIL
            // 
            this.dsSTOCK_OUTWARD_DETAIL.DataSetName = "dsSTOCK_OUTWARD_DETAIL";
            this.dsSTOCK_OUTWARD_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "Mã số";
            this.colID.FieldName = "ID";
            this.colID.FieldNameSortGroup = "Mã số";
            this.colID.Name = "colID";
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "Trạng thái";
            this.colName.FieldName = "Name";
            this.colName.FieldNameSortGroup = "Trạng thái";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // nOTESTableAdapter
            // 
            this.nOTESTableAdapter.ClearBeforeFill = true;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(85, 97);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCustomer.Properties.Appearance.Options.UseFont = true;
            this.txtCustomer.Properties.Appearance.Options.UseForeColor = true;
            this.txtCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustomer.Properties.DataSource = this.cUSTOMERBindingSource;
            this.txtCustomer.Properties.DisplayMember = "CustomerName";
            this.txtCustomer.Properties.NullText = "";
            this.txtCustomer.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtCustomer.Properties.ValueMember = "Customer_ID";
            this.txtCustomer.Properties.View = this.gridView1;
            this.txtCustomer.Size = new System.Drawing.Size(344, 22);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.TabStop = false;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dsCUSTOMERS;
            // 
            // dsCUSTOMERS
            // 
            this.dsCUSTOMERS.DataSetName = "dsCUSTOMERS";
            this.dsCUSTOMERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomer_ID,
            this.colRouteID,
            this.colRouteName,
            this.colCustomer_Group_Name});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "Tên khách hàng";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 338;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_ID.Caption = "Mã số";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 1;
            this.colCustomer_ID.Width = 209;
            // 
            // colRouteID
            // 
            this.colRouteID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteID.Caption = "Mã tuyến";
            this.colRouteID.FieldName = "RouteID";
            this.colRouteID.Name = "colRouteID";
            this.colRouteID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRouteID.Visible = true;
            this.colRouteID.VisibleIndex = 2;
            this.colRouteID.Width = 209;
            // 
            // colRouteName
            // 
            this.colRouteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRouteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRouteName.Caption = "Tên Tuyến";
            this.colRouteName.FieldName = "RouteName";
            this.colRouteName.Name = "colRouteName";
            this.colRouteName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRouteName.Visible = true;
            this.colRouteName.VisibleIndex = 3;
            this.colRouteName.Width = 209;
            // 
            // colCustomer_Group_Name
            // 
            this.colCustomer_Group_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer_Group_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer_Group_Name.Caption = "Khu vực";
            this.colCustomer_Group_Name.FieldName = "Customer_Group_Name";
            this.colCustomer_Group_Name.Name = "colCustomer_Group_Name";
            this.colCustomer_Group_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_Group_Name.Visible = true;
            this.colCustomer_Group_Name.VisibleIndex = 4;
            this.colCustomer_Group_Name.Width = 211;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(18, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 24);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Khách hàng";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(85, 17);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSaleID.Properties.Appearance.Options.UseBackColor = true;
            this.txtSaleID.Properties.ReadOnly = true;
            this.txtSaleID.Size = new System.Drawing.Size(170, 20);
            this.txtSaleID.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Số đơn hàng";
            // 
            // xfmReplicationSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 164);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmReplicationSales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Bản Đơn Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCUSTOMERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtCreatedDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit txtStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAIL dsSTOCK_OUTWARD_DETAIL;
        private System.Windows.Forms.BindingSource nOTESBindingSource;
        private Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.NOTESTableAdapter nOTESTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.GridLookUpEdit txtCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Perfect.Inventory.Core.Inventory.Outward.dsCUSTOMERS dsCUSTOMERS;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private Perfect.Inventory.Core.Inventory.Outward.dsCUSTOMERSTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteID;
        private DevExpress.XtraGrid.Columns.GridColumn colRouteName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Group_Name;
        private DevExpress.XtraEditors.TextEdit txtSaleID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}