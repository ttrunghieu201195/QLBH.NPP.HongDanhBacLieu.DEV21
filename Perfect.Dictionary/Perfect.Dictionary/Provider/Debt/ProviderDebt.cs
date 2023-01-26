using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Perfect.Dictionary.Provider.Debt
{
    public class ProviderDebt
    {
        #region Init

        private bool m_Active;
        private decimal m_Amount;
        private decimal m_Balance;
        private string m_CreatedBy;
        private DateTime m_CreatedDate;
        private string m_CurrencyID;
        private string m_CustomerID;
        private string m_Description;
        private decimal m_Discount;
        private DateTime m_DueDate;
        private decimal m_ExchangeRate;
        private decimal m_FAmount;
        private decimal m_FBalance;
        private decimal m_FDiscount;
        private decimal m_FPayment;
        private string m_ID;
        private bool m_IsChanged;
        private bool m_IsPublic;
        private string m_ModifiedBy;
        private DateTime m_ModifiedDate;
        private string m_OwnerID;
        private decimal m_Payment;
        private string m_PaymentMethod;
        private string m_ProductID;
        private string m_ProductName;
        private decimal m_Quantity;
        private decimal m_ReQuantity;
        private DateTime m_RefDate;
        private string m_RefID;
        private string m_RefOrgNo;
        private int m_RefStatus;
        private int m_RefType;
        private long m_Sorted;
        private string m_TermID;


        public ProviderDebt()
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = "";
            m_RefID = "";
            m_RefDate = DateTime.Now;
            m_RefOrgNo = "";
            m_RefType = 0;
            m_RefStatus = 0;
            m_PaymentMethod = "";
            m_CustomerID = "";
            m_ProductID = "";
            m_ProductName = "";
            m_CurrencyID = "";
            m_ExchangeRate = 0;
            m_TermID = "";
            m_DueDate = DateTime.Now;
            m_Quantity = 0;
            m_ReQuantity = 0;
            m_Amount = 0;
            m_Payment = 0;
            m_Balance = 0;
            m_FAmount = 0;
            m_FPayment = 0;
            m_FBalance = 0;
            m_Discount = 0;
            m_FDiscount = 0;
            m_IsChanged = true;
            m_IsPublic = true;
            m_CreatedBy = "";
            m_CreatedDate = DateTime.Now;
            m_ModifiedBy = "";
            m_ModifiedDate = DateTime.Now;
            m_OwnerID = "";
            m_Description = "";
            m_Sorted = 0;
            m_Active = true;
        }

        public ProviderDebt(
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_RefID = RefID;
            m_RefDate = RefDate;
            m_RefOrgNo = RefOrgNo;
            m_RefType = RefType;
            m_RefStatus = RefStatus;
            m_PaymentMethod = PaymentMethod;
            m_CustomerID = CustomerID;
            m_ProductID = ProductID;
            m_ProductName = ProductName;
            m_CurrencyID = CurrencyID;
            m_ExchangeRate = ExchangeRate;
            m_TermID = TermID;
            m_DueDate = DueDate;
            m_Quantity = Quantity;
            m_ReQuantity = ReQuantity;
            m_Amount = Amount;
            m_Payment = Payment;
            m_Balance = Balance;
            m_FAmount = FAmount;
            m_FPayment = FPayment;
            m_FBalance = FBalance;
            m_Discount = Discount;
            m_FDiscount = FDiscount;
            m_IsChanged = IsChanged;
            m_IsPublic = IsPublic;
            m_CreatedBy = CreatedBy;
            m_CreatedDate = CreatedDate;
            m_ModifiedBy = ModifiedBy;
            m_ModifiedDate = ModifiedDate;
            m_OwnerID = OwnerID;
            m_Description = Description;
            m_Sorted = Sorted;
            m_Active = Active;
        }


        public void SetData(
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_RefID = RefID;
            m_RefDate = RefDate;
            m_RefOrgNo = RefOrgNo;
            m_RefType = RefType;
            m_RefStatus = RefStatus;
            m_PaymentMethod = PaymentMethod;
            m_CustomerID = CustomerID;
            m_ProductID = ProductID;
            m_ProductName = ProductName;
            m_CurrencyID = CurrencyID;
            m_ExchangeRate = ExchangeRate;
            m_TermID = TermID;
            m_DueDate = DueDate;
            m_Quantity = Quantity;
            m_ReQuantity = ReQuantity;
            m_Amount = Amount;
            m_Payment = Payment;
            m_Balance = Balance;
            m_FAmount = FAmount;
            m_FPayment = FPayment;
            m_FBalance = FBalance;
            m_Discount = Discount;
            m_FDiscount = FDiscount;
            m_IsChanged = IsChanged;
            m_IsPublic = IsPublic;
            m_CreatedBy = CreatedBy;
            m_CreatedDate = CreatedDate;
            m_ModifiedBy = ModifiedBy;
            m_ModifiedDate = ModifiedDate;
            m_OwnerID = OwnerID;
            m_Description = Description;
            m_Sorted = Sorted;
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

        [DisplayName("RefID")]
        [Category("Column")]
        public string RefID
        {
            get { return m_RefID; }
            set { m_RefID = value; }
        }

        [DisplayName("RefDate")]
        [Category("Column")]
        public DateTime RefDate
        {
            get { return m_RefDate; }
            set { m_RefDate = value; }
        }

        [DisplayName("RefOrgNo")]
        [Category("Column")]
        public string RefOrgNo
        {
            get { return m_RefOrgNo; }
            set { m_RefOrgNo = value; }
        }

        [DisplayName("RefType")]
        [Category("Column")]
        public int RefType
        {
            get { return m_RefType; }
            set { m_RefType = value; }
        }

        [DisplayName("RefStatus")]
        [Category("Column")]
        public int RefStatus
        {
            get { return m_RefStatus; }
            set { m_RefStatus = value; }
        }

        [DisplayName("PaymentMethod")]
        [Category("Column")]
        public string PaymentMethod
        {
            get { return m_PaymentMethod; }
            set { m_PaymentMethod = value; }
        }

        [DisplayName("CustomerID")]
        [Category("Column")]
        public string CustomerID
        {
            get { return m_CustomerID; }
            set { m_CustomerID = value; }
        }

        [DisplayName("ProductID")]
        [Category("Column")]
        public string ProductID
        {
            get { return m_ProductID; }
            set { m_ProductID = value; }
        }

        [DisplayName("ProductName")]
        [Category("Column")]
        public string ProductName
        {
            get { return m_ProductName; }
            set { m_ProductName = value; }
        }

        [DisplayName("CurrencyID")]
        [Category("Column")]
        public string CurrencyID
        {
            get { return m_CurrencyID; }
            set { m_CurrencyID = value; }
        }

        [DisplayName("ExchangeRate")]
        [Category("Column")]
        public decimal ExchangeRate
        {
            get { return m_ExchangeRate; }
            set { m_ExchangeRate = value; }
        }

        [DisplayName("TermID")]
        [Category("Column")]
        public string TermID
        {
            get { return m_TermID; }
            set { m_TermID = value; }
        }

        [DisplayName("DueDate")]
        [Category("Column")]
        public DateTime DueDate
        {
            get { return m_DueDate; }
            set { m_DueDate = value; }
        }

        [DisplayName("Quantity")]
        [Category("Column")]
        public decimal Quantity
        {
            get { return m_Quantity; }
            set { m_Quantity = value; }
        }

        [DisplayName("ReQuantity")]
        [Category("Column")]
        public decimal ReQuantity
        {
            get { return m_ReQuantity; }
            set { m_ReQuantity = value; }
        }

        [DisplayName("Amount")]
        [Category("Column")]
        public decimal Amount
        {
            get { return m_Amount; }
            set { m_Amount = value; }
        }

        [DisplayName("Payment")]
        [Category("Column")]
        public decimal Payment
        {
            get { return m_Payment; }
            set { m_Payment = value; }
        }

        [DisplayName("Balance")]
        [Category("Column")]
        public decimal Balance
        {
            get { return m_Balance; }
            set { m_Balance = value; }
        }

        [DisplayName("FAmount")]
        [Category("Column")]
        public decimal FAmount
        {
            get { return m_FAmount; }
            set { m_FAmount = value; }
        }

        [DisplayName("FPayment")]
        [Category("Column")]
        public decimal FPayment
        {
            get { return m_FPayment; }
            set { m_FPayment = value; }
        }

        [DisplayName("FBalance")]
        [Category("Column")]
        public decimal FBalance
        {
            get { return m_FBalance; }
            set { m_FBalance = value; }
        }

        [DisplayName("Discount")]
        [Category("Column")]
        public decimal Discount
        {
            get { return m_Discount; }
            set { m_Discount = value; }
        }

        [DisplayName("FDiscount")]
        [Category("Column")]
        public decimal FDiscount
        {
            get { return m_FDiscount; }
            set { m_FDiscount = value; }
        }

        [DisplayName("IsChanged")]
        [Category("Column")]
        public bool IsChanged
        {
            get { return m_IsChanged; }
            set { m_IsChanged = value; }
        }

        [DisplayName("IsPublic")]
        [Category("Column")]
        public bool IsPublic
        {
            get { return m_IsPublic; }
            set { m_IsPublic = value; }
        }

        [DisplayName("CreatedBy")]
        [Category("Column")]
        public string CreatedBy
        {
            get { return m_CreatedBy; }
            set { m_CreatedBy = value; }
        }

        [DisplayName("CreatedDate")]
        [Category("Column")]
        public DateTime CreatedDate
        {
            get { return m_CreatedDate; }
            set { m_CreatedDate = value; }
        }

        [DisplayName("ModifiedBy")]
        [Category("Column")]
        public string ModifiedBy
        {
            get { return m_ModifiedBy; }
            set { m_ModifiedBy = value; }
        }

        [DisplayName("ModifiedDate")]
        [Category("Column")]
        public DateTime ModifiedDate
        {
            get { return m_ModifiedDate; }
            set { m_ModifiedDate = value; }
        }

        [DisplayName("OwnerID")]
        [Category("Column")]
        public string OwnerID
        {
            get { return m_OwnerID; }
            set { m_OwnerID = value; }
        }

        [DisplayName("Description")]
        [Category("Column")]
        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
        }

        [DisplayName("Sorted")]
        [Category("Column")]
        public long Sorted
        {
            get { return m_Sorted; }
            set { m_Sorted = value; }
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
            get { return "Class PROVIDER_DEBT"; }
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
            return SqlHelper.GenCode("PROVIDER_DEBT", "PROVIDER_DEBTID", key);
        }

        public string NewID(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, "PROVIDER_DEBT", "PROVIDER_DEBTID", key);
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
            var mySql = new SqlHelper();
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
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "PROVIDER_DEBT_Get", myPara, myValue);
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
            string[] myPara = {
                                  "@ID"
                              };
            object[] myValue = {
                                   ID
                               };
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "PROVIDER_DEBT_Get", myPara, myValue);
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

        #region Exist By ID

        public bool ExistByID()
        {
            return ExistByID(m_RefID);
        }


        public bool ExistByID(string ID)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (ExistByID(mySql.Connection, ID))
            {
                mySql.Close();
                return true;
            }
            return false;
        }


        public bool ExistByID(SqlTransaction myTransaction, string ID)
        {
            bool Result = false;
            string[] myPara = {"@RefID"};
            object[] myValue = {ID};
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "PROVIDER_DEBT_ExistByID", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader = null;
            }
            return Result;
        }

        public bool ExistByID(
            SqlConnection myConnection,
            string ID)
        {
            bool Result = false;
            string[] myPara = {"@RefID"};
            object[] myValue = {ID};
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "PROVIDER_DEBT_ExistByID", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            return Result;
        }

        #endregion

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

        public bool Get(
            string ID)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Get(
                mySql.Connection,
                ID))
            {
                mySql.Close();
                return true;
            }
            ;
            return false;
        }

        public bool Get(
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
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "PROVIDER_DEBT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = Convert.ToString(myReader["RefOrgNo"]);
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = Convert.ToString(myReader["PaymentMethod"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_ProductID = Convert.ToString(myReader["ProductID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_TermID = Convert.ToString(myReader["TermID"]);
                    m_DueDate = Convert.ToDateTime(myReader["DueDate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_ReQuantity = Convert.ToDecimal(myReader["ReQuantity"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_Balance = Convert.ToDecimal(myReader["Balance"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_FPayment = Convert.ToDecimal(myReader["FPayment"]);
                    m_FBalance = Convert.ToDecimal(myReader["FBalance"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_FDiscount = Convert.ToDecimal(myReader["FDiscount"]);
                    m_IsChanged = Convert.ToBoolean(myReader["IsChanged"]);
                    m_IsPublic = Convert.ToBoolean(myReader["IsPublic"]);
                    m_CreatedBy = Convert.ToString(myReader["CreatedBy"]);
                    m_CreatedDate = Convert.ToDateTime(myReader["CreatedDate"]);
                    m_ModifiedBy = Convert.ToString(myReader["ModifiedBy"]);
                    m_ModifiedDate = Convert.ToDateTime(myReader["ModifiedDate"]);
                    m_OwnerID = Convert.ToString(myReader["OwnerID"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_ProductID =Convert.ToString(myReader["ProductID"]==DBNull.Value?"":myReader["ProductID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_TermID =Convert.ToString(myReader["TermID"]==DBNull.Value?"":myReader["TermID"] );
						m_DueDate =Convert.ToDateTime(myReader["DueDate"]==DBNull.Value?DateTime.Now:myReader["DueDate"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_ReQuantity =Convert.ToDecimal(myReader["ReQuantity"]==DBNull.Value?0:myReader["ReQuantity"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Balance =Convert.ToDecimal(myReader["Balance"]==DBNull.Value?0:myReader["Balance"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FBalance =Convert.ToDecimal(myReader["FBalance"]==DBNull.Value?0:myReader["FBalance"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_IsChanged =Convert.ToBoolean(myReader["IsChanged"]==DBNull.Value?true:myReader["IsChanged"] );
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
						m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif
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

        public bool Get(
            SqlTransaction myTransaction,
            string ID)
        {
            bool Result = false;
            string[] myPara = {
                                  "@ID"
                              };
            object[] myValue = {
                                   ID
                               };
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "PROVIDER_DEBT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = Convert.ToString(myReader["RefOrgNo"]);
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = Convert.ToString(myReader["PaymentMethod"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_ProductID = Convert.ToString(myReader["ProductID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_TermID = Convert.ToString(myReader["TermID"]);
                    m_DueDate = Convert.ToDateTime(myReader["DueDate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_ReQuantity = Convert.ToDecimal(myReader["ReQuantity"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_Balance = Convert.ToDecimal(myReader["Balance"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_FPayment = Convert.ToDecimal(myReader["FPayment"]);
                    m_FBalance = Convert.ToDecimal(myReader["FBalance"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_FDiscount = Convert.ToDecimal(myReader["FDiscount"]);
                    m_IsChanged = Convert.ToBoolean(myReader["IsChanged"]);
                    m_IsPublic = Convert.ToBoolean(myReader["IsPublic"]);
                    m_CreatedBy = Convert.ToString(myReader["CreatedBy"]);
                    m_CreatedDate = Convert.ToDateTime(myReader["CreatedDate"]);
                    m_ModifiedBy = Convert.ToString(myReader["ModifiedBy"]);
                    m_ModifiedDate = Convert.ToDateTime(myReader["ModifiedDate"]);
                    m_OwnerID = Convert.ToString(myReader["OwnerID"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_ProductID =Convert.ToString(myReader["ProductID"]==DBNull.Value?"":myReader["ProductID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_TermID =Convert.ToString(myReader["TermID"]==DBNull.Value?"":myReader["TermID"] );
						m_DueDate =Convert.ToDateTime(myReader["DueDate"]==DBNull.Value?DateTime.Now:myReader["DueDate"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_ReQuantity =Convert.ToDecimal(myReader["ReQuantity"]==DBNull.Value?0:myReader["ReQuantity"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Balance =Convert.ToDecimal(myReader["Balance"]==DBNull.Value?0:myReader["Balance"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FBalance =Convert.ToDecimal(myReader["FBalance"]==DBNull.Value?0:myReader["FBalance"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_IsChanged =Convert.ToBoolean(myReader["IsChanged"]==DBNull.Value?true:myReader["IsChanged"] );
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
						m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif
                    Result = true;
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
            return Result;
        }

        #endregion

        #region Add

        public bool Insert()
        {
            return Insert(
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_CreatedBy,
                m_CreatedDate,
                m_ModifiedBy,
                m_ModifiedDate,
                m_OwnerID,
                m_Description,
                m_Sorted,
                m_Active);
        }

        public bool Insert(
            SqlTransaction myTransaction)
        {
            return Insert(
                myTransaction,
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_CreatedBy,
                m_CreatedDate,
                m_ModifiedBy,
                m_ModifiedDate,
                m_OwnerID,
                m_Description,
                m_Sorted,
                m_Active);
        }

        public bool Insert(
            SqlConnection myConnection)
        {
            return Insert(
                myConnection,
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_CreatedBy,
                m_CreatedDate,
                m_ModifiedBy,
                m_ModifiedDate,
                m_OwnerID,
                m_Description,
                m_Sorted,
                m_Active);
        }

        public bool Insert(
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Insert(
                mySql.Connection,
                ID,
                RefID,
                RefDate,
                RefOrgNo,
                RefType,
                RefStatus,
                PaymentMethod,
                CustomerID,
                ProductID,
                ProductName,
                CurrencyID,
                ExchangeRate,
                TermID,
                DueDate,
                Quantity,
                ReQuantity,
                Amount,
                Payment,
                Balance,
                FAmount,
                FPayment,
                FBalance,
                Discount,
                FDiscount,
                IsChanged,
                IsPublic,
                CreatedBy,
                CreatedDate,
                ModifiedBy,
                ModifiedDate,
                OwnerID,
                Description,
                Sorted,
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
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@CreatedBy",
                                  "@CreatedDate",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@OwnerID",
                                  "@Description",
                                  "@Sorted",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefID,
                                   RefDate,
                                   RefOrgNo,
                                   RefType,
                                   RefStatus,
                                   PaymentMethod,
                                   CustomerID,
                                   ProductID,
                                   ProductName,
                                   CurrencyID,
                                   ExchangeRate,
                                   TermID,
                                   DueDate,
                                   Quantity,
                                   ReQuantity,
                                   Amount,
                                   Payment,
                                   Balance,
                                   FAmount,
                                   FPayment,
                                   FBalance,
                                   Discount,
                                   FDiscount,
                                   IsChanged,
                                   IsPublic,
                                   CreatedBy,
                                   CreatedDate,
                                   ModifiedBy,
                                   ModifiedDate,
                                   OwnerID,
                                   Description,
                                   Sorted,
                                   Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "PROVIDER_DEBT_Insert", myPara, myValue) == "OK" ? true : false;
        }

        public bool Insert(
            SqlTransaction myTransaction,
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@CreatedBy",
                                  "@CreatedDate",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@OwnerID",
                                  "@Description",
                                  "@Sorted",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefID,
                                   RefDate,
                                   RefOrgNo,
                                   RefType,
                                   RefStatus,
                                   PaymentMethod,
                                   CustomerID,
                                   ProductID,
                                   ProductName,
                                   CurrencyID,
                                   ExchangeRate,
                                   TermID,
                                   DueDate,
                                   Quantity,
                                   ReQuantity,
                                   Amount,
                                   Payment,
                                   Balance,
                                   FAmount,
                                   FPayment,
                                   FBalance,
                                   Discount,
                                   FDiscount,
                                   IsChanged,
                                   IsPublic,
                                   CreatedBy,
                                   CreatedDate,
                                   ModifiedBy,
                                   ModifiedDate,
                                   OwnerID,
                                   Description,
                                   Sorted,
                                   Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "PROVIDER_DEBT_Insert", myPara, myValue) == "OK" ? true : false;
        }


        public string ImportInsert(SqlTransaction myTransaction)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@CreatedBy",
                                  "@CreatedDate",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@OwnerID",
                                  "@Description",
                                  "@Sorted",
                                  "@Active"
                              };

            object[] myValue = {
                                   ID, RefID, RefDate, RefOrgNo, RefType, RefStatus, PaymentMethod, CustomerID, ProductID,
                                   ProductName, CurrencyID, ExchangeRate, TermID, DueDate, Quantity, ReQuantity, Amount,
                                   Payment, Balance, FAmount, FPayment, FBalance, Discount, FDiscount, IsChanged, IsPublic,
                                   CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, OwnerID, Description, Sorted, Active
                               };

            var mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "PROVIDER_DEBT_Update", myPara, myValue);
        }

        #endregion

        #region Update

        public bool Update()
        {
            return Update(
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_CreatedBy,
                m_CreatedDate,
                m_ModifiedBy,
                m_ModifiedDate,
                m_OwnerID,
                m_Description,
                m_Sorted,
                m_Active);
        }

        public bool Update(
            SqlConnection myConnection)
        {
            return Update(
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_CreatedBy,
                m_CreatedDate,
                m_ModifiedBy,
                m_ModifiedDate,
                m_OwnerID,
                m_Description,
                m_Sorted,
                m_Active);
        }

        public bool Update(
            SqlTransaction myTransaction)
        {
            return Update(
                myTransaction,
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_CreatedBy,
                m_CreatedDate,
                m_ModifiedBy,
                m_ModifiedDate,
                m_OwnerID,
                m_Description,
                m_Sorted,
                m_Active);
        }

        public bool Update(
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (
                Update(
                    mySql.Connection,
                    ID,
                    RefID,
                    RefDate,
                    RefOrgNo,
                    RefType,
                    RefStatus,
                    PaymentMethod,
                    CustomerID,
                    ProductID,
                    ProductName,
                    CurrencyID,
                    ExchangeRate,
                    TermID,
                    DueDate,
                    Quantity,
                    ReQuantity,
                    Amount,
                    Payment,
                    Balance,
                    FAmount,
                    FPayment,
                    FBalance,
                    Discount,
                    FDiscount,
                    IsChanged,
                    IsPublic,
                    CreatedBy,
                    CreatedDate,
                    ModifiedBy,
                    ModifiedDate,
                    OwnerID,
                    Description,
                    Sorted,
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
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@CreatedBy",
                                  "@CreatedDate",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@OwnerID",
                                  "@Description",
                                  "@Sorted",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefID,
                                   RefDate,
                                   RefOrgNo,
                                   RefType,
                                   RefStatus,
                                   PaymentMethod,
                                   CustomerID,
                                   ProductID,
                                   ProductName,
                                   CurrencyID,
                                   ExchangeRate,
                                   TermID,
                                   DueDate,
                                   Quantity,
                                   ReQuantity,
                                   Amount,
                                   Payment,
                                   Balance,
                                   FAmount,
                                   FPayment,
                                   FBalance,
                                   Discount,
                                   FDiscount,
                                   IsChanged,
                                   IsPublic,
                                   CreatedBy,
                                   CreatedDate,
                                   ModifiedBy,
                                   ModifiedDate,
                                   OwnerID,
                                   Description,
                                   Sorted,
                                   Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "PROVIDER_DEBT_Update", myPara, myValue) == "OK" ? true : false;
        }

        public bool Update(
            SqlTransaction myTransaction,
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string CreatedBy,
            DateTime CreatedDate,
            string ModifiedBy,
            DateTime ModifiedDate,
            string OwnerID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@CreatedBy",
                                  "@CreatedDate",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@OwnerID",
                                  "@Description",
                                  "@Sorted",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID, RefID, RefDate, RefOrgNo, RefType, RefStatus, PaymentMethod, CustomerID, ProductID,
                                   ProductName, CurrencyID, ExchangeRate, TermID, DueDate, Quantity, ReQuantity, Amount,
                                   Payment, Balance, FAmount, FPayment, FBalance, Discount, FDiscount, IsChanged, IsPublic,
                                   CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, OwnerID, Description, Sorted, Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "PROVIDER_DEBT_Update", myPara, myValue) == "OK" ? true : false;
        }

        #endregion

        #region UpdateByID

        public bool UpdateByID()
        {
            return UpdateByID(
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_ModifiedBy,
                m_ModifiedDate,
                m_Description,
                m_Active);
        }

        public bool UpdateByID(
            SqlConnection myConnection)
        {
            return UpdateByID(
                myConnection,
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_ModifiedBy,
                m_ModifiedDate,
                m_Description,
                m_Active);
        }

        public bool UpdateByID(
            SqlTransaction myTransaction)
        {
            return UpdateByID(
                myTransaction,
                m_ID,
                m_RefID,
                m_RefDate,
                m_RefOrgNo,
                m_RefType,
                m_RefStatus,
                m_PaymentMethod,
                m_CustomerID,
                m_ProductID,
                m_ProductName,
                m_CurrencyID,
                m_ExchangeRate,
                m_TermID,
                m_DueDate,
                m_Quantity,
                m_ReQuantity,
                m_Amount,
                m_Payment,
                m_Balance,
                m_FAmount,
                m_FPayment,
                m_FBalance,
                m_Discount,
                m_FDiscount,
                m_IsChanged,
                m_IsPublic,
                m_ModifiedBy,
                m_ModifiedDate,
                m_Description,
                m_Active);
        }

        public bool UpdateByID(
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string ModifiedBy,
            DateTime ModifiedDate,
            string Description,
            bool Active)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (UpdateByID(mySql.Connection,
                           ID,
                           RefID,
                           RefDate,
                           RefOrgNo,
                           RefType,
                           RefStatus,
                           PaymentMethod,
                           CustomerID,
                           ProductID,
                           ProductName,
                           CurrencyID,
                           ExchangeRate,
                           TermID,
                           DueDate,
                           Quantity,
                           ReQuantity,
                           Amount,
                           Payment,
                           Balance,
                           FAmount,
                           FPayment,
                           FBalance,
                           Discount,
                           FDiscount,
                           IsChanged,
                           IsPublic,
                           ModifiedBy,
                           ModifiedDate,
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
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string ModifiedBy,
            DateTime ModifiedDate,
            string Description,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@Description",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefID,
                                   RefDate,
                                   RefOrgNo,
                                   RefType,
                                   RefStatus,
                                   PaymentMethod,
                                   CustomerID,
                                   ProductID,
                                   ProductName,
                                   CurrencyID,
                                   ExchangeRate,
                                   TermID,
                                   DueDate,
                                   Quantity,
                                   ReQuantity,
                                   Amount,
                                   Payment,
                                   Balance,
                                   FAmount,
                                   FPayment,
                                   FBalance,
                                   Discount,
                                   FDiscount,
                                   IsChanged,
                                   IsPublic,
                                   ModifiedBy,
                                   ModifiedDate,
                                   Description,
                                   Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "PROVIDER_DEBT_UpdateByID", myPara, myValue) == "OK"
                       ? true
                       : false;
        }

        public bool UpdateByID(
            SqlTransaction myTransaction,
            string ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            bool IsPublic,
            string ModifiedBy,
            DateTime ModifiedDate,
            string Description,
            bool Active)
        {
            string[] myPara = {
                                  "@ID",
                                  "@RefID",
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@CustomerID",
                                  "@ProductID",
                                  "@ProductName",
                                  "@CurrencyID",
                                  "@ExchangeRate",
                                  "@TermID",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@IsPublic",
                                  "@ModifiedBy",
                                  "@ModifiedDate",
                                  "@Description",
                                  "@Active"
                              };
            object[] myValue = {
                                   ID,
                                   RefID,
                                   RefDate,
                                   RefOrgNo,
                                   RefType,
                                   RefStatus,
                                   PaymentMethod,
                                   CustomerID,
                                   ProductID,
                                   ProductName,
                                   CurrencyID,
                                   ExchangeRate,
                                   TermID,
                                   DueDate,
                                   Quantity,
                                   ReQuantity,
                                   Amount,
                                   Payment,
                                   Balance,
                                   FAmount,
                                   FPayment,
                                   FBalance,
                                   Discount,
                                   FDiscount,
                                   IsChanged,
                                   IsPublic,
                                   ModifiedBy,
                                   ModifiedDate,
                                   Description,
                                   Active
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "PROVIDER_DEBT_UpdateByID", myPara, myValue) == "OK"
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
            var mySql = new SqlHelper();
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
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "PROVIDER_DEBT_Delete", myPara, myValue) == "OK" ? true : false;
        }

        public bool Delete(SqlTransaction myTransaction, string RefID)
        {
            string[] myPara = {"@RefID"};
            object[] myValue = {RefID};
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "sp_DeleteDebtInit", myPara, myValue) == "OK" ? true : false;
        }

        #endregion

        #region GetList

        public DataTable GetList()
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("PROVIDER_DEBT_GetList");
        }

        #endregion

        #region GetList Connection

        public DataTable GetList(SqlConnection myConnection)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myConnection, "PROVIDER_DEBT_GetList");
        }

        #endregion

        #region GetList Transaction

        public DataTable GetList(SqlTransaction myTransaction)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myTransaction, "PROVIDER_DEBT_GetList");
        }

        #endregion

        #region Count

        public int Count()
        {
            var mySql = new SqlHelper();
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
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteScalar(myConnection, "PROVIDER_DEBT_Count", 0);
        }

        public int Count(
            SqlTransaction myTransaction)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteScalar(myTransaction, "PROVIDER_DEBT_Count", 0);
        }

        #endregion Count

        #region Search

        public DataTable Search(
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string ProductName,
            decimal ExchangeRate,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            string Description)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return null;
            return Search(
                mySql.Connection,
                RefDate,
                RefOrgNo,
                RefType,
                RefStatus,
                PaymentMethod,
                ProductName,
                ExchangeRate,
                DueDate,
                Quantity,
                ReQuantity,
                Amount,
                Payment,
                Balance,
                FAmount,
                FPayment,
                FBalance,
                Discount,
                FDiscount,
                IsChanged,
                Description);
            return null;
        }

        #endregion

        #region Search Connection

        public DataTable Search(
            SqlConnection myConnection,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string ProductName,
            decimal ExchangeRate,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            string Description)
        {
            string[] myPara = {
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@ProductName",
                                  "@ExchangeRate",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@Description"
                              };
            object[] myValue = {
                                   "%" + RefDate + "%",
                                   "%" + RefOrgNo + "%",
                                   "%" + RefType + "%",
                                   "%" + RefStatus + "%",
                                   "%" + PaymentMethod + "%",
                                   "%" + ProductName + "%",
                                   "%" + ExchangeRate + "%",
                                   "%" + DueDate + "%",
                                   "%" + Quantity + "%",
                                   "%" + ReQuantity + "%",
                                   "%" + Amount + "%",
                                   "%" + Payment + "%",
                                   "%" + Balance + "%",
                                   "%" + FAmount + "%",
                                   "%" + FPayment + "%",
                                   "%" + FBalance + "%",
                                   "%" + Discount + "%",
                                   "%" + FDiscount + "%",
                                   "%" + IsChanged + "%",
                                   "%" + Description + "%"
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myConnection, "PROVIDER_DEBT_Search", myPara, myValue);
        }

        #endregion

        #region Search Transaction

        public DataTable Search(
            SqlTransaction myTransaction,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            string PaymentMethod,
            string ProductName,
            decimal ExchangeRate,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Amount,
            decimal Payment,
            decimal Balance,
            decimal FAmount,
            decimal FPayment,
            decimal FBalance,
            decimal Discount,
            decimal FDiscount,
            bool IsChanged,
            string Description)
        {
            string[] myPara = {
                                  "@RefDate",
                                  "@RefOrgNo",
                                  "@RefType",
                                  "@RefStatus",
                                  "@PaymentMethod",
                                  "@ProductName",
                                  "@ExchangeRate",
                                  "@DueDate",
                                  "@Quantity",
                                  "@ReQuantity",
                                  "@Amount",
                                  "@Payment",
                                  "@Balance",
                                  "@FAmount",
                                  "@FPayment",
                                  "@FBalance",
                                  "@Discount",
                                  "@FDiscount",
                                  "@IsChanged",
                                  "@Description"
                              };
            object[] myValue = {
                                   "%" + RefDate + "%",
                                   "%" + RefOrgNo + "%",
                                   "%" + RefType + "%",
                                   "%" + RefStatus + "%",
                                   "%" + PaymentMethod + "%",
                                   "%" + ProductName + "%",
                                   "%" + ExchangeRate + "%",
                                   "%" + DueDate + "%",
                                   "%" + Quantity + "%",
                                   "%" + ReQuantity + "%",
                                   "%" + Amount + "%",
                                   "%" + Payment + "%",
                                   "%" + Balance + "%",
                                   "%" + FAmount + "%",
                                   "%" + FPayment + "%",
                                   "%" + FBalance + "%",
                                   "%" + Discount + "%",
                                   "%" + FDiscount + "%",
                                   "%" + IsChanged + "%",
                                   "%" + Description + "%"
                               };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myTransaction, "PROVIDER_DEBT_Search", myPara, myValue);
        }

        #endregion

        #region Insert Combo

        #region LookUp

        public DataTable LookUp()
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("PROVIDER_DEBT_LookUp");
        }

        #endregion

       

        public void AddComboAll(ComboBox combo, string text)
        {
            var dt = new DataTable();
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
    }

    #region Enum Fields

    #endregion

    #region Class Collection

    #endregion
}