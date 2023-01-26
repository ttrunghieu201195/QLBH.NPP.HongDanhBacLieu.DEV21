using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Perfect.Common;

namespace Perfect.Dictionary.Customer.usercontrol.Debt
{

	public class CustomerDebt
	{
		#region Init
		private string _mID;
		private string _mRefID;
		private DateTime _mRefDate;
		private string _mRefOrgNo;
		private int _mRefType;
		private int _mRefStatus;
		private string _mPaymentMethod;
		private string _mCustomerID;
		private string _mProductID;
		private string _mProductName;
		private string _mCurrencyID;
		private decimal _mExchangeRate;
		private string _mTermID;
		private DateTime _mDueDate;
		private decimal _mQuantity;
		private decimal _mReQuantity;
		private decimal _mAmount;
		private decimal _mDiscount;
		private decimal _mPayment;
		private decimal _mBalance;
		private decimal _mFAmount;
		private decimal _mFPayment;
		private decimal _mFBalance;
		private decimal _mFDiscount;
		private bool _mIsChanged;
		private bool _mIsPublic;
		private string _mCreatedBy;
		private DateTime _mCreatedDate;
		private string _mModifiedBy;
		private DateTime _mModifiedDate;
		private string _mOwnerID;
		private string _mDescription;
		private long _mSorted;
		private bool _mActive;
		
		
		public CustomerDebt()
		{
			//
			// TODO: Add constructor logic here
			//
			 _mID="";
			 _mRefID="";
			 _mRefDate=DateTime.Now;
			 _mRefOrgNo="";
			 _mRefType=0;
			 _mRefStatus=0;
			 _mPaymentMethod="";
			 _mCustomerID="";
			 _mProductID="";
			 _mProductName="";
			 _mCurrencyID="";
			 _mExchangeRate=0;
			 _mTermID="";
			 _mDueDate=DateTime.Now;
			 _mQuantity=0;
			 _mReQuantity=0;
			 _mAmount=0;
			 _mDiscount=0;
			 _mPayment=0;
			 _mBalance=0;
			 _mFAmount=0;
			 _mFPayment=0;
			 _mFBalance=0;
			 _mFDiscount=0;
			 _mIsChanged=true;
			 _mIsPublic=true;
			 _mCreatedBy="";
			 _mCreatedDate=DateTime.Now;
			 _mModifiedBy="";
			 _mModifiedDate=DateTime.Now;
			 _mOwnerID="";
			 _mDescription="";
			 _mSorted=0;
			 _mActive=true;
		}
		public CustomerDebt(
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			 _mID=ID;
			 _mRefID=RefID;
			 _mRefDate=RefDate;
			 _mRefOrgNo=RefOrgNo;
			 _mRefType=RefType;
			 _mRefStatus=RefStatus;
			 _mPaymentMethod=PaymentMethod;
			 _mCustomerID=CustomerID;
			 _mProductID=ProductID;
			 _mProductName=ProductName;
			 _mCurrencyID=CurrencyID;
			 _mExchangeRate=ExchangeRate;
			 _mTermID=TermID;
			 _mDueDate=DueDate;
			 _mQuantity=Quantity;
			 _mReQuantity=ReQuantity;
			 _mAmount=Amount;
			 _mDiscount=Discount;
			 _mPayment=Payment;
			 _mBalance=Balance;
			 _mFAmount=FAmount;
			 _mFPayment=FPayment;
			 _mFBalance=FBalance;
			 _mFDiscount=FDiscount;
			 _mIsChanged=IsChanged;
			 _mIsPublic=IsPublic;
			 _mCreatedBy=CreatedBy;
			 _mCreatedDate=CreatedDate;
			 _mModifiedBy=ModifiedBy;
			 _mModifiedDate=ModifiedDate;
			 _mOwnerID=OwnerID;
			 _mDescription=Description;
			 _mSorted=Sorted;
			 _mActive=Active;
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			 _mID=ID;
			 _mRefID=RefID;
			 _mRefDate=RefDate;
			 _mRefOrgNo=RefOrgNo;
			 _mRefType=RefType;
			 _mRefStatus=RefStatus;
			 _mPaymentMethod=PaymentMethod;
			 _mCustomerID=CustomerID;
			 _mProductID=ProductID;
			 _mProductName=ProductName;
			 _mCurrencyID=CurrencyID;
			 _mExchangeRate=ExchangeRate;
			 _mTermID=TermID;
			 _mDueDate=DueDate;
			 _mQuantity=Quantity;
			 _mReQuantity=ReQuantity;
			 _mAmount=Amount;
			 _mDiscount=Discount;
			 _mPayment=Payment;
			 _mBalance=Balance;
			 _mFAmount=FAmount;
			 _mFPayment=FPayment;
			 _mFBalance=FBalance;
			 _mFDiscount=FDiscount;
			 _mIsChanged=IsChanged;
			 _mIsPublic=IsPublic;
			 _mCreatedBy=CreatedBy;
			 _mCreatedDate=CreatedDate;
			 _mModifiedBy=ModifiedBy;
			 _mModifiedDate=ModifiedDate;
			 _mOwnerID=OwnerID;
			 _mDescription=Description;
			 _mSorted=Sorted;
			 _mActive=Active;
		}
		#endregion
		
		#region Property
		[DisplayName("ID")]
		[Category("Primary Key")]
		public string ID
		{
			get
			{
				return _mID;
			}
			set
			{
				_mID = value;
			}
		}
		[DisplayName("RefID")]
		[Category("Column")]
		public string RefID
		{
			get
			{
				return _mRefID;
			}
			set
			{
				_mRefID = value;
			}
		}
		[DisplayName("RefDate")]
		[Category("Column")]
		public DateTime RefDate
		{
			get
			{
				return _mRefDate;
			}
			set
			{
				_mRefDate = value;
			}
		}
		[DisplayName("RefOrgNo")]
		[Category("Column")]
		public string RefOrgNo
		{
			get
			{
				return _mRefOrgNo;
			}
			set
			{
				_mRefOrgNo = value;
			}
		}
		[DisplayName("RefType")]
		[Category("Column")]
		public int RefType
		{
			get
			{
				return _mRefType;
			}
			set
			{
				_mRefType = value;
			}
		}
		[DisplayName("RefStatus")]
		[Category("Column")]
		public int RefStatus
		{
			get
			{
				return _mRefStatus;
			}
			set
			{
				_mRefStatus = value;
			}
		}
		[DisplayName("PaymentMethod")]
		[Category("Column")]
		public string PaymentMethod
		{
			get
			{
				return _mPaymentMethod;
			}
			set
			{
				_mPaymentMethod = value;
			}
		}
		[DisplayName("CustomerID")]
		[Category("Column")]
		public string CustomerID
		{
			get
			{
				return _mCustomerID;
			}
			set
			{
				_mCustomerID = value;
			}
		}
		[DisplayName("ProductID")]
		[Category("Column")]
		public string ProductID
		{
			get
			{
				return _mProductID;
			}
			set
			{
				_mProductID = value;
			}
		}
		[DisplayName("ProductName")]
		[Category("Column")]
		public string ProductName
		{
			get
			{
				return _mProductName;
			}
			set
			{
				_mProductName = value;
			}
		}
		[DisplayName("CurrencyID")]
		[Category("Column")]
		public string CurrencyID
		{
			get
			{
				return _mCurrencyID;
			}
			set
			{
				_mCurrencyID = value;
			}
		}
		[DisplayName("ExchangeRate")]
		[Category("Column")]
		public decimal ExchangeRate
		{
			get
			{
				return _mExchangeRate;
			}
			set
			{
				_mExchangeRate = value;
			}
		}
		[DisplayName("TermID")]
		[Category("Column")]
		public string TermID
		{
			get
			{
				return _mTermID;
			}
			set
			{
				_mTermID = value;
			}
		}
		[DisplayName("DueDate")]
		[Category("Column")]
		public DateTime DueDate
		{
			get
			{
				return _mDueDate;
			}
			set
			{
				_mDueDate = value;
			}
		}
		[DisplayName("Quantity")]
		[Category("Column")]
		public decimal Quantity
		{
			get
			{
				return _mQuantity;
			}
			set
			{
				_mQuantity = value;
			}
		}
		[DisplayName("ReQuantity")]
		[Category("Column")]
		public decimal ReQuantity
		{
			get
			{
				return _mReQuantity;
			}
			set
			{
				_mReQuantity = value;
			}
		}
		[DisplayName("Amount")]
		[Category("Column")]
		public decimal Amount
		{
			get
			{
				return _mAmount;
			}
			set
			{
				_mAmount = value;
			}
		}
		[DisplayName("Discount")]
		[Category("Column")]
		public decimal Discount
		{
			get
			{
				return _mDiscount;
			}
			set
			{
				_mDiscount = value;
			}
		}
		[DisplayName("Payment")]
		[Category("Column")]
		public decimal Payment
		{
			get
			{
				return _mPayment;
			}
			set
			{
				_mPayment = value;
			}
		}
		[DisplayName("Balance")]
		[Category("Column")]
		public decimal Balance
		{
			get
			{
				return _mBalance;
			}
			set
			{
				_mBalance = value;
			}
		}
		[DisplayName("FAmount")]
		[Category("Column")]
		public decimal FAmount
		{
			get
			{
				return _mFAmount;
			}
			set
			{
				_mFAmount = value;
			}
		}
		[DisplayName("FPayment")]
		[Category("Column")]
		public decimal FPayment
		{
			get
			{
				return _mFPayment;
			}
			set
			{
				_mFPayment = value;
			}
		}
		[DisplayName("FBalance")]
		[Category("Column")]
		public decimal FBalance
		{
			get
			{
				return _mFBalance;
			}
			set
			{
				_mFBalance = value;
			}
		}
		[DisplayName("FDiscount")]
		[Category("Column")]
		public decimal FDiscount
		{
			get
			{
				return _mFDiscount;
			}
			set
			{
				_mFDiscount = value;
			}
		}
		[DisplayName("IsChanged")]
		[Category("Column")]
		public bool IsChanged
		{
			get
			{
				return _mIsChanged;
			}
			set
			{
				_mIsChanged = value;
			}
		}
		[DisplayName("IsPublic")]
		[Category("Column")]
		public bool IsPublic
		{
			get
			{
				return _mIsPublic;
			}
			set
			{
				_mIsPublic = value;
			}
		}
		[DisplayName("CreatedBy")]
		[Category("Column")]
		public string CreatedBy
		{
			get
			{
				return _mCreatedBy;
			}
			set
			{
				_mCreatedBy = value;
			}
		}
		[DisplayName("CreatedDate")]
		[Category("Column")]
		public DateTime CreatedDate
		{
			get
			{
				return _mCreatedDate;
			}
			set
			{
				_mCreatedDate = value;
			}
		}
		[DisplayName("ModifiedBy")]
		[Category("Column")]
		public string ModifiedBy
		{
			get
			{
				return _mModifiedBy;
			}
			set
			{
				_mModifiedBy = value;
			}
		}
		[DisplayName("ModifiedDate")]
		[Category("Column")]
		public DateTime ModifiedDate
		{
			get
			{
				return _mModifiedDate;
			}
			set
			{
				_mModifiedDate = value;
			}
		}
		[DisplayName("OwnerID")]
		[Category("Column")]
		public string OwnerID
		{
			get
			{
				return _mOwnerID;
			}
			set
			{
				_mOwnerID = value;
			}
		}
		[DisplayName("Description")]
		[Category("Column")]
		public string Description
		{
			get
			{
				return _mDescription;
			}
			set
			{
				_mDescription = value;
			}
		}
		[DisplayName("Sorted")]
		[Category("Column")]
		public long Sorted
		{
			get
			{
				return _mSorted;
			}
			set
			{
				_mSorted = value;
			}
		}
		[DisplayName("Active")]
		[Category("Column")]
		public bool Active
		{
			get
			{
				return _mActive;
			}
			set
			{
				_mActive = value;
			}
		}
		public string Product
		{
			get
			{
				return "Class CUSTOMER_DEBT";
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
			return SqlHelper.GenCode("CUSTOMER_DEBT","CUSTOMER_DEBTID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"CUSTOMER_DEBT","CUSTOMER_DEBTID",key);
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
			_mID);
		}

		public bool Exist(
			SqlTransaction myTransaction)
		{
			return Exist(
			myTransaction,
			_mID);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_DEBT_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_DEBT_Get",myPara,myValue);
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
				return ExistByID(_mRefID);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_DEBT_ExistByID",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_DEBT_ExistByID",myPara,myValue);
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
			_mID);
		}

		public bool Get(SqlConnection myConnection)
		{
			return Get(myConnection,
			_mID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			_mID);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_DEBT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
                        //#if DEBUG
						_mID =Convert.ToString(myReader["ID"]);
						_mRefID =Convert.ToString(myReader["RefID"]);
						_mRefDate =Convert.ToDateTime(myReader["RefDate"]);
						_mRefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						_mRefType =Convert.ToInt16(myReader["RefType"]);
						_mRefStatus =Convert.ToInt16(myReader["RefStatus"]);
						_mPaymentMethod =Convert.ToString(myReader["PaymentMethod"]);
						_mCustomerID =Convert.ToString(myReader["CustomerID"]);
						_mProductID =Convert.ToString(myReader["ProductID"]);
						_mProductName =Convert.ToString(myReader["ProductName"]);
						_mCurrencyID =Convert.ToString(myReader["CurrencyID"]);
						_mExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						_mTermID =Convert.ToString(myReader["TermID"]);
						_mDueDate =Convert.ToDateTime(myReader["DueDate"]);
						_mQuantity =Convert.ToDecimal(myReader["Quantity"]);
						_mReQuantity =Convert.ToDecimal(myReader["ReQuantity"]);
						_mAmount =Convert.ToDecimal(myReader["Amount"]);
						_mDiscount =Convert.ToDecimal(myReader["Discount"]);
						_mPayment =Convert.ToDecimal(myReader["Payment"]);
						_mBalance =Convert.ToDecimal(myReader["Balance"]);
						_mFAmount =Convert.ToDecimal(myReader["FAmount"]);
						_mFPayment =Convert.ToDecimal(myReader["FPayment"]);
						_mFBalance =Convert.ToDecimal(myReader["FBalance"]);
						_mFDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						_mIsChanged =Convert.ToBoolean(myReader["IsChanged"]);
						_mIsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						_mCreatedBy =Convert.ToString(myReader["CreatedBy"]);
						_mCreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						_mModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						_mModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						_mOwnerID =Convert.ToString(myReader["OwnerID"]);
						_mDescription =Convert.ToString(myReader["Description"]);
						_mSorted =Convert.ToInt64(myReader["Sorted"]);
						_mActive =Convert.ToBoolean(myReader["Active"]);
                        //#else
                        //m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
                        //m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
                        //m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
                        //m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
                        //m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
                        //m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
                        //m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
                        //m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
                        //m_ProductID =Convert.ToString(myReader["ProductID"]==DBNull.Value?"":myReader["ProductID"] );
                        //m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
                        //m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
                        //m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
                        //m_TermID =Convert.ToString(myReader["TermID"]==DBNull.Value?"":myReader["TermID"] );
                        //m_DueDate =Convert.ToDateTime(myReader["DueDate"]==DBNull.Value?DateTime.Now:myReader["DueDate"] );
                        //m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
                        //m_ReQuantity =Convert.ToDecimal(myReader["ReQuantity"]==DBNull.Value?0:myReader["ReQuantity"] );
                        //m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
                        //m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
                        //m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
                        //m_Balance =Convert.ToDecimal(myReader["Balance"]==DBNull.Value?0:myReader["Balance"] );
                        //m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
                        //m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
                        //m_FBalance =Convert.ToDecimal(myReader["FBalance"]==DBNull.Value?0:myReader["FBalance"] );
                        //m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
                        //m_IsChanged =Convert.ToBoolean(myReader["IsChanged"]==DBNull.Value?true:myReader["IsChanged"] );
                        //m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
                        //m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
                        //m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
                        //m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
                        //m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
                        //m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
                        //m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
                        //m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
                        //m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
                        //#endif
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_DEBT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
                        //#if DEBUG
						_mID =Convert.ToString(myReader["ID"]);
						_mRefID =Convert.ToString(myReader["RefID"]);
						_mRefDate =Convert.ToDateTime(myReader["RefDate"]);
						_mRefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						_mRefType =Convert.ToInt16(myReader["RefType"]);
						_mRefStatus =Convert.ToInt16(myReader["RefStatus"]);
						_mPaymentMethod =Convert.ToString(myReader["PaymentMethod"]);
						_mCustomerID =Convert.ToString(myReader["CustomerID"]);
						_mProductID =Convert.ToString(myReader["ProductID"]);
						_mProductName =Convert.ToString(myReader["ProductName"]);
						_mCurrencyID =Convert.ToString(myReader["CurrencyID"]);
						_mExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						_mTermID =Convert.ToString(myReader["TermID"]);
						_mDueDate =Convert.ToDateTime(myReader["DueDate"]);
						_mQuantity =Convert.ToDecimal(myReader["Quantity"]);
						_mReQuantity =Convert.ToDecimal(myReader["ReQuantity"]);
						_mAmount =Convert.ToDecimal(myReader["Amount"]);
						_mDiscount =Convert.ToDecimal(myReader["Discount"]);
						_mPayment =Convert.ToDecimal(myReader["Payment"]);
						_mBalance =Convert.ToDecimal(myReader["Balance"]);
						_mFAmount =Convert.ToDecimal(myReader["FAmount"]);
						_mFPayment =Convert.ToDecimal(myReader["FPayment"]);
						_mFBalance =Convert.ToDecimal(myReader["FBalance"]);
						_mFDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						_mIsChanged =Convert.ToBoolean(myReader["IsChanged"]);
						_mIsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						_mCreatedBy =Convert.ToString(myReader["CreatedBy"]);
						_mCreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						_mModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						_mModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						_mOwnerID =Convert.ToString(myReader["OwnerID"]);
						_mDescription =Convert.ToString(myReader["Description"]);
						_mSorted =Convert.ToInt64(myReader["Sorted"]);
						_mActive =Convert.ToBoolean(myReader["Active"]);
                        //#else
                        //m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
                        //m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
                        //m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
                        //m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
                        //m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
                        //m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
                        //m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
                        //m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
                        //m_ProductID =Convert.ToString(myReader["ProductID"]==DBNull.Value?"":myReader["ProductID"] );
                        //m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
                        //m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
                        //m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
                        //m_TermID =Convert.ToString(myReader["TermID"]==DBNull.Value?"":myReader["TermID"] );
                        //m_DueDate =Convert.ToDateTime(myReader["DueDate"]==DBNull.Value?DateTime.Now:myReader["DueDate"] );
                        //m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
                        //m_ReQuantity =Convert.ToDecimal(myReader["ReQuantity"]==DBNull.Value?0:myReader["ReQuantity"] );
                        //m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
                        //m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
                        //m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
                        //m_Balance =Convert.ToDecimal(myReader["Balance"]==DBNull.Value?0:myReader["Balance"] );
                        //m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
                        //m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
                        //m_FBalance =Convert.ToDecimal(myReader["FBalance"]==DBNull.Value?0:myReader["FBalance"] );
                        //m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
                        //m_IsChanged =Convert.ToBoolean(myReader["IsChanged"]==DBNull.Value?true:myReader["IsChanged"] );
                        //m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
                        //m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
                        //m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
                        //m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
                        //m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
                        //m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
                        //m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
                        //m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
                        //m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
                        //#endif
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
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mCreatedBy,
			_mCreatedDate,
			_mModifiedBy,
			_mModifiedDate,
			_mOwnerID,
			_mDescription,
			_mSorted,
			_mActive);
		}



		public bool Insert(SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mCreatedBy,
			_mCreatedDate,
			_mModifiedBy,
			_mModifiedDate,
			_mOwnerID,
			_mDescription,
			_mSorted,
			_mActive);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mCreatedBy,
			_mCreatedDate,
			_mModifiedBy,
			_mModifiedDate,
			_mOwnerID,
			_mDescription,
			_mSorted,
			_mActive);
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			string[] myPara={
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
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
			"@Active"};
			object[] myValue={
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_DEBT_Insert",myPara,myValue)=="OK"?true:false;
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			string[] myPara={
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
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
			"@Active"};
			object[] myValue={
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_DEBT_Insert",myPara,myValue)=="OK"?true:false;
		}


        public string ImportInsert(SqlTransaction myTransaction)
        {
            string[] myPara ={
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
			    "@Discount",
			    "@Payment",
			    "@Balance",
			    "@FAmount",
			    "@FPayment",
			    "@FBalance",
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
			    "@Active"};

            object[] myValue ={
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
			    Discount,
			    Payment,
			    Balance,
			    FAmount,
			    FPayment,
			    FBalance,
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
			    Active};

            var mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CUSTOMER_DEBT_Update", myPara, myValue);
        }



		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mCreatedBy,
			_mCreatedDate,
			_mModifiedBy,
			_mModifiedDate,
			_mOwnerID,
			_mDescription,
			_mSorted,
			_mActive);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mCreatedBy,
			_mCreatedDate,
			_mModifiedBy,
			_mModifiedDate,
			_mOwnerID,
			_mDescription,
			_mSorted,
			_mActive);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mCreatedBy,
			_mCreatedDate,
			_mModifiedBy,
			_mModifiedDate,
			_mOwnerID,
			_mDescription,
			_mSorted,
			_mActive);
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			SqlHelper mySql=new SqlHelper();
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			string[] myPara={
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
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
			"@Active"};
			object[] myValue={
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_DEBT_Update",myPara,myValue)=="OK"?true:false;
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
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
			string[] myPara={
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
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
			"@Active"};
			object[] myValue={ID,RefID,RefDate,RefOrgNo,RefType,RefStatus,PaymentMethod,CustomerID,ProductID,ProductName,CurrencyID,ExchangeRate,TermID,DueDate,Quantity,ReQuantity,Amount,Discount,Payment,Balance,FAmount,FPayment,FBalance,FDiscount,IsChanged,IsPublic,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,OwnerID,Description,Sorted,Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_DEBT_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mModifiedBy,
			_mModifiedDate,
			_mDescription,
			_mActive);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mModifiedBy,
			_mModifiedDate,
			_mDescription,
			_mActive);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			_mID,
			_mRefID,
			_mRefDate,
			_mRefOrgNo,
			_mRefType,
			_mRefStatus,
			_mPaymentMethod,
			_mCustomerID,
			_mProductID,
			_mProductName,
			_mCurrencyID,
			_mExchangeRate,
			_mTermID,
			_mDueDate,
			_mQuantity,
			_mReQuantity,
			_mAmount,
			_mDiscount,
			_mPayment,
			_mBalance,
			_mFAmount,
			_mFPayment,
			_mFBalance,
			_mFDiscount,
			_mIsChanged,
			_mIsPublic,
			_mModifiedBy,
			_mModifiedDate,
			_mDescription,
			_mActive);
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
			decimal FDiscount,
			bool IsChanged,
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
			decimal FDiscount,
			bool IsChanged,
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
			"@FDiscount",
			"@IsChanged",
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
			FDiscount,
			IsChanged,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_DEBT_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
			decimal FDiscount,
			bool IsChanged,
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
			"@FDiscount",
			"@IsChanged",
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
			FDiscount,
			IsChanged,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_DEBT_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Delete
		public bool Delete()
		{
			return Delete(
			_mID);
		}
		public bool Delete(
			SqlConnection myConnection)
		{
			return Delete(
			myConnection,
			_mID);
		}
		public bool Delete(
			SqlTransaction myTransaction)
		{
			return Delete(
			myTransaction,
			_mID);
		}
		public bool Delete(
			string ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete(
			mySql.Connection,
			ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Delete(
			SqlConnection myConnection,
			string ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_DEBT_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(SqlTransaction myTransaction,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_DEBT_Delete",myPara,myValue)=="OK"?true:false;
		}
        public bool Delete(SqlTransaction myTransaction, string RefID, string text)
        {
            string[] myPara = { "@RefID" };
            object[] myValue = { RefID };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "sp_DeleteDebtInit", myPara, myValue) == "OK" ? true : false;
        }
        //sp_DeleteDebtInit

		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("CUSTOMER_DEBT_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"CUSTOMER_DEBT_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"CUSTOMER_DEBT_GetList");
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
			return mySql.ExecuteScalar(myConnection,"CUSTOMER_DEBT_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"CUSTOMER_DEBT_Count",0);
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
			decimal FDiscount,
			bool IsChanged,
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
			ProductName,
			ExchangeRate,
			DueDate,
			Quantity,
			ReQuantity,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
			decimal FDiscount,
			bool IsChanged,
			string Description)
		{
			string[] myPara={
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
			"@FDiscount",
			"@IsChanged",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+PaymentMethod+"%",
			"%"+ProductName+"%",
			"%"+ExchangeRate+"%",
			"%"+DueDate+"%",
			"%"+Quantity+"%",
			"%"+ReQuantity+"%",
			"%"+Amount+"%",
			"%"+Discount+"%",
			"%"+Payment+"%",
			"%"+Balance+"%",
			"%"+FAmount+"%",
			"%"+FPayment+"%",
			"%"+FBalance+"%",
			"%"+FDiscount+"%",
			"%"+IsChanged+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"CUSTOMER_DEBT_Search",myPara,myValue);
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
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FPayment,
			decimal FBalance,
			decimal FDiscount,
			bool IsChanged,
			string Description)
		{
			string[] myPara={
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
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FPayment",
			"@FBalance",
			"@FDiscount",
			"@IsChanged",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+PaymentMethod+"%",
			"%"+ProductName+"%",
			"%"+ExchangeRate+"%",
			"%"+DueDate+"%",
			"%"+Quantity+"%",
			"%"+ReQuantity+"%",
			"%"+Amount+"%",
			"%"+Discount+"%",
			"%"+Payment+"%",
			"%"+Balance+"%",
			"%"+FAmount+"%",
			"%"+FPayment+"%",
			"%"+FBalance+"%",
			"%"+FDiscount+"%",
			"%"+IsChanged+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"CUSTOMER_DEBT_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("CUSTOMER_DEBT_LookUp");
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

        public DataTable GetListInit(string customerGroupID)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("CUSTOMER_DEBT_GetListInit", new string[] { "@Customer_Group_ID" }, new object[] { customerGroupID });
        }

	}
	#region Enum Fields

	public enum CUSTOMER_DEBTFields
		{
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
			Discount,
			Payment,
			Balance,
			FAmount,
			FPayment,
			FBalance,
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
		}

	#endregion

	#region Class Collection

	public class CUSTOMER_DEBTCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new CUSTOMER_DEBT to the collection.")]
			public int Add(CustomerDebt item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a CUSTOMER_DEBT from the collection.")]
			public void Remove(CustomerDebt item)
				{
					List.Remove(item);
				}
			[Description("Inserts an CUSTOMER_DEBT into the collection at the specified index..")]
			public void Inserts(int index,CustomerDebt item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(CustomerDebt item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the CUSTOMER_DEBT class is present in the collection.")]
			public bool Contains(CustomerDebt item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
