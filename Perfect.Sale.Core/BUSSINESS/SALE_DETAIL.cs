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
	/// <summary>
	/// Project: Perfect ERP System 
	/// Generated Class for Table : SALE_DETAIL.
	/// Date: 15/03/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class SALE_DETAIL:Object
	{
		#region Init
		private string m_ID;
		private string m_SaleID;
		private string m_StockID;
		private int m_RefType;
		private string m_ProductID;
		private string m_ProductName;
		private string m_Unit;
		private decimal m_UnitConvert;
		private decimal m_Thung;
		private decimal m_Met;
		private decimal m_Vien;
		private int m_Vat;
		private decimal m_VatAmount;
		private decimal m_CurrentQty;
		private decimal m_Quantity;
		private decimal m_Shipped;
		private decimal m_UnitPrice;
		private decimal m_Amount;
		private decimal m_QtyConvert;
		private decimal m_DiscountRate;
		private decimal m_Discount;
		private decimal m_Charge;
		private decimal m_FDiscount;
		private decimal m_FVatAmount;
		private decimal m_FCharge;
		private decimal m_FAmount;
		private DateTime m_Limit;
		private decimal m_Guarantee;
		private decimal m_Width;
		private decimal m_Height;
		private string m_Batch;
		private string m_Serial;
		private string m_ChassyNo;
		private string m_IME;
		private string m_Orgin;
		private string m_Size;
		private string m_Color;
		private int m_Sorted;
		private long m_StoreID;
		private string m_Description;
		private bool m_Active;
		
		
		public SALE_DETAIL()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_SaleID="";
			 m_StockID="";
			 m_RefType=0;
			 m_ProductID="";
			 m_ProductName="";
			 m_Unit="";
			 m_UnitConvert=0;
			 m_Thung=0;
			 m_Met=0;
			 m_Vien=0;
			 m_Vat=0;
			 m_VatAmount=0;
			 m_CurrentQty=0;
			 m_Quantity=0;
			 m_Shipped=0;
			 m_UnitPrice=0;
			 m_Amount=0;
			 m_QtyConvert=0;
			 m_DiscountRate=0;
			 m_Discount=0;
			 m_Charge=0;
			 m_FDiscount=0;
			 m_FVatAmount=0;
			 m_FCharge=0;
			 m_FAmount=0;
			 m_Limit=DateTime.Now;
			 m_Guarantee=0;
			 m_Width=0;
			 m_Height=0;
			 m_Batch="";
			 m_Serial="";
			 m_ChassyNo="";
			 m_IME="";
			 m_Orgin="";
			 m_Size="";
			 m_Color="";
			 m_Sorted=0;
			 m_StoreID=0;
			 m_Description="";
			 m_Active=true;
		}
		public SALE_DETAIL(
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_SaleID=SaleID;
			 m_StockID=StockID;
			 m_RefType=RefType;
			 m_ProductID=ProductID;
			 m_ProductName=ProductName;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_Thung=Thung;
			 m_Met=Met;
			 m_Vien=Vien;
			 m_Vat=Vat;
			 m_VatAmount=VatAmount;
			 m_CurrentQty=CurrentQty;
			 m_Quantity=Quantity;
			 m_Shipped=Shipped;
			 m_UnitPrice=UnitPrice;
			 m_Amount=Amount;
			 m_QtyConvert=QtyConvert;
			 m_DiscountRate=DiscountRate;
			 m_Discount=Discount;
			 m_Charge=Charge;
			 m_FDiscount=FDiscount;
			 m_FVatAmount=FVatAmount;
			 m_FCharge=FCharge;
			 m_FAmount=FAmount;
			 m_Limit=Limit;
			 m_Guarantee=Guarantee;
			 m_Width=Width;
			 m_Height=Height;
			 m_Batch=Batch;
			 m_Serial=Serial;
			 m_ChassyNo=ChassyNo;
			 m_IME=IME;
			 m_Orgin=Orgin;
			 m_Size=Size;
			 m_Color=Color;
			 m_Sorted=Sorted;
			 m_StoreID=StoreID;
			 m_Description=Description;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_SaleID=SaleID;
			 m_StockID=StockID;
			 m_RefType=RefType;
			 m_ProductID=ProductID;
			 m_ProductName=ProductName;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_Thung=Thung;
			 m_Met=Met;
			 m_Vien=Vien;
			 m_Vat=Vat;
			 m_VatAmount=VatAmount;
			 m_CurrentQty=CurrentQty;
			 m_Quantity=Quantity;
			 m_Shipped=Shipped;
			 m_UnitPrice=UnitPrice;
			 m_Amount=Amount;
			 m_QtyConvert=QtyConvert;
			 m_DiscountRate=DiscountRate;
			 m_Discount=Discount;
			 m_Charge=Charge;
			 m_FDiscount=FDiscount;
			 m_FVatAmount=FVatAmount;
			 m_FCharge=FCharge;
			 m_FAmount=FAmount;
			 m_Limit=Limit;
			 m_Guarantee=Guarantee;
			 m_Width=Width;
			 m_Height=Height;
			 m_Batch=Batch;
			 m_Serial=Serial;
			 m_ChassyNo=ChassyNo;
			 m_IME=IME;
			 m_Orgin=Orgin;
			 m_Size=Size;
			 m_Color=Color;
			 m_Sorted=Sorted;
			 m_StoreID=StoreID;
			 m_Description=Description;
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
		[DisplayName("SaleID")]
		[Category("Column")]
		public string SaleID
		{
			get
			{
				return m_SaleID;
			}
			set
			{
				m_SaleID = value;
			}
		}
		[DisplayName("StockID")]
		[Category("Column")]
		public string StockID
		{
			get
			{
				return m_StockID;
			}
			set
			{
				m_StockID = value;
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
		[DisplayName("ProductID")]
		[Category("Column")]
		public string ProductID
		{
			get
			{
				return m_ProductID;
			}
			set
			{
				m_ProductID = value;
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
		[DisplayName("Thung")]
		[Category("Column")]
		public decimal Thung
		{
			get
			{
				return m_Thung;
			}
			set
			{
				m_Thung = value;
			}
		}
		[DisplayName("Met")]
		[Category("Column")]
		public decimal Met
		{
			get
			{
				return m_Met;
			}
			set
			{
				m_Met = value;
			}
		}
		[DisplayName("Vien")]
		[Category("Column")]
		public decimal Vien
		{
			get
			{
				return m_Vien;
			}
			set
			{
				m_Vien = value;
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
		[DisplayName("VatAmount")]
		[Category("Column")]
		public decimal VatAmount
		{
			get
			{
				return m_VatAmount;
			}
			set
			{
				m_VatAmount = value;
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
		[DisplayName("Shipped")]
		[Category("Column")]
		public decimal Shipped
		{
			get
			{
				return m_Shipped;
			}
			set
			{
				m_Shipped = value;
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
		[DisplayName("DiscountRate")]
		[Category("Column")]
		public decimal DiscountRate
		{
			get
			{
				return m_DiscountRate;
			}
			set
			{
				m_DiscountRate = value;
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
		[DisplayName("FDiscount")]
		[Category("Column")]
		public decimal FDiscount
		{
			get
			{
				return m_FDiscount;
			}
			set
			{
				m_FDiscount = value;
			}
		}
		[DisplayName("FVatAmount")]
		[Category("Column")]
		public decimal FVatAmount
		{
			get
			{
				return m_FVatAmount;
			}
			set
			{
				m_FVatAmount = value;
			}
		}
		[DisplayName("FCharge")]
		[Category("Column")]
		public decimal FCharge
		{
			get
			{
				return m_FCharge;
			}
			set
			{
				m_FCharge = value;
			}
		}
		[DisplayName("FAmount")]
		[Category("Column")]
		public decimal FAmount
		{
			get
			{
				return m_FAmount;
			}
			set
			{
				m_FAmount = value;
			}
		}
		[DisplayName("Limit")]
		[Category("Column")]
		public DateTime Limit
		{
			get
			{
				return m_Limit;
			}
			set
			{
				m_Limit = value;
			}
		}
		[DisplayName("Guarantee")]
		[Category("Column")]
		public decimal Guarantee
		{
			get
			{
				return m_Guarantee;
			}
			set
			{
				m_Guarantee = value;
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
		[DisplayName("Color")]
		[Category("Column")]
		public string Color
		{
			get
			{
				return m_Color;
			}
			set
			{
				m_Color = value;
			}
		}
		[DisplayName("Sorted")]
		[Category("Column")]
		public int Sorted
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
				return "Class SALE_DETAIL";
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
			return SqlHelper.GenCode("SALE_DETAIL","SALE_DETAILID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"SALE_DETAIL","SALE_DETAILID",key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_SaleID =Convert.ToString(myReader["SaleID"]);
						m_StockID =Convert.ToString(myReader["StockID"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_ProductID =Convert.ToString(myReader["ProductID"]);
						m_ProductName =Convert.ToString(myReader["ProductName"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]);
						m_Thung =Convert.ToDecimal(myReader["Thung"]);
						m_Met =Convert.ToDecimal(myReader["Met"]);
						m_Vien =Convert.ToDecimal(myReader["Vien"]);
						m_Vat =Convert.ToInt32(myReader["Vat"]);
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]);
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]);
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]);
						m_Shipped =Convert.ToDecimal(myReader["Shipped"]);
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]);
						m_DiscountRate =Convert.ToDecimal(myReader["DiscountRate"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_Charge =Convert.ToDecimal(myReader["Charge"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]);
						m_FCharge =Convert.ToDecimal(myReader["FCharge"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_Limit =Convert.ToDateTime(myReader["Limit"]);
						m_Guarantee =Convert.ToDecimal(myReader["Guarantee"]);
						m_Width =Convert.ToDecimal(myReader["Width"]);
						m_Height =Convert.ToDecimal(myReader["Height"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Serial =Convert.ToString(myReader["Serial"]);
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]);
						m_IME =Convert.ToString(myReader["IME"]);
						m_Orgin =Convert.ToString(myReader["Orgin"]);
						m_Size =Convert.ToString(myReader["Size"]);
						m_Color =Convert.ToString(myReader["Color"]);
						m_Sorted =Convert.ToInt32(myReader["Sorted"]);
						m_StoreID =Convert.ToInt64(myReader["StoreID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_SaleID =Convert.ToString(myReader["SaleID"]==DBNull.Value?"":myReader["SaleID"] );
						m_StockID =Convert.ToString(myReader["StockID"]==DBNull.Value?"":myReader["StockID"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_ProductID =Convert.ToString(myReader["ProductID"]==DBNull.Value?"":myReader["ProductID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_Thung =Convert.ToDecimal(myReader["Thung"]==DBNull.Value?0:myReader["Thung"] );
						m_Met =Convert.ToDecimal(myReader["Met"]==DBNull.Value?0:myReader["Met"] );
						m_Vien =Convert.ToDecimal(myReader["Vien"]==DBNull.Value?0:myReader["Vien"] );
						m_Vat =Convert.ToInt32(myReader["Vat"]==DBNull.Value?0:myReader["Vat"] );
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]==DBNull.Value?0:myReader["VatAmount"] );
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]==DBNull.Value?0:myReader["CurrentQty"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_Shipped =Convert.ToDecimal(myReader["Shipped"]==DBNull.Value?0:myReader["Shipped"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_DiscountRate =Convert.ToDecimal(myReader["DiscountRate"]==DBNull.Value?0:myReader["DiscountRate"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]==DBNull.Value?0:myReader["FVatAmount"] );
						m_FCharge =Convert.ToDecimal(myReader["FCharge"]==DBNull.Value?0:myReader["FCharge"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Limit =Convert.ToDateTime(myReader["Limit"]==DBNull.Value?DateTime.Now:myReader["Limit"] );
						m_Guarantee =Convert.ToDecimal(myReader["Guarantee"]==DBNull.Value?0:myReader["Guarantee"] );
						m_Width =Convert.ToDecimal(myReader["Width"]==DBNull.Value?0:myReader["Width"] );
						m_Height =Convert.ToDecimal(myReader["Height"]==DBNull.Value?0:myReader["Height"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]==DBNull.Value?"":myReader["ChassyNo"] );
						m_IME =Convert.ToString(myReader["IME"]==DBNull.Value?"":myReader["IME"] );
						m_Orgin =Convert.ToString(myReader["Orgin"]==DBNull.Value?"":myReader["Orgin"] );
						m_Size =Convert.ToString(myReader["Size"]==DBNull.Value?"":myReader["Size"] );
						m_Color =Convert.ToString(myReader["Color"]==DBNull.Value?"":myReader["Color"] );
						m_Sorted =Convert.ToInt32(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
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
			string ID)
		{
			bool Result=false;
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_SaleID =Convert.ToString(myReader["SaleID"]);
						m_StockID =Convert.ToString(myReader["StockID"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_ProductID =Convert.ToString(myReader["ProductID"]);
						m_ProductName =Convert.ToString(myReader["ProductName"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]);
						m_Thung =Convert.ToDecimal(myReader["Thung"]);
						m_Met =Convert.ToDecimal(myReader["Met"]);
						m_Vien =Convert.ToDecimal(myReader["Vien"]);
						m_Vat =Convert.ToInt32(myReader["Vat"]);
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]);
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]);
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]);
						m_Shipped =Convert.ToDecimal(myReader["Shipped"]);
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]);
						m_DiscountRate =Convert.ToDecimal(myReader["DiscountRate"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_Charge =Convert.ToDecimal(myReader["Charge"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]);
						m_FCharge =Convert.ToDecimal(myReader["FCharge"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_Limit =Convert.ToDateTime(myReader["Limit"]);
						m_Guarantee =Convert.ToDecimal(myReader["Guarantee"]);
						m_Width =Convert.ToDecimal(myReader["Width"]);
						m_Height =Convert.ToDecimal(myReader["Height"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Serial =Convert.ToString(myReader["Serial"]);
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]);
						m_IME =Convert.ToString(myReader["IME"]);
						m_Orgin =Convert.ToString(myReader["Orgin"]);
						m_Size =Convert.ToString(myReader["Size"]);
						m_Color =Convert.ToString(myReader["Color"]);
						m_Sorted =Convert.ToInt32(myReader["Sorted"]);
						m_StoreID =Convert.ToInt64(myReader["StoreID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_SaleID =Convert.ToString(myReader["SaleID"]==DBNull.Value?"":myReader["SaleID"] );
						m_StockID =Convert.ToString(myReader["StockID"]==DBNull.Value?"":myReader["StockID"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_ProductID =Convert.ToString(myReader["ProductID"]==DBNull.Value?"":myReader["ProductID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_Thung =Convert.ToDecimal(myReader["Thung"]==DBNull.Value?0:myReader["Thung"] );
						m_Met =Convert.ToDecimal(myReader["Met"]==DBNull.Value?0:myReader["Met"] );
						m_Vien =Convert.ToDecimal(myReader["Vien"]==DBNull.Value?0:myReader["Vien"] );
						m_Vat =Convert.ToInt32(myReader["Vat"]==DBNull.Value?0:myReader["Vat"] );
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]==DBNull.Value?0:myReader["VatAmount"] );
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]==DBNull.Value?0:myReader["CurrentQty"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_Shipped =Convert.ToDecimal(myReader["Shipped"]==DBNull.Value?0:myReader["Shipped"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_DiscountRate =Convert.ToDecimal(myReader["DiscountRate"]==DBNull.Value?0:myReader["DiscountRate"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]==DBNull.Value?0:myReader["FVatAmount"] );
						m_FCharge =Convert.ToDecimal(myReader["FCharge"]==DBNull.Value?0:myReader["FCharge"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_Limit =Convert.ToDateTime(myReader["Limit"]==DBNull.Value?DateTime.Now:myReader["Limit"] );
						m_Guarantee =Convert.ToDecimal(myReader["Guarantee"]==DBNull.Value?0:myReader["Guarantee"] );
						m_Width =Convert.ToDecimal(myReader["Width"]==DBNull.Value?0:myReader["Width"] );
						m_Height =Convert.ToDecimal(myReader["Height"]==DBNull.Value?0:myReader["Height"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]==DBNull.Value?"":myReader["ChassyNo"] );
						m_IME =Convert.ToString(myReader["IME"]==DBNull.Value?"":myReader["IME"] );
						m_Orgin =Convert.ToString(myReader["Orgin"]==DBNull.Value?"":myReader["Orgin"] );
						m_Size =Convert.ToString(myReader["Size"]==DBNull.Value?"":myReader["Size"] );
						m_Color =Convert.ToString(myReader["Color"]==DBNull.Value?"":myReader["Color"] );
						m_Sorted =Convert.ToInt32(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
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
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_Sorted,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_Sorted,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_Sorted,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool Insert(
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Sorted,
			StoreID,
			Description,
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
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@SaleID",
			"@StockID",
			"@RefType",
			"@ProductID",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@Sorted",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Sorted,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@SaleID",
			"@StockID",
			"@RefType",
			"@ProductID",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@Sorted",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Sorted,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_Sorted,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_Sorted,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_Sorted,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool Update(
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Sorted,
			StoreID,
			Description,
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
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@SaleID",
			"@StockID",
			"@RefType",
			"@ProductID",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@Sorted",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Sorted,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			int Sorted,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@SaleID",
			"@StockID",
			"@RefType",
			"@ProductID",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@Sorted",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={ID,SaleID,StockID,RefType,ProductID,ProductName,Unit,UnitConvert,Thung,Met,Vien,Vat,VatAmount,CurrentQty,Quantity,Shipped,UnitPrice,Amount,QtyConvert,DiscountRate,Discount,Charge,FDiscount,FVatAmount,FCharge,FAmount,Limit,Guarantee,Width,Height,Batch,Serial,ChassyNo,IME,Orgin,Size,Color,Sorted,StoreID,Description,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
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
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
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
			m_SaleID,
			m_StockID,
			m_RefType,
			m_ProductID,
			m_ProductName,
			m_Unit,
			m_UnitConvert,
			m_Thung,
			m_Met,
			m_Vien,
			m_Vat,
			m_VatAmount,
			m_CurrentQty,
			m_Quantity,
			m_Shipped,
			m_UnitPrice,
			m_Amount,
			m_QtyConvert,
			m_DiscountRate,
			m_Discount,
			m_Charge,
			m_FDiscount,
			m_FVatAmount,
			m_FCharge,
			m_FAmount,
			m_Limit,
			m_Guarantee,
			m_Width,
			m_Height,
			m_Batch,
			m_Serial,
			m_ChassyNo,
			m_IME,
			m_Orgin,
			m_Size,
			m_Color,
			m_StoreID,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			long StoreID,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
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
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@SaleID",
			"@StockID",
			"@RefType",
			"@ProductID",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string SaleID,
			string StockID,
			int RefType,
			string ProductID,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			long StoreID,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@SaleID",
			"@StockID",
			"@RefType",
			"@ProductID",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@StoreID",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			StoreID,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myConnection,"SALE_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myTransaction,"SALE_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_DETAIL_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_DETAIL_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_DETAIL_GetList");
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
			return mySql.ExecuteScalar(myConnection,"SALE_DETAIL_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"SALE_DETAIL_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			int RefType,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefType,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			int RefType,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			string Description)
		{
			string[] myPara={
			"@RefType",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@Description"};
			object[] myValue={
			"%"+RefType+"%",
			"%"+ProductName+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+Thung+"%",
			"%"+Met+"%",
			"%"+Vien+"%",
			"%"+Vat+"%",
			"%"+VatAmount+"%",
			"%"+CurrentQty+"%",
			"%"+Quantity+"%",
			"%"+Shipped+"%",
			"%"+UnitPrice+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+DiscountRate+"%",
			"%"+Discount+"%",
			"%"+Charge+"%",
			"%"+FDiscount+"%",
			"%"+FVatAmount+"%",
			"%"+FCharge+"%",
			"%"+FAmount+"%",
			"%"+Limit+"%",
			"%"+Guarantee+"%",
			"%"+Width+"%",
			"%"+Height+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+ChassyNo+"%",
			"%"+IME+"%",
			"%"+Orgin+"%",
			"%"+Size+"%",
			"%"+Color+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			int RefType,
			string ProductName,
			string Unit,
			decimal UnitConvert,
			decimal Thung,
			decimal Met,
			decimal Vien,
			int Vat,
			decimal VatAmount,
			decimal CurrentQty,
			decimal Quantity,
			decimal Shipped,
			decimal UnitPrice,
			decimal Amount,
			decimal QtyConvert,
			decimal DiscountRate,
			decimal Discount,
			decimal Charge,
			decimal FDiscount,
			decimal FVatAmount,
			decimal FCharge,
			decimal FAmount,
			DateTime Limit,
			decimal Guarantee,
			decimal Width,
			decimal Height,
			string Batch,
			string Serial,
			string ChassyNo,
			string IME,
			string Orgin,
			string Size,
			string Color,
			string Description)
		{
			string[] myPara={
			"@RefType",
			"@ProductName",
			"@Unit",
			"@UnitConvert",
			"@Thung",
			"@Met",
			"@Vien",
			"@Vat",
			"@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@Shipped",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
			"@Discount",
			"@Charge",
			"@FDiscount",
			"@FVatAmount",
			"@FCharge",
			"@FAmount",
			"@Limit",
			"@Guarantee",
			"@Width",
			"@Height",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Orgin",
			"@Size",
			"@Color",
			"@Description"};
			object[] myValue={
			"%"+RefType+"%",
			"%"+ProductName+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+Thung+"%",
			"%"+Met+"%",
			"%"+Vien+"%",
			"%"+Vat+"%",
			"%"+VatAmount+"%",
			"%"+CurrentQty+"%",
			"%"+Quantity+"%",
			"%"+Shipped+"%",
			"%"+UnitPrice+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+DiscountRate+"%",
			"%"+Discount+"%",
			"%"+Charge+"%",
			"%"+FDiscount+"%",
			"%"+FVatAmount+"%",
			"%"+FCharge+"%",
			"%"+FAmount+"%",
			"%"+Limit+"%",
			"%"+Guarantee+"%",
			"%"+Width+"%",
			"%"+Height+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+ChassyNo+"%",
			"%"+IME+"%",
			"%"+Orgin+"%",
			"%"+Size+"%",
			"%"+Color+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_DETAIL_LookUp");
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

	public enum SALE_DETAILFields
		{
			ID,
			SaleID,
			StockID,
			RefType,
			ProductID,
			ProductName,
			Unit,
			UnitConvert,
			Thung,
			Met,
			Vien,
			Vat,
			VatAmount,
			CurrentQty,
			Quantity,
			Shipped,
			UnitPrice,
			Amount,
			QtyConvert,
			DiscountRate,
			Discount,
			Charge,
			FDiscount,
			FVatAmount,
			FCharge,
			FAmount,
			Limit,
			Guarantee,
			Width,
			Height,
			Batch,
			Serial,
			ChassyNo,
			IME,
			Orgin,
			Size,
			Color,
			Sorted,
			StoreID,
			Description,
			Active
		}

	#endregion

	#region Class Collection

	public class SALE_DETAILCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new SALE_DETAIL to the collection.")]
			public int Add(SALE_DETAIL item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a SALE_DETAIL from the collection.")]
			public void Remove(SALE_DETAIL item)
				{
					List.Remove(item);
				}
			[Description("Inserts an SALE_DETAIL into the collection at the specified index..")]
			public void Inserts(int index,SALE_DETAIL item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(SALE_DETAIL item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the SALE_DETAIL class is present in the collection.")]
			public bool Contains(SALE_DETAIL item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
