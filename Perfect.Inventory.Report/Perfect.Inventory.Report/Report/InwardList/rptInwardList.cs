using System.Data;
using Perfect.ERP;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report.InwardList
{
    public partial class rptInwardList : XtraReport
    {
        public rptInwardList(DataTable dt, string id, string title, string comment)
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
                    dsINWARD1.STOCK_INWARD.Merge(dt);
                }
            }
            SetLanguage();
            SetInfo(id, title, comment);

        }

        void SetInfo(string id, string title, string comment)
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

            // CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
            //Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            //DataTable tb = CONTROL_FORMAT.Load("rptInwardList", SYS_OPTION.ReportLanguage);
            //if (tb != null)
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
            //    }
        }

        int _counter;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}