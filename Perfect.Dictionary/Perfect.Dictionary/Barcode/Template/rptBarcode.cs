using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Perfect.Dictionary.Barcode.Template
{
    public partial class rptBarcode : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBarcode(DS.dsBarcode.PRODUCTDataTable dt)
        {
            InitializeComponent();

            dsBarcode1.PRODUCT.Merge(dt);
            
        }

    }
}
