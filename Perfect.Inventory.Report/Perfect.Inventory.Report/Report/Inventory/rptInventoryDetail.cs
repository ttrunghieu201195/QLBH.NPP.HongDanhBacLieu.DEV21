using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Data.Helper;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report
{
    public partial class rptInventoryDetail : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly string _id;
        int Count = 0;
        int Action = 0;

        public rptInventoryDetail()
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection
        }

        public rptInventoryDetail(int Action,string id,DataTable dt)
        {
            _id = id;
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 

            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    
                    dsInventoryDetail1.INVENTORY_DETAILREPORT.Merge(dt);
                }
            }
            SetLanguage();

            SetInfo(id);

            

            //CONTROL_FORMAT cf = new CONTROL_FORMAT();
            //for (int i = 0; i < PageHeader.Controls.Count; i++)
            //{
            //    if (PageHeader.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventoryDetail", PageHeader.Controls[i].Name, "EN", PageHeader.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < xrTableRow1.Controls.Count; i++)
            //{
            //    if (xrTableRow1.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventoryDetail", xrTableRow1.Controls[i].Name, "EN", xrTableRow1.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < ReportFooter.Controls.Count; i++)
            //{
            //    if (ReportFooter.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventoryDetail", ReportFooter.Controls[i].Name, "EN", ReportFooter.Controls[i].Text, "", true);
            //    }
            //}

            //CONTROL_FORMAT.Save("rptInventoryDetail", "VN");

           
        }

        void SetInfo(string id)
        {
          
            var report = new REPORT();
            report.Get(id, SysOption.ReportLanguage);
            Parameters["Title"].Value = report.Title;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            
            RequestParameters = false;
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo=new CultureInfo(SysOption.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Count++;
            ((XRLabel)sender).Text = Count.ToString();
        }
        
        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
