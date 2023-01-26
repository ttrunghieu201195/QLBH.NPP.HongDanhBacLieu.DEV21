using System.Data;
using Perfect.Net.Info;

namespace Perfect.Sale.Core.REICEIPT.Report
{
    public partial class RptReceiptInvoice2011 : DevExpress.XtraReports.UI.XtraReport
    {
        public RptReceiptInvoice2011(DataTable dt, string title, string id, string amountText, string address, string SaleOrg, string Employee, string reason)
        {
            InitializeComponent();
            
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["Title"].Value = title.ToUpper();
            picLogo.Image = MyInfo.Photo;

            Parameters["Text"].Value = amountText;
            Parameters["ID"].Value = id;
            Parameters["Address"].Value = address;
            Parameters["Employee"].Value = Employee;
            Parameters["SaleOrg"].Value = SaleOrg;
            Parameters["Reason"].Value = reason;
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