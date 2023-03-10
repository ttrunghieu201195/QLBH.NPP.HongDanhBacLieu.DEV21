using System;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using DevExpress.XtraBars;

namespace Perfect.Sale.Core.Report.SaleQuantity
{
    public partial class XucSaleQuantityByEmp : xucBasicListL3
    {
        public XucSaleQuantityByEmp(ListType style)
        {
            InitializeComponent();
            //Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style==ListType.Detail)
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
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            //EmpInit();
            //Reload();
        }

        public override void Reload()
        {
            //saleForEmpTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //saleForEmpTableAdapter.ClearBeforeFill = true;
            //saleForEmpTableAdapter.Fill(dsSaleQuantity.SaleForEmp, Bar.From, Bar.To);

            eMPLOYEE_HeaderTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEE_HeaderTableAdapter.ClearBeforeFill = true;
            eMPLOYEE_HeaderTableAdapter.Fill(dsSaleQuantity.EMPLOYEE_Header, Bar.From, Bar.To);

            sale_DetailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sale_DetailTableAdapter.ClearBeforeFill = true;
            sale_DetailTableAdapter.Fill(dsSaleQuantity.Sale_Detail, Bar.From, Bar.To);

            buy_DetailTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            buy_DetailTableAdapter.ClearBeforeFill = true;
            buy_DetailTableAdapter.Fill(dsSaleQuantity.Buy_Detail, Bar.From, Bar.To);



        }
        

        private void EmpInit()
        {
            //eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //eMPLOYEETableAdapter.Fill(dsSaleQuantity.EMPLOYEE);
        }




       

       

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            SysLog.Insert("Báo cáo bán hàng theo nhân viên", "Xuất");
            return true;
        }

       

        

        private void GbListClick(object sender, EventArgs e)
        {
            Detail();
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

        private void gbList_Buy_Detail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void gbList_Sale_Detail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
    }
}