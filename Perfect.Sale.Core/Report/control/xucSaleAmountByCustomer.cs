using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Sale.Core.Report.control
{
    public partial class XucSaleAmountByCustomer : xucBasicListL3
    {
        public XucSaleAmountByCustomer(ListType style)
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
            sale_By_Customer_HeaderTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sale_By_Customer_HeaderTableAdapter.ClearBeforeFill = true;
            sale_By_Customer_HeaderTableAdapter.Fill(dsSaleAmountByCustomer.Sale_By_Customer_Header, Bar.From, Bar.To);

            sale_By_Customer_DetailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sale_By_Customer_DetailTableAdapter.ClearBeforeFill = true;
            sale_By_Customer_DetailTableAdapter.Fill(dsSaleAmountByCustomer.Sale_By_Customer_Detail, Bar.From, Bar.To);

        }

        public override void Detail()
        {
            object arg = gbList_Header.GetRowCellValue(gbList_Header.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData();
        }

        private void SetData()
        {
            Edit();
        }

        public override void Edit()
        {
            object arg = gbList_Header.GetRowCellValue(gbList_Header.FocusedRowHandle, "ID");
            if (arg == null) return;
            object type = gbList_Header.GetRowCellValue(gbList_Header.FocusedRowHandle, "RefType");
            if (type == null) return;
            RaiseChangedEventHander(arg.ToString(), Convert.ToInt32(type));
            RaiseSendIdEventHander(arg.ToString());
        }


        protected override void Print()
        {
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList_Header;
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
            if (gbList_Header.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            object arg = gbList_Header.GetFocusedRowCellValue("Product_ID");
            Bar.Bar.bbiProduct.Enabled = false;
            if (arg != null)
            {
                Bar.Bar.bbiProduct.Enabled = true;
            }
        }
    }
}