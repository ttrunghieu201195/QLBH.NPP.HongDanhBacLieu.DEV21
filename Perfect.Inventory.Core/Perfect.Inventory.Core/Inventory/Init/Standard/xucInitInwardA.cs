using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout.Utils;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Inward;
using Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAILTableAdapters;
using Perfect.Security;

namespace Perfect.Inventory.Core.Inventory.Init.Standard
{
    public partial class XucInitInwardA : xucBaseB
    {
        private readonly EnumRefType _part;

        private Column _mColumn;
        private xfmProviderAdd _xfmProviderAdd;

        public XucInitInwardA(EnumRefType refType)
        {
            _mColumn = new Column();
            InitializeComponent();
            _part = new EnumRefType();
            _part = refType;
            _exportView = gbList;
            //Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            dtCreated.DateTime = MyLogin.LoginDate;

            Bar.Bar.bbiPrint.Caption = "Nhập từ Excel";
            Bar.Bar.bbiPrint.ImageIndex = 49;
        }

        public EnumRefType Part
        {
            get { return _part; }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();
        }


        public void Customer_Init()
        {
            //SetWaitDialogCaption("Đang nạp dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            pROVIDERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDERTableAdapter.Fill(dsPROVIDER.PROVIDER);
            Cursor.Current = Cursors.Default;
            //DoHide();
        }


        public void SetStock(STOCK item)
        {
            //dsSTOCK.STOCK.AddSTOCKRow(item.Stock_Name, item.Stock_ID);
            Stock_Init();
        }

        public void Stock_Init()
        {
            Cursor.Current = Cursors.WaitCursor;

            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsSTOCK.STOCK);


            Cursor.Current = Cursors.Default;
        }

        public void Product_Init()
        {
            Cursor.Current = Cursors.WaitCursor;

            var adapter = new PRODUCTTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill_InitInward(dsPRODUCT.PRODUCT);
            rpgProduct.View.ActiveFilterString = "ActiveInt = 1";
            rpProductName.View.ActiveFilterString = "ActiveInt = 1";
            Cursor.Current = Cursors.Default;
        }

        private void Unit_Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsUnit.UNIT);
            Cursor.Current = Cursors.Default;
        }

        //private XucBaseBarcode _ucBarcode;
        private void Init()
        {
            Updated();


            SetWaitDialogCaption("Nạp cấu hình....");
            FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã");
            FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");
            SetWaitDialogCaption("Nạp cấu hình giao diện....");
            SetWaitDialogCaption("Nạp dữ liệu cũ....");
            colAmount.OptionsColumn.ReadOnly = true;
            _mColumn = Column.None;
            colLimit.Visible = false;
            if (CODE.TypeSoft < 400)
            {
                colUnit.OptionsColumn.AllowEdit = false;
            }

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            SetWaitDialogCaption("Nạp hoàn thành....");
            DoHide();
        }

        private void Updated()
        {
            Cursor.Current = Cursors.WaitCursor;
            Customer_Init();
            Stock_Init();
            Product_Init();
            Unit_Init();
            Cursor.Current = Cursors.Default;
        }

        private void XfmProviderAddFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmProviderAdd = null;
        }

        private void XfmProviderAddAdded(object sender, PROVIDER item)
        {
            pROVIDERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDERTableAdapter.Fill(dsPROVIDER.PROVIDER);
        }


        private void XfmProvidersItemSelected(object sender, PROVIDER item)
        {
        }

        private void GbListCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            gbList.UpdateCurrentRow();

            if (_mColumn == Column.Lock) return;


            if (_mColumn == Column.None)
            {
                if (e.Column.FieldName == "Quantity")
                {
                    _mColumn = Column.Quantity;
                }
                else if (e.Column.FieldName == "Product_ID")
                {
                    _mColumn = Column.ID;
                }
                else if (e.Column.FieldName == "UnitPrice")
                {
                    _mColumn = Column.Price;
                }
                else if (e.Column.FieldName == "Amount")
                {
                    _mColumn = Column.Amount;
                }
                else if (e.Column.FieldName == "Stock_ID")
                {
                    _mColumn = Column.StockID;
                }
                else if (e.Column.FieldName == "ItemID")
                {
                    _mColumn = Column.Name;
                }
                else if (e.Column.FieldName == "Product_Name")
                {
                    _mColumn = Column.Name;
                }
                else if (e.Column.FieldName == "Unit")
                {
                    _mColumn = Column.Unit;
                }
                else if (e.Column.FieldName == "Lev1")
                {
                    _mColumn = Column.Lev1;
                }
                else if (e.Column.FieldName == "Lev2")
                {
                    _mColumn = Column.Lev2;
                }
                else if (e.Column.FieldName == "Lev3")
                {
                    _mColumn = Column.Lev3;
                }
                else if (e.Column.FieldName == "Lev4")
                {
                    _mColumn = Column.Lev4;
                }
            }

            switch (_mColumn)
            {
                case Column.None:
                    return;
                case Column.Lev1:
                    {
                        double lev2 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev2") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev2"));
                        double lev3 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev3") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev3"));
                        double lev4 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev4") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev4"));


                        double value;

                        if (Convert.ToDouble(e.Value == DBNull.Value || e.Value == Convert.DBNull ? 0.0 : e.Value) ==
                            0.0 && lev2 == 0.0 && lev3 == 0.0)
                        {
                            _mColumn = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Quantity", lev4);
                            break;
                        }
                        if (e.Value == DBNull.Value)
                        {
                            value = 1;
                        }
                        else if (e.Value == Convert.DBNull)
                        {
                            value = 1;
                        }
                        else if (Convert.IsDBNull(e.Value))
                        {
                            value = 1;
                        }
                        else if (Convert.ToDouble(e.Value) == 0.0)
                        {
                            value = 1;
                        }
                        else
                        {
                            value = Convert.ToDouble(e.Value);
                        }
                        double d1 = lev2 == 0.0 ? 1 : lev2;
                        double d2 = lev3 == 0.0 ? 1 : lev3;

                        double mul = (value*d1*d2) + (lev4);

                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Quantity", mul);
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Lev2:
                    {
                        double lev1 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev1") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev1"));
                        double lev3 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev3") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev3"));
                        double lev4 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev4") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev4"));


                        double value;

                        if (Convert.ToDouble(e.Value == DBNull.Value || e.Value == Convert.DBNull ? 0.0 : e.Value) ==
                            0.0 && lev1 == 0.0 && lev3 == 0.0)
                        {
                            _mColumn = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Quantity", lev4);
                            break;
                        }
                        if (e.Value == DBNull.Value)
                        {
                            value = 1;
                        }
                        else if (e.Value == Convert.DBNull)
                        {
                            value = 1;
                        }
                        else if (Convert.IsDBNull(e.Value))
                        {
                            value = 1;
                        }
                        else if (Convert.ToDouble(e.Value) == 0.0)
                        {
                            value = 1;
                        }
                        else
                        {
                            value = Convert.ToDouble(e.Value);
                        }
                        double d1 = lev1 == 0.0 ? 1 : lev1;
                        double d2 = lev3 == 0.0 ? 1 : lev3;

                        double mul = (value*d1*d2) + (lev4);

                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Quantity", mul);
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Lev3:
                    {
                        double lev1 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev1") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev1"));
                        double lev2 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev2") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev2"));
                        double lev4 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev4") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev4"));


                        double value;

                        if (Convert.ToDouble(e.Value == DBNull.Value || e.Value == Convert.DBNull ? 0.0 : e.Value) ==
                            0.0 && lev1 == 0.0 && lev2 == 0.0)
                        {
                            _mColumn = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Quantity", lev4);
                            break;
                        }
                        if (e.Value == DBNull.Value)
                        {
                            value = 1;
                        }
                        else if (e.Value == Convert.DBNull)
                        {
                            value = 1;
                        }
                        else if (Convert.IsDBNull(e.Value))
                        {
                            value = 1;
                        }
                        else if (Convert.ToDouble(e.Value) == 0.0)
                        {
                            value = 1;
                        }
                        else
                        {
                            value = Convert.ToDouble(e.Value);
                        }
                        double d1 = lev1 == 0.0 ? 1 : lev1;
                        double d2 = lev2 == 0.0 ? 1 : lev2;

                        double mul = (value*d1*d2) + (lev4);

                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Quantity", mul);
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Lev4:
                    {
                        double lev1 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev1") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev1"));
                        double lev2 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev2") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev2"));
                        double lev3 =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Lev3") == DBNull.Value
                                                 ? 0.0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Lev3"));

                        double mul;

                        if (lev1 == 0.0 && lev2 == 0.0 && lev3 == 0.0)
                        {
                            _mColumn = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Quantity", e.Value);
                            break;
                        }
                        mul =
                            (Convert.ToDouble(Convert.ToDouble(e.Value == DBNull.Value ? 0.0 : e.Value) == 0.0
                                                  ? 0.0
                                                  : e.Value)*lev3) +
                            ((lev1 == 0 ? 1 : lev1)*
                             (lev2 == 0 ? 1 : lev2)*
                             (lev3 == 0 ? 1 : lev3));


                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Quantity", mul);
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Quantity:
                    {
                        object unitPrice = gbList.GetRowCellValue(e.RowHandle, "UnitPrice");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Amount",
                                               Convert.ToDouble(e.Value == DBNull.Value ? 0.0 : e.Value)*
                                               Convert.ToDouble(unitPrice == DBNull.Value ? 0 : unitPrice));
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Price:
                    {
                        object qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Amount",
                                               Convert.ToDouble(e.Value == DBNull.Value ? 0.0 : e.Value)*
                                               Convert.ToDouble(qty == DBNull.Value ? 0 : qty));
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Amount:
                    {
                        double unitPrice =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        double qty =
                            Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

                        _mColumn = Column.Lock;
                        if (qty == 0)
                        {
                            if (unitPrice != 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity",
                                                       Convert.ToDouble(e.Value == DBNull.Value ? 0.0 : e.Value)/
                                                       unitPrice);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", 1);
                                gbList.SetRowCellValue(e.RowHandle, "UnitPrice",
                                                       Convert.ToDouble(e.Value == DBNull.Value ? 0.0 : e.Value));
                            }
                        }
                        else
                        {
                            gbList.SetRowCellValue(e.RowHandle, "UnitPrice",
                                                   Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value)/qty);
                        }

                        _mColumn = Column.None;
                        break;
                    }
                case Column.ID:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        ProductAdd(e.Value.ToString());
                        //gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], "");
                        gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"],
                                                      dsPRODUCT.PRODUCT.Rows[
                                                          rpgProduct.View.GetFocusedDataSourceRowIndex()]["Stock_ID"].
                                                          ToString());
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Name:
                    _mColumn = Column.Lock;
                    if (e.Value != null)
                    {
                        string o =
                            dsPRODUCT.PRODUCT.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Product_ID"].
                                ToString();
                        ProductAdd(o);
                        //gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], "");
                        gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"],
                                                      dsPRODUCT.PRODUCT.Rows[
                                                          rpgProduct.View.GetFocusedDataSourceRowIndex()]["Stock_ID"].
                                                          ToString());
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Unit:
                    {
                        _mColumn = Column.Lock;
                        gbList.SetColumnError(colUnit, null);
                        object productId = gbList.GetRowCellValue(e.RowHandle, "Product_ID") ?? "";
                        var product = new PRODUCT();

                        if (product.Get(productId.ToString()) == "OK")
                        {
                            if (e.Value != null)
                            {
                                var unitconvert = new PRODUCT_UNIT();
                                decimal convert = unitconvert.GetConvert(product.Product_ID, product.Unit,
                                                                         e.Value.ToString());
                                if (convert == 0)
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "Unit", null);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", 1);
                                    gbList.SetColumnError(colUnit, "Hàng hoá này không có đơn vị quy đổi này!");
                                }
                                else
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", convert);
                                }
                            }
                        }
                        _mColumn = Column.None;
                    }
                    break;
            }
            Total();
            _mColumn = Column.None;
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void GbListCellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            gbList.ClearColumnErrors();
            //gbList_CellValueChanged(sender,e);
        }


        public void ProductAdd(PRODUCT item)
        {
            dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.AddSTOCK_INWARD_DETAILRow(
                0,
                "",
                txtID.Text,
                item.Product_ID,
                item.Product_ID,
                item.Provider_ID,
                MyLogin.LoginDate.AddDays(
                    item.ExpiryValue),
                (int)item.VAT_ID,
                0,
                0,
                "",
                "",
                0,
                0,
                Convert.ToDecimal(item.Org_Price),
                Convert.ToDecimal(item.Org_Price),
                "",
                "",
                item.Unit,
                1,
                0,
                0,
                "",
                0,
                true,
                0,
                Convert.ToDecimal(item.Quantity),
                1,
                Guid.NewGuid(),
                item.Product_Type_ID,
                item.Product_Name,
                "", 0, 0, 0);

            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void ProductAdd(string id)
        {
            var pro = new PRODUCT();

            if (pro.Get(id) != "OK") return;

            gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
            gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);


            gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
            gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 0);
            gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
            gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], 0);
            gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], "");
            gbList.SetFocusedRowCellValue(gbList.Columns["Limit"], DateTime.Today.AddDays(pro.ExpiryValue));
            gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);


            if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
            Total();
        }

        private void Total()

        {
            double Amount = 0.0;

            for (int i = 0; i < gbList.RowCount; i++)
            {
                Amount +=
                    Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                         ? 0
                                         : gbList.GetRowCellValue(i, "Amount"));
            }
        }

        private void RpgProductButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag.ToString())
            {
                case "Search":
                    {
                        var xfmProducts = new xfmProducts(true);
                        xfmProducts.ItemSelected += XfmProductsItemSelected;
                        xfmProducts.ShowDialog();
                    }
                    break;
                case "Add":
                    {
                        var xfmItemAdd = new xfmItemAdd(Actions.Add);
                        xfmItemAdd.Added += XfmItemAddAdded;
                        xfmItemAdd.ShowDialog();
                    }
                    break;
            }
            // this.Enabled = true;
        }

        private void XfmItemAddAdded(object sender, PRODUCT item)
        {
            Product_Init();
            gbList.AddNewRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
        }

        private void XfmProductsItemSelected(object sender, PRODUCT item)
        {
            Product_Init();
            gbList.AddNewRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
        }

        public override void Clear()
        {
            //base.Clear();
            dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Clear();
        }

        public override void Add()
        {
            if (!MyRule.IsAdd("bbiInitInventory")) return;

            var cls = new STOCK_INWARD();
            txtID.Text = cls.CreateKey("DK");


            txtDescription.Text = "";
            DisableControl(true);
            txtID.Properties.ReadOnly = false;
            txtReciever.Text = "";

            Err.ClearErrors();

            Updated();
            m_Status = Actions.Add;
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
        }

        public override bool Check()
        {
            //if (txtReciever.Text == string.Empty)
            //{
            //    txtReciever.Focus();
            //    Err.SetError(txtReciever, "Ô này không được rỗng");
            //    return false;
            //}
            if (txtID.Text == string.Empty)
            {
                txtID.Focus();
                Err.SetError(txtID, "Ô này không được rỗng");
                return false;
            }

            if (txtID.ErrorText != string.Empty)
            {
                txtID.Focus();
                Err.SetError(txtID, "Mã phiếu đã tồn tại");
                return false;
            }

            if (dtCreated.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtCreated.Focus();
                return false;
            }
            if (dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Rows.Count == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public override void DisableControl(bool disable)
        {
            gcList.Enabled = disable;
            Bar.Bar.bbiCancel.Enabled = disable;
            Bar.Bar.bbiSave.Enabled = disable;
            Bar.Bar.bbiSaveNew.Enabled = disable;
            Bar.Bar.bbiSaveM.Enabled = disable;
        }

        private bool DetailCheck()
        {
            if (gbList.RowCount - 1 == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return false;
            }
            dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable dt = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;


            string text;
            int j = 0;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                j++;
                text = gbList.GetDisplayTextByColumnValue(colProduct_ID, dt.Rows[i]["Product_ID"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    //dt.Rows.RemoveAt(i);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                    return false;
                }

                text = gbList.GetDisplayTextByColumnValue(colStock_ID, dt.Rows[i]["Stock_ID"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Chưa chọn kho hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colStock_ID, "Chưa chọn kho hàng");
                    //dt.Rows.RemoveAt(i);
                    return false;
                }

                if (dt.Rows[i]["Stock_ID"] == null | dt.Rows[i]["Stock_ID"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Kho hàng nhập không đúng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colStock_ID, "Kho hàng xuất không đúng");
                    return false;
                }
                if (dt.Rows[i]["Product_ID"] == null | dt.Rows[i]["Product_ID"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                    return false;
                }

                if (dt.Rows[i]["Unit"] == null | dt.Rows[i]["Unit"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Đơn vị tính không đúng.\n\tDòng số: " + (j), "Cảnh Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colProduct_ID, "Đơn vị tính không đúng");
                    return false;
                }
            }

            return true;
        }

        public override string uc_Save()
        {
            if (!MyRule.IsAdd("bbiInitInventory")) 
            {
                MyRule.Notify();
                return ""; 
            }


            SysLog.Insert("Nhập Kho Đầu Kỳ", "Thêm", txtID.Text);

            if (!DetailCheck()) return "";


            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            if (CODE.TypeSoft == 0 || CODE.TypeSoft == 1)
            {
                if (INVENTORY_DETAIL.Count > INVENTORY_DETAIL.LimitRecord)
                {
                    DoHide();
                    CODE.Notify();
                    return "Phần mềm bị giới hạn dữ liệu, vui lòng đăng ký phiên bản thu phí.";
                }
            }


            var mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            var cls = new STOCK_INWARD(
               txtID.Text,
               dtCreated.DateTime,
               "",
               0,
               "11111111-1111-1111-1111-111111111111",
               "",
               DateTime.Now,
               DateTime.Now,
               txtID.Text,
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               "",
               txtReciever.Text,//"",
               "Nhập Kho",
               0,
                cbCurrency.Text,
               txtExchangeRate.Value,
               0, 
               0,
               Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * txtExchangeRate.Value,
               0,
               DateTime.Now, 
               0, 
               cbCurrency.Text == SysOption.Currency ? 0 : Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
               0, 
               0,
               false,
               txtDescription.Text,
               0,
               MyLogin.UserId,
               true);

            if (!cls.Insert(mySql.Transaction))
            {
                result = mySql.Result;
                DoHide();
                mySql.RollBack();

                return result;
            }

            result = DetailSave(mySql);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();

                return result;
            }

            mySql.Commit();

            DoHide();
            Cancel();
            SetData(txtID.Text);
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
            Cursor.Current = Cursors.Default;
            return result;
        }

        private string DetailSave(SqlHelper sql)
        {
            string result = "OK";

            var cls = new STOCK_INWARD_DETAIL();
            dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable dt =
                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;

            int row = 0;
            string id = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    row++;

                    if (dt.Rows[i]["Stock_ID"] == DBNull.Value)
                    {
                        DoHide();
                        XtraMessageBox.Show("Lỗi:\n\tChưa chọn kho xuất.\n\tDòng lỗi: " + (row), "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        result = "Chưa chọn kho hàng";
                        sql.RollBack();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colStock_ID, "Chưa chọn kho hàng");
                        return result;
                    }

                    if (dt.Rows[i]["Product_ID"] == DBNull.Value)
                    {
                        DoHide();
                        XtraMessageBox.Show("Lỗi:\n\tVui lòng chọn mặt hàng.\n\tDòng lỗi: " + (row), "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sql.RollBack();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                        result = "Chưa chọn mặt hàng";
                        return result;
                    }

                    id = dt.Rows[i]["ID"].ToString();
                }

                switch (dr.RowState)
                {
                    case DataRowState.Added:
                        if (!cls.Insert(
                            sql.Transaction,
                        Guid.NewGuid().ToString(),
                        txtID.Text,
                        dt.Rows[i]["Product_ID"].ToString(),
                        dt.Rows[i]["Product_Name"].ToString(),
                        0,
                        dt.Rows[i]["Stock_ID"].ToString(),
                         dt.Rows[i]["Unit"].ToString(),
                        1,
                        0,
                        0, // VatAmount
                        0,
                        Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                        0, //DiscountRate
                        0,
                        0,
                        DateTime.Now,
                        0,
                        0,
                        "",
                        "",
                        "",
                       "",
                        "",
                        "",
                        "",
                        0,
                       "",
                        0,
                        true
                                 ))
                        {
                            sql.RollBack();

                            gbList.FocusedRowHandle = row;
                            gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                            return "Mặt hàng này sẽ không được lưu!";
                        }
                        break;
                    case DataRowState.Modified:
                        if (!cls.Update(
                           sql.Transaction,
                        id,
                        txtID.Text,
                         dt.Rows[i]["Product_ID"].ToString(),
                        dt.Rows[i]["Product_Name"].ToString(),
                        0,
                        dt.Rows[i]["Stock_ID"].ToString(),
                        dt.Rows[i]["Unit"].ToString(),
                        1,
                        0,
                        0, // VatAmount
                        0,
                        Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"]),
                        0, // DiscountRate
                        0,
                        0,
                        DateTime.Now,
                        0,
                        0,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        0,
                        "",
                        0,
                        true
                                 ))
                        {
                            result = sql.Result;
                            sql.RollBack();

                            gbList.FocusedRowHandle = row;
                            gbList.SetColumnError(colProduct_ID, result);
                            return "Mặt hàng này sẽ không được lưu!";
                        }
                        break;
                    case DataRowState.Deleted:
                        if (!cls.Delete(sql.Transaction, dt.Rows[i]["ID", DataRowVersion.Original].ToString()))
                        {
                            result = sql.Result;
                            sql.RollBack();
                            DoHide();

                            gbList.FocusedRowHandle = row;
                            gbList.SetColumnError(colProduct_ID, result);
                            return "Mặt hàng này sẽ không được lưu!";
                        }
                        break;
                }
            }

            return result;
        }

        private void GbListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gbList.FocusedColumn == colQuantity)
                {
                    _mColumn = Column.Lock;

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colQuantity, 0);
                    _mColumn = Column.None;
                }
                else if (gbList.FocusedColumn == colUnitPrice)
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
                    DeleteSelected();
                }
            }


            ProcessDialogKey(e.KeyData);
        }

        public bool KeyDoEvent(Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Alt | Keys.D):
                    MessageBox.Show(@"You are stupid");
                    break;
                case Keys.F1:
                    F11Execute();
                    break;
                case Keys.F3:
                    F3Execute();
                    break;
                case Keys.F4:
                    F4Execute();
                    break;
                case Keys.F5:
                    F5Execute();
                    break;
                case Keys.F6:
                    F9Execute();
                    break;
                case Keys.F7:
                    F7Execute();
                    break;
                case Keys.F8:
                    F8Execute();
                    break;
                case Keys.F9:
                    F9Execute();
                    break;
                case Keys.F11:
                    F11Execute();
                    break;
                case Keys.F12:
                    F12Execute();
                    break;
                case (Keys.Control | Keys.N):
                    Add();
                    break;
                case (Keys.Control | Keys.T):
                    Add();
                    break;
                case (Keys.Control | Keys.S):
                    Save();
                    break;
                case (Keys.Control | Keys.W):
                    Save();
                    break;
                case Keys.F2:
                    Save();
                    break;
                case (Keys.Control | Keys.Shift | Keys.S):
                    Save();
                    break;
                case (Keys.Control | Keys.Shift | Keys.W):
                    Save();
                    break;
                case (Keys.Shift | Keys.F2):
                    Save();
                    break;
                case (Keys.Control | Keys.P):
                    Print();
                    break;
                case Keys.Escape:
                    Cancel();
                    EscapeExecute();
                    break;
                case (Keys.Alt | Keys.X):
                    if (ParentForm != null) ParentForm.Close();
                    break;
                case Keys.F10:
                    F10Execute();
                    if (ParentForm != null) ParentForm.Close();
                    break;
            }
            return false;
        }

        public new void SetData(string table)
        {
            var cls = new STOCK_INWARD();
            if (!cls.Get(table))
            {
                XtraMessageBox.Show("Không tìm thấy thông tin phiếu này", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }

            m_Status = Actions.Change;
            DisableControl(true);

            if (m_Status == Actions.Change)
            {
                txtID.Properties.ReadOnly = true;
                txtID.Text = cls.ID;
            }
            dtCreated.DateTime = cls.RefDate;
            cbCurrency.Text = cls.Currency_ID;
            txtExchangeRate.Value = Convert.ToDecimal(cls.ExchangeRate);
            txtReciever.Text = cls.Contact;
            txtDescription.Text = cls.Description;

            var adapter = new STOCK_INWARD_DETAILTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL, txtID.Text);
            Updated();
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        public override string uc_Change()
        {
            if (!MyRule.IsEdit("bbiInitInventory")) 
            {
                MyRule.Notify();
                return ""; 
            }

            SysLog.Insert("Nhập Kho Đầu Kỳ", "Cập Nhật", txtID.Text);

            if (!DetailCheck()) return "";


            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            if (CODE.TypeSoft == 0 || CODE.TypeSoft == 1)
            {
                if (INVENTORY_DETAIL.Count > INVENTORY_DETAIL.LimitRecord)
                {
                    DoHide();
                    CODE.Notify();
                    return "Phần mềm bị giới hạn dữ liệu, vui lòng đăng ký phiên bản thu phí.";
                }
            }

            var mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            var cls = new STOCK_INWARD(
               txtID.Text,
                dtCreated.DateTime,
                "",
               0,
                "11111111-1111-1111-1111-111111111111",//"",
                "",
                DateTime.Now,
                DateTime.Now,
                txtID.Text,
                "",
                "",
                "",
                "",
                "",
                "",
                "", // customername
                "",
                txtReciever.Text,//"",
                "Nhập Kho",
                0,
                 cbCurrency.Text,
                txtExchangeRate.Value,
                0, // VAT
                0,//VatAmount
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * txtExchangeRate.Value,
                0,
                DateTime.Now, // DiscountDate
                0, // DiscountRate
                cbCurrency.Text == SysOption.Currency ? 0 : Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                0, // OtherDiscoutn
                0,
                false,
                txtDescription.Text,
                0,
                MyLogin.UserId,
                true);

            if (!cls.Update(mySql.Transaction))
            {
                result = mySql.Result;
                DoHide();
                mySql.RollBack();

                return result;
            }

            result = DetailSave(mySql);
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();

                return result;
            }

            mySql.Commit();


            DoHide();
            Cancel();
            SetData(txtID.Text);
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
            Cursor.Current = Cursors.Default;
            return result;
        }

        private void Print(bool preview)
        {
           // nhập từ file excel

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Excel WorkSheet(*.xls)|*.xls";
            OFD.InitialDirectory = Application.StartupPath;
            if (OFD.ShowDialog() != DialogResult.OK) return;
            ExcelDataReader excelDataReader = new ExcelDataReader(OFD.FileName);
            string ERROR = "";
            excelDataReader.ExcelReaderComplete += (obj, dtImport) =>
            {
                DataTable dtTemp = new DataTable();
                dtTemp.Columns.Add("Product_ID", typeof(string));
                dtTemp.Columns.Add("Product_Name", typeof(string));
                dtTemp.Columns.Add("Unit", typeof(string));
                dtTemp.Columns.Add("Stock_ID", typeof(string));
                dtTemp.Columns.Add("Quantity", typeof(decimal));
                dtTemp.Columns.Add("UnitPrice", typeof(decimal));
                dtTemp.Columns.Add("Charge", typeof(decimal));
                dtTemp.Columns.Add("Amount", typeof(decimal));
                dtTemp.Columns.Add("Batch", typeof(string));
                dtTemp.Columns.Add("Serial", typeof(string));
                int count = 0;

                foreach (DataRow dr in dtImport.Rows)
                {
                    count++;
                    SetWaitDialogCaption(string.Format("Đang nạp dữ liệu: {0}/{1}", count, dtImport.Rows.Count));
                    string UnitName = Convert.ToString(dr["Đơn Vị"]);
                    UNIT u = new UNIT();
                    u.GetByName(UnitName);

                    string StockName = Convert.ToString(dr["Kho Mặc Định"]);
                    STOCK st = new STOCK();
                    st.GetByName(StockName);

                    PRODUCT item = new PRODUCT();
                    item.Get(Convert.ToString(dr["Mã Hàng"]));

                    try
                    {
                        dtTemp.Rows.Add(
                            Convert.ToString(dr["Mã Hàng"]),
                            Convert.ToString(dr["Tên Hàng"]),
                            u.Unit_ID,
                            st.Stock_ID,
                            Convert.ToDecimal(dr["Số Lượng"] == DBNull.Value ? 0 : dr["Số Lượng"]),
                            Convert.ToDecimal(dr["Đơn Giá"] == DBNull.Value ? 0 : dr["Đơn Giá"]),
                            Convert.ToDecimal(dr["Thành Tiền"] == DBNull.Value ? 0 : dr["Thành Tiền"]),
                            Convert.ToDecimal(dr["Thành Tiền"] == DBNull.Value ? 0 : dr["Thành Tiền"]),
                            "",
                            ""
                            );
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                DoHide();

                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Rows.Clear();
                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Merge(dtTemp);
                gcList.Refresh();
                DisableControl(true);
            };
            excelDataReader.ExcelReaderError += (obj, Message) =>
            {
                ERROR += Message + "\n";
            };
            excelDataReader.ExcelReadByADO(OFD.FileName, "Sheet");
            //DataTable dttmp = gcList.DataSource as DataTable;
            if (ERROR != "")
                MessageBox.Show(ERROR);
        }

        public override void Print()
        {
           
            //SysLog.Insert("Nhập Kho", "In", txtID.Text);
            Print(true);
        }

        private void TxtIDEditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit) sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }

            if (m_Status != Actions.Add) return;
            var stockInward = new TRANS_REF();
            if (stockInward.Exist(txt.Text))
            {
                Err.SetError(txt, "Mã đã tồn tại.");
                txt.Focus();
            }
        }

        private void TxtIDLeave(object sender, EventArgs e)
        {
            var txt = (TextEdit) sender;

            if (m_Status == Actions.None) return;

            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
                //txt.Focus();
            }
            else
            {
                var stockInward = new TRANS_REF();

                if (m_Status == Actions.Add)
                {
                    if (!stockInward.Exist(txt.Text)) return;
                    Err.SetError(txt, "Mã đã tồn tại.");
                    //txt.Focus();
                }
                else
                {
                    SetData(txtID.Text);
                }
            }
        }

        private void TxtIDKeyDown(object sender, KeyEventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;

            var txt = (TextEdit) sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }
            if (e.KeyCode == Keys.Enter)
            {
                //if (!(e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)) return;
                var stockInward = new TRANS_REF();

                if (m_Status == Actions.Add)
                {
                    if (!stockInward.Exist(txt.Text)) return;
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
                else
                {
                    SetData(txtID.Text);
                }
            }
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Column)
                {
                    //MessageBox.Show("Ad");

                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();
                }
                switch (gbList.CalcHitInfo(e.X, e.Y).HitTest)
                {
                    case BandedGridHitTest.ColumnButton:
                        Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                        Bar.Bar.bm.HideToolBarsPopup();
                        Bar.Bar.pm.HidePopup();
                        break;
                    case BandedGridHitTest.Row:
                        Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                        break;
                    case BandedGridHitTest.RowCell:
                        Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                        break;
                    case BandedGridHitTest.EmptyRow:
                        Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                        break;
                    case BandedGridHitTest.RowFooter:
                        Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                        break;
                }
            }

          

            DisableMenu(false);
            if (gbList.RowCount - 1 == 0)
            {
                DisableMenu(true);
                return;
            }

            //Get Object 
            object arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            Bar.Bar.bbiProduct.Enabled = true;
        }

        


        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
           
            int rowIndex = e.RowHandle;
            if (rowIndex < 0) return;
            rowIndex++;
            e.Info.DisplayText = rowIndex.ToString();
        }


        private void XucInwardsLoad(object sender, EventArgs e)
        {
        }

        private void RpglkProductCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void RpgProductDoubleClick(object sender, EventArgs e)
        {
            ProductDetail();
        }

        private void RpProductNameDoubleClick(object sender, EventArgs e)
        {
            ProductDetail();
        }

        private void RpProductNameCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpgProductCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpUnitCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpgStockCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpgProductKeyDown(object sender, KeyEventArgs e)
        {
            ProcessDialogKey(e.KeyData);
        }

        private void RpgStockDoubleClick(object sender, EventArgs e)
        {
            StockDetail();
        }

        private void StockDetail()
        {
            object arg = gbList.GetFocusedRowCellValue("Stock_ID");

            if (arg == null) return;
            var product = new STOCK();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmStockAdd(Actions.Update, product);

            xfmItemAdd.Show(this);
        }

        private void CbCurrencySelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurrency.Text == SysOption.Currency)
            {
                txtExchangeRate.Value = 1;
                txtExchangeRate.Properties.ReadOnly = true;
                liExChangeRate.Visibility = LayoutVisibility.Never;
            }
            else
            {
                txtExchangeRate.Value = 17000;
                txtExchangeRate.Properties.ReadOnly = false;
                liExChangeRate.Visibility = LayoutVisibility.Always;
            }
            SetIndex();
        }

        private void SetIndex()
        {
            for (int i = 0; i < gbList.RowCount; i++)
            {
                gbList.SetRowCellValue(i, "Active", 1);
            }
        }


        protected override void Refresh()
        {
            Updated();
            //base.Refresh();
        }


        private void TxtDescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                gbList.Focus();
            }
        }

        #region Popup

        public override void DeleteSelected()
        {
            if (gbList.GetSelectedRows().Length > 0)
            {
                if (
                    XtraMessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                gbList.DeleteSelectedRows();
            }
            else
            {
                gbList.DeleteRow(gbList.FocusedRowHandle);
            }
            gbList.UpdateCurrentRow();
        }

        public override void SelectAll()
        {
            gbList.SelectAll();
        }

        public override void DeleteAll()
        {
            if (
                XtraMessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No) return;
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
            Clear();
        }

        public override void Search()
        {
            var xfmProducts = new xfmProducts(true);
            xfmProducts.ItemSelected += XfmProductsItemSelected;
            xfmProducts.ShowDialog();
        }

        public override void ProductDetail()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            xfmItemAdd.ShowDialog();
        }


        public override void Inventory()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;
            var xfmInventoryDetail = new xfmInventoryDetail();
            xfmInventoryDetail.SetData(arg.ToString(), "");
            xfmInventoryDetail.ShowDialog(this);
        }

        public override void History()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;
            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(arg.ToString(), "");
            xfmHistory.ShowDialog(this);
        }

        #endregion

        #region Nested type: Column

        private enum Column
        {
            None = 0,
            Quantity = 1,
            Price = 2,
            Amount = 3,
            ID = 4,
            Lock = 5,
            StockID = 14,
            Name = 15,
            Unit = 16,

            Lev1 = 17,
            Lev2 = 18,
            Lev3 = 19,
            Lev4 = 20,
        }

        #endregion
    }
}