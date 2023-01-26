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
	/// Generated Class for Table : HRM_POSITION.
	/// Date: 1/5/2009
	/// Author: 
	/// </summary>
	public class HRM_POSITION
	{
		#region Init
		private string m_Position_ID;
		private string m_Position_Name;
		private string m_Description;
		private bool m_Active;
		public HRM_POSITION()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Position_ID="";
			 m_Position_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public HRM_POSITION(string Position_ID,string Position_Name,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Position_ID=Position_ID;
			 m_Position_Name=Position_Name;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Position_ID
		{
			get
			{
				return m_Position_ID;
			}
			set
			{
				m_Position_ID = value;
			}
		}
		public string Position_Name
		{
			get
			{
				return m_Position_Name;
			}
			set
			{
				m_Position_Name = value;
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
				return "Class HRM_POSITION";
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
			return SqlHelper.GenCode("HRM_POSITION","HRM_POSITIONID","");
		}
		public Boolean Exist(string Position_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("HRM_POSITION_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Position_ID)
		{
			string Result="";
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("HRM_POSITION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Position_ID =Convert.ToString(myReader["Position_ID"]);
						m_Position_Name =Convert.ToString(myReader["Position_Name"]);
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
		public string Get(SqlConnection myConnection,string Position_ID)
		{
			string Result="";
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"HRM_POSITION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Position_ID =Convert.ToString(myReader["Position_ID"]);
						m_Position_Name =Convert.ToString(myReader["Position_Name"]);
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
		public string Get(SqlTransaction myTransaction,string Position_ID)
		{
			string Result="";
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"HRM_POSITION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Position_ID =Convert.ToString(myReader["Position_ID"]);
						m_Position_Name =Convert.ToString(myReader["Position_Name"]);
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
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={m_Position_ID,m_Position_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("HRM_POSITION_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={m_Position_ID,m_Position_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"HRM_POSITION_Insert",myPara,myValue);
		}
		public string Insert(string Position_ID,string Position_Name,string Description,bool Active)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={Position_ID,Position_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("HRM_POSITION_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Position_ID,string Position_Name,string Description,bool Active)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={Position_ID,Position_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"HRM_POSITION_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Position_ID,string Position_Name,string Description,bool Active)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={Position_ID,Position_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"HRM_POSITION_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={m_Position_ID,m_Position_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("HRM_POSITION_Update",myPara,myValue);
		}
		public string Update(string Position_ID,string Position_Name,string Description,bool Active)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={Position_ID,Position_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("HRM_POSITION_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Position_ID,string Position_Name,string Description,bool Active)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={Position_ID,Position_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"HRM_POSITION_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Position_ID,string Position_Name,string Description,bool Active)
		{
			string[] myPara={"@Position_ID","@Position_Name","@Description","@Active"};
			object[] myValue={Position_ID,Position_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"HRM_POSITION_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Position_ID"};
			object[] myValue={m_Position_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("HRM_POSITION_Delete",myPara,myValue);
		}
		public string Delete(string Position_ID)
		{
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("HRM_POSITION_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Position_ID)
		{
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"HRM_POSITION_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Position_ID)
		{
			string[] myPara={"@Position_ID"};
			object[] myValue={Position_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"HRM_POSITION_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("HRM_POSITION_GetList");
		}
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
            MyLib.TableToComboBox(combo, GetList(), "Position_Name", "Position_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
            b["Position_ID"] = "All";
            b["Position_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "Position_Name", "Position_ID");
		}
		#endregion
		
	}
}
