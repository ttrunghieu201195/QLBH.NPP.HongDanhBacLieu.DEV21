namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    partial class XfmOutward
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmOutward));
            this.image = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dplOutward = new DevExpress.XtraBars.Docking.DockPanel();
            this.dplcMain = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvOutward = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgOutward = new DevExpress.XtraNavBar.NavBarGroup();
            this.niOutward = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgOutwardList = new DevExpress.XtraNavBar.NavBarGroup();
            this.niOutwardList = new DevExpress.XtraNavBar.NavBarItem();
            this.niOutwardDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgDictionary = new DevExpress.XtraNavBar.NavBarGroup();
            this.niProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.niCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.niStock = new DevExpress.XtraNavBar.NavBarItem();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.iNVOICESTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSTOCK_OUTWARD_DETAIL = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAIL();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpCal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colColorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iNVOICE_STATUSTableAdapter = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.INVOICE_STATUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dplOutward.SuspendLayout();
            this.dplcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvOutward)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICESTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCal)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.ImageSize = new System.Drawing.Size(32, 32);
            this.image.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("image.ImageStream")));
            this.image.Images.SetKeyName(0, "BO_Address_32x32.png");
            this.image.Images.SetKeyName(1, "BO_Contract_32x32.png");
            this.image.Images.SetKeyName(2, "1318304498_list.png");
            this.image.Images.SetKeyName(3, "1318306141_customers.png");
            this.image.Images.SetKeyName(4, "1318319147_Download_Crate.png");
            this.image.Images.SetKeyName(5, "Localization.png");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.plMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(171, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(723, 706);
            this.panelControl1.TabIndex = 2;
            // 
            // plMain
            // 
            this.plMain.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.plMain.AppearanceCaption.Options.UseForeColor = true;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(2, 2);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(719, 702);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            // 
            // dm
            // 
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.dplOutward);
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.ID = new System.Guid("cdfa15f4-552d-4f0a-81a9-70f02baea621");
            this.panelContainer1.Location = new System.Drawing.Point(0, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(171, 200);
            this.panelContainer1.Size = new System.Drawing.Size(171, 706);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dplOutward
            // 
            this.dplOutward.Controls.Add(this.dplcMain);
            this.dplOutward.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dplOutward.ID = new System.Guid("f2631645-0ef5-44c5-a57c-f1293fc924d4");
            this.dplOutward.Location = new System.Drawing.Point(0, 0);
            this.dplOutward.Name = "dplOutward";
            this.dplOutward.OriginalSize = new System.Drawing.Size(171, 503);
            this.dplOutward.Size = new System.Drawing.Size(171, 455);
            this.dplOutward.Text = "Chức Năng";
            this.dplOutward.Click += new System.EventHandler(this.dplOutward_Click);
            // 
            // dplcMain
            // 
            this.dplcMain.Controls.Add(this.nvOutward);
            this.dplcMain.Location = new System.Drawing.Point(3, 25);
            this.dplcMain.Name = "dplcMain";
            this.dplcMain.Size = new System.Drawing.Size(165, 427);
            this.dplcMain.TabIndex = 0;
            // 
            // nvOutward
            // 
            this.nvOutward.ActiveGroup = this.nvgOutward;
            this.nvOutward.ContentButtonHint = null;
            this.nvOutward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvOutward.EachGroupHasSelectedLink = true;
            this.nvOutward.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvgOutward,
            this.nvgOutwardList,
            this.nvgDictionary});
            this.nvOutward.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niOutward,
            this.niOutwardList,
            this.niOutwardDetailList,
            this.niProduct,
            this.niCustomer,
            this.niStock,
            this.navBarItem1});
            this.nvOutward.LargeImages = this.image;
            this.nvOutward.Location = new System.Drawing.Point(0, 0);
            this.nvOutward.Name = "nvOutward";
            this.nvOutward.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.nvOutward.OptionsNavPane.ExpandedWidth = 205;
            this.nvOutward.Size = new System.Drawing.Size(165, 427);
            this.nvOutward.SmallImages = this.image;
            this.nvOutward.TabIndex = 0;
            this.nvOutward.Text = "navBarControl1";
            this.nvOutward.Click += new System.EventHandler(this.nvOutward_Click);
            // 
            // nvgOutward
            // 
            this.nvgOutward.Caption = "Bán Hàng";
            this.nvgOutward.Expanded = true;
            this.nvgOutward.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgOutward.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niOutward)});
            this.nvgOutward.Name = "nvgOutward";
            // 
            // niOutward
            // 
            this.niOutward.Caption = "Phiếu Bán Hàng";
            this.niOutward.LargeImageIndex = 1;
            this.niOutward.Name = "niOutward";
            this.niOutward.SmallImageIndex = 1;
            this.niOutward.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiOutwardLinkClicked);
            // 
            // nvgOutwardList
            // 
            this.nvgOutwardList.Caption = "Bảng Kê";
            this.nvgOutwardList.Expanded = true;
            this.nvgOutwardList.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgOutwardList.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niOutwardList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niOutwardDetailList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.nvgOutwardList.Name = "nvgOutwardList";
            // 
            // niOutwardList
            // 
            this.niOutwardList.Caption = "Theo Chứng Từ";
            this.niOutwardList.LargeImageIndex = 2;
            this.niOutwardList.Name = "niOutwardList";
            this.niOutwardList.SmallImageIndex = 2;
            this.niOutwardList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiOutwardListLinkClicked);
            // 
            // niOutwardDetailList
            // 
            this.niOutwardDetailList.Caption = "Theo Hàng Hoá";
            this.niOutwardDetailList.LargeImageIndex = 2;
            this.niOutwardDetailList.Name = "niOutwardDetailList";
            this.niOutwardDetailList.SmallImageIndex = 2;
            this.niOutwardDetailList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiOutwardDetailListLinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Sản Lượng Theo Tuyến";
            this.navBarItem1.LargeImageIndex = 5;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 5;
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // nvgDictionary
            // 
            this.nvgDictionary.Caption = "Thêm Danh Mục";
            this.nvgDictionary.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgDictionary.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niStock)});
            this.nvgDictionary.Name = "nvgDictionary";
            this.nvgDictionary.Visible = false;
            // 
            // niProduct
            // 
            this.niProduct.Caption = "Hàng Hoá";
            this.niProduct.LargeImageIndex = 4;
            this.niProduct.Name = "niProduct";
            this.niProduct.SmallImageIndex = 4;
            this.niProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiProductLinkClicked);
            // 
            // niCustomer
            // 
            this.niCustomer.Caption = "Khách Hàng";
            this.niCustomer.LargeImageIndex = 3;
            this.niCustomer.Name = "niCustomer";
            this.niCustomer.SmallImageIndex = 3;
            this.niCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiCustomerLinkClicked);
            // 
            // niStock
            // 
            this.niStock.Caption = "Kho Hàng";
            this.niStock.LargeImageIndex = 0;
            this.niStock.Name = "niStock";
            this.niStock.SmallImageIndex = 0;
            this.niStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiStockLinkClicked);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("a599ebc8-86df-4e32-ac35-e04702e8e9d0");
            this.dockPanel1.Location = new System.Drawing.Point(0, 455);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(171, 203);
            this.dockPanel1.Size = new System.Drawing.Size(171, 251);
            this.dockPanel1.Text = "Thống kê";
            this.dockPanel1.Click += new System.EventHandler(this.dockPanel1_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gcList);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(165, 223);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.iNVOICESTATUSBindingSource;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpCal});
            this.gcList.Size = new System.Drawing.Size(165, 223);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            this.gcList.Click += new System.EventHandler(this.gcList_Click);
            // 
            // iNVOICESTATUSBindingSource
            // 
            this.iNVOICESTATUSBindingSource.DataMember = "INVOICE_STATUS";
            this.iNVOICESTATUSBindingSource.DataSource = this.dsSTOCK_OUTWARD_DETAIL;
            // 
            // dsSTOCK_OUTWARD_DETAIL
            // 
            this.dsSTOCK_OUTWARD_DETAIL.DataSetName = "dsSTOCK_OUTWARD_DETAIL";
            this.dsSTOCK_OUTWARD_DETAIL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity,
            this.colColorName,
            this.colName});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.Click += new System.EventHandler(this.gvList_Click);
            this.gvList.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvList_RowCellStyle);
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.BackColor = System.Drawing.Color.Azure;
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceCell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.colQuantity.AppearanceCell.Options.UseBackColor = true;
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceCell.Options.UseForeColor = true;
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.rpCal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 73;
            // 
            // rpCal
            // 
            this.rpCal.AutoHeight = false;
            this.rpCal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpCal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rpCal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpCal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rpCal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpCal.Name = "rpCal";
            // 
            // colColorName
            // 
            this.colColorName.FieldName = "ColorName";
            this.colColorName.Name = "colColorName";
            // 
            // colName
            // 
            this.colName.Caption = "Trạng thái";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // iNVOICE_STATUSTableAdapter
            // 
            this.iNVOICE_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // XfmOutward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 706);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelContainer1);
            this.Name = "XfmOutward";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dplOutward.ResumeLayout(false);
            this.dplcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvOutward)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICESTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSTOCK_OUTWARD_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        //private Perfect.Inventory.Core.Inventory.Outward.xucOutwardA _ucOutwardB;
        
        protected DevExpress.Utils.ImageCollection image;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraBars.Docking.DockPanel dplOutward;
        private DevExpress.XtraBars.Docking.ControlContainer dplcMain;
        private DevExpress.XtraNavBar.NavBarControl nvOutward;
        private DevExpress.XtraNavBar.NavBarGroup nvgOutward;
        private DevExpress.XtraNavBar.NavBarItem niOutward;
        private DevExpress.XtraNavBar.NavBarGroup nvgOutwardList;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niOutwardList;
        private DevExpress.XtraNavBar.NavBarItem niOutwardDetailList;
        private DevExpress.XtraNavBar.NavBarGroup nvgDictionary;
        private DevExpress.XtraNavBar.NavBarItem niProduct;
        private DevExpress.XtraNavBar.NavBarItem niCustomer;
        private DevExpress.XtraNavBar.NavBarItem niStock;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private dsSTOCK_OUTWARD_DETAIL dsSTOCK_OUTWARD_DETAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colColorName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rpCal;
        private System.Windows.Forms.BindingSource iNVOICESTATUSBindingSource;
        private Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.INVOICE_STATUSTableAdapter iNVOICE_STATUSTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
    }
}