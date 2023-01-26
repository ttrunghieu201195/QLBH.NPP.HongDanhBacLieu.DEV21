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
	public class STOCK_OUTWARD_DETAIL:Object
	{
		#region Init
		private string m_ID;
		private string m_Outward_ID;
		private string m_Stock_ID;
		private int m_RefType;
		private string m_Product_ID;
		private string m_ProductName;
		private int m_Vat;
	    private decimal m_VatAmount;
        //private decimal m_Lev1;
        //private decimal m_Lev2;
        //private decimal m_Lev3;
        //private decimal m_Lev4;
		private string m_Unit;
		private decimal m_UnitConvert;
		private decimal m_CurrentQty;
		private decimal m_Quantity;
		private decimal m_UnitPrice;
		private decimal m_Amount;
		private decimal m_QtyConvert;
	    private decimal m_DiscountRate;
		private decimal m_Discount;
		private decimal m_Charge;
		private decimal m_Cost;
		private decimal m_Profit;
		private string m_Batch;
		private string m_Serial;
		private string m_ChassyNo;
		private string m_IME;
		private decimal m_Width;
		private decimal m_Height;
		private string m_Orgin;
		private string m_Size;
		private long m_StoreID;
		private string m_Description;
		private long m_Sorted;
		private bool m_Active;
		
		
		public STOCK_OUTWARD_DETAIL()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_Outward_ID="";
			 m_Stock_ID="";
			 m_RefType=0;
			 m_Product_ID="";
			 m_ProductName="";
			 m_Vat=0;
		    m_VatAmount = 0;
             //m_Lev1=0;
             //m_Lev2=0;
             //m_Lev3=0;
             //m_Lev4=0;
			 m_Unit="";
			 m_UnitConvert=0;
			 m_CurrentQty=0;
			 m_Quantity=0;
			 m_UnitPrice=0;
			 m_Amount=0;
			 m_QtyConvert=0;
		    m_DiscountRate = 0;
			 m_Discount=0;
			 m_Charge=0;
			 m_Cost=0;
			 m_Profit=0;
			 m_Batch="";
			 m_Serial="";
			 m_ChassyNo="";
			 m_IME="";
			 m_Width=0;
			 m_Height=0;
			 m_Orgin="";
			 m_Size="";
			 m_StoreID=0;
			 m_Description="";
			 m_Sorted=0;
			 m_Active=true;
		}
		public STOCK_OUTWARD_DETAIL(
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Outward_ID=Outward_ID;
			 m_Stock_ID=Stock_ID;
			 m_RefType=RefType;
			 m_Product_ID=Product_ID;
			 m_ProductName=ProductName;
			 m_Vat=Vat;
             //m_Lev1=Lev1;
             //m_Lev2=Lev2;
             //m_Lev3=Lev3;
             //m_Lev4=Lev4;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_CurrentQty=CurrentQty;
			 m_Quantity=Quantity;
			 m_UnitPrice=UnitPrice;
			 m_Amount=Amount;
			 m_QtyConvert=QtyConvert;
			 m_Discount=Discount;
			 m_Charge=Charge;
			 m_Cost=Cost;
			 m_Profit=Profit;
			 m_Batch=Batch;
			 m_Serial=Serial;
			 m_ChassyNo=ChassyNo;
			 m_IME=IME;
			 m_Width=Width;
			 m_Height=Height;
			 m_Orgin=Orgin;
			 m_Size=Size;
			 m_StoreID=StoreID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Outward_ID=Outward_ID;
			 m_Stock_ID=Stock_ID;
			 m_RefType=RefType;
			 m_Product_ID=Product_ID;
			 m_ProductName=ProductName;
			 m_Vat=Vat;
             //m_Lev1=Lev1;
             //m_Lev2=Lev2;
             //m_Lev3=Lev3;
             //m_Lev4=Lev4;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_CurrentQty=CurrentQty;
			 m_Quantity=Quantity;
			 m_UnitPrice=UnitPrice;
			 m_Amount=Amount;
			 m_QtyConvert=QtyConvert;
			 m_Discount=Discount;
			 m_Charge=Charge;
			 m_Cost=Cost;
			 m_Profit=Profit;
			 m_Batch=Batch;
			 m_Serial=Serial;
			 m_ChassyNo=ChassyNo;
			 m_IME=IME;
			 m_Width=Width;
			 m_Height=Height;
			 m_Orgin=Orgin;
			 m_Size=Size;
			 m_StoreID=StoreID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
		[DisplayName("ID")]
		[Category("Primary Key")]
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
		[DisplayName("Outward_ID")]
		[Category("Column")]
		public string Outward_ID
		{
			get
			{
				return m_Outward_ID;
			}
			set
			{
				m_Outward_ID = value;
			}
		}
		[DisplayName("Stock_ID")]
		[Category("Column")]
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
		[DisplayName("RefType")]
		[Category("Column")]
		public int RefType
		{
			get
			{
				return m_RefType;
			}
			set
			{
				m_RefType = value;
			}
		}
		[DisplayName("Product_ID")]
		[Category("Column")]
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
		[DisplayName("ProductName")]
		[Category("Column")]
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
		[DisplayName("Vat")]
		[Category("Column")]
		public int Vat
		{
			get
			{
				return m_Vat;
			}
			set
			{
				m_Vat = value;
			}
		}


		[DisplayName("Unit")]
		[Category("Column")]
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
		[DisplayName("UnitConvert")]
		[Category("Column")]
		public decimal UnitConvert
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
		[DisplayName("CurrentQty")]
		[Category("Column")]
		public decimal CurrentQty
		{
			get
			{
				return m_CurrentQty;
			}
			set
			{
				m_CurrentQty = value;
			}
		}
		[DisplayName("Quantity")]
		[Category("Column")]
		public decimal Quantity
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
		[DisplayName("UnitPrice")]
		[Category("Column")]
		public decimal UnitPrice
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
		[DisplayName("Amount")]
		[Category("Column")]
		public decimal Amount
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
		[DisplayName("QtyConvert")]
		[Category("Column")]
		public decimal QtyConvert
		{
			get
			{
				return m_QtyConvert;
			}
			set
			{
				m_QtyConvert = value;
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
		[DisplayName("Charge")]
		[Category("Column")]
		public decimal Charge
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
		[DisplayName("Cost")]
		[Category("Column")]
		public decimal Cost
		{
			get
			{
				return m_Cost;
			}
			set
			{
				m_Cost = value;
			}
		}
		[DisplayName("Profit")]
		[Category("Column")]
		public decimal Profit
		{
			get
			{
				return m_Profit;
			}
			set
			{
				m_Profit = value;
			}
		}
		[DisplayName("Batch")]
		[Category("Column")]
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
		[DisplayName("Serial")]
		[Category("Column")]
		public string Serial
		{
			get
			{
				return m_Serial;
			}
			set
			{
				m_Serial = value;
			}
		}
		[DisplayName("ChassyNo")]
		[Category("Column")]
		public string ChassyNo
		{
			get
			{
				return m_ChassyNo;
			}
			set
			{
				m_ChassyNo = value;
			}
		}
		[DisplayName("IME")]
		[Category("Column")]
		public string IME
		{
			get
			{
				return m_IME;
			}
			set
			{
				m_IME = value;
			}
		}
		[DisplayName("Width")]
		[Category("Column")]
		public decimal Width
		{
			get
			{
				return m_Width;
			}
			set
			{
				m_Width = value;
			}
		}
		[DisplayName("Height")]
		[Category("Column")]
		public decimal Height
		{
			get
			{
				return m_Height;
			}
			set
			{
				m_Height = value;
			}
		}
		[DisplayName("Orgin")]
		[Category("Column")]
		public string Orgin
		{
			get
			{
				return m_Orgin;
			}
			set
			{
				m_Orgin = value;
			}
		}
		[DisplayName("Size")]
		[Category("Column")]
		public string Size
		{
			get
			{
				return m_Size;
			}
			set
			{
				m_Size = value;
			}
		}
		[DisplayName("StoreID")]
		[Category("Column")]
		public long StoreID
		{
			get
			{
				return m_StoreID;
			}
			set
			{
				m_StoreID = value;
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
				return "Class STOCK_OUTWARD_DETAIL";
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
			return NewID("");
		}

		public string NewID(string key)
		{
			return SqlHelper.GenCode("STOCK_OUTWARD_DETAIL","STOCK_OUTWARD_DETAILID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"STOCK_OUTWARD_DETAIL","STOCK_OUTWARD_DETAILID",key);
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
			m_ID);
		}

		public bool Exist(
			SqlTransaction myTransaction)
		{
			return Exist(
			myTransaction,
			m_ID);
		}

		public bool Exist(
			string ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Exist(
			mySql.Connection,
			ID))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool Exist(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_OUTWARD_DETAIL_Get",myPara,myValue);
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
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_OUTWARD_DETAIL_Get",myPara,myValue);
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
			m_ID);
		}

		public bool Get(SqlConnection myConnection)
		{
			return Get(myConnection,
			m_ID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			m_ID);
		}

		public bool Get(
			string ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Get(
			mySql.Connection,
			ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Get(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_OUTWARD_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						
						if (!myReader.IsDBNull(myReader.GetOrdinal("ID")))
						{
							m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						}
						m_Outward_ID =Convert.ToString(myReader["Outward_ID"]==DBNull.Value?"":myReader["Outward_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_Vat =Convert.ToInt32(myReader["Vat"]==DBNull.Value?0:myReader["Vat"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]==DBNull.Value?0:myReader["CurrentQty"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Cost =Convert.ToDecimal(myReader["Cost"]==DBNull.Value?0:myReader["Cost"] );
						m_Profit =Convert.ToDecimal(myReader["Profit"]==DBNull.Value?0:myReader["Profit"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]==DBNull.Value?"":myReader["ChassyNo"] );
						m_IME =Convert.ToString(myReader["IME"]==DBNull.Value?"":myReader["IME"] );
						m_Width =Convert.ToDecimal(myReader["Width"]==DBNull.Value?0:myReader["Width"] );
						m_Height =Convert.ToDecimal(myReader["Height"]==DBNull.Value?0:myReader["Height"] );
						m_Orgin =Convert.ToString(myReader["Orgin"]==DBNull.Value?"":myReader["Orgin"] );
						m_Size =Convert.ToString(myReader["Size"]==DBNull.Value?"":myReader["Size"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );

                        Result =true;
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
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			var mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_OUTWARD_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						
						if (!myReader.IsDBNull(myReader.GetOrdinal("ID")))
						{
							m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						}
						m_Outward_ID =Convert.ToString(myReader["Outward_ID"]==DBNull.Value?"":myReader["Outward_ID"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_Vat =Convert.ToInt32(myReader["Vat"]==DBNull.Value?0:myReader["Vat"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]==DBNull.Value?0:myReader["CurrentQty"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Cost =Convert.ToDecimal(myReader["Cost"]==DBNull.Value?0:myReader["Cost"] );
						m_Profit =Convert.ToDecimal(myReader["Profit"]==DBNull.Value?0:myReader["Profit"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]==DBNull.Value?"":myReader["ChassyNo"] );
						m_IME =Convert.ToString(myReader["IME"]==DBNull.Value?"":myReader["IME"] );
						m_Width =Convert.ToDecimal(myReader["Width"]==DBNull.Value?0:myReader["Width"] );
						m_Height =Convert.ToDecimal(myReader["Height"]==DBNull.Value?0:myReader["Height"] );
						m_Orgin =Convert.ToString(myReader["Orgin"]==DBNull.Value?"":myReader["Orgin"] );
						m_Size =Convert.ToString(myReader["Size"]==DBNull.Value?"":myReader["Size"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );

                        Result =true;
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
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            m_VatAmount,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
            m_DiscountRate,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            m_VatAmount,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
            m_DiscountRate,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            m_VatAmount,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
            m_DiscountRate,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            decimal VatAmount,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
            decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            VatAmount,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
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
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            decimal  VatAmount,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
            decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@Outward_ID",
			"@Stock_ID",
			"@RefType",
			"@Product_ID",
			"@ProductName",
			"@Vat",
            "@VatAmount",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
            "@DiscountRate",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            VatAmount,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
			Description,
			Sorted,
			Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_OUTWARD_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            decimal VatAmount,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
            decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@Outward_ID",
			"@Stock_ID",
			"@RefType",
			"@Product_ID",
			"@ProductName",
			"@Vat",
            "@VatAmount",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
            "@DiscountRate",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            VatAmount,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
			Description,
			Sorted,
			Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_OUTWARD_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            m_VatAmount,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
            m_DiscountRate,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            m_VatAmount,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
            m_DiscountRate,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            m_VatAmount,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
            m_DiscountRate,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            decimal VatAmount,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
            decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            VatAmount,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
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
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            decimal VatAmount,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
            decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@Outward_ID",
			"@Stock_ID",
			"@RefType",
			"@Product_ID",
			"@ProductName",
			"@Vat",
            "@VatAmount",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
            "@DiscountRate",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            VatAmount,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
			Description,
			Sorted,
			Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_OUTWARD_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            decimal VatAmount,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
            decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@Outward_ID",
			"@Stock_ID",
			"@RefType",
			"@Product_ID",
			"@ProductName",
			"@Vat",
            "@VatAmount",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
            "@DiscountRate",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={ID,Outward_ID,Stock_ID,RefType,Product_ID,ProductName,Vat,VatAmount,
                                 //Lev1,Lev2,Lev3,Lev4,
                                 Unit,UnitConvert,CurrentQty,Quantity,UnitPrice,Amount,QtyConvert,DiscountRate,Discount,Charge,Cost,Profit,Batch,Serial,ChassyNo,IME,Width,Height,Orgin,Size,StoreID,Description,Sorted,Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_OUTWARD_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_ID,
			m_Outward_ID,
			m_Stock_ID,
			m_RefType,
			m_Product_ID,
			m_ProductName,
			m_Vat,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_CurrentQty,
			m_Quantity,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_Discount,
			m_Charge,
			m_Cost,
			m_Profit,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Width,
			m_Height,
			m_Orgin,
			m_Size,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			bool Active)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
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
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@Outward_ID",
			"@Stock_ID",
			"@RefType",
			"@Product_ID",
			"@ProductName",
			"@Vat",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_OUTWARD_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string Outward_ID,
			string Stock_ID,
			int RefType,
			string Product_ID,
			string ProductName,
			int Vat,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@Outward_ID",
			"@Stock_ID",
			"@RefType",
			"@Product_ID",
			"@ProductName",
			"@Vat",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_OUTWARD_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Delete
		public bool Delete()
		{
			return Delete(
			m_ID);
		}
		public bool Delete(
			SqlConnection myConnection)
		{
			return Delete(
			myConnection,
			m_ID);
		}
		public bool Delete(
			SqlTransaction myTransaction)
		{
			return Delete(
			myTransaction,
			m_ID);
		}
		public bool Delete(
			string ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Delete(
			mySql.Connection,
			ID))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool Delete(
			SqlConnection myConnection,
			string ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_OUTWARD_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			string ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_OUTWARD_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		
		public string Delete_XBB(SqlTransaction myTransaction, string Outward_Detail_ID)
        {
            string[] myPara = { "@Outward_Detail_ID" };
            object[] myValue = { Outward_Detail_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "STOCK_OUTWARD_DETAIL_Delete_XuatBaoBi", myPara, myValue);
        }
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"STOCK_OUTWARD_DETAIL_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"STOCK_OUTWARD_DETAIL_GetList");
		}
		
		
		 public DataTable GetList_ByOutward_ID(string Outward_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={"@Outward_ID" };
            object[] myValue ={Outward_ID };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetList_ByID", myPara, myValue);
        }

         public DataTable GetList_ByOutward_ID(SqlTransaction myTransaction,string Outward_ID)
         {
             SqlHelper mysql = new SqlHelper();
             string[] myPara = { "@Outward_ID" };
             object[] myValue = { Outward_ID };
             return mysql.ExecuteDataTable(myTransaction,"STOCK_OUTWARD_DETAIL_GetList_ByID", myPara, myValue);
         }

        public DataTable GetList_Merrial_ById(string Outward_Id)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Outward_ID" };
            object[] myValue = { Outward_Id };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetList_Merrial_ByID", myPara, myValue);
        }


        public DataTable GetList_ByDate(DateTime FromDate, DateTime ToDate, int Type)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@FromDate", "@ToDate", "@MoneyType" };
            object[] myValue ={ FromDate, ToDate, Type };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetList_ByDate", myPara, myValue);
        }

        public DataTable GetList_ByDate_Action(DateTime FromDate, DateTime ToDate, int Type,int Action)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@MoneyType", "@Action" };
            object[] myValue = { FromDate, ToDate, Type,Action };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetList_ByDate_Action", myPara, myValue);
        }

        public DataTable ReportDate(DateTime FromDate, DateTime ToDate, string Stock,string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID","@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock,Product };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_ReportDate", myPara, myValue);
        }
        public DataTable GetList_ByDate_Build(DateTime FromDate, DateTime ToDate, int Type)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara ={ "@FromDate", "@ToDate", "@MoneyType" };
            object[] myValue ={ FromDate, ToDate, Type };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetList_Date_Build", myPara, myValue);
        }
        public DataTable GetListIDSX(string Inward_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@OutwardID" };
            object[] myValue = { Inward_ID };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetListIDSX", myPara, myValue);
        }
        public DataTable GetListSale(string SaleID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@SaleID" };
            object[] myValue = { SaleID };
            return mysql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_GetListSale", myPara, myValue);
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
			return mySql.ExecuteScalar(myConnection,"STOCK_OUTWARD_DETAIL_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"STOCK_OUTWARD_DETAIL_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			int RefType,
			string ProductName,
			int Vat,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefType,
			ProductName,
			Vat,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			int RefType,
			string ProductName,
			int Vat,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			string Description)
		{
			string[] myPara={
			"@RefType",
			"@ProductName",
			"@Vat",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Description"};
			object[] myValue={
			"%"+RefType+"%",
			"%"+ProductName+"%",
			"%"+Vat+"%",
			"%"+Lev1+"%",
			"%"+Lev2+"%",
			"%"+Lev3+"%",
			"%"+Lev4+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+CurrentQty+"%",
			"%"+Quantity+"%",
			"%"+UnitPrice+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+Discount+"%",
			"%"+Charge+"%",
			"%"+Cost+"%",
			"%"+Profit+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+ChassyNo+"%",
			"%"+IME+"%",
			"%"+Width+"%",
			"%"+Height+"%",
			"%"+Orgin+"%",
			"%"+Size+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"STOCK_OUTWARD_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			int RefType,
			string ProductName,
			int Vat,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal CurrentQty,
			decimal Quantity,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal Discount,
			decimal Charge,
			decimal Cost,
			decimal Profit,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			decimal Width,
			decimal Height,
			string Orgin,
			string Size,
			string Description)
		{
			string[] myPara={
			"@RefType",
			"@ProductName",
			"@Vat",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Cost",
			"@Profit",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Description"};
			object[] myValue={
			"%"+RefType+"%",
			"%"+ProductName+"%",
			"%"+Vat+"%",
			"%"+Lev1+"%",
			"%"+Lev2+"%",
			"%"+Lev3+"%",
			"%"+Lev4+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+CurrentQty+"%",
			"%"+Quantity+"%",
			"%"+UnitPrice+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+Discount+"%",
			"%"+Charge+"%",
			"%"+Cost+"%",
			"%"+Profit+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+ChassyNo+"%",
			"%"+IME+"%",
			"%"+Width+"%",
			"%"+Height+"%",
			"%"+Orgin+"%",
			"%"+Size+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"STOCK_OUTWARD_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("STOCK_OUTWARD_DETAIL_LookUp");
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
	}
	#region Enum Fields

	public enum STOCK_OUTWARD_DETAILFields
		{
			ID,
			Outward_ID,
			Stock_ID,
			RefType,
			Product_ID,
			ProductName,
			Vat,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Cost,
			Profit,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Width,
			Height,
			Orgin,
			Size,
			StoreID,
			Description,
			Sorted,
			Active
		}

	#endregion

	#region Class Collection

	public class STOCK_OUTWARD_DETAILCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new STOCK_OUTWARD_DETAIL to the collection.")]
			public int Add(STOCK_OUTWARD_DETAIL item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a STOCK_OUTWARD_DETAIL from the collection.")]
			public void Remove(STOCK_OUTWARD_DETAIL item)
				{
					List.Remove(item);
				}
			[Description("Inserts an STOCK_OUTWARD_DETAIL into the collection at the specified index..")]
			public void Inserts(int index,STOCK_OUTWARD_DETAIL item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(STOCK_OUTWARD_DETAIL item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the STOCK_OUTWARD_DETAIL class is present in the collection.")]
			public bool Contains(STOCK_OUTWARD_DETAIL item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
