using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{

	public class CUSTOMER
	{
		#region Init
		private string m_Customer_ID;
		private long m_OrderID;
		private string m_CustomerName;
		private string m_Customer_Type_ID;
		private string m_Customer_Group_ID;
		private string m_CustomerAddress;
		private string m_Birthday;
		private string m_Barcode;
		private string m_Tax;
		private string m_Tel;
		private string m_Fax;
		private string m_Email;
		private string m_Mobile;
		private string m_Website;
		private string m_Contact;
		private string m_Position;
		private string m_NickYM;
		private string m_NickSky;
		private string m_Area;
		private string m_District;
		private string m_Contry;
		private string m_City;
		private string m_BankAccount;
		private string m_BankName;
		private double m_CreditLimit;
		private double m_Discount;
        private bool m_IsDebt;
		private string m_Description;
		private bool m_Active;

		public CUSTOMER()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Customer_ID="";
			 m_OrderID=0;
			 m_CustomerName="";
			 m_Customer_Type_ID="";
			 m_Customer_Group_ID="";
			 m_CustomerAddress="";
			 m_Birthday="";
			 m_Barcode="";
			 m_Tax="";
			 m_Tel="";
			 m_Fax="";
			 m_Email="";
			 m_Mobile="";
			 m_Website="";
			 m_Contact="";
			 m_Position="";
			 m_NickYM="";
			 m_NickSky="";
			 m_Area="";
			 m_District="";
			 m_Contry="";
			 m_City="";
			 m_BankAccount="";
			 m_BankName="";
			 m_CreditLimit=0.0;
			 m_Discount=0.0;
             m_IsDebt = true;
			 m_Description="";
			 m_Active=true;
		}

		public CUSTOMER(string Customer_ID,long OrderID,string CustomerName,
            string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,
            string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,
            string Contact,string Position,string NickYM,string NickSky,string Area,string District,
            string Contry,string City,string BankAccount,string BankName,double CreditLimit,
            double Discount,bool IsDebt, string Description,bool Active)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_Customer_ID=Customer_ID;
			 m_OrderID=OrderID;
			 m_CustomerName=CustomerName;
			 m_Customer_Type_ID=Customer_Type_ID;
			 m_Customer_Group_ID=Customer_Group_ID;
			 m_CustomerAddress=CustomerAddress;
			 m_Birthday=Birthday;
			 m_Barcode=Barcode;
			 m_Tax=Tax;
			 m_Tel=Tel;
			 m_Fax=Fax;
			 m_Email=Email;
			 m_Mobile=Mobile;
			 m_Website=Website;
			 m_Contact=Contact;
			 m_Position=Position;
			 m_NickYM=NickYM;
			 m_NickSky=NickSky;
			 m_Area=Area;
			 m_District=District;
			 m_Contry=Contry;
			 m_City=City;
			 m_BankAccount=BankAccount;
			 m_BankName=BankName;
			 m_CreditLimit=CreditLimit;
			 m_Discount=Discount;
             m_IsDebt = IsDebt;
			 m_Description=Description;
			 m_Active=Active;
		}
		#endregion
		
		#region Property
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
		public long OrderID
		{
			get
			{
				return m_OrderID;
			}
			set
			{
				m_OrderID = value;
			}
		}
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
		public string Customer_Type_ID
		{
			get
			{
				return m_Customer_Type_ID;
			}
			set
			{
				m_Customer_Type_ID = value;
			}
		}
		public string Customer_Group_ID
		{
			get
			{
				return m_Customer_Group_ID;
			}
			set
			{
				m_Customer_Group_ID = value;
			}
		}
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
		public string Birthday
		{
			get
			{
				return m_Birthday;
			}
			set
			{
				m_Birthday = value;
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
		public string Tax
		{
			get
			{
				return m_Tax;
			}
			set
			{
				m_Tax = value;
			}
		}
		public string Tel
		{
			get
			{
				return m_Tel;
			}
			set
			{
				m_Tel = value;
			}
		}
		public string Fax
		{
			get
			{
				return m_Fax;
			}
			set
			{
				m_Fax = value;
			}
		}
		public string Email
		{
			get
			{
				return m_Email;
			}
			set
			{
				m_Email = value;
			}
		}
		public string Mobile
		{
			get
			{
				return m_Mobile;
			}
			set
			{
				m_Mobile = value;
			}
		}
		public string Website
		{
			get
			{
				return m_Website;
			}
			set
			{
				m_Website = value;
			}
		}
		public string Contact
		{
			get
			{
				return m_Contact;
			}
			set
			{
				m_Contact = value;
			}
		}
		public string Position
		{
			get
			{
				return m_Position;
			}
			set
			{
				m_Position = value;
			}
		}
		public string NickYM
		{
			get
			{
				return m_NickYM;
			}
			set
			{
				m_NickYM = value;
			}
		}
		public string NickSky
		{
			get
			{
				return m_NickSky;
			}
			set
			{
				m_NickSky = value;
			}
		}
		public string Area
		{
			get
			{
				return m_Area;
			}
			set
			{
				m_Area = value;
			}
		}
		public string District
		{
			get
			{
				return m_District;
			}
			set
			{
				m_District = value;
			}
		}
		public string Contry
		{
			get
			{
				return m_Contry;
			}
			set
			{
				m_Contry = value;
			}
		}
		public string City
		{
			get
			{
				return m_City;
			}
			set
			{
				m_City = value;
			}
		}
		public string BankAccount
		{
			get
			{
				return m_BankAccount;
			}
			set
			{
				m_BankAccount = value;
			}
		}
		public string BankName
		{
			get
			{
				return m_BankName;
			}
			set
			{
				m_BankName = value;
			}
		}
		public double CreditLimit
		{
			get
			{
				return m_CreditLimit;
			}
			set
			{
				m_CreditLimit = value;
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
        public bool IsDebt
        {
            get
            {
                return m_IsDebt;
            }
            set
            {
                m_IsDebt = value;
            }
        }
		public string ProductName
		{
			get
			{
				return "Class CUSTOMER";
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
            return SqlHelper.GenCode("CUSTOMER", "Customer_ID", "KH");
		}

		public Boolean Exist(string Customer_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("CUSTOMER_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

        public Boolean Exist(SqlTransaction myTransaction,string Customer_ID)
        {
            Boolean Result = false;
            string[] myPara = { "@Customer_ID" };
            object[] myValue = { Customer_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction,"CUSTOMER_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            return Result;
        }



		public string Get(string Customer_ID)
		{
			string Result="";
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("CUSTOMER_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_OrderID =Convert.ToInt64(myReader["OrderID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_Customer_Type_ID =Convert.ToString(myReader["Customer_Type_ID"]);
						m_Customer_Group_ID =Convert.ToString(myReader["Customer_Group_ID"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_Birthday =Convert.ToString(myReader["Birthday"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Tax =Convert.ToString(myReader["Tax"]);
						m_Tel =Convert.ToString(myReader["Tel"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Mobile =Convert.ToString(myReader["Mobile"]);
						m_Website =Convert.ToString(myReader["Website"]);
						m_Contact =Convert.ToString(myReader["Contact"]);
						m_Position =Convert.ToString(myReader["Position"]);
						m_NickYM =Convert.ToString(myReader["NickYM"]);
						m_NickSky =Convert.ToString(myReader["NickSky"]);
						m_Area =Convert.ToString(myReader["Area"]);
						m_District =Convert.ToString(myReader["District"]);
						m_Contry =Convert.ToString(myReader["Contry"]);
						m_City =Convert.ToString(myReader["City"]);
						m_BankAccount =Convert.ToString(myReader["BankAccount"]);
						m_BankName =Convert.ToString(myReader["BankName"]);
						m_CreditLimit =Convert.ToSingle(myReader["CreditLimit"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);

                        m_IsDebt = Convert.ToBoolean(myReader["IsDebt"] == DBNull.Value ? false : myReader["IsDebt"]);

						m_Description =Convert.ToString(myReader["Description"]);

						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public string Get(SqlConnection myConnection,string Customer_ID)
		{
			string Result="";
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"CUSTOMER_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_OrderID =Convert.ToInt64(myReader["OrderID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_Customer_Type_ID =Convert.ToString(myReader["Customer_Type_ID"]);
						m_Customer_Group_ID =Convert.ToString(myReader["Customer_Group_ID"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_Birthday =Convert.ToString(myReader["Birthday"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Tax =Convert.ToString(myReader["Tax"]);
						m_Tel =Convert.ToString(myReader["Tel"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Mobile =Convert.ToString(myReader["Mobile"]);
						m_Website =Convert.ToString(myReader["Website"]);
						m_Contact =Convert.ToString(myReader["Contact"]);
						m_Position =Convert.ToString(myReader["Position"]);
						m_NickYM =Convert.ToString(myReader["NickYM"]);
						m_NickSky =Convert.ToString(myReader["NickSky"]);
						m_Area =Convert.ToString(myReader["Area"]);
						m_District =Convert.ToString(myReader["District"]);
						m_Contry =Convert.ToString(myReader["Contry"]);
						m_City =Convert.ToString(myReader["City"]);
						m_BankAccount =Convert.ToString(myReader["BankAccount"]);
						m_BankName =Convert.ToString(myReader["BankName"]);
						m_CreditLimit =Convert.ToSingle(myReader["CreditLimit"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
                        m_IsDebt = Convert.ToBoolean(myReader["IsDebt"] == DBNull.Value ? false : myReader["IsDebt"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public string Get(SqlTransaction myTransaction,string Customer_ID)
		{
			string Result="";
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"CUSTOMER_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_Customer_ID =Convert.ToString(myReader["Customer_ID"]);
						m_OrderID =Convert.ToInt64(myReader["OrderID"]);
						m_CustomerName =Convert.ToString(myReader["CustomerName"]);
						m_Customer_Type_ID =Convert.ToString(myReader["Customer_Type_ID"]);
						m_Customer_Group_ID =Convert.ToString(myReader["Customer_Group_ID"]);
						m_CustomerAddress =Convert.ToString(myReader["CustomerAddress"]);
						m_Birthday =Convert.ToString(myReader["Birthday"]);
						m_Barcode =Convert.ToString(myReader["Barcode"]);
						m_Tax =Convert.ToString(myReader["Tax"]);
						m_Tel =Convert.ToString(myReader["Tel"]);
						m_Fax =Convert.ToString(myReader["Fax"]);
						m_Email =Convert.ToString(myReader["Email"]);
						m_Mobile =Convert.ToString(myReader["Mobile"]);
						m_Website =Convert.ToString(myReader["Website"]);
						m_Contact =Convert.ToString(myReader["Contact"]);
						m_Position =Convert.ToString(myReader["Position"]);
						m_NickYM =Convert.ToString(myReader["NickYM"]);
						m_NickSky =Convert.ToString(myReader["NickSky"]);
						m_Area =Convert.ToString(myReader["Area"]);
						m_District =Convert.ToString(myReader["District"]);
						m_Contry =Convert.ToString(myReader["Contry"]);
						m_City =Convert.ToString(myReader["City"]);
						m_BankAccount =Convert.ToString(myReader["BankAccount"]);
						m_BankName =Convert.ToString(myReader["BankName"]);
						m_CreditLimit =Convert.ToSingle(myReader["CreditLimit"]);
						m_Discount =Convert.ToSingle(myReader["Discount"]);
                        m_IsDebt = Convert.ToBoolean(myReader["IsDebt"] == DBNull.Value ? false : myReader["IsDebt"]);
						m_Description =Convert.ToString(myReader["Description"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		#endregion

        public Boolean ExistByName(SqlTransaction myTransaction, string customerName)
        {
            Boolean result = false;
            string[] myPara = { "@CustomerName" };
            object[] myValue = { customerName };
            var mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CUSTOMER_GetByName", myPara, myValue);
            if (myReader != null)
            {
                result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();

            return result;
        }
        public Boolean ExistByName(string CustomerName)
        {
            Boolean Result = false;
            string[] myPara = { "@CustomerName" };
            object[] myValue = { CustomerName };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CUSTOMER_GetByName", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                myReader.Dispose();
            }
            mySql.Close();

            return Result;
        }

        public string GetByName(SqlTransaction myTransaction, string CustomerName)
        {
            string Result = "";
            string[] myPara = { "@CustomerName" };
            object[] myValue = { CustomerName };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "CUSTOMER_GetByName", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Customer_ID = Convert.ToString(myReader["Customer_ID"]);
                    m_OrderID = Convert.ToInt64(myReader["OrderID"]);
                    m_CustomerName = Convert.ToString(myReader["CustomerName"]);
                    m_Customer_Type_ID = Convert.ToString(myReader["Customer_Type_ID"]);
                    m_Customer_Group_ID = Convert.ToString(myReader["Customer_Group_ID"]);
                    m_CustomerAddress = Convert.ToString(myReader["CustomerAddress"]);
                    m_Birthday = Convert.ToString(myReader["Birthday"]);
                    m_Barcode = Convert.ToString(myReader["Barcode"]);
                    m_Tax = Convert.ToString(myReader["Tax"]);
                    m_Tel = Convert.ToString(myReader["Tel"]);
                    m_Fax = Convert.ToString(myReader["Fax"]);
                    m_Email = Convert.ToString(myReader["Email"]);
                    m_Mobile = Convert.ToString(myReader["Mobile"]);
                    m_Website = Convert.ToString(myReader["Website"]);
                    m_Contact = Convert.ToString(myReader["Contact"]);
                    m_Position = Convert.ToString(myReader["Position"]);
                    m_NickYM = Convert.ToString(myReader["NickYM"]);
                    m_NickSky = Convert.ToString(myReader["NickSky"]);
                    m_Area = Convert.ToString(myReader["Area"]);
                    m_District = Convert.ToString(myReader["District"]);
                    m_Contry = Convert.ToString(myReader["Contry"]);
                    m_City = Convert.ToString(myReader["City"]);
                    m_BankAccount = Convert.ToString(myReader["BankAccount"]);
                    m_BankName = Convert.ToString(myReader["BankName"]);
                    m_CreditLimit = Convert.ToSingle(myReader["CreditLimit"]);
                    m_Discount = Convert.ToSingle(myReader["Discount"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                myReader.Dispose();
                //  mySql.Close();
                // myReader = null;
            }
            return Result;
        }






		#region Add

        #region sqlInsert
        string sqlInsert = @"INSERT INTO [CUSTOMER]
	  (
	    Customer_ID,
	    OrderID,
	    CustomerName,
	    Customer_Type_ID,
	    Customer_Group_ID,
	    CustomerAddress,
	    Birthday,
	    Barcode,
	    Tax,
	    Tel,
	    Fax,
	    Email,
	    Mobile,
	    Website,
	    Contact,
	    Position,
	    NickYM,
	    NickSky,
	    Area,
	    District,
	    Contry,
	    City,
	    BankAccount,
	    BankName,
	    CreditLimit,
	    Discount,
	    IsDebt,
	    Description,
	    Active
	  )
	VALUES
	  (
	    @Customer_ID,
	    @OrderID,
	    @CustomerName,
	    @Customer_Type_ID,
	    @Customer_Group_ID,
	    @CustomerAddress,
	    @Birthday,
	    @Barcode,
	    @Tax,
	    @Tel,
	    @Fax,
	    @Email,
	    @Mobile,
	    @Website,
	    @Contact,
	    @Position,
	    @NickYM,
	    @NickSky,
	    @Area,
	    @District,
	    @Contry,
	    @City,
	    @BankAccount,
	    @BankName,
	    @CreditLimit,
	    @Discount,
	    @IsDebt,
	    @Description,
	    @Active
	  )";
        #endregion

        public string Insert()
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@IsDebt","@Description","@Active"};
			object[] myValue={m_Customer_ID,m_OrderID,m_CustomerName,m_Customer_Type_ID,m_Customer_Group_ID,m_CustomerAddress,m_Birthday,m_Barcode,m_Tax,m_Tel,m_Fax,m_Email,m_Mobile,m_Website,m_Contact,m_Position,m_NickYM,m_NickSky,m_Area,m_District,m_Contry,m_City,m_BankAccount,m_BankName,m_CreditLimit,m_Discount,m_IsDebt,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            //return mySql.ExecuteNonQuery("CUSTOMER_Insert", myPara, myValue);
			return mySql.ExecuteNonQuery(sqlInsert,myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={m_Customer_ID,m_OrderID,m_CustomerName,m_Customer_Type_ID,m_Customer_Group_ID,m_CustomerAddress,m_Birthday,m_Barcode,m_Tax,m_Tel,m_Fax,m_Email,m_Mobile,m_Website,m_Contact,m_Position,m_NickYM,m_NickSky,m_Area,m_District,m_Contry,m_City,m_BankAccount,m_BankName,m_CreditLimit,m_Discount,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_Insert",myPara,myValue);
		}
		public string Insert(string Customer_ID,long OrderID,string CustomerName,string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,string Contact,string Position,string NickYM,string NickSky,string Area,string District,string Contry,string City,string BankAccount,string BankName,double CreditLimit,double Discount,string Description,bool Active)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={Customer_ID,OrderID,CustomerName,Customer_Type_ID,Customer_Group_ID,CustomerAddress,Birthday,Barcode,Tax,Tel,Fax,Email,Mobile,Website,Contact,Position,NickYM,NickSky,Area,District,Contry,City,BankAccount,BankName,CreditLimit,Discount,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string Customer_ID,long OrderID,string CustomerName,string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,string Contact,string Position,string NickYM,string NickSky,string Area,string District,string Contry,string City,string BankAccount,string BankName,double CreditLimit,double Discount,string Description,bool Active)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={Customer_ID,OrderID,CustomerName,Customer_Type_ID,Customer_Group_ID,CustomerAddress,Birthday,Barcode,Tax,Tel,Fax,Email,Mobile,Website,Contact,Position,NickYM,NickSky,Area,District,Contry,City,BankAccount,BankName,CreditLimit,Discount,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string Customer_ID,long OrderID,string CustomerName,string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,string Contact,string Position,string NickYM,string NickSky,string Area,string District,string Contry,string City,string BankAccount,string BankName,double CreditLimit,double Discount,string Description,bool Active)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={Customer_ID,OrderID,CustomerName,Customer_Type_ID,Customer_Group_ID,CustomerAddress,Birthday,Barcode,Tax,Tel,Fax,Email,Mobile,Website,Contact,Position,NickYM,NickSky,Area,District,Contry,City,BankAccount,BankName,CreditLimit,Discount,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
        #region sqlUpdate
        string sqlUpdate = @"UPDATE [CUSTOMER]
SET
    OrderID = @OrderID,
    CustomerName = @CustomerName,
    Customer_Type_ID = @Customer_Type_ID,
    Customer_Group_ID = @Customer_Group_ID,
    CustomerAddress = @CustomerAddress,
    Birthday = @Birthday,
    Barcode = @Barcode,
    Tax = @Tax,
    Tel = @Tel,
    Fax = @Fax,
    Email = @Email,
    Mobile = @Mobile,
    Website = @Website,
    Contact = @Contact,
    Position = @Position,
    NickYM = @NickYM,
    NickSky = @NickSky,
    Area = @Area,
    District = @District,
    Contry = @Contry,
    City = @City,
    BankAccount = @BankAccount,
    BankName = @BankName,
    CreditLimit = @CreditLimit,
    Discount = @Discount,
    IsDebt = @IsDebt,
    Description = @Description,
    Active = @Active
 Where 
    Customer_ID = @Customer_ID";
        #endregion

        public string Update()
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@IsDebt","@Description","@Active"};
			object[] myValue={m_Customer_ID,m_OrderID,m_CustomerName,m_Customer_Type_ID,m_Customer_Group_ID,m_CustomerAddress,m_Birthday,m_Barcode,m_Tax,m_Tel,m_Fax,m_Email,m_Mobile,m_Website,m_Contact,m_Position,m_NickYM,m_NickSky,m_Area,m_District,m_Contry,m_City,m_BankAccount,m_BankName,m_CreditLimit,m_Discount,m_IsDebt ,m_Description,m_Active};
			SqlHelper mySql=new SqlHelper();
            mySql.CommandType = CommandType.Text;
            //return mySql.ExecuteNonQuery("CUSTOMER_Update", myPara, myValue);
			return mySql.ExecuteNonQuery(sqlUpdate,myPara,myValue);
		}

        public string Update(SqlTransaction myTransaction)
        {
            string[] myPara = { "@Customer_ID", "@OrderID", "@CustomerName", "@Customer_Type_ID", "@Customer_Group_ID", "@CustomerAddress", "@Birthday", "@Barcode", "@Tax", "@Tel", "@Fax", "@Email", "@Mobile", "@Website", "@Contact", "@Position", "@NickYM", "@NickSky", "@Area", "@District", "@Contry", "@City", "@BankAccount", "@BankName", "@CreditLimit", "@Discount", "@Description", "@Active" };
            object[] myValue = { m_Customer_ID, m_OrderID, m_CustomerName, m_Customer_Type_ID, m_Customer_Group_ID, m_CustomerAddress, m_Birthday, m_Barcode, m_Tax, m_Tel, m_Fax, m_Email, m_Mobile, m_Website, m_Contact, m_Position, m_NickYM, m_NickSky, m_Area, m_District, m_Contry, m_City, m_BankAccount, m_BankName, m_CreditLimit, m_Discount, m_Description, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_Update", myPara, myValue);
        }

		public string Update(string Customer_ID,long OrderID,string CustomerName,string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,string Contact,string Position,string NickYM,string NickSky,string Area,string District,string Contry,string City,string BankAccount,string BankName,double CreditLimit,double Discount,string Description,bool Active)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={Customer_ID,OrderID,CustomerName,Customer_Type_ID,Customer_Group_ID,CustomerAddress,Birthday,Barcode,Tax,Tel,Fax,Email,Mobile,Website,Contact,Position,NickYM,NickSky,Area,District,Contry,City,BankAccount,BankName,CreditLimit,Discount,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string Customer_ID,long OrderID,string CustomerName,string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,string Contact,string Position,string NickYM,string NickSky,string Area,string District,string Contry,string City,string BankAccount,string BankName,double CreditLimit,double Discount,string Description,bool Active)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={Customer_ID,OrderID,CustomerName,Customer_Type_ID,Customer_Group_ID,CustomerAddress,Birthday,Barcode,Tax,Tel,Fax,Email,Mobile,Website,Contact,Position,NickYM,NickSky,Area,District,Contry,City,BankAccount,BankName,CreditLimit,Discount,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string Customer_ID,long OrderID,string CustomerName,string Customer_Type_ID,string Customer_Group_ID,string CustomerAddress,string Birthday,string Barcode,string Tax,string Tel,string Fax,string Email,string Mobile,string Website,string Contact,string Position,string NickYM,string NickSky,string Area,string District,string Contry,string City,string BankAccount,string BankName,double CreditLimit,double Discount,string Description,bool Active)
		{
			string[] myPara={"@Customer_ID","@OrderID","@CustomerName","@Customer_Type_ID","@Customer_Group_ID","@CustomerAddress","@Birthday","@Barcode","@Tax","@Tel","@Fax","@Email","@Mobile","@Website","@Contact","@Position","@NickYM","@NickSky","@Area","@District","@Contry","@City","@BankAccount","@BankName","@CreditLimit","@Discount","@Description","@Active"};
			object[] myValue={Customer_ID,OrderID,CustomerName,Customer_Type_ID,Customer_Group_ID,CustomerAddress,Birthday,Barcode,Tax,Tel,Fax,Email,Mobile,Website,Contact,Position,NickYM,NickSky,Area,District,Contry,City,BankAccount,BankName,CreditLimit,Discount,Description,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@Customer_ID"};
			object[] myValue={m_Customer_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_Delete",myPara,myValue);
		}
		public string Delete(string Customer_ID)
		{
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("CUSTOMER_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string Customer_ID)
		{
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"CUSTOMER_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string Customer_ID)
		{
			string[] myPara={"@Customer_ID"};
			object[] myValue={Customer_ID};
			var mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"CUSTOMER_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("CUSTOMER_GetList");
		}

        public DataTable Search(string Customer_ID, string CustomerName)
        {
            string[] myPara ={ "@Customer_ID","@CustomerName" };
            object[] myValue ={"%"+ Customer_ID +"%","%"+ CustomerName+"%" };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("CUSTOMER_Search",myPara,myValue);
        }

		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "CUSTOMERName", "CUSTOMER_ID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["CUSTOMER_ID"] = "All";
			b["CUSTOMERName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "CUSTOMERName", "CUSTOMER_ID");
		}
		#endregion
		
	}

    public enum CUSTOMER_Fields
    {

        Customer_ID,

        OrderID,

        CustomerName,

        Customer_Type_ID,

        Customer_Group_ID,

        CustomerAddress,

        Birthday,

        Barcode,

        Tax,

        Tel,

        Fax,

        Email,

        Mobile,

        Website,

        Contact,

        Position,

        NickYM,

        NickSky,

        Area,

        District,

        Contry,

        City,

        BankAccount,

        BankName,

        CreditLimit,

        Discount,

        Description,

        Active,
    }
}
