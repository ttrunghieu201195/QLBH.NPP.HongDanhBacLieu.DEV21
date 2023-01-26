using System;
using System.Globalization;
using DevExpress.XtraReports.UI;
using Perfect.ERP;
using System.Data;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report
{
    public partial class rptInventory : XtraReport
    {
        int Count = 0;
        public rptInventory()
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //iNVENTORY_SUMMARYREPORTTableAdapter.Connection
        }

        public rptInventory(int action, string id, DataTable dt,string title,string comment,string filterstring)
        {
            InitializeComponent();
            
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
          
            //this.PrintProgress += new DevExpress.XtraPrinting.PrintProgressEventHandler(rptInventory_PrintProgress);
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    
                    dsInventory1.INVENTORY.Merge(dt);
                }
            }
            
            FilterString = filterstring;

            SetLanguage();
            SetInfo(id,title,comment);                   

        }

        void rptInventory_PrintProgress(object sender, DevExpress.XtraPrinting.PrintProgressEventArgs e)
        {
           
        }

        void SetInfo(string id, string title, string comment)
        {
            if (title == "")
            {
                var report = new REPORT();
                report.Get(id, SysOption.ReportLanguage);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            Parameters["Comment"].Value = comment;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
        }

        void SetLanguage()
        {
            #region MyRegion

           // CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
           // //if (cultureInfo.Name == "vi-VN") return;

           // ResourceManager rm = new ResourceManager("Perfect.Inventory.Report.Report.Inventory.LNG.Inventory", typeof(rptInventory).Assembly);
           // // Title.Value = rm.GetString("Title", cultureInfo);
           // riAmount.Text = rm.GetString("riAmount", cultureInfo);
           // //riBatch.Text = rm.GetString("riBatch", cultureInfo);
           // riChief.Text = rm.GetString("riChief", cultureInfo);
           //// riDate.Text = rm.GetString("riDate", cultureInfo);
           // riDateNote.Text = rm.GetString("riDateNote", cultureInfo);
           // riHeadOfUnit.Text = rm.GetString("riHeadOfUnit", cultureInfo);
           // riPrepaid.Text = rm.GetString("riPrepaid", cultureInfo);
           // riProductID.Text = rm.GetString("riProductID", cultureInfo);
           // riProductName.Text = rm.GetString("riProductName", cultureInfo);
           // riQuantity.Text = rm.GetString("riQuantity", cultureInfo);
           // riCatalogID.Text = rm.GetString("riCatalogID");
           // riCatalogName.Text = rm.GetString("riCatalogName", cultureInfo);
           // riNo.Text = rm.GetString("riNo", cultureInfo);
           // riSign1.Text = rm.GetString("riSign1", cultureInfo);
           // riSign2.Text = rm.GetString("riSign2", cultureInfo);
           // riSign3.Text = rm.GetString("riSign3", cultureInfo);
           // //riStock.Text = rm.GetString("riStock", cultureInfo);
           // riTel.Text = rm.GetString("riTel", cultureInfo);
           // riTitle.Text = rm.GetString("riTitle", cultureInfo);
           // riTotal.Text = rm.GetString("riTotal", cultureInfo);
           // riUnit.Text = rm.GetString("riUnit", cultureInfo);
           // riUnitPrice.Text = rm.GetString("riUnitPrice", cultureInfo);
            //DataTable tb = CONTROL_FORMAT.Load("rptInventory", SYS_OPTION.ReportLanguage);
            //if (tb != null)
            //{
            //    for (int i = 0; i < tb.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < PageHeader.Controls.Count; j++)
            //        {
            //            if (PageHeader.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                PageHeader.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow1.Controls.Count; j++)
            //        {
            //            if (xrTableRow1.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow1.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow3.Controls.Count; j++)
            //        {
            //            if (xrTableRow3.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow3.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }

            //        for (int j = 0; j < ReportFooter.Controls.Count; j++)
            //        {
            //            if (ReportFooter.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                ReportFooter.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //    }
            //} 
            #endregion

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
           
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Count++;
            ((XRLabel)sender).Text = Count.ToString();
        }

        private void xrSUMAMT_AfterPrint(object sender, EventArgs e)
        {
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
