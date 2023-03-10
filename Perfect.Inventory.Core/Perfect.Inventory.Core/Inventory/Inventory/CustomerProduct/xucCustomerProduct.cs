using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Report;
using Perfect.Net.Info;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    public partial class xucCustomerProduct : xucDetailList
    {
        public xucCustomerProduct()
        {
            InitializeComponent();
            Init();
            Bar.IsStock = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        private void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetWaitDialogCaption("Đang nạp danh sách đơn vị tính...");
            Unit_Init();
            SetWaitDialogCaption("Đang nạp danh sách kho hàng...");
            Stock_Init();
           // iNVENTORY_DETAIL_SUMMARYTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            DoHide();
        }

        public void Stock_Init()
        {
            //STOCKTableAdapter adapter = new STOCKTableAdapter();
            //adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //adapter.Fill(dsSTOCK.STOCK);
        }

        public void Unit_Init()
        {
            //UNITTableAdapter adapter = new UNITTableAdapter();
            //adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //adapter.Fill(dsUnit.UNIT);
        }
   
        public override void Reload()
        {
            //this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xem");
            SetData(Bar.From,Bar.To);
            DoHide();
            Cursor.Current = Cursors.Default;
            //this.Enabled = true;
        }

        public void SetData(DateTime from,DateTime to)
        {
            //var result = from c in dsCUSTOMERPRODUCT.Tables[0] select c 

            cUSTOMERPRODUCTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMERPRODUCTTableAdapter.Fill(dsCUSTOMERPRODUCT.CUSTOMERPRODUCT, from, to);
          
        }

        public override void Print()
        {
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) || string.IsNullOrEmpty(MyInfo.Tel) || string.IsNullOrEmpty(MyInfo.Fax))
            {
                XtraMessageBox.Show("Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            if (!MyRule.IsPrint("bbiInventorySummary")) return;

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";
            SysLog.Insert("Bảng Kê Xuất Kho", "In");

           

            //rptSummary rpt = new rptSummary(dsSummary.INVENTORY_DETAIL_SUMMARY, "RD0000027","Tổng Hợp Xuất Nhập Tồn",from + Strings.Format(Bar.From, "dd/MM/yyyy") + to + Strings.Format(Bar.To, "dd/MM/yyyy"),gbList.ActiveFilterString);

           // rpt.ShowPreview();
            var rpt = new rptCustomerProduct("", dsCUSTOMERPRODUCT.CUSTOMERPRODUCT, "Bảng Kê Xuất Kho",
                                                            from + Strings.Format(Bar.From, "dd/MM/yyyy") + to +
                                                            Strings.Format(Bar.To, "dd/MM/yyyy"),
                                                            gbList.ActiveFilterString);
            rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventorySummary")) return false;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xuất");
            DoHide();
            return base.ExportPermision();

        }

        public override void ProductDetail()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
          
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
           
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
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
            if(dsCUSTOMERPRODUCT.CUSTOMERPRODUCT.Rows.Count==0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
   
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            Bar.Bar.bbiProduct.Enabled = true;
            if (arg == null)
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
                double quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                    quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = amount/quantity;
            }
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
    }
}
