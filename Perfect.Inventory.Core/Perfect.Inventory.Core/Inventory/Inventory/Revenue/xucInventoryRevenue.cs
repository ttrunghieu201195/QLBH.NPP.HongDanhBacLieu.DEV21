using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Report.Report;
using Perfect.Net.Info;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    public partial class xucInventoryRevenue : xucDetailList
    {
        public xucInventoryRevenue()
        {
            InitializeComponent();
            Init();
            Bar.Stock_Init();
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        private void Init()
        {
           
            gbList.OptionsView.AllowCellMerge = true;
            Bar.All = false;
            Bar.IsStock = false;
            Bar.IsProductId = false;
            Bar.IsProductName = false;
            Bar.Stock_Init();
            //Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }
   
        public override void Reload()
        {
            Enabled = false;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xem");
            SetData(Bar.Id,Bar.Text);
            Enabled = true;
            DoHide();
        }

        public void SetData(string productID,string productName)
        {
            
            if (MyRule.Get(MyLogin.RoleId, "bbiInventorySummary") != "OK")
            {
                
                return;
            }
            if (!MyRule.AllowAccess)
            {
                //this.Enabled = true;
                MyRule.Notify();
               
                return;
            }


            if (Bar.Stock=="")
            {
                Enabled = true;
                return;
            }


            //dsInventory.INVENTORY.Reset();
            //dsInventory.INVENTORY.Merge(cls.GetList(cbxStock.SelectedValue.ToString(), txtProductID.Text, txtProductName.Text, chxZero.Checked));
            //MessageBox.Show(dsInventory.INVENTORY.Rows.Count.ToString());



            iNVENTORY_Summary_RevenueTableAdapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            iNVENTORY_Summary_RevenueTableAdapter.Fill(dsInventoryRevenue.INVENTORY_Summary_Revenue, Bar.From, Bar.To);
           // Total();
            Enabled = true;
        }

        public void List_Init(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "Stock_Date":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language=="VN") dt.Columns[i].Caption = "Ngày";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Limit":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
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
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Mã hàng";
                        dt.Columns[i].Width =80;
                        break;
                    case "Product_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Hàng hóa";
                        dt.Columns[i].Width = 170;
                        break;
                    case "Unit":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Đơn vị";
                        dt.Columns[i].Width = 100;
                        break;
                    case "ProductGroup_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Nhóm";
                        dt.Columns[i].Width = 150;
                        break;
                    case "Stock_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Kho";
                        dt.Columns[i].Width = 120;
                        break;
                    case "Batch":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Visible = SysOption.Batch;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Lô";
                        dt.Columns[i].Width = 120;
                        break;

                    case "Quantity":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                      
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Số lượng";
                        dt.Columns[i].Width = 80;
                        break;
                    case "UnitPrice":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                       // dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Đơn giá";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Amount":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
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

        public override void Print()
        {
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) || string.IsNullOrEmpty(MyInfo.Tel) || string.IsNullOrEmpty(MyInfo.Fax))
            {
                XtraMessageBox.Show("Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            if (MyRule.Get(MyLogin.RoleId, "bbiInventorySummary") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                MyRule.Notify();
                return;
            }

            //xfmReportManagers frm = new xfmReportManagers("RD0000006");
            //xfmReportManagers frm=new xfmReportManagers();
            //frm.SetData("RD0000006");
            //frm.Show();

            //string from = SYS_OPTION.Language == "VN" ? "Từ " : "From ";
            //string to = SYS_OPTION.Language == "VN" ? " đến " : " to ";
            //SYS_LOG.Insert("Tồn Kho (XNT)", "In");

            //rptSummary rpt = new rptSummary(dsInventoryDetailSummary.INVENTORY_DETAIL_SUMMARY, "RD0000027", from + Strings.Format(dtFrom.DateTime, "dd/MM/yyyy") + to + Strings.Format(dtTo.DateTime, "dd/MM/yyyy"));

            //rpt.ShowPreview();
            //gcList.ShowPrintPreview();

            if (dsInventoryRevenue.INVENTORY_Summary_Revenue.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //DoHide();
                return;
            }

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";

            var rpt = new rptInventoryRevenue(dsInventoryRevenue.INVENTORY_Summary_Revenue, "", from + Strings.Format(Bar.From, "dd/MM/yyyy") + to + Strings.Format(Bar.To, "dd/MM/yyyy"));
            rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (MyRule.Get(MyLogin.RoleId, "bbiInventorySummary") != "OK")
            {
                MyRule.Notify();
                return false;
            }
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
                return false;
            }

            SysLog.Insert("Tồn Kho (XNT)", "Xuất");

            return base.ExportPermision();
        }
       

        public override void ProductDetail()
        {
            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            object arg;
            arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
           //Get Object 
            object arg;
            arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
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
            if(dsInventoryRevenue.INVENTORY_Summary_Revenue.Rows.Count==0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.BandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            
            //Get Object 
            object arg;
            arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            Bar.Bar.bbiProduct.Enabled = true;
            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                //return;
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

                double amount = 0.0;
                double quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount += Convert.ToDouble( gbList.GetRowCellValue(i, "Amount")??0);
                    quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity")??0);
                }

                e.TotalValue = amount/quantity;
            }
        }
        
        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
        
        private void gbList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
        }

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }


    }
}
