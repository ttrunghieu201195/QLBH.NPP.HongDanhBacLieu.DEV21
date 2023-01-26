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
	/// Generated Class for Table : SALE_CURRENCY.
	/// Date: 6/18/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class SALE_CURRENCY:Object
	{
		#region Init
		private string m_Code;
		private string m_Name;
		private bool m_Active;
		
		
		public SALE_CURRENCY()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Code="";
			 m_Name="";
			 m_Active=true;
		}
		public SALE_CURRENCY(
			string Code,
			string Name,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Code=Code;
			 m_Name=Name;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string Code,
			string Name,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Code=Code;
			 m_Name=Name;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		[DisplayName("Code")]
		[Category("Primary Key")]
		public string Code
		{
			get
			{
				return m_Code;
			}
			set
			{
				m_Code = value;
			}
		}
		[DisplayName("Name")]
		[Category("Column")]
		public string Name
		{
			get
			{
				return m_Name;
			}
			set
			{
				m_Name = value;
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
				return "Class SALE_CURRENCY";
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
			return SqlHelper.GenCode("SALE_CURRENCY","SALE_CURRENCYID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"SALE_CURRENCY","SALE_CURRENCYID",key);
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
			m_Code);
		}

		public bool Exist(
			SqlTransaction myTransaction)
		{
			return Exist(
			myTransaction,
			m_Code);
		}

		public bool Exist(
			string Code)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Exist(
			mySql.Connection,
			Code))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string Code)
		{
			bool Result=false;
			string[] myPara={
			"@Code"};
			object[] myValue={
			Code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_CURRENCY_Get",myPara,myValue);
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
			string Code)
		{
			bool Result=false;
			string[] myPara={
			"@Code"};
			object[] myValue={
			Code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_CURRENCY_Get",myPara,myValue);
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

		#region Exist By Code

		public bool ExistByCode()
		{
				return ExistByCode(m_Code);
		}


		public bool ExistByCode(string Code)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open() !="OK") return false;
			if (ExistByCode(mySql.Connection,Code))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool ExistByCode(SqlTransaction myTransaction,string Code)
		{
			bool Result=false;
			string[] myPara={"@Code"};
			object[] myValue={Code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_CURRENCY_ExistByCode",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
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

		public bool ExistByCode(
			SqlConnection myConnection,
			string Code)
		{
			bool Result=false;
			string[] myPara={"@Code"};
			object[] myValue={Code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_CURRENCY_ExistByCode",myPara,myValue);
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

		#endregion

		#region Exist By Name

		public bool ExistByName()
		{
				return ExistByName(Name);
		}


		public Boolean ExistByName(string Name)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (ExistByName(mySql.Connection,Name))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool ExistByName(
			SqlTransaction myTransaction,
			string Name)
		{
			bool Result=false;
			string[] myPara={"@Name"};
			object[] myValue={Name};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_CURRENCY_ExistByName",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
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

		public Boolean ExistByName(
			SqlConnection myConnection,
			string Name)
		{
			Boolean Result=false;
			string[] myPara={"@Name"};
			object[] myValue={Name};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_CURRENCY_ExistByName",myPara,myValue);
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

		#endregion

		#region Get

		public bool Get()
		{
			return Get(
			m_Code);
		}

		public bool Get(SqlConnection myConnection)
		{
			return Get(myConnection,
			m_Code);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			m_Code);
		}

		public bool Get(
			string Code)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Get(
			mySql.Connection,
			Code))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Get(
			SqlConnection myConnection,
			string Code)
		{
			bool Result=false;
			string[] myPara={
			"@Code"};
			object[] myValue={
			Code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_CURRENCY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Code =Convert.ToString(myReader["Code"]);
						m_Name =Convert.ToString(myReader["Name"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Code =Convert.ToString(myReader["Code"]==DBNull.Value?"":myReader["Code"] );
						m_Name =Convert.ToString(myReader["Name"]==DBNull.Value?"":myReader["Name"] );
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
			string Code)
		{
			bool Result=false;
			string[] myPara={
			"@Code"};
			object[] myValue={
			Code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_CURRENCY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Code =Convert.ToString(myReader["Code"]);
						m_Name =Convert.ToString(myReader["Name"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Code =Convert.ToString(myReader["Code"]==DBNull.Value?"":myReader["Code"] );
						m_Name =Convert.ToString(myReader["Name"]==DBNull.Value?"":myReader["Name"] );
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

		#region Get By Code

		public bool GetByCode()
		{
			return GetByCode(m_Code);
		}

		public bool GetByCode(SqlConnection myConnection)
		{
			return GetByCode(myConnection,m_Code);
		}

		public bool GetByCode(SqlTransaction myTransaction)
		{
			return GetByCode(myTransaction,m_Code);
		}

		public bool GetByCode(
			string code)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (GetByCode(mySql.Connection,code))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool GetByCode(
			SqlConnection myConnection,
			string code)
		{
			bool Result=false;
			string[] myPara={"@code"};
			object[] myValue={code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_CURRENCY_GetByCode",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Code =Convert.ToString(myReader["Code"]);
						m_Name =Convert.ToString(myReader["Name"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Code =Convert.ToString(myReader["Code"]==DBNull.Value?"":myReader["Code"] );
						m_Name =Convert.ToString(myReader["Name"]==DBNull.Value?"":myReader["Name"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
						#endif
						Result=true;
				}
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

		public bool GetByCode(SqlTransaction myTransaction,string code)
		{
			bool Result=false;
			string[] myPara={"@code"};
			object[] myValue={code};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_CURRENCY_GetByCode",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Code =Convert.ToString(myReader["Code"]);
						m_Name =Convert.ToString(myReader["Name"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Code =Convert.ToString(myReader["Code"]==DBNull.Value?"":myReader["Code"] );
						m_Name =Convert.ToString(myReader["Name"]==DBNull.Value?"":myReader["Name"] );
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
			m_Code,
			m_Name,
			m_Active);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool Insert(
			string Code,
			string Name,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			Code,
			Name,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
		public bool Insert(
			SqlConnection myConnection,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_CURRENCY_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_CURRENCY_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_Code,
			m_Name,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_Code,
			m_Name,
			m_Active);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool Update(
			string Code,
			string Name,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			Code,
			Name,
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
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_CURRENCY_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={Code,Name,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_CURRENCY_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_Code,
			m_Name,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool UpdateByID(
			string Code,
			string Name,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			Code,
			Name,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByID(
			SqlConnection myConnection,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_CURRENCY_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_CURRENCY_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByCode
		public bool UpdateByCode()
		{
			return UpdateByCode(
			m_Code,
			m_Name,
			m_Active);
		}
		public bool UpdateByCode(
			SqlConnection myConnection)
		{
			return UpdateByCode(
			myConnection,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool UpdateByCode(
			SqlTransaction myTransaction)
		{
			return UpdateByCode(
			myTransaction,
			m_Code,
			m_Name,
			m_Active);
		}
		public bool UpdateByCode(
			string Code,
			string Name,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (
			UpdateByCode(mySql.Connection,
			Code,
			Name,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByCode(
			SqlConnection myConnection,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_CURRENCY_UpdateByCode",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByCode(
			SqlTransaction myTransaction,
			string Code,
			string Name,
			bool Active)
		{
			string[] myPara={
			"@Code",
			"@Name",
			"@Active"};
			object[] myValue={
			Code,
			Name,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_CURRENCY_UpdateByCode",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Delete
		public bool Delete()
		{
			return Delete(
			m_Code);
		}
		public bool Delete(
			SqlConnection myConnection)
		{
			return Delete(
			myConnection,
			m_Code);
		}
		public bool Delete(
			SqlTransaction myTransaction)
		{
			return Delete(
			myTransaction,
			m_Code);
		}
		public bool Delete(
			string Code)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete(
			mySql.Connection,
			Code))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Delete(
			SqlConnection myConnection,
			string Code)
		{
			string[] myPara={
			"@Code"};
			object[] myValue={
			Code};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_CURRENCY_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			string Code)
		{
			string[] myPara={
			"@Code"};
			object[] myValue={
			Code};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_CURRENCY_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region DeleteByCode
		public bool DeleteByCode()
		{
			return DeleteByCode(m_Code);
		}
		public bool DeleteByCode(SqlConnection myConnection)
		{
            //return DeleteByCode(myConnection,m_Code);
		    return true;
		}
		public bool DeleteByCode(SqlTransaction myTransaction)
		{
            //return DeleteByCode(myTransaction,m_Code);
            return true;
		}
		public bool DeleteByCode(string code)
		{
            //SqlHelper mySql=new SqlHelper();
            //mySql.Error += DispError;
            //if (mySql.Open()!="OK") return false;
            //return DeleteByCode(mySql.Connection,code);
			return false;
		}

        //public bool DeleteByCode(SqlConnection myConnection,string code)
        //{
        //    string[] myPara={"@code"};
        //    object[] myValue={code};
        //    SqlHelper mySql=new SqlHelper();
        //    mySql.Error += DispError;
        //    return mySql.ExecuteNonQuery(myConnection,"SALE_CURRENCY_DeleteByCode",myPara,myValue);
        //}
        //public bool DeleteByCode(SqlTransaction myTransaction,string code)
        //{
        //    string[] myPara={"@code"};
        //    object[] myValue={code};
        //    SqlHelper mySql=new SqlHelper();
        //    mySql.Error += DispError;
        //    return mySql.ExecuteNonQuery(myTransaction,"SALE_CURRENCY_DeleteByCode",myPara,myValue);
        //}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_CURRENCY_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_CURRENCY_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_CURRENCY_GetList");
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
			return mySql.ExecuteScalar(myConnection,"SALE_CURRENCY_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"SALE_CURRENCY_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			string Code,
			string Name)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			Code,
			Name);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			string Code,
			string Name)
		{
			string[] myPara={
			"@Code",
			"@Name"};
			object[] myValue={
			"%"+Code+"%",
			"%"+Name+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_CURRENCY_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			string Code,
			string Name)
		{
			string[] myPara={
			"@Code",
			"@Name"};
			object[] myValue={
			"%"+Code+"%",
			"%"+Name+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_CURRENCY_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_CURRENCY_LookUp");
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

	public enum SALE_CURRENCYFields
		{
			Code,
			Name,
			Active
		}

	#endregion

	#region Class Collection

	public class SALE_CURRENCYCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new SALE_CURRENCY to the collection.")]
			public int Add(SALE_CURRENCY item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a SALE_CURRENCY from the collection.")]
			public void Remove(SALE_CURRENCY item)
				{
					List.Remove(item);
				}
			[Description("Inserts an SALE_CURRENCY into the collection at the specified index..")]
			public void Inserts(int index,SALE_CURRENCY item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(SALE_CURRENCY item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the SALE_CURRENCY class is present in the collection.")]
			public bool Contains(SALE_CURRENCY item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
