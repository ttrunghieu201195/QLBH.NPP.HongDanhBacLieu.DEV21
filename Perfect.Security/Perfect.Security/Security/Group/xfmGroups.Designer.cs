namespace Perfect.Security
{
    partial class xfmGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmGroups));
            this.ucList = new Perfect.Security.xucGroup();
            this.SuspendLayout();
            // 
            // ucList
            // 
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.IsClose = Perfect.Common.CloseOrNew.None;
            this.ucList.IsSearch = false;
            this.ucList.Location = new System.Drawing.Point(0, 0);
            this.ucList.Name = "ucList";
            this.ucList.Size = new System.Drawing.Size(1012, 734);
            this.ucList.Status = Perfect.Common.Actions.Add;
            this.ucList.TabIndex = 0;
            // 
            // xfmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 734);
            this.Controls.Add(this.ucList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfmGroups";
            this.Text = "Vai Trò & Quyền Hạn";
            this.ResumeLayout(false);

        }

        #endregion

        private xucGroup ucList;
    }
}