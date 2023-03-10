using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using DevExpress.XtraGrid.Views.Grid;

namespace Perfect.Sale.Core.PAYMENT
{
    public partial class XucList : xucBasicListL3
    {
        public XucList(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style==ListType.Detail)
            {
                DetailView();
            }
            Init();

            gbList.ShownEditor += GbListShownEditor;
        }

        private void GbListShownEditor(object sender, EventArgs e)
        {
            var view = sender as GridView;

            view.ActiveEditor.DoubleClick += ActiveEditorDoubleClick;
        
        }

        private void ActiveEditorDoubleClick(object sender, EventArgs e)
        {
            Detail();
        }

        private void Init()
        {
               base.Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            //Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveNew.Visibility = BarItemVisibility.Never;
            Bar.Bar.BbiSaveDataById.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveTemp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
      
           
        }

        public override void Reload()
        {

            if (!MyRule.IsAccess("bbiPayment"))
            {
                Options.CloseDialog();
                return;
            }
            pROVIDER_PAYMENTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDER_PAYMENTTableAdapter.Fill(dsDEBT.PROVIDER_PAYMENT, Bar.From, Bar.To);

        }
        
        public void Detail()
        {
            //object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            //if (arg == null) return;
            //SetData(arg.ToString());

            object arg = gbList.GetFocusedRowCellValue("ID");
            if (arg == null) return;

            var payment = new PROVIDER_PAYMENT();
            if (payment.Get(arg.ToString()))
            {
                var phieuChi = new XfmPhieuChi();
                phieuChi.Success += PhieuChiSuccess;
                phieuChi.SetData(payment);
                phieuChi.ShowDialog(this);
            }
        }

        private void PhieuChiSuccess()
        {
            Reload();
        }

        public void SetData(string id)
        {
            //ucDetail.SetData(ID);
            Edit();
            // Options.SetWaitDialogCaption("Hoàn Tất");
            // Options.CloseDialog();
        }

        public override void Edit()
        {
            if (!MyRule.IsEdit("bbiPayment")) return;

            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            object type = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType");
            if (type == null) return;
            RaiseChangedEventHander(arg.ToString(),Convert.ToInt32(type));
            RaiseSendIdEventHander(arg.ToString());
        }
        
        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiPayment")) return;
           
            //Get Object 
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "ID");
            if (arg == null) return;
            object refid = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefID");
            if (refid == null) return;

            object refOrgNo = gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefOrgNo");
            if (refOrgNo == null) return;

            if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SysLog.Insert("Bảng Kê Phiếu Chi", "Xoá", refid.ToString());

            if (Delete(arg.ToString(), refOrgNo.ToString()) == "OK")
            {
                Reload();
            }
        }


        private string Delete(string id, string refOrgNo)
        {

            var cls = new PROVIDER_PAYMENT();
            return !cls.Delete2011(id,refOrgNo) ? "Không xóa được!" : "OK";
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiPayment")) return;
           
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
            if (!MyRule.IsExport("bbiPayment")) return false;
            _exportView = gbList;
            return true;
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

        private void gbList_MouseDown(object sender, MouseEventArgs e)
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