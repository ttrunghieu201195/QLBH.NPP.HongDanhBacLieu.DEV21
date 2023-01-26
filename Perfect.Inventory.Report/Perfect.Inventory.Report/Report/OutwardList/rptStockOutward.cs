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
using Microsoft.VisualBasic;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptStockOutward : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStockOutward(DataTable dt, string ID, string Title, string Date, string CustomerName, string CustomerAddress, string StockName, string Reason)
        {
            InitializeComponent();
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    dsOrder21.Tables["OrderDetail"].Merge(dt);
                }
            }
            REPORT report = new REPORT();
            report.Get(Title, SYS_OPTION.Language);
            Parameters["Title"].Value = report.Title;

            Parameters["CustomerName"].Value = CustomerName;
            Parameters["CustomerAddress"].Value = CustomerAddress;
            Parameters["StockName"].Value = StockName;
            
            Parameters["Date"].Value = Date;
            Parameters["Reason"].Value = Reason;
            Parameters["ID"].Value = ID;
            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            RequestParameters = false;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            //CONTROL_FORMAT cf = new CONTROL_FORMAT();
            //for (int i = 0; i < PageHeader.Controls.Count; i++)
            //{
            //    if (PageHeader.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptStockOutward", PageHeader.Controls[i].Name, "EN", PageHeader.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < xrTableRow1.Controls.Count; i++)
            //{
            //    if (xrTableRow1.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptStockOutward", xrTableRow1.Controls[i].Name, "EN", xrTableRow1.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < PageFooter.Controls.Count; i++)
            //{
            //    if (PageFooter.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptStockOutward", PageFooter.Controls[i].Name, "EN", PageFooter.Controls[i].Text, "", true);
            //    }
            //}

            //CONTROL_FORMAT.Save("rptStockOutward", "EN");

            //DataTable tb = CONTROL_FORMAT.Load("rptStockOutward");
            //if (tb != null)
            //    for (int i = 0; i < tb.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < PageHeader.Controls.Count; j++)
            //        {
            //            if (PageHeader.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                PageHeader.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow1.Controls.Count; j++)
            //        {
            //            if (xrTableRow1.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow1.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < xrTableRow3.Controls.Count; j++)
            //        {
            //            if (xrTableRow3.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow3.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //        for (int j = 0; j < PageFooter.Controls.Count; j++)
            //        {
            //            if (PageFooter.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                PageFooter.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
            //            }
            //        }
            //    }
        }

        int Counter = 0;
        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

    }
}
