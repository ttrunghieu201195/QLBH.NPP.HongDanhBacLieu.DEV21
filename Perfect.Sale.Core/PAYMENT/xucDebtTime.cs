using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Sale.Core.PAYMENT
{
    public partial class xucSaleAmountByDay : xucDetailList
    {
        public xucSaleAmountByDay()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            //gET_DEBTDETAILTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //gET_DEBTDETAILTableAdapter.Fill(dsDebtDetails.GET_DEBTDETAIL);

            sp_DEBT_GetInfoForProviderTableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            sp_DEBT_GetInfoForProviderTableAdapter.Fill(dsDebtTime.sp_DEBT_GetInfoForProvider);
           
            Bar.All = true;
            Bar.IsStock = false;
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Cursor.Current = Cursors.Default;
        }



   


        protected override void StockChanged(object value)
        {
            //base.StockChanged(value);
            
        }

        public override void Reload()
        {
            Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData(Bar.Id, Bar.Text);
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

            //dETAILTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //dETAILTableAdapter.Fill(dsDEBT.DETAIL);

        }

        private void Total()
        {
            double Amount = 0.0;
            double Quantity = 0.0;
            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount +=Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Amount"));
                Quantity +=Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Quantity"));
            }
        }

        public override void Print()
        {
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

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {

        }

        
    }
}