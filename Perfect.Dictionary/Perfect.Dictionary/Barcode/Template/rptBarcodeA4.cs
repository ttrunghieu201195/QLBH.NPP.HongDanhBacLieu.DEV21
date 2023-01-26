using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Perfect.Dictionary.Barcode.Template
{
    public partial class rptBarcodeA4 : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBarcodeA4(DS.dsBarcode.PRODUCTDataTable dt)
        {
            InitializeComponent();
            EventBeforePrint();
            if (dt != null)
                dsBarcode1.Merge(dt);
        }

        private void EventBeforePrint()
        {
            
        }

    }
}
