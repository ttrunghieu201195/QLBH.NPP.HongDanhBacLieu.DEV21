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
	public class STOCK_TRANSFER_DETAIL:Object
	{
		#region Init
		private string m_ID;
		private string m_Transfer_ID;
		private int m_RefType;
		private string m_Product_ID;
		private string m_Product_Name;
		private string m_OutStock;
		private string m_InStock;
		private decimal m_Lev1;
		private decimal m_Lev2;
		private decimal m_Lev3;
		private decimal m_Lev4;
		private string m_Unit;
		private decimal m_UnitConvert;
		private decimal m_UnitPrice;
		private decimal m_Quantity;
		private decimal m_Amount;
		private decimal m_QtyConvert;
		private long m_StoreID;
		private string m_Batch;
		private string m_Serial;
		private string m_Description;
		private long m_Sorted;
		
		
		public STOCK_TRANSFER_DETAIL()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_Transfer_ID="";
			 m_RefType=0;
			 m_Product_ID="";
			 m_Product_Name="";
			 m_OutStock="";
			 m_InStock="";
			 m_Lev1=0;
			 m_Lev2=0;
			 m_Lev3=0;
			 m_Lev4=0;
			 m_Unit="";
			 m_UnitConvert=0;
			 m_UnitPrice=0;
			 m_Quantity=0;
			 m_Amount=0;
			 m_QtyConvert=0;
			 m_StoreID=0;
			 m_Batch="";
			 m_Serial="";
			 m_Description="";
			 m_Sorted=0;
		}
		public STOCK_TRANSFER_DETAIL(
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Transfer_ID=Transfer_ID;
			 m_RefType=RefType;
			 m_Product_ID=Product_ID;
			 m_Product_Name=Product_Name;
			 m_OutStock=OutStock;
			 m_InStock=InStock;
			 m_Lev1=Lev1;
			 m_Lev2=Lev2;
			 m_Lev3=Lev3;
			 m_Lev4=Lev4;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_UnitPrice=UnitPrice;
			 m_Quantity=Quantity;
			 m_Amount=Amount;
			 m_QtyConvert=QtyConvert;
			 m_StoreID=StoreID;
			 m_Batch=Batch;
			 m_Serial=Serial;
			 m_Description=Description;
			 m_Sorted=Sorted;
		}
		
		
		public void SetData(
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_Transfer_ID=Transfer_ID;
			 m_RefType=RefType;
			 m_Product_ID=Product_ID;
			 m_Product_Name=Product_Name;
			 m_OutStock=OutStock;
			 m_InStock=InStock;
			 m_Lev1=Lev1;
			 m_Lev2=Lev2;
			 m_Lev3=Lev3;
			 m_Lev4=Lev4;
			 m_Unit=Unit;
			 m_UnitConvert=UnitConvert;
			 m_UnitPrice=UnitPrice;
			 m_Quantity=Quantity;
			 m_Amount=Amount;
			 m_QtyConvert=QtyConvert;
			 m_StoreID=StoreID;
			 m_Batch=Batch;
			 m_Serial=Serial;
			 m_Description=Description;
			 m_Sorted=Sorted;
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
		[DisplayName("Transfer_ID")]
		[Category("Column")]
		public string Transfer_ID
		{
			get
			{
				return m_Transfer_ID;
			}
			set
			{
				m_Transfer_ID = value;
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
		[DisplayName("Product_Name")]
		[Category("Column")]
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
		[DisplayName("OutStock")]
		[Category("Column")]
		public string OutStock
		{
			get
			{
				return m_OutStock;
			}
			set
			{
				m_OutStock = value;
			}
		}
		[DisplayName("InStock")]
		[Category("Column")]
		public string InStock
		{
			get
			{
				return m_InStock;
			}
			set
			{
				m_InStock = value;
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
		public string Product
		{
			get
			{
				return "Class STOCK_TRANSFER_DETAIL";
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
			return SqlHelper.GenCode("STOCK_TRANSFER_DETAIL","STOCK_TRANSFER_DETAILID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"STOCK_TRANSFER_DETAIL","STOCK_TRANSFER_DETAILID",key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_TRANSFER_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_TRANSFER_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_TRANSFER_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						m_Transfer_ID =Convert.ToString(myReader["Transfer_ID"]);
						m_RefType =Convert.ToInt32(myReader["RefType"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Product_Name =Convert.ToString(myReader["Product_Name"]);
						m_OutStock =Convert.ToString(myReader["OutStock"]);
						m_InStock =Convert.ToString(myReader["InStock"]);
						m_Lev1 =Convert.ToDecimal(myReader["Lev1"]);
						m_Lev2 =Convert.ToDecimal(myReader["Lev2"]);
						m_Lev3 =Convert.ToDecimal(myReader["Lev3"]);
						m_Lev4 =Convert.ToDecimal(myReader["Lev4"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]);
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]);
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]);
						m_StoreID =Convert.ToInt64(myReader["StoreID"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Serial =Convert.ToString(myReader["Serial"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						if (!myReader.IsDBNull(myReader.GetOrdinal("ID")))
						{
							m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						}
						m_Transfer_ID =Convert.ToString(myReader["Transfer_ID"]==DBNull.Value?"":myReader["Transfer_ID"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_Product_Name =Convert.ToString(myReader["Product_Name"]==DBNull.Value?"":myReader["Product_Name"] );
						m_OutStock =Convert.ToString(myReader["OutStock"]==DBNull.Value?"":myReader["OutStock"] );
						m_InStock =Convert.ToString(myReader["InStock"]==DBNull.Value?"":myReader["InStock"] );
						m_Lev1 =Convert.ToDecimal(myReader["Lev1"]==DBNull.Value?0:myReader["Lev1"] );
						m_Lev2 =Convert.ToDecimal(myReader["Lev2"]==DBNull.Value?0:myReader["Lev2"] );
						m_Lev3 =Convert.ToDecimal(myReader["Lev3"]==DBNull.Value?0:myReader["Lev3"] );
						m_Lev4 =Convert.ToDecimal(myReader["Lev4"]==DBNull.Value?0:myReader["Lev4"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
#endif
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
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_TRANSFER_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
                    m_ID = myReader.GetString(myReader.GetOrdinal("ID"));
						m_Transfer_ID =Convert.ToString(myReader["Transfer_ID"]);
						m_RefType =Convert.ToInt32(myReader["RefType"]);
						m_Product_ID =Convert.ToString(myReader["Product_ID"]);
						m_Product_Name =Convert.ToString(myReader["Product_Name"]);
						m_OutStock =Convert.ToString(myReader["OutStock"]);
						m_InStock =Convert.ToString(myReader["InStock"]);
						m_Lev1 =Convert.ToDecimal(myReader["Lev1"]);
						m_Lev2 =Convert.ToDecimal(myReader["Lev2"]);
						m_Lev3 =Convert.ToDecimal(myReader["Lev3"]);
						m_Lev4 =Convert.ToDecimal(myReader["Lev4"]);
						m_Unit =Convert.ToString(myReader["Unit"]);
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]);
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]);
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]);
						m_StoreID =Convert.ToInt64(myReader["StoreID"]);
						m_Batch =Convert.ToString(myReader["Batch"]);
						m_Serial =Convert.ToString(myReader["Serial"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						if (!myReader.IsDBNull(myReader.GetOrdinal("ID")))
						{
							m_ID= myReader.GetString(myReader.GetOrdinal("ID"));
						}
						m_Transfer_ID =Convert.ToString(myReader["Transfer_ID"]==DBNull.Value?"":myReader["Transfer_ID"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Product_ID =Convert.ToString(myReader["Product_ID"]==DBNull.Value?"":myReader["Product_ID"] );
						m_Product_Name =Convert.ToString(myReader["Product_Name"]==DBNull.Value?"":myReader["Product_Name"] );
						m_OutStock =Convert.ToString(myReader["OutStock"]==DBNull.Value?"":myReader["OutStock"] );
						m_InStock =Convert.ToString(myReader["InStock"]==DBNull.Value?"":myReader["InStock"] );
						m_Lev1 =Convert.ToDecimal(myReader["Lev1"]==DBNull.Value?0:myReader["Lev1"] );
						m_Lev2 =Convert.ToDecimal(myReader["Lev2"]==DBNull.Value?0:myReader["Lev2"] );
						m_Lev3 =Convert.ToDecimal(myReader["Lev3"]==DBNull.Value?0:myReader["Lev3"] );
						m_Lev4 =Convert.ToDecimal(myReader["Lev4"]==DBNull.Value?0:myReader["Lev4"] );
						m_Unit =Convert.ToString(myReader["Unit"]==DBNull.Value?"":myReader["Unit"] );
						m_UnitConvert =Convert.ToDecimal(myReader["UnitConvert"]==DBNull.Value?0:myReader["UnitConvert"] );
						m_UnitPrice =Convert.ToDecimal(myReader["UnitPrice"]==DBNull.Value?0:myReader["UnitPrice"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_QtyConvert =Convert.ToDecimal(myReader["QtyConvert"]==DBNull.Value?0:myReader["QtyConvert"] );
						m_StoreID =Convert.ToInt64(myReader["StoreID"]==DBNull.Value?0:myReader["StoreID"] );
						m_Batch =Convert.ToString(myReader["Batch"]==DBNull.Value?"":myReader["Batch"] );
						m_Serial =Convert.ToString(myReader["Serial"]==DBNull.Value?"":myReader["Serial"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
#endif
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
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description,
			m_Sorted);
		}
		public bool Insert(
			SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description,
			m_Sorted);
		}
		public bool Insert(
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description,
			m_Sorted);
		}
		public bool Insert(
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted))
				{
					mySql.Close();
					return true;
				};
			return false;
		}
		public bool Insert(
			SqlConnection myConnection,
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@Transfer_ID",
			"@RefType",
			"@Product_ID",
			"@Product_Name",
			"@OutStock",
			"@InStock",
			
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
            //decimal Lev1,
            //decimal Lev2,
            //decimal Lev3,
            //decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@Transfer_ID",
			"@RefType",
			"@Product_ID",
			"@Product_Name",
			"@OutStock",
			"@InStock",
            //"@Lev1",
            //"@Lev2",
            //"@Lev3",
            //"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
            //Lev1,
            //Lev2,
            //Lev3,
            //Lev4,
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description,
			m_Sorted);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description,
			m_Sorted);
		}
		public bool Update(
			SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description,
			m_Sorted);
		}
		public bool Update(
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted)
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
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@Transfer_ID",
			"@RefType",
			"@Product_ID",
			"@Product_Name",
			"@OutStock",
			"@InStock",
			
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
           
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@Transfer_ID",
			"@RefType",
			"@Product_ID",
			"@Product_Name",
			"@OutStock",
			"@InStock",
            
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description",
			"@Sorted"};
			object[] myValue={ID,Transfer_ID,RefType,Product_ID,Product_Name,OutStock,InStock,
                                
                                 Unit,UnitConvert,UnitPrice,Quantity,Amount,QtyConvert,StoreID,Batch,Serial,Description,Sorted};
			var mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_ID,
			m_Transfer_ID,
			m_RefType,
			m_Product_ID,
			m_Product_Name,
			m_OutStock,
			m_InStock,
			m_Lev1,
			m_Lev2,
			m_Lev3,
			m_Lev4,
			m_Unit,
			m_UnitConvert,
			m_UnitPrice,
			m_Quantity,
			m_Amount,
			m_QtyConvert,
			m_StoreID,
			m_Batch,
			m_Serial,
			m_Description);
		}
		public bool UpdateByID(
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description))
				{
					mySql.Close();
					return true;
				};
			return false;
		}

		public bool UpdateByID(
			SqlConnection myConnection,
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description)
		{
			string[] myPara={
			"@ID",
			"@Transfer_ID",
			"@RefType",
			"@Product_ID",
			"@Product_Name",
			"@OutStock",
			"@InStock",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description"};
			object[] myValue={
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string Transfer_ID,
			int RefType,
			string Product_ID,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			long StoreID,
			string Batch,
			string Serial,
			string Description)
		{
			string[] myPara={
			"@ID",
			"@Transfer_ID",
			"@RefType",
			"@Product_ID",
			"@Product_Name",
			"@OutStock",
			"@InStock",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description"};
			object[] myValue={
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetList");
		}

        public DataTable GetList_ByTransferID(string TransferID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Transfer_ID" };
            object[] myValue = { TransferID };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetList_ByTransferID", myPara, myValue);
        }

        public DataTable GetList_ByTransferID(SqlTransaction myTransaction,string TransferID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Transfer_ID" };
            object[] myValue = { TransferID };
            return mysql.ExecuteDataTable(myTransaction,"STOCK_TRANSFER_DETAIL_GetList_ByTransferID", myPara, myValue);
        }

        public DataTable GetList_Merrial_ById(string TransferId)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Transfer_ID" };
            object[] myValue = { TransferId };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetList_Merrial_ByID", myPara, myValue);
        }

        public DataTable GetListIDSX(string TransferID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Transfer_ID" };
            object[] myValue = { TransferID };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetListIDSX", myPara, myValue);
        }

        public DataTable GetList_ByDate(DateTime FromDate, DateTime ToDate, int Type)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@MoneyType" };
            object[] myValue = { FromDate, ToDate, Type };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetList_ByDate", myPara, myValue);
        }

        public DataTable GetList_ByDate_Action(DateTime FromDate, DateTime ToDate, int Type, int Action)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@MoneyType", "@Action" };
            object[] myValue = { FromDate, ToDate, Type, Action };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetList_ByDate_Action", myPara, myValue);
        }

        public DataTable ReportDate(DateTime FromDate, DateTime ToDate, string Stock, string Product)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@StockID", "@ProductID" };
            object[] myValue = { FromDate, ToDate, Stock, Product };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_ReportDate", myPara, myValue);
        }

        public DataTable GetList_ByDate_Build(DateTime FromDate, DateTime ToDate, int Type, int Action)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@FromDate", "@ToDate", "@MoneyType", "@Action" };
            object[] myValue = { FromDate, ToDate, Type, Action };
            return mysql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_GetList_ByDate_Build", myPara, myValue);
        }
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"STOCK_TRANSFER_DETAIL_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"STOCK_TRANSFER_DETAIL_GetList");
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
			return mySql.ExecuteScalar(myConnection,"STOCK_TRANSFER_DETAIL_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"STOCK_TRANSFER_DETAIL_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			int RefType,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			string Batch,
			string Serial,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefType,
			Product_Name,
			OutStock,
			InStock,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			Batch,
			Serial,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			int RefType,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			string Batch,
			string Serial,
			string Description)
		{
			string[] myPara={
			"@RefType",
			"@Product_Name",
			"@OutStock",
			"@InStock",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@Batch",
			"@Serial",
			"@Description"};
			object[] myValue={
			"%"+RefType+"%",
			"%"+Product_Name+"%",
			"%"+OutStock+"%",
			"%"+InStock+"%",
			"%"+Lev1+"%",
			"%"+Lev2+"%",
			"%"+Lev3+"%",
			"%"+Lev4+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+UnitPrice+"%",
			"%"+Quantity+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"STOCK_TRANSFER_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			int RefType,
			string Product_Name,
			string OutStock,
			string InStock,
			decimal Lev1,
			decimal Lev2,
			decimal Lev3,
			decimal Lev4,
			string Unit,
			decimal UnitConvert,
			decimal UnitPrice,
			decimal Quantity,
			decimal Amount,
			decimal QtyConvert,
			string Batch,
			string Serial,
			string Description)
		{
			string[] myPara={
			"@RefType",
			"@Product_Name",
			"@OutStock",
			"@InStock",
			"@Lev1",
			"@Lev2",
			"@Lev3",
			"@Lev4",
			"@Unit",
			"@UnitConvert",
			"@UnitPrice",
			"@Quantity",
			"@Amount",
			"@QtyConvert",
			"@Batch",
			"@Serial",
			"@Description"};
			object[] myValue={
			"%"+RefType+"%",
			"%"+Product_Name+"%",
			"%"+OutStock+"%",
			"%"+InStock+"%",
			"%"+Lev1+"%",
			"%"+Lev2+"%",
			"%"+Lev3+"%",
			"%"+Lev4+"%",
			"%"+Unit+"%",
			"%"+UnitConvert+"%",
			"%"+UnitPrice+"%",
			"%"+Quantity+"%",
			"%"+Amount+"%",
			"%"+QtyConvert+"%",
			"%"+Batch+"%",
			"%"+Serial+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"STOCK_TRANSFER_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("STOCK_TRANSFER_DETAIL_LookUp");
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

	public enum STOCK_TRANSFER_DETAILFields
		{
			ID,
			Transfer_ID,
			RefType,
			Product_ID,
			Product_Name,
			OutStock,
			InStock,
			Lev1,
			Lev2,
			Lev3,
			Lev4,
			Unit,
			UnitConvert,
			UnitPrice,
			Quantity,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted
		}

	#endregion

	#region Class Collection

	public class STOCK_TRANSFER_DETAILCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new STOCK_TRANSFER_DETAIL to the collection.")]
			public int Add(STOCK_TRANSFER_DETAIL item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a STOCK_TRANSFER_DETAIL from the collection.")]
			public void Remove(STOCK_TRANSFER_DETAIL item)
				{
					List.Remove(item);
				}
			[Description("Inserts an STOCK_TRANSFER_DETAIL into the collection at the specified index..")]
			public void Inserts(int index,STOCK_TRANSFER_DETAIL item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(STOCK_TRANSFER_DETAIL item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the STOCK_TRANSFER_DETAIL class is present in the collection.")]
			public bool Contains(STOCK_TRANSFER_DETAIL item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
