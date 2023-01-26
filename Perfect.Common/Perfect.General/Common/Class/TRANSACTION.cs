using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : TRANSACTION.
	/// Date: 08/07/2009
	/// Author: 
	/// </summary>
	public class TRANSACTION
	{
		#region Init
		private long m_ID;
		private string m_Trans_ID;
		private string m_Trans_No;
		private string m_TransRef;
		private int m_TransType;
		private DateTime m_Created;
		private string m_TransFrom;
		private string m_TransTo;
		private int m_Vat;
		private double m_ImportTax;
		private double m_ExportTax;
		private double m_LuxuryTax;
		private string m_Series;
		private string m_Number;
		private string m_Branch_ID;
		private string m_Contract;
		private int m_Payment;
		private DateTime m_Limit;
		private string m_Currency_ID;
		private double m_ExchangeRate;
		private double m_Amount;
		private double m_Discount;
		private double m_Charge;
		private double m_ChargeOther;
		private string m_Conveyance;
		private string m_Employee_ID;
		private double m_Commission;
		private string m_User_ID;
		private string m_Description;
		private bool m_Active;
		public TRANSACTION()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=0;
			 m_Trans_ID="";
			 m_Trans_No="";
			 m_TransRef="";
			 m_TransType=0;
			 m_Created=DateTime.Now;
			 m_TransFrom="";
			 m_TransTo="";
			 m_Vat=0;
			 m_ImportTax=0.0;
			 m_ExportTax=0.0;
			 m_LuxuryTax=0.0;
			 m_Series="";
			 m_Number="";
			 m_Branch_ID="";
			 m_Contract="";
			 m_Payment=0;
			 m_Limit=DateTime.Now;
			 m_Currency_ID="";
			 m_ExchangeRate=0.0;
			 m_Amount=0.0;
			 m_Discount=0.0;
			 m_Charge=0.0;
			 m_ChargeOther=0.0;
			 m_Conveyance="";
			 m_Employee_ID="";
			 m_Commission=0.0;
			 m_User_ID="";
			 m_Description="";
			 m_Active=true;
		}
		public TRANSACTION(long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Trans_ID=Trans_ID;
			 m_Trans_No=Trans_No;
			 m_TransRef=TransRef;
			 m_TransType=TransType;
			 m_Created=Created;
			 m_TransFrom=TransFrom;
			 m_TransTo=TransTo;
			 m_Vat=Vat;
			 m_ImportTax=ImportTax;
			 m_ExportTax=ExportTax;
			 m_LuxuryTax=LuxuryTax;
			 m_Series=Series;
			 m_Number=Number;
			 m_Branch_ID=Branch_ID;
			 m_Contract=Contract;
			 m_Payment=Payment;
			 m_Limit=Limit;
			 m_Currency_ID=Currency_ID;
			 m_ExchangeRate=ExchangeRate;
			 m_Amount=Amount;
			 m_Discount=Discount;
			 m_Charge=Charge;
			 m_ChargeOther=ChargeOther;
			 m_Conveyance=Conveyance;
			 m_Employee_ID=Employee_ID;
			 m_Commission=Commission;
			 m_User_ID=User_ID;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public long ID
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
		public string Trans_ID
		{
			get
			{
				return m_Trans_ID;
			}
			set
			{
				m_Trans_ID = value;
			}
		}
		public string Trans_No
		{
			get
			{
				return m_Trans_No;
			}
			set
			{
				m_Trans_No = value;
			}
		}
		public string TransRef
		{
			get
			{
				return m_TransRef;
			}
			set
			{
				m_TransRef = value;
			}
		}
		public int TransType
		{
			get
			{
				return m_TransType;
			}
			set
			{
				m_TransType = value;
			}
		}
		public DateTime Created
		{
			get
			{
				return m_Created;
			}
			set
			{
				m_Created = value;
			}
		}
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
		public int Vat
		{
			get
			{
				return m_Vat;
			}
			set
			{
				m_Vat = value;
			}
		}
		public double ImportTax
		{
			get
			{
				return m_ImportTax;
			}
			set
			{
				m_ImportTax = value;
			}
		}
		public double ExportTax
		{
			get
			{
				return m_ExportTax;
			}
			set
			{
				m_ExportTax = value;
			}
		}
		public double LuxuryTax
		{
			get
			{
				return m_LuxuryTax;
			}
			set
			{
				m_LuxuryTax = value;
			}
		}
		public string Series
		{
			get
			{
				return m_Series;
			}
			set
			{
				m_Series = value;
			}
		}
		public string Number
		{
			get
			{
				return m_Number;
			}
			set
			{
				m_Number = value;
			}
		}
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
		public int Payment
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
		public DateTime Limit
		{
			get
			{
				return m_Limit;
			}
			set
			{
				m_Limit = value;
			}
		}
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
		public double ExchangeRate
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
		public double Amount
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
		public double Discount
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
		public double Charge
		{
			get
			{
				return m_Charge;
			}
			set
			{
				m_Charge = value;
			}
		}
		public double ChargeOther
		{
			get
			{
				return m_ChargeOther;
			}
			set
			{
				m_ChargeOther = value;
			}
		}
		public string Conveyance
		{
			get
			{
				return m_Conveyance;
			}
			set
			{
				m_Conveyance = value;
			}
		}
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
		public double Commission
		{
			get
			{
				return m_Commission;
			}
			set
			{
				m_Commission = value;
			}
		}
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
		public string ProductName
		{
			get
			{
				return "Class TRANSACTION";
			}
		}
		public string ProductVersion
		{
			get
			{
				return "1.0.0.0";
			}
		}
		#endregion
		
		#region Get

		public string NewID()
		{
			return SqlHelper.GenCode("TRANSACTION","TRANSACTIONID","");
		}

		public Boolean Exist(long ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("TRANSACTION_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public string Get(long ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("TRANSACTION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Trans_ID =Convert.ToString(myReader["Trans_ID"]);
						m_Trans_No =Convert.ToString(myReader["Trans_No"]);
						m_TransRef =Convert.ToString(myReader["TransRef"]);
						m_TransType =Convert.ToInt32(myReader["TransType"]);
						m_Created =Convert.ToDateTime(myReader["Created"]);
						m_TransFrom =Convert.ToString(myReader["TransFrom"]);
						m_TransTo =Convert.ToString(myReader["TransTo"]);
						m_Vat =Convert.ToInt32(myReader["Vat"]);
						m_ImportTax =Convert.ToSingle(myReader["ImportTax"]);
						m_ExportTax =Convert.ToSingle(myReader["ExportTax"]);
						m_LuxuryTax =Convert.ToSingle(myReader["LuxuryTax"]);
						m_Series =Convert.ToString(myReader["Series"]);
						m_Number =Convert.ToString(myReader["Number"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Contract =Convert.ToString(myReader["Contract"]);
						m_Payment =Convert.ToInt32(myReader["Payment"]);
						m_Limit =Convert.ToDateTime(myReader["Limit"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Charge =Convert.ToSingle(myReader["Charge"]);
						m_ChargeOther =Convert.ToSingle(myReader["ChargeOther"]);
						m_Conveyance =Convert.ToString(myReader["Conveyance"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Commission =Convert.ToSingle(myReader["Commission"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public string Get(SqlConnection myConnection,long ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"TRANSACTION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Trans_ID =Convert.ToString(myReader["Trans_ID"]);
						m_Trans_No =Convert.ToString(myReader["Trans_No"]);
						m_TransRef =Convert.ToString(myReader["TransRef"]);
						m_TransType =Convert.ToInt32(myReader["TransType"]);
						m_Created =Convert.ToDateTime(myReader["Created"]);
						m_TransFrom =Convert.ToString(myReader["TransFrom"]);
						m_TransTo =Convert.ToString(myReader["TransTo"]);
						m_Vat =Convert.ToInt32(myReader["Vat"]);
						m_ImportTax =Convert.ToSingle(myReader["ImportTax"]);
						m_ExportTax =Convert.ToSingle(myReader["ExportTax"]);
						m_LuxuryTax =Convert.ToSingle(myReader["LuxuryTax"]);
						m_Series =Convert.ToString(myReader["Series"]);
						m_Number =Convert.ToString(myReader["Number"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Contract =Convert.ToString(myReader["Contract"]);
						m_Payment =Convert.ToInt32(myReader["Payment"]);
						m_Limit =Convert.ToDateTime(myReader["Limit"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Charge =Convert.ToSingle(myReader["Charge"]);
						m_ChargeOther =Convert.ToSingle(myReader["ChargeOther"]);
						m_Conveyance =Convert.ToString(myReader["Conveyance"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Commission =Convert.ToSingle(myReader["Commission"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public string Get(SqlTransaction myTransaction,long ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"TRANSACTION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Trans_ID =Convert.ToString(myReader["Trans_ID"]);
						m_Trans_No =Convert.ToString(myReader["Trans_No"]);
						m_TransRef =Convert.ToString(myReader["TransRef"]);
						m_TransType =Convert.ToInt32(myReader["TransType"]);
						m_Created =Convert.ToDateTime(myReader["Created"]);
						m_TransFrom =Convert.ToString(myReader["TransFrom"]);
						m_TransTo =Convert.ToString(myReader["TransTo"]);
						m_Vat =Convert.ToInt32(myReader["Vat"]);
						m_ImportTax =Convert.ToSingle(myReader["ImportTax"]);
						m_ExportTax =Convert.ToSingle(myReader["ExportTax"]);
						m_LuxuryTax =Convert.ToSingle(myReader["LuxuryTax"]);
						m_Series =Convert.ToString(myReader["Series"]);
						m_Number =Convert.ToString(myReader["Number"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Contract =Convert.ToString(myReader["Contract"]);
						m_Payment =Convert.ToInt32(myReader["Payment"]);
						m_Limit =Convert.ToDateTime(myReader["Limit"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Charge =Convert.ToSingle(myReader["Charge"]);
						m_ChargeOther =Convert.ToSingle(myReader["ChargeOther"]);
						m_Conveyance =Convert.ToString(myReader["Conveyance"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Commission =Convert.ToSingle(myReader["Commission"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		#endregion

		#region Add
		public string Insert()
		{
			string[] myPara={"@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={m_Trans_ID,m_Trans_No,m_TransRef,m_TransType,m_Created,m_TransFrom,m_TransTo,m_Vat,m_ImportTax,m_ExportTax,m_LuxuryTax,m_Series,m_Number,m_Branch_ID,m_Contract,m_Payment,m_Limit,m_Currency_ID,m_ExchangeRate,m_Amount,m_Discount,m_Charge,m_ChargeOther,m_Conveyance,m_Employee_ID,m_Commission,m_User_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("TRANSACTION_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={m_Trans_ID,m_Trans_No,m_TransRef,m_TransType,m_Created,m_TransFrom,m_TransTo,m_Vat,m_ImportTax,m_ExportTax,m_LuxuryTax,m_Series,m_Number,m_Branch_ID,m_Contract,m_Payment,m_Limit,m_Currency_ID,m_ExchangeRate,m_Amount,m_Discount,m_Charge,m_ChargeOther,m_Conveyance,m_Employee_ID,m_Commission,m_User_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"TRANSACTION_Insert",myPara,myValue);
		}
		public string Insert(long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			string[] myPara={"@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={Trans_ID,Trans_No,TransRef,TransType,Created,TransFrom,TransTo,Vat,ImportTax,ExportTax,LuxuryTax,Series,Number,Branch_ID,Contract,Payment,Limit,Currency_ID,ExchangeRate,Amount,Discount,Charge,ChargeOther,Conveyance,Employee_ID,Commission,User_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("TRANSACTION_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			string[] myPara={"@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={Trans_ID,Trans_No,TransRef,TransType,Created,TransFrom,TransTo,Vat,ImportTax,ExportTax,LuxuryTax,Series,Number,Branch_ID,Contract,Payment,Limit,Currency_ID,ExchangeRate,Amount,Discount,Charge,ChargeOther,Conveyance,Employee_ID,Commission,User_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"TRANSACTION_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			string[] myPara={"@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={Trans_ID,Trans_No,TransRef,TransType,Created,TransFrom,TransTo,Vat,ImportTax,ExportTax,LuxuryTax,Series,Number,Branch_ID,Contract,Payment,Limit,Currency_ID,ExchangeRate,Amount,Discount,Charge,ChargeOther,Conveyance,Employee_ID,Commission,User_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"TRANSACTION_Insert",myPara,myValue);
		}
		#endregion
		

		#region Update
		public string Update()
		{
			string[] myPara={"@ID","@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={m_ID,m_Trans_ID,m_Trans_No,m_TransRef,m_TransType,m_Created,m_TransFrom,m_TransTo,m_Vat,m_ImportTax,m_ExportTax,m_LuxuryTax,m_Series,m_Number,m_Branch_ID,m_Contract,m_Payment,m_Limit,m_Currency_ID,m_ExchangeRate,m_Amount,m_Discount,m_Charge,m_ChargeOther,m_Conveyance,m_Employee_ID,m_Commission,m_User_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("TRANSACTION_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction)
		{
			string[] myPara={"@ID","@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={m_ID,m_Trans_ID,m_Trans_No,m_TransRef,m_TransType,m_Created,m_TransFrom,m_TransTo,m_Vat,m_ImportTax,m_ExportTax,m_LuxuryTax,m_Series,m_Number,m_Branch_ID,m_Contract,m_Payment,m_Limit,m_Currency_ID,m_ExchangeRate,m_Amount,m_Discount,m_Charge,m_ChargeOther,m_Conveyance,m_Employee_ID,m_Commission,m_User_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"TRANSACTION_Update",myPara,myValue);
		}

        public string UpdateByID(SqlTransaction myTransaction)
        {
            
			string[] myPara={"@ID","@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={m_ID,m_Trans_ID,m_Trans_No,m_TransRef,m_TransType,m_Created,m_TransFrom,m_TransTo,m_Vat,m_ImportTax,m_ExportTax,m_LuxuryTax,m_Series,m_Number,m_Branch_ID,m_Contract,m_Payment,m_Limit,m_Currency_ID,m_ExchangeRate,m_Amount,m_Discount,m_Charge,m_ChargeOther,m_Conveyance,m_Employee_ID,m_Commission,m_User_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "TRANSACTION_Update_ByID", myPara, myValue);
        }

		public string Update(long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			string[] myPara={"@ID","@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={ID,Trans_ID,Trans_No,TransRef,TransType,Created,TransFrom,TransTo,Vat,ImportTax,ExportTax,LuxuryTax,Series,Number,Branch_ID,Contract,Payment,Limit,Currency_ID,ExchangeRate,Amount,Discount,Charge,ChargeOther,Conveyance,Employee_ID,Commission,User_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("TRANSACTION_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			string[] myPara={"@ID","@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={ID,Trans_ID,Trans_No,TransRef,TransType,Created,TransFrom,TransTo,Vat,ImportTax,ExportTax,LuxuryTax,Series,Number,Branch_ID,Contract,Payment,Limit,Currency_ID,ExchangeRate,Amount,Discount,Charge,ChargeOther,Conveyance,Employee_ID,Commission,User_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"TRANSACTION_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,long ID,string Trans_ID,string Trans_No,string TransRef,int TransType,DateTime Created,string TransFrom,string TransTo,int Vat,double ImportTax,double ExportTax,double LuxuryTax,string Series,string Number,string Branch_ID,string Contract,int Payment,DateTime Limit,string Currency_ID,double ExchangeRate,double Amount,double Discount,double Charge,double ChargeOther,string Conveyance,string Employee_ID,double Commission,string User_ID,string Description,bool Active)
		{
			string[] myPara={"@ID","@Trans_ID","@Trans_No","@TransRef","@TransType","@Created","@TransFrom","@TransTo","@Vat","@ImportTax","@ExportTax","@LuxuryTax","@Series","@Number","@Branch_ID","@Contract","@Payment","@Limit","@Currency_ID","@ExchangeRate","@Amount","@Discount","@Charge","@ChargeOther","@Conveyance","@Employee_ID","@Commission","@User_ID","@Description","@Active"};
			object[] myValue={ID,Trans_ID,Trans_No,TransRef,TransType,Created,TransFrom,TransTo,Vat,ImportTax,ExportTax,LuxuryTax,Series,Number,Branch_ID,Contract,Payment,Limit,Currency_ID,ExchangeRate,Amount,Discount,Charge,ChargeOther,Conveyance,Employee_ID,Commission,User_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"TRANSACTION_Update",myPara,myValue);
		}

        public string Update(SqlTransaction myTransaction, long ID, long Sorted)
        {
            string[] myPara = { "@ID", "@Sorted" };
            object[] myValue = { ID, Sorted };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "TRANSACTION_Update_BySorted", myPara, myValue);
        }

		#endregion

		#region Delete
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("TRANSACTION_Delete",myPara,myValue);
		}
		public string Delete(long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("TRANSACTION_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"TRANSACTION_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"TRANSACTION_Delete",myPara,myValue);
		}


        public string Delete(string Trans_ID)
        {
            string[] myPara = { "@Trans_ID" };
            object[] myValue = { Trans_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("TRANSACTION_Delete_ByID", myPara, myValue);
        }

        public string Delete(SqlTransaction myTransaction, string Trans_ID)
        {
            string[] myPara = { "@Trans_ID" };
            object[] myValue = { Trans_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "TRANSACTION_Delete_ByID", myPara, myValue);
        }

		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("TRANSACTION_GetList");
		}

        public DataTable GetListByAll()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("TRANSACTION_GetListAll");
        }

        public DataTable GetList(DateTime from, DateTime to)
        {
            string[] myPara = {"@From","@To" };
            object[] myValue = {from,to };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("TRANSACTION_GetList_ByDate",myPara,myValue);
        }



		#endregion

		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "TRANSACTIONName", "TRANSACTIONID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["TRANSACTIONID"] = "All";
			b["TRANSACTIONName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "TRANSACTIONName", "TRANSACTIONID");
		}
		#endregion
		
	}
}
