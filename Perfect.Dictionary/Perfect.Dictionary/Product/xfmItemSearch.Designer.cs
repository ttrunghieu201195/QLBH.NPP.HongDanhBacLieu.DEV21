namespace Perfect.Dictionary.Product
{
    partial class xfmItemSearch
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
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtProductID = new Perfect.Common.xucTextEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.rgCal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtProductName = new Perfect.Common.xucTextEdit();
            this.btView = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liID = new DevExpress.XtraLayout.LayoutControlItem();
            this.liName = new DevExpress.XtraLayout.LayoutControlItem();
            this.liSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.liList = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsSearch = new Perfect.Dictionary.Product.DS.dsSearch();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new Perfect.Dictionary.Product.DS.dsSearchTableAdapters.PRODUCTTableAdapter();
            this.colSelected = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.ImageIndex = 22;
            this.btClose.Location = new System.Drawing.Point(627, 546);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(68, 27);
            this.btClose.StyleController = this.layoutControl1;
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Thoát";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnOK);
            this.layoutControl1.Controls.Add(this.txtProductID);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Controls.Add(this.btClose);
            this.layoutControl1.Controls.Add(this.txtProductName);
            this.layoutControl1.Controls.Add(this.btView);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(707, 585);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(485, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 27);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Tạo Mới";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(543, 546);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 27);
            this.btnOK.StyleController = this.layoutControl1;
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Đồng ý";
            // 
            // txtProductID
            // 
            this.txtProductID.DefaultText = "Mã Hàng";
            this.txtProductID.EditValue = "Mã Hàng";
            this.txtProductID.Location = new System.Drawing.Point(20, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProductID.Properties.Appearance.Options.UseFont = true;
            this.txtProductID.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductID.Properties.NullText = "Mã Hàng";
            this.txtProductID.Properties.NullValuePrompt = "Mã Hàng";
            this.txtProductID.Size = new System.Drawing.Size(131, 22);
            this.txtProductID.StyleController = this.layoutControl1;
            this.txtProductID.TabIndex = 5;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.pRODUCTBindingSource;
            this.gcList.Location = new System.Drawing.Point(9, 73);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rgCal,
            this.rpDate});
            this.gcList.Size = new System.Drawing.Size(689, 466);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSelected,
            this.colProduct_ID,
            this.colProduct_Name,
            this.colQuantity});
            this.gbList.GridControl = this.gcList;
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsView.ColumnAutoWidth = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 80;
            // 
            // rgCal
            // 
            this.rgCal.AutoHeight = false;
            this.rgCal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rgCal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rgCal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rgCal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rgCal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rgCal.Name = "rgCal";
            // 
            // rpDate
            // 
            this.rpDate.AutoHeight = false;
            this.rpDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.rpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpDate.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            this.rpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpDate.Mask.EditMask = "dd/MM/yyyy";
            this.rpDate.Name = "rpDate";
            this.rpDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // txtProductName
            // 
            this.txtProductName.DefaultText = "Hàng Hoá";
            this.txtProductName.EditValue = "Hàng Hoá";
            this.txtProductName.Location = new System.Drawing.Point(161, 22);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductName.Properties.NullText = "Hàng Hoá";
            this.txtProductName.Properties.NullValuePrompt = "Hàng Hoá";
            this.txtProductName.Size = new System.Drawing.Size(237, 22);
            this.txtProductName.StyleController = this.layoutControl1;
            this.txtProductName.TabIndex = 6;
            // 
            // btView
            // 
            this.btView.ImageIndex = 44;
            this.btView.Location = new System.Drawing.Point(408, 20);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(67, 27);
            this.btView.StyleController = this.layoutControl1;
            this.btView.TabIndex = 7;
            this.btView.Text = "Tìm";
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem2,
            this.liList,
            this.layoutControlItem2,
            this.emptySpaceItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 7, 7);
            this.layoutControlGroup1.Size = new System.Drawing.Size(707, 585);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liID,
            this.liName,
            this.liSearch,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup2.Size = new System.Drawing.Size(693, 53);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // liID
            // 
            this.liID.Control = this.txtProductID;
            this.liID.CustomizationFormText = "liID";
            this.liID.Location = new System.Drawing.Point(0, 0);
            this.liID.MaxSize = new System.Drawing.Size(141, 30);
            this.liID.MinSize = new System.Drawing.Size(141, 30);
            this.liID.Name = "liID";
            this.liID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 5);
            this.liID.Size = new System.Drawing.Size(141, 37);
            this.liID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.liID.Text = "liID";
            this.liID.TextSize = new System.Drawing.Size(0, 0);
            this.liID.TextToControlDistance = 0;
            this.liID.TextVisible = false;
            // 
            // liName
            // 
            this.liName.Control = this.txtProductName;
            this.liName.CustomizationFormText = "liName";
            this.liName.Location = new System.Drawing.Point(141, 0);
            this.liName.Name = "liName";
            this.liName.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 7, 5);
            this.liName.Size = new System.Drawing.Size(247, 37);
            this.liName.Text = "liName";
            this.liName.TextSize = new System.Drawing.Size(0, 0);
            this.liName.TextToControlDistance = 0;
            this.liName.TextVisible = false;
            // 
            // liSearch
            // 
            this.liSearch.Control = this.btView;
            this.liSearch.CustomizationFormText = "liSearch";
            this.liSearch.Location = new System.Drawing.Point(388, 0);
            this.liSearch.MaxSize = new System.Drawing.Size(77, 37);
            this.liSearch.MinSize = new System.Drawing.Size(77, 37);
            this.liSearch.Name = "liSearch";
            this.liSearch.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.liSearch.Size = new System.Drawing.Size(77, 37);
            this.liSearch.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.liSearch.Text = "liSearch";
            this.liSearch.TextSize = new System.Drawing.Size(0, 0);
            this.liSearch.TextToControlDistance = 0;
            this.liSearch.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(547, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(130, 37);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAdd;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(465, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(82, 37);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(82, 37);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(82, 37);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 53);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(693, 11);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // liList
            // 
            this.liList.Control = this.gcList;
            this.liList.CustomizationFormText = "liList";
            this.liList.Location = new System.Drawing.Point(0, 64);
            this.liList.Name = "liList";
            this.liList.Size = new System.Drawing.Size(693, 470);
            this.liList.Text = "liList";
            this.liList.TextSize = new System.Drawing.Size(0, 0);
            this.liList.TextToControlDistance = 0;
            this.liList.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnOK;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(531, 534);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(84, 37);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(84, 37);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(84, 37);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 534);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(531, 37);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btClose;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(615, 534);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(78, 37);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(78, 37);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(78, 37);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // dsSearch
            // 
            this.dsSearch.DataSetName = "dsSearch";
            this.dsSearch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dsSearch;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // colSelected
            // 
            this.colSelected.Caption = " ";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.OptionsColumn.ReadOnly = true;
            this.colSelected.Visible = true;
            this.colSelected.Width = 40;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.Caption = "Mã";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 100;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.Caption = "Tên";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 220;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Tồn";
            this.colQuantity.ColumnEdit = this.rgCal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.Visible = true;
            this.colQuantity.Width = 100;
            // 
            // xfmItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 585);
            this.Controls.Add(this.layoutControl1);
            this.MinimizeBox = false;
            this.Name = "xfmItemSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.xfmItemSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btClose;
        private DevExpress.XtraEditors.SimpleButton btView;
        private Perfect.Common.xucTextEdit txtProductName;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rgCal;
        private Perfect.Common.xucTextEdit txtProductID;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem liID;
        private DevExpress.XtraLayout.LayoutControlItem liName;
        private DevExpress.XtraLayout.LayoutControlItem liSearch;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem liList;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Perfect.Dictionary.Product.DS.dsSearch dsSearch;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private Perfect.Dictionary.Product.DS.dsSearchTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSelected;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQuantity;
    }
}