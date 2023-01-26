using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Perfect.Common;

namespace Perfect.ERP
{ 
	public class EMPLOYEE:Object
	{
		#region Init
		private string m_Employee_ID;
		private string m_FirtName;
		private string m_LastName;
		private string m_Employee_Name;
		private string m_Alias;
		private bool m_Sex;
		private string m_Address;
		private string m_Country_ID;
		private string m_H_Tel;
		private string m_O_Tel;
		private string m_Mobile;
		private string m_Fax;
		private string m_Email;
		private DateTime m_Birthday;
		private int m_Married;
		private string m_Position_ID;
		private string m_JobTitle_ID;
		private string m_Branch_ID;
		private string m_Department_ID;
		private string m_Team_ID;
		private string m_PersonalTax_ID;
		private string m_City_ID;
		private string m_District_ID;
		private string m_Manager_ID;
		private int m_EmployeeType;
		private decimal m_BasicSalary;
		private decimal m_Advance;
		private decimal m_AdvanceOther;
		private decimal m_Commission;
		private decimal m_Discount;
		private decimal m_ProfitRate;
		private bool m_IsPublic;
		private string m_CreatedBy;
		private DateTime m_CreatedDate;
		private string m_ModifiedBy;
		private DateTime m_ModifiedDate;
		private string m_OwnerID;
		private string m_Description;
		private long m_Sorted;
		private bool m_Active;
		
		
		public EMPLOYEE()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Employee_ID="";
			 m_FirtName="";
			 m_LastName="";
			 m_Employee_Name="";
			 m_Alias="";
			 m_Sex=true;
			 m_Address="";
			 m_Country_ID="";
			 m_H_Tel="";
			 m_O_Tel="";
			 m_Mobile="";
			 m_Fax="";
			 m_Email="";
			 m_Birthday=DateTime.Now;
			 m_Married=0;
			 m_Position_ID="";
			 m_JobTitle_ID="";
			 m_Branch_ID="";
			 m_Department_ID="";
			 m_Team_ID="";
			 m_PersonalTax_ID="";
			 m_City_ID="";
			 m_District_ID="";
			 m_Manager_ID="";
			 m_EmployeeType=0;
			 m_BasicSalary=0;
			 m_Advance=0;
			 m_AdvanceOther=0;
			 m_Commission=0;
			 m_Discount=0;
			 m_ProfitRate=0;
			 m_IsPublic=true;
			 m_CreatedBy="";
			 m_CreatedDate=DateTime.Now;
			 m_ModifiedBy="";
			 m_ModifiedDate=DateTime.Now;
			 m_OwnerID="";
			 m_Description="";
			 m_Sorted=0;
			 m_Active=true;
		}
		public EMPLOYEE(
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Employee_ID=Employee_ID;
			 m_FirtName=FirtName;
			 m_LastName=LastName;
			 m_Employee_Name=Employee_Name;
			 m_Alias=Alias;
			 m_Sex=Sex;
			 m_Address=Address;
			 m_Country_ID=Country_ID;
			 m_H_Tel=H_Tel;
			 m_O_Tel=O_Tel;
			 m_Mobile=Mobile;
			 m_Fax=Fax;
			 m_Email=Email;
			 m_Birthday=Birthday;
			 m_Married=Married;
			 m_Position_ID=Position_ID;
			 m_JobTitle_ID=JobTitle_ID;
			 m_Branch_ID=Branch_ID;
			 m_Department_ID=Department_ID;
			 m_Team_ID=Team_ID;
			 m_PersonalTax_ID=PersonalTax_ID;
			 m_City_ID=City_ID;
			 m_District_ID=District_ID;
			 m_Manager_ID=Manager_ID;
			 m_EmployeeType=EmployeeType;
			 m_BasicSalary=BasicSalary;
			 m_Advance=Advance;
			 m_AdvanceOther=AdvanceOther;
			 m_Commission=Commission;
			 m_Discount=Discount;
			 m_ProfitRate=ProfitRate;
			 m_IsPublic=IsPublic;
			 m_CreatedBy=CreatedBy;
			 m_CreatedDate=CreatedDate;
			 m_ModifiedBy=ModifiedBy;
			 m_ModifiedDate=ModifiedDate;
			 m_OwnerID=OwnerID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Employee_ID=Employee_ID;
			 m_FirtName=FirtName;
			 m_LastName=LastName;
			 m_Employee_Name=Employee_Name;
			 m_Alias=Alias;
			 m_Sex=Sex;
			 m_Address=Address;
			 m_Country_ID=Country_ID;
			 m_H_Tel=H_Tel;
			 m_O_Tel=O_Tel;
			 m_Mobile=Mobile;
			 m_Fax=Fax;
			 m_Email=Email;
			 m_Birthday=Birthday;
			 m_Married=Married;
			 m_Position_ID=Position_ID;
			 m_JobTitle_ID=JobTitle_ID;
			 m_Branch_ID=Branch_ID;
			 m_Department_ID=Department_ID;
			 m_Team_ID=Team_ID;
			 m_PersonalTax_ID=PersonalTax_ID;
			 m_City_ID=City_ID;
			 m_District_ID=District_ID;
			 m_Manager_ID=Manager_ID;
			 m_EmployeeType=EmployeeType;
			 m_BasicSalary=BasicSalary;
			 m_Advance=Advance;
			 m_AdvanceOther=AdvanceOther;
			 m_Commission=Commission;
			 m_Discount=Discount;
			 m_ProfitRate=ProfitRate;
			 m_IsPublic=IsPublic;
			 m_CreatedBy=CreatedBy;
			 m_CreatedDate=CreatedDate;
			 m_ModifiedBy=ModifiedBy;
			 m_ModifiedDate=ModifiedDate;
			 m_OwnerID=OwnerID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		[DisplayName("Employee_ID")]
		[Category("Primary Key")]
		public string Employee_ID
		{
			get
			{
				return m_Employee_ID;
			}
			set
			{
				m_Employee_ID = value;
			}
		}
		[DisplayName("FirtName")]
		[Category("Column")]
		public string FirtName
		{
			get
			{
				return m_FirtName;
			}
			set
			{
				m_FirtName = value;
			}
		}
		[DisplayName("LastName")]
		[Category("Column")]
		public string LastName
		{
			get
			{
				return m_LastName;
			}
			set
			{
				m_LastName = value;
			}
		}
		[DisplayName("Employee_Name")]
		[Category("Column")]
		public string Employee_Name
		{
			get
			{
				return m_Employee_Name;
			}
			set
			{
				m_Employee_Name = value;
			}
		}
		[DisplayName("Alias")]
		[Category("Column")]
		public string Alias
		{
			get
			{
				return m_Alias;
			}
			set
			{
				m_Alias = value;
			}
		}
		[DisplayName("Sex")]
		[Category("Column")]
		public bool Sex
		{
			get
			{
				return m_Sex;
			}
			set
			{
				m_Sex = value;
			}
		}
		[DisplayName("Address")]
		[Category("Column")]
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
		[DisplayName("Country_ID")]
		[Category("Column")]
		public string Country_ID
		{
			get
			{
				return m_Country_ID;
			}
			set
			{
				m_Country_ID = value;
			}
		}
		[DisplayName("H_Tel")]
		[Category("Column")]
		public string H_Tel
		{
			get
			{
				return m_H_Tel;
			}
			set
			{
				m_H_Tel = value;
			}
		}
		[DisplayName("O_Tel")]
		[Category("Column")]
		public string O_Tel
		{
			get
			{
				return m_O_Tel;
			}
			set
			{
				m_O_Tel = value;
			}
		}
		[DisplayName("Mobile")]
		[Category("Column")]
		public string Mobile
		{
			get
			{
				return m_Mobile;
			}
			set
			{
				m_Mobile = value;
			}
		}
		[DisplayName("Fax")]
		[Category("Column")]
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
		[DisplayName("Email")]
		[Category("Column")]
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
		[DisplayName("Birthday")]
		[Category("Column")]
		public DateTime Birthday
		{
			get
			{
				return m_Birthday;
			}
			set
			{
				m_Birthday = value;
			}
		}
		[DisplayName("Married")]
		[Category("Column")]
		public int Married
		{
			get
			{
				return m_Married;
			}
			set
			{
				m_Married = value;
			}
		}
		[DisplayName("Position_ID")]
		[Category("Column")]
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
		[DisplayName("JobTitle_ID")]
		[Category("Column")]
		public string JobTitle_ID
		{
			get
			{
				return m_JobTitle_ID;
			}
			set
			{
				m_JobTitle_ID = value;
			}
		}
		[DisplayName("Branch_ID")]
		[Category("Column")]
		public string Branch_ID
		{
			get
			{
				return m_Branch_ID;
			}
			set
			{
				m_Branch_ID = value;
			}
		}
		[DisplayName("Department_ID")]
		[Category("Column")]
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
		[DisplayName("Team_ID")]
		[Category("Column")]
		public string Team_ID
		{
			get
			{
				return m_Team_ID;
			}
			set
			{
				m_Team_ID = value;
			}
		}
		[DisplayName("PersonalTax_ID")]
		[Category("Column")]
		public string PersonalTax_ID
		{
			get
			{
				return m_PersonalTax_ID;
			}
			set
			{
				m_PersonalTax_ID = value;
			}
		}
		[DisplayName("City_ID")]
		[Category("Column")]
		public string City_ID
		{
			get
			{
				return m_City_ID;
			}
			set
			{
				m_City_ID = value;
			}
		}
		[DisplayName("District_ID")]
		[Category("Column")]
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
		[DisplayName("Manager_ID")]
		[Category("Column")]
		public string Manager_ID
		{
			get
			{
				return m_Manager_ID;
			}
			set
			{
				m_Manager_ID = value;
			}
		}
		[DisplayName("EmployeeType")]
		[Category("Column")]
		public int EmployeeType
		{
			get
			{
				return m_EmployeeType;
			}
			set
			{
				m_EmployeeType = value;
			}
		}
		[DisplayName("BasicSalary")]
		[Category("Column")]
		public decimal BasicSalary
		{
			get
			{
				return m_BasicSalary;
			}
			set
			{
				m_BasicSalary = value;
			}
		}
		[DisplayName("Advance")]
		[Category("Column")]
		public decimal Advance
		{
			get
			{
				return m_Advance;
			}
			set
			{
				m_Advance = value;
			}
		}
		[DisplayName("AdvanceOther")]
		[Category("Column")]
		public decimal AdvanceOther
		{
			get
			{
				return m_AdvanceOther;
			}
			set
			{
				m_AdvanceOther = value;
			}
		}
		[DisplayName("Commission")]
		[Category("Column")]
		public decimal Commission
		{
			get
			{
				return m_Commission;
			}
			set
			{
				m_Commission = value;
			}
		}
		[DisplayName("Discount")]
		[Category("Column")]
		public decimal Discount
		{
			get
			{
				return m_Discount;
			}
			set
			{
				m_Discount = value;
			}
		}
		[DisplayName("ProfitRate")]
		[Category("Column")]
		public decimal ProfitRate
		{
			get
			{
				return m_ProfitRate;
			}
			set
			{
				m_ProfitRate = value;
			}
		}
		[DisplayName("IsPublic")]
		[Category("Column")]
		public bool IsPublic
		{
			get
			{
				return m_IsPublic;
			}
			set
			{
				m_IsPublic = value;
			}
		}
		[DisplayName("CreatedBy")]
		[Category("Column")]
		public string CreatedBy
		{
			get
			{
				return m_CreatedBy;
			}
			set
			{
				m_CreatedBy = value;
			}
		}
		[DisplayName("CreatedDate")]
		[Category("Column")]
		public DateTime CreatedDate
		{
			get
			{
				return m_CreatedDate;
			}
			set
			{
				m_CreatedDate = value;
			}
		}
		[DisplayName("ModifiedBy")]
		[Category("Column")]
		public string ModifiedBy
		{
			get
			{
				return m_ModifiedBy;
			}
			set
			{
				m_ModifiedBy = value;
			}
		}
		[DisplayName("ModifiedDate")]
		[Category("Column")]
		public DateTime ModifiedDate
		{
			get
			{
				return m_ModifiedDate;
			}
			set
			{
				m_ModifiedDate = value;
			}
		}
		[DisplayName("OwnerID")]
		[Category("Column")]
		public string OwnerID
		{
			get
			{
				return m_OwnerID;
			}
			set
			{
				m_OwnerID = value;
			}
		}
		[DisplayName("Description")]
		[Category("Column")]
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
		[DisplayName("Sorted")]
		[Category("Column")]
		public long Sorted
		{
			get
			{
				return m_Sorted;
			}
			set
			{
				m_Sorted = value;
			}
		}
		[DisplayName("Active")]
		[Category("Column")]
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
		public string Product
		{
			get
			{
				return "Class EMPLOYEE";
			}
		}
		public string AssemblyVersion
		{
			get
			{
				return "2.5.0.0";
			}
		}
		public string Copyright
		{
			get
			{
				return "Công Ty Phần Mềm Hoàn Hảo";
			}
		}
		#endregion
		
		#region NewID

		public string NewID()
		{
			return NewID("NV");
		}

		public string NewID(string key)
		{
            return SqlHelper.GenCode("EMPLOYEE", "Employee_ID", key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
            return SqlHelper.GenCode(myTransaction, "EMPLOYEE", "Employee_ID", key);
		}

		public string CreateKey()
		{
			return CreateKey("");
		}

		public string CreateKey(string key)
		{
			return SqlHelper.GenCode(key);
		}

		public string CreateKey(SqlTransaction myTransaction,string key)
		{
			return SqlHelper.GenCode(myTransaction,key);
		}

		public string CreateKey(SqlTransaction myTransaction)
		{
			return SqlHelper.GenCode(myTransaction,"");
		}

		#endregion 

		#region Exist

		public bool Exist()
		{
			return Exist(
			m_Employee_ID);
		}

		public bool Exist(
			SqlTransaction myTransaction)
		{
			return Exist(
			myTransaction,
			m_Employee_ID);
		}

		public bool Exist(
			string Employee_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Exist(
			mySql.Connection,
			Employee_ID))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string Employee_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Employee_ID"};
			object[] myValue={
			Employee_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"EMPLOYEE_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
			}
			else
			{
				mySql.Close();
				if(MyParamaters.IsShowWarning) 
					XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return Result;
		}

		public bool Exist(
			SqlTransaction myTransaction,
			string Employee_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Employee_ID"};
			object[] myValue={
			Employee_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"EMPLOYEE_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
			}
			else
				{
						mySql.RollBack(myTransaction);
						if(MyParamaters.IsShowWarning) 
						XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			return Result;
		}

		#endregion NewID

		#region Get

		public bool Get()
		{
			return Get(
			m_Employee_ID);
		}

		public bool Get(SqlConnection myConnection)
		{
			return Get(myConnection,
			m_Employee_ID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			m_Employee_ID);
		}

		public bool Get(
			string Employee_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Get(
			mySql.Connection,
			Employee_ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Get(
			SqlConnection myConnection,
			string Employee_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Employee_ID"};
			object[] myValue={
			Employee_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"EMPLOYEE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_FirtName =Convert.ToString(myReader["FirtName"]);
						m_LastName =Convert.ToString(myReader["LastName"]);
						m_Employee_Name =Convert.ToString(myReader["Employee_Name"]);
						m_Alias =Convert.ToString(myReader["Alias"]);
						m_Sex =Convert.ToBoolean(myReader["Sex"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Country_ID =Convert.ToString(myReader["Country_ID"]);
						m_H_Tel =Convert.ToString(myReader["H_Tel"]);
						m_O_Tel =Convert.ToString(myReader["O_Tel"]);
						m_Mobile =Convert.ToString(myReader["Mobile"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Birthday =Convert.ToDateTime(myReader["Birthday"]);
						m_Married =Convert.ToInt32(myReader["Married"]);
						m_Position_ID =Convert.ToString(myReader["Position_ID"]);
						m_JobTitle_ID =Convert.ToString(myReader["JobTitle_ID"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Team_ID =Convert.ToString(myReader["Team_ID"]);
						m_PersonalTax_ID =Convert.ToString(myReader["PersonalTax_ID"]);
						m_City_ID =Convert.ToString(myReader["City_ID"]);
						m_District_ID =Convert.ToString(myReader["District_ID"]);
						m_Manager_ID =Convert.ToString(myReader["Manager_ID"]);
						m_EmployeeType =Convert.ToInt32(myReader["EmployeeType"]);
                        //m_BasicSalary =Convert.ToDecimal(myReader["BasicSalary"]);
                        //m_Advance =Convert.ToDecimal(myReader["Advance"]);
                        //m_AdvanceOther =Convert.ToDecimal(myReader["AdvanceOther"]);
                        //m_Commission =Convert.ToDecimal(myReader["Commission"]);
                        //m_Discount =Convert.ToDecimal(myReader["Discount"]);
                        //m_ProfitRate =Convert.ToDecimal(myReader["ProfitRate"]);
                        //m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]);
                        //m_CreatedBy =Convert.ToString(myReader["CreatedBy"]);
                        //m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
                        //m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
                        //m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
                        //m_OwnerID =Convert.ToString(myReader["OwnerID"]);
                        //m_Description =Convert.ToString(myReader["Description"]);
                        //m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_FirtName =Convert.ToString(myReader["FirtName"]==DBNull.Value?"":myReader["FirtName"] );
						m_LastName =Convert.ToString(myReader["LastName"]==DBNull.Value?"":myReader["LastName"] );
						m_Employee_Name =Convert.ToString(myReader["Employee_Name"]==DBNull.Value?"":myReader["Employee_Name"] );
						m_Alias =Convert.ToString(myReader["Alias"]==DBNull.Value?"":myReader["Alias"] );
						m_Sex =Convert.ToBoolean(myReader["Sex"]==DBNull.Value?true:myReader["Sex"] );
						m_Address =Convert.ToString(myReader["Address"]==DBNull.Value?"":myReader["Address"] );
						m_Country_ID =Convert.ToString(myReader["Country_ID"]==DBNull.Value?"":myReader["Country_ID"] );
						m_H_Tel =Convert.ToString(myReader["H_Tel"]==DBNull.Value?"":myReader["H_Tel"] );
						m_O_Tel =Convert.ToString(myReader["O_Tel"]==DBNull.Value?"":myReader["O_Tel"] );
						m_Mobile =Convert.ToString(myReader["Mobile"]==DBNull.Value?"":myReader["Mobile"] );
						m_Fax =Convert.ToString(myReader["Fax"]==DBNull.Value?"":myReader["Fax"] );
						m_Email =Convert.ToString(myReader["Email"]==DBNull.Value?"":myReader["Email"] );
						m_Birthday =Convert.ToDateTime(myReader["Birthday"]==DBNull.Value?DateTime.Now:myReader["Birthday"] );
						m_Married =Convert.ToInt32(myReader["Married"]==DBNull.Value?0:myReader["Married"] );
						m_Position_ID =Convert.ToString(myReader["Position_ID"]==DBNull.Value?"":myReader["Position_ID"] );
						m_JobTitle_ID =Convert.ToString(myReader["JobTitle_ID"]==DBNull.Value?"":myReader["JobTitle_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Team_ID =Convert.ToString(myReader["Team_ID"]==DBNull.Value?"":myReader["Team_ID"] );
						m_PersonalTax_ID =Convert.ToString(myReader["PersonalTax_ID"]==DBNull.Value?"":myReader["PersonalTax_ID"] );
						m_City_ID =Convert.ToString(myReader["City_ID"]==DBNull.Value?"":myReader["City_ID"] );
						m_District_ID =Convert.ToString(myReader["District_ID"]==DBNull.Value?"":myReader["District_ID"] );
						m_Manager_ID =Convert.ToString(myReader["Manager_ID"]==DBNull.Value?"":myReader["Manager_ID"] );
						m_EmployeeType =Convert.ToInt32(myReader["EmployeeType"]==DBNull.Value?0:myReader["EmployeeType"] );
						m_BasicSalary =Convert.ToDecimal(myReader["BasicSalary"]==DBNull.Value?0:myReader["BasicSalary"] );
						m_Advance =Convert.ToDecimal(myReader["Advance"]==DBNull.Value?0:myReader["Advance"] );
						m_AdvanceOther =Convert.ToDecimal(myReader["AdvanceOther"]==DBNull.Value?0:myReader["AdvanceOther"] );
						m_Commission =Convert.ToDecimal(myReader["Commission"]==DBNull.Value?0:myReader["Commission"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_ProfitRate =Convert.ToDecimal(myReader["ProfitRate"]==DBNull.Value?0:myReader["ProfitRate"] );
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
						m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
						#endif
						Result=true;
				}
				myReader.Close();
				myReader = null;
			}
			else
			{
				mySql.Close();
				if(MyParamaters.IsShowWarning) 
					XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return Result;
		}

		public bool Get(
			SqlTransaction myTransaction,
			string Employee_ID)
		{
			bool Result=false;
			string[] myPara={
			"@Employee_ID"};
			object[] myValue={
			Employee_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"EMPLOYEE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_FirtName =Convert.ToString(myReader["FirtName"]);
						m_LastName =Convert.ToString(myReader["LastName"]);
						m_Employee_Name =Convert.ToString(myReader["Employee_Name"]);
						m_Alias =Convert.ToString(myReader["Alias"]);
						m_Sex =Convert.ToBoolean(myReader["Sex"]);
						m_Address =Convert.ToString(myReader["Address"]);
						m_Country_ID =Convert.ToString(myReader["Country_ID"]);
						m_H_Tel =Convert.ToString(myReader["H_Tel"]);
						m_O_Tel =Convert.ToString(myReader["O_Tel"]);
						m_Mobile =Convert.ToString(myReader["Mobile"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Birthday =Convert.ToDateTime(myReader["Birthday"]);
						m_Married =Convert.ToInt32(myReader["Married"]);
						m_Position_ID =Convert.ToString(myReader["Position_ID"]);
						m_JobTitle_ID =Convert.ToString(myReader["JobTitle_ID"]);
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]);
						m_Department_ID =Convert.ToString(myReader["Department_ID"]);
						m_Team_ID =Convert.ToString(myReader["Team_ID"]);
						m_PersonalTax_ID =Convert.ToString(myReader["PersonalTax_ID"]);
						m_City_ID =Convert.ToString(myReader["City_ID"]);
						m_District_ID =Convert.ToString(myReader["District_ID"]);
						m_Manager_ID =Convert.ToString(myReader["Manager_ID"]);
						m_EmployeeType =Convert.ToInt32(myReader["EmployeeType"]);
						m_BasicSalary =Convert.ToDecimal(myReader["BasicSalary"]);
						m_Advance =Convert.ToDecimal(myReader["Advance"]);
						m_AdvanceOther =Convert.ToDecimal(myReader["AdvanceOther"]);
						m_Commission =Convert.ToDecimal(myReader["Commission"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_ProfitRate =Convert.ToDecimal(myReader["ProfitRate"]);
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]);
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						m_OwnerID =Convert.ToString(myReader["OwnerID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]==DBNull.Value?"":myReader["Employee_ID"] );
						m_FirtName =Convert.ToString(myReader["FirtName"]==DBNull.Value?"":myReader["FirtName"] );
						m_LastName =Convert.ToString(myReader["LastName"]==DBNull.Value?"":myReader["LastName"] );
						m_Employee_Name =Convert.ToString(myReader["Employee_Name"]==DBNull.Value?"":myReader["Employee_Name"] );
						m_Alias =Convert.ToString(myReader["Alias"]==DBNull.Value?"":myReader["Alias"] );
						m_Sex =Convert.ToBoolean(myReader["Sex"]==DBNull.Value?true:myReader["Sex"] );
						m_Address =Convert.ToString(myReader["Address"]==DBNull.Value?"":myReader["Address"] );
						m_Country_ID =Convert.ToString(myReader["Country_ID"]==DBNull.Value?"":myReader["Country_ID"] );
						m_H_Tel =Convert.ToString(myReader["H_Tel"]==DBNull.Value?"":myReader["H_Tel"] );
						m_O_Tel =Convert.ToString(myReader["O_Tel"]==DBNull.Value?"":myReader["O_Tel"] );
						m_Mobile =Convert.ToString(myReader["Mobile"]==DBNull.Value?"":myReader["Mobile"] );
						m_Fax =Convert.ToString(myReader["Fax"]==DBNull.Value?"":myReader["Fax"] );
						m_Email =Convert.ToString(myReader["Email"]==DBNull.Value?"":myReader["Email"] );
						m_Birthday =Convert.ToDateTime(myReader["Birthday"]==DBNull.Value?DateTime.Now:myReader["Birthday"] );
						m_Married =Convert.ToInt32(myReader["Married"]==DBNull.Value?0:myReader["Married"] );
						m_Position_ID =Convert.ToString(myReader["Position_ID"]==DBNull.Value?"":myReader["Position_ID"] );
						m_JobTitle_ID =Convert.ToString(myReader["JobTitle_ID"]==DBNull.Value?"":myReader["JobTitle_ID"] );
						m_Branch_ID =Convert.ToString(myReader["Branch_ID"]==DBNull.Value?"":myReader["Branch_ID"] );
						m_Department_ID =Convert.ToString(myReader["Department_ID"]==DBNull.Value?"":myReader["Department_ID"] );
						m_Team_ID =Convert.ToString(myReader["Team_ID"]==DBNull.Value?"":myReader["Team_ID"] );
						m_PersonalTax_ID =Convert.ToString(myReader["PersonalTax_ID"]==DBNull.Value?"":myReader["PersonalTax_ID"] );
						m_City_ID =Convert.ToString(myReader["City_ID"]==DBNull.Value?"":myReader["City_ID"] );
						m_District_ID =Convert.ToString(myReader["District_ID"]==DBNull.Value?"":myReader["District_ID"] );
						m_Manager_ID =Convert.ToString(myReader["Manager_ID"]==DBNull.Value?"":myReader["Manager_ID"] );
						m_EmployeeType =Convert.ToInt32(myReader["EmployeeType"]==DBNull.Value?0:myReader["EmployeeType"] );
						m_BasicSalary =Convert.ToDecimal(myReader["BasicSalary"]==DBNull.Value?0:myReader["BasicSalary"] );
						m_Advance =Convert.ToDecimal(myReader["Advance"]==DBNull.Value?0:myReader["Advance"] );
						m_AdvanceOther =Convert.ToDecimal(myReader["AdvanceOther"]==DBNull.Value?0:myReader["AdvanceOther"] );
						m_Commission =Convert.ToDecimal(myReader["Commission"]==DBNull.Value?0:myReader["Commission"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_ProfitRate =Convert.ToDecimal(myReader["ProfitRate"]==DBNull.Value?0:myReader["ProfitRate"] );
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
						m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
						#endif
						Result=true;
				}
				myReader.Close();
				myReader = null;
			}
			else
				{
						mySql.RollBack(myTransaction);
						if(MyParamaters.IsShowWarning) 
							XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			return Result;
		}
		#endregion

		#region Add
		public bool Insert()
		{
			return Insert(
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
		public bool Insert(
			SqlConnection myConnection,
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@Employee_ID",
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@Country_ID",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@Position_ID",
			"@JobTitle_ID",
			"@Branch_ID",
			"@Department_ID",
			"@Team_ID",
			"@PersonalTax_ID",
			"@City_ID",
			"@District_ID",
			"@Manager_ID",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"EMPLOYEE_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@Employee_ID",
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@Country_ID",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@Position_ID",
			"@JobTitle_ID",
			"@Branch_ID",
			"@Department_ID",
			"@Team_ID",
			"@PersonalTax_ID",
			"@City_ID",
			"@District_ID",
			"@Manager_ID",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"EMPLOYEE_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active)
			)
				{
					mySql.Close();
					return true;
				}
			return false;
		}

		public bool Update(
			SqlConnection myConnection,
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@Employee_ID",
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@Country_ID",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@Position_ID",
			"@JobTitle_ID",
			"@Branch_ID",
			"@Department_ID",
			"@Team_ID",
			"@PersonalTax_ID",
			"@City_ID",
			"@District_ID",
			"@Manager_ID",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"EMPLOYEE_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@Employee_ID",
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@Country_ID",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@Position_ID",
			"@JobTitle_ID",
			"@Branch_ID",
			"@Department_ID",
			"@Team_ID",
			"@PersonalTax_ID",
			"@City_ID",
			"@District_ID",
			"@Manager_ID",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={Employee_ID,FirtName,LastName,Employee_Name,Alias,Sex,Address,Country_ID,H_Tel,O_Tel,Mobile,Fax,Email,Birthday,Married,Position_ID,JobTitle_ID,Branch_ID,Department_ID,Team_ID,PersonalTax_ID,City_ID,District_ID,Manager_ID,EmployeeType,BasicSalary,Advance,AdvanceOther,Commission,Discount,ProfitRate,IsPublic,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,OwnerID,Description,Sorted,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"EMPLOYEE_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_ModifiedBy,
			m_ModifiedDate,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_ModifiedBy,
			m_ModifiedDate,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_Employee_ID,
			m_FirtName,
			m_LastName,
			m_Employee_Name,
			m_Alias,
			m_Sex,
			m_Address,
			m_Country_ID,
			m_H_Tel,
			m_O_Tel,
			m_Mobile,
			m_Fax,
			m_Email,
			m_Birthday,
			m_Married,
			m_Position_ID,
			m_JobTitle_ID,
			m_Branch_ID,
			m_Department_ID,
			m_Team_ID,
			m_PersonalTax_ID,
			m_City_ID,
			m_District_ID,
			m_Manager_ID,
			m_EmployeeType,
			m_BasicSalary,
			m_Advance,
			m_AdvanceOther,
			m_Commission,
			m_Discount,
			m_ProfitRate,
			m_IsPublic,
			m_ModifiedBy,
			m_ModifiedDate,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByID(
			SqlConnection myConnection,
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@Employee_ID",
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@Country_ID",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@Position_ID",
			"@JobTitle_ID",
			"@Branch_ID",
			"@Department_ID",
			"@Team_ID",
			"@PersonalTax_ID",
			"@City_ID",
			"@District_ID",
			"@Manager_ID",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@IsPublic",
			"@ModifiedBy",
			"@ModifiedDate",
			"@Description",
			"@Active"};
			object[] myValue={
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"EMPLOYEE_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string Employee_ID,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string Country_ID,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			string Position_ID,
			string JobTitle_ID,
			string Branch_ID,
			string Department_ID,
			string Team_ID,
			string PersonalTax_ID,
			string City_ID,
			string District_ID,
			string Manager_ID,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			bool IsPublic,
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@Employee_ID",
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@Country_ID",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@Position_ID",
			"@JobTitle_ID",
			"@Branch_ID",
			"@Department_ID",
			"@Team_ID",
			"@PersonalTax_ID",
			"@City_ID",
			"@District_ID",
			"@Manager_ID",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@IsPublic",
			"@ModifiedBy",
			"@ModifiedDate",
			"@Description",
			"@Active"};
			object[] myValue={
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"EMPLOYEE_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Delete
		public bool Delete()
		{
			return Delete(
			m_Employee_ID);
		}
		public bool Delete(
			SqlConnection myConnection)
		{
			return Delete(
			myConnection,
			m_Employee_ID);
		}
		public bool Delete(
			SqlTransaction myTransaction)
		{
			return Delete(
			myTransaction,
			m_Employee_ID);
		}
		public bool Delete(
			string Employee_ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete(
			mySql.Connection,
			Employee_ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Delete(
			SqlConnection myConnection,
			string Employee_ID)
		{
			string[] myPara={
			"@Employee_ID"};
			object[] myValue={
			Employee_ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"EMPLOYEE_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			string Employee_ID)
		{
			string[] myPara={
			"@Employee_ID"};
			object[] myValue={
			Employee_ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"EMPLOYEE_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteDataTable(QGetList);
		}
        
        public DataTable GetRegionList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(RegionList);
        }

        


		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"EMPLOYEE_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"EMPLOYEE_GetList");
		}
		#endregion
		

		#region Count

		public int Count()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return 0;
			int _count= Count(
			mySql.Connection);

			mySql.Close();
			return _count;
		}


		public int Count(
			SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myConnection,"EMPLOYEE_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"EMPLOYEE_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			string Description)
		{
			string[] myPara={
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@Description"};
			object[] myValue={
			"%"+FirtName+"%",
			"%"+LastName+"%",
			"%"+Employee_Name+"%",
			"%"+Alias+"%",
			"%"+Sex+"%",
			"%"+Address+"%",
			"%"+H_Tel+"%",
			"%"+O_Tel+"%",
			"%"+Mobile+"%",
			"%"+Fax+"%",
			"%"+Email+"%",
			"%"+Birthday+"%",
			"%"+Married+"%",
			"%"+EmployeeType+"%",
			"%"+BasicSalary+"%",
			"%"+Advance+"%",
			"%"+AdvanceOther+"%",
			"%"+Commission+"%",
			"%"+Discount+"%",
			"%"+ProfitRate+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"EMPLOYEE_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			string FirtName,
			string LastName,
			string Employee_Name,
			string Alias,
			bool Sex,
			string Address,
			string H_Tel,
			string O_Tel,
			string Mobile,
			string Fax,
			string Email,
			DateTime Birthday,
			int Married,
			int EmployeeType,
			decimal BasicSalary,
			decimal Advance,
			decimal AdvanceOther,
			decimal Commission,
			decimal Discount,
			decimal ProfitRate,
			string Description)
		{
			string[] myPara={
			"@FirtName",
			"@LastName",
			"@Employee_Name",
			"@Alias",
			"@Sex",
			"@Address",
			"@H_Tel",
			"@O_Tel",
			"@Mobile",
			"@Fax",
			"@Email",
			"@Birthday",
			"@Married",
			"@EmployeeType",
			"@BasicSalary",
			"@Advance",
			"@AdvanceOther",
			"@Commission",
			"@Discount",
			"@ProfitRate",
			"@Description"};
			object[] myValue={
			"%"+FirtName+"%",
			"%"+LastName+"%",
			"%"+Employee_Name+"%",
			"%"+Alias+"%",
			"%"+Sex+"%",
			"%"+Address+"%",
			"%"+H_Tel+"%",
			"%"+O_Tel+"%",
			"%"+Mobile+"%",
			"%"+Fax+"%",
			"%"+Email+"%",
			"%"+Birthday+"%",
			"%"+Married+"%",
			"%"+EmployeeType+"%",
			"%"+BasicSalary+"%",
			"%"+Advance+"%",
			"%"+AdvanceOther+"%",
			"%"+Commission+"%",
			"%"+Discount+"%",
			"%"+ProfitRate+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"EMPLOYEE_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("EMPLOYEE_LookUp");
		}
		#endregion
		
		public void AddCombo(System.Windows.Forms.ComboBox combo)
		{
			AddCombo(combo,LookUp());
		}
		
		public void AddCombo(System.Windows.Forms.ComboBox combo,System.Data.DataTable dt)
		{
			MyLib.TableToComboBox(combo,dt, "ID", "Name");
		}
		
		public void AddComboAll(System.Windows.Forms.ComboBox combo)
		{
			AddComboAll(combo,"(Tất cả)");
		}
		public void AddComboDefault(System.Windows.Forms.ComboBox combo)
		{
			AddComboAll(combo,"(Mặc định)");
		}
		public void AddComboAll(System.Windows.Forms.ComboBox combo,string text)
		{
			DataTable dt = new DataTable();
			dt =LookUp();
			DataRow b = dt.NewRow();
			b["ID"] = "All";
			b["Name"] = text;
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "ID", "Name");
		}
		#endregion
		
		#region Error
		
		private void DispError(object sender, SqlHelperException e)
		{
			XtraMessageBox.Show(e.Message,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion


        #region Query
        
        private string QGetList
        {
            get
            {
                return @"SELECT e.Employee_ID,
       e.FirtName,
       e.LastName,
       e.Employee_Name,
       e.Alias,
       e.Sex,
       e.[Address],
       e.Country_ID,
       e.H_Tel,
       e.O_Tel,
       e.Mobile,
       e.Fax,
       e.Email,
       e.Birthday,
       e.Married,
       e.Position_ID,
       e.JobTitle_ID,
       e.Branch_ID,
       e.Department_ID,
       e.Team_ID,
       e.PersonalTax_ID,
       e.City_ID,
       e.District_ID,
       e.Manager_ID,
       e.EmployeeType,
       e.BasicSalary,
       e.Advance,
       e.AdvanceOther,
       e.Commission,
       e.Discount,
       e.ProfitRate,
       e.IsPublic,
       e.CreatedBy,
       e.CreatedDate,
       e.ModifiedBy,
       e.ModifiedDate,
       e.OwnerID,
       e.[Description],
       e.Sorted,
       e.[Active],
       CAST(e.[Active] AS INT) AS [ActiveInt]
FROM   EMPLOYEE e";
            }
        }

        private string RegionList
        {
            get
            {
                return @"SELECT Customer_Group_ID AS GroupID, Customer_Group_Name AS GroupName FROM CUSTOMER_GROUP";
            }
        }


        #endregion
    }

	#region Enum Fields

	public enum EMPLOYEEFields
		{
			Employee_ID,
			FirtName,
			LastName,
			Employee_Name,
			Alias,
			Sex,
			Address,
			Country_ID,
			H_Tel,
			O_Tel,
			Mobile,
			Fax,
			Email,
			Birthday,
			Married,
			Position_ID,
			JobTitle_ID,
			Branch_ID,
			Department_ID,
			Team_ID,
			PersonalTax_ID,
			City_ID,
			District_ID,
			Manager_ID,
			EmployeeType,
			BasicSalary,
			Advance,
			AdvanceOther,
			Commission,
			Discount,
			ProfitRate,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active
		}

	#endregion

	#region Class Collection

	public class EMPLOYEECollection : System.Collections.CollectionBase
		{
			[Description("Adds a new EMPLOYEE to the collection.")]
			public int Add(EMPLOYEE item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a EMPLOYEE from the collection.")]
			public void Remove(EMPLOYEE item)
				{
					List.Remove(item);
				}
			[Description("Inserts an EMPLOYEE into the collection at the specified index..")]
			public void Inserts(int index,EMPLOYEE item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(EMPLOYEE item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the EMPLOYEE class is present in the collection.")]
			public bool Contains(EMPLOYEE item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
