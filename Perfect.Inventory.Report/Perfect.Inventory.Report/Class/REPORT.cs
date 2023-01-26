using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraReports.Parameters;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : REPORT.
	/// Date: 5/7/2009
	/// Author: 
	/// </summary>
	public class REPORT
	{
		#region Init
		private string m_Report_ID;
		private string m_Report_Name;
		private string m_Title;
		private string m_Comment;
		private string m_FileName;
		private string m_Description;
		private string m_DataSet;
		private string m_Class;
		private string m_Parent_ID;
		private bool m_Avtive;
		public REPORT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Report_ID="";
			 m_Report_Name="";
			 m_Title="";
			 m_Comment="";
			 m_FileName="";
			 m_Description="";
			 m_DataSet="";
			 m_Class="";
			 m_Parent_ID="";
			 m_Avtive=true;
		}
		public REPORT(string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Report_ID=Report_ID;
			 m_Report_Name=Report_Name;
			 m_Title=Title;
			 m_Comment=Comment;
			 m_FileName=FileName;
			 m_Description=Description;
			 m_DataSet=DataSet;
			 m_Class=Class;
			 m_Parent_ID=Parent_ID;
			 m_Avtive=Avtive;
		}
		#endregion
		
		#region Property
		public string Report_ID
		{
			get
			{
				return m_Report_ID;
			}
			set
			{
				m_Report_ID = value;
			}
		}
		public string Report_Name
		{
			get
			{
				return m_Report_Name;
			}
			set
			{
				m_Report_Name = value;
			}
		}
		public string Title
		{
			get
			{
				return m_Title;
			}
			set
			{
				m_Title = value;
			}
		}
		public string Comment
		{
			get
			{
				return m_Comment;
			}
			set
			{
				m_Comment = value;
			}
		}
		public string FileName
		{
			get
			{
				return m_FileName;
			}
			set
			{
				m_FileName = value;
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
		public string DataSet
		{
			get
			{
				return m_DataSet;
			}
			set
			{
				m_DataSet = value;
			}
		}
		public string Class
		{
			get
			{
				return m_Class;
			}
			set
			{
				m_Class = value;
			}
		}
		public string Parent_ID
		{
			get
			{
				return m_Parent_ID;
			}
			set
			{
				m_Parent_ID = value;
			}
		}
		public bool Avtive
		{
			get
			{
				return m_Avtive;
			}
			set
			{
				m_Avtive = value;
			}
		}
		public string ProductName
		{
			get
			{
				return "Class REPORT";
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
			return SqlHelper.GenCode("REPORT","REPORT_ID","");
		}

		public Boolean Exist(string Report_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Report_ID"};
			object[] myValue={Report_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("REPORT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Report_ID,string Language_Id)
		{
			string Result="";
            string[] myPara ={ "@Report_ID", "@Language_Id" };
			object[] myValue={Report_ID,Language_Id};
			SqlHelper mySql=new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("REPORT_Get_By_Language", myPara, myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Report_ID =Convert.ToString(myReader["Report_ID"]);						
						m_Title =Convert.ToString(myReader["Title"]);					
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlConnection myConnection,string Report_ID)
		{
			string Result="";
			string[] myPara={"@Report_ID"};
			object[] myValue={Report_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"REPORT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Report_ID =Convert.ToString(myReader["Report_ID"]);
						m_Report_Name =Convert.ToString(myReader["Report_Name"]);
						m_Title =Convert.ToString(myReader["Title"]);
						m_Comment =Convert.ToString(myReader["Comment"]);
						m_FileName =Convert.ToString(myReader["FileName"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_DataSet =Convert.ToString(myReader["DataSet"]);
						m_Class =Convert.ToString(myReader["Class"]);
						m_Parent_ID =Convert.ToString(myReader["Parent_ID"]);
						m_Avtive =Convert.ToBoolean(myReader["Avtive"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,string Report_ID)
		{
			string Result="";
			string[] myPara={"@Report_ID"};
			object[] myValue={Report_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"REPORT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Report_ID =Convert.ToString(myReader["Report_ID"]);
						m_Report_Name =Convert.ToString(myReader["Report_Name"]);
						m_Title =Convert.ToString(myReader["Title"]);
						m_Comment =Convert.ToString(myReader["Comment"]);
						m_FileName =Convert.ToString(myReader["FileName"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_DataSet =Convert.ToString(myReader["DataSet"]);
						m_Class =Convert.ToString(myReader["Class"]);
						m_Parent_ID =Convert.ToString(myReader["Parent_ID"]);
						m_Avtive =Convert.ToBoolean(myReader["Avtive"]);
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
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={m_Report_ID,m_Report_Name,m_Title,m_Comment,m_FileName,m_Description,m_DataSet,m_Class,m_Parent_ID,m_Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("REPORT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={m_Report_ID,m_Report_Name,m_Title,m_Comment,m_FileName,m_Description,m_DataSet,m_Class,m_Parent_ID,m_Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"REPORT_Insert",myPara,myValue);
		}
		public string Insert(string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={Report_ID,Report_Name,Title,Comment,FileName,Description,DataSet,Class,Parent_ID,Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("REPORT_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={Report_ID,Report_Name,Title,Comment,FileName,Description,DataSet,Class,Parent_ID,Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"REPORT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={Report_ID,Report_Name,Title,Comment,FileName,Description,DataSet,Class,Parent_ID,Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"REPORT_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={m_Report_ID,m_Report_Name,m_Title,m_Comment,m_FileName,m_Description,m_DataSet,m_Class,m_Parent_ID,m_Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("REPORT_Update",myPara,myValue);
		}
		public string Update(string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={Report_ID,Report_Name,Title,Comment,FileName,Description,DataSet,Class,Parent_ID,Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("REPORT_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={Report_ID,Report_Name,Title,Comment,FileName,Description,DataSet,Class,Parent_ID,Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"REPORT_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Report_ID,string Report_Name,string Title,string Comment,string FileName,string Description,string DataSet,string Class,string Parent_ID,bool Avtive)
		{
			string[] myPara={"@Report_ID","@Report_Name","@Title","@Comment","@FileName","@Description","@DataSet","@Class","@Parent_ID","@Avtive"};
			object[] myValue={Report_ID,Report_Name,Title,Comment,FileName,Description,DataSet,Class,Parent_ID,Avtive};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"REPORT_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Report_ID"};
			object[] myValue={m_Report_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("REPORT_Delete",myPara,myValue);
		}
		public string Delete(string Report_ID)
		{
			string[] myPara={"@Report_ID"};
			object[] myValue={Report_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("REPORT_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Report_ID)
		{
			string[] myPara={"@Report_ID"};
			object[] myValue={Report_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"REPORT_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Report_ID)
		{
			string[] myPara={"@Report_ID"};
			object[] myValue={Report_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"REPORT_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("REPORT_GetList");
		}
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "REPORTName", "REPORTID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["REPORTID"] = "All";
			b["REPORTName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "REPORTName", "REPORTID");
		}
		#endregion
		
	}
}
