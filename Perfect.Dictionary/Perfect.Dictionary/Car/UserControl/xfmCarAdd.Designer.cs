namespace Perfect.Dictionary
{
    partial class xfmCarAdd
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
            this.ucAdd = new Perfect.Common.xucCarAdd();
            this.SuspendLayout();
            // 
            // ucAdd
            // 
            this.ucAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdd.IsClose = Perfect.Common.CloseOrNew.None;
            this.ucAdd.Location = new System.Drawing.Point(0, 0);
            this.ucAdd.Name = "ucAdd";
            this.ucAdd.Size = new System.Drawing.Size(287, 285); 
            this.ucAdd.Status = Perfect.Common.Actions.Add;
            this.ucAdd.TabIndex = 0;
            // 
            // xfmCurrencyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 285);
            this.Controls.Add(this.ucAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.Name = "xfmCurrencyAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Xe";
            this.ResumeLayout(false);

        }

        #endregion

        private Perfect.Common.xucCarAdd ucAdd;
    }
}