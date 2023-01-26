using System.Globalization;
using Perfect.ERP;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;
using Perfect.Inventory.Core.Inventory.Outward.Report;
using System.Data;


namespace Perfect.Inventory.Report.Report
{
    
    public partial class rptStockOutwardA4 : XtraReport
    {
        System.Data.DataSet ds = null;
        string id;
        public rptStockOutwardA4(System.Data.DataSet dt, string ID, string title, string comment, decimal vatAmount, 
            decimal totalAmount, decimal TotalDebt, string phone, decimal amount,
            decimal width, decimal oldDebt, decimal totalDebt, string invoice)
        {
            
            InitializeComponent();
            if (dt != null)
            {
                dsSTOCK_OUTWARD_DETAIL1.Merge(dt);
            }
            id = ID;
            if (title == "")
            {
                REPORT report = new REPORT();
                report.Get(ID, SysOption.Language);
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
            Parameters["Phone"].Value = phone;

            Parameters["Amount"].Value = amount;
            Parameters["VatAmount"].Value = vatAmount;
            Parameters["TotalAmount"].Value = totalAmount;

            Parameters["OldDebt"].Value = oldDebt;
            Parameters["TotalDebt"].Value = totalDebt;
            Parameters["Invoice"].Value = invoice;

            Parameters["width"].Value = width;

            //
            //CellTotalDebt.Text = TotalDebt.ToString("##,##0");
            //
            //picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("vi-VN");
            Perfect.Utils.Localization.CultureManager.SetThreadUICulture(true);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
           
        }
        int Counter = 0;
        private void xrTableCell20_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

        int Cou = 0;
        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Cou++;
            ((XRLabel)sender).Text = Cou.ToString();
        }

        
        

    }
}
