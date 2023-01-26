namespace Perfect.Core
{
    partial class xfmLocks
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.wc = new DevExpress.XtraWizard.WizardControl();
            this.wpServer = new DevExpress.XtraWizard.WizardPage();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.chxDelete = new DevExpress.XtraEditors.CheckEdit();
            this.cbxDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chxCreated = new DevExpress.XtraEditors.CheckEdit();
            this.plCreated = new DevExpress.XtraEditors.PanelControl();
            this.BarCreated = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.txtPath = new DevExpress.XtraEditors.ButtonEdit();
            this.lblDatabase = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rdgAuthentication = new DevExpress.XtraEditors.RadioGroup();
            this.lblServer = new DevExpress.XtraEditors.LabelControl();
            this.lblSqlusername = new DevExpress.XtraEditors.LabelControl();
            this.lblSqlpassword = new DevExpress.XtraEditors.LabelControl();
            this.cbxServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.wpOptions = new DevExpress.XtraWizard.WizardPage();
            this.chxOnly = new DevExpress.XtraEditors.CheckEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.chxLocks = new DevExpress.XtraEditors.CheckEdit();
            this.wpLocks = new DevExpress.XtraWizard.WizardPage();
            this.lResult = new DevExpress.XtraEditors.ListBoxControl();
            this.Bar2 = new DevExpress.XtraEditors.ProgressBarControl();
            this.Bar = new DevExpress.XtraEditors.ProgressBarControl();
            this.wpFinish = new DevExpress.XtraWizard.WizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wc)).BeginInit();
            this.wc.SuspendLayout();
            this.wpServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plCreated)).BeginInit();
            this.plCreated.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAuthentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            this.wpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxLocks.Properties)).BeginInit();
            this.wpLocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wc
            // 
            this.wc.AllowPagePadding = false;
            this.wc.CancelText = "Huỷ";
            this.wc.Controls.Add(this.wpServer);
            this.wc.Controls.Add(this.wpOptions);
            this.wc.Controls.Add(this.wpLocks);
            this.wc.Controls.Add(this.wpFinish);
            this.wc.FinishText = "&Kết Thúc";
            this.wc.HelpText = "&Trợ Giúp";
            this.wc.Name = "wc";
            this.wc.NextText = "&Tiếp Tục >";
            this.wc.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wpOptions,
            this.wpServer,
            this.wpLocks,
            this.wpFinish});
            this.wc.PreviousText = "< &Trở Lại";
            this.wc.Text = "Kết Chuyển Dữ Liệu Sang Năm Mới";
            this.wc.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wc_NextClick);
            this.wc.CancelClick += new System.ComponentModel.CancelEventHandler(this.wc_CancelClick);
            // 
            // wpServer
            // 
            this.wpServer.Controls.Add(this.panelControl3);
            this.wpServer.Controls.Add(this.plCreated);
            this.wpServer.Controls.Add(this.panelControl1);
            this.wpServer.DescriptionText = "";
            this.wpServer.Name = "wpServer";
            this.wpServer.Size = new System.Drawing.Size(595, 203);
            this.wpServer.Text = "2/3. Cấu Hình Cơ Sở Dữ Liệu Mới";
            this.wpServer.Click += new System.EventHandler(this.wpServer_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.chxDelete);
            this.panelControl3.Controls.Add(this.cbxDatabase);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.chxCreated);
            this.panelControl3.Location = new System.Drawing.Point(369, 7);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(218, 116);
            this.panelControl3.TabIndex = 75;
            // 
            // chxDelete
            // 
            this.chxDelete.EditValue = true;
            this.chxDelete.Location = new System.Drawing.Point(5, 59);
            this.chxDelete.Name = "chxDelete";
            this.chxDelete.Properties.Caption = "Xóa dữ liệu đã tồn tại";
            this.chxDelete.Size = new System.Drawing.Size(208, 19);
            this.chxDelete.TabIndex = 60;
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.Location = new System.Drawing.Point(7, 27);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDatabase.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxDatabase_Properties_ButtonClick);
            this.cbxDatabase.Size = new System.Drawing.Size(207, 20);
            this.cbxDatabase.TabIndex = 59;
            this.cbxDatabase.SelectedIndexChanged += new System.EventHandler(this.cbxDatabase_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "Cơ Sở Dữ Liệu";
            // 
            // chxCreated
            // 
            this.chxCreated.Location = new System.Drawing.Point(5, 85);
            this.chxCreated.Name = "chxCreated";
            this.chxCreated.Properties.Caption = "Tạo Cơ Sở Dữ Liệu Mới";
            this.chxCreated.Size = new System.Drawing.Size(208, 19);
            this.chxCreated.TabIndex = 0;
            this.chxCreated.CheckedChanged += new System.EventHandler(this.chxCreated_CheckedChanged);
            // 
            // plCreated
            // 
            this.plCreated.Controls.Add(this.BarCreated);
            this.plCreated.Controls.Add(this.txtDatabase);
            this.plCreated.Controls.Add(this.txtPath);
            this.plCreated.Controls.Add(this.lblDatabase);
            this.plCreated.Controls.Add(this.labelControl1);
            this.plCreated.Enabled = false;
            this.plCreated.Location = new System.Drawing.Point(8, 129);
            this.plCreated.Name = "plCreated";
            this.plCreated.Size = new System.Drawing.Size(579, 66);
            this.plCreated.TabIndex = 74;
            // 
            // BarCreated
            // 
            this.BarCreated.EditValue = 0;
            this.BarCreated.Location = new System.Drawing.Point(368, 13);
            this.BarCreated.Name = "BarCreated";
            this.BarCreated.Properties.AutoHeight = true;
            this.BarCreated.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.BarCreated.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.BarCreated.Properties.UseParentBackground = true;
            this.BarCreated.Size = new System.Drawing.Size(206, 12);
            this.BarCreated.TabIndex = 73;
            this.BarCreated.Visible = false;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(78, 11);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(267, 20);
            this.txtDatabase.TabIndex = 72;
            this.txtDatabase.EditValueChanged += new System.EventHandler(this.txtDatabase_EditValueChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(78, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "Browse", null, true)});
            this.txtPath.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPath_Properties_ButtonClick);
            this.txtPath.Size = new System.Drawing.Size(496, 20);
            this.txtPath.TabIndex = 69;
            this.txtPath.TabStop = false;
            this.txtPath.EditValueChanged += new System.EventHandler(this.txtPath_EditValueChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(9, 14);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(62, 13);
            this.lblDatabase.TabIndex = 71;
            this.lblDatabase.Text = "Cơ sở dữ liệu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Đường dẫn";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rdgAuthentication);
            this.panelControl1.Controls.Add(this.lblServer);
            this.panelControl1.Controls.Add(this.lblSqlusername);
            this.panelControl1.Controls.Add(this.lblSqlpassword);
            this.panelControl1.Controls.Add(this.cbxServer);
            this.panelControl1.Controls.Add(this.teLogin);
            this.panelControl1.Controls.Add(this.tePassword);
            this.panelControl1.Location = new System.Drawing.Point(8, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(355, 116);
            this.panelControl1.TabIndex = 73;
            // 
            // rdgAuthentication
            // 
            this.rdgAuthentication.AutoSizeInLayoutControl = true;
            this.rdgAuthentication.EditValue = 0;
            this.rdgAuthentication.Location = new System.Drawing.Point(78, 34);
            this.rdgAuthentication.Name = "rdgAuthentication";
            this.rdgAuthentication.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgAuthentication.Properties.Appearance.Options.UseBackColor = true;
            this.rdgAuthentication.Properties.Columns = 2;
            this.rdgAuthentication.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Tài Khoản Windows"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tài Khoản SQL Server")});
            this.rdgAuthentication.Size = new System.Drawing.Size(267, 25);
            this.rdgAuthentication.TabIndex = 63;
            this.rdgAuthentication.SelectedIndexChanged += new System.EventHandler(this.rdgAuthentication_SelectedIndexChanged);
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(9, 11);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(42, 13);
            this.lblServer.TabIndex = 62;
            this.lblServer.Text = "Máy Chủ";
            // 
            // lblSqlusername
            // 
            this.lblSqlusername.Location = new System.Drawing.Point(9, 67);
            this.lblSqlusername.Name = "lblSqlusername";
            this.lblSqlusername.Size = new System.Drawing.Size(47, 13);
            this.lblSqlusername.TabIndex = 66;
            this.lblSqlusername.Text = "Tài Khoản";
            // 
            // lblSqlpassword
            // 
            this.lblSqlpassword.Location = new System.Drawing.Point(9, 91);
            this.lblSqlpassword.Name = "lblSqlpassword";
            this.lblSqlpassword.Size = new System.Drawing.Size(45, 13);
            this.lblSqlpassword.TabIndex = 67;
            this.lblSqlpassword.Text = "Mật Khẩu";
            // 
            // cbxServer
            // 
            this.cbxServer.EditValue = "(Local)\\PERFECT";
            this.cbxServer.Location = new System.Drawing.Point(78, 8);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxServer.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxServer_Properties_ButtonClick);
            this.cbxServer.Size = new System.Drawing.Size(267, 20);
            superToolTip2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipItem2.Text = "Bạn có thể gõ trực tiếp hoặc chọn từ danh sách. <br>Chú ý: máy chủ mặc định là TÊ" +
                "NMÁYCHỦ\\PERFECT";
            superToolTip2.Items.Add(toolTipItem2);
            this.cbxServer.SuperTip = superToolTip2;
            this.cbxServer.TabIndex = 68;
            // 
            // teLogin
            // 
            this.teLogin.EditValue = "sa";
            this.teLogin.Enabled = false;
            this.teLogin.Location = new System.Drawing.Point(78, 64);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(267, 20);
            this.teLogin.TabIndex = 64;
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "perfect";
            this.tePassword.Enabled = false;
            this.tePassword.Location = new System.Drawing.Point(78, 88);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(267, 20);
            this.tePassword.TabIndex = 65;
            // 
            // wpOptions
            // 
            this.wpOptions.Controls.Add(this.chxOnly);
            this.wpOptions.Controls.Add(this.radioGroup1);
            this.wpOptions.Controls.Add(this.chxLocks);
            this.wpOptions.DescriptionText = "";
            this.wpOptions.Name = "wpOptions";
            this.wpOptions.Size = new System.Drawing.Size(595, 203);
            this.wpOptions.Text = "1/3. Tùy Chọn";
            // 
            // chxOnly
            // 
            this.chxOnly.Location = new System.Drawing.Point(22, 170);
            this.chxOnly.Name = "chxOnly";
            this.chxOnly.Properties.Caption = "Chỉ sao chép dữ liệu";
            this.chxOnly.Size = new System.Drawing.Size(561, 19);
            this.chxOnly.TabIndex = 57;
            this.chxOnly.Visible = false;
            this.chxOnly.CheckedChanged += new System.EventHandler(this.chxOnly_CheckedChanged);
            this.chxOnly.Click += new System.EventHandler(this.chxOnly_Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(65, 44);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Từ 3.0"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Từ 2.5-2.7", false),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Từ 2.0", false)});
            this.radioGroup1.Size = new System.Drawing.Size(518, 115);
            this.radioGroup1.TabIndex = 56;
            // 
            // chxLocks
            // 
            this.chxLocks.Location = new System.Drawing.Point(22, 19);
            this.chxLocks.Name = "chxLocks";
            this.chxLocks.Properties.Caption = "Kết Chuyển Số Dư Cuối Kỳ";
            this.chxLocks.Size = new System.Drawing.Size(561, 19);
            this.chxLocks.TabIndex = 55;
            this.chxLocks.Click += new System.EventHandler(this.chxLocks_Click);
            // 
            // wpLocks
            // 
            this.wpLocks.Controls.Add(this.lResult);
            this.wpLocks.Controls.Add(this.Bar2);
            this.wpLocks.Controls.Add(this.Bar);
            this.wpLocks.DescriptionText = "";
            this.wpLocks.Name = "wpLocks";
            this.wpLocks.Size = new System.Drawing.Size(595, 203);
            this.wpLocks.Text = "3/3. Thực Hiện Kết Chuyển.";
            // 
            // lResult
            // 
            this.lResult.Location = new System.Drawing.Point(2, 21);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(588, 158);
            this.lResult.TabIndex = 6;
            // 
            // Bar2
            // 
            this.Bar2.Location = new System.Drawing.Point(2, 183);
            this.Bar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bar2.Name = "Bar2";
            this.Bar2.Properties.ShowTitle = true;
            this.Bar2.Size = new System.Drawing.Size(588, 16);
            this.Bar2.TabIndex = 5;
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(2, 2);
            this.Bar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bar.Name = "Bar";
            this.Bar.Properties.ShowTitle = true;
            this.Bar.Size = new System.Drawing.Size(588, 16);
            this.Bar.TabIndex = 4;
            // 
            // wpFinish
            // 
            this.wpFinish.DescriptionText = "";
            this.wpFinish.Name = "wpFinish";
            this.wpFinish.Size = new System.Drawing.Size(595, 203);
            this.wpFinish.Text = "Kết Chuyển Thành Công";
            // 
            // xfmLocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 316);
            this.Controls.Add(this.wc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xfmLocks";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Chuyển";
            ((System.ComponentModel.ISupportInitialize)(this.wc)).EndInit();
            this.wc.ResumeLayout(false);
            this.wpServer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chxDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plCreated)).EndInit();
            this.plCreated.ResumeLayout(false);
            this.plCreated.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAuthentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            this.wpOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chxOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxLocks.Properties)).EndInit();
            this.wpLocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wc;
        private DevExpress.XtraWizard.WizardPage wpServer;
        private DevExpress.XtraEditors.ComboBoxEdit cbxServer;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.LabelControl lblSqlpassword;
        private DevExpress.XtraEditors.LabelControl lblSqlusername;
        private DevExpress.XtraEditors.RadioGroup rdgAuthentication;
        private DevExpress.XtraEditors.LabelControl lblServer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtPath;
        private DevExpress.XtraWizard.WizardPage wpOptions;
        private DevExpress.XtraEditors.CheckEdit chxLocks;
        private DevExpress.XtraWizard.WizardPage wpLocks;
        private DevExpress.XtraEditors.ProgressBarControl Bar2;
        private DevExpress.XtraEditors.ProgressBarControl Bar;
        private DevExpress.XtraEditors.ListBoxControl lResult;
        private DevExpress.XtraWizard.WizardPage wpFinish;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.LabelControl lblDatabase;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl plCreated;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.CheckEdit chxCreated;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chxDelete;
        private DevExpress.XtraEditors.MarqueeProgressBarControl BarCreated;
        private DevExpress.XtraEditors.CheckEdit chxOnly;
    }
}