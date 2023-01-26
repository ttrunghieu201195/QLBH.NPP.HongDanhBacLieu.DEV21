using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Perfect.Inventory.Core.Inventory.Adjustment.Class
{
	
	public class ADJUSTMENT_DETAIL:Object
	{
		#region Init
		private string m_ID;
		private string m_Adjustment_ID;
		private string m_Product_ID;
		private string m_Product_Name;
		private string m_Stock_ID;
		private string m_Unit;
		private decimal m_UnitConvert;
		private decimal m_Width;
		private decimal m_Height;
		private string m_Orgin;
		private decimal m_CurrentQty;
		private decimal m_NewQty;
		private decimal m_QtyDiff;
		private decimal m_UnitPrice;
		private decimal m_Amount;
		private decimal m_QtyConvert;
		private long m_StoreID;
		private string m_Batch;
		private string m_Serial;
		private string m_Description;
		private long m_Sorted;
		
		
		public ADJUSTMENT_DETAIL()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_Adjustment_ID="";
			 m_Product_ID="";
			 m_Product_Name="";
			 m_Stock_ID="";
			 m_Unit="";
			 m_UnitConvert=0;
			 m_Width=0;
			 m_Height=0;
			 m_Orgin="";
			 m_CurrentQty=0;
			 m_NewQty=0;
			 m_QtyDiff=0;
			 m_UnitPrice=0;
			 m_Amount=0;
			 m_QtyConvert=0;
			 m_StoreID=0;
			 m_Batch="";
			 m_Serial="";
			 m_Description="";
			 m_Sorted=0;
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
		[DisplayName("Adjustment_ID")]
		[Category("Column")]
		public string Adjustment_ID
		{
			get
			{
				return m_Adjustment_ID;
			}
			set
			{
				m_Adjustment_ID = value;
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
		[DisplayName("NewQty")]
		[Category("Column")]
		public decimal NewQty
		{
			get
			{
				return m_NewQty;
			}
			set
			{
				m_NewQty = value;
			}
		}
		[DisplayName("QtyDiff")]
		[Category("Column")]
		public decimal QtyDiff
		{
			get
			{
				return m_QtyDiff;
			}
			set
			{
				m_QtyDiff = value;
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

	    #endregion

	    #region Add

	    public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string Adjustment_ID,
			string Product_ID,
			string Product_Name,
			string Stock_ID,
			string Unit,
			decimal UnitConvert,
			decimal Width,
			decimal Height,
			string Orgin,
			decimal CurrentQty,
			decimal NewQty,
			decimal QtyDiff,
			decimal UnitPrice,
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
			"@Adjustment_ID",
			"@Product_ID",
			"@Product_Name",
			"@Stock_ID",
			"@Unit",
			"@UnitConvert",
			"@Width",
			"@Height",
			"@Orgin",
			"@CurrentQty",
			"@NewQty",
			"@QtyDiff",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			Adjustment_ID,
			Product_ID,
			Product_Name,
			Stock_ID,
			Unit,
			UnitConvert,
			Width,
			Height,
			Orgin,
			CurrentQty,
			NewQty,
			QtyDiff,
			UnitPrice,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.StoredProcedure;
             
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "ADJUSTMENT_DETAIL_Insert", myPara, myValue) == "OK" ? true : false;
		}


        public bool Update(
            SqlTransaction myTransaction,
            string ID,
            string Adjustment_ID,
            string Product_ID,
            string Product_Name,
            string Stock_ID,
            string Unit,
            decimal UnitConvert,
            decimal Width,
            decimal Height,
            string Orgin,
            decimal CurrentQty,
            decimal NewQty,
            decimal QtyDiff,
            decimal UnitPrice,
            decimal Amount,
            decimal QtyConvert,
            long StoreID,
            string Batch,
            string Serial,
            string Description,
            long Sorted)
        {
            string[] myPara ={
			"@ID",
			"@Adjustment_ID",
			"@Product_ID",
			"@Product_Name",
			"@Stock_ID",
			"@Unit",
			"@UnitConvert",
			"@Width",
			"@Height",
			"@Orgin",
			"@CurrentQty",
			"@NewQty",
			"@QtyDiff",
			"@UnitPrice",
			"@Amount",
			"@QtyConvert",
			"@StoreID",
			"@Batch",
			"@Serial",
			"@Description",
			"@Sorted"};
            object[] myValue ={
			ID,
			Adjustment_ID,
			Product_ID,
			Product_Name,
			Stock_ID,
			Unit,
			UnitConvert,
			Width,
			Height,
			Orgin,
			CurrentQty,
			NewQty,
			QtyDiff,
			UnitPrice,
			Amount,
			QtyConvert,
			StoreID,
			Batch,
			Serial,
			Description,
			Sorted};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.StoredProcedure;

            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "ADJUSTMENT_DETAIL_Update", myPara, myValue) == "OK" ? true : false;
        }



		#endregion

	    #region Delete

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
			return mySql.ExecuteNonQuery(myTransaction,"ADJUSTMENT_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
        
	    public static DataTable GetListByAdjustmentID(SqlTransaction myTransaction,string ID)
        {
            var mysql = new SqlHelper();
            string[] myPara = { "@Adjustment_ID" };
            object[] myValue = { ID };
	        mysql.CommandType = CommandType.Text;
            const string sql = "SELECT * FROM ADJUSTMENT_DETAIL ad WHERE ad.Adjustment_ID = @Adjustment_ID \n"
                               + "	ORDER BY ad.Sorted";
            return mysql.ExecuteDataTable(myTransaction,sql, myPara, myValue);
        }
        public DataTable GetList_ByAdjustment_ID(string ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Adjustment_ID" };
            object[] myValue = { ID };
            return mysql.ExecuteDataTable("ADJUSTMENT_DETAIL_GetList_ByAdjustment_ID", myPara, myValue);
        }

        public DataTable GetList_ByAdjustment_ID(SqlTransaction myTransaction, string ID)
        {
            SqlHelper mysql = new SqlHelper();
            string[] myPara = { "@Adjustment_ID" };
            object[] myValue = { ID };
            return mysql.ExecuteDataTable(myTransaction, "ADJUSTMENT_DETAIL_GetList_ByAdjustment_ID", myPara, myValue);
        }
	    #endregion
		

		
		
		#region Error
		
		private void DispError(object sender, SqlHelperException e)
		{
			XtraMessageBox.Show(e.Message,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion
	}

}
