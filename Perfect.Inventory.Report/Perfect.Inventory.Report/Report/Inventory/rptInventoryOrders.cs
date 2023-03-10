using System;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report
{
    public partial class rptInventoryOrders : XtraReport
    {
        int Count = 0;
        public rptInventoryOrders(DataTable dt, string id, string title,string comment)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection

            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                   
                    dsInventory1.INVENTORY_Order_Warning.Merge(dt);
                }
            }
            //dsInventoryOrders1.INVENTORY_REPORT.Rows.Clear();
            //dsInventoryOrders1.INVENTORY_REPORT.Merge(dt);
            SetLanguage();
            SetInfo(id, title,comment);
            
        }


        void SetInfo(string id, string title, string comment)
        {
            if (title == "")
            {
                var report = new REPORT();
                report.Get(id, SysOption.ReportLanguage);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";


            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            
            RequestParameters = false;
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
        }

        public rptInventoryOrders(int Action, string ID, DataTable dt)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            SetLanguage();
        }      


        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Count++;
            ((XRLabel)sender).Text = Count.ToString();
        }

        private void xrSUMAMT_AfterPrint(object sender, EventArgs e)
        {           
        }

    }
}
