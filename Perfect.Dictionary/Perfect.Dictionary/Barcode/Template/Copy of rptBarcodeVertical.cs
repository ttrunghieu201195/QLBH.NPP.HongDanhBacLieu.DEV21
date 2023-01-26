namespace Perfect.Dictionary.Barcode.Template
{
    public partial class RptBarcodeVertical : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBarcodeVertical(DS.dsBarcode.PRODUCTDataTable dt)
        {
            InitializeComponent();
            dsBarcode1.PRODUCT.Merge(dt);
            xrLabel1.Visible = true;
            xrLabel2.Visible = true;
        }

       

    }
}
