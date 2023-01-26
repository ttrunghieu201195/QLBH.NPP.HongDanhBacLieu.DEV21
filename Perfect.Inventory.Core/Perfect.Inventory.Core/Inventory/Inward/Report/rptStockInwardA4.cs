using System.Globalization;
using Perfect.ERP;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptStockInwardA4 : XtraReport
    {
        private decimal SoTien, VAT, VATAmount, ThanhToan;
        public rptStockInwardA4(System.Data.DataSet ds, string Title,decimal TotalCharge, decimal VatRate, decimal VatAmount , decimal TotalAmount)
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
            Perfect.Utils.Localization.CultureManager.SetThreadUICulture(true);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            SoTien = TotalCharge;
            VAT = VatRate;
            VATAmount = VatAmount;
            ThanhToan = TotalAmount;
            EventB4Print();
        }

        int Counter = 0;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

        private void EventB4Print()
        {
            GroupFooter1.BeforePrint += (s, e) =>
                {
                    CellVatRate.Text = VAT.ToString("##,##0");
                    CellVatAmount.Text = VATAmount.ToString("##,##0");
                    CellTotalAmount.Text = ThanhToan.ToString("##,##0");
                };
        }

    }
}
