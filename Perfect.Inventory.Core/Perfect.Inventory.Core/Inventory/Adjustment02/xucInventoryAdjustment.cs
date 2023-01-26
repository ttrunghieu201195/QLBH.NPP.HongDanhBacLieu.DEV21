using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Perfect.Common.Base;
using Perfect.Data.Extra.Class;
using Perfect.Data.Helper;
using Perfect.Dictionary.History;
using Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Adjustment.Class;
using Perfect.Dictionary;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Inventory.Core.Inventory.Adjustment
{
    public partial class XucInventoryAdjustment : xucBase
    {
        private string _id = "";
        private Column _mColumn;

        public XucInventoryAdjustment()
        {
            InitializeComponent();
            Init();
        }

        private void ProductAdd(string id, string stock)
        {
            var pro = new PRODUCT();


            if (pro.Get(id, stock == "" ? cbxStock.EditValue.ToString() : stock) == "OK")
            {
              
                gbList.SetFocusedRowCellValue(gbList.Columns["ProductName"], pro.Product_Name);
                gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                gbList.SetFocusedRowCellValue(gbList.Columns["CurrentQty"], pro.Quantity);
                gbList.SetFocusedRowCellValue(gbList.Columns["QtyDiff"], 0);

                if (stock == "")
                {
                    gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], cbxStock.EditValue);
                    gbList.SetFocusedRowCellValue(gbList.Columns["NewQty"], pro.Quantity);
                }
                else
                {
                    object qty = gbList.GetRowCellValue(gbList.FocusedRowHandle, "NewQty");
                    gbList.SetFocusedRowCellValue(gbList.Columns["QtyDiff"],
                                                  Convert.ToDouble(qty == DBNull.Value ? 0 : qty) - pro.Quantity);
                }

                gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
                gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], pro.AverageCost);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], "");
                if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
            }
            else
            {
                if (pro.Get(id) == "OK")
                {
                    gbList.SetFocusedRowCellValue(gbList.Columns["ProductName"], pro.Product_Name);
                    gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                    gbList.SetFocusedRowCellValue(gbList.Columns["CurrentQty"], 0);
                    gbList.SetFocusedRowCellValue(gbList.Columns["QtyDiff"], 0);


                    if (stock == "")
                    {
                        //chua chon kho o duoi luoi
                        gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], cbxStock.EditValue);
                        gbList.SetFocusedRowCellValue(gbList.Columns["NewQty"], 0);
                    }
                    else
                    {
                        object qty = gbList.GetRowCellValue(gbList.FocusedRowHandle, "NewQty");
                        gbList.SetFocusedRowCellValue(gbList.Columns["QtyDiff"], qty);
                    }


                    gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], 0);
                    gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], "");

                    if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                }
                else
                {
                    gbList.SetColumnError(colProduct_ID, "Mặt hàng không tồn tại!");
                }
            }
        }

        

        private void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Kiểm kê kho", "Xem");
            bm.SetPopupContextMenu(gcList, pm);
            Reload();
            DoHide();
        }

        private void Reload()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Unit_Init();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Stock_Init();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Product_Init();
            InitAdjustment();
            DoHide();
        }

        private void InitAdjustment()
        {
            aDJUSTMENTTableAdapter1.Connection.ConnectionString = SqlHelper.ConnectString;
            aDJUSTMENTTableAdapter1.ClearBeforeFill = true;
            aDJUSTMENTTableAdapter1.Fill(dsAdjustmentMana1.ADJUSTMENT);
        }

        private void Stock_Init()
        {
            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsSTOCK.STOCK);

        }

        private void Unit_Init()
        {
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsUnit.UNIT);
        }

        private void Product_Init()
        {
            var adapter = new PRODUCTTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            //adapter.Fill(dsPRODUCT.PRODUCT);
            adapter.FillAllBy(dsPRODUCT.PRODUCT);
        }


        private void SetData()
        {             
            dsAdjustment1.INVENTORY_GetList_Adjustment.Clear();
            var inventorys = new INVENTORYS();
            dsAdjustment1.INVENTORY_GetList_Adjustment.Merge(inventorys.AdjustmentProductList((cbxStock.EditValue ?? "").ToString()));

        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {
            Enabled = false;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData();
            DoHide();
            Enabled = true;
        }

        private bool DetailCheck()
        {
            //if (gbList.RowCount - 1 == 0)
            //{
            //    XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            var dt = dsAdjustment1.INVENTORY_GetList_Adjustment;

            string text;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState == DataRowState.Deleted) continue;


                //if (dt.Rows[i]["Unit"] == null || dt.Rows[i]["Unit"] == DBNull.Value)
                //{
                //    XtraMessageBox.Show("Chưa chọn đơn vị tính cho hàng hoá.\n\tDòng số: " + (i + 1), "Cảnh Báo",
                //                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}

                //if (dt.Rows[i]["Product_ID"] == null || dt.Rows[i]["Product_ID"] == DBNull.Value)
                //{
                //    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (i + 1), "Cảnh Báo", MessageBoxButtons.OK,
                //                        MessageBoxIcon.Warning);
                //    return false;
                //}

                //text = gbList.GetDisplayTextByColumnValue(colProduct_ID, dt.Rows[i]["Product_ID"].ToString());
                //if (text.Trim() == "")
                //{
                //    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (i + 1), "Cảnh Báo", MessageBoxButtons.OK,
                //                        MessageBoxIcon.Warning);
                //    //dt.Rows.RemoveAt(i);
                //    return false;
                //}

                //text = gbList.GetDisplayTextByColumnValue(colUnit, dt.Rows[i]["Unit"].ToString());
                //if (text.Trim() == "")
                //{
                //    XtraMessageBox.Show("Chưa chọn đơn vị tính cho hàng hoá.\n\tDòng số: " + (i + 1), "Cảnh Báo",
                //                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    //dt.Rows.RemoveAt(i);
                //    return false;
                //}
            }
            return true;
        }

        private string DetailSave(SqlHelper mySql)
        {
            btnSave.Enabled = false;
            var cls = new ADJUSTMENT_DETAIL();
            string result = "OK";
            double qty = 0;

            var dt = dsAdjustment1.INVENTORY_GetList_Adjustment;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    qty = Convert.ToDouble(dt.Rows[i]["QtyDiff"] == DBNull.Value ? 0 : dt.Rows[i]["QtyDiff"]);
                    //detailNo = dt.Rows[i]["ID"].ToString();
                }

                if (dt.Rows[i].RowState == DataRowState.Added)
                {
                    if (qty != 0)
                    {
                        //if (Convert.ToInt32(dt.Rows[i]["ID"]) == 0)
                        //{
                        if (! cls.Insert(
                            mySql.Transaction,
                            Guid.NewGuid().ToString(),
                            _id,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["Stock_ID"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            Convert.ToDecimal(dt.Rows[i]["Convert"]),
                            0,
                            0,
                            "",
                            Convert.ToDecimal(dt.Rows[i]["CurrentQty"]),
                            Convert.ToDecimal(dt.Rows[i]["NewQty"]),
                            Convert.ToDecimal(dt.Rows[i]["QtyDiff"]),
                            Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            Convert.ToDecimal(dt.Rows[i]["Convert"]) * Convert.ToDecimal(dt.Rows[i]["NewQty"]),
                            0,
                            "",
                            "",
                            "(Kiểm kê)",
                            0))
                        {
                            result = mySql.Result;
                            DoHide();
                            mySql.RollBack();
                            return result;
                        }
                        //}
                    }
                }
                else if (dt.Rows[i].RowState == DataRowState.Modified)
                {
                    if (qty != 0)
                    {
                        if (!cls.Insert(
                            mySql.Transaction,
                            Guid.NewGuid().ToString(),
                            _id,
                            dt.Rows[i]["Product_ID"].ToString(),
                            dt.Rows[i]["Product_Name"].ToString(),
                            dt.Rows[i]["Stock_ID"].ToString(),
                            dt.Rows[i]["Unit"].ToString(),
                            Convert.ToDecimal(dt.Rows[i]["Convert"]),
                            0,
                            0,
                            "",
                            Convert.ToDecimal(dt.Rows[i]["CurrentQty"]),
                            Convert.ToDecimal(dt.Rows[i]["NewQty"]),
                            Convert.ToDecimal(dt.Rows[i]["QtyDiff"]),
                            Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                            Convert.ToDecimal(dt.Rows[i]["Amount"]),
                            Convert.ToDecimal(dt.Rows[i]["Convert"]) * Convert.ToDecimal(dt.Rows[i]["NewQty"]),
                            0,
                            "",
                            "",
                            "(Kiểm kê)",
                            0))
                        {
                            result = mySql.Result;
                            DoHide();
                            mySql.RollBack();
                            return result;
                        }
                    }
                }

                //else if (dt.Rows[i].RowState==DataRowState.Deleted)
                //{

                //}
            }
            return result;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (!MyRule.IsAdd("bbiAdjustment")) return;
            if (cbxStock.EditValue == null) return;

            if (!DetailCheck()) return;

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn thực hiện kiểm kê không?", "Thông Báo",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            _id = "";
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            SysLog.Insert("Kiểm kê tồn kho", "Cập Nhật");
            btnSave.Enabled = false;
            var mysql = new SqlHelper();
            string result = mysql.Start();
            if (result != "OK")
            {
                DoHide();
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
                return;
            }

            var cls = new ADJUSTMENT();

            _id = "KK." + cbxStock.EditValue + "." + string.Format("{0:ddMMyyyy}", DateTime.Now);
            if (!cls.Exist(_id))
            {
                if (! cls.Insert(
                    mysql.Transaction,
                    _id,
                    DateTime.Now,
                    _id,
                    5,
                    MyLogin.UserId,
                    cbxStock.EditValue.ToString(),
                    0,
                    true,
                    false,
                    "(Kiểm Kê)",
                    MyLogin.UserId,
                    true))
                {
                    result = mysql.Result;
                    DoHide();
                    mysql.RollBack();
                    XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;
                    return;
                }
            }

            result = DetailSave(mysql);
            if (result != "OK")
            {
                DoHide();
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
                return;
            }
            mysql.CommandType = CommandType.Text;

            double amount = mysql.ExecuteScalar(mysql.Transaction,
                                                "select sum(amount) from ADJUSTMENT_DETAIL where Adjustment_ID='" + _id +
                                                "'", 0);

            mysql.CommandType = CommandType.Text;
            result = mysql.ExecuteNonQuery(mysql.Transaction,
                                           "update ADJUSTMENT set Amount=" + amount + " where ID='" + _id + "'");

            if (result != "OK")
            {
                DoHide();
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
                return;
            }

            mysql.CommandType = CommandType.StoredProcedure;
            result = mysql.Commit();
            if (result != "OK")
            {
                DoHide();
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
                return;
            }

            DoHide();
            XtraMessageBox.Show("Dữ liệu được lưu thành công.", "Thông Báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            SetData();
            btnSave.Enabled = true;
            InitAdjustment();
        }

        private void GbListCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gbList.UpdateCurrentRow();
            if (_mColumn == Column.Lock) return;

            if (_mColumn == Column.None)
            {
                switch (e.Column.FieldName)
                {
                    case "NewQty":
                        _mColumn = Column.NewQty;
                        break;
                    case "UnitPrice":
                        _mColumn = Column.UnitPrice;
                        break;
                    case "Amount":
                        _mColumn = Column.Amount;
                        break;
                    case "Stock_ID":
                        _mColumn = Column.StockId;
                        break;
                }
            }

            switch (_mColumn)
            {
                case Column.None:
                    return;
                case Column.NewQty:
                    {
                        object unitPrice = gbList.GetRowCellValue(e.RowHandle, "UnitPrice");
                        object currentQty = gbList.GetRowCellValue(e.RowHandle, "CurrentQty");
                        _mColumn = Column.Lock;

                        double qtyDiff = Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) -
                                         Convert.ToDouble(currentQty == DBNull.Value ? 0 : currentQty);

                        //double qtyDiff = Convert.ToDouble(currentQty == DBNull.Value ? 0 : currentQty) - Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value);

                        gbList.SetRowCellValue(e.RowHandle, "QtyDiff", qtyDiff);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", qtyDiff * Convert.ToDouble(unitPrice == DBNull.Value ? 0 : unitPrice));
                        gbList.UpdateCurrentRow();
                        _mColumn = Column.None;
                        return;

                    }
                case Column.UnitPrice:
                    {
                        object qty = gbList.GetRowCellValue(e.RowHandle, "QtyDiff");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Amount",
                                               Convert.ToDouble(e.Value)*Convert.ToDouble(qty == DBNull.Value ? 0 : qty));
                        gbList.UpdateCurrentRow();
                        _mColumn = Column.None;
                        return;
                    }
                case Column.Amount:
                    {
                        double unitPrice =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        double qty =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "QtyDiff") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "QtyDiff"));

                        _mColumn = Column.Lock;
                        if (qty == 0)
                        {
                            if (unitPrice != 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "QtyDiff", Convert.ToDouble(e.Value)/unitPrice);
                            }
                        }
                        else
                        {
                            if (unitPrice == 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value)/qty);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "QtyDiff", Convert.ToDouble(e.Value)/unitPrice);
                            }
                        }
                        gbList.UpdateCurrentRow();
                        _mColumn = Column.None;
                        return;
                    }
                case Column.StockId:

                    object productId = gbList.GetRowCellValue(e.RowHandle, "Product_ID");
                    gbList.SetColumnError(colStock_ID1, null);
                    _mColumn = Column.Lock;

                    if (e.Value == null)
                    {
                        gbList.SetColumnError(colStock_ID1, "Không được rỗng");
                    }
                    else
                    {
                        if (productId != null)
                        {
                            ProductAdd(productId.ToString(), e.Value.ToString());
                        }
                        else
                        {
                            gbList.SetColumnError(colProduct_ID, "Vui lòng chọn hàng hoá.");
                        }
                    }

                    _mColumn = Column.None;
                    break;
            }
            _mColumn = Column.None;
        }

        private void BbiRefreshItemClick(object sender, ItemClickEventArgs e)
        {
            BtnSearchClick(btnSearch, e);
        }

        private void BbiExportItemClick(object sender, ItemClickEventArgs e)
        {
            //ExportView = gbList;
            //Export();
        }

        private void BbiCloseItemClick(object sender, ItemClickEventArgs e)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        private void BbiProductDetailItemClick(object sender, ItemClickEventArgs e)
        {
            //AdvBandedGridView view = gbList;
            //if (view != null)
            //{
            //    var ex = new RowClickEventArgs(view.FocusedRowHandle,
            //                                   view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
            //                                   view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //    object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            //    if (arg == null) return;
            //    var product = new PRODUCT();
            //    product.Get(arg.ToString());
            //    var xfmItemAdd = new XfmItemAdd(Actions.Update, product);
            //    xfmItemAdd.ShowDialog();
            //}
        }

        private void BbiHistoryItemClick(object sender, ItemClickEventArgs e)
        {
            //AdvBandedGridView view = gbList;
            //if (view != null)
            //{
            //    var ex = new RowClickEventArgs(view.FocusedRowHandle,
            //                                   view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
            //                                   view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //    //Get Object 
            //    object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            //    if (arg == null) return;
            //    var product = new PRODUCT();
            //    product.Get(arg.ToString());

            //    var xfmHistory = new XfmHistory();
            //    xfmHistory.SetData(product.Product_ID, "");
            //    xfmHistory.ShowDialog(this);
            //}
        }

        private void BbiImportItemClick(object sender, ItemClickEventArgs e)
        {
            //btnImport_Click(btnImport, e);
        }

        private void DisableMenu(bool disable)
        {
            bbiPrint.Enabled = !disable;
            bbiExport.Enabled = !disable;
            bbiProduct.Enabled = !disable;
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (dsAdjustment1.INVENTORY_GetList_Adjustment.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }

            AdvBandedGridView view = gbList;
            if (view != null)
            {
                var ex = new Perfect.Common.RowClickEventArgs(view.FocusedRowHandle,
                                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
                //Get Object 
                object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

                bbiProduct.Enabled = true;
                if (arg == null)
                {
                    bbiProduct.Enabled = false;
                    return;
                }
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void GbListCustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                //e.TotalValue = Convert.ToDouble(colQuantity.SummaryItem.SummaryValue) == 0 ? 0 : Convert.ToDouble(colAmount.SummaryItem.SummaryValue) /
                //            Convert.ToDouble(colQuantity.SummaryItem.SummaryValue);

                double amount = 0.0;
                double quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount +=
                        Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                             ? 0
                                             : gbList.GetRowCellValue(i, "Amount"));
                    quantity +=
                        Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                             ? 0
                                             : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = amount/quantity;
            }
        }

        private void BbiInitItemClick(object sender, ItemClickEventArgs e)
        {
            BtnSaveClick(sender, e);
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex < 0) return;
            rowIndex++;
            e.Info.DisplayText = rowIndex.ToString();
        }


        private void GbListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //if (gbList.FocusedColumn == colNewQty)
                //{
                //    _mColumn = Column.Lock;

                //    gbList.SetRowCellValue(gbList.FocusedRowHandle, colNewQty, 0);
                //    _mColumn = Column.None;

                //}
                if (gbList.FocusedColumn == colUnitPrice)
                {
                    _mColumn = Column.Lock;


                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colUnitPrice, 0);
                    _mColumn = Column.None;
                }
                else if (gbList.FocusedColumn == colAmount)
                {
                    _mColumn = Column.Lock;


                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colAmount, 0);
                    _mColumn = Column.None;
                }
                else
                {
                    if (gbList.GetSelectedRows().Length > 0)
                    {
                        gbList.DeleteSelectedRows();
                    }
                    else
                    {
                        gbList.DeleteRow(gbList.FocusedRowHandle);
                    }
                    gbList.UpdateCurrentRow();
                }
            }
        }

        private void GbList01DoubleClick(object sender, EventArgs e)
        {
            string s = gbList01.GetFocusedRowCellValue("ID").ToString();
            if (string.IsNullOrEmpty(s)) return;
            var adjustmentDetails = new XfmAdjustmentDetails(s);
            adjustmentDetails.ShowDialog();
        }

        private void BttViewClick(object sender, EventArgs e)
        {
            string s = gbList01.GetFocusedRowCellValue("ID") == null
                           ? ""
                           : gbList01.GetFocusedRowCellValue("ID").ToString();
            if (string.IsNullOrEmpty(s)) return;
            var adjustmentDetails = new XfmAdjustmentDetails(s);
            adjustmentDetails.ShowDialog();
        }

        private void BttLoadAgainClick(object sender, EventArgs e)
        {
            InitAdjustment();
        }

        private void BttDeleteClick(object sender, EventArgs e)
        {
            string s = gbList01.GetFocusedRowCellValue("ID") == null
                           ? ""
                           : gbList01.GetFocusedRowCellValue("ID").ToString();
            if (string.IsNullOrEmpty(s)) return;
            if (
                XtraMessageBox.Show("Bạn có chắc là muốn xoá kiểm kê vào ngày này không ?", "Question",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var mysql = new SqlHelper();
            string result = mysql.Start();
            if (result != "OK")
            {
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cls = new ADJUSTMENT();
            if (!cls.Exist(s))
            {
                result = mysql.Result;
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cls.Delete(mysql.Transaction, s))
            {
                result = mysql.Result;
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            result = mysql.Commit();
            if (result != "OK")
            {
                mysql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            gbList01.DeleteSelectedRows();
        }

    

        #region Nested type: Column

        private enum Column
        {
            None = 0,
            StockId = 1,
            Lock = 5,
            NewQty = 7,
            UnitPrice = 9,
            Amount = 10
        }

        #endregion

        private void gbList_DoubleClick(object sender, EventArgs e)
        {
            //var arg = gbList.GetFocusedRowCellValue("Product_ID");
            //if (arg == null) return;
            //var product = new PRODUCT();
            //if (product.Get(arg.ToString()) != "OK")
            //{
            //    DoHide();
            //    XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (product.Photo != null)
            //{
            //    var frm = new XfmProductPicture(product.Photo);
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Hàng hóa này không có hình ảnh.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }

        private void gbList01_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex < 0) return;
            rowIndex++;
            e.Info.DisplayText = rowIndex.ToString();
        }

        private void cbxStock_EditValueChanged(object sender, EventArgs e)
        {
            //Enabled = false;
            //CreateWaitDialog();
            //SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData();
            //DoHide();
            //Enabled = true;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}