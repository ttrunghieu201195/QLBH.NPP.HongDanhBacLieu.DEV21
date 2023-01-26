using System;
using System.Globalization;
using System.Resources;
using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptStockCardDN : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStockCardDN(DataTable dt, string ID,string Comment)
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
                    dsStockCardDN1.Tables["StockCard"].Merge(dt);
                }
            }

            var report = new REPORT();
            report.Get(ID, SysOption.ReportLanguage);
            Parameters["Title"].Value = report.Title;
            Parameters["Comment"].Value = Comment;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company;
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            RequestParameters = false;

            SetLanguage();
            
        }

        void SetLanguage()
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SysOption.ReportLocalization);
            Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;
            //if (cultureInfo.Name == "vi-VN") return;

            //ResourceManager rm = new ResourceManager("Perfect.Inventory.Report.Report.StockCard.LNG.StockCardDN", typeof(rptStockCard).Assembly);
            //// Title.Value = rm.GetString("Title", cultureInfo);
            ////riEnd.Text = rm.GetString("riEnd", cultureInfo);
            ////riInward.Text = rm.GetString("riInward", cultureInfo);
            ////riOutward.Text = rm.GetString("riOutward", cultureInfo);
            //riInOutDate.Text = rm.GetString("riInOutDate", cultureInfo);
            //riInwardReceipt.Text = rm.GetString("riInwardReceipt", cultureInfo);
            //riOutwardReceipt.Text = rm.GetString("riOutwardReceipt", cultureInfo);
            //riSign.Text = rm.GetString("riSign", cultureInfo);

            //riStockID.Text = rm.GetString("riStockID", cultureInfo);
            //riQuantity.Text = rm.GetString("riQuantity", cultureInfo);

            //riStoreKeeper.Text = rm.GetString("riStoreKeeper", cultureInfo);

            
            ////riBatch.Text = rm.GetString("riBatch", cultureInfo);
            //riChief.Text = rm.GetString("riChief", cultureInfo);
            //riDate.Text = rm.GetString("riDate", cultureInfo);
            //riDateNote.Text = rm.GetString("riDateNote", cultureInfo);
            //riManager.Text = rm.GetString("riManager", cultureInfo);
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
            //riStockName.Text = rm.GetString("riStockName", cultureInfo);
        }

        int Counter = 0;

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Counter++;
            ((XRLabel)sender).Text = Counter.ToString();
        }

    }
}

