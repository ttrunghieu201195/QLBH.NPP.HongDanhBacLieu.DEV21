namespace Perfect.Dictionary.Product
{
    partial class xfmGroupChanged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmGroupChanged));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cbxGroup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.pRODUCTGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCTGROUP = new Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUP();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductGroup_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductGroup_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.pRODUCT_GROUPTableAdapter = new Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUPTableAdapters.PRODUCT_GROUPTableAdapter();
            this.lblTel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCTGROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGroup
            // 
            this.cbxGroup.Location = new System.Drawing.Point(12, 49);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Properties.ActionButtonIndex = 1;
            this.cbxGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroup.Properties.Appearance.Options.UseFont = true;
            this.cbxGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject2.Options.UseFont = true;
            this.cbxGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cbxGroup.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Add", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "None", null, true)});
            this.cbxGroup.Properties.DataSource = this.pRODUCTGROUPBindingSource;
            this.cbxGroup.Properties.DisplayMember = "ProductGroup_Name";
            this.cbxGroup.Properties.ImmediatePopup = true;
            this.cbxGroup.Properties.NullText = "";
            this.cbxGroup.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbxGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxGroup.Properties.ValueMember = "ProductGroup_ID";
            this.cbxGroup.Properties.View = this.gridView2;
            this.cbxGroup.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxGroup_Properties_ButtonClick);
            this.cbxGroup.Size = new System.Drawing.Size(338, 22);
            this.cbxGroup.TabIndex = 5;
            // 
            // pRODUCTGROUPBindingSource
            // 
            this.pRODUCTGROUPBindingSource.DataMember = "PRODUCT_GROUP";
            this.pRODUCTGROUPBindingSource.DataSource = this.dsPRODUCTGROUP;
            // 
            // dsPRODUCTGROUP
            // 
            this.dsPRODUCTGROUP.DataSetName = "dsPRODUCTGROUP";
            this.dsPRODUCTGROUP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductGroup_Name,
            this.colProductGroup_ID});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colProductGroup_Name
            // 
            this.colProductGroup_Name.Caption = "Nhóm Hàng";
            this.colProductGroup_Name.FieldName = "ProductGroup_Name";
            this.colProductGroup_Name.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colProductGroup_Name.Name = "colProductGroup_Name";
            this.colProductGroup_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProductGroup_Name.Visible = true;
            this.colProductGroup_Name.VisibleIndex = 0;
            this.colProductGroup_Name.Width = 200;
            // 
            // colProductGroup_ID
            // 
            this.colProductGroup_ID.Caption = "Mã";
            this.colProductGroup_ID.FieldName = "ProductGroup_ID";
            this.colProductGroup_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colProductGroup_ID.Name = "colProductGroup_ID";
            this.colProductGroup_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProductGroup_ID.Visible = true;
            this.colProductGroup_ID.VisibleIndex = 1;
            this.colProductGroup_ID.Width = 181;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(275, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 22);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(194, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 22);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Thực Hiện";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pRODUCT_GROUPTableAdapter
            // 
            this.pRODUCT_GROUPTableAdapter.ClearBeforeFill = true;
            // 
            // lblTel
            // 
            this.lblTel.Appearance.Options.UseTextOptions = true;
            this.lblTel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTel.Location = new System.Drawing.Point(12, 12);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(338, 31);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Thực hiện thay đổi nhóm hàng hàng loạt cho những hàng hóa được chọn.";
            // 
            // xfmGroupChanged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 106);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbxGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmGroupChanged";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm Hàng";
            this.Load += new System.EventHandler(this.xfmGroupChanged_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xfmGroupChanged_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCTGROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cbxGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colProductGroup_ID;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUP dsPRODUCTGROUP;
        private System.Windows.Forms.BindingSource pRODUCTGROUPBindingSource;
        private Perfect.Dictionary.ProductGroup.DS.dsPRODUCTGROUPTableAdapters.PRODUCT_GROUPTableAdapter pRODUCT_GROUPTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblTel;
    }
}