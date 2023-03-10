using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Utils;
using Microsoft.VisualBasic;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.Dictionary.Customer;
using Perfect.Dictionary.UI;
using Perfect.Dictionary.UI.UBarcode;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.DS.dsPRODUCTTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Common.Forms;
using Perfect.Inventory.Core.Inventory.Outward.Report;
using Perfect.Inventory.Core.Inventory.Outward.dsCUSTOMERSTableAdapters;
using Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Net.Info;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Outward.Sale
{
    public partial class XucOutwardA : xucBaseB
    {
        #region Delegates

        public delegate void SuccessfullEvenhandler();

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
            DiscountRate = 17,
            Size = 18,
            Height = 19,
            Cost = 20
        }

        #endregion

        private Column _mColumn;

        private EnumRefType _part;
        private int _refStatus;

        public XucOutwardA(EnumRefType part)
        {
            _part = part;
            _mColumn = new Column();
            InitializeComponent();
            dtCreated.DateTime = MyLogin.LoginDate;
            txtDeliveryDate.DateTime = MyLogin.LoginDate;
            dtDueTime.DateTime = MyLogin.LoginDate;
            _exportView = gbList;
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
            _mColumn = Column.None;
            rpDate.DisplayFormat.FormatType = FormatType.Custom;
            rpDate.DisplayFormat.FormatString = Options.DateTime.FormatString;
            rpDate.EditFormat.FormatType = FormatType.Custom;
            rpDate.EditFormat.FormatString = Options.DateTime.FormatString;
            DoHide();
        }

        public void CustomerInit()
        {
            var adapter = new CUSTOMERTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsCUSTOMERS.CUSTOMER);

            txtCustomerName.Properties.View.ActiveFilterString = "ActiveInt = 1";
            txtCustomerID.Properties.View.ActiveFilterString = "ActiveInt = 1";
            txtCustomerName.Focus();


            var ad = new Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters.NOTESTableAdapter
            {
                Connection = { ConnectionString = SqlHelper.ConnectString }
            };
            ad.Fill(dsSTOCK_OUTWARD_DETAIL.NOTES);
            

        }

        public void StockInit()
        {
            Cursor.Current = Cursors.WaitCursor;
            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsSTOCK.STOCK);
            rpgStock.View.ActiveFilterString = "ActiveInt = 1";
            Cursor.Current = Cursors.Default;
        }

        public void SetStock(STOCK item)
        {
            //dsSTOCK.STOCK.AddSTOCKRow(item.Stock_Name, item.Stock_ID);
            StockInit();
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

        private void UnitInit()
        {
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString},
                                  ClearBeforeFill = true
                              };
            adapter.Fill(dsUnit.UNIT);

            rOUTETableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            rOUTETableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.ROUTE);

            cARSTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cARSTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.CARS);
        }

        public void SetCustomer(CUSTOMER item)
        {
            CustomerInit();
            //dsCUSTOMERS.CUSTOMER.AddCUSTOMERRow(item.CustomerName, item.Customer_ID);
            if (item.Active) txtCustomerName.EditValue = item.Customer_ID;
        }

        private new void Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu ....");
            Updated();

          
            rpgStock.ReadOnly = false;
            colStock_ID.OptionsColumn.ReadOnly = false;

            ucBarcode = new XucBaseBarcode(2);
            lcBarcode.Control = ucBarcode;
            lcBarcode.TextVisible = false;
            ucBarcode.ItemSelected += UcBarcodeItemSelected;


            _mColumn = Column.None;

            //if (CODE.TypeSoft < 400 & CODE.TypeSoft != 0)
            //{
            //    colUnit.OptionsColumn.AllowEdit = false;
            //}

            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            _exportView = gbList;

            SetWaitDialogCaption("Nạp hoàn thành....");
            Add();
            DoHide();
            Cursor.Current = Cursors.Default;
        }

        private void UcBarcodeItemSelected(object sender, Barcode item)
        {
            if (m_Status == Actions.None) return;

            var pro = new PRODUCT();
            var _unit = new UNIT();
            decimal price = 0;
            string size = "";

            if (pro.Get(item.Item.Product_ID) == "OK")
            {
                if (customerType == "0")
                {
                    price = Convert.ToDecimal(pro.Sale_Price);
                    size = "2";
                }
                else if (customerType == "1")
                {
                    price = Convert.ToDecimal(pro.Retail_Price);
                    size = "3";
                }
                _unit.Get(pro.Unit);
            }

            if (string.IsNullOrEmpty(size))
            {
                size = "5";
                price = GetPriceRecent(item.Item.Product_ID,item.Item.Unit);
            }

            if (item.Action == TypeAdd.Duplicate)
            {
                dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                    Guid.NewGuid(),
                    txtID.Text,
                    item.Item.Provider_ID,
                    2,
                    item.Item.Product_ID,
                    item.Item.Product_ID,
                    pro.ProductName,
                    pro.Product_Type_ID,
                    (int) item.Item.VAT_ID,
                    item.Item.Unit,
                    _unit.Unit_Name,
                    1,
                    Convert.ToDecimal(item.Quantity),
                    Convert.ToDecimal(item.Quantity),
                    price,
                    price,//price discount
                    price,// price vat
                    Convert.ToDecimal(item.Quantity) * price,// amount
                    Convert.ToDecimal(item.Quantity),
                    0,
                    0,
                    Convert.ToDecimal(item.Quantity) * price,
                    0,
                    0,
                    "",
                    "",
                    "",
                    "",
                    0,
                    0,
                    "",
                    size,
                    0,
                    "",
                    0,
                    true
                    );
                
            }
            else if (item.Action == TypeAdd.Add)
            {
                var dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
                bool add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    add = true;
                    double qty = Convert.ToDouble(dt.Rows[i]["Quantity"] ?? 0) + item.Quantity;
                    double uni = Convert.ToDouble(dt.Rows[i]["UnitPrice"] ?? 0);
                    dt.Rows[i]["Quantity"] = qty;
                    if (uni == 0)
                    {
                        dt.Rows[i]["UnitPrice"] = item.Price;
                        uni = item.Price;
                    }
                    dt.Rows[i]["Charge"] = uni * qty;

                    /*
                     * gbList.SetFocusedRowCellValue(gbList.Columns["DiscountRate"], 0);
                     * gbList.SetFocusedRowCellValue(gbList.Columns["Discount"], 0);
                     */

                    double discountRate = Convert.ToDouble(dt.Rows[i]["DiscountRate"] ?? 0);
                    double discount = ((uni * qty) / 100) * discountRate;

                    dt.Rows[i]["Discount"] = discount;
                    dt.Rows[i]["Amount"] = (uni * qty) - discount;
                    break;
                }

                if (!add)
                {
                    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                   Guid.NewGuid(),
                   txtID.Text,
                   item.Item.Provider_ID,
                   2,
                   item.Item.Product_ID,
                   item.Item.Product_ID,
                   pro.ProductName,
                   pro.Product_Type_ID,
                   (int)item.Item.VAT_ID,
                   item.Item.Unit,
                   _unit.Unit_Name,
                   1,
                   Convert.ToDecimal(item.Quantity),
                   Convert.ToDecimal(item.Quantity),
                   price,
                   price,//price discount
                   price,// price vat
                   Convert.ToDecimal(item.Quantity) * price,// amount
                   Convert.ToDecimal(item.Quantity),
                   0,
                   0,
                   Convert.ToDecimal(item.Quantity) * price,
                   0,
                   0,
                   "",
                   "",
                   "",
                   "",
                   0,
                   0,
                   "",
                   size,
                   0,
                   "",
                   0,
                   true
                   );
                    
                }
              
            }
            else if (item.Action == TypeAdd.Replace)
            {
                var dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
                bool add = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].RowState == DataRowState.Deleted) continue;
                    if (dt.Rows[i]["Product_ID"] == DBNull.Value) continue;
                    if (dt.Rows[i]["Product_ID"].ToString() != item.Item.Product_ID) continue;
                    add = true;
                    dt.Rows[i]["Quantity"] = item.Quantity;
                    dt.Rows[i]["UnitPrice"] = item.Price;
                    dt.Rows[i]["Charge"] = item.Amount;

                    double discountRate = Convert.ToDouble(dt.Rows[i]["DiscountRate"] ?? 0);
                    double discount = (item.Amount / 100) * discountRate;

                    dt.Rows[i]["Discount"] = discount;
                    dt.Rows[i]["Amount"] = item.Amount - discount;

                    //dt.Rows[i]["Amount"] = item.Amount;
                    break;
                }

                if (!add)
                {
                    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                   Guid.NewGuid(),
                   txtID.Text,
                   item.Item.Provider_ID,
                   2,
                   item.Item.Product_ID,
                   item.Item.Product_ID,
                   pro.ProductName,
                   pro.Product_Type_ID,
                   (int)item.Item.VAT_ID,
                   item.Item.Unit,
                   _unit.Unit_Name,
                   1,
                   Convert.ToDecimal(item.Quantity),
                   Convert.ToDecimal(item.Quantity),
                   price,
                   price,//price discount
                   price,// price vat
                   Convert.ToDecimal(item.Quantity) * price,// amount
                   Convert.ToDecimal(item.Quantity),
                   0,
                   0,
                   Convert.ToDecimal(item.Quantity) * price,
                   0,
                   0,
                   "",
                   "",
                   "",
                   "",
                   0,
                   0,
                   "",
                   size,
                   0,
                   "",
                   0,
                   true
                   );
                    
                }
            }
            else if (item.Action == TypeAdd.Single)
            {
                var dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;
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
                    dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                   Guid.NewGuid(),
                   txtID.Text,
                   item.Item.Provider_ID,
                   2,
                   item.Item.Product_ID,
                   item.Item.Product_ID,
                   pro.ProductName,
                   pro.Product_Type_ID,
                   (int)item.Item.VAT_ID,
                   item.Item.Unit,
                   _unit.Unit_Name,
                   1,
                   Convert.ToDecimal(item.Quantity),
                   Convert.ToDecimal(item.Quantity),
                   price,
                   price,//price discount
                   price,// price vat
                   Convert.ToDecimal(item.Quantity) * price,// amount
                   Convert.ToDecimal(item.Quantity),
                   0,
                   0,
                   Convert.ToDecimal(item.Quantity) * price,
                   0,
                   0,
                   "",
                   "",
                   "",
                   "",
                   0,
                   0,
                   "",
                   size,
                   0,
                   "",
                   0,
                   true
                   );
                }
                
            }
            Total();
        }

        private void TxtCustomerNamePropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Search")
            {
                //Nút tìm nhấn

                var xfmCustomers = new XfmCustomers(true);
                xfmCustomers.ItemSelected += XfmProvidersItemSelected;
                xfmCustomers.ShowDialog();
            }
            else if (e.Button.Tag.ToString() == "Add")
            {
                var customer = new CUSTOMER(txtCustomerID.Text, 0, txtCustomerName.Text, "", "", txtAddress.Text, "", "",
                                            "", txtTel.Text, "", "", "", "", "", "", "", "", "", "", "", "", "",
                                            "", 0, 0,true, "", true);

                var xfmCustomerAdd = new xfmCustomerAdd(customer);
                xfmCustomerAdd.Added += XfmCustomerAddAdded;
                xfmCustomerAdd.ShowDialog();
            }
        }

        private void XfmCustomerAddAdded(object sender, CUSTOMER item)
        {
            CustomerInit();
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private void XfmProvidersItemSelected(object sender, CUSTOMER item)
        {
            txtCustomerName.EditValue = item.Customer_ID;
        }

        private string customerType = "";


        private string _customerRegion;
        private void TxtCustomerIDEditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.EditValue == null) return;
            txtCustomerName.EditValue = txtCustomerID.EditValue;
            //CUSTOMER cus = new CUSTOMER();
            //cus.Get(Convert.ToString(txtCustomerID.EditValue));
            //txtDiscountRate.Value = Convert.ToDecimal(cus.Discount);
            //Total();
        }
        private void TxtCustomerNameEditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.EditValue == null) return;

            txtOldID.Text = "";
            txtOldDebt.Value = 0;
            txtOldDate.DateTime = DateTime.Now;
            txtOldNotes.Text = "";

            var cus = new CUSTOMER();
            if (cus.Get(txtCustomerName.EditValue.ToString()) == "OK")
            {
                txtCustomerID.Text = cus.Customer_ID;
                txtAddress.Text = cus.CustomerAddress;
                txtNotes.Text = cus.Description;             

                txtTel.Text = cus.Tel;
                customerType = cus.Customer_Type_ID;
                txtDiscountRate.Value = Convert.ToDecimal(cus.Discount);
                txtRoute.EditValue = cus.NickYM;
                

                _customerRegion = cus.Customer_Group_ID;
                SetEmpRegion(cus.Customer_Group_ID);
                

                /////
                
                if (Status == Actions.Add && cus.IsDebt == true)
                {
                    decimal oldDebt = GetTotalDebtCustomer(dtCreated.DateTime, dtCreated.DateTime, txtCustomerName.EditValue.ToString());
                    var cls = new STOCK_OUTWARD();
                    if (cls.GetLastInvoice(txtCustomerName.EditValue.ToString(), dtCreated.DateTime))
                    {
                        txtOldDebt.Value = oldDebt;
                        txtOldID.Text = cls.ID;
                        txtOldDate.DateTime = Convert.ToDateTime(cls.RefDate);
                        txtOldNotes.Text = cls.Description;
                    }

                    if (oldDebt > Convert.ToDecimal(cus.CreditLimit) && Convert.ToDecimal(cus.CreditLimit) > 0)
                    {
                        if (XtraMessageBox.Show("CÔNG NỢ: \n\nKhách hàng: " + txtCustomerName.Text + " đã vượt định mức công nợ cho phép."
                            + "\n\nĐịnh mức: " + cus.CreditLimit.ToString()
                            + "\n\nBạn có muốn tiếp tục không ?",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            txtCustomerName.EditValue = null;
                            txtCustomerID.EditValue = null;
                            txtAddress.Text = "";
                            txtTel.Text = "";

                            txtOldDebt.Value = 0;
                            txtOldID.Text = "";
                            txtOldNotes.Text = "";

                            return;
                        }
                    }

                    
                }
                
            } 
            
            Total(); 
            NotSave = true;
        }

        private void SetEmpRegion(string RegionID)
        {
            dsSTOCK_OUTWARD_DETAIL.EMP.Clear();

            string[] myPara = { "@RegionID" };
            object[] myValue = { RegionID };
            string sql = @"
                            SELECT e.Employee_Name           AS EmployeeName,
                                   e.O_Tel                   AS PhoneNumber,
                                   e.CreatedBy               AS ProductGroup,
                                   e.ModifiedBy              AS ProductGroup2
                            FROM   EMPLOYEE_REGION           AS er
                                   LEFT OUTER JOIN EMPLOYEE  AS e
                                        ON  er.EmployeeID = e.Employee_ID
                            WHERE  er.RegionID = @RegionID
                         ";
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            dsSTOCK_OUTWARD_DETAIL.EMP.Merge(mySql.ExecuteDataTable(sql, myPara, myValue));
        }

        private void TxtCustomerIDKeyDown(object sender, KeyEventArgs e)
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
                }
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

        private void TxtIDEditValueChanged(object sender, EventArgs e)
        {
            NotSave = true;

            var cls = new STOCK_OUTWARD();
            var txt = (TextEdit) sender;
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

        private void TxtIDLeave(object sender, EventArgs e)
        {
            var txt = (TextEdit) sender;
            if (m_Status == Actions.None) return;
            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
            }
            else
            {
                var stockInward = new STOCK_OUTWARD();

                if (m_Status == Actions.Add)
                {
                    if (!stockInward.Exist(txt.Text)) return;
                    Err.SetError(txt, "Mã đã tồn tại.");
                }
                else
                {
                    SetData(txtID.Text);
                }
            }
        }

        private void TxtIDKeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit) sender;
            if (txt.ErrorText != string.Empty)
            {
                txt.ErrorText = "";
                Err.SetError(txt, null);
            }
            if (e.KeyCode == Keys.Enter)
            {
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

        private string GetEmployeeList(string ProductGroupID, string CustomerGroupID)
        {
            string[] myPara = { "@ProductGroupID", "@CustomerGroupID" };
            object[] myValue = { ProductGroupID, CustomerGroupID };
            string sql = @"

DECLARE @Results NVARCHAR(500)
--DECLARE @ProductGroupID NVARCHAR(100)
--SET @ProductGroupID = 'NH000011' 

--DECLARE @CustomerGroupID NVARCHAR(100)
--SET @CustomerGroupID = 'T3h*P3'

DECLARE @CustomerGroupName NVARCHAR(100)
SET @CustomerGroupName = (SELECT cg.Customer_Group_Name
                            FROM CUSTOMER_GROUP AS cg WHERE cg.Customer_Group_ID = @CustomerGroupID)

SELECT @Results = COALESCE(@Results + ', ', '') + CONVERT(VARCHAR(12), e.Employee_ID)
FROM   EMPLOYEE AS e
WHERE  
       e.[Description] LIKE '%' +@CustomerGroupName + '%' 
       AND (e.Team_ID = @ProductGroupID OR e.PersonalTax_ID = @ProductGroupID)
ORDER BY
       e.Employee_ID

SELECT @Results AS EmployeeList                         ";

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return Convert.ToString(mySql.ExecuteScalar(sql, myPara, myValue));

        }

        private void ProductAdd(string id)
        {
            var pro = new PRODUCT();

            if (id == "") return;
            {
                if (pro.Get(id) == "OK")
                {

                    decimal price = 0;
                    if (customerType == "0")
                    {
                        price = Convert.ToDecimal(pro.Sale_Price);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Size"], 2);
                    }
                    else if (customerType == "1")
                    {
                        price = Convert.ToDecimal(pro.Retail_Price);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Size"], 3);
                    }
                    else
                    {
                        price = GetPriceRecent(id,pro.Unit);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Size"], 5);
                    }

                    gbList.SetFocusedRowCellValue(gbList.Columns["Product_Name"], pro.Product_Name);
                    gbList.SetFocusedRowCellValue(gbList.Columns["ItemID"], pro.Product_ID);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Product_ID"], pro.Product_ID);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Unit"], pro.Unit);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Quantity"], 1);
                    gbList.SetFocusedRowCellValue(gbList.Columns["UnitPrice"], price);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Amount"], price);
                    gbList.SetFocusedRowCellValue(gbList.Columns["UnitConvert"], 1);
                    
                    gbList.SetFocusedRowCellValue(gbList.Columns["Charge"], price);
                    gbList.SetFocusedRowCellValue(gbList.Columns["DiscountRate"], 0);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Discount"], 0);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Height"], pro.Depth);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Width"], pro.Depth);
                    gbList.SetFocusedRowCellValue(colPriceDiscount, price);
                    gbList.SetFocusedRowCellValue(colPriceVat, price);

                    //string dateNow = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    gbList.SetFocusedRowCellValue(gbList.Columns["Batch"], DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    gbList.SetFocusedRowCellValue(gbList.Columns["IME"], DateTime.Now.ToString("dd/MM/yyyy"));

                    gbList.SetFocusedRowCellValue(gbList.Columns["Cost"], pro.Thickness);
                    gbList.SetFocusedRowCellValue(gbList.Columns["Profit"], pro.Thickness);

                    gbList.SetFocusedRowCellValue(gbList.Columns["Stock_ID"], pro.Provider_ID);

                    gbList.SetFocusedRowCellValue(gbList.Columns["Orgin"],GetEmployeeList(pro.Product_Group_ID, _customerRegion)); ;

                    if (gbList.FocusedRowHandle == (gbList.RowCount)) gbList.AddNewRow();
                    //gbList.UpdateSummary();
                    Total();
                }
            }
        }

        public void ProductAdd(PRODUCT item)
        {
            UNIT _unit = new UNIT();
            _unit.Get(item.Unit);
            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                   Guid.NewGuid(),
                   txtID.Text,
                   item.Provider_ID,
                   2,
                   item.Product_ID,
                   item.Product_ID,
                   item.ProductName,
                   item.Product_Type_ID,
                   (int)item.VAT_ID,
                   item.Unit,
                   _unit.Unit_Name,
                   1,
                   1,
                   1,
                   Convert.ToDecimal(item.Sale_Price),
                   Convert.ToDecimal(item.Sale_Price),//price discount
                   Convert.ToDecimal(item.Sale_Price),// price vat
                   Convert.ToDecimal(item.Sale_Price),// amount
                   1,
                   0,
                   0,
                   Convert.ToDecimal(item.Sale_Price),
                   0,
                   0,
                   "",
                   "",
                   "",
                   "",
                   0,
                   0,
                   "",
                   "5",
                   0,
                   "",
                   0,
                   true
                   );
        }

        private void Total()
        {
            CalcSale();
            //txtTotalAmount.Value = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
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
            txtID.Text = cls.CreateKey("BH_" + MyLogin.Account + "_");
            txtID.Properties.ReadOnly = false;

            dtCreated.EditValue = DateTime.Now;
            txtDeliveryDate.EditValue = DateTime.Now;

            txtCarNumber.EditValue = null;

            txtCustomerID.EditValue = null;
            txtCustomerName.EditValue = null;

            txtDescription.Text = "";

            txtOldID.Text = "";
            txtOldDebt.Value = 0;
            txtOldDate.DateTime = DateTime.Now;
            txtOldNotes.Text = "";
            txtTotal.Value = 0;

            txtRoute.EditValue = null;
            txtNotes.Text = "";
           
            CalcSale0();
            DisableControl(false);
            
            Updated();
            
            NotSave = false;
            Status = Actions.Add;

            
            txtAddress.Text = "";
            txtTel.Text = "";
            
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
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
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

            if (txtOldDebt.Value < 0)
            {
                XtraMessageBox.Show("Công nợ không được nhỏ hơn 0.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtOldDebt.Focus();
                return false;
            }

            if (dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Rows.Count == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public override void DisableControl(bool disable)
        {
            gcList.Enabled = !disable;

            Bar.Bar.bbiCancel.Enabled = !disable;
            Bar.Bar.bbiSave.Enabled = !disable;
            Bar.Bar.bbiSaveNew.Enabled = !disable;
            Bar.Bar.bbiSaveM.Enabled = !disable;
        }

        public void Updated()
        {
            CashMethodInit();
            CashTermInit();
            StockInit();
            UnitInit();
            EmpInit();
            CustomerInit();
            ProductInit();
            
            
            

        }

        private void CashMethodInit()
        {
            cASH_METHODTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cASH_METHODTableAdapter.Fill(dsSaleDic.CASH_METHOD);
            if (txtMethod.Text == "")
            {
                if (dsSaleDic.CASH_METHOD.Rows.Count > 0)
                {
                    txtMethod.EditValue = dsSaleDic.CASH_METHOD.Rows[0]["ID"];
                }
            }
        }

        private void CashTermInit()
        {
            cASH_TERMTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cASH_TERMTableAdapter.Fill(dsSaleDic.CASH_TERM);
            if (txtTerm.Text == "")
                if (dsSaleDic.CASH_TERM.Rows.Count > 0)
                    txtTerm.EditValue = dsSaleDic.CASH_TERM.Rows[0]["ID"];
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

        private bool DetailCheck()
        {
            if (gbList.RowCount - 1 == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể lưu được.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return false;
            }

            var dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;

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
                    XtraMessageBox.Show("Kho hàng xuất không đúng.\n\tDòng số: " + (j), "Cảnh Báo", MessageBoxButtons.OK,
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
                    gbList.SetColumnError(colUnit, "Đơn vị tính không đúng");
                    return false;
                }
            }
            return true;
        }


        public delegate void CheckBarcodeEvenhandler(object sender, bool chk);

        public event CheckBarcodeEvenhandler CheckBarcode;

        public void OnCheckBarcode(bool chk)
        {
            CheckBarcodeEvenhandler handler = CheckBarcode;
            if (handler != null) handler(this, chk);
        }


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
                MyRule.Notify();
                return ""; 
            }

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            SysLog.Insert("Phiếu Xuất", "Thêm", txtID.Text);

            if (!DetailCheck()) return "";

            if (CODE.TypeSoft == 0 || CODE.TypeSoft == 1)
            {
                if (INVENTORY_DETAIL.Count > INVENTORY_DETAIL.LimitRecord)
                {
                    DoHide();
                    CODE.Notify();
                    return "Phần mềm bị giới hạn dữ liệu, vui lòng đăng ký phiên bản thu phí.";
                }
            }

            Total();

            STOCK_OUTWARD cls = new STOCK_OUTWARD();
            if (cls.Get(txtID.Text))
            {
                if (XtraMessageBox.Show("Mã phiếu đã tồn tại. Bạn có muốn tạo mã mới không!?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return "";
                cls.CreateKey("BH_" + MyLogin.Account + "_");
                return "";
            }
           
            SetWaitDialogCaption("Đang lưu dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;

            var mySql = new SqlHelper();

            string result = mySql.Start();
            if (result != "OK")
            {
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            cls = new STOCK_OUTWARD(
                txtID.Text,
                dtCreated.DateTime,
                txtOldID.Text,
                (int) _part, // xuất kho thường
                0,//Convert.ToString(txtTerm.EditValue) == "TM" ? 1 : 0,
                txtMethod.EditValue.ToString(),
                txtTerm.EditValue.ToString(),
                dtDueTime.DateTime,
                txtDeliveryDate.DateTime,
                txtID.Text,

                (txtRoute.EditValue ?? "").ToString(),

                Convert.ToString(txtEmployee.EditValue),

                "",// PrintOptionInfo

                (txtCarNumber.EditValue ?? "").ToString(),

                "",

                txtCustomerID.Text,
                txtCustomerName.Text,
                txtAddress.Text,
                txtOldNotes.Text,
                txtOldID.Text.Trim(),// Invoice
                0,
                "VND",
                1,
                Convert.ToInt32(txtVatRate.Value),
                Convert.ToDecimal(txtVatAmount.Value),
                Convert.ToDecimal(txtTotalAmount.Value),
                Convert.ToDecimal(txtTotalAmount.Value),
                txtOldDate.DateTime,
                Convert.ToDecimal(txtDiscountRate.Value),
                Convert.ToDecimal(txtDiscount.Value),
                Convert.ToDecimal(txtOldDebt.Value),
                Convert.ToDecimal(txtTotal.Value),
                0,
                
                Convert.ToDecimal(colProfit.SummaryItem.SummaryValue), // Tổng khối lượng

                MyLogin.UserId,
                false,
                0,
                (txtDescription.EditValue ?? "").ToString(),
                txtNotes.Text.Trim(),
                true);


            if (!cls.Insert(mySql.Transaction))
            {
                result = mySql.Result;
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            //
            //if (Convert.ToString(txtTerm.EditValue) == "TM")
            //{
            //    result = DebtInsert(mySql);
            //    if (result != "OK")
            //    {
            //        mySql.RollBack();
            //        DoHide();
            //        XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return result;
            //    }
            //}
            //

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
            DoHide();
            //Cancel();
            //SetData(txtID.Text);
            Add();
            return result;
        }

        private string DebtInsert(SqlHelper sql)
        {
            DEBT_OUTWARD debt = new DEBT_OUTWARD();
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
            CUSTOMER_RECEIPT_OUTWARD cro = new CUSTOMER_RECEIPT_OUTWARD();
            string PhieuThuID = cro.NewID(sql.Transaction, "PTN." + MyLogin.Account + ".");
            
            result = cro.Insert(
                sql.Transaction,
                _id,
                PhieuThuID,
                dtCreated.DateTime,
                txtID.Text,
                41,
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
            if (!result) return "Có lỗi xãy ra trong quá trình cập nhật phiếu thu. Vui lòng chọn thanh toán là 'Công nợ'";

            Guid detailID = Guid.NewGuid();
            CUSTOMER_RECEIPT_DETAIL_OUTWARD crdo = new CUSTOMER_RECEIPT_DETAIL_OUTWARD();
            result = crdo.Insert(sql.Transaction,
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
                txtCustomerName.Text,
                0);
            if (!result) return "Không thể cập nhật vào bảng công nợ. Vui lòng chọn thanh toán là 'Công nợ'";
            return "OK";
        }


        //'Negative'
        private bool IsNegativeWarehouse()
        {
            string[] myPara = { "@OptionName" };
            object[] myValue = { "Negative" };
            string sql = @"
                            SELECT so.[System] AS OptionValue
                            FROM   SYS_OPTION AS so
                            WHERE  so.Option_ID = @OptionName
                         ";
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return Convert.ToBoolean(mySql.ExecuteScalar(sql, myPara, myValue));

        }

        private string DetailSave(SqlHelper sql)
        {
            string result = "OK";
            var cls = new STOCK_OUTWARD_DETAIL();
            var pro = new PRODUCT();
            double qty = 0.0;

            bool checkNegative = IsNegativeWarehouse();

            var dt = dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL;

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

                    if (Convert.ToDecimal(dt.Rows[i]["Quantity"]) == 0)
                    {
                        DoHide();
                        sql.RollBack();
                        XtraMessageBox.Show("Vui lòng nhập số lượng xuất.\n\tDòng thứ : " + (i + 1), "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return "Không thể lưu thông tin phiếu này.";
                    }


                    pro.Product_ID = dt.Rows[i]["Product_ID"].ToString();
                    pro.Provider_ID = dt.Rows[i]["Stock_ID"].ToString();
                    qty = Convert.ToDouble(dt.Rows[i]["Quantity"]);
                    
                    
                    ///////////////////////////////////////////////////////////
                    // KIEM TRA XUAT KHO AM
                    //////////////////////////////////////////////////////////
                    #region KIEM TRA XUAT KHO AM                    
                    
                   if (pro.GetProductInventory(sql.Transaction, pro.Product_ID, pro.Provider_ID) == "OK")
                    {
                        double qtyOld = dt.Rows[i].RowState == DataRowState.Modified ||
                                        dt.Rows[i].RowState == DataRowState.Unchanged
                                            ? Convert.ToDouble(dt.Rows[i]["Quantity", DataRowVersion.Original])
                                            : 0;

                        double cal = qty - (qtyOld + pro.Quantity);

                        if (pro.Product_Type_ID != 1)
                        {
                            if (cal > 0)
                            {
                                //DoHide();
                                //sql.RollBack();

                                //string mess = "Mã hàng " + pro.Product_ID + " đã xuất quá số lượng tồn."
                                //    + "\nTồn kho hiện tại là: " + pro.Quantity
                                //    + "\nDòng số: " + row;
                                //gbList.FocusedRowHandle = row - 1;

                                //gbList.SetColumnError(colQuantity, "Xuất kho vượt quá số lượng tồn. Tồn kho hiện tại: " + pro.Quantity);
                                //return mess;


                                if (SysOption.Negative)
                                {
                                    DoHide();
                                    if (XtraMessageBox.Show("Mặt Hàng: " + pro.Product_Name.ToUpper() +
                                                            " đã xuất quá số lượng tồn.\nSố lượng tồn hiện tại là: " +  pro.Quantity +  
                                                            " \nNếu công việc thực hiện sẽ dẫn đến tồn kho bị âm.\nBạn chắc chắn muốn thực hiện công việc này không ?",
                                                            "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                    {
                                        sql.RollBack();
                                        return "Không thể lưu thông tin phiếu này.";
                                    }
                                }
                                else
                                {
                                    DoHide();
                                    sql.RollBack();
                                    XtraMessageBox.Show(
                                        "Mặt hàng này đã xuất vượt quá số lượng tồn.\n\tDòng thứ : " + row,
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    gbList.FocusedRowHandle = row;
                                    gbList.SetColumnError(colQuantity, "Mặt hàng này đã xuất vượt quá số lượng tồn");
                                    return "Không thể lưu thông tin phiếu này.";

                                }
                            }
                        }
                    }
                   
                    
                         
                     

                    #endregion
                     

                    id = dt.Rows[i]["ID"].ToString();
                }

                SetWaitDialogCaption("Đang lưu dữ liệu...");

                if (dt.Rows[i].RowState == DataRowState.Added)
                {
                    decimal width = Math.Round(Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),3);
                    decimal Height = Math.Round(Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]), 3);

                    if (!cls.Insert
                    (
                        sql.Transaction,
                        Guid.NewGuid().ToString(),
                        txtID.Text,
                        Convert.ToString(dt.Rows[i]["Stock_ID"]),
                        (int)_part,
                        Convert.ToString(dt.Rows[i]["Product_ID"]),
                        Convert.ToString(dt.Rows[i]["Product_Name"]),
                        0,
                        0,
                        Convert.ToString(dt.Rows[i]["Unit"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : dt.Rows[i]["DiscountRate"]),
                        Convert.ToDecimal(dt.Rows[i]["Discount"] == DBNull.Value ? 0 : dt.Rows[i]["Discount"]),
                        Convert.ToDecimal(dt.Rows[i]["Charge"] == DBNull.Value ? 0 : dt.Rows[i]["Charge"]),

                        Math.Round(Convert.ToDecimal(dt.Rows[i]["Cost"] == DBNull.Value ? 0 : dt.Rows[i]["Cost"])), // Cost: Số khối
                        Math.Round(Convert.ToDecimal(dt.Rows[i]["Profit"] == DBNull.Value ? 0 : dt.Rows[i]["Profit"])), // Profit: Tổng số khối
                        
                        Convert.ToString(dt.Rows[i]["Batch"] == DBNull.Value ? "" : dt.Rows[i]["Batch"]), 

                        dt.Rows[i]["Serial"].ToString(),
                        Convert.ToString(dt.Rows[i]["ChassyNo"] == DBNull.Value ? "" : dt.Rows[i]["ChassyNo"]),
                        Convert.ToString(dt.Rows[i]["IME"] == DBNull.Value ? "" : dt.Rows[i]["IME"]),
                        width,//Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),
                        Height,//Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]), //Convert.ToDouble(gbList.GetRowCellValue(i, "ChargeTransport")),

                        Convert.ToString(dt.Rows[i][colOrgin.FieldName] == DBNull.Value ? "" : dt.Rows[i][colOrgin.FieldName]),// Thong tin
                        
                        Convert.ToString(dt.Rows[i]["Size"]),
                        0,
                        Convert.ToString(dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"]),
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
                    decimal width = Math.Round(Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]), 3);
                    decimal Height = Math.Round(Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]), 3);
                    
                    if (!cls.Update(
                        sql.Transaction,
                        id,
                        txtID.Text,
                        Convert.ToString(dt.Rows[i]["Stock_ID"]),
                        (int)_part,
                        Convert.ToString(dt.Rows[i]["Product_ID"]),
                        Convert.ToString(dt.Rows[i]["Product_Name"]),
                        0,
                        0,
                        Convert.ToString(dt.Rows[i]["Unit"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitConvert"] == DBNull.Value ? 0 : dt.Rows[i]["UnitConvert"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[i]["UnitPrice"]),
                        Convert.ToDecimal(dt.Rows[i]["Amount"] == DBNull.Value ? 0 : dt.Rows[i]["Amount"]),
                        Convert.ToDecimal(dt.Rows[i]["Quantity"] == DBNull.Value ? 0 : dt.Rows[i]["Quantity"]),
                        Convert.ToDecimal(dt.Rows[i]["DiscountRate"] == DBNull.Value ? 0 : dt.Rows[i]["DiscountRate"]),
                        Convert.ToDecimal(dt.Rows[i]["Discount"] == DBNull.Value ? 0 : dt.Rows[i]["Discount"]),
                        Convert.ToDecimal(dt.Rows[i]["Charge"] == DBNull.Value ? 0 : dt.Rows[i]["Charge"]),

                        Math.Round(Convert.ToDecimal(dt.Rows[i]["Cost"] == DBNull.Value ? 0 : dt.Rows[i]["Cost"])), // Cost: Số khối
                        Math.Round(Convert.ToDecimal(dt.Rows[i]["Profit"] == DBNull.Value ? 0 : dt.Rows[i]["Profit"])), // Profit: Tổng số khối
                        
                        Convert.ToString(dt.Rows[i]["Batch"] == DBNull.Value ? "" : dt.Rows[i]["Batch"]), 
                        dt.Rows[i]["Serial"].ToString(),
                        Convert.ToString(dt.Rows[i]["ChassyNo"] == DBNull.Value ? "" : dt.Rows[i]["ChassyNo"]),
                        Convert.ToString(dt.Rows[i]["IME"] == DBNull.Value ? "" : dt.Rows[i]["IME"]),
                        width,//Convert.ToDecimal(dt.Rows[i]["Width"] == DBNull.Value ? 0 : dt.Rows[i]["Width"]),
                        Height,//Convert.ToDecimal(dt.Rows[i]["Height"] == DBNull.Value ? 0 : dt.Rows[i]["Height"]), //Convert.ToDouble(gbList.GetRowCellValue(i, "ChargeTransport")),
                        
                        Convert.ToString(dt.Rows[i][colOrgin.FieldName] == DBNull.Value ? "" : dt.Rows[i][colOrgin.FieldName]),// Thong tin
                        
                        Convert.ToString(dt.Rows[i]["Size"]),
                        0,
                        Convert.ToString(dt.Rows[i]["Description"] == DBNull.Value ? "" : dt.Rows[i]["Description"]),
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



        private string _printOptionInfo;

        public new void SetData(string table)
        {
            var cls = new STOCK_OUTWARD();
            if (cls.Get(table))
            {
                Status = Actions.Change;
                DisableControl(false);

                if (Status == Actions.Change)
                {
                    txtID.Properties.ReadOnly = true;
                    txtID.Text = cls.ID;
                }

                _printOptionInfo = cls.Stock_ID;

                txtEmployee.EditValue = cls.Employee_ID;
                dtCreated.DateTime = cls.RefDate;
                txtID.Properties.ReadOnly = true;
                txtCustomerName.EditValue = cls.Customer_ID;
                txtDescription.EditValue = cls.Description;
                txtCarNumber.EditValue = cls.Branch_ID;

                txtRoute.EditValue = cls.Department_ID;

                _refStatus = cls.RefStatus;

                txtTerm.EditValue = cls.TermID;
                txtMethod.EditValue = cls.PaymentMethod;
                dtDueTime.DateTime = cls.PaymentDate;
                txtDeliveryDate.DateTime = cls.DeliveryDate;
                txtOldID.Text = cls.Reason;
                txtTotalAmount.Value = cls.Amount;

                var adapter = new STOCK_OUTWARD_DETAILTableAdapter
                                  {Connection = {ConnectionString = SqlHelper.ConnectString}};
                adapter.Fill(dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL, txtID.Text);

                txtDiscountRate.Value = cls.DiscountRate;
                txtVatRate.Value = cls.Vat;

                txtDiscount.Value = cls.Discount;
                txtVatAmount.Value = cls.VatAmount;

                txtOldDebt.Value = cls.OtherDiscount;
                txtOldID.Text = cls.Ref_OrgNo;
                txtOldDate.DateTime = Convert.ToDateTime(cls.DiscountDate);
                txtOldNotes.Text = cls.Reason;

                txtNotes.Text = cls.Notes;

                txtTotal.Value = cls.Charge;
                Updated();
                NotSave = false;
            }
        }

        public override string uc_Change()
        {

            gbList.FocusedRowHandle = gbList.FocusedRowHandle + 1;
            gbList.UpdateCurrentRow();

            if (!MyRule.IsEdit("bbiSale")) 
            {
                MyRule.Notify();
                return ""; 
            }

            if (_refStatus == 1)
            {
                XtraMessageBox.Show("Không thể thay đổi thông tin phiếu này.\n\n Phiếu này đã được thu tiền.",
                                    "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            SysLog.Insert("Phiếu Xuất", "Cập Nhật", txtID.Text);

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
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            var cls = new STOCK_OUTWARD(
                txtID.Text,
                dtCreated.DateTime,
                txtOldID.Text,
                (int) _part, // xuất kho thường
                0,//Convert.ToString(txtTerm.EditValue) == "TM" ? 1 : 0, // RefStatus
                txtMethod.EditValue.ToString(),
                txtTerm.EditValue.ToString(),
                dtDueTime.DateTime,
                txtDeliveryDate.DateTime,
                txtID.Text,
                (txtRoute.EditValue ?? "").ToString(),
                Convert.ToString(txtEmployee.EditValue),

                _printOptionInfo, //PrintOptionInfo
                (txtCarNumber.EditValue ?? "").ToString(),             
                
                "",

                txtCustomerID.Text,
                txtCustomerName.Text,
                txtAddress.Text,

                txtOldNotes.Text,

                txtOldID.Text.Trim(),// Invoice
                0,
                "VND",
                1,
                Convert.ToInt32(txtVatRate.Value),
                Convert.ToDecimal(txtVatAmount.Value),
                Convert.ToDecimal(txtTotalAmount.Value),
                Convert.ToDecimal(txtTotalAmount.Value),
                txtOldDate.DateTime,
                Convert.ToDecimal(txtDiscountRate.Value),
                Convert.ToDecimal(txtDiscount.Value),
                Convert.ToDecimal(txtOldDebt.Value),
                Convert.ToDecimal(txtTotal.Value),
                0,

                Convert.ToDecimal(colProfit.SummaryItem.SummaryValue), // Tổng khối lượng
                
                MyLogin.UserId,
                false,
                0,
                (txtDescription.EditValue ?? "").ToString(),
                txtNotes.Text.Trim(),
                true);

            if (!cls.Update(mySql.Transaction))
            {
                result = mySql.Result;
                DoHide();
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            //
            //if (Convert.ToString(txtTerm.EditValue) == "TM")
            //{
            //    result = DebtInsert(mySql);
            //    if (result != "OK")
            //    {
            //        mySql.RollBack();
            //        DoHide();
            //        XtraMessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return result;
            //    }
            //}
            //

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

        // Tinh cong no theo thoi gian - Ban chuan
        private decimal GetDebtCustomer(string customerID, DateTime RefDate)
        {
            string[] myPara = { "@CustomerID", "@RefDate" };
            object[] myValue = { customerID, RefDate };
            string sql = @"SELECT CASE 
            WHEN SUM(d.TotalDebt) IS NULL THEN 0
            ELSE SUM(d.TotalDebt)
       END AS TotalDebt
FROM   (
           SELECT SUM(d.Amount) AS TotalDebt
           FROM   DEBT d
           WHERE  d.RefStatus = 0
                  AND d.TermID = 'CN'
                  AND d.CustomerID = @CustomerID
                  AND d.RefDate < @RefDate
           UNION ALL
           SELECT (cr.Amount * -1) AS RealAmount
           FROM   CUSTOMER_RECEIPT cr
           WHERE  cr.RefDate < @RefDate
                  AND cr.CustomerID = @CustomerID
       )d";
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return Convert.ToDecimal(mySql.ExecuteScalar(sql, myPara, myValue));

        }

        private string GetProductGroup(string productID)
        {
            string[] myPara = { "@Product_ID" };
            object[] myValue = { productID};
            string sql = @"SELECT pg.ProductGroup_Name
FROM   PRODUCT p
       LEFT OUTER JOIN PRODUCT_GROUP pg
            ON  p.Product_Group_ID = pg.ProductGroup_ID
WHERE  p.Product_ID = @Product_ID";
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return (mySql.ExecuteScalar(sql, myPara, myValue)).ToString();

        }
        private void Print(bool preview)
        {
            if (!MyRule.IsPrint("bbiSale")) 
            {
                MyRule.Notify();
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
            if (gbList.RowCount - 1 == 0)
            {
                XtraMessageBox.Show("Phiếu này rỗng không thể in được.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            SysLog.Insert("Phiếu Bán Hàng", "In");

            CUSTOMER c = new CUSTOMER();
            c.Get(txtCustomerID.Text);

            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.Rows.Clear();

            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD.AddSTOCK_OUTWARDRow(
                txtID.Text,
                dtCreated.DateTime,
                txtCustomerID.Text,
                "",
                "Xuất Kho",
                chxIsPrint.Checked,
                chxBarcode.Checked,
                "",
                txtCustomerName.Text,
                txtAddress.Text,
                txtTel.Text,
                c.Fax,
                c.Tax,
                Convert.ToString(txtTerm.EditValue),
                txtTerm.Text,
                Convert.ToString(txtMethod.EditValue),
                txtMethod.Text,
                txtTotalAmount.Value,
                txtDescription.Text,
                2,
                false,
                txtDeliveryDate.DateTime,
                Convert.ToInt32(txtVatRate.Value), 
                txtVatAmount.Value,
                0, 
                txtDiscountRate.Value,
                txtDiscount.Value,
                txtEmployee.Text
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


            foreach (DataRow row in dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Rows)
            {
                row[colOrgin.FieldName] = GetProductGroup(row[colProduct_ID.FieldName].ToString());
            }

            

            DoHide();


            //decimal oldDebt = GetDebtCustomer((txtCustomerName.EditValue ?? "").ToString(),dtCreated.DateTime);
            decimal totalDebt = txtOldDebt.Value + txtTotalAmount.Value;

            int option = 0;
            xfmPrintOptionsOutward frm = new xfmPrintOptionsOutward();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.OptionsSelected += (opt) =>
            {
                option = opt;
            };
            frm.ShowDialog();
            
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            decimal width = Math.Round(Convert.ToDecimal(colWidth.SummaryItem.SummaryValue),3);
            switch (option)
            {
                case 1:
                    {
                        var rpt = new rptStockOutwardA4(dsSTOCK_OUTWARD_DETAIL, "RD0000022", "PHIẾU BÁN HÀNG",
                                            Strings.Format(dtCreated.DateTime, "dd/MM/yyyy"), txtVatAmount.Value,
                                            txtTotalAmount.Value, 0, txtTel.Text,amount,width, txtOldDebt.Value, totalDebt, txtOldID.Text.Trim());
                        rpt.ShowPreview();
                    }
                    break;
                case 2:
                    {
                        var rpt = new rptStockOutwardA402(dsSTOCK_OUTWARD_DETAIL, "RD0000022", "PHIẾU BÁN HÀNG",
                                            Strings.Format(dtCreated.DateTime, "dd/MM/yyyy"), txtVatAmount.Value,
                                            txtTotalAmount.Value, 0, txtTel.Text, amount, width, txtOldDebt.Value, totalDebt, txtOldID.Text.Trim());
                        rpt.ShowPreview();
                    }
                    break;
                case 3:
                    {
                        var rpt = new rptStockOutward_Bill80mm(dsSTOCK_OUTWARD_DETAIL, txtTotalAmount.Value);
                        rpt.CreateDocument();

                        int PgCount = rpt.Pages.Count * 8 / 9;
                        float Height = rpt.PageHeight * PgCount;
                        var rptReal = new rptStockOutward_Bill80mm(dsSTOCK_OUTWARD_DETAIL, txtTotalAmount.Value);
                        rptReal.PageHeight = Convert.ToInt32(Height);
                        rptReal.ShowPreview();
                    }
                    break;
                case 4:
                    {
                        //Process.Start("https://admin.dmshongdanh.com/1app/indon/donhang.php?dh=" + txtID.Text + "&giay=a4");

                        Process.Start(MyInfo.WebSite + txtID.Text + "&giay=a4");
                    }
                    break;
                default:
                    ////Process.Start("https://admin.dmshongdanh.com/1app/indon/donhang.php?dh=" + txtID.Text + "&giay=a4");
                    Process.Start(MyInfo.WebSite + txtID.Text + "&giay=a4");
                    break;
            }

        }

        public override void Print()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Print(true);
            DoHide();
        }
       
        private void DoShowMenu(GridHitInfo hi)
        {
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                GridViewMenu menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }

        private void ChxBarcodeCheckedChanged(object sender, EventArgs e)
        {
            lcBarcode.Visibility = chxBarcode.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            OnCheckBarcode(chxBarcode.Checked);
        }

        protected override void F3Execute()
        {
            txtCustomerName.Focus();
            txtCustomerName.ShowPopup();
        }

        private void TxtCustomerNameCloseUp(object sender, CloseUpEventArgs e)
        {
            //if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void CbxStockCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpgProductCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpProductNameCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
        }

        private void RpUnitCloseUp(object sender, CloseUpEventArgs e)
        {
            if (sender != null) ((GridLookUpEdit) sender).Properties.View.ClearColumnsFilter();
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



       

        private void TxtCustomerIDKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtCustomerName.Focus();
            }
        }

        private void TxtCustomerNameKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtAddressKeyPress(object sender, KeyPressEventArgs e)
        {

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
            Total();
        }

        

        private void CalcSale()
        {
            decimal amount;
            decimal vatAmount;
            decimal discount;

            amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            vatAmount = amount * (Convert.ToDecimal(txtVatRate.Value)) / 100;
            discount = amount * (Convert.ToDecimal(txtDiscountRate.Value)) / 100;

            txtVatAmount.Value = vatAmount;
            txtDiscount.Value = discount;
            txtTotalAmount.Value = amount + vatAmount - discount;

            txtTotal.Value = txtTotalAmount.Value + txtOldDebt.Value;
        }

        private void CalcSale0()
        {
            txtVatRate.Value = 0;
            txtDiscountRate.Value = 0;
            txtTotalAmount.Value = 0;
        }

        #region Grid

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
            Total();
            Bar.Bar.bbiProduct.Enabled = true;
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
            Total();
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
            if (_mColumn == Column.Lock) return;
            gbList.ClearColumnErrors();

            gbList.UpdateCurrentRow();
            Total();
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
                else if(e.Column.FieldName == "Discount")
                {
                    _mColumn = Column.Discount;
                }
                else if(e.Column.FieldName == "DiscountRate")
                {
                    _mColumn = Column.DiscountRate;
                }
                else if (e.Column.FieldName == "Size")
                {
                    _mColumn = Column.Size;
                
                }
                else if (e.Column.FieldName == "Height")
                {
                    _mColumn = Column.Height;

                }
                else if (e.Column.FieldName == "Cost")
                {
                    _mColumn = Column.Cost;

                }
            }

            if (_mColumn == Column.None) return;


            switch (_mColumn)
            {
                case Column.Size:
                    {
                        _mColumn = Column.Lock;
                        gbList.SetColumnError(colSize, null);
                        decimal price = 0;
                        if (string.IsNullOrEmpty(e.Value.ToString()))
                        {
                            gbList.SetRowCellValue(e.RowHandle, "Size", 0);
                            //return;
                        }
                        var product = new PRODUCT();
                        var productID = gbList.GetRowCellValue(e.RowHandle, "Product_ID") == null
                                            ? ""
                                            : gbList.GetRowCellValue(e.RowHandle, "Product_ID").ToString();

                        var customerID = txtCustomerName.EditValue == null
                                             ? ""
                                             : txtCustomerName.EditValue.ToString();
                        var m_unit = gbList.GetRowCellValue(e.RowHandle, "Unit");
                        var unitconvert = new PRODUCT_UNIT();
                        var conv = gbList.GetRowCellValue(e.RowHandle, "UnitConvert");
                        decimal convert = Convert.ToDecimal(conv);
                        var m_price = GetPrice(customerID, productID, string.IsNullOrEmpty(e.Value.ToString()) ? 0 : Convert.ToInt32(e.Value),m_unit.ToString());
                        
                        if (product.Get(productID.ToString()) == "OK")
                        {
                            if (e.Value != null)
                            {
                                if (Convert.ToString(m_unit) != product.Unit)
                                {
                                    if (e.Value.ToString() == "1" | e.Value.ToString() == "2" | e.Value.ToString() == "3")
                                    {
                                        price = Convert.ToDecimal(m_price * convert);
                                    }
                                    if (e.Value.ToString() == "4" | e.Value.ToString() == "5")
                                    {
                                        price = Convert.ToDecimal(m_price);
                                    }
                                }
                                if (Convert.ToString(m_unit) == product.Unit)
                                {
                                    price = Convert.ToDecimal(m_price);
                                }
                            }
                        }
                        var discountRateTemp = gbList.GetRowCellValue(e.RowHandle, "DiscountRate");
                        var qtyTemp = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        var discountRate = Convert.ToDecimal(discountRateTemp == DBNull.Value ? 0 : discountRateTemp);
                        var quantity = Convert.ToDecimal(qtyTemp == DBNull.Value ? 0 : qtyTemp);

                        var discount = ((quantity * price) / 100) * discountRate;
                        var amount = (quantity * price) - discount;


                        gbList.SetRowCellValue(e.RowHandle, "UnitPrice", price);
                        gbList.SetRowCellValue(e.RowHandle, "Charge", (quantity * price));
                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                        gbList.SetFocusedRowCellValue(colPriceDiscount, price - price * discountRate / 100);
                        gbList.SetFocusedRowCellValue(colPriceDiscount, price - price * discountRate / 100);
                        Total();
                        _mColumn = Column.None;
                        
                    }
                    break;
                case Column.DiscountRate:
                    {
                        _mColumn = Column.Lock;
                        decimal DRate = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value);
                        decimal Price = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colUnitPrice));
                        decimal charge = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colCharge));
                        decimal amount = charge - charge * DRate / 100;



                        gbList.SetFocusedRowCellValue(colDiscountRate, DRate);
                        gbList.SetFocusedRowCellValue(colDiscount, charge * DRate / 100);
                        gbList.SetFocusedRowCellValue(colPriceDiscount, Price - Price * DRate / 100);
                        gbList.SetFocusedRowCellValue(colPriceVat, Price - Price * DRate / 100);
                        gbList.SetFocusedRowCellValue(colAmount, amount);
                         
                        _mColumn = Column.None;
                        break;
                    }
                case Column.Discount:
                    {
                        _mColumn = Column.Lock;
                        decimal Price = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colUnitPrice));
                        decimal charge = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colCharge));
                        decimal Discount = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value);
                        decimal DRate = charge == 0 ? 0 : Discount / charge * 100;

                        gbList.SetFocusedRowCellValue(colDiscount, Discount);
                        gbList.SetFocusedRowCellValue(colDiscountRate, DRate);
                        gbList.SetFocusedRowCellValue(colAmount, charge - Discount);

                        gbList.SetFocusedRowCellValue(colPriceDiscount, Price - Price * DRate / 100);
                        gbList.SetFocusedRowCellValue(colPriceVat, Price - Price * DRate / 100);
                        Total();
                        _mColumn = Column.None;
                        
                        break;
                    }
                case Column.Cost:
                    {
                        double cost = Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value);

                        double unitPrice = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice")
                                                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));

                        double quantity = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Quantity")
                                                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Quantity"));

                        double discountRate = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "DiscountRate")
                                                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "DiscountRate"));

                        double weight = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Height")
                                                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Height"));

                        _mColumn = Column.Lock;

                        double charge = quantity * unitPrice;
                        double discount = charge / 100 * discountRate;

                        gbList.SetRowCellValue(e.RowHandle, "Width", quantity * weight);

                        gbList.SetFocusedRowCellValue(colQuantity, e.Value == DBNull.Value ? 0 : e.Value);

                        gbList.SetRowCellValue(e.RowHandle, "Charge", charge);

                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);

                        gbList.SetRowCellValue(e.RowHandle, "Amount", charge - discount);

                        gbList.SetRowCellValue(e.RowHandle, "Profit", cost * quantity);

                        _mColumn = Column.None;

                        break;
                    }
                case Column.Quantity:
                    {
                        double quantity = Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value);

                        double unitPrice = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "UnitPrice")
                                                            == DBNull.Value ? 0 :gbList.GetRowCellValue(e.RowHandle, "UnitPrice"));

                        double cost = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Cost") 
                                                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Cost"));

                        double discountRate = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "DiscountRate")
                                                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "DiscountRate"));

                        double weight = Convert.ToDouble(gbList.GetRowCellValue(e.RowHandle, "Height") 
                                                            == DBNull.Value ? 0: gbList.GetRowCellValue(e.RowHandle, "Height"));
                        
                        _mColumn = Column.Lock;

                        double charge = quantity * unitPrice;
                        double discount = charge / 100 * discountRate;

                        gbList.SetRowCellValue(e.RowHandle, "Width", quantity * weight);

                        gbList.SetFocusedRowCellValue(colQuantity, e.Value == DBNull.Value ? 0 : e.Value);

                        gbList.SetRowCellValue(e.RowHandle, "Charge", charge);

                        gbList.SetRowCellValue(e.RowHandle, "Discount", discount);

                        gbList.SetRowCellValue(e.RowHandle, "Amount", charge - discount);

                        gbList.SetRowCellValue(e.RowHandle, "Profit", cost * quantity);
 
                        _mColumn = Column.None;
                        
                        break;
                    }

                case Column.Price:
                    {
                        _mColumn = Column.Lock;

                        decimal qty = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colQuantity));
                        decimal cost = Convert.ToDecimal(gbList.GetRowCellValue(e.RowHandle, "Cost") 
                            == DBNull.Value ? 0 : gbList.GetRowCellValue(e.RowHandle, "Cost"));

                        decimal Price = Convert.ToDecimal(e.Value == DBNull.Value ? 0 : e.Value);
                        decimal charge = qty * Price;
                        decimal DRate = Convert.ToDecimal(gbList.GetFocusedRowCellValue(colDiscountRate));
                        decimal Discount = charge * DRate / 100;

                        gbList.SetFocusedRowCellValue(colUnitPrice, Price);
                        gbList.SetRowCellValue(e.RowHandle, "Charge", charge);
                        gbList.SetRowCellValue(e.RowHandle, "Discount", Discount);
                        gbList.SetRowCellValue(e.RowHandle, "Amount", charge - Discount);
                        gbList.SetFocusedRowCellValue(colPriceDiscount, Price - Price * DRate / 100);
                        gbList.SetFocusedRowCellValue(colPriceVat, Price - Price * DRate / 100);
                        gbList.SetFocusedRowCellValue(colProfit, qty * cost);
                         
                        _mColumn = Column.None;
                        
                        break;
                    }
                
                case Column.StockID:
                    {
                        object productID = gbList.GetRowCellValue(e.RowHandle, "Product_ID");

                        gbList.SetColumnError(colStock_ID, null);
                        _mColumn = Column.Lock;

                        if (e.Value == null)
                        {
                            gbList.SetColumnError(colStock_ID, "Không được rỗng");
                            gbList.UpdateCurrentRow();
                        }
                        else
                        {
                            if (productID != null)
                            {
                                ProductAdd(productID.ToString());
                            }
                            else
                            {
                                gbList.SetColumnError(colProduct_ID, "Vui lòng chọn hàng hoá.");
                            }
                        }

                        Total();
                        _mColumn = Column.None;
                    }
                    break;

                case Column.ID:
                    _mColumn = Column.Lock;
                    gbList.SetColumnError(colProduct_ID, null);
                    if (e.Value != null)
                    {
                        ProductAdd(e.Value.ToString());
                        



                        //XtraMessageBox.Show(rpgProduct.View.GetRowCellDisplayText(rpgProduct.View.GetFocusedDataSourceRowIndex(), colStock_ID1.FieldName).ToString());
                        ////gbList.SetFocusedRowCellValue("StoreID",
                        ////                              dsPRODUCT.PRODUCT[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Quantity"]);
                        //gbList.SetFocusedRowCellValue("Stock_ID",rpgProduct.GetRowByKeyValue(colStock_ID1.FieldName.ToString()));
                        ////gbList.GetRowCellValue(gbList.FocusedRowHandle, "RefType")

                    }
                    else
                    {
                        gbList.SetColumnError(colProduct_ID, "Vui lòng chọn hàng hoá.");
                    }
                    Total();
                    _mColumn = Column.None;
                    break;
                case Column.Name:
                    _mColumn = Column.Lock;
                    gbList.SetColumnError(colItemID, null);
                    if (e.Value != null)
                    {
                        ProductAdd(e.Value.ToString());
                        //gbList.SetFocusedRowCellValue("Stock_ID", 
                        //    dsPRODUCT.PRODUCT[rpgProduct.View.GetFocusedDataSourceRowIndex()]["Stock_ID"]);
                    }
                    else
                    {
                        gbList.SetColumnError(colItemID, "Vui lòng chọn hàng hoá.");
                    }
                    Total();
                    _mColumn = Column.None;
                    break;
                case Column.Height:
                    {
                        object Qty = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                        _mColumn = Column.Lock;

                        gbList.SetRowCellValue(e.RowHandle, "Width",
                                               Convert.ToDouble(e.Value == DBNull.Value ? 0 : e.Value) *
                                               Convert.ToDouble(Qty == DBNull.Value ? 0 : Qty));

                        _mColumn = Column.None;

                    }
                    break;
                case Column.Unit:
                    {
                        _mColumn = Column.Lock;
                        decimal price = 0;
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
                                decimal weight = Convert.ToDecimal(product.Depth) * convert;
                                decimal sumweight = weight * Convert.ToDecimal(qty);
                                if (convert == 0)
                                {
                                    gbList.SetRowCellValue(e.RowHandle, "Unit", null);
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", 1);
                                    gbList.SetRowCellValue(e.RowHandle, "ChassyNo", null);
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
                                        gbList.SetRowCellValue(e.RowHandle, "ChassyNo", tenQC);

                                    }
                                    else
                                    {
                                        gbList.SetRowCellValue(e.RowHandle, "ChassyNo", null);
                                    }
                                    //////
                                    var productID = gbList.GetRowCellValue(e.RowHandle, "Product_ID") == null
                                            ? ""
                                            : gbList.GetRowCellValue(e.RowHandle, "Product_ID").ToString();
                                    var customerID = txtCustomerName.EditValue == null
                                             ? ""
                                             : txtCustomerName.EditValue.ToString();
                                    var m_Size = gbList.GetRowCellValue(e.RowHandle, "Size");
                                    var m_price =
                                        GetPrice(customerID, productID,Convert.ToInt32(m_Size == DBNull.Value ? 0 : m_Size),e.Value.ToString());
                                    if (Convert.ToInt32(m_Size) == 1 | Convert.ToInt32(m_Size) == 2 | Convert.ToInt32(m_Size) == 3)
                                    {
                                        price = Convert.ToDecimal(m_price * convert); 
                                    }
                                    if (Convert.ToInt32(m_Size) == 4 | Convert.ToInt32(m_Size) == 5)
                                    {
                                        price = Convert.ToDecimal(m_price);
                                    }
                                    var discountRateTemp = gbList.GetRowCellValue(e.RowHandle, "DiscountRate");
                                    var qtyTemp = gbList.GetRowCellValue(e.RowHandle, "Quantity");
                                    var discountRate = Convert.ToDecimal(discountRateTemp == DBNull.Value ? 0 : discountRateTemp);
                                    var quantity = Convert.ToDecimal(qtyTemp == DBNull.Value ? 0 : qtyTemp);

                                    var discount = ((quantity * price) / 100) * discountRate;
                                    var amount = (quantity * price) - discount;

                                    gbList.SetRowCellValue(e.RowHandle, "UnitPrice", price);
                                    gbList.SetRowCellValue(e.RowHandle, "Charge", (quantity * price));
                                    gbList.SetRowCellValue(e.RowHandle, "Discount", discount);
                                    gbList.SetRowCellValue(e.RowHandle, "Amount", amount);
                                    gbList.SetFocusedRowCellValue(colPriceDiscount, price - price * discountRate / 100);
                                    gbList.SetFocusedRowCellValue(colPriceDiscount, price - price * discountRate / 100);
                                    Total();
                                    //////
                                    gbList.SetRowCellValue(e.RowHandle, "UnitConvert", convert);
                                    gbList.SetRowCellValue(e.RowHandle, "Height", weight);
                                    gbList.SetRowCellValue(e.RowHandle, "Width", sumweight);
                                }
                            }
                        }
                        Total();
                        _mColumn = Column.None;
                    }
                    break;
                default:
                    Total();
                    _mColumn = Column.None;
                    break;
            }
            Total();
            _mColumn = Column.None;
            NotSave = true;
            
        }

        #endregion

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

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }

        #endregion

        private void TxtEmployeeEditValueChanged(object sender, EventArgs e)
        {
        }

        private void DtCreatedEditValueChanged(object sender, EventArgs e)
        {
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            decimal discountRate = (amount + txtVatAmount.Value) == 0 ? 0 : (txtDiscount.Value / amount) * 100;
            decimal vatAmount = txtVatAmount.Value;

            txtDiscountRate.Value = discountRate;
            txtTotalAmount.Value = amount + vatAmount - txtDiscount.Value;
        }

        private void txtVatAmount_EditValueChanged(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            decimal vatAmountRate = amount == 0 ? 0 : (txtVatAmount.Value / amount) * 100;
            decimal discount = amount * (Convert.ToDecimal(txtDiscountRate.Value)) / 100;

            //txtVatAmount.Value = vatAmount;
            txtVatRate.Value = vatAmountRate;
            txtTotalAmount.Value = amount + txtVatAmount.Value - discount;
        }

        private void TxtDiscountRateEditValueChanged(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            decimal discount = amount * (Convert.ToDecimal(txtDiscountRate.Value)) / 100;
            decimal vatAmount = amount * (Convert.ToDecimal(txtVatRate.Value)) / 100;

            txtDiscount.Value = discount;
            txtTotalAmount.Value = amount + vatAmount - discount;
        }

        private void TxtVatRateEditValueChanged(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            decimal vatAmount = amount * (Convert.ToDecimal(txtVatRate.Value)) / 100;
            decimal discount = amount * (Convert.ToDecimal(txtDiscountRate.Value)) / 100;

            txtVatAmount.Value = vatAmount;
            txtTotalAmount.Value = amount + vatAmount - discount;
        }

        private void rpValPriceType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;  
            }
        }

        decimal GetPrice(string customerID, string productID, int priceType, string m_unit)
        {
            decimal price = 0;

            if (priceType == 4 && (string.IsNullOrEmpty(customerID) || customerID == null))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(productID) || priceType > 5 || priceType <= 0)
            {
                price = 0;
            }
            else
            {

                var pro = new PRODUCT();

                //var pro = PRODUCT.SingleOrDefault(p => p.Product_ID == productID);
                if (pro.Get(productID) != "OK")
                {
                    return 0;
                }
                
                if (pro == null) return 0;
                switch (priceType)
                {
                    case 1:
                        price = Convert.ToDecimal(pro.Org_Price);
                        break;
                    case 2:
                        price = Convert.ToDecimal(pro.Sale_Price);
                        break;
                    case 3:
                        price = Convert.ToDecimal(pro.Retail_Price);
                        break;
                    case 4:
                        if (string.IsNullOrEmpty(customerID))
                        {
                            price = 0;
                        }
                        else
                        {
                            price = GetPriceByCustomer(productID, customerID, m_unit);
                        }
                        break;
                    case 5:
                        price = GetPriceRecent(productID, m_unit);
                        break;
                }
            }
            return price;
        }

        decimal GetPriceRecent(string productID, string m_unit)
        {
            if (string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(m_unit))
            {
                return 0;
            }
            string[] myPara = { "@Product_ID", "@Unit" };
            object[] myValue = { productID, m_unit};

            string sql = "SELECT TOP 1 sod.UnitPrice \n"
           + "FROM   STOCK_OUTWARD_DETAIL sod \n"
           + "       LEFT OUTER JOIN STOCK_OUTWARD so \n"
           + "            ON  sod.Outward_ID = so.ID \n"
           + "WHERE  sod.Product_ID = @Product_ID \n"
           + "       AND sod.Unit = @Unit \n"
           + "       AND sod.[Size] != '0' \n"
           + "ORDER BY \n"
           + "       DATEADD(dd, DATEDIFF(d, 0, so.RefDate), 0) DESC, \n"
           + "       so.ID DESC";

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            DataTable dt = mySql.ExecuteDataTable(sql, myPara, myValue);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(dt.Rows[0]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[0]["UnitPrice"]);
            }
        
        }

        decimal GetPriceByCustomer(string productID, string customerID, string m_unit)
        {
            if (string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(m_unit))
            {
                return 0;
            }
            string[] myPara = { "@Product_ID", "@Customer_ID", "@Unit" };
            object[] myValue = { productID, customerID, m_unit };
            string sql = "SELECT TOP 1 sod.UnitPrice \n"
           + "FROM   STOCK_OUTWARD_DETAIL sod \n"
           + "       LEFT OUTER JOIN STOCK_OUTWARD so \n"
           + "            ON  sod.Outward_ID = so.ID \n"
           + "WHERE  sod.Product_ID = @Product_ID \n"
           + "       AND so.Customer_ID = @Customer_ID \n"
           + "       AND sod.Unit = @Unit \n"
           + "       AND sod.[Size] != '0' \n"
           + "ORDER BY \n"
           + "       DATEADD(dd, DATEDIFF(d, 0, so.RefDate), 0) DESC,so.ID DESC";

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            DataTable dt = mySql.ExecuteDataTable(sql, myPara, myValue);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(dt.Rows[0]["UnitPrice"] == DBNull.Value ? 0 : dt.Rows[0]["UnitPrice"]);
            }
        }

        private void gbList_Click(object sender, EventArgs e)
        {
            Total();
        }

        private void gbList_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            gbList.UpdateSummary();
            Total();
        }


        public decimal GetTotalDebtCustomer(DateTime FromDate, DateTime ToDate, string CustomerID)
        {
            decimal debt = 0;

            var mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            #region Query
            string myQuery = @"


SELECT 
       ds.DebtInitAmount + ds.DebtIn - ds.ReceiptIn AS TotalDebt
FROM   (
           SELECT DEBT_LIST.CustomerID,
                  SUM(DEBT_LIST.DebtInit) AS [DebtInitAmount],
                  SUM(DEBT_LIST.DebtIn) AS [DebtIn],
                  SUM(DEBT_LIST.ReceiptIn) AS [ReceiptIn]
           FROM   (
                      SELECT DEBT_CARD_INIT.CustomerID,
                             SUM(DEBT_CARD_INIT.Amount) AS [DebtInit],
                             CAST(0 AS MONEY) AS [DebtIn],
                             CAST(0 AS MONEY) AS [ReceiptIn]
                      FROM   (
                                 --phieu con no ky truoc
                                 SELECT d.CustomerID,
                                        CASE 
                                             WHEN d.TermID = 'TM' THEN 0
                                             ELSE d.Balance
                                        END AS Amount
                                 FROM   DEBT d
                                 WHERE  d.RefStatus = 0
                                        AND DATEDIFF(DAY, d.RefDate, @FromDate) 
                                            > 0
                                 
                                 
                                 UNION ALL
                                 --cac phieu thu khac ky truoc
                                 SELECT cr.CustomerID,
                                        (cr.Amount * -1) AS RealAmount
                                 FROM   CUSTOMER_RECEIPT cr
                                 WHERE  DATEDIFF(DAY, cr.RefDate, @FromDate) > 0
                             ) DEBT_CARD_INIT
                      WHERE  DEBT_CARD_INIT.CustomerID = @CustomerID
                             OR  1 = CASE 
                                          WHEN @CustomerID = 'All' THEN 1
                                          ELSE 0
                                     END
                      GROUP BY
                             DEBT_CARD_INIT.CustomerID
                      
                      UNION ALL
                      -- cac phieu cong no trong ky
                      SELECT d.CustomerID,
                             0,
                             CASE 
                                 WHEN d.TermID = 'TM' THEN 0
                                 ELSE d.Amount END AS Amount,
                             0
                      FROM   DEBT d
                      WHERE  d.RefStatus = 0
                             AND d.RefType = 2
                             AND DATEDIFF(DAY, @FromDate, d.RefDate) >= 0
                             AND DATEDIFF(DAY, @ToDate, d.RefDate) <= 0
                             AND (
                                     d.CustomerID = @CustomerID
                                     OR 1 = CASE 
                                                 WHEN @CustomerID = 'All' THEN 1
                                                 ELSE 0
                                            END
                                 )
                      UNION ALL
                      -- cac phieu thu khac trong ky
                      SELECT cr.CustomerID,
                             0,
                             0,
                             cr.Amount
                      FROM   CUSTOMER_RECEIPT cr
                      WHERE  DATEDIFF(DAY, @FromDate, cr.RefDate) >= 0
                             AND DATEDIFF(DAY, @ToDate, cr.RefDate) <= 0
                                 -- AND cr.RefOrgNo = ''
                             AND (
                                     cr.CustomerID = @CustomerID
                                     OR 1 = CASE 
                                                 WHEN @CustomerID = 'All' THEN 1
                                                 ELSE 0
                                            END
                                 )
                  ) DEBT_LIST
           GROUP BY
                  DEBT_LIST.CustomerID
       )ds
       LEFT OUTER JOIN CUSTOMER c
            ON  ds.CustomerID = c.Customer_ID
       LEFT OUTER JOIN CUSTOMER_GROUP cg
            ON  cg.Customer_Group_ID = c.Customer_Group_ID";
            #endregion


            #region NewQuery
            string NewQuery = @"
--DECLARE @FromDate    DATETIME,
--        @ToDate      DATETIME,
--        @CustomerID  NVARCHAR(255)
--
--SELECT @FromDate = DATEADD(DAY, DATEPART(DAY, GETDATE()) * -1 + 1, GETDATE()),
--       @ToDate = DATEADD(DAY, -1, DATEADD(MONTH, 1, @FromDate)),
--       @CustomerID = 'All'

SELECT ds.CustomerID,
       c.CustomerName,
       c.Tel AS CustomerAddress,
       cg.Customer_Group_Name,
       ds.DebtInitAmount,
       ds.DebtIn,
       ds.ReceiptIn,
       ds.DebtInitAmount + ds.DebtIn - ds.ReceiptIn AS TotalDebt
FROM   (
           SELECT DEBT_LIST.CustomerID,
                  SUM(DEBT_LIST.DebtInit) AS [DebtInitAmount],
                  SUM(DEBT_LIST.DebtIn) AS [DebtIn],
                  SUM(DEBT_LIST.ReceiptIn) AS [ReceiptIn]
           FROM   (
                      SELECT DEBT_CARD_INIT.CustomerID,
                             SUM(DEBT_CARD_INIT.Amount) AS [DebtInit],
                             CAST(0 AS MONEY) AS [DebtIn],
                             CAST(0 AS MONEY) AS [ReceiptIn]
                      FROM   (
                                 --phieu con no ky truoc
                                 SELECT d.CustomerID,
                                        d.Amount
                                 FROM   DEBT d
                                 WHERE  d.RefType IN (2, 11, 31)
                                        AND d.TermID = 'CN'
                                        AND DATEDIFF(DAY, d.RefDate, @FromDate) 
                                            > 0
                                 
                                 
                                 UNION ALL
                                 --cac phieu thu khac ky truoc
                                 SELECT cr.CustomerID,
                                        (cr.Amount * -1) AS RealAmount
                                 FROM   CUSTOMER_RECEIPT cr
                                 WHERE  DATEDIFF(DAY, cr.RefDate, @FromDate) > 0
                             ) DEBT_CARD_INIT
                      WHERE  DEBT_CARD_INIT.CustomerID = @CustomerID
                             OR  1 = CASE 
                                          WHEN @CustomerID = 'All' THEN 1
                                          ELSE 0
                                     END
                      GROUP BY
                             DEBT_CARD_INIT.CustomerID
                      
                      UNION ALL
                      -- cac phieu cong no trong ky
                      SELECT d.CustomerID,
                             0,
                             CASE 
                                 WHEN d.TermID = 'TM' THEN 0
                                 ELSE d.Amount END AS Amount,
                             0
                      FROM   DEBT d
                      WHERE  d.RefStatus = 0
                             AND d.RefType = 2
                             AND DATEDIFF(DAY, @FromDate, d.RefDate) >= 0
                             AND DATEDIFF(DAY, @ToDate, d.RefDate) <= 0
                             AND (
                                     d.CustomerID = @CustomerID
                                     OR 1 = CASE 
                                                 WHEN @CustomerID = 'All' THEN 1
                                                 ELSE 0
                                            END
                                 )
                      UNION ALL
                      -- cac phieu thu khac trong ky
                      SELECT cr.CustomerID,
                             0,
                             0,
                             cr.Amount
                      FROM   CUSTOMER_RECEIPT cr
                      WHERE  DATEDIFF(DAY, @FromDate, cr.RefDate) >= 0
                             AND DATEDIFF(DAY, @ToDate, cr.RefDate) <= 0
                                 -- AND cr.RefOrgNo = ''
                             AND (
                                     cr.CustomerID = @CustomerID
                                     OR 1 = CASE 
                                                 WHEN @CustomerID = 'All' THEN 1
                                                 ELSE 0
                                            END
                                 )
                  ) DEBT_LIST
           GROUP BY
                  DEBT_LIST.CustomerID
       )ds
       LEFT OUTER JOIN CUSTOMER c
            ON  ds.CustomerID = c.Customer_ID
       LEFT OUTER JOIN CUSTOMER_GROUP cg
            ON  cg.Customer_Group_ID = c.Customer_Group_ID";
            #endregion

            string[] myPara = { "@FromDate", "@ToDate", "@CustomerID" };
            object[] myValue = { FromDate, ToDate, CustomerID };

            DataTable dt = mySql.ExecuteDataTable(NewQuery, myPara, myValue);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(dt.Rows[0]["TotalDebt"] == null ? 0 : dt.Rows[0]["TotalDebt"]);
            }
        }

        private void txtAddress_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadDebt_Click(object sender, EventArgs e)
        {
            txtOldDebt.Value = GetTotalDebtCustomer(dtCreated.DateTime, dtCreated.DateTime, txtCustomerName.EditValue.ToString()) - txtTotalAmount.Value;

            CalcSale();
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            
        }

       

        private void txtEmployeeRegion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRefInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetInvoiceDetail(txtRefInvoice.Text.Trim());
            }
        }

        private void GetInvoiceDetail(string RefInvoice)
        {
            dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.Clear();

            DataTable dt = new DataTable();
            string[] myPara = { "@RefInvoice" };
            object[] myValue = { RefInvoice };

            string sql = @"
                SELECT sod.ID,
                       sod.Outward_ID,
                       sod.Stock_ID,
                       sod.RefType,
                       sod.Product_ID,
                       sod.ProductName,
                       sod.Vat,
                       sod.VatAmount,
                       sod.Unit,
                       sod.UnitConvert,
                       sod.CurrentQty,
                       sod.Quantity,
                       sod.UnitPrice,
                       sod.Amount,
                       sod.QtyConvert,
                       sod.DiscountRate,
                       sod.Discount,
                       sod.Charge,
                       sod.Cost,
                       sod.Profit,
                       sod.Batch,
                       sod.Serial,
                       sod.ChassyNo,
                       sod.IME,
                       sod.Width,
                       sod.Height,
                       sod.Orgin,
                       sod.[Size],
                       sod.StoreID,
                       sod.[Description],
                       sod.Sorted,
                       sod.[Active],
                       sod.[Timestamp]
                FROM   STOCK_OUTWARD_DETAIL AS sod
                WHERE  sod.Outward_ID = @RefInvoice
                ORDER BY sod.Sorted";
            var mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;
            dt.Merge(mySql.ExecuteDataTable(sql, myPara, myValue));

            //Add data into 
            foreach (DataRow dr in dt.Rows)
            {
                dsSTOCK_OUTWARD_DETAIL.STOCK_OUTWARD_DETAIL.AddSTOCK_OUTWARD_DETAILRow(
                    Guid.NewGuid(),
                    txtID.Text,
                    Convert.ToString(dr["Stock_ID"]),
                    2,
                    Convert.ToString(dr["Product_ID"]),
                    Convert.ToString(dr["Product_ID"]),
                    Convert.ToString(dr["ProductName"]),

                    //pro.Product_Type_ID
                    1,

                    Convert.ToInt32(dr["Vat"]),
                    Convert.ToString(dr["Unit"]),
                    "",
                    Convert.ToDecimal(dr["UnitConvert"]),

                    Convert.ToDecimal(dr["CurrentQty"]),
                    Convert.ToDecimal(dr["Quantity"]),
                    Convert.ToDecimal(dr["UnitPrice"]),

                    Convert.ToDecimal(dr["UnitPrice"]),
                    Convert.ToDecimal(dr["UnitPrice"]),
                    Convert.ToDecimal(dr["Amount"]),
                    Convert.ToDecimal(dr["QtyConvert"]),


                    Convert.ToDecimal(dr["DiscountRate"]),
                    Convert.ToDecimal(dr["Discount"]),

                    Convert.ToDecimal(dr["Charge"]),
                    Convert.ToDecimal(dr["Cost"]),
                    Convert.ToDecimal(dr["Profit"]),

                    Convert.ToString(dr["Batch"]),
                    Convert.ToString(dr["Serial"]),
                    Convert.ToString(dr["ChassyNo"]),
                    Convert.ToString(dr["IME"]),

                    Convert.ToDecimal(dr["Width"]),
                    Convert.ToDecimal(dr["Height"]),

                    Convert.ToString(dr["Orgin"]),
                    Convert.ToString(dr["Size"]),
                    0,
                    Convert.ToString(dr["Description"]),
                    0,
                    true
                    );
            }
            Total();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetInvoiceDetail(txtRefInvoice.Text.Trim());
        }

        private void txtRoute_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gbList_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            gbList.ClearColumnErrors();
        }
    }
}