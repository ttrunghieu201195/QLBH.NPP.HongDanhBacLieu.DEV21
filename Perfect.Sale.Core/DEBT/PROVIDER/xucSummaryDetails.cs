using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using DevExpress.XtraBars;
using Perfect.Sale.Core.PAYMENT;
using Perfect.Inventory.Core.Common.Forms;

namespace Perfect.Sale.Core.DEBT.PROVIDER
{
    public partial class XucSummaryDetails : xucBasicListL3
    {
        public XucSummaryDetails(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style==ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        public new void Init()
        {

            base.Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Caption = @"Lập phiếu chi";

            Bar.Bar.bbiSaveNew.Visibility = BarItemVisibility.Never;
            Bar.Bar.BbiSaveDataById.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveTemp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            
        }

        public override void Reload()
        {
            gET_DEBTSummaryDetailsProvTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            gET_DEBTSummaryDetailsProvTableAdapter.Fill(dsSummaryDetails.GET_DEBTSummaryDetailsProv, Bar.From, Bar.To);

            detailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            detailTableAdapter.Fill(dsSummaryDetails.Detail);
        }
        
        public override void Detail()
        {
            var arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (arg == null) return;
            var phieu = gbList.GetFocusedRowCellValue("ChungTu");
            if (phieu == null) return;
            var soTien = gbList.GetFocusedRowCellValue("SoTien");
            if (soTien == null) return;
            var daTra = gbList.GetFocusedRowCellValue("DaTra");
            if (daTra == null) return;
            var conLai = gbList.GetFocusedRowCellValue("ConLai");
            if (conLai == null) return;
            var ngay = gbList.GetFocusedRowCellValue("Ngay");
            if (ngay == null) return;

            var address = gbList.GetFocusedRowCellValue("CustomerAddress");
            if (address == null) return;
            var debtID = gbList.GetFocusedRowCellValue("ID");
            if (debtID == null) return;

            var debtRefOrgNo = gbList.GetFocusedRowCellValue("RefOrgNo"); // CHứng từ bên bản Debt
            if (debtRefOrgNo == null) return;
         
            var phieuChi = new XfmPhieuChi();
            phieuChi.Success += PhieuChiSuccess;
            phieuChi.SetData(address.ToString(), arg.ToString(), phieu.ToString(), Convert.ToDateTime(ngay), Convert.ToDecimal(soTien), Convert.ToDecimal(daTra), Convert.ToDecimal(conLai), new Guid(debtID.ToString()), new Guid(debtRefOrgNo.ToString()));
            phieuChi.ShowDialog(this);
        }
        void PhieuChiSuccess()
        {
            Reload();
        }
        public void SetData(string id)
        {
            Cursor.Current = Cursors.WaitCursor;
            Edit();
            Cursor.Current = Cursors.Default;
        }
        public override void Add()
        {
            Detail();
        }
        public override void Edit()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (arg == null) return;
            RaiseSendIdEventHander(arg.ToString());
        }
        
        public override void Delete()
        {
           // if (!MyRule.IsDelete("bbiCustomerReceipt")) return;
           
            //Get Object 
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            object refid = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefID");
            if (refid == null) return;

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SysLog.Insert("Bảng Kê Nhập Kho", "Xoá", refid.ToString());

            if (Delete(arg.ToString()) == "OK")
            {
                Reload();
            }
        }


        public string Delete(string id)
        {

            var cls = new CUSTOMER_RECEIPT();

            if (!cls.Delete(id,""))
            {
               // XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "Không xóa được!";
            }
            return "OK";
        }

        protected override void Print()
        {
           // if (!MyRule.IsPrint("bbiCustomerReceipt")) return;
           
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
            int option = -1;
            xfmExportGridviewOptions frm = new xfmExportGridviewOptions();
            frm.OptionsSelected += (opt) =>
            {
                option = opt;
            };
            frm.ShowDialog();
            if (option == -1) return false;
            gbList.OptionsPrint.PrintDetails = option == 1;
            gbList.OptionsPrint.ExpandAllDetails = option == 1;

            _exportView = gbList;
            SysLog.Insert("Bảng Kê Nhập Kho", "Xuất");
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
        private void GbListKeyPress(object sender, KeyPressEventArgs e)
        {
           Detail();
        }
    }
}