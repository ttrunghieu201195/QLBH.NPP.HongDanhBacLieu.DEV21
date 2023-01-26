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
	public class CURRENCY
	{
		#region Init
		private string m_Currency_ID;
		private string m_CurrencyName;
		private double m_Exchange;
		private bool m_Active;
		public CURRENCY()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Currency_ID="";
			 m_CurrencyName="";
			 m_Exchange=0.0;
			 m_Active=true;
		}
		public CURRENCY(string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Currency_ID=Currency_ID;
			 m_CurrencyName=CurrencyName;
			 m_Exchange=Exchange;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		public string Currency_ID
		{
			get
			{
				return m_Currency_ID;
			}
			set
			{
				m_Currency_ID = value;
			}
		}
		public string CurrencyName
		{
			get
			{
				return m_CurrencyName;
			}
			set
			{
				m_CurrencyName = value;
			}
		}
		public double Exchange
		{
			get
			{
				return m_Exchange;
			}
			set
			{
				m_Exchange = value;
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
			return SqlHelper.GenCode("CURRENCY","CURRENCYID","");
		}
		public Boolean Exist(string Currency_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("CURRENCY_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Currency_ID)
		{
			string Result="";
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("CURRENCY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_CurrencyName =Convert.ToString(myReader["CurrencyName"]);
						m_Exchange =Convert.ToSingle(myReader["Exchange"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlConnection myConnection,string Currency_ID)
		{
			string Result="";
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CURRENCY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_CurrencyName =Convert.ToString(myReader["CurrencyName"]);
						m_Exchange =Convert.ToSingle(myReader["Exchange"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,string Currency_ID)
		{
			string Result="";
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CURRENCY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_CurrencyName =Convert.ToString(myReader["CurrencyName"]);
						m_Exchange =Convert.ToSingle(myReader["Exchange"]);
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
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={m_Currency_ID,m_CurrencyName,m_Exchange,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CURRENCY_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={m_Currency_ID,m_CurrencyName,m_Exchange,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CURRENCY_Insert",myPara,myValue);
		}
		public string Insert(string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={Currency_ID,CurrencyName,Exchange,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CURRENCY_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={Currency_ID,CurrencyName,Exchange,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CURRENCY_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={Currency_ID,CurrencyName,Exchange,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CURRENCY_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={m_Currency_ID,m_CurrencyName,m_Exchange,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CURRENCY_Update",myPara,myValue);
		}
		public string Update(string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={Currency_ID,CurrencyName,Exchange,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CURRENCY_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={Currency_ID,CurrencyName,Exchange,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CURRENCY_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Currency_ID,string CurrencyName,double Exchange,bool Active)
		{
			string[] myPara={"@Currency_ID","@CurrencyName","@Exchange","@Active"};
			object[] myValue={Currency_ID,CurrencyName,Exchange,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CURRENCY_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Currency_ID"};
			object[] myValue={m_Currency_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CURRENCY_Delete",myPara,myValue);
		}
		public string Delete(string Currency_ID)
		{
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CURRENCY_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Currency_ID)
		{
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CURRENCY_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Currency_ID)
		{
			string[] myPara={"@Currency_ID"};
			object[] myValue={Currency_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CURRENCY_Delete",myPara,myValue);
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
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
            MyLib.TableToComboBox(combo, GetList(),"Currency_ID", "Exchange");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["CURRENCYID"] = "All";
			b["CURRENCYName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "CURRENCYName", "CURRENCYID");
		}
		#endregion

        #region Query
        private string QGetList
        {
            get
            {
                return @"SELECT c.Currency_ID,
       c.CurrencyName,
       c.Exchange,
       c.[Active],
       CAST(c.[Active] AS  INT) AS [ActiveInt]
FROM   CURRENCY c";
            }
        }
        #endregion

    }

   
}
