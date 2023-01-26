using System.Data;
//using Perfect.Common.Class;
using DevExpress.XtraReports.UI;
using Perfect.Data.Helper;
using Perfect.Net.Info;
//using Perfect.Inventory.Report.Class;
//using Perfect.Net.Info.Bussiness;

namespace Perfect.Inventory.Core.Inventory.StockCard
{
    public partial class rptStockCard : XtraReport
    {
        public rptStockCard(DataTable dt, string ID, string title, string comment)
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
                    dsStock_Card1.STOCK_CARD.Merge(dt);
                }
            }
            //if (title == "")
            //{
            //    REPORT report = new REPORT();
            //    report.Get(ID, SysOption.Language);
            //    Parameters["Title"].Value = report.Title.ToUpper();
            //}
            //else
            {
                Parameters["Title"].Value = title.ToUpper();
            }
            Parameters["Comment"].Value = comment;
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
            
        }

        int Counter = 0;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Counter++;
            //((XRLabel)sender).Text = Counter.ToString();
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

    }
}
