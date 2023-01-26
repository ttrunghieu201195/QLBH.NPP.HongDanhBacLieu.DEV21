using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{ 
	public class PRODUCT_BRAND
	{
		#region Init
		private string m_ID;
		private string m_Name;
		private string m_Description;
		private bool m_Active;

		public PRODUCT_BRAND()
		{
			 m_ID="";
			 m_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public PRODUCT_BRAND(string ID,string Name,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Name=Name;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
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
				return "Class PRODUCT_BRAND";
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
			return SqlHelper.GenCode("PRODUCT_BRAND","ID","");
		}
		public Boolean Exist(string ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FRM PRODUCT_BRAND WHERE ID = @ID";
			SqlDataReader myReader=mySql.ExecuteReader(sql,myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper(); 
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM PRODUCT_BRAND WHERE ID = @ID";
            SqlDataReader myReader = mySql.ExecuteReader(sql, myPara, myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToString(myReader["ID"]);
						m_Name =Convert.ToString(myReader["Name"]);
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
		public string Get(SqlConnection myConnection,string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM PRODUCT_BRAND WHERE ID = @ID";
            SqlDataReader myReader = mySql.ExecuteReader(sql, myPara, myValue);

			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToString(myReader["ID"]);
						m_Name =Convert.ToString(myReader["Name"]);
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
		public string Get(SqlTransaction myTransaction,string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM PRODUCT_BRAND WHERE ID = @ID";
            SqlDataReader myReader = mySql.ExecuteReader(sql, myPara, myValue); 
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToString(myReader["ID"]);
						m_Name =Convert.ToString(myReader["Name"]);
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

        public string GetByName(SqlTransaction myTransaction, string Name)
        {
            string Result = "";
            string[] myPara = { "@Name" };
            object[] myValue = { Name };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FRM PRODUCT_BRAND WHERE Name = @Name";
            SqlDataReader myReader = mySql.ExecuteReader(sql, myPara, myValue);

            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_Name = Convert.ToString(myReader["Name"]);
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

        public Boolean ExistByName(string Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Name" };
            object[] myValue = { Name };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FRM PRODUCT_BRAND WHERE Name = @Name";
            SqlDataReader myReader = mySql.ExecuteReader(sql, myPara, myValue);
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
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO PRODUCT_BRAND
                              (
                                ID,
                                NAME,
                                DESCRIPTION,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";

			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO PRODUCT_BRAND
                              (
                                ID,
                                NAME,
                                DESCRIPTION,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
 
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		public string Insert(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO PRODUCT_BRAND
                              (
                                ID,
                                NAME,
                                DESCRIPTION,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";

             
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO PRODUCT_BRAND
                              (
                                ID,
                                NAME,
                                DESCRIPTION,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
 
			return mySql.ExecuteNonQuery(myConnection,sql,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO PRODUCT_BRAND
                              (
                                ID,
                                NAME,
                                DESCRIPTION,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"
                            UPDATE PRODUCT_BRAND
                            SET    Name            = @Name,
                                   Description     = @Description,
                                   @Active          = @Active
                            WHERE  ID              = @ID";

			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Update(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"
                            UPDATE PRODUCT_BRAND
                            SET    Name            = @Name,
                                   Description     = @Description,
                                   @Active          = @Active
                            WHERE  ID              = @ID";

			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"
                            UPDATE PRODUCT_BRAND
                            SET    Name            = @Name,
                                   Description     = @Description,
                                   @Active          = @Active
                            WHERE  ID              = @ID";

			return mySql.ExecuteNonQuery(myConnection,sql,myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"
                            UPDATE PRODUCT_BRAND
                            SET    Name            = @Name,
                                   Description     = @Description,
                                   @Active          = @Active
                            WHERE  ID              = @ID";

			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"DELETE FROM PRODUCT_BRAND WHERE ID = @ID";

			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Delete(string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"DELETE FROM PRODUCT_BRAND WHERE ID = @ID";

			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"DELETE FROM PRODUCT_BRAND WHERE ID = @ID";

			return mySql.ExecuteNonQuery(myConnection,sql,myPara,myValue);
		}

		public string Delete(SqlTransaction myTransaction,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"DELETE FROM PRODUCT_BRAND WHERE ID = @ID";

			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
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
            b["ID"] = "All";
            b["Name"] = "Tất cả";
            dt.Rows.InsertAt(b, 0);
            return dt;
        }
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "Name", "ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["ID"] = "All";
			b["Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "Name", "ID");
		}
		#endregion

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT * FROM PRODUCT_BRAND";
            }
        }
        #endregion
		
	}
}
