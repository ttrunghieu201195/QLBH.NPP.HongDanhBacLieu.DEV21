namespace Perfect.Common.Base {
    partial class XProgressForm
    {
        protected override void Dispose(bool disposing) {
            _die = true;
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XProgressForm));
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.progressBarControl1.Location = new System.Drawing.Point(12, 171);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.progressBarControl1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBarControl1.Properties.AutoHeight = true;
            this.progressBarControl1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.progressBarControl1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBarControl1.Size = new System.Drawing.Size(383, 14);
            this.progressBarControl1.TabIndex = 0;
            this.progressBarControl1.EditValueChanged += new System.EventHandler(this.progressBarControl1_EditValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AllowHtmlString = true;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Location = new System.Drawing.Point(12, 128);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 16);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Text = "....";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AllowHtmlString = true;
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Appearance.Options.UseForeColor = true;
            this.lblMessage.Appearance.Options.UseTextOptions = true;
            this.lblMessage.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMessage.Location = new System.Drawing.Point(12, 150);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(387, 15);
            this.lblMessage.TabIndex = 64;
            this.lblMessage.Text = "......";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 62);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(383, 60);
            this.pictureEdit1.TabIndex = 65;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 13);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "ERP.HONGDANH SYSTEM";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(72, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(281, 23);
            this.labelControl2.TabIndex = 67;
            this.labelControl2.Text = "Phần Mềm Quản Lý Hệ Thống";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // XProgressForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Perfect.Common.Properties.Resources.flash_screen__blue_white_1;
            this.ClientSize = new System.Drawing.Size(408, 195);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.progressBarControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XProgressForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.XProgressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
