using Perfect.Dictionary.Department.usercontrol;

namespace Perfect.Dictionary.Department
{
    partial class XfmDepartmentAdd
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
            this.ucAdd = new XucDepartmentAdd();
            this.SuspendLayout();
            // 
            // ucAdd
            // 
            this.ucAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdd.IsClose = Perfect.Common.CloseOrNew.None;
            this.ucAdd.Location = new System.Drawing.Point(0, 0);
            this.ucAdd.Name = "ucAdd";
            this.ucAdd.Size = new System.Drawing.Size(286, 161);
            this.ucAdd.Status = Perfect.Common.Actions.Add;
            this.ucAdd.TabIndex = 0;
            // 
            // xfmDepartmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 161);
            this.Controls.Add(this.ucAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XfmDepartmentAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ Phận";
            this.ResumeLayout(false);

        }

        #endregion

        private XucDepartmentAdd ucAdd;
    }
}