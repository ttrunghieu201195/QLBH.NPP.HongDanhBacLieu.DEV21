using System.Globalization;
using Perfect.ERP;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptStockInward2011 : XtraReport
    {
        public rptStockInward2011(System.Data.DataSet ds, string Title)
        {
            
            InitializeComponent();
            if (ds != null)
            {
                
                    dsSTOCK_INWARD_DETAIL1.Merge(ds);
                //XtraMessageBox.Show(Convert.ToString(dsSTOCK_INWARD_DETAIL1.STOCK_INWARD_DETAIL.Rows.Count));
            }

            if (Title == null)
            {
                REPORT report = new REPORT();
                report.Get(Title, SysOption.Language);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = Title.ToUpper();
            }
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;

            RequestParameters = false;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("vi-VN");
            Utils.Localization.CultureManager.SetThreadUICulture(true);
            Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            
        }

        int _counter = 0;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}
