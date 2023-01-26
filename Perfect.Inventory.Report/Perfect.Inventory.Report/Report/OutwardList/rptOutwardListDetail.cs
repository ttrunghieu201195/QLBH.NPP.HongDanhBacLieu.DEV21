using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptOutwardListDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOutwardListDetail(DataTable dt, string ID, string title, string Comment)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    dsOUTWARD1.STOCK_OUTWARD_DETAIL.Merge(dt);
                }
            }
            if (title == "")
            {
                var report = new REPORT();
                report.Get(ID, SysOption.Language);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }
            Parameters["Comment"].Value = Comment;
            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
            
        }

        int Counter = 0;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Counter++;
            //((XRLabel)sender).Text = Counter.ToString();
        }

        private void xrTableCell31_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

    }
}
