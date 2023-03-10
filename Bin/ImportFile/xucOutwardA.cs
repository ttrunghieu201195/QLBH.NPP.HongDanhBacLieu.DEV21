using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using Perfect.Dictionary;
using Perfect.Net.Info;
using Perfect.Dictionary.UI;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Outward.dsCUSTOMERSTableAdapters;
using Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Data.Helper;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Perfect.Dictionary.Promotion.CLS;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;
using Perfect.Inventory.Core.Common.DS.dsPRODUCT_APPOINTTableAdapters;

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class xucOutwardA : xucBaseB
    {
        #region Column enum

        public enum Column
        {
            None = 0,
            Quantity = 1,
            Price = 2,
            Amount = 3,
            ID = 4,
            Lock = 5,
            ImportTax_ID = 6,
            ExportTax_ID = 7,
            LuxuryTax_ID = 8,
            Vat_ID = 9,
            ChargeTransport = 10,
            ChargeDelivery = 11,
            Discount = 12,
            Vat = 13,
            Stock_ID = 14,
            Name = 15,
            Unit = 16,
            Height = 17,
            Width = 18

        }

        #endregion

        private Column m_Column;

        private EnumRefType _part;

        public xucOutwardA(EnumRefType part)
        {
            _part = part;
            m_Column = new Column();
            InitializeComponent();
            dtCreated.DateTime = MyLogin.LoginDate;
            txtDeliveryDate.DateTime = MyLogin.LoginDate;
            dtDueTime.DateTime = MyLogin.LoginDate;
            _exportView = gbList;
            txtVatRate.Value = 10;
            
            
        }

        public EnumRefType Part
        {
            get { return _part; }
            set { _part = value; }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();
            m_Column = Column.None;
            rpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            rpDate.DisplayFormat.FormatString = Options.DateTime.FormatString;
            rpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            rpDate.EditFormat.FormatString = Options.DateTime.FormatString;
            DoHide();
        }

      

        public void Customer_Init()
        {
            var adapter = new CUSTOMERTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsCUSTOMERS.CUSTOMER);
            txtCustomerName.Focus();
        }

        public void Stock_Init()
        {
            getStockForPermissionTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            getStockForPermissionTableAdapter.Fill(dsSTOCK.GetStockForPermission,MyLogin.AccountName);

            if (dsSTOCK.GetStockForPermission.Rows.Count > 0)
            {
                if (txtStockID.Text == "") txtStockID.EditValue = dsSTOCK.GetStockForPermission.Rows[0]["Stock_ID"];
            }
        }

      

        public void SetStock(STOCK item)
        {
            dsSTOCK.STOCK.AddSTOCKRow(item.Stock_Name, item.Stock_ID);
        }

        private void Promotion_Init()
        {
            pROMOTIONTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pROMOTIONTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.PROMOTION);
        }

        public void Product_Init()
        {

            var adapter = new sp_GetProductForStock_OutTableAdapter
                                  {
                                      Connection = {ConnectionString = SqlHelper.ConnectString},
                                      ClearBeforeFill = true
                                  };
            
            //adapter.FillByUsername(dsPRODUCT_APPOINT.sp_GetProductForStock_Out, MyLogin.AccountName);
            adapter.FillByStockID(dsPRODUCT_APPOINT.sp_GetProductForStock_Out, MyLogin.AccountName, txtStockID.EditValue.ToString());


         }

        private void Unit_Init()
        {
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsUnit.UNIT);
        }

        public void SetCustomer(CUSTOMER item)
        {
            dsCUSTOMERS.CUSTOMER.AddCUSTOMERRow(item.CustomerName, item.Customer_ID);
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void Init()
        {
            SetWaitDialogCaption("Nạp dữ liệu cũ....");
            Updated();
            rpgStock.ReadOnly = false;
            colStock_ID.OptionsColumn.ReadOnly = false;
            ucBarcode.ItemSelected += UcBarcodeItemSelected;
          
            
            m_Column = Column.None;

            if (CODE.TypeSoft < 400 & CODE.TypeSoft != 0)
            {
                colUnit.OptionsColumn.AllowEdit = false;
            }

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            _exportView = gbList;

            SetWaitDialogCaption("Nạp hoàn thành....");
            Add();
            DoHide();
            Cursor.Current = Cursors.Default;
        }

        private void UcBarcodeItemSelected(object sender, Barcode item)
        {

            //if (m_Status == Actions.None) return;

            //if (item.Action == TypeAdd.Duplicate)
            //{
            //    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
            //        0,
            //        "",
            //        item.Item.Product_Type_ID,
            //        txtID.Text,
            //        item.Item.Product_ID,
            //        item.Item.Product_ID,
            //        item.Item.Provider_ID,
            //        (int)item.Item.VAT_ID,
            //        0,
            //        0,
            //        "",
            //        "",
            //        0,
            //        Convert.ToDecimal(1),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        "",
            //        "",
            //        item.Item.Unit,
            //        1,
            //        0,
            //        0,
            //        0,
            //        0,
            //        txtCustomerName.Text,
            //        0,
            //        true,
            //        Guid.NewGuid(),
            //        2,
            //        0,
            //        "",
            //        "",
            //        0,
            //        item.Item.Product_Name,
            //        "");
            //}
            //else if (item.Action == TypeAdd.Add)
            //{
            //    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
            //    bool add = false;
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
            //        if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
            //        if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
            //        add = true;
            //        double qty = Convert.ToDouble(dt.Rows[i]["Quantity"] ?? 0) + item.Quantity;
            //        ;
            //        double uni = Convert.ToDouble(dt.Rows[i]["UnitPrice"] ?? 0);
            //        dt.Rows[i]["Quantity"] = qty;
            //        if (uni == 0)
            //        {
            //            dt.Rows[i]["UnitPrice"] = item.Price;
            //            uni = item.Price;
            //        }
            //        dt.Rows[i]["Amount"] = uni * qty;
            //        break;
            //    }

            //    if (!add)
            //    {
            //        dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
            //         0,
            //        "",
            //        item.Item.Product_Type_ID,
            //        txtID.Text,
            //        item.Item.Product_ID,
            //        item.Item.Product_ID,
            //        item.Item.Provider_ID,
            //        (int)item.Item.VAT_ID,
            //        0,
            //        0,
            //        "",
            //        "",
            //        0,
            //        Convert.ToDecimal(1),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        "",
            //        "",
            //        item.Item.Unit,
            //        1,
            //        0,
            //        0,
            //        0,
            //        0,
            //        txtCustomerName.Text,
            //        0,
            //        true,
            //        Guid.NewGuid(),
            //        2,
            //        0,
            //        "",
            //        "",
            //        0,
            //        item.Item.Product_Name,
            //        ""
            //        );
            //    }
            //}
            //else if (item.Action == TypeAdd.Replace)
            //{
            //    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
            //    bool Add = false;
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
            //        if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
            //        if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
            //        Add = true;
            //        dt.Rows[i]["Quantity"] = item.Quantity;
            //        dt.Rows[i]["UnitPrice"] = item.Price;
            //        dt.Rows[i]["Amount"] = item.Amount;
            //        break;
            //    }

            //    if (!Add)
            //    {
            //        dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
            //         0,
            //        "",
            //        item.Item.Product_Type_ID,
            //        txtID.Text,
            //        item.Item.Product_ID,
            //        item.Item.Product_ID,
            //        item.Item.Provider_ID,
            //        (int)item.Item.VAT_ID,
            //        0,
            //        0,
            //        "",
            //        "",
            //        0,
            //        Convert.ToDecimal(1),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        "",
            //        "",
            //        item.Item.Unit,
            //        1,
            //        0,
            //        0,
            //        0,
            //        0,
            //        txtCustomerName.Text,
            //        0,
            //        true,
            //        Guid.NewGuid(),
            //        2,
            //        0,
            //        "",
            //        "",
            //        0,
            //        item.Item.Product_Name,
            //        ""
            //        );
            //    }
            //}
            //else if (item.Action == TypeAdd.Single)
            //{
            //    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
            //    bool add = false;
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
            //        if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
            //        if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;

            //        alc.Show(ParentForm, "Thông Báo", "Hàng Hoá này đã tồn tại trong danh sách.");
            //        gbList.MoveBy(i);
            //        add = true;
            //        break;
            //    }
            //    if (!add)
            //    {
            //        dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
            //         0,
            //        "",
            //        item.Item.Product_Type_ID,
            //        txtID.Text,
            //        item.Item.Product_ID,
            //        item.Item.Product_ID,
            //       item.Item.Provider_ID,
            //        (int)item.Item.VAT_ID,
            //        0,
            //        0,
            //        "",
            //        "",
            //        0,
            //        Convert.ToDecimal(1),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        Convert.ToDecimal(item.Item.Sale_Price),
            //        "",
            //        "",
            //        item.Item.Unit,
            //        1,
            //        0,
            //        0,
            //        0,
            //        0,
            //        txtCustomerName.Text,
            //        0,
            //        true,
            //        Guid.NewGuid(),
            //        2,
            //        0,
            //        "",
            //        "",
            //        0,
            //        item.Item.Product_Name,
            //        ""

                   
            //        );
            //    }
            //}
        }

        private void TxtCustomerNamePropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Search")
            {
                //Nút tìm nhấn

                var xfmCustomers = new xfmCustomers(true);
                xfmCustomers.ItemSelected += XfmProvidersItemSelected;
                xfmCustomers.ShowDialog();
            }
            else if (e.Button.Tag.ToString() == "Add")
            {
                var customer = new CUSTOMER(txtCustomerID.Text, 0, txtCustomerName.Text, "", "", txtAddress.Text, "", "",
                                            txtTax.Text, txtTel.Text, "", "", "", "", "", "", "", "", "", "", "", "", "",
                                            "", 0, 0, "", true);

                var xfmCustomerAdd = new xfmCustomerAdd(customer);
                xfmCustomerAdd.Added += XfmCustomerAddAdded;
                xfmCustomerAdd.ShowDialog();
            }
        }

        private void XfmCustomerAddAdded(object sender, CUSTOMER item)
        {
            Customer_Init();
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void XfmProvidersItemSelected(object sender, CUSTOMER item)
        {
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void TxtCustomerNameEditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.EditValue == null) return;
            var cus = new CUSTOMER();
            if (cus.Get(txtCustomerName.EditValue.ToString()) == "OK")
            {
                txtCustomerID.Text = cus.Customer_ID;
                txtAddress.Text = cus.CustomerAddress;
                txtTel.Text = cus.Tel;
                txtTax.Text = cus.Tax;
            }
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;

        }

        private void TxtCustomerIdKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerID.Text == "") return;
                var cus = new CUSTOMER();
                if (cus.Get(txtCustomerID.Text) == "OK")
                {
                    txtCustomerName.EditValue = cus.Customer_ID;
                    txtAddress.Text = cus.CustomerAddress;
                    txtTel.Text = cus.Tel;
                    txtTax.Text = cus.Tax;
                }
            }
        }

        private void RpgProductButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //this.Enabled = false;
            if (e.Button.Tag.ToString() == "Search")
            {
                var xfmProducts = new xfmProducts(true);
                xfmProducts.ItemSelected += XfmProductsItemSelected;
                xfmProducts.ShowDialog();
            }
            else if (e.Button.Tag.ToString() == "Add")
            {
                var xfmItemAdd = new xfmItemAdd(Actions.Add);
                xfmItemAdd.Added += XfmItemAddAdded;
                xfmItemAdd.ShowDialog();
            }
            //this.Enabled = true;
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
            // gbList.SetFocusedValue(item.Product_ID);
        }

        private void TxtIdEditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;

            var cls = new STOCK_OUTWARD();
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }
            if (m_Status == Actions.Add)
            {
                if (cls.Exist(txtID.Text))
                {
                    Err.SetError(txtID, "Mã phiếu đã tồn tại.");
                    txtID.Focus();
                }
            }
        }

        private void TxtIdLeave(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;

            if (m_Status == Actions.None) return;

            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
                //txt.Focus();
            }
            else
            {
                var stockInward = new STOCK_OUTWARD();

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

        private void TxtIdKeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }
            if (e.KeyCode == Keys.Enter)
            {

                //if (!(e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)) return;
                var stockInward = new STOCK_OUTWARD();

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
        
        private void ProductAdd(string id, string stock)
        {
            var pro = new PRODUCT();

            if (id == "") return;
            {
                if (pro.Get(id) == "OK")
                {
                    gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);
                    gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 0);
                    gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Sale_Price);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], 0);
                    gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], ""); 
                    if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                    
                    Total();
                }
            }
        }
        public void ProductAdd(PRODUCT item)
        {
            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                0,
                "",
                Guid.NewGuid(),
                txtID.Text,
                item.Product_ID,
                2,
                item.Product_ID,
                item.Provider_ID,
                (int)item.VAT_ID,
                item.Unit,
                1,
                0,
                0,
                Convert.ToDecimal(item.Sale_Price),
                Convert.ToDecimal(item.Sale_Price),
                0,
                0,
                0,
                0,
                0,

                "",
                "",
                "",
                "",
                0,
                0,
                "",
                "",
                0,
                "",
                0,
                true,item.Product_Name,
                item.Product_Type_ID,
                ""
                );
        }

        private void SetIndex()
        {
            //m_Column = Column.Lock;

            //dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable dt =
            //    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;

            //    if (dt.Rows[i]["Product_ID"] != DBNull.Value)
            //    {
            //        dt.Rows[i]["STT"] = i + 1;
            //    }
            //}
            //m_Column = Column.None;
        }

        private void Total()
        {
            //double Amount = 0.0;

            //for (int i = 0; i < gbList.RowCount; i++)
            //{
            //    Amount +=
            //        Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
            //                             ? 0
            //                             : gbList.GetRowCellValue(i, "Amount"));
            //}

            // txtAmount.Value = Convert.ToDecimal(Amount);
        }

        public override void Clear()
        {
            //base.Clear();
            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Rows.Clear();
        }

        public override void Add()
        {
            if (!MyRule.IsAdd("bbiSale")) return;
            var cls = new STOCK_OUTWARD();
            string prefix;
            try
            {
                if (cls.GetShortCode(MyLogin.StockID))
                {
                    prefix = cls.ShortCode + ".BH.";
                    txtID.Text = cls.CreateKey(prefix);

                    txtID.Properties.ReadOnly = false;
                    txtDescription.Text = "";
                    txtOtherDiscountRate.Value = 0;
                    CalcSale0();
                    txtPromotionID.EditValue = "";
                    DisableControl(true);
                    Updated();
                    NotSave = false;
                    Bar.Bar.bbiSaveM.Enabled = false;
                    Status = Actions.Add;
                }
                else
                {
                    prefix = MyLogin.StockID + ".BH.";
                    txtID.Text = cls.CreateKey(prefix);

                    txtID.Properties.ReadOnly = false;
                    txtDescription.Text = "";
                    txtOtherDiscountRate.Value = 0;
                    CalcSale0();
                    txtPromotionID.EditValue = "";
                    DisableControl(true);
                    Updated();
                    NotSave = false;
                    Bar.Bar.bbiSaveM.Enabled = false;
                    Status = Actions.Add;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi: " + "Không thể tạo được mã phiếu. " );
            }       
        }

        public override bool Check()
        {
           

            if (dtCreated.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtCreated.Focus();
                return false;
            }
            if (txtCustomerName.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                return false;
            }


            if (txtID.Text == string.Empty)
            {
                txtID.Focus();
                Err.SetError(txtID, "Mã phiếu không được rỗng");
                return false;
            }

            if (txtID.ErrorText != string.Empty)
            {
                txtID.Focus();
                Err.SetError(txtID, "Mã phiếu đã tồn tại");
                return false;
            }

       
            if (dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Rows.Count == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void Updated()
        {
            Cursor.Current = Cursors.WaitCursor;
            Stock_Init();
            Customer_Init();

            Product_Init();
            Emp_Init();
            CashMethodInit();
            Promotion_Init();
            CashTermInit();
           
            Unit_Init();
            Cursor.Current = Cursors.Default;
        }
        void CashMethodInit()
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

        void CashTermInit()
        {
            Cursor.Current = Cursors.WaitCursor;
            cASH_TERMTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cASH_TERMTableAdapter.Fill(dsSaleDic.CASH_TERM);

            if (txtTerm.Text == "")
                if (dsSaleDic.CASH_TERM.Rows.Count > 0)
                {
                    txtTerm.EditValue = dsSaleDic.CASH_TERM.Rows[1]["ID"];
                }
            Cursor.Current = Cursors.Default;

        }
        private void Emp_Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            eMPLOYEETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            eMPLOYEETableAdapter.ClearBeforeFill = true;
            eMPLOYEETableAdapter.Fill(dsEmpForStock.EMPLOYEE,MyLogin.AccountName);

            if (dsEmpForStock.EMPLOYEE.Rows.Count > 0)
            {
                if (txtEmployee.Text == "") txtEmployee.EditValue = dsEmpForStock.EMPLOYEE.Rows[0]["Employee_ID"];
            }
            Cursor.Current = Cursors.Default;
        }

        private bool DetailCheck()
        {
            if (gbList.RowCount - 1 == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
            
            string text;
            int j = 0;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                j++;
                text = gbList.GetDisplayTextByColumnValue(colProduct_ID, dt.Rows[i]["Product_ID"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //dt.Rows.RemoveAt(i);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colProduct_ID, "Chưa chọn mặt hàng");
                    return false;
                }

                text = gbList.GetDisplayTextByColumnValue(colStock_ID, dt.Rows[i]["Stock_ID"].ToString());
                if (text.Trim() == "")
                {
                    XtraMessageBox.Show("Chưa chọn kho hàng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbList.FocusedRowHandle = j - 1;
                    gbList.SetColumnError(colStock_ID, "Chưa chọn kho hàng");
                    //dt.Rows.RemoveAt(i);
                    return false;
                }

                if (dt.Rows[i]["Stock_ID"] == null | dt.Rows[i]["Stock_ID"] == DBNull.Value)
                {
                    XtraMessageBox.Show("Kho hàng xuất không đúng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    gbList.SetColumnError(colUnit, "Đơn vị tính không đúng");
                    return false;
                }


                if (Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) <= 0)
                {
                    XtraMessageBox.Show("Vui lòng xem lại giá trị nhập vào, giá trị thành tiền ko hợp lệ.", "Thông Báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }



            }
            return true;
        }

        public delegate void SuccessfullEvenhandler();

        public event SuccessfullEvenhandler Successfull;

        private void InvokeSuccessfull()
        {
            SuccessfullEvenhandler successfull1 = Successfull;
            if (successfull1 != null) successfull1();
        }
        public override string uc_Save()
        {
            if (!MyRule.IsAdd("bbiSale"))
            {
                XtraMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return "";
            }

            SYS_LOG.Insert("Phiếu Xuất", "Thêm", txtID.Text);

            if (!DetailCheck()) return "";

            if (CODE.TypeSoft == 0)
            {
                if (INVENTORY_DETAIL.Count > 5000)
                {
                    CODE.Notify();
                    return "";
                }
            }

            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            if (CODE.TypeSoft == 1)
            {
                if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 2000)
                {
                   Thread.Sleep(10000);
                }
                else
                {
                    if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 3000)
                    {
                         Thread.Sleep(15000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 4000)
                    {
                        Thread.Sleep(30000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 5000)
                    {
                         Thread.Sleep(60000);
                    }
                }
            }


            var mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            var cls = new STOCK_OUTWARD(
                txtID.Text,
                dtCreated.DateTime,
                "",
                (int)_part, // xuất kho thường
                0,
                txtMethod.EditValue.ToString(),
                txtTerm.EditValue.ToString(),
                dtDueTime.DateTime,
                txtDeliveryDate.DateTime,
                txtID.Text,
                "",
                txtEmployee.EditValue.ToString(),
                txtStockID.EditValue.ToString(),
                "",
                "",
                txtCustomerName.EditValue.ToString(),
                txtCustomerName.Text,
                txtAddress.Text,
                "",
                txtPromotionID.EditValue.ToString(),
                0,
                cbxCurrency.Text,
                Convert.ToDecimal(txtExchange.Value),
                Convert.ToInt32(txtVatRate.Value),
                Convert.ToDecimal(txtVatAmount.Value),
                Convert.ToDecimal(txtTotalAmount.Value) * txtExchange.Value,
                cbxCurrency.Text == SYS_OPTION.Currency ? Convert.ToDecimal(txtTotalAmount.Value) * txtExchange.Value : Convert.ToDecimal(txtTotalAmount.Value),
                DateTime.Now,
                Convert.ToDecimal(txtDiscountRate.Value),
                Convert.ToDecimal(txtDiscount.Value),
                Convert.ToDecimal(txtOtherDiscount.Value),
                Convert.ToDecimal(txtOtherDiscountRate.EditValue),
                Convert.ToDecimal(txtDoanhThu.Value),
                0,
                MyLogin.UserId,
                false,
                0,
                txtDescription.Text,
                true);



            if (!cls.Insert(mySql.Transaction))
            {
                result = mySql.Result;
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }
           
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            result = DetailSave(mySql);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            mySql.Commit();
            InvokeSuccessfull();
            if (chxIsPrint.Checked) Print(false);
            Cursor.Current = Cursors.Default;
            //Updated();
            DoHide();
            Cancel();
            SetData(txtID.Text);
            return result;
        }

        private string DetailSave(SqlHelper sql)
        {
            string result = "OK";
            var cls = new STOCK_OUTWARD_DETAIL();
            var pro = new PRODUCT();

            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAILDataTable dt =dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;

            int row = 0;
            string id = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    row++;
                    if (dt.Rows[i]["Stock_ID"] == DBNull.Value)
                    {
                        DoHide();
                        sql.RollBack();
                        XtraMessageBox.Show("Chưa chọn kho xuất.\n\tDòng thứ : " + (i + 1), "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return "Không thể lưu thông tin phiếu này.";
                    }

                    if (dt.Rows[i]["Product_ID"] == DBNull.Value)
                    {
                        DoHide();
                        sql.RollBack();
                        XtraMessageBox.Show("Vui lòng chọn mặt hàng.\n\tDòng thứ : " + (i + 1), "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return "Không thể lưu thông tin phiếu này.";
                    }

                    pro.Product_ID = dt.Rows[i]["Product_ID"].ToString();
                    pro.Provider_ID = txtStockID.EditValue.ToString();
                    pro.InventoryID = Convert.ToInt64(dt.Rows[i]["StoreID"]);
                    double qty = Convert.ToDouble(dt.Rows[i]["Quantity"]);


                    if (pro.GetByStockAllVnpt(sql.Transaction, pro.Product_ID, pro.Provider_ID, pro.InventoryID) == "OK")
                    {
                        if (pro.Product_Type_ID != 1)
                        {
                            if (qty > pro.Quantity)
                            {
                                if (SYS_OPTION.Negative)
                                {
                                    DoHide();
                                    XtraMessageBox.Show(
                                       " - Mã Hàng: " + pro.Product_ID.ToUpper() +
                                       "\n---------------------------------------" +
                                       "\n - Mặt Hàng: " + pro.Product_Name.ToUpper() +
                                       "\n---------------------------------------" +
                                       "\n - Số lượng tồn hiện tại là: " + pro.Quantity +
                                       "\n---------------------------------------" +
                                       "\nBạn không thể xuất quá số lượng tồn của mặt hàng này.",
                                       "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    //dt.Rows[i]["Error"] = 1;
                                    DoHide();
                                    sql.RollBack();
                                    //gbList.FocusedRowHandle = row;
                                    //gbList.SetColumnError(colQuantity, "Mặt hàng này đã xuất vượt quá số lượng tồn");
                                    return "Không thể lưu thông tin phiếu này.";
                                }
                                else
                                {
                                    dt.Rows[i]["Error"] = 1;
                                    DoHide();
                                    sql.RollBack();
                                    XtraMessageBox.Show(
                                        "Mặt hàng này đã xuất vượt quá số lượng tồn.\n\tDòng lỗi: " + row,
                                        "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    gbList.FocusedRowHandle = row;
                                    gbList.SetColumnError(colQuantity, "Mặt hàng này đã xuất vượt quá số lượng tồn");
                                    return "Không thể lưu thông tin phiếu này.";
                                }
                            }
                        }
                    }
                    //else
                    //{
                    //    dt.Rows[i]["Error"] = 1;
                    //    DoHide();
                    //    sql.RollBack();
                    //    XtraMessageBox.Show(
                    //        "Không kiểm tra được tồn kho của mặt hàng này.\n\tDòng lỗi: " + (row), "Thông báo",
                    //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    gbList.FocusedRowHandle = row;
                    //    gbList.SetColumnError(colQuantity, "Không kiểm tra được tồn kho của mặt hàng này");
                    //    return "Không kiểm tra được tồn kho của mặt hàng này";
                    //}

                    id = dt.Rows[i]["ID"].ToString();
                }

                SetWaitDialogCaption("Đang lưu dữ liệu...");
                if (dt.Rows[i].RowState == DataRowState.Added)
                {
                    if (!cls.Insert(
                        sql.Transaction,
                        Guid.NewGuid().ToString(),
                        txtID.Text,
                        txtStockID.EditValue.ToString(),
                        //dt.Rows[i]["Stock_ID"].ToString(),
                        (int)_part,
                        dt.Rows[i]["Product_ID"].ToString(),
                        dt.Rows[i]["Product_Name"].ToString(),
                        0,
                        0,
                        dt.Rows[i]["Unit"].ToString(),
                        1,//Convert.ToDecimal(dt.Rows[i]["UnitConvert"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        0, // DiscountRate
                        0,//Convert.ToDecimal(dt.Rows[i]["Discount"]),
                        0,//Convert.ToDecimal(dt.Rows[i]["Charge"]),
                        0,
                        0,
                        "",
                        "",
                        "",
                        "",
                        Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),
                        Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]),
                        "",
                        "",
                        Convert.ToInt64(dt.Rows[i]["StoreID"]),
                        txtCustomerName.Text,
                        0,
                        true
                        ))
                    {
                        DoHide();
                        result = sql.Result;
                        sql.RollBack();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, result);
                        return "Không thể lưu thông tin phiếu này.";
                    }

                }
                else if (dt.Rows[i].RowState == DataRowState.Modified)
                {

                    if (!cls.Update(
                        sql.Transaction,
                        id,
                        txtID.Text,
                        txtStockID.EditValue.ToString(),
                        //dt.Rows[i]["Stock_ID"].ToString(),
                        (int)_part,
                        dt.Rows[i]["Product_ID"].ToString(),
                        dt.Rows[i]["Product_Name"].ToString(),
                        0,
                        0,
                        dt.Rows[i]["Unit"].ToString(),
                        Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        0,
                        Convert.ToDecimal(dt.Rows[i]["Discount"] == DBNull.Value ? 0 : dt.Rows[i]["Discount"]),
                        Convert.ToDecimal(dt.Rows[i]["Charge"] == DBNull.Value ? 0 : dt.Rows[i]["Charge"]),
                        0,
                        0,
                        "",
                        "",
                        "",
                        "",
                        Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),
                        Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]),
                        "",
                        "",
                        Convert.ToInt64(dt.Rows[i]["StoreID"]),
                        txtCustomerName.Text,
                        0,
                        true
                        ))
                    {
                        DoHide();
                        result = sql.Result;
                        sql.RollBack();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, result);
                        return "Không thể lưu thông tin phiếu này.";
                    }

                }
                else if (dt.Rows[i].RowState == DataRowState.Deleted)
                {
                    if (!cls.Delete(sql.Transaction, dt.Rows[i]["ID", DataRowVersion.Original].ToString()))
                    {
                   
                        result = sql.Result;
                        sql.RollBack();
                        DoHide();
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colQuantity, result);
                        return "Mặt hàng này sẽ không được lưu!";
                    }
                }
            }

            return result;
        }

        private int _refStatus;
        public void SetData(string table)
        {
           
            var cls = new STOCK_OUTWARD();
            if (cls.Get(table))
            {
                Status = Actions.Change;
                DisableControl(true);
                if (Status == Actions.Change)
                {
                    txtID.Properties.ReadOnly = true;
                    txtID.Text = cls.ID;
                    //colStock_ID.OptionsColumn.ReadOnly = true;
                }
                dtCreated.DateTime = cls.RefDate;
                txtID.Properties.ReadOnly = true;
                txtCustomerName.EditValue = cls.Customer_ID;
                txtDescription.Text = cls.Description;
                _refStatus = cls.RefStatus;
                txtVatRate.Value = cls.Vat;
                txtVatAmount.Value = cls.VatAmount;
                txtDiscountRate.Value = cls.DiscountRate;
                txtDiscount.Value = cls.Discount;
                txtTotalAmount.Value = cls.Amount;
                txtOtherDiscount.Value = cls.OtherDiscount;
                txtOtherDiscountRate.Value = cls.Charge;
                txtPromotionID.EditValue = cls.Reason;
                txtStockID.EditValue = cls.Stock_ID;

                var adapter = new STOCK_OUTWARD_DETAILTableAdapter
                                  {
                                      Connection = {ConnectionString = SqlHelper.ConnectString}
                                  };
                adapter.Fill(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL, txtID.Text);
                //CalcSale();
                Updated();
				NotSave=false;
				Bar.Bar.bbiSaveM.Enabled = false;
            }
        }

        public override string uc_Change()
        {

            int update = 1;
            if (update == 1)
            {
                XtraMessageBox.Show("Bạn không thể thực hiện thao tác này.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return "";
            }

            if (!MyRule.IsEdit("bbiSale"))
            {
                XtraMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return "";
            }
            if (_refStatus == 1)
            {
                XtraMessageBox.Show("Không thể xóa phiếu Mua Hàng này.\n\n Phiếu này đã được thu tiền.", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            SYS_LOG.Insert("Phiếu Xuất", "Cập Nhật", txtID.Text);

            if (!DetailCheck()) return "";

            if (CODE.TypeSoft == 0)
            {
                if (INVENTORY_DETAIL.Count > 5000)
                {
                    CODE.Notify();
                    return "";
                }
            }
             SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            if (CODE.TypeSoft == 1)
            {
                if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 2000)
                {
                    Thread.Sleep(10000);
                }
                else
                {
                    if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 3000)
                    {
                        Thread.Sleep(15000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 4000)
                    {
                        Thread.Sleep(30000);
                    }
                    else if ((INVENTORY_DETAIL.Count - SYS_INFO.Count) > 5000)
                    {
                         Thread.Sleep(60000);
                    }
                }
            }

            var mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                //XtraMessageBox.Show("Lỗi:\n\t" + result);
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

           var cls = new STOCK_OUTWARD(
                txtID.Text,
                dtCreated.DateTime,
                "",
                (int)_part, // xuất kho thường
                0, // RefStatus
                txtMethod.EditValue.ToString(),
                txtTerm.EditValue.ToString(),
                dtDueTime.DateTime,
                txtDeliveryDate.DateTime,
                txtID.Text,
                "",
                txtEmployee.EditValue.ToString(),
                //MyLogin.StockID,
                txtStockID.EditValue.ToString(),
                "",
                "",
                txtCustomerName.EditValue.ToString(),
                txtCustomerName.Text,
                txtAddress.Text,
                "",
                txtPromotionID.EditValue.ToString(),
                0,
                cbxCurrency.Text,
                Convert.ToDecimal(txtExchange.Value),
                Convert.ToInt32(txtVatRate.Value),
                Convert.ToDecimal(txtVatAmount.Value),
               //Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * txtExchange.Value,
                Convert.ToDecimal(txtTotalAmount.Value) * txtExchange.Value,
                cbxCurrency.Text == SYS_OPTION.Currency ? Convert.ToDecimal(txtTotalAmount.Value) * txtExchange.Value : Convert.ToDecimal(txtTotalAmount.Value),
                DateTime.Now,
                Convert.ToDecimal(txtDiscountRate.Value),
                Convert.ToDecimal(txtDiscount.Value),
                Convert.ToDecimal(txtOtherDiscount.Value),
                Convert.ToDecimal(txtOtherDiscountRate.EditValue),
                Convert.ToDecimal(txtDoanhThu.Value),
                0,
                MyLogin.UserId,
                false,
                0,
                txtDescription.Text,
                true);

            if (!cls.Update(mySql.Transaction))
            {
                result = mySql.Result;
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            InvokeSuccessfull();
            if (chxIsPrint.Checked) Print(false);
            Cursor.Current = Cursors.Default;
            DoHide();
            Cancel();
            SetData(txtID.Text);
            Cursor.Current = Cursors.Default;
            return result;
        }

        private void Print(bool preview)
        {
            if (!MyRule.IsPrint("bbiSale")) return;
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) || string.IsNullOrEmpty(MyInfo.Tel))
            {
                XtraMessageBox.Show("Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            SYS_LOG.Insert("Phiếu Bán Hàng", "In");

            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows.Clear();

            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.AddSTOCK_OUTWARDRow(
                txtID.Text,
                dtCreated.DateTime,
                txtCustomerName.EditValue == null ? "" : txtCustomerName.EditValue.ToString(),
                "",
                "Xuất Bán Hàng",
                chxIsPrint.Checked,
                chxBarcode.Checked,
                "",
                txtCustomerName.Text,
                txtAddress.Text,
                Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * txtExchange.Value,
                
                2,
                false, 
                txtDeliveryDate.DateTime, 
                Convert.ToInt32(txtVatRate.Value), 
                txtVatAmount.Value, 
                0, 
                txtDescription.Text, 
                txtDiscountRate.Value, 
                txtDiscount.Value
                );
            foreach (DataRow dtSale in dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Rows)
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

            string promotion = txtPromotionID.EditValue.ToString();
            decimal otherDiscountRate = Convert.ToDecimal(txtOtherDiscountRate.Value);
            decimal otherDiscount = Convert.ToDecimal(txtOtherDiscount.Value);

            var rpt = new rptStockOutwardA4(dsSTOCK_OUTWARD_DETAIL, "RD0000022", "Phiếu Xuất Hàng", Strings.Format(dtCreated.DateTime, "dd/MM/yyyy"),txtVatAmount.Value, txtTotalAmount.Value,promotion,otherDiscountRate,otherDiscount,txtDoanhThu.Value);
            if (preview)
            {
                rpt.ShowPreview();
                return;
            }
            rpt.ShowPreview();
        }

        public override void Print()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Print(true);
            DoHide();

        }

        public override void ReadLayout(string name)
        {
            var fileInfo = new FileInfo(name);
            if (fileInfo.Exists)
            {
                gbList.RestoreLayoutFromXml(fileInfo.FullName);
            }
        }

        private void SaveLayout()
        {
            SaveLayout(Application.StartupPath + "\\Layout\\xucOutward"+_part+".xml");
        }

        public override void SaveLayout(string name)
        {
            try
            {
                gbList.SaveLayoutToXml(name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void ChxBarcodeCheckedChanged(object sender, EventArgs e)
        {
            lcBarcode.Visibility = chxBarcode.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        protected override void F3Execute()
        {
            txtCustomerName.Focus();
            txtCustomerName.ShowPopup();
        }

        #region Grid

        private void GbListCustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            //try
            //{
            //    if (e.Column.FieldName == "Stock_ID")
            //    {
            //        if (gbList.GetRowCellDisplayText(e.RowHandle, colStock_ID) == "")
            //        {
            //            PRODUCT product = new PRODUCT();
            //            object arg = GetCellValue(e.RowHandle, colProduct_ID, gbList);
            //            if (arg != null)
            //                product.Get(arg.ToString());
            //            gbList.SetRowCellValue(e.RowHandle, colStock_ID, product.Provider_ID);
            //        }
            //    }
            //}
            //catch
            {
            }
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Column)
                {
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

            AdvBandedGridView view = gbList;
            if (view != null)
            {
                var ex = new RowClickEventArgs(view.FocusedRowHandle,
                                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

                //Get Object 
                object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

                if (arg == null)
                {
                    Bar.Bar.bbiProduct.Enabled = false;
                    return;
                }
            }
            Bar.Bar.bbiProduct.Enabled = true;
        }

        private void GbListLayout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        private void GbListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gbList.FocusedColumn == colQuantity)
                {
                    m_Column = Column.Lock;

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colQuantity, 0);
                    m_Column = Column.None;
                 }
                else if (gbList.FocusedColumn == colUnitPrice)
                {
                    m_Column = Column.Lock;

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colUnitPrice, 0);
                    m_Column = Column.None;
                }
                else if (gbList.FocusedColumn == colAmount)
                {
                    m_Column = Column.Lock;

                    gbList.SetRowCellValue(gbList.FocusedRowHandle, colAmount, 0);
                    m_Column = Column.None;
                }
                else
                {
                    DeleteSelected();
                }
            }
            ProcessDialogKey(e.KeyData);
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

        private void GbListCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (m_Column == Column.Lock) return;
            gbList.ClearColumnErrors();

            gbList.UpdateCurrentRow();

            if (m_Column == Column.None)
            {
                if (e.Column.FieldName == "Quantity")
                {
                    m_Column = Column.Quantity;
                }
                else if (e.Column.FieldName == "Product_ID")
                {
                    m_Column = Column.ID;
                }
                else if (e.Column.FieldName == "UnitPrice")
                {
                    m_Column = Column.Price;
                }
                else if (e.Column.FieldName == "Amount")
                {
                    m_Column = Column.Amount;
                }
                else if (e.Column.FieldName == "Stock_ID")
                {
                    m_Column = Column.Stock_ID;
                }
                else if (e.Column.FieldName == "ItemID")
                {
                    m_Column = Column.Name;
                }
                else if (e.Column.FieldName == "Unit")
                {
                    m_Column = Column.Unit;
                }
                else if (e.Column.FieldName == "Height")
                {
                    m_Column = Column.Height;
                }
                else if (e.Column.FieldName == "Width")
                {
                    m_Column = Column.Width;
                }
            }

            if (m_Column == Column.None) return;


            switch (m_Column)
            {

                
                case Column.Quantity:
                    {
                        object unitPrice = gbList.GetRowCellValue(e.RowHandle, "UnitPrice");
                        object unitPriceVat = gbList.GetRowCellValue(e.RowHandle, "Height");
                        m_Column = Column.Lock;

                        gbList.SetRowCellValue(e.RowHandle, "Amount", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) * Convert.ToDouble(unitPrice == DBNull.Value ? 0 : unitPrice));
                        gbList.SetRowCellValue(e.RowHandle, "Width", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) * Convert.ToDouble(unitPriceVat == DBNull.Value ? 0 : unitPriceVat));
                        m_Column = Column.None;
                        SetIndex();
                        CalcSale();
                        Total();
                       
                        break;
                    }
                case Column.Price:
                    {
                        object qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        m_Column = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Amount", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) * Convert.ToDouble(qty == DBNull.Value ? 0 : qty));
                        m_Column = Column.None;
                        SetIndex();
                        CalcSale();
                        Total();
                        
                        break;
                    }
                case Column.Height: // Tinh gia co VAT
                    {
                        object qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");

                        m_Column = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Width", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) * Convert.ToDouble(qty == DBNull.Value ? 0 : qty));
                        gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Math.Round(Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) / 1.1));
                        double quantity = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity"));
                        double amount = quantity * Convert.ToDouble(Math.Round(Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) / 1.1));
                       
                        gbList.SetRowCellValue(e.RowHandle, "Amount",amount);
                        m_Column = Column.None;
                        SetIndex();
                        CalcSale();
                        Total();
                        break;
                    }
                case Column.Width:
                    {
                        double unitPrice = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Height") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Height"));

                        double qty = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

                        m_Column = Column.Lock;
                        if (qty == 0)
                        {
                            if (unitPrice != 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) / unitPrice);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", 1);
                                gbList.SetRowCellValue(e.RowHandle, "Height", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value));
                            }
                        }
                        else
                        {
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Height", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) / qty);
                            }
                        }
                        m_Column = Column.None;
                        SetIndex();
                        CalcSale();
                        Total();
                        break;
                    }
                case Column.Amount:
                    {
                        double unitPrice = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
                        
                        double qty =Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity") == DBNull.Value
                                                 ? 0
                                                 : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

                        m_Column = Column.Lock;
                        if (qty == 0)
                        {
                            if (unitPrice != 0)
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) / unitPrice);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Quantity", 1);
                                gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value));
                            }
                        }
                        else
                        {
                             {
                                 gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) / qty);
                            }
                          }
                        m_Column = Column.None;
                        SetIndex();
                        CalcSale();
                        Total();
                        break;
                    }
                case Column.Stock_ID:
                    {
                        object productId = gbList.GetRowCellValue(e.RowHandle, "Product_ID");

                        gbList.SetColumnError(colStock_ID, null);
                        m_Column = Column.Lock;

                        if (e.Value == null)
                        {
                            gbList.SetColumnError(colStock_ID, "Không được rỗng");
                            gbList.UpdateCurrentRow();
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

                        m_Column = Column.None;
                        }
                    break;

                case Column.ID:
                    m_Column = Column.Lock;
                    gbList.SetColumnError(colProduct_ID, null);
                     if (e.Value != null)
                    {
                         ProductAdd(e.Value.ToString(), "");

                         gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Product_ID"].ToString());
                         gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Stock_ID"].ToString());
                         //gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["UnitPrice"].ToString());
                         gbList.SetFocusedRowCellValue(gbList.Columns["StoreID"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["ID"].ToString());
                         gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Unit"].ToString());
                         gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Quantity"].ToString());
                      }
                    else
                    {
                        gbList.SetColumnError(colProduct_ID, "Vui lòng chọn hàng hoá.");
                    }

                    m_Column = Column.None;
                    break;
                case Column.Name:
                    m_Column = Column.Lock;
                    gbList.SetColumnError(colItemID, null);
                    if (e.Value != null)
                    {
                           ProductAdd(e.Value.ToString(), "");
                           //gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["ID"].ToString());
                           gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Stock_ID"].ToString());
                           //gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["UnitPrice"].ToString());
                           gbList.SetFocusedRowCellValue(gbList.Columns["StoreID"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["ID"].ToString());
                           gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Unit"].ToString());
                           gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], dsPRODUCT_APPOINT.sp_GetProductForStock_Out.Rows[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Quantity"].ToString());
                    }
                    else
                    {
                        gbList.SetColumnError(colItemID, "Vui lòng chọn hàng hoá.");

                    }
                    m_Column = Column.None;
                       break;
                case Column.Unit:
                    {
                        m_Column = Column.Lock;
                        gbList.SetColumnError(colUnit, null);
                        object product_id = gbList.GetRowCellValue(e.RowHandle, "Product_ID") == DBNull.Value
                                                ? ""
                                                : gbList.GetRowCellValue(e.RowHandle, "Product_ID");
                        product_id = gbList.GetRowCellValue(e.RowHandle, "Product_ID") ?? "";
                        var product = new PRODUCT();

                        if (product.Get(product_id.ToString()) == "OK")
                        {
                            if (e.Value != null)
                            {
                                var unitconvert = new PRODUCT_UNIT();
                                decimal convert = unitconvert.GetConvert(product.Product_ID, product.Unit, e.Value.ToString());
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
                         m_Column = Column.None;
                     }
                    break;
            }
            Total();
            m_Column = Column.None;
            SaveHistory();
            SaveHistory(string.Format("{0:yyyyMMddhhmmss}_", DateTime.Now) + txtID.Text);
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void GbListCellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            //if (m_Column == Column.None)
            //{
            //    if (e.Column.FieldName == "Quantity")
            //    {
            //        m_Column = Column.Quantity;
            //    }
            //    else if (e.Column.FieldName == "UnitPrice")
            //    {
            //        m_Column = Column.Price;
            //    }
            //    else if (e.Column.FieldName == "Amount")
            //    {
            //        m_Column = Column.Amount;
            //    }

            //}

            //if (m_Column == Column.None) return;

            //if (e.RowHandle < 0) return;

            //switch (m_Column)
            //{
            //    case Column.Quantity:
            //        {

            //            object UnitPrice = gbList.GetRowCellValue(e.RowHandle, "UnitPrice");
            //            m_Column = Column.Lock;
            //            gbList.SetRowCellValue(e.RowHandle, "Amount",
            //                                   Convert.ToDouble(e.Value) *
            //                                   Convert.ToDouble(UnitPrice == DBNull.Value ? 0 : UnitPrice));
            //            m_Column = Column.None;
            //            SetIndex();
            //            Total();
            //            //  gbList.UpdateCurrentRow();
            //            return;
            //        }
            //    case Column.Price:
            //        {
            //            object Qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
            //            m_Column = Column.Lock;
            //            gbList.SetRowCellValue(e.RowHandle, "Amount",
            //                                   Convert.ToDouble(e.Value) * Convert.ToDouble(Qty == DBNull.Value ? 0 : Qty));
            //            m_Column = Column.None;
            //            SetIndex();
            //            Total();
            //            //  gbList.UpdateCurrentRow();
            //            return;
            //        }
            //    case Column.Amount:
            //        {
            //            double UnitPrice =
            //                Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice") == DBNull.Value
            //                                     ? 0
            //                                     : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));
            //            double Qty =
            //                Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity") == DBNull.Value
            //                                     ? 0
            //                                     : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

            //            m_Column = Column.Lock;
            //            if (Qty == 0)
            //            {
            //                if (UnitPrice != 0)
            //                {
            //                    gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value) / UnitPrice);
            //                }
            //                else
            //                {
            //                    gbList.SetRowCellValue(e.RowHandle, "Quantity", 1);
            //                    gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value));
            //                }
            //            }
            //            else
            //            {
            //                //if (UnitPrice == 0)
            //                {
            //                    gbList.SetRowCellValue(e.RowHandle, "UnitPrice", Convert.ToDouble(e.Value) / Qty);
            //                }
            //                //else
            //                //{
            //                //    gbList.SetRowCellValue(e.RowHandle, "Quantity", Convert.ToDouble(e.Value) / UnitPrice);
            //                //}
            //            }
            //            //  gbList.UpdateCurrentRow();
            //            m_Column = Column.None;
            //            SetIndex();
            //            Total();
            //            return;
            //        }
            //}
        }

        private void GbListCustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            //gbList.GetRowCellDisplayText(e.RowHandle)

            //    if (e.Column.FieldName=="Stock_ID")
            //    {

            //        PRODUCT product=new PRODUCT();
            //        object arg = GetCellValue(e.RowHandle, colProduct_ID, gbList);
            //        if (arg != null)
            //            product.Get(arg.ToString());
            //        gbList.SetRowCellValue(e.RowHandle,colStock_ID,product.Provider_ID);
            //    }
            //}
        }

        #endregion

        #region Popup

        public override void DeleteSelected()
        {
            if (gbList.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                gbList.DeleteSelectedRows();
            }
            else
            {
                gbList.DeleteRow(gbList.FocusedRowHandle);
            }
            gbList.UpdateCurrentRow();
             CalcSale();
        }

        public override void SelectAll()
        {
            gbList.SelectAll();
        }

        public override void DeleteAll()
        {
            if (XtraMessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
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

        private void SaveHistory()
        {
            SaveToFile(Application.StartupPath + "\\Data\\STOCK_OUTWARD"+_part+".xml");
        }

        private void SaveHistory(string name)
        {
            SaveToFile(Application.StartupPath + "\\Data\\" + name + ".old");
        }

        public override void SaveToFile(string name)
        {
            try
            {
                dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows.Clear();

                dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.AddSTOCK_OUTWARDRow(
                    txtID.Text,
                    dtCreated.DateTime,
                    txtCustomerName.EditValue == null ? "" : txtCustomerName.EditValue.ToString(),
                    "",
                    "Xuất Kho",
                    chxIsPrint.Checked,
                    chxBarcode.Checked,
                    "",
                    txtCustomerName.Text,
                    txtAddress.Text,
                    Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * txtExchange.Value,
                    2,
                    false, txtDeliveryDate.DateTime, Convert.ToInt32(txtVatRate.Value), txtVatAmount.Value, 0, txtDescription.Text, txtDiscountRate.Value, txtDiscount.Value);

                dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.WriteXml(name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RestoreHistory()
        {
            ReadFromFile(Application.StartupPath + "\\Data\\STOCK_OUTWARD"+ _part +".xml");
        }

        public override void ReadFromFile(string name)
        {
            try
            {
                var fileInfo = new FileInfo(name);
                if (fileInfo.Exists)
                {
                    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows.Clear();
                    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Rows.Clear();

                    dsSTOCK_OUTWARD_DETAIL.ReadXml(fileInfo.FullName);
                    if (dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows.Count > 0)
                    {
                        txtCustomerName.EditValue =
                            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows[0]["Customer_ID"].ToString();
                        
                        chxIsPrint.Checked = Convert.ToBoolean(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows[0]["IsPrint"] == DBNull.Value ? true : dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows[0]["IsPrint"]);
                        chxBarcode.Checked = Convert.ToBoolean(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows[0]["IsBarcode"] == DBNull.Value ? false : dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows[0]["IsBarcode"]);
                      }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void SaveTemp()
        {
            SaveHistory();
        }

        public override void RestoreTemp()
        {
            RestoreHistory();
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

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }

        #endregion


        private void TxtCustomerNameCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void CbxStockCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void RpgProductCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void RpProductNameCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void RpUnitCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit)sender).Properties.View.ClearColumnsFilter();
        }

        private void RpgProductKeyDown(object sender, KeyEventArgs e)
        {
            ProcessDialogKey(e.KeyData);
        }

        private void RpgProductDoubleClick(object sender, EventArgs e)
        {
            ProductDetail();
        }

       

        protected override void Refresh()
        {
            Updated();
        }

        private void TxtCustomerIdEditValueChanged(object sender, EventArgs e)
        {
            txtCustomerName.EditValue = txtCustomerID.EditValue;
        }

        private void TxtCustomerIdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtCustomerName.Focus();
            }
        }

        private void TxtCustomerNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void TxtAddressKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTax.Focus();
            }
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void TxtTaxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTel.Focus();
            }
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void TxtTelKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void TxtDescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            Bar.Bar.bbiSaveM.Enabled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                gbList.Focus();
            }
        }

        private void TxtTermEditValueChanged(object sender, EventArgs e)
        {
            if (txtTerm.EditValue == null | txtTerm.Text == "") return;

            if (txtTerm.EditValue.ToString() == "CN")
            {
                liMethod.Visibility = LayoutVisibility.Never;
                liPayment.Visibility = LayoutVisibility.Never;
                LiDueTime.Visibility = LayoutVisibility.Always;
                txtPayment.Value = 0;
            }
            else if (txtTerm.EditValue.ToString() == "TM")
            {
                liMethod.Visibility = LayoutVisibility.Always;
                liPayment.Visibility = LayoutVisibility.Never;
                LiDueTime.Visibility = LayoutVisibility.Never;
                txtPayment.Value = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            }
            else if (txtTerm.EditValue.ToString() == "TP")
            {
                liMethod.Visibility = LayoutVisibility.Always;
                LiDueTime.Visibility = LayoutVisibility.Always;
                liPayment.Visibility = LayoutVisibility.Always;
            }
        }

        private void TxtTermKeyPress(object sender, KeyPressEventArgs e)
        {
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        private void TxtDiscountRateEditValueChanged(object sender, EventArgs e)
        {
           CalcSale();
        }

        private void TxtVatRateEditValueChanged(object sender, EventArgs e)
        {
            if (txtOtherDiscountRate.Value != 0)
                CalcSaleKm();
            else
            {
                CalcSale();
            }
        }

        private void CalcSale()
        {
            // Chiết khấu 1
            decimal discount = Math.Round((Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * Convert.ToDecimal(txtDiscountRate.Value) / 100));
            // Chiết khấu 2
            decimal discountVat = Math.Round((Convert.ToDecimal(colWidth.SummaryItem.SummaryValue) * Convert.ToDecimal(txtDiscountRate.Value) / 100));
           
            //Tinh tien thue
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) - discount;
            decimal amountVat = Convert.ToDecimal(colWidth.SummaryItem.SummaryValue) - discountVat;
            decimal vatAmount = amountVat - amount;
            
            //Tinh khuyen mai
            decimal otherDiscount = (amount * Convert.ToDecimal(txtOtherDiscountRate.Value) / 100);
           
            // -----------
            txtDiscount.Value = discount;
            txtOtherDiscount.Value = otherDiscount;
            txtVatRate.Value = 10;
            txtTotalAmount.Value = Convert.ToDecimal(colWidth.SummaryItem.SummaryValue)  - discountVat;
            txtDoanhThu.Value = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) - discount;
            
            if (txtDiscountRate.Value == 0)
            {
                //txtVatAmount.Value = Math.Round(Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) * 10 / 100);
                //txtTotalAmount.Value = Math.Round((Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) - discount) +
                //                       (Convert.ToDecimal(colAmount.SummaryItem.SummaryValue)*10/100));

                txtVatAmount.Value = txtTotalAmount.Value - txtDoanhThu.Value;

            }
            else
            {
                txtVatAmount.Value = vatAmount;
            }
        }
        private void CalcSaleKm()
        {
            txtDiscountRate.Value = 0;
            txtDiscount.Value = 0;
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) ; // tong thanh tien
            decimal otherDiscount = (amount * Convert.ToDecimal(txtOtherDiscountRate.Value) / 100); // tien khuyen mai

            decimal totalAmount = amount - otherDiscount;
            decimal vatAmount = totalAmount * 10/100;

            txtVatAmount.Value = vatAmount;
            txtOtherDiscount.Value = otherDiscount;
            txtDoanhThu.Value = amount - otherDiscount;
            txtTotalAmount.Value = totalAmount + (totalAmount * 10 / 100);

        }
        private void CalcSale0()
        {
            txtVatRate.Value = 0;
            txtDiscountRate.Value = 0;
            txtOtherDiscount.Value = 0;
            txtTotalAmount.Value = 0;

        }

        private void GbListValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            var advBandedGridView = sender as AdvBandedGridView;
            if (advBandedGridView == null) return;
            if (e.Value == null) return;
            if (string.IsNullOrEmpty(e.Value.ToString())) return;

            //switch (advBandedGridView.FocusedColumn.FieldName)
            //{
            //    case "Stock_ID":
            //        {

            //            if (MyLogin.StockID != e.Value.ToString())
            //            {
            //                e.Valid = false;
            //                e.ErrorText = "Bạn không có quyền thao tác trên kho này. \n\n Kho mặc định theo tài khoản " + MyLogin.AccountName;
            //                e.Value = MyLogin.StockID;

            //            }
            //        }
            //        break;
            //}

        }

        private void GbListInvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
            XtraMessageBox.Show(e.ErrorText, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TxtPromotionIdEditValueChanged(object sender, EventArgs e)
        {
           try
           {
               string refiD = txtPromotionID.EditValue.ToString();
               if (refiD != null)
               {
                   var cls = new PROMOTION();
                   if (cls.Get(refiD))
                   {
                       txtOtherDiscountRate.Value = cls.DiscountRate;
                       CalcSale();
                   }
               }
               else
               {
                   txtOtherDiscountRate.Value = 0;
                   txtOtherDiscount.Value = 0;
               }
           }
            catch(Exception)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại.");
            }
        }

        private void TxtPromotionIdPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if(e.Button.Tag == "setNull")
            {
                txtPromotionID.EditValue = "";
                txtOtherDiscountRate.Value = 0;
                txtOtherDiscount.Value = 0;
                CalcSale();
            }
        }

        private void TxtIdPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
           if (e.Button.Tag == "NewID")
                {
                    GetNewId();
                }
          
           
        }
      private void GetNewId()
      {
          try
          {
              var cls = new STOCK_OUTWARD();
              if (cls.GetShortCode(MyLogin.StockID))
              {
                  string prefix = cls.ShortCode + ".BH.";
                  txtID.Text = cls.CreateKey(prefix);
                  txtID.Properties.ReadOnly = false;
              }
              else
              {
                  var cls1 = new STOCK_INWARD();
                  string prefix1 = MyLogin.StockID + ".BH.";
                  txtID.Text = cls1.CreateKey(prefix1);
                  txtID.Properties.ReadOnly = false;
              }

          }
          catch (Exception e)
          {
              XtraMessageBox.Show("Lỗi: " + e);
          }
      }

      private void TxtStockIdEditValueChanged(object sender, EventArgs e)
      {
          Clear();
          Product_Init();
      }

       private void TxtIdKeyPress(object sender, KeyPressEventArgs e)
      {
          if (e.KeyChar == (char)Keys.Enter)
          {
              dtCreated.Focus();
          }
      }

       private void TxtOtherDiscountRateEditValueChanged(object sender, EventArgs e)
       {
         CalcSaleKm();
       }

    }
}