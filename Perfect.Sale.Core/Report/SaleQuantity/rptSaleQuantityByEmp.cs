using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Sale.Core.Report.SaleQuantity
{
    public partial class rptSaleQuantityByEmp : DevExpress.XtraReports.UI.XtraReport
    {
        private int count = 0;
        public rptSaleQuantityByEmp(DataSet dt, string title, string filterstring)
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
                dsSaleQuantity1.Merge(dt);
            }
            RequestParameters = false;

        }

        private void CellSTT_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            count++;
            CellSTT.Text = count.ToString();
        }

    }
}
