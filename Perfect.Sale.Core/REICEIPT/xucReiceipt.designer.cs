
using Perfect.Dictionary.UI.UBarcode;

namespace Perfect.Sale.Core.REICEIPT
{
    partial class xucReiceipt
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucReiceipt));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscount = new DevExpress.XtraEditors.CalcEdit();
            this.txtDiscountRate = new DevExpress.XtraEditors.CalcEdit();
            this.chxIsPrint = new DevExpress.XtraEditors.CheckEdit();
            this.txtTotalText = new DevExpress.XtraEditors.TextEdit();
            this.chxKhautru = new DevExpress.XtraEditors.CheckEdit();
            this.txtTotal = new DevExpress.XtraEditors.CalcEdit();
            this.txtDebt = new DevExpress.XtraEditors.CalcEdit();
            this.txtCustomerName = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCustomer = new Perfect.Sale.Core.Common.DS.dsCustomer();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtTax = new DevExpress.XtraEditors.TextEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.dEBTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDEBT = new Perfect.Sale.Core.REICEIPT.DS.dsDEBT();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIsCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colError = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colErrorText = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRefDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDebt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPayment = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCopyDebt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpgProduct = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.rpglkProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpgStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpProductName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rcVat = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rgCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtExchange = new DevExpress.XtraEditors.CalcEdit();
            this.dtCreated = new DevExpress.XtraEditors.DateEdit();
            this.cbxCurrency = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcBarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcList = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcTax = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcTel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcCustomerID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcCreated = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcExchange = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colRefType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cUSTOMERTableAdapter = new Perfect.Sale.Core.Common.DS.dsCustomerTableAdapters.CUSTOMERTableAdapter();
            this.dEBTTableAdapter = new Perfect.Sale.Core.REICEIPT.DS.dsDEBTTableAdapters.DEBTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxIsPrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxKhautru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEBTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDEBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCreated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // plBottom
            // 
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBottom.Location = new System.Drawing.Point(0, 0);
            this.plBottom.Size = new System.Drawing.Size(800, 31);
            // 
            // ucBarB
            // 
            this.ucBarB.Size = new System.Drawing.Size(796, 27);
            // 
            // rpVal
            // 
            this.rpVal.AutoHeight = false;
            this.rpVal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpVal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpVal.Name = "rpVal";
            this.rpVal.ShowCloseButton = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(65, 103);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(511, 25);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 5;
            // 
            // lcMain
            // 
            this.lcMain.AllowDrop = true;
            this.lcMain.Controls.Add(this.txtEmail);
            this.lcMain.Controls.Add(this.txtDiscount);
            this.lcMain.Controls.Add(this.txtDiscountRate);
            this.lcMain.Controls.Add(this.chxIsPrint);
            this.lcMain.Controls.Add(this.txtTotalText);
            this.lcMain.Controls.Add(this.chxKhautru);
            this.lcMain.Controls.Add(this.txtTotal);
            this.lcMain.Controls.Add(this.txtDebt);
            this.lcMain.Controls.Add(this.txtCustomerName);
            this.lcMain.Controls.Add(this.txtID);
            this.lcMain.Controls.Add(this.txtAddress);
            this.lcMain.Controls.Add(this.txtTax);
            this.lcMain.Controls.Add(this.gcList);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.txtTel);
            this.lcMain.Controls.Add(this.txtExchange);
            this.lcMain.Controls.Add(this.dtCreated);
            this.lcMain.Controls.Add(this.cbxCurrency);
            this.lcMain.Controls.Add(this.txtCustomerID);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 31);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsFocus.AllowFocusControlOnActivatedTabPage = true;
            this.lcMain.OptionsView.AllowHotTrack = true;
            this.lcMain.OptionsView.EnableIndentsInGroupsWithoutBorders = true;
            this.lcMain.OptionsView.HighlightDisabledItem = true;
            this.lcMain.OptionsView.HighlightFocusedItem = true;
            this.lcMain.Root = this.layoutControlGroup2;
            this.lcMain.Size = new System.Drawing.Size(800, 602);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(431, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.StyleController = this.lcMain;
            this.txtEmail.TabIndex = 127;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(274, 156);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDiscount.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDiscount.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDiscount.Size = new System.Drawing.Size(111, 20);
            this.txtDiscount.StyleController = this.lcMain;
            this.txtDiscount.TabIndex = 124;
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Location = new System.Drawing.Point(220, 156);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDiscountRate.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtDiscountRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDiscountRate.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtDiscountRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDiscountRate.Size = new System.Drawing.Size(50, 20);
            this.txtDiscountRate.StyleController = this.lcMain;
            this.txtDiscountRate.TabIndex = 124;
            // 
            // chxIsPrint
            // 
            this.chxIsPrint.EditValue = true;
            this.chxIsPrint.Location = new System.Drawing.Point(3, 580);
            this.chxIsPrint.Name = "chxIsPrint";
            this.chxIsPrint.Properties.Caption = "In sau khi lưu";
            this.chxIsPrint.Size = new System.Drawing.Size(794, 19);
            this.chxIsPrint.StyleController = this.lcMain;
            this.chxIsPrint.TabIndex = 2;
            this.chxIsPrint.Visible = false;
            // 
            // txtTotalText
            // 
            this.txtTotalText.Location = new System.Drawing.Point(389, 156);
            this.txtTotalText.Name = "txtTotalText";
            this.txtTotalText.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalText.Properties.Appearance.Options.UseFont = true;
            this.txtTotalText.Properties.ReadOnly = true;
            this.txtTotalText.Size = new System.Drawing.Size(408, 20);
            this.txtTotalText.StyleController = this.lcMain;
            this.txtTotalText.TabIndex = 126;
            // 
            // chxKhautru
            // 
            this.chxKhautru.Location = new System.Drawing.Point(3, 156);
            this.chxKhautru.Name = "chxKhautru";
            this.chxKhautru.Properties.Caption = "";
            this.chxKhautru.Size = new System.Drawing.Size(60, 19);
            this.chxKhautru.StyleController = this.lcMain;
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "Khi chọn khấu trừ, khi đó chúng ta thu tiền nợ không quan tâm đến chứng từ. ";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.chxKhautru.SuperTip = superToolTip1;
            this.chxKhautru.TabIndex = 125;
            this.chxKhautru.CheckedChanged += new System.EventHandler(this.chxKhautru_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(67, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotal.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotal.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(149, 22);
            this.txtTotal.StyleController = this.lcMain;
            this.txtTotal.TabIndex = 123;
            this.txtTotal.EditValueChanged += new System.EventHandler(this.txtTotal_EditValueChanged);
            this.txtTotal.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTotal_EditValueChanging);
            // 
            // txtDebt
            // 
            this.txtDebt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDebt.Location = new System.Drawing.Point(642, 102);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.Properties.Appearance.Options.UseFont = true;
            this.txtDebt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDebt.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtDebt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDebt.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtDebt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDebt.Properties.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(149, 22);
            this.txtDebt.StyleController = this.lcMain;
            this.txtDebt.TabIndex = 13;
            this.txtDebt.Visible = false;
            // 
            // txtCustomerName
            // 
            this.Err.SetIconAlignment(this.txtCustomerName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtCustomerName.Location = new System.Drawing.Point(65, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.ActionButtonIndex = 2;
            this.txtCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCustomerName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerName.Properties.Appearance.Options.UseForeColor = true;
            this.txtCustomerName.Properties.AutoComplete = false;
            this.txtCustomerName.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            toolTipItem1.Text = "Nếu khách hàng chưa tồn tại, bạn có thể nhấn nút này để thêm khách hàng mới này v" +
                "ào.";
            superToolTip2.Items.Add(toolTipItem1);
            this.txtCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Tìm", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("txtCustomerName.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Search", null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("txtCustomerName.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Tạo mới thông tin khách hàng", "Add", superToolTip2, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "None", null, true)});
            this.txtCustomerName.Properties.DataSource = this.cUSTOMERBindingSource;
            this.txtCustomerName.Properties.DisplayMember = "CustomerName";
            this.txtCustomerName.Properties.NullText = "(Chọn Khách Hàng)";
            this.txtCustomerName.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtCustomerName.Properties.UseParentBackground = true;
            this.txtCustomerName.Properties.ValidateOnEnterKey = true;
            this.txtCustomerName.Properties.ValueMember = "Customer_ID";
            this.txtCustomerName.Properties.View = this.gridLookUpEdit1View;
            this.txtCustomerName.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCustomerName_Properties_ButtonClick);
            this.txtCustomerName.Size = new System.Drawing.Size(310, 22);
            this.txtCustomerName.StyleController = this.lcMain;
            toolTipItem2.Text = "Khi chọn Nhà Phân Phối thì mặc định tất cả mặt hàng của NPP này sẽ được nạp lên.";
            superToolTip3.Items.Add(toolTipItem2);
            this.txtCustomerName.SuperTip = superToolTip3;
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.EditValueChanged += new System.EventHandler(this.txtCustomerName_EditValueChanged);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dsCustomer;
            // 
            // dsCustomer
            // 
            this.dsCustomer.DataSetName = "dsCustomer";
            this.dsCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colCustomerName.Caption = "Nhà phân phối";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 230;
            // 
            // colCustomer_ID
            // 
            this.colCustomer_ID.Caption = "Mã";
            this.colCustomer_ID.FieldName = "Customer_ID";
            this.colCustomer_ID.Name = "colCustomer_ID";
            this.colCustomer_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCustomer_ID.Visible = true;
            this.colCustomer_ID.VisibleIndex = 1;
            this.colCustomer_ID.Width = 80;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(642, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 20);
            this.txtID.StyleController = this.lcMain;
            this.txtID.TabIndex = 6;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(65, 55);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(511, 20);
            this.txtAddress.StyleController = this.lcMain;
            this.txtAddress.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(65, 79);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(128, 20);
            this.txtTax.StyleController = this.lcMain;
            this.txtTax.TabIndex = 3;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.dEBTBindingSource;
            this.gcList.Location = new System.Drawing.Point(243, 178);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpgProduct,
            this.rpgStock,
            this.rpProductName,
            this.rpUnit,
            this.rpDate,
            this.rpVal,
            this.rcVat,
            this.rgCheck});
            this.gcList.Size = new System.Drawing.Size(556, 400);
            this.gcList.TabIndex = 12;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // dEBTBindingSource
            // 
            this.dEBTBindingSource.DataMember = "DEBT";
            this.dEBTBindingSource.DataSource = this.dsDEBT;
            // 
            // dsDEBT
            // 
            this.dsDEBT.DataSetName = "dsDEBT";
            this.dsDEBT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.gbList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colError,
            this.colErrorText,
            this.colRefID,
            this.colRefDate,
            this.colAmount,
            this.colDebt,
            this.colPayment,
            this.colDiscount,
            this.colDiscountPercent,
            this.colCopyDebt,
            this.colIsCheck});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gbList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gbList.IndicatorWidth = 45;
            this.gbList.Name = "gbList";
            this.gbList.NewItemRowText = "(Thêm dòng mới)";
            this.gbList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gbList.OptionsBehavior.FocusLeaveOnTab = true;
            this.gbList.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gbList.OptionsCustomization.AllowFilter = false;
            this.gbList.OptionsCustomization.AllowSort = false;
            this.gbList.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gbList.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gbList.VertScrollTipFieldName = "Product_ID";
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanged);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gbList_KeyDown);
            this.gbList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanging);
            this.gbList.Layout += new System.EventHandler(this.gbList_Layout);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            //this.gbList.LayoutUpgrade += new DevExpress.Utils.LayoutUpgadeEventHandler(this.gbList_LayoutUpgrade);
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.colIsCheck);
            this.gridBand2.Columns.Add(this.colError);
            this.gridBand2.Columns.Add(this.colErrorText);
            this.gridBand2.Columns.Add(this.colRefID);
            this.gridBand2.Columns.Add(this.colRefDate);
            this.gridBand2.Columns.Add(this.colAmount);
            this.gridBand2.Columns.Add(this.colDebt);
            this.gridBand2.Columns.Add(this.colDiscountPercent);
            this.gridBand2.Columns.Add(this.colDiscount);
            this.gridBand2.Columns.Add(this.colPayment);
            this.gridBand2.Columns.Add(this.colCopyDebt);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 782;
            // 
            // colIsCheck
            // 
            this.colIsCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsCheck.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIsCheck.Caption = "Chọn";
            this.colIsCheck.FieldName = "Selected";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.OptionsFilter.AllowFilter = false;
            this.colIsCheck.Visible = true;
            this.colIsCheck.Width = 42;
            // 
            // colError
            // 
            this.colError.AppearanceHeader.Options.UseTextOptions = true;
            this.colError.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colError.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colError.FieldName = "Error";
            this.colError.Name = "colError";
            this.colError.OptionsColumn.ShowInCustomizationForm = false;
            this.colError.OptionsFilter.AllowFilter = false;
            // 
            // colErrorText
            // 
            this.colErrorText.AppearanceHeader.Options.UseTextOptions = true;
            this.colErrorText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colErrorText.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colErrorText.FieldName = "ErrorText";
            this.colErrorText.Name = "colErrorText";
            this.colErrorText.OptionsColumn.ShowInCustomizationForm = false;
            this.colErrorText.OptionsFilter.AllowFilter = false;
            // 
            // colRefID
            // 
            this.colRefID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRefID.Caption = "Chứng Từ";
            this.colRefID.FieldName = "RefID";
            this.colRefID.Name = "colRefID";
            this.colRefID.OptionsColumn.ReadOnly = true;
            this.colRefID.OptionsFilter.AllowFilter = false;
            this.colRefID.Visible = true;
            this.colRefID.Width = 117;
            // 
            // colRefDate
            // 
            this.colRefDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRefDate.Caption = "Ngày";
            this.colRefDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.colRefDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRefDate.FieldName = "RefDate";
            this.colRefDate.Name = "colRefDate";
            this.colRefDate.OptionsColumn.AllowEdit = false;
            this.colRefDate.OptionsColumn.ReadOnly = true;
            this.colRefDate.OptionsFilter.AllowFilter = false;
            this.colRefDate.Visible = true;
            this.colRefDate.Width = 86;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colAmount.Caption = "Tổng Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AllowFilter = false;
            this.colAmount.Visible = true;
            this.colAmount.Width = 130;
            // 
            // colDebt
            // 
            this.colDebt.AppearanceHeader.Options.UseTextOptions = true;
            this.colDebt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDebt.Caption = "Còn Nợ";
            this.colDebt.ColumnEdit = this.rpVal;
            this.colDebt.FieldName = "Balance";
            this.colDebt.Name = "colDebt";
            this.colDebt.OptionsColumn.ReadOnly = true;
            this.colDebt.OptionsFilter.AllowFilter = false;
            this.colDebt.Visible = true;
            this.colDebt.Width = 137;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscountPercent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscountPercent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDiscountPercent.Caption = "CK(%)";
            this.colDiscountPercent.ColumnEdit = this.rpVal;
            this.colDiscountPercent.FieldName = "DiscountRate";
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.OptionsFilter.AllowFilter = false;
            this.colDiscountPercent.Width = 57;
            // 
            // colDiscount
            // 
            this.colDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDiscount.Caption = "Chiết Khấu";
            this.colDiscount.ColumnEdit = this.rpVal;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsFilter.AllowFilter = false;
            this.colDiscount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDiscount.Width = 90;
            // 
            // colPayment
            // 
            this.colPayment.AppearanceHeader.Options.UseTextOptions = true;
            this.colPayment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayment.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colPayment.Caption = "Tiền Trả";
            this.colPayment.ColumnEdit = this.rpVal;
            this.colPayment.FieldName = "Payment";
            this.colPayment.Name = "colPayment";
            this.colPayment.OptionsFilter.AllowFilter = false;
            this.colPayment.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colPayment.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colPayment.Visible = true;
            this.colPayment.Width = 126;
            // 
            // colCopyDebt
            // 
            this.colCopyDebt.Caption = "Còn Lại";
            this.colCopyDebt.ColumnEdit = this.rpVal;
            this.colCopyDebt.FieldName = "colCopyDebt";
            this.colCopyDebt.Name = "colCopyDebt";
            this.colCopyDebt.OptionsFilter.AllowFilter = false;
            this.colCopyDebt.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colCopyDebt.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCopyDebt.UnboundExpression = "[Balance] - ([Payment] + [Discount])";
            this.colCopyDebt.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colCopyDebt.Visible = true;
            this.colCopyDebt.Width = 144;
            // 
            // rpgProduct
            // 
            this.rpgProduct.AutoComplete = false;
            this.rpgProduct.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            serializableAppearanceObject5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.rpgProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons1"))), new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject5, "", null, null, false)});
            this.rpgProduct.DisplayMember = "Product_ID";
            this.rpgProduct.Name = "rpgProduct";
            this.rpgProduct.NullText = "(Chọn)";
            this.rpgProduct.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpgProduct.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgProduct.ValueMember = "Product_ID";
            this.rpgProduct.View = this.rpglkProduct;
            // 
            // rpglkProduct
            // 
            this.rpglkProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.rpglkProduct.Name = "rpglkProduct";
            this.rpglkProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rpglkProduct.OptionsView.ShowAutoFilterRow = true;
            this.rpglkProduct.OptionsView.ShowGroupPanel = false;
            // 
            // rpgStock
            // 
            this.rpgStock.AutoComplete = false;
            this.rpgStock.AutoHeight = false;
            this.rpgStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpgStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpgStock.DisplayMember = "Stock_Name";
            this.rpgStock.Name = "rpgStock";
            this.rpgStock.NullText = "(Chọn)";
            this.rpgStock.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpgStock.ValueMember = "Stock_ID";
            this.rpgStock.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // rpProductName
            // 
            this.rpProductName.AutoComplete = false;
            this.rpProductName.AutoHeight = false;
            this.rpProductName.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpProductName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, false)});
            this.rpProductName.DisplayMember = "Product_Name";
            this.rpProductName.Name = "rpProductName";
            this.rpProductName.NullText = "(Chọn)";
            this.rpProductName.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpProductName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpProductName.ValueMember = "Product_ID";
            this.rpProductName.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // rpUnit
            // 
            this.rpUnit.AutoComplete = false;
            this.rpUnit.AutoHeight = false;
            this.rpUnit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "(Chọn)";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // rcVat
            // 
            this.rcVat.AutoHeight = false;
            this.rcVat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcVat.Items.AddRange(new object[] {
            "Không Thuế",
            "0%",
            "5%",
            "10%",
            "15%",
            ""});
            this.rcVat.Name = "rcVat";
            this.rcVat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // rgCheck
            // 
            this.rgCheck.AutoHeight = false;
            this.rgCheck.Name = "rgCheck";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(252, 79);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(122, 20);
            this.txtTel.StyleController = this.lcMain;
            this.txtTel.TabIndex = 4;
            // 
            // txtExchange
            // 
            this.txtExchange.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExchange.Location = new System.Drawing.Point(695, 77);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExchange.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtExchange.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtExchange.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtExchange.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtExchange.Size = new System.Drawing.Size(96, 20);
            this.txtExchange.StyleController = this.lcMain;
            this.txtExchange.TabIndex = 9;
            this.txtExchange.Visible = false;
            this.txtExchange.EditValueChanged += new System.EventHandler(this.txtExchange_EditValueChanged);
            // 
            // dtCreated
            // 
            this.dtCreated.EditValue = new System.DateTime(2008, 2, 8, 14, 22, 49, 437);
            this.dtCreated.Location = new System.Drawing.Point(642, 53);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCreated.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.dtCreated.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtCreated.Properties.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            this.dtCreated.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtCreated.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.dtCreated.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtCreated.Properties.NullDate = new System.DateTime(2008, 2, 8, 14, 23, 58, 359);
            this.dtCreated.Properties.UseParentBackground = true;
            this.dtCreated.Properties.ValidateOnEnterKey = true;
            this.dtCreated.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtCreated.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtCreated.Size = new System.Drawing.Size(149, 20);
            this.dtCreated.StyleController = this.lcMain;
            this.dtCreated.TabIndex = 7;
            // 
            // cbxCurrency
            // 
            this.cbxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurrency.FormattingEnabled = true;
            this.cbxCurrency.Items.AddRange(new object[] {
            "VND",
            "USD"});
            this.cbxCurrency.Location = new System.Drawing.Point(642, 77);
            this.cbxCurrency.Name = "cbxCurrency";
            this.cbxCurrency.Size = new System.Drawing.Size(49, 21);
            this.cbxCurrency.TabIndex = 8;
            this.cbxCurrency.SelectedValueChanged += new System.EventHandler(this.cbxCurrency_SelectedValueChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.EditValue = "";
            this.txtCustomerID.Location = new System.Drawing.Point(432, 29);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustomerID.Properties.DataSource = this.cUSTOMERBindingSource;
            this.txtCustomerID.Properties.DisplayMember = "Customer_ID";
            this.txtCustomerID.Properties.NullText = "";
            this.txtCustomerID.Properties.ValueMember = "Customer_ID";
            this.txtCustomerID.Properties.View = this.gridView3;
            this.txtCustomerID.Size = new System.Drawing.Size(144, 20);
            this.txtCustomerID.StyleController = this.lcMain;
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.TabStop = false;
            this.txtCustomerID.EditValueChanged += new System.EventHandler(this.txtCustomerID_EditValueChanged);
            this.txtCustomerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerID_KeyDown);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer_ID1,
            this.colCustomerName1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomer_ID1
            // 
            this.colCustomer_ID1.Caption = "Mã";
            this.colCustomer_ID1.FieldName = "Customer_ID";
            this.colCustomer_ID1.Name = "colCustomer_ID1";
            this.colCustomer_ID1.Visible = true;
            this.colCustomer_ID1.VisibleIndex = 0;
            // 
            // colCustomerName1
            // 
            this.colCustomerName1.Caption = "Tên";
            this.colCustomerName1.FieldName = "CustomerName";
            this.colCustomerName1.Name = "colCustomerName1";
            this.colCustomerName1.Visible = true;
            this.colCustomerName1.VisibleIndex = 1;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Root";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcBarcode,
            this.lcList,
            this.lcgMain,
            this.splitterItem2,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(800, 602);
            this.layoutControlGroup2.Text = "Root";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // lcBarcode
            // 
            this.lcBarcode.CustomizationFormText = "lcBarcode";
            this.lcBarcode.Location = new System.Drawing.Point(0, 177);
            this.lcBarcode.Name = "lcBarcode";
            this.lcBarcode.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcBarcode.Size = new System.Drawing.Size(236, 400);
            this.lcBarcode.Text = "lcBarcode";
            this.lcBarcode.TextSize = new System.Drawing.Size(0, 0);
            this.lcBarcode.TextToControlDistance = 0;
            this.lcBarcode.TextVisible = false;
            this.lcBarcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lcList
            // 
            this.lcList.Control = this.gcList;
            this.lcList.CustomizationFormText = "lcList";
            this.lcList.Location = new System.Drawing.Point(242, 177);
            this.lcList.Name = "lcList";
            this.lcList.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcList.Size = new System.Drawing.Size(556, 400);
            this.lcList.Text = "lcList";
            this.lcList.TextSize = new System.Drawing.Size(0, 0);
            this.lcList.TextToControlDistance = 0;
            this.lcList.TextVisible = false;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Thông Tin Phiếu Chi Tiền";
            this.lcgMain.ExpandButtonVisible = true;
            this.lcgMain.ExpandOnDoubleClick = true;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup3,
            this.splitterItem3});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(798, 135);
            this.lcgMain.Text = "Thông Tin Khách Hàng";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcCustomerName,
            this.lcAddress,
            this.lcTax,
            this.lcDescription,
            this.lcEmail,
            this.lcTel,
            this.lcCustomerID});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(577, 109);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcCustomerName
            // 
            this.lcCustomerName.Control = this.txtCustomerName;
            this.lcCustomerName.CustomizationFormText = "NPP";
            this.lcCustomerName.Location = new System.Drawing.Point(0, 0);
            this.lcCustomerName.Name = "lcCustomerName";
            this.lcCustomerName.OptionsToolTip.ToolTip = "Nhà Phân Phối";
            this.lcCustomerName.Size = new System.Drawing.Size(370, 26);
            this.lcCustomerName.Text = "Tên";
            this.lcCustomerName.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcCustomerName.TextSize = new System.Drawing.Size(51, 13);
            this.lcCustomerName.TextToControlDistance = 5;
            // 
            // lcAddress
            // 
            this.lcAddress.Control = this.txtAddress;
            this.lcAddress.CustomizationFormText = "Địa Chỉ";
            this.lcAddress.Location = new System.Drawing.Point(0, 26);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(571, 24);
            this.lcAddress.Text = "Địa Chỉ";
            this.lcAddress.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcAddress.TextSize = new System.Drawing.Size(51, 13);
            this.lcAddress.TextToControlDistance = 5;
            // 
            // lcTax
            // 
            this.lcTax.Control = this.txtTax;
            this.lcTax.CustomizationFormText = "MST";
            this.lcTax.Location = new System.Drawing.Point(0, 50);
            this.lcTax.Name = "lcTax";
            this.lcTax.Size = new System.Drawing.Size(188, 24);
            this.lcTax.Text = "MST";
            this.lcTax.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcTax.TextSize = new System.Drawing.Size(51, 13);
            this.lcTax.TextToControlDistance = 5;
            // 
            // lcDescription
            // 
            this.lcDescription.Control = this.txtDescription;
            this.lcDescription.CustomizationFormText = "Ghi Chú";
            this.lcDescription.Location = new System.Drawing.Point(0, 74);
            this.lcDescription.Name = "lcDescription";
            this.lcDescription.Size = new System.Drawing.Size(571, 29);
            this.lcDescription.Text = "Ghi Chú";
            this.lcDescription.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcDescription.TextSize = new System.Drawing.Size(51, 25);
            this.lcDescription.TextToControlDistance = 5;
            this.lcDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lcEmail
            // 
            this.lcEmail.Control = this.txtEmail;
            this.lcEmail.CustomizationFormText = "Email";
            this.lcEmail.Location = new System.Drawing.Point(369, 50);
            this.lcEmail.Name = "lcEmail";
            this.lcEmail.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.lcEmail.Size = new System.Drawing.Size(202, 24);
            this.lcEmail.Text = "Email";
            this.lcEmail.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcEmail.TextSize = new System.Drawing.Size(40, 13);
            this.lcEmail.TextToControlDistance = 5;
            // 
            // lcTel
            // 
            this.lcTel.Control = this.txtTel;
            this.lcTel.CustomizationFormText = "Điện Thoại";
            this.lcTel.Location = new System.Drawing.Point(188, 50);
            this.lcTel.Name = "lcTel";
            this.lcTel.Size = new System.Drawing.Size(181, 24);
            this.lcTel.Text = "Điện Thoại";
            this.lcTel.TextSize = new System.Drawing.Size(51, 13);
            // 
            // lcCustomerID
            // 
            this.lcCustomerID.Control = this.txtCustomerID;
            this.lcCustomerID.CustomizationFormText = "Mã";
            this.lcCustomerID.Location = new System.Drawing.Point(370, 0);
            this.lcCustomerID.Name = "lcCustomerID";
            this.lcCustomerID.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.lcCustomerID.Size = new System.Drawing.Size(201, 26);
            this.lcCustomerID.Text = "Mã KH";
            this.lcCustomerID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcCustomerID.TextSize = new System.Drawing.Size(40, 13);
            this.lcCustomerID.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcID,
            this.lcCreated,
            this.lcCurrency,
            this.lcExchange,
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(583, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.ShowInCustomizationForm = false;
            this.layoutControlGroup3.ShowTabPageCloseButton = true;
            this.layoutControlGroup3.Size = new System.Drawing.Size(209, 109);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lcID
            // 
            this.lcID.Control = this.txtID;
            this.lcID.CustomizationFormText = "Phiếu";
            this.lcID.Location = new System.Drawing.Point(0, 0);
            this.lcID.MaxSize = new System.Drawing.Size(203, 24);
            this.lcID.MinSize = new System.Drawing.Size(203, 24);
            this.lcID.Name = "lcID";
            this.lcID.Size = new System.Drawing.Size(203, 24);
            this.lcID.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcID.Text = "Phiếu";
            this.lcID.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcID.TextSize = new System.Drawing.Size(45, 20);
            this.lcID.TextToControlDistance = 5;
            // 
            // lcCreated
            // 
            this.lcCreated.Control = this.dtCreated;
            this.lcCreated.CustomizationFormText = "Ngày";
            this.lcCreated.Location = new System.Drawing.Point(0, 24);
            this.lcCreated.MaxSize = new System.Drawing.Size(203, 24);
            this.lcCreated.MinSize = new System.Drawing.Size(203, 24);
            this.lcCreated.Name = "lcCreated";
            this.lcCreated.Size = new System.Drawing.Size(203, 24);
            this.lcCreated.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcCreated.Text = "Ngày";
            this.lcCreated.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcCreated.TextSize = new System.Drawing.Size(45, 20);
            this.lcCreated.TextToControlDistance = 5;
            // 
            // lcCurrency
            // 
            this.lcCurrency.Control = this.cbxCurrency;
            this.lcCurrency.CustomizationFormText = "Loại Tiền";
            this.lcCurrency.Location = new System.Drawing.Point(0, 48);
            this.lcCurrency.Name = "lcCurrency";
            this.lcCurrency.Size = new System.Drawing.Size(103, 25);
            this.lcCurrency.Text = "Loại Tiền";
            this.lcCurrency.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcCurrency.TextSize = new System.Drawing.Size(45, 20);
            this.lcCurrency.TextToControlDistance = 5;
            this.lcCurrency.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lcExchange
            // 
            this.lcExchange.Control = this.txtExchange;
            this.lcExchange.CustomizationFormText = "lcExchange";
            this.lcExchange.Location = new System.Drawing.Point(103, 48);
            this.lcExchange.Name = "lcExchange";
            this.lcExchange.Size = new System.Drawing.Size(100, 25);
            this.lcExchange.Text = "lcExchange";
            this.lcExchange.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lcExchange.TextSize = new System.Drawing.Size(0, 0);
            this.lcExchange.TextToControlDistance = 0;
            this.lcExchange.TextVisible = false;
            this.lcExchange.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDebt;
            this.layoutControlItem1.CustomizationFormText = "Dư Nợ";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(203, 30);
            this.layoutControlItem1.Text = "Dư Nợ";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.CustomizationFormText = "splitterItem3";
            this.splitterItem3.Location = new System.Drawing.Point(577, 0);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(6, 109);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(236, 177);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(6, 400);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.txtTotal;
            this.layoutControlItem2.CustomizationFormText = "Số Tiền";
            this.layoutControlItem2.Location = new System.Drawing.Point(64, 135);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(153, 42);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(153, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(153, 42);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Số Tiền";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem4.Control = this.txtTotalText;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(386, 135);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(412, 42);
            this.layoutControlItem4.Text = "Tiền Bằng Chữ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 18);
            this.layoutControlItem4.TextToControlDistance = 0;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chxIsPrint;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 577);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(798, 23);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem6.Control = this.txtDiscountRate;
            this.layoutControlItem6.CustomizationFormText = "CK(%)";
            this.layoutControlItem6.Location = new System.Drawing.Point(217, 135);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(54, 42);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(54, 42);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(54, 42);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "CK(%)";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            this.layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem7.Control = this.txtDiscount;
            this.layoutControlItem7.CustomizationFormText = "Chiết Khấu";
            this.layoutControlItem7.Location = new System.Drawing.Point(271, 135);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(115, 42);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "Chiết Khấu";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            this.layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.chxKhautru;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 135);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(64, 42);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(64, 42);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Khấu Trừ";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(20, 18);
            this.layoutControlItem3.TextToControlDistance = 0;
            // 
            // colRefType
            // 
            this.colRefType.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRefType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colRefType.Caption = "Loại Chứng Từ";
            this.colRefType.FieldName = "RefType";
            this.colRefType.Name = "colRefType";
            this.colRefType.OptionsColumn.AllowEdit = false;
            this.colRefType.OptionsColumn.ReadOnly = true;
            this.colRefType.OptionsFilter.AllowFilter = false;
            this.colRefType.Visible = true;
            this.colRefType.Width = 150;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // dEBTTableAdapter
            // 
            this.dEBTTableAdapter.ClearBeforeFill = true;
            // 
            // xucReiceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lcMain);
            this.Name = "xucReiceipt";
            this.NotSave = true;
            this.Size = new System.Drawing.Size(800, 633);
            this.Load += new System.EventHandler(this.xucInwards_Load);
            this.Controls.SetChildIndex(this.plBottom, 0);
            this.Controls.SetChildIndex(this.lcMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxIsPrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxKhautru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEBTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDEBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCreated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit txtCustomerName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtTax;
        private DevExpress.XtraEditors.CalcEdit txtExchange;
        private System.Windows.Forms.ComboBox cbxCurrency;
        private DevExpress.XtraEditors.DateEdit dtCreated;
        private DevExpress.XtraEditors.TextEdit txtID;
        protected DevExpress.XtraGrid.GridControl gcList;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView rpglkProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgStock;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rpDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private XucBaseBarcode ucBarcode;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lcCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem lcCustomerID;
        private DevExpress.XtraLayout.LayoutControlItem lcAddress;
        private DevExpress.XtraLayout.LayoutControlItem lcTax;
        private DevExpress.XtraLayout.LayoutControlItem lcTel;
        private DevExpress.XtraLayout.LayoutControlItem lcDescription;
        private DevExpress.XtraLayout.LayoutControlItem lcID;
        private DevExpress.XtraLayout.LayoutControlItem lcCreated;
        private DevExpress.XtraLayout.LayoutControlItem lcCurrency;
        private DevExpress.XtraLayout.LayoutControlItem lcExchange;
        private DevExpress.XtraLayout.LayoutControlItem lcBarcode;
        private DevExpress.XtraLayout.LayoutControlItem lcList;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcVat;
        private DevExpress.XtraEditors.CalcEdit txtDebt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.CalcEdit txtTotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckEdit chxKhautru;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtTotalText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colError;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colErrorText;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDebt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPayment;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiscountPercent;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiscount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCopyDebt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIsCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rgCheck;
        private DevExpress.XtraEditors.GridLookUpEdit txtCustomerID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.CheckEdit chxIsPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.CalcEdit txtDiscountRate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.CalcEdit txtDiscount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRefType;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private Perfect.Sale.Core.Common.DS.dsCustomer dsCustomer;
        private Perfect.Sale.Core.Common.DS.dsCustomerTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource dEBTBindingSource;
        private Perfect.Sale.Core.REICEIPT.DS.dsDEBT dsDEBT;
        private Perfect.Sale.Core.REICEIPT.DS.dsDEBTTableAdapters.DEBTTableAdapter dEBTTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem lcEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName1;
    }
}
