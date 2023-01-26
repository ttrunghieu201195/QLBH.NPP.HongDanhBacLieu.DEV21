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
	/// Generated Class for Table : PRODUCT_GROUP.
	/// Date: 1/13/2009
	/// Author: 
	/// </summary>
	public class PRODUCT_GROUP
	{
		#region Init
		private string m_ProductGroup_ID;
		private string m_ProductGroup_Name;
		private string m_Description;
		private bool m_Active;
		public PRODUCT_GROUP()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ProductGroup_ID="";
			 m_ProductGroup_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public PRODUCT_GROUP(string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ProductGroup_ID=ProductGroup_ID;
			 m_ProductGroup_Name=ProductGroup_Name;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string ProductGroup_ID
		{
			get
			{
				return m_ProductGroup_ID;
			}
			set
			{
				m_ProductGroup_ID = value;
			}
		}
		public string ProductGroup_Name
		{
			get
			{
				return m_ProductGroup_Name;
			}
			set
			{
				m_ProductGroup_Name = value;
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
				return "Class PRODUCT_GROUP";
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
            return SqlHelper.GenCode("PRODUCT_GROUP", "ProductGroup_ID", "NH");
		}

        public string NewID(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction,"PRODUCT_GROUP", "ProductGroup_ID", "NH");
        }

		public Boolean Exist(string ProductGroup_ID)
		{
			Boolean Result=false;
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				
			}
			return Result;
		}

        public Boolean Exist(SqlTransaction myTransaction,string ProductGroup_ID)
        {
            Boolean Result = false;
            string[] myPara = { "@ProductGroup_ID" };
            object[] myValue = { ProductGroup_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction,"PRODUCT_GROUP_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            return Result;
        }

        public Boolean ExistByName(SqlTransaction myTransaction, string ProductGroup_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@ProductGroup_Name" };
            object[] myValue = { ProductGroup_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "PRODUCT_GROUP_GetByName", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            return Result;
        }

        public Boolean ExistByName(string ProductGroup_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@ProductGroup_Name" };
            object[] myValue = { ProductGroup_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PRODUCT_GROUP_GetByName", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();

            return Result;
        }

		public string Get(string ProductGroup_ID)
		{
			string Result="";
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ProductGroup_ID =Convert.ToString(myReader["ProductGroup_ID"]);
						m_ProductGroup_Name =Convert.ToString(myReader["ProductGroup_Name"]);
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

		public string Get(SqlConnection myConnection,string ProductGroup_ID)
		{
			string Result="";
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PRODUCT_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ProductGroup_ID =Convert.ToString(myReader["ProductGroup_ID"]);
						m_ProductGroup_Name =Convert.ToString(myReader["ProductGroup_Name"]);
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

		public string Get(SqlTransaction myTransaction,string ProductGroup_ID)
		{
			string Result="";
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PRODUCT_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ProductGroup_ID =Convert.ToString(myReader["ProductGroup_ID"]);
						m_ProductGroup_Name =Convert.ToString(myReader["ProductGroup_Name"]);
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

        public string GetByName(SqlTransaction myTransaction, string ProductGroup_Name)
        {
            string Result = "";
            string[] myPara = { "@ProductGroup_Name" };
            object[] myValue = { ProductGroup_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "PRODUCT_GROUP_GetByName", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ProductGroup_ID = Convert.ToString(myReader["ProductGroup_ID"]);
                    m_ProductGroup_Name = Convert.ToString(myReader["ProductGroup_Name"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
               // mySql.Close();
                myReader.Dispose();
                
            }
            return Result;
        }

        public string GetByName(string ProductGroup_Name)
        {
            string Result = "";
            string[] myPara = { "@ProductGroup_Name" };
            object[] myValue = { ProductGroup_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PRODUCT_GROUP_GetByName", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ProductGroup_ID = Convert.ToString(myReader["ProductGroup_ID"]);
                    m_ProductGroup_Name = Convert.ToString(myReader["ProductGroup_Name"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();
            return Result;
        }
		#endregion
		
		#region Add
		public string Insert()
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={m_ProductGroup_ID,m_ProductGroup_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={m_ProductGroup_ID,m_ProductGroup_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_GROUP_Insert",myPara,myValue);
		}
		public string Insert(string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={ProductGroup_ID,ProductGroup_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={ProductGroup_ID,ProductGroup_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
		    m_ProductGroup_ID = ProductGroup_ID;
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={ProductGroup_ID,ProductGroup_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_GROUP_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={m_ProductGroup_ID,m_ProductGroup_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_GROUP_Update",myPara,myValue);
		}

        public string Update(SqlTransaction myTransaction)
        {
            string[] myPara = { "@ProductGroup_ID", "@ProductGroup_Name", "@Description", "@Active" };
            object[] myValue = { m_ProductGroup_ID, m_ProductGroup_Name, m_Description, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "PRODUCT_GROUP_Update", myPara, myValue);
        }

		public string Update(string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={ProductGroup_ID,ProductGroup_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_GROUP_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={ProductGroup_ID,ProductGroup_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_GROUP_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string ProductGroup_ID,string ProductGroup_Name,string Description,bool Active)
		{
			string[] myPara={"@ProductGroup_ID","@ProductGroup_Name","@Description","@Active"};
			object[] myValue={ProductGroup_ID,ProductGroup_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_GROUP_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={m_ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_GROUP_Delete",myPara,myValue);
		}
		public string Delete(string ProductGroup_ID)
		{
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_GROUP_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string ProductGroup_ID)
		{
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_GROUP_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string ProductGroup_ID)
		{
			string[] myPara={"@ProductGroup_ID"};
			object[] myValue={ProductGroup_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_GROUP_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(QGetList);
		}
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
            MyLib.TableToComboBox(combo, GetList(), "ProductGroup_Name", "ProductGroup_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
            b["ProductGroup_ID"] = "All";
            b["ProductGroup_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "ProductGroup_Name", "ProductGroup_ID");
		}
		#endregion

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT
	pg.ProductGroup_ID,
	pg.ProductGroup_Name,
	pg.[Description],
	pg.IsMain,
	pg.[Active],
	CAST(pg.[Active] AS INT) AS ActiveInt
FROM
	PRODUCT_GROUP pg";
            }
        }
        #endregion
		
	}
}
