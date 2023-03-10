namespace Perfect.Common
{
    partial class xucCurrencyAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucCurrencyAdd));
            this.txtExchange = new DevExpress.XtraEditors.CalcEdit();
            this.lblExchange = new DevExpress.XtraEditors.LabelControl();
            this.chxUse = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.chxUse);
            this.gcInfo.Controls.Add(this.lblExchange);
            this.gcInfo.Controls.Add(this.txtExchange);
            this.gcInfo.Size = new System.Drawing.Size(284, 123);
            this.gcInfo.Text = "Thông tin";
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtExchange, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblExchange, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.chxUse, 0);
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(84, 52);
            this.txtNAME.Size = new System.Drawing.Size(188, 20);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(11, 55);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 26);
            this.txtID.Size = new System.Drawing.Size(188, 20);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(11, 29);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1, 129);
            this.btnSave.Size = new System.Drawing.Size(96, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 129);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(100, 129);
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(84, 77);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExchange.Properties.NullText = "0";
            this.txtExchange.Properties.ShowCloseButton = true;
            this.txtExchange.Properties.ValidateOnEnterKey = true;
            this.txtExchange.Size = new System.Drawing.Size(188, 20);
            this.txtExchange.TabIndex = 4;
            // 
            // lblExchange
            // 
            this.lblExchange.Location = new System.Drawing.Point(11, 80);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(67, 13);
            this.lblExchange.TabIndex = 37;
            this.lblExchange.Text = "Tỷ giá quy đổi";
            // 
            // chxUse
            // 
            this.chxUse.EditValue = true;
            this.chxUse.Location = new System.Drawing.Point(82, 100);
            this.chxUse.Name = "chxUse";
            this.chxUse.Properties.Caption = "Còn quản lý";
            this.chxUse.Size = new System.Drawing.Size(97, 18);
            this.chxUse.TabIndex = 38;
            // 
            // xucCurrencyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucCurrencyAdd";
            this.Size = new System.Drawing.Size(288, 157);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblExchange;
        private DevExpress.XtraEditors.CalcEdit txtExchange;
        private DevExpress.XtraEditors.CheckEdit chxUse;
    }
}
