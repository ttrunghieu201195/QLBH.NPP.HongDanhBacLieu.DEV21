using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Perfect.Common;

namespace Perfect.ERP
{
    public class SALES_ORDER : Object
    {
        #region Init

        private string m_ID;
        private DateTime m_RefDate;
        private string m_Ref_OrgNo;
        private int m_RefType;
        private int m_RefStatus;
        private string m_PaymentMethod;
        private string m_TermID;
        private DateTime m_PaymentDate;
        private DateTime m_DeliveryDate;
        private string m_Barcode;
        private string m_Department_ID;
        private string m_Employee_ID;
        private string m_Stock_ID;
        private string m_Branch_ID;
        private string m_Contract_ID;
        private string m_Customer_ID;
        private string m_CustomerName;
        private string m_CustomerAddress;
        private string m_Contact;
        private string m_Reason;
        private int m_Payment;
        private string m_Currency_ID;
        private decimal m_ExchangeRate;
        private int m_Vat;
        private decimal m_VatAmount;
        private decimal m_Amount;
        private decimal m_FAmount;
        private DateTime m_DiscountDate;
        private decimal m_DiscountRate;
        private decimal m_Discount;
        private decimal m_OtherDiscount;
        private decimal m_Charge;
        private decimal m_Cost;
        private decimal m_Profit;
        private string m_User_ID;
        private bool m_IsClose;
        private long m_Sorted;

        private string m_Description;
        private string m_Notes;

        private bool m_Active;


        public SALES_ORDER()
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = "";
            m_RefDate = DateTime.Now;
            m_Ref_OrgNo = "";
            m_RefType = 0;
            m_RefStatus = 0;
            m_PaymentMethod = "";
            m_TermID = "";
            m_PaymentDate = DateTime.Now;
            m_DeliveryDate = DateTime.Now;
            m_Barcode = "";
            m_Department_ID = "";
            m_Employee_ID = "";
            m_Stock_ID = "";
            m_Branch_ID = "";
            m_Contract_ID = "";
            m_Customer_ID = "";
            m_CustomerName = "";
            m_CustomerAddress = "";
            m_Contact = "";
            m_Reason = "";
            m_Payment = 0;
            m_Currency_ID = "";
            m_ExchangeRate = 0;
            m_Vat = 0;
            m_VatAmount = 0;
            m_Amount = 0;
            m_FAmount = 0;
            m_DiscountDate = DateTime.Now;
            m_DiscountRate = 0;

            m_Discount = 0;
            m_OtherDiscount = 0;
            m_Charge = 0;
            m_Cost = 0;
            m_Profit = 0;
            m_User_ID = "";
            m_IsClose = true;
            m_Sorted = 0;
            m_Description = "";
            m_Notes = "";
            m_Active = true;
        }

        public SALES_ORDER(
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string TermID,
            DateTime PaymentDate,
            DateTime DeliveryDate,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            int Vat,
            decimal VatAmount,
            decimal Amount,
            decimal FAmount,
            DateTime DiscountDate,
            decimal DiscountRate,
            decimal Discount,
            decimal OtherDiscount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,

            string Description,
            string Notes,

            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_RefDate = RefDate;
            m_Ref_OrgNo = Ref_OrgNo;
            m_RefType = RefType;
            m_RefStatus = RefStatus;
            m_PaymentMethod = PaymentMethod;
            m_TermID = TermID;
            m_PaymentDate = PaymentDate;
            m_DeliveryDate = DeliveryDate;
            m_Barcode = Barcode;
            m_Department_ID = Department_ID;
            m_Employee_ID = Employee_ID;
            m_Stock_ID = Stock_ID;
            m_Branch_ID = Branch_ID;
            m_Contract_ID = Contract_ID;
            m_Customer_ID = Customer_ID;
            m_CustomerName = CustomerName;
            m_CustomerAddress = CustomerAddress;
            m_Contact = Contact;
            m_Reason = Reason;
            m_Payment = Payment;
            m_Currency_ID = Currency_ID;
            m_ExchangeRate = ExchangeRate;
            m_Vat = Vat;
            m_VatAmount = VatAmount;
            m_Amount = Amount;
            m_FAmount = FAmount;
            m_DiscountDate = DiscountDate;
            m_DiscountRate = DiscountRate;
            m_Discount = Discount;
            m_OtherDiscount = OtherDiscount;
            m_Charge = Charge;
            m_Cost = Cost;
            m_Profit = Profit;
            m_User_ID = User_ID;
            m_IsClose = IsClose;
            m_Sorted = Sorted;
            m_Description = Description;
            m_Notes = Notes;
            m_Active = Active;
        }


        public void SetData(
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_RefDate = RefDate;
            m_Ref_OrgNo = Ref_OrgNo;
            m_RefType = RefType;
            m_Barcode = Barcode;
            m_Department_ID = Department_ID;
            m_Employee_ID = Employee_ID;
            m_Stock_ID = Stock_ID;
            m_Branch_ID = Branch_ID;
            m_Contract_ID = Contract_ID;
            m_Customer_ID = Customer_ID;
            m_CustomerName = CustomerName;
            m_CustomerAddress = CustomerAddress;
            m_Contact = Contact;
            m_Reason = Reason;
            m_Payment = Payment;
            m_Currency_ID = Currency_ID;
            m_ExchangeRate = ExchangeRate;
            m_Amount = Amount;
            m_FAmount = FAmount;
            m_Discount = Discount;
            m_Charge = Charge;
            m_Cost = Cost;
            m_Profit = Profit;
            m_User_ID = User_ID;
            m_IsClose = IsClose;
            m_Sorted = Sorted;
            m_Description = Description;
            m_Notes = Notes;
            m_Active = Active;
        }

        #endregion

        #region Property

        [DisplayName("ID")]
        [Category("Primary Key")]
        public string ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        [DisplayName("RefDate")]
        [Category("Column")]
        public DateTime RefDate
        {
            get { return m_RefDate; }
            set { m_RefDate = value; }
        }

        [DisplayName("Ref_OrgNo")]
        [Category("Column")]
        public string Ref_OrgNo
        {
            get { return m_Ref_OrgNo; }
            set { m_Ref_OrgNo = value; }
        }


        public string TermID
        {
            get
            {
                return m_TermID;
            }
            set
            {
                m_TermID = value;
            }
        }
        public DateTime PaymentDate
        {
            get
            {
                return m_PaymentDate;
            }
            set
            {
                m_PaymentDate = value;
            }
        }

        public DateTime DeliveryDate
        {
            get
            {
                return m_DeliveryDate;
            }
            set
            {
                m_DeliveryDate = value;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return m_PaymentMethod;
            }
            set
            {
                m_PaymentMethod = value;
            }
        }


        [DisplayName("RefType")]
        [Category("Column")]
        public int RefType
        {
            get { return m_RefType; }
            set { m_RefType = value; }
        }

        public int RefStatus
        {
            get { return m_RefStatus; }
            set { m_RefStatus = value; }
        }

        public int Vat
        {
            get { return m_Vat; }
            set { m_Vat = value; }
        }

        public decimal VatAmount
        {
            get { return m_VatAmount; }
            set { m_VatAmount = value; }
        }

        public decimal DiscountRate
        {
            get { return m_DiscountRate; }
            set { m_DiscountRate = value; }
        }

        [DisplayName("Barcode")]
        [Category("Column")]
        public string Barcode
        {
            get { return m_Barcode; }
            set { m_Barcode = value; }
        }

        [DisplayName("Department_ID")]
        [Category("Column")]
        public string Department_ID
        {
            get { return m_Department_ID; }
            set { m_Department_ID = value; }
        }

        [DisplayName("Employee_ID")]
        [Category("Column")]
        public string Employee_ID
        {
            get { return m_Employee_ID; }
            set { m_Employee_ID = value; }
        }

        [DisplayName("Stock_ID")]
        [Category("Column")]
        public string Stock_ID
        {
            get { return m_Stock_ID; }
            set { m_Stock_ID = value; }
        }

        [DisplayName("Branch_ID")]
        [Category("Column")]
        public string Branch_ID
        {
            get { return m_Branch_ID; }
            set { m_Branch_ID = value; }
        }

        [DisplayName("Contract_ID")]
        [Category("Column")]
        public string Contract_ID
        {
            get { return m_Contract_ID; }
            set { m_Contract_ID = value; }
        }

        [DisplayName("Customer_ID")]
        [Category("Column")]
        public string Customer_ID
        {
            get { return m_Customer_ID; }
            set { m_Customer_ID = value; }
        }

        [DisplayName("CustomerName")]
        [Category("Column")]
        public string CustomerName
        {
            get { return m_CustomerName; }
            set { m_CustomerName = value; }
        }

        [DisplayName("CustomerAddress")]
        [Category("Column")]
        public string CustomerAddress
        {
            get { return m_CustomerAddress; }
            set { m_CustomerAddress = value; }
        }

        [DisplayName("Contact")]
        [Category("Column")]
        public string Contact
        {
            get { return m_Contact; }
            set { m_Contact = value; }
        }

        [DisplayName("Reason")]
        [Category("Column")]
        public string Reason
        {
            get { return m_Reason; }
            set { m_Reason = value; }
        }

        [DisplayName("Payment")]
        [Category("Column")]
        public int Payment
        {
            get { return m_Payment; }
            set { m_Payment = value; }
        }

        [DisplayName("Currency_ID")]
        [Category("Column")]
        public string Currency_ID
        {
            get { return m_Currency_ID; }
            set { m_Currency_ID = value; }
        }

        [DisplayName("ExchangeRate")]
        [Category("Column")]
        public decimal ExchangeRate
        {
            get { return m_ExchangeRate; }
            set { m_ExchangeRate = value; }
        }

        [DisplayName("Amount")]
        [Category("Column")]
        public decimal Amount
        {
            get { return m_Amount; }
            set { m_Amount = value; }
        }

        [DisplayName("FAmount")]
        [Category("Column")]
        public decimal FAmount
        {
            get { return m_FAmount; }
            set { m_FAmount = value; }
        }

        [DisplayName("Discount")]
        [Category("Column")]
        public decimal Discount
        {
            get { return m_Discount; }
            set { m_Discount = value; }
        }

        [DisplayName("OtherDiscount")]
        [Category("Column")]
        public decimal OtherDiscount
        {
            get { return m_OtherDiscount; }
            set { m_OtherDiscount = value; }
        }
        [DisplayName("DiscountDate")]
        [Category("Column")]
        public DateTime DiscountDate
        {
            get { return m_DiscountDate; }
            set { m_DiscountDate = value; }
        }
        [DisplayName("Charge")]
        [Category("Column")]
        public decimal Charge
        {
            get { return m_Charge; }
            set { m_Charge = value; }
        }

        [DisplayName("Cost")]
        [Category("Column")]
        public decimal Cost
        {
            get { return m_Cost; }
            set { m_Cost = value; }
        }

        [DisplayName("Profit")]
        [Category("Column")]
        public decimal Profit
        {
            get { return m_Profit; }
            set { m_Profit = value; }
        }

        [DisplayName("User_ID")]
        [Category("Column")]
        public string User_ID
        {
            get { return m_User_ID; }
            set { m_User_ID = value; }
        }

        [DisplayName("IsClose")]
        [Category("Column")]
        public bool IsClose
        {
            get { return m_IsClose; }
            set { m_IsClose = value; }
        }

        [DisplayName("Sorted")]
        [Category("Column")]
        public long Sorted
        {
            get { return m_Sorted; }
            set { m_Sorted = value; }
        }

        [DisplayName("Description")]
        [Category("Column")]
        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        [DisplayName("Notes")]
        [Category("Column")]
        public string Notes
        {
            get { return m_Notes; }
            set { m_Notes = value; }
        }

        [DisplayName("Active")]
        [Category("Column")]
        public bool Active
        {
            get { return m_Active; }
            set { m_Active = value; }
        }

        public string Product
        {
            get { return "Class SALES_ORDER"; }
        }

        public string AssemblyVersion
        {
            get { return "2.5.0.0"; }
        }

        public string Copyright
        {
            get { return "Công Ty Phần Mềm Hoàn Hảo"; }
        }

        #endregion

        #region NewID

        public string NewID()
        {
            return NewID("");
        }

        public string NewID(string key)
        {
            return SqlHelper.GenCode("SALES_ORDER", "SALES_ORDERID", key);
        }

        public string NewID(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, "SALES_ORDER", "SALES_ORDERID", key);
        }

        public string CreateKey()
        {
            return CreateKey("");
        }

        public string CreateKey(string key)
        {
            return SqlHelper.GenCode(key);
        }

        public string CreateKey(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, key);
        }

        public string CreateKey(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "");
        }

        #endregion

        #region Exist

        public string GetSale(string SaleID)
        {
            string Result = "";
            string[] myPara = {"@SaleID"};
            object[] myValue = {SaleID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("SALES_ORDER_GetSaleID", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_Ref_OrgNo = Convert.ToString(myReader["Ref_OrgNo"]);
                    m_RefType = Convert.ToInt32(myReader["RefType"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_Department_ID = Convert.ToString(myReader["Department_ID"]);
                    m_Employee_ID = Convert.ToString(myReader["Employee_ID"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
                    m_Branch_ID = Convert.ToString(myReader["Branch_ID"]);
                    m_Contract_ID = Convert.ToString(myReader["Contract_ID"]);
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"]);
                    m_Contact = Convert.ToString(myReader["Contact"]);
                    m_Reason = Convert.ToString(myReader["Reason"]);
                    m_Payment = Convert.ToInt16(myReader["Payment"]);
                    m_Currency_ID = Convert.ToString(myReader["Currency_ID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_Charge = Convert.ToDecimal(myReader["Charge"]);
                    m_Cost = Convert.ToDecimal(myReader["Cost"]);
                    m_Profit = Convert.ToDecimal(myReader["Profit"]);
                    m_User_ID = Convert.ToString(myReader["User_ID"]);
                    m_IsClose = Convert.ToBoolean(myReader["IsClose"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]==DBNull.Value?"":myReader["Contract_ID"] );
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]==DBNull.Value?"":myReader["Customer_ID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_Contact =Convert.ToString(myReader["Contact"]==DBNull.Value?"":myReader["Contact"] );
						m_Reason =Convert.ToString(myReader["Reason"]==DBNull.Value?"":myReader["Reason"] );
						m_Payment =Convert.ToInt16(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]==DBNull.Value?"":myReader["Currency_ID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Cost =Convert.ToDecimal(myReader["Cost"]==DBNull.Value?0:myReader["Cost"] );
						m_Profit =Convert.ToDecimal(myReader["Profit"]==DBNull.Value?0:myReader["Profit"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif

                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string GetLast(string CustomerID)
        {
            string Result = "";
            string[] myPara = {"@Customer_ID"};
            object[] myValue = {CustomerID};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader =
                mySql.ExecuteReader("Select * From [SALES_ORDER] Where Customer_ID ='" + CustomerID +
                                    "' and Payment=0");
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_Ref_OrgNo = Convert.ToString(myReader["Ref_OrgNo"]);
                    m_RefType = Convert.ToInt32(myReader["RefType"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_Department_ID = Convert.ToString(myReader["Department_ID"]);
                    m_Employee_ID = Convert.ToString(myReader["Employee_ID"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
                    m_Branch_ID = Convert.ToString(myReader["Branch_ID"]);
                    m_Contract_ID = Convert.ToString(myReader["Contract_ID"]);
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"]);
                    m_Contact = Convert.ToString(myReader["Contact"]);
                    m_Reason = Convert.ToString(myReader["Reason"]);
                    m_Payment = Convert.ToInt16(myReader["Payment"]);
                    m_Currency_ID = Convert.ToString(myReader["Currency_ID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_Charge = Convert.ToDecimal(myReader["Charge"]);
                    m_Cost = Convert.ToDecimal(myReader["Cost"]);
                    m_Profit = Convert.ToDecimal(myReader["Profit"]);
                    m_User_ID = Convert.ToString(myReader["User_ID"]);
                    m_IsClose = Convert.ToBoolean(myReader["IsClose"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]==DBNull.Value?"":myReader["Contract_ID"] );
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]==DBNull.Value?"":myReader["Customer_ID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_Contact =Convert.ToString(myReader["Contact"]==DBNull.Value?"":myReader["Contact"] );
						m_Reason =Convert.ToString(myReader["Reason"]==DBNull.Value?"":myReader["Reason"] );
						m_Payment =Convert.ToInt16(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]==DBNull.Value?"":myReader["Currency_ID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Cost =Convert.ToDecimal(myReader["Cost"]==DBNull.Value?0:myReader["Cost"] );
						m_Profit =Convert.ToDecimal(myReader["Profit"]==DBNull.Value?0:myReader["Profit"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif

                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
            }
            return Result;
        }

        public string GetSX(string Outward_ID)
        {
            string Result = "";
            string[] myPara = {"@Outward_ID"};
            object[] myValue = {Outward_ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("SALES_ORDER_GetSX", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_Ref_OrgNo = Convert.ToString(myReader["Ref_OrgNo"]);
                    m_RefType = Convert.ToInt32(myReader["RefType"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_Department_ID = Convert.ToString(myReader["Department_ID"]);
                    m_Employee_ID = Convert.ToString(myReader["Employee_ID"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
                    m_Branch_ID = Convert.ToString(myReader["Branch_ID"]);
                    m_Contract_ID = Convert.ToString(myReader["Contract_ID"]);
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"]);
                    m_Contact = Convert.ToString(myReader["Contact"]);
                    m_Reason = Convert.ToString(myReader["Reason"]);
                    m_Payment = Convert.ToInt16(myReader["Payment"]);
                    m_Currency_ID = Convert.ToString(myReader["Currency_ID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_Charge = Convert.ToDecimal(myReader["Charge"]);
                    m_Cost = Convert.ToDecimal(myReader["Cost"]);
                    m_Profit = Convert.ToDecimal(myReader["Profit"]);
                    m_User_ID = Convert.ToString(myReader["User_ID"]);
                    m_IsClose = Convert.ToBoolean(myReader["IsClose"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]==DBNull.Value?"":myReader["Contract_ID"] );
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]==DBNull.Value?"":myReader["Customer_ID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_Contact =Convert.ToString(myReader["Contact"]==DBNull.Value?"":myReader["Contact"] );
						m_Reason =Convert.ToString(myReader["Reason"]==DBNull.Value?"":myReader["Reason"] );
						m_Payment =Convert.ToInt16(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]==DBNull.Value?"":myReader["Currency_ID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Cost =Convert.ToDecimal(myReader["Cost"]==DBNull.Value?0:myReader["Cost"] );
						m_Profit =Convert.ToDecimal(myReader["Profit"]==DBNull.Value?0:myReader["Profit"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif

                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }


        public bool Exist()
        {
            return Exist(
                m_ID);
        }

        public bool Exist(
            SqlTransaction myTransaction)
        {
            return Exist(
                myTransaction,
                m_ID);
        }

        public bool Exist(
            string ID)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Exist(
                mySql.Connection,
                ID))
            {
                mySql.Close();
                return true;
            }
            ;
            return false;
        }


        public bool Exist(
            SqlConnection myConnection,
            string ID)
        {
            bool Result = false;
            string[] myPara = {
                                  "@ID"
                              };
            object[] myValue = {
                                   ID
                               };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "SALES_ORDER_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            else
            {
                mySql.Close();
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        public bool Exist(
            SqlTransaction myTransaction,
            string ID)
        {
            bool Result = false;
            string[] myPara = {"@ID" };
            object[] myValue = {
                                   ID
                               };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "SALES_ORDER_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            else
            {
                mySql.RollBack(myTransaction);
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        #endregion NewID

        #region Get

        public bool Get()
        {
            return Get(
                m_ID);
        }

        public bool Get(SqlConnection myConnection)
        {
            return Get(myConnection,
                       m_ID);
        }

        public bool Get(SqlTransaction myTransaction)
        {
            return Get(
                myTransaction,
                m_ID);
        }

        public bool Get(string ID)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Get(mySql.Connection,ID))
            {
                mySql.Close();
                return true;
            }
            
            return false;
        }

        public bool GetLastInvoice(string CustomerID, DateTime RefDate)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (GetLastInvoice(mySql.Connection, CustomerID, RefDate))
            {
                mySql.Close();
                return true;
            }

            return false;
        }

        public bool GetLastInvoice(SqlConnection myConnection, string Customer_ID, DateTime RefDate)
        {
            bool Result = false;
            string[] myPara = { "@Customer_ID", "@RefDate" };
            object[] myValue = { Customer_ID,RefDate };
            var mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT  TOP(1) *
                        FROM   SALES_ORDER so
                        WHERE  so.RefType = 2
                               AND so.Customer_ID = @Customer_ID
                               AND so.RefDate < @RefDate
                        ORDER BY
                             so.RefDate DESC";
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, sql, myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = Convert.ToString(myReader["ID"] == DBNull.Value ? "" : myReader["ID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"] == DBNull.Value ? DateTime.Now : myReader["RefDate"]);
                    m_Ref_OrgNo = Convert.ToString(myReader["Ref_OrgNo"] == DBNull.Value ? "" : myReader["Ref_OrgNo"]);
                    m_DeliveryDate = Convert.ToDateTime(myReader["DeliveryDate"] == DBNull.Value ? DateTime.Now : myReader["DeliveryDate"]);

                    m_TermID = Convert.ToString(myReader["TermID"] == DBNull.Value ? "" : myReader["TermID"]);
                    m_PaymentMethod = Convert.ToString(myReader["PaymentMethod"] == DBNull.Value ? "" : myReader["PaymentMethod"]);
                    m_PaymentDate = Convert.ToDateTime(myReader["PaymentDate"] == DBNull.Value ? DateTime.Now : myReader["PaymentDate"]);



                    m_RefType = Convert.ToInt32(myReader["RefType"] == DBNull.Value ? 0 : myReader["RefType"]);
                    m_RefStatus = Convert.ToInt32(myReader["RefStatus"] == DBNull.Value ? 0 : myReader["RefStatus"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"] == DBNull.Value ? "" : myReader["Barcode"]);
                    m_Department_ID = Convert.ToString(myReader["Department_ID"] == DBNull.Value ? "" : myReader["Department_ID"]);
                    m_Employee_ID = Convert.ToString(myReader["Employee_ID"] == DBNull.Value ? "" : myReader["Employee_ID"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"] == DBNull.Value ? "" : myReader["Stock_ID"]);
                    m_Branch_ID = Convert.ToString(myReader["Branch_ID"] == DBNull.Value ? "" : myReader["Branch_ID"]);
                    m_Contract_ID = Convert.ToString(myReader["Contract_ID"] == DBNull.Value ? "" : myReader["Contract_ID"]);
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"] == DBNull.Value ? "" : myReader["Customer_ID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"] == DBNull.Value ? "" : myReader["CustomerName"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"] == DBNull.Value ? "" : myReader["CustomerAddress"]);
                    m_Contact = Convert.ToString(myReader["Contact"] == DBNull.Value ? "" : myReader["Contact"]);
                    m_Reason = Convert.ToString(myReader["Reason"] == DBNull.Value ? "" : myReader["Reason"]);
                    m_Payment = Convert.ToInt16(myReader["Payment"] == DBNull.Value ? 0 : myReader["Payment"]);
                    m_Currency_ID =
                        Convert.ToString(myReader["Currency_ID"] == DBNull.Value ? "" : myReader["Currency_ID"]);
                    m_ExchangeRate =
                        Convert.ToDecimal(myReader["ExchangeRate"] == DBNull.Value ? 0 : myReader["ExchangeRate"]);

                    m_Vat = Convert.ToInt32(myReader["Vat"] == DBNull.Value ? 0 : myReader["Vat"]);
                    m_VatAmount = Convert.ToDecimal(myReader["VatAmount"] == DBNull.Value ? 0 : myReader["VatAmount"]);
                    m_DiscountRate =
                        Convert.ToDecimal(myReader["DiscountRate"] == DBNull.Value ? 0 : myReader["DiscountRate"]);


                    m_Amount = Convert.ToDecimal(myReader["Amount"] == DBNull.Value ? 0 : myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"] == DBNull.Value ? 0 : myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"] == DBNull.Value ? 0 : myReader["Discount"]);

                    m_OtherDiscount = Convert.ToDecimal(myReader["OtherDiscount"] == DBNull.Value ? 0 : myReader["OtherDiscount"]);

                    m_Charge = Convert.ToDecimal(myReader["Charge"] == DBNull.Value ? 0 : myReader["Charge"]);
                    m_Cost = Convert.ToDecimal(myReader["Cost"] == DBNull.Value ? 0 : myReader["Cost"]);
                    m_Profit = Convert.ToDecimal(myReader["Profit"] == DBNull.Value ? 0 : myReader["Profit"]);
                    m_User_ID = Convert.ToString(myReader["User_ID"] == DBNull.Value ? "" : myReader["User_ID"]);
                    m_IsClose = Convert.ToBoolean(myReader["IsClose"] == DBNull.Value ? true : myReader["IsClose"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"] == DBNull.Value ? 0 : myReader["Sorted"]);
                    m_Description =
                        Convert.ToString(myReader["Description"] == DBNull.Value ? "" : myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"] == DBNull.Value ? true : myReader["Active"]);
                    m_Notes = Convert.ToString(myReader["Notes"] == DBNull.Value ? "" : myReader["Notes"]);
                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                mySql.Close();
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        public bool Get(SqlConnection myConnection,string ID)
        {
            bool Result = false;
            string[] myPara = {"@ID"};
            object[] myValue = {ID};
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "SALES_ORDER_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = Convert.ToString(myReader["ID"] == DBNull.Value ? "" : myReader["ID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"] == DBNull.Value ? DateTime.Now : myReader["RefDate"]);
                    m_Ref_OrgNo = Convert.ToString(myReader["Ref_OrgNo"] == DBNull.Value ? "" : myReader["Ref_OrgNo"]);
                    m_DeliveryDate = Convert.ToDateTime(myReader["DeliveryDate"] == DBNull.Value ? DateTime.Now : myReader["DeliveryDate"]);

                    m_TermID = Convert.ToString(myReader["TermID"] == DBNull.Value ? "" : myReader["TermID"]);
                    m_PaymentMethod = Convert.ToString(myReader["PaymentMethod"] == DBNull.Value ? "" : myReader["PaymentMethod"]);
                    m_PaymentDate = Convert.ToDateTime(myReader["PaymentDate"] == DBNull.Value ? DateTime.Now : myReader["PaymentDate"]);



                    m_RefType = Convert.ToInt32(myReader["RefType"] == DBNull.Value ? 0 : myReader["RefType"]);
                    m_RefStatus = Convert.ToInt32(myReader["RefStatus"] == DBNull.Value ? 0 : myReader["RefStatus"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"] == DBNull.Value ? "" : myReader["Barcode"]);
                    m_Department_ID =Convert.ToString(myReader["Department_ID"] == DBNull.Value ? "" : myReader["Department_ID"]);
                    m_Employee_ID =Convert.ToString(myReader["Employee_ID"] == DBNull.Value ? "" : myReader["Employee_ID"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"] == DBNull.Value ? "" : myReader["Stock_ID"]);
                    m_Branch_ID = Convert.ToString(myReader["Branch_ID"] == DBNull.Value ? "" : myReader["Branch_ID"]);
                    m_Contract_ID =Convert.ToString(myReader["Contract_ID"] == DBNull.Value ? "" : myReader["Contract_ID"]);
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"] == DBNull.Value ? "" : myReader["Customer_ID"]);
                    m_CustomerName =Convert.ToString(myReader["CustomerName"] == DBNull.Value ? "" : myReader["CustomerName"]);
                    m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"] == DBNull.Value ? "" : myReader["CustomerAddress"]);
                    m_Contact = Convert.ToString(myReader["Contact"] == DBNull.Value ? "" : myReader["Contact"]);
                    m_Reason = Convert.ToString(myReader["Reason"] == DBNull.Value ? "" : myReader["Reason"]);
                    m_Payment = Convert.ToInt16(myReader["Payment"] == DBNull.Value ? 0 : myReader["Payment"]);
                    m_Currency_ID =
                        Convert.ToString(myReader["Currency_ID"] == DBNull.Value ? "" : myReader["Currency_ID"]);
                    m_ExchangeRate =
                        Convert.ToDecimal(myReader["ExchangeRate"] == DBNull.Value ? 0 : myReader["ExchangeRate"]);

                    m_Vat = Convert.ToInt32(myReader["Vat"] == DBNull.Value ? 0 : myReader["Vat"]);
                    m_VatAmount = Convert.ToDecimal(myReader["VatAmount"] == DBNull.Value ? 0 : myReader["VatAmount"]);
                    m_DiscountRate =
                        Convert.ToDecimal(myReader["DiscountRate"] == DBNull.Value ? 0 : myReader["DiscountRate"]);


                    m_Amount = Convert.ToDecimal(myReader["Amount"] == DBNull.Value ? 0 : myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"] == DBNull.Value ? 0 : myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"] == DBNull.Value ? 0 : myReader["Discount"]);
                    m_DiscountDate = Convert.ToDateTime(myReader["DiscountDate"] == DBNull.Value ? DateTime.Now : myReader["DiscountDate"]);
                    m_OtherDiscount = Convert.ToDecimal(myReader["OtherDiscount"] == DBNull.Value ? 0 : myReader["OtherDiscount"]);
                    
                    m_Charge = Convert.ToDecimal(myReader["Charge"] == DBNull.Value ? 0 : myReader["Charge"]);
                    m_Cost = Convert.ToDecimal(myReader["Cost"] == DBNull.Value ? 0 : myReader["Cost"]);
                    m_Profit = Convert.ToDecimal(myReader["Profit"] == DBNull.Value ? 0 : myReader["Profit"]);
                    m_User_ID = Convert.ToString(myReader["User_ID"] == DBNull.Value ? "" : myReader["User_ID"]);
                    m_IsClose = Convert.ToBoolean(myReader["IsClose"] == DBNull.Value ? true : myReader["IsClose"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"] == DBNull.Value ? 0 : myReader["Sorted"]);
                    m_Description =
                        Convert.ToString(myReader["Description"] == DBNull.Value ? "" : myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"] == DBNull.Value ? true : myReader["Active"]);

                    m_Notes = Convert.ToString(myReader["Notes"] == DBNull.Value ? "" : myReader["Notes"]);
                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                mySql.Close();
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        public bool Get(            SqlTransaction myTransaction,
            string ID)
        {
            bool result = false;
            string[] myPara = {"@ID"};
            object[] myValue = {
                                   ID
                               };
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "SALES_ORDER_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = Convert.ToString(myReader["ID"] == DBNull.Value ? "" : myReader["ID"]);
                    m_RefDate =
                        Convert.ToDateTime(myReader["RefDate"] == DBNull.Value ? DateTime.Now : myReader["RefDate"]);
                    m_DeliveryDate = Convert.ToDateTime(myReader["DeliveryDate"] == DBNull.Value ? DateTime.Now : myReader["DeliveryDate"]);

                    m_Ref_OrgNo = Convert.ToString(myReader["Ref_OrgNo"] == DBNull.Value ? "" : myReader["Ref_OrgNo"]);
                    m_RefType = Convert.ToInt32(myReader["RefType"] == DBNull.Value ? 0 : myReader["RefType"]);
                    m_RefStatus = Convert.ToInt32(myReader["RefStatus"] == DBNull.Value ? 0 : myReader["RefStatus"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"] == DBNull.Value ? "" : myReader["Barcode"]);
                    m_Department_ID =
                        Convert.ToString(myReader["Department_ID"] == DBNull.Value ? "" : myReader["Department_ID"]);
                    m_Employee_ID =
                        Convert.ToString(myReader["Employee_ID"] == DBNull.Value ? "" : myReader["Employee_ID"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"] == DBNull.Value ? "" : myReader["Stock_ID"]);
                    m_Branch_ID = Convert.ToString(myReader["Branch_ID"] == DBNull.Value ? "" : myReader["Branch_ID"]);
                    m_Contract_ID =
                        Convert.ToString(myReader["Contract_ID"] == DBNull.Value ? "" : myReader["Contract_ID"]);
                    m_Customer_ID =
                        Convert.ToString(myReader["Customer_ID"] == DBNull.Value ? "" : myReader["Customer_ID"]);
                    m_CustomerName =
                        Convert.ToString(myReader["CustomerName"] == DBNull.Value ? "" : myReader["CustomerName"]);
                    m_CustomerAddress =
                        Convert.ToString(myReader["CustomerAddress"] == DBNull.Value ? "" : myReader["CustomerAddress"]);
                    m_Contact = Convert.ToString(myReader["Contact"] == DBNull.Value ? "" : myReader["Contact"]);
                    m_Reason = Convert.ToString(myReader["Reason"] == DBNull.Value ? "" : myReader["Reason"]);
                    m_Payment = Convert.ToInt16(myReader["Payment"] == DBNull.Value ? 0 : myReader["Payment"]);
                    m_Currency_ID =
                        Convert.ToString(myReader["Currency_ID"] == DBNull.Value ? "" : myReader["Currency_ID"]);
                    m_ExchangeRate =
                        Convert.ToDecimal(myReader["ExchangeRate"] == DBNull.Value ? 0 : myReader["ExchangeRate"]);

                    m_Vat = Convert.ToInt32(myReader["Vat"] == DBNull.Value ? 0 : myReader["Vat"]);
                    m_VatAmount = Convert.ToDecimal(myReader["VatAmount"] == DBNull.Value ? 0 : myReader["VatAmount"]);
                    m_DiscountRate =
                        Convert.ToDecimal(myReader["DiscountRate"] == DBNull.Value ? 0 : myReader["DiscountRate"]);


                    m_Amount = Convert.ToDecimal(myReader["Amount"] == DBNull.Value ? 0 : myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"] == DBNull.Value ? 0 : myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"] == DBNull.Value ? 0 : myReader["Discount"]);
                    m_OtherDiscount = Convert.ToDecimal(myReader["OtherDiscount"] == DBNull.Value ? 0 : myReader["OtherDiscount"]);
                    m_Charge = Convert.ToDecimal(myReader["Charge"] == DBNull.Value ? 0 : myReader["Charge"]);
                    m_Cost = Convert.ToDecimal(myReader["Cost"] == DBNull.Value ? 0 : myReader["Cost"]);
                    m_Profit = Convert.ToDecimal(myReader["Profit"] == DBNull.Value ? 0 : myReader["Profit"]);
                    m_User_ID = Convert.ToString(myReader["User_ID"] == DBNull.Value ? "" : myReader["User_ID"]);
                    m_IsClose = Convert.ToBoolean(myReader["IsClose"] == DBNull.Value ? true : myReader["IsClose"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"] == DBNull.Value ? 0 : myReader["Sorted"]);
                    m_Description =
                        Convert.ToString(myReader["Description"] == DBNull.Value ? "" : myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"] == DBNull.Value ? true : myReader["Active"]);
                    m_Notes = Convert.ToString(myReader["Notes"] == DBNull.Value ? "" : myReader["Notes"]);
                    result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                mySql.RollBack(myTransaction);
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        #endregion

        #region Add

        public bool Insert()
        {
            return Insert(
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Sorted,
                m_Description,
                m_Notes,
                m_Active);
        }

        public bool Insert(SqlTransaction myTransaction)
        {
            return Insert(
                myTransaction,
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_TermID,
                m_PaymentDate,
                m_DeliveryDate,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Vat,
                m_VatAmount,
                m_Amount,
                m_FAmount,
                m_DiscountDate,
                m_DiscountRate,
                m_Discount,
                m_OtherDiscount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Sorted,
                m_Description,
                m_Notes,
                m_Active);
        }

        public bool Insert( SqlConnection myConnection)
        {
            return Insert(
                myConnection,
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Sorted,
                m_Description,
                m_Notes,
                m_Active);
        }

        public bool Insert(
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Insert(
                mySql.Connection,
                ID,
                RefDate,
                Ref_OrgNo,
                RefType,
                Barcode,
                Department_ID,
                Employee_ID,
                Stock_ID,
                Branch_ID,
                Contract_ID,
                Customer_ID,
                CustomerName,
                CustomerAddress,
                Contact,
                Reason,
                Payment,
                Currency_ID,
                ExchangeRate,
                Amount,
                FAmount,
                Discount,
                Charge,
                Cost,
                Profit,
                User_ID,
                IsClose,
                Sorted,
                Description,
                Notes,
                Active))
            {
                mySql.Close();
                return true;
            }
            ;
            return false;
        }

        public bool Insert(
            SqlConnection myConnection,
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@Barcode",
                                  "@Department_ID",
                                  "@Employee_ID",
                                  "@Stock_ID",
                                  "@Branch_ID",
                                  "@Contract_ID",
                                  "@Customer_ID",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@Currency_ID",
                                  "@ExchangeRate",
                                  "@Amount",
                                  "@FAmount",
                                  "@Discount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@User_ID",
                                  "@IsClose",
                                  "@Sorted",
                                  "@Description",
                                  "@Notes",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefDate,
                                   Ref_OrgNo,
                                   RefType,
                                   Barcode,
                                   Department_ID,
                                   Employee_ID,
                                   Stock_ID,
                                   Branch_ID,
                                   Contract_ID,
                                   Customer_ID,
                                   CustomerName,
                                   CustomerAddress,
                                   Contact,
                                   Reason,
                                   Payment,
                                   Currency_ID,
                                   ExchangeRate,
                                   Amount,
                                   FAmount,
                                   Discount,
                                   Charge,
                                   Cost,
                                   Profit,
                                   User_ID,
                                   IsClose,
                                   Sorted,
                                   Description,
                                   Notes,
                                   Active
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "SALES_ORDER_Insert", myPara, myValue) == "OK" ? true : false;
        }

        public bool Insert(
            SqlTransaction myTransaction,
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string TermID,
            DateTime PaymentDate,
            DateTime DeliveryDate,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            int Vat,
            decimal VatAmount,
            decimal Amount,
            decimal FAmount,
            DateTime DiscountDate,
            decimal DiscountRate,
            decimal Discount,
            decimal OtherDiscount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@TermID",
                                  "@PaymentDate",
                                  "@DeliveryDate",
                                  "@Barcode",
                                  "@Department_ID",
                                  "@Employee_ID",
                                  "@Stock_ID",
                                  "@Branch_ID",
                                  "@Contract_ID",
                                  "@Customer_ID",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@Currency_ID",
                                  "@ExchangeRate",
                                  "@Vat",
                                  "@VatAmount",
                                  "@Amount",
                                  "@FAmount",
                                  "@DiscountDate",
                                  "@DiscountRate",
                                  "@Discount",
                                  "@OtherDiscount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@User_ID",
                                  "@IsClose",
                                  "@Sorted",
                                  "@Description",
                                  "@Notes",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefDate,
                                   Ref_OrgNo,
                                   RefType,
                                   RefStatus,
                                   PaymentMethod,
                                   TermID,
                                   PaymentDate,
                                   DeliveryDate,
                                   Barcode,
                                   Department_ID,
                                   Employee_ID,
                                   Stock_ID,
                                   Branch_ID,
                                   Contract_ID,
                                   Customer_ID,
                                   CustomerName,
                                   CustomerAddress,
                                   Contact,
                                   Reason,
                                   Payment,
                                   Currency_ID,
                                   ExchangeRate,
                                   Vat,
                                   VatAmount,
                                   Amount,
                                   FAmount,
                                   DiscountDate,
                                   DiscountRate,
                                   Discount,
                                   OtherDiscount,
                                   Charge,
                                   Cost,
                                   Profit,
                                   User_ID,
                                   IsClose,
                                   Sorted,
                                   Description,
                                   Notes,
                                   Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "SALES_ORDER_Insert", myPara, myValue) == "OK" ? true : false;
        }

        #endregion

        #region Update

        public bool Update()
        {
            return Update(
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Sorted,
                m_Description,
                m_Notes,
                m_Active);
        }

        public bool Update(
            SqlConnection myConnection)
        {
            return Update(
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Sorted,
                m_Description,
                m_Notes,
                m_Active);
        }

        public bool Update(
            SqlTransaction myTransaction)
        {
            return Update(
                myTransaction,
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_TermID,
                m_PaymentDate,
                m_DeliveryDate,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Vat,
                m_VatAmount,
                m_Amount,
                m_FAmount,
                m_DiscountDate,
                m_DiscountRate,
                m_Discount,
                m_OtherDiscount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Sorted,
                m_Description,
                m_Notes,
                m_Active);
        }

        public bool Update(
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (
                Update(
                    mySql.Connection,
                    ID,
                    RefDate,
                    Ref_OrgNo,
                    RefType,
                    Barcode,
                    Department_ID,
                    Employee_ID,
                    Stock_ID,
                    Branch_ID,
                    Contract_ID,
                    Customer_ID,
                    CustomerName,
                    CustomerAddress,
                    Contact,
                    Reason,
                    Payment,
                    Currency_ID,
                    ExchangeRate,
                    Amount,
                    FAmount,
                    Discount,
                    Charge,
                    Cost,
                    Profit,
                    User_ID,
                    IsClose,
                    Sorted,
                    Description,
                    Notes,
                    Active)
                )
            {
                mySql.Close();
                return true;
            }
            return false;
        }

        public bool Update(
            SqlConnection myConnection,
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@Barcode",
                                  "@Department_ID",
                                  "@Employee_ID",
                                  "@Stock_ID",
                                  "@Branch_ID",
                                  "@Contract_ID",
                                  "@Customer_ID",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@Currency_ID",
                                  "@ExchangeRate",
                                  "@Amount",
                                  "@FAmount",
                                  "@Discount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@User_ID",
                                  "@IsClose",
                                  "@Sorted",
                                  "@Description",
                                  "@Notes",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefDate,
                                   Ref_OrgNo,
                                   RefType,
                                   Barcode,
                                   Department_ID,
                                   Employee_ID,
                                   Stock_ID,
                                   Branch_ID,
                                   Contract_ID,
                                   Customer_ID,
                                   CustomerName,
                                   CustomerAddress,
                                   Contact,
                                   Reason,
                                   Payment,
                                   Currency_ID,
                                   ExchangeRate,
                                   Amount,
                                   FAmount,
                                   Discount,
                                   Charge,
                                   Cost,
                                   Profit,
                                   User_ID,
                                   IsClose,
                                   Sorted,
                                   Description,
                                   Notes,
                                   Active
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "SALES_ORDER_Update", myPara, myValue) == "OK" ? true : false;
        }

        public bool Update(
            SqlTransaction myTransaction,
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string TermID,
            DateTime PaymentDate,
            DateTime DeliveryDate,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            int Vat,
            decimal VatAmount,
            decimal Amount,
            decimal FAmount,
            DateTime DiscountDate,
            decimal DiscountRate,
            decimal Discount,
            decimal OtherDiscount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            long Sorted,
            string Description,
            string Notes,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@TermID",
                                  "@PaymentDate",
                                  "@DeliveryDate",
                                  "@Barcode",
                                  "@Department_ID",
                                  "@Employee_ID",
                                  "@Stock_ID",
                                  "@Branch_ID",
                                  "@Contract_ID",
                                  "@Customer_ID",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@Currency_ID",
                                  "@ExchangeRate",
                                  "@Vat",
                                  "@VatAmount",
                                  "@Amount",
                                  "@FAmount",
                                  "@DiscountDate",
                                  "@DiscountRate",
                                  "@Discount",
                                  "@OtherDiscount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@User_ID",
                                  "@IsClose",
                                  "@Sorted",
                                  "@Description",
                                  "@Notes",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID, RefDate, Ref_OrgNo, RefType, RefStatus, PaymentMethod, TermID, PaymentDate,
                                   DeliveryDate, Barcode, Department_ID, Employee_ID, Stock_ID, Branch_ID, Contract_ID,
                                   Customer_ID, CustomerName, CustomerAddress, Contact, Reason, Payment, Currency_ID,
                                   ExchangeRate, Vat, VatAmount, Amount, FAmount, DiscountDate, DiscountRate, Discount,
                                   OtherDiscount, Charge, Cost, Profit, User_ID, IsClose, Sorted, Description,Notes, Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "SALES_ORDER_Update", myPara, myValue) == "OK" ? true : false;
        }

        #endregion

        #region UpdateByID

        public bool UpdateByID()
        {
            return UpdateByID(
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Description,
                m_Active);
        }

        public bool UpdateByID(
            SqlConnection myConnection)
        {
            return UpdateByID(
                myConnection,
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Description,
                m_Active);
        }

        public bool UpdateByID(
            SqlTransaction myTransaction)
        {
            return UpdateByID(
                myTransaction,
                m_ID,
                m_RefDate,
                m_Ref_OrgNo,
                m_RefType,
                m_Barcode,
                m_Department_ID,
                m_Employee_ID,
                m_Stock_ID,
                m_Branch_ID,
                m_Contract_ID,
                m_Customer_ID,
                m_CustomerName,
                m_CustomerAddress,
                m_Contact,
                m_Reason,
                m_Payment,
                m_Currency_ID,
                m_ExchangeRate,
                m_Amount,
                m_FAmount,
                m_Discount,
                m_Charge,
                m_Cost,
                m_Profit,
                m_User_ID,
                m_IsClose,
                m_Description,
                m_Active);
        }

        public bool UpdateByID(
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            string Description,
            bool Active)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (UpdateByID(mySql.Connection,
                           ID,
                           RefDate,
                           Ref_OrgNo,
                           RefType,
                           Barcode,
                           Department_ID,
                           Employee_ID,
                           Stock_ID,
                           Branch_ID,
                           Contract_ID,
                           Customer_ID,
                           CustomerName,
                           CustomerAddress,
                           Contact,
                           Reason,
                           Payment,
                           Currency_ID,
                           ExchangeRate,
                           Amount,
                           FAmount,
                           Discount,
                           Charge,
                           Cost,
                           Profit,
                           User_ID,
                           IsClose,
                           Description,
                           Active))
            {
                mySql.Close();
                return true;
            }
            ;
            return false;
        }

        public bool UpdateByID(
            SqlConnection myConnection,
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            string Description,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@Barcode",
                                  "@Department_ID",
                                  "@Employee_ID",
                                  "@Stock_ID",
                                  "@Branch_ID",
                                  "@Contract_ID",
                                  "@Customer_ID",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@Currency_ID",
                                  "@ExchangeRate",
                                  "@Amount",
                                  "@FAmount",
                                  "@Discount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@User_ID",
                                  "@IsClose",
                                  "@Description",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefDate,
                                   Ref_OrgNo,
                                   RefType,
                                   Barcode,
                                   Department_ID,
                                   Employee_ID,
                                   Stock_ID,
                                   Branch_ID,
                                   Contract_ID,
                                   Customer_ID,
                                   CustomerName,
                                   CustomerAddress,
                                   Contact,
                                   Reason,
                                   Payment,
                                   Currency_ID,
                                   ExchangeRate,
                                   Amount,
                                   FAmount,
                                   Discount,
                                   Charge,
                                   Cost,
                                   Profit,
                                   User_ID,
                                   IsClose,
                                   Description,
                                   Active
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "SALES_ORDER_UpdateByID", myPara, myValue) == "OK"
                       ? true
                       : false;
        }

        public bool UpdateByID(
            SqlTransaction myTransaction,
            string ID,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string Department_ID,
            string Employee_ID,
            string Stock_ID,
            string Branch_ID,
            string Contract_ID,
            string Customer_ID,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            string Currency_ID,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            string User_ID,
            bool IsClose,
            string Description,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@Barcode",
                                  "@Department_ID",
                                  "@Employee_ID",
                                  "@Stock_ID",
                                  "@Branch_ID",
                                  "@Contract_ID",
                                  "@Customer_ID",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@Currency_ID",
                                  "@ExchangeRate",
                                  "@Amount",
                                  "@FAmount",
                                  "@Discount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@User_ID",
                                  "@IsClose",
                                  "@Description",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefDate,
                                   Ref_OrgNo,
                                   RefType,
                                   Barcode,
                                   Department_ID,
                                   Employee_ID,
                                   Stock_ID,
                                   Branch_ID,
                                   Contract_ID,
                                   Customer_ID,
                                   CustomerName,
                                   CustomerAddress,
                                   Contact,
                                   Reason,
                                   Payment,
                                   Currency_ID,
                                   ExchangeRate,
                                   Amount,
                                   FAmount,
                                   Discount,
                                   Charge,
                                   Cost,
                                   Profit,
                                   User_ID,
                                   IsClose,
                                   Description,
                                   Active
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "SALES_ORDER_UpdateByID", myPara, myValue) == "OK"
                       ? true
                       : false;
        }

        #endregion

        #region Delete

        public bool Delete()
        {
            return Delete(
                m_ID);
        }

        public bool Delete(
            SqlConnection myConnection)
        {
            return Delete(
                myConnection,
                m_ID);
        }

        public bool Delete(
            SqlTransaction myTransaction)
        {
            return Delete(
                myTransaction,
                m_ID);
        }

        public bool Delete(
            string ID)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Delete(
                mySql.Connection,
                ID))
            {
                mySql.Close();
                return true;
            }
            ;
            return false;
        }

        public bool Delete(
            SqlConnection myConnection,
            string ID)
        {
            string[] myPara = {
                                  "@ID"
                              };
            object[] myValue = {
                                   ID
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "SALES_ORDER_Delete", myPara, myValue) == "OK" ? true : false;
        }

        public bool Delete(
            SqlTransaction myTransaction,
            string ID)
        {
            string[] myPara = {
                                  "@ID"
                              };
            object[] myValue = {
                                   ID
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "SALES_ORDER_Delete", myPara, myValue) == "OK" ? true : false;
        }


        public string DeleteSale(SqlTransaction myTransaction, string ID)
        {
            string[] myPara = {"@ID"};
            object[] myValue = {ID};
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "SALES_ORDER_DeleteSale", myPara, myValue);
        }

        public string DeleteNo(SqlTransaction myTransaction, string Inward_ID)
        {
            string[] myPara = {"@OutwardNo"};
            object[] myValue = {Inward_ID};
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "SALES_ORDER_DeleteNo", myPara, myValue);
        }

        #endregion

        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("SALES_ORDER_GetList");
        }

        public DataTable GetListDebtByCustomer(string CustomerID, string OutwardID)
        {
            string[] myPara = { "@CustomerID" , "@OutwardID"};
            object[] myValue = { CustomerID, OutwardID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            mySql.Error += DispError;

            string myQuery = @"SELECT CASE WHEN SUM(d.Balance) IS NULL THEN 0 ELSE SUM(d.Balance) END AS [TotalDebt]
                                FROM   DEBT d
                                WHERE  d.RefType IN (2, 31)
                                       AND d.Balance <> 0
                                       AND d.CustomerID = @CustomerID
	                                   AND d.RefID <> @OutwardID";
            return mySql.ExecuteDataTable(myQuery, myPara, myValue);
        }
        #endregion

        #region GetList Connection

        public DataTable GetList(SqlConnection myConnection)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myConnection, "SALES_ORDER_GetList");
        }

        #endregion

        #region GetList Transaction

        public DataTable GetList(SqlTransaction myTransaction)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myTransaction, "SALES_ORDER_GetList");
        }

        public DataTable GetList_ByDate(DateTime FromDate, DateTime ToDate, int Type)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = {"@FromDate", "@ToDate", "@MoneyType"};
            object[] myValue = {FromDate, ToDate, Type};
            return mysql.ExecuteDataTable("SALES_ORDER_GetList_ByDate", myPara, myValue);
        }

        public DataTable GetList_ByDate_Action(DateTime FromDate, DateTime ToDate, int Type, int @Action)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = {"@FromDate", "@ToDate", "@MoneyType", "@Action"};
            object[] myValue = {FromDate, ToDate, Type, Action};
            return mysql.ExecuteDataTable("SALES_ORDER_GetList_ByDate_Action", myPara, myValue);
        }

        public DataTable GetListSX(string id)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = {"@Outward_ID"};
            object[] myValue = {id};
            return mysql.ExecuteDataTable("SALES_ORDER_GetSX", myPara, myValue);
        }

        #endregion

        #region Count

        public int Count()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return 0;
            int _count = Count(
                mySql.Connection);

            mySql.Close();
            return _count;
        }


        public int Count(
            SqlConnection myConnection)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteScalar(myConnection, "SALES_ORDER_Count", 0);
        }

        public int Count(
            SqlTransaction myTransaction)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteScalar(myTransaction, "SALES_ORDER_Count", 0);
        }

        #endregion Count

        #region Search

        public DataTable Search(
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            bool IsClose,
            string Description)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return null;
            return Search(
                mySql.Connection,
                RefDate,
                Ref_OrgNo,
                RefType,
                Barcode,
                CustomerName,
                CustomerAddress,
                Contact,
                Reason,
                Payment,
                ExchangeRate,
                Amount,
                FAmount,
                Discount,
                Charge,
                Cost,
                Profit,
                IsClose,
                Description);
            return null;
        }

        #endregion

        #region Search Connection

        public DataTable Search(
            SqlConnection myConnection,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            bool IsClose,
            string Description)
        {
            string[] myPara = {
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@Barcode",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@ExchangeRate",
                                  "@Amount",
                                  "@FAmount",
                                  "@Discount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@IsClose",
                                  "@Description"
                              };
            object[] myValue = {
                                   "%" + RefDate + "%",
                                   "%" + Ref_OrgNo + "%",
                                   "%" + RefType + "%",
                                   "%" + Barcode + "%",
                                   "%" + CustomerName + "%",
                                   "%" + CustomerAddress + "%",
                                   "%" + Contact + "%",
                                   "%" + Reason + "%",
                                   "%" + Payment + "%",
                                   "%" + ExchangeRate + "%",
                                   "%" + Amount + "%",
                                   "%" + FAmount + "%",
                                   "%" + Discount + "%",
                                   "%" + Charge + "%",
                                   "%" + Cost + "%",
                                   "%" + Profit + "%",
                                   "%" + IsClose + "%",
                                   "%" + Description + "%"
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myConnection, "SALES_ORDER_Search", myPara, myValue);
        }

        #endregion

        #region Search Transaction

        public DataTable Search(
            SqlTransaction myTransaction,
            DateTime RefDate,
            string Ref_OrgNo,
            int RefType,
            string Barcode,
            string CustomerName,
            string CustomerAddress,
            string Contact,
            string Reason,
            int Payment,
            decimal ExchangeRate,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal Charge,
            decimal Cost,
            decimal Profit,
            bool IsClose,
            string Description)
        {
            string[] myPara = {
                                  "@RefDate",
                                  "@Ref_OrgNo",
                                  "@RefType",
                                  "@Barcode",
                                  "@CustomerName",
                                  "@CustomerAddress",
                                  "@Contact",
                                  "@Reason",
                                  "@Payment",
                                  "@ExchangeRate",
                                  "@Amount",
                                  "@FAmount",
                                  "@Discount",
                                  "@Charge",
                                  "@Cost",
                                  "@Profit",
                                  "@IsClose",
                                  "@Description"
                              };
            object[] myValue = {
                                   "%" + RefDate + "%",
                                   "%" + Ref_OrgNo + "%",
                                   "%" + RefType + "%",
                                   "%" + Barcode + "%",
                                   "%" + CustomerName + "%",
                                   "%" + CustomerAddress + "%",
                                   "%" + Contact + "%",
                                   "%" + Reason + "%",
                                   "%" + Payment + "%",
                                   "%" + ExchangeRate + "%",
                                   "%" + Amount + "%",
                                   "%" + FAmount + "%",
                                   "%" + Discount + "%",
                                   "%" + Charge + "%",
                                   "%" + Cost + "%",
                                   "%" + Profit + "%",
                                   "%" + IsClose + "%",
                                   "%" + Description + "%"
                               };
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myTransaction, "SALES_ORDER_Search", myPara, myValue);
        }

        #endregion

        #region Insert Combo

        #region LookUp

        public DataTable LookUp()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("SALES_ORDER_LookUp");
        }

        #endregion

        public void AddCombo(System.Windows.Forms.ComboBox combo)
        {
            AddCombo(combo, LookUp());
        }

        public void AddCombo(System.Windows.Forms.ComboBox combo, System.Data.DataTable dt)
        {
            MyLib.TableToComboBox(combo, dt, "ID", "Name");
        }

        public void AddComboAll(System.Windows.Forms.ComboBox combo)
        {
            AddComboAll(combo, "(Tất cả)");
        }

        public void AddComboDefault(System.Windows.Forms.ComboBox combo)
        {
            AddComboAll(combo, "(Mặc định)");
        }

        public void AddComboAll(System.Windows.Forms.ComboBox combo, string text)
        {
            DataTable dt = new DataTable();
            dt = LookUp();
            DataRow b = dt.NewRow();
            b["ID"] = "All";
            b["Name"] = text;
            dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "ID", "Name");
        }

        #endregion

        #region Error

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
         
        public string ChangedInfo(string ID, DateTime RefDate, string Status, string CarNumber)
        {
            string[] myPara = { "@ID", "RefDate", "@Status","@CarNumber" };
            object[] myValue = { ID, RefDate, Status, CarNumber };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"UPDATE SALES_ORDER
	SET    RefDate = @RefDate,
		   Branch_ID = @CarNumber,
	       [Description] = @Status
	WHERE  ID = @ID
	
	UPDATE DEBT
	SET    RefDate = @RefDate,
	       [Description] = @Status
	WHERE  RefType = 2
	       AND RefID = @ID
	
	UPDATE TRANS_REF
	SET    RefDate           = @RefDate,
	       [Description]     = @Status
	WHERE  RefType           = 2
	       AND RefID         = @ID";
 
            return mySql.ExecuteNonQuery(sql, myPara, myValue);

            //mySql.CommandType = CommandType.StoredProcedure;
            //return mySql.ExecuteNonQuery("SALES_ORDER_UpdateInfo", myPara, myValue);
             
        }
        public string PrintOptionInfoUpdate(string ID, string PrintOption)
        {
            string[] myPara = { "@ID", "@PrintOption" };
            object[] myValue = { ID, PrintOption };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"UPDATE SALES_ORDER SET Stock_ID = @PrintOption WHERE ID = @ID ";
            return mySql.ExecuteNonQuery(sql, myPara, myValue);

        }

        
    }

    #region Enum Fields

    public enum SALES_ORDERFields
    {
        ID,
        RefDate,
        Ref_OrgNo,
        RefType,
        Barcode,
        Department_ID,
        Employee_ID,
        Stock_ID,
        Branch_ID,
        Contract_ID,
        Customer_ID,
        CustomerName,
        CustomerAddress,
        Contact,
        Reason,
        Payment,
        Currency_ID,
        ExchangeRate,
        Amount,
        FAmount,
        Discount,
        Charge,
        Cost,
        Profit,
        User_ID,
        IsClose,
        Sorted,
        Description,
        Active
    }

    #endregion

    #region Class Collection

    public class SALES_ORDERCollection : System.Collections.CollectionBase
    {
        [Description("Adds a new SALES_ORDER to the collection.")]
        public int Add(SALES_ORDER item)
        {
            int newindex = List.Add(item);
            return newindex;
        }

        [Description("Removes a SALES_ORDER from the collection.")]
        public void Remove(SALES_ORDER item)
        {
            List.Remove(item);
        }

        [Description("Inserts an SALES_ORDER into the collection at the specified index..")]
        public void Inserts(int index, SALES_ORDER item)
        {
            List.Insert(index, item);
        }

        [Description("Returns the index value of the BRANCH class in the collection.")]
        public int IndexOf(SALES_ORDER item)
        {
            return List.IndexOf(item);
        }

        [Description("Returns true if the SALES_ORDER class is present in the collection.")]
        public bool Contains(SALES_ORDER item)
        {
            return List.Contains(item);
        }
    }

    #endregion
}