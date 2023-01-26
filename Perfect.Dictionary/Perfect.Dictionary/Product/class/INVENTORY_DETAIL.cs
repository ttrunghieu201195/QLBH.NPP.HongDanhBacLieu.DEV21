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
	/// Generated Class for Table : INVENTORY_DETAIL.
	/// Date: 3/12/2009
	/// Author: 
	/// </summary>
	public class INVENTORY_DETAIL
	{
		#region Init
		private long m_ID;
		private string m_Detail_No;
		private string m_InventoryNo;
		private DateTime m_InventoryDate;
		private long m_Inventory_ID;
		private string m_Stock_ID;
		private string m_Product_ID;
		private string m_Customer_ID;
		private string m_Employee_ID;
		private string m_Batch;
		private int m_Action;
		private string m_Unit;
		private double m_UnitConvert;
		private double m_SalePrice;
		private double m_Discount;
		private double m_Charge;
		private double m_Quantity;
		private double m_ExchangeRate;
		private double m_UnitPrice;
		private double m_Amount;
		private double m_E_Qty;
		private double m_E_ExchangeRate;
		private double m_E_Unt;
		private double m_E_Amt;
		private string m_Description;
		public INVENTORY_DETAIL()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=0;
			 m_Detail_No=System.Guid.NewGuid().ToString();
			 m_InventoryNo="";
			 m_InventoryDate=DateTime.Now;
			 m_Inventory_ID=0;
			 m_Stock_ID="";
			 m_Product_ID="";
			 m_Customer_ID="";
			 m_Employee_ID="";
			 m_Batch="";
			 m_Action=0;
			 m_Unit="";
			 m_UnitConvert=0.0;
			 m_SalePrice=0.0;
			 m_Discount=0.0;
			 m_Charge=0.0;
			 m_Quantity=0.0;
			 m_ExchangeRate=0.0;
			 m_UnitPrice=0.0;
			 m_Amount=0.0;
			 m_E_Qty=0.0;
			 m_E_ExchangeRate=0.0;
			 m_E_Unt=0.0;
			 m_E_Amt=0.0;
			 m_Description="";
		}
		public INVENTORY_DETAIL(long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Detail_No=Detail_No;
			 m_InventoryNo=InventoryNo;
			 m_InventoryDate=InventoryDate;
			 m_Inventory_ID=Inventory_ID;
			 m_Stock_ID=Stock_ID;
			 m_Product_ID=Product_ID;
			 m_Customer_ID=Customer_ID;
			 m_Employee_ID=Employee_ID;
			 m_Batch=Batch;
			 m_Action=Action;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_SalePrice=SalePrice;
			 m_Discount=Discount;
			 m_Charge=Charge;
			 m_Quantity=Quantity;
			 m_ExchangeRate=ExchangeRate;
			 m_UnitPrice=UnitPrice;
			 m_Amount=Amount;
			 m_E_Qty=E_Qty;
			 m_E_ExchangeRate=E_ExchangeRate;
			 m_E_Unt=E_Unt;
			 m_E_Amt=E_Amt;
			 m_Description=Description;
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
		public string Detail_No
		{
			get
			{
				return m_Detail_No;
			}
			set
			{
				m_Detail_No = value;
			}
		}
		public string InventoryNo
		{
			get
			{
				return m_InventoryNo;
			}
			set
			{
				m_InventoryNo = value;
			}
		}
		public DateTime InventoryDate
		{
			get
			{
				return m_InventoryDate;
			}
			set
			{
				m_InventoryDate = value;
			}
		}
		public long Inventory_ID
		{
			get
			{
				return m_Inventory_ID;
			}
			set
			{
				m_Inventory_ID = value;
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
		public string Batch
		{
			get
			{
				return m_Batch;
			}
			set
			{
				m_Batch = value;
			}
		}
		public int Action
		{
			get
			{
				return m_Action;
			}
			set
			{
				m_Action = value;
			}
		}
		public string Unit
		{
			get
			{
				return m_Unit;
			}
			set
			{
				m_Unit = value;
			}
		}
		public double UnitConvert
		{
			get
			{
				return m_UnitConvert;
			}
			set
			{
				m_UnitConvert = value;
			}
		}
		public double SalePrice
		{
			get
			{
				return m_SalePrice;
			}
			set
			{
				m_SalePrice = value;
			}
		}
		public double Discount
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
		public double Charge
		{
			get
			{
				return m_Charge;
			}
			set
			{
				m_Charge = value;
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
		public double E_Qty
		{
			get
			{
				return m_E_Qty;
			}
			set
			{
				m_E_Qty = value;
			}
		}
		public double E_ExchangeRate
		{
			get
			{
				return m_E_ExchangeRate;
			}
			set
			{
				m_E_ExchangeRate = value;
			}
		}
		public double E_Unt
		{
			get
			{
				return m_E_Unt;
			}
			set
			{
				m_E_Unt = value;
			}
		}
		public double E_Amt
		{
			get
			{
				return m_E_Amt;
			}
			set
			{
				m_E_Amt = value;
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
				return "Class INVENTORY_DETAIL";
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
            return SqlHelper.GenCode("INVENTORY_DETAIL", "InventoryNo", "PKK");
		}
		public Boolean Exist(long ID)
		{
			Boolean Result=false;
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("INVENTORY_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader("INVENTORY_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Detail_No =Convert.ToString(myReader["Detail_No"]);
						m_InventoryNo =Convert.ToString(myReader["InventoryNo"]);
						m_InventoryDate =Convert.ToDateTime(myReader["InventoryDate"]);
						m_Inventory_ID =Convert.ToInt64(myReader["Inventory_ID"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Action =Convert.ToInt32(myReader["Action"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToSingle(myReader["UnitConvert"]);
						m_SalePrice =Convert.ToSingle(myReader["SalePrice"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Charge =Convert.ToSingle(myReader["Charge"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_UnitPrice =Convert.ToSingle(myReader["UnitPrice"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_E_Qty =Convert.ToSingle(myReader["E_Qty"]);
						m_E_ExchangeRate =Convert.ToSingle(myReader["E_ExchangeRate"]);
						m_E_Unt =Convert.ToSingle(myReader["E_Unt"]);
						m_E_Amt =Convert.ToSingle(myReader["E_Amt"]);
						m_Description =Convert.ToString(myReader["Description"]);
						Result="OK";
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"INVENTORY_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Detail_No =Convert.ToString(myReader["Detail_No"]);
						m_InventoryNo =Convert.ToString(myReader["InventoryNo"]);
						m_InventoryDate =Convert.ToDateTime(myReader["InventoryDate"]);
						m_Inventory_ID =Convert.ToInt64(myReader["Inventory_ID"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Action =Convert.ToInt32(myReader["Action"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToSingle(myReader["UnitConvert"]);
						m_SalePrice =Convert.ToSingle(myReader["SalePrice"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Charge =Convert.ToSingle(myReader["Charge"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_UnitPrice =Convert.ToSingle(myReader["UnitPrice"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_E_Qty =Convert.ToSingle(myReader["E_Qty"]);
						m_E_ExchangeRate =Convert.ToSingle(myReader["E_ExchangeRate"]);
						m_E_Unt =Convert.ToSingle(myReader["E_Unt"]);
						m_E_Amt =Convert.ToSingle(myReader["E_Amt"]);
						m_Description =Convert.ToString(myReader["Description"]);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"INVENTORY_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ID =Convert.ToInt64(myReader["ID"]);
						m_Detail_No =Convert.ToString(myReader["Detail_No"]);
						m_InventoryNo =Convert.ToString(myReader["InventoryNo"]);
						m_InventoryDate =Convert.ToDateTime(myReader["InventoryDate"]);
						m_Inventory_ID =Convert.ToInt64(myReader["Inventory_ID"]);
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Employee_ID =Convert.ToString(myReader["Employee_ID"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Action =Convert.ToInt32(myReader["Action"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToSingle(myReader["UnitConvert"]);
						m_SalePrice =Convert.ToSingle(myReader["SalePrice"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Charge =Convert.ToSingle(myReader["Charge"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_ExchangeRate =Convert.ToSingle(myReader["ExchangeRate"]);
						m_UnitPrice =Convert.ToSingle(myReader["UnitPrice"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						m_E_Qty =Convert.ToSingle(myReader["E_Qty"]);
						m_E_ExchangeRate =Convert.ToSingle(myReader["E_ExchangeRate"]);
						m_E_Unt =Convert.ToSingle(myReader["E_Unt"]);
						m_E_Amt =Convert.ToSingle(myReader["E_Amt"]);
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
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={m_ID,m_Detail_No,m_InventoryNo,m_InventoryDate,m_Inventory_ID,m_Stock_ID,m_Product_ID,m_Customer_ID,m_Employee_ID,m_Batch,m_Action,m_Unit,m_UnitConvert,m_SalePrice,m_Discount,m_Charge,m_Quantity,m_ExchangeRate,m_UnitPrice,m_Amount,m_E_Qty,m_E_ExchangeRate,m_E_Unt,m_E_Amt,m_Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_DETAIL_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={m_ID,m_Detail_No,m_InventoryNo,m_InventoryDate,m_Inventory_ID,m_Stock_ID,m_Product_ID,m_Customer_ID,m_Employee_ID,m_Batch,m_Action,m_Unit,m_UnitConvert,m_SalePrice,m_Discount,m_Charge,m_Quantity,m_ExchangeRate,m_UnitPrice,m_Amount,m_E_Qty,m_E_ExchangeRate,m_E_Unt,m_E_Amt,m_Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_DETAIL_Insert",myPara,myValue);
		}
		public string Insert(long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={ID,Detail_No,InventoryNo,InventoryDate,Inventory_ID,Stock_ID,Product_ID,Customer_ID,Employee_ID,Batch,Action,Unit,UnitConvert,SalePrice,Discount,Charge,Quantity,ExchangeRate,UnitPrice,Amount,E_Qty,E_ExchangeRate,E_Unt,E_Amt,Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_DETAIL_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={ID,Detail_No,InventoryNo,InventoryDate,Inventory_ID,Stock_ID,Product_ID,Customer_ID,Employee_ID,Batch,Action,Unit,UnitConvert,SalePrice,Discount,Charge,Quantity,ExchangeRate,UnitPrice,Amount,E_Qty,E_ExchangeRate,E_Unt,E_Amt,Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"INVENTORY_DETAIL_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={ID,Detail_No,InventoryNo,InventoryDate,Inventory_ID,Stock_ID,Product_ID,Customer_ID,Employee_ID,Batch,Action,Unit,UnitConvert,SalePrice,Discount,Charge,Quantity,ExchangeRate,UnitPrice,Amount,E_Qty,E_ExchangeRate,E_Unt,E_Amt,Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_DETAIL_Insert",myPara,myValue);
		}

        public string Insert_Build(SqlTransaction myTransaction, string Detail_No, string InventoryNo, string Product_ID, string Stock_ID, DateTime InventoryDate, string Unit, double UnitConvert, double SalePrice, double Quantity,  double Amount, string Description)
        {
            string[] myPara ={ "@Detail_ID", "@InventoryNo", "@Product_ID", "@Stock_ID", "@Date", "@Unit", "@UnitConvert", "@UnitPrice", "@Quantity", "@Amount", "@Description"};
            object[] myValue ={ Detail_No,InventoryNo,Product_ID,Stock_ID,InventoryDate,Unit,UnitConvert,SalePrice,Quantity,Amount,Description};
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteNonQuery(myTransaction, "INVENTORY_DETAIL_Insert_Build", myPara, myValue);
        }
        public string Insert_Trans_Build(SqlTransaction myTransaction, string Detail_No, string InventoryNo, string Product_ID, string Stock_ID, DateTime InventoryDate, string Unit, double UnitConvert, double SalePrice, double Quantity, double Amount, string Description)
        {
            string[] myPara ={ "@Detail_ID", "@InventoryNo", "@Product_ID", "@Stock_ID", "@Date", "@Unit", "@UnitConvert", "@UnitPrice", "@Quantity", "@Amount", "@Description" };
            object[] myValue ={ Detail_No, InventoryNo, Product_ID, Stock_ID, InventoryDate, Unit, UnitConvert, SalePrice, Quantity, Amount, Description };
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteNonQuery(myTransaction, "INVENTORY_DETAIL_Insert_Trans_Build", myPara, myValue);
        }
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={m_ID,m_Detail_No,m_InventoryNo,m_InventoryDate,m_Inventory_ID,m_Stock_ID,m_Product_ID,m_Customer_ID,m_Employee_ID,m_Batch,m_Action,m_Unit,m_UnitConvert,m_SalePrice,m_Discount,m_Charge,m_Quantity,m_ExchangeRate,m_UnitPrice,m_Amount,m_E_Qty,m_E_ExchangeRate,m_E_Unt,m_E_Amt,m_Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_DETAIL_Update",myPara,myValue);
		}
		public string Update(long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={ID,Detail_No,InventoryNo,InventoryDate,Inventory_ID,Stock_ID,Product_ID,Customer_ID,Employee_ID,Batch,Action,Unit,UnitConvert,SalePrice,Discount,Charge,Quantity,ExchangeRate,UnitPrice,Amount,E_Qty,E_ExchangeRate,E_Unt,E_Amt,Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_DETAIL_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={ID,Detail_No,InventoryNo,InventoryDate,Inventory_ID,Stock_ID,Product_ID,Customer_ID,Employee_ID,Batch,Action,Unit,UnitConvert,SalePrice,Discount,Charge,Quantity,ExchangeRate,UnitPrice,Amount,E_Qty,E_ExchangeRate,E_Unt,E_Amt,Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"INVENTORY_DETAIL_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,long ID,string Detail_No,string InventoryNo,DateTime InventoryDate,long Inventory_ID,string Stock_ID,string Product_ID,string Customer_ID,string Employee_ID,string Batch,int Action,string Unit,double UnitConvert,double SalePrice,double Discount,double Charge,double Quantity,double ExchangeRate,double UnitPrice,double Amount,double E_Qty,double E_ExchangeRate,double E_Unt,double E_Amt,string Description)
		{
			string[] myPara={"@ID","@Detail_No","@InventoryNo","@InventoryDate","@Inventory_ID","@Stock_ID","@Product_ID","@Customer_ID","@Employee_ID","@Batch","@Action","@Unit","@UnitConvert","@SalePrice","@Discount","@Charge","@Quantity","@ExchangeRate","@UnitPrice","@Amount","@E_Qty","@E_ExchangeRate","@E_Unt","@E_Amt","@Description"};
			object[] myValue={ID,Detail_No,InventoryNo,InventoryDate,Inventory_ID,Stock_ID,Product_ID,Customer_ID,Employee_ID,Batch,Action,Unit,UnitConvert,SalePrice,Discount,Charge,Quantity,ExchangeRate,UnitPrice,Amount,E_Qty,E_ExchangeRate,E_Unt,E_Amt,Description};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_DETAIL_Update",myPara,myValue);
		}
        public string Update_Build(SqlTransaction myTransaction,string InventoryNo,string Product_ID,string Stock_ID,DateTime Date,string Unit, double UnitConvert,double UnitPrice,double Quantity,double Amount,string Description)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@InventoryNo", "@Product_ID", "@Stock_ID", "@Date", "@Unit", "@UnitConvert", "@UnitPrice", "@Quantity", "@Amount", "@Description" };
            object[] myValue ={InventoryNo,Product_ID,Stock_ID,Date,Unit,UnitConvert,UnitPrice,Quantity,Amount,Description };
            return mysql.ExecuteNonQuery(myTransaction, "INVENTORY_DETAIL_Update_Build", myPara, myValue);
        }

		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ID"};
			object[] myValue={m_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_DETAIL_Delete",myPara,myValue);
		}
		public string Delete(long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("INVENTORY_DETAIL_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"INVENTORY_DETAIL_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,long ID)
		{
			string[] myPara={"@ID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"INVENTORY_DETAIL_Delete",myPara,myValue);
		}

        public string Delete_Build(SqlTransaction myTransaction,string ID)
        {
            string[] myPara ={"@ID" };
            object[] myValue ={ID };
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteNonQuery(myTransaction, "INVENTORY_DETAIL_Delete_Build", myPara, myValue);
        }
        public string Delete_Tran_Build(SqlTransaction myTransaction, int ID)
        {
            string[] myPara ={ "@ID" };
            object[] myValue ={ ID };
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteNonQuery(myTransaction, "INVENTORY_DETAIL_Delete_Trans_Build", myPara, myValue);
        }
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("INVENTORY_DETAIL_GetList");
		}

        public static double LimitRecord
        {
            get { return 1000; }
        }
        
        public static double Count
        {
            get
            {
                SqlHelper mySql = new SqlHelper();
                mySql.CommandType = CommandType.Text;
                return mySql.ExecuteScalar("SELECT COUNT(id.ID) FROM INVENTORY_DETAIL id WHERE id.RefType != 0", 0.0);
                //return mySql.ExecuteScalar("Select Count(*) from INVENTORY_DETAIL", 0.0);
            }
            
        }
	
		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "INVENTORY_DETAILName", "INVENTORY_DETAILID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["INVENTORY_DETAILID"] = "All";
			b["INVENTORY_DETAILName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "INVENTORY_DETAILName", "INVENTORY_DETAILID");
		}
		#endregion

        #region Report

        public DataTable Report_StockCard(DateTime FromDate,DateTime ToDate,string Stock_ID,string Product_ID )
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("REPORT_STOCK_CARD", myPara, myValue);
        }
        public DataTable Summary(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_Summary", myPara, myValue);
        }
        public DataTable SummaryNoTransfer(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_SummaryNoTransfer", myPara, myValue);
        }
        public DataTable SummaryTranIn(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_TongHopNhapLuanChuyen", myPara, myValue);
        }
        public DataTable SummaryTranOut(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_TongHopXuatLuanChuyen", myPara, myValue);
        }
        public DataTable Report_InventoryLedger(DateTime FromDate, DateTime ToDate,string Stock_ID,string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue ={ FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_InventoryLedger", myPara, myValue);
        }
        public DataTable Report_InventoryQuantityNoTransfer(DateTime FromDate, DateTime ToDate,string Stock_ID,string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue ={ FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_InventoryQuantityNoTransfer", myPara, myValue);
        }
        public DataTable Report_InventoryQuantity(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_InventoryQuantity", myPara, myValue);
        }
        public DataTable Report_InventorySummaryNoTransfer(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue ={ FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_InventorySummaryNoTransfer", myPara, myValue);
        }
        public DataTable Report_InventorySummary(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue = { FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("Report_InventorySummary", myPara, myValue);
        }
        public DataTable Report_StockCardDN(DateTime FromDate, DateTime ToDate, string Stock_ID, string Product_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@FromDate", "@ToDate", "@Stock_ID", "@Product_ID" };
            object[] myValue ={ FromDate, ToDate, Stock_ID, Product_ID };
            return mysql.ExecuteDataTable("REPORT_STOCK_CARD_DN", myPara, myValue);
        }
        #endregion
    }
}
