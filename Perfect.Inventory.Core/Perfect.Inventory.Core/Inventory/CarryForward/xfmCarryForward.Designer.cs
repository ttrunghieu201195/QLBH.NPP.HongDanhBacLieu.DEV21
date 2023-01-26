namespace Perfect.Inventory.Core.Inventory.CarryForward
{
    partial class xfmCarryForward
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
            this.wz_CarryForward = new DevExpress.XtraWizard.WizardControl();
            this.PageWelcome = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.PageSetTime = new DevExpress.XtraWizard.WizardPage();
            this.txtDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PageFinish = new DevExpress.XtraWizard.CompletionWizardPage();
            this.PageBeforeExecute = new DevExpress.XtraWizard.WizardPage();
            this.txtCaution = new DevExpress.XtraEditors.MemoEdit();
            this.PageProgress = new DevExpress.XtraWizard.WizardPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.barProcess = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtProcess = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcbarProcess = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.wz_CarryForward)).BeginInit();
            this.wz_CarryForward.SuspendLayout();
            this.PageSetTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateBegin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateBegin.Properties)).BeginInit();
            this.PageBeforeExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaution.Properties)).BeginInit();
            this.PageProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcbarProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // wz_CarryForward
            // 
            this.wz_CarryForward.Controls.Add(this.PageWelcome);
            this.wz_CarryForward.Controls.Add(this.PageSetTime);
            this.wz_CarryForward.Controls.Add(this.PageFinish);
            this.wz_CarryForward.Controls.Add(this.PageBeforeExecute);
            this.wz_CarryForward.Controls.Add(this.PageProgress);
            this.wz_CarryForward.Name = "wz_CarryForward";
            this.wz_CarryForward.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.PageWelcome,
            this.PageSetTime,
            this.PageBeforeExecute,
            this.PageProgress,
            this.PageFinish});
            this.wz_CarryForward.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wz_CarryForward_SelectedPageChanged);
            // 
            // PageWelcome
            // 
            this.PageWelcome.Name = "PageWelcome";
            this.PageWelcome.Size = new System.Drawing.Size(538, 320);
            // 
            // PageSetTime
            // 
            this.PageSetTime.Controls.Add(this.txtDateBegin);
            this.PageSetTime.Controls.Add(this.labelControl2);
            this.PageSetTime.Controls.Add(this.labelControl1);
            this.PageSetTime.Name = "PageSetTime";
            this.PageSetTime.Size = new System.Drawing.Size(723, 308);
            this.PageSetTime.Text = "Set Time";
            // 
            // txtDateBegin
            // 
            this.txtDateBegin.EditValue = null;
            this.txtDateBegin.Location = new System.Drawing.Point(87, 16);
            this.txtDateBegin.Name = "txtDateBegin";
            this.txtDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateBegin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDateBegin.Size = new System.Drawing.Size(138, 20);
            this.txtDateBegin.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mốc thời gian:";
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 278);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(369, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lưu ý <color=red>*</color>: bạn nên sao lưu dữ liệu lại trước khi tiến hành kết c" +
                "huyển";
            // 
            // PageFinish
            // 
            this.PageFinish.Name = "PageFinish";
            this.PageFinish.Size = new System.Drawing.Size(538, 320);
            // 
            // PageBeforeExecute
            // 
            this.PageBeforeExecute.Controls.Add(this.txtCaution);
            this.PageBeforeExecute.Name = "PageBeforeExecute";
            this.PageBeforeExecute.Size = new System.Drawing.Size(723, 308);
            this.PageBeforeExecute.Text = "Before Execute";
            // 
            // txtCaution
            // 
            this.txtCaution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaution.Location = new System.Drawing.Point(0, 0);
            this.txtCaution.Name = "txtCaution";
            this.txtCaution.Properties.ReadOnly = true;
            this.txtCaution.Size = new System.Drawing.Size(723, 308);
            this.txtCaution.TabIndex = 0;
            // 
            // PageProgress
            // 
            this.PageProgress.Controls.Add(this.layoutControl1);
            this.PageProgress.Name = "PageProgress";
            this.PageProgress.Size = new System.Drawing.Size(723, 308);
            this.PageProgress.Text = "Progress";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.barProcess);
            this.layoutControl1.Controls.Add(this.txtProcess);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(723, 308);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // barProcess
            // 
            this.barProcess.Location = new System.Drawing.Point(12, 282);
            this.barProcess.Name = "barProcess";
            this.barProcess.Properties.ShowTitle = true;
            this.barProcess.Size = new System.Drawing.Size(699, 14);
            this.barProcess.StyleController = this.layoutControl1;
            this.barProcess.TabIndex = 5;
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(12, 12);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(699, 266);
            this.txtProcess.StyleController = this.layoutControl1;
            this.txtProcess.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lcbarProcess});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(723, 308);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtProcess;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(703, 270);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // lcbarProcess
            // 
            this.lcbarProcess.Control = this.barProcess;
            this.lcbarProcess.CustomizationFormText = "layoutControlItem2";
            this.lcbarProcess.Location = new System.Drawing.Point(0, 270);
            this.lcbarProcess.Name = "lcbarProcess";
            this.lcbarProcess.Size = new System.Drawing.Size(703, 18);
            this.lcbarProcess.Text = "lcbarProcess";
            this.lcbarProcess.TextSize = new System.Drawing.Size(0, 0);
            this.lcbarProcess.TextToControlDistance = 0;
            this.lcbarProcess.TextVisible = false;
            // 
            // xfmCarryForward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 453);
            this.Controls.Add(this.wz_CarryForward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "xfmCarryForward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xfmCarryForward";
            ((System.ComponentModel.ISupportInitialize)(this.wz_CarryForward)).EndInit();
            this.wz_CarryForward.ResumeLayout(false);
            this.PageSetTime.ResumeLayout(false);
            this.PageSetTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateBegin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateBegin.Properties)).EndInit();
            this.PageBeforeExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCaution.Properties)).EndInit();
            this.PageProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcbarProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wz_CarryForward;
        private DevExpress.XtraWizard.WelcomeWizardPage PageWelcome;
        private DevExpress.XtraWizard.WizardPage PageSetTime;
        private DevExpress.XtraWizard.CompletionWizardPage PageFinish;
        private DevExpress.XtraWizard.WizardPage PageBeforeExecute;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDateBegin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraWizard.WizardPage PageProgress;
        private DevExpress.XtraEditors.MemoEdit txtCaution;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ProgressBarControl barProcess;
        private DevExpress.XtraEditors.MemoEdit txtProcess;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lcbarProcess;
    }
}