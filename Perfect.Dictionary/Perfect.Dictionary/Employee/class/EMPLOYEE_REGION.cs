using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{ 
	public class EMPLOYEE_REGION
	{
		#region Init

		private string m_EmployeeID;
		private string m_RegionID;
		private string m_RegionName; 

		public EMPLOYEE_REGION()
		{ 
			 m_EmployeeID="";
			 m_RegionID="";
			 m_RegionName=""; 
		}
		public EMPLOYEE_REGION(string EmployeeID,string RegionID,string RegionName)
		{ 
			 m_EmployeeID=EmployeeID;
			 m_RegionID=RegionID;
			 m_RegionName=RegionName; 
		}
		#endregion
		
		#region Property
		public string EmployeeID
		{
			get
			{
				return m_EmployeeID;
			}
			set
			{
				m_EmployeeID = value;
			}
		}
		public string RegionID
		{
			get
			{
				return m_RegionID;
			}
			set
			{
				m_RegionID = value;
			}
		}
		public string RegionName
		{
			get
			{
				return m_RegionName;
			}
			set
			{
				m_RegionName = value;
			}
		} 
		public string ProductName
		{
			get
			{
				return "Class EMPLOYEE_REGION";
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
			return SqlHelper.GenCode("EMPLOYEE_REGION","EMPLOYEE_REGIONID","");
		}
        public Boolean ExistEmployee(string EmployeeID)
        {
            Boolean Result = false;
            string[] myPara = { "@EmployeeID"};
            object[] myValue = { EmployeeID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM EMPLOYEE_REGION WHERE EmployeeID = @EmployeeID ";
            SqlDataReader myReader = mySql.ExecuteReader(sql, myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
		public Boolean Exist(string EmployeeID, string RegionID)
		{
			Boolean Result=false;
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM EMPLOYEE_REGION WHERE EmployeeID = @EmployeeID AND RegionID = @RegionID ";
			SqlDataReader myReader=mySql.ExecuteReader(sql,myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
        public string Get(string EmployeeID, string RegionID)
		{
			string Result="";
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM EMPLOYEE_REGION WHERE EmployeeID = @EmployeeID AND RegionID = @RegionID ";
			
			SqlDataReader myReader=mySql.ExecuteReader(sql,myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_EmployeeID =Convert.ToString(myReader["EmployeeID"]);
						m_RegionID =Convert.ToString(myReader["RegionID"]);
						m_RegionName =Convert.ToString(myReader["RegionName"]); 
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
        public string Get(SqlConnection myConnection, string EmployeeID, string RegionID)
		{
			string Result="";
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM EMPLOYEE_REGION WHERE EmployeeID = @EmployeeID AND RegionID = @RegionID ";
			
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,sql,myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_EmployeeID =Convert.ToString(myReader["EmployeeID"]);
						m_RegionID =Convert.ToString(myReader["RegionID"]);
						m_RegionName =Convert.ToString(myReader["RegionName"]); 
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
        public string Get(SqlTransaction myTransaction, string EmployeeID, string RegionID)
		{
			string Result="";
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM EMPLOYEE_REGION WHERE EmployeeID = @EmployeeID AND RegionID = @RegionID ";
			
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,sql,myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_EmployeeID =Convert.ToString(myReader["EmployeeID"]);
						m_RegionID =Convert.ToString(myReader["RegionID"]);
						m_RegionName =Convert.ToString(myReader["RegionName"]); 
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
        string sqlInsert = @"
                INSERT INTO EMPLOYEE_REGION
                  (
                    EmployeeID,
                    RegionID,
                    RegionName
                  )
                VALUES
                  (
                    @EmployeeID,
                    @RegionID,
                    @RegionName
                  )";
		public string Insert()
		{
			string[] myPara={"@EmployeeID","@RegionID","@RegionName"};
			object[] myValue={m_EmployeeID,m_RegionID,m_RegionName };

			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlInsert,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlInsert,myPara,myValue);
		}
		public string Insert(string EmployeeID,string RegionID,string RegionName,bool Active)
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlInsert,myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string EmployeeID,string RegionID,string RegionName,bool Active)
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sqlInsert,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string EmployeeID,string RegionID,string RegionName,bool Active)
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlInsert,myPara,myValue);
		}
		#endregion
		
		#region Update
        string sqlUpdate = @"UPDATE EMPLOYEE_REGION
SET    EmployeeID       = @EmployeeID,
       RegionID         = @RegionID,
       RegionName       = @RegionName
WHERE  EmployeeID       = @EmployeeID
       AND RegionID     = @RegionID";

		public string Update()
		{
			string[] myPara={"@EmployeeID","@RegionID","@RegionName"};
			object[] myValue={m_EmployeeID,m_RegionID,m_RegionName};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlUpdate,myPara,myValue);
		}
		public string Update(string EmployeeID,string RegionID,string RegionName )
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlUpdate,myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string EmployeeID,string RegionID,string RegionName)
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myConnection,sqlUpdate,myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string EmployeeID,string RegionID,string RegionName)
		{
            string[] myPara = { "@EmployeeID", "@RegionID", "@RegionName" };
            object[] myValue = { m_EmployeeID, m_RegionID, m_RegionName };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(myTransaction,sqlUpdate,myPara,myValue);
		}
		#endregion
		
		#region Delete
        string sqlDel = @"DELETE 
                            FROM   EMPLOYEE_REGION
                            WHERE  EmployeeID = @EmployeeID
                                   AND RegionID = @RegionID";
        public string DeleteByEmp(string EmployeeID)
        {
            string[] myPara = { "@EmployeeID" };
            object[] myValue = { EmployeeID};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sqlDel = @"DELETE 
                            FROM   EMPLOYEE_REGION
                            WHERE  EmployeeID = @EmployeeID";
            return mySql.ExecuteNonQuery(sqlDel, myPara, myValue);
        }
        public string Delete()
		{
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlDel,myPara,myValue);
		}
        public string Delete(string EmployeeID, string RegionID)
		{
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(sqlDel, myPara, myValue);


		}
        public string Delete(SqlConnection myConnection, string EmployeeID, string RegionID)
		{ 
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myConnection,sqlDel, myPara, myValue); 

		}
        public string Delete(SqlTransaction myTransaction, string EmployeeID, string RegionID)
		{
            string[] myPara = { "@EmployeeID", "@RegionID" };
            object[] myValue = { EmployeeID, RegionID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction, sqlDel, myPara, myValue); 

		}
		#endregion

 
        
        
        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(QGetList);
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt = GetList();
            DataRow b = dt.NewRow();
            b["EMPLOYEE_REGION_ID"] = "All";
            b["EMPLOYEE_REGION_Name"] = "Tất cả";
            dt.Rows.InsertAt(b, 0);
            return dt;
        }
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "EMPLOYEE_REGION_Name", "EMPLOYEE_REGION_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["EMPLOYEE_REGION_ID"] = "All";
			b["EMPLOYEE_REGION_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "EMPLOYEE_REGION_Name", "EMPLOYEE_REGION_ID");
		}
		#endregion

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT
	*
FROM
	EMPLOYEE_REGION cg";
            }
        }
        #endregion
		
	}
}
