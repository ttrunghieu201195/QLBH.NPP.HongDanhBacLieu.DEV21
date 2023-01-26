using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report
{
    public partial class rptInventoryLimit : XtraReport
    {
        int Count = 0;
        int Action = 0;

        public rptInventoryLimit()
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection
        }

        public rptInventoryLimit(int Action, string id, DataTable dt, string stockid, string stockname)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                   
                    dsInventoryLimit1.INVENTORY_ORVERLIMIT_REPORT.Merge(dt);
                }
            }
            SetLanguage();
            SetInfo(id,stockid,stockname);                           

        }

        void SetInfo(string id, string stockid, string stockname)
        {            
            var report = new REPORT();
            report.Get(id, SysOption.ReportLanguage);
            Parameters["Title"].Value = report.Title;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["StockID"].Value = stockid;
            Parameters["StockName"].Value = stockname;
            RequestParameters = false;
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Count++;
            ((XRLabel)sender).Text = Count.ToString();
        }
        
        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
