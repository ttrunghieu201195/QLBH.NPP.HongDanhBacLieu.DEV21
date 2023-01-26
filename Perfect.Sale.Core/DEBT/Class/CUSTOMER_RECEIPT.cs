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
	public class CUSTOMER_RECEIPT:Object
	{
		#region Init
		private string m_ID;
		private string m_RefID;
		private DateTime m_RefDate;
		private string m_RefOrgNo;
		private int m_RefType;
		private int m_RefStatus;
		private string m_PaymentMethod;
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
		
		
		public CUSTOMER_RECEIPT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_RefID="";
			 m_RefDate=DateTime.Now;
			 m_RefOrgNo="";
			 m_RefType=0;
			 m_RefStatus=0;
			 m_PaymentMethod="";
			 m_Barcode="";
			 m_CurrencyID="";
			 m_ExchangeRate=0;
			 m_BranchID="";
			 m_ContractID="";
			 m_CustomerID="";
			 m_CustomerName="";
			 m_CustomerAddress="";
			 m_CustomerTax="";
			 m_ContactName="";
			 m_Amount=0;
			 m_FAmount=0;
			 m_Discount=0;
			 m_FDiscount=0;
			 m_Reconciled=true;
			 m_IsPublic=true;
			 m_CreatedBy="";
			 m_CreatedDate=DateTime.Now;
			 m_ModifiedBy="";
			 m_ModifiedDate=DateTime.Now;
			 m_OwnerID="";
			 m_Description="";
			 m_Sorted=0;
			 m_Active=true;
		}
		public CUSTOMER_RECEIPT(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
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
			 m_ID=ID;
			 m_RefID=RefID;
			 m_RefDate=RefDate;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefStatus=RefStatus;
			 m_PaymentMethod=PaymentMethod;
			 m_Barcode=Barcode;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_BranchID=BranchID;
			 m_ContractID=ContractID;
			 m_CustomerID=CustomerID;
			 m_CustomerName=CustomerName;
			 m_CustomerAddress=CustomerAddress;
			 m_CustomerTax=CustomerTax;
			 m_ContactName=ContactName;
			 m_Amount=Amount;
			 m_FAmount=FAmount;
			 m_Discount=Discount;
			 m_FDiscount=FDiscount;
			 m_Reconciled=Reconciled;
			 m_IsPublic=IsPublic;
			 m_CreatedBy=CreatedBy;
			 m_CreatedDate=CreatedDate;
			 m_ModifiedBy=ModifiedBy;
			 m_ModifiedDate=ModifiedDate;
			 m_OwnerID=OwnerID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
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
			 m_ID=ID;
			 m_RefID=RefID;
			 m_RefDate=RefDate;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefStatus=RefStatus;
			 m_PaymentMethod=PaymentMethod;
			 m_Barcode=Barcode;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_BranchID=BranchID;
			 m_ContractID=ContractID;
			 m_CustomerID=CustomerID;
			 m_CustomerName=CustomerName;
			 m_CustomerAddress=CustomerAddress;
			 m_CustomerTax=CustomerTax;
			 m_ContactName=ContactName;
			 m_Amount=Amount;
			 m_FAmount=FAmount;
			 m_Discount=Discount;
			 m_FDiscount=FDiscount;
			 m_Reconciled=Reconciled;
			 m_IsPublic=IsPublic;
			 m_CreatedBy=CreatedBy;
			 m_CreatedDate=CreatedDate;
			 m_ModifiedBy=ModifiedBy;
			 m_ModifiedDate=ModifiedDate;
			 m_OwnerID=OwnerID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		[DisplayName("ID")]
		[Category("Primary Key")]
		public string ID
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
			return SqlHelper.GenCode("CUSTOMER_RECEIPT","CUSTOMER_RECEIPTID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"CUSTOMER_RECEIPT","CUSTOMER_RECEIPTID",key);
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Exist(
			mySql.Connection,
			ID))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_RECEIPT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
			}
			else
			{
				mySql.Close();
				if(MyParamaters.IsShowWarning) 
					XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return Result;
		}

		public bool Exist(
			SqlTransaction myTransaction,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_RECEIPT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
			}
			else
				{
						mySql.RollBack(myTransaction);
						if(MyParamaters.IsShowWarning) 
						XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open() !="OK") return false;
			if (ExistByID(mySql.Connection,ID))
				{
					mySql.Close();
					return true;
				}
			return false;

		}


		public bool ExistByID(SqlTransaction myTransaction,string ID)
		{
			bool Result=false;
			string[] myPara={"@RefID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_RECEIPT_ExistByID",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				myReader = null;
			}
			return Result;
		}

		public bool ExistByID(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={"@RefID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_RECEIPT_ExistByID",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Get(
			mySql.Connection,
			ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Get(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_RECEIPT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]);
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_BranchID =Convert.ToString(myReader["BranchID"]);
						m_ContractID =Convert.ToString(myReader["ContractID"]);
						m_CustomerID =Convert.ToString(myReader["CustomerID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]);
						m_ContactName =Convert.ToString(myReader["ContactName"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_Reconciled =Convert.ToBoolean(myReader["Reconciled"]);
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]);
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						m_OwnerID =Convert.ToString(myReader["OwnerID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_BranchID =Convert.ToString(myReader["BranchID"]==DBNull.Value?"":myReader["BranchID"] );
						m_ContractID =Convert.ToString(myReader["ContractID"]==DBNull.Value?"":myReader["ContractID"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]==DBNull.Value?"":myReader["CustomerTax"] );
						m_ContactName =Convert.ToString(myReader["ContactName"]==DBNull.Value?"":myReader["ContactName"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_Reconciled =Convert.ToBoolean(myReader["Reconciled"]==DBNull.Value?true:myReader["Reconciled"] );
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
						Result=true;
				}
				myReader.Close();
				myReader = null;
			}
			else
			{
				mySql.Close();
				if(MyParamaters.IsShowWarning) 
					XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return Result;
		}

		public bool Get(
			SqlTransaction myTransaction,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_RECEIPT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]);
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_BranchID =Convert.ToString(myReader["BranchID"]);
						m_ContractID =Convert.ToString(myReader["ContractID"]);
						m_CustomerID =Convert.ToString(myReader["CustomerID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]);
						m_ContactName =Convert.ToString(myReader["ContactName"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_Reconciled =Convert.ToBoolean(myReader["Reconciled"]);
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]);
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						m_OwnerID =Convert.ToString(myReader["OwnerID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_BranchID =Convert.ToString(myReader["BranchID"]==DBNull.Value?"":myReader["BranchID"] );
						m_ContractID =Convert.ToString(myReader["ContractID"]==DBNull.Value?"":myReader["ContractID"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]==DBNull.Value?"":myReader["CustomerTax"] );
						m_ContactName =Convert.ToString(myReader["ContactName"]==DBNull.Value?"":myReader["ContactName"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_Reconciled =Convert.ToBoolean(myReader["Reconciled"]==DBNull.Value?true:myReader["Reconciled"] );
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
						Result=true;
				}
				myReader.Close();
				myReader = null;
			}
			else
				{
						mySql.RollBack(myTransaction);
						if(MyParamaters.IsShowWarning) 
							XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
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
			Active))
				{
					mySql.Close();
					return true;
				};
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
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_RECEIPT_Insert",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_RECEIPT_Insert",myPara,myValue)=="OK"?true:false;
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
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
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
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
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
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_RECEIPT_Update",myPara,myValue)=="OK"?true:false;
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
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
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
			ModifiedBy,
			ModifiedDate,
			Description,
			Active))
				{
					mySql.Close();
					return true;
				};
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
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
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
			"@ModifiedBy",
			"@ModifiedDate",
			"@Description",
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
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_RECEIPT_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
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
			"@ModifiedBy",
			"@ModifiedDate",
			"@Description",
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
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_RECEIPT_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Delete
		public bool Delete()
		{
			return Delete(m_ID,"");
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
		public bool Delete(string id, string refOrg)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete2011(mySql.Connection,id,refOrg))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
        public bool Delete2011(SqlConnection myConnection, string ID, string RefOrgNo)
        {
            string[] myPara = { "@ID", "@RefOrgNo" };
            object[] myValue = { ID, RefOrgNo };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "CUSTOMER_RECEIPT_Delete2011", myPara, myValue) == "OK" ? true : false;
        }
		public bool Delete(SqlConnection myConnection,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_RECEIPT_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			string ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_RECEIPT_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("CUSTOMER_RECEIPT_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"CUSTOMER_RECEIPT_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"CUSTOMER_RECEIPT_GetList");
		}
		#endregion
		

		#region Count

		public int Count()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return 0;
			int _count= Count(
			mySql.Connection);

			mySql.Close();
			return _count;
		}


		public int Count(
			SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myConnection,"CUSTOMER_RECEIPT_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"CUSTOMER_RECEIPT_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			string Barcode,
			decimal ExchangeRate,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			Barcode,
			ExchangeRate,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			Amount,
			FAmount,
			Discount,
			FDiscount,
			Reconciled,
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
			string Barcode,
			decimal ExchangeRate,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@Barcode",
			"@ExchangeRate",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@Amount",
			"@FAmount",
			"@Discount",
			"@FDiscount",
			"@Reconciled",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+PaymentMethod+"%",
			"%"+Barcode+"%",
			"%"+ExchangeRate+"%",
			"%"+CustomerName+"%",
			"%"+CustomerAddress+"%",
			"%"+CustomerTax+"%",
			"%"+ContactName+"%",
			"%"+Amount+"%",
			"%"+FAmount+"%",
			"%"+Discount+"%",
			"%"+FDiscount+"%",
			"%"+Reconciled+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"CUSTOMER_RECEIPT_Search",myPara,myValue);
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
			string Barcode,
			decimal ExchangeRate,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			decimal Amount,
			decimal FAmount,
			decimal Discount,
			decimal FDiscount,
			bool Reconciled,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@Barcode",
			"@ExchangeRate",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@Amount",
			"@FAmount",
			"@Discount",
			"@FDiscount",
			"@Reconciled",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+PaymentMethod+"%",
			"%"+Barcode+"%",
			"%"+ExchangeRate+"%",
			"%"+CustomerName+"%",
			"%"+CustomerAddress+"%",
			"%"+CustomerTax+"%",
			"%"+ContactName+"%",
			"%"+Amount+"%",
			"%"+FAmount+"%",
			"%"+Discount+"%",
			"%"+FDiscount+"%",
			"%"+Reconciled+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"CUSTOMER_RECEIPT_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("CUSTOMER_RECEIPT_LookUp");
		}
		#endregion
		
		public void AddCombo(System.Windows.Forms.ComboBox combo)
		{
			AddCombo(combo,LookUp());
		}
		
		public void AddCombo(System.Windows.Forms.ComboBox combo,System.Data.DataTable dt)
		{
			MyLib.TableToComboBox(combo,dt, "ID", "Name");
		}
		
		public void AddComboAll(System.Windows.Forms.ComboBox combo)
		{
			AddComboAll(combo,"(Tất cả)");
		}
		public void AddComboDefault(System.Windows.Forms.ComboBox combo)
		{
			AddComboAll(combo,"(Mặc định)");
		}
		public void AddComboAll(System.Windows.Forms.ComboBox combo,string text)
		{
			DataTable dt = new DataTable();
			dt =LookUp();
			DataRow b = dt.NewRow();
			b["ID"] = "All";
			b["Name"] = text;
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "ID", "Name");
		}
		#endregion
		
		#region Error
		
		private void DispError(object sender, SqlHelperException e)
		{
			XtraMessageBox.Show(e.Message,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion
	}
	#region Enum Fields

	public enum CUSTOMER_RECEIPTFields
		{
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
			Active
		}

	#endregion

	#region Class Collection

	public class CUSTOMER_RECEIPTCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new CUSTOMER_RECEIPT to the collection.")]
			public int Add(CUSTOMER_RECEIPT item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a CUSTOMER_RECEIPT from the collection.")]
			public void Remove(CUSTOMER_RECEIPT item)
				{
					List.Remove(item);
				}
			[Description("Inserts an CUSTOMER_RECEIPT into the collection at the specified index..")]
			public void Inserts(int index,CUSTOMER_RECEIPT item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(CUSTOMER_RECEIPT item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the CUSTOMER_RECEIPT class is present in the collection.")]
			public bool Contains(CUSTOMER_RECEIPT item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
