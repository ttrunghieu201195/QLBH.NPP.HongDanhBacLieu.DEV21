using System.Data;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Cash.Cash.Payment.Report
{
    public partial class rptPaymentInvoice : XtraReport
    {
        public rptPaymentInvoice(DataTable dt, string title, string filerString, string desc)
        {
            InitializeComponent();

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["Title"].Value = title.ToUpper();
            Parameters["Text"].Value = filerString;
            Parameters["Desc"].Value = desc;
            picLogo.Image = MyInfo.Photo;
            if (dt!=null)
            {
                if (dt.Rows.Count>0) 
                {
                    dsPayment1.PROVIDER_PAYMENT.Merge(dt);
                }
            }
            RequestParameters = false;

        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {


        }

    }
}