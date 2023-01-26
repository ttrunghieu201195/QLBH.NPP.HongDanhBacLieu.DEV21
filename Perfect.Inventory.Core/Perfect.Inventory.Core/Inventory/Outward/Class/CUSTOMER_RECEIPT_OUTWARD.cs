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
	/// <summary>
	/// Project: Perfect ERP System 
	/// Generated Class for Table : CUSTOMER_RECEIPT.
	/// Date: 16/03/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class CUSTOMER_RECEIPT_OUTWARD:Object
	{
		#region Init
		private Guid m_ID;
		private string m_RefID;
		private DateTime m_RefDate;
		private string m_RefOrgNo;
		private int m_RefType;
		private int m_RefStatus;
		private Guid m_PaymentMethod;
		private string m_Barcode;
		private string m_CurrencyID;
		private decimal m_ExchangeRate;
		private string m_BranchID;
		private string m_ContractID;
		private string m_CustomerID;
		private string m_CustomerName;
		private string m_CustomerAddress;
		private string m_CustomerTax;
		private string m_ContactName;
		private decimal m_Amount;
		private decimal m_FAmount;
		private decimal m_Discount;
		private decimal m_FDiscount;
		private bool m_Reconciled;
		private bool m_IsPublic;
		private string m_CreatedBy;
		private DateTime m_CreatedDate;
		private string m_ModifiedBy;
		private DateTime m_ModifiedDate;
		private string m_OwnerID;
		private string m_Description;
		private long m_Sorted;
		private bool m_Active;


        public CUSTOMER_RECEIPT_OUTWARD()
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = Guid.Empty;
            m_RefID = "";
            m_RefDate = DateTime.Now;
            m_RefOrgNo = "";
            m_RefType = 0;
            m_RefStatus = 0;
            m_PaymentMethod = Guid.Empty;
            m_Barcode = "";
            m_CurrencyID = "";
            m_ExchangeRate = 0;
            m_BranchID = "";
            m_ContractID = "";
            m_CustomerID = "";
            m_CustomerName = "";
            m_CustomerAddress = "";
            m_CustomerTax = "";
            m_ContactName = "";
            m_Amount = 0;
            m_FAmount = 0;
            m_Discount = 0;
            m_FDiscount = 0;
            m_Reconciled = true;
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
        public CUSTOMER_RECEIPT_OUTWARD(
            Guid ID,
            string RefID,
            DateTime RefDate,
            string RefOrgNo,
            int RefType,
            int RefStatus,
            Guid PaymentMethod,
            string Barcode,
            string CurrencyID,
            decimal ExchangeRate,
            string BranchID,
            string ContractID,
            string CustomerID,
            string CustomerName,
            string CustomerAddress,
            string CustomerTax,
            string ContactName,
            decimal Amount,
            decimal FAmount,
            decimal Discount,
            decimal FDiscount,
            bool Reconciled,
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
            m_Barcode = Barcode;
            m_CurrencyID = CurrencyID;
            m_ExchangeRate = ExchangeRate;
            m_BranchID = BranchID;
            m_ContractID = ContractID;
            m_CustomerID = CustomerID;
            m_CustomerName = CustomerName;
            m_CustomerAddress = CustomerAddress;
            m_CustomerTax = CustomerTax;
            m_ContactName = ContactName;
            m_Amount = Amount;
            m_FAmount = FAmount;
            m_Discount = Discount;
            m_FDiscount = FDiscount;
            m_Reconciled = Reconciled;
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
		public Guid ID
		{
			get
			{
				return m_ID;
			}
			set
			{
				m_ID = value;
			}
		}
		[DisplayName("RefID")]
		[Category("Column")]
		public string RefID
		{
			get
			{
				return m_RefID;
			}
			set
			{
				m_RefID = value;
			}
		}
		[DisplayName("RefDate")]
		[Category("Column")]
		public DateTime RefDate
		{
			get
			{
				return m_RefDate;
			}
			set
			{
				m_RefDate = value;
			}
		}
		[DisplayName("RefOrgNo")]
		[Category("Column")]
		public string RefOrgNo
		{
			get
			{
				return m_RefOrgNo;
			}
			set
			{
				m_RefOrgNo = value;
			}
		}
		[DisplayName("RefType")]
		[Category("Column")]
		public int RefType
		{
			get
			{
				return m_RefType;
			}
			set
			{
				m_RefType = value;
			}
		}
		[DisplayName("RefStatus")]
		[Category("Column")]
		public int RefStatus
		{
			get
			{
				return m_RefStatus;
			}
			set
			{
				m_RefStatus = value;
			}
		}
		[DisplayName("PaymentMethod")]
		[Category("Column")]
		public Guid PaymentMethod
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
		[DisplayName("Barcode")]
		[Category("Column")]
		public string Barcode
		{
			get
			{
				return m_Barcode;
			}
			set
			{
				m_Barcode = value;
			}
		}
		[DisplayName("CurrencyID")]
		[Category("Column")]
		public string CurrencyID
		{
			get
			{
				return m_CurrencyID;
			}
			set
			{
				m_CurrencyID = value;
			}
		}
		[DisplayName("ExchangeRate")]
		[Category("Column")]
		public decimal ExchangeRate
		{
			get
			{
				return m_ExchangeRate;
			}
			set
			{
				m_ExchangeRate = value;
			}
		}
		[DisplayName("BranchID")]
		[Category("Column")]
		public string BranchID
		{
			get
			{
				return m_BranchID;
			}
			set
			{
				m_BranchID = value;
			}
		}
		[DisplayName("ContractID")]
		[Category("Column")]
		public string ContractID
		{
			get
			{
				return m_ContractID;
			}
			set
			{
				m_ContractID = value;
			}
		}
		[DisplayName("CustomerID")]
		[Category("Column")]
		public string CustomerID
		{
			get
			{
				return m_CustomerID;
			}
			set
			{
				m_CustomerID = value;
			}
		}
		[DisplayName("CustomerName")]
		[Category("Column")]
		public string CustomerName
		{
			get
			{
				return m_CustomerName;
			}
			set
			{
				m_CustomerName = value;
			}
		}
		[DisplayName("CustomerAddress")]
		[Category("Column")]
		public string CustomerAddress
		{
			get
			{
				return m_CustomerAddress;
			}
			set
			{
				m_CustomerAddress = value;
			}
		}
		[DisplayName("CustomerTax")]
		[Category("Column")]
		public string CustomerTax
		{
			get
			{
				return m_CustomerTax;
			}
			set
			{
				m_CustomerTax = value;
			}
		}
		[DisplayName("ContactName")]
		[Category("Column")]
		public string ContactName
		{
			get
			{
				return m_ContactName;
			}
			set
			{
				m_ContactName = value;
			}
		}
		[DisplayName("Amount")]
		[Category("Column")]
		public decimal Amount
		{
			get
			{
				return m_Amount;
			}
			set
			{
				m_Amount = value;
			}
		}
		[DisplayName("FAmount")]
		[Category("Column")]
		public decimal FAmount
		{
			get
			{
				return m_FAmount;
			}
			set
			{
				m_FAmount = value;
			}
		}
		[DisplayName("Discount")]
		[Category("Column")]
		public decimal Discount
		{
			get
			{
				return m_Discount;
			}
			set
			{
				m_Discount = value;
			}
		}
		[DisplayName("FDiscount")]
		[Category("Column")]
		public decimal FDiscount
		{
			get
			{
				return m_FDiscount;
			}
			set
			{
				m_FDiscount = value;
			}
		}
		[DisplayName("Reconciled")]
		[Category("Column")]
		public bool Reconciled
		{
			get
			{
				return m_Reconciled;
			}
			set
			{
				m_Reconciled = value;
			}
		}
		[DisplayName("IsPublic")]
		[Category("Column")]
		public bool IsPublic
		{
			get
			{
				return m_IsPublic;
			}
			set
			{
				m_IsPublic = value;
			}
		}
		[DisplayName("CreatedBy")]
		[Category("Column")]
		public string CreatedBy
		{
			get
			{
				return m_CreatedBy;
			}
			set
			{
				m_CreatedBy = value;
			}
		}
		[DisplayName("CreatedDate")]
		[Category("Column")]
		public DateTime CreatedDate
		{
			get
			{
				return m_CreatedDate;
			}
			set
			{
				m_CreatedDate = value;
			}
		}
		[DisplayName("ModifiedBy")]
		[Category("Column")]
		public string ModifiedBy
		{
			get
			{
				return m_ModifiedBy;
			}
			set
			{
				m_ModifiedBy = value;
			}
		}
		[DisplayName("ModifiedDate")]
		[Category("Column")]
		public DateTime ModifiedDate
		{
			get
			{
				return m_ModifiedDate;
			}
			set
			{
				m_ModifiedDate = value;
			}
		}
		[DisplayName("OwnerID")]
		[Category("Column")]
		public string OwnerID
		{
			get
			{
				return m_OwnerID;
			}
			set
			{
				m_OwnerID = value;
			}
		}
		[DisplayName("Description")]
		[Category("Column")]
		public string Description
		{
			get
			{
				return m_Description;
			}
			set
			{
				m_Description = value;
			}
		}
		[DisplayName("Sorted")]
		[Category("Column")]
		public long Sorted
		{
			get
			{
				return m_Sorted;
			}
			set
			{
				m_Sorted = value;
			}
		}
		[DisplayName("Active")]
		[Category("Column")]
		public bool Active
		{
			get
			{
				return m_Active;
			}
			set
			{
				m_Active = value;
			}
		}
		public string Product
		{
			get
			{
				return "Class CUSTOMER_RECEIPT";
			}
		}
		public string AssemblyVersion
		{
			get
			{
				return "2.5.0.0";
			}
		}
		public string Copyright
		{
			get
			{
				return "Công Ty Phần Mềm Hoàn Hảo";
			}
		}
		#endregion
		
		#region NewID

		public string NewID()
		{
			return NewID("");
		}

		public string NewID(string key)
		{
			return SqlHelper.GenCode("CUSTOMER_RECEIPT","RefID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"CUSTOMER_RECEIPT","RefID",key);
		}

		public string CreateKey()
		{
			return CreateKey("");
		}

		public string CreateKey(string key)
		{
			return SqlHelper.GenCode(key);
		}

		public string CreateKey(SqlTransaction myTransaction,string key)
		{
			return SqlHelper.GenCode(myTransaction,key);
		}

		public string CreateKey(SqlTransaction myTransaction)
		{
			return SqlHelper.GenCode(myTransaction,"");
		}

		#endregion 


		#region Get

		public bool Get()
		{
			return Get(
			m_ID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
            return Get(myTransaction, m_ID);
		}

        public bool Get(Guid ID)
        {
            bool Result = false;
            string[] myPara = { "@ID" };
            object[] myValue = { ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CUSTOMER_RECEIPT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = Convert.ToString(myReader["RefOrgNo"]);
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = (Guid)(myReader["PaymentMethod"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_BranchID = Convert.ToString(myReader["BranchID"]);
                    m_ContractID = Convert.ToString(myReader["ContractID"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"]);
                    m_CustomerTax = Convert.ToString(myReader["CustomerTax"]);
                    m_ContactName = Convert.ToString(myReader["ContactName"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_FDiscount = Convert.ToDecimal(myReader["FDiscount"]);
                    m_Reconciled = Convert.ToBoolean(myReader["Reconciled"]);
                    m_IsPublic = Convert.ToBoolean(myReader["IsPublic"]);
                    m_CreatedBy = Convert.ToString(myReader["CreatedBy"]);
                    m_CreatedDate = Convert.ToDateTime(myReader["CreatedDate"]);
                    m_ModifiedBy = Convert.ToString(myReader["ModifiedBy"]);
                    m_ModifiedDate = Convert.ToDateTime(myReader["ModifiedDate"]);
                    m_OwnerID = Convert.ToString(myReader["OwnerID"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

		public bool Get(SqlTransaction myTransaction,Guid ID)
		{
			bool Result=false;
            string[] myPara = { "@ID" };
            object[] myValue = { ID };
			SqlHelper mySql=new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "CUSTOMER_RECEIPT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = Convert.ToString(myReader["RefOrgNo"]);
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = (Guid)(myReader["PaymentMethod"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_BranchID = Convert.ToString(myReader["BranchID"]);
                    m_ContractID = Convert.ToString(myReader["ContractID"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"]);
                    m_CustomerTax = Convert.ToString(myReader["CustomerTax"]);
                    m_ContactName = Convert.ToString(myReader["ContactName"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_FDiscount = Convert.ToDecimal(myReader["FDiscount"]);
                    m_Reconciled = Convert.ToBoolean(myReader["Reconciled"]);
                    m_IsPublic = Convert.ToBoolean(myReader["IsPublic"]);
                    m_CreatedBy = Convert.ToString(myReader["CreatedBy"]);
                    m_CreatedDate = Convert.ToDateTime(myReader["CreatedDate"]);
                    m_ModifiedBy = Convert.ToString(myReader["ModifiedBy"]);
                    m_ModifiedDate = Convert.ToDateTime(myReader["ModifiedDate"]);
                    m_OwnerID = Convert.ToString(myReader["OwnerID"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
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
			m_Barcode,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_Amount,
			m_FAmount,
			m_Discount,
			m_FDiscount,
			m_Reconciled,
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
			m_Barcode,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_Amount,
			m_FAmount,
			m_Discount,
			m_FDiscount,
			m_Reconciled,
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
			Guid ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			Guid PaymentMethod,
			string Barcode,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
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
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@Barcode",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@Amount",
			"@FAmount",
			"@Discount",
			"@FDiscount",
			"@Reconciled",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			Barcode,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			Amount,
			FAmount,
			Discount,
			FDiscount,
			Reconciled,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("CUSTOMER_RECEIPT_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			Guid ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			Guid PaymentMethod,
			string Barcode,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
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
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@Barcode",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@Amount",
			"@FAmount",
			"@Discount",
			"@FDiscount",
			"@Reconciled",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			Barcode,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			Amount,
			FAmount,
			Discount,
			FDiscount,
			Reconciled,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "CUSTOMER_RECEIPT_Insert", myPara, myValue) == "OK" ? true : false;
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
			m_Barcode,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_Amount,
			m_FAmount,
			m_Discount,
			m_FDiscount,
			m_Reconciled,
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
			m_Barcode,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_Amount,
			m_FAmount,
			m_Discount,
			m_FDiscount,
			m_Reconciled,
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
			Guid ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			Guid PaymentMethod,
			string Barcode,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
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
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@Barcode",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@Amount",
			"@FAmount",
			"@Discount",
			"@FDiscount",
			"@Reconciled",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			Barcode,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			Amount,
			FAmount,
			Discount,
			FDiscount,
			Reconciled,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("CUSTOMER_RECEIPT_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			Guid ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			Guid PaymentMethod,
			string Barcode,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
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
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@Barcode",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@Amount",
			"@FAmount",
			"@Discount",
			"@FDiscount",
			"@Reconciled",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={ID,RefID,RefDate,RefOrgNo,RefType,RefStatus,PaymentMethod,Barcode,CurrencyID,ExchangeRate,BranchID,ContractID,CustomerID,CustomerName,CustomerAddress,CustomerTax,ContactName,Amount,FAmount,Discount,FDiscount,Reconciled,IsPublic,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,OwnerID,Description,Sorted,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_RECEIPT_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion		
		
		#region Error
		
		private void DispError(object sender, SqlHelperException e)
		{
			XtraMessageBox.Show(e.Message,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion
	}

	

}
