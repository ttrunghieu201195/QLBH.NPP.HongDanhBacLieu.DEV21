using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.Forms;
using Perfect.Sale.Core.REICEIPT;
using Perfect.Sale.Core.DEBT.CUSTOMER.REPORT;

namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    public partial class XucDebtDetails : xucBasicListL3
    {
        public XucDebtDetails(ListType style)
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
            base.Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;// sua chua
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;

            Bar.Bar.bbiSaveNew.Visibility = BarItemVisibility.Never;
            Bar.Bar.BbiSaveDataById.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveTemp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Caption = @"Lập phiếu thu";

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Reload()
        {
            gET_DEBTDETAILTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            gET_DEBTDETAILTableAdapter.Fill(dsDebtDetails.GET_DEBTDETAIL, Bar.From, Bar.To);

            detailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            detailTableAdapter.Fill(dsDebtDetails.Detail);
            gbList.ExpandAllGroups();
        }


        public override void Detail()
        {
            object phieu = gbList.GetFocusedRowCellValue("ChungTu");
            if (phieu == null) return;
            object soTien = gbList.GetFocusedRowCellValue("SoTien");
            if (soTien == null) return;
            object daTra = gbList.GetFocusedRowCellValue("DaTra");
            if (daTra == null) return;
            object conLai = gbList.GetFocusedRowCellValue("ConLai");
            if (conLai == null) return;
            object ngay = gbList.GetFocusedRowCellValue("Ngay");
            if (ngay == null) return;
            object customerID = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (customerID == null) return;
            object customerAddress = gbList.GetRowCellValue(gbList.FocusedRowHandle, "CustomerAddress");
            if (customerAddress == null) return;
            object debtID = gbList.GetFocusedRowCellValue("ID");
            if (debtID == null) return;
            object debtRefOrgNo = gbList.GetFocusedRowCellValue("RefOrgNo");
            if (debtRefOrgNo == null) return;
            var phieuThu = new XfmPhieuThu();
            phieuThu.Success += PhieuThuSuccess;
            phieuThu.SetData(customerAddress.ToString(), customerID.ToString(), phieu.ToString(),
                             Convert.ToDateTime(ngay), Convert.ToDecimal(soTien), Convert.ToDecimal(daTra),
                             Convert.ToDecimal(conLai), new Guid(debtID.ToString()), new Guid(debtRefOrgNo.ToString()));
            phieuThu.ShowDialog(this);
        }

        private void PhieuThuSuccess()
        {
            Reload();
        }

        public void SetData(string id)
        {
            Edit();
        }

        public override void Edit()
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Customer_ID");
            if (arg == null) return;
            RaiseSendIdEventHander(arg.ToString());
        }

        public override void Add()
        {
            Detail();
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