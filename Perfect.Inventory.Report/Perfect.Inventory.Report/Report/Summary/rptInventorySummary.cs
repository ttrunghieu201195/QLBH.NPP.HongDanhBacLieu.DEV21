using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptInventorySummary : XtraReport
    {
        public rptInventorySummary(DataTable dt,string id,string comment,string stockid, string stockname)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
           // 
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    dsInventorySummary1.Tables["InventorySummary"].Merge(dt);
                }
            }
            SetLanguage();
            SetInfo(id,comment,stockid,stockname);

           //MessageBox.Show(dt.Rows[0]["ProductGroupID"].ToString());

            #region MyRegion
            //CONTROL_FORMAT cf = new CONTROL_FORMAT();
            //for (int i = 0; i < PageHeader.Controls.Count; i++)
            //{
            //    if (PageHeader.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", PageHeader.Controls[i].Name, "EN", PageHeader.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < xrTableRow1.Controls.Count; i++)
            //{
            //    if (xrTableRow1.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow1.Controls[i].Name, "EN", xrTableRow1.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow16.Controls.Count; i++)
            //{
            //    if (xrTableRow16.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow16.Controls[i].Name, "EN", xrTableRow16.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < xrTableRow7.Controls.Count; i++)
            //{
            //    if (xrTableRow7.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow7.Controls[i].Name, "EN", xrTableRow7.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow13.Controls.Count; i++)
            //{
            //    if (xrTableRow13.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow13.Controls[i].Name, "EN", xrTableRow13.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow9.Controls.Count; i++)
            //{
            //    if (xrTableRow9.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow9.Controls[i].Name, "EN", xrTableRow9.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow10.Controls.Count; i++)
            //{
            //    if (xrTableRow10.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow10.Controls[i].Name, "EN", xrTableRow10.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow3.Controls.Count; i++)
            //{
            //    if (xrTableRow3.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow3.Controls[i].Name, "EN", xrTableRow3.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow15.Controls.Count; i++)
            //{
            //    if (xrTableRow15.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow15.Controls[i].Name, "EN", xrTableRow15.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow14.Controls.Count; i++)
            //{
            //    if (xrTableRow14.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow14.Controls[i].Name, "EN", xrTableRow14.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow6.Controls.Count; i++)
            //{
            //    if (xrTableRow6.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow6.Controls[i].Name, "EN", xrTableRow6.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow12.Controls.Count; i++)
            //{
            //    if (xrTableRow12.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow12.Controls[i].Name, "EN", xrTableRow12.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow11.Controls.Count; i++)
            //{
            //    if (xrTableRow11.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow11.Controls[i].Name, "EN", xrTableRow11.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow8.Controls.Count; i++)
            //{
            //    if (xrTableRow8.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow8.Controls[i].Name, "EN", xrTableRow8.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < xrTableRow2.Controls.Count; i++)
            //{
            //    if (xrTableRow2.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", xrTableRow2.Controls[i].Name, "EN", xrTableRow2.Controls[i].Text, "", true);
            //    }
            //}



            //for (int i = 0; i < PageFooter.Controls.Count; i++)
            //{
            //    if (PageFooter.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptInventorySummary", PageFooter.Controls[i].Name, "EN", PageFooter.Controls[i].Text, "", true);
            //    }
            //} 
            #endregion


            //CONTROL_FORMAT.Save("rptInventorySummary", "EN");

            
        }

        void SetInfo(string id, string comment,string stockid, string stockname)
        {
            var report = new REPORT();
            report.Get(id, SysOption.ReportLanguage);
            Parameters["Title"].Value = report.Title;
            Parameters["Comment"].Value = comment;

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

        }

        void SetLanguage()
        {

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            //if (cultureInfo.Name == "vi-VN") return;

            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            //DataTable tb = CONTROL_FORMAT.Load("rptInventorySummary",SYS_OPTION.ReportLanguage);
            //if (tb != null)
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
            //        for (int j = 0; j < xrTableRow16.Controls.Count; j++)
            //        {
            //            if (xrTableRow16.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow16.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow7.Controls.Count; j++)
            //        {
            //            if (xrTableRow7.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow7.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow13.Controls.Count; j++)
            //        {
            //            if (xrTableRow13.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow13.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow9.Controls.Count; j++)
            //        {
            //            if (xrTableRow9.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow9.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow10.Controls.Count; j++)
            //        {
            //            if (xrTableRow10.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow10.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
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
            //        for (int j = 0; j < xrTableRow15.Controls.Count; j++)
            //        {
            //            if (xrTableRow15.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow15.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow14.Controls.Count; j++)
            //        {
            //            if (xrTableRow14.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow14.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow6.Controls.Count; j++)
            //        {
            //            if (xrTableRow6.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow6.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow12.Controls.Count; j++)
            //        {
            //            if (xrTableRow12.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow12.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }

            //        for (int j = 0; j < xrTableRow11.Controls.Count; j++)
            //        {
            //            if (xrTableRow11.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow11.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow8.Controls.Count; j++)
            //        {
            //            if (xrTableRow8.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow8.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow2.Controls.Count; j++)
            //        {
            //            if (xrTableRow2.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow2.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow5.Controls.Count; j++)
            //        {
            //            if (xrTableRow5.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow5.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < PageFooter.Controls.Count; j++)
            //        {
            //            if (PageFooter.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active=Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                PageFooter.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //    }
        }

        int _counter;
        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}
