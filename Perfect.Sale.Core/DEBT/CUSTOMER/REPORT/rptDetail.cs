using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Sale.Core.DEBT.CUSTOMER.REPORT
{
    public partial class rptDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDetail(DataTable dt, string title, string filterstring)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //   DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["Title"].Value = title.ToUpper();
            FilterString = filterstring;
           
            if (dt!=null)
            {
                if (dt.Rows.Count>0) 
                {
                    //dsReceiptInvoice.CASH_RECEIPT.Merge(dt);
                    dsDEBT1.DETAIL.Merge(dt);
                }
            }
            RequestParameters = false;

        }

    }
}
