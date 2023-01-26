using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using PerfectSolutions.Data;
using PerfectSolutions.Lib;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : PRODUCT.
	/// Date: 1/2/2009
	/// Author: 
	/// </summary>
	public class PRODUCT
	{
		#region Init
		private string m_Product_ID;
		private string m_Product_Name;
		private int m_Product_Type_ID;
		private int m_Manufacturer_ID;
		private string m_Product_Group_ID;
		private string m_Provider_ID;
		private string m_Origin;
		private string m_Barcode;
		private string m_Unit;
		private double m_Org_Price;
		private double m_Sale_Price;
		private double m_Retail_Price;
		private double m_Quantity;
		private double m_CurrentCost;
		private double m_AverageCost;
		private int m_Warranty;
		private double m_VAT_ID;
		private double m_ImportTax_ID;
		private double m_ExportTax_ID;
		private double m_LuxuryTax_ID;
		private string m_Customer_ID;
		private string m_Customer_Name;
		private int m_CostMethod;
		private double m_MinStock;
		private double m_MaxStock;
		private double m_Discount;
		private double m_Commission;
		private string m_Description;
		private string m_Color;
		private bool m_Expiry;
		private double m_LimitOrders;
		private double m_ExpiryValue;
		private bool m_Batch;
		private double m_Depth;
		private double m_Height;
		private double m_Width;
		private double m_Thickness;
		private string m_Size;
		private string m_UserID;
		private bool m_Active;
		public PRODUCT()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Product_ID="";
			 m_Product_Name="";
			 m_Product_Type_ID=0;
			 m_Manufacturer_ID=0;
			 m_Product_Group_ID="";
			 m_Provider_ID="";
			 m_Origin="";
			 m_Barcode="";
			 m_Unit="";
			 m_Org_Price=0.0;
			 m_Sale_Price=0.0;
			 m_Retail_Price=0.0;
			 m_Quantity=0.0;
			 m_CurrentCost=0.0;
			 m_AverageCost=0.0;
			 m_Warranty=0;
			 m_VAT_ID=0.0;
			 m_ImportTax_ID=0.0;
			 m_ExportTax_ID=0.0;
			 m_LuxuryTax_ID=0.0;
			 m_Customer_ID="";
			 m_Customer_Name="";
			 m_CostMethod=0;
			 m_MinStock=0.0;
			 m_MaxStock=0.0;
			 m_Discount=0.0;
			 m_Commission=0.0;
			 m_Description="";
			 m_Color="";
			 m_Expiry=true;
			 m_LimitOrders=0.0;
			 m_ExpiryValue=0.0;
			 m_Batch=true;
			 m_Depth=0.0;
			 m_Height=0.0;
			 m_Width=0.0;
			 m_Thickness=0.0;
			 m_Size="";
			 m_UserID="";
			 m_Active=true;
		}
		public PRODUCT(string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Product_ID=Product_ID;
			 m_Product_Name=Product_Name;
			 m_Product_Type_ID=Product_Type_ID;
			 m_Manufacturer_ID=Manufacturer_ID;
			 m_Product_Group_ID=Product_Group_ID;
			 m_Provider_ID=Provider_ID;
			 m_Origin=Origin;
			 m_Barcode=Barcode;
			 m_Unit=Unit;
			 m_Org_Price=Org_Price;
			 m_Sale_Price=Sale_Price;
			 m_Retail_Price=Retail_Price;
			 m_Quantity=Quantity;
			 m_CurrentCost=CurrentCost;
			 m_AverageCost=AverageCost;
			 m_Warranty=Warranty;
			 m_VAT_ID=VAT_ID;
			 m_ImportTax_ID=ImportTax_ID;
			 m_ExportTax_ID=ExportTax_ID;
			 m_LuxuryTax_ID=LuxuryTax_ID;
			 m_Customer_ID=Customer_ID;
			 m_Customer_Name=Customer_Name;
			 m_CostMethod=CostMethod;
			 m_MinStock=MinStock;
			 m_MaxStock=MaxStock;
			 m_Discount=Discount;
			 m_Commission=Commission;
			 m_Description=Description;
			 m_Color=Color;
			 m_Expiry=Expiry;
			 m_LimitOrders=LimitOrders;
			 m_ExpiryValue=ExpiryValue;
			 m_Batch=Batch;
			 m_Depth=Depth;
			 m_Height=Height;
			 m_Width=Width;
			 m_Thickness=Thickness;
			 m_Size=Size;
			 m_UserID=UserID;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
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
		public string Product_Name
		{
			get
			{
				return m_Product_Name;
			}
			set
			{
				m_Product_Name = value;
			}
		}
		public int Product_Type_ID
		{
			get
			{
				return m_Product_Type_ID;
			}
			set
			{
				m_Product_Type_ID = value;
			}
		}
		public int Manufacturer_ID
		{
			get
			{
				return m_Manufacturer_ID;
			}
			set
			{
				m_Manufacturer_ID = value;
			}
		}
		public string Product_Group_ID
		{
			get
			{
				return m_Product_Group_ID;
			}
			set
			{
				m_Product_Group_ID = value;
			}
		}
		public string Provider_ID
		{
			get
			{
				return m_Provider_ID;
			}
			set
			{
				m_Provider_ID = value;
			}
		}
		public string Origin
		{
			get
			{
				return m_Origin;
			}
			set
			{
				m_Origin = value;
			}
		}
		public string Barcode
		{
			get
			{
				return m_Barcode;
			}
			set
			{
				m_Barcode = value;
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
		public double Org_Price
		{
			get
			{
				return m_Org_Price;
			}
			set
			{
				m_Org_Price = value;
			}
		}
		public double Sale_Price
		{
			get
			{
				return m_Sale_Price;
			}
			set
			{
				m_Sale_Price = value;
			}
		}
		public double Retail_Price
		{
			get
			{
				return m_Retail_Price;
			}
			set
			{
				m_Retail_Price = value;
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
		public double CurrentCost
		{
			get
			{
				return m_CurrentCost;
			}
			set
			{
				m_CurrentCost = value;
			}
		}
		public double AverageCost
		{
			get
			{
				return m_AverageCost;
			}
			set
			{
				m_AverageCost = value;
			}
		}
		public int Warranty
		{
			get
			{
				return m_Warranty;
			}
			set
			{
				m_Warranty = value;
			}
		}
		public double VAT_ID
		{
			get
			{
				return m_VAT_ID;
			}
			set
			{
				m_VAT_ID = value;
			}
		}
		public double ImportTax_ID
		{
			get
			{
				return m_ImportTax_ID;
			}
			set
			{
				m_ImportTax_ID = value;
			}
		}
		public double ExportTax_ID
		{
			get
			{
				return m_ExportTax_ID;
			}
			set
			{
				m_ExportTax_ID = value;
			}
		}
		public double LuxuryTax_ID
		{
			get
			{
				return m_LuxuryTax_ID;
			}
			set
			{
				m_LuxuryTax_ID = value;
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
		public string Customer_Name
		{
			get
			{
				return m_Customer_Name;
			}
			set
			{
				m_Customer_Name = value;
			}
		}
		public int CostMethod
		{
			get
			{
				return m_CostMethod;
			}
			set
			{
				m_CostMethod = value;
			}
		}
		public double MinStock
		{
			get
			{
				return m_MinStock;
			}
			set
			{
				m_MinStock = value;
			}
		}
		public double MaxStock
		{
			get
			{
				return m_MaxStock;
			}
			set
			{
				m_MaxStock = value;
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
		public double Commission
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
		public bool Expiry
		{
			get
			{
				return m_Expiry;
			}
			set
			{
				m_Expiry = value;
			}
		}
		public double LimitOrders
		{
			get
			{
				return m_LimitOrders;
			}
			set
			{
				m_LimitOrders = value;
			}
		}
		public double ExpiryValue
		{
			get
			{
				return m_ExpiryValue;
			}
			set
			{
				m_ExpiryValue = value;
			}
		}
		public bool Batch
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
		public double Depth
		{
			get
			{
				return m_Depth;
			}
			set
			{
				m_Depth = value;
			}
		}
		public double Height
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
		public double Width
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
		public double Thickness
		{
			get
			{
				return m_Thickness;
			}
			set
			{
				m_Thickness = value;
			}
		}
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
		public string UserID
		{
			get
			{
				return m_UserID;
			}
			set
			{
				m_UserID = value;
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
				return "Class PRODUCT";
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
			return SqlData.GenCode("PRODUCT","PRODUCTID","");
		}
		public Boolean Exist(string Product_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string Product_ID)
		{
			string Result="";
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Product_Name =Convert.ToString(myReader["Product_Name"]);
						m_Product_Type_ID =Convert.ToInt32(myReader["Product_Type_ID"]);
						m_Manufacturer_ID =Convert.ToInt32(myReader["Manufacturer_ID"]);
						m_Product_Group_ID =Convert.ToString(myReader["Product_Group_ID"]);
						m_Provider_ID =Convert.ToString(myReader["Provider_ID"]);
						m_Origin =Convert.ToString(myReader["Origin"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_Org_Price =Convert.ToSingle(myReader["Org_Price"]);
						m_Sale_Price =Convert.ToSingle(myReader["Sale_Price"]);
						m_Retail_Price =Convert.ToSingle(myReader["Retail_Price"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_CurrentCost =Convert.ToSingle(myReader["CurrentCost"]);
						m_AverageCost =Convert.ToSingle(myReader["AverageCost"]);
						m_Warranty =Convert.ToInt32(myReader["Warranty"]);
						m_VAT_ID =Convert.ToSingle(myReader["VAT_ID"]);
						m_ImportTax_ID =Convert.ToSingle(myReader["ImportTax_ID"]);
						m_ExportTax_ID =Convert.ToSingle(myReader["ExportTax_ID"]);
						m_LuxuryTax_ID =Convert.ToSingle(myReader["LuxuryTax_ID"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Customer_Name =Convert.ToString(myReader["Customer_Name"]);
						m_CostMethod =Convert.ToInt16(myReader["CostMethod"]);
						m_MinStock =Convert.ToSingle(myReader["MinStock"]);
						m_MaxStock =Convert.ToSingle(myReader["MaxStock"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Commission =Convert.ToSingle(myReader["Commission"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Color =Convert.ToString(myReader["Color"]);
						m_Expiry =Convert.ToBoolean(myReader["Expiry"]);
						m_LimitOrders =Convert.ToSingle(myReader["LimitOrders"]);
						m_ExpiryValue =Convert.ToSingle(myReader["ExpiryValue"]);
						m_Batch =Convert.ToBoolean(myReader["Batch"]);
						m_Depth =Convert.ToSingle(myReader["Depth"]);
						m_Height =Convert.ToSingle(myReader["Height"]);
						m_Width =Convert.ToSingle(myReader["Width"]);
						m_Thickness =Convert.ToSingle(myReader["Thickness"]);
						m_Size =Convert.ToString(myReader["Size"]);
						m_UserID =Convert.ToString(myReader["UserID"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlConnection myConnection,string Product_ID)
		{
			string Result="";
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PRODUCT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Product_Name =Convert.ToString(myReader["Product_Name"]);
						m_Product_Type_ID =Convert.ToInt32(myReader["Product_Type_ID"]);
						m_Manufacturer_ID =Convert.ToInt32(myReader["Manufacturer_ID"]);
						m_Product_Group_ID =Convert.ToString(myReader["Product_Group_ID"]);
						m_Provider_ID =Convert.ToString(myReader["Provider_ID"]);
						m_Origin =Convert.ToString(myReader["Origin"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_Org_Price =Convert.ToSingle(myReader["Org_Price"]);
						m_Sale_Price =Convert.ToSingle(myReader["Sale_Price"]);
						m_Retail_Price =Convert.ToSingle(myReader["Retail_Price"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_CurrentCost =Convert.ToSingle(myReader["CurrentCost"]);
						m_AverageCost =Convert.ToSingle(myReader["AverageCost"]);
						m_Warranty =Convert.ToInt32(myReader["Warranty"]);
						m_VAT_ID =Convert.ToSingle(myReader["VAT_ID"]);
						m_ImportTax_ID =Convert.ToSingle(myReader["ImportTax_ID"]);
						m_ExportTax_ID =Convert.ToSingle(myReader["ExportTax_ID"]);
						m_LuxuryTax_ID =Convert.ToSingle(myReader["LuxuryTax_ID"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Customer_Name =Convert.ToString(myReader["Customer_Name"]);
						m_CostMethod =Convert.ToInt16(myReader["CostMethod"]);
						m_MinStock =Convert.ToSingle(myReader["MinStock"]);
						m_MaxStock =Convert.ToSingle(myReader["MaxStock"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Commission =Convert.ToSingle(myReader["Commission"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Color =Convert.ToString(myReader["Color"]);
						m_Expiry =Convert.ToBoolean(myReader["Expiry"]);
						m_LimitOrders =Convert.ToSingle(myReader["LimitOrders"]);
						m_ExpiryValue =Convert.ToSingle(myReader["ExpiryValue"]);
						m_Batch =Convert.ToBoolean(myReader["Batch"]);
						m_Depth =Convert.ToSingle(myReader["Depth"]);
						m_Height =Convert.ToSingle(myReader["Height"]);
						m_Width =Convert.ToSingle(myReader["Width"]);
						m_Thickness =Convert.ToSingle(myReader["Thickness"]);
						m_Size =Convert.ToString(myReader["Size"]);
						m_UserID =Convert.ToString(myReader["UserID"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,string Product_ID)
		{
			string Result="";
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PRODUCT_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Product_Name =Convert.ToString(myReader["Product_Name"]);
						m_Product_Type_ID =Convert.ToInt32(myReader["Product_Type_ID"]);
						m_Manufacturer_ID =Convert.ToInt32(myReader["Manufacturer_ID"]);
						m_Product_Group_ID =Convert.ToString(myReader["Product_Group_ID"]);
						m_Provider_ID =Convert.ToString(myReader["Provider_ID"]);
						m_Origin =Convert.ToString(myReader["Origin"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_Org_Price =Convert.ToSingle(myReader["Org_Price"]);
						m_Sale_Price =Convert.ToSingle(myReader["Sale_Price"]);
						m_Retail_Price =Convert.ToSingle(myReader["Retail_Price"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_CurrentCost =Convert.ToSingle(myReader["CurrentCost"]);
						m_AverageCost =Convert.ToSingle(myReader["AverageCost"]);
						m_Warranty =Convert.ToInt32(myReader["Warranty"]);
						m_VAT_ID =Convert.ToSingle(myReader["VAT_ID"]);
						m_ImportTax_ID =Convert.ToSingle(myReader["ImportTax_ID"]);
						m_ExportTax_ID =Convert.ToSingle(myReader["ExportTax_ID"]);
						m_LuxuryTax_ID =Convert.ToSingle(myReader["LuxuryTax_ID"]);
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_Customer_Name =Convert.ToString(myReader["Customer_Name"]);
						m_CostMethod =Convert.ToInt16(myReader["CostMethod"]);
						m_MinStock =Convert.ToSingle(myReader["MinStock"]);
						m_MaxStock =Convert.ToSingle(myReader["MaxStock"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
						m_Commission =Convert.ToSingle(myReader["Commission"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Color =Convert.ToString(myReader["Color"]);
						m_Expiry =Convert.ToBoolean(myReader["Expiry"]);
						m_LimitOrders =Convert.ToSingle(myReader["LimitOrders"]);
						m_ExpiryValue =Convert.ToSingle(myReader["ExpiryValue"]);
						m_Batch =Convert.ToBoolean(myReader["Batch"]);
						m_Depth =Convert.ToSingle(myReader["Depth"]);
						m_Height =Convert.ToSingle(myReader["Height"]);
						m_Width =Convert.ToSingle(myReader["Width"]);
						m_Thickness =Convert.ToSingle(myReader["Thickness"]);
						m_Size =Convert.ToString(myReader["Size"]);
						m_UserID =Convert.ToString(myReader["UserID"]);
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
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={m_Product_ID,m_Product_Name,m_Product_Type_ID,m_Manufacturer_ID,m_Product_Group_ID,m_Provider_ID,m_Origin,m_Barcode,m_Unit,m_Org_Price,m_Sale_Price,m_Retail_Price,m_Quantity,m_CurrentCost,m_AverageCost,m_Warranty,m_VAT_ID,m_ImportTax_ID,m_ExportTax_ID,m_LuxuryTax_ID,m_Customer_ID,m_Customer_Name,m_CostMethod,m_MinStock,m_MaxStock,m_Discount,m_Commission,m_Description,m_Color,m_Expiry,m_LimitOrders,m_ExpiryValue,m_Batch,m_Depth,m_Height,m_Width,m_Thickness,m_Size,m_UserID,m_Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery("PRODUCT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={m_Product_ID,m_Product_Name,m_Product_Type_ID,m_Manufacturer_ID,m_Product_Group_ID,m_Provider_ID,m_Origin,m_Barcode,m_Unit,m_Org_Price,m_Sale_Price,m_Retail_Price,m_Quantity,m_CurrentCost,m_AverageCost,m_Warranty,m_VAT_ID,m_ImportTax_ID,m_ExportTax_ID,m_LuxuryTax_ID,m_Customer_ID,m_Customer_Name,m_CostMethod,m_MinStock,m_MaxStock,m_Discount,m_Commission,m_Description,m_Color,m_Expiry,m_LimitOrders,m_ExpiryValue,m_Batch,m_Depth,m_Height,m_Width,m_Thickness,m_Size,m_UserID,m_Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Insert",myPara,myValue);
		}
		public string Insert(string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery("PRODUCT_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={m_Product_ID,m_Product_Name,m_Product_Type_ID,m_Manufacturer_ID,m_Product_Group_ID,m_Provider_ID,m_Origin,m_Barcode,m_Unit,m_Org_Price,m_Sale_Price,m_Retail_Price,m_Quantity,m_CurrentCost,m_AverageCost,m_Warranty,m_VAT_ID,m_ImportTax_ID,m_ExportTax_ID,m_LuxuryTax_ID,m_Customer_ID,m_Customer_Name,m_CostMethod,m_MinStock,m_MaxStock,m_Discount,m_Commission,m_Description,m_Color,m_Expiry,m_LimitOrders,m_ExpiryValue,m_Batch,m_Depth,m_Height,m_Width,m_Thickness,m_Size,m_UserID,m_Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery("PRODUCT_Update",myPara,myValue);
		}
		public string Update(string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery("PRODUCT_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={m_Product_ID};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery("PRODUCT_Delete",myPara,myValue);
		}
		public string Delete(string Product_ID)
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery("PRODUCT_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Product_ID)
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Product_ID)
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlData mySql=new SqlData();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlData mySql=new SqlData();
			return mySql.ExecuteDataTable("PRODUCT_GetList");
		}

        public DataTable Search(string Product_ID, string Product_Name)
        {
            string[] myPara ={ "@Product_ID", "@Product_Name" };
            object[] myValue ={ "%" + Product_ID + "%", "%" + Product_Name + "%" };
            SqlData mySql = new SqlData();
            return mySql.ExecuteDataTable("PRODUCT_Search", myPara, myValue);
        }

        public DataTable GetList_Build()
        {
            SqlData mysql = new SqlData();
            return mysql.ExecuteDataTable("PRODUCT_GetList_Build");
        }

		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			Func.TableToComboBox(combo,GetList(), "PRODUCT_Name", "PRODUCT_ID");
		}
        public void AddCombo_Build(ComboBox combo)
        {
            Func.TableToComboBox(combo, GetList_Build(), "PRODUCT_Name", "PRODUCT_ID");
        }
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["PRODUCT_ID"] = "All";
			b["PRODUCT_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			Func.TableToComboBox(combo,dt, "PRODUCT_Name", "PRODUCT_ID");
		}
		#endregion
		
	}
}
