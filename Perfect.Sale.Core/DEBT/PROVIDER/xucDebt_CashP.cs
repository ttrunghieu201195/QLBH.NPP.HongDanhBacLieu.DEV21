using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Sale.Core.PAYMENT;

namespace Perfect.Sale.Core.DEBT.PROVIDER
{
    public partial class xucDebt_CashP : xucBasicListL3
    {
        public xucDebt_CashP()
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            InitGUI();
            DetailView();
            //Reload();
        }

        private void InitGUI()
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
            Bar.Bar.bbiAdd.Caption = @"Lập phiếu chi";

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Reload()
        {
            Perfect.ERP.DEBT dbt = new Perfect.ERP.DEBT();
            gcList.DataSource = dbt.GetListPaied(1, "TM", Bar.From, Bar.To);
            gbList.ExpandAllGroups();
            DisableMenu(false);
        }

        public override void Add()
        {
            string InvoiceID = Convert.ToString(gbList.GetFocusedRowCellValue(colRefID));
            if (InvoiceID == "") return;

            DateTime RefDate = Convert.ToDateTime(gbList.GetFocusedRowCellValue(colRefDate));
            string CustomerID = Convert.ToString(gbList.GetFocusedRowCellValue(colCustomerID));
            string CustomerAddress = Convert.ToString(gbList.GetFocusedRowCellValue(colCustomerAddress));
            Guid DebtID = (Guid)gbList.GetFocusedRowCellValue(colID);
            Guid ReceiptID = Guid.NewGuid();

            decimal Amount = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colAmount));
            decimal Payment = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colPayment));
            decimal Balance = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colBalance));

            if (Balance == 0) return;
            var phieuChi = new XfmPhieuChi();
            phieuChi.Success += () =>
            {
                Reload();
            };
            phieuChi.SetData(CustomerAddress, CustomerID, InvoiceID, RefDate, Amount, Payment, Balance, ReceiptID, DebtID);
            phieuChi.ShowDialog(this);
        }
        protected override bool ExportPermision()
        {
            _exportView = gbList;
            SysLog.Insert("Bảng Kê Nhập Kho", "Xuất");
            return true;
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void gbList_DoubleClick(object sender, EventArgs e)
        {
            Add();
        }
    }
}
