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
	/// Generated Class for Table : DEBT.
	/// Date: 01/10/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class DEBT_OUTWARD:Object
	{
		#region Init
		private Guid m_ID;
		private string m_RefID;
		private DateTime m_RefDate;
        private Guid m_RefOrgNo;
		private int m_RefType;
		private int m_RefStatus;
        private Guid m_PaymentMethod;
		private string m_CustomerID;
		private string m_ProductID;
		private string m_ProductName;
		private string m_CurrencyID;
		private decimal m_ExchangeRate;
		private string m_TermID;
		private DateTime m_DueDate;
		private decimal m_Quantity;
		private decimal m_ReQuantity;
		private decimal m_Price;
		private decimal m_Amount;
        private decimal m_Payment;
        private decimal m_Balance;
		private decimal m_FAmount;
		private bool m_IsChanged;
		private string m_Description;
		private long m_Sorted;
		private bool m_Active;


        public DEBT_OUTWARD()
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = Guid.NewGuid();
            m_RefID = "";
            m_RefDate = DateTime.Now;
            m_RefOrgNo = Guid.NewGuid();
            m_RefType = 0;
            m_RefStatus = 0;
            m_PaymentMethod = Guid.NewGuid();
            m_CustomerID = "";
            m_ProductID = "";
            m_ProductName = "";
            m_CurrencyID = "";
            m_ExchangeRate = 0;
            m_TermID = "";
            m_DueDate = DateTime.Now;
            m_Quantity = 0;
            m_ReQuantity = 0;
            m_Price = 0;
            m_Amount = 0;
            m_Payment = 0;
            m_Balance = 0;
            m_FAmount = 0;
            m_IsChanged = true;
            m_Description = "";
            m_Sorted = 0;
            m_Active = true;
        }
        public DEBT_OUTWARD(
            Guid ID,
            string RefID,
            DateTime RefDate,
            Guid RefOrgNo,
            int RefType,
            int RefStatus,
            Guid PaymentMethod,
            string CustomerID,
            string ProductID,
            string ProductName,
            string CurrencyID,
            decimal ExchangeRate,
            string TermID,
            DateTime DueDate,
            decimal Quantity,
            decimal ReQuantity,
            decimal Price,
            decimal Amount,
            decimal FAmount,
            bool IsChanged,
            string Description,
            long Sorted,
            bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_RefID = RefID;
            m_RefDate = RefDate;
            m_RefOrgNo = RefOrgNo;
            m_RefType = RefType;
            m_RefStatus = RefStatus;
            m_PaymentMethod = PaymentMethod;
            m_CustomerID = CustomerID;
            m_ProductID = ProductID;
            m_ProductName = ProductName;
            m_CurrencyID = CurrencyID;
            m_ExchangeRate = ExchangeRate;
            m_TermID = TermID;
            m_DueDate = DueDate;
            m_Quantity = Quantity;
            m_ReQuantity = ReQuantity;
            m_Price = Price;
            m_Amount = Amount;
            m_Payment = 0;
            m_Balance = Amount;
            m_FAmount = FAmount;
            m_IsChanged = IsChanged;
            m_Description = Description;
            m_Sorted = Sorted;
            m_Active = Active;
        }
		
		#endregion
		
		#region Property
		[DisplayName("ID")]
		[Category("Primary Key")]
		public Guid ID
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
		[DisplayName("RefID")]
		[Category("Column")]
		public string RefID
		{
			get
			{
				return m_RefID;
			}
			set
			{
				m_RefID = value;
			}
		}
		[DisplayName("RefDate")]
		[Category("Column")]
		public DateTime RefDate
		{
			get
			{
				return m_RefDate;
			}
			set
			{
				m_RefDate = value;
			}
		}
		[DisplayName("RefOrgNo")]
		[Category("Column")]
        public Guid RefOrgNo
		{
			get
			{
				return m_RefOrgNo;
			}
			set
			{
				m_RefOrgNo = value;
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
		[DisplayName("RefStatus")]
		[Category("Column")]
		public int RefStatus
		{
			get
			{
				return m_RefStatus;
			}
			set
			{
				m_RefStatus = value;
			}
		}
		[DisplayName("PaymentMethod")]
		[Category("Column")]
        public Guid PaymentMethod
		{
			get
			{
				return m_PaymentMethod;
			}
			set
			{
				m_PaymentMethod = value;
			}
		}
		[DisplayName("CustomerID")]
		[Category("Column")]
		public string CustomerID
		{
			get
			{
				return m_CustomerID;
			}
			set
			{
				m_CustomerID = value;
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
		[DisplayName("CurrencyID")]
		[Category("Column")]
		public string CurrencyID
		{
			get
			{
				return m_CurrencyID;
			}
			set
			{
				m_CurrencyID = value;
			}
		}
		[DisplayName("ExchangeRate")]
		[Category("Column")]
		public decimal ExchangeRate
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
		[DisplayName("TermID")]
		[Category("Column")]
		public string TermID
		{
			get
			{
				return m_TermID;
			}
			set
			{
				m_TermID = value;
			}
		}
		[DisplayName("DueDate")]
		[Category("Column")]
		public DateTime DueDate
		{
			get
			{
				return m_DueDate;
			}
			set
			{
				m_DueDate = value;
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
		[DisplayName("ReQuantity")]
		[Category("Column")]
		public decimal ReQuantity
		{
			get
			{
				return m_ReQuantity;
			}
			set
			{
				m_ReQuantity = value;
			}
		}
		[DisplayName("Price")]
		[Category("Column")]
		public decimal Price
		{
			get
			{
				return m_Price;
			}
			set
			{
				m_Price = value;
			}
		}
		[DisplayName("Amount")]
		[Category("Column")]
		public decimal Payment
		{
			get
			{
				return m_Payment;
			}
			set
			{
                m_Payment = value;
			}
		}
        public decimal Balance
        {
            get
            {
                return m_Balance;
            }
            set
            {
                m_Balance = value;
            }
        }
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
		[DisplayName("IsChanged")]
		[Category("Column")]
		public bool IsChanged
		{
			get
			{
				return m_IsChanged;
			}
			set
			{
				m_IsChanged = value;
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
				return "Class DEBT";
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
		
		#region Get

		public bool Get()
		{
			return Get(
			m_ID);
		}

		public bool Get(SqlTransaction myTransaction)
		{
			return Get(
			myTransaction,
			m_ID);
		}


        public bool Get(Guid ID)
        {
            bool Result = false;
            string[] myPara = { "@ID" };
            object[] myValue = { ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("DEBT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = (Guid)(myReader["RefOrgNo"] ?? Guid.Empty);
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = (Guid)(myReader["PaymentMethod"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_ProductID = Convert.ToString(myReader["ProductID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_TermID = Convert.ToString(myReader["TermID"]);
                    m_DueDate = Convert.ToDateTime(myReader["DueDate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_ReQuantity = Convert.ToDecimal(myReader["ReQuantity"]);
                    m_Price = Convert.ToDecimal(myReader["Price"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_Balance = Convert.ToDecimal(myReader["Balance"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_IsChanged = Convert.ToBoolean(myReader["IsChanged"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);

                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
                if (MyParamaters.IsShowWarning)
                    XtraMessageBox.Show(mySql.Result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;
        }

        public bool Get(SqlTransaction myTransaction, Guid ID)
        {
            bool Result = false;
            string[] myPara = { "@ID" };
            object[] myValue = { ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "DEBT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = (Guid)(myReader["RefOrgNo"] ?? Guid.Empty);
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = (Guid)(myReader["PaymentMethod"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_ProductID = Convert.ToString(myReader["ProductID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_TermID = Convert.ToString(myReader["TermID"]);
                    m_DueDate = Convert.ToDateTime(myReader["DueDate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_ReQuantity = Convert.ToDecimal(myReader["ReQuantity"]);
                    m_Price = Convert.ToDecimal(myReader["Price"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_Balance = Convert.ToDecimal(myReader["Balance"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_IsChanged = Convert.ToBoolean(myReader["IsChanged"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
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


        public bool GetByIO(SqlTransaction myTrans, string IO_ID)
        {
            bool Result = false;
            string[] myPara = { "@RefID" };
            object[] myValue = { IO_ID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader(myTrans, QGetByIO, myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)(myReader["ID"]);
                    m_RefID = Convert.ToString(myReader["RefID"]);
                    m_RefDate = Convert.ToDateTime(myReader["RefDate"]);
                    m_RefOrgNo = myReader["RefOrgNo"] == DBNull.Value ? Guid.Empty : (Guid)myReader["RefOrgNo"];
                    m_RefType = Convert.ToInt16(myReader["RefType"]);
                    m_RefStatus = Convert.ToInt16(myReader["RefStatus"]);
                    m_PaymentMethod = (Guid)(myReader["PaymentMethod"]);
                    m_CustomerID = Convert.ToString(myReader["CustomerID"]);
                    m_ProductID = Convert.ToString(myReader["ProductID"]);
                    m_ProductName = Convert.ToString(myReader["ProductName"]);
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_TermID = Convert.ToString(myReader["TermID"]);
                    m_DueDate = Convert.ToDateTime(myReader["DueDate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_ReQuantity = Convert.ToDecimal(myReader["ReQuantity"]);
                    m_Price = Convert.ToDecimal(myReader["Price"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_Balance = Convert.ToDecimal(myReader["Balance"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_IsChanged = Convert.ToBoolean(myReader["IsChanged"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = true;
                }
                myReader.Close();
                myReader = null;
            }
            else
            {
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
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_CustomerID,
			m_ProductID,
			m_ProductName,
			m_CurrencyID,
			m_ExchangeRate,
			m_TermID,
			m_DueDate,
			m_Quantity,
			m_ReQuantity,
			m_Price,
			m_Amount,
            m_Payment,
            m_Balance,
			m_FAmount,
			m_IsChanged,
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
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_CustomerID,
			m_ProductID,
			m_ProductName,
			m_CurrencyID,
			m_ExchangeRate,
			m_TermID,
			m_DueDate,
			m_Quantity,
			m_ReQuantity,
			m_Price,
			m_Amount,
            m_Payment,
            m_Balance,
			m_FAmount,
			m_IsChanged,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			Guid ID,
			string RefID,
			DateTime RefDate,
            Guid RefOrgNo,
			int RefType,
			int RefStatus,
            Guid PaymentMethod,
			string CustomerID,
			string ProductID,
			string ProductName,
			string CurrencyID,
			decimal ExchangeRate,
			string TermID,
			DateTime DueDate,
			decimal Quantity,
			decimal ReQuantity,
			decimal Price,
            decimal Amount, 
            decimal Payment,
            decimal Balance,
			decimal FAmount,
			bool IsChanged,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@CustomerID",
			"@ProductID",
			"@ProductName",
			"@CurrencyID",
			"@ExchangeRate",
			"@TermID",
			"@DueDate",
			"@Quantity",
			"@ReQuantity",
			"@Price",
			"@Amount",
            "@Payment",
            "@Balance",
			"@FAmount",
			"@IsChanged",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			CustomerID,
			ProductID,
			ProductName,
			CurrencyID,
			ExchangeRate,
			TermID,
			DueDate,
			Quantity,
			ReQuantity,
			Price,
			Amount,
            Payment, 
            Balance,
			FAmount,
			IsChanged,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("DEBT_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
            Guid ID,
			string RefID,
			DateTime RefDate,
            Guid RefOrgNo,
			int RefType,
			int RefStatus,
            Guid PaymentMethod,
			string CustomerID,
			string ProductID,
			string ProductName,
			string CurrencyID,
			decimal ExchangeRate,
			string TermID,
			DateTime DueDate,
			decimal Quantity,
			decimal ReQuantity,
			decimal Price,
			decimal Amount,
            decimal Payment,
            decimal Balance,
			decimal FAmount,
			bool IsChanged,
			string Description,
			long Sorted,
			bool Active)
		{
            string[] myPara ={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@CustomerID",
			"@ProductID",
			"@ProductName",
			"@CurrencyID",
			"@ExchangeRate",
			"@TermID",
			"@DueDate",
			"@Quantity",
			"@ReQuantity",
			"@Price",
			"@Amount",
            "@Payment",
            "@Balance",
			"@FAmount",
			"@IsChanged",
			"@Description",
			"@Sorted",
			"@Active"};
            object[] myValue ={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			CustomerID,
			ProductID,
			ProductName,
			CurrencyID,
			ExchangeRate,
			TermID,
			DueDate,
			Quantity,
			ReQuantity,
			Price,
			Amount,
            Payment, 
            Balance,
			FAmount,
			IsChanged,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"DEBT_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_CustomerID,
			m_ProductID,
			m_ProductName,
			m_CurrencyID,
			m_ExchangeRate,
			m_TermID,
			m_DueDate,
			m_Quantity,
			m_ReQuantity,
			m_Price,
			m_Amount,
            m_Payment, 
            m_Balance,
			m_FAmount,
			m_IsChanged,
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
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_CustomerID,
			m_ProductID,
			m_ProductName,
			m_CurrencyID,
			m_ExchangeRate,
			m_TermID,
			m_DueDate,
			m_Quantity,
			m_ReQuantity,
			m_Price,
			m_Amount,
            m_Payment,
            m_Balance,
			m_FAmount,
			m_IsChanged,
			m_Description,
			m_Sorted,
			m_Active);
		}

		public bool Update(
			Guid ID,
			string RefID,
			DateTime RefDate,
            Guid RefOrgNo,
			int RefType,
			int RefStatus,
            Guid PaymentMethod,
			string CustomerID,
			string ProductID,
			string ProductName,
			string CurrencyID,
			decimal ExchangeRate,
			string TermID,
			DateTime DueDate,
			decimal Quantity,
			decimal ReQuantity,
			decimal Price,
			decimal Amount,
            decimal Payment,
            decimal Balance,
			decimal FAmount,
			bool IsChanged,
			string Description,
			long Sorted,
			bool Active)
		{
            string[] myPara ={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@CustomerID",
			"@ProductID",
			"@ProductName",
			"@CurrencyID",
			"@ExchangeRate",
			"@TermID",
			"@DueDate",
			"@Quantity",
			"@ReQuantity",
			"@Price",
			"@Amount",
            "@Payment",
            "@Balance",
			"@FAmount",
			"@IsChanged",
			"@Description",
			"@Sorted",
			"@Active"};
            object[] myValue = { ID, RefID, RefDate, RefOrgNo, RefType, RefStatus, PaymentMethod, CustomerID, ProductID, ProductName, CurrencyID, ExchangeRate, TermID, DueDate, Quantity, ReQuantity, Price, Amount, Payment, Balance, FAmount, IsChanged, Description, Sorted, Active };
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("DEBT_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
            Guid ID,
			string RefID,
			DateTime RefDate,
            Guid RefOrgNo,
			int RefType,
			int RefStatus,
            Guid PaymentMethod,
			string CustomerID,
			string ProductID,
			string ProductName,
			string CurrencyID,
			decimal ExchangeRate,
			string TermID,
			DateTime DueDate,
			decimal Quantity,
			decimal ReQuantity,
			decimal Price,
			decimal Amount,
            decimal Payment,
            decimal Balance,
			decimal FAmount,
			bool IsChanged,
			string Description,
			long Sorted,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefID",
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@CustomerID",
			"@ProductID",
			"@ProductName",
			"@CurrencyID",
			"@ExchangeRate",
			"@TermID",
			"@DueDate",
			"@Quantity",
			"@ReQuantity",
			"@Price",
			"@Amount",
            "@Payment",
            "@Balance",
			"@FAmount",
			"@IsChanged",
			"@Description",
			"@Sorted",
			"@Active"};
            object[] myValue = { ID, RefID, RefDate, RefOrgNo, RefType, RefStatus, PaymentMethod, CustomerID, ProductID, ProductName, CurrencyID, ExchangeRate, TermID, DueDate, Quantity, ReQuantity, Price, Amount, Payment, Balance, FAmount, IsChanged, Description, Sorted, Active };
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"DEBT_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		
		
		#region Error
		
		private void DispError(object sender, SqlHelperException e)
		{
			XtraMessageBox.Show(e.Message,"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		#endregion
				
        #region Query
        private string QGetByIO
        {
            get { return @"SELECT * FROM DEBT d WHERE d.RefID = @RefID"; }
        }
        #endregion

    }

}
