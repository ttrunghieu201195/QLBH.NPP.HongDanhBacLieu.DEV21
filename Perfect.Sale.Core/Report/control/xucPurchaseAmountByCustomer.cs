using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;

namespace Perfect.Sale.Core.Report.control
{
    public partial class XucPurchaseAmountByCustomer : xucBasicListL3
    {
        public XucPurchaseAmountByCustomer(ListType style)
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
            SysLog.Insert("Báo cáo doanh thu", "Xem");
            //pURCHASE_PurchaseAmountByCustomerTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //pURCHASE_PurchaseAmountByCustomerTableAdapter.Fill(
            //    dsSaleAmountByCustomer.PURCHASE_PurchaseAmountByCustomer, "",
            //    Bar.From, Bar.To);

            buy_By_Provider_HeaderTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            buy_By_Provider_HeaderTableAdapter.ClearBeforeFill = true;
            buy_By_Provider_HeaderTableAdapter.Fill(dsSaleAmountByCustomer.Buy_By_Provider_Header, Bar.From, Bar.To);


            buy_By_Provider_DetailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            buy_By_Provider_DetailTableAdapter.ClearBeforeFill = true;
            buy_By_Provider_DetailTableAdapter.Fill(dsSaleAmountByCustomer.Buy_By_Provider_Detail, Bar.From, Bar.To);

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

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiCustomerReceipt")) return;

            //Get Object 
            object arg = gbList_Header.GetRowCellValue(gbList_Header.FocusedRowHandle, "ID");
            if (arg == null) return;
            object refid = gbList_Header.GetRowCellValue(gbList_Header.FocusedRowHandle, "RefID");
            if (refid == null) return;

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) return;

            SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", refid.ToString());

            if (Delete(arg.ToString()) == "OK")
            {
                Reload();
            }
        }


        private string Delete(string id)
        {
            var cls = new CUSTOMER_RECEIPT();

            if (!cls.Delete(id, ""))
            {
                // XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "Không xóa được!";
            }
            return "OK";
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiCustomerReceipt")) return;
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList_Header;
            SysLog.Insert("Báo cáo bán hàng", "Xuất");
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