using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using Perfect.Data.Helper;
using System.Data;
using System.IO;
using Perfect.Net.Info;
using System.Globalization;
//using System.Globalization;

namespace Perfect.Inventory.Report
{
    public partial class rptInventoryDate : DevExpress.XtraReports.UI.XtraReport
    {
        int Count = 0;
        public rptInventoryDate()
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection
        }

        public rptInventoryDate(int Action, string id, string commemt, DataTable dt, string stockid, string stockname)
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
                  //  dsInventory1.INVENTORY_SUMMARYREPORT.Merge(dt);
                }
            }
            var report = new REPORT();
            report.Get(id, SysOption.ReportLanguage);
            Parameters["Title"].Value = report.Title ;

            Parameters["Comment"].Value = commemt;
            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            
            
            Parameters["StockID"].Value = stockid;
            Parameters["StockName"].Value = stockname;
            RequestParameters = false;

            SetLanguage();

            
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            //MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
            //CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
            //Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
            //if (cultureInfo.Name == "vi-VN") return;

            //ResourceManager rm = new ResourceManager("Perfect.Inventory.Report.Report.AdjustList.LNG.AdjustList", typeof(rptAdjustList).Assembly);
            //Title.Value = rm.GetString("Title",cultureInfo);
            //xrTel.Text = rm.GetString("xrTel", cultureInfo);
            //xrDate.Text = rm.GetString("xrDate", cultureInfo);
            //xrReceipt.Text = rm.GetString("xrReceipt", cultureInfo);
            //xrEmployeeID.Text = rm.GetString("xrEmployeeID", cultureInfo);
            //xrEmployee.Text = rm.GetString("xrEmployee", cultureInfo);
            //xrDescription.Text = rm.GetString("xrDescription", cultureInfo);
            //xrAmount.Text = rm.GetString("xrAmount", cultureInfo);
            //xrSum.Text = rm.GetString("xrSum", cultureInfo);
            //xrKeeper.Text = rm.GetString("xrKeeper", cultureInfo);
            //xrChief.Text = rm.GetString("xrChief");
            //xrHeadOfUnit.Text = rm.GetString("xrHeadOfUnit", cultureInfo);
            //xrSign1.Text = rm.GetString("xrSign1", cultureInfo);
            //xrSign2.Text = rm.GetString("xrSign2", cultureInfo);
            //xrSign3.Text = rm.GetString("xrSign3", cultureInfo);
            //xrDateNote.Text = rm.GetString("xrDateNote", cultureInfo);
        }


        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Count++;
            ((XRLabel)sender).Text = Count.ToString();
        }

        private void xrSUMAMT_AfterPrint(object sender, EventArgs e)
        {           
        }

    }
}
