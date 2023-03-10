using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.ERP;
using Perfect.Data.Helper;
using Perfect.Sale.Core.DEBT.CUSTOMER.REPORT;
using DevExpress.XtraReports.UI;

namespace Perfect.Sale.Core.DEBT.CUSTOMER
{
    public partial class xucSummary : Perfect.Common.xucBasicListL3
    {
        public xucSummary()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            //CreateWaitDialog();
            Cursor.Current = Cursors.WaitCursor;
            //sTOCKTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            //sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
            //List_Init(gbList);
           
            //Bar.All = true;
            //Bar.IsStock = false;
            //Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Cursor.Current = Cursors.Default;
        }

        public override void Reload()
        {
            Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            DoHide();
            Cursor.Current = Cursors.Default;
            Enabled = true;
        }

        public void SetColumns(int action)
        {
           
        }

        public void SetData(string product_id, string product_name)
        {
           
            SysLog.Insert("Tổng Hợp Công Nợ Phải Thu", "Xem");

            sUMMARYTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sUMMARYTableAdapter.Fill(dsDEBT.SUMMARY);

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
           // if (!MyRule.IsPrint("bbiInventory")) return;
            SysLog.Insert("Tổng Hợp Công Nợ Phải Thu", "In");
            if (dsDEBT.SUMMARY.Rows.Count!=0)
            {
                var rpt = new rptSummary(dsDEBT.DETAIL, "Tổng Hợp Công Nợ Phải Thu",
                                                                     gbList.ActiveFilterString);
                rpt.ShowRibbonPreview();
            }
            
            
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            //if (!MyRule.IsExport("bbiInventory"))
            //{
                
            //    return false;
            //}
            

            SysLog.Insert("Tổng Hợp Công Nợ Phải Thu", "Xuất");

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
            
            //Get Object 
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

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}