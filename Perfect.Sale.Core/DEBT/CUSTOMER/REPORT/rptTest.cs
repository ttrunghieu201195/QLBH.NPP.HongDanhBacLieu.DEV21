using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Perfect.Sale.Core.DEBT.CUSTOMER.REPORT
{
    public partial class rptTest : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTest(System.Data.DataSet ds)
        {
            InitializeComponent();
            if (ds != null)
                dsDebtDetails1.Merge(ds);
        }

    }
}
