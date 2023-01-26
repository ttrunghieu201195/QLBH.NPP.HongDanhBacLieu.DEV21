using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{

	public class STOCK
	{
		#region Init
		private string m_Stock_ID;
		private string m_Stock_Name;
		private string m_Contact;
		private string m_Address;
		private string m_Email;
		private string m_Telephone;
		private string m_Fax;
		private string m_Mobi;
		private string m_Manager;
		private string m_Description;
		private bool m_Active;
		public STOCK()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Stock_ID="";
			 m_Stock_Name="";
			 m_Contact="";
			 m_Address="";
			 m_Email="";
			 m_Telephone="";
			 m_Fax="";
			 m_Mobi="";
			 m_Manager="";
			 m_Description="";
			 m_Active=true;
		}
		public STOCK(string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Stock_ID=Stock_ID;
			 m_Stock_Name=Stock_Name;
			 m_Contact=Contact;
			 m_Address=Address;
			 m_Email=Email;
			 m_Telephone=Telephone;
			 m_Fax=Fax;
			 m_Mobi=Mobi;
			 m_Manager=Manager;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Stock_ID
		{
			get
			{
				return m_Stock_ID;
			}
			set
			{
				m_Stock_ID = value;
			}
		}
		public string Stock_Name
		{
			get
			{
				return m_Stock_Name;
			}
			set
			{
				m_Stock_Name = value;
			}
		}
		public string Contact
		{
			get
			{
				return m_Contact;
			}
			set
			{
				m_Contact = value;
			}
		}
		public string Address
		{
			get
			{
				return m_Address;
			}
			set
			{
				m_Address = value;
			}
		}
		public string Email
		{
			get
			{
				return m_Email;
			}
			set
			{
				m_Email = value;
			}
		}
		public string Telephone
		{
			get
			{
				return m_Telephone;
			}
			set
			{
				m_Telephone = value;
			}
		}
		public string Fax
		{
			get
			{
				return m_Fax;
			}
			set
			{
				m_Fax = value;
			}
		}
		public string Mobi
		{
			get
			{
				return m_Mobi;
			}
			set
			{
				m_Mobi = value;
			}
		}
		public string Manager
		{
			get
			{
				return m_Manager;
			}
			set
			{
				m_Manager = value;
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
				return "Class STOCK";
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
            return SqlHelper.GenCode("STOCK", "Stock_ID", "K");
		}

        public string NewID(SqlTransaction myTransaction)
        {
            
            return SqlHelper.GenCode(myTransaction,"STOCK", "Stock_ID", "K");
        }

		public Boolean Exist(string Stock_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			
			return Result;
		}


        public Boolean Exist(SqlTransaction myTransaction,string Stock_ID)
        {
            Boolean result = false;
            string[] myPara = { "@Stock_ID" };
            object[] myValue = { Stock_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "STOCK_Get", myPara, myValue);
            if (myReader != null)
            {
                result = myReader.HasRows;
                myReader.Close();
               // mySql.Close();
                myReader.Dispose();
            }
            return result;
        }


        public Boolean ExistByName(string Stock_Name)
        {
            Boolean result = false;
            string[] myPara = { "@Stock_Name" };
            object[] myValue = { Stock_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("STOCK_GetByName", myPara, myValue);
            if (myReader != null)
            {
                result = myReader.HasRows;
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return result;
        }

        public Boolean ExistByName(SqlTransaction myTransaction, string Stock_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Stock_Name" };
            object[] myValue = { Stock_Name };
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "STOCK_GetByName", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            return Result;
        }

		public string Get(string Stock_ID)
		{
			string result="";
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("STOCK_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Stock_Name =Convert.ToString(myReader["Stock_Name"]);
						m_Contact =Convert.ToString(myReader["Contact"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Telephone =Convert.ToString(myReader["Telephone"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Mobi =Convert.ToString(myReader["Mobi"]);
						m_Manager =Convert.ToString(myReader["Manager"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return result;
		}
		public string Get(SqlConnection myConnection,string Stock_ID)
		{
			string Result="";
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Stock_Name =Convert.ToString(myReader["Stock_Name"]);
						m_Contact =Convert.ToString(myReader["Contact"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Telephone =Convert.ToString(myReader["Telephone"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Mobi =Convert.ToString(myReader["Mobi"]);
						m_Manager =Convert.ToString(myReader["Manager"]);
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
		public string Get(SqlTransaction myTransaction,string Stock_ID)
		{
			string Result="";
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Stock_Name =Convert.ToString(myReader["Stock_Name"]);
						m_Contact =Convert.ToString(myReader["Contact"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Telephone =Convert.ToString(myReader["Telephone"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Mobi =Convert.ToString(myReader["Mobi"]);
						m_Manager =Convert.ToString(myReader["Manager"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
			}
			return Result;
		}

        public string GetByName(SqlTransaction myTransaction, string Stock_Name)
        {
            string Result = "";
            string[] myPara = { "@Stock_Name" };
            object[] myValue = { Stock_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "STOCK_GetByName", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
                    m_Stock_Name = Convert.ToString(myReader["Stock_Name"]);
                    m_Contact = Convert.ToString(myReader["Contact"]);
                    m_Address = Convert.ToString(myReader["Address"]);
                    m_Email = Convert.ToString(myReader["Email"]);
                    m_Telephone = Convert.ToString(myReader["Telephone"]);
                    m_Fax = Convert.ToString(myReader["Fax"]);
                    m_Mobi = Convert.ToString(myReader["Mobi"]);
                    m_Manager = Convert.ToString(myReader["Manager"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
            }
            return Result;
        }

        public string GetByName( string Stock_Name)
        {
            string Result = "";
            string[] myPara = { "@Stock_Name" };
            object[] myValue = { Stock_Name };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("STOCK_GetByName", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
                    m_Stock_Name = Convert.ToString(myReader["Stock_Name"]);
                    m_Contact = Convert.ToString(myReader["Contact"]);
                    m_Address = Convert.ToString(myReader["Address"]);
                    m_Email = Convert.ToString(myReader["Email"]);
                    m_Telephone = Convert.ToString(myReader["Telephone"]);
                    m_Fax = Convert.ToString(myReader["Fax"]);
                    m_Mobi = Convert.ToString(myReader["Mobi"]);
                    m_Manager = Convert.ToString(myReader["Manager"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
               
            } 
            mySql.Close();

            return Result;
        }
		#endregion
		
		#region Add
		public string Insert()
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={m_Stock_ID,m_Stock_Name,m_Contact,m_Address,m_Email,m_Telephone,m_Fax,m_Mobi,m_Manager,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("STOCK_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={m_Stock_ID,m_Stock_Name,m_Contact,m_Address,m_Email,m_Telephone,m_Fax,m_Mobi,m_Manager,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_Insert",myPara,myValue);
		}
		public string Insert(string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("STOCK_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"STOCK_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
		    m_Stock_ID = Stock_ID;
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={m_Stock_ID,m_Stock_Name,m_Contact,m_Address,m_Email,m_Telephone,m_Fax,m_Mobi,m_Manager,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("STOCK_Update",myPara,myValue);
		}
        public string Update(SqlTransaction myTransaction)
        {
            string[] myPara = { "@Stock_ID", "@Stock_Name", "@Contact", "@Address", "@Email", "@Telephone", "@Fax", "@Mobi", "@Manager", "@Description", "@Active" };
            object[] myValue = { m_Stock_ID, m_Stock_Name, m_Contact, m_Address, m_Email, m_Telephone, m_Fax, m_Mobi, m_Manager, m_Description, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction,"STOCK_Update", myPara, myValue);
        }
		public string Update(string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("STOCK_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"STOCK_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Stock_ID,string Stock_Name,string Contact,string Address,string Email,string Telephone,string Fax,string Mobi,string Manager,string Description,bool Active)
		{
			string[] myPara={"@Stock_ID","@Stock_Name","@Contact","@Address","@Email","@Telephone","@Fax","@Mobi","@Manager","@Description","@Active"};
			object[] myValue={Stock_ID,Stock_Name,Contact,Address,Email,Telephone,Fax,Mobi,Manager,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Stock_ID"};
			object[] myValue={m_Stock_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("STOCK_Delete",myPara,myValue);
		}
		public string Delete(string Stock_ID)
		{
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("STOCK_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Stock_ID)
		{
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"STOCK_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Stock_ID)
		{
			string[] myPara={"@Stock_ID"};
			object[] myValue={Stock_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_Delete",myPara,myValue);
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
			MyLib.TableToComboBox(combo,GetList(), "STOCK_Name", "STOCK_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["STOCK_ID"] = "All";
			b["STOCK_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "STOCK_Name", "STOCK_ID");
		}
		#endregion


        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT
	s.Stock_ID,
	s.Stock_Name,
	s.Contact,
	s.[Address],
	s.Email,
	s.Telephone,
	s.Fax,
	s.Mobi,
	s.Manager,
	s.[Description],
	s.[Active],
	CAST(s.[Active] AS INT) [ActiveInt]
FROM
	STOCK s";
            }
        }
        #endregion

    }
}
