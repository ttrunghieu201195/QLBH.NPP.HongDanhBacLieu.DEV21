using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Sale.Core.Report.control
{
    public partial class XucSaleAmountByProvince : xucBasicListL3
    {
        public XucSaleAmountByProvince(ListType style)
        {
            InitializeComponent();
            //Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style == ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        private new void Init()
        {
            base.Init();

            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Reload()
        {
            sALE_SaleAmountByProvinceTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sALE_SaleAmountByProvinceTableAdapter.Fill(dsSaleAmountByProvince.SALE_SaleAmountByProvince, "", Bar.From,
                                                       Bar.To);
        }


        protected override void Print()
        {
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            return true;
        }


        private void GbListClick(object sender, EventArgs e)
        {
            Detail();
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
        }
    }
}