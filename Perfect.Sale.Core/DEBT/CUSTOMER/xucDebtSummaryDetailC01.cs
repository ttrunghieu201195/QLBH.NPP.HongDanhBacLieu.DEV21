using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory;
using Perfect.Sale.Core.DEBT.CUSTOMER.REPORT;

namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    public partial class xucDebtSummaryDetailC01 : xucBasicListL3
    {
        public xucDebtSummaryDetailC01(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Init();
            Reload();
        }

        private new void Init()
        {
            // SetInterface();
            base.Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;

            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveNew.Visibility = BarItemVisibility.Never;
            Bar.Bar.BbiSaveDataById.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveTemp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Reload()
        {
            var debt = new Perfect.ERP.DEBT();
            DataTable dt = debt.GetListDebtSummaryDetailC(Bar.From, Bar.To, "All");
            dsDebtSummaryDetail.CUSTOMER_DEBT_SUM.Rows.Clear();
            dsDebtSummaryDetail.CUSTOMER_DEBT_SUM.Merge(dt);
        }

        protected override void Print()
        {
            gcList.ShowPrintPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            return true;
        }

        private void GbListClick(object sender, EventArgs e)
        {
            //Detail();
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

        private void GbListKeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void gbListChild_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
    }
}