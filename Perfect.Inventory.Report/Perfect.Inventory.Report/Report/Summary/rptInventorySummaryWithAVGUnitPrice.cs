using DevExpress.XtraReports.UI;
using System.Data;
using Perfect.ERP;
using Perfect.Net.Info;

namespace Perfect.Inventory.Report.Report
{
    public partial class rptInventorySummaryWithAVGUnitPrice : XtraReport
    {
        public rptInventorySummaryWithAVGUnitPrice(DataTable dt, string id, string title, string comment, string filterstring)
        {
            InitializeComponent();
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ShowPageHeadersMode =
            //    DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            //PrintingSystem.PreviewRibbonFormEx.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            //MessageBox.Show(dt.Rows[0]["AdjustQuantity"].ToString());
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                   dsInventorySummary1.INVENTORY_DETAIL_SUMMARY_WITH_AVG_UNIT_PRICE.Merge(dt);
                }
            }

            FilterString = filterstring;

            SetInfo(id, title,comment);
            SetLanguage();
           
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
            Parameters["Comment"].Value = comment;

            //Parameters["CompanyName"].Value = MyInfo.Company == null ? "" : MyInfo.Company.ToUpper();
            //Parameters["CompanyAddress"].Value = MyInfo.Address ?? "";
            //Parameters["Tel"].Value = MyInfo.Tel ?? "";
            //Parameters["Fax"].Value = MyInfo.Fax ?? "";

            Parameters["CompanyName"].Value = MyInfo.Company.ToUpper();
            Parameters["CompanyAddress"].Value = MyInfo.Address;
            Parameters["Tel"].Value = MyInfo.Tel;
            Parameters["Fax"].Value = MyInfo.Fax;
            picLogo.Image = MyInfo.Photo;
            RequestParameters = false;
        }

        void SetLanguage()
        {
           // CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(SYS_OPTION.ReportLocalization);
            //if (cultureInfo.Name == "vi-VN") return;

           // Perfect.Utils.Localization.CultureManager.ApplicationUICulture = cultureInfo;

            //ResourceManager rm = new ResourceManager("Perfect.Inventory.Report.Report.Summary.LNG.Summary", typeof(rptSummary).Assembly);
            //// Title.Value = rm.GetString("Title", cultureInfo);
            //riCatalogID.Text = rm.GetString("riCatalogID", cultureInfo);
            //riCatalogName.Text = rm.GetString("riCatalogName", cultureInfo);
            //riChief.Text = rm.GetString("riChief", cultureInfo);
            //riCloseAmount.Text = rm.GetString("riCloseAmount", cultureInfo);
            //riCloseQuantity.Text = rm.GetString("riCloseQuantity", cultureInfo);
            //riClosingBalance.Text = rm.GetString("riClosingBalance", cultureInfo);
            //riDateNote.Text = rm.GetString("riDateNote", cultureInfo);
            //riFax.Text = rm.GetString("riFax", cultureInfo);
            //riHeadOfUnit.Text = rm.GetString("riHeadOfUnit", cultureInfo);
            //riInward.Text = rm.GetString("riInward", cultureInfo);
            //riInwardAmount.Text = rm.GetString("riInwardAmount", cultureInfo);
            //riInwardQuantity.Text = rm.GetString("riInwardQuantity", cultureInfo);
            //riNo.Text = rm.GetString("riNo", cultureInfo);
            //riOpenAmount.Text = rm.GetString("riOpenAmount", cultureInfo);
            //riOpeningBalance.Text = rm.GetString("riOpeningBalance", cultureInfo);
            //riOpenQuantity.Text = rm.GetString("riOpenQuantity", cultureInfo);
            //riOutward.Text = rm.GetString("riOutward", cultureInfo);
            //riOutwardAmount.Text = rm.GetString("riOutwardAmount", cultureInfo);
            //riOutwardQuantity.Text = rm.GetString("riOutwardQuantity", cultureInfo);
            //riPrepaid.Text = rm.GetString("riPrepaid", cultureInfo);
            //riProductID.Text = rm.GetString("riProductID", cultureInfo);
            //riProductName.Text = rm.GetString("riProductName", cultureInfo);
            
            //riHeadOfUnit.Text = rm.GetString("riHeadOfUnit", cultureInfo);
            //riChief.Text = rm.GetString("riChief", cultureInfo);
            //riPrepaid.Text = rm.GetString("riPrepaid", cultureInfo);
            //riNo.Text = rm.GetString("riNo", cultureInfo);
            //riSign1.Text = rm.GetString("riSign1", cultureInfo);
            //riSign2.Text = rm.GetString("riSign2", cultureInfo);
            //riSign3.Text = rm.GetString("riSign3", cultureInfo);
            ////riStock.Text = rm.GetString("riStock", cultureInfo);
            //riTel.Text = rm.GetString("riTel", cultureInfo);
            //riTitle.Text = rm.GetString("riTitle", cultureInfo);
            //riTotal.Text = rm.GetString("riTotal", cultureInfo);
            //riUnit.Text = rm.GetString("riUnit", cultureInfo);
            //riSum.Text = rm.GetString("riSum", cultureInfo);

        }



        int _counter;
        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _counter++;
            ((XRLabel)sender).Text = _counter.ToString();
        }

    }
}
