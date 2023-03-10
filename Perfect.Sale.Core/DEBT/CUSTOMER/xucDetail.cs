using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    public partial class xucDebtTime : xucBasicListL3
    {
        public xucDebtTime(ListType style)
        {
            InitializeComponent();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style == ListType.Detail)
            {
                DetailView();
            }
            Init();

        }

       public void Init()
        {
           base.Init();
            Cursor.Current = Cursors.WaitCursor;
            
            gET_DEBTDETAILTableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            gET_DEBTDETAILTableAdapter.Fill(dsDebtDetails.GET_DEBTDETAIL);
            
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Cursor.Current = Cursors.Default;
        }

        public override void Reload()
        {
            Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            //SetData(Bar.Id, Bar.Text);
            DoHide();
            Cursor.Current = Cursors.Default;
            Enabled = true;
        }

        public void SetColumns(int action)
        {
           
        }

        public void SetData(string product_id, string product_name)
        {
           
            SysLog.Insert("Chi Tiết Công Nợ Phải Thu", "Xem");

        }

        private void Total()
        {
            double Amount = 0.0;
            double Quantity = 0.0;
            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount +=
                    Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Amount"));
                Quantity +=
                    Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Quantity"));
            }
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiCustomerReceipt")) return;

            //Cursor.Current = Cursors.WaitCursor;
            //SYS_LOG.Insert("Chi Tiết Công Nợ Phải Thu", "In");
            //if (dsDEBT.DETAIL.Rows.Count!=0)
            //{
            //    DEBT.CUSTOMER.REPORT.rptDetail rpt=new rptDetail(dsDEBT.DETAIL,"Chi Tiết Công Nợ Phải Thu",gbList.ActiveFilterString);
            //    Cursor.Current = Cursors.Default;
            //    rpt.ShowRibbonPreview();
            //}
            //Cursor.Current = Cursors.Default;
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            //if (!MyRule.IsExport("bbiInventory"))
            //{
                
            //    return false;
            //}
            

            SysLog.Insert("Chi Tiết Công Nợ Phải Thu", "Xuất");

            return base.ExportPermision();

        }


        public override void ProductDetail()
        {
           
        }

        public override void History()
        {
            
        }

        public void DisableMenu(bool disable)
        {
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            //DisableMenu(false);
            //if (dsDEBT.DETAIL.Rows.Count == 0)
            //{
            //    DisableMenu(true);
            //    return;
            //}
            
            ////Get Object 
            //object Arg = gbList.GetFocusedRowCellValue("Product_ID");

            //Bar.Bar.bbiProduct.Enabled = true;
            //if (Arg == null)
            //{
            //    Bar.Bar.bbiProduct.Enabled = false;
            //    return;
            //}
            ////PRODUCT product = new PRODUCT();
            ////product.Get(Arg.ToString());
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

        protected override void Copy()
        {
            gbList.CopyToClipboard();
        }
    }
}