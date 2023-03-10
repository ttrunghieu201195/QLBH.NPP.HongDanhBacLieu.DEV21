namespace Perfect.Common
{
    partial class xucBaseBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucBaseBar));
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.dtTo = new DevExpress.XtraEditors.DateEdit();
            this.ucDateTimeSelect = new Perfect.Common.UI.xucDateTimeSelectEdit();
            this.dtFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucBar = new Perfect.Common.xucToolBarL();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDateTimeSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "RibbonPrintPreview_DocumentMapLarge.png");
            // 
            // dtTo
            // 
            this.dtTo.EditValue = new System.DateTime(2009, 7, 25, 22, 57, 46, 531);
            this.dtTo.Location = new System.Drawing.Point(251, 3);
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
            this.dtTo.Size = new System.Drawing.Size(89, 20);
            this.dtTo.TabIndex = 237;
            // 
            // ucDateTimeSelect
            // 
            this.ucDateTimeSelect.DefaultText = "Tuỳ Chọn";
            this.ucDateTimeSelect.EditValue = "Tuỳ Chọn";
            this.ucDateTimeSelect.From = new System.DateTime(2010, 2, 1, 0, 0, 0, 0);
            this.ucDateTimeSelect.Location = new System.Drawing.Point(3, 3);
            this.ucDateTimeSelect.Name = "ucDateTimeSelect";
            this.ucDateTimeSelect.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ucDateTimeSelect.Properties.Appearance.Options.UseForeColor = true;
            this.ucDateTimeSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ucDateTimeSelect.Properties.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Quý này",
            "Năm nay",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"
            });
            this.ucDateTimeSelect.Properties.NullText = "Tuỳ Chọn";
            this.ucDateTimeSelect.Properties.NullValuePrompt = "Tuỳ Chọn";
            this.ucDateTimeSelect.Size = new System.Drawing.Size(106, 20);
            this.ucDateTimeSelect.TabIndex = 242;
            this.ucDateTimeSelect.To = new System.DateTime(2010, 2, 28, 0, 0, 0, 0);
            this.ucDateTimeSelect.DataTimeChanged += new Perfect.Common.UI.xucDateTimeSelectEdit.DataTimeChangedEventHander(this.ucDateTimeSelect_DataTimeChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.EditValue = new System.DateTime(2009, 7, 25, 22, 57, 46, 531);
            this.dtFrom.Location = new System.Drawing.Point(130, 3);
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
            this.dtFrom.Size = new System.Drawing.Size(94, 20);
            this.dtFrom.TabIndex = 236;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(226, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 245;
            this.labelControl1.Text = "Đến";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(111, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(13, 13);
            this.lblEmail.TabIndex = 244;
            this.lblEmail.Text = "Từ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucDateTimeSelect);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 26);
            this.panel1.TabIndex = 246;
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
            this.ucBar.Location = new System.Drawing.Point(344, 0);
            this.ucBar.Name = "ucBar";
            this.ucBar.Size = new System.Drawing.Size(404, 26);
            this.ucBar.Status = Perfect.Common.Actions.None;
            this.ucBar.TabIndex = 247;
            this.ucBar.Title = "";
            // 
            // xucBaseBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucBar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "xucBaseBar";
            this.Size = new System.Drawing.Size(748, 26);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDateTimeSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.Utils.ImageCollection img;
        protected DevExpress.XtraEditors.DateEdit dtTo;
        protected DevExpress.XtraEditors.DateEdit dtFrom;
        protected Perfect.Common.UI.xucDateTimeSelectEdit ucDateTimeSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private System.Windows.Forms.Panel panel1;
        private xucToolBarL ucBar;
    }
}
