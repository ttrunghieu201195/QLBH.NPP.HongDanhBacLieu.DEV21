namespace Perfect.Dictionary.Product
{
    partial class xfmChangeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmChangeInfo));
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
            this.txtCarNumber = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cARSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARSTableAdapter = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.CARSTableAdapter();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(232, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(151, 107);
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
            this.labelControl1.Location = new System.Drawing.Point(17, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 24);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Trạng thái";
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.EditValue = null;
            this.txtCreatedDate.Location = new System.Drawing.Point(84, 13);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreatedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCreatedDate.Size = new System.Drawing.Size(223, 20);
            this.txtCreatedDate.TabIndex = 0;
            this.txtCreatedDate.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Ngày lập";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(84, 39);
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
            this.txtStatus.Size = new System.Drawing.Size(223, 22);
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
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(84, 66);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCarNumber.Properties.Appearance.Options.UseFont = true;
            this.txtCarNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtCarNumber.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtCarNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCarNumber.Properties.DataSource = this.cARSBindingSource;
            this.txtCarNumber.Properties.DisplayMember = "CarNumber";
            this.txtCarNumber.Properties.NullText = "";
            this.txtCarNumber.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtCarNumber.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtCarNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtCarNumber.Properties.ValueMember = "ID";
            this.txtCarNumber.Properties.View = this.gridView1;
            this.txtCarNumber.Size = new System.Drawing.Size(223, 22);
            this.txtCarNumber.TabIndex = 1;
            this.txtCarNumber.TabStop = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colCarNumber});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(17, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 24);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Xe giao";
            // 
            // cARSBindingSource
            // 
            this.cARSBindingSource.DataMember = "CARS";
            this.cARSBindingSource.DataSource = this.dsSTOCK_OUTWARD_DETAIL;
            // 
            // cARSTableAdapter
            // 
            this.cARSTableAdapter.ClearBeforeFill = true;
            // 
            // colID1
            // 
            this.colID1.AppearanceHeader.Options.UseTextOptions = true;
            this.colID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID1.Caption = "Mã số";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colCarNumber
            // 
            this.colCarNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colCarNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCarNumber.Caption = "Số xe";
            this.colCarNumber.FieldName = "CarNumber";
            this.colCarNumber.Name = "colCarNumber";
            this.colCarNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCarNumber.Visible = true;
            this.colCarNumber.VisibleIndex = 1;
            // 
            // xfmChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 146);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.txtStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmChangeInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin Đơn hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfmGroupChanged_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.GridLookUpEdit txtCarNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource cARSBindingSource;
        private Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.CARSTableAdapter cARSTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCarNumber;
    }
}