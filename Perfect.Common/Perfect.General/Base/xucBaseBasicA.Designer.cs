namespace Perfect.Common
{
    partial class xucBaseBasicA
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
            this.ucToolBar = new Perfect.Common.xucToolBar();
            this.tList = new DevExpress.XtraTreeList.TreeList();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucToolBar
            // 
            this.ucToolBar.ButtonAdd = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonCancel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonChange = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonDelete = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonEdit = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonExport = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonOption = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonPrint = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonSave = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonSaveNew = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucToolBar.IsClose = Perfect.Common.CloseOrNew.None;
            this.ucToolBar.Location = new System.Drawing.Point(0, 0);
            this.ucToolBar.Name = "ucToolBar";
            this.ucToolBar.Size = new System.Drawing.Size(761, 43);
            this.ucToolBar.Status = Perfect.Common.Actions.Add;
            this.ucToolBar.TabIndex = 0;
            this.ucToolBar.Title = "";
            // 
            // tList
            // 
            this.tList.Dock = System.Windows.Forms.DockStyle.Left;
            this.tList.Location = new System.Drawing.Point(0, 43);
            this.tList.Name = "tList";
            this.tList.Size = new System.Drawing.Size(270, 454);
            this.tList.TabIndex = 11;
            // 
            // gbList
            // 
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gbList.IndicatorWidth = 45;
            this.gbList.Name = "gbList";
            this.gbList.OptionsPrint.ExpandAllDetails = true;
            this.gbList.OptionsPrint.PrintDetails = true;
            this.gbList.OptionsPrint.PrintFilterInfo = true;
            this.gbList.OptionsPrint.PrintPreview = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = true;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowBands = false;
            this.gbList.OptionsView.ShowDetailButtons = false;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gbList_KeyDown);
            this.gbList.Click += new System.EventHandler(this.gbList_Click);
            this.gbList.Layout += new System.EventHandler(this.gbList_Layout);
            this.gbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gbList_MouseDown);
            this.gbList.DoubleClick += new System.EventHandler(this.gbList_DoubleClick);
            this.gbList.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gbList_RowCellClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "DANH MỤC";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.ShowCaption = false;
            this.gridBand1.ToolTip = "DANH MỤC";
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.LookAndFeel.SkinName = "Office 2007 Black";
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(487, 450);
            this.gcList.TabIndex = 10;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(270, 43);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(491, 454);
            this.panelControl1.TabIndex = 12;
            // 
            // xucBaseBasicA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tList);
            this.Controls.Add(this.ucToolBar);
            this.DoubleBuffered = true;
            this.Name = "xucBaseBasicA";
            this.Size = new System.Drawing.Size(761, 497);
            ((System.ComponentModel.ISupportInitialize)(this.tList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected xucToolBar ucToolBar;
        protected DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gbList;
        protected DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        protected DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        protected DevExpress.XtraTreeList.TreeList tList;
    }
}
