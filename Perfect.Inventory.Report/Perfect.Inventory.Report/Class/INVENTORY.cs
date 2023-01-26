using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using Perfect.Inventory;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : INVENTORY.
	/// Date: 4/21/2009
	/// Author: 
	/// </summary>
	public class INVENTORYS
	{
		#region Init
		private long m_ID;
		private DateTime m_Stock_Date;
		private string m_Stock_ID;
		private string m_Product_ID;
		private string m_ProductName;
		private string m_Customer_ID;
		private string m_Currency_ID;
		private double m_Quantity;
		private double m_ExchangeRate;
		private double m_UnitPrice;
		private double m_Amount;
		private string m_Bacth;
		private int m_Lock;
		public INVENTORYS()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=0;
			 m_Stock_Date=DateTime.Now;
			 m_Stock_ID="";
			 m_Product_ID="";
			 m_ProductName="";
			 m_Customer_ID="";
			 m_Currency_ID="";
			 m_Quantity=0.0;
			 m_ExchangeRate=0.0;
			 m_UnitPrice=0.0;
			 m_Amount=0.0;
			 m_Bacth="";
			 m_Lock=0;
		}
		public INVENTORYS(long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Stock_Date=Stock_Date;
			 m_Stock_ID=Stock_ID;
			 m_Product_ID=Product_ID;
			 m_ProductName=ProductName;
			 m_Customer_ID=Customer_ID;
			 m_Currency_ID=Currency_ID;
			 m_Quantity=Quantity;
			 m_ExchangeRate=ExchangeRate;
			 m_UnitPrice=UnitPrice;
			 m_Amount=Amount;
			 m_Bacth=Bacth;
			 m_Lock=Lock;
		}
		#endregion
		
		#region Property
		public long ID
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
		public DateTime Stock_Date
		{
			get
			{
				return m_Stock_Date;
			}
			set
			{
				m_Stock_Date = value;
			}
		}
		public string Stock_ID
		{
			get
			{
				return m_Stock_ID;
			}
			set
			{
				m_Stock_ID = value;
			}
		}
		public string Product_ID
		{
			get
			{
				return m_Product_ID;
			}
			set
			{
				m_Product_ID = value;
			}
		}
		public string ProductName
		{
			get
			{
				return m_ProductName;
			}
			set
			{
				m_ProductName = value;
			}
		}
		public string Customer_ID
		{
			get
			{
				return m_Customer_ID;
			}
			set
			{
				m_Customer_ID = value;
			}
		}
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
		public double Quantity
		{
			get
			{
				return m_Quantity;
			}
			set
			{
				m_Quantity = value;
			}
		}
		public double ExchangeRate
		{
			get
			{
				return m_ExchangeRate;
			}
			set
			{
				m_ExchangeRate = value;
			}
		}
		public double UnitPrice
		{
			get
			{
				return m_UnitPrice;
			}
			set
			{
				m_UnitPrice = value;
			}
		}
		public double Amount
		{
			get
			{
				return m_Amount;
			}
			set
			{
				m_Amount = value;
			}
		}
		public string Bacth
		{
			get
			{
				return m_Bacth;
			}
			set
			{
				m_Bacth = value;
			}
		}
		public int Lock
		{
			get
			{
				return m_Lock;
			}
			set
			{
				m_Lock = value;
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
			return SqlHelper.GenCode("INVENTORY","INVENTORYID","");
		}

		public Boolean Exist(long ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("INVENTORY_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public string Get(long ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("INVENTORY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Stock_Date =Convert.ToDateTime(myReader["Stock_Date"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_ProductName =Convert.ToString(myReader["ProductName"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_UnitPrice =Convert.ToSingle(myReader["UnitPrice"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_Bacth =Convert.ToString(myReader["Batch"]);
						m_Lock =Convert.ToInt32(myReader["Lock"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

        public string Get(string Stock_ID,string Product_ID)
        {
            string Result = "";
            string[] myPara ={ "@Stock_ID", "@Product_ID" };
            object[] myValue ={ Stock_ID, Product_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("INVENTORY_Get_By_Stock", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {                   
                    
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_ProductName = Convert.ToString(myReader["Product_Name"]);                                        
                    m_Quantity = Convert.ToSingle(myReader["Quantity"]);
                    m_ExchangeRate = Convert.ToSingle(myReader["ExchangeRate"] == DBNull.Value ? 1 : myReader["ExchangeRate"]);
                    m_UnitPrice = Convert.ToSingle(myReader["UnitPrice"]);
                    m_Amount = Convert.ToSingle(myReader["Amount"]);
                    m_Bacth = Convert.ToString(myReader["Batch"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

		public string Get(SqlConnection myConnection,long ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"INVENTORY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Stock_Date =Convert.ToDateTime(myReader["Stock_Date"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_ProductName =Convert.ToString(myReader["ProductName"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_UnitPrice =Convert.ToSingle(myReader["UnitPrice"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_Bacth =Convert.ToString(myReader["Bacth"]);
						m_Lock =Convert.ToInt32(myReader["Lock"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,long ID)
		{
			string Result="";
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"INVENTORY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Stock_Date =Convert.ToDateTime(myReader["Stock_Date"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_ProductName =Convert.ToString(myReader["ProductName"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Currency_ID =Convert.ToString(myReader["Currency_ID"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_UnitPrice =Convert.ToSingle(myReader["UnitPrice"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_Bacth =Convert.ToString(myReader["Bacth"]);
						m_Lock =Convert.ToInt32(myReader["Lock"]);
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
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={m_ID,m_Stock_Date,m_Stock_ID,m_Product_ID,m_ProductName,m_Customer_ID,m_Currency_ID,m_Quantity,m_ExchangeRate,m_UnitPrice,m_Amount,m_Bacth,m_Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={m_ID,m_Stock_Date,m_Stock_ID,m_Product_ID,m_ProductName,m_Customer_ID,m_Currency_ID,m_Quantity,m_ExchangeRate,m_UnitPrice,m_Amount,m_Bacth,m_Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_Insert",myPara,myValue);
		}
		public string Insert(long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={ID,Stock_Date,Stock_ID,Product_ID,ProductName,Customer_ID,Currency_ID,Quantity,ExchangeRate,UnitPrice,Amount,Bacth,Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={ID,Stock_Date,Stock_ID,Product_ID,ProductName,Customer_ID,Currency_ID,Quantity,ExchangeRate,UnitPrice,Amount,Bacth,Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"INVENTORY_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={ID,Stock_Date,Stock_ID,Product_ID,ProductName,Customer_ID,Currency_ID,Quantity,ExchangeRate,UnitPrice,Amount,Bacth,Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={m_ID,m_Stock_Date,m_Stock_ID,m_Product_ID,m_ProductName,m_Customer_ID,m_Currency_ID,m_Quantity,m_ExchangeRate,m_UnitPrice,m_Amount,m_Bacth,m_Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_Update",myPara,myValue);
		}
		public string Update(long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={ID,Stock_Date,Stock_ID,Product_ID,ProductName,Customer_ID,Currency_ID,Quantity,ExchangeRate,UnitPrice,Amount,Bacth,Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={ID,Stock_Date,Stock_ID,Product_ID,ProductName,Customer_ID,Currency_ID,Quantity,ExchangeRate,UnitPrice,Amount,Bacth,Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"INVENTORY_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,long ID,DateTime Stock_Date,string Stock_ID,string Product_ID,string ProductName,string Customer_ID,string Currency_ID,double Quantity,double ExchangeRate,double UnitPrice,double Amount,string Bacth,int Lock)
		{
			string[] myPara={"@ID","@Stock_Date","@Stock_ID","@Product_ID","@ProductName","@Customer_ID","@Currency_ID","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@Bacth","@Lock"};
			object[] myValue={ID,Stock_Date,Stock_ID,Product_ID,ProductName,Customer_ID,Currency_ID,Quantity,ExchangeRate,UnitPrice,Amount,Bacth,Lock};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_Delete",myPara,myValue);
		}
		public string Delete(long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"INVENTORY_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("INVENTORY_GetList");
		}

        public DataTable GetList(string Stock_ID, string Product_Id, string productName, bool Zero)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", "@Product_Name", "@Zero" };
            object[] myValue ={ Stock_ID,"%"+ Product_Id + "%","%"+ productName +"%", Zero };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_GetFull",myPara,myValue);
        }
        public DataTable Search(string Product_ID, string productName,string StockID)
        {
            string[] myPara ={ "@Product_ID", "@Product_Name","@Stock_ID" };
            object[] myValue ={ "%" + Product_ID + "%", "%" + productName + "%",StockID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_Search", myPara, myValue);
        }
        public DataTable SearchStock(string Product_ID, string productName,string stockId)
        {
            string[] myPara ={ "@Product_ID", "@Product_Name","@Stock_ID" };
            object[] myValue ={ "%" + Product_ID + "%", "%" + productName + "%",stockId };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_Search_Stock", myPara, myValue);
        }
        public double GetQuantityStock(string Stock_ID, string Product_ID)
        {
            SqlHelper data = new SqlHelper();
            string[] myPara = { "@Stock_ID", "@Product_ID" };
            object[] myValue = { Stock_ID, Product_ID };
            return data.ExecuteScalar("INVENTORY_GetQuantityStock", myPara, myValue, 0);
        }
		
		 public DataTable Summary(string Stock_ID, string Product_Id)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", };
            object[] myValue ={ Stock_ID,  Product_Id};
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_SUMMARYREPORT", myPara, myValue);
        }       
      

        public DataTable SummaryOver(string Stock_ID, string Product_Id)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", };
            object[] myValue ={ Stock_ID, Product_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_SUMMARYREPORT", myPara, myValue);
        }

        public DataTable SummaryBelower(string Stock_ID, string Product_Id)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", };
            object[] myValue ={ Stock_ID, Product_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_SUMMARY_BELOWER_REPORT", myPara, myValue);
        }

        public DataTable Detail(string Stock_ID, string Product_Id)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", };
            object[] myValue ={ Stock_ID, Product_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_DETAILREPORT", myPara, myValue);
        }

        public DataTable DetailOverLimit(string Stock_ID, string Product_Id,DateTime m_Now)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", "@Now" };
            object[] myValue ={ Stock_ID, Product_Id, m_Now };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_DETAIL_ORVERLIMIT_REPORT", myPara, myValue);
        }

        public DataTable DetailOverStored(string Stock_ID, string Product_Id,DateTime m_Now)
        {
            string[] myPara ={ "@Stock_ID", "@Product_Id", "@Now" };
            object[] myValue ={ Stock_ID, Product_Id, m_Now };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_DETAIL_OLDSTORED_REPORT", myPara, myValue);
        }

        public DataTable Order(string Product_ID, string productName, string stockId)
        {
            string[] myPara = { "@Product_ID", "@Product_Name", "@Stock_ID" };
            object[] myValue = { "%" + Product_ID + "%", "%" + productName + "%", stockId };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_ORDER", myPara, myValue);
        }


        public DataTable SummaryLimit(DateTime vFrom,DateTime vTo,string Stock_Id,string Product_ID,string Product_Name)
        {
            string[] myPara = { "@FromDate","@ToDate","@Product_ID", "@Product_Name", "@Stock_ID" };
            object[] myValue = { vFrom, vTo, "%" + Product_ID + "%", "%" + Product_Name + "%", Stock_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("Report_Summary", myPara, myValue);
        }

        public DataTable GetListDate(DateTime FromDate, DateTime ToDate, string CustomerId, string ProviderID, string OutStock, string InStock, string ProductId, string ProductName, string Id)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@CustomerID", "@ProviderID", "@OutStock", "@InStock", "@ProductId", "@ProductName", "@ID" };
            object[] myValue = { FromDate, ToDate, CustomerId, ProviderID, OutStock, InStock, "%" + ProductId + "%", "%" + ProductName + "%", "%" + Id + "%" };
            return mysql.ExecuteDataTable("Search", myPara, myValue);
        }

        public DataTable GetListDateAll(DateTime FromDate, DateTime ToDate, string CustomerId, string ProviderID, string OutStock, string InStock, string ProductId, string ProductName, string Id)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@CustomerID", "@ProviderID", "@OutStock", "@InStock", "@ProductId", "@ProductName", "@ID" };
            object[] myValue = { FromDate, ToDate, CustomerId, ProviderID, OutStock, InStock, "%" + ProductId + "%", "%" + ProductName + "%", "%" + Id + "%" };
            return mysql.ExecuteDataTable("SearchAll", myPara, myValue);
        }
        public DataTable InwardReportDate(DateTime FromDate, DateTime ToDate, string Stock, string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID", "@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock, Product };
            return mysql.ExecuteDataTable("STOCK_INWARD_DETAIL_ReportDate", myPara, myValue);
        }
        public DataTable OutwardReportDate(DateTime FromDate, DateTime ToDate, string Stock, string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID", "@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock, Product };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_ReportDate", myPara, myValue);
        }
        public DataTable AdjustReportDate(DateTime FromDate, DateTime ToDate, string Stock, string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID", "@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock, Product };
            return mysql.ExecuteDataTable("ADJUSTMENT_DETAIL_ReportDate", myPara, myValue);
        }
        public DataTable TransferReportDate(DateTime FromDate, DateTime ToDate, string Stock, string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID", "@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock, Product };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_ReportDate", myPara, myValue);
        }
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "INVENTORYName", "INVENTORYID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["INVENTORYID"] = "All";
			b["INVENTORYName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "INVENTORYName", "INVENTORYID");
		}
		#endregion
		
	}
}
