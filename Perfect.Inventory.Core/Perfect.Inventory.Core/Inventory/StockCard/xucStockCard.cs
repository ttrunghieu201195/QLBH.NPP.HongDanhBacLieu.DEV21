using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Perfect.Common.Base;
using Perfect.Data.Helper;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.StockCard
{
    public partial class xucStockCard : xucBasicListSearchProduct
    {
        public xucStockCard()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            base.Init();
            Bar.ShowProduct();
            Bar.Stock_Init();
        }

        public override void Reload()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if(Bar.Stock == "")
            {
                DoHide();
                return;
            }


            sTOCK_CARDTableAdapter1.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCK_CARDTableAdapter1.ClearBeforeFill = true;
            if(string.IsNullOrEmpty(Bar.Id) && string.IsNullOrEmpty(Bar.Text))
            {
                sTOCK_CARDTableAdapter1.FillAllProduct(dsStock_Card.STOCK_CARD, Bar.From, Bar.To, Bar.Stock);    
            }
            else
            {
                sTOCK_CARDTableAdapter1.FillOneProduct(dsStock_Card.STOCK_CARD, Bar.From, Bar.To, Bar.Stock, "%" + Bar.Id + "%", "%" + Bar.Text + "%");    
            }
            DoHide();
        }

        //protected override bool ExportPermision()
        //{
            //ExportView = gbList;            
            //return true;
        //}

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            return true;
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsStock_Card.STOCK_CARD.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }
        }

        protected override void Print()
        {
            var rpt = new rptStockCard(dsStock_Card.STOCK_CARD, "RD0000019", "Thẻ Kho",
                                       "Từ " + String.Format("{0:dd/MM/yyyy}", Bar.From) + " đến " +
                                       String.Format("{0:dd/MM/yyyy}", Bar.To));
            rpt.ShowPreview();

        }
    }
}
