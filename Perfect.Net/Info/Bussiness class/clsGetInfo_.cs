using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : clsGetInfo.
	/// Date: 5/8/2009
	/// Author: 
	/// </summary>
	public class clsGetInfo
	{
		#region Init
		private string m_Company_Id;
		private string m_Company;
		private string m_Address;
		private string m_Tel;
		private string m_Fax;
		private string m_WebSite;
		private string m_Email;
		private string m_Tax;
		private string m_Licence;
		public clsGetInfo()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Company_Id="";
			 m_Company="";
			 m_Address="";
			 m_Tel="";
			 m_Fax="";
			 m_WebSite="";
			 m_Email="";
			 m_Tax="";
			 m_Licence="";
		}
		public clsGetInfo(string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Company_Id=Company_Id;
			 m_Company=Company;
			 m_Address=Address;
			 m_Tel=Tel;
			 m_Fax=Fax;
			 m_WebSite=WebSite;
			 m_Email=Email;
			 m_Tax=Tax;
			 m_Licence=Licence;
		}
		#endregion
		
		#region Property
		public string Company_Id
		{
			get
			{
				return m_Company_Id;
			}
			set
			{
				m_Company_Id = value;
			}
		}
		public string Company
		{
			get
			{
				return m_Company;
			}
			set
			{
				m_Company = value;
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
		public string Tel
		{
			get
			{
				return m_Tel;
			}
			set
			{
				m_Tel = value;
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
		public string WebSite
		{
			get
			{
				return m_WebSite;
			}
			set
			{
				m_WebSite = value;
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
		public string Tax
		{
			get
			{
				return m_Tax;
			}
			set
			{
				m_Tax = value;
			}
		}
		public string Licence
		{
			get
			{
				return m_Licence;
			}
			set
			{
				m_Licence = value;
			}
		}
		public string ProductName
		{
			get
			{
				return "Class clsGetInfo";
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
			return SqlHelper.GenCode("clsGetInfo","SYS_COMPANYID","");
		}
		public Boolean Exist(string Company_Id)
		{
			Boolean Result=false;
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_COMPANY_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Company_Id)
		{
			string Result="";
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_COMPANY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Company_Id =Convert.ToString(myReader["Company_Id"]);
						m_Company =Convert.ToString(myReader["Company"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Tel =Convert.ToString(myReader["Tel"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_WebSite =Convert.ToString(myReader["WebSite"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Tax =Convert.ToString(myReader["Tax"]);
						m_Licence =Convert.ToString(myReader["Licence"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlConnection myConnection,string Company_Id)
		{
			string Result="";
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SYS_COMPANY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Company_Id =Convert.ToString(myReader["Company_Id"]);
						m_Company =Convert.ToString(myReader["Company"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Tel =Convert.ToString(myReader["Tel"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_WebSite =Convert.ToString(myReader["WebSite"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Tax =Convert.ToString(myReader["Tax"]);
						m_Licence =Convert.ToString(myReader["Licence"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,string Company_Id)
		{
			string Result="";
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SYS_COMPANY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Company_Id =Convert.ToString(myReader["Company_Id"]);
						m_Company =Convert.ToString(myReader["Company"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Tel =Convert.ToString(myReader["Tel"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_WebSite =Convert.ToString(myReader["WebSite"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Tax =Convert.ToString(myReader["Tax"]);
						m_Licence =Convert.ToString(myReader["Licence"]);
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
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={m_Company_Id,m_Company,m_Address,m_Tel,m_Fax,m_WebSite,m_Email,m_Tax,m_Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_COMPANY_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={m_Company_Id,m_Company,m_Address,m_Tel,m_Fax,m_WebSite,m_Email,m_Tax,m_Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_COMPANY_Insert",myPara,myValue);
		}
		public string Insert(string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={Company_Id,Company,Address,Tel,Fax,WebSite,Email,Tax,Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_COMPANY_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={Company_Id,Company,Address,Tel,Fax,WebSite,Email,Tax,Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_COMPANY_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={Company_Id,Company,Address,Tel,Fax,WebSite,Email,Tax,Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_COMPANY_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={m_Company_Id,m_Company,m_Address,m_Tel,m_Fax,m_WebSite,m_Email,m_Tax,m_Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_COMPANY_Update",myPara,myValue);
		}
		public string Update(string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={Company_Id,Company,Address,Tel,Fax,WebSite,Email,Tax,Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_COMPANY_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={Company_Id,Company,Address,Tel,Fax,WebSite,Email,Tax,Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_COMPANY_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Company_Id,string Company,string Address,string Tel,string Fax,string WebSite,string Email,string Tax,string Licence)
		{
			string[] myPara={"@Company_Id","@Company","@Address","@Tel","@Fax","@WebSite","@Email","@Tax","@Licence"};
			object[] myValue={Company_Id,Company,Address,Tel,Fax,WebSite,Email,Tax,Licence};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_COMPANY_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Company_Id"};
			object[] myValue={m_Company_Id};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_COMPANY_Delete",myPara,myValue);
		}
		public string Delete(string Company_Id)
		{
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_COMPANY_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Company_Id)
		{
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_COMPANY_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Company_Id)
		{
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_COMPANY_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("SYS_COMPANY_GetList");
		}
		#endregion
		
		#region Insert Combo
		
		
		#endregion
		
	}
}
