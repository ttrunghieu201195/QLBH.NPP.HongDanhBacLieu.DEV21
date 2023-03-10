using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;

namespace Perfect.Sale.Core.DEBT.PROVIDER
{
    public partial class xucDetail : xucDetailList
    {
        public xucDetail()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
           Cursor.Current = Cursors.WaitCursor;
            //sTOCKTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
            //List_Init(gbList);
           
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

        public void SetData(string productID, string productName)
        {
           
            SysLog.Insert("Tồn Kho", "Xem");

            dETAILTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            dETAILTableAdapter.Fill(dsDEBT.DETAIL);

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

        public override void Print()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (!MyRule.IsPrint("bbiInventory")) return;
            
            SysLog.Insert("Tồn Kho", "In");

            
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventory"))
            {
                
                return false;
            }
            

            SysLog.Insert("Tồn Kho", "Xuất");

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
            DisableMenu(false);
            if (dsDEBT.DETAIL.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }
            
            object arg = gbList.GetFocusedRowCellValue("Product_ID");

            Bar.Bar.bbiProduct.Enabled = true;
            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
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