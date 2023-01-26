namespace Perfect.Security.Security.GroupUser.usercontrol
{
    partial class XucGroupUser
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XucGroupUser));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.dsGroup_User = new Perfect.Security.Security.GroupUser.DataSet.dsGroup_User();
            this.sYSUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bm1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddUser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.bbiPermision = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.pm1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.sYS_USERTableAdapter = new Perfect.Security.Security.GroupUser.DataSet.dsGroup_UserTableAdapters.SYS_USERTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPARENT_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcgroupuser = new DevExpress.XtraGrid.GridControl();
            this.gbgroupuser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcgroupuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbgroupuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsGroup_User
            // 
            this.dsGroup_User.DataSetName = "dsGroup_User";
            this.dsGroup_User.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sYSUSERBindingSource
            // 
            this.sYSUSERBindingSource.DataMember = "SYS_USER";
            this.sYSUSERBindingSource.DataSource = this.dsGroup_User;
            // 
            // bm1
            // 
            this.bm1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bm1.DockControls.Add(this.barDockControlTop);
            this.bm1.DockControls.Add(this.barDockControlBottom);
            this.bm1.DockControls.Add(this.barDockControlLeft);
            this.bm1.DockControls.Add(this.barDockControlRight);
            this.bm1.Form = this;
            this.bm1.Images = this.imageCollection2;
            this.bm1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiPermision,
            this.barButtonItem3,
            this.bbiClose,
            this.barButtonItem1,
            this.bbiAddUser});
            this.bm1.LargeImages = this.imageCollection2;
            this.bm1.MaxItemId = 15;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(47, 128);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiAddUser, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Công Cụ";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Thêm Vai Trò";
            this.bbiAdd.Id = 0;
            this.bbiAdd.ImageIndex = 69;
            this.bbiAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiAdd.LargeImageIndex = 69;
            this.bbiAdd.Name = "bbiAdd";
            toolTipItem1.Text = "Ctrl + N";
            superToolTip1.Items.Add(toolTipItem1);
            this.bbiAdd.SuperTip = superToolTip1;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiAddItemClick);
            // 
            // bbiAddUser
            // 
            this.bbiAddUser.Caption = "Thêm Người Dùng";
            this.bbiAddUser.Id = 14;
            this.bbiAddUser.ImageIndex = 69;
            this.bbiAddUser.LargeImageIndex = 69;
            this.bbiAddUser.Name = "bbiAddUser";
            this.bbiAddUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiAddUserItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Sửa";
            this.bbiEdit.Id = 1;
            this.bbiEdit.ImageIndex = 14;
            this.bbiEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.bbiEdit.Name = "bbiEdit";
            toolTipItem2.Text = "F2\r\nEnter";
            superToolTip2.Items.Add(toolTipItem2);
            this.bbiEdit.SuperTip = superToolTip2;
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiEditItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 2;
            this.bbiDelete.ImageIndex = 13;
            this.bbiDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.bbiDelete.Name = "bbiDelete";
            toolTipItem3.Text = "Ctrl +Delete";
            superToolTip3.Items.Add(toolTipItem3);
            this.bbiDelete.SuperTip = superToolTip3;
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiDeleteItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Đóng";
            this.bbiClose.Id = 10;
            this.bbiClose.ImageIndex = 22;
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BbiCloseItemClick);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(61, "Vista (35).ico");
            this.imageCollection2.Images.SetKeyName(62, "Security.ico");
            this.imageCollection2.Images.SetKeyName(63, "RibbonPrintPreview_DocumentMapLarge.png");
            this.imageCollection2.Images.SetKeyName(64, "11.png");
            this.imageCollection2.Images.SetKeyName(65, "Sua.png");
            this.imageCollection2.Images.SetKeyName(66, "Them.png");
            this.imageCollection2.Images.SetKeyName(67, "PhanQuyen.png");
            this.imageCollection2.Images.SetKeyName(68, "11.png");
            this.imageCollection2.Images.SetKeyName(69, "plus.png");
            // 
            // bbiPermision
            // 
            this.bbiPermision.Caption = "Phân Quyền";
            this.bbiPermision.Id = 3;
            this.bbiPermision.Name = "bbiPermision";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // pm1
            // 
            this.pm1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiClose)});
            this.pm1.Manager = this.bm1;
            this.pm1.Name = "pm1";
            // 
            // sYS_USERTableAdapter
            // 
            this.sYS_USERTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colID,
            this.colDescName,
            this.colPARENT_ID});
            this.treeList1.DataSource = this.sYSUSERBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList1.ImageIndexFieldName = "DescName";
            this.treeList1.Location = new System.Drawing.Point(0, 26);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsSelection.InvertSelection = true;
            this.treeList1.OptionsSelection.MultiSelect = true;
            this.treeList1.ParentFieldName = "PARENT_ID";
            this.treeList1.Size = new System.Drawing.Size(191, 481);
            this.treeList1.TabIndex = 6;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.TreeList1FocusedNodeChanged1);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colDescName
            // 
            this.colDescName.Caption = "Vai Trò Và Người Dùng";
            this.colDescName.FieldName = "DescName";
            this.colDescName.MinWidth = 38;
            this.colDescName.Name = "colDescName";
            this.colDescName.Visible = true;
            this.colDescName.VisibleIndex = 0;
            // 
            // colPARENT_ID
            // 
            this.colPARENT_ID.FieldName = "PARENT_ID";
            this.colPARENT_ID.Name = "colPARENT_ID";
            // 
            // gcgroupuser
            // 
            this.gcgroupuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcgroupuser.Location = new System.Drawing.Point(191, 26);
            this.gcgroupuser.MainView = this.gbgroupuser;
            this.gcgroupuser.Name = "gcgroupuser";
            this.gcgroupuser.Size = new System.Drawing.Size(809, 248);
            this.gcgroupuser.TabIndex = 11;
            this.gcgroupuser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbgroupuser});
            // 
            // gbgroupuser
            // 
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            this.gbgroupuser.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gbgroupuser.GridControl = this.gcgroupuser;
            this.gbgroupuser.Name = "gbgroupuser";
            this.gbgroupuser.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gbgroupuser.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gbgroupuser.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(191, 274);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(809, 233);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Bảng Phân Quyền";
            // 
            // XucGroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcgroupuser);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XucGroupUser";
            this.Size = new System.Drawing.Size(1000, 507);
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcgroupuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbgroupuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager bm1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiPermision;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        public DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraBars.PopupMenu pm1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.BindingSource sYSUSERBindingSource;
        private Perfect.Security.Security.GroupUser.DataSet.dsGroup_User dsGroup_User;
        private Perfect.Security.Security.GroupUser.DataSet.dsGroup_UserTableAdapters.SYS_USERTableAdapter sYS_USERTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPARENT_ID;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcgroupuser;
        private DevExpress.XtraGrid.Views.Grid.GridView gbgroupuser;
        private DevExpress.XtraBars.BarButtonItem bbiAddUser;
    }
}
