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
	
	public class SALE:Object
	{
		#region Init
		private string m_ID;
		private string m_RefID;
		private DateTime m_RefDate;
		private string m_RefOrgNo;
		private int m_RefType;
		private int m_RefStatus;
		private string m_PaymentMethod;
		private bool m_InvReceived;
		private string m_Series;
		private string m_Number;
		private DateTime m_InvDate;
		private string m_Barcode;
		private string m_StockID;
		private string m_CurrencyID;
		private decimal m_ExchangeRate;
		private string m_BranchID;
		private string m_ContractID;
		private string m_CustomerID;
		private string m_CustomerName;
		private string m_CustomerAddress;
		private string m_CustomerTax;
		private string m_ContactName;
		private string m_ShipViaID;
		private string m_TermID;
		private DateTime m_DueDate;
		private DateTime m_ExpectedDate;
		private DateTime m_DiscountDate;
		private decimal m_DiscountPercent;
		private decimal m_DiscountTaken;
		private bool m_IsOutward;
		private bool m_IsReceived;
		private bool m_IsClosed;
		private decimal m_Amount;
		private decimal m_Payment;
		private decimal m_VatAmount;
		private decimal m_Discount;
		private decimal m_OtherDiscount;
		private decimal m_ShipCharge;
		private decimal m_OtherCharge;
		private decimal m_FAmount;
		private decimal m_FPayment;
		private decimal m_FVatAmount;
		private decimal m_FDiscount;
		private decimal m_FOtherDiscount;
		private decimal m_FShipCharge;
		private decimal m_FOtherCharge;
		private string m_SellerID;
		private string m_DeliverID;
		private DateTime m_DeliveryDate;
		private string m_DriverID;
		private string m_TruckNumber;
		private string m_CarryingMeans;
		private bool m_IsPublic;
		private string m_CreatedBy;
		private DateTime m_CreatedDate;
		private string m_ModifiedBy;
		private DateTime m_ModifiedDate;
		private string m_OwnerID;
		private string m_Description;
		private long m_Sorted;
		private bool m_Active;
		
		
		public SALE()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_RefID="";
			 m_RefDate=DateTime.Now;
			 m_RefOrgNo="";
			 m_RefType=0;
			 m_RefStatus=0;
			 m_PaymentMethod="";
			 m_InvReceived=true;
			 m_Series="";
			 m_Number="";
			 m_InvDate=DateTime.Now;
			 m_Barcode="";
			 m_StockID="";
			 m_CurrencyID="";
			 m_ExchangeRate=0;
			 m_BranchID="";
			 m_ContractID="";
			 m_CustomerID="";
			 m_CustomerName="";
			 m_CustomerAddress="";
			 m_CustomerTax="";
			 m_ContactName="";
			 m_ShipViaID="";
			 m_TermID="";
			 m_DueDate=DateTime.Now;
			 m_ExpectedDate=DateTime.Now;
			 m_DiscountDate=DateTime.Now;
			 m_DiscountPercent=0;
			 m_DiscountTaken=0;
			 m_IsOutward=true;
			 m_IsReceived=true;
			 m_IsClosed=true;
			 m_Amount=0;
			 m_Payment=0;
			 m_VatAmount=0;
			 m_Discount=0;
			 m_OtherDiscount=0;
			 m_ShipCharge=0;
			 m_OtherCharge=0;
			 m_FAmount=0;
			 m_FPayment=0;
			 m_FVatAmount=0;
			 m_FDiscount=0;
			 m_FOtherDiscount=0;
			 m_FShipCharge=0;
			 m_FOtherCharge=0;
			 m_SellerID="";
			 m_DeliverID="";
			 m_DeliveryDate=DateTime.Now;
			 m_DriverID="";
			 m_TruckNumber="";
			 m_CarryingMeans="";
			 m_IsPublic=true;
			 m_CreatedBy="";
			 m_CreatedDate=DateTime.Now;
			 m_ModifiedBy="";
			 m_ModifiedDate=DateTime.Now;
			 m_OwnerID="";
			 m_Description="";
			 m_Sorted=0;
			 m_Active=true;
		}
		public SALE(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_RefID=RefID;
			 m_RefDate=RefDate;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefStatus=RefStatus;
			 m_PaymentMethod=PaymentMethod;
			 m_InvReceived=InvReceived;
			 m_Series=Series;
			 m_Number=Number;
			 m_InvDate=InvDate;
			 m_Barcode=Barcode;
			 m_StockID=StockID;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_BranchID=BranchID;
			 m_ContractID=ContractID;
			 m_CustomerID=CustomerID;
			 m_CustomerName=CustomerName;
			 m_CustomerAddress=CustomerAddress;
			 m_CustomerTax=CustomerTax;
			 m_ContactName=ContactName;
			 m_ShipViaID=ShipViaID;
			 m_TermID=TermID;
			 m_DueDate=DueDate;
			 m_ExpectedDate=ExpectedDate;
			 m_DiscountDate=DiscountDate;
			 m_DiscountPercent=DiscountPercent;
			 m_DiscountTaken=DiscountTaken;
			 m_IsOutward=IsOutward;
			 m_IsReceived=IsReceived;
			 m_IsClosed=IsClosed;
			 m_Amount=Amount;
			 m_Payment=Payment;
			 m_VatAmount=VatAmount;
			 m_Discount=Discount;
			 m_OtherDiscount=OtherDiscount;
			 m_ShipCharge=ShipCharge;
			 m_OtherCharge=OtherCharge;
			 m_FAmount=FAmount;
			 m_FPayment=FPayment;
			 m_FVatAmount=FVatAmount;
			 m_FDiscount=FDiscount;
			 m_FOtherDiscount=FOtherDiscount;
			 m_FShipCharge=FShipCharge;
			 m_FOtherCharge=FOtherCharge;
			 m_SellerID=SellerID;
			 m_DeliverID=DeliverID;
			 m_DeliveryDate=DeliveryDate;
			 m_DriverID=DriverID;
			 m_TruckNumber=TruckNumber;
			 m_CarryingMeans=CarryingMeans;
			 m_IsPublic=IsPublic;
			 m_CreatedBy=CreatedBy;
			 m_CreatedDate=CreatedDate;
			 m_ModifiedBy=ModifiedBy;
			 m_ModifiedDate=ModifiedDate;
			 m_OwnerID=OwnerID;
			 m_Description=Description;
			 m_Sorted=Sorted;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_RefID=RefID;
			 m_RefDate=RefDate;
			 m_RefOrgNo=RefOrgNo;
			 m_RefType=RefType;
			 m_RefStatus=RefStatus;
			 m_PaymentMethod=PaymentMethod;
			 m_InvReceived=InvReceived;
			 m_Series=Series;
			 m_Number=Number;
			 m_InvDate=InvDate;
			 m_Barcode=Barcode;
			 m_StockID=StockID;
			 m_CurrencyID=CurrencyID;
			 m_ExchangeRate=ExchangeRate;
			 m_BranchID=BranchID;
			 m_ContractID=ContractID;
			 m_CustomerID=CustomerID;
			 m_CustomerName=CustomerName;
			 m_CustomerAddress=CustomerAddress;
			 m_CustomerTax=CustomerTax;
			 m_ContactName=ContactName;
			 m_ShipViaID=ShipViaID;
			 m_TermID=TermID;
			 m_DueDate=DueDate;
			 m_ExpectedDate=ExpectedDate;
			 m_DiscountDate=DiscountDate;
			 m_DiscountPercent=DiscountPercent;
			 m_DiscountTaken=DiscountTaken;
			 m_IsOutward=IsOutward;
			 m_IsReceived=IsReceived;
			 m_IsClosed=IsClosed;
			 m_Amount=Amount;
			 m_Payment=Payment;
			 m_VatAmount=VatAmount;
			 m_Discount=Discount;
			 m_OtherDiscount=OtherDiscount;
			 m_ShipCharge=ShipCharge;
			 m_OtherCharge=OtherCharge;
			 m_FAmount=FAmount;
			 m_FPayment=FPayment;
			 m_FVatAmount=FVatAmount;
			 m_FDiscount=FDiscount;
			 m_FOtherDiscount=FOtherDiscount;
			 m_FShipCharge=FShipCharge;
			 m_FOtherCharge=FOtherCharge;
			 m_SellerID=SellerID;
			 m_DeliverID=DeliverID;
			 m_DeliveryDate=DeliveryDate;
			 m_DriverID=DriverID;
			 m_TruckNumber=TruckNumber;
			 m_CarryingMeans=CarryingMeans;
			 m_IsPublic=IsPublic;
			 m_CreatedBy=CreatedBy;
			 m_CreatedDate=CreatedDate;
			 m_ModifiedBy=ModifiedBy;
			 m_ModifiedDate=ModifiedDate;
			 m_OwnerID=OwnerID;
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
		public string PaymentMethod
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
		[DisplayName("InvReceived")]
		[Category("Column")]
		public bool InvReceived
		{
			get
			{
				return m_InvReceived;
			}
			set
			{
				m_InvReceived = value;
			}
		}
		[DisplayName("Series")]
		[Category("Column")]
		public string Series
		{
			get
			{
				return m_Series;
			}
			set
			{
				m_Series = value;
			}
		}
		[DisplayName("Number")]
		[Category("Column")]
		public string Number
		{
			get
			{
				return m_Number;
			}
			set
			{
				m_Number = value;
			}
		}
		[DisplayName("InvDate")]
		[Category("Column")]
		public DateTime InvDate
		{
			get
			{
				return m_InvDate;
			}
			set
			{
				m_InvDate = value;
			}
		}
		[DisplayName("Barcode")]
		[Category("Column")]
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
		[DisplayName("BranchID")]
		[Category("Column")]
		public string BranchID
		{
			get
			{
				return m_BranchID;
			}
			set
			{
				m_BranchID = value;
			}
		}
		[DisplayName("ContractID")]
		[Category("Column")]
		public string ContractID
		{
			get
			{
				return m_ContractID;
			}
			set
			{
				m_ContractID = value;
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
		[DisplayName("CustomerName")]
		[Category("Column")]
		public string CustomerName
		{
			get
			{
				return m_CustomerName;
			}
			set
			{
				m_CustomerName = value;
			}
		}
		[DisplayName("CustomerAddress")]
		[Category("Column")]
		public string CustomerAddress
		{
			get
			{
				return m_CustomerAddress;
			}
			set
			{
				m_CustomerAddress = value;
			}
		}
		[DisplayName("CustomerTax")]
		[Category("Column")]
		public string CustomerTax
		{
			get
			{
				return m_CustomerTax;
			}
			set
			{
				m_CustomerTax = value;
			}
		}
		[DisplayName("ContactName")]
		[Category("Column")]
		public string ContactName
		{
			get
			{
				return m_ContactName;
			}
			set
			{
				m_ContactName = value;
			}
		}
		[DisplayName("ShipViaID")]
		[Category("Column")]
		public string ShipViaID
		{
			get
			{
				return m_ShipViaID;
			}
			set
			{
				m_ShipViaID = value;
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
		[DisplayName("ExpectedDate")]
		[Category("Column")]
		public DateTime ExpectedDate
		{
			get
			{
				return m_ExpectedDate;
			}
			set
			{
				m_ExpectedDate = value;
			}
		}
		[DisplayName("DiscountDate")]
		[Category("Column")]
		public DateTime DiscountDate
		{
			get
			{
				return m_DiscountDate;
			}
			set
			{
				m_DiscountDate = value;
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
		[DisplayName("DiscountTaken")]
		[Category("Column")]
		public decimal DiscountTaken
		{
			get
			{
				return m_DiscountTaken;
			}
			set
			{
				m_DiscountTaken = value;
			}
		}
		[DisplayName("IsOutward")]
		[Category("Column")]
		public bool IsOutward
		{
			get
			{
				return m_IsOutward;
			}
			set
			{
				m_IsOutward = value;
			}
		}
		[DisplayName("IsReceived")]
		[Category("Column")]
		public bool IsReceived
		{
			get
			{
				return m_IsReceived;
			}
			set
			{
				m_IsReceived = value;
			}
		}
		[DisplayName("IsClosed")]
		[Category("Column")]
		public bool IsClosed
		{
			get
			{
				return m_IsClosed;
			}
			set
			{
				m_IsClosed = value;
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
		[DisplayName("OtherDiscount")]
		[Category("Column")]
		public decimal OtherDiscount
		{
			get
			{
				return m_OtherDiscount;
			}
			set
			{
				m_OtherDiscount = value;
			}
		}
		[DisplayName("ShipCharge")]
		[Category("Column")]
		public decimal ShipCharge
		{
			get
			{
				return m_ShipCharge;
			}
			set
			{
				m_ShipCharge = value;
			}
		}
		[DisplayName("OtherCharge")]
		[Category("Column")]
		public decimal OtherCharge
		{
			get
			{
				return m_OtherCharge;
			}
			set
			{
				m_OtherCharge = value;
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
		[DisplayName("FOtherDiscount")]
		[Category("Column")]
		public decimal FOtherDiscount
		{
			get
			{
				return m_FOtherDiscount;
			}
			set
			{
				m_FOtherDiscount = value;
			}
		}
		[DisplayName("FShipCharge")]
		[Category("Column")]
		public decimal FShipCharge
		{
			get
			{
				return m_FShipCharge;
			}
			set
			{
				m_FShipCharge = value;
			}
		}
		[DisplayName("FOtherCharge")]
		[Category("Column")]
		public decimal FOtherCharge
		{
			get
			{
				return m_FOtherCharge;
			}
			set
			{
				m_FOtherCharge = value;
			}
		}
		[DisplayName("SellerID")]
		[Category("Column")]
		public string SellerID
		{
			get
			{
				return m_SellerID;
			}
			set
			{
				m_SellerID = value;
			}
		}
		[DisplayName("DeliverID")]
		[Category("Column")]
		public string DeliverID
		{
			get
			{
				return m_DeliverID;
			}
			set
			{
				m_DeliverID = value;
			}
		}
		[DisplayName("DeliveryDate")]
		[Category("Column")]
		public DateTime DeliveryDate
		{
			get
			{
				return m_DeliveryDate;
			}
			set
			{
				m_DeliveryDate = value;
			}
		}
		[DisplayName("DriverID")]
		[Category("Column")]
		public string DriverID
		{
			get
			{
				return m_DriverID;
			}
			set
			{
				m_DriverID = value;
			}
		}
		[DisplayName("TruckNumber")]
		[Category("Column")]
		public string TruckNumber
		{
			get
			{
				return m_TruckNumber;
			}
			set
			{
				m_TruckNumber = value;
			}
		}
		[DisplayName("CarryingMeans")]
		[Category("Column")]
		public string CarryingMeans
		{
			get
			{
				return m_CarryingMeans;
			}
			set
			{
				m_CarryingMeans = value;
			}
		}
		[DisplayName("IsPublic")]
		[Category("Column")]
		public bool IsPublic
		{
			get
			{
				return m_IsPublic;
			}
			set
			{
				m_IsPublic = value;
			}
		}
		[DisplayName("CreatedBy")]
		[Category("Column")]
		public string CreatedBy
		{
			get
			{
				return m_CreatedBy;
			}
			set
			{
				m_CreatedBy = value;
			}
		}
		[DisplayName("CreatedDate")]
		[Category("Column")]
		public DateTime CreatedDate
		{
			get
			{
				return m_CreatedDate;
			}
			set
			{
				m_CreatedDate = value;
			}
		}
		[DisplayName("ModifiedBy")]
		[Category("Column")]
		public string ModifiedBy
		{
			get
			{
				return m_ModifiedBy;
			}
			set
			{
				m_ModifiedBy = value;
			}
		}
		[DisplayName("ModifiedDate")]
		[Category("Column")]
		public DateTime ModifiedDate
		{
			get
			{
				return m_ModifiedDate;
			}
			set
			{
				m_ModifiedDate = value;
			}
		}
		[DisplayName("OwnerID")]
		[Category("Column")]
		public string OwnerID
		{
			get
			{
				return m_OwnerID;
			}
			set
			{
				m_OwnerID = value;
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
				return "Class SALE";
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
			return SqlHelper.GenCode("SALE","SALEID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"SALE","SALEID",key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_Get",myPara,myValue);
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

		#region Exist By ID

		public bool ExistByID()
		{
				return ExistByID(m_RefID);
		}


		public bool ExistByID(string ID)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open() !="OK") return false;
            if (ExistByID(mySql.Connection, ID))
				{
					mySql.Close();
					return true;
				};
			return false;

		}


		public bool ExistByID(SqlTransaction myTransaction,string ID)
		{
			bool Result=false;
			string[] myPara={"@RefID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_ExistByID",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				myReader = null;
			}
			return Result;
		}

		public bool ExistByID(
			SqlConnection myConnection,
			string ID)
		{
			bool Result=false;
			string[] myPara={"@RefID"};
			object[] myValue={ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_ExistByID",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
			}
			return Result;
		}

		#endregion

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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SALE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]);
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]);
						m_InvReceived =Convert.ToBoolean(myReader["InvReceived"]);
						m_Series =Convert.ToString(myReader["Series"]);
						m_Number =Convert.ToString(myReader["Number"]);
						m_InvDate =Convert.ToDateTime(myReader["InvDate"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_StockID =Convert.ToString(myReader["StockID"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_BranchID =Convert.ToString(myReader["BranchID"]);
						m_ContractID =Convert.ToString(myReader["ContractID"]);
						m_CustomerID =Convert.ToString(myReader["CustomerID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]);
						m_ContactName =Convert.ToString(myReader["ContactName"]);
						m_ShipViaID =Convert.ToString(myReader["ShipViaID"]);
						m_TermID =Convert.ToString(myReader["TermID"]);
						m_DueDate =Convert.ToDateTime(myReader["DueDate"]);
						m_ExpectedDate =Convert.ToDateTime(myReader["ExpectedDate"]);
						m_DiscountDate =Convert.ToDateTime(myReader["DiscountDate"]);
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]);
						m_DiscountTaken =Convert.ToDecimal(myReader["DiscountTaken"]);
						m_IsOutward =Convert.ToBoolean(myReader["IsOutward"]);
						m_IsReceived =Convert.ToBoolean(myReader["IsReceived"]);
						m_IsClosed =Convert.ToBoolean(myReader["IsClosed"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Payment =Convert.ToDecimal(myReader["Payment"]);
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_OtherDiscount =Convert.ToDecimal(myReader["OtherDiscount"]);
						m_ShipCharge =Convert.ToDecimal(myReader["ShipCharge"]);
						m_OtherCharge =Convert.ToDecimal(myReader["OtherCharge"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]);
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_FOtherDiscount =Convert.ToDecimal(myReader["FOtherDiscount"]);
						m_FShipCharge =Convert.ToDecimal(myReader["FShipCharge"]);
						m_FOtherCharge =Convert.ToDecimal(myReader["FOtherCharge"]);
						m_SellerID =Convert.ToString(myReader["SellerID"]);
						m_DeliverID =Convert.ToString(myReader["DeliverID"]);
						m_DeliveryDate =Convert.ToDateTime(myReader["DeliveryDate"]);
						m_DriverID =Convert.ToString(myReader["DriverID"]);
						m_TruckNumber =Convert.ToString(myReader["TruckNumber"]);
						m_CarryingMeans =Convert.ToString(myReader["CarryingMeans"]);
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]);
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						m_OwnerID =Convert.ToString(myReader["OwnerID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
						m_InvReceived =Convert.ToBoolean(myReader["InvReceived"]==DBNull.Value?true:myReader["InvReceived"] );
						m_Series =Convert.ToString(myReader["Series"]==DBNull.Value?"":myReader["Series"] );
						m_Number =Convert.ToString(myReader["Number"]==DBNull.Value?"":myReader["Number"] );
						m_InvDate =Convert.ToDateTime(myReader["InvDate"]==DBNull.Value?DateTime.Now:myReader["InvDate"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_StockID =Convert.ToString(myReader["StockID"]==DBNull.Value?"":myReader["StockID"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_BranchID =Convert.ToString(myReader["BranchID"]==DBNull.Value?"":myReader["BranchID"] );
						m_ContractID =Convert.ToString(myReader["ContractID"]==DBNull.Value?"":myReader["ContractID"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]==DBNull.Value?"":myReader["CustomerTax"] );
						m_ContactName =Convert.ToString(myReader["ContactName"]==DBNull.Value?"":myReader["ContactName"] );
						m_ShipViaID =Convert.ToString(myReader["ShipViaID"]==DBNull.Value?"":myReader["ShipViaID"] );
						m_TermID =Convert.ToString(myReader["TermID"]==DBNull.Value?"":myReader["TermID"] );
						m_DueDate =Convert.ToDateTime(myReader["DueDate"]==DBNull.Value?DateTime.Now:myReader["DueDate"] );
						m_ExpectedDate =Convert.ToDateTime(myReader["ExpectedDate"]==DBNull.Value?DateTime.Now:myReader["ExpectedDate"] );
						m_DiscountDate =Convert.ToDateTime(myReader["DiscountDate"]==DBNull.Value?DateTime.Now:myReader["DiscountDate"] );
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]==DBNull.Value?0:myReader["DiscountPercent"] );
						m_DiscountTaken =Convert.ToDecimal(myReader["DiscountTaken"]==DBNull.Value?0:myReader["DiscountTaken"] );
						m_IsOutward =Convert.ToBoolean(myReader["IsOutward"]==DBNull.Value?true:myReader["IsOutward"] );
						m_IsReceived =Convert.ToBoolean(myReader["IsReceived"]==DBNull.Value?true:myReader["IsReceived"] );
						m_IsClosed =Convert.ToBoolean(myReader["IsClosed"]==DBNull.Value?true:myReader["IsClosed"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]==DBNull.Value?0:myReader["VatAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_OtherDiscount =Convert.ToDecimal(myReader["OtherDiscount"]==DBNull.Value?0:myReader["OtherDiscount"] );
						m_ShipCharge =Convert.ToDecimal(myReader["ShipCharge"]==DBNull.Value?0:myReader["ShipCharge"] );
						m_OtherCharge =Convert.ToDecimal(myReader["OtherCharge"]==DBNull.Value?0:myReader["OtherCharge"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]==DBNull.Value?0:myReader["FVatAmount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_FOtherDiscount =Convert.ToDecimal(myReader["FOtherDiscount"]==DBNull.Value?0:myReader["FOtherDiscount"] );
						m_FShipCharge =Convert.ToDecimal(myReader["FShipCharge"]==DBNull.Value?0:myReader["FShipCharge"] );
						m_FOtherCharge =Convert.ToDecimal(myReader["FOtherCharge"]==DBNull.Value?0:myReader["FOtherCharge"] );
						m_SellerID =Convert.ToString(myReader["SellerID"]==DBNull.Value?"":myReader["SellerID"] );
						m_DeliverID =Convert.ToString(myReader["DeliverID"]==DBNull.Value?"":myReader["DeliverID"] );
						m_DeliveryDate =Convert.ToDateTime(myReader["DeliveryDate"]==DBNull.Value?DateTime.Now:myReader["DeliveryDate"] );
						m_DriverID =Convert.ToString(myReader["DriverID"]==DBNull.Value?"":myReader["DriverID"] );
						m_TruckNumber =Convert.ToString(myReader["TruckNumber"]==DBNull.Value?"":myReader["TruckNumber"] );
						m_CarryingMeans =Convert.ToString(myReader["CarryingMeans"]==DBNull.Value?"":myReader["CarryingMeans"] );
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
						m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SALE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefID =Convert.ToString(myReader["RefID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]);
						m_RefType =Convert.ToInt16(myReader["RefType"]);
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]);
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]);
						m_InvReceived =Convert.ToBoolean(myReader["InvReceived"]);
						m_Series =Convert.ToString(myReader["Series"]);
						m_Number =Convert.ToString(myReader["Number"]);
						m_InvDate =Convert.ToDateTime(myReader["InvDate"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_StockID =Convert.ToString(myReader["StockID"]);
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]);
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]);
						m_BranchID =Convert.ToString(myReader["BranchID"]);
						m_ContractID =Convert.ToString(myReader["ContractID"]);
						m_CustomerID =Convert.ToString(myReader["CustomerID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]);
						m_ContactName =Convert.ToString(myReader["ContactName"]);
						m_ShipViaID =Convert.ToString(myReader["ShipViaID"]);
						m_TermID =Convert.ToString(myReader["TermID"]);
						m_DueDate =Convert.ToDateTime(myReader["DueDate"]);
						m_ExpectedDate =Convert.ToDateTime(myReader["ExpectedDate"]);
						m_DiscountDate =Convert.ToDateTime(myReader["DiscountDate"]);
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]);
						m_DiscountTaken =Convert.ToDecimal(myReader["DiscountTaken"]);
						m_IsOutward =Convert.ToBoolean(myReader["IsOutward"]);
						m_IsReceived =Convert.ToBoolean(myReader["IsReceived"]);
						m_IsClosed =Convert.ToBoolean(myReader["IsClosed"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_Payment =Convert.ToDecimal(myReader["Payment"]);
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]);
						m_Discount =Convert.ToDecimal(myReader["Discount"]);
						m_OtherDiscount =Convert.ToDecimal(myReader["OtherDiscount"]);
						m_ShipCharge =Convert.ToDecimal(myReader["ShipCharge"]);
						m_OtherCharge =Convert.ToDecimal(myReader["OtherCharge"]);
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]);
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]);
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]);
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]);
						m_FOtherDiscount =Convert.ToDecimal(myReader["FOtherDiscount"]);
						m_FShipCharge =Convert.ToDecimal(myReader["FShipCharge"]);
						m_FOtherCharge =Convert.ToDecimal(myReader["FOtherCharge"]);
						m_SellerID =Convert.ToString(myReader["SellerID"]);
						m_DeliverID =Convert.ToString(myReader["DeliverID"]);
						m_DeliveryDate =Convert.ToDateTime(myReader["DeliveryDate"]);
						m_DriverID =Convert.ToString(myReader["DriverID"]);
						m_TruckNumber =Convert.ToString(myReader["TruckNumber"]);
						m_CarryingMeans =Convert.ToString(myReader["CarryingMeans"]);
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]);
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]);
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]);
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]);
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]);
						m_OwnerID =Convert.ToString(myReader["OwnerID"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefID =Convert.ToString(myReader["RefID"]==DBNull.Value?"":myReader["RefID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_RefOrgNo =Convert.ToString(myReader["RefOrgNo"]==DBNull.Value?"":myReader["RefOrgNo"] );
						m_RefType =Convert.ToInt16(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_RefStatus =Convert.ToInt16(myReader["RefStatus"]==DBNull.Value?0:myReader["RefStatus"] );
						m_PaymentMethod =Convert.ToString(myReader["PaymentMethod"]==DBNull.Value?"":myReader["PaymentMethod"] );
						m_InvReceived =Convert.ToBoolean(myReader["InvReceived"]==DBNull.Value?true:myReader["InvReceived"] );
						m_Series =Convert.ToString(myReader["Series"]==DBNull.Value?"":myReader["Series"] );
						m_Number =Convert.ToString(myReader["Number"]==DBNull.Value?"":myReader["Number"] );
						m_InvDate =Convert.ToDateTime(myReader["InvDate"]==DBNull.Value?DateTime.Now:myReader["InvDate"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_StockID =Convert.ToString(myReader["StockID"]==DBNull.Value?"":myReader["StockID"] );
						m_CurrencyID =Convert.ToString(myReader["CurrencyID"]==DBNull.Value?"":myReader["CurrencyID"] );
						m_ExchangeRate =Convert.ToDecimal(myReader["ExchangeRate"]==DBNull.Value?0:myReader["ExchangeRate"] );
						m_BranchID =Convert.ToString(myReader["BranchID"]==DBNull.Value?"":myReader["BranchID"] );
						m_ContractID =Convert.ToString(myReader["ContractID"]==DBNull.Value?"":myReader["ContractID"] );
						m_CustomerID =Convert.ToString(myReader["CustomerID"]==DBNull.Value?"":myReader["CustomerID"] );
						m_CustomerName =Convert.ToString(myReader["CustomerName"]==DBNull.Value?"":myReader["CustomerName"] );
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]==DBNull.Value?"":myReader["CustomerAddress"] );
						m_CustomerTax =Convert.ToString(myReader["CustomerTax"]==DBNull.Value?"":myReader["CustomerTax"] );
						m_ContactName =Convert.ToString(myReader["ContactName"]==DBNull.Value?"":myReader["ContactName"] );
						m_ShipViaID =Convert.ToString(myReader["ShipViaID"]==DBNull.Value?"":myReader["ShipViaID"] );
						m_TermID =Convert.ToString(myReader["TermID"]==DBNull.Value?"":myReader["TermID"] );
						m_DueDate =Convert.ToDateTime(myReader["DueDate"]==DBNull.Value?DateTime.Now:myReader["DueDate"] );
						m_ExpectedDate =Convert.ToDateTime(myReader["ExpectedDate"]==DBNull.Value?DateTime.Now:myReader["ExpectedDate"] );
						m_DiscountDate =Convert.ToDateTime(myReader["DiscountDate"]==DBNull.Value?DateTime.Now:myReader["DiscountDate"] );
						m_DiscountPercent =Convert.ToDecimal(myReader["DiscountPercent"]==DBNull.Value?0:myReader["DiscountPercent"] );
						m_DiscountTaken =Convert.ToDecimal(myReader["DiscountTaken"]==DBNull.Value?0:myReader["DiscountTaken"] );
						m_IsOutward =Convert.ToBoolean(myReader["IsOutward"]==DBNull.Value?true:myReader["IsOutward"] );
						m_IsReceived =Convert.ToBoolean(myReader["IsReceived"]==DBNull.Value?true:myReader["IsReceived"] );
						m_IsClosed =Convert.ToBoolean(myReader["IsClosed"]==DBNull.Value?true:myReader["IsClosed"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_Payment =Convert.ToDecimal(myReader["Payment"]==DBNull.Value?0:myReader["Payment"] );
						m_VatAmount =Convert.ToDecimal(myReader["VatAmount"]==DBNull.Value?0:myReader["VatAmount"] );
						m_Discount =Convert.ToDecimal(myReader["Discount"]==DBNull.Value?0:myReader["Discount"] );
						m_OtherDiscount =Convert.ToDecimal(myReader["OtherDiscount"]==DBNull.Value?0:myReader["OtherDiscount"] );
						m_ShipCharge =Convert.ToDecimal(myReader["ShipCharge"]==DBNull.Value?0:myReader["ShipCharge"] );
						m_OtherCharge =Convert.ToDecimal(myReader["OtherCharge"]==DBNull.Value?0:myReader["OtherCharge"] );
						m_FAmount =Convert.ToDecimal(myReader["FAmount"]==DBNull.Value?0:myReader["FAmount"] );
						m_FPayment =Convert.ToDecimal(myReader["FPayment"]==DBNull.Value?0:myReader["FPayment"] );
						m_FVatAmount =Convert.ToDecimal(myReader["FVatAmount"]==DBNull.Value?0:myReader["FVatAmount"] );
						m_FDiscount =Convert.ToDecimal(myReader["FDiscount"]==DBNull.Value?0:myReader["FDiscount"] );
						m_FOtherDiscount =Convert.ToDecimal(myReader["FOtherDiscount"]==DBNull.Value?0:myReader["FOtherDiscount"] );
						m_FShipCharge =Convert.ToDecimal(myReader["FShipCharge"]==DBNull.Value?0:myReader["FShipCharge"] );
						m_FOtherCharge =Convert.ToDecimal(myReader["FOtherCharge"]==DBNull.Value?0:myReader["FOtherCharge"] );
						m_SellerID =Convert.ToString(myReader["SellerID"]==DBNull.Value?"":myReader["SellerID"] );
						m_DeliverID =Convert.ToString(myReader["DeliverID"]==DBNull.Value?"":myReader["DeliverID"] );
						m_DeliveryDate =Convert.ToDateTime(myReader["DeliveryDate"]==DBNull.Value?DateTime.Now:myReader["DeliveryDate"] );
						m_DriverID =Convert.ToString(myReader["DriverID"]==DBNull.Value?"":myReader["DriverID"] );
						m_TruckNumber =Convert.ToString(myReader["TruckNumber"]==DBNull.Value?"":myReader["TruckNumber"] );
						m_CarryingMeans =Convert.ToString(myReader["CarryingMeans"]==DBNull.Value?"":myReader["CarryingMeans"] );
						m_IsPublic =Convert.ToBoolean(myReader["IsPublic"]==DBNull.Value?true:myReader["IsPublic"] );
						m_CreatedBy =Convert.ToString(myReader["CreatedBy"]==DBNull.Value?"":myReader["CreatedBy"] );
						m_CreatedDate =Convert.ToDateTime(myReader["CreatedDate"]==DBNull.Value?DateTime.Now:myReader["CreatedDate"] );
						m_ModifiedBy =Convert.ToString(myReader["ModifiedBy"]==DBNull.Value?"":myReader["ModifiedBy"] );
						m_ModifiedDate =Convert.ToDateTime(myReader["ModifiedDate"]==DBNull.Value?DateTime.Now:myReader["ModifiedDate"] );
						m_OwnerID =Convert.ToString(myReader["OwnerID"]==DBNull.Value?"":myReader["OwnerID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
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
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
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
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Insert(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
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
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
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
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
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
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@StockID",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@ShipViaID",
			"@TermID",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@SellerID",
			"@DeliverID",
			"@DeliveryDate",
			"@DriverID",
			"@TruckNumber",
			"@CarryingMeans",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
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
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
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
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@StockID",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@ShipViaID",
			"@TermID",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@SellerID",
			"@DeliverID",
			"@DeliveryDate",
			"@DriverID",
			"@TruckNumber",
			"@CarryingMeans",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
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
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_Insert",myPara,myValue)=="OK"?true:false;
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
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
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
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_CreatedBy,
			m_CreatedDate,
			m_ModifiedBy,
			m_ModifiedDate,
			m_OwnerID,
			m_Description,
			m_Sorted,
			m_Active);
		}
		public bool Update(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
			string Description,
			long Sorted,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(
			Update(
			mySql.Connection,
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
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
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
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
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@StockID",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@ShipViaID",
			"@TermID",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@SellerID",
			"@DeliverID",
			"@DeliveryDate",
			"@DriverID",
			"@TruckNumber",
			"@CarryingMeans",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
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
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_Update",myPara,myValue)=="OK"?true:false;
		}
		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string CreatedBy,
			DateTime CreatedDate,
			string ModifiedBy,
			DateTime ModifiedDate,
			string OwnerID,
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
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@StockID",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@ShipViaID",
			"@TermID",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@SellerID",
			"@DeliverID",
			"@DeliveryDate",
			"@DriverID",
			"@TruckNumber",
			"@CarryingMeans",
			"@IsPublic",
			"@CreatedBy",
			"@CreatedDate",
			"@ModifiedBy",
			"@ModifiedDate",
			"@OwnerID",
			"@Description",
			"@Sorted",
			"@Active"};
			object[] myValue={ID,RefID,RefDate,RefOrgNo,RefType,RefStatus,PaymentMethod,InvReceived,Series,Number,InvDate,Barcode,StockID,CurrencyID,ExchangeRate,BranchID,ContractID,CustomerID,CustomerName,CustomerAddress,CustomerTax,ContactName,ShipViaID,TermID,DueDate,ExpectedDate,DiscountDate,DiscountPercent,DiscountTaken,IsOutward,IsReceived,IsClosed,Amount,Payment,VatAmount,Discount,OtherDiscount,ShipCharge,OtherCharge,FAmount,FPayment,FVatAmount,FDiscount,FOtherDiscount,FShipCharge,FOtherCharge,SellerID,DeliverID,DeliveryDate,DriverID,TruckNumber,CarryingMeans,IsPublic,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,OwnerID,Description,Sorted,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_ModifiedBy,
			m_ModifiedDate,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_ID,
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_ModifiedBy,
			m_ModifiedDate,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_ID,
			m_RefID,
			m_RefDate,
			m_RefOrgNo,
			m_RefType,
			m_RefStatus,
			m_PaymentMethod,
			m_InvReceived,
			m_Series,
			m_Number,
			m_InvDate,
			m_Barcode,
			m_StockID,
			m_CurrencyID,
			m_ExchangeRate,
			m_BranchID,
			m_ContractID,
			m_CustomerID,
			m_CustomerName,
			m_CustomerAddress,
			m_CustomerTax,
			m_ContactName,
			m_ShipViaID,
			m_TermID,
			m_DueDate,
			m_ExpectedDate,
			m_DiscountDate,
			m_DiscountPercent,
			m_DiscountTaken,
			m_IsOutward,
			m_IsReceived,
			m_IsClosed,
			m_Amount,
			m_Payment,
			m_VatAmount,
			m_Discount,
			m_OtherDiscount,
			m_ShipCharge,
			m_OtherCharge,
			m_FAmount,
			m_FPayment,
			m_FVatAmount,
			m_FDiscount,
			m_FOtherDiscount,
			m_FShipCharge,
			m_FOtherCharge,
			m_SellerID,
			m_DeliverID,
			m_DeliveryDate,
			m_DriverID,
			m_TruckNumber,
			m_CarryingMeans,
			m_IsPublic,
			m_ModifiedBy,
			m_ModifiedDate,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
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
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
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
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@StockID",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@ShipViaID",
			"@TermID",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@SellerID",
			"@DeliverID",
			"@DeliveryDate",
			"@DriverID",
			"@TruckNumber",
			"@CarryingMeans",
			"@IsPublic",
			"@ModifiedBy",
			"@ModifiedDate",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"SALE_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			string RefID,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			string StockID,
			string CurrencyID,
			decimal ExchangeRate,
			string BranchID,
			string ContractID,
			string CustomerID,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			string ShipViaID,
			string TermID,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			string SellerID,
			string DeliverID,
			DateTime DeliveryDate,
			string DriverID,
			string TruckNumber,
			string CarryingMeans,
			bool IsPublic,
			string ModifiedBy,
			DateTime ModifiedDate,
			string Description,
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
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@StockID",
			"@CurrencyID",
			"@ExchangeRate",
			"@BranchID",
			"@ContractID",
			"@CustomerID",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@ShipViaID",
			"@TermID",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@SellerID",
			"@DeliverID",
			"@DeliveryDate",
			"@DriverID",
			"@TruckNumber",
			"@CarryingMeans",
			"@IsPublic",
			"@ModifiedBy",
			"@ModifiedDate",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			ModifiedBy,
			ModifiedDate,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SALE_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myConnection,"SALE_Delete",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myTransaction,"SALE_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_GetList");
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
			return mySql.ExecuteScalar(myConnection,"SALE_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"SALE_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			decimal ExchangeRate,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			DateTime DeliveryDate,
			string TruckNumber,
			string CarryingMeans,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			ExchangeRate,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			DeliveryDate,
			TruckNumber,
			CarryingMeans,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			decimal ExchangeRate,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			DateTime DeliveryDate,
			string TruckNumber,
			string CarryingMeans,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@ExchangeRate",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@DeliveryDate",
			"@TruckNumber",
			"@CarryingMeans",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+PaymentMethod+"%",
			"%"+InvReceived+"%",
			"%"+Series+"%",
			"%"+Number+"%",
			"%"+InvDate+"%",
			"%"+Barcode+"%",
			"%"+ExchangeRate+"%",
			"%"+CustomerName+"%",
			"%"+CustomerAddress+"%",
			"%"+CustomerTax+"%",
			"%"+ContactName+"%",
			"%"+DueDate+"%",
			"%"+ExpectedDate+"%",
			"%"+DiscountDate+"%",
			"%"+DiscountPercent+"%",
			"%"+DiscountTaken+"%",
			"%"+IsOutward+"%",
			"%"+IsReceived+"%",
			"%"+IsClosed+"%",
			"%"+Amount+"%",
			"%"+Payment+"%",
			"%"+VatAmount+"%",
			"%"+Discount+"%",
			"%"+OtherDiscount+"%",
			"%"+ShipCharge+"%",
			"%"+OtherCharge+"%",
			"%"+FAmount+"%",
			"%"+FPayment+"%",
			"%"+FVatAmount+"%",
			"%"+FDiscount+"%",
			"%"+FOtherDiscount+"%",
			"%"+FShipCharge+"%",
			"%"+FOtherCharge+"%",
			"%"+DeliveryDate+"%",
			"%"+TruckNumber+"%",
			"%"+CarryingMeans+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"SALE_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			DateTime RefDate,
			string RefOrgNo,
			int RefType,
			int RefStatus,
			string PaymentMethod,
			bool InvReceived,
			string Series,
			string Number,
			DateTime InvDate,
			string Barcode,
			decimal ExchangeRate,
			string CustomerName,
			string CustomerAddress,
			string CustomerTax,
			string ContactName,
			DateTime DueDate,
			DateTime ExpectedDate,
			DateTime DiscountDate,
			decimal DiscountPercent,
			decimal DiscountTaken,
			bool IsOutward,
			bool IsReceived,
			bool IsClosed,
			decimal Amount,
			decimal Payment,
			decimal VatAmount,
			decimal Discount,
			decimal OtherDiscount,
			decimal ShipCharge,
			decimal OtherCharge,
			decimal FAmount,
			decimal FPayment,
			decimal FVatAmount,
			decimal FDiscount,
			decimal FOtherDiscount,
			decimal FShipCharge,
			decimal FOtherCharge,
			DateTime DeliveryDate,
			string TruckNumber,
			string CarryingMeans,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@RefOrgNo",
			"@RefType",
			"@RefStatus",
			"@PaymentMethod",
			"@InvReceived",
			"@Series",
			"@Number",
			"@InvDate",
			"@Barcode",
			"@ExchangeRate",
			"@CustomerName",
			"@CustomerAddress",
			"@CustomerTax",
			"@ContactName",
			"@DueDate",
			"@ExpectedDate",
			"@DiscountDate",
			"@DiscountPercent",
			"@DiscountTaken",
			"@IsOutward",
			"@IsReceived",
			"@IsClosed",
			"@Amount",
			"@Payment",
			"@VatAmount",
			"@Discount",
			"@OtherDiscount",
			"@ShipCharge",
			"@OtherCharge",
			"@FAmount",
			"@FPayment",
			"@FVatAmount",
			"@FDiscount",
			"@FOtherDiscount",
			"@FShipCharge",
			"@FOtherCharge",
			"@DeliveryDate",
			"@TruckNumber",
			"@CarryingMeans",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+RefOrgNo+"%",
			"%"+RefType+"%",
			"%"+RefStatus+"%",
			"%"+PaymentMethod+"%",
			"%"+InvReceived+"%",
			"%"+Series+"%",
			"%"+Number+"%",
			"%"+InvDate+"%",
			"%"+Barcode+"%",
			"%"+ExchangeRate+"%",
			"%"+CustomerName+"%",
			"%"+CustomerAddress+"%",
			"%"+CustomerTax+"%",
			"%"+ContactName+"%",
			"%"+DueDate+"%",
			"%"+ExpectedDate+"%",
			"%"+DiscountDate+"%",
			"%"+DiscountPercent+"%",
			"%"+DiscountTaken+"%",
			"%"+IsOutward+"%",
			"%"+IsReceived+"%",
			"%"+IsClosed+"%",
			"%"+Amount+"%",
			"%"+Payment+"%",
			"%"+VatAmount+"%",
			"%"+Discount+"%",
			"%"+OtherDiscount+"%",
			"%"+ShipCharge+"%",
			"%"+OtherCharge+"%",
			"%"+FAmount+"%",
			"%"+FPayment+"%",
			"%"+FVatAmount+"%",
			"%"+FDiscount+"%",
			"%"+FOtherDiscount+"%",
			"%"+FShipCharge+"%",
			"%"+FOtherCharge+"%",
			"%"+DeliveryDate+"%",
			"%"+TruckNumber+"%",
			"%"+CarryingMeans+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"SALE_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("SALE_LookUp");
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

	public enum SALEFields
		{
			ID,
			RefID,
			RefDate,
			RefOrgNo,
			RefType,
			RefStatus,
			PaymentMethod,
			InvReceived,
			Series,
			Number,
			InvDate,
			Barcode,
			StockID,
			CurrencyID,
			ExchangeRate,
			BranchID,
			ContractID,
			CustomerID,
			CustomerName,
			CustomerAddress,
			CustomerTax,
			ContactName,
			ShipViaID,
			TermID,
			DueDate,
			ExpectedDate,
			DiscountDate,
			DiscountPercent,
			DiscountTaken,
			IsOutward,
			IsReceived,
			IsClosed,
			Amount,
			Payment,
			VatAmount,
			Discount,
			OtherDiscount,
			ShipCharge,
			OtherCharge,
			FAmount,
			FPayment,
			FVatAmount,
			FDiscount,
			FOtherDiscount,
			FShipCharge,
			FOtherCharge,
			SellerID,
			DeliverID,
			DeliveryDate,
			DriverID,
			TruckNumber,
			CarryingMeans,
			IsPublic,
			CreatedBy,
			CreatedDate,
			ModifiedBy,
			ModifiedDate,
			OwnerID,
			Description,
			Sorted,
			Active
		}

	#endregion

	#region Class Collection

	public class SALECollection : System.Collections.CollectionBase
		{
			[Description("Adds a new SALE to the collection.")]
			public int Add(SALE item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a SALE from the collection.")]
			public void Remove(SALE item)
				{
					List.Remove(item);
				}
			[Description("Inserts an SALE into the collection at the specified index..")]
			public void Inserts(int index,SALE item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(SALE item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the SALE class is present in the collection.")]
			public bool Contains(SALE item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
