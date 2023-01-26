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
    public partial class rptStockTransfer : XtraReport
    {
        public rptStockTransfer(System.Data.DataSet dt, string ID,string title, string comment)
        {
            InitializeComponent();
            if (dt != null)
            {
                dsSTOCK_TRANSFER_DETAIL1.Merge(dt);
            }

            if (title == "")
            {
                REPORT report = new REPORT();
                report.Get(ID, SysOption.Language);
                Parameters["Title"].Value = report.Title.ToUpper();
            }
            else
            {
                Parameters["Title"].Value = title.ToUpper();
            }


            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("vi-VN");
            Perfect.Utils.Localization.CultureManager.SetThreadUICulture(true);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
           // CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
           // Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;


           
        }
        int _counter;
        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}

