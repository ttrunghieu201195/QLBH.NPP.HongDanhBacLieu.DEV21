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

namespace Perfect.Inventory.Report
{
    public partial class rptInventoryBFC : DevExpress.XtraReports.UI.XtraReport
    {
        int Count = 0;
        public rptInventoryBFC(string stockId,string stockName)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection

            iNVENTORY_REPORTTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            iNVENTORY_REPORTTableAdapter.Fill(dsInventoryOrders1.INVENTORY_REPORT,stockId,"","",MyLogin.LoginDate);
            //dsInventoryOrders1.INVENTORY_REPORT.Rows.Clear();
            //dsInventoryOrders1.INVENTORY_REPORT.Merge(dt);

            SetInfo(stockId, stockName);

            SetLanguage();
        }

        void SetInfo(string stockId, string stockName)
        {
            //Perfect.ERP.REPORT REPORT = new Perfect.ERP.REPORT();
            //REPORT.Get(ID, Perfect.ERP.SYS_OPTION.Language);
            Parameters["Title"].Value = "TỒN KHO";


            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["Stock_ID"].Value = stockId;
            Parameters["Stock_Name"].Value = stockName;
            RequestParameters = false;
        }

        public rptInventoryBFC(int Action, string ID,DataTable dt)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
        }   
   
        void SetLanguage()
        {
            
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
