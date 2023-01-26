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
    /// Generated Class for Table : STOCK_INWARD_DETAIL.
    /// Date: 19/01/2010
    /// Author: Trần Hoàng Tâm
    /// </summary>
    public class STOCK_INWARD_DETAIL : Object
    {
        #region Init
        private string m_ID;
        private string m_Inward_ID;
        private string m_Product_ID;
        private string m_ProductName;
        private int m_RefType;
        private string m_Stock_ID;
		private decimal m_Lev1;
		private decimal m_Lev2;
		private decimal m_Lev3;
		private decimal m_Lev4;
        private string m_Unit;
        private decimal m_UnitConvert;
        private int m_Vat;
        private decimal m_VatAmount;
        private decimal m_CurrentQty;
        private decimal m_Quantity;
        private decimal m_UnitPrice;
        private decimal m_Amount;
        private decimal m_QtyConvert;
        private decimal m_DiscountRate;
        private decimal m_Discount;
        private decimal m_Charge;
        private DateTime m_Limit;
        private decimal m_Width;
        private decimal m_Height;
        private string m_Orgin;
        private string m_Size;
        private string m_Color;
        private string m_Batch;
        private string m_Serial;
        private string m_ChassyNo;
        private string m_IME;
        private long m_StoreID;
        private string m_Description;
        private long m_Sorted;
        private bool m_Active;


        public STOCK_INWARD_DETAIL()
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = "";
            m_Inward_ID = "";
            m_Product_ID = "";
            m_ProductName = "";
            m_RefType = 0;
            m_Stock_ID = "";
			 m_Lev1=0;
			 m_Lev2=0;
			 m_Lev3=0;
			 m_Lev4=0;
            m_Unit = "";
            m_UnitConvert = 0;
            m_Vat = 0;
            m_VatAmount = 0;
            m_CurrentQty = 0;
            m_Quantity = 0;
            m_UnitPrice = 0;
            m_Amount = 0;
            m_QtyConvert = 0;
            m_DiscountRate = 0;
            m_Discount = 0;
            m_Charge = 0;
            m_Limit = DateTime.Now;
            m_Width = 0;
            m_Height = 0;
            m_Orgin = "";
            m_Size = "";
            m_Color = "";
            m_Batch = "";
            m_Serial = "";
            m_ChassyNo = "";
            m_IME = "";
            m_StoreID = 0;
            m_Description = "";
            m_Sorted = 0;
            m_Active = true;
        }
        public STOCK_INWARD_DETAIL(
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_Inward_ID = Inward_ID;
            m_Product_ID = Product_ID;
            m_ProductName = ProductName;
            m_RefType = RefType;
            m_Stock_ID = Stock_ID;
			 m_Lev1=Lev1;
			 m_Lev2=Lev2;
			 m_Lev3=Lev3;
			 m_Lev4=Lev4;
            m_Unit = Unit;
            m_UnitConvert = UnitConvert;
            m_Vat = Vat;
            m_CurrentQty = CurrentQty;
            m_Quantity = Quantity;
            m_UnitPrice = UnitPrice;
            m_Amount = Amount;
            m_QtyConvert = QtyConvert;
            m_Discount = Discount;
            m_Charge = Charge;
            m_Limit = Limit;
            m_Width = Width;
            m_Height = Height;
            m_Orgin = Orgin;
            m_Size = Size;
            m_Color = Color;
            m_Batch = Batch;
            m_Serial = Serial;
            m_ChassyNo = ChassyNo;
            m_IME = IME;
            m_StoreID = StoreID;
            m_Description = Description;
            m_Sorted = Sorted;
            m_Active = Active;
        }


        public void SetData(
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_Inward_ID = Inward_ID;
            m_Product_ID = Product_ID;
            m_ProductName = ProductName;
            m_RefType = RefType;
            m_Stock_ID = Stock_ID;
			 m_Lev1=Lev1;
			 m_Lev2=Lev2;
			 m_Lev3=Lev3;
			 m_Lev4=Lev4;
            m_Unit = Unit;
            m_UnitConvert = UnitConvert;
            m_Vat = Vat;
            m_CurrentQty = CurrentQty;
            m_Quantity = Quantity;
            m_UnitPrice = UnitPrice;
            m_Amount = Amount;
            m_QtyConvert = QtyConvert;
            m_Discount = Discount;
            m_Charge = Charge;
            m_Limit = Limit;
            m_Width = Width;
            m_Height = Height;
            m_Orgin = Orgin;
            m_Size = Size;
            m_Color = Color;
            m_Batch = Batch;
            m_Serial = Serial;
            m_ChassyNo = ChassyNo;
            m_IME = IME;
            m_StoreID = StoreID;
            m_Description = Description;
            m_Sorted = Sorted;
            m_Active = Active;
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
        [DisplayName("Inward_ID")]
        [Category("Column")]
        public string Inward_ID
        {
            get
            {
                return m_Inward_ID;
            }
            set
            {
                m_Inward_ID = value;
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
		[DisplayName("Lev1")]
		[Category("Column")]
		public decimal Lev1
		{
			get
			{
				return m_Lev1;
			}
			set
			{
				m_Lev1 = value;
			}
		}
		[DisplayName("Lev2")]
		[Category("Column")]
		public decimal Lev2
		{
			get
			{
				return m_Lev2;
			}
			set
			{
				m_Lev2 = value;
			}
		}
		[DisplayName("Lev3")]
		[Category("Column")]
		public decimal Lev3
		{
			get
			{
				return m_Lev3;
			}
			set
			{
				m_Lev3 = value;
			}
		}
		[DisplayName("Lev4")]
		[Category("Column")]
		public decimal Lev4
		{
			get
			{
				return m_Lev4;
			}
			set
			{
				m_Lev4 = value;
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
                return "Class STOCK_INWARD_DETAIL";
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
            return SqlHelper.GenCode("STOCK_INWARD_DETAIL", "STOCK_INWARD_DETAILID", key);
        }

        public string NewID(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, "STOCK_INWARD_DETAIL", "STOCK_INWARD_DETAILID", key);
        }

        public string CreateKey()
        {
            return CreateKey("");
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
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
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
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "STOCK_INWARD_DETAIL_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            else
            {
                mySql.Close();
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        public bool Exist(
            SqlTransaction myTransaction,
            string ID)
        {
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "STOCK_INWARD_DETAIL_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            else
            {
                mySql.RollBack(myTransaction);
                //if(MyParamaters.IsShowWarning) 
                //XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }


        public bool Exist(
            SqlTransaction myTransaction,
            string StockID,
            string ProductID,
            string ProductName,
            decimal qty,
            decimal amt,
            int compare)
        {
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            string sql = "";
            if (compare == 0)
            {
                sql = "Select * from STOCK_INWARD_DETAIL where Product_ID='" + ProductID + "'";
            }
            else if (compare == 1)
            {
                sql = "Select * from STOCK_INWARD_DETAIL where Product_ID='" + ProductID + "' and Stock_ID='" + StockID + "'";
            }
            else if (compare == 2)
            {
                sql = "Select * from STOCK_INWARD_DETAIL where Product_ID='" + ProductID + "' and Stock_ID='" + StockID + "' and Quantity=" + qty;
            }
            else
            {
                sql = "Select * from STOCK_INWARD_DETAIL where Product_ID='" + ProductID + "' and Stock_ID='" + StockID + "' and Quantity=" + qty + " and Amount=" + amt;
            }
            mySql.CommandType = CommandType.Text;
            mySql.Error += new SqlHelper.ErrorEventHander(DispError);
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, sql);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
            }
            else
            {
                mySql.RollBack(myTransaction);
                //if(MyParamaters.IsShowWarning) 
                //XtraMessageBox.Show(mySql.Result,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
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
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "STOCK_INWARD_DETAIL_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
						m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
                    m_Inward_ID = Convert.ToString(myReader["Inward_ID"]);
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_RefType = Convert.ToInt32(myReader["RefType"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
					m_Lev1 =Convert.ToDecimal(myReader["Lev1"]);
					m_Lev2 =Convert.ToDecimal(myReader["Lev2"]);
					m_Lev3 =Convert.ToDecimal(myReader["Lev3"]);
					m_Lev4 =Convert.ToDecimal(myReader["Lev4"]);
                    m_Unit = Convert.ToString(myReader["Unit"]);
                    m_UnitConvert = Convert.ToDecimal(myReader["UnitConvert"]);
                    m_Vat = Convert.ToInt32(myReader["Vat"]);
                    m_CurrentQty = Convert.ToDecimal(myReader["CurrentQty"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_UnitPrice = Convert.ToDecimal(myReader["UnitPrice"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_QtyConvert = Convert.ToDecimal(myReader["QtyConvert"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_Charge = Convert.ToDecimal(myReader["Charge"]);
                    m_Limit = Convert.ToDateTime(myReader["Limit"]);
                    m_Width = Convert.ToDecimal(myReader["Width"]);
                    m_Height = Convert.ToDecimal(myReader["Height"]);
                    m_Orgin = Convert.ToString(myReader["Orgin"]);
                    m_Size = Convert.ToString(myReader["Size"]);
                    m_Color = Convert.ToString(myReader["Color"]);
                    m_Batch = Convert.ToString(myReader["Batch"]);
                    m_Serial = Convert.ToString(myReader["Serial"]);
                    m_ChassyNo = Convert.ToString(myReader["ChassyNo"]);
                    m_IME = Convert.ToString(myReader["IME"]);
                    m_StoreID = Convert.ToInt64(myReader["StoreID"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						if (!myReader.IsDBNull(myReader.GetOrdinal("ID")))
						{
							m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						}
						m_Inward_ID =Convert.ToString(myReader["Inward_ID"]==DBNull.Value?"":myReader["Inward_ID"] );
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Lev1 =Convert.ToDecimal(myReader["Lev1"]==DBNull.Value?0:myReader["Lev1"] );
						m_Lev2 =Convert.ToDecimal(myReader["Lev2"]==DBNull.Value?0:myReader["Lev2"] );
						m_Lev3 =Convert.ToDecimal(myReader["Lev3"]==DBNull.Value?0:myReader["Lev3"] );
						m_Lev4 =Convert.ToDecimal(myReader["Lev4"]==DBNull.Value?0:myReader["Lev4"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_Vat =Convert.ToInt32(myReader["Vat"]==DBNull.Value?0:myReader["Vat"] );
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]==DBNull.Value?0:myReader["CurrentQty"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Limit =Convert.ToDateTime(myReader["Limit"]==DBNull.Value?DateTime.Now:myReader["Limit"] );
						m_Width =Convert.ToDecimal(myReader["Width"]==DBNull.Value?0:myReader["Width"] );
						m_Height =Convert.ToDecimal(myReader["Height"]==DBNull.Value?0:myReader["Height"] );
						m_Orgin =Convert.ToString(myReader["Orgin"]==DBNull.Value?"":myReader["Orgin"] );
						m_Size =Convert.ToString(myReader["Size"]==DBNull.Value?"":myReader["Size"] );
						m_Color =Convert.ToString(myReader["Color"]==DBNull.Value?"":myReader["Color"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]==DBNull.Value?"":myReader["ChassyNo"] );
						m_IME =Convert.ToString(myReader["IME"]==DBNull.Value?"":myReader["IME"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif
                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                mySql.Close();
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        public bool Get(
            SqlTransaction myTransaction,
            string ID)
        {
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "STOCK_INWARD_DETAIL_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
#if DEBUG
						m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
                    m_Inward_ID = Convert.ToString(myReader["Inward_ID"]);
                    m_Product_ID = Convert.ToString(myReader["Product_ID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_RefType = Convert.ToInt32(myReader["RefType"]);
                    m_Stock_ID = Convert.ToString(myReader["Stock_ID"]);
					m_Lev1 =Convert.ToDecimal(myReader["Lev1"]);
					m_Lev2 =Convert.ToDecimal(myReader["Lev2"]);
					m_Lev3 =Convert.ToDecimal(myReader["Lev3"]);
					m_Lev4 =Convert.ToDecimal(myReader["Lev4"]);
                    m_Unit = Convert.ToString(myReader["Unit"]);
                    m_UnitConvert = Convert.ToDecimal(myReader["UnitConvert"]);
                    m_Vat = Convert.ToInt32(myReader["Vat"]);
                    m_CurrentQty = Convert.ToDecimal(myReader["CurrentQty"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_UnitPrice = Convert.ToDecimal(myReader["UnitPrice"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_QtyConvert = Convert.ToDecimal(myReader["QtyConvert"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_Charge = Convert.ToDecimal(myReader["Charge"]);
                    m_Limit = Convert.ToDateTime(myReader["Limit"]);
                    m_Width = Convert.ToDecimal(myReader["Width"]);
                    m_Height = Convert.ToDecimal(myReader["Height"]);
                    m_Orgin = Convert.ToString(myReader["Orgin"]);
                    m_Size = Convert.ToString(myReader["Size"]);
                    m_Color = Convert.ToString(myReader["Color"]);
                    m_Batch = Convert.ToString(myReader["Batch"]);
                    m_Serial = Convert.ToString(myReader["Serial"]);
                    m_ChassyNo = Convert.ToString(myReader["ChassyNo"]);
                    m_IME = Convert.ToString(myReader["IME"]);
                    m_StoreID = Convert.ToInt64(myReader["StoreID"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
#else
						if (!myReader.IsDBNull(myReader.GetOrdinal("ID")))
						{
							m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						}
						m_Inward_ID =Convert.ToString(myReader["Inward_ID"]==DBNull.Value?"":myReader["Inward_ID"] );
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_ProductName =Convert.ToString(myReader["ProductName"]==DBNull.Value?"":myReader["ProductName"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Stock_ID =Convert.ToString(myReader["Stock_ID"]==DBNull.Value?"":myReader["Stock_ID"] );
						m_Lev1 =Convert.ToDecimal(myReader["Lev1"]==DBNull.Value?0:myReader["Lev1"] );
						m_Lev2 =Convert.ToDecimal(myReader["Lev2"]==DBNull.Value?0:myReader["Lev2"] );
						m_Lev3 =Convert.ToDecimal(myReader["Lev3"]==DBNull.Value?0:myReader["Lev3"] );
						m_Lev4 =Convert.ToDecimal(myReader["Lev4"]==DBNull.Value?0:myReader["Lev4"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_Vat =Convert.ToInt32(myReader["Vat"]==DBNull.Value?0:myReader["Vat"] );
						m_CurrentQty =Convert.ToDecimal(myReader["CurrentQty"]==DBNull.Value?0:myReader["CurrentQty"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_Charge =Convert.ToDecimal(myReader["Charge"]==DBNull.Value?0:myReader["Charge"] );
						m_Limit =Convert.ToDateTime(myReader["Limit"]==DBNull.Value?DateTime.Now:myReader["Limit"] );
						m_Width =Convert.ToDecimal(myReader["Width"]==DBNull.Value?0:myReader["Width"] );
						m_Height =Convert.ToDecimal(myReader["Height"]==DBNull.Value?0:myReader["Height"] );
						m_Orgin =Convert.ToString(myReader["Orgin"]==DBNull.Value?"":myReader["Orgin"] );
						m_Size =Convert.ToString(myReader["Size"]==DBNull.Value?"":myReader["Size"] );
						m_Color =Convert.ToString(myReader["Color"]==DBNull.Value?"":myReader["Color"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_ChassyNo =Convert.ToString(myReader["ChassyNo"]==DBNull.Value?"":myReader["ChassyNo"] );
						m_IME =Convert.ToString(myReader["IME"]==DBNull.Value?"":myReader["IME"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
#endif
                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                mySql.RollBack(myTransaction);
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }
        #endregion

        #region Add
        public bool Insert()
        {
            return Insert(
            m_ID,
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_VatAmount,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_DiscountRate,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
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
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_VatAmount,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_DiscountRate,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
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
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
            //m_Lev1,
            //m_Lev2,
            //m_Lev3,
            //m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_VatAmount,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_DiscountRate,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
            m_StoreID,
            m_Description,
            m_Sorted,
            m_Active);
        }
        public bool Insert(
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal VatAmount,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal DiscountRate,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Insert(
            mySql.Connection,
            ID,
            Inward_ID,
            Product_ID,
            ProductName,
            RefType,
            Stock_ID,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
            Unit,
            UnitConvert,
            Vat,
            VatAmount,
            CurrentQty,
            Quantity,
            UnitPrice,
            Amount,
            QtyConvert,
            DiscountRate,
            Discount,
            Charge,
            Limit,
            Width,
            Height,
            Orgin,
            Size,
            Color,
            Batch,
            Serial,
            ChassyNo,
            IME,
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
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal VatAmount,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal DiscountRate,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara ={
			"@ID",
			"@Inward_ID",
			"@Product_ID",
			"@ProductName",
			"@RefType",
			"@Stock_ID",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
            "@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@DiscountRate",
            "@Discount",

			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
            object[] myValue ={
			ID,
			Inward_ID,
			Product_ID,
			ProductName,
			RefType,
			Stock_ID,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			Vat,
            VatAmount,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Limit,
			Width,
			Height,
			Orgin,
			Size,
			Color,
			Batch,
			Serial,
			ChassyNo,
			IME,
			StoreID,
			Description,
			Sorted,
			Active};
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "STOCK_INWARD_DETAIL_Insert", myPara, myValue) == "OK" ? true : false;
        }
        public bool Insert(
            SqlTransaction myTransaction,
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal VatAmount,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal DiscountRate,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara ={
			"@ID",
			"@Inward_ID",
			"@Product_ID",
			"@ProductName",
			"@RefType",
			"@Stock_ID",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
            "@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
            "@DiscountRate",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
            object[] myValue ={
			ID,
			Inward_ID,
			Product_ID,
			ProductName,
			RefType,
			Stock_ID,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			Vat,
            VatAmount,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
            DiscountRate,
			Discount,
			Charge,
			Limit,
			Width,
			Height,
			Orgin,
			Size,
			Color,
			Batch,
			Serial,
			ChassyNo,
			IME,
			StoreID,
			Description,
			Sorted,
			Active};
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "STOCK_INWARD_DETAIL_Insert", myPara, myValue) == "OK" ? true : false;
        }
        #endregion


        #region Update
        public bool Update()
        {
            return Update(
            m_ID,
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
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
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
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
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
			m_Unit,
            m_UnitConvert,
            m_Vat,
            m_VatAmount,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_DiscountRate,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
            m_StoreID,
            m_Description,
            m_Sorted,
            m_Active);
        }
        public bool Update(
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (
            Update(
            mySql.Connection,
            ID,
            Inward_ID,
            Product_ID,
            ProductName,
            RefType,
            Stock_ID,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
            Unit,
            UnitConvert,
            Vat,
            CurrentQty,
            Quantity,
            UnitPrice,
            Amount,
            QtyConvert,
            Discount,
            Charge,
            Limit,
            Width,
            Height,
            Orgin,
            Size,
            Color,
            Batch,
            Serial,
            ChassyNo,
            IME,
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
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara ={
			"@ID",
			"@Inward_ID",
			"@Product_ID",
			"@ProductName",
			"@RefType",
			"@Stock_ID",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
            object[] myValue ={
			ID,
			Inward_ID,
			Product_ID,
			ProductName,
			RefType,
			Stock_ID,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			Vat,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Limit,
			Width,
			Height,
			Orgin,
			Size,
			Color,
			Batch,
			Serial,
			ChassyNo,
			IME,
			StoreID,
			Description,
			Sorted,
			Active};
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "STOCK_INWARD_DETAIL_Update", myPara, myValue) == "OK" ? true : false;
        }
        public bool Update(
            SqlTransaction myTransaction,
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			string Unit,
            decimal UnitConvert,
            int Vat,
            decimal VatAmount,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal DiscountRate,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            long Sorted,
            bool Active)
        {
            string[] myPara ={
			"@ID",
			"@Inward_ID",
			"@Product_ID",
			"@ProductName",
			"@RefType",
			"@Stock_ID",
			"@Unit",
			"@UnitConvert",
			"@Vat",
            "@VatAmount",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
            "@DiscountRate",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@StoreID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={ID,Inward_ID,Product_ID,ProductName,RefType,Stock_ID,Unit,UnitConvert,Vat,VatAmount,CurrentQty,Quantity,UnitPrice,Amount,QtyConvert,DiscountRate,Discount,Charge,Limit,Width,Height,Orgin,Size,Color,Batch,Serial,ChassyNo,IME,StoreID,Description,Sorted,Active};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_INWARD_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

        #region UpdateByID
        public bool UpdateByID()
        {
            return UpdateByID(
            m_ID,
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
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
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
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
            m_Inward_ID,
            m_Product_ID,
            m_ProductName,
            m_RefType,
            m_Stock_ID,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
            m_Unit,
            m_UnitConvert,
            m_Vat,
            m_CurrentQty,
            m_Quantity,
            m_UnitPrice,
            m_Amount,
            m_QtyConvert,
            m_Discount,
            m_Charge,
            m_Limit,
            m_Width,
            m_Height,
            m_Orgin,
            m_Size,
            m_Color,
            m_Batch,
            m_Serial,
            m_ChassyNo,
            m_IME,
            m_StoreID,
            m_Description,
            m_Active);
        }
        public bool UpdateByID(
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            bool Active)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (UpdateByID(mySql.Connection,
            ID,
            Inward_ID,
            Product_ID,
            ProductName,
            RefType,
            Stock_ID,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
            Unit,
            UnitConvert,
            Vat,
            CurrentQty,
            Quantity,
            UnitPrice,
            Amount,
            QtyConvert,
            Discount,
            Charge,
            Limit,
            Width,
            Height,
            Orgin,
            Size,
            Color,
            Batch,
            Serial,
            ChassyNo,
            IME,
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
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            bool Active)
        {
            string[] myPara ={
			"@ID",
			"@Inward_ID",
			"@Product_ID",
			"@ProductName",
			"@RefType",
			"@Stock_ID",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@StoreID",
			"@Description",
			"@Active"};
            object[] myValue ={
			ID,
			Inward_ID,
			Product_ID,
			ProductName,
			RefType,
			Stock_ID,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			Vat,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Limit,
			Width,
			Height,
			Orgin,
			Size,
			Color,
			Batch,
			Serial,
			ChassyNo,
			IME,
			StoreID,
			Description,
			Active};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "STOCK_INWARD_DETAIL_UpdateByID", myPara, myValue) == "OK" ? true : false;
        }
        public bool UpdateByID(
            SqlTransaction myTransaction,
            string ID,
            string Inward_ID,
            string Product_ID,
            string ProductName,
            int RefType,
            string Stock_ID,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            long StoreID,
            string Description,
            bool Active)
        {
            string[] myPara ={
			"@ID",
			"@Inward_ID",
			"@Product_ID",
			"@ProductName",
			"@RefType",
			"@Stock_ID",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@StoreID",
			"@Description",
			"@Active"};
            object[] myValue ={
			ID,
			Inward_ID,
			Product_ID,
			ProductName,
			RefType,
			Stock_ID,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			Vat,
			CurrentQty,
			Quantity,
			UnitPrice,
			Amount,
			QtyConvert,
			Discount,
			Charge,
			Limit,
			Width,
			Height,
			Orgin,
			Size,
			Color,
			Batch,
			Serial,
			ChassyNo,
			IME,
			StoreID,
			Description,
			Active};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "STOCK_INWARD_DETAIL_UpdateByID", myPara, myValue) == "OK" ? true : false;
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
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
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
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myConnection, "STOCK_INWARD_DETAIL_Delete", myPara, myValue) == "OK" ? true : false;
        }
        public bool Delete(
            SqlTransaction myTransaction,
            string ID)
        {
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "STOCK_INWARD_DETAIL_Delete", myPara, myValue) == "OK" ? true : false;
        }
        #endregion

        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("STOCK_INWARD_DETAIL_GetList");
        }
        #endregion


        #region GetList Connection

        public DataTable GetList(SqlConnection myConnection)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myConnection, "STOCK_INWARD_DETAIL_GetList");
        }
        #endregion


        #region GetList Transaction

        public DataTable GetList(SqlTransaction myTransaction)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myTransaction, "STOCK_INWARD_DETAIL_GetList");
        }


        public DataTable GetList_ByInward_ID(string Inward_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@InwardID" };
            object[] myValue = { Inward_ID };
            mysql.Error += DispError;
            return mysql.ExecuteDataTable("STOCK_INWARD_DETAIL_GetList_ByID", myPara, myValue);
        }

        public DataTable GetList_ByInward_ID(SqlTransaction myTransaction, string Inward_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@InwardID" };
            object[] myValue = { Inward_ID };
            mysql.Error += DispError;
            return mysql.ExecuteDataTable(myTransaction, "STOCK_INWARD_DETAIL_GetList_ByID", myPara, myValue);
        }

        public DataTable GetList_ByDate(DateTime FromDate, DateTime ToDate, int Type)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@MoneyType" };
            object[] myValue = { FromDate, ToDate, Type };
            mysql.Error += DispError;
            return mysql.ExecuteDataTable("STOCK_INWARD_DETAIL_GetList_ByDate", myPara, myValue);
        }
        public DataTable ReportDate(DateTime FromDate, DateTime ToDate, string Stock, string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID", "@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock, Product };
            mysql.Error += DispError;
            return mysql.ExecuteDataTable("STOCK_INWARD_DETAIL_ReportDate", myPara, myValue);
        }

        public DataTable GetListIDSX(string Inward_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@InwardID" };
            object[] myValue = { Inward_ID };
            mysql.Error += DispError;
            return mysql.ExecuteDataTable("STOCK_INWARD_DETAIL_GetListIDSX", myPara, myValue);
        }

        public DataTable GetListPurchase(string Purchase_ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Purchase_ID" };
            object[] myValue = { Purchase_ID };
            mysql.Error += DispError;
            return mysql.ExecuteDataTable("STOCK_INWARD_DETAIL_GetListPurchaseID", myPara, myValue);
        }

        #endregion


        #region Count

        public int Count()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return 0;
            int _count = Count(
            mySql.Connection);

            mySql.Close();
            return _count;
        }


        public int Count(
            SqlConnection myConnection)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteScalar(myConnection, "STOCK_INWARD_DETAIL_Count", 0);
        }

        public int Count(
            SqlTransaction myTransaction)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteScalar(myTransaction, "STOCK_INWARD_DETAIL_Count", 0);
        }

        #endregion Count

        #region Search

        public DataTable Search(
            string ProductName,
            int RefType,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            string Description)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return null;
            return Search(
            mySql.Connection,
            ProductName,
            RefType,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
            Unit,
            UnitConvert,
            Vat,
            CurrentQty,
            Quantity,
            UnitPrice,
            Amount,
            QtyConvert,
            Discount,
            Charge,
            Limit,
            Width,
            Height,
            Orgin,
            Size,
            Color,
            Batch,
            Serial,
            ChassyNo,
            IME,
            Description);
            return null;
        }
        #endregion


        #region Search Connection

        public DataTable Search(
            SqlConnection myConnection,
            string ProductName,
            int RefType,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            string Description)
        {
            string[] myPara ={
			"@ProductName",
			"@RefType",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Description"};
            object[] myValue ={
			"%"+ProductName+"%",
			"%"+RefType+"%",
			"%"+Lev1+"%",
			"%"+Lev2+"%",
			"%"+Lev3+"%",
			"%"+Lev4+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+Vat+"%",
			"%"+CurrentQty+"%",
			"%"+Quantity+"%",
			"%"+UnitPrice+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+Discount+"%",
			"%"+Charge+"%",
			"%"+Limit+"%",
			"%"+Width+"%",
			"%"+Height+"%",
			"%"+Orgin+"%",
			"%"+Size+"%",
			"%"+Color+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+ChassyNo+"%",
			"%"+IME+"%",
			"%"+Description+"%"};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myConnection, "STOCK_INWARD_DETAIL_Search", myPara, myValue);
        }
        #endregion


        #region Search Transaction

        public DataTable Search(
            SqlTransaction myTransaction,
            string ProductName,
            int RefType,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
            string Unit,
            decimal UnitConvert,
            int Vat,
            decimal CurrentQty,
            decimal Quantity,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            decimal Discount,
            decimal Charge,
            DateTime Limit,
            decimal Width,
            decimal Height,
            string Orgin,
            string Size,
            string Color,
            string Batch,
            string Serial,
            string ChassyNo,
            string IME,
            string Description)
        {
            string[] myPara ={
			"@ProductName",
			"@RefType",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@Vat",
			"@CurrentQty",
			"@Quantity",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@Discount",
			"@Charge",
			"@Limit",
			"@Width",
			"@Height",
			"@Orgin",
			"@Size",
			"@Color",
			"@Batch",
			"@Serial",
			"@ChassyNo",
			"@IME",
			"@Description"};
            object[] myValue ={
			"%"+ProductName+"%",
			"%"+RefType+"%",
			"%"+Lev1+"%",
			"%"+Lev2+"%",
			"%"+Lev3+"%",
			"%"+Lev4+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+Vat+"%",
			"%"+CurrentQty+"%",
			"%"+Quantity+"%",
			"%"+UnitPrice+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+Discount+"%",
			"%"+Charge+"%",
			"%"+Limit+"%",
			"%"+Width+"%",
			"%"+Height+"%",
			"%"+Orgin+"%",
			"%"+Size+"%",
			"%"+Color+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+ChassyNo+"%",
			"%"+IME+"%",
			"%"+Description+"%"};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable(myTransaction, "STOCK_INWARD_DETAIL_Search", myPara, myValue);
        }
        #endregion


        #region Insert Combo
        #region LookUp

        public DataTable LookUp()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteDataTable("STOCK_INWARD_DETAIL_LookUp");
        }
        #endregion

        public void AddCombo(System.Windows.Forms.ComboBox combo)
        {
            AddCombo(combo, LookUp());
        }

        public void AddCombo(System.Windows.Forms.ComboBox combo, System.Data.DataTable dt)
        {
            MyLib.TableToComboBox(combo, dt, "ID", "Name");
        }

        public void AddComboAll(System.Windows.Forms.ComboBox combo)
        {
            AddComboAll(combo, "(Tất cả)");
        }
        public void AddComboDefault(System.Windows.Forms.ComboBox combo)
        {
            AddComboAll(combo, "(Mặc định)");
        }
        public void AddComboAll(System.Windows.Forms.ComboBox combo, string text)
        {
            DataTable dt = new DataTable();
            dt = LookUp();
            DataRow b = dt.NewRow();
            b["ID"] = "All";
            b["Name"] = text;
            dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "ID", "Name");
        }
        #endregion

        #region Error

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
    #region Enum Fields

    public enum STOCK_INWARD_DETAILFields
    {
        ID,
        Inward_ID,
        Product_ID,
        ProductName,
        RefType,
        Stock_ID,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
        Unit,
        UnitConvert,
        Vat,
        CurrentQty,
        Quantity,
        UnitPrice,
        Amount,
        QtyConvert,
        Discount,
        Charge,
        Limit,
        Width,
        Height,
        Orgin,
        Size,
        Color,
        Batch,
        Serial,
        ChassyNo,
        IME,
        StoreID,
        Description,
        Sorted,
        Active
    }

    #endregion

    #region Class Collection

    public class STOCK_INWARD_DETAILCollection : System.Collections.CollectionBase
    {
        [Description("Adds a new STOCK_INWARD_DETAIL to the collection.")]
        public int Add(STOCK_INWARD_DETAIL item)
        {
            int newindex = List.Add(item);
            return newindex;
        }
        [Description("Removes a STOCK_INWARD_DETAIL from the collection.")]
        public void Remove(STOCK_INWARD_DETAIL item)
        {
            List.Remove(item);
        }
        [Description("Inserts an STOCK_INWARD_DETAIL into the collection at the specified index..")]
        public void Inserts(int index, STOCK_INWARD_DETAIL item)
        {
            List.Insert(index, item);
        }
        [Description("Returns the index value of the BRANCH class in the collection.")]
        public int IndexOf(STOCK_INWARD_DETAIL item)
        {
            return List.IndexOf(item);
        }
        [Description("Returns true if the STOCK_INWARD_DETAIL class is present in the collection.")]
        public bool Contains(STOCK_INWARD_DETAIL item)
        {
            return List.Contains(item);
        }
    }
    #endregion

}
