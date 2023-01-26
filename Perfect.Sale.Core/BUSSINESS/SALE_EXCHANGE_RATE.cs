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

namespace PERFECT.ERP
{
	/// <summary>
	/// Project: Perfect ERP System 
	/// Generated Class for Table : SALE_EXCHANGE_RATE.
	/// Date: 6/18/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class SALE_EXCHANGE_RATE:Object
	{
		#region Init
		private string m_Exchange_Rate_ID;
		private string m_CurrencyCode;
		private DateTime m_StartingDate;
		private string m_RelationCurrencyCode;
		private decimal m_ExchRateAmount;
		private string m_UserID;
		private bool m_Active;
		
		
		public SALE_EXCHANGE_RATE()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Exchange_Rate_ID="";
			 m_CurrencyCode="";
			 m_StartingDate=DateTime.Now;
			 m_RelationCurrencyCode="";
			 m_ExchRateAmount=0;
			 m_UserID="";
			 m_Active=true;
		}
		public SALE_EXCHANGE_RATE(
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Exchange_Rate_ID=Exchange_Rate_ID;
			 m_CurrencyCode=CurrencyCode;
			 m_StartingDate=StartingDate;
			 m_RelationCurrencyCode=RelationCurrencyCode;
			 m_ExchRateAmount=ExchRateAmount;
			 m_UserID=UserID;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Exchange_Rate_ID=Exchange_Rate_ID;
			 m_CurrencyCode=CurrencyCode;
			 m_StartingDate=StartingDate;
			 m_RelationCurrencyCode=RelationCurrencyCode;
			 m_ExchRateAmount=ExchRateAmount;
			 m_UserID=UserID;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		[DisplayName("Exchange_Rate_ID")]
		[Category("Primary Key")]
		public string Exchange_Rate_ID
		{
			get
			{
				return m_Exchange_Rate_ID;
			}
			set
			{
				m_Exchange_Rate_ID = value;
			}
		}
		[DisplayName("CurrencyCode")]
		[Category("Column")]
		public string CurrencyCode
		{
			get
			{
				return m_CurrencyCode;
			}
			set
			{
				m_CurrencyCode = value;
			}
		}
		[DisplayName("StartingDate")]
		[Category("Column")]
		public DateTime StartingDate
		{
			get
			{
				return m_StartingDate;
			}
			set
			{
				m_StartingDate = value;
			}
		}
		[DisplayName("RelationCurrencyCode")]
		[Category("Column")]
		public string RelationCurrencyCode
		{
			get
			{
				return m_RelationCurrencyCode;
			}
			set
			{
				m_RelationCurrencyCode = value;
			}
		}
		[DisplayName("ExchRateAmount")]
		[Category("Column")]
		public decimal ExchRateAmount
		{
			get
			{
				return m_ExchRateAmount;
			}
			set
			{
				m_ExchRateAmount = value;
			}
		}
		[DisplayName("UserID")]
		[Category("Column")]
		public string UserID
		{
			get
			{
				return m_UserID;
			}
			set
			{
				m_UserID = value;
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
				return "Class SALE_EXCHANGE_RATE";
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
			return SqlHelper.GenCode("SALE_EXCHANGE_RATE","SALE_EXCHANGE_RATEID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"SALE_EXCHANGE_RATE","SALE_EXCHANGE_RATEID",key);
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
			m_Exchange_Rate_ID);
		}

		public bool Exist(
			SqlTransaction myTransaction)
		{
			return Exist(
			myTransaction,
			m_Exchange_Rate_ID);
		}

		public bool Exist(
			string Exchange_Rate_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Exist(
			mySql.Connection,
			Exchange_Rate_ID))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string Exchange_Rate_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Exchange_Rate_ID"};
			object[] myValue={
			Exchange_Rate_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_EXCHANGE_RATE_Get",myPara,myValue);
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
			string Exchange_Rate_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Exchange_Rate_ID"};
			object[] myValue={
			Exchange_Rate_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_EXCHANGE_RATE_Get",myPara,myValue);
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
			m_Exchange_Rate_ID);
		}

		public bool Get(SqlConnection myConnection)
		{
			return Get(myConnection,
			m_Exchange_Rate_ID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			m_Exchange_Rate_ID);
		}

		public bool Get(
			string Exchange_Rate_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Get(
			mySql.Connection,
			Exchange_Rate_ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Get(
			SqlConnection myConnection,
			string Exchange_Rate_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Exchange_Rate_ID"};
			object[] myValue={
			Exchange_Rate_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_EXCHANGE_RATE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
                        //m_Exchange_Rate_ID= myReader.GetGuid(myReader.GetOrdinal("Exchange_Rate_ID"));
				        m_Exchange_Rate_ID = Convert.ToString(myReader["Exchange_Rate_ID"]);
						m_CurrencyCode =Convert.ToString(myReader["CurrencyCode"]);
						m_StartingDate =Convert.ToDateTime(myReader["StartingDate"]);
						m_RelationCurrencyCode =Convert.ToString(myReader["RelationCurrencyCode"]);
						m_ExchRateAmount =Convert.ToDecimal(myReader["ExchRateAmount"]);
						m_UserID =Convert.ToString(myReader["UserID"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						if (!myReader.IsDBNull(myReader.GetOrdinal("Exchange_Rate_ID")))
						{
							m_Exchange_Rate_ID= myReader.GetString(myReader.GetOrdinal("Exchange_Rate_ID"));
						}
						m_CurrencyCode =Convert.ToString(myReader["CurrencyCode"]==DBNull.Value?"":myReader["CurrencyCode"] );
						m_StartingDate =Convert.ToDateTime(myReader["StartingDate"]==DBNull.Value?DateTime.Now:myReader["StartingDate"] );
						m_RelationCurrencyCode =Convert.ToString(myReader["RelationCurrencyCode"]==DBNull.Value?"":myReader["RelationCurrencyCode"] );
						m_ExchRateAmount =Convert.ToDecimal(myReader["ExchRateAmount"]==DBNull.Value?0:myReader["ExchRateAmount"] );
						m_UserID =Convert.ToString(myReader["UserID"]==DBNull.Value?"":myReader["UserID"] );
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
			string Exchange_Rate_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Exchange_Rate_ID"};
			object[] myValue={
			Exchange_Rate_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_EXCHANGE_RATE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
                        m_Exchange_Rate_ID = Convert.ToString(myReader["Exchange_Rate_ID"]);
                        //m_Exchange_Rate_ID = Convert.ToString(myReader.GetGuid(myReader.GetOrdinal("Exchange_Rate_ID")));
						m_CurrencyCode =Convert.ToString(myReader["CurrencyCode"]);
						m_StartingDate =Convert.ToDateTime(myReader["StartingDate"]);
						m_RelationCurrencyCode =Convert.ToString(myReader["RelationCurrencyCode"]);
						m_ExchRateAmount =Convert.ToDecimal(myReader["ExchRateAmount"]);
						m_UserID =Convert.ToString(myReader["UserID"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						if (!myReader.IsDBNull(myReader.GetOrdinal("Exchange_Rate_ID")))
						{
							m_Exchange_Rate_ID= myReader.GetString(myReader.GetOrdinal("Exchange_Rate_ID"));
						}
						m_CurrencyCode =Convert.ToString(myReader["CurrencyCode"]==DBNull.Value?"":myReader["CurrencyCode"] );
						m_StartingDate =Convert.ToDateTime(myReader["StartingDate"]==DBNull.Value?DateTime.Now:myReader["StartingDate"] );
						m_RelationCurrencyCode =Convert.ToString(myReader["RelationCurrencyCode"]==DBNull.Value?"":myReader["RelationCurrencyCode"] );
						m_ExchRateAmount =Convert.ToDecimal(myReader["ExchRateAmount"]==DBNull.Value?0:myReader["ExchRateAmount"] );
						m_UserID =Convert.ToString(myReader["UserID"]==DBNull.Value?"":myReader["UserID"] );
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
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool Insert(
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
		public bool Insert(
			SqlConnection myConnection,
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			string[] myPara={
			"@Exchange_Rate_ID",
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount",
			"@UserID",
			"@Active"};
			object[] myValue={
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_EXCHANGE_RATE_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			string[] myPara={
			"@Exchange_Rate_ID",
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount",
			"@UserID",
			"@Active"};
			object[] myValue={
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_EXCHANGE_RATE_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool Update(
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
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
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			string[] myPara={
			"@Exchange_Rate_ID",
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount",
			"@UserID",
			"@Active"};
			object[] myValue={
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_EXCHANGE_RATE_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			string[] myPara={
			"@Exchange_Rate_ID",
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount",
			"@UserID",
			"@Active"};
			object[] myValue={Exchange_Rate_ID,CurrencyCode,StartingDate,RelationCurrencyCode,ExchRateAmount,UserID,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_EXCHANGE_RATE_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_Exchange_Rate_ID,
			m_CurrencyCode,
			m_StartingDate,
			m_RelationCurrencyCode,
			m_ExchRateAmount,
			m_UserID,
			m_Active);
		}
		public bool UpdateByID(
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByID(
			SqlConnection myConnection,
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			string[] myPara={
			"@Exchange_Rate_ID",
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount",
			"@UserID",
			"@Active"};
			object[] myValue={
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_EXCHANGE_RATE_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string Exchange_Rate_ID,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount,
			string UserID,
			bool Active)
		{
			string[] myPara={
			"@Exchange_Rate_ID",
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount",
			"@UserID",
			"@Active"};
			object[] myValue={
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_EXCHANGE_RATE_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Delete
		public bool Delete()
		{
			return Delete(
			m_Exchange_Rate_ID);
		}
		public bool Delete(
			SqlConnection myConnection)
		{
			return Delete(
			myConnection,
			m_Exchange_Rate_ID);
		}
		public bool Delete(
			SqlTransaction myTransaction)
		{
			return Delete(
			myTransaction,
			m_Exchange_Rate_ID);
		}
		public bool Delete(
			string Exchange_Rate_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete(
			mySql.Connection,
			Exchange_Rate_ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Delete(
			SqlConnection myConnection,
			string Exchange_Rate_ID)
		{
			string[] myPara={
			"@Exchange_Rate_ID"};
			object[] myValue={
			Exchange_Rate_ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_EXCHANGE_RATE_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			string Exchange_Rate_ID)
		{
			string[] myPara={
			"@Exchange_Rate_ID"};
			object[] myValue={
			Exchange_Rate_ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_EXCHANGE_RATE_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_EXCHANGE_RATE_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_EXCHANGE_RATE_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_EXCHANGE_RATE_GetList");
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
			return mySql.ExecuteScalar(myConnection,"SALE_EXCHANGE_RATE_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"SALE_EXCHANGE_RATE_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount)
		{
			string[] myPara={
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount"};
			object[] myValue={
			"%"+CurrencyCode+"%",
			"%"+StartingDate+"%",
			"%"+RelationCurrencyCode+"%",
			"%"+ExchRateAmount+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_EXCHANGE_RATE_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			string CurrencyCode,
			DateTime StartingDate,
			string RelationCurrencyCode,
			decimal ExchRateAmount)
		{
			string[] myPara={
			"@CurrencyCode",
			"@StartingDate",
			"@RelationCurrencyCode",
			"@ExchRateAmount"};
			object[] myValue={
			"%"+CurrencyCode+"%",
			"%"+StartingDate+"%",
			"%"+RelationCurrencyCode+"%",
			"%"+ExchRateAmount+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_EXCHANGE_RATE_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_EXCHANGE_RATE_LookUp");
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

	public enum SALE_EXCHANGE_RATEFields
		{
			Exchange_Rate_ID,
			CurrencyCode,
			StartingDate,
			RelationCurrencyCode,
			ExchRateAmount,
			UserID,
			Active
		}

	#endregion

	#region Class Collection

	public class SALE_EXCHANGE_RATECollection : System.Collections.CollectionBase
		{
			[Description("Adds a new SALE_EXCHANGE_RATE to the collection.")]
			public int Add(SALE_EXCHANGE_RATE item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a SALE_EXCHANGE_RATE from the collection.")]
			public void Remove(SALE_EXCHANGE_RATE item)
				{
					List.Remove(item);
				}
			[Description("Inserts an SALE_EXCHANGE_RATE into the collection at the specified index..")]
			public void Inserts(int index,SALE_EXCHANGE_RATE item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(SALE_EXCHANGE_RATE item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the SALE_EXCHANGE_RATE class is present in the collection.")]
			public bool Contains(SALE_EXCHANGE_RATE item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
