using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Utils;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.Dictionary.UI;
using Perfect.Dictionary.UI.UBarcode;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Inward.Report;
using Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Net.Info;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inward.SALE
{
    public partial class XucInwardA : xucBaseB
    {
        #region Delegates

        public delegate void CheckBarcodeEvenhandler(object sender, bool chk);

        #endregion

        #region Column enum

        public enum Column
        {
            None = 0,
            Quantity = 1,
            Price = 2,
            Amount = 3,
            ID = 4,
            Lock = 5,
            ImportTaxID = 6,
            ExportTaxID = 7,
            LuxuryTaxID = 8,
            VatID = 9,
            ChargeTransport = 10,
            ChargeDelivery = 11,
            Discount = 12,
            Vat = 13,
            StockID = 14,
            Name = 15,
            Unit = 16,
            Height= 17,
            DiscountRate = 18
        }

        #endregion

        private Column _mColumn;
        private EnumRefType _part;
        private int _refStatus;

        public XucInwardA(EnumRefType refType)
        {
            _mColumn = new Column();
            InitializeComponent();
            _part = new EnumRefType();
            _part = refType;
            _exportView = gbList;
            dtCreated.DateTime = MyLogin.LoginDate;
            dtDueTime.DateTime = MyLogin.LoginDate;
        }

        public EnumRefType Part
        {
            get { return _part; }
            set
            {
                _part = value;
                SetInterface();
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();
        }


        public void CustomerInit()
        {
            pROVIDERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROVIDERTableAdapter.Fill(dsPROVIDER.PROVIDER);
            txtCustomerName.Focus();
            txtCustomerName.Properties.View.ActiveFilterString = "ActiveInt = 1";
            txtCustomerID.Properties.View.ActiveFilterString = "ActiveInt = 1";
        }

        public void SetCustomer(CUSTOMER item)
        {
            CustomerInit();
            //dsPROVIDER.PROVIDER.AddPROVIDERRow(item.CustomerName, item.Customer_ID);
            if (item.Active) txtCustomerName.EditValue = item.Customer_ID;
        }

        public void SetStock(STOCK item)
        {
            //dsSTOCK.STOCK.AddSTOCKRow(item.Stock_Name, item.Stock_ID, item.Active);
            StockInit();
        }

        public void StockInit()
        {
            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsSTOCK.STOCK);
            rpgStock.View.ActiveFilterString = "ActiveInt = 1";
            
        }

        public void ProductInit()
        {
            var adapter = new PRODUCTTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.FillBy(dsPRODUCT.PRODUCT);
            rpgProduct.View.ActiveFilterString = "ActiveInt = 1";
            rpProductName.View.ActiveFilterString = "ActiveInt = 1";
        }


        private void EmpInit()
        {
            eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEETableAdapter.ClearBeforeFill = true;
            eMPLOYEETableAdapter.Fill(dsEmpForStock.EMPLOYEE);

            if (dsEmpForStock.EMPLOYEE.Rows.Count > 0)
            {
                if (txtEmployee.Text == "") txtEmployee.EditValue = MyLogin.EmployeeID == "" ? Convert.ToString(dsEmpForStock.EMPLOYEE.Rows[0]["Employee_ID"]) : MyLogin.EmployeeID;
            }
        }

        public void UnitInit()
        {
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsUnit.UNIT);
        }

        public new void Init()
        {
            SetWaitDialogCaption("Nạp thông tin dữ liệu ....");
            Updated();
            ucBarcode = new XucBaseBarcode(1);
            lcBarcode.Control = ucBarcode;
            lcBarcode.TextVisible = false;
            ucBarcode.ItemSelected += UcBarcodeItemSelected;

            _mColumn = Column.None;
            //if (CODE.TypeSoft < 400 & CODE.TypeSoft != 0)
            //{
            //    colUnit.OptionsColumn.AllowEdit = false;
            //}

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            SetWaitDialogCaption("Nạp hoàn thành....");
            DoHide();
        }

        public void Updated()
        {
            Cursor.Current = Cursors.WaitCursor;
            CustomerInit();
            StockInit();
            ProductInit();
            UnitInit();
            EmpInit();
            CashMethodInit();
            CashTermInit();
            Cursor.Current = Cursors.Default;
        }

        private void CashMethodInit()
        {
            Cursor.Current = Cursors.WaitCursor;
            cASH_METHODTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cASH_METHODTableAdapter.Fill(dsSaleDic.CASH_METHOD);
            if (txtMethod.Text == "")
            {
                if (dsSaleDic.CASH_METHOD.Rows.Count > 0)
                {
                    txtMethod.EditValue = dsSaleDic.CASH_METHOD.Rows[0]["ID"];
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void CashTermInit()
        {
            cASH_TERMTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cASH_TERMTableAdapter.Fill(dsSaleDic.CASH_TERM);
            if (txtTerm.Text == "")
                if (dsSaleDic.CASH_TERM.Rows.Count > 0)
                    txtTerm.EditValue = dsSaleDic.CASH_TERM.Rows[0]["ID"];
        }

        private void UcBarcodeItemSelected(object sender, Barcode item)
        {
            if (m_Status == Actions.None) return;

            if (item.Action == TypeAdd.Duplicate)
            {
                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.AddSTOCK_INWARD_DETAILRow(
                    0,
                    "",
                    txtID.Text,
                    item.Item.Product_ID,
                    item.Item.Product_ID,
                    item.Item.Provider_ID,
                    MyLogin.LoginDate.AddDays(item.Item.ExpiryValue),
                    (int) item.Item.VAT_ID,
                    0,
                    0,
                    "",
                    "",
                    0,
                    Convert.ToDecimal(item.Quantity),
                    Convert.ToDecimal(item.Price),
                    Convert.ToDecimal(item.Amount),
                    "",
                    "",
                    item.Item.Unit,
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
                    item.Item.Product_Type_ID,
                    item.Item.Product_Name,
                    "", 0, 0, 0);
            }
            else if (item.Action == TypeAdd.Add)
            {
                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable dt = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;
                bool add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    add = true;
                    double qty = Convert.ToDouble(dt.Rows[i]["Quantity"] ?? 0) + item.Quantity;
                    ;
                    double uni = Convert.ToDouble(dt.Rows[i]["UnitPrice"] ?? 0);
                    dt.Rows[i]["Quantity"] = qty;
                    if (uni == 0)
                    {
                        dt.Rows[i]["UnitPrice"] = item.Price;
                        uni = item.Price;
                    }
                    dt.Rows[i]["Amount"] = uni*qty;
                    break;
                }

                if (!add)
                {
                    dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.AddSTOCK_INWARD_DETAILRow(
                        0,
                        "",
                        txtID.Text,
                        item.Item.Product_ID,
                        item.Item.Product_ID,
                        item.Item.Provider_ID,
                        MyLogin.LoginDate.AddDays(
                            item.Item.ExpiryValue),
                        (int) item.Item.VAT_ID,
                        0,
                        0,
                        "",
                        "",
                        0,
                        Convert.ToDecimal(item.Quantity),
                        Convert.ToDecimal(item.Price),
                        Convert.ToDecimal(item.Amount),
                        "",
                        "",
                        item.Item.Unit,
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
                        item.Item.Product_Type_ID,
                        item.Item.Product_Name,
                        "", 0, 0, 0);
                }
            }
            else if (item.Action == TypeAdd.Duplicate)
            {
                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable dt = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;
                bool add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    add = true;
                    dt.Rows[i]["Quantity"] = item.Quantity;
                    dt.Rows[i]["UnitPrice"] = item.Price;
                    dt.Rows[i]["Amount"] = item.Amount;
                    break;
                }

                if (!add)
                {
                    dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.AddSTOCK_INWARD_DETAILRow(
                        0,
                        "",
                        txtID.Text,
                        item.Item.Product_ID,
                        item.Item.Product_ID,
                        item.Item.Provider_ID,
                        MyLogin.LoginDate.AddDays(
                            item.Item.ExpiryValue),
                        (int) item.Item.VAT_ID,
                        0,
                        0,
                        "",
                        "",
                        0,
                        Convert.ToDecimal(item.Quantity),
                        Convert.ToDecimal(item.Price),
                        Convert.ToDecimal(item.Amount),
                        "",
                        "",
                        item.Item.Unit,
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
                        item.Item.Product_Type_ID,
                        item.Item.Product_Name,
                        "", 0, 0, 0);
                }
            }
            else if (item.Action == TypeAdd.Single)
            {
                dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable dt = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;
                bool add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;

                    alc.Show(ParentForm, "Thông Báo", "Hàng Hoá này đã tồn tại trong danh sách.");
                    gbList.MoveBy(i);
                    add = true;
                    break;
                }
                if (!add)
                {
                    dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.AddSTOCK_INWARD_DETAILRow(
                        0,
                        "",
                        txtID.Text,
                        item.Item.Product_ID,
                        item.Item.Product_ID,
                        item.Item.Provider_ID,
                        MyLogin.LoginDate.AddDays(
                            item.Item.ExpiryValue),
                        (int) item.Item.VAT_ID,
                        0,
                        0,
                        "",
                        "",
                        0,
                        Convert.ToDecimal(item.Quantity),
                        Convert.ToDecimal(item.Price),
                        Convert.ToDecimal(item.Amount),
                        "",
                        "",
                        item.Item.Unit,
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
                        item.Item.Product_Type_ID,
                        item.Item.Product_Name,
                        "", 0, 0, 0);
                }
            }
        }


        private void TxtCustomerNamePropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Search")
            {
                var xfmProviders = new xfmProviders(true);
                xfmProviders.ItemSelected += XfmProvidersItemSelected;
                xfmProviders.ShowDialog();
            }
            else if (e.Button.Tag.ToString() == "Add")
            {
                var customer = new PROVIDER(txtCustomerID.Text, 0, txtCustomerName.Text, "", "", txtAddress.Text, "", "",
                                            "", txtTel.Text, "", "", "", "", "", "", "", "", "", "", "", "", "",
                                            "", 0, 0, "", true);
                var xfmProviderAdd = new xfmProviderAdd(customer);
                xfmProviderAdd.Added += XfmProviderAddAdded;
                xfmProviderAdd.ShowDialog();
            }
        }

        private void XfmProviderAddAdded(object sender, PROVIDER item)
        {
            CustomerInit();
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void XfmProvidersItemSelected(object sender, PROVIDER item)
        {
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void TxtCustomerNameEditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;

            if (txtCustomerName.EditValue == null) return;
            var provider = new PROVIDER();
            if (provider.Get(txtCustomerName.EditValue.ToString()) == "OK")
            {
                txtCustomerID.Text = provider.Customer_ID;
                txtAddress.Text = provider.CustomerAddress;
                txtTel.Text = provider.Tel;
            }
        }

        private void TxtCustomerIDKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerID.Text == "") return;
                var cus = new PROVIDER();
                if (cus.Get(txtCustomerID.Text) == "OK")
                {
                    txtCustomerName.EditValue = cus.Customer_ID;
                    txtAddress.Text = cus.CustomerAddress;
                    txtTel.Text = cus.Tel;
                }
            }
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
                else if (e.Column.FieldName == "Unit")
                {
                    _mColumn = Column.Unit;
                }
                else if (e.Column.FieldName == "Height")
                {
                    _mColumn = Column.Height;
                }
                else if (e.Column.FieldName == "DiscountRate")
                {
                    _mColumn = Column.Height;
                }
            }

            switch (_mColumn)
            {
                case Column.None:
                    return;
                case Column.Quantity:
                    {
                        decimal quantity = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value);
                        decimal unitPrice = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        decimal discountRate = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "DiscountRate"));
                        decimal weight = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Height"));
 
                        decimal discount = (quantity * unitPrice * discountRate) / 100;
                        decimal amount = (quantity * unitPrice) - discount;
                        decimal width = quantity * weight;

                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                        gbList.SetRowCellValue(e.RowHandle, "Width", width);                        
                        _mColumn = Column.None;


                        break;
                    }
                case Column.Price:
                    {
                        decimal quantity = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Quantity"));
                        decimal unitPrice = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value);
                        decimal discountRate = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "DiscountRate"));
                        decimal weight = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Height"));

                        decimal discount = (quantity * unitPrice * discountRate) / 100;
                        decimal amount = (quantity * unitPrice) - discount;
                        decimal width = quantity * weight;

                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                        gbList.SetRowCellValue(e.RowHandle, "Width", width);
                        _mColumn = Column.None;

                        break; 
                    }

                case Column.DiscountRate:
                    {
                        decimal quantity = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Quantity"));
                        decimal unitPrice = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        decimal discountRate = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value); 
                        
                        decimal weight = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Height"));

                        decimal discount = (quantity * unitPrice * discountRate) / 100;
                        decimal amount = (quantity * unitPrice) - discount;
                        decimal width = quantity * weight;

                        _mColumn = Column.Lock;

                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                        gbList.SetRowCellValue(e.RowHandle, "Width", width);

                        _mColumn = Column.None;
            
                        break;
                    }

                case Column.ID:
                    _mColumn = Column.Lock;
                    if (e.Value != null)
                    {
                        ProductAdd(e.Value.ToString());
                    }
                    _mColumn = Column.None;
                    break;

                case Column.Name:
                    _mColumn = Column.Lock;
                    if (e.Value != null)
                    {
                        ProductAdd(e.Value.ToString());
                    }
                    _mColumn = Column.None;
                    break;

                case Column.Height:
                    {
                        decimal quantity = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Quantity"));
                        decimal unitPrice = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        decimal discountRate = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "DiscountRate"));
                        decimal weight = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value); 
                        
                        decimal discount = (quantity * unitPrice * discountRate) / 100;
                        decimal amount = (quantity * unitPrice) - discount;
                        decimal width = quantity * weight;

                        _mColumn = Column.Lock;

                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                        gbList.SetRowCellValue(e.RowHandle, "Width", width);

                        _mColumn = Column.None;

                        break;

                    }
                    break;
                case Column.Unit:
                    {
                        _mColumn = Column.Lock;
                        gbList.SetColumnError(colUnit, null);
                        object product_id = gbList.GetRowCellValue(e.RowHandle, "Product_ID") == DBNull.Value
                                                ? ""
                                                : gbList.GetRowCellValue(e.RowHandle, "Product_ID");
                        product_id = gbList.GetRowCellValue(e.RowHandle, "Product_ID") ?? "";
                        var product = new PRODUCT();
                        object qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        if (product.Get(product_id.ToString()) == "OK")
                        {
                            if (e.Value != null)
                            {
                                var unitconvert = new PRODUCT_UNIT();
                                decimal convert = unitconvert.GetConvert(product.Product_ID, product.Unit,
                                                                         e.Value.ToString());
                                decimal price= Convert.ToDecimal(product.Org_Price) * convert;
                                decimal amount = price * Convert.ToDecimal(qty);
                                decimal weight = Convert.ToDecimal(product.Depth) * convert;
                                decimal sumweight = weight * Convert.ToDecimal(qty);
                                if (convert == 0)
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "Unit", null);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", 1);
                                    gbList.SetRowCellValue(e.RowHandle, "Description", null);
                                    gbList.SetColumnError(colUnit, "Hàng hoá này không có đơn vị quy đổi này!");
                                }
                                else
                                {
                                    var unit1 = new UNIT();
                                    unit1.Get(product.Unit);
                                    string unitPro = unit1.Unit_Name.ToString();
                                    var unit2 = new UNIT();
                                    unit2.Get(e.Value.ToString());
                                    string unitConver = unit2.Unit_Name.ToString();
                                    var tenQC = convert.ToString(convert + " " + unitPro + "/" + unitConver);
                                    if (e.Value.ToString() != product.Unit)
                                    {
                                        gbList.SetRowCellValue(e.RowHandle, "Description", tenQC);
                                        
                                    }
                                    else
                                    {
                                        gbList.SetRowCellValue(e.RowHandle, "Description", null);
                                    }
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", convert);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitPrice", price);
                                    gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                                    gbList.SetRowCellValue(e.RowHandle, "Height", weight);
                                    gbList.SetRowCellValue(e.RowHandle, "Width", sumweight);
                                }
                            }
                        }
                        _mColumn = Column.None;
                    }
                    break;
            }
            gbList.UpdateSummary();
            gbList.UpdateTotalSummary();

            Total();
            _mColumn = Column.None;
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void GbListCellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            gbList.ClearColumnErrors();
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
                (int) item.VAT_ID,
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

            if (pro.Get(id) == "OK")
            {
                if (txtCustomerName.Text == "")
                {
                    txtCustomerName.EditValue = pro.Customer_ID;
                }

                gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);
                gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);

                gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);

                gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 1);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
                gbList.SetFocusedRowCellValue(gbList.Columns["DiscountRate"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["Discount"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], pro.Org_Price);

                gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], "");
                gbList.SetFocusedRowCellValue(gbList.Columns["Limit"], DateTime.Today.AddDays(pro.ExpiryValue));
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], pro.Provider_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Height"], pro.Depth);
                gbList.SetFocusedRowCellValue(gbList.Columns["Width"], pro.Depth);
                if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                gbList.UpdateSummary();
                gbList.UpdateTotalSummary();
                Total();
            }
        }

        private void Total()
        {
            gbList.UpdateSummary();
            decimal TotalCharge = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            decimal VatRate = txtVatRate.Value;
            txtTotalCharge.Value = TotalCharge;
            txtVatAmount.Value = VatRate * TotalCharge / 100;
            txtTotalAmount.Value = txtTotalCharge.Value + txtVatAmount.Value;
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
            ProductInit();
            gbList.AddNewRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
        }

        private void XfmProductsItemSelected(object sender, PRODUCT item)
        {
            ProductInit();
            gbList.AddNewRow();
            gbList.SetRowCellValue(gbList.FocusedRowHandle, "Product_ID", item.Product_ID);
        }

        public override void Clear()
        {
            dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Clear();
        }

        public override void Add()
        {
            if (!MyRule.IsAdd("bbiPurchase")) return;

            var cls = new STOCK_INWARD();
            {
                txtID.Text = cls.CreateKey("MH_" + MyLogin.Account + "_");
            }


            txtDescription.Text = "";
            DisableControl(true);
            txtID.Properties.ReadOnly = false;
            dtCreated.EditValue = DateTime.Now;
            txtVatAmount.Value = 0;
            txtVatRate.Value = 0;
            txtDocLink.Text = "";
            Total();
            Updated();
            m_Status = Actions.Add;
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
        }

        public override bool Check()
        {
            if (_part == EnumRefType.StockInward)
            {
                if (txtCustomerName.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    txtCustomerName.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCustomerID.Text))
                {
                    XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    txtCustomerID.Focus();
                    return false;
                }
            }
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
            // plTop.Enabled = readOnly;
            gcList.Enabled = disable;
            //Bar.Bar.bbiAdd.Enabled = !disable;
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
            var dt = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;


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

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            if (!MyRule.IsAdd("bbiPurchase")) 
            {
                MyRule.Notify();
                return ""; 
            }


            SysLog.Insert("Nhập Kho", "Thêm", txtID.Text);

            if (!DetailCheck()) return "";

 
            Total();
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
 
            STOCK_INWARD cls = new STOCK_INWARD();
            if (cls.Get(txtID.Text))
            {
                if (XtraMessageBox.Show("Mã phiếu đã tồn tại. Bạn có muốn tạo mã mới không!?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return "";
                cls.CreateKey("MH_" + MyLogin.Account + "_");
                return "";
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

            cls = new STOCK_INWARD(
                txtID.Text,
                dtCreated.DateTime,
                "",
                (int) _part,
                Convert.ToString(txtMethod.EditValue),
                Convert.ToString(txtTerm.EditValue),
                dtDueTime.DateTime,
                DateTime.Now,
                txtID.Text,
                "",
                Convert.ToString(txtEmployee.EditValue),
                "",
                "",
                "",
                txtCustomerID.Text,
                txtCustomerName.Text,
                txtAddress.Text,
                "",
                txtDocLink.Text.Trim(),
                0,
                "VND",
                1,
                Convert.ToInt32(txtVatRate.Value),
                txtVatAmount.Value,
                txtTotalAmount.Value,
                txtTotalAmount.Value,
                DateTime.Now,
                0,
                Convert.ToDecimal(colDiscount.SummaryItem.SummaryValue),
                0,
                txtTotalCharge.Value,
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

            //if (Convert.ToString(txtTerm.EditValue) == "TM")
            //{
            //    result = DebtInsert(mySql);
            //    if (result != "OK")
            //    {
            //        mySql.RollBack();
            //        DoHide();
            //        return result;
            //    }
            //}

            result = DetailSave(mySql);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                return result;
            }

            mySql.Commit();
            if (chxIsPrint.Checked) Print(false);
            Cursor.Current = Cursors.Default;
            DoHide();
            Cancel();
            SetData(txtID.Text);
            NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
            Cursor.Current = Cursors.Default;
            return result;
        }

        private string DebtInsert(SqlHelper sql)
        {
            DEBT_OUTWARD debt = new DEBT_OUTWARD(); //Path: Perfect.Inventory.Core.Inventory.Outward.Class
            bool result = debt.GetByIO(sql.Transaction, txtID.Text);
            /* 
             * sau khi chèn phiếu xong sẽ tự phát sinh công nợ nếu số tiền > 0
             */
            if (result)
            {
                debt.TermID = Convert.ToString(txtTerm.EditValue);
                debt.Amount = txtTotalAmount.Value;
                debt.Payment = 0;//đã set dưới Store
                debt.Balance = 0;
                debt.FAmount = txtTotalAmount.Value;
                result = debt.Update(sql.Transaction);
                if (!result) return "Không thể cập nhật vào bảng công nợ. Vui lòng chọn thanh toán là 'Công nợ'";
            }
            else
            {
                /*
                 * nếu số tiền = 0 thì dừng lại, vì không có công nợ
                 */
                return "OK";
            }
            Guid _id = Guid.NewGuid();
            PROVIDER_PAYMENT_INWARD ppi = new PROVIDER_PAYMENT_INWARD();
            string PhieuChiID = ppi.NewID(sql.Transaction, "PCN." + MyLogin.Account + ".");

            result = ppi.Insert(
                sql.Transaction,
                _id,
                PhieuChiID,
                dtCreated.DateTime,
                txtID.Text,
                42,
                1,
                new Guid(Convert.ToString(txtMethod.EditValue)),
                "",
                "VND",
                1,
                "",
                "",
                txtCustomerID.Text,
                txtCustomerName.Text,
                txtAddress.Text,
                "",
                "",
                txtTotalAmount.Value,
                0,
                0,
                0,
                false,
                false,
                MyLogin.Account,
                DateTime.Now,
                MyLogin.Account,
                DateTime.Now,
                Convert.ToString(txtEmployee.EditValue),
                "Thu tiền khách hàng",
                0,
                true
                );
            if (!result) 
                return "Có lỗi xãy ra trong quá trình cập nhật phiếu thu. Vui lòng chọn thanh toán là 'Công nợ'";
            else 
                ppi.UpdateRefStatus(sql.Transaction, txtID.Text); // this is suck! damn it!

            Guid detailID = Guid.NewGuid();
            PROVIDER_PAYMENT_DETAIL_INWARD ppdi = new PROVIDER_PAYMENT_DETAIL_INWARD();
            result = ppdi.Insert(sql.Transaction,
                detailID,
                _id,
                debt.ID,
                "VND",
                1,
                1,
                txtTotalAmount.Value,
                txtTotalAmount.Value,
                txtTotalAmount.Value,
                0,
                0,
                0,
                0,
                0,
                0,
                txtCustomerName.Text,
                0);
            
            if (!result) return "Không thể cập nhật vào bảng công nợ. Vui lòng chọn thanh toán là 'Công nợ'";
            return "OK";
        }

        private string DetailSave(SqlHelper sql)
        {
            string result = "OK";

            var cls = new STOCK_INWARD_DETAIL();
            var dt = dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;

            int row = 0;
            string id = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr.RowState != DataRowState.Deleted)
                {
                    if (Convert.ToDecimal(dt.Rows[i]["Quantity"]) == 0)
                    {
                        XtraMessageBox.Show("Lỗi:\n\tSố lượng nhập = 0.\n\tDòng lỗi: " + (row + 1), "Thông báo",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        result = "Số lượng nhập = 0";
                        sql.RollBack();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, "Số lượng nhập = 0");
                        return result;
                    }
                    if (dt.Rows[i].RowState != DataRowState.Deleted)
                    {
                        row++;

                        if (dt.Rows[i]["Stock_ID"] == DBNull.Value)
                        {
                            DoHide();
                            XtraMessageBox.Show("Lỗi:\n\tChưa chọn kho xuất.\n\tDòng lỗi: " + (row + 1), "Thông báo",
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
                            XtraMessageBox.Show("Lỗi:\n\tVui lòng chọn mặt hàng.\n\tDòng lỗi: " + (row + 1), "Thông báo",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            sql.RollBack();
                            gbList.FocusedRowHandle = row;
                            gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                            result = "Chưa chọn mặt hàng";
                            return result;
                        }

                        id = dt.Rows[i]["ID"].ToString();
                    }
                }
                if (dr.RowState == DataRowState.Added)
                {
                    if (!cls.Insert(
                        sql.Transaction,
                        Guid.NewGuid().ToString(),
                        txtID.Text,
                        Convert.ToString(dt.Rows[i]["Product_ID"]),
                        Convert.ToString(dt.Rows[i]["Product_Name"]),
                        (int)_part,
                        Convert.ToString(dt.Rows[i]["Stock_ID"]),
                        Convert.ToString(dt.Rows[i]["Unit"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                        0,
                        0, // VatAmount
                        0,
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),

                        Convert.ToDecimal(dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : dt.Rows[i]["DiscountRate"]),
                        Convert.ToDecimal(dt.Rows[i]["Discount"] == DBNull.Value ? 0 : dt.Rows[i]["Discount"]),
                       
                        0,
                        DateTime.Now,
                        Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),
                        Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]),

                        Convert.ToString(dt.Rows[i]["Orgin"] == DBNull.Value ? "" : dt.Rows[i]["Orgin"]),
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        0,
                        Convert.ToString(dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"]),
                        0,
                        true
                             ))
                    {
                        sql.RollBack();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                        return "Mặt hàng này sẽ không được lưu!";
                    }
                }
                else if (dr.RowState == DataRowState.Modified)
                {
                    if (!cls.Update(
                        sql.Transaction,
                        id,
                        txtID.Text,
                        Convert.ToString(dt.Rows[i]["Product_ID"]),
                        Convert.ToString(dt.Rows[i]["Product_Name"]),
                        (int)_part,
                        Convert.ToString(dt.Rows[i]["Stock_ID"]),
                        Convert.ToString(dt.Rows[i]["Unit"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                        0,
                        0, // VatAmount
                        0,
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),

                        Convert.ToDecimal(dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : dt.Rows[i]["DiscountRate"]),
                        Convert.ToDecimal(dt.Rows[i]["Discount"] == DBNull.Value ? 0 : dt.Rows[i]["Discount"]),
                        0,
                        DateTime.Now,
                        Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),
                        Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]),

                        Convert.ToString(dt.Rows[i]["Orgin"] == DBNull.Value ? "" : dt.Rows[i]["Orgin"]),
                       
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        0,
                        Convert.ToString(dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"]),
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
                }
                else if (dr.RowState == DataRowState.Deleted)
                {
                    if (!cls.Delete(sql.Transaction, dt.Rows[i]["ID", DataRowVersion.Original].ToString()))
                    {
                        result = sql.Result;
                        sql.RollBack();
                        DoHide();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colProduct_ID, result);
                        return "Mặt hàng này sẽ không được lưu!";
                    }
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
            if (keyData == (Keys.Alt | Keys.D))
            {
                MessageBox.Show(@"You are stupid");
            }
            else if (keyData == Keys.F1)
            {
                F11Execute();
            }
            else if (keyData == Keys.F3)
            {
                F3Execute();
            }
            else if (keyData == Keys.F4)
            {
                F4Execute();
            }
            else if (keyData == Keys.F5)
            {
                F5Execute();
            }
            else if (keyData == Keys.F6)
            {
                F9Execute();
            }
            else if (keyData == Keys.F7)
            {
                F7Execute();
            }
            else if (keyData == Keys.F8)
            {
                F8Execute();
            }
            else if (keyData == Keys.F9)
            {
                F9Execute();
            }
            else if (keyData == Keys.F11)
            {
                F11Execute();
            }
            else if (keyData == Keys.F12)
            {
                F12Execute();
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                Add();
            }
            else if (keyData == (Keys.Control | Keys.T))
            {
                Add();
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                Save();
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                Save();
            }
            else if (keyData == Keys.F2)
            {
                Save();
            }
            else if (keyData == (Keys.Control | Keys.Shift | Keys.S))
            {
                Save();
            }
            else if (keyData == (Keys.Control | Keys.Shift | Keys.W))
            {
                Save();
            }
            else if (keyData == (Keys.Shift | Keys.F2))
            {
                Save();
            }
            else if (keyData == (Keys.Control | Keys.P))
            {
                Print();
            }
            else if (keyData == Keys.Escape)
            {
                Cancel();
                EscapeExecute();
            }
            else if (keyData == (Keys.Alt | Keys.X))
            {
                if (ParentForm != null) ParentForm.Close();
            }
            else if (keyData == Keys.F10)
            {
                F10Execute();
                if (ParentForm != null) ParentForm.Close();
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
            txtEmployee.EditValue = cls.Employee_ID;
            dtCreated.DateTime = cls.RefDate;
            txtCustomerName.EditValue = cls.Customer_ID;
            txtAddress.Text = cls.CustomerAddress;
            txtDescription.Text = cls.Description;
            txtDocLink.Text = cls.Reason;

            _refStatus = cls.RefStatus;
            txtTerm.EditValue = cls.TermID;
            dtDueTime.DateTime = cls.PaymentDate;
            txtMethod.EditValue = cls.PaymentMethod;
            txtTotalCharge.Value = cls.Charge;
            txtVatRate.Value = cls.Vat;
            txtVatAmount.Value = cls.VatAmount;
            txtTotalAmount.Value = cls.Amount;
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
            if (!MyRule.IsEdit("bbiPurchase")) 
            {
                MyRule.Notify();
                return "";
            }

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            if (_refStatus == 1)
            {
                XtraMessageBox.Show(
                    "Không thể thay đổi thông tin phiếu này.\n\n Phiếu này đã được chi tiền trong phần Công Nợ Mua Hàng.",
                    "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            SysLog.Insert("Nhập Hàng", "Cập Nhật", txtID.Text);
            if (!DetailCheck()) return "";
 
            Total();
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

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
                (int) _part,
                txtMethod.EditValue.ToString(),
                txtTerm.EditValue.ToString(),
                dtDueTime.DateTime,
                DateTime.Now,
                txtID.Text,
                "",
                Convert.ToString(txtEmployee.EditValue),
                "",
                "",
                "",
                txtCustomerID.Text,
                txtCustomerName.Text,
                txtAddress.Text,
                "",
                txtDocLink.Text.Trim(),
                0,
                "VND",
                1,
                Convert.ToInt32(txtVatRate.Value),
                txtVatAmount.Value,
                txtTotalAmount.Value,
                txtTotalAmount.Value,
                DateTime.Now,
                0,
                Convert.ToDecimal(colDiscount.SummaryItem.SummaryValue),
                0,
                txtTotalCharge.Value,
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

            //if (Convert.ToString(txtTerm.EditValue) == "TM")
            //{
            //    result = DebtInsert(mySql);
            //    if (result != "OK")
            //    {
            //        mySql.RollBack();
            //        DoHide();
            //        return result;
            //    }
            //}

            result = DetailSave(mySql);
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                return result;
            }

            mySql.Commit();

            if (chxIsPrint.Checked) Print(false);
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
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (!MyRule.IsPrint("bbiPurchase"))
            {
                DoHide();
                return;
            }

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) ||
                string.IsNullOrEmpty(MyInfo.Tel))
            {
                XtraMessageBox.Show(
                    "Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.",
                    "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows.Clear();

            dsSTOCK_INWARD_DETAIL.STOCK_INWARD.AddSTOCK_INWARDRow(
                txtID.Text,
                dtCreated.DateTime,
                "",
                txtCustomerName.EditValue == null ? "" : txtCustomerName.EditValue.ToString(),
                "",
                "",
                txtCustomerName.Text,
                txtAddress.Text,
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue),
                txtDescription.Text,
                1,
                chxIsPrint.Checked,
                chxBarcode.Checked
                );
            foreach (DataRow dtSale in dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Rows)
            {
                foreach (DataRow dtProduct in dsPRODUCT.PRODUCT.Rows)
                {
                    if (dtSale["Product_ID"].ToString() == dtProduct["Product_ID"].ToString())
                    {
                        dtSale["Product_Name"] = dtProduct["Product_Name"].ToString();
                        break;
                    }
                }
            }
            foreach (DataRow dtSale in dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Rows)
            {
                foreach (DataRow dtUnit in dsUnit.UNIT.Rows)
                {
                    if (dtSale["Unit"].ToString() == dtUnit["Unit_ID"].ToString())
                    {
                        dtSale["Unit_Name"] = dtUnit["Unit_Name"].ToString();
                        break;
                    }
                }
            }
            var rpt = new RptStockInward(
                dsSTOCK_INWARD_DETAIL, 
                "Phiếu Nhập Hàng",
                txtTotalCharge.Value,
                txtVatRate.Value,
                txtVatAmount.Value,
                txtTotalAmount.Value,
                txtDescription.Text);
            if (preview)
            {
                DoHide();
                rpt.ShowPreview();
                return;
            }
            DoHide();
            rpt.ShowPreview();
        }

        public override void Print()
        {
            SysLog.Insert("Nhập Hàng", "In", txtID.Text);
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

        protected void TxtIDKeyDown(object sender, KeyEventArgs e)
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
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.ColumnButton)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();
                    DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Row)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowCell)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.EmptyRow)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowFooter)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                }
            }

            if (e.Button == MouseButtons.Left)
                DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));

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

        private void DoShowMenu(GridHitInfo hi)
        {
            GridViewMenu menu;
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
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

        public event CheckBarcodeEvenhandler CheckBarcode;

        public void OnCheckBarcode(bool chk)
        {
            CheckBarcodeEvenhandler handler = CheckBarcode;
            if (handler != null) handler(this, chk);
        }

        private void ChxBarcodeCheckedChanged(object sender, EventArgs e)
        {
            // plBarCode.Visible = chxBarcode.Checked;
            lcBarcode.Visibility = chxBarcode.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            OnCheckBarcode(chxBarcode.Checked);
        }

        protected override void F3Execute()
        {
            txtCustomerName.Focus();
            txtCustomerName.ShowPopup();
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


        protected override void Refresh()
        {
            Updated();
        }

        private void TxtCustomerIDEditValueChanged(object sender, EventArgs e)
        {
            txtCustomerName.EditValue = txtCustomerID.EditValue;
        }

        private void TxtCustomerIDKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtCustomerName.Focus();
            }
        }

        private void TxtCustomerNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void TxtAddressKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
            }
        }

        private void TxtTelKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void TxtDescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                gbList.Focus();
            }
        }

      

        private void TxtTermKeyPress(object sender, KeyPressEventArgs e)
        {
            Bar.Bar.bbiSaveM.Enabled = true;
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
            Total();
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
            Total();
            Clear();
        }

        public override void Search()
        {
            var xfmProducts = new xfmProducts(true);
            xfmProducts.ItemSelected += XfmProductsItemSelected;
            xfmProducts.ShowDialog();
            // this.Enabled = true;
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

        private void txtVatRate_EditValueChanged(object sender, EventArgs e)
        {
            decimal totalCharge = txtTotalCharge.Value;
            decimal VatAmount = totalCharge * txtVatRate.Value / 100;
            txtVatAmount.Value = VatAmount;
            txtTotalAmount.Value = totalCharge + VatAmount;
        }

        private void txtVatAmount_EditValueChanged(object sender, EventArgs e)
        {
            decimal totalCharge = txtTotalCharge.Value;
            decimal vatRate = totalCharge == 0 ? 0 : txtVatAmount.Value / totalCharge * 100;
            txtVatRate.Value = vatRate;
            txtTotalAmount.Value = totalCharge + txtVatAmount.Value;
        }
    }
}