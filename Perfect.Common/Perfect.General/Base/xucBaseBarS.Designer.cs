namespace Perfect.Common
{
    partial class xucBaseBarS
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public xucToolBarL Bar
        {
            get { return ucBar; }
            set { ucBar = value; }
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucBaseBarS));
            this.dtTo = new DevExpress.XtraEditors.DateEdit();
            this.bbiListType = new DevExpress.XtraEditors.CheckButton();
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.dtFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.bbiMerrial = new DevExpress.XtraEditors.CheckButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.ucBar = new Perfect.Common.xucToolBarL();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtTo
            // 
            this.dtTo.EditValue = new System.DateTime(2009, 7, 25, 22, 57, 46, 531);
            this.dtTo.Location = new System.Drawing.Point(148, 3);
            this.dtTo.Name = "dtTo";
            this.dtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.dtTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtTo.Properties.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            this.dtTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtTo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtTo.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.dtTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtTo.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtTo.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.False;
            this.dtTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtTo.Size = new System.Drawing.Size(86, 20);
            this.dtTo.TabIndex = 237;
            this.dtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFrom_KeyDown);
            // 
            // bbiListType
            // 
            this.bbiListType.Dock = System.Windows.Forms.DockStyle.Left;
            this.bbiListType.ImageIndex = 0;
            this.bbiListType.ImageList = this.img;
            this.bbiListType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bbiListType.Location = new System.Drawing.Point(0, 0);
            this.bbiListType.Name = "bbiListType";
            this.bbiListType.Size = new System.Drawing.Size(84, 26);
            this.bbiListType.TabIndex = 239;
            this.bbiListType.Text = "Chi Tiết";
            this.bbiListType.CheckedChanged += new System.EventHandler(this.bbiListType_CheckedChanged);
            this.bbiListType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFrom_KeyDown);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "RibbonPrintPreview_DocumentMapLarge.png");
            this.img.Images.SetKeyName(1, "101.ico");
            // 
            // dtFrom
            // 
            this.dtFrom.EditValue = new System.DateTime(2009, 7, 25, 22, 57, 46, 531);
            this.dtFrom.Location = new System.Drawing.Point(27, 3);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.dtFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtFrom.Properties.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            this.dtFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtFrom.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dtFrom.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.dtFrom.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtFrom.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtFrom.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.False;
            this.dtFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFrom.Size = new System.Drawing.Size(87, 20);
            this.dtFrom.TabIndex = 236;
            this.dtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFrom_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 240;
            this.labelControl1.Text = "Từ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(120, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 241;
            this.labelControl2.Text = "Đến";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.dtTo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dtFrom);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(237, 26);
            this.panelControl1.TabIndex = 243;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(422, 26);
            this.panelControl2.TabIndex = 244;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.bbiMerrial);
            this.panelControl3.Controls.Add(this.bbiListType);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(237, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(185, 26);
            this.panelControl3.TabIndex = 244;
            // 
            // bbiMerrial
            // 
            this.bbiMerrial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbiMerrial.ImageIndex = 1;
            this.bbiMerrial.ImageList = this.img;
            this.bbiMerrial.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.bbiMerrial.Location = new System.Drawing.Point(84, 0);
            this.bbiMerrial.Name = "bbiMerrial";
            this.bbiMerrial.Size = new System.Drawing.Size(101, 26);
            this.bbiMerrial.TabIndex = 240;
            this.bbiMerrial.Text = "Thành Phẩm";
            this.bbiMerrial.CheckedChanged += new System.EventHandler(this.chxMerrial_CheckedChanged);
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.ucBar);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(422, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(212, 26);
            this.panelControl4.TabIndex = 245;
            // 
            // ucBar
            // 
            this.ucBar.ButtonAdd = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonCancel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonChange = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucBar.ButtonDelete = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonEdit = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonExport = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonOption = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucBar.ButtonPrint = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonSave = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.ButtonSaveNew = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBar.IsClose = Perfect.Common.CloseOrNew.None;
            this.ucBar.Location = new System.Drawing.Point(0, 0);
            this.ucBar.Name = "ucBar";
            this.ucBar.Size = new System.Drawing.Size(212, 26);
            this.ucBar.Status = Perfect.Common.Actions.None;
            this.ucBar.TabIndex = 0;
            this.ucBar.Title = "";
            // 
            // xucBaseBarS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl2);
            this.DoubleBuffered = true;
            this.Name = "xucBaseBarS";
            this.Size = new System.Drawing.Size(634, 26);
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.DateEdit dtTo;
        protected DevExpress.XtraEditors.DateEdit dtFrom;
        private DevExpress.XtraEditors.CheckButton bbiListType;
        protected DevExpress.Utils.ImageCollection img;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private xucToolBarL ucBar;
        private DevExpress.XtraEditors.CheckButton bbiMerrial;
    }
}
