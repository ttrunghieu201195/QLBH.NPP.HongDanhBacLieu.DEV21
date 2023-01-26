using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using System.ComponentModel;
using System.Reflection;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : UNIT.
	/// Date: 1/13/2009
	/// Author: 
	/// </summary>
	public class UNIT
	{
		#region Init
		private string m_Unit_ID;
		private string m_Unit_Name;
		private string m_Description;
		private bool m_Active;
		public UNIT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Unit_ID="";
			 m_Unit_Name="";
			 m_Description="";
			 m_Active=true;
		}
		public UNIT(string Unit_ID,string Unit_Name,string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Unit_ID=Unit_ID;
			 m_Unit_Name=Unit_Name;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Unit_ID
		{
			get
			{
				return m_Unit_ID;
			}
			set
			{
				m_Unit_ID = value;
			}
		}
		public string Unit_Name
		{
			get
			{
				return m_Unit_Name;
			}
			set
			{
				m_Unit_Name = value;
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
				return "Class UNIT";
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
			return SqlHelper.GenCode("UNIT","UNITID","");
		}
        public string NewID(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "UNIT", "Unit_ID", "");
        }
		public Boolean Exist(string Unit_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("UNIT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

        public Boolean Exist(SqlTransaction myTransaction,string Unit_ID)
        {
            Boolean Result = false;
            string[] myPara = { "@Unit_ID" };
            object[] myValue = { Unit_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "UNIT_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();
            return Result;
        }

        public Boolean ExistByName(string Unit_Name)
        {
            Boolean Result = false;
            //string[] myPara = { "@Unit_Name" };
            //object[] myValue = { Unit_Name };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader("Select * from UNIT Where Unit_Name like N'%"+ Unit_Name+"%'");
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
                mySql.Close();
            }
            return Result;
        }

        public Boolean ExistByName(SqlTransaction myTransaction, string Unit_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Unit_Name" };
            object[] myValue = { Unit_Name };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader("Select * from UNIT Where Unit_Name like N'%" + Unit_Name + "%'", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            return Result;
        }


		public string Get(string Unit_ID)
		{
			string Result="";
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("UNIT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]);
						m_Unit_Name =Convert.ToString(myReader["Unit_Name"]);
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
		public string Get(SqlConnection myConnection,string Unit_ID)
		{
			string Result="";
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"UNIT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]);
						m_Unit_Name =Convert.ToString(myReader["Unit_Name"]);
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
		public string Get(SqlTransaction myTransaction,string Unit_ID)
		{
			string Result="";
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"UNIT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Unit_ID =Convert.ToString(myReader["Unit_ID"]);
						m_Unit_Name =Convert.ToString(myReader["Unit_Name"]);
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

        public string GetByName(SqlTransaction myTransaction, string Unit_Name)
        {
            string Result = "";
           // string[] myPara = { "@Unit_ID" };
          //  object[] myValue = { Unit_ID };
            var mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction,"Select * from UNIT Where Unit_Name like N'%"+ Unit_Name+"%'");
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Unit_ID = Convert.ToString(myReader["Unit_ID"]);
                    m_Unit_Name = Convert.ToString(myReader["Unit_Name"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                //mySql.Close();
               // myReader = null;
            }
            return Result;
        }

        public string GetByName( string Unit_Name)
        {
            string Result = "";
            // string[] myPara = { "@Unit_ID" };
            //  object[] myValue = { Unit_ID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader( "Select * from UNIT Where Unit_Name like N'%" + Unit_Name + "%'");
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Unit_ID = Convert.ToString(myReader["Unit_ID"]);
                    m_Unit_Name = Convert.ToString(myReader["Unit_Name"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                
                // myReader = null;
            }
            mySql.Close();
            return Result;
        }

        public string CheckUnitGetByNameWithProduct(SqlTransaction myTransaction, string unitID, string productID)
        {
            string Result = "";
            string[] myPara = { "@UnitID", "@ProductID" };
            object[] myValue = { unitID, productID };
            var mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            string sql = "SELECT TOP 1 u.*  \n"
           + "FROM UNIT u INNER JOIN PRODUCT p \n"
           + "ON u.Unit_ID = p.Unit \n"
           + "WHERE u.Unit_ID = @UnitID AND p.Product_ID = @ProductID";

            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, sql, myPara, myValue);

            if (myReader != null)
            {
                while (myReader.Read())
                {
                    //m_Unit_ID = Convert.ToString(myReader["Unit_ID"]);
                    //m_Unit_Name = Convert.ToString(myReader["Unit_Name"]);
                    //m_Description = Convert.ToString(myReader["Description"]);
                    //m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                //mySql.Close();
                // myReader = null;
            }
            return Result;
        }

		#endregion
		
		#region Add
		public string Insert()
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={m_Unit_ID,m_Unit_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("UNIT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={m_Unit_ID,m_Unit_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"UNIT_Insert",myPara,myValue);
		}
		public string Insert(string Unit_ID,string Unit_Name,string Description,bool Active)
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={Unit_ID,Unit_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("UNIT_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Unit_ID,string Unit_Name,string Description,bool Active)
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={Unit_ID,Unit_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"UNIT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Unit_ID,string Unit_Name,string Description,bool Active)
		{
		    m_Unit_ID = Unit_ID;
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={Unit_ID,Unit_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"UNIT_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={m_Unit_ID,m_Unit_Name,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("UNIT_Update",myPara,myValue);
		}
		public string Update(string Unit_ID,string Unit_Name,string Description,bool Active)
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={Unit_ID,Unit_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("UNIT_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Unit_ID,string Unit_Name,string Description,bool Active)
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={Unit_ID,Unit_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"UNIT_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Unit_ID,string Unit_Name,string Description,bool Active)
		{
			string[] myPara={"@Unit_ID","@Unit_Name","@Description","@Active"};
			object[] myValue={Unit_ID,Unit_Name,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"UNIT_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Unit_ID"};
			object[] myValue={m_Unit_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("UNIT_Delete",myPara,myValue);
		}
		public string Delete(string Unit_ID)
		{
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("UNIT_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Unit_ID)
		{
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"UNIT_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Unit_ID)
		{
			string[] myPara={"@Unit_ID"};
			object[] myValue={Unit_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"UNIT_Delete",myPara,myValue);
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
			MyLib.TableToComboBox(combo,GetList(), "UNIT_Name", "UNIT_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["UNIT_ID"] = "All";
			b["UNIT_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "UNIT_Name", "UNIT_ID");
		}
		#endregion

     ////   public static string GetStringValue(this Enum value)
     //   {
     //       // Get the type
     //       Type type = value.GetType();

     //       // Get fieldinfo for this type
     //       FieldInfo fieldInfo = type.GetField(value.ToString());

     //       // Get the stringvalue attributes
     //       StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
     //           typeof(StringValueAttribute), false) as StringValueAttribute[];

     //       // Return the first if there was a match.
     //       return attribs.Length > 0 ? attribs[0].StringValue : null;
     //   }

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT
	u.Unit_ID,
	u.Unit_Name,
	u.[Description],
	u.[Active],
	CAST(u.[Active] AS INT) AS [ActiveInt]
FROM
	UNIT u";
            }
        }
        #endregion


        public enum Fields
        {
            [DescriptionAttribute("Unit_ID")]
            Unit_ID,
            [DescriptionAttribute("Unit_Name")]
            Unit_Name,
            [DescriptionAttribute("Description")]
            Description,
            [DescriptionAttribute("Active")]
            Active,
        }
		
	}


    public class EnumUtils
    {
        public static string stringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public static object enumValueOf(string value, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                if (stringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }
    }

   

}
