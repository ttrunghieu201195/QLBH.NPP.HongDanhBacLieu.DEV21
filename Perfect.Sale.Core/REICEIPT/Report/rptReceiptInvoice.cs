using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Cash.Cash.Receipt.Report
{
    public partial class rptReceiptInvoice : XtraReport
    {
        public rptReceiptInvoice(DataTable dt, string title,string id,string filterString, string currency, string desc)
        {
            InitializeComponent();

            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;

            Parameters["Title"].Value = title.ToUpper();
            Parameters["Text"].Value = filterString;
            Parameters["ID"].Value = id;
            Parameters["Desc"].Value = desc;
            if (dt!=null)
            {
                if (dt.Rows.Count>0) 
                {
                    dsReceipt1.CUSTOMER_RECEIPT.Merge(dt);
                }
            }
            RequestParameters = false;

        }

    }
}
