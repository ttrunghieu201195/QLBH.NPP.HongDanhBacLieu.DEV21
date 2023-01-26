using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptInventoryQuantityDate : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInventoryQuantityDate(DataTable dt, string id, string title, string comment,string filterstring)
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
                    dsSummary1.INVENTORY_LEDGER.Merge(dt);
                }
            }
            FilterString = filterstring;
            SetInfo(id,title, comment);
            SetLanguage();          
           
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

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["Comment"].Value = comment;
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
        }

        void SetLanguage()
        {
            //CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);     
           // Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
            
        }

        int _counter;
        private void xrTableCell18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

        private void xrTableCell30_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            
        }

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //MessageBox.Show(xrTableCell27.Text);
        }

    }
}
