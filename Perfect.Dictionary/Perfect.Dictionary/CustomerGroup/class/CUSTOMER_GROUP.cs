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
	/// Generated Class for Table : CUSTOMER_GROUP.
	/// Date: 1/12/2009
	/// Author: 
	/// </summary>
	public class CUSTOMER_GROUP
	{
		#region Init
		private string m_Customer_Group_ID;
		private string m_Customer_Group_Name;
		private string m_Description;
		private bool m_Active;
		public CUSTOMER_GROUP()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Customer_Group_ID="";
			 m_Customer_Group_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public CUSTOMER_GROUP(string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Customer_Group_ID=Customer_Group_ID;
			 m_Customer_Group_Name=Customer_Group_Name;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Customer_Group_ID
		{
			get
			{
				return m_Customer_Group_ID;
			}
			set
			{
				m_Customer_Group_ID = value;
			}
		}
		public string Customer_Group_Name
		{
			get
			{
				return m_Customer_Group_Name;
			}
			set
			{
				m_Customer_Group_Name = value;
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
				return "Class CUSTOMER_GROUP";
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
			return SqlHelper.GenCode("CUSTOMER_GROUP","CUSTOMER_GROUPID","");
		}
		public Boolean Exist(string Customer_Group_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("CUSTOMER_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Customer_Group_ID)
		{
			string Result="";
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("CUSTOMER_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Customer_Group_ID =Convert.ToString(myReader["Customer_Group_ID"]);
						m_Customer_Group_Name =Convert.ToString(myReader["Customer_Group_Name"]);
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
		public string Get(SqlConnection myConnection,string Customer_Group_ID)
		{
			string Result="";
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Customer_Group_ID =Convert.ToString(myReader["Customer_Group_ID"]);
						m_Customer_Group_Name =Convert.ToString(myReader["Customer_Group_Name"]);
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
		public string Get(SqlTransaction myTransaction,string Customer_Group_ID)
		{
			string Result="";
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Customer_Group_ID =Convert.ToString(myReader["Customer_Group_ID"]);
						m_Customer_Group_Name =Convert.ToString(myReader["Customer_Group_Name"]);
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

        public string GetByName(SqlTransaction myTransaction, string Customer_Group_Name)
        {
            string Result = "";
            string[] myPara = { "@Customer_Group_Name" };
            object[] myValue = { Customer_Group_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "CUSTOMER_GROUP_GetByName", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Customer_Group_ID = Convert.ToString(myReader["Customer_Group_ID"]);
                    m_Customer_Group_Name = Convert.ToString(myReader["Customer_Group_Name"]);
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

        public Boolean ExistByName(string Customer_Group_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Customer_Group_Name" };
            object[] myValue = { Customer_Group_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CUSTOMER_GROUP_GetByName", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();

            return Result;
        }







		#region Add
		public string Insert()
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={m_Customer_Group_ID,m_Customer_Group_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={m_Customer_Group_ID,m_Customer_Group_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_GROUP_Insert",myPara,myValue);
		}
		public string Insert(string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={Customer_Group_ID,Customer_Group_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={Customer_Group_ID,Customer_Group_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={Customer_Group_ID,Customer_Group_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_GROUP_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={m_Customer_Group_ID,m_Customer_Group_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_GROUP_Update",myPara,myValue);
		}
		public string Update(string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={Customer_Group_ID,Customer_Group_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_GROUP_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={Customer_Group_ID,Customer_Group_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_GROUP_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Customer_Group_ID,string Customer_Group_Name,string Description,bool Active)
		{
			string[] myPara={"@Customer_Group_ID","@Customer_Group_Name","@Description","@Active"};
			object[] myValue={Customer_Group_ID,Customer_Group_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_GROUP_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={m_Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_GROUP_Delete",myPara,myValue);
		}
		public string Delete(string Customer_Group_ID)
		{
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_GROUP_Delete",myPara,myValue);

		}
		public string Delete(SqlConnection myConnection,string Customer_Group_ID)
		{
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_GROUP_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Customer_Group_ID)
		{
			string[] myPara={"@Customer_Group_ID"};
			object[] myValue={Customer_Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_GROUP_Delete",myPara,myValue);
		}
		#endregion


        #region Check Customer And Provider

        public bool ExistCustomerAndProvider(SqlTransaction myTransaction, string Customer_Group_ID)
        {
            string[] myPara = { "@CustomerGroupID" };
            object[] myValue = { Customer_Group_ID };
            
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            string sql = "DECLARE @CountCustomerGroup INT \n"
          + "SET @CountCustomerGroup = 0 \n"
          + " \n"
          + "SET @CountCustomerGroup = (SELECT COUNT(*) FROM CUSTOMER c \n"
          + "WHERE c.Customer_Group_ID = @CustomerGroupID) \n"
          + " \n"
          + "SET @CountCustomerGroup = @CountCustomerGroup + (SELECT COUNT(*) FROM PROVIDER p \n"
          + "WHERE p.Customer_Group_ID = @CustomerGroupID) \n"
          + " \n"
          + "SELECT @CountCustomerGroup";

            int count = Convert.ToInt32(mySql.ExecuteScalar(myTransaction, sql, myPara, myValue));
            if (count > 0)
                return true;
            return false;
        }


        /*
         
         string sql = "DECLARE @CountCustomerGroup INT \n"
           + "SET @CountCustomerGroup = 0 \n"
           + " \n"
           + "SET @CountCustomerGroup = (SELECT COUNT(*) FROM CUSTOMER c \n"
           + "WHERE c.Customer_Group_ID = @CustomerGroupID) \n"
           + " \n"
           + "SET @CountCustomerGroup = @CountCustomerGroup + (SELECT COUNT(*) FROM PROVIDER p \n"
           + "WHERE p.Customer_Group_ID = @CustomerGroupID) \n"
           + " \n"
           + "SELECT @CountCustomerGroup";
         */
        
        #endregion
        
        
        
        
        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(QGetList);
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt = GetList();
            DataRow b = dt.NewRow();
            b["CUSTOMER_GROUP_ID"] = "All";
            b["CUSTOMER_GROUP_Name"] = "Tất cả";
            dt.Rows.InsertAt(b, 0);
            return dt;
        }
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "CUSTOMER_GROUP_Name", "CUSTOMER_GROUP_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["CUSTOMER_GROUP_ID"] = "All";
			b["CUSTOMER_GROUP_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "CUSTOMER_GROUP_Name", "CUSTOMER_GROUP_ID");
		}
		#endregion

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT
	cg.Customer_Group_ID,
	cg.Customer_Group_Name,
	cg.[Description],
	cg.[Active],
	CAST(cg.[Active] AS INT) AS [ActiveInt]
FROM
	CUSTOMER_GROUP cg";
            }
        }
        #endregion
		
	}
}
