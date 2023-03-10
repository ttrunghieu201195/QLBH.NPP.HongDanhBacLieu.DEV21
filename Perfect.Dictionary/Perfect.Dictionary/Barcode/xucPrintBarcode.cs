using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Perfect.Common;
using Perfect.Data.Helper;
//using Perfect.Dictionary.Barcode.DS;
using Perfect.Dictionary.Barcode.DS;
using Perfect.Dictionary.Barcode.Template;
using Perfect.ERP;
using dsBarcode = Perfect.Dictionary.Barcode.Template.DS.dsBarcode;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;

namespace Perfect.Dictionary.Barcode
{
    public partial class XucPrintBarcode : xucDetailList
    {
        private Column _mColumn;
        public XucPrintBarcode()
        {
            InitializeComponent();
            Init();
            Reload();
        }

        private new void Init()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            ProductInit();
            UnitInit();
            Bar.All = true;
            Bar.IsStock = false;
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            FormatColumns(rpProduct, "Product_ID", 0, 100, "Mã");
            FormatColumns(rpProduct, "Product_Name", 1, 200, "Tên");
            FormatColumns(rpProductName, "Product_ID", 1, 100, "Mã");
            FormatColumns(rpProductName, "Product_Name", 0, 200, "Tên");
            //Product_NameEN
            _mColumn = Column.None;
            DoHide();
        }

        private void ProductInit()
        {
            pRODUCTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCTTableAdapter.ClearBeforeFill = true;
            pRODUCTTableAdapter.Fill(dsPRODUCT.PRODUCT);
        }

        private void UnitInit()
        {
            uNITTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            uNITTableAdapter.Fill(dsUNIT.UNIT);
        }

        public override void Reload()
        {
            Enabled = false;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData();
            DoHide();
            Enabled = true;
        }

        private void SetData()
        {
            SysLog.Insert("In Mã Vạch", "Xem");
           
            pRODUCTTableAdapter1.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCTTableAdapter1.ClearBeforeFill = true;
            pRODUCTTableAdapter1.Fill(dsProductBarcode.PRODUCT);

        }

        private void Total()
        {
            double Amount = 0.0;
            double Quantity = 0.0;
            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount +=
                    Convert.ToDouble((object) ((int) (gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                                          ? 0
                                                          : gbList.GetRowCellValue(i, "Amount"))));
                Quantity += Convert.ToDouble((object) ((int) (gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                                          ? 0
                                                          : gbList.GetRowCellValue(i, "Quantity"))));
            }
        }

        public override void Print()
        {
            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (MyRule.Get(MyLogin.RoleId, "bbiPrintBarcode") != "OK") return;
            if (!MyRule.AllowPrint)
            {
                DoHide();
                MyRule.Notify();
                return;
            }

            SysLog.Insert("In Mã Vạch", "In");
            if (dsProductBarcode.PRODUCT.Rows.Count == 0)
            {
                DoHide();
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var barcode = new dsBarcode();
            var dataTable = new dsProductBarcode.PRODUCTDataTable();
            dataTable.Merge(dsProductBarcode.PRODUCT);
            int times = 0;
            string productname = "";

            DoHide();
            //extra
            int PriceType = 0;
            xfmPriceOptions frm = new xfmPriceOptions();
            frm.PriceToPrint += (_priceType) =>
            {
                PriceType = _priceType;
            };
            frm.ShowDialog();
            //
            if (PriceType == -99)
                return;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataTable[i]["Selected"]))
                {
                    productname = Convert.ToString(dataTable[i]["Product_Name"]);
                    times = Convert.ToInt32(dataTable[i]["Times"]);
                }
                else
                {
                    continue;
                }

                if (times <= 0)
                {
                    DoHide();
                    XtraMessageBox.Show("Không có dữ liệu để in, số lần in là 0.\n\n Hàng hoá: " + productname, "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    continue;
                }

                PRODUCT itemPro = new PRODUCT();
                itemPro.Get(Convert.ToString(dataTable[i]["Product_ID"]));
                decimal Price = Convert.ToDecimal(dataTable[i]["Retail_Price"] == DBNull.Value ? 0 : dataTable[i]["Retail_Price"]);

                switch (PriceType)
                {
                    case 0:
                        Price = 0;
                        break;
                    case 1:
                        Price = Convert.ToDecimal(itemPro.Org_Price);
                        break;
                    case 2:
                        Price = Convert.ToDecimal(itemPro.Sale_Price);
                        break;
                    case 3:
                        Price = Convert.ToDecimal(itemPro.Retail_Price);
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < times; j++)
                {

                    barcode.PRODUCT.AddPRODUCTRow(
                    dataTable[i]["Product_ID"].ToString(),
                    dataTable[i]["Product_Name"].ToString(),
                    dataTable[i]["Unit"].ToString(),
                    Price,
                    dataTable[i]["Barcode"].ToString(),
                    null, null, null, 0, null,
                    null, null, null, 0, null,
                    null, null, null, 0, null,
                    null, null, null, 0, null,
                    null, null, null, 0, null,
                    null, null, null, 0, null,
                    dataTable[i]["Product_NameEN"].ToString(),
                    null, null, null,
                    null, null, null,
                    dataTable[i]["Batch"].ToString()
                    );

                   
                }
               
            }
            var rptBarcode = new rptBarcodeV_01(barcode.PRODUCT, PriceType != -1);

            //var rptBarcode = new rptBarcodeVerticalCustomMod(barcode.PRODUCT, PriceType != -1);
            rptBarcode.ShowPreview();
            DoHide();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (MyRule.Get(MyLogin.RoleId, "bbiPrintBarcode") != "OK")
            {
                MyRule.Notify();
                return false;
            }
            if (!MyRule.AllowExport)
            {
                MyRule.Notify();
                return false;
            }

            SysLog.Insert("Mã Vạch", "Xuất");

            return base.ExportPermision();
        }


        public override void ProductDetail()
        {
            AdvBandedGridView view = gbList;
            if (view == null) return;
            var ex = new RowClickEventArgs(view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);
            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);


            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        private void DisableMenu(bool disable)
        {
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsProductBarcode.PRODUCT.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);
            Bar.Bar.bbiProduct.Enabled = true;
            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
        }

        private void GbListCustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                double amount = 0.0;
                double quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount +=
                        Convert.ToDouble((object) ((int) (gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                                              ? 0
                                                              : gbList.GetRowCellValue(i, "Amount"))));
                    quantity +=
                        Convert.ToDouble((object) ((int) (gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                                              ? 0
                                                              : gbList.GetRowCellValue(i, "Quantity"))));
                }

                e.TotalValue = amount/quantity;
            }
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void GbListCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (_mColumn == Column.Lock) return;
            gbList.UpdateCurrentRow();
            gbList.ClearColumnErrors();

            if (_mColumn == Column.None)
            {
                switch (e.Column.FieldName)
                {
                    case "Product_ID":
                        _mColumn = Column.ID;
                        break;
                    case "ItemID":
                        _mColumn = Column.ID;
                        break;
                }
            }

            switch (_mColumn)
            {
                case Column.None:
                    return;
                case Column.ID:
                    _mColumn = Column.Lock;
                    ProductAdd(e.Value.ToString());
                    _mColumn = Column.None;
                    break;
            }

            _mColumn = Column.None;
        }

        private void ProductAdd(string id)
        {
            var pro = new PRODUCT();

            if (pro.Get(id) == "OK")
            {
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);
                gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                gbList.SetFocusedRowCellValue(gbList.Columns["Times"], 1);
                gbList.SetFocusedRowCellValue(gbList.Columns["Retail_Price"],
                                              (pro.Retail_Price == 0) ? pro.Sale_Price : pro.Retail_Price);
                gbList.SetFocusedRowCellValue(gbList.Columns["Barcode"],
                                              pro.Barcode == "" ? pro.Product_ID : pro.Barcode);

                if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                Total();
            }
        }

        #region Nested type: Column

        private enum Column
        {
            None = 0,
            Quantity = 1,
            Price = 2,
            Amount = 3,
            ID = 4,
            Lock = 5,
            Name = 6,
            Vat_ID = 9,
            Discount = 12,
            Vat = 13,
            Stock_ID = 14
        }

        #endregion
    }
}