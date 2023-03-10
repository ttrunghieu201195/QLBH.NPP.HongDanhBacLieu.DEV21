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
    public partial class xucInventoryDetailBFC : Perfect.Common.xucBase
    {
        public xucInventoryDetailBFC()
        {
            InitializeComponent();
            Init();
          
            List_Init(gbList);
            bm.SetPopupContextMenu(gcList,pm);
        }

        public void Init()
        {
            Stock_Init();
            Unit_Init();
        }

        public void Stock_Init()
        {
            STOCKTableAdapter adapter=new STOCKTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsStock.STOCK);
        }

        public void Unit_Init()
        {
            UNITTableAdapter adapter=new UNITTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsUnit.UNIT);
        }

       
        private void btnView_Click(object sender, EventArgs e)
        {
            SetData(txtProductID.Text,txtProductName.Text);
        }

        public void SetData(string product_id,string product_name)
        {
            this.Enabled = false;
            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK") return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                this.Enabled = true;
                return;
            }


            if (cbxStock.SelectedValue == null)
            {
                this.Enabled = true;
                return;
            }


            //dsInventory.INVENTORY.Reset();
            //dsInventory.INVENTORY.Merge(cls.GetList(cbxStock.SelectedValue.ToString(), txtProductID.Text, txtProductName.Text, chxZero.Checked));
            //MessageBox.Show(dsInventory.INVENTORY.Rows.Count.ToString());



            iNVENTORYTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            iNVENTORYTableAdapter.Fill(dsInventory.INVENTORY_GetFull, cbxStock.SelectedValue.ToString(), "%" + product_id + "%", "%" + product_name + "%", chxZero.Checked);
           // Total();
            this.Enabled = true;
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
                        if (SysOption.Language=="VN") dt.Columns[i].Caption = "Ngày";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Limit":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Visible = SysOption.Batch;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "HSD";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Product_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Mã hàng";
                        dt.Columns[i].Width =80;
                        break;
                    case "ProductName":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Hàng hóa";
                        dt.Columns[i].Width = 170;
                        break;
                    case "Unit":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Đơn vị";
                        dt.Columns[i].Width = 100;
                        break;
                    case "ProductGroup_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Nhóm";
                        dt.Columns[i].Width = 150;
                        break;
                    case "Stock_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Kho";
                        dt.Columns[i].Width = 120;
                        break;
                    case "Batch":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Visible = SysOption.Batch;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Lô";
                        dt.Columns[i].Width = 120;
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
            if (MyRule.Get(MyLogin.RoleId, "bbiInventory") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            //xfmReportManagers frm = new xfmReportManagers("RD0000006");
            //xfmReportManagers frm=new xfmReportManagers();
            //frm.SetData("RD0000006");
            //frm.Show();

            rptInventoryDetail rpt = new rptInventoryDetail(0, "RD0000006", dsInventory.INVENTORY_GetFull);
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

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnView_Click(btnView,e);
            }
        }

        private void cbxStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxStock.SelectedIndex==-1) return;
            btnView_Click(sender,EventArgs.Empty);
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnView_Click(sender,EventArgs.Empty);
        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPrint_Click(btnPrint,e);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnExport_Click(btnExport,e);
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
            if(dsInventory.INVENTORY_GetFull.Rows.Count==0)
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

                e.TotalValue = Amount/Quantity;
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm!=null) this.ParentForm.Close();
        }

        private void btnPrintDetail_Click(object sender, EventArgs e)
        {
            rptInventoryBFC rpt = new rptInventoryBFC(cbxStock.SelectedValue.ToString(), cbxStock.Text);
            rpt.ShowPreview();
        }

    }
}
