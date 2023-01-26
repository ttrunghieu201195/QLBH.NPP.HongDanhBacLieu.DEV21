using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptStockCard : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStockCard(DataTable dt, string ID,string Comment)
        {
            InitializeComponent();
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    dsStockCard1.Tables["StockCard"].Merge(dt);
                }
            }
            xrTableCell23.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrTableCell23_BeforePrint);
            xrTableCell6.SummaryGetResult += new SummaryGetResultHandler(xrTableCell6_SummaryGetResult);
            xrTableCell6.AfterPrint += new EventHandler(xrTableCell6_AfterPrint);
            xrTableCell6.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xrTableCell6_BeforePrint);

            REPORT report = new REPORT();
            report.Get(ID, SYS_OPTION.ReportLanguage);
            Parameters["Title"].Value = report.Title;
            Parameters["Comment"].Value = Comment;
            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            RequestParameters = false;

            SetLanguage();
            
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
            //if (cultureInfo.Name == "vi-VN") return;
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
            //ResourceManager rm = new ResourceManager("Perfect.Inventory.Report.Report.StockCard.LNG.StockCard", typeof(rptStockCard).Assembly);
            //// Title.Value = rm.GetString("Title", cultureInfo);
            //riAdjust.Text = rm.GetString("riAdjust", cultureInfo);
            //riInward.Text = rm.GetString("riInward", cultureInfo);
            //riOutward.Text = rm.GetString("riOutward", cultureInfo);
            //riBuild.Text = rm.GetString("riBuild", cultureInfo);
            //riBalance.Text = rm.GetString("riBalance", cultureInfo);
            ////riBatch.Text = rm.GetString("riBatch", cultureInfo);
            //riChief.Text = rm.GetString("riChief", cultureInfo);
            //riDate.Text = rm.GetString("riDate", cultureInfo);
            //riDateNote.Text = rm.GetString("riDateNote", cultureInfo);
            //riManager.Text = rm.GetString("riManager", cultureInfo);
            //riPrepaid.Text = rm.GetString("riPrepaid", cultureInfo);
            //riProductName.Text = rm.GetString("riProductName", cultureInfo);
            //riReceipt.Text = rm.GetString("riReceipt", cultureInfo);
            //riDescription.Text = rm.GetString("riDescription");
            //riNo.Text = rm.GetString("riNo", cultureInfo);
            //riSign1.Text = rm.GetString("riSign1", cultureInfo);
            //riSign2.Text = rm.GetString("riSign2", cultureInfo);
            //riSign3.Text = rm.GetString("riSign3", cultureInfo);
            ////riStock.Text = rm.GetString("riStock", cultureInfo);
            //riTel.Text = rm.GetString("riTel", cultureInfo);
            //riTitle.Text = rm.GetString("riTitle", cultureInfo);
            //riTotal.Text = rm.GetString("riTotal", cultureInfo);
            //riUnit.Text = rm.GetString("riUnit", cultureInfo);
        }

        void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell6.Text = OnHandQty.ToString();
        }

        void xrTableCell6_AfterPrint(object sender, EventArgs e)
        {
            xrTableCell6.Text = OnHandQty.ToString();
        }

        void xrTableCell6_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = OnHandQty;
            e.Handled = true;
        }

        private double OnHandQty = 0.0;

        void xrTableCell23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            OnHandQty += Convert.ToDouble(GetCurrentColumnValue("OnhandQuantity"));

        }
        int Counter = 0;
        private void xrTableCell16_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

    }
}

