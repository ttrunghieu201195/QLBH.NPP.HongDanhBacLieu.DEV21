using Perfect.Dictionary.UI.UBarcode.DataSets;
using Perfect.Common;

namespace Perfect.Dictionary.UI.UBarcode
{
    partial class XucBaseBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucBaseBarcode));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Dictionary.UI.UBarcode.DataSets.dsPRODUCT();
            this.pRODUCTTableAdapter = new Perfect.Dictionary.UI.UBarcode.DataSets.dsPRODUCTTableAdapters.PRODUCTTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbxAction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAmount = new DevExpress.XtraEditors.CalcEdit();
            this.txtPrice = new DevExpress.XtraEditors.CalcEdit();
            this.txtQuantity = new DevExpress.XtraEditors.CalcEdit();
            this.txtProductName = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtProduct_ID = new Perfect.Common.xucTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dsPRODUCT;
            // 
            // dsPRODUCT
            // 
            this.dsPRODUCT.DataSetName = "dsPRODUCT";
            this.dsPRODUCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.cbxAction);
            this.layoutControl1.Controls.Add(this.txtAmount);
            this.layoutControl1.Controls.Add(this.txtPrice);
            this.layoutControl1.Controls.Add(this.txtQuantity);
            this.layoutControl1.Controls.Add(this.txtProductName);
            this.layoutControl1.Controls.Add(this.txtProduct_ID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(221, 221);
            this.layoutControl1.TabIndex = 31;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Location = new System.Drawing.Point(10, 163);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(201, 34);
            this.panelControl1.TabIndex = 32;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowDrop = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 30);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            this.btnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnAddKeyPress);
            // 
            // cbxAction
            // 
            this.cbxAction.EditValue = "Cộng Thêm";
            this.cbxAction.Location = new System.Drawing.Point(70, 139);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cbxAction.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.cbxAction.Properties.Items.AddRange(new object[] {
            "Thêm Dòng Mới",
            "Thay Thế Dòng",
            "Cộng Thêm",
            "Kiểm Tra Trùng"});
            this.cbxAction.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CbxActionPropertiesButtonClick);
            this.cbxAction.Size = new System.Drawing.Size(139, 22);
            this.cbxAction.StyleController = this.layoutControl1;
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "Cảnh Báo";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = resources.GetString("toolTipItem1.Text");
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.cbxAction.SuperTip = superToolTip1;
            this.cbxAction.TabIndex = 31;
            this.cbxAction.SelectedIndexChanged += new System.EventHandler(this.CbxActionSelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(70, 115);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAmount.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAmount.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAmount.Size = new System.Drawing.Size(139, 20);
            this.txtAmount.StyleController = this.layoutControl1;
            this.txtAmount.TabIndex = 29;
            this.txtAmount.EditValueChanged += new System.EventHandler(this.TxtAmountEditValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(70, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrice.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPrice.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtPrice.Size = new System.Drawing.Size(139, 20);
            this.txtPrice.StyleController = this.layoutControl1;
            this.txtPrice.TabIndex = 28;
            this.txtPrice.EditValueChanged += new System.EventHandler(this.TxtPriceEditValueChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Location = new System.Drawing.Point(70, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtQuantity.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtQuantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Size = new System.Drawing.Size(139, 20);
            this.txtQuantity.StyleController = this.layoutControl1;
            this.txtQuantity.TabIndex = 27;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.TxtQuantityEditValueChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(12, 43);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.AutoComplete = false;
            this.txtProductName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            toolTipItem2.Text = "Nếu khách hàng chưa tồn tại, bạn có thể nhấn nút này để thêm khách hàng mới này v" +
                "ào.";
            superToolTip2.Items.Add(toolTipItem2);
            this.txtProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Tạo", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("txtProductName.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, superToolTip2, false)});
            this.txtProductName.Properties.DataSource = this.pRODUCTBindingSource;
            this.txtProductName.Properties.DisplayMember = "Product_Name";
            this.txtProductName.Properties.NullText = "";
            this.txtProductName.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtProductName.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.txtProductName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtProductName.Properties.UseParentBackground = true;
            this.txtProductName.Properties.ValidateOnEnterKey = true;
            this.txtProductName.Properties.ValueMember = "Product_ID";
            this.txtProductName.Properties.View = this.gridLookUpEdit1View;
            this.txtProductName.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCustomerNamePropertiesButtonClick);
            this.txtProductName.Size = new System.Drawing.Size(197, 20);
            this.txtProductName.StyleController = this.layoutControl1;
            this.txtProductName.TabIndex = 26;
            this.txtProductName.EditValueChanged += new System.EventHandler(this.TxtProductNameEditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomer_ID});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Hàng Hoá";
            this.colCustomerName.FieldName = "Product_Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.FixedWidth = true;
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 230;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.Caption = "Mã Hàng";
            this.colCustomer_ID.FieldName = "Product_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsColumn.FixedWidth = true;
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 1;
            this.colCustomer_ID.Width = 80;
            // 
            // txtProduct_ID
            // 
            this.txtProduct_ID.DefaultText = "Mã Hàng Hoá";
            this.txtProduct_ID.EditValue = "Mã Hàng Hoá";
            this.txtProduct_ID.Location = new System.Drawing.Point(12, 12);
            this.txtProduct_ID.Name = "txtProduct_ID";
            this.txtProduct_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtProduct_ID.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.txtProduct_ID.Properties.Appearance.Options.UseFont = true;
            this.txtProduct_ID.Properties.Appearance.Options.UseForeColor = true;
            this.txtProduct_ID.Properties.Appearance.Options.UseTextOptions = true;
            this.txtProduct_ID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtProduct_ID.Properties.NullText = "Mã Hàng Hoá";
            this.txtProduct_ID.Properties.NullValuePrompt = "Mã Hàng Hoá";
            this.txtProduct_ID.Size = new System.Drawing.Size(197, 20);
            this.txtProduct_ID.StyleController = this.layoutControl1;
            this.txtProduct_ID.TabIndex = 0;
            this.txtProduct_ID.DoubleClick += new System.EventHandler(this.TxtProductIdDoubleClick);
            this.txtProduct_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductIdKeyDown);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(221, 221);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtProduct_ID;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 31);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(61, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(201, 31);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtProductName;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtQuantity;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem3.Text = "Số Lượng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtPrice;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 79);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem4.Text = "Đơn Giá";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtAmount;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 103);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem5.Text = "Thành Tiền";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbxAction;
            this.layoutControlItem7.CustomizationFormText = "Hành Động";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 127);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(201, 26);
            this.layoutControlItem7.Text = "Hành Động";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.panelControl1;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 153);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 34);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(199, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem6.Size = new System.Drawing.Size(201, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 187);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(201, 14);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // XucBaseBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "XucBaseBarcode";
            this.Size = new System.Drawing.Size(221, 221);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxAction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private dsPRODUCT dsPRODUCT;
        private Perfect.Dictionary.UI.UBarcode.DataSets.dsPRODUCTTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CalcEdit txtAmount;
        private DevExpress.XtraEditors.CalcEdit txtPrice;
        private DevExpress.XtraEditors.CalcEdit txtQuantity;
        private DevExpress.XtraEditors.GridLookUpEdit txtProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private xucTextEdit txtProduct_ID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ComboBoxEdit cbxAction;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
