using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : DISTRICT.
	/// Date: 1/14/2009
	/// Author: 
	/// </summary>
	public class DISTRICT
	{
		#region Init
		private string m_District_ID;
		private string m_DistrictName;
		private string m_Province_ID;
		private string m_Description;
		private bool m_Active;
		public DISTRICT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_District_ID="";
			 m_DistrictName="";
			 m_Province_ID="";
			 m_Description="";
			 m_Active=true;
		}
		public DISTRICT(string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_District_ID=District_ID;
			 m_DistrictName=DistrictName;
			 m_Province_ID=Province_ID;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string District_ID
		{
			get
			{
				return m_District_ID;
			}
			set
			{
				m_District_ID = value;
			}
		}
		public string DistrictName
		{
			get
			{
				return m_DistrictName;
			}
			set
			{
				m_DistrictName = value;
			}
		}
		public string Province_ID
		{
			get
			{
				return m_Province_ID;
			}
			set
			{
				m_Province_ID = value;
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
				return "Class DISTRICT";
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
			return SqlHelper.GenCode("DISTRICT","DISTRICTID","");
		}
		public Boolean Exist(string District_ID)
		{
			Boolean Result=false;
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("DISTRICT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string District_ID)
		{
			string Result="";
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("DISTRICT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_District_ID =Convert.ToString(myReader["District_ID"]);
						m_DistrictName =Convert.ToString(myReader["DistrictName"]);
						m_Province_ID =Convert.ToString(myReader["Province_ID"]);
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
		public string Get(SqlConnection myConnection,string District_ID)
		{
			string Result="";
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"DISTRICT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_District_ID =Convert.ToString(myReader["District_ID"]);
						m_DistrictName =Convert.ToString(myReader["DistrictName"]);
						m_Province_ID =Convert.ToString(myReader["Province_ID"]);
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
		public string Get(SqlTransaction myTransaction,string District_ID)
		{
			string Result="";
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"DISTRICT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_District_ID =Convert.ToString(myReader["District_ID"]);
						m_DistrictName =Convert.ToString(myReader["DistrictName"]);
						m_Province_ID =Convert.ToString(myReader["Province_ID"]);
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
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={m_District_ID,m_DistrictName,m_Province_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DISTRICT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={m_District_ID,m_DistrictName,m_Province_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DISTRICT_Insert",myPara,myValue);
		}
		public string Insert(string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={District_ID,DistrictName,Province_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DISTRICT_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={District_ID,DistrictName,Province_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"DISTRICT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={District_ID,DistrictName,Province_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DISTRICT_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={m_District_ID,m_DistrictName,m_Province_ID,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DISTRICT_Update",myPara,myValue);
		}
		public string Update(string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={District_ID,DistrictName,Province_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DISTRICT_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={District_ID,DistrictName,Province_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"DISTRICT_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string District_ID,string DistrictName,string Province_ID,string Description,bool Active)
		{
			string[] myPara={"@District_ID","@DistrictName","@Province_ID","@Description","@Active"};
			object[] myValue={District_ID,DistrictName,Province_ID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DISTRICT_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@District_ID"};
			object[] myValue={m_District_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DISTRICT_Delete",myPara,myValue);
		}
		public string Delete(string District_ID)
		{
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("DISTRICT_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string District_ID)
		{
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"DISTRICT_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string District_ID)
		{
			string[] myPara={"@District_ID"};
			object[] myValue={District_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"DISTRICT_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("DISTRICT_GetList");
		}
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "DISTRICT_Name", "DISTRICT_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["DISTRICT_ID"] = "All";
			b["DISTRICT_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "DISTRICT_Name", "DISTRICT_ID");
		}
		#endregion
		
	}
}
