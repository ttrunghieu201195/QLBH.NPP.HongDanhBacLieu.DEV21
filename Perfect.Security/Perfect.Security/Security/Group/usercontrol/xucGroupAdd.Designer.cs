namespace Perfect.Security
{
    partial class xucGroupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucGroupAdd));
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.chxUse = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Controls.Add(this.lblDescription);
            this.gcInfo.Controls.Add(this.chxUse);
            this.gcInfo.Size = new System.Drawing.Size(279, 127);
            this.gcInfo.Controls.SetChildIndex(this.chxUse, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(62, 52);
            this.txtNAME.Size = new System.Drawing.Size(212, 20);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 55);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(62, 26);
            this.txtID.Size = new System.Drawing.Size(212, 20);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 134);
            this.btnSave.Size = new System.Drawing.Size(95, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 134);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(1, 134);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(6, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(40, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Diễn giải";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(62, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // chxUse
            // 
            this.chxUse.EditValue = true;
            this.chxUse.Location = new System.Drawing.Point(60, 102);
            this.chxUse.Name = "chxUse";
            this.chxUse.Properties.Caption = "Còn quản lý";
            this.chxUse.Size = new System.Drawing.Size(95, 19);
            this.chxUse.TabIndex = 6;
            // 
            // xucGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucGroupAdd";
            this.Size = new System.Drawing.Size(281, 164);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.CheckEdit chxUse;
    }
}
