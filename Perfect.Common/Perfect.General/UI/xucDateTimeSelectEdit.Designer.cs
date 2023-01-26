namespace Perfect.Common.UI
{
    partial class xucDateTimeSelectEdit
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
            this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.fProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            //this.fProperties.Items.AddRange(new object[] {
            //"Hôm nay",
            //"Tuần này",
            //"Tháng này",
            //"Quý này",
            //"Năm nay",
            //"Tháng 1",
            //"Tháng 2",
            //"Tháng 3",
            //"Tháng 4",
            //"Tháng 5",
            //"Tháng 6",
            //"Tháng 7",
            //"Tháng 9",
            //"Tháng 10",
            //"Tháng 11",
            //"Tháng 12",
            //"Quý 1",
            //"Quý 2",
            //"Quý 3",
            //"Quý 4"});
            this.fProperties.Name = "fProperties";
            // 
            // xucDateTimeSelectEdit
            // 
            this.EditValue = "Hôm nay";
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox fProperties;
    }
}
