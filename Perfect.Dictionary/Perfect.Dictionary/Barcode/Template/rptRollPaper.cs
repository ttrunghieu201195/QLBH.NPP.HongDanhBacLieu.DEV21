namespace Perfect.Dictionary.Barcode.Template
{
    public partial class rptRollPaper : DevExpress.XtraReports.UI.XtraReport
    {
        public rptRollPaper(DS.dsBarcode.PRODUCTDataTable dt)
        {
            InitializeComponent();

            dsBarcode1.PRODUCT.Merge(dt);
            
        }

    }
}
