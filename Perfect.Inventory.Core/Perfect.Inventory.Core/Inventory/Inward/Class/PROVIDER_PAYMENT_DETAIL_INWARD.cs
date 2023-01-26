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
	/// Generated Class for Table : PROVIDER_PAYMENT_DETAIL.
	/// Date: 16/03/2010
	/// Author: Trần Hoàng Tâm
	/// </summary>
	public class PROVIDER_PAYMENT_DETAIL_INWARD:Object
	{
		#region Init
		private Guid m_ID;
		private Guid m_PaymentID;
		private Guid m_RefOrgNo;
		private string m_CurrencyID;
		private decimal m_ExchangeRate;
		private decimal m_Quantity;
		private decimal m_Amount;
		private decimal m_Debit;
		private decimal m_Payment;
		private decimal m_DiscountPercent;
		private decimal m_Discount;
		private decimal m_FAmount;
		private decimal m_FDebit;
		private decimal m_FPayment;
		private decimal m_FDiscount;
		private string m_Description;
		private long m_Sorted;


        public PROVIDER_PAYMENT_DETAIL_INWARD()
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = Guid.NewGuid();
            m_PaymentID = new Guid("11111111-1111-1111-1111-111111111111");
            m_RefOrgNo = Guid.NewGuid();
            m_CurrencyID = "";
            m_ExchangeRate = 0;
            m_Quantity = 0;
            m_Amount = 0;
            m_Debit = 0;
            m_Payment = 0;
            m_DiscountPercent = 0;
            m_Discount = 0;
            m_FAmount = 0;
            m_FDebit = 0;
            m_FPayment = 0;
            m_FDiscount = 0;
            m_Description = "";
            m_Sorted = 0;
        }
        public PROVIDER_PAYMENT_DETAIL_INWARD(
            Guid ID,
            Guid PaymentID,
            Guid RefOrgNo,
            string CurrencyID,
            decimal ExchangeRate,
            decimal Quantity,
            decimal Amount,
            decimal Debit,
            decimal Payment,
            decimal DiscountPercent,
            decimal Discount,
            decimal FAmount,
            decimal FDebit,
            decimal FPayment,
            decimal FDiscount,
            string Description,
            long Sorted)
        {
            //
            // TODO: Add constructor logic here
            //
            m_ID = ID;
            m_PaymentID = PaymentID;
            m_RefOrgNo = RefOrgNo;
            m_CurrencyID = CurrencyID;
            m_ExchangeRate = ExchangeRate;
            m_Quantity = Quantity;
            m_Amount = Amount;
            m_Debit = Debit;
            m_Payment = Payment;
            m_DiscountPercent = DiscountPercent;
            m_Discount = Discount;
            m_FAmount = FAmount;
            m_FDebit = FDebit;
            m_FPayment = FPayment;
            m_FDiscount = FDiscount;
            m_Description = Description;
            m_Sorted = Sorted;
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
		[DisplayName("PaymentID")]
		[Category("Column")]
		public Guid PaymentID
		{
			get
			{
				return m_PaymentID;
			}
			set
			{
				m_PaymentID = value;
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
		[DisplayName("Debit")]
		[Category("Column")]
		public decimal Debit
		{
			get
			{
				return m_Debit;
			}
			set
			{
				m_Debit = value;
			}
		}
		[DisplayName("Payment")]
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
		[DisplayName("DiscountPercent")]
		[Category("Column")]
		public decimal DiscountPercent
		{
			get
			{
				return m_DiscountPercent;
			}
			set
			{
				m_DiscountPercent = value;
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
		[DisplayName("FDebit")]
		[Category("Column")]
		public decimal FDebit
		{
			get
			{
				return m_FDebit;
			}
			set
			{
				m_FDebit = value;
			}
		}
		[DisplayName("FPayment")]
		[Category("Column")]
		public decimal FPayment
		{
			get
			{
				return m_FPayment;
			}
			set
			{
				m_FPayment = value;
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
                return "Class PROVIDER_PAYMENT_DETAIL_INWARD";
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
			return Get(m_ID);
		}


        public bool Get(SqlTransaction myTransaction)
        {
            return Get(myTransaction, m_ID);
        }

        public bool Get(Guid ID)
        {
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("PROVIDER_PAYMENT_DETAIL_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)myReader["ID"];
                    m_PaymentID = (Guid)myReader["PaymentID"];
                    m_RefOrgNo = (Guid)myReader["RefOrgNo"];
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Debit = Convert.ToDecimal(myReader["Debit"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_DiscountPercent = Convert.ToDecimal(myReader["DiscountPercent"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_FDebit = Convert.ToDecimal(myReader["FDebit"]);
                    m_FPayment = Convert.ToDecimal(myReader["FPayment"]);
                    m_FDiscount = Convert.ToDecimal(myReader["FDiscount"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);

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

        public bool Get(SqlTransaction myTransaction, Guid ID)
        {
            bool Result = false;
            string[] myPara ={
			"@ID"};
            object[] myValue ={
			ID};
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "PROVIDER_PAYMENT_DETAIL_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_ID = (Guid)myReader["ID"];
                    m_PaymentID = (Guid)myReader["PaymentID"];
                    m_RefOrgNo = (Guid)myReader["RefOrgNo"];
                    m_CurrencyID = Convert.ToString(myReader["CurrencyID"]);
                    m_ExchangeRate = Convert.ToDecimal(myReader["ExchangeRate"]);
                    m_Quantity = Convert.ToDecimal(myReader["Quantity"]);
                    m_Amount = Convert.ToDecimal(myReader["Amount"]);
                    m_Debit = Convert.ToDecimal(myReader["Debit"]);
                    m_Payment = Convert.ToDecimal(myReader["Payment"]);
                    m_DiscountPercent = Convert.ToDecimal(myReader["DiscountPercent"]);
                    m_Discount = Convert.ToDecimal(myReader["Discount"]);
                    m_FAmount = Convert.ToDecimal(myReader["FAmount"]);
                    m_FDebit = Convert.ToDecimal(myReader["FDebit"]);
                    m_FPayment = Convert.ToDecimal(myReader["FPayment"]);
                    m_FDiscount = Convert.ToDecimal(myReader["FDiscount"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Sorted = Convert.ToInt64(myReader["Sorted"]);
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
			m_PaymentID,
			m_RefOrgNo,
			m_CurrencyID,
			m_ExchangeRate,
			m_Quantity,
			m_Amount,
			m_Debit,
			m_Payment,
			m_DiscountPercent,
			m_Discount,
			m_FAmount,
			m_FDebit,
			m_FPayment,
			m_FDiscount,
			m_Description,
			m_Sorted);
		}
		public bool Insert(SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_PaymentID,
			m_RefOrgNo,
			m_CurrencyID,
			m_ExchangeRate,
			m_Quantity,
			m_Amount,
			m_Debit,
			m_Payment,
			m_DiscountPercent,
			m_Discount,
			m_FAmount,
			m_FDebit,
			m_FPayment,
			m_FDiscount,
			m_Description,
			m_Sorted);
		}
		
		public bool Insert(
			Guid ID,
			Guid PaymentID,
			Guid RefOrgNo,
			string CurrencyID,
			decimal ExchangeRate,
			decimal Quantity,
			decimal Amount,
			decimal Debit,
			decimal Payment,
			decimal DiscountPercent,
			decimal Discount,
			decimal FAmount,
			decimal FDebit,
			decimal FPayment,
			decimal FDiscount,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@PaymentID",
			"@RefOrgNo",
			"@CurrencyID",
			"@ExchangeRate",
			"@Quantity",
			"@Amount",
			"@Debit",
			"@Payment",
			"@DiscountPercent",
			"@Discount",
			"@FAmount",
			"@FDebit",
			"@FPayment",
			"@FDiscount",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			PaymentID,
			RefOrgNo,
			CurrencyID,
			ExchangeRate,
			Quantity,
			Amount,
			Debit,
			Payment,
			DiscountPercent,
			Discount,
			FAmount,
			FDebit,
			FPayment,
			FDiscount,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("PROVIDER_PAYMENT_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
            Guid ID,
            Guid PaymentID,
            Guid RefOrgNo,
			string CurrencyID,
			decimal ExchangeRate,
			decimal Quantity,
			decimal Amount,
			decimal Debit,
			decimal Payment,
			decimal DiscountPercent,
			decimal Discount,
			decimal FAmount,
			decimal FDebit,
			decimal FPayment,
			decimal FDiscount,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@PaymentID",
			"@RefOrgNo",
			"@CurrencyID",
			"@ExchangeRate",
			"@Quantity",
			"@Amount",
			"@Debit",
			"@Payment",
			"@DiscountPercent",
			"@Discount",
			"@FAmount",
			"@FDebit",
			"@FPayment",
			"@FDiscount",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			PaymentID,
			RefOrgNo,
			CurrencyID,
			ExchangeRate,
			Quantity,
			Amount,
			Debit,
			Payment,
			DiscountPercent,
			Discount,
			FAmount,
			FDebit,
			FPayment,
			FDiscount,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PROVIDER_PAYMENT_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region Update

        public bool UpdatePurchaseTable(SqlTransaction myTransaction, string inward)
        {
            string[] myPara = { "@STOCK_INWARD_ID" };
            object[] myValue = { inward };
            var mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "STOCK_INWARD_Update_RefStatus", myPara, myValue) == "OK" ? true : false;
        }

		public bool Update()
		{
			return Update(
			m_ID,
			m_PaymentID,
			m_RefOrgNo,
			m_CurrencyID,
			m_ExchangeRate,
			m_Quantity,
			m_Amount,
			m_Debit,
			m_Payment,
			m_DiscountPercent,
			m_Discount,
			m_FAmount,
			m_FDebit,
			m_FPayment,
			m_FDiscount,
			m_Description,
			m_Sorted);
		}
		
		public bool Update(
			Guid ID,
			Guid PaymentID,
			Guid RefOrgNo,
			string CurrencyID,
			decimal ExchangeRate,
			decimal Quantity,
			decimal Amount,
			decimal Debit,
			decimal Payment,
			decimal DiscountPercent,
			decimal Discount,
			decimal FAmount,
			decimal FDebit,
			decimal FPayment,
			decimal FDiscount,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@PaymentID",
			"@RefOrgNo",
			"@CurrencyID",
			"@ExchangeRate",
			"@Quantity",
			"@Amount",
			"@Debit",
			"@Payment",
			"@DiscountPercent",
			"@Discount",
			"@FAmount",
			"@FDebit",
			"@FPayment",
			"@FDiscount",
			"@Description",
			"@Sorted"};
			object[] myValue={
			ID,
			PaymentID,
			RefOrgNo,
			CurrencyID,
			ExchangeRate,
			Quantity,
			Amount,
			Debit,
			Payment,
			DiscountPercent,
			Discount,
			FAmount,
			FDebit,
			FPayment,
			FDiscount,
			Description,
			Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("PROVIDER_PAYMENT_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
            Guid ID,
            Guid PaymentID,
            Guid RefOrgNo,
			string CurrencyID,
			decimal ExchangeRate,
			decimal Quantity,
			decimal Amount,
			decimal Debit,
			decimal Payment,
			decimal DiscountPercent,
			decimal Discount,
			decimal FAmount,
			decimal FDebit,
			decimal FPayment,
			decimal FDiscount,
			string Description,
			long Sorted)
		{
			string[] myPara={
			"@ID",
			"@PaymentID",
			"@RefOrgNo",
			"@CurrencyID",
			"@ExchangeRate",
			"@Quantity",
			"@Amount",
			"@Debit",
			"@Payment",
			"@DiscountPercent",
			"@Discount",
			"@FAmount",
			"@FDebit",
			"@FPayment",
			"@FDiscount",
			"@Description",
			"@Sorted"};
			object[] myValue={ID,PaymentID,RefOrgNo,CurrencyID,ExchangeRate,Quantity,Amount,Debit,Payment,DiscountPercent,Discount,FAmount,FDebit,FPayment,FDiscount,Description,Sorted};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PROVIDER_PAYMENT_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region Delete
		public bool Delete()
		{
			return Delete(
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
			Guid ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery("PROVIDER_PAYMENT_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		public bool Delete(
			SqlTransaction myTransaction,
			Guid ID)
		{
			string[] myPara={
			"@ID"};
			object[] myValue={
			ID};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PROVIDER_PAYMENT_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("PROVIDER_PAYMENT_DETAIL_GetList");
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
