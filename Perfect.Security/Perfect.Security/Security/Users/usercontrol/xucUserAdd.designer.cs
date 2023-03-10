namespace Perfect.Security
{
    partial class xucUserAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucUserAdd));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblRoles = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblConfirm = new DevExpress.XtraEditors.LabelControl();
            this.txtRepassword = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.chxUse = new DevExpress.XtraEditors.CheckEdit();
            this.sYSGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGroup = new Perfect.Security.Security.Group.DataSet.dsGroup();
            this.SYS_GROUPAdapter = new Perfect.Security.Security.Group.DataSet.dsGroupTableAdapters.SYS_GROUPTableAdapter();
            this.cbxGroup = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroup_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.sYSUSERGetEmpListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmpList = new Perfect.Security.Security.Users.ds.dsEmpList();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sYS_USER_GetEmpListTableAdapter = new Perfect.Security.Security.Users.ds.dsEmpListTableAdapters.SYS_USER_GetEmpListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSUSERGetEmpListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcInfo
            // 
            this.gcInfo.Controls.Add(this.labelControl1);
            this.gcInfo.Controls.Add(this.cbxGroup);
            this.gcInfo.Controls.Add(this.chxUse);
            this.gcInfo.Controls.Add(this.lblDescription);
            this.gcInfo.Controls.Add(this.txtDescription);
            this.gcInfo.Controls.Add(this.lblConfirm);
            this.gcInfo.Controls.Add(this.txtRepassword);
            this.gcInfo.Controls.Add(this.lblRoles);
            this.gcInfo.Controls.Add(this.lblPassword);
            this.gcInfo.Controls.Add(this.txtPassword);
            this.gcInfo.Controls.Add(this.txtEmp);
            this.gcInfo.Size = new System.Drawing.Size(320, 214);
            this.gcInfo.Controls.SetChildIndex(this.txtEmp, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtPassword, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblPassword, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblRoles, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblName, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtNAME, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblId, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtID, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtRepassword, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblConfirm, 0);
            this.gcInfo.Controls.SetChildIndex(this.txtDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.lblDescription, 0);
            this.gcInfo.Controls.SetChildIndex(this.chxUse, 0);
            this.gcInfo.Controls.SetChildIndex(this.cbxGroup, 0);
            this.gcInfo.Controls.SetChildIndex(this.labelControl1, 0);
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(64, 56);
            this.txtNAME.Size = new System.Drawing.Size(247, 20);
            this.txtNAME.EditValueChanged += new System.EventHandler(this.txtNAME_EditValueChanged);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(5, 59);
            this.lblName.Size = new System.Drawing.Size(46, 13);
            this.lblName.Text = "Tài khoản";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(166, 185);
            this.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtID.Properties.Appearance.Options.UseForeColor = true;
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.Visible = false;
            // 
            // lblId
            // 
            this.lblId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblId.Appearance.Options.UseForeColor = true;
            this.lblId.Location = new System.Drawing.Point(7, 8);
            this.lblId.Visible = false;
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 221);
            this.btnSave.Size = new System.Drawing.Size(94, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 222);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(128, 221);
            this.btnSaveNew.Size = new System.Drawing.Size(90, 27);
            // 
            // lblRoles
            // 
            this.lblRoles.Location = new System.Drawing.Point(5, 138);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(31, 13);
            this.lblRoles.TabIndex = 5;
            this.lblRoles.Text = "Vai trò";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(5, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(64, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(247, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Location = new System.Drawing.Point(5, 111);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(44, 13);
            this.lblConfirm.TabIndex = 9;
            this.lblConfirm.Text = "Xác nhận";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(64, 108);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Properties.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(247, 20);
            this.txtRepassword.TabIndex = 10;
            this.txtRepassword.Click += new System.EventHandler(this.txtRepassword_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(64, 159);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(247, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(5, 163);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(40, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Diễn giải";
            // 
            // chxUse
            // 
            this.chxUse.EditValue = true;
            this.chxUse.Location = new System.Drawing.Point(62, 186);
            this.chxUse.Name = "chxUse";
            this.chxUse.Properties.Caption = "Còn quản lý";
            this.chxUse.Size = new System.Drawing.Size(98, 19);
            this.chxUse.TabIndex = 13;
            // 
            // sYSGROUPBindingSource
            // 
            this.sYSGROUPBindingSource.DataMember = "SYS_GROUP";
            this.sYSGROUPBindingSource.DataSource = this.dsGroup;
            // 
            // dsGroup
            // 
            this.dsGroup.DataSetName = "dsGroup";
            this.dsGroup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SYS_GROUPAdapter
            // 
            this.SYS_GROUPAdapter.ClearBeforeFill = true;
            // 
            // cbxGroup
            // 
            this.cbxGroup.Location = new System.Drawing.Point(64, 133);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Properties.ActionButtonIndex = 1;
            this.cbxGroup.Properties.AutoComplete = false;
            this.cbxGroup.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbxGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Thêm", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "Add", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGroup.Properties.DataSource = this.sYSGROUPBindingSource;
            this.cbxGroup.Properties.DisplayMember = "Group_Name";
            this.cbxGroup.Properties.NullText = "";
            this.cbxGroup.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cbxGroup.Properties.ValueMember = "Group_ID";
            this.cbxGroup.Properties.View = this.gridLookUpEdit1View;
            this.cbxGroup.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxGroup_Properties_ButtonClick);
            this.cbxGroup.Size = new System.Drawing.Size(247, 20);
            this.cbxGroup.TabIndex = 15;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroup_ID,
            this.colGroup_Name});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colGroup_ID
            // 
            this.colGroup_ID.Caption = "Mã";
            this.colGroup_ID.FieldName = "Group_ID";
            this.colGroup_ID.Name = "colGroup_ID";
            this.colGroup_ID.OptionsColumn.FixedWidth = true;
            this.colGroup_ID.Visible = true;
            this.colGroup_ID.VisibleIndex = 0;
            this.colGroup_ID.Width = 100;
            // 
            // colGroup_Name
            // 
            this.colGroup_Name.Caption = "Vai Trò";
            this.colGroup_Name.FieldName = "Group_Name";
            this.colGroup_Name.Name = "colGroup_Name";
            this.colGroup_Name.OptionsColumn.FixedWidth = true;
            this.colGroup_Name.Visible = true;
            this.colGroup_Name.VisibleIndex = 1;
            this.colGroup_Name.Width = 200;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Nhân viên";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(64, 30);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEmp.Properties.DataSource = this.sYSUSERGetEmpListBindingSource;
            this.txtEmp.Properties.DisplayMember = "Employee_Name";
            this.txtEmp.Properties.NullText = "";
            this.txtEmp.Properties.ValueMember = "Employee_ID";
            this.txtEmp.Properties.View = this.gridView1;
            this.txtEmp.Size = new System.Drawing.Size(247, 20);
            this.txtEmp.TabIndex = 16;
            this.txtEmp.TabStop = false;
            this.txtEmp.EditValueChanged += new System.EventHandler(this.txtEmp_EditValueChanged);
            // 
            // sYSUSERGetEmpListBindingSource
            // 
            this.sYSUSERGetEmpListBindingSource.DataMember = "SYS_USER_GetEmpList";
            this.sYSUSERGetEmpListBindingSource.DataSource = this.dsEmpList;
            // 
            // dsEmpList
            // 
            this.dsEmpList.DataSetName = "dsEmpList";
            this.dsEmpList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployee_ID,
            this.colEmployee_Name,
            this.colDepartment_Name});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployee_ID
            // 
            this.colEmployee_ID.Caption = "Mã NV";
            this.colEmployee_ID.FieldName = "Employee_ID";
            this.colEmployee_ID.Name = "colEmployee_ID";
            this.colEmployee_ID.OptionsColumn.AllowEdit = false;
            this.colEmployee_ID.OptionsColumn.ReadOnly = true;
            this.colEmployee_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_ID.Visible = true;
            this.colEmployee_ID.VisibleIndex = 0;
            // 
            // colEmployee_Name
            // 
            this.colEmployee_Name.Caption = "Họ & Tên";
            this.colEmployee_Name.FieldName = "Employee_Name";
            this.colEmployee_Name.Name = "colEmployee_Name";
            this.colEmployee_Name.OptionsColumn.AllowEdit = false;
            this.colEmployee_Name.OptionsColumn.ReadOnly = true;
            this.colEmployee_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmployee_Name.Visible = true;
            this.colEmployee_Name.VisibleIndex = 1;
            // 
            // colDepartment_Name
            // 
            this.colDepartment_Name.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.colDepartment_Name.AppearanceCell.Options.UseBackColor = true;
            this.colDepartment_Name.AppearanceHeader.BackColor2 = System.Drawing.Color.PapayaWhip;
            this.colDepartment_Name.Caption = "Bộ Phận";
            this.colDepartment_Name.FieldName = "Department_Name";
            this.colDepartment_Name.Name = "colDepartment_Name";
            this.colDepartment_Name.OptionsColumn.AllowEdit = false;
            this.colDepartment_Name.OptionsColumn.ReadOnly = true;
            this.colDepartment_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDepartment_Name.Visible = true;
            this.colDepartment_Name.VisibleIndex = 2;
            // 
            // sYS_USER_GetEmpListTableAdapter
            // 
            this.sYS_USER_GetEmpListTableAdapter.ClearBeforeFill = true;
            // 
            // xucUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "xucUserAdd";
            this.Size = new System.Drawing.Size(322, 261);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSUSERGetEmpListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblRoles;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblConfirm;
        private DevExpress.XtraEditors.TextEdit txtRepassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.CheckEdit chxUse;
        private System.Windows.Forms.BindingSource sYSGROUPBindingSource;
        private Security.Group.DataSet.dsGroup dsGroup;
        private Security.Group.DataSet.dsGroupTableAdapters.SYS_GROUPTableAdapter SYS_GROUPAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cbxGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup_Name;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit txtEmp;
        private System.Windows.Forms.BindingSource sYSUSERGetEmpListBindingSource;
        private Perfect.Security.Security.Users.ds.dsEmpList dsEmpList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Perfect.Security.Security.Users.ds.dsEmpListTableAdapters.SYS_USER_GetEmpListTableAdapter sYS_USER_GetEmpListTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment_Name;
    }
}
