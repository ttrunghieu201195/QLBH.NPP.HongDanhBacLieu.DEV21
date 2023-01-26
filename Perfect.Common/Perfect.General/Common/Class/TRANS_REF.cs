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
	
	public class TRANS_REF:Object
	{
		#region Init
		private string m_ID;
		private string m_RefID;
		private string m_RefOrgNo;
		private int m_RefType;
		private DateTime m_RefDate;
		private string m_TransFrom;
		private string m_TransTo;
		private string m_Department_ID;
		private string m_Employee_ID;
		private string m_Stock_ID;
		private string m_Branch_ID;
		private string m_Contract_ID;
		private string m_Contract;
		private string m_Reason;
		private string m_Currency_ID;
		private decimal m_ExchangeRate;
		private decimal m_Amount;
		private decimal m_Discount;
		private decimal m_FAmount;
		private decimal m_FDiscount;
		private bool m_IsClose;
		private long m_Sorted;
		private string m_Description;
		private string m_User_ID;
		private bool m_Active;
		
		
		public TRANS_REF()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_RefID="";
			 m_RefOrgNo="";
			 m_RefType=0;
			 m_RefDate=DateTime.Now;
			 m_TransFrom="";
			 m_TransTo="";
			 m_Department_ID="";
			 m_Employee_ID="";
			 m_Stock_ID="";
			 m_Branch_ID="";
			 m_Contract_ID="";
			 m_Contract="";
			 m_Reason="";
			 m_Currency_ID="";
			 m_ExchangeRate=0;
			 m_Amount=0;
			 m_Discount=0;
			 m_FAmount=0;
			 m_FDiscount=0;
			 m_IsClose=true;
			 m_Sorted=0;
			 m_Description="";
			 m_User_ID="";
			 m_Active=true;
		}
		public TRANS_REF(
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_RefID=RefID;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefDate=RefDate;
			 m_TransFrom=TransFrom;
			 m_TransTo=TransTo;
			 m_Department_ID=Department_ID;
			 m_Employee_ID=Employee_ID;
			 m_Stock_ID=Stock_ID;
			 m_Branch_ID=Branch_ID;
			 m_Contract_ID=Contract_ID;
			 m_Contract=Contract;
			 m_Reason=Reason;
			 m_Currency_ID=Currency_ID;
			 m_ExchangeRate=ExchangeRate;
			 m_Amount=Amount;
			 m_Discount=Discount;
			 m_FAmount=FAmount;
			 m_FDiscount=FDiscount;
			 m_IsClose=IsClose;
			 m_Sorted=Sorted;
			 m_Description=Description;
			 m_User_ID=User_ID;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_RefID=RefID;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefDate=RefDate;
			 m_TransFrom=TransFrom;
			 m_TransTo=TransTo;
			 m_Department_ID=Department_ID;
			 m_Employee_ID=Employee_ID;
			 m_Stock_ID=Stock_ID;
			 m_Branch_ID=Branch_ID;
			 m_Contract_ID=Contract_ID;
			 m_Contract=Contract;
			 m_Reason=Reason;
			 m_Currency_ID=Currency_ID;
			 m_ExchangeRate=ExchangeRate;
			 m_Amount=Amount;
			 m_Discount=Discount;
			 m_FAmount=FAmount;
			 m_FDiscount=FDiscount;
			 m_IsClose=IsClose;
			 m_Sorted=Sorted;
			 m_Description=Description;
			 m_User_ID=User_ID;
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
		[DisplayName("TransFrom")]
		[Category("Column")]
		public string TransFrom
		{
			get
			{
				return m_TransFrom;
			}
			set
			{
				m_TransFrom = value;
			}
		}
		[DisplayName("TransTo")]
		[Category("Column")]
		public string TransTo
		{
			get
			{
				return m_TransTo;
			}
			set
			{
				m_TransTo = value;
			}
		}
		[DisplayName("Department_ID")]
		[Category("Column")]
		public string Department_ID
		{
			get
			{
				return m_Department_ID;
			}
			set
			{
				m_Department_ID = value;
			}
		}
		[DisplayName("Employee_ID")]
		[Category("Column")]
		public string Employee_ID
		{
			get
			{
				return m_Employee_ID;
			}
			set
			{
				m_Employee_ID = value;
			}
		}
		[DisplayName("Stock_ID")]
		[Category("Column")]
		public string Stock_ID
		{
			get
			{
				return m_Stock_ID;
			}
			set
			{
				m_Stock_ID = value;
			}
		}
		[DisplayName("Branch_ID")]
		[Category("Column")]
		public string Branch_ID
		{
			get
			{
				return m_Branch_ID;
			}
			set
			{
				m_Branch_ID = value;
			}
		}
		[DisplayName("Contract_ID")]
		[Category("Column")]
		public string Contract_ID
		{
			get
			{
				return m_Contract_ID;
			}
			set
			{
				m_Contract_ID = value;
			}
		}
		[DisplayName("Contract")]
		[Category("Column")]
		public string Contract
		{
			get
			{
				return m_Contract;
			}
			set
			{
				m_Contract = value;
			}
		}
		[DisplayName("Reason")]
		[Category("Column")]
		public string Reason
		{
			get
			{
				return m_Reason;
			}
			set
			{
				m_Reason = value;
			}
		}
		[DisplayName("Currency_ID")]
		[Category("Column")]
		public string Currency_ID
		{
			get
			{
				return m_Currency_ID;
			}
			set
			{
				m_Currency_ID = value;
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
		[DisplayName("IsClose")]
		[Category("Column")]
		public bool IsClose
		{
			get
			{
				return m_IsClose;
			}
			set
			{
				m_IsClose = value;
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
		[DisplayName("User_ID")]
		[Category("Column")]
		public string User_ID
		{
			get
			{
				return m_User_ID;
			}
			set
			{
				m_User_ID = value;
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
				return "Class TRANS_REF";
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
            return SqlHelper.GenCode("TRANS_REF", "RefID", key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
            return SqlHelper.GenCode(myTransaction, "TRANS_REF", "RefID", key);
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
				}
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@RefID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "TRANS_REF_ExistByID", myPara, myValue);
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
			"@RefID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "TRANS_REF_ExistByID", myPara, myValue);
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
				};
			return false;

		}


		public bool ExistByID(SqlTransaction myTransaction,string ID)
		{
			bool Result=false;
			string[] myPara={"@RefID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"TRANS_REF_ExistByID",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"TRANS_REF_ExistByID",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"TRANS_REF_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt32(myReader["RefType"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_TransFrom =Convert.ToString(myReader["TransFrom"]);
						m_TransTo =Convert.ToString(myReader["TransTo"]);
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]);
						m_Contract =Convert.ToString(myReader["Contract"]);
						m_Reason =Convert.ToString(myReader["Reason"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_TransFrom =Convert.ToString(myReader["TransFrom"]==DBNull.Value?"":myReader["TransFrom"] );
						m_TransTo =Convert.ToString(myReader["TransTo"]==DBNull.Value?"":myReader["TransTo"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]==DBNull.Value?"":myReader["Contract_ID"] );
						m_Contract =Convert.ToString(myReader["Contract"]==DBNull.Value?"":myReader["Contract"] );
						m_Reason =Convert.ToString(myReader["Reason"]==DBNull.Value?"":myReader["Reason"] );
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]==DBNull.Value?"":myReader["Currency_ID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"TRANS_REF_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt32(myReader["RefType"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_TransFrom =Convert.ToString(myReader["TransFrom"]);
						m_TransTo =Convert.ToString(myReader["TransTo"]);
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]);
						m_Contract =Convert.ToString(myReader["Contract"]);
						m_Reason =Convert.ToString(myReader["Reason"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_TransFrom =Convert.ToString(myReader["TransFrom"]==DBNull.Value?"":myReader["TransFrom"] );
						m_TransTo =Convert.ToString(myReader["TransTo"]==DBNull.Value?"":myReader["TransTo"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Contract_ID =Convert.ToString(myReader["Contract_ID"]==DBNull.Value?"":myReader["Contract_ID"] );
						m_Contract =Convert.ToString(myReader["Contract"]==DBNull.Value?"":myReader["Contract"] );
						m_Reason =Convert.ToString(myReader["Reason"]==DBNull.Value?"":myReader["Reason"] );
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]==DBNull.Value?"":myReader["Currency_ID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
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
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool Insert(
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Sorted,
			Description,
			User_ID,
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
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Department_ID",
			"@Employee_ID",
			"@Stock_ID",
			"@Branch_ID",
			"@Contract_ID",
			"@Contract",
			"@Reason",
			"@Currency_ID",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Sorted,
			Description,
			User_ID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_REF_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Department_ID",
			"@Employee_ID",
			"@Stock_ID",
			"@Branch_ID",
			"@Contract_ID",
			"@Contract",
			"@Reason",
			"@Currency_ID",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Sorted,
			Description,
			User_ID,
			Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_REF_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool Update(
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
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
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Sorted,
			Description,
			User_ID,
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
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Department_ID",
			"@Employee_ID",
			"@Stock_ID",
			"@Branch_ID",
			"@Contract_ID",
			"@Contract",
			"@Reason",
			"@Currency_ID",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Sorted,
			Description,
			User_ID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_REF_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			long Sorted,
			string Description,
			string User_ID,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Department_ID",
			"@Employee_ID",
			"@Stock_ID",
			"@Branch_ID",
			"@Contract_ID",
			"@Contract",
			"@Reason",
			"@Currency_ID",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={ID,RefID,RefOrgNo,RefType,RefDate,TransFrom,TransTo,Department_ID,Employee_ID,Stock_ID,Branch_ID,Contract_ID,Contract,Reason,Currency_ID,ExchangeRate,Amount,Discount,FAmount,FDiscount,IsClose,Sorted,Description,User_ID,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_REF_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_ID,
			m_RefID,
			m_RefOrgNo,
			m_RefType,
			m_RefDate,
			m_TransFrom,
			m_TransTo,
			m_Department_ID,
			m_Employee_ID,
			m_Stock_ID,
			m_Branch_ID,
			m_Contract_ID,
			m_Contract,
			m_Reason,
			m_Currency_ID,
			m_ExchangeRate,
			m_Amount,
			m_Discount,
			m_FAmount,
			m_FDiscount,
			m_IsClose,
			m_Description,
			m_User_ID,
			m_Active);
		}
		public bool UpdateByID(
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			string Description,
			string User_ID,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Description,
			User_ID,
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
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			string Description,
			string User_ID,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Department_ID",
			"@Employee_ID",
			"@Stock_ID",
			"@Branch_ID",
			"@Contract_ID",
			"@Contract",
			"@Reason",
			"@Currency_ID",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Description,
			User_ID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"TRANS_REF_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string RefID,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Department_ID,
			string Employee_ID,
			string Stock_ID,
			string Branch_ID,
			string Contract_ID,
			string Contract,
			string Reason,
			string Currency_ID,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			string Description,
			string User_ID,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Department_ID",
			"@Employee_ID",
			"@Stock_ID",
			"@Branch_ID",
			"@Contract_ID",
			"@Contract",
			"@Reason",
			"@Currency_ID",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Description,
			User_ID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_REF_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			var mySql=new SqlHelper();
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
			return mySql.ExecuteNonQuery(myConnection,"TRANS_REF_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			string ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"TRANS_REF_Delete",myPara,myValue)=="OK"?true:false;
		}

       

		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("TRANS_REF_GetList");
		}


		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"TRANS_REF_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"TRANS_REF_GetList");
		}
		#endregion
		

		#region Count

		public int Count()
		{
			var mySql=new SqlHelper();
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
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myConnection,"TRANS_REF_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"TRANS_REF_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Contract,
			string Reason,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Contract,
			Reason,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Contract,
			string Reason,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			string Description)
		{
			string[] myPara={
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Contract",
			"@Reason",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Description"};
			object[] myValue={
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefDate+"%",
			"%"+TransFrom+"%",
			"%"+TransTo+"%",
			"%"+Contract+"%",
			"%"+Reason+"%",
			"%"+ExchangeRate+"%",
			"%"+Amount+"%",
			"%"+Discount+"%",
			"%"+FAmount+"%",
			"%"+FDiscount+"%",
			"%"+IsClose+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"TRANS_REF_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			string RefOrgNo,
			int RefType,
			DateTime RefDate,
			string TransFrom,
			string TransTo,
			string Contract,
			string Reason,
			decimal ExchangeRate,
			decimal Amount,
			decimal Discount,
			decimal FAmount,
			decimal FDiscount,
			bool IsClose,
			string Description)
		{
			string[] myPara={
			"@RefOrgNo",
			"@RefType",
			"@RefDate",
			"@TransFrom",
			"@TransTo",
			"@Contract",
			"@Reason",
			"@ExchangeRate",
			"@Amount",
			"@Discount",
			"@FAmount",
			"@FDiscount",
			"@IsClose",
			"@Description"};
			object[] myValue={
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefDate+"%",
			"%"+TransFrom+"%",
			"%"+TransTo+"%",
			"%"+Contract+"%",
			"%"+Reason+"%",
			"%"+ExchangeRate+"%",
			"%"+Amount+"%",
			"%"+Discount+"%",
			"%"+FAmount+"%",
			"%"+FDiscount+"%",
			"%"+IsClose+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"TRANS_REF_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("TRANS_REF_LookUp");
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
			var dt = new DataTable();
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

        #region Custom
        public DataTable GetListByAll()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("TRANS_REF_GetListAll");
        }

        public DataTable GetList(DateTime from, DateTime to)
        {
            string[] myPara = { "@From", "@To" };
            object[] myValue = { from, to };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("TRANS_REF_GetList_ByDate", myPara, myValue);
        }

        public string DeleteByID(SqlTransaction myTransaction, string Trans_ID)
        {
            string[] myPara = { "@RefID" };
            object[] myValue = { Trans_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "TRANS_REF_DeleteByID", myPara, myValue);
        }

        public string UpdateBySorted(SqlTransaction myTransaction, string ID, long Sorted)
        {
            string[] myPara = { "@ID", "@Sorted" };
            object[] myValue = { ID, Sorted };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "TRANS_REF_UpdateBySorted", myPara, myValue);
        }

        public DataTable GetProductHistory(string productid, string productName)
        {
            SqlHelper mySql = new SqlHelper();
            string[] myPara = { "@ProductID", "@ProductName)" };
            object[] myValue = { "%" + productid + "%", "%" + productName + "%" };
            mySql.Error += DispError;
            mySql.CommandType = CommandType.Text;
            string sql = "";

            sql +=
                "SELECT     INVENTORY_DETAIL.RefDate, INVENTORY_DETAIL.RefNo, INVENTORY_DETAIL.RefType, INVENTORY_DETAIL.Product_ID, PRODUCT.Product_Name, ";
            sql +=
                "UNIT.Unit_Name, INVENTORY_DETAIL.Quantity, INVENTORY_DETAIL.UnitPrice, INVENTORY_DETAIL.Amount, INVENTORY_DETAIL.Stock_ID, ";
            sql += "INVENTORY_DETAIL.Customer_ID, INVENTORY_DETAIL.Employee_ID, INVENTORY_DETAIL.Description ";

            sql += "FROM         INVENTORY_DETAIL INNER JOIN ";
            sql += "  PRODUCT ON INVENTORY_DETAIL.Product_ID = PRODUCT.Product_ID INNER JOIN ";
            sql += "          UNIT ON PRODUCT.Unit = UNIT.Unit_ID ";
            sql +=
                " WHERE     (INVENTORY_DETAIL.Product_ID LIKE N'%" + productid + "%') AND (PRODUCT.Product_Name LIKE N'%" + productName + "%') ";
            sql += " ORDER BY INVENTORY_DETAIL.RefDate";

            //StringBuilder sql=new StringBuilder();
            //sql.Append(
            //    "SELECT     INVENTORY_DETAIL.RefDate, INVENTORY_DETAIL.RefNo, INVENTORY_DETAIL.RefType, INVENTORY_DETAIL.Product_ID, PRODUCT.Product_Name,");
            //sql.Append(
            //    "UNIT.Unit_Name, INVENTORY_DETAIL.Quantity, INVENTORY_DETAIL.UnitPrice, INVENTORY_DETAIL.Amount, INVENTORY_DETAIL.Stock_ID,");
            //sql.Append("INVENTORY_DETAIL.Customer_ID, INVENTORY_DETAIL.Employee_ID, INVENTORY_DETAIL.Description ");
            //sql.Append("FROM         INVENTORY_DETAIL INNER JOIN ");
            //sql.Append("PRODUCT ON INVENTORY_DETAIL.Product_ID = PRODUCT.Product_ID INNER JOIN ");
            //sql.Append("UNIT ON PRODUCT.Unit = UNIT.Unit_ID ");
            //sql.Append(
            //    "WHERE     (INVENTORY_DETAIL.Product_ID like @ProductID) AND (PRODUCT.Product_Name like @ProductName) ");
            //sql.Append("order by RefDate");

            return mySql.ExecuteDataTable(@sql);
        } 
        #endregion
	}
	#region Enum Fields

	public enum TRANS_REFFields
		{
			ID,
			RefID,
			RefOrgNo,
			RefType,
			RefDate,
			TransFrom,
			TransTo,
			Department_ID,
			Employee_ID,
			Stock_ID,
			Branch_ID,
			Contract_ID,
			Contract,
			Reason,
			Currency_ID,
			ExchangeRate,
			Amount,
			Discount,
			FAmount,
			FDiscount,
			IsClose,
			Sorted,
			Description,
			User_ID,
			Active
		}

	#endregion

	#region Class Collection

	public class TRANS_REFCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new TRANS_REF to the collection.")]
			public int Add(TRANS_REF item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a TRANS_REF from the collection.")]
			public void Remove(TRANS_REF item)
				{
					List.Remove(item);
				}
			[Description("Inserts an TRANS_REF into the collection at the specified index..")]
			public void Inserts(int index,TRANS_REF item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(TRANS_REF item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the TRANS_REF class is present in the collection.")]
			public bool Contains(TRANS_REF item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
