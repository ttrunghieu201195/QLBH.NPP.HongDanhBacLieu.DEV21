using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;


namespace Perfect.ERP
{
	
	public class SysOption
	{
		#region Init
		private string m_Option_ID;
		private string m_OptionValue;
		private int m_ValueType;
		private string m_Description;

		public SysOption()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Option_ID="";
			 m_OptionValue="";
			 m_ValueType=0;
			 m_Description="";
		}
		public SysOption(string Option_ID,string OptionValue,int ValueType,string Description)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Option_ID=Option_ID;
			 m_OptionValue=OptionValue;
			 m_ValueType=ValueType;
			 m_Description=Description;
		}
		#endregion
		
		#region Property
		public string Option_ID
		{
			get
			{
				return m_Option_ID;
			}
			set
			{
				m_Option_ID = value;
			}
		}
		public string OptionValue
		{
			get
			{
				return m_OptionValue;
			}
			set
			{
				m_OptionValue = value;
			}
		}
		public int ValueType
		{
			get
			{
				return m_ValueType;
			}
			set
			{
				m_ValueType = value;
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
		public string ProductName
		{
			get
			{
				return "Class SYS_OPTION";
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
			return SqlHelper.GenCode("SYS_OPTION","SYS_OPTIONID","");
		}
		public Boolean Exist(string Option_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_OPTION_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
		    
             
 
			return Result;
		}
		public string Get(string Option_ID)
		{
			string result="";
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_OPTION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Option_ID =Convert.ToString(myReader["Option_ID"]);
						m_OptionValue =Convert.ToString(myReader["OptionValue"]);
						m_ValueType =Convert.ToInt32(myReader["ValueType"]);
						m_Description =Convert.ToString(myReader["Description"]);
						result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return result;
		}
		public string Get(SqlConnection myConnection,string Option_ID)
		{
			string result="";
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SYS_OPTION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Option_ID =Convert.ToString(myReader["Option_ID"]);
						m_OptionValue =Convert.ToString(myReader["OptionValue"]);
						m_ValueType =Convert.ToInt32(myReader["ValueType"]);
						m_Description =Convert.ToString(myReader["Description"]);
						result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return result;
		}
		public string Get(SqlTransaction myTransaction,string Option_ID)
		{
			string Result="";
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SYS_OPTION_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Option_ID =Convert.ToString(myReader["Option_ID"]);
						m_OptionValue =Convert.ToString(myReader["OptionValue"]);
						m_ValueType =Convert.ToInt32(myReader["ValueType"]);
						m_Description =Convert.ToString(myReader["Description"]);
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
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={m_Option_ID,m_OptionValue,m_ValueType,m_Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_OPTION_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={m_Option_ID,m_OptionValue,m_ValueType,m_Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_OPTION_Insert",myPara,myValue);
		}
		public string Insert(string Option_ID,string OptionValue,int ValueType,string Description)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={Option_ID,OptionValue,ValueType,Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_OPTION_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Option_ID,string OptionValue,int ValueType,string Description)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={Option_ID,OptionValue,ValueType,Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_OPTION_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Option_ID,string OptionValue,int ValueType,string Description)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={Option_ID,OptionValue,ValueType,Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_OPTION_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={m_Option_ID,m_OptionValue,m_ValueType,m_Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_OPTION_Update",myPara,myValue);
		}
		public string Update(string Option_ID,string OptionValue,int ValueType,string Description)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={Option_ID,OptionValue,ValueType,Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_OPTION_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Option_ID,string OptionValue,int ValueType,string Description)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={Option_ID,OptionValue,ValueType,Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_OPTION_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Option_ID,string OptionValue,int ValueType,string Description)
		{
			string[] myPara={"@Option_ID","@OptionValue","@ValueType","@Description"};
			object[] myValue={Option_ID,OptionValue,ValueType,Description};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_OPTION_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Option_ID"};
			object[] myValue={m_Option_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_OPTION_Delete",myPara,myValue);
		}
		public string Delete(string Option_ID)
		{
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_OPTION_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Option_ID)
		{
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_OPTION_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Option_ID)
		{
			string[] myPara={"@Option_ID"};
			object[] myValue={Option_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_OPTION_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			var mySql=new SqlHelper();
			return mySql.ExecuteDataTable("SYS_OPTION_GetList");
		}
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "SYS_OPTIONName", "SYS_OPTIONID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			var dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["SYS_OPTIONID"] = "All";
			b["SYS_OPTIONName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "SYS_OPTIONName", "SYS_OPTIONID");
		}
		#endregion

        #region Modiffy

        private static string m_Language="VN";

        public static string Language
        {
            get { return m_Language; }
            set { m_Language = value; }
        }

        public static void Load()
        {
            var SYS = new SysOption();
            SYS.Get("Language_Id");
            m_Language = SYS.OptionValue == "" ? "VN" : SYS.OptionValue;            
        }

        #endregion

        #region Batch


        private static bool m_Batch=false;

        public static bool Batch
        {
            get { return m_Batch; }
            set { m_Batch = value; }
        }
	        
        /// <summary>
        /// Can bat loi
        /// </summary>
        public static void LoadBatch()
        {
            var sys = new SysOption();
            sys.Get("Batch");
            m_Batch = sys.OptionValue == "1" ? true : false;
        }
        

        #endregion

        #region Limit


        private static bool m_Limit = false;

        public static bool Limit
        {
            get { return m_Limit; }
            set { m_Limit = value; }
        }
        /// <summary>
        /// Can bat loi
        /// </summary>
        public static void LoadLimit()
        {
            var sys = new SysOption();
            sys.Get("Limit");
            m_Limit = sys.OptionValue == "1" ? true : false;
        }


        #endregion

        #region Negative


        private static bool _mNegative;

        public static bool Negative
        {
            get { return _mNegative; }
            set { _mNegative = value; }
        }

        public static void LoadNegative()
        {
            var sys = new SysOption();
            sys.Get("Negative");
            _mNegative = sys.OptionValue == "1" ? true : false;
        }


        #endregion

        #region Currency


        private static string m_Currency = "VND";

        public static string Currency
        {
            get { return m_Currency; }
            set { m_Currency = value; }
        }

	   
	    public static void LoadCurrency()
        {
            var sys = new SysOption();
            sys.Get("Currency");
            try
            {
                m_Currency = Convert.ToString((sys.OptionValue));
            }
            catch (System.Exception ex)
            {
                m_Currency = "VND";
            }
        }


        #endregion

        #region Language Report

	    private static string m_ReportLanguage = "VN";

        public static string ReportLanguage
        {
            get { return m_ReportLanguage; }
            set { m_ReportLanguage = value; }
        }

	    public static string ReportLocalization
	    {
	        get { return m_ReportLocalization; }
	        set { m_ReportLocalization = value; }
	    }

	    private static string m_ReportLocalization = "vi-VN";


        #endregion

    }
}
