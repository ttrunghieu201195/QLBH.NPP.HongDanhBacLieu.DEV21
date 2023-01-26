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
	public class PROVIDER_PAYMENT_DETAIL:Object
	{
		#region Init
		private string m_ID;
		private string m_PaymentID;
		private string m_RefOrgNo;
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
		
		
		public PROVIDER_PAYMENT_DETAIL()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_PaymentID="";
			 m_RefOrgNo="";
			 m_CurrencyID="";
			 m_ExchangeRate=0;
			 m_Quantity=0;
			 m_Amount=0;
			 m_Debit=0;
			 m_Payment=0;
			 m_DiscountPercent=0;
			 m_Discount=0;
			 m_FAmount=0;
			 m_FDebit=0;
			 m_FPayment=0;
			 m_FDiscount=0;
			 m_Description="";
			 m_Sorted=0;
		}
		public PROVIDER_PAYMENT_DETAIL(
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			 m_ID=ID;
			 m_PaymentID=PaymentID;
			 m_RefOrgNo=RefOrgNo;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_Quantity=Quantity;
			 m_Amount=Amount;
			 m_Debit=Debit;
			 m_Payment=Payment;
			 m_DiscountPercent=DiscountPercent;
			 m_Discount=Discount;
			 m_FAmount=FAmount;
			 m_FDebit=FDebit;
			 m_FPayment=FPayment;
			 m_FDiscount=FDiscount;
			 m_Description=Description;
			 m_Sorted=Sorted;
		}
		
		
		public void SetData(
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			 m_ID=ID;
			 m_PaymentID=PaymentID;
			 m_RefOrgNo=RefOrgNo;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_Quantity=Quantity;
			 m_Amount=Amount;
			 m_Debit=Debit;
			 m_Payment=Payment;
			 m_DiscountPercent=DiscountPercent;
			 m_Discount=Discount;
			 m_FAmount=FAmount;
			 m_FDebit=FDebit;
			 m_FPayment=FPayment;
			 m_FDiscount=FDiscount;
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
		[DisplayName("PaymentID")]
		[Category("Column")]
		public string PaymentID
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
		public string RefOrgNo
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
				return "Class PROVIDER_PAYMENT_DETAIL";
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
			return SqlHelper.GenCode("PROVIDER_PAYMENT_DETAIL","PROVIDER_PAYMENT_DETAILID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"PROVIDER_PAYMENT_DETAIL","PROVIDER_PAYMENT_DETAILID",key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PROVIDER_PAYMENT_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PROVIDER_PAYMENT_DETAIL_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PROVIDER_PAYMENT_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_PaymentID =Convert.ToString(myReader["PaymentID"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Debit =Convert.ToDecimal(myReader["Debit"]);
						m_Payment =Convert.ToDecimal(myReader["Payment"]);
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FDebit =Convert.ToDecimal(myReader["FDebit"]);
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_PaymentID =Convert.ToString(myReader["PaymentID"]==DBNull.Value?"":myReader["PaymentID"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Debit =Convert.ToDecimal(myReader["Debit"]==DBNull.Value?0:myReader["Debit"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]==DBNull.Value?0:myReader["DiscountPercent"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FDebit =Convert.ToDecimal(myReader["FDebit"]==DBNull.Value?0:myReader["FDebit"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PROVIDER_PAYMENT_DETAIL_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_PaymentID =Convert.ToString(myReader["PaymentID"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Debit =Convert.ToDecimal(myReader["Debit"]);
						m_Payment =Convert.ToDecimal(myReader["Payment"]);
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FDebit =Convert.ToDecimal(myReader["FDebit"]);
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_PaymentID =Convert.ToString(myReader["PaymentID"]==DBNull.Value?"":myReader["PaymentID"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_Quantity =Convert.ToDecimal(myReader["Quantity"]==DBNull.Value?0:myReader["Quantity"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Debit =Convert.ToDecimal(myReader["Debit"]==DBNull.Value?0:myReader["Debit"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]==DBNull.Value?0:myReader["DiscountPercent"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FDebit =Convert.ToDecimal(myReader["FDebit"]==DBNull.Value?0:myReader["FDebit"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			SqlTransaction myTransaction)
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
			SqlConnection myConnection)
		{

			return Insert(
			myConnection,
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
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
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
			string PaymentID,
			string RefOrgNo,
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
			return mySql.ExecuteNonQuery(myConnection,"PROVIDER_PAYMENT_DETAIL_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			SqlConnection myConnection)
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
			SqlTransaction myTransaction)
		{
			return Update(
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
		public bool Update(
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
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
			string PaymentID,
			string RefOrgNo,
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
			return mySql.ExecuteNonQuery(myConnection,"PROVIDER_PAYMENT_DETAIL_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string PaymentID,
			string RefOrgNo,
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
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
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
			m_Description);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
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
			m_Description);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
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
			m_Description);
		}
		public bool UpdateByID(
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
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
			string PaymentID,
			string RefOrgNo,
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
			string Description)
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
			"@Description"};
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
			Description};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"PROVIDER_PAYMENT_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string PaymentID,
			string RefOrgNo,
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
			string Description)
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
			"@Description"};
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
			Description};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"PROVIDER_PAYMENT_DETAIL_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myConnection,"PROVIDER_PAYMENT_DETAIL_Delete",myPara,myValue)=="OK"?true:false;
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
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"PROVIDER_PAYMENT_DETAIL_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"PROVIDER_PAYMENT_DETAIL_GetList");
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
			return mySql.ExecuteScalar(myConnection,"PROVIDER_PAYMENT_DETAIL_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"PROVIDER_PAYMENT_DETAIL_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			string RefOrgNo,
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
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefOrgNo,
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
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			string RefOrgNo,
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
			string Description)
		{
			string[] myPara={
			"@RefOrgNo",
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
			"@Description"};
			object[] myValue={
			"%"+RefOrgNo+"%",
			"%"+ExchangeRate+"%",
			"%"+Quantity+"%",
			"%"+Amount+"%",
			"%"+Debit+"%",
			"%"+Payment+"%",
			"%"+DiscountPercent+"%",
			"%"+Discount+"%",
			"%"+FAmount+"%",
			"%"+FDebit+"%",
			"%"+FPayment+"%",
			"%"+FDiscount+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"PROVIDER_PAYMENT_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			string RefOrgNo,
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
			string Description)
		{
			string[] myPara={
			"@RefOrgNo",
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
			"@Description"};
			object[] myValue={
			"%"+RefOrgNo+"%",
			"%"+ExchangeRate+"%",
			"%"+Quantity+"%",
			"%"+Amount+"%",
			"%"+Debit+"%",
			"%"+Payment+"%",
			"%"+DiscountPercent+"%",
			"%"+Discount+"%",
			"%"+FAmount+"%",
			"%"+FDebit+"%",
			"%"+FPayment+"%",
			"%"+FDiscount+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"PROVIDER_PAYMENT_DETAIL_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("PROVIDER_PAYMENT_DETAIL_LookUp");
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

	public enum PROVIDER_PAYMENT_DETAILFields
		{
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
			Sorted
		}

	#endregion

	#region Class Collection

	public class PROVIDER_PAYMENT_DETAILCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new PROVIDER_PAYMENT_DETAIL to the collection.")]
			public int Add(PROVIDER_PAYMENT_DETAIL item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a PROVIDER_PAYMENT_DETAIL from the collection.")]
			public void Remove(PROVIDER_PAYMENT_DETAIL item)
				{
					List.Remove(item);
				}
			[Description("Inserts an PROVIDER_PAYMENT_DETAIL into the collection at the specified index..")]
			public void Inserts(int index,PROVIDER_PAYMENT_DETAIL item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(PROVIDER_PAYMENT_DETAIL item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the PROVIDER_PAYMENT_DETAIL class is present in the collection.")]
			public bool Contains(PROVIDER_PAYMENT_DETAIL item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
