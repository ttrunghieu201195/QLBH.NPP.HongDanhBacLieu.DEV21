using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using System.ComponentModel;
using DevExpress.XtraEditors;
using Perfect.Common;

namespace Perfect.Inventory.Core.Inventory.Adjustment.Class
{

	public class ADJUSTMENT:Object
	{
		#region Init

		private string m_ID;
		private DateTime m_RefDate;
		private string m_Ref_OrgNo;
		private int m_RefType;
		private string m_Employee_ID;
		private string m_Stock_ID;
		private decimal m_Amount;
		private bool m_Accept;
		private bool m_IsClose;
		private string m_Description;
		private string m_User_ID;
		private bool m_Active;
		
		
		public ADJUSTMENT()
		{			
			 m_ID="";
			 m_RefDate=DateTime.Now;
			 m_Ref_OrgNo="";
			 m_RefType=0;
			 m_Employee_ID="";
			 m_Stock_ID="";
			 m_Amount=0;
			 m_Accept=true;
			 m_IsClose=true;
			 m_Description="";
			 m_User_ID="";
			 m_Active=true;
		}

        public ADJUSTMENT
        (
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
            string Employee_ID,
            string Stock_ID, 
			decimal Amount,
			bool Accept,
			bool IsClose, 
			string Description,
            string User_ID,
			bool Active            
        )
		{
            m_ID = ID;
            m_RefDate = RefDate;
            m_Ref_OrgNo = Ref_OrgNo;
            m_RefType = RefType;
            m_Employee_ID = Employee_ID;
            m_Stock_ID = Stock_ID;
            m_Amount = Amount;
            m_Accept = Accept;
            m_IsClose = IsClose;
            m_Description = Description;
            m_User_ID = User_ID;
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
		[DisplayName("Employee_ID")]
		[Category("Column")]
		public string Employee_ID
		{
			get
			{
				return m_Employee_ID;
			}
			set
			{
				m_Employee_ID = value;
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
		[DisplayName("Accept")]
		[Category("Column")]
		public bool Accept
		{
			get
			{
				return m_Accept;
			}
			set
			{
				m_Accept = value;
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

	    #endregion

        #region NewID

        public string NewID()
        {
            return NewID("");
        }

        public string NewID(string key)
        {
            return SqlHelper.GenCode("ADJUSTMENT", "ID", key);
        }

        public string NewID(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, "ADJUSTMENT", "D", key);
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
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"ADJUSTMENT_Get",myPara,myValue);
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

	    #endregion NewID


        #region Get

        public bool Get()
        {
            return Get( m_ID);
        }

        public bool Get(SqlConnection myConnection)
        {
            return Get(myConnection, m_ID);
        }

        public bool Get(SqlTransaction myTransaction)
        {
            return Get( myTransaction, m_ID);
        }

        public bool Get( string ID)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (Get( mySql.Connection, ID))
            {
                mySql.Close();
                return true;
            };
            return false;
        }

        public bool Get( SqlConnection myConnection, string ID)
        {
            bool Result = false;
            string[] myPara ={ "@ID"};
            object[] myValue ={ ID};
            SqlHelper mySql = new SqlHelper();

            mySql.CommandType = System.Data.CommandType.Text;
            string sql = @"SELECT * FROM ADJUSTMENT WHERE ID = @ID";
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, sql, myPara, myValue);

            if (myReader != null)
            {
                while (myReader.Read())
                { 
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						 	m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] ); 
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
 
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

        public bool Get( SqlTransaction myTransaction, string ID)
        {
            bool Result = false;
            string[] myPara ={ "@ID"};
            object[] myValue ={ ID};
            SqlHelper mySql = new SqlHelper();


            mySql.CommandType = System.Data.CommandType.Text;
            string sql = @"SELECT * FROM ADJUSTMENT WHERE ID = @ID";
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, sql, myPara, myValue);
 
            if (myReader != null)
            {
                while (myReader.Read())
                { 
						m_ID =Convert.ToString(myReader["ID"]==DBNull.Value?"":myReader["ID"] );
						m_RefDate =Convert.ToDateTime(myReader["RefDate"]==DBNull.Value?DateTime.Now:myReader["RefDate"] );
						m_Ref_OrgNo =Convert.ToString(myReader["Ref_OrgNo"]==DBNull.Value?"":myReader["Ref_OrgNo"] );
						m_RefType =Convert.ToInt32(myReader["RefType"]==DBNull.Value?0:myReader["RefType"] );
						m_Amount =Convert.ToDecimal(myReader["Amount"]==DBNull.Value?0:myReader["Amount"] );
						 
						m_User_ID =Convert.ToString(myReader["User_ID"]==DBNull.Value?"":myReader["User_ID"] );
						m_IsClose =Convert.ToBoolean(myReader["IsClose"]==DBNull.Value?true:myReader["IsClose"] );
						m_Description =Convert.ToString(myReader["Description"]==DBNull.Value?"":myReader["Description"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
 
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

        public bool Insert(SqlTransaction myTransaction)
        {
            return Insert(
            myTransaction,
            m_ID,
            m_RefDate,
            m_Ref_OrgNo,
            m_RefType,
            m_Employee_ID,
            m_Stock_ID,
             
            m_Amount,
            m_Accept,
            m_IsClose,
            m_Description,

            m_User_ID, 
            m_Active);
        }

	    public bool Insert
        (
			SqlTransaction myTransaction,
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string Employee_ID,
			string Stock_ID,
			decimal Amount,
			bool Accept,
			bool IsClose,
			string Description,
			string User_ID,
			bool Active
        )
		{
			string[] myPara={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@Employee_ID",
			"@Stock_ID",
			"@Amount",
			"@Accept",
			"@IsClose",
			"@Description",
			"@User_ID",
			"@Active"};
			object[] myValue={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			Employee_ID,
			Stock_ID,
			Amount,
			Accept,
			IsClose,
			Description,
			User_ID,
			Active};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"ADJUSTMENT_Insert",myPara,myValue)=="OK"?true:false;
		}


        public bool Update(SqlTransaction myTransaction)
        {
            return Update(
            myTransaction,
            m_ID,
            m_RefDate,
            m_Ref_OrgNo,
            m_RefType,
            m_Employee_ID,
            m_Stock_ID,

            m_Amount,
            m_Accept,
            m_IsClose,
            m_Description,

            m_User_ID,
            m_Active);
        }

        public bool Update
        ( 
            SqlTransaction myTransaction,
			string ID,
			DateTime RefDate,
			string Ref_OrgNo,
			int RefType,
			string Employee_ID,
			string Stock_ID,
			decimal Amount,
			bool Accept,
			bool IsClose,
			string Description,
			string User_ID,
			bool Active
        )
        {
            string[] myPara ={
			"@ID",
			"@RefDate",
			"@Ref_OrgNo",
			"@RefType",
			"@Employee_ID",
			"@Stock_ID",
			"@Amount",
			"@Accept",
			"@IsClose",
			"@Description",
			"@User_ID",
			"@Active"};
            object[] myValue ={
			ID,
			RefDate,
			Ref_OrgNo,
			RefType,
			Employee_ID,
			Stock_ID,
			Amount,
			Accept,
			IsClose,
			Description,
			User_ID,
			Active};
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "ADJUSTMENT_Update", myPara, myValue) == "OK" ? true : false;
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
			return mySql.ExecuteNonQuery(myTransaction,"ADJUSTMENT_Delete",myPara,myValue)=="OK"?true:false;
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
