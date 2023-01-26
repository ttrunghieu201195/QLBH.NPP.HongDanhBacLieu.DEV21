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
	/// Generated Class for Table : TRANS_DEBT.
	/// Date: 12/03/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class TRANS_DEBT:Object
	{
		#region Init
		private string m_ID;
		private string m_BookID;
		private string m_RefID;
		private DateTime m_RefDate;
		private string m_RefDetailNo;
		private string m_RefNo;
		private string m_RefOrgNo;
		private int m_RefType;
		private int m_RefStatus;
		private string m_CustomerID;
		private string m_CurrencyID;
		private decimal m_ExchangeRate;
		private bool m_IsDebt;
		private decimal m_Amount;
		private decimal m_Discount;
		private decimal m_Payment;
		private decimal m_Balance;
		private decimal m_FAmount;
		private decimal m_FDiscount;
		private decimal m_FPayment;
		private decimal m_FBalance;
		private string m_Description;
		private long m_Sorted;
		
		
		public TRANS_DEBT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_BookID="";
			 m_RefID="";
			 m_RefDate=DateTime.Now;
			 m_RefDetailNo="";
			 m_RefNo="";
			 m_RefOrgNo="";
			 m_RefType=0;
			 m_RefStatus=0;
			 m_CustomerID="";
			 m_CurrencyID="";
			 m_ExchangeRate=0;
			 m_IsDebt=true;
			 m_Amount=0;
			 m_Discount=0;
			 m_Payment=0;
			 m_Balance=0;
			 m_FAmount=0;
			 m_FDiscount=0;
			 m_FPayment=0;
			 m_FBalance=0;
			 m_Description="";
			 m_Sorted=0;
		}
		public TRANS_DEBT(
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_BookID=BookID;
			 m_RefID=RefID;
			 m_RefDate=RefDate;
			 m_RefDetailNo=RefDetailNo;
			 m_RefNo=RefNo;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefStatus=RefStatus;
			 m_CustomerID=CustomerID;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_IsDebt=IsDebt;
			 m_Amount=Amount;
			 m_Discount=Discount;
			 m_Payment=Payment;
			 m_Balance=Balance;
			 m_FAmount=FAmount;
			 m_FDiscount=FDiscount;
			 m_FPayment=FPayment;
			 m_FBalance=FBalance;
			 m_Description=Description;
			 m_Sorted=Sorted;
		}
		
		
		public void SetData(
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_BookID=BookID;
			 m_RefID=RefID;
			 m_RefDate=RefDate;
			 m_RefDetailNo=RefDetailNo;
			 m_RefNo=RefNo;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefStatus=RefStatus;
			 m_CustomerID=CustomerID;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_IsDebt=IsDebt;
			 m_Amount=Amount;
			 m_Discount=Discount;
			 m_Payment=Payment;
			 m_Balance=Balance;
			 m_FAmount=FAmount;
			 m_FDiscount=FDiscount;
			 m_FPayment=FPayment;
			 m_FBalance=FBalance;
			 m_Description=Description;
			 m_Sorted=Sorted;
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
		[DisplayName("BookID")]
		[Category("Column")]
		public string BookID
		{
			get
			{
				return m_BookID;
			}
			set
			{
				m_BookID = value;
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
		[DisplayName("RefDetailNo")]
		[Category("Column")]
		public string RefDetailNo
		{
			get
			{
				return m_RefDetailNo;
			}
			set
			{
				m_RefDetailNo = value;
			}
		}
		[DisplayName("RefNo")]
		[Category("Column")]
		public string RefNo
		{
			get
			{
				return m_RefNo;
			}
			set
			{
				m_RefNo = value;
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
		[DisplayName("IsDebt")]
		[Category("Column")]
		public bool IsDebt
		{
			get
			{
				return m_IsDebt;
			}
			set
			{
				m_IsDebt = value;
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
		[DisplayName("Payment")]
		[Category("Column")]
		public decimal Payment
		{
			get
			{
				return m_Payment;
			}
			set
			{
				m_Payment = value;
			}
		}
		[DisplayName("Balance")]
		[Category("Column")]
		public decimal Balance
		{
			get
			{
				return m_Balance;
			}
			set
			{
				m_Balance = value;
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
		[DisplayName("FPayment")]
		[Category("Column")]
		public decimal FPayment
		{
			get
			{
				return m_FPayment;
			}
			set
			{
				m_FPayment = value;
			}
		}
		[DisplayName("FBalance")]
		[Category("Column")]
		public decimal FBalance
		{
			get
			{
				return m_FBalance;
			}
			set
			{
				m_FBalance = value;
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
		public string Product
		{
			get
			{
				return "Class TRANS_DEBT";
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
			return SqlHelper.GenCode("TRANS_DEBT","TRANS_DEBTID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"TRANS_DEBT","TRANS_DEBTID",key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"TRANS_DEBT_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"TRANS_DEBT_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"TRANS_DEBT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_BookID =Convert.ToString(myReader["BookID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_RefDetailNo =Convert.ToString(myReader["RefDetailNo"]);
						m_RefNo =Convert.ToString(myReader["RefNo"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]);
						m_CustomerID =Convert.ToString(myReader["CustomerID"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_IsDebt =Convert.ToBoolean(myReader["IsDebt"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_Payment =Convert.ToDecimal(myReader["Payment"]);
						m_Balance =Convert.ToDecimal(myReader["Balance"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]);
						m_FBalance =Convert.ToDecimal(myReader["FBalance"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_BookID =Convert.ToString(myReader["BookID"]==DBNull.Value?"":myReader["BookID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefDetailNo =Convert.ToString(myReader["RefDetailNo"]==DBNull.Value?"":myReader["RefDetailNo"] );
						m_RefNo =Convert.ToString(myReader["RefNo"]==DBNull.Value?"":myReader["RefNo"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_IsDebt =Convert.ToBoolean(myReader["IsDebt"]==DBNull.Value?true:myReader["IsDebt"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Balance =Convert.ToDecimal(myReader["Balance"]==DBNull.Value?0:myReader["Balance"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FBalance =Convert.ToDecimal(myReader["FBalance"]==DBNull.Value?0:myReader["FBalance"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"TRANS_DEBT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_BookID =Convert.ToString(myReader["BookID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_RefDetailNo =Convert.ToString(myReader["RefDetailNo"]);
						m_RefNo =Convert.ToString(myReader["RefNo"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]);
						m_CustomerID =Convert.ToString(myReader["CustomerID"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_IsDebt =Convert.ToBoolean(myReader["IsDebt"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_Payment =Convert.ToDecimal(myReader["Payment"]);
						m_Balance =Convert.ToDecimal(myReader["Balance"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]);
						m_FBalance =Convert.ToDecimal(myReader["FBalance"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_BookID =Convert.ToString(myReader["BookID"]==DBNull.Value?"":myReader["BookID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefDetailNo =Convert.ToString(myReader["RefDetailNo"]==DBNull.Value?"":myReader["RefDetailNo"] );
						m_RefNo =Convert.ToString(myReader["RefNo"]==DBNull.Value?"":myReader["RefNo"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_IsDebt =Convert.ToBoolean(myReader["IsDebt"]==DBNull.Value?true:myReader["IsDebt"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_Balance =Convert.ToDecimal(myReader["Balance"]==DBNull.Value?0:myReader["Balance"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FBalance =Convert.ToDecimal(myReader["FBalance"]==DBNull.Value?0:myReader["FBalance"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description,
			m_Sorted);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description,
			m_Sorted);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description,
			m_Sorted);
		}
		public bool Insert(
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description,
			Sorted))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
		public bool Insert(
			SqlConnection myConnection,
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@BookID",
			"@RefID",
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@CustomerID",
			"@CurrencyID",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_DEBT_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@BookID",
			"@RefID",
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@CustomerID",
			"@CurrencyID",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_DEBT_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description,
			m_Sorted);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description,
			m_Sorted);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description,
			m_Sorted);
		}
		public bool Update(
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description,
			Sorted)
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
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@BookID",
			"@RefID",
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@CustomerID",
			"@CurrencyID",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_DEBT_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@BookID",
			"@RefID",
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@CustomerID",
			"@CurrencyID",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description",
			"@Sorted"};
			object[] myValue={ID,BookID,RefID,RefDate,RefDetailNo,RefNo,RefOrgNo,RefType,RefStatus,CustomerID,CurrencyID,ExchangeRate,IsDebt,Amount,Discount,Payment,Balance,FAmount,FDiscount,FPayment,FBalance,Description,Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_DEBT_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_ID,
			m_BookID,
			m_RefID,
			m_RefDate,
			m_RefDetailNo,
			m_RefNo,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_CustomerID,
			m_CurrencyID,
			m_ExchangeRate,
			m_IsDebt,
			m_Amount,
			m_Discount,
			m_Payment,
			m_Balance,
			m_FAmount,
			m_FDiscount,
			m_FPayment,
			m_FBalance,
			m_Description);
		}
		public bool UpdateByID(
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByID(
			SqlConnection myConnection,
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description)
		{
			string[] myPara={
			"@ID",
			"@BookID",
			"@RefID",
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@CustomerID",
			"@CurrencyID",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description"};
			object[] myValue={
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_DEBT_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string BookID,
			string RefID,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string CustomerID,
			string CurrencyID,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description)
		{
			string[] myPara={
			"@ID",
			"@BookID",
			"@RefID",
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@CustomerID",
			"@CurrencyID",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description"};
			object[] myValue={
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_DEBT_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_DEBT_Delete",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_DEBT_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("TRANS_DEBT_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"TRANS_DEBT_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"TRANS_DEBT_GetList");
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
			return mySql.ExecuteScalar(myConnection,"TRANS_DEBT_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"TRANS_DEBT_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefDetailNo+"%",
			"%"+RefNo+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+ExchangeRate+"%",
			"%"+IsDebt+"%",
			"%"+Amount+"%",
			"%"+Discount+"%",
			"%"+Payment+"%",
			"%"+Balance+"%",
			"%"+FAmount+"%",
			"%"+FDiscount+"%",
			"%"+FPayment+"%",
			"%"+FBalance+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"TRANS_DEBT_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			DateTime RefDate,
			string RefDetailNo,
			string RefNo,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			decimal ExchangeRate,
			bool IsDebt,
			decimal Amount,
			decimal Discount,
			decimal Payment,
			decimal Balance,
			decimal FAmount,
			decimal FDiscount,
			decimal FPayment,
			decimal FBalance,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@RefDetailNo",
			"@RefNo",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@ExchangeRate",
			"@IsDebt",
			"@Amount",
			"@Discount",
			"@Payment",
			"@Balance",
			"@FAmount",
			"@FDiscount",
			"@FPayment",
			"@FBalance",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefDetailNo+"%",
			"%"+RefNo+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+ExchangeRate+"%",
			"%"+IsDebt+"%",
			"%"+Amount+"%",
			"%"+Discount+"%",
			"%"+Payment+"%",
			"%"+Balance+"%",
			"%"+FAmount+"%",
			"%"+FDiscount+"%",
			"%"+FPayment+"%",
			"%"+FBalance+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"TRANS_DEBT_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
        

		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("TRANS_DEBT_LookUp");
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
		
		public double GetDebt(string Id)
        {
            SqlHelper mySql = new SqlHelper();
            string[] myPara = { "@CustomerID" };
            object[] myValue = {Id};
            return mySql.ExecuteScalar("TRANS_DEBT_GetDebt", myPara, myValue,0.0);
        }

	}
	#region Enum Fields

	public enum TRANS_DEBTFields
		{
			ID,
			BookID,
			RefID,
			RefDate,
			RefDetailNo,
			RefNo,
			RefOrgNo,
			RefType,
			RefStatus,
			CustomerID,
			CurrencyID,
			ExchangeRate,
			IsDebt,
			Amount,
			Discount,
			Payment,
			Balance,
			FAmount,
			FDiscount,
			FPayment,
			FBalance,
			Description,
			Sorted
		}

	#endregion

	#region Class Collection

	public class TRANS_DEBTCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new TRANS_DEBT to the collection.")]
			public int Add(TRANS_DEBT item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a TRANS_DEBT from the collection.")]
			public void Remove(TRANS_DEBT item)
				{
					List.Remove(item);
				}
			[Description("Inserts an TRANS_DEBT into the collection at the specified index..")]
			public void Inserts(int index,TRANS_DEBT item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(TRANS_DEBT item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the TRANS_DEBT class is present in the collection.")]
			public bool Contains(TRANS_DEBT item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
