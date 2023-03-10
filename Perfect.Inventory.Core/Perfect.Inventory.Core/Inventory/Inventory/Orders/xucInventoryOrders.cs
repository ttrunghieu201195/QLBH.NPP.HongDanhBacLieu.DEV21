using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Report;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    public partial class xucInventoryOrders : xucDetailList
    {
       
        public xucInventoryOrders()
        {
            InitializeComponent();
            Init();
        }
     
        void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Stock_Init();
            Unit_Init();
            Bar.Stock_Init();
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            _exportView = gbList;
            SysLog.Insert("Yêu Cầu Đặt Hàng", "Xem");
            DoHide();
        }

        private void Stock_Init()
        {
            var adapter = new STOCKTableAdapter();
            adapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsSTOCK.STOCK);
        }

        private void Unit_Init()
        {
            var adapter = new UNITTableAdapter();
            adapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsUnit.UNIT);
        }

        public override void Reload()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData();
            DoHide();
        }

        void  SetData()
        {
            if (Bar.Stock == "") return;

            iNVENTORY_Order_WarningTableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            iNVENTORY_Order_WarningTableAdapter.Fill(dsInventoryOrder.INVENTORY_Order_Warning, Bar.Stock, "%" + Bar.Id + "%", "%" + Bar.Text + "%", -1);
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventory")) return false;

            SysLog.Insert("Yêu Cầu Đặt Hàng", "Xuất");

            return base.ExportPermision();

        }

        public override void ProductDetail()
        {
            object Arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
          //Get Object 
            object Arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            xfmHistory xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public void DisableMenu(bool disable)
        {
             Bar.Bar.bbiPrint.Enabled = !disable;
             Bar.Bar.bbiExport.Enabled = !disable;
             Bar.Bar.bbiProduct.Enabled = !disable;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsInventoryOrder.INVENTORY_Order_Warning.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }

            object Arg = gbList.GetFocusedRowCellValue("Product_ID");

            Bar.Bar.bbiProduct.Enabled = true;
            if (Arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                //e.TotalValue = Convert.ToDouble(colQuantity.SummaryItem.SummaryValue) == 0 ? 0 : Convert.ToDouble(colAmount.SummaryItem.SummaryValue) /
                //            Convert.ToDouble(colQuantity.SummaryItem.SummaryValue);

                double amount = 0.0;
                double Quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                    Quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = amount / Quantity;
            }
        }

        public override void Print()
        {
            SysLog.Insert("Yêu Cầu Đặt Hàng", "In");

            if (dsInventoryOrder.INVENTORY_Order_Warning.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var rpt = new rptInventoryOrders(dsInventoryOrder.INVENTORY_Order_Warning,"RD0000005","Tồn Kho","");
            rpt.ShowPreview();


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

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }

    }
}
