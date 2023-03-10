using System;
using System.Drawing;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory;
using Perfect.Data.Helper;
using Perfect.Net.Info;
using Perfect.Sale.Core.REICEIPT.DS;
using Perfect.Sale.Core.REICEIPT.DS.dsDEBTTableAdapters;
using Perfect.Utils.Lib;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using Perfect.Cash.Cash.Receipt.Report;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;

namespace Perfect.Sale.Core.REICEIPT
{
    public partial class xucReiceipt : xucBaseB
    {
        Column m_Column;
        private string id = "";
        
        private EnumRefType _part;
        public EnumRefType Part
        {
            get { return _part; }
            set
            {
                _part = value;
            }
        }

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
            Stock_ID = 14,
            Name = 15,
            Unit = 16,
            Payment = 17,
            DiscountPercent = 18,
            IsCheck = 19

        }

        public xucReiceipt()
        {
            m_Column = new Column();
            InitializeComponent();
            cbxCurrency.SelectedIndex = 0;
            Bar.Bar.bbiRefresh.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveNew.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSaveM.Enabled = false;
           
            _part = new EnumRefType();
            _part = EnumRefType.StockInward;

            txtTotal.Value = 0;
            txtDebt.Value = 0;


        }

        public bool CheckCount()
        {
            //dsPaymentDetail.PROVIDER_PAYMENT_DETAILDataTable dt = dsPaymentDetail.PROVIDER_PAYMENT_DETAIL;

            //int temp = 0;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;

            //    if (Convert.ToDouble(dt.Rows[i]["Payment"]) == 0)
            //    {
            //        temp = 1;
            //    }
            //    else
            //    {
            //        temp = 2;
            //        break; 
            //    }
            //}

            //if (temp==1)
            //{
            //    return false;
            //}


            return true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();
        }

        public void SetInterface()
        {
            if (_part != EnumRefType.StockInward)
            {
                txtCustomerID.Enabled = false;
                txtCustomerName.Enabled = false;
                txtTax.Enabled = false;
                txtTel.Enabled = false;
                txtAddress.Enabled = false;
                Add();
            }
            //    Init();

        }

        double GetVal(string Text)
        {
            if (Text == "Không Thuế")
                return 0;
            if (Text == "0%")
                return 0;
            if (Text == "5%")
                return 5;
            if (Text == "10%")
                return 10;
            if (Text == "15%")
                return 15;
            return 0;
        }

        public void CustomerInit()
        {
            Cursor.Current = Cursors.WaitCursor;
            cUSTOMERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMERTableAdapter.Fill(dsCustomer.CUSTOMER);
            Cursor.Current = Cursors.Default;
        }

        public void Updated()
        {
            CustomerInit();
        }

        public void Init()
        {
            CreateWaitDialog();
            Updated();

            FormatColumns(rpgProduct, "Product_ID", 0, 100, "Mã Hàng");
            FormatColumns(rpgProduct, "Product_Name", 1, 200, "Hàng Hoá");

            FormatColumns(rpUnit, "Unit_ID", 1, 100, "Mã");
            FormatColumns(rpUnit, "Unit_Name", 0, 200, "Đơn Vị");


            FormatColumns(rpProductName, "Product_ID", 1, 100, "Mã Hàng");
            FormatColumns(rpProductName, "Product_Name", 0, 200, "Hàng Hoá");

            FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã");
            FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");

            dtCreated.DateTime = DateTime.Now;
            SetWaitDialogCaption("Nạp cấu hình giao diện....");
            ReadLayout();
            SetWaitDialogCaption("Nạp dữ liệu cũ....");
            RestoreHistory();



            m_Column = Column.None;

            //colLimit.Visible = SYS_OPTION.Limit;


            if (CODE.TypeSoft < 400 & CODE.TypeSoft != 0)
            {
                // colUnit.OptionsColumn.AllowEdit = false;
                //colUnit.OptionsColumn.ReadOnly = true;
            }

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);

            SetWaitDialogCaption("Nạp hoàn thành....");
            DoHide();
        }


        private void txtCustomerName_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var customer = new PROVIDER(txtCustomerID.Text, 0, txtCustomerName.Text, "", "", txtAddress.Text, "", "", txtTax.Text, txtTel.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, 0, "", true);

                var xfmProviderAdd = new xfmProviderAdd(customer);
                xfmProviderAdd.Added += XfmProviderAddAdded;
                xfmProviderAdd.ShowDialog();

            }
        }

        void XfmProviderAddAdded(object sender, PROVIDER item)
        {
            CustomerInit();
            txtCustomerName.EditValue = item.Customer_ID;
        }

        void XfmProvidersItemSelected(object sender, PROVIDER item)
        {
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void txtCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            Cursor.Current = Cursors.WaitCursor;

            if (txtCustomerName.EditValue == null) return;
            var customer = new CUSTOMER();
            if (customer.Get(txtCustomerName.EditValue.ToString()) == "OK")
            {
                txtCustomerID.Text = customer.Customer_ID;
                txtAddress.Text = customer.CustomerAddress;
                txtTel.Text = customer.Tel;
                txtTax.Text = customer.Tax;
            }

            var db = new ERP.DEBT();
            txtDebt.Value = db.GetDebit(txtCustomerName.EditValue.ToString());
            dEBTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            dEBTTableAdapter.Fill(dsDEBT.DEBT, txtCustomerName.EditValue.ToString());
            Cursor.Current = Cursors.Default;

        }

        private void txtCustomerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustomerName.EditValue = txtCustomerID.EditValue;
            }
        }

        private void gbList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            gbList.UpdateCurrentRow();

            if (m_Column == Column.Lock) return;

            if (m_Column == Column.None)
            {
                if (e.Column.FieldName == "Quantity")
                {
                    m_Column = Column.Quantity;
                }
                else if (e.Column.FieldName == "ProductID")
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
                else if (e.Column.FieldName == "Discount")
                {
                    m_Column = Column.Discount;
                }
                else if (e.Column.FieldName == "DiscountPercent")
                {
                    m_Column = Column.DiscountPercent;
                }
                else if (e.Column.FieldName == "Payment")
                {
                    m_Column = Column.Payment;
                }
                else if (e.Column.FieldName == "Selected")
                {
                    m_Column = Column.IsCheck;
                }
            }

            switch (m_Column)
            {
                case Column.None:
                    return;
                case Column.Discount:
                    {
                        double oldDebt = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "CopyDebt") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "CopyDebt"));
                        double debt = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Debt") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Debt"));
                        double discount = Convert.ToDouble(e.Value ?? 0);
                        double newDebt = debt - discount;

                        double payment = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Payment") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Payment"));

                        double discountPercent = 100 * discount / oldDebt;

                        m_Column = Column.Lock;


                        if (discount > oldDebt | discount < 0)
                        {
                            gbList.SetRowCellValue(e.RowHandle, "DiscountPercent", 0);
                            gbList.SetRowCellValue(e.RowHandle, "Discount", 0);
                            gbList.SetRowCellValue(e.RowHandle, "Debt", oldDebt);

                            if (Convert.ToBoolean(gbList.GetRowCellValue(e.RowHandle, "IsCheck")))
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Payment", oldDebt);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Payment", 0);
                            }

                            m_Column = Column.None;
                            return;
                        }


                        if (discount == 0)
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Debt", oldDebt);
                            gbList.SetRowCellValue(e.RowHandle, "DiscountPercent", discountPercent);

                            if (Convert.ToBoolean(gbList.GetRowCellValue(e.RowHandle, "IsCheck")))
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Payment", oldDebt);
                            }
                        }
                        else
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Debt", newDebt);
                            gbList.SetRowCellValue(e.RowHandle, "DiscountPercent", discountPercent);


                        }

                        if (payment > newDebt)
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Payment", newDebt);
                        }

                        m_Column = Column.None;

                        SetIndex();
                        Total();
                        return;
                    }
                case Column.DiscountPercent:
                    {
                        double oldDebt = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "CopyDebt") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "CopyDebt"));
                        double discountPercent = Convert.ToDouble(e.Value ?? 0);
                        double debt = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Debt") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Debt"));
                        double discount = debt * discountPercent / 100;
                        double newDebt = debt - discount;

                        double payment = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Payment") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Payment"));

                        m_Column = Column.Lock;

                        if (discountPercent > 100 | discountPercent < 0)
                        {
                            gbList.SetRowCellValue(e.RowHandle, "DiscountPercent", 0);
                            gbList.SetRowCellValue(e.RowHandle, "Discount", 0);
                            gbList.SetRowCellValue(e.RowHandle, "Debt", oldDebt);

                            if (Convert.ToBoolean(gbList.GetRowCellValue(e.RowHandle, "IsCheck")))
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Payment", oldDebt);
                            }
                            else
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Payment", 0);
                            }

                            m_Column = Column.None;
                            return;
                        }

                        if (discount == 0)
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                            gbList.SetRowCellValue(e.RowHandle, "Debt", oldDebt);

                            if (Convert.ToBoolean(gbList.GetRowCellValue(e.RowHandle, "IsCheck")))
                            {
                                gbList.SetRowCellValue(e.RowHandle, "Payment", oldDebt);
                            }
                        }
                        else
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                            gbList.SetRowCellValue(e.RowHandle, "Debt", newDebt);
                        }

                        if (payment > newDebt)
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Payment", newDebt);
                        }

                        m_Column = Column.None;

                        SetIndex();
                        Total();
                        break;
                    }

                case Column.Payment:
                    {
                        double payment = Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value ?? 0);
                        double debt = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Balance") == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Balance"));


                        m_Column = Column.Lock;

                        gbList.SetColumnError(colPayment, null);

                        if (payment > debt | payment < 0)
                        {
                            gbList.SetColumnError(colPayment, "Tiền trả lớn hơn số tiền nợ");
                            gbList.SetRowCellValue(e.RowHandle, "Payment", 0);
                            //gbList.SetColumnError(colPayment, 0);

                        }
                        else
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Payment", payment);
                            m_Column = Column.None;
                        }

                        m_Column = Column.None;
                        //Total();

                        if (!chxKhautru.Checked)
                        {
                            txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue);
                        }

                        SetIndex();

                        break;

                    }

                case Column.IsCheck:
                    {
                        //double payment = Convert.ToDouble(e.Value);
                        gbList.SetColumnError(colPayment, null);
                        if (Convert.ToBoolean(e.Value))
                        {
                            double debt =
                                Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Balance") == DBNull.Value
                                                     ? 0
                                                     : gbList.GetRowCellValue(e.RowHandle, "Balance"));


                            m_Column = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Payment", debt);
                        }
                        else
                        {
                            m_Column = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Payment", 0);
                        }
                        m_Column = Column.None;

                        //Total();

                        if (!chxKhautru.Checked)
                        {
                            txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue);
                        }

                        SetIndex();

                        break;
                    }
            }
            Total();
            m_Column = Column.None;
            SaveHistory();
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
        }

        public void ProductAdd(string id)
        {
            var pro = new PRODUCT();

            if (pro.Get(id) == "OK")
            {

                //UNIT unit = new UNIT();
                //unit.Get(pro.Unit);
                //UnitInit(pro.Product_ID);

                if (txtCustomerName.Text == "")
                {
                    txtCustomerName.EditValue = pro.Customer_ID;
                }

                gbList.SetFocusedRowCellValue(gbList.Columns["ProductName"], pro.Product_Name);
                gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["ProductID"], pro.Product_ID);
                gbList.SetFocusedRowCellValue(gbList.Columns["Vat"], "Không Thuế");
                gbList.SetFocusedRowCellValue(gbList.Columns["VatAmount"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], pro.Org_Price);
                gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], 0);
                gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], "");
                gbList.SetFocusedRowCellValue(gbList.Columns["Limit"], DateTime.Today.AddDays(pro.ExpiryValue));
                gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                //gbList.SetFocusedRowCellValue(gbList.Columns["StockID"], cbxStock.EditValue);
                //gbList.SetFocusedRowCellValue(gbList.Columns["Stock_Name"], cbxStock.Text);
                gbList.SetRowCellValue(gbList.FocusedRowHandle, "STT", gbList.FocusedRowHandle + 1);
                //return;
                if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                //gbList.Columns["Quantity"].View.Focus();
                Total();
                //gbList.UpdateCurrentRow();
            }
        }

        private void gbList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (m_Status == Actions.None)
            //{
            //    Add();
            //}
            //gbList.UpdateCurrentRow();
            if (m_Column == Column.Lock) return;

            if (m_Column == Column.None)
            {
                switch (e.Column.FieldName)
                {
                    //case "Quantity":
                    //    m_Column = Column.Quantity;
                    //    break;
                    //case "ProductID":
                    //    m_Column = Column.ID;
                    //    break;
                    //case "UnitPrice":
                    //    m_Column = Column.Price;
                    //    break;
                    //case "Amount":
                    //    m_Column = Column.Amount;
                    //    break;
                    //case "Stock_ID":
                    //    m_Column = Column.Stock_ID;
                    //    break;
                    //case "ItemID":
                    //    m_Column = Column.Name;
                    //    break;
                    //case "Unit":
                    //    m_Column = Column.Unit;
                    //    break;
                    //case "Discount":
                    //    m_Column = Column.Discount;
                    //    break;
                    //case "DiscountPercent":
                    //    m_Column = Column.DiscountPercent;
                    //    break;
                    //case "Payment":
                    //    m_Column = Column.Payment;
                    //    break;
                    case "Selected":
                        m_Column = Column.IsCheck;
                        break;
                }
            }

            switch (m_Column)
            {
                case Column.None:
                    return;
                case Column.IsCheck:
                    {
                        //double payment = Convert.ToDouble(e.Value);
                        if (e.Value == null)
                        {
                            m_Column = Column.None;
                            return;
                        }
                        gbList.SetColumnError(colPayment, null);
                        if (Convert.ToBoolean(e.Value))
                        {
                            double debt =
                                Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Balance") == DBNull.Value
                                                     ? 0
                                                     : gbList.GetRowCellValue(e.RowHandle, "Balance"));


                            m_Column = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Payment", debt);
                            gbList.UpdateCurrentRow();
                        }
                        else
                        {
                            m_Column = Column.Lock;
                            gbList.SetRowCellValue(e.RowHandle, "Payment", 0);
                            gbList.UpdateCurrentRow();
                        }
                        m_Column = Column.None;

                        //Total();

                        if (!chxKhautru.Checked)
                        {
                            txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue);
                        }

                        SetIndex();

                        break;
                    }
            }
            
        }

        public void SetIndex()
        {
            //m_Column = Column.Lock;

            //dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAILDataTable dt =
            //    dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i].RowState== DataRowState.Deleted) continue;

            //    if (dt.Rows[i]["Product_ID"] != DBNull.Value)
            //    {
            //        dt.Rows[i]["STT"] = i + 1;
            //    }
            //}
            //m_Column = Column.None;
        }

        public void Total()
        {
            //double Amount = 0.0;

            //for (int i = 0; i < gbList.RowCount; i++)
            //{
            //    Amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));

            //}

            //txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue);

            if (cbxCurrency.SelectedIndex == 0)
            {
                MyLib.Currency = "VND";
                MyLib.CurrencySymbol = "đồng";
                MyLib.UnitSecond = "không";

                txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue),2));
            }

            else
            {
                MyLib.Currency = "USD";
                MyLib.CurrencySymbol = "đô la";
                MyLib.UnitSecond = "cent";

                //txtTotalText.Text = MyLib.ToText(colPayment.SummaryItem.SummaryValue);

                txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue) /
                                    Convert.ToDouble(txtExchange.Value), 2));

            }

            if (!chxKhautru.Checked)
            {
                txtTotal.Value = Math.Round(Convert.ToDecimal(colPayment.SummaryItem.SummaryValue) /
                                        Convert.ToDecimal(txtExchange.Value), 2);
            }

            // txtAmount.Value = Convert.ToDecimal(Amount);
        }

        public override void Clear()
        {
            //base.Clear();
            //dsPurchaseDetail.PURCHASE_INVOICE_DETAIL.Clear();
        }

        public override void Add()
        {
            if (!MyRule.IsAdd("bbiReciept")) return;
            //var cls = new CUSTOMER_RECEIPT();
            var cls = new TRANS_REF();
            txtID.Text = cls.NewID("PT");
            
            txtTel.Text = "";
            txtTax.Text = "";
            txtTotalText.Text = "";
            txtCustomerName.EditValue = "";
            txtCustomerID.EditValue = "";
            txtAddress.Text = "";

            txtTotal.Value = 0;
            txtDebt.Value = 0;
            txtDescription.Text = "";
            DisableControl(true);
            //cbxStock.Enabled = true;
            txtID.Properties.ReadOnly = false;
			m_Status = Actions.Add;
			NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
			id = "";

            txtCustomerID.Enabled = true;
            txtCustomerName.Enabled = true;
            txtCustomerName_EditValueChanged(this, null);
        }

        public void AddNew(string id)
        {
            var cls = new CUSTOMER();
            cls.Get(id);
            txtCustomerID.EditValue = id;
        }
        
        public override bool Check()
        {
            if (txtCustomerName.Text == "" | txtCustomerName.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
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

            if (txtTotal.Value == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (gbList.RowCount == 0)
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

        public bool DetailCheck()
        {
            //Purchase.DS.dsPurchaseDetail.PURCHASE_INVOICE_DETAILDataTable dt =
            //    dsPurchaseDetail.PURCHASE_INVOICE_DETAIL;



            //string text;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;

            //    text = gbList.GetDisplayTextByColumnValue(colProductID, dt.Rows[i]["ProductID"].ToString());
            //    if (text.Trim() == "")
            //    {
            //        XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (i + 1), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        //dt.Rows.RemoveAt(i);
            //        return false;
            //    }

            //    text = gbList.GetDisplayTextByColumnValue(colStockID, dt.Rows[i]["StockID"].ToString());
            //    if (text.Trim() == "")
            //    {
            //        XtraMessageBox.Show("Chưa chọn kho hàng.\n\tDòng số: " + (i + 1), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        //dt.Rows.RemoveAt(i);
            //        return false;
            //    }

            //    if (dt.Rows[i]["StockID"] == null | dt.Rows[i]["StockID"] == DBNull.Value)
            //    {
            //        XtraMessageBox.Show("Kho hàng nhập không đúng.\n\tDòng số: " + (i + 1), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return false;
            //    }
            //    if (dt.Rows[i]["ProductID"] == null | dt.Rows[i]["ProductID"] == DBNull.Value)
            //    {
            //        XtraMessageBox.Show("Chưa chọn mặt hàng.\n\tDòng số: " + (i + 1), "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return false;
            //    }


            //}

            return true;
        }

        public override string uc_Save()
        {
            SysLog.Insert("Phiếu Chi", "Thêm", txtID.Text);

            if (!DetailCheck()) return "";
            if (CODE.TypeSoft == 0)
            {
                if (INVENTORY_DETAIL.Count > 10000)
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
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            #region Phiếu Chi

            id = Guid.NewGuid().ToString();
            var providerPayment = new CUSTOMER_RECEIPT(
               id,
               txtID.Text,
               dtCreated.DateTime,
               "",
               35,
               0,
               "11111111-1111-1111-1111-111111111111",
               "",
               cbxCurrency.Text,
               txtExchange.Value,
               "",
               "",
               txtCustomerName.EditValue.ToString(),
               txtCustomerName.Text,
               txtAddress.Text,
               txtTax.Text,
               "",
               txtTotal.Value,
               0,
               0,
               0,
               false,
               false,
               MyLogin.Account,
               DateTime.Now,
               MyLogin.Account,
               DateTime.Now,
               MyLogin.UserId,
               txtDescription.Text,
               0,
               true
               );

            if (!providerPayment.Insert(mySql.Transaction))
            {
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

            #endregion


            mySql.Commit();
            if (XtraMessageBox.Show("Bạn có muốn in phiếu này không?", "Thông báo", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                SetWaitDialogCaption("Đang in dữ liệu....");
                Print(false);
                DoHide();
            }
            // Updated();
            DoHide();
            Cancel();
            SetData(id);
            Bar.Bar.bbiSaveM.Enabled = false;
            Cursor.Current = Cursors.Default;
            return result;
        }
        string DetailSave(SqlHelper sql)
        {
            string result = "OK";

            var cls = new CUSTOMER_RECEIPT_DETAIL();
            var dt = dsDEBT.DEBT;


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];

                if (dr.RowState == DataRowState.Added)
                {
                   
                    if (!cls.Insert(
                        sql.Transaction,
                        Guid.NewGuid().ToString(),
                        id,
                        dr["RefOrgNo"].ToString(),
                        cbxCurrency.Text,
                        txtExchange.Value,
                        1,
                        Convert.ToDecimal(dr["Amount"]),
                        Convert.ToDecimal(dr["Balance"]),
                        Convert.ToDecimal(dr["Payment"]),
                        Convert.ToDecimal(dr["DiscountRate"]),
                        Convert.ToDecimal(dr["Discount"]),
                        0,
                        0,
                        0,
                        txtCustomerName.Text,
                        0)
)
                    {
                        DoHide();
                        sql.RollBack();
                        return "Không lưu được!";
                    }
                }
                else if (dr.RowState == DataRowState.Modified)
                {

                    if (!cls.Insert(
                        sql.Transaction,
                        dr["ID"].ToString(),
                        id,
                        dr["RefOrgNo"].ToString(),
                        cbxCurrency.Text,
                        txtExchange.Value,
                        1,
                        Convert.ToDecimal(dr["Amount"]),
                        Convert.ToDecimal(dr["Balance"]),
                        Convert.ToDecimal(dr["Payment"]),
                        Convert.ToDecimal(dr["DiscountRate"]),
                        Convert.ToDecimal(dr["Discount"]),
                        0,
                        0,
                        0,
                        txtCustomerName.Text,
                        0)
)
                    {
                        DoHide();
                        sql.RollBack();
                        return "Không lưu được!";
                    }
                }
                else if (dr.RowState == DataRowState.Deleted)
                {
                    if (!cls.Delete(
                       sql.Transaction,
                       dr["ID",DataRowVersion.Original].ToString()
                      ))
                    {
                        DoHide();
                        sql.RollBack();
                        return "Không lưu được!";
                    }
                }
            }

            return result;
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Delete)
            //{
            //    if (gbList.FocusedColumn == colQuantity)
            //    {
            //        m_Column = Column.Lock;
            //        //    //object Arg = gbList.GetFocusedValue();
            //        //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());

            //        gbList.SetRowCellValue(gbList.FocusedRowHandle, colQuantity, 0);
            //        m_Column = Column.None;
            //        //    return;
            //    }
            //    else if (gbList.FocusedColumn == colUnitPrice)
            //    {
            //        m_Column = Column.Lock;
            //        //    //object Arg = gbList.GetFocusedValue();
            //        //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());

            //        gbList.SetRowCellValue(gbList.FocusedRowHandle, colUnitPrice, 0);
            //        m_Column = Column.None;
            //        //    return;
            //    }
            //    else if (gbList.FocusedColumn == colAmount)
            //    {
            //        m_Column = Column.Lock;
            //        //    //object Arg = gbList.GetFocusedValue();
            //        //    //ProductAdd(Arg == DBNull.Value ? "" : Arg.ToString());

            //        gbList.SetRowCellValue(gbList.FocusedRowHandle, colAmount, 0);
            //        m_Column = Column.None;
            //        //    return;
            //    }
            //    else
            //    {
            //        gbList.DeleteRow(gbList.FocusedRowHandle);
            //    }
            //}

            ////KeyDoEvent(e.KeyCode);
            //ProcessDialogKey(e.KeyData);
        }

        public bool KeyDoEvent(Keys keyData)
        {
			 NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            if (keyData == (Keys.Alt | Keys.D))
            {
               // some more cases...  
            }
            else if (keyData == Keys.F1)
            {
                //ucToolBar_HelpClick(ucBar);
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

        public void Mirror(string id)
        {
            SetData(id);
            m_Status = Actions.Add;
            txtID.Properties.ReadOnly = false;
            var cls = new STOCK_OUTWARD();
            txtID.Text = cls.NewID();

        }

        public new void SetData(string table)
        {
            var cls = new CUSTOMER_RECEIPT();
            if (!cls.Get(table))
            {
                XtraMessageBox.Show("Không tìm thấy thông tin phiếu này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_Status = Actions.Change;
            DisableControl(true);
            if (m_Status == Actions.Change)
            {
                txtID.Properties.ReadOnly = true;
                txtID.Text = cls.RefID;
           
            }
            id = cls.ID;
            dtCreated.DateTime = cls.RefDate;
            cbxCurrency.Text = cls.CurrencyID;
            txtExchange.Value = Convert.ToDecimal(cls.ExchangeRate);
            txtCustomerID.Text = cls.CurrencyID;
            txtCustomerName.EditValue = cls.CustomerID;
            txtAddress.Text = cls.CustomerAddress;
            txtDescription.Text = cls.Description;

            cbxCurrency.Text = cls.CurrencyID;
            txtExchange.Value = Convert.ToDecimal(cls.ExchangeRate);

            //Lay dữ liệu

            //txtTotal.Value = Convert.ToDecimal(cls.Amount);
            //txtTotalText.Text = MyLib.ToText(cls.Amount);
            var adapter = new CUSTOMER_RECEIPT_DETAILTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            dsDEBT.DEBT.Rows.Clear();
            dsDEBT.DEBT.Merge(adapter.GetData(new Guid(id)));


            txtTotal.Value = Math.Round(Convert.ToDecimal(cls.Amount) / Convert.ToDecimal(cls.ExchangeRate), 2);

            if (cbxCurrency.SelectedIndex == 0)
            {
                MyLib.Currency = "VND";
                MyLib.CurrencySymbol = "đồng";
                MyLib.UnitSecond = "không";

                //txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(cls.Amount) / Convert.ToDouble(cls.ExchangeRate), 2));

                txtTotalText.Text = MyLib.ToText(Math.Round(txtTotal.Value, 2));

            }
            else
            {
                MyLib.Currency = "USD";
                MyLib.CurrencySymbol = "đô la";
                MyLib.UnitSecond = "cent";

                txtTotalText.Text = MyLib.ToText(Math.Round(txtTotal.Value, 2));
            }
            txtCustomerID.Enabled = !true;
            txtCustomerName.Enabled = !true;
			NotSave = false;
            Bar.Bar.bbiSaveM.Enabled = false;
            Status = Actions.None;
            //m_Status = Actions.Change;

        }


        public void SetData1(string id)
        {
            var cls = new CUSTOMER();
            cls.Get(id);
            txtCustomerID.EditValue = id;
           }

        public override string uc_Change()
        {
            //MessageBox.Show(Convert.ToDouble(colAmount.SummaryItem.SummaryValue).ToString());

           // if (!MyRule.IsEdit("bbiReciept")) return "";
           

            SysLog.Insert("Phiếu Chi", "Cập Nhật", txtID.Text);

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
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }
            
            #region Phiếu Thu

            var cls = new CUSTOMER_RECEIPT(
               id,
               txtID.Text,
               dtCreated.DateTime,
               "",
               35,
               0,
               "11111111-1111-1111-1111-111111111111",
               "",
               cbxCurrency.Text,
               txtExchange.Value,
               "",
               "",
               txtCustomerName.EditValue.ToString(),
               txtCustomerName.Text,
               txtAddress.Text,
               txtTax.Text,
               "",
               txtTotal.Value,
               0,
               0,
               0,
               false,
               false,
               MyLogin.Account,
               DateTime.Now,
               MyLogin.Account,
               DateTime.Now,
               MyLogin.UserId,
               txtDescription.Text,
               0,
               true
               );
        
            if (!cls.Update(mySql.Transaction))
            {
                DoHide();
                mySql.RollBack();
                //XtraMessageBox.Show("Lỗi:\n\t" + result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }


            result = DetailSave(mySql);

            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                // XtraMessageBox.Show("Lỗi:\n\t" + result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }
            #endregion
            mySql.Commit();
            if (XtraMessageBox.Show("Bạn có muốn in phiếu này không?", "Thông báo", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                SetWaitDialogCaption("Đang in dữ liệu....");
                Print(false);
                DoHide();
            }

            //Updated();
            DoHide();
            Cancel();
			SetData(id);
			NotSave = false;			
            Bar.Bar.bbiSaveM.Enabled = false;
            Cursor.Current = Cursors.Default;
            return result;
        }

        public void Print(bool preview)
        {
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) || string.IsNullOrEmpty(MyInfo.Tel) || string.IsNullOrEmpty(MyInfo.Fax))
            {
                XtraMessageBox.Show("Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            if (!MyRule.IsPrint("bbiReciept")) return;
           
            if (dsDEBT.DEBT.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không tìm thấy dữ liệu để in", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SysLog.Insert("Phiếu thu tiền", "In");

            var dsReceipt = new dsReceipt();
            dsReceipt.CUSTOMER_RECEIPT.AddCUSTOMER_RECEIPTRow(
                dtCreated.DateTime, 
                txtCustomerName.Text, 
                txtAddress.Text,
                txtTax.Text, "",
                Convert.ToDecimal(txtTotal.Text), 
                txtDescription.Text);

            txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue) /
                                    Convert.ToDouble(txtExchange.Value), 2));
            string desc = "Thu Tiền Nợ Khách Hàng";
            var rpt = new rptReceiptInvoice(dsReceipt.CUSTOMER_RECEIPT,"PHIẾU THU",txtID.Text,txtTotalText.Text, cbxCurrency.Text, desc);
            rpt.ShowRibbonPreview();
        }

        public override void Print()
        {
            SysLog.Insert("Phiếu Chi", "In", txtID.Text);
            Print(true);
        }

        protected void txtID_EditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (m_Status != Actions.Add) return;

            var transRef = new TRANS_REF();
            if (transRef.Exist(txt.Text))
            {
                Err.SetError(txt, "Mã đã tồn tại.");
                txt.Focus();
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            var txt = (TextEdit)sender;

            if (m_Status == Actions.None) return;

            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
                txt.Focus();
            }
        }

        protected void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;

            var txt = (TextEdit)sender;
            //if (!(e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)) return;
            var transRef = new TRANS_REF();
            if (m_Status == Actions.Add)
            {
                if (!transRef.Exist(txt.Text)) return;
                Err.SetError(txt, "Mã đã tồn tại.");
                txt.Focus();
            }
            else
            {
                SetData(txtID.Text);
            }
        }

        public void SaveLayout()
        {
            //SaveLayout(Application.StartupPath + "\\Layout\\xucReiceipt.xml");
        }

        public override void SaveLayout(string name)
        {
            try
            {
                gbList.SaveLayoutToXml(name);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show( ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void ReadLayout()
        {
            //ReadLayout(Application.StartupPath + "\\Layout\\xucReiceipt.xml");
        }

        public override void ReadLayout(string name)
        {
            var fileInfo = new FileInfo(name);
            if (fileInfo.Exists)
            {
                gbList.RestoreLayoutFromXml(fileInfo.FullName);
            }
        }

        public void SaveHistory()
        {
            //SaveToFile(Application.StartupPath + "\\Data\\CUSTOMER_REICEIPT.xml");
        }

        public override void SaveToFile(string name)
        {
            //try
            //{
            //    dsPurchaseDetail.PURCHASE_INVOICE_DETAIL.Rows.Clear();

            //    dsPurchaseDetail.PURCHASE_INVOICE_DETAIL.AddPURCHASE_INVOICE_DETAILRow(txtID.Text, dtCreated.DateTime,
            //        cbxStock.EditValue==null?"": cbxStock.EditValue.ToString(), "",
            //        txtCustomerName.EditValue==null?"":txtCustomerName.EditValue.ToString(),
            //                                                          chxIsPrint.Checked, chxBarcode.Checked);

            //    dsSTOCK_INWARD_DETAIL.WriteXml(name);



            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }

        public void RestoreHistory()
        {
            //ReadFromFile(Application.StartupPath + "\\Data\\CUSTOMER_REICEIPT.xml");

        }

        public override void ReadFromFile(string name)
        {
            //try
            //{
            //    FileInfo fileInfo = new FileInfo(name);
            //    if (fileInfo.Exists)
            //    {
            //        dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows.Clear();
            //        dsSTOCK_INWARD_DETAIL.STOCK_INWARD_DETAIL.Rows.Clear();    
            //        dsSTOCK_INWARD_DETAIL.ReadXml(fileInfo.FullName);
            //        if (dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows.Count > 0)
            //        {
            //            txtCustomerName.EditValue = dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows[0]["Customer_ID"].ToString();
            //            cbxStock.EditValue = dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows[0]["Stock_ID"].ToString();
            //            chxIsPrint.Checked = Convert.ToBoolean(dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows[0]["IsPreview"]);
            //            chxBarcode.Checked = Convert.ToBoolean(dsSTOCK_INWARD_DETAIL.STOCK_INWARD.Rows[0]["IsBarcode"]);
            //        }

            //    }

            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void gbList_Layout(object sender, EventArgs e)
        {
            SaveLayout();
        }

        //private void gbList_LayoutUpgrade(object sender, DevExpress.Utils.LayoutUpgadeEventArgs e)
        //{
        //    SaveLayout();
        //}

        #region Popup

        public override void DeleteSelected()
        {
            gbList.DeleteSelectedRows();
        }

        public override void SelectAll()
        {
            gbList.SelectAll();
        }

        public override void DeleteAll()
        {
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
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

        #endregion

        private void gbList_MouseDown(object sender, MouseEventArgs e)
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
                    //MessageBox.Show("Ad");

                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                    Bar.Bar.bm.HideToolBarsPopup();
                    Bar.Bar.pm.HidePopup();
                    DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.Row)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    // MessageBox.Show("BB");
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowCell)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    // MessageBox.Show("BB");
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.EmptyRow)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
                    // MessageBox.Show("BB");
                }
                else if (gbList.CalcHitInfo(e.X, e.Y).HitTest == BandedGridHitTest.RowFooter)
                {
                    Bar.Bar.bm.SetPopupContextMenu(gcList, null);
                }
                //else
                //{
                //   // MessageBox.Show(gbList.CalcHitInfo(e.X, e.Y).HitTest.ToString());
                //}
            }
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks==2)
                    gbList.SelectAll();
            }
                //DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));

            DisableMenu(false);
            if (gbList.RowCount - 1 == 0)
            {
                DisableMenu(true);
                return;
            }

            
            object arg=gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            Bar.Bar.bbiProduct.Enabled = true;

        }

        void DoShowMenu(GridHitInfo hi)
        {
            DevExpress.XtraGrid.Menu.GridViewMenu menu;
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            //if (e.RowHandle == GridControl.InvalidRowHandle)
            //{
            //    e.Handled = true;
            //    e.Painter.DrawObject(e.Info);

            //    Rectangle r = e.Bounds;
            //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), r);
            //    r.Height--; r.Width--;
            //    e.Graphics.DrawRectangle(Pens.Blue, r);
            //}

            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }


        }

        protected override void F3Execute()
        {
            txtCustomerName.Focus();
            txtCustomerName.ShowPopup();
        }

        private void xucInwards_Load(object sender, EventArgs e)
        {

        }

        private void cbxCurrency_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cbxCurrency.Text == "" | cbxCurrency.SelectedValue == null) return;

            if (cbxCurrency.Text == "VND")
            {
                MyLib.Currency = "VND";
                MyLib.CurrencySymbol = "đồng";
                MyLib.UnitSecond = "không";

                txtExchange.Value = 1;

                txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue);

                txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue) /
                                    Convert.ToDouble(txtExchange.Value), 2));

            }
            else
            {
                MyLib.Currency = "USD";
                MyLib.CurrencySymbol = "đô la";
                MyLib.UnitSecond = "cent";

                //txtExchange.Value = 16000;

                txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue) / Convert.ToDecimal(txtExchange.Value);

                txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue) /
                                    Convert.ToDouble(txtExchange.Value), 2));
            }
        }

        private void chxKhautru_CheckedChanged(object sender, EventArgs e)
        {
            if (chxKhautru.Checked)
            {
                txtTotal.Properties.ReadOnly = false;
                txtDiscountRate.Properties.ReadOnly = false;
                txtDiscount.Properties.ReadOnly = false;
                colPayment.OptionsColumn.AllowEdit = false;
                colIsCheck.OptionsColumn.AllowEdit = false;
            }
            else
            {
                txtTotal.Properties.ReadOnly = true;
                txtDiscountRate.Properties.ReadOnly = true;
                txtDiscount.Properties.ReadOnly = true;
                colPayment.OptionsColumn.AllowEdit = true;
                colIsCheck.OptionsColumn.AllowEdit = true;
            }
        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            var dt = dsDEBT.DEBT;

           
            if (chxKhautru.Checked)
            {
                if (txtCustomerName.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn thông tin Khách Hàng.");
                    return;
                }

                double total = Convert.ToDouble(txtTotal.Value);

                double debt = 0.0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (dr.RowState == DataRowState.Deleted) continue;
                    dr["Payment"] = 0;
                }

                for (int i = 0; (i < dt.Rows.Count) | total <= 0; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (dr.RowState == DataRowState.Deleted) continue;
                    //debt = Convert.ToDouble(dgvList["ConNo", i].Value);
                    debt = Convert.ToDouble(dr["Balance"]);
                    if (total > debt)
                    {
                        //dgvList["ThanhToan", i].Value = debt;
                        dr["Payment"] = debt;
                        total -= Math.Round(debt);
                    }
                    else
                    {
                        //dgvList["ThanhToan", i].Value = total;
                        dr["Payment"] = total;
                        return;
                    }
                }
                if (total > 0)
                {
                    txtTotal.Value = txtDebt.Value;
                    //Total();
                }
            }
            
           // txtTotalText.Text = MyLib.ToText(txtTotal.Value.ToString());
            txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(txtTotal.Value),2));
        }

        private void txtExchange_EditValueChanged(object sender, EventArgs e)
        {
            if (txtExchange.Value == 0)
            {
                txtExchange.Value = 1;
                txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue);
            }

            if (cbxCurrency.SelectedIndex == 0)
            {
                MyLib.Currency = "VND";
                MyLib.CurrencySymbol = "đồng";
                MyLib.UnitSecond = "không";


                txtTotal.Value = Convert.ToDecimal(colPayment.SummaryItem.SummaryValue) /
                                 Convert.ToDecimal(txtExchange.Value);

                //txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue) /
                //                    Convert.ToDouble(txtExchange.Value), 2));
                txtTotalText.Text = MyLib.ToText(Math.Round(txtTotal.Value, 2));

            }
            else
            {
                MyLib.Currency = "USD";
                MyLib.CurrencySymbol = "đô la";
                MyLib.UnitSecond = "cent";

                txtTotalText.Text = MyLib.ToText(Math.Round(Convert.ToDouble(colPayment.SummaryItem.SummaryValue) /
                                    Convert.ToDouble(txtExchange.Value), 2));

            }
        }

        private void txtCustomerID_EditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            txtCustomerName.EditValue = txtCustomerID.EditValue;
        }

        private void txtTotal_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //if (txtTotal.Value > txtDebt.Value) 
            //    txtTotal.Value = txtDebt.Value;
            
        }

        
    }


}


