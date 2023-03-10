namespace Perfect.Security
{
    partial class xfmOption
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
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmOption));
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sYSOPTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOption = new Perfect.Security.Security.Option.DataSet.dsOption();
            this.sYS_OPTIONTableAdapter = new Perfect.Security.Security.Option.DataSet.dsOptionTableAdapters.SYS_OPTIONTableAdapter();
            this.cbxLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLimit = new DevExpress.XtraEditors.CalcEdit();
            this.txtOld = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSOPTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 141);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(254, 36);
            this.panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 32;
            this.btnClose.ImageList = this.imageCollection2;
            this.btnClose.Location = new System.Drawing.Point(151, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 25);
            toolTipItem3.Text = "Alt+X\r\nF10";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnClose.SuperTip = superToolTip3;
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageCollection2;
            this.btnSave.Location = new System.Drawing.Point(39, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 25);
            toolTipItem4.Text = "F2\r\nCtrl+S\r\nCtrl+W";
            superToolTip4.Items.Add(toolTipItem4);
            this.btnSave.SuperTip = superToolTip4;
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // sYSOPTIONBindingSource
            // 
            this.sYSOPTIONBindingSource.DataMember = "SYS_OPTION";
            this.sYSOPTIONBindingSource.DataSource = this.dsOption;
            // 
            // dsOption
            // 
            this.dsOption.DataSetName = "dsOption";
            this.dsOption.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sYS_OPTIONTableAdapter
            // 
            this.sYS_OPTIONTableAdapter.ClearBeforeFill = true;
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.EditValue = "VN";
            this.cbxLanguage.Location = new System.Drawing.Point(156, 23);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLanguage.Properties.Items.AddRange(new object[] {
            "VN",
            "EN"});
            this.cbxLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLanguage.Size = new System.Drawing.Size(75, 20);
            this.cbxLanguage.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ngôn ngữ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cảnh Báo Quá Hạn Tồn";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cảnh Báo Quá Hạn Sử Dụng";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(155, 59);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLimit.Size = new System.Drawing.Size(76, 20);
            this.txtLimit.TabIndex = 6;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(155, 95);
            this.txtOld.Name = "txtOld";
            this.txtOld.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOld.Size = new System.Drawing.Size(76, 20);
            this.txtOld.TabIndex = 7;
            // 
            // xfmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 177);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.panelControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmOption";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn";
            this.Load += new System.EventHandler(this.xfmOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSOPTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOld.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        protected DevExpress.XtraEditors.SimpleButton btnClose;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        protected DevExpress.XtraEditors.SimpleButton btnSave;
        protected DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private Perfect.Security.Security.Option.DataSet.dsOption dsOption;
        private System.Windows.Forms.BindingSource sYSOPTIONBindingSource;
        private Perfect.Security.Security.Option.DataSet.dsOptionTableAdapters.SYS_OPTIONTableAdapter sYS_OPTIONTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLanguage;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit txtOld;
        private DevExpress.XtraEditors.CalcEdit txtLimit;
    }
}