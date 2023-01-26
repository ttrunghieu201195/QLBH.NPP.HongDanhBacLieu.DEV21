namespace Perfect.Dictionary.ProductGroup.usercontrol
{
    partial class XucProductGroupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucProductGroupAdd));
            this.chxUse = new DevExpress.XtraEditors.CheckEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(60, 53);
            this.txtNAME.Size = new System.Drawing.Size(218, 20);
            this.txtNAME.TabIndex = 0;
            this.txtNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameKeyPress);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(97, 128);
            this.btnSaveNew.TabIndex = 1;
            this.btnSaveNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnSaveNewKeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 128);
            this.btnSave.Size = new System.Drawing.Size(92, 27);
            this.btnSave.TabIndex = 2;
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.chxUse);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Controls.Add(this.lblDescription);
            this.gcInfo.Size = new System.Drawing.Size(286, 122);
            this.gcInfo.TabIndex = 0;
            this.gcInfo.Text = "Thông tin";
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.chxUse, 0);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(5, 56);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 28);
            this.txtID.Size = new System.Drawing.Size(218, 20);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIDKeyPress);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(5, 30);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 128);
            this.btnCancel.TabIndex = 3;
            // 
            // chxUse
            // 
            this.chxUse.EditValue = true;
            this.chxUse.Location = new System.Drawing.Point(57, 101);
            this.chxUse.Name = "chxUse";
            this.chxUse.Properties.Caption = "Còn quản lý";
            this.chxUse.Size = new System.Drawing.Size(97, 19);
            this.chxUse.TabIndex = 3;
            this.chxUse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChxUseKeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(60, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(218, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescriptionKeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(5, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Ghi chú";
            // 
            // xucProductGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "XucProductGroupAdd";
            this.Size = new System.Drawing.Size(287, 158);
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chxUse;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
    }
}
