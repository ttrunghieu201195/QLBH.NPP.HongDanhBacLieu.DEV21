namespace Perfect.Sale.Core.REICEIPT
{
    partial class XfmReiceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfmReiceipt));
            this.image = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dplOutward = new DevExpress.XtraBars.Docking.DockPanel();
            this.dplcMain = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nvOutward = new DevExpress.XtraNavBar.NavBarControl();
            this.nvgOutward = new DevExpress.XtraNavBar.NavBarGroup();
            this.niOutwardList = new DevExpress.XtraNavBar.NavBarItem();
            this.niNotOutwardList = new DevExpress.XtraNavBar.NavBarItem();
            this.niOutward = new DevExpress.XtraNavBar.NavBarItem();
            this.nvgDebit = new DevExpress.XtraNavBar.NavBarGroup();
            this.niDebitList = new DevExpress.XtraNavBar.NavBarItem();
            this.niSummary = new DevExpress.XtraNavBar.NavBarItem();
            this.niPayList = new DevExpress.XtraNavBar.NavBarItem();
            this.niOutwardDetailList = new DevExpress.XtraNavBar.NavBarItem();
            this.niTables = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dplOutward.SuspendLayout();
            this.dplcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvOutward)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.ImageSize = new System.Drawing.Size(32, 32);
            this.image.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("image.ImageStream")));
            this.image.Images.SetKeyName(0, "1318304491_order-1.png");
            this.image.Images.SetKeyName(1, "1318304498_list.png");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.plMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(165, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 724);
            this.panelControl1.TabIndex = 2;
            // 
            // plMain
            // 
            this.plMain.Appearance.Options.UseFont = true;
            this.plMain.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.plMain.AppearanceCaption.Options.UseFont = true;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(2, 2);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(823, 720);
            this.plMain.TabIndex = 0;
            // 
            // dm
            // 
            this.dm.DockingOptions.ShowCloseButton = false;
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dplOutward});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dplOutward
            // 
            this.dplOutward.Controls.Add(this.dplcMain);
            this.dplOutward.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dplOutward.ID = new System.Guid("f2631645-0ef5-44c5-a57c-f1293fc924d4");
            this.dplOutward.Location = new System.Drawing.Point(0, 0);
            this.dplOutward.Name = "dplOutward";
            this.dplOutward.OriginalSize = new System.Drawing.Size(165, 200);
            this.dplOutward.Size = new System.Drawing.Size(165, 724);
            this.dplOutward.Text = "Chức Năng";
            // 
            // dplcMain
            // 
            this.dplcMain.Controls.Add(this.nvOutward);
            this.dplcMain.Location = new System.Drawing.Point(3, 25);
            this.dplcMain.Name = "dplcMain";
            this.dplcMain.Size = new System.Drawing.Size(159, 696);
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
            this.nvgDebit});
            this.nvOutward.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.niOutward,
            this.niOutwardList,
            this.niOutwardDetailList,
            this.niTables,
            this.niDebitList,
            this.niSummary,
            this.niNotOutwardList,
            this.niPayList});
            this.nvOutward.LargeImages = this.image;
            this.nvOutward.Location = new System.Drawing.Point(0, 0);
            this.nvOutward.Name = "nvOutward";
            this.nvOutward.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.nvOutward.OptionsNavPane.ExpandedWidth = 205;
            this.nvOutward.Size = new System.Drawing.Size(159, 696);
            this.nvOutward.SmallImages = this.image;
            this.nvOutward.TabIndex = 0;
            this.nvOutward.Text = "navBarControl1";
            // 
            // nvgOutward
            // 
            this.nvgOutward.Caption = "Phiếu Thu";
            this.nvgOutward.Expanded = true;
            this.nvgOutward.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgOutward.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niOutwardList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niNotOutwardList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niOutward)});
            this.nvgOutward.Name = "nvgOutward";
            // 
            // niOutwardList
            // 
            this.niOutwardList.Caption = "Danh Sách Phiếu Thu";
            this.niOutwardList.LargeImageIndex = 1;
            this.niOutwardList.Name = "niOutwardList";
            this.niOutwardList.SmallImageIndex = 1;
            this.niOutwardList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiOutwardListLinkClicked);
            // 
            // niNotOutwardList
            // 
            this.niNotOutwardList.Caption = "Chưa Thu";
            this.niNotOutwardList.Name = "niNotOutwardList";
            this.niNotOutwardList.SmallImageIndex = 9;
            this.niNotOutwardList.Visible = false;
            this.niNotOutwardList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiNotOutwardListLinkClicked);
            // 
            // niOutward
            // 
            this.niOutward.Caption = "Lập Phiếu Thu";
            this.niOutward.Name = "niOutward";
            this.niOutward.SmallImageIndex = 10;
            this.niOutward.Visible = false;
            this.niOutward.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiOutwardLinkClicked);
            // 
            // nvgDebit
            // 
            this.nvgDebit.Caption = "Bảng Kê";
            this.nvgDebit.Expanded = true;
            this.nvgDebit.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.nvgDebit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.niDebitList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niPayList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.niSummary)});
            this.nvgDebit.Name = "nvgDebit";
            // 
            // niDebitList
            // 
            this.niDebitList.Caption = "Danh Sách Phiếu Công Nợ";
            this.niDebitList.LargeImageIndex = 0;
            this.niDebitList.Name = "niDebitList";
            this.niDebitList.SmallImageIndex = 0;
            this.niDebitList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiDebitListLinkClicked);
            // 
            // niSummary
            // 
            this.niSummary.Caption = "Công Nợ Tổng Hợp";
            this.niSummary.LargeImageIndex = 1;
            this.niSummary.Name = "niSummary";
            this.niSummary.SmallImageIndex = 1;
            this.niSummary.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NiSummaryLinkClicked);
            // 
            // niPayList
            // 
            this.niPayList.Caption = "Danh Sách Phiếu Trả Ngay";
            this.niPayList.LargeImageIndex = 0;
            this.niPayList.Name = "niPayList";
            this.niPayList.SmallImageIndex = 0;
            this.niPayList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.niPayList_LinkClicked);
            // 
            // niOutwardDetailList
            // 
            this.niOutwardDetailList.Caption = "Theo Hàng Hoá";
            this.niOutwardDetailList.Name = "niOutwardDetailList";
            this.niOutwardDetailList.SmallImageIndex = 13;
            this.niOutwardDetailList.Visible = false;
            // 
            // niTables
            // 
            this.niTables.Caption = "Danh Sách Bàn";
            this.niTables.Name = "niTables";
            this.niTables.SmallImageIndex = 9;
            this.niTables.Visible = false;
            // 
            // XfmReiceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 724);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dplOutward);
            this.Name = "XfmReiceipt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu Tiền";
            this.Activated += new System.EventHandler(this.XfmOutwardActivated);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dplOutward.ResumeLayout(false);
            this.dplcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvOutward)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraNavBar.NavBarItem niOutwardList;
        private DevExpress.XtraNavBar.NavBarItem niOutwardDetailList;
        private DevExpress.XtraNavBar.NavBarItem niTables;
        private DevExpress.XtraNavBar.NavBarGroup nvgDebit;
        private DevExpress.XtraNavBar.NavBarItem niDebitList;
        private DevExpress.XtraNavBar.NavBarItem niSummary;
        private DevExpress.XtraNavBar.NavBarItem niNotOutwardList;
        private DevExpress.XtraNavBar.NavBarItem niPayList;
    }
}