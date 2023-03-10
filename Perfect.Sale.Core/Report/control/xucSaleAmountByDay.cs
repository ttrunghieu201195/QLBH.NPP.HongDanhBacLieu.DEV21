using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;

namespace Perfect.Sale.Core.Report.control
{
    public partial class XucSaleAmountByDay : xucBasicListL3
    {
        public XucSaleAmountByDay(ListType style)
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
            SysLog.Insert("Doanh Thu Theo Ngày", "Xem");
            sale_Revenue_By_DayTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sale_Revenue_By_DayTableAdapter.ClearBeforeFill = true;
            sale_Revenue_By_DayTableAdapter.Fill(dsSaleAmountByDay.Sale_Revenue_By_Day, Bar.From, Bar.To);
        }

        public override void Detail()
        {
            //object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            //if (arg == null) return;
            //SetData();
        }

        //private void SetData()
        //{
        //    Edit();
        //}

        //public override void Edit()
        //{
        //    object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
        //    if (arg == null) return;
        //    object type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
        //    if (type == null) return;
        //    RaiseChangedEventHander(arg.ToString(), Convert.ToInt32(type));
        //    RaiseSendIdEventHander(arg.ToString());
        //}


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