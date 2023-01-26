using Perfect.Inventory.Core.Inventory.Adjustment02; 
using Perfect.Inventory.Core.Inventory.Adjustment02.DS;
using Perfect.Inventory.Core.Inventory.Adjustment02.DS.dsAdjustmentManaTableAdapters;
namespace Perfect.Inventory.Core.Inventory.Adjustment
{
    partial class XfmAdjustmentDetails
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
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.adjustmentGetByBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjustmentMana1 = new dsAdjustmentMana();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStock_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAdjustment_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCurrentQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colNewQty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQtyDiff = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAmount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSorted = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.adjustmentGetByTableAdapter1 = new AdjustmentGetByTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentGetByBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustmentMana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.DataSource = this.adjustmentGetByBindingSource1;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpVal});
            this.gcList.Size = new System.Drawing.Size(893, 503);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // adjustmentGetByBindingSource1
            // 
            this.adjustmentGetByBindingSource1.DataMember = "AdjustmentGetBy";
            this.adjustmentGetByBindingSource1.DataSource = this.dsAdjustmentMana1;
            // 
            // dsAdjustmentMana1
            // 
            this.dsAdjustmentMana1.DataSetName = "dsAdjustmentMana";
            this.dsAdjustmentMana1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colAdjustment_ID,
            this.colProduct_ID,
            this.colUnit,
            this.colCurrentQty,
            this.colNewQty,
            this.colQtyDiff,
            this.colUnitPrice,
            this.colAmount,
            this.colProduct_Name,
            this.colStock_Name,
            this.colSorted});
            this.gbList.GridControl = this.gcList;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.ReadOnly = true;
            this.gbList.OptionsCustomization.AllowBandMoving = false;
            this.gbList.OptionsCustomization.AllowBandResizing = false;
            this.gbList.OptionsCustomization.AllowColumnMoving = false;
            this.gbList.OptionsCustomization.AllowColumnResizing = false;
            this.gbList.OptionsCustomization.AllowGroup = false;
            this.gbList.OptionsCustomization.AllowQuickHideColumns = false;
            this.gbList.OptionsCustomization.AllowRowSizing = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSorted, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colStock_Name);
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colAdjustment_ID);
            this.gridBand1.Columns.Add(this.colProduct_ID);
            this.gridBand1.Columns.Add(this.colProduct_Name);
            this.gridBand1.Columns.Add(this.colUnit);
            this.gridBand1.Columns.Add(this.colCurrentQty);
            this.gridBand1.Columns.Add(this.colNewQty);
            this.gridBand1.Columns.Add(this.colQtyDiff);
            this.gridBand1.Columns.Add(this.colUnitPrice);
            this.gridBand1.Columns.Add(this.colAmount);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 1072;
            // 
            // colStock_Name
            // 
            this.colStock_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colStock_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStock_Name.Caption = "Kho Hàng";
            this.colStock_Name.FieldName = "Stock_Name";
            this.colStock_Name.Name = "colStock_Name";
            this.colStock_Name.OptionsColumn.ReadOnly = true;
            this.colStock_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colStock_Name.Visible = true;
            this.colStock_Name.Width = 118;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colAdjustment_ID
            // 
            this.colAdjustment_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdjustment_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdjustment_ID.FieldName = "Adjustment_ID";
            this.colAdjustment_ID.Name = "colAdjustment_ID";
            this.colAdjustment_ID.OptionsColumn.ReadOnly = true;
            this.colAdjustment_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colProduct_ID
            // 
            this.colProduct_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_ID.Caption = "Mã Hàng";
            this.colProduct_ID.FieldName = "Product_ID";
            this.colProduct_ID.Name = "colProduct_ID";
            this.colProduct_ID.OptionsColumn.ReadOnly = true;
            this.colProduct_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_ID.Visible = true;
            this.colProduct_ID.Width = 116;
            // 
            // colProduct_Name
            // 
            this.colProduct_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colProduct_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProduct_Name.Caption = "Tên Hàng";
            this.colProduct_Name.FieldName = "Product_Name";
            this.colProduct_Name.Name = "colProduct_Name";
            this.colProduct_Name.OptionsColumn.ReadOnly = true;
            this.colProduct_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProduct_Name.Visible = true;
            this.colProduct_Name.Width = 301;
            // 
            // colUnit
            // 
            this.colUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnit.Caption = "Đơn Vị";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.ReadOnly = true;
            this.colUnit.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnit.Visible = true;
            // 
            // colCurrentQty
            // 
            this.colCurrentQty.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colCurrentQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCurrentQty.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colCurrentQty.AppearanceCell.Options.UseBackColor = true;
            this.colCurrentQty.AppearanceCell.Options.UseFont = true;
            this.colCurrentQty.AppearanceCell.Options.UseForeColor = true;
            this.colCurrentQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrentQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrentQty.Caption = "SL Hiện Tại";
            this.colCurrentQty.ColumnEdit = this.rpVal;
            this.colCurrentQty.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colCurrentQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCurrentQty.FieldName = "CurrentQty";
            this.colCurrentQty.Name = "colCurrentQty";
            this.colCurrentQty.OptionsColumn.ReadOnly = true;
            this.colCurrentQty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCurrentQty.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colCurrentQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCurrentQty.Visible = true;
            this.colCurrentQty.Width = 82;
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
            // 
            // colNewQty
            // 
            this.colNewQty.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colNewQty.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colNewQty.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colNewQty.AppearanceCell.Options.UseBackColor = true;
            this.colNewQty.AppearanceCell.Options.UseFont = true;
            this.colNewQty.AppearanceCell.Options.UseForeColor = true;
            this.colNewQty.AppearanceHeader.Options.UseTextOptions = true;
            this.colNewQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewQty.Caption = "SL Kiểm Kê";
            this.colNewQty.ColumnEdit = this.rpVal;
            this.colNewQty.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colNewQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNewQty.FieldName = "NewQty";
            this.colNewQty.Name = "colNewQty";
            this.colNewQty.OptionsColumn.ReadOnly = true;
            this.colNewQty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNewQty.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colNewQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNewQty.Visible = true;
            this.colNewQty.Width = 80;
            // 
            // colQtyDiff
            // 
            this.colQtyDiff.AppearanceCell.BackColor = System.Drawing.SystemColors.Info;
            this.colQtyDiff.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQtyDiff.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colQtyDiff.AppearanceCell.Options.UseBackColor = true;
            this.colQtyDiff.AppearanceCell.Options.UseFont = true;
            this.colQtyDiff.AppearanceCell.Options.UseForeColor = true;
            this.colQtyDiff.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyDiff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyDiff.Caption = "Chênh Lệch";
            this.colQtyDiff.ColumnEdit = this.rpVal;
            this.colQtyDiff.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colQtyDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colQtyDiff.FieldName = "QtyDiff";
            this.colQtyDiff.Name = "colQtyDiff";
            this.colQtyDiff.OptionsColumn.ReadOnly = true;
            this.colQtyDiff.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colQtyDiff.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colQtyDiff.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQtyDiff.Visible = true;
            this.colQtyDiff.Width = 91;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "Đơn Giá";
            this.colUnitPrice.ColumnEdit = this.rpVal;
            this.colUnitPrice.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.OptionsColumn.ReadOnly = true;
            this.colUnitPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.Width = 89;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount.Caption = "Thành Tiền";
            this.colAmount.ColumnEdit = this.rpVal;
            this.colAmount.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colAmount.SummaryItem.DisplayFormat = "{0:##,##0.###}";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.Width = 120;
            // 
            // colSorted
            // 
            this.colSorted.AppearanceHeader.Options.UseTextOptions = true;
            this.colSorted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSorted.FieldName = "Sorted";
            this.colSorted.Name = "colSorted";
            this.colSorted.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSorted.OptionsColumn.ReadOnly = true;
            this.colSorted.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExportExcel);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(897, 533);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(2, 509);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(76, 22);
            this.btnExportExcel.StyleController = this.layoutControl1;
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(897, 533);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(897, 507);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExportExcel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 507);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(897, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // adjustmentGetByTableAdapter1
            // 
            this.adjustmentGetByTableAdapter1.ClearBeforeFill = true;
            // 
            // XfmAdjustmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 533);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "XfmAdjustmentDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết";
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentGetByBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustmentMana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private dsAdjustmentMana dsAdjustmentMana;
        private AdjustmentGetByTableAdapter adjustmentGetByTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAdjustment_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrentQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewQty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQtyDiff;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAmount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStock_Name;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpVal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSorted;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource adjustmentGetByBindingSource1;
        private  dsAdjustmentMana dsAdjustmentMana1;
        private  AdjustmentGetByTableAdapter adjustmentGetByTableAdapter1;
    }
}