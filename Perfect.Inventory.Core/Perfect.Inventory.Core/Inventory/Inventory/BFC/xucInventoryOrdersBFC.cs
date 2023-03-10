using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Perfect.Dictionary;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Report;
using Perfect.Inventory;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory
{
    public partial class xucInventoryOrdersBFC : Perfect.Common.xucBase
    {
        public xucInventoryOrdersBFC()
        {
            InitializeComponent();
            Init();
            bm.SetPopupContextMenu(gcList,pm);
            _exportView = gbList;
        }

        public void Init()
        {
            Stock_Init();
            Unit_Init();
        }

        public void Stock_Init()
        {
            STOCKTableAdapter adapter = new STOCKTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsSTOCK.STOCK);
        }

        public void Unit_Init()
        {
            UNITTableAdapter adapter = new UNITTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsUnit.UNIT);
        }




        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbxStock.SelectedValue == null) return;
            

            iNVENTORY_ORDERTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            iNVENTORY_ORDERTableAdapter.Fill(dsInventoryOrder.INVENTORY_ORDER,cbxStock.SelectedValue.ToString(), "%" + txtProductID.Text + "%", "%" + txtProductName.Text + "%", -1);
        }
        public void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "Stock_Date":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Ngày";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Product_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Mã hàng";
                        dt.Columns[i].Width = 80;
                        break;
                    case "ProductName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Hàng hóa";
                        dt.Columns[i].Width = 170;
                        break;

                    case "Quantity":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Số lượng";
                        dt.Columns[i].Width = 80;
                        break;
                    case "UnitPrice":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Đơn giá";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Amount":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Thành tiền";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        private void Total()
        {
            double Amount = 0.0;
            double Quantity = 0.0;
            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                Quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
            }

            txtTotal.Value = Convert.ToDecimal(Amount);
            txtQuantity.Value = Convert.ToDecimal(Quantity);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbxStock.SelectedValue==null)   return;
            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            //xfmReportManager frm = new xfmReportManager("RD0000006");
            //frm.Show();
            rptInventoryBFC rpt=new rptInventoryBFC(cbxStock.SelectedValue.ToString(),cbxStock.Text);
            rpt.ShowPreview();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK") return;
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
                return;
            }
            Export(gbList);
        }

        
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnView_Click(btnView,e);

        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPrint_Click(btnPrint,e);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnExport_Click(btnExport,e);
        }

        private void bbiHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiProductDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());
            xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        private void bbiHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            PRODUCT product = new PRODUCT();
            product.Get(Arg.ToString());

            xfmHistory xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        public void DisableMenu(bool disable)
        {
            bbiPrint.Enabled = !disable;
            bbiExport.Enabled = !disable;
            bbiProduct.Enabled = !disable;
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsInventoryOrder.INVENTORY_ORDER.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            string Result = string.Empty;
            //Get Object 
            object Arg = null;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            bbiProduct.Enabled = true;
            if (Arg == null)
            {
                bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                //e.TotalValue = Convert.ToDouble(colQuantity.SummaryItem.SummaryValue) == 0 ? 0 : Convert.ToDouble(colAmount.SummaryItem.SummaryValue) /
                //            Convert.ToDouble(colQuantity.SummaryItem.SummaryValue);

                double Amount = 0.0;
                double Quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    Amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                    Quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = Amount / Quantity;
            }
        }

        private void bbiNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //rgSelect.SelectedIndex = 0;
            btnView_Click(btnView,e);
        }

        private void bbiWarning_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // rgSelect.SelectedIndex = 1;
            btnView_Click(btnView, e);
        }

        private void bbiDangerous_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // rgSelect.SelectedIndex = 2;
            btnView_Click(btnView, e);
        }

        private void bbiAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // rgSelect.SelectedIndex = 3;
            btnView_Click(btnView, e);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm != null) this.ParentForm.Close();
        }

    }
}
