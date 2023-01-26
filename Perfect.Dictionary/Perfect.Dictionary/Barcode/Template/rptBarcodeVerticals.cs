namespace Perfect.Dictionary.Barcode.Template
{
    public partial class RptBarcodeVerticals : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBarcodeVerticals(DS.dsBarcode.PRODUCTDataTable dt)
        {
            InitializeComponent();

            dsBarcode1.PRODUCT.Merge(dt);

        }

    }
}
