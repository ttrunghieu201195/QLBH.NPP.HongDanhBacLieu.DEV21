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
	/// Generated Class for Table : PRODUCT_UNIT.
	/// Date: 19/01/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class PRODUCT_UNIT:Object
	{
		#region Init
		private string m_Product_ID;
		private string m_Unit_ID;
		private string m_UnitConvert_ID;
		private decimal m_UnitConvert;
		private long m_Sorted;
		
		
		public PRODUCT_UNIT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Product_ID="";
			 m_Unit_ID="";
			 m_UnitConvert_ID="";
			 m_UnitConvert=0;
			 m_Sorted=0;
		}
		public PRODUCT_UNIT(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Product_ID=Product_ID;
			 m_Unit_ID=Unit_ID;
			 m_UnitConvert_ID=UnitConvert_ID;
			 m_UnitConvert=UnitConvert;
			 m_Sorted=Sorted;
		}
		
		
		public void SetData(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Product_ID=Product_ID;
			 m_Unit_ID=Unit_ID;
			 m_UnitConvert_ID=UnitConvert_ID;
			 m_UnitConvert=UnitConvert;
			 m_Sorted=Sorted;
		}
		#endregion
		
		#region Property
		[DisplayName("Product_ID")]
		[Category("Primary Key")]
		public string Product_ID
		{
			get
			{
				return m_Product_ID;
			}
			set
			{
				m_Product_ID = value;
			}
		}
		[DisplayName("Unit_ID")]
		[Category("Primary Key")]
		public string Unit_ID
		{
			get
			{
				return m_Unit_ID;
			}
			set
			{
				m_Unit_ID = value;
			}
		}
		[DisplayName("UnitConvert_ID")]
		[Category("Primary Key")]
		public string UnitConvert_ID
		{
			get
			{
				return m_UnitConvert_ID;
			}
			set
			{
				m_UnitConvert_ID = value;
			}
		}
		[DisplayName("UnitConvert")]
		[Category("Column")]
		public decimal UnitConvert
		{
			get
			{
				return m_UnitConvert;
			}
			set
			{
				m_UnitConvert = value;
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
				return "Class PRODUCT_UNIT";
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
			return SqlHelper.GenCode("PRODUCT_UNIT","PRODUCT_UNITID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"PRODUCT_UNIT","PRODUCT_UNITID",key);
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
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID);
		}

		public bool Exist(
			SqlTransaction myTransaction)
		{
			return Exist(
			myTransaction,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID);
		}

		public bool Exist(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Exist(
			mySql.Connection,
			Product_ID,
			Unit_ID,
			UnitConvert_ID))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PRODUCT_UNIT_Get",myPara,myValue);
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
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PRODUCT_UNIT_Get",myPara,myValue);
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
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID);
		}

		public bool Get(SqlConnection myConnection)
		{
			return Get(myConnection,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID);
		}

		public bool Get(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Get(
			mySql.Connection,
			Product_ID,
			Unit_ID,
			UnitConvert_ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Get(
			SqlConnection myConnection,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PRODUCT_UNIT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]);
						m_UnitConvert_ID =Convert.ToString(myReader["UnitConvert_ID"]);
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]==DBNull.Value?"":myReader["Unit_ID"] );
						m_UnitConvert_ID =Convert.ToString(myReader["UnitConvert_ID"]==DBNull.Value?"":myReader["UnitConvert_ID"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
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
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PRODUCT_UNIT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]);
						m_UnitConvert_ID =Convert.ToString(myReader["UnitConvert_ID"]);
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]==DBNull.Value?"":myReader["Unit_ID"] );
						m_UnitConvert_ID =Convert.ToString(myReader["UnitConvert_ID"]==DBNull.Value?"":myReader["UnitConvert_ID"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
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
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert,
			m_Sorted);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert,
			m_Sorted);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert,
			m_Sorted);
		}
		public bool Insert(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert,
			Sorted))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
		public bool Insert(
			SqlConnection myConnection,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID",
			"@UnitConvert",
			"@Sorted"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_UNIT_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID",
			"@UnitConvert",
			"@Sorted"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_UNIT_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region Update
		public bool Update()
		{
			return Update(
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert,
			m_Sorted);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert,
			m_Sorted);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert,
			m_Sorted);
		}
		public bool Update(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert,
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
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID",
			"@UnitConvert",
			"@Sorted"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_UNIT_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert,
			long Sorted)
		{
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID",
			"@UnitConvert",
			"@Sorted"};
			object[] myValue={Product_ID,Unit_ID,UnitConvert_ID,UnitConvert,Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_UNIT_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_Product_ID,
			m_Unit_ID,
			m_UnitConvert_ID,
			m_UnitConvert);
		}
		public bool UpdateByID(
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByID(
			SqlConnection myConnection,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert)
		{
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID",
			"@UnitConvert"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_UNIT_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string Product_ID,
			string Unit_ID,
			string UnitConvert_ID,
			decimal UnitConvert)
		{
			string[] myPara={
			"@Product_ID",
			"@Unit_ID",
			"@UnitConvert_ID",
			"@UnitConvert"};
			object[] myValue={
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_UNIT_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region Delete
		public bool Delete()
		{
			return Delete(m_Product_ID);
		}
		public bool Delete(
			SqlConnection myConnection)
		{
			return Delete(
			myConnection,
			m_Product_ID);
		}

		public bool Delete(
			SqlTransaction myTransaction)
		{
			return Delete(myTransaction,m_Product_ID);
		}
		public bool Delete(
			string Product_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete(
			mySql.Connection,
			Product_ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}



		public bool Delete(
			SqlConnection myConnection,
			string Product_ID)
		{
			string[] myPara={
			"@Product_ID"};
			object[] myValue={
			Product_ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_UNIT_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(SqlTransaction myTransaction,string Product_ID)
		{
			string[] myPara={
			"@Product_ID"};
			object[] myValue={
			Product_ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_UNIT_Delete",myPara,myValue)=="OK"?true:false;
		}

       
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("PRODUCT_UNIT_GetList");
		}
		#endregion

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"PRODUCT_UNIT_GetList");
		}
		#endregion

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"PRODUCT_UNIT_GetList");
		}

        public DataTable GetList(string Product_ID)
        {
            string[] myPara = { "@Product_ID" };
            object[] myValue = { Product_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("UNITCONVERT_GetList_PRODUCT", myPara, myValue);
        }
        public decimal GetConvert(string ProductID, string UnitID, string UnitConvertID)
        {
            
            PRODUCT product=new PRODUCT();
            if (product.Get(ProductID) != "OK") return 1;
            if (product.Unit == UnitConvertID) return 1;
            //if (product.UnitConvert == UnitChildID) return (decimal) product.UnitRate;
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Product_ID", "@Unit_ID", "@UnitConvert_ID" };
            object[] myValue = { ProductID, UnitID, UnitConvertID };
            mysql.CommandType = System.Data.CommandType.Text;
            return mysql.ExecuteScalar("Select UnitConvert From [PRODUCT_UNIT] Where  Product_ID = @Product_ID AND  Unit_ID = @Unit_ID AND  UnitConvert_ID = @UnitConvert_ID", myPara, myValue, 0);
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
			return mySql.ExecuteScalar(myConnection,"PRODUCT_UNIT_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"PRODUCT_UNIT_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			decimal UnitConvert)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			UnitConvert);
			return null;
		}
		#endregion

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			decimal UnitConvert)
		{
			string[] myPara={
			"@UnitConvert"};
			object[] myValue={
			"%"+UnitConvert+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"PRODUCT_UNIT_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			decimal UnitConvert)
		{
			string[] myPara={
			"@UnitConvert"};
			object[] myValue={
			"%"+UnitConvert+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"PRODUCT_UNIT_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("PRODUCT_UNIT_LookUp");
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

	public enum PRODUCT_UNITFields
		{
			Product_ID,
			Unit_ID,
			UnitConvert_ID,
			UnitConvert,
			Sorted
		}

	#endregion

	#region Class Collection

	public class PRODUCT_UNITCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new PRODUCT_UNIT to the collection.")]
			public int Add(PRODUCT_UNIT item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a PRODUCT_UNIT from the collection.")]
			public void Remove(PRODUCT_UNIT item)
				{
					List.Remove(item);
				}
			[Description("Inserts an PRODUCT_UNIT into the collection at the specified index..")]
			public void Inserts(int index,PRODUCT_UNIT item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(PRODUCT_UNIT item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the PRODUCT_UNIT class is present in the collection.")]
			public bool Contains(PRODUCT_UNIT item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
