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
using Microsoft.VisualBasic;
using DevExpress.XtraReports.UI;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptStockTransfer : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStockTransfer(DataTable dt, string ID,string Title, string EmployeeName, string OutStock,string InStock, string Reason,string Date)
        {
            InitializeComponent();
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {

                   // dsTransfer21.Tables["TransferDetail"].Merge(dt);
                }
            }

            REPORT report = new REPORT();
            report.Get(Title, SYS_OPTION.Language);
            Parameters["Title"].Value = report.Title;
            Parameters["EmployeeName"].Value = EmployeeName;            
            Parameters["OutStock"].Value = OutStock;
            Parameters["InStock"].Value = InStock;
            Parameters["Date"].Value = Date;//Strings.Format(Date,"{0:dd/MM/yyyy}");            
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
            //        cf.Insert(Guid.NewGuid().ToString(), "rptStockTransfer", PageHeader.Controls[i].Name, "EN", PageHeader.Controls[i].Text, "", true);
            //    }
            //}

            //for (int i = 0; i < xrTableRow2.Controls.Count; i++)
            //{
            //    if (xrTableRow2.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptStockTransfer", xrTableRow2.Controls[i].Name, "EN", xrTableRow2.Controls[i].Text, "", true);
            //    }
            //}
            //for (int i = 0; i < PageFooter.Controls.Count; i++)
            //{
            //    if (PageFooter.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "rptStockTransfer", PageFooter.Controls[i].Name, "EN", PageFooter.Controls[i].Text, "", true);
            //    }
            //}

            //CONTROL_FORMAT.Save("rptStockTransfer", "EN");


            //DataTable tb = CONTROL_FORMAT.Load("rptStockTransfer");
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
            //        for (int j = 0; j < xrTableRow2.Controls.Count; j++)
            //        {
            //            if (xrTableRow2.Controls[j].Name == tb.Rows[i]["Control_Id"].ToString())
            //            {
            //                //_Active = Convert.ToBoolean(dtPage.Rows[i]["AllowAccess"]);
            //                xrTableRow2.Controls[j].Text = tb.Rows[i]["Caption"].ToString();
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
        int _counter;
        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}

