

namespace Perfect.Inventory
{
    partial class xfmSearch
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
            this.xucSearch = new Perfect.Inventory.xucSearch();
            this.SuspendLayout();
            // 
            // xucSearch
            // 
            this.xucSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xucSearch.Location = new System.Drawing.Point(0, 0);
            this.xucSearch.Name = "xucSearch";
            this.xucSearch.Size = new System.Drawing.Size(798, 511);
            this.xucSearch.TabIndex = 0;
            // 
            // xfmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 511);
            this.Controls.Add(this.xucSearch);
            this.Name = "xfmSearch";
            this.Text = "Tìm Kiếm Chứng Từ";
            this.ResumeLayout(false);

        }

        #endregion

        private xucSearch xucSearch;
    }
}