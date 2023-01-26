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
	 
	public class INDUSTRY
	{
		#region Init
		private string m_ID;
		private string m_Name;
		private string m_Description;
		private bool m_Active;

		public INDUSTRY()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public INDUSTRY(string ID,string Name,string Description,bool Active)
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
				return "Class INDUSTRY";
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
			return SqlHelper.GenCode("INDUSTRY","ID","");
		}
        public string NewID(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "INDUSTRY", "ID", "");
        }
		public Boolean Exist(string ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("INDUSTRY_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

        public Boolean Exist(SqlTransaction myTransaction,string ID)
        {
            Boolean Result = false;
            string[] myPara = { "@ID" };
            object[] myValue = { ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "INDUSTRY_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();
            return Result;
        }

        public Boolean ExistByName(string Name)
        {
            Boolean Result = false;
            //string[] myPara = { "@Name" };
            //object[] myValue = { Name };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader("Select * from INDUSTRY Where Name like N'%"+ Name+"%'");
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
                mySql.Close();
            }
            return Result;
        }

        public Boolean ExistByName(SqlTransaction myTransaction, string Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Name" };
            object[] myValue = { Name };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader("Select * from INDUSTRY Where Name like N'%" + Name + "%'", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
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
			SqlDataReader myReader=mySql.ExecuteReader("SELECT * FROM INDUSTRY WHERE ID = @ID",myPara,myValue);
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
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "SELECT * FROM INDUSTRY WHERE ID = @ID", myPara, myValue);
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
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "SELECT * FROM INDUSTRY WHERE ID = @ID", myPara, myValue);
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
        string sqlInsert = @"INSERT INTO INDUSTRY
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
		public string Insert()
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;

			return mySql.ExecuteNonQuery(sqlInsert,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlInsert,myPara,myValue);
		}
		public string Insert(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlInsert,myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sqlInsert,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
		    m_ID = ID;
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlInsert,myPara,myValue);
		}
		
        #endregion
		
		#region Update
        string sqlUpdate = @"UPDATE INDUSTRY
SET    NAME         = @Name,
       Description = @Description,
       Active     = @Active
WHERE  ID           = @ID";
		public string Update()
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={m_ID,m_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;

			return mySql.ExecuteNonQuery(sqlUpdate,myPara,myValue);
		}
		public string Update(string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlUpdate,myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sqlUpdate,myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string ID,string Name,string Description,bool Active)
		{
			string[] myPara={"@ID","@Name","@Description","@Active"};
			object[] myValue={ID,Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlUpdate,myPara,myValue);
		}
		#endregion
		
		#region Delete
        string sqlDelete = @"DELETE FROM INDUSTRY WHERE ID = @ID";
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlDelete,myPara,myValue);
		}
		public string Delete(string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlDelete,myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sqlDelete,myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlDelete,myPara,myValue);
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
                return @"SELECT
	u.ID,
	u.Name,
	u.[Description],
	u.[Active],
	CAST(u.[Active] AS INT) AS [ActiveInt]
FROM
	INDUSTRY u";
            }
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


    public class EnumIndustry
    {
        public static string stringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static object enumValueOf(string value, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                if (stringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }
    }

   

}
