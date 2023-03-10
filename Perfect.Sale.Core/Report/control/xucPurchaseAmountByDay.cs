using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Sale.Core.Report.control
{
    public partial class XucPurchaseAmountByDay : xucBasicListL3
    {
        public XucPurchaseAmountByDay(ListType style)
        {
            InitializeComponent();
            //Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            
            if (style==ListType.Detail)
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
            buy_Revenue_By_DateTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            buy_Revenue_By_DateTableAdapter.ClearBeforeFill = true;
            buy_Revenue_By_DateTableAdapter.Fill(dsSaleAmountByDay.Buy_Revenue_By_Date, Bar.From, Bar.To);


        }
        
        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            SetData();
        }

        private void SetData()
        {
            Edit();
        }

        public override void Edit()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            object type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            if (type == null) return;
            RaiseChangedEventHander(arg.ToString(),Convert.ToInt32(type));
            RaiseSendIdEventHander(arg.ToString());
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

        private void GbListCustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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