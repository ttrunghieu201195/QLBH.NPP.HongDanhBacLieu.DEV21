namespace Perfect.ERP
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblNewpassword = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblCurrentpassword = new System.Windows.Forms.Label();
            this.txtLapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblConfirmpassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dsLayout = new Perfect.Security.Layout.dsLayout();
            this.controL_FormTableAdapter = new Perfect.Security.Layout.dsLayoutTableAdapters.CONTROL_FormTableAdapter();
            this.picLogin = new DevExpress.XtraEditors.PictureEdit();
            this.btLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.Navy;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(112, 75);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(229, 23);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi_KeyPress);
            // 
            // lblNewpassword
            // 
            this.lblNewpassword.AutoSize = true;
            this.lblNewpassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpassword.Location = new System.Drawing.Point(6, 76);
            this.lblNewpassword.Name = "lblNewpassword";
            this.lblNewpassword.Size = new System.Drawing.Size(71, 13);
            this.lblNewpassword.TabIndex = 65;
            this.lblNewpassword.Text = "Mật Khẩu Mới";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.Navy;
            this.txtMatKhauCu.Location = new System.Drawing.Point(112, 43);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(229, 23);
            this.txtMatKhauCu.TabIndex = 0;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauCu_KeyPress);
            // 
            // lblCurrentpassword
            // 
            this.lblCurrentpassword.AutoSize = true;
            this.lblCurrentpassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentpassword.Location = new System.Drawing.Point(6, 45);
            this.lblCurrentpassword.Name = "lblCurrentpassword";
            this.lblCurrentpassword.Size = new System.Drawing.Size(68, 13);
            this.lblCurrentpassword.TabIndex = 63;
            this.lblCurrentpassword.Text = "Mật Khẩu Cũ";
            // 
            // txtLapLaiMatKhauMoi
            // 
            this.txtLapLaiMatKhauMoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLapLaiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLapLaiMatKhauMoi.ForeColor = System.Drawing.Color.Navy;
            this.txtLapLaiMatKhauMoi.Location = new System.Drawing.Point(112, 106);
            this.txtLapLaiMatKhauMoi.Name = "txtLapLaiMatKhauMoi";
            this.txtLapLaiMatKhauMoi.PasswordChar = '*';
            this.txtLapLaiMatKhauMoi.Size = new System.Drawing.Size(229, 23);
            this.txtLapLaiMatKhauMoi.TabIndex = 2;
            this.txtLapLaiMatKhauMoi.UseSystemPasswordChar = true;
            this.txtLapLaiMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLapLaiMatKhauMoi_KeyPress);
            // 
            // lblConfirmpassword
            // 
            this.lblConfirmpassword.AutoSize = true;
            this.lblConfirmpassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmpassword.Location = new System.Drawing.Point(6, 110);
            this.lblConfirmpassword.Name = "lblConfirmpassword";
            this.lblConfirmpassword.Size = new System.Drawing.Size(96, 13);
            this.lblConfirmpassword.TabIndex = 67;
            this.lblConfirmpassword.Text = "Nhập Lại Mật Khẩu";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(123, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 16);
            this.lblTitle.TabIndex = 69;
            this.lblTitle.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // dsLayout
            // 
            this.dsLayout.DataSetName = "dsLayout";
            this.dsLayout.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controL_FormTableAdapter
            // 
            this.controL_FormTableAdapter.ClearBeforeFill = true;
            // 
            // picLogin
            // 
            this.picLogin.EditValue = ((object)(resources.GetObject("picLogin.EditValue")));
            this.picLogin.Location = new System.Drawing.Point(26, 5);
            this.picLogin.Name = "picLogin";
            this.picLogin.Properties.AllowFocused = false;
            this.picLogin.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.picLogin.Properties.Appearance.Options.UseBackColor = true;
            this.picLogin.Properties.Appearance.Options.UseForeColor = true;
            this.picLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogin.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.picLogin.Properties.ReadOnly = true;
            this.picLogin.Properties.ShowMenu = false;
            this.picLogin.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogin.Size = new System.Drawing.Size(32, 32);
            this.picLogin.TabIndex = 72;
            // 
            // btLogin
            // 
            this.btLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btLogin.Appearance.Options.UseFont = true;
            this.btLogin.Appearance.Options.UseForeColor = true;
            this.btLogin.Image = ((System.Drawing.Image)(resources.GetObject("btLogin.Image")));
            this.btLogin.Location = new System.Drawing.Point(112, 136);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(70, 27);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Đồng ý";
            this.btLogin.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btClose
            // 
            this.btClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Appearance.Options.UseFont = true;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(209, 136);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(70, 27);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "&Thoát";
            this.btClose.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(354, 175);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLapLaiMatKhauMoi);
            this.Controls.Add(this.lblConfirmpassword);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblNewpassword);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblCurrentpassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.dsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblNewpassword;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblCurrentpassword;
        private System.Windows.Forms.TextBox txtLapLaiMatKhauMoi;
        private System.Windows.Forms.Label lblConfirmpassword;
        private System.Windows.Forms.Label lblTitle;
        private Perfect.Security.Layout.dsLayout dsLayout;
        private Perfect.Security.Layout.dsLayoutTableAdapters.CONTROL_FormTableAdapter controL_FormTableAdapter;
        private DevExpress.XtraEditors.PictureEdit picLogin;
        private DevExpress.XtraEditors.SimpleButton btLogin;
        private DevExpress.XtraEditors.SimpleButton btClose;
    }
}