using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{
	public class ROUTE
	{
		#region Init
		private string m_ID;
		private string m_Name;
		private string m_Description;
		private bool m_Active;
		public ROUTE()
		{
			 m_ID="";
			 m_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public ROUTE(string ID, string Name,string Description,bool Active)
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
				return "Class ROUTE";
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
			return SqlHelper.GenCode("ROUTE","ID","");
		}
		public Boolean Exist(string ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			SqlDataReader myReader=mySql.ExecuteReader("SELECT * FROM ROUTE WHERE ID = @ID",myPara,myValue);
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
            SqlDataReader myReader = mySql.ExecuteReader("SELECT * FROM ROUTE WHERE ID = @ID", myPara, myValue);
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
            SqlDataReader myReader = mySql.ExecuteReader("SELECT * FROM ROUTE WHERE ID = @ID", myPara, myValue);
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
            SqlDataReader myReader = mySql.ExecuteReader("SELECT * FROM ROUTE WHERE ID = @ID", myPara, myValue);
            if (myReader != null)
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
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO [ROUTE]
                          (
                            ID,
	                        Name,
	                        [Description],
	                        [Active]
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
			return mySql.ExecuteNonQuery(myTransaction,"ROUTE_Insert",myPara,myValue);
		}
		public string Insert(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("ROUTE_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"ROUTE_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"ROUTE_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"UPDATE [ROUTE]
                              SET
                                Name = @Name,
                                Description = @Description,
                                Active = @Active
                              WHERE ID = @ID";
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Update(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("ROUTE_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"ROUTE_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"ROUTE_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery("DELETE FROM ROUTE WHERE ID = @ID", myPara, myValue);
		}
		public string Delete(string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery("DELETE FROM ROUTE WHERE ID = @ID", myPara, myValue);
		}
		public string Delete(SqlConnection myConnection,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myConnection, "DELETE FROM ROUTE WHERE ID = @ID", myPara, myValue);
		}
		public string Delete(SqlTransaction myTransaction,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction, "DELETE FROM ROUTE WHERE ID = @ID", myPara, myValue);
		}
		#endregion

  
        
        
        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            return mySql.ExecuteDataTable("SELECT * FROM ROUTE ORDER BY ID");
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
			MyLib.TableToComboBox(combo,GetList(), "ROUTE_Name", "ROUTE_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["ROUTE_ID"] = "All";
			b["ROUTE_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "ROUTE_Name", "ROUTE_ID");
		}
		#endregion

	}
}
