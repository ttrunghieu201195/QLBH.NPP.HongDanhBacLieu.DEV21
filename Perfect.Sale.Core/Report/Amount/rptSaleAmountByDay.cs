using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Perfect.Sale.Core.Report.Amount
{
    public partial class rptSaleAmountByDay : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSaleAmountByDay()
        {
            InitializeComponent();
        }

        public rptSaleAmountByDay(string p1, string p2, string p3, string p4, DataTable dt)
        {
            InitializeComponent();
            //this.p1.Value = p1;
            //this.p2.Value = p2;
            //this.p3.Value = p3;
            //this.p4.Value = p4;
            


           
            Parameters["p1"].Value = p1;
            Parameters["p2"].Value = p2;
            Parameters["p3"].Value = p3;
            Parameters["p4"].Value = p4;

            if (dt != null && dt.Rows.Count >0)
            {
                dsCustomer1.CURRENCY_GetList.Merge(dt);
            }

            RequestParameters = false;

        }

    }
}
