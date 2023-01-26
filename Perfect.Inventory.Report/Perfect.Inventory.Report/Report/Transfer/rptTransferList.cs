using System;
using System.Data;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptTransferList : XtraReport
    {
        public rptTransferList(DataTable dt, string ID,string title,string Comment)
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
                    dsTRANSFER1.STOCK_TRANSFER_BY_DATE.Merge(dt);
                }
            }
            if (title == "")
            {
                var report = new REPORT();
                report.Get(ID, SysOption.Language);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }
            Parameters["Comment"].Value = Comment;
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;

            picLogo.Image = MyInfo.Photo;

            RequestParameters = false;

            //CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
            //Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            
        }

        int Counter = 0;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Counter++;
            //((XRLabel)sender).Text = Counter.ToString();
        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

    }
}
