using Perfect.Dictionary.Department.usercontrol;

namespace Perfect.Dictionary.Department
{
    partial class XfmDepartments
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
            this.ucList = new XucDepartment();
            this.SuspendLayout();
            // 
            // ucList
            // 
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 0);
            this.ucList.Name = "ucList";
            this.ucList.Size = new System.Drawing.Size(607, 430);
            this.ucList.TabIndex = 0;
            // 
            // xfmDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 430);
            this.Controls.Add(this.ucList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "XfmDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ Phận";
            this.ResumeLayout(false);

        }

        #endregion

        private XucDepartment ucList;
    }
}