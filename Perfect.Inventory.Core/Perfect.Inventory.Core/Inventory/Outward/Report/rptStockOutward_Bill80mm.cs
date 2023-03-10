using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;
using Perfect.Utils.Lib;

namespace Perfect.Inventory.Core.Inventory.Outward.Report
{
    public partial class rptStockOutward_Bill80mm : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal m_TotalAmount;
        private int Count = 1;
        public rptStockOutward_Bill80mm(System.Data.DataSet ds, decimal TotalAmount)
        {
            InitializeComponent();
            m_TotalAmount = TotalAmount;
            if (ds != null)
                dsSTOCK_OUTWARD_DETAIL1.Merge(ds);

            lbCompany.Text = MyInfo.Company.ToUpper();
            lbAddress.Text = MyInfo.Address;
            lbTelFax.Text = string.Format("ĐT: {0}", MyInfo.Tel);
            picLogo.Image = MyInfo.Photo;

            CellInWord.Text = MyLib.ToText(Convert.ToDouble(m_TotalAmount));
            InitEvent();
        }

        private void InitEvent()
        {
            CellSorted.BeforePrint += (s, e) =>
            {
                CellSorted.Text = Count.ToString("##,#00");
                Count++;
            };
        }
    }
}
