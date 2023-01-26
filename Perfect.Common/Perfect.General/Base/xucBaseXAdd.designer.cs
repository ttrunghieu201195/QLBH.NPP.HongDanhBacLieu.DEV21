namespace Perfect.Common
{
    partial class xucBaseXAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucBaseXAdd));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.gcInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtNAME = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.txtNAME);
            this.gcInfo.Controls.Add(this.lblName);
            this.gcInfo.Controls.Add(this.txtID);
            this.gcInfo.Controls.Add(this.lblId);
            this.gcInfo.Location = new System.Drawing.Point(1, 1);
            this.gcInfo.Name = "gcInfo";
            this.gcInfo.Size = new System.Drawing.Size(383, 55);
            this.gcInfo.TabIndex = 2;
            this.gcInfo.Text = "Thông tin bắt buộc";
            // 
            // txtNAME
            // 
            this.txtNAME.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.txtNAME.Location = new System.Drawing.Point(155, 26);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Properties.DropDownRows = 10;
            this.txtNAME.Properties.ImmediatePopup = true;
            this.txtNAME.Properties.PopupSizeable = true;
            this.txtNAME.Size = new System.Drawing.Size(222, 20);
            this.txtNAME.TabIndex = 3;
            this.txtNAME.EditValueChanged += new System.EventHandler(this.txtNAME_EditValueChanged);
            this.txtNAME.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNAME_MouseClick);
            this.txtNAME.Leave += new System.EventHandler(this.txtNAME_Leave);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(126, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(18, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(27, 26);
            this.txtID.Name = "txtID";
            this.txtID.Properties.MaxLength = 20;
            this.txtID.Size = new System.Drawing.Size(93, 20);
            this.txtID.TabIndex = 1;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(6, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(14, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã";
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 0;
            this.btnSave.ImageList = this.imageCollection2;
            this.btnSave.Location = new System.Drawing.Point(89, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            toolTipItem2.Text = "Ctrl+S\r\n";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnSave.SuperTip = superToolTip2;
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu && Đóng";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 6;
            this.btnCancel.ImageList = this.imageCollection2;
            this.btnCancel.Location = new System.Drawing.Point(276, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 27);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.ImageIndex = 0;
            this.btnSaveNew.ImageList = this.imageCollection2;
            this.btnSaveNew.Location = new System.Drawing.Point(183, 78);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(87, 27);
            toolTipItem1.Text = "Ctrl+Shift +S";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnSaveNew.SuperTip = superToolTip1;
            this.btnSaveNew.TabIndex = 37;
            this.btnSaveNew.Text = "Lưu";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // xucBaseXAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gcInfo);
            this.DoubleBuffered = true;
            this.Name = "xucBaseXAdd";
            this.Size = new System.Drawing.Size(386, 108);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.GroupControl gcInfo;
        protected DevExpress.XtraEditors.LabelControl lblName;
        protected DevExpress.XtraEditors.TextEdit txtID;
        protected DevExpress.XtraEditors.LabelControl lblId;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        protected DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        protected DevExpress.XtraEditors.SimpleButton btnSave;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.SimpleButton btnSaveNew;
        protected DevExpress.XtraEditors.ComboBoxEdit txtNAME;
    }
}
