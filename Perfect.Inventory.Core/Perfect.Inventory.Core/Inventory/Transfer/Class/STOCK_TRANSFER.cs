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
	public class STOCK_TRANSFER:Object
	{
		#region Init
		private string m_ID;
		private DateTime m_RefDate;
		private string m_Ref_OrgNo;
		private int m_RefType;
		private string m_FromStock_ID;
		private string m_Sender_ID;
		private string m_ToStock_ID;
		private string m_Receiver_ID;
		private string m_Barcode;
		private decimal m_Amount;
		private bool m_IsReview;
		private string m_User_ID;
		private bool m_IsClose;
		private long m_Sorted;
		private string m_Description;
		private bool m_Active;
		
		
		public STOCK_TRANSFER()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID="";
			 m_RefDate=DateTime.Now;
			 m_Ref_OrgNo="";
			 m_RefType=0;
			 m_FromStock_ID="";
			 m_Sender_ID="";
			 m_ToStock_ID="";
			 m_Receiver_ID="";
			 m_Barcode="";
			 m_Amount=0;
			 m_IsReview=true;
			 m_User_ID="";
			 m_IsClose=true;
			 m_Sorted=0;
			 m_Description="";
			 m_Active=true;
		}
		public STOCK_TRANSFER(
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_RefDate=RefDate;
			 m_Ref_OrgNo=Ref_OrgNo;
			 m_RefType=RefType;
			 m_FromStock_ID=FromStock_ID;
			 m_Sender_ID=Sender_ID;
			 m_ToStock_ID=ToStock_ID;
			 m_Receiver_ID=Receiver_ID;
			 m_Barcode=Barcode;
			 m_Amount=Amount;
			 m_IsReview=IsReview;
			 m_User_ID=User_ID;
			 m_IsClose=IsClose;
			 m_Sorted=Sorted;
			 m_Description=Description;
			 m_Active=Active;
		}
		
		
		public void SetData(
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ID=ID;
			 m_RefDate=RefDate;
			 m_Ref_OrgNo=Ref_OrgNo;
			 m_RefType=RefType;
			 m_FromStock_ID=FromStock_ID;
			 m_Sender_ID=Sender_ID;
			 m_ToStock_ID=ToStock_ID;
			 m_Receiver_ID=Receiver_ID;
			 m_Barcode=Barcode;
			 m_Amount=Amount;
			 m_IsReview=IsReview;
			 m_User_ID=User_ID;
			 m_IsClose=IsClose;
			 m_Sorted=Sorted;
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
		[DisplayName("Ref_OrgNo")]
		[Category("Column")]
		public string Ref_OrgNo
		{
			get
			{
				return m_Ref_OrgNo;
			}
			set
			{
				m_Ref_OrgNo = value;
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
		[DisplayName("FromStock_ID")]
		[Category("Column")]
		public string FromStock_ID
		{
			get
			{
				return m_FromStock_ID;
			}
			set
			{
				m_FromStock_ID = value;
			}
		}
		[DisplayName("Sender_ID")]
		[Category("Column")]
		public string Sender_ID
		{
			get
			{
				return m_Sender_ID;
			}
			set
			{
				m_Sender_ID = value;
			}
		}
		[DisplayName("ToStock_ID")]
		[Category("Column")]
		public string ToStock_ID
		{
			get
			{
				return m_ToStock_ID;
			}
			set
			{
				m_ToStock_ID = value;
			}
		}
		[DisplayName("Receiver_ID")]
		[Category("Column")]
		public string Receiver_ID
		{
			get
			{
				return m_Receiver_ID;
			}
			set
			{
				m_Receiver_ID = value;
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
		[DisplayName("IsReview")]
		[Category("Column")]
		public bool IsReview
		{
			get
			{
				return m_IsReview;
			}
			set
			{
				m_IsReview = value;
			}
		}
		[DisplayName("User_ID")]
		[Category("Column")]
		public string User_ID
		{
			get
			{
				return m_User_ID;
			}
			set
			{
				m_User_ID = value;
			}
		}
		[DisplayName("IsClose")]
		[Category("Column")]
		public bool IsClose
		{
			get
			{
				return m_IsClose;
			}
			set
			{
				m_IsClose = value;
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
				return "Class STOCK_TRANSFER";
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
			return SqlHelper.GenCode("STOCK_TRANSFER","ID",key);
		}

		public string NewID(SqlTransaction myTransaction, string key)
		{
			return SqlHelper.GenCode(myTransaction,"STOCK_TRANSFER","D",key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_TRANSFER_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_TRANSFER_Get",myPara,myValue);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"STOCK_TRANSFER_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]);
						m_RefType =Convert.ToInt32(myReader["RefType"]);
						m_FromStock_ID =Convert.ToString(myReader["FromStock_ID"]);
						m_Sender_ID =Convert.ToString(myReader["Sender_ID"]);
						m_ToStock_ID =Convert.ToString(myReader["ToStock_ID"]);
						m_Receiver_ID =Convert.ToString(myReader["Receiver_ID"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_IsReview =Convert.ToBoolean(myReader["IsReview"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_FromStock_ID =Convert.ToString(myReader["FromStock_ID"]==DBNull.Value?"":myReader["FromStock_ID"] );
						m_Sender_ID =Convert.ToString(myReader["Sender_ID"]==DBNull.Value?"":myReader["Sender_ID"] );
						m_ToStock_ID =Convert.ToString(myReader["ToStock_ID"]==DBNull.Value?"":myReader["ToStock_ID"] );
						m_Receiver_ID =Convert.ToString(myReader["Receiver_ID"]==DBNull.Value?"":myReader["Receiver_ID"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_IsReview =Convert.ToBoolean(myReader["IsReview"]==DBNull.Value?true:myReader["IsReview"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"STOCK_TRANSFER_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_ID =Convert.ToString(myReader["ID"]);
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]);
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]);
						m_RefType =Convert.ToInt32(myReader["RefType"]);
						m_FromStock_ID =Convert.ToString(myReader["FromStock_ID"]);
						m_Sender_ID =Convert.ToString(myReader["Sender_ID"]);
						m_ToStock_ID =Convert.ToString(myReader["ToStock_ID"]);
						m_Receiver_ID =Convert.ToString(myReader["Receiver_ID"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Amount =Convert.ToDecimal(myReader["Amount"]);
						m_IsReview =Convert.ToBoolean(myReader["IsReview"]);
						m_User_ID =Convert.ToString(myReader["User_ID"]);
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]);
						m_Sorted =Convert.ToInt64(myReader["Sorted"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_FromStock_ID =Convert.ToString(myReader["FromStock_ID"]==DBNull.Value?"":myReader["FromStock_ID"] );
						m_Sender_ID =Convert.ToString(myReader["Sender_ID"]==DBNull.Value?"":myReader["Sender_ID"] );
						m_ToStock_ID =Convert.ToString(myReader["ToStock_ID"]==DBNull.Value?"":myReader["ToStock_ID"] );
						m_Receiver_ID =Convert.ToString(myReader["Receiver_ID"]==DBNull.Value?"":myReader["Receiver_ID"] );
						m_Barcode =Convert.ToString(myReader["Barcode"]==DBNull.Value?"":myReader["Barcode"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						m_IsReview =Convert.ToBoolean(myReader["IsReview"]==DBNull.Value?true:myReader["IsReview"] );
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Sorted =Convert.ToInt64(myReader["Sorted"]==DBNull.Value?0:myReader["Sorted"] );
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
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_Active);
		}
		
        public bool Insert( SqlTransaction myTransaction)
		{
			return Insert(
			myTransaction,
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_Active);
		}

		public bool Insert(SqlConnection myConnection)
		{

			return Insert(
			myConnection,
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_Active);
		}
		public bool Insert(
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if (Insert(
			mySql.Connection,
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Sorted,
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
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@FromStock_ID",
			"@Sender_ID",
			"@ToStock_ID",
			"@Receiver_ID",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@User_ID",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Sorted,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_Insert",myPara,myValue)=="OK"?true:false;
		}
		public bool Insert(
			SqlTransaction myTransaction,
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@FromStock_ID",
			"@Sender_ID",
			"@ToStock_ID",
			"@Receiver_ID",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@User_ID",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Sorted,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_Insert",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region Update
		public bool Update()
		{
			return Update(
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_Active);
		}
		public bool Update(
			SqlConnection myConnection)
		{
			return Update(
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_Active);
		}
		public bool Update(SqlTransaction myTransaction)
		{
			return Update(
			myTransaction,
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Sorted,
			m_Description,
			m_Active);
		}

		public bool Update(
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
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
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Sorted,
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
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@FromStock_ID",
			"@Sender_ID",
			"@ToStock_ID",
			"@Receiver_ID",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@User_ID",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Sorted,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_Update",myPara,myValue)=="OK"?true:false;
		}

		public bool Update(
			SqlTransaction myTransaction,
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			long Sorted,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@FromStock_ID",
			"@Sender_ID",
			"@ToStock_ID",
			"@Receiver_ID",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@User_ID",
			"@IsClose",
			"@Sorted",
			"@Description",
			"@Active"};
			object[] myValue={ID,RefDate,Ref_OrgNo,RefType,FromStock_ID,Sender_ID,ToStock_ID,Receiver_ID,Barcode,Amount,IsReview,User_ID,IsClose,Sorted,Description,Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_Update",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		

		#region UpdateByID
		public bool UpdateByID()
		{
			return UpdateByID(
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlConnection myConnection)
		{
			return UpdateByID(
			myConnection,
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			SqlTransaction myTransaction)
		{
			return UpdateByID(
			myTransaction,
			m_ID,
			m_RefDate,
			m_Ref_OrgNo,
			m_RefType,
			m_FromStock_ID,
			m_Sender_ID,
			m_ToStock_ID,
			m_Receiver_ID,
			m_Barcode,
			m_Amount,
			m_IsReview,
			m_User_ID,
			m_IsClose,
			m_Description,
			m_Active);
		}
		public bool UpdateByID(
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			string Description,
			bool Active)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return false;
			if(UpdateByID(mySql.Connection,
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
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
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@FromStock_ID",
			"@Sender_ID",
			"@ToStock_ID",
			"@Receiver_ID",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@User_ID",
			"@IsClose",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_UpdateByID",myPara,myValue)=="OK"?true:false;
		}
		public bool UpdateByID(
			SqlTransaction myTransaction,
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string FromStock_ID,
			string Sender_ID,
			string ToStock_ID,
			string Receiver_ID,
			string Barcode,
			decimal Amount,
			bool IsReview,
			string User_ID,
			bool IsClose,
			string Description,
			bool Active)
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@FromStock_ID",
			"@Sender_ID",
			"@ToStock_ID",
			"@Receiver_ID",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@User_ID",
			"@IsClose",
			"@Description",
			"@Active"};
			object[] myValue={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Description,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_UpdateByID",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myConnection,"STOCK_TRANSFER_Delete",myPara,myValue)=="OK"?true:false;
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
			return mySql.ExecuteNonQuery(myTransaction,"STOCK_TRANSFER_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion

		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("STOCK_TRANSFER_GetList");
		}
		#endregion
		

		#region GetList Connection
		
		public DataTable GetList(SqlConnection myConnection)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"STOCK_TRANSFER_GetList");
		}
		#endregion
		

		#region GetList Transaction
		
		public DataTable GetList(SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"STOCK_TRANSFER_GetList");
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
			return mySql.ExecuteScalar(myConnection,"STOCK_TRANSFER_Count",0);
		}

		public int Count(
			SqlTransaction myTransaction)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteScalar(myTransaction,"STOCK_TRANSFER_Count",0);
		}

		#endregion Count

		#region Search
		
		public DataTable Search(
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string Barcode,
			decimal Amount,
			bool IsReview,
			bool IsClose,
			string Description)
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			if (mySql.Open()!="OK") return null;
			return Search(
			mySql.Connection,
			RefDate,
			Ref_OrgNo,
			RefType,
			Barcode,
			Amount,
			IsReview,
			IsClose,
			Description);
			return null;
		}
		#endregion
		

		#region Search Connection
		
		public DataTable Search(
			SqlConnection myConnection,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string Barcode,
			decimal Amount,
			bool IsReview,
			bool IsClose,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@IsClose",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+Ref_OrgNo+"%",
			"%"+RefType+"%",
			"%"+Barcode+"%",
			"%"+Amount+"%",
			"%"+IsReview+"%",
			"%"+IsClose+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myConnection,"STOCK_TRANSFER_Search",myPara,myValue);
		}
		#endregion
		

		#region Search Transaction
		
		public DataTable Search(
			SqlTransaction myTransaction,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string Barcode,
			decimal Amount,
			bool IsReview,
			bool IsClose,
			string Description)
		{
			string[] myPara={
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@Barcode",
			"@Amount",
			"@IsReview",
			"@IsClose",
			"@Description"};
			object[] myValue={
			"%"+RefDate+"%",
			"%"+Ref_OrgNo+"%",
			"%"+RefType+"%",
			"%"+Barcode+"%",
			"%"+Amount+"%",
			"%"+IsReview+"%",
			"%"+IsClose+"%",
			"%"+Description+"%"};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable(myTransaction,"STOCK_TRANSFER_Search",myPara,myValue);
		}
		#endregion
		

		#region Insert Combo
		#region LookUp
		
		public DataTable LookUp()
		{
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteDataTable("STOCK_TRANSFER_LookUp");
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

	public enum STOCK_TRANSFERFields
		{
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			FromStock_ID,
			Sender_ID,
			ToStock_ID,
			Receiver_ID,
			Barcode,
			Amount,
			IsReview,
			User_ID,
			IsClose,
			Sorted,
			Description,
			Active
		}

	#endregion

	#region Class Collection

	public class STOCK_TRANSFERCollection : System.Collections.CollectionBase
		{
			[Description("Adds a new STOCK_TRANSFER to the collection.")]
			public int Add(STOCK_TRANSFER item)
				{
					int newindex = List.Add(item);
					return newindex;
				}
			[Description("Removes a STOCK_TRANSFER from the collection.")]
			public void Remove(STOCK_TRANSFER item)
				{
					List.Remove(item);
				}
			[Description("Inserts an STOCK_TRANSFER into the collection at the specified index..")]
			public void Inserts(int index,STOCK_TRANSFER item)
				{
					List.Insert(index,item);
				}
			[Description("Returns the index value of the BRANCH class in the collection.")]
			public int IndexOf(STOCK_TRANSFER item)
				{
					return List.IndexOf(item);
				}
			[Description("Returns true if the STOCK_TRANSFER class is present in the collection.")]
			public bool Contains(STOCK_TRANSFER item)
				{
					return List.Contains(item);
				}
		}
	#endregion

}
