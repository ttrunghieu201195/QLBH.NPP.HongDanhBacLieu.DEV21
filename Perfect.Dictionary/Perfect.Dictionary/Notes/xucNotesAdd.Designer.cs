namespace Perfect.Dictionary
{
    partial class xucNotesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucNotesAdd));
            this.chxUse = new DevExpress.XtraEditors.CheckEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.ColorEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.chxUse);
            this.gcInfo.Controls.Add(this.lblDescription);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Size = new System.Drawing.Size(288, 123);
            this.gcInfo.Text = "Thông tin";
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.chxUse, 0);
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(54, 53);
            this.txtNAME.Size = new System.Drawing.Size(222, 20);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(5, 56);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 27);
            this.txtID.Size = new System.Drawing.Size(222, 20);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(5, 30);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1, 129);
            this.btnSave.Size = new System.Drawing.Size(92, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 129);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(99, 129);
            // 
            // chxUse
            // 
            this.chxUse.EditValue = true;
            this.chxUse.Location = new System.Drawing.Point(53, 102);
            this.chxUse.Name = "chxUse";
            this.chxUse.Properties.Caption = "Còn quản lý";
            this.chxUse.Size = new System.Drawing.Size(97, 19);
            this.chxUse.TabIndex = 29;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(5, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(39, 13);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Màu sắc";
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = System.Drawing.Color.Empty;
            this.txtDescription.Location = new System.Drawing.Point(54, 79);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDescription.Size = new System.Drawing.Size(222, 20);
            this.txtDescription.TabIndex = 28;
            this.txtDescription.TabStop = false;
            this.txtDescription.EditValueChanged += new System.EventHandler(this.txtDescription_EditValueChanged);
            // 
            // xucNotesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "xucNotesAdd";
            this.Size = new System.Drawing.Size(292, 159);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chxUse;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.ColorEdit txtDescription;
    }
}
