namespace Perfect.Sale.Core.REICEIPT
{
    partial class xfmReceiptOptions
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
            this.treeOptions = new DevExpress.XtraTreeList.TreeList();
            this.colOption = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // treeOptions
            // 
            this.treeOptions.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colOption,
            this.colID});
            this.treeOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeOptions.Location = new System.Drawing.Point(0, 0);
            this.treeOptions.Name = "treeOptions";
            this.treeOptions.BeginUnboundLoad();
            this.treeOptions.AppendNode(new object[] {
            "Chọn Phiếu",
            "0"}, -1);
            this.treeOptions.AppendNode(new object[] {
            "Phiếu Thu Đơn",
            "1"}, 0);
            this.treeOptions.AppendNode(new object[] {
            "Phiếu Thu Tổng",
            "2"}, 0);
            this.treeOptions.EndUnboundLoad();
            this.treeOptions.Size = new System.Drawing.Size(457, 222);
            this.treeOptions.TabIndex = 0;
            this.treeOptions.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeOptions_FocusedNodeChanged);
            // 
            // colOption
            // 
            this.colOption.Caption = "Phiếu";
            this.colOption.FieldName = "Option";
            this.colOption.MinWidth = 38;
            this.colOption.Name = "colOption";
            this.colOption.Visible = true;
            this.colOption.VisibleIndex = 0;
            this.colOption.Width = 343;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 93;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(214, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Chọn";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // xfmReceiptOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.treeOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "xfmReceiptOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Phiếu Thu";
            ((System.ComponentModel.ISupportInitialize)(this.treeOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeOptions;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOption;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}