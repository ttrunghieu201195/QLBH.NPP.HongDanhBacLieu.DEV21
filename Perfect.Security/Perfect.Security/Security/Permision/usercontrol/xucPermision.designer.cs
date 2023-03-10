namespace Perfect.Security
{
    partial class xucPermision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xucPermision));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.tlPermision = new DevExpress.XtraTreeList.TreeList();
            this.colObject_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colActive = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowAccess = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowAdd = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowEdit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowPrint = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowImport = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowExport = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.permisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPermision = new Perfect.Security.Security.Permision.dsPermision();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.permisionTableAdapter = new Perfect.Security.Security.Permision.dsPermisionTableAdapters.PermisionTableAdapter();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnCollapseAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpandAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExpand = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSimple = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHelp = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.tlPermision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPermision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPermision
            // 
            this.tlPermision.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colObject_Name,
            this.colActive,
            this.colAllowAccess,
            this.colAllowAdd,
            this.colAllowEdit,
            this.colAllowDelete,
            this.colAllowPrint,
            this.colAllowImport,
            this.colAllowExport});
            this.tlPermision.DataSource = this.permisionBindingSource;
            this.tlPermision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPermision.ImageIndexFieldName = "41";
            this.tlPermision.KeyFieldName = "Object_ID";
            this.tlPermision.Location = new System.Drawing.Point(2, 2);
            this.tlPermision.Name = "tlPermision";
            this.tlPermision.OptionsPrint.PrintFilledTreeIndent = true;
            this.tlPermision.OptionsPrint.PrintPreview = true;
            this.tlPermision.OptionsPrint.PrintReportFooter = false;
            this.tlPermision.ParentFieldName = "Parent_ID";
            this.tlPermision.PreviewFieldName = "Parent_ID";
            this.tlPermision.Size = new System.Drawing.Size(607, 532);
            this.tlPermision.TabIndex = 0;
            this.tlPermision.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tlPermision_CellValueChanging);
            this.tlPermision.DoubleClick += new System.EventHandler(this.tlPermision_DoubleClick);
            // 
            // colObject_Name
            // 
            this.colObject_Name.Caption = "Chức năng";
            this.colObject_Name.FieldName = "Object_Name";
            this.colObject_Name.MinWidth = 35;
            this.colObject_Name.Name = "colObject_Name";
            this.colObject_Name.OptionsColumn.AllowEdit = false;
            this.colObject_Name.OptionsColumn.ReadOnly = true;
            this.colObject_Name.Visible = true;
            this.colObject_Name.VisibleIndex = 0;
            this.colObject_Name.Width = 197;
            // 
            // colActive
            // 
            this.colActive.AppearanceCell.Options.UseTextOptions = true;
            this.colActive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Tất cả";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.FixedWidth = true;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 1;
            this.colActive.Width = 60;
            // 
            // colAllowAccess
            // 
            this.colAllowAccess.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowAccess.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowAccess.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowAccess.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowAccess.Caption = "Truy cập";
            this.colAllowAccess.FieldName = "AllowAccess";
            this.colAllowAccess.Name = "colAllowAccess";
            this.colAllowAccess.OptionsColumn.FixedWidth = true;
            this.colAllowAccess.Visible = true;
            this.colAllowAccess.VisibleIndex = 2;
            this.colAllowAccess.Width = 60;
            // 
            // colAllowAdd
            // 
            this.colAllowAdd.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowAdd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowAdd.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowAdd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowAdd.Caption = "Thêm";
            this.colAllowAdd.FieldName = "AllowAdd";
            this.colAllowAdd.Name = "colAllowAdd";
            this.colAllowAdd.OptionsColumn.FixedWidth = true;
            this.colAllowAdd.Visible = true;
            this.colAllowAdd.VisibleIndex = 3;
            this.colAllowAdd.Width = 60;
            // 
            // colAllowEdit
            // 
            this.colAllowEdit.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowEdit.Caption = "Sửa";
            this.colAllowEdit.FieldName = "AllowEdit";
            this.colAllowEdit.Name = "colAllowEdit";
            this.colAllowEdit.OptionsColumn.FixedWidth = true;
            this.colAllowEdit.Visible = true;
            this.colAllowEdit.VisibleIndex = 4;
            this.colAllowEdit.Width = 60;
            // 
            // colAllowDelete
            // 
            this.colAllowDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowDelete.Caption = "Xoá";
            this.colAllowDelete.FieldName = "AllowDelete";
            this.colAllowDelete.Name = "colAllowDelete";
            this.colAllowDelete.OptionsColumn.FixedWidth = true;
            this.colAllowDelete.Visible = true;
            this.colAllowDelete.VisibleIndex = 5;
            this.colAllowDelete.Width = 60;
            // 
            // colAllowPrint
            // 
            this.colAllowPrint.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowPrint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowPrint.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowPrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowPrint.Caption = "In";
            this.colAllowPrint.FieldName = "AllowPrint";
            this.colAllowPrint.Name = "colAllowPrint";
            this.colAllowPrint.OptionsColumn.FixedWidth = true;
            this.colAllowPrint.Visible = true;
            this.colAllowPrint.VisibleIndex = 6;
            this.colAllowPrint.Width = 60;
            // 
            // colAllowImport
            // 
            this.colAllowImport.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowImport.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowImport.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowImport.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowImport.Caption = "Nhập";
            this.colAllowImport.FieldName = "AllowImport";
            this.colAllowImport.Name = "colAllowImport";
            this.colAllowImport.OptionsColumn.FixedWidth = true;
            this.colAllowImport.Visible = true;
            this.colAllowImport.VisibleIndex = 7;
            this.colAllowImport.Width = 60;
            // 
            // colAllowExport
            // 
            this.colAllowExport.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowExport.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowExport.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowExport.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowExport.Caption = "Xuất";
            this.colAllowExport.FieldName = "AllowExport";
            this.colAllowExport.Name = "colAllowExport";
            this.colAllowExport.OptionsColumn.FixedWidth = true;
            this.colAllowExport.Visible = true;
            this.colAllowExport.VisibleIndex = 8;
            this.colAllowExport.Width = 60;
            // 
            // permisionBindingSource
            // 
            this.permisionBindingSource.DataMember = "Permision";
            this.permisionBindingSource.DataSource = this.dsPermision;
            // 
            // dsPermision
            // 
            this.dsPermision.DataSetName = "dsPermision";
            this.dsPermision.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(41, "label-red.ico");
            this.imageCollection2.Images.SetKeyName(42, "label-green.ico");
            this.imageCollection2.Images.SetKeyName(43, "Run.ico");
            this.imageCollection2.Images.SetKeyName(44, "nav-up.ico");
            this.imageCollection2.Images.SetKeyName(45, "reload.ico");
            this.imageCollection2.Images.SetKeyName(46, "nav-add.ico");
            this.imageCollection2.Images.SetKeyName(47, "nav-down.ico");
            this.imageCollection2.Images.SetKeyName(48, "nav-left.ico");
            this.imageCollection2.Images.SetKeyName(49, "nav-right.ico");
            // 
            // permisionTableAdapter
            // 
            this.permisionTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnCollapseAll);
            this.panelControl4.Controls.Add(this.btnExpandAll);
            this.panelControl4.Controls.Add(this.btnClose);
            this.panelControl4.Controls.Add(this.btnSave);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 536);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(611, 35);
            this.panelControl4.TabIndex = 19;
            this.panelControl4.Visible = false;
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.ImageIndex = 39;
            this.btnCollapseAll.ImageList = this.imageCollection2;
            this.btnCollapseAll.Location = new System.Drawing.Point(93, 3);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(85, 28);
            toolTipItem1.Text = "F2\r\nCtrl+S\r\nCtrl+W";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnCollapseAll.SuperTip = superToolTip1;
            this.btnCollapseAll.TabIndex = 16;
            this.btnCollapseAll.Text = "Thu hẹp";
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.ImageIndex = 40;
            this.btnExpandAll.ImageList = this.imageCollection2;
            this.btnExpandAll.Location = new System.Drawing.Point(5, 3);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(84, 28);
            toolTipItem2.Text = "F2\r\nCtrl+S\r\nCtrl+W";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnExpandAll.SuperTip = superToolTip2;
            this.btnExpandAll.TabIndex = 15;
            this.btnExpandAll.Text = "Mở rộng";
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageIndex = 32;
            this.btnClose.ImageList = this.imageCollection2;
            this.btnClose.Location = new System.Drawing.Point(269, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            toolTipItem3.Text = "Alt+X\r\nF10";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnClose.SuperTip = superToolTip3;
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageCollection2;
            this.btnSave.Location = new System.Drawing.Point(182, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 28);
            toolTipItem4.Text = "F2\r\nCtrl+S\r\nCtrl+W";
            superToolTip4.Items.Add(toolTipItem4);
            this.btnSave.SuperTip = superToolTip4;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tlPermision);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(611, 536);
            this.panelControl1.TabIndex = 20;
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExpand, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSimple),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHelp, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose, true)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Nạp";
            this.bbiRefresh.Id = 4;
            this.bbiRefresh.ImageIndex = 45;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Lưu";
            this.bbiSave.Id = 12;
            this.bbiSave.ImageIndex = 1;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiExpand
            // 
            this.bbiExpand.Caption = "Mở Rộng";
            this.bbiExpand.Id = 13;
            this.bbiExpand.ImageIndex = 47;
            this.bbiExpand.Name = "bbiExpand";
            this.bbiExpand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExpand_ItemClick);
            // 
            // bbiSimple
            // 
            this.bbiSimple.Caption = "Thu Hẹp";
            this.bbiSimple.Id = 14;
            this.bbiSimple.ImageIndex = 48;
            this.bbiSimple.Name = "bbiSimple";
            this.bbiSimple.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSimple_ItemClick);
            // 
            // bbiHelp
            // 
            this.bbiHelp.Caption = "Trợ Giúp";
            this.bbiHelp.Id = 6;
            this.bbiHelp.ImageIndex = 16;
            this.bbiHelp.Name = "bbiHelp";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Đóng";
            this.bbiClose.Id = 10;
            this.bbiClose.ImageIndex = 13;
            this.bbiClose.LargeImageIndex = 1;
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bm
            // 
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.imageCollection2;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiPrint,
            this.bbiRefresh,
            this.bbiExport,
            this.bbiHelp,
            this.bbiClose,
            this.bbiSave,
            this.bbiExpand,
            this.bbiSimple});
            this.bm.MaxItemId = 15;
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "In";
            this.bbiPrint.Id = 3;
            this.bbiPrint.ImageIndex = 9;
            this.bbiPrint.Name = "bbiPrint";
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Xuất";
            this.bbiExport.Id = 5;
            this.bbiExport.ImageIndex = 17;
            this.bbiExport.LargeImageIndex = 19;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // xucPermision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.Name = "xucPermision";
            this.Size = new System.Drawing.Size(611, 571);
            ((System.ComponentModel.ISupportInitialize)(this.tlPermision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPermision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlPermision;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colObject_Name;
        //private ERPDataSet eRPDataSet1;
        //private Perfect.Security.ERPDataSetTableAdapters.PermisionTableAdapter permisionTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowAccess;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowDelete;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowPrint;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowImport;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowExport;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colActive;
        private System.Windows.Forms.BindingSource permisionBindingSource;
        private Perfect.Security.Security.Permision.dsPermision dsPermision;
        private Perfect.Security.Security.Permision.dsPermisionTableAdapters.PermisionTableAdapter permisionTableAdapter;
        protected DevExpress.XtraEditors.PanelControl panelControl4;
        protected DevExpress.XtraEditors.SimpleButton btnClose;
        protected DevExpress.Utils.ImageCollection imageCollection2;
        protected DevExpress.XtraEditors.SimpleButton btnSave;
        protected DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        protected DevExpress.XtraEditors.SimpleButton btnExpandAll;
        protected DevExpress.XtraEditors.SimpleButton btnCollapseAll;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        protected DevExpress.XtraBars.PopupMenu pm;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiHelp;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        protected DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExpand;
        private DevExpress.XtraBars.BarButtonItem bbiSimple;
    }
}
