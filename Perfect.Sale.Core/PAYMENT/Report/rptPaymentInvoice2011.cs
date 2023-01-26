using System.Data;
using Perfect.Net.Info;

namespace Perfect.Cash.Cash.Payment.Report
{
    public partial class rptPaymentInvoice2011 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPaymentInvoice2011(DataTable dt, string title, string filerString, string lyDo, string Emp, string ID, string address)
        {
            InitializeComponent();
            
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["Title"].Value = title.ToUpper();
            Parameters["Text"].Value = filerString;
            Parameters["lyDo"].Value = lyDo;
            Parameters["Emp"].Value = Emp;
            Parameters["SoPC"].Value = ID;
            Parameters["address"].Value = address;
            picLogo.Image = MyInfo.Photo;
            if (dt!=null)
            {
                if (dt.Rows.Count>0) 
                {
                    dsReport_PC1.PROVIDER_PAYMENT.Merge(dt);
                }
            }
            RequestParameters = false;

        }
        
    }
}