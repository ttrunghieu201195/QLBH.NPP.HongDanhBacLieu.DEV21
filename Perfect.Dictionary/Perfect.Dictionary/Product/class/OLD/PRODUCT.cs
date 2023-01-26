using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;
using DevExpress.XtraEditors;

namespace Perfect.ERP
{
	 
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
		private string m_UnitConvert;
		private double m_UnitRate;
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
	    private Image m_photo;

        private string m_TrongTam01;
        private string m_TrongTam02;
        private string m_TrongTam03;

        private string m_GhiChu01;
        private string m_GhiChu02;
        private string m_GhiChu03;



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
			 m_UnitConvert="";
			 m_UnitRate=0.0;
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

             m_TrongTam01 = "";
             m_TrongTam02 = "";
             m_TrongTam03 = "";
             m_GhiChu01 = "";
             m_GhiChu02 = "";
             m_GhiChu03 = "";

		}
		public PRODUCT(
            string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,
            string Provider_ID,string Origin,string Barcode,string Unit,string UnitConvert,
            double UnitRate,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,
            double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,
            string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,
            double Discount,double Commission,string Description,string Color,bool Expiry,
            double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,
            string Size,string UserID,bool Active,
            string TrongTam01,
            string TrongTam02,
            string TrongTam03,
            string GhiChu01,
            string GhiChu02,
            string GhiChu03

            )
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
			 m_UnitConvert=UnitConvert;
			 m_UnitRate=UnitRate;
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

             m_TrongTam01 = TrongTam01;
             m_TrongTam02 = TrongTam02;
             m_TrongTam03 = TrongTam03;

             m_GhiChu01 = GhiChu01;
             m_GhiChu02 = GhiChu02;
             m_GhiChu03 = GhiChu03;
		}
		#endregion
		
		#region Property

        public Image Photo
        {
            get
            {
                return m_photo;
            }
            set
            {
                m_photo = value;
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
		public string UnitConvert
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
		public double UnitRate
		{
			get
			{
				return m_UnitRate;
			}
			set
			{
				m_UnitRate = value;
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

        //
        public string TrongTam01
        {
            get
            {
                return m_TrongTam01;
            }
            set
            {
                m_TrongTam01 = value;
            }
        }
        public string TrongTam02
        {
            get
            {
                return m_TrongTam02;
            }
            set
            {
                m_TrongTam02 = value;
            }
        }
        public string TrongTam03
        {
            get
            {
                return m_TrongTam03;
            }
            set
            {
                m_TrongTam03 = value;
            }
        }
        public string GhiChu01
        {
            get
            {
                return m_GhiChu01;
            }
            set
            {
                m_GhiChu01 = value;
            }
        }
        public string GhiChu02
        {
            get
            {
                return m_GhiChu02;
            }
            set
            {
                m_GhiChu02 = value;
            }
        }
        public string GhiChu03
        {
            get
            {
                return m_GhiChu03;
            }
            set
            {
                m_GhiChu03 = value;
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
            return SqlHelper.GenCode("PRODUCT", "Product_ID", "HH");
		}

        public string CreateKey()
        {
            return CreateKey("HH");
        }

        public string CreateKey(string key)
        {
            return SqlHelper.GenCode(key);
        }

        public string CreateKey(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, key);
        }

        public string CreateKey(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "");
        }

		public Boolean Exist(string Product_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_Get",myPara,myValue);
			if (myReader !=null)
			{
				Result= myReader.HasRows;
				myReader.Close();
				myReader = null;
			}
            mySql.Close();
			return Result;
		}

        public Boolean ExistByName(string Product_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Product_Name" };
            object[] myValue = {"%"+Product_Name+"%"};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PRODUCT_GetByName", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader = null;
            }
            mySql.Close();
            return Result;
        }

        public Boolean ExistByName(SqlTransaction myTransaction, string Product_Name)
        {
            Boolean Result = false;
            string[] myPara = { "@Product_Name" };
            object[] myValue = { Product_Name};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader("Select * from PRODUCT WHERE Product_Name=N'" + Product_Name + "'");
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader = null;
            }
            mySql.Close();
            return Result;
        }

        public Boolean Exist(SqlTransaction myTransaction,string Product_ID)
        {
            Boolean Result = false;
            string[] myPara = { "@Product_ID" };
            object[] myValue = { Product_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction,"PRODUCT_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            
            return Result;
        }

		public string Get(string Product_ID)
		{
			string Result="";
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM PRODUCT p WHERE p.Product_ID = @Product_ID ";
			SqlDataReader myReader=mySql.ExecuteReader(sql,myPara,myValue);
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
						m_UnitConvert =Convert.ToString(myReader["UnitConvert"]);
						m_UnitRate =Convert.ToSingle(myReader["UnitRate"]);
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

                        m_TrongTam01 = Convert.ToString(myReader["TrongTam01"]);
                        m_TrongTam02 = Convert.ToString(myReader["TrongTam02"]);
                        m_TrongTam03 = Convert.ToString(myReader["TrongTam03"]);

                        m_GhiChu01 = Convert.ToString(myReader["GhiChu01"]);
                        m_GhiChu02 = Convert.ToString(myReader["GhiChu02"]);
                        m_GhiChu03 = Convert.ToString(myReader["GhiChu03"]);

                        if (!myReader.IsDBNull(myReader.GetOrdinal("Photo")))
                        {
                            if (myReader["Photo"] != Convert.DBNull)
                            {
                                var vImage = (byte[])myReader["Photo"];
                                if (vImage.Length != 2)
                                {
                                    var ms = new MemoryStream(vImage);
                                    m_photo = Image.FromStream(ms);
                                }
                                if (vImage.Length == 2)
                                {
                                    m_photo = null;
                                }
                            }

                        }
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

        public string GetByStore(string Product_ID)
        {
            string Result = "";
            string[] myPara = { "@Product_ID" };
            object[] myValue = { Product_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PRODUCT_GetByStore", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_Product_Name = Convert.ToString(myReader["Product_Name"]);
                    m_Product_Type_ID = Convert.ToInt32(myReader["Product_Type_ID"]);
                    m_Manufacturer_ID = Convert.ToInt32(myReader["Manufacturer_ID"]);
                    m_Product_Group_ID = Convert.ToString(myReader["Product_Group_ID"]);
                    m_Provider_ID = Convert.ToString(myReader["Provider_ID"]);
                    m_Origin = Convert.ToString(myReader["Origin"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_Unit = Convert.ToString(myReader["Unit"]);
                    m_UnitConvert = Convert.ToString(myReader["UnitConvert"]);
                    m_UnitRate = Convert.ToSingle(myReader["UnitRate"]);
                    m_Org_Price = Convert.ToSingle(myReader["Org_Price"]);
                    m_Sale_Price = Convert.ToSingle(myReader["Sale_Price"]);
                    m_Retail_Price = Convert.ToSingle(myReader["Retail_Price"]);
                    m_Quantity = Convert.ToSingle(myReader["Quantity"]);
                    m_CurrentCost = Convert.ToSingle(myReader["CurrentCost"]);
                    m_AverageCost = Convert.ToSingle(myReader["AverageCost"]);
                    m_Warranty = Convert.ToInt32(myReader["Warranty"]);
                    m_VAT_ID = Convert.ToSingle(myReader["VAT_ID"]);
                    m_ImportTax_ID = Convert.ToSingle(myReader["ImportTax_ID"]);
                    m_ExportTax_ID = Convert.ToSingle(myReader["ExportTax_ID"]);
                    m_LuxuryTax_ID = Convert.ToSingle(myReader["LuxuryTax_ID"]);
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"]);
                    m_Customer_Name = Convert.ToString(myReader["Customer_Name"]);
                    m_CostMethod = Convert.ToInt16(myReader["CostMethod"]);
                    m_MinStock = Convert.ToSingle(myReader["MinStock"]);
                    m_MaxStock = Convert.ToSingle(myReader["MaxStock"]);
                    m_Discount = Convert.ToSingle(myReader["Discount"]);
                    m_Commission = Convert.ToSingle(myReader["Commission"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Color = Convert.ToString(myReader["Color"]);
                    m_Expiry = Convert.ToBoolean(myReader["Expiry"]);
                    m_LimitOrders = Convert.ToSingle(myReader["LimitOrders"]);
                    m_ExpiryValue = Convert.ToSingle(myReader["ExpiryValue"]);
                    m_Batch = Convert.ToBoolean(myReader["Batch"]);
                    m_Depth = Convert.ToSingle(myReader["Depth"]);
                    m_Height = Convert.ToSingle(myReader["Height"]);
                    m_Width = Convert.ToSingle(myReader["Width"]);
                    m_Thickness = Convert.ToSingle(myReader["Thickness"]);
                    m_Size = Convert.ToString(myReader["Size"]);
                    m_UserID = Convert.ToString(myReader["UserID"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);

                    //m_TrongTam01 = Convert.ToString(myReader["TrongTam01"]);
                    //m_TrongTam02 = Convert.ToString(myReader["TrongTam02"]);
                    //m_TrongTam03 = Convert.ToString(myReader["TrongTam03"]);

                    //m_GhiChu01 = Convert.ToString(myReader["GhiChu01"]);
                    //m_GhiChu02 = Convert.ToString(myReader["GhiChu02"]);
                    //m_GhiChu03 = Convert.ToString(myReader["GhiChu03"]);

                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string Get(string Product_ID, string Stock_ID)
        {
            string Result = "";
            string[] myPara = { "@Product_ID", "@Stock_ID" };
            object[] myValue = { Product_ID, Stock_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PRODUCT_GetByStock", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_Product_Name = Convert.ToString(myReader["Product_Name"]);
                    m_Unit = Convert.ToString(myReader["Unit"]);
                    m_UnitConvert = Convert.ToString(myReader["UnitConvert"]);
                    m_UnitRate = Convert.ToSingle(myReader["UnitRate"]);
                    m_Org_Price = Convert.ToSingle(myReader["Org_Price"]);
                    m_Quantity = Convert.ToSingle(myReader["Quantity"]);
                    m_AverageCost = Convert.ToSingle(myReader["AverageCost"]);
                    m_Product_Type_ID = Convert.ToInt32(myReader["Product_Type_ID"]);
                    m_MinStock = Convert.ToSingle(myReader["MinStock"]);
                    m_MaxStock = Convert.ToSingle(myReader["MaxStock"]);

                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string GetByStockAll(string Product_ID, string Stock_ID)
        {
            string Result = "";
            string[] myPara = { "@Product_ID", "@Stock_ID" };
            object[] myValue = { Product_ID, Stock_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PRODUCT_GetByStockAll", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_Product_Name = Convert.ToString(myReader["Product_Name"]);
                    m_Unit = Convert.ToString(myReader["Unit"]);
                    m_UnitConvert = Convert.ToString(myReader["UnitConvert"]);
                    m_UnitRate = Convert.ToSingle(myReader["UnitRate"]);
                    m_Org_Price = Convert.ToSingle(myReader["Org_Price"]);
                    m_Quantity = Convert.ToSingle(myReader["Quantity"]);
                    m_AverageCost = Convert.ToSingle(myReader["AverageCost"]);
                    m_Product_Type_ID = Convert.ToInt32(myReader["Product_Type_ID"]); 
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string GetByStockAll(SqlTransaction myTransaction,string Product_ID, string Stock_ID)
        {
            string Result = "";
            string[] myPara = { "@Product_ID", "@Stock_ID" };
            object[] myValue = { Product_ID, Stock_ID };

            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction,"PRODUCT_GetByStockAll", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_Product_Name = Convert.ToString(myReader["Product_Name"]);
                    m_Unit = Convert.ToString(myReader["Unit"]);
                    m_UnitConvert = Convert.ToString(myReader["UnitConvert"]);
                    m_UnitRate = Convert.ToSingle(myReader["UnitRate"]);
                    m_Org_Price = Convert.ToSingle(myReader["Org_Price"]);
                    m_Quantity = Convert.ToSingle(myReader["Quantity"]);
                    m_AverageCost = Convert.ToSingle(myReader["AverageCost"]);
                    m_Product_Type_ID = Convert.ToInt32(myReader["Product_Type_ID"]);
                    m_MinStock = Convert.ToDouble(myReader["MinStock"]);
                    m_MaxStock = Convert.ToDouble(myReader["MaxStock"]);
                    Result = "OK";
                }
                myReader.Close();
            }
            return Result;
        }

		public string Get(SqlConnection myConnection,string Product_ID)
		{
			string Result="";
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM PRODUCT p WHERE p.Product_ID = @Product_ID ";

			SqlDataReader myReader=mySql.ExecuteReader(myConnection,sql,myPara,myValue);
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
						m_UnitConvert =Convert.ToString(myReader["UnitConvert"]);
						m_UnitRate =Convert.ToSingle(myReader["UnitRate"]);
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
                        m_TrongTam01 = Convert.ToString(myReader["TrongTam01"]);
                        m_TrongTam02 = Convert.ToString(myReader["TrongTam02"]);
                        m_TrongTam03 = Convert.ToString(myReader["TrongTam03"]);

                        m_GhiChu01 = Convert.ToString(myReader["GhiChu01"]);
                        m_GhiChu02 = Convert.ToString(myReader["GhiChu02"]);
                        m_GhiChu03 = Convert.ToString(myReader["GhiChu03"]);
    

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
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"SELECT * FROM PRODUCT p WHERE p.Product_ID = @Product_ID ";
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,sql,myPara,myValue);
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
						m_UnitConvert =Convert.ToString(myReader["UnitConvert"]);
						m_UnitRate =Convert.ToSingle(myReader["UnitRate"]);
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
                        m_TrongTam01 = Convert.ToString(myReader["TrongTam01"]);
                        m_TrongTam02 = Convert.ToString(myReader["TrongTam02"]);
                        m_TrongTam03 = Convert.ToString(myReader["TrongTam03"]);

                        m_GhiChu01 = Convert.ToString(myReader["GhiChu01"]);
                        m_GhiChu02 = Convert.ToString(myReader["GhiChu02"]);
                        m_GhiChu03 = Convert.ToString(myReader["GhiChu03"]);

						m_Active =Convert.ToBoolean(myReader["Active"]);


						Result="OK";
				}
				myReader.Dispose();
				//mySql.Close();
				myReader = null;
			}
			return Result;
		}

        public string GetProductInventory(SqlTransaction myTransaction, string Product_ID, string Stock_ID)
        {
            string Result = "";

            #region sql
            string sql = @"

	SELECT B.Stock_ID,
	       s.Stock_Name,
	       ----
	       B.Product_ID,
	       p.Product_Name,
	       B.Quantity,
	       u.Unit_Name              AS Unit,
	       ----
	       CASE 
	            WHEN pu.UnitConvert IS NULL THEN NULL
	            ELSE pu.UnitConvert
	       END                      AS ConvertValues,
	       ----
	       CASE 
	            WHEN pu.UnitConvert IS NULL THEN B.Quantity
	            ELSE B.Quantity % pu.UnitConvert
	       END                      AS OrgQuantity,
	       ------
	       
	       CASE 
	            WHEN pu.UnitConvert IS NULL THEN NULL
	            ELSE (B.Quantity -(B.Quantity % pu.UnitConvert)) / pu.UnitConvert
	       END                      AS ConvertQuantity,
	       CASE 
	            WHEN pu.UnitConvert IS NULL THEN NULL
	            ELSE uu.Unit_Name
	       END                      AS UnitConvert,
	       p.[Active]
	FROM   (
	           SELECT A.Stock_ID,
	                  A.Product_ID,
	                  A.Unit,
	                  SUM(
	                      CASE 
	                           WHEN A.RefStatus = 1 THEN A.Quantity
	                           WHEN A.RefStatus = 3 THEN A.Quantity
	                           ELSE A.Quantity * -1
	                      END
	                  )  AS Quantity
	           FROM   (
	                      SELECT id.Stock_ID,
	                             id.Product_ID,
	                             CASE 
	                                  WHEN pu.Unit_ID IS NULL THEN id.Unit
	                                  ELSE pu.Unit_ID
	                             END  AS Unit,
	                             id.RefStatus,
	                             CASE 
	                                  WHEN pu.UnitConvert IS NULL THEN id.Quantity
	                                  ELSE id.Quantity * pu.UnitConvert
	                             END  AS Quantity
	                      FROM   (
	                                 -- Nhập kho
	                                 SELECT sid1.Stock_ID,
	                                        sid1.Product_ID,
	                                        CAST(1 AS SMALLINT) AS RefStatus,
	                                        sid1.Unit,
	                                        sid1.Quantity
	                                 FROM   STOCK_INWARD_DETAIL AS sid1
	                                 WHERE  sid1.Stock_ID = @Stock_ID
	                                        AND sid1.Product_ID = @Product_ID
	                                 -- Xuất kho
	                                 UNION ALL
	                                 
	                                 SELECT sod.Stock_ID,
	                                        sod.Product_ID,
	                                        CAST(2 AS SMALLINT) AS RefStatus,
	                                        sod.Unit,
	                                        sod.Quantity
	                                 FROM   STOCK_OUTWARD_DETAIL AS sod
	                                 WHERE  sod.Stock_ID = @Stock_ID
	                                        AND sod.Product_ID = @Product_ID
	                                 -------------------------------------------
	                                 -- Chuyển kho
	                                 -------------------------------------------
	                                 -- Nhập chuyển kho
	                                UNION ALL
	                                 
	                                 SELECT std.InStock AS Stock_ID,
	                                        std.Product_ID,
	                                        CAST(1 AS SMALLINT) AS RefStatus,
	                                        std.Unit,
	                                        std.Quantity
	                                 FROM   STOCK_TRANSFER_DETAIL AS std
	                                 WHERE  std.InStock = @Stock_ID
	                                        AND std.Product_ID = @Product_ID
	                                 -- Xuất chuyển kho
	                                 UNION ALL
	                                 
	                                 SELECT std.OutStock AS Stock_ID,
	                                        std.Product_ID,
	                                        CAST(2 AS SMALLINT) AS RefStatus,
	                                        std.Unit,
	                                        std.Quantity
	                                 FROM   STOCK_TRANSFER_DETAIL AS std
	                                 WHERE  std.OutStock = @Stock_ID
	                                        AND std.Product_ID = @Product_ID
	                                 -------------------------------------------
	                                 -- KIỂM KÊ
	                                 -------------------------------------------
	                                 UNION ALL
	                                 
	                                 SELECT std.Stock_ID,
	                                        std.Product_ID,
	                                        CAST(3 AS SMALLINT) AS RefStatus,
	                                        std.Unit,
	                                        std.QtyDiff AS Quantity
	                                 FROM   ADJUSTMENT_DETAIL AS std
	                                 WHERE  std.Stock_ID = @Stock_ID
	                                        AND std.Product_ID = @Product_ID
	                             )    AS id
	                             LEFT JOIN PRODUCT_UNIT AS pu
	                                  ON  pu.Product_ID = id.Product_ID
	                                  AND id.Unit = pu.UnitConvert_ID
	                  )     A
	           GROUP BY
	                  A.Stock_ID,
	                  A.Product_ID,
	                  A.Unit
	       )B
	       LEFT JOIN PRODUCT_UNIT   AS pu
	            ON  pu.Product_ID = B.Product_ID
	            AND pu.Unit_ID = B.Unit
	       LEFT OUTER JOIN UNIT     AS u
	            ON  u.Unit_ID = B.Unit
	       LEFT OUTER JOIN UNIT     AS uu
	            ON  uu.Unit_ID = pu.UnitConvert_ID
	       LEFT JOIN STOCK          AS s
	            ON  s.Stock_ID = B.Stock_ID
	       LEFT OUTER JOIN PRODUCT  AS p
	            ON  p.Product_ID = B.Product_ID
	ORDER BY
	       B.Product_ID
";

            #endregion  
            
            string[] myPara = { "@Product_ID", "@Stock_ID"};
            object[] myValue = { Product_ID, Stock_ID };

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, sql, myPara, myValue);
            //SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "sp_GetProductInventory", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_Product_Name = Convert.ToString(myReader["Product_Name"]);
                    m_Unit = Convert.ToString(myReader["Unit"]); 
                    m_Quantity = Convert.ToSingle(myReader["Quantity"]);
                    Result = "OK";
                }
                myReader.Close();
            }
            return Result;
        }

		#endregion
		
		#region Add
		public string Insert()
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active",
                                "@TrongTam01",
                                "@TrongTam02",
                                "@TrongTam03",
                                "@GhiChu01",
                                "@GhiChu02",
                                "@GhiChu03"

                            };
			object[] myValue={m_Product_ID,m_Product_Name,m_Product_Type_ID,m_Manufacturer_ID,m_Product_Group_ID,m_Provider_ID,m_Origin,m_Barcode,m_Unit,m_UnitConvert,m_UnitRate,m_Org_Price,m_Sale_Price,m_Retail_Price,m_Quantity,m_CurrentCost,m_AverageCost,m_Warranty,m_VAT_ID,m_ImportTax_ID,m_ExportTax_ID,m_LuxuryTax_ID,m_Customer_ID,m_Customer_Name,m_CostMethod,m_MinStock,m_MaxStock,m_Discount,m_Commission,m_Description,m_Color,m_Expiry,m_LimitOrders,m_ExpiryValue,m_Batch,m_Depth,m_Height,m_Width,m_Thickness,m_Size,m_UserID,m_Active,
                             m_TrongTam01,
                             m_TrongTam02,
                             m_TrongTam03,
                             m_GhiChu01,
                             m_GhiChu02,
                             m_GhiChu03
                             };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO [PRODUCT]
	  (
	    Product_ID,
	    Product_Name,
	    Product_Type_ID,
	    Manufacturer_ID,
	    Product_Group_ID,
	    Provider_ID,
	    Origin,
	    Barcode,
	    Unit,
	    UnitConvert,
	    UnitRate,
	    Org_Price,
	    Sale_Price,
	    Retail_Price,
	    Quantity,
	    CurrentCost,
	    AverageCost,
	    Warranty,
	    VAT_ID,
	    ImportTax_ID,
	    ExportTax_ID,
	    LuxuryTax_ID,
	    Customer_ID,
	    Customer_Name,
	    CostMethod,
	    MinStock,
	    MaxStock,
	    Discount,
	    Commission,
	    DESCRIPTION,
	    Color,
	    Expiry,
	    LimitOrders,
	    ExpiryValue,
	    Batch,
	    Depth,
	    Height,
	    Width,
	    Thickness,
	    SIZE,
	    UserID,
	    [Active],
	    TrongTam01,
	    TrongTam02,
	    TrongTam03,
	    GhiChu01,
	    GhiChu02,
	    GhiChu03
	  )
	VALUES
	  (
	    @Product_ID,
	    @Product_Name,
	    @Product_Type_ID,
	    @Manufacturer_ID,
	    @Product_Group_ID,
	    @Provider_ID,
	    @Origin,
	    @Barcode,
	    @Unit,
	    @UnitConvert,
	    @UnitRate,
	    @Org_Price,
	    @Sale_Price,
	    @Retail_Price,
	    @Quantity,
	    @CurrentCost,
	    @AverageCost,
	    @Warranty,
	    @VAT_ID,
	    @ImportTax_ID,
	    @ExportTax_ID,
	    @LuxuryTax_ID,
	    @Customer_ID,
	    @Customer_Name,
	    @CostMethod,
	    @MinStock,
	    @MaxStock,
	    @Discount,
	    @Commission,
	    @Description,
	    @Color,
	    @Expiry,
	    @LimitOrders,
	    @ExpiryValue,
	    @Batch,
	    @Depth,
	    @Height,
	    @Width,
	    @Thickness,
	    @Size,
	    @UserID,
	    @Active,
	    @TrongTam01,
	    @TrongTam02,
	    @TrongTam03,
	    @GhiChu01,
	    @GhiChu02,
	    @GhiChu03
	  )";
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID",
                                "@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode",
                                "@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price",
                                "@Retail_Price","@Quantity",
                                "@CurrentCost","@AverageCost","@Warranty",
                                "@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active",
                                "@TrongTam01",
                                "@TrongTam02",
                                "@TrongTam03",
                                "@GhiChu01",
                                "@GhiChu02",
                                "@GhiChu03"
                            };
			object[] myValue={m_Product_ID,m_Product_Name,m_Product_Type_ID,m_Manufacturer_ID,m_Product_Group_ID,m_Provider_ID,m_Origin,m_Barcode,m_Unit,m_UnitConvert,m_UnitRate,m_Org_Price,m_Sale_Price,m_Retail_Price,m_Quantity,m_CurrentCost,m_AverageCost,m_Warranty,m_VAT_ID,m_ImportTax_ID,m_ExportTax_ID,m_LuxuryTax_ID,m_Customer_ID,m_Customer_Name,m_CostMethod,m_MinStock,m_MaxStock,m_Discount,m_Commission,m_Description,m_Color,m_Expiry,m_LimitOrders,m_ExpiryValue,m_Batch,m_Depth,m_Height,m_Width,m_Thickness,m_Size,m_UserID,m_Active,
                             m_TrongTam01,
                             m_TrongTam02,
                             m_TrongTam03,
                             m_GhiChu01,
                             m_GhiChu02,
                             m_GhiChu03
                             };
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO [PRODUCT]
	  (
	    Product_ID,
	    Product_Name,
	    Product_Type_ID,
	    Manufacturer_ID,
	    Product_Group_ID,
	    Provider_ID,
	    Origin,
	    Barcode,
	    Unit,
	    UnitConvert,
	    UnitRate,
	    Org_Price,
	    Sale_Price,
	    Retail_Price,
	    Quantity,
	    CurrentCost,
	    AverageCost,
	    Warranty,
	    VAT_ID,
	    ImportTax_ID,
	    ExportTax_ID,
	    LuxuryTax_ID,
	    Customer_ID,
	    Customer_Name,
	    CostMethod,
	    MinStock,
	    MaxStock,
	    Discount,
	    Commission,
	    DESCRIPTION,
	    Color,
	    Expiry,
	    LimitOrders,
	    ExpiryValue,
	    Batch,
	    Depth,
	    Height,
	    Width,
	    Thickness,
	    SIZE,
	    UserID,
	    [Active],
	    TrongTam01,
	    TrongTam02,
	    TrongTam03,
	    GhiChu01,
	    GhiChu02,
	    GhiChu03
	  )
	VALUES
	  (
	    @Product_ID,
	    @Product_Name,
	    @Product_Type_ID,
	    @Manufacturer_ID,
	    @Product_Group_ID,
	    @Provider_ID,
	    @Origin,
	    @Barcode,
	    @Unit,
	    @UnitConvert,
	    @UnitRate,
	    @Org_Price,
	    @Sale_Price,
	    @Retail_Price,
	    @Quantity,
	    @CurrentCost,
	    @AverageCost,
	    @Warranty,
	    @VAT_ID,
	    @ImportTax_ID,
	    @ExportTax_ID,
	    @LuxuryTax_ID,
	    @Customer_ID,
	    @Customer_Name,
	    @CostMethod,
	    @MinStock,
	    @MaxStock,
	    @Discount,
	    @Commission,
	    @Description,
	    @Color,
	    @Expiry,
	    @LimitOrders,
	    @ExpiryValue,
	    @Batch,
	    @Depth,
	    @Height,
	    @Width,
	    @Thickness,
	    @Size,
	    @UserID,
	    @Active,
	    @TrongTam01,
	    @TrongTam02,
	    @TrongTam03,
	    @GhiChu01,
	    @GhiChu02,
	    @GhiChu03
	  )";
			return mySql.ExecuteNonQuery(myTransaction,sql,myPara,myValue);
		}
		public string Insert(string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,string UnitConvert,double UnitRate,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,UnitConvert,UnitRate,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"INSERT INTO [PRODUCT]
	  (
	    Product_ID,
	    Product_Name,
	    Product_Type_ID,
	    Manufacturer_ID,
	    Product_Group_ID,
	    Provider_ID,
	    Origin,
	    Barcode,
	    Unit,
	    UnitConvert,
	    UnitRate,
	    Org_Price,
	    Sale_Price,
	    Retail_Price,
	    Quantity,
	    CurrentCost,
	    AverageCost,
	    Warranty,
	    VAT_ID,
	    ImportTax_ID,
	    ExportTax_ID,
	    LuxuryTax_ID,
	    Customer_ID,
	    Customer_Name,
	    CostMethod,
	    MinStock,
	    MaxStock,
	    Discount,
	    Commission,
	    DESCRIPTION,
	    Color,
	    Expiry,
	    LimitOrders,
	    ExpiryValue,
	    Batch,
	    Depth,
	    Height,
	    Width,
	    Thickness,
	    SIZE,
	    UserID,
	    [Active],
	    TrongTam01,
	    TrongTam02,
	    TrongTam03,
	    GhiChu01,
	    GhiChu02,
	    GhiChu03
	  )
	VALUES
	  (
	    @Product_ID,
	    @Product_Name,
	    @Product_Type_ID,
	    @Manufacturer_ID,
	    @Product_Group_ID,
	    @Provider_ID,
	    @Origin,
	    @Barcode,
	    @Unit,
	    @UnitConvert,
	    @UnitRate,
	    @Org_Price,
	    @Sale_Price,
	    @Retail_Price,
	    @Quantity,
	    @CurrentCost,
	    @AverageCost,
	    @Warranty,
	    @VAT_ID,
	    @ImportTax_ID,
	    @ExportTax_ID,
	    @LuxuryTax_ID,
	    @Customer_ID,
	    @Customer_Name,
	    @CostMethod,
	    @MinStock,
	    @MaxStock,
	    @Discount,
	    @Commission,
	    @Description,
	    @Color,
	    @Expiry,
	    @LimitOrders,
	    @ExpiryValue,
	    @Batch,
	    @Depth,
	    @Height,
	    @Width,
	    @Thickness,
	    @Size,
	    @UserID,
	    @Active,
	    @TrongTam01,
	    @TrongTam02,
	    @TrongTam03,
	    @GhiChu01,
	    @GhiChu02,
	    @GhiChu03
	  )";
			return mySql.ExecuteNonQuery(sql,myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,string UnitConvert,double UnitRate,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,UnitConvert,UnitRate,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,string UnitConvert,double UnitRate,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,UnitConvert,UnitRate,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active",
                                "@TrongTam01",
                                "@TrongTam02",
                                "@TrongTam03",
                                "@GhiChu01",
                                "@GhiChu02",
                                "@GhiChu03"
                            };
			object[] myValue={m_Product_ID,m_Product_Name,m_Product_Type_ID,m_Manufacturer_ID,m_Product_Group_ID,m_Provider_ID,m_Origin,m_Barcode,m_Unit,m_UnitConvert,m_UnitRate,m_Org_Price,m_Sale_Price,m_Retail_Price,m_Quantity,m_CurrentCost,m_AverageCost,m_Warranty,m_VAT_ID,m_ImportTax_ID,m_ExportTax_ID,m_LuxuryTax_ID,m_Customer_ID,m_Customer_Name,m_CostMethod,m_MinStock,m_MaxStock,m_Discount,m_Commission,m_Description,m_Color,m_Expiry,m_LimitOrders,m_ExpiryValue,m_Batch,m_Depth,m_Height,m_Width,m_Thickness,m_Size,m_UserID,m_Active,
                             m_TrongTam01,
                             m_TrongTam02,
                             m_TrongTam03,
                             m_GhiChu01,
                             m_GhiChu02,
                             m_GhiChu03
                             };
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_Update",myPara,myValue);
		}

        public string Update(SqlTransaction myTransaction)
        {
            string[] myPara = { "@Product_ID", "@Product_Name", "@Product_Type_ID",
                                  "@Manufacturer_ID", "@Product_Group_ID", "@Provider_ID", "@Origin", "@Barcode",
                                  "@Unit", "@UnitConvert", "@UnitRate", "@Org_Price", "@Sale_Price", "@Retail_Price",
                                  "@Quantity", "@CurrentCost", "@AverageCost", "@Warranty", "@VAT_ID", "@ImportTax_ID", "@ExportTax_ID", "@LuxuryTax_ID", "@Customer_ID", "@Customer_Name", "@CostMethod", "@MinStock", "@MaxStock", "@Discount", "@Commission", "@Description", "@Color", "@Expiry", "@LimitOrders", "@ExpiryValue", "@Batch", "@Depth", "@Height", "@Width", "@Thickness", "@Size", "@UserID", "@Active",
                                "@TrongTam01",
                                "@TrongTam02",
                                "@TrongTam03",
                                "@GhiChu01",
                                "@GhiChu02",
                                "@GhiChu03"
                              };
            object[] myValue = { m_Product_ID, m_Product_Name, m_Product_Type_ID, m_Manufacturer_ID, m_Product_Group_ID, m_Provider_ID, m_Origin, m_Barcode, m_Unit, m_UnitConvert, m_UnitRate, m_Org_Price, m_Sale_Price, m_Retail_Price, m_Quantity, m_CurrentCost, m_AverageCost, m_Warranty, m_VAT_ID, m_ImportTax_ID, m_ExportTax_ID, m_LuxuryTax_ID, m_Customer_ID, m_Customer_Name, m_CostMethod, m_MinStock, m_MaxStock, m_Discount, m_Commission, m_Description, m_Color, m_Expiry, m_LimitOrders, m_ExpiryValue, m_Batch, m_Depth, m_Height, m_Width, m_Thickness, m_Size, m_UserID, m_Active,
                                m_TrongTam01,
                                 m_TrongTam02,
                                 m_TrongTam03,
                                 m_GhiChu01,
                                 m_GhiChu02,
                                 m_GhiChu03
                               };
            var mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string sql = @"UPDATE [PRODUCT]
	SET    Product_Name      = @Product_Name,
	       Product_Type_ID   = @Product_Type_ID,
	       Manufacturer_ID   = @Manufacturer_ID,
	       Product_Group_ID  = @Product_Group_ID,
	       Provider_ID       = @Provider_ID,
	       Origin            = @Origin,
	       Barcode           = @Barcode,
	       Unit              = @Unit,
	       UnitConvert       = @UnitConvert,
	       UnitRate          = @UnitRate,
	       Org_Price         = @Org_Price,
	       Sale_Price        = @Sale_Price,
	       Retail_Price      = @Retail_Price,
           Quantity          = @Quantity,
	       Warranty          = @Warranty,
	       VAT_ID            = @VAT_ID,
	       ImportTax_ID      = @ImportTax_ID,
	       ExportTax_ID      = @ExportTax_ID,
	       LuxuryTax_ID      = @LuxuryTax_ID,
	       Customer_ID       = @Customer_ID,
	       Customer_Name     = @Customer_Name,
	       CostMethod        = @CostMethod,
	       MinStock          = @MinStock,
	       MaxStock          = @MaxStock,
	       Discount          = @Discount,
	       Commission        = @Commission,
	       DESCRIPTION       = @Description,
	       Color             = @Color,
	       Expiry            = @Expiry,
	       LimitOrders       = @LimitOrders,
	       ExpiryValue       = @ExpiryValue,
	       Batch             = @Batch,
	       Depth             = @Depth,
	       Height            = @Height,
	       Width             = @Width,
	       Thickness         = @Thickness,
	       SIZE              = @Size,
	       UserID            = @UserID,
	       ACTIVE            = @Active,
	       
	       TrongTam01 = @TrongTam01,
	       TrongTam02 = @TrongTam02,
	       TrongTam03 = @TrongTam03,
	       GhiChu01 = @GhiChu01,
	       GhiChu02 = @GhiChu02,
	       GhiChu03 = @GhiChu03
	       
	WHERE  Product_ID        = @Product_ID";
            return mySql.ExecuteNonQuery(myTransaction,sql, myPara, myValue);
        }

	    public string Update(SqlConnection myConnection,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,string UnitConvert,double UnitRate,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,UnitConvert,UnitRate,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Product_ID,string Product_Name,int Product_Type_ID,int Manufacturer_ID,string Product_Group_ID,string Provider_ID,string Origin,string Barcode,string Unit,string UnitConvert,double UnitRate,double Org_Price,double Sale_Price,double Retail_Price,double Quantity,double CurrentCost,double AverageCost,int Warranty,double VAT_ID,double ImportTax_ID,double ExportTax_ID,double LuxuryTax_ID,string Customer_ID,string Customer_Name,int CostMethod,double MinStock,double MaxStock,double Discount,double Commission,string Description,string Color,bool Expiry,double LimitOrders,double ExpiryValue,bool Batch,double Depth,double Height,double Width,double Thickness,string Size,string UserID,bool Active)
		{
			string[] myPara={"@Product_ID","@Product_Name","@Product_Type_ID","@Manufacturer_ID","@Product_Group_ID","@Provider_ID","@Origin","@Barcode","@Unit","@UnitConvert","@UnitRate","@Org_Price","@Sale_Price","@Retail_Price","@Quantity","@CurrentCost","@AverageCost","@Warranty","@VAT_ID","@ImportTax_ID","@ExportTax_ID","@LuxuryTax_ID","@Customer_ID","@Customer_Name","@CostMethod","@MinStock","@MaxStock","@Discount","@Commission","@Description","@Color","@Expiry","@LimitOrders","@ExpiryValue","@Batch","@Depth","@Height","@Width","@Thickness","@Size","@UserID","@Active"};
			object[] myValue={Product_ID,Product_Name,Product_Type_ID,Manufacturer_ID,Product_Group_ID,Provider_ID,Origin,Barcode,Unit,UnitConvert,UnitRate,Org_Price,Sale_Price,Retail_Price,Quantity,CurrentCost,AverageCost,Warranty,VAT_ID,ImportTax_ID,ExportTax_ID,LuxuryTax_ID,Customer_ID,Customer_Name,CostMethod,MinStock,MaxStock,Discount,Commission,Description,Color,Expiry,LimitOrders,ExpiryValue,Batch,Depth,Height,Width,Thickness,Size,UserID,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={m_Product_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_Delete",myPara,myValue);
		}
		public string Delete(string Product_ID)
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Product_ID)
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Product_ID)
		{
			string[] myPara={"@Product_ID"};
			object[] myValue={Product_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("PRODUCT_GetList");
		}

        public DataTable GetFull()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("PRODUCT_GetFull");
        }

        public DataTable GetPack()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("PRODUCT_GetPack");
        }

        public DataTable Search(string Product_ID, string Product_Name)
        {
            string[] myPara ={ "@Product_ID", "@Product_Name" };
            object[] myValue ={ "%" + Product_ID + "%", "%" + Product_Name + "%" };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("PRODUCT_Search", myPara, myValue);
        }
        public DataTable GetList_Init(string Product_ID, string Product_Name,string Stock_ID)
        {
            string[] myPara ={ "@Product_ID", "@ProductName","@Stock_ID" };
            object[] myValue ={ "%" + Product_ID + "%", "%" + Product_Name + "%",Stock_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("INVENTORY_GetList_Init", myPara, myValue);
        }
        public DataTable GetList_Build()
        {
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("PRODUCT_GetList_Build");
        }

        public DataTable GetList_TP()
        {
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("PRODUCT_Get_TP");
        }

        public DataTable GetList_BTP()
        {
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("PRODUCT_Get_BTP");
        }

		#endregion

        #region Custom
        public string Update(SqlConnection myConnection, string Product_ID, string Product_Group_ID)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "UPDATE PRODUCT SET Product_Group_ID = N'"+ Product_Group_ID +"' WHERE Product_ID=N'"+ Product_ID +"'");
        }

        public string Update(SqlTransaction myTransaction,string Product_ID,Image photo)
        {
            
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            mySql.Error += DispError;
            byte[] vImage;
            if (photo != null)
            {
                MemoryStream ms = new MemoryStream();
                photo.Save(ms, photo.RawFormat);
                vImage = ms.GetBuffer();
                ms.Close();
                //Result = cls.Update_Image(gs.Transaction, txtEmployee_ID.Text, vImage);
            }
            else
            {
                vImage = new byte[2];
            }
            string[] myPara = { "@Product_ID", "@Photo" };
            object[] myValue = { Product_ID, vImage };

            //return mySql.ExecuteNonQuery(myTransaction, "Update PRODUCT set Photo=@Photo WHERE Product_ID=N'" + Product_ID + "'");
            return mySql.ExecuteNonQuery(myTransaction, "Update PRODUCT set Photo=@Photo WHERE Product_ID=@Product_ID",myPara,myValue);
        }
        public string Update(SqlTransaction myTransaction, string idSrc, string idDesc)
        {

            SqlHelper mySql = new SqlHelper();
            
            mySql.Error += DispError;

            string[] myPara = { "@IdSrc", "@IdDesc" };
            object[] myValue = { idSrc, idDesc };

            //return mySql.ExecuteNonQuery(myTransaction, "Update PRODUCT set Photo=@Photo WHERE Product_ID=N'" + Product_ID + "'");
            return mySql.ExecuteNonQuery(myTransaction, "PRODUCT_mergByProductId", myPara, myValue);
        }
        public string ChangeId(SqlTransaction myTransaction, string idSrc, string idDesc)
        {

            SqlHelper mySql = new SqlHelper();

            mySql.Error += DispError;

            string[] myPara = { "@IdSrc", "@IdDesc" };
            object[] myValue = { idSrc, idDesc };

            //return mySql.ExecuteNonQuery(myTransaction, "Update PRODUCT set Photo=@Photo WHERE Product_ID=N'" + Product_ID + "'");
            return mySql.ExecuteNonQuery(myTransaction, "PRODUCT_ChangeProductId", myPara, myValue);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        #endregion
        
		
		#region Insert Combo
		
		public void AddCombo(System.Windows.Forms.ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "PRODUCT_Name", "PRODUCT_ID");
		}

        public void AddComboAll(System.Windows.Forms.ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["PRODUCT_ID"] = "All";
			b["PRODUCT_Name"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "PRODUCT_Name", "PRODUCT_ID");
		}
		#endregion
		
	}
}
