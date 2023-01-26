using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report
{
    public partial class rptInventoryOlder : XtraReport
    {
        int Count = 0;
        int Action = 0;

        public rptInventoryOlder()
        {
            InitializeComponent();

            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection
        }

        public rptInventoryOlder(int Action, string id, DataTable dt, string stockid, string stockname)
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

            //DataTable tb = CONTROL_FORMAT.Load("rptInventoryLimit",SYS_OPTION.ReportLanguage);
            //if (tb != null)
            //{
            //    for (int i = 0; i < tb.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < PageHeader.Controls.Count; j++)
            //        {
            //            if (PageHeader.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                PageHeader.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow1.Controls.Count; j++)
            //        {
            //            if (xrTableRow1.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow1.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow3.Controls.Count; j++)
            //        {
            //            if (xrTableRow3.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow3.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }

            //        for (int j = 0; j < ReportFooter.Controls.Count; j++)
            //        {
            //            if (ReportFooter.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                ReportFooter.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //    }

            //}

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
