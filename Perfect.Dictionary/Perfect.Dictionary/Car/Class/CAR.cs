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
	/// Generated Class for Table : CURRENCY.
	/// Date: 1/14/2009
	/// Author: 
	/// </summary>
	public class CAR
	{
		#region Init

		private string m_ID;
		private string m_CarNumber;
        private string m_Owner;
        private string m_Phone;
        private string m_CarSize;
        private Int32 m_CarVolume;
        private string m_Schedule;
        private string m_Notes;

		public CAR()
		{
			m_ID = "";
		    m_CarNumber = "";
            m_Owner = "";
            m_Phone = "";
            m_CarSize = "";
            m_CarVolume = 0;
            m_Schedule = "";
            m_Notes = "";
		}
        public CAR(string ID, string CarNumber, string Owner, string Phone, 
            string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            m_ID = ID;
            m_CarNumber = CarNumber;
            m_Owner = Owner;
            m_Phone = Phone;
            m_CarSize = CarSize;
            m_CarVolume = CarVolume;
            m_Schedule = Schedule;
            m_Notes = Notes;
		}
		#endregion
		
		#region Property
		public string ID
		{
			get
			{
				return m_ID;
			}
			set
			{
				m_ID = value;
			}
		}
        
        public string CarNumber
        {
            get
            {
                return m_CarNumber;
            }
            set
            {
                m_CarNumber = value;
            }
        }
        public string Owner
        {
            get
            {
                return m_Owner;
            }
            set
            {
                m_Owner = value;
            }
        }
        public string Phone
        {
            get
            {
                return m_Phone;
            }
            set
            {
                m_Phone = value;
            }
        }

        public string CarSize
        {
            get
            {
                return m_CarSize;
            }
            set
            {
                m_CarSize = value;
            }
        }

        public Int32 CarVolume
        {
            get
            {
                return m_CarVolume;
            }
            set
            {
                m_CarVolume = value;
            }
        }

        public string Schedule
        {
            get
            {
                return m_Schedule;
            }
            set
            {
                m_Schedule = value;
            }
        }

        public string Notes
        {
            get
            {
                return m_Notes;
            }
            set
            {
                m_Notes = value;
            }
        }
         
         
		public string ProductName
		{
			get
			{
				return "Class CURRENCY";
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
			return SqlHelper.GenCode("CARS","ID","");
		}
		public Boolean Exist(string ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;            
			SqlDataReader myReader=mySql.ExecuteReader("SELECT * FROM CARS WHERE ID = @ID",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader("SELECT * FROM CARS WHERE ID = @ID", myPara, myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
					m_ID =Convert.ToString(myReader["ID"]);
					m_CarNumber =Convert.ToString(myReader["CarNumber"]);
                    m_Owner = Convert.ToString(myReader["Owner"]);

                    m_Phone = Convert.ToString(myReader["Phone"]);
                    m_CarSize = Convert.ToString(myReader["CarSize"]);

                    m_CarVolume = Convert.ToInt32(myReader["CarVolume"]);
                    m_Schedule = Convert.ToString(myReader["Schedule"]);

                    m_Notes = Convert.ToString(myReader["Notes"]); 

					Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlConnection myConnection,string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "SELECT * FROM CARS WHERE ID = @ID", myPara, myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_CarNumber = Convert.ToString(myReader["CarNumber"]);
                    m_Owner = Convert.ToString(myReader["Owner"]);

                    m_Phone = Convert.ToString(myReader["Phone"]);
                    m_CarSize = Convert.ToString(myReader["CarSize"]);

                    m_CarVolume = Convert.ToInt32(myReader["CarVolume"]);
                    m_Schedule = Convert.ToString(myReader["Schedule"]);

                    m_Notes = Convert.ToString(myReader["Notes"]); 
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,string ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "SELECT * FROM CARS WHERE ID = @ID", myPara, myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
                    m_ID = Convert.ToString(myReader["ID"]);
                    m_CarNumber = Convert.ToString(myReader["CarNumber"]);
                    m_Owner = Convert.ToString(myReader["Owner"]);

                    m_Phone = Convert.ToString(myReader["Phone"]);
                    m_CarSize = Convert.ToString(myReader["CarSize"]);

                    m_CarVolume = Convert.ToInt32(myReader["CarVolume"]);
                    m_Schedule = Convert.ToString(myReader["Schedule"]);

                    m_Notes = Convert.ToString(myReader["Notes"]); 
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

        #region sqlInsert
        string sqlInsert = @"INSERT INTO CARS
(
	ID,
	CarNumber,
	Owner,
	Phone,
	CarSize,
	CarVolume,
	Schedule,
	Notes
)
VALUES
(
	@ID,
	@CarNumber,
	@Owner,
	@Phone,
	@CarSize,
	@CarVolume,
	@Schedule,
	@Notes
)";
        #endregion

        public string Insert()
		{
            string[] myPara ={"@ID","@CarNumber","@Owner","@Phone","@CarSize","@CarVolume","@Schedule","@Notes"};
            object[] myValue ={m_ID,m_CarNumber,m_Owner,m_Phone,m_CarSize,m_CarVolume,m_Schedule,m_Notes};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
			return mySql.ExecuteNonQuery(sqlInsert,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { m_ID, m_CarNumber, m_Owner, m_Phone, m_CarSize, m_CarVolume, m_Schedule, m_Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction,sqlInsert, myPara, myValue);
		}
        public string Insert(string ID, string CarNumber, string Owner, string Phone, string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { ID, CarNumber, Owner, Phone, CarSize, CarVolume, Schedule, Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(sqlInsert, myPara, myValue);
		}
        public string Insert(SqlConnection myConnection, string ID, string CarNumber, string Owner, string Phone, string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { ID, CarNumber, Owner, Phone, CarSize, CarVolume, Schedule, Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myConnection,sqlInsert, myPara, myValue);
		}
        public string Insert(SqlTransaction myTransaction, string ID, string CarNumber, string Owner, string Phone, string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { ID, CarNumber, Owner, Phone, CarSize, CarVolume, Schedule, Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction,sqlInsert, myPara, myValue);
		}
		#endregion
		
		#region Update
        #region sqlUpdate
        string sqlUpdate = @"UPDATE CARS
                SET 
	                CarNumber = @CarNumber,
	                Owner = @Owner,
	                Phone = @Phone,
	                CarSize = @CarSize,
	                CarVolume = @CarVolume,
	                Schedule = @Schedule,
	                Notes = @Notes
                WHERE ID = @ID";
        #endregion

        public string Update()
		{ 
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { m_ID, m_CarNumber, m_Owner, m_Phone, m_CarSize, m_CarVolume, m_Schedule, m_Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(sqlUpdate, myPara, myValue);
		}

        public string Update(string ID, string CarNumber, string Owner, string Phone, string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { ID, CarNumber, Owner, Phone, CarSize, CarVolume, Schedule, Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(sqlUpdate, myPara, myValue);             
		}

        public string Update(SqlConnection myConnection, string ID, string CarNumber, string Owner, string Phone, string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { ID, CarNumber, Owner, Phone, CarSize, CarVolume, Schedule, Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myConnection, sqlUpdate, myPara, myValue);
		}
        public string Update(SqlTransaction myTransaction, string ID, string CarNumber, string Owner, string Phone, string CarSize, Int32 CarVolume, string Schedule, string Notes)
		{
            string[] myPara = { "@ID", "@CarNumber", "@Owner", "@Phone", "@CarSize", "@CarVolume", "@Schedule", "@Notes" };
            object[] myValue = { ID, CarNumber, Owner, Phone, CarSize, CarVolume, Schedule, Notes };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction,sqlUpdate, myPara, myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery("DELETE FROM CARS WHERE ID = @ID", myPara, myValue);
		}
		public string Delete(string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery("DELETE FROM CARS WHERE ID = @ID", myPara, myValue);
		}
		public string Delete(SqlConnection myConnection,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();

            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myConnection, "DELETE FROM CARS WHERE ID = @ID", myPara, myValue);
		}
		public string Delete(SqlTransaction myTransaction,string ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction, "DELETE FROM CARS WHERE ID = @ID", myPara, myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(QGetList);
		}
		#endregion
		 
        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT * FROM CARS";
            }
        }
        #endregion

    }

   
}
