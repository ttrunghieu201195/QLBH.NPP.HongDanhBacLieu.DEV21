using System.Globalization;
using Perfect.ERP;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Core.Inventory.Inward.Report
{
    public partial class RptStockInward : XtraReport
    {
        private decimal SoTien, VAT, VATAmount, ThanhToan;
        public RptStockInward(System.Data.DataSet ds, string title, decimal TotalCharge, decimal VatRate, decimal VatAmount, decimal TotalAmount, string desc)
        {
            
            InitializeComponent();
            if (ds != null)
            {
                dsSTOCK_INWARD_DETAIL1.Merge(ds);
            }

            if (title == null)
            {
                var report = new REPORT();
                report.Get(title, SysOption.Language);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            Parameters["Description"].Value = desc;
            RequestParameters = false;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("vi-VN");
            Utils.Localization.CultureManager.SetThreadUICulture(true);
            Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            SoTien = TotalCharge;
            VAT = VatRate;
            VATAmount = VatAmount;
            ThanhToan = TotalAmount;
            EventB4Print();
        }

        int _counter = 0;
        private void XrTableCell8BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }
        private void EventB4Print()
        {
            GroupFooter1.BeforePrint += (s, e) =>
            {
                CellVatRate.Text = VAT.ToString("##,##0") + "%";
                CellVatAmount.Text = VATAmount.ToString("##,##0");
                CellTotalAmount.Text = ThanhToan.ToString("##,##0");
            };
        }
    }
}
