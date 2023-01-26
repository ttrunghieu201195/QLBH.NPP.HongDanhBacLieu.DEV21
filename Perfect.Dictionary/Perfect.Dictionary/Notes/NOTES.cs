using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using System.ComponentModel;
using System.Reflection;

namespace Perfect.ERP
{
	 
	public class NOTES
	{
		#region Init
		private string m_ID;
		private string m_Name;
		private string m_Description;
		private bool m_Active;

		public NOTES()
		{
			 
			 m_ID="";
			 m_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public NOTES(string ID,string Name,string Description,bool Active)
		{ 
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
				return "Class NOTES";
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
			return SqlHelper.GenCode("NOTES","ID","");
		}
        public string NewID(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "NOTES", "ID", "");
        }
		public Boolean Exist(string ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM NOTES WHERE ID = @ID";
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

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM NOTES";
            return mySql.ExecuteDataTable(sql);
        }
        public Boolean Exist(SqlTransaction myTransaction,string ID)
        {
            Boolean Result = false;
            string[] myPara = { "@ID" };
            object[] myValue = { ID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM NOTES WHERE ID = @ID";
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, sql, myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();
            return Result;
        } 
		public string Get(string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM NOTES WHERE ID = @ID";
			SqlDataReader myReader=mySql.ExecuteReader(sql,myPara,myValue);
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
            string sql = @"SELECT * FROM NOTES WHERE ID = @ID";
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,sql,myPara,myValue);
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
            string sql = @"SELECT * FROM NOTES WHERE ID = @ID";
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,sql,myPara,myValue);
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
		
		#region Add
		public string Insert()
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @"
                            INSERT INTO NOTES
                              (
                                ID,
                                NAME,
                                Description,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @"
                            INSERT INTO NOTES
                              (
                                ID,
                                NAME,
                                Description,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		public string Insert(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @"
                            INSERT INTO NOTES
                              (
                                ID,
                                NAME,
                                Description,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @"
                            INSERT INTO NOTES
                              (
                                ID,
                                NAME,
                                Description,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sql,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
		    m_ID = ID;
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @"
                            INSERT INTO NOTES
                              (
                                ID,
                                NAME,
                                Description,
                                ACTIVE
                              )
                            VALUES
                              (
                                @ID,
                                @Name,
                                @Description,
                                @Active
                              )";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @" UPDATE NOTES
	                        SET    Name            = @Name,
	                               Description     = @Description,
	                               Active          = @Active
	                        WHERE  ID              = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Update(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @" UPDATE NOTES
	                        SET    Name            = @Name,
	                               Description     = @Description,
	                               Active          = @Active
	                        WHERE  ID              = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @" UPDATE NOTES
	                        SET    Name            = @Name,
	                               Description     = @Description,
	                               Active          = @Active
	                        WHERE  ID              = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sql,myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            string sql = @" UPDATE NOTES
	                        SET    Name            = @Name,
	                               Description     = @Description,
	                               Active          = @Active
	                        WHERE  ID              = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		#endregion
		
		#region Delete
        public string Delete()
        {
            string[] myPara = { "@ID" };
            object[] myValue = { m_ID };
            SqlHelper mySql = new SqlHelper();
            string sql = @"DELETE FROM NOTES WHERE ID = @ID";
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(sql, myPara, myValue);
        }
		public string Delete(string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            string sql = @"DELETE FROM NOTES WHERE ID = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            string sql = @" DELETE FROM NOTES WHERE ID = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sql,myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            string sql = @" DELETE FROM NOTES WHERE ID = @ID";
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		#endregion
		 

        public enum Fields
        {
            [DescriptionAttribute("ID")]
            ID,
            [DescriptionAttribute("Name")]
            Name,
            [DescriptionAttribute("Description")]
            Description,
            [DescriptionAttribute("Active")]
            Active,
        }
		
	}


   

}
