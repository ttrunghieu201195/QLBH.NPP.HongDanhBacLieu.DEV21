namespace Perfect.Common.Report
{
    partial class xucBaseReportControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucBaseReportControls));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.plButton = new DevExpress.XtraEditors.PanelControl();
            this.plReportControl = new DevExpress.XtraEditors.PanelControl();
            this.printControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.plTop = new DevExpress.XtraEditors.PanelControl();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPreviewForm = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDesign = new DevExpress.XtraBars.BarButtonItem();
            this.ac = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plReportControl)).BeginInit();
            this.plReportControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // plButton
            // 
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 508);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(925, 28);
            this.plButton.TabIndex = 80;
            this.plButton.Visible = false;
            // 
            // plReportControl
            // 
            this.plReportControl.Controls.Add(this.printControl);
            this.plReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plReportControl.Location = new System.Drawing.Point(0, 60);
            this.plReportControl.Name = "plReportControl";
            this.plReportControl.Size = new System.Drawing.Size(925, 448);
            this.plReportControl.TabIndex = 81;
            // 
            // printControl
            // 
            this.printControl.BackColor = System.Drawing.Color.Empty;
            this.printControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl.ForeColor = System.Drawing.Color.Empty;
            this.printControl.IsMetric = false;
            this.printControl.Location = new System.Drawing.Point(2, 2);
            this.printControl.Name = "printControl";
            this.printControl.PageBorderVisibility = DevExpress.XtraPrinting.Control.PageBorderVisibility.AllWithoutSelection;
            this.printControl.PrintingSystem = this.printingSystem;
            this.printControl.Size = new System.Drawing.Size(921, 444);
            this.printControl.TabIndex = 2;
            this.printControl.TabStop = false;
            this.printControl.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 24);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(925, 36);
            this.plTop.TabIndex = 79;
            this.plTop.Visible = false;
            // 
            // bm
            // 
            this.bm.AutoSaveInRegistry = true;
            this.bm.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.imageCollection2;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPreviewForm,
            this.bbiDesign});
            this.bm.LargeImages = this.imageCollection2;
            this.bm.MaxItemId = 2;
            this.bm.RegistryPath = "HKEY_CURRENT_USER\\Software\\Perfect Software\\Perfect Stock Management";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 2";
            this.bar1.Visible = false;
            // 
            // btnPreviewForm
            // 
            this.btnPreviewForm.Caption = "Tách Ra";
            this.btnPreviewForm.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPreviewForm.Glyph")));
            this.btnPreviewForm.Id = 0;
            this.btnPreviewForm.Name = "btnPreviewForm";
            toolTipItem1.Text = "Chức năng này giúp bạn tách báo cáo đang xem ra một cửa sổ khác.";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnPreviewForm.SuperTip = superToolTip1;
            this.btnPreviewForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreviewForm_ItemClick);
            // 
            // bbiDesign
            // 
            this.bbiDesign.Caption = "Thiết Kế";
            this.bbiDesign.Id = 1;
            this.bbiDesign.ImageIndex = 5;
            this.bbiDesign.Name = "bbiDesign";
            toolTipTitleItem1.Text = "Thiết Kế";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Đây là chức năng giúp chúng ta tự thiết kế lại trang báo cáo hiện tại, bạn có thể" +
                " lưu lại và bạn có thể sử dụng báo cáo cho công việc sau này. ";
            superToolTip2.Items.Add(toolTipTitleItem1);
            superToolTip2.Items.Add(toolTipItem2);
            this.bbiDesign.SuperTip = superToolTip2;
            this.bbiDesign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDesign_ItemClick);
            // 
            // ac
            // 
            this.ac.AllowHtmlText = true;
            this.ac.AppearanceText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.AppearanceText.Options.UseFont = true;
            this.ac.AutoFormDelay = 5000;
            this.ac.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopLeft;
            // 
            // xucBaseReportControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plReportControl);
            this.Controls.Add(this.plButton);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xucBaseReportControls";
            this.Size = new System.Drawing.Size(925, 536);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plReportControl)).EndInit();
            this.plReportControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.PanelControl plButton;
        private DevExpress.XtraEditors.PanelControl plReportControl;
        protected DevExpress.XtraPrinting.Control.PrintControl printControl;
        protected DevExpress.XtraPrinting.PrintingSystem printingSystem;
        private DevExpress.XtraEditors.PanelControl plTop;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPreviewForm;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiDesign;
        protected DevExpress.XtraBars.Alerter.AlertControl ac;
    }
}
