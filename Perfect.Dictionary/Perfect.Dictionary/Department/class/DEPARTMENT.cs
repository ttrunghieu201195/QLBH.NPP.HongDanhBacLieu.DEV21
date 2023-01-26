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
	/// Generated Class for Table : DEPARTMENT.
	/// Date: 20/01/2009
	/// Author: 
	/// </summary>
	public class DEPARTMENT
	{
		#region Init
		private string m_Department_ID;
		private string m_Department_Name;
		private string m_Description;
		private bool m_Active;
		public DEPARTMENT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Department_ID="";
			 m_Department_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public DEPARTMENT(string Department_ID,string Department_Name,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Department_ID=Department_ID;
			 m_Department_Name=Department_Name;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Department_ID
		{
			get
			{
				return m_Department_ID;
			}
			set
			{
				m_Department_ID = value;
			}
		}
		public string Department_Name
		{
			get
			{
				return m_Department_Name;
			}
			set
			{
				m_Department_Name = value;
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
				return "Class DEPARTMENT";
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
            return SqlHelper.GenCode("DEPARTMENT", "Department_ID", "BP");
		}
		public Boolean Exist(string Department_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("DEPARTMENT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Department_ID)
		{
			string Result="";
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("DEPARTMENT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Department_Name =Convert.ToString(myReader["Department_Name"]);
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
		public string Get(SqlConnection myConnection,string Department_ID)
		{
			string Result="";
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"DEPARTMENT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Department_Name =Convert.ToString(myReader["Department_Name"]);
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
		public string Get(SqlTransaction myTransaction,string Department_ID)
		{
			string Result="";
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"DEPARTMENT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Department_Name =Convert.ToString(myReader["Department_Name"]);
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
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={m_Department_ID,m_Department_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DEPARTMENT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={m_Department_ID,m_Department_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DEPARTMENT_Insert",myPara,myValue);
		}
		public string Insert(string Department_ID,string Department_Name,string Description,bool Active)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={Department_ID,Department_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DEPARTMENT_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Department_ID,string Department_Name,string Description,bool Active)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={Department_ID,Department_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"DEPARTMENT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Department_ID,string Department_Name,string Description,bool Active)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={Department_ID,Department_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DEPARTMENT_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={m_Department_ID,m_Department_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DEPARTMENT_Update",myPara,myValue);
		}
		public string Update(string Department_ID,string Department_Name,string Description,bool Active)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={Department_ID,Department_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DEPARTMENT_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Department_ID,string Department_Name,string Description,bool Active)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={Department_ID,Department_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"DEPARTMENT_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Department_ID,string Department_Name,string Description,bool Active)
		{
			string[] myPara={"@Department_ID","@Department_Name","@Description","@Active"};
			object[] myValue={Department_ID,Department_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DEPARTMENT_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Department_ID"};
			object[] myValue={m_Department_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DEPARTMENT_Delete",myPara,myValue);
		}
		public string Delete(string Department_ID)
		{
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DEPARTMENT_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Department_ID)
		{
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"DEPARTMENT_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Department_ID)
		{
			string[] myPara={"@Department_ID"};
			object[] myValue={Department_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DEPARTMENT_Delete",myPara,myValue);
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
            MyLib.TableToComboBox(combo, GetList(), "Department_Name", "Department_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
            b["Department_ID"] = "All";
            b["Department_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "Department_Name", "Department_ID");
		}
		#endregion

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT
	d.Department_ID,
	d.Department_Name,
	d.[Description],
	d.[Active],
	CAST(d.[Active] AS INT) AS [ActiveInt]
FROM
	DEPARTMENT d";
            }
        }
        #endregion

    }
}
