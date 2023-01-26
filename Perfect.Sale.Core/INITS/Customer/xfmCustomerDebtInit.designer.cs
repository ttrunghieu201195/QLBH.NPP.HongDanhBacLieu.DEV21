using Perfect.Sale.Core.INITS.Customer.UI;

namespace Perfect.Sale.Core
{
    partial class xfmCustomerDebtInit
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ucDebt = new XucCustomerDebtInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ucDebt);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(562, 456);
            this.panelControl2.TabIndex = 2;
            // 
            // ucDebt
            // 
            this.ucDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDebt.Location = new System.Drawing.Point(2, 2);
            this.ucDebt.Name = "ucDebt";
            this.ucDebt.Size = new System.Drawing.Size(558, 452);
            this.ucDebt.TabIndex = 0;
            // 
            // xfmCUSTOMER_DEBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 456);
            this.Controls.Add(this.panelControl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmCUSTOMER_DEBT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Nợ Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XucCustomerDebtInit ucDebt;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}