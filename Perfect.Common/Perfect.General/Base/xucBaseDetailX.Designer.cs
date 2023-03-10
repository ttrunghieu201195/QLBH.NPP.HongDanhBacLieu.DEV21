
using Perfect.Common.DS;

namespace Perfect.Common
{
    partial class xucBaseDetailX
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucBaseDetailX));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.rpSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.rpgProduct = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPRODUCT = new Perfect.Common.DS.dsPRODUCT();
            this.rpglkProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpNumPercent = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.rpVat = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rpgStock = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK = new Perfect.Common.DS.dsSTOCK();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpProductName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUNIT = new Perfect.Common.DS.dsUNIT();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.uNITTableAdapter = new Perfect.Common.DS.dsUNITTableAdapters.UNITTableAdapter();
            this.pRODUCTTableAdapter = new Perfect.Common.DS.dsPRODUCTTableAdapters.PRODUCTTableAdapter();
            this.sTOCKTableAdapter = new Perfect.Common.DS.dsSTOCKTableAdapters.STOCKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rpSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpNumPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUNIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // rpVal
            // 
            this.rpSpin.AutoHeight = false;
            this.rpSpin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rpSpin.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpSpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpSpin.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpSpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpSpin.Name = "rpVal";
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpgProduct,
            this.rpNumPercent,
            this.rpVat,
            this.rpgStock,
            this.rpSpin,
            this.rpProductName,
            this.rpUnit});
            this.gcList.Size = new System.Drawing.Size(703, 316);
            this.gcList.TabIndex = 39;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // gbList
            // 
            this.gbList.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gbList.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gbList.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gbList.Name = "gbList";
            this.gbList.NewItemRowText = "(Thêm dòng mới)";
            this.gbList.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gbList.OptionsCustomization.AllowFilter = false;
            this.gbList.OptionsCustomization.AllowSort = false;
            this.gbList.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gbList.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.AllowHtmlDrawHeaders = true;
            this.gbList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gbList.OptionsView.EnableAppearanceEvenRow = true;
            this.gbList.OptionsView.EnableAppearanceOddRow = true;
            this.gbList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 200;
            // 
            // rpgProduct
            // 
            this.rpgProduct.AutoComplete = false;
            this.rpgProduct.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            serializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.rpgProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons"))), null),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpgProduct.Buttons1"))), new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)), serializableAppearanceObject1)});
            this.rpgProduct.DataSource = this.pRODUCTBindingSource;
            this.rpgProduct.DisplayMember = "Product_ID";
            this.rpgProduct.Name = "rpgProduct";
            this.rpgProduct.NullText = "(Chọn)";
            this.rpgProduct.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpgProduct.ValueMember = "Product_ID";
            this.rpgProduct.View = this.rpglkProduct;
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
            // rpglkProduct
            // 
            this.rpglkProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.rpglkProduct.Name = "rpglkProduct";
            this.rpglkProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rpglkProduct.OptionsView.ShowAutoFilterRow = true;
            this.rpglkProduct.OptionsView.ShowGroupPanel = false;
            // 
            // rpNumPercent
            // 
            this.rpNumPercent.AutoHeight = false;
            this.rpNumPercent.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpNumPercent.DisplayFormat.FormatString = "{0:##,##0.###} %";
            this.rpNumPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpNumPercent.EditFormat.FormatString = "{0:##,##0.###} %";
            this.rpNumPercent.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpNumPercent.Name = "rpNumPercent";
            // 
            // rpVat
            // 
            this.rpVat.AutoHeight = false;
            this.rpVat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpVat.Items.AddRange(new object[] {
            "Không thuế",
            "0%",
            "5%",
            "10%"});
            this.rpVat.Name = "rpVat";
            this.rpVat.NullText = "Không thuế";
            this.rpVat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // rpgStock
            // 
            this.rpgStock.AutoComplete = false;
            this.rpgStock.AutoHeight = false;
            this.rpgStock.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rpgStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpgStock.DataSource = this.sTOCKBindingSource;
            this.rpgStock.DisplayMember = "Stock_Name";
            this.rpgStock.Name = "rpgStock";
            this.rpgStock.NullText = "(Chọn)";
            this.rpgStock.ValueMember = "Stock_ID";
            this.rpgStock.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.dsSTOCK;
            // 
            // dsSTOCK
            // 
            this.dsSTOCK.DataSetName = "dsSTOCK";
            this.dsSTOCK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons")))),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpProductName.Buttons1"))))});
            this.rpProductName.DataSource = this.pRODUCTBindingSource;
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
            this.rpUnit.DataSource = this.uNITBindingSource;
            this.rpUnit.DisplayMember = "Unit_Name";
            this.rpUnit.Name = "rpUnit";
            this.rpUnit.NullText = "(Chọn)";
            this.rpUnit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rpUnit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rpUnit.ValueMember = "Unit_ID";
            this.rpUnit.View = this.gridView2;
            // 
            // uNITBindingSource
            // 
            this.uNITBindingSource.DataMember = "UNIT";
            this.uNITBindingSource.DataSource = this.dsUNIT;
            // 
            // dsUNIT
            // 
            this.dsUNIT.DataSetName = "dsUNIT";
            this.dsUNIT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // uNITTableAdapter
            // 
            this.uNITTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // xucBaseDetailX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcList);
            this.Name = "xucBaseDetailX";
            this.Size = new System.Drawing.Size(703, 316);
            ((System.ComponentModel.ISupportInitialize)(this.rpSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPRODUCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpglkProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpNumPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpgStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUNIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.Grid.GridView rpglkProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        public DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        public DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgProduct;
        public DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpProductName;
        public DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpUnit;
        public DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rpgStock;
        public DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rpSpin;
        public DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpNumPercent;
        public DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpVat;
        private System.Windows.Forms.BindingSource uNITBindingSource;
        private dsUNIT dsUNIT;
        private Perfect.Common.DS.dsUNITTableAdapters.UNITTableAdapter uNITTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private dsPRODUCT dsPRODUCT;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private dsSTOCK dsSTOCK;
        private Perfect.Common.DS.dsPRODUCTTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private Perfect.Common.DS.dsSTOCKTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        public DevExpress.XtraGrid.GridControl gcList;
    }
}
