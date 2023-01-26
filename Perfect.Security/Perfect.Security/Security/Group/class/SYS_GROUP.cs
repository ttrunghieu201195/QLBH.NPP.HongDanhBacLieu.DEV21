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
	/// Generated Class for Table : SYS_GROUP.
	/// Date: 1/19/2009
	/// Author: 
	/// </summary>
	public class SYS_GROUP
	{
		#region Init
		private string m_Group_ID;
		private string m_Group_Name;
		private string m_Group_NameEn;
		private string m_Description;
		private bool m_Active;
		public SYS_GROUP()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Group_ID="";
			 m_Group_Name="";
			 m_Group_NameEn="";
			 m_Description="";
			 m_Active=true;
		}
		public SYS_GROUP(string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Group_ID=Group_ID;
			 m_Group_Name=Group_Name;
			 m_Group_NameEn=Group_NameEn;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Group_ID
		{
			get
			{
				return m_Group_ID;
			}
			set
			{
				m_Group_ID = value;
			}
		}
		public string Group_Name
		{
			get
			{
				return m_Group_Name;
			}
			set
			{
				m_Group_Name = value;
			}
		}
		public string Group_NameEn
		{
			get
			{
				return m_Group_NameEn;
			}
			set
			{
				m_Group_NameEn = value;
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
				return "Class SYS_GROUP";
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
            return SqlHelper.GenCode("SYS_GROUP", "Group_ID", "VT");
		}
		public Boolean Exist(string Group_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Group_ID)
		{
			string Result="";
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Group_ID =Convert.ToString(myReader["Group_ID"]);
						m_Group_Name =Convert.ToString(myReader["Group_Name"]);
						m_Group_NameEn =Convert.ToString(myReader["Group_NameEn"]);
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
		public string Get(SqlConnection myConnection,string Group_ID)
		{
			string Result="";
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SYS_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Group_ID =Convert.ToString(myReader["Group_ID"]);
						m_Group_Name =Convert.ToString(myReader["Group_Name"]);
						m_Group_NameEn =Convert.ToString(myReader["Group_NameEn"]);
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
		public string Get(SqlTransaction myTransaction,string Group_ID)
		{
			string Result="";
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SYS_GROUP_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Group_ID =Convert.ToString(myReader["Group_ID"]);
						m_Group_Name =Convert.ToString(myReader["Group_Name"]);
						m_Group_NameEn =Convert.ToString(myReader["Group_NameEn"]);
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
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={m_Group_ID,m_Group_Name,m_Group_NameEn,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={m_Group_ID,m_Group_Name,m_Group_NameEn,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_GROUP_Insert",myPara,myValue);
		}
		public string Insert(string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={Group_ID,Group_Name,Group_NameEn,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={Group_ID,Group_Name,Group_NameEn,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_GROUP_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={Group_ID,Group_Name,Group_NameEn,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_GROUP_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={m_Group_ID,m_Group_Name,m_Group_NameEn,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_GROUP_Update",myPara,myValue);
		}
		public string Update(string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={Group_ID,Group_Name,Group_NameEn,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_GROUP_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={Group_ID,Group_Name,Group_NameEn,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_GROUP_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Group_ID,string Group_Name,string Group_NameEn,string Description,bool Active)
		{
			string[] myPara={"@Group_ID","@Group_Name","@Group_NameEn","@Description","@Active"};
			object[] myValue={Group_ID,Group_Name,Group_NameEn,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_GROUP_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Group_ID"};
			object[] myValue={m_Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_GROUP_Delete",myPara,myValue);
		}
		public string Delete(string Group_ID)
		{
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_GROUP_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Group_ID)
		{
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_GROUP_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Group_ID)
		{
			string[] myPara={"@Group_ID"};
			object[] myValue={Group_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_GROUP_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("SYS_GROUP_GetList");
		}
        public DataTable Get_List(string Group_ID)
        {
            string[] mypara = { "@Group_ID" };
            object[] myvalue = { Group_ID  };
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("SYS_GROUP_Get", mypara, myvalue);
        }
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "SYS_GROUPName", "SYS_GROUPID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["SYS_GROUPID"] = "All";
			b["SYS_GROUPName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "SYS_GROUPName", "SYS_GROUPID");
		}
		#endregion
		
	}
}
