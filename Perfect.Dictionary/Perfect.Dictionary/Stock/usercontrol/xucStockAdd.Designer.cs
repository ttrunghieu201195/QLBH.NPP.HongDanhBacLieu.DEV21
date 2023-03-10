namespace Perfect.Dictionary
{
    partial class xucStockAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucStockAdd));
            this.gcOther = new DevExpress.XtraEditors.GroupControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.lblMobile = new DevExpress.XtraEditors.LabelControl();
            this.txtCONTACT = new DevExpress.XtraEditors.TextEdit();
            this.lblContact = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtFAX = new DevExpress.XtraEditors.TextEdit();
            this.lblFax = new DevExpress.XtraEditors.LabelControl();
            this.txtTEL = new DevExpress.XtraEditors.TextEdit();
            this.lblTel = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.lblManager = new DevExpress.XtraEditors.LabelControl();
            this.chxUse = new DevExpress.XtraEditors.CheckEdit();
            this.txtManager = new DevExpress.XtraEditors.LookUpEdit();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEMPLOYEE = new Perfect.Dictionary.Employee.DS.dsEMPLOYEE();
            this.eMPLOYEETableAdapter = new Perfect.Dictionary.Employee.DS.dsEMPLOYEETableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOther)).BeginInit();
            this.gcOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONTACT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFAX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEMPLOYEE)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.lblManager);
            this.gcInfo.Controls.Add(this.txtManager);
            this.gcInfo.Controls.Add(this.txtMobile);
            this.gcInfo.Controls.Add(this.lblMobile);
            this.gcInfo.Size = new System.Drawing.Size(383, 101);
            this.gcInfo.TabIndex = 0;
            this.gcInfo.Controls.SetChildIndex(this.lblMobile, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtMobile, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtManager, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblManager, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(74, 52);
            this.txtNAME.Size = new System.Drawing.Size(299, 20);
            this.txtNAME.TabIndex = 0;
            this.txtNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNAME_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AllowHtmlString = true;
            this.lblName.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.lblName.Location = new System.Drawing.Point(8, 55);
            this.lblName.Size = new System.Drawing.Size(35, 14);
            this.lblName.Text = "Tên <color=red>(*)";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(74, 26);
            this.txtID.Size = new System.Drawing.Size(124, 20);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AllowHtmlString = true;
            this.lblId.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.lblId.Location = new System.Drawing.Point(8, 29);
            this.lblId.Size = new System.Drawing.Size(31, 14);
            this.lblId.Text = "Mã <color=red>(*)";
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 263);
            this.btnSave.Size = new System.Drawing.Size(95, 25);
            this.btnSave.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 263);
            this.btnCancel.Size = new System.Drawing.Size(95, 25);
            this.btnCancel.TabIndex = 4;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(197, 263);
            this.btnSaveNew.Size = new System.Drawing.Size(87, 25);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSaveNew_KeyPress);
            // 
            // gcOther
            // 
            this.gcOther.Controls.Add(this.lblDescription);
            this.gcOther.Controls.Add(this.txtDescription);
            this.gcOther.Controls.Add(this.txtCONTACT);
            this.gcOther.Controls.Add(this.lblContact);
            this.gcOther.Controls.Add(this.txtEmail);
            this.gcOther.Controls.Add(this.lblEmail);
            this.gcOther.Controls.Add(this.txtFAX);
            this.gcOther.Controls.Add(this.lblFax);
            this.gcOther.Controls.Add(this.txtTEL);
            this.gcOther.Controls.Add(this.lblTel);
            this.gcOther.Controls.Add(this.txtAddress);
            this.gcOther.Controls.Add(this.lblAddress);
            this.gcOther.Location = new System.Drawing.Point(1, 108);
            this.gcOther.Name = "gcOther";
            this.gcOther.Size = new System.Drawing.Size(384, 149);
            this.gcOther.TabIndex = 1;
            this.gcOther.Text = "Thông tin khác";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(5, 125);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(40, 13);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Diễn giải";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(74, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 20);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(255, 26);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(118, 20);
            this.txtMobile.TabIndex = 3;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // lblMobile
            // 
            this.lblMobile.Location = new System.Drawing.Point(214, 29);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(35, 13);
            this.lblMobile.TabIndex = 29;
            this.lblMobile.Text = "Ký hiệu";
            // 
            // txtCONTACT
            // 
            this.txtCONTACT.Location = new System.Drawing.Point(74, 25);
            this.txtCONTACT.Name = "txtCONTACT";
            this.txtCONTACT.Size = new System.Drawing.Size(299, 20);
            this.txtCONTACT.TabIndex = 0;
            this.txtCONTACT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCONTACT_KeyPress);
            // 
            // lblContact
            // 
            this.lblContact.Location = new System.Drawing.Point(5, 28);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Người liên hệ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.BeepOnError = true;
            this.txtEmail.Properties.Mask.EditMask = ".+@.+[.].+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Size = new System.Drawing.Size(299, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(5, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(24, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtFAX
            // 
            this.txtFAX.Location = new System.Drawing.Point(255, 71);
            this.txtFAX.Name = "txtFAX";
            this.txtFAX.Size = new System.Drawing.Size(119, 20);
            this.txtFAX.TabIndex = 4;
            this.txtFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFAX_KeyPress);
            // 
            // lblFax
            // 
            this.lblFax.Location = new System.Drawing.Point(214, 74);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(18, 13);
            this.lblFax.TabIndex = 4;
            this.lblFax.Text = "Fax";
            // 
            // txtTEL
            // 
            this.txtTEL.Location = new System.Drawing.Point(74, 72);
            this.txtTEL.Name = "txtTEL";
            this.txtTEL.Size = new System.Drawing.Size(124, 20);
            this.txtTEL.TabIndex = 2;
            this.txtTEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTEL_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.Location = new System.Drawing.Point(5, 75);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Điện thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(74, 48);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(5, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(32, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblManager
            // 
            this.lblManager.Location = new System.Drawing.Point(5, 79);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(66, 13);
            this.lblManager.TabIndex = 8;
            this.lblManager.Text = "Người quản lý";
            // 
            // chxUse
            // 
            this.chxUse.EditValue = true;
            this.chxUse.Location = new System.Drawing.Point(7, 263);
            this.chxUse.Name = "chxUse";
            this.chxUse.Properties.Caption = "Còn quản lý";
            this.chxUse.Size = new System.Drawing.Size(83, 19);
            this.chxUse.TabIndex = 8;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(74, 76);
            this.txtManager.Name = "txtManager";
            this.txtManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtManager.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_Name", "Employee_Name", 102, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee_ID", "Employee_ID", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.txtManager.Properties.DataSource = this.eMPLOYEEBindingSource;
            this.txtManager.Properties.DisplayMember = "Employee_Name";
            this.txtManager.Properties.NullText = "";
            this.txtManager.Properties.ShowHeader = false;
            this.txtManager.Properties.ValueMember = "Employee_ID";
            this.txtManager.Size = new System.Drawing.Size(300, 20);
            this.txtManager.TabIndex = 6;
            this.txtManager.TabStop = false;
            this.txtManager.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManager_KeyPress);
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dsEMPLOYEE;
            // 
            // dsEMPLOYEE
            // 
            this.dsEMPLOYEE.DataSetName = "dsEMPLOYEE";
            this.dsEMPLOYEE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // xucStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.gcOther);
            this.Controls.Add(this.chxUse);
            this.Name = "xucStockAdd";
            this.Size = new System.Drawing.Size(386, 292);
            this.Controls.SetChildIndex(this.btnSaveNew, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.chxUse, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.gcInfo, 0);
            this.Controls.SetChildIndex(this.gcOther, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOther)).EndInit();
            this.gcOther.ResumeLayout(false);
            this.gcOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCONTACT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFAX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEMPLOYEE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcOther;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.LabelControl lblMobile;
        private DevExpress.XtraEditors.TextEdit txtCONTACT;
        private DevExpress.XtraEditors.LabelControl lblContact;
        private DevExpress.XtraEditors.LabelControl lblManager;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtFAX;
        private DevExpress.XtraEditors.LabelControl lblFax;
        private DevExpress.XtraEditors.TextEdit txtTEL;
        private DevExpress.XtraEditors.LabelControl lblTel;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.CheckEdit chxUse;
        private DevExpress.XtraEditors.LookUpEdit txtManager;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private Perfect.Dictionary.Employee.DS.dsEMPLOYEE dsEMPLOYEE;
        private Perfect.Dictionary.Employee.DS.dsEMPLOYEETableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
    }
}
