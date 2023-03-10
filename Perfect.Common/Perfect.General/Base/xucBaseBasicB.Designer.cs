namespace Perfect.Common
{
    partial class xucBaseBasicB
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
            this.ucToolBar = new Perfect.Common.xucToolBar();
            this.SuspendLayout();
            // 
            // ucToolBar
            // 
            this.ucToolBar.ButtonAdd = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonCancel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonChange = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonDelete = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonEdit = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonExport = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonOption = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonPrint = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucToolBar.ButtonSave = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.ButtonSaveNew = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucToolBar.IsClose = Perfect.Common.CloseOrNew.None;
            this.ucToolBar.Location = new System.Drawing.Point(0, 0);
            this.ucToolBar.Name = "ucToolBar";
            this.ucToolBar.Size = new System.Drawing.Size(761, 43);
            this.ucToolBar.Status = Perfect.Common.Actions.Add;
            this.ucToolBar.TabIndex = 0;
            this.ucToolBar.Title = "";
            // 
            // xucBaseBasicB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucToolBar);
            this.DoubleBuffered = true;
            this.Name = "xucBaseBasicB";
            this.Size = new System.Drawing.Size(761, 664);
            this.ResumeLayout(false);

        }

        #endregion

        protected xucToolBar ucToolBar;
    }
}
