namespace Perfect.Security
{
    partial class xfmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfmUsers));
			this.ucList = new Perfect.Security.xucUser();
            this.SuspendLayout();
            // 
            // ucList
            // 
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 0);
            this.ucList.Name = "ucList";
            this.ucList.Size = new System.Drawing.Size(618, 445);
            this.ucList.TabIndex = 0;
            // 
            // xfmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 445);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Controls.Add(this.ucList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Dùng";
            this.ResumeLayout(false);

        }

        #endregion

        private xucUser ucList;
    }
}