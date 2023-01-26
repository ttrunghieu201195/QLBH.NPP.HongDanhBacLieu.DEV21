using System;
using System.Data;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptInwardListDetail : XtraReport
    {
        public rptInwardListDetail(DataTable dt, string id,string title, string comment)
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
                    dsINWARD1.STOCK_INWARD_DETAIL.Merge(dt);
                }
            }
            SetLanguage();
            SetInfo(id,title, comment);     
                 
        }

        void SetInfo(string id,string title, string comment)
        {
            if (title == "")
            {
                REPORT report = new REPORT();
                report.Get(id, SysOption.ReportLanguage);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }
            Parameters["Comment"].Value = comment;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

           
        }

        int _counter;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}
