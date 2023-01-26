namespace Perfect.Common
{
    partial class xucBaseAdd26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucBaseAdd26));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.txtNAME = new DevExpress.XtraEditors.TextEdit();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.liId = new DevExpress.XtraLayout.LayoutControlItem();
            this.liName = new DevExpress.XtraLayout.LayoutControlItem();
            this.liSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.liSaveNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.liCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liSaveNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(60, 31);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(319, 20);
            this.txtNAME.StyleController = this.lcMain;
            this.txtNAME.TabIndex = 3;
            this.txtNAME.EditValueChanged += new System.EventHandler(this.txtNAME_EditValueChanged);
            this.txtNAME.Leave += new System.EventHandler(this.txtNAME_Leave);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtNAME);
            this.lcMain.Controls.Add(this.btnCancel);
            this.lcMain.Controls.Add(this.btnSaveNew);
            this.lcMain.Controls.Add(this.txtID);
            this.lcMain.Controls.Add(this.btnSave);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lgMain;
            this.lcMain.Size = new System.Drawing.Size(386, 452);
            this.lcMain.TabIndex = 38;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 6;
            this.btnCancel.ImageList = this.imageCollection2;
            this.btnCancel.Location = new System.Drawing.Point(60, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(319, 22);
            this.btnCancel.StyleController = this.lcMain;
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ImageIndex = 0;
            this.btnSaveNew.ImageList = this.imageCollection2;
            this.btnSaveNew.Location = new System.Drawing.Point(60, 81);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(319, 22);
            this.btnSaveNew.StyleController = this.lcMain;
            toolTipItem3.Text = "Ctrl+Shift +S";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnSaveNew.SuperTip = superToolTip3;
            this.btnSaveNew.TabIndex = 37;
            this.btnSaveNew.Text = "Lưu && Thêm";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(319, 20);
            this.txtID.StyleController = this.lcMain;
            this.txtID.TabIndex = 1;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imageCollection2;
            this.btnSave.Location = new System.Drawing.Point(60, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 22);
            this.btnSave.StyleController = this.lcMain;
            toolTipItem4.Text = "Ctrl+S\r\n";
            superToolTip4.Items.Add(toolTipItem4);
            this.btnSave.SuperTip = superToolTip4;
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu && Đóng";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lgMain
            // 
            this.lgMain.CustomizationFormText = "lgMain";
            this.lgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lgMain.GroupBordersVisible = false;
            this.lgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liId,
            this.liName,
            this.liSave,
            this.liSaveNew,
            this.liCancel});
            this.lgMain.Location = new System.Drawing.Point(0, 0);
            this.lgMain.Name = "lgMain";
            this.lgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lgMain.Size = new System.Drawing.Size(386, 452);
            this.lgMain.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lgMain.Text = "lgMain";
            this.lgMain.TextVisible = false;
            // 
            // liId
            // 
            this.liId.Control = this.txtID;
            this.liId.CustomizationFormText = "Mã";
            this.liId.Location = new System.Drawing.Point(0, 0);
            this.liId.Name = "liId";
            this.liId.Size = new System.Drawing.Size(376, 24);
            this.liId.Text = "Mã";
            this.liId.TextSize = new System.Drawing.Size(49, 13);
            // 
            // liName
            // 
            this.liName.Control = this.txtNAME;
            this.liName.CustomizationFormText = "Tên";
            this.liName.Location = new System.Drawing.Point(0, 24);
            this.liName.Name = "liName";
            this.liName.Size = new System.Drawing.Size(376, 24);
            this.liName.Text = "Tên";
            this.liName.TextSize = new System.Drawing.Size(49, 13);
            // 
            // liSave
            // 
            this.liSave.Control = this.btnSave;
            this.liSave.CustomizationFormText = "layoutControlItem1";
            this.liSave.Location = new System.Drawing.Point(0, 48);
            this.liSave.Name = "liSave";
            this.liSave.Size = new System.Drawing.Size(376, 26);
            this.liSave.Text = "liSave";
            this.liSave.TextSize = new System.Drawing.Size(49, 13);
            // 
            // liSaveNew
            // 
            this.liSaveNew.Control = this.btnSaveNew;
            this.liSaveNew.CustomizationFormText = "layoutControlItem2";
            this.liSaveNew.Location = new System.Drawing.Point(0, 74);
            this.liSaveNew.Name = "liSaveNew";
            this.liSaveNew.Size = new System.Drawing.Size(376, 26);
            this.liSaveNew.Text = "liSaveNew";
            this.liSaveNew.TextSize = new System.Drawing.Size(49, 13);
            // 
            // liCancel
            // 
            this.liCancel.Control = this.btnCancel;
            this.liCancel.CustomizationFormText = "layoutControlItem3";
            this.liCancel.Location = new System.Drawing.Point(0, 100);
            this.liCancel.Name = "liCancel";
            this.liCancel.Size = new System.Drawing.Size(376, 342);
            this.liCancel.Text = "liCancel";
            this.liCancel.TextSize = new System.Drawing.Size(49, 13);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // xucBaseAdd26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "xucBaseAdd26";
            this.Size = new System.Drawing.Size(386, 452);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liSaveNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.TextEdit txtNAME;
        protected DevExpress.XtraEditors.TextEdit txtID;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        protected DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        protected DevExpress.XtraEditors.SimpleButton btnSave;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.SimpleButton btnSaveNew;
        protected DevExpress.XtraLayout.LayoutControlItem liId;
        protected DevExpress.XtraLayout.LayoutControlItem liName;
        protected DevExpress.XtraLayout.LayoutControl lcMain;
        protected DevExpress.XtraLayout.LayoutControlGroup lgMain;
        protected DevExpress.XtraLayout.LayoutControlItem liSave;
        protected DevExpress.XtraLayout.LayoutControlItem liCancel;
        protected DevExpress.XtraLayout.LayoutControlItem liSaveNew;
    }
}
