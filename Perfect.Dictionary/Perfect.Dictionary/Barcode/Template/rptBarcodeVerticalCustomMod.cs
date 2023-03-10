using DevExpress.XtraReports.UI;
using System;
using DevExpress.XtraPrinting.BarCode;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace Perfect.Dictionary.Barcode.Template
{
    public partial class rptBarcodeVerticalCustomMod : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBarcodeVerticalCustomMod(DS.dsBarcode.PRODUCTDataTable dt, bool displayPrice)
        {
            InitializeComponent();

            float m_TopF = 28.82f;
            float m_LeftF = 0f;
            float m_WidthF = 122.63f;
            float m_HeightFProduct = 14.12f;
            float m_HeigthFBarCode = 36.64f;
            float m_HeightFPrice = 14.01f;
            int m_Index = 1;
            int m_ColumnIndex = 1;
            foreach (DataRow dr in dt.Rows)
            {
                if (m_ColumnIndex > 3) m_ColumnIndex = 1;

                if (m_ColumnIndex == 1) m_LeftF = 13.01f;
                else if (m_ColumnIndex == 2) m_LeftF = 150.35f;
                else if (m_ColumnIndex == 3) m_LeftF = 287.75f;

                if (m_Index != 1 && m_ColumnIndex == 1)
                    m_TopF = m_TopF + m_HeightFProduct + m_HeigthFBarCode + m_HeightFPrice + 28.82f + 2.54f;

                XRLabel lbProduct = new XRLabel();
                XRBarCode lbBarCode = new XRBarCode();
                XRLabel lbPrice = new XRLabel();

                lbProduct.LeftF = m_LeftF;
                lbProduct.WidthF = m_WidthF;
                lbProduct.HeightF = m_HeightFProduct;
                lbProduct.TopF = m_TopF;
                lbProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
                lbProduct.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
                lbProduct.Text = dr["Product_ID"].ToString();

                lbBarCode.LeftF = m_LeftF;
                lbBarCode.WidthF = m_WidthF;
                lbBarCode.HeightF = m_HeigthFBarCode;
                lbBarCode.TopF = m_TopF + m_HeightFProduct;
                lbBarCode.Symbology = new Code128Generator();
                lbBarCode.ShowText = false;
                lbBarCode.Font = new System.Drawing.Font("Times New Roman", 8.25F);
                lbBarCode.AutoModule = true; //
                lbBarCode.Text = Convert.ToString(dr["Barcode"]);
                ((Code128Generator)lbBarCode.Symbology).CharacterSet = Code128Charset.CharsetB;

                lbPrice.LeftF = m_LeftF;
                lbPrice.WidthF = m_WidthF;
                lbPrice.HeightF = m_HeightFPrice;
                lbPrice.TopF = m_TopF + m_HeightFProduct + m_HeigthFBarCode;
                lbPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
                lbPrice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
                lbPrice.Text = Convert.ToDecimal(dr["Retail_Price"]).ToString("##,##0.###") + " vnđ";
                Detail.Controls.Add(lbPrice);
                lbPrice.Visible = displayPrice;

                Detail.Controls.Add(lbProduct);
                Detail.Controls.Add(lbBarCode);

                m_Index++;
                m_ColumnIndex++;
            }
            
        }

        private void rptBarcodeVerticalCustomMod_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

    }
}
