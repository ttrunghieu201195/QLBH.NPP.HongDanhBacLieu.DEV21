using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraPrinting.BarCode;

namespace Perfect.Dictionary.Barcode.Template
{
    public partial class rptBarcodeV_01 : DevExpress.XtraReports.UI.XtraReport
    {
        private float m_TopF = 10f;
        private float m_LeftF = 0f;
        private float m_WidthF = 130f;

        private float m_HeightFProduct = 15.62f;
        private float m_HeightFBarcode = 50f;
        private float m_HeightFPrice = 15.62f;

        private int m_Pos = 1;
        private int PageCount = 0;

        public rptBarcodeV_01(DataTable dt, bool displayPrice)
        {
            InitializeComponent();

            foreach (DataRow dr in dt.Rows)
            {
                decimal price = Convert.ToDecimal(dr["Retail_Price"]);

                if (m_Pos > 3)
                {
                    PageCount++;
                    m_Pos = 1;
                    m_TopF = 10f + PageCount * 98;//98 = detail.Height
                }

                if (m_Pos == 1) m_LeftF = 8f;
                else if (m_Pos == 2) m_LeftF = 148f;
                else if (m_Pos == 3) m_LeftF = 288f;

                XRLabel lbProduct = new XRLabel();
                XRBarCode lbBarCode = new XRBarCode();
                XRLabel lbPrice = new XRLabel();

                lbProduct.TopF = m_TopF;
                lbProduct.LeftF = m_LeftF;
                lbProduct.WidthF = m_WidthF;
                lbProduct.HeightF = m_HeightFProduct;
                lbProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
                lbProduct.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
                lbProduct.Text = Convert.ToString(dr["Product_ID"]);

                lbBarCode.TopF = m_TopF + m_HeightFProduct;
                lbBarCode.LeftF = m_LeftF;
                lbBarCode.WidthF = m_WidthF;
                lbBarCode.HeightF = m_HeightFBarcode;
                lbBarCode.Symbology = new Code128Generator();
                lbBarCode.ShowText = false;
                lbBarCode.Font = new System.Drawing.Font("Times New Roman", 8.25F);
                lbBarCode.AutoModule = true; //
                lbBarCode.Text = Convert.ToString(dr["Barcode"]);
                ((Code128Generator)lbBarCode.Symbology).CharacterSet = Code128Charset.CharsetB;

                lbPrice.TopF = m_TopF + m_HeightFProduct + m_HeightFBarcode;
                lbPrice.LeftF = m_LeftF;
                lbPrice.WidthF = m_WidthF;
                lbPrice.HeightF = m_HeightFPrice;
                lbPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
                lbPrice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
                lbPrice.Text = price.ToString("##,##0.###") + " vnđ";
                lbPrice.Visible = displayPrice;

                Detail.Controls.Add(lbPrice);
                Detail.Controls.Add(lbProduct);
                Detail.Controls.Add(lbBarCode);

                m_Pos++;
            }
        }

    }
}
