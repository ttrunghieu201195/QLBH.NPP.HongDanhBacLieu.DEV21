using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory;

namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    public partial class XucDebtSummaryDetail : xucBasicListL3
    {
        public XucDebtSummaryDetail(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style == ListType.Detail)
            {
                DetailView();
            }
            Init();
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
            SysLog.Insert("Bảng Kê Tổng Hợp Công Nợ Thu", "Xem");


            gET_DebtSummaryDetailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            gET_DebtSummaryDetailTableAdapter.Fill(dsDebtSummaryDetail.GET_DebtSummaryDetail, Bar.From, Bar.To);

            //Total();
        }

        public override void Detail()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (arg == null) return;
            SetData(arg.ToString());
        }

        private void SetData(string id)
        {
            Edit();
        }

        public override void Add()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (arg == null) return;
            InvokeAddNewClick2(arg.ToString());
        }

        public override void Edit()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (arg == null) return;
            RaiseSendIdEventHander(arg.ToString());
        }

        public override void Delete()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            object refid = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefID");
            if (refid == null) return;

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) return;
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
            if (!MyRule.IsPrint("bbiReciept")) return;

            //if (gbList.RowCount == 0)
            //{
            //    XtraMessageBox.Show("Không có dữ liệu để in.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string from = SYS_OPTION.Language == "VN" ? "Từ " : "From ";
            //string to = SYS_OPTION.Language == "VN" ? " đến " : " to ";


            //var rpt = new rptInwardList(dsSTOCK_INWARD_DETAIL.STOCK_INWARD_ByDate, "RD0000016", "Bảng Kê Nhập Kho", from + Strings.Format(From, "dd/MM/yyyy") + to + Strings.Format(To, "dd/MM/yyyy"));
            //rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            if (!MyRule.IsExport("bbiReciept")) return false;
            _exportView = gbList;
            SysLog.Insert("Bảng Kê Nhập Kho", "Xuất");
            return true;
        }

        public override void History()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public override void ProductDetail()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;

            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        public override void Inventory()
        {
            //Get Object 
            object arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(product.Product_ID, "");
            xfmInventoryDetail.ShowDialog(this);
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
            Detail();
        }
    }
}