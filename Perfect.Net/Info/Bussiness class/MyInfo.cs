using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using Perfect.Utils.Security2;
using Perfect.Data.Helper;

namespace  Perfect.Net.Info
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : clsGetInfo.
	/// Date: 5/8/2009
	/// Author: 
	/// </summary>
	public class MyInfo
	{
		#region Init
		private static string _mCompanyId;
        private static string _mCompany;
        private static string _mAddress;
        private static string _mTel;
        private static string _mFax;
        private static string _mWebSite;
		private static string _mEmail;
        private static string _mTax;
        private static string _mLicence;
		private static Image _mPhoto;

        private static bool _optionValue;

		public MyInfo()
		{
			//
			// TODO: Add constructor logic here
			//
			
		}
		public MyInfo(
			string companyId,
			string company,
			string address,
			string tel,
			string fax,
			string webSite,
			string email,
			string tax,
			string licence,
            Image photo)		
			{			//
			// TODO: Add constructor logic here
			//
			 _mCompanyId=companyId;
			 _mCompany=company;
			 _mAddress=address;
			 _mTel=tel;
			 _mFax=fax;
			 _mWebSite=webSite;
			 _mEmail=email;
			 _mTax=tax;
			 _mLicence=licence;
			 _mPhoto=photo;
		}
		public static void SetData(
			string Company_Id,
			string Company,
			string Address,
			string Tel,
			string Fax,
			string WebSite,
			string Email,
			string Tax,
			string Licence,
            Image Photo)
		{
			//
			// TODO: Add constructor logic here
			//
			 _mCompanyId=Company_Id;
			 _mCompany=Company;
			 _mAddress=Address;
			 _mTel=Tel;
			 _mFax=Fax;
			 _mWebSite=WebSite;
			 _mEmail=Email;
			 _mTax=Tax;
			 _mLicence=Licence;
			 _mPhoto=Photo;
		}
		#endregion
		
		#region Property
        [DisplayName("OptionValue")]
        [Category("Column")]
        public static bool OptionValue
        {
            get
            {
                return _optionValue;
            }
            set
            {
                _optionValue = value;
            }
        }


		[DisplayName("Company_Id")]
		[Category("Primary Key")]
        public static string Company_Id
		{
			get
			{
				return _mCompanyId;
			}
			set
			{
				_mCompanyId = value;
			}
		}
		[DisplayName("Company")]
		[Category("Column")]
        public static string Company
		{
			get
			{
				return _mCompany;
			}
			set
			{
				_mCompany = value;
			}
		}
		[DisplayName("Address")]
		[Category("Column")]
        public static string Address
		{
			get
			{
				return _mAddress;
			}
			set
			{
				_mAddress = value;
			}
		}
		[DisplayName("Tel")]
		[Category("Column")]
        public static string Tel
		{
			get
			{
				return _mTel;
			}
			set
			{
				_mTel = value;
			}
		}
		[DisplayName("Fax")]
		[Category("Column")]
        public static string Fax
		{
			get
			{
				return _mFax;
			}
			set
			{
				_mFax = value;
			}
		}
		[DisplayName("WebSite")]
		[Category("Column")]
        public static string WebSite
		{
			get
			{
				return _mWebSite;
			}
			set
			{
				_mWebSite = value;
			}
		}
		[DisplayName("Email")]
		[Category("Column")]
        public static string Email
		{
			get
			{
				return _mEmail;
			}
			set
			{
				_mEmail = value;
			}
		}
		[DisplayName("Tax")]
		[Category("Column")]
        public static string Tax
		{
			get
			{
				return _mTax;
			}
			set
			{
				_mTax = value;
			}
		}
		[DisplayName("Licence")]
		[Category("Column")]
        public static string Licence
		{
			get
			{
				return _mLicence;
			}
			set
			{
				_mLicence = value;
			}
		}
		[DisplayName("Photo")]
		[Category("Column")]
		
		public static Image Photo
		{
			get
			{
				return _mPhoto;
			}
			
		}
		
		public string ProductName
		{
			get
			{
				return "Class clsGetInfo";
			}
		}
		public string ProductVersion
		{
			get
			{
				return "1.0.0.0";
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

		

        public static string Get(string Company_Id)
		{
			var result="";
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			var mySql=new SqlHelper();
			var myReader=mySql.ExecuteReader("SYS_COMPANY_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						_mCompanyId =Convert.ToString(myReader["Company_Id"]);
						_mCompany =Convert.ToString(myReader["Company"]);
                        _mCompany = MyEncryption.Decrypt(_mCompany, "123654", true);
						_mAddress =Convert.ToString(myReader["Address"]);
						_mTel =Convert.ToString(myReader["Tel"]);
						_mFax =Convert.ToString(myReader["Fax"]);
						_mWebSite =Convert.ToString(myReader["WebSite"]);
						_mEmail =Convert.ToString(myReader["Email"]);
						_mTax =Convert.ToString(myReader["Tax"]);
						_mLicence =Convert.ToString(myReader["Licence"]);
	                    if (!myReader.IsDBNull(myReader.GetOrdinal("Photo")))
						{
                            if ( myReader["Photo"] != Convert.DBNull)
                            {
                                var vImage = (byte[])myReader["Photo"];
                                if (vImage.Length != 2)
                                {
                                    var ms = new MemoryStream(vImage);
                                    _mPhoto = Image.FromStream(ms);
                                }
                                if (vImage.Length == 2)
                                {
                                     _mPhoto = null;
                                }
                            }
							
						}
						result="OK";
				}
				myReader.Close();
				mySql.Close();
			}
			return result;
		}

        public static bool Get()
        {
            var result = false;
            var mySql = new SqlHelper();
            var myReader = mySql.ExecuteReader("sp_SYS_COMPANY_GetCountRow");
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    _mCompanyId = Convert.ToString(myReader["Company_Id"]);
                    _mCompany = Convert.ToString(myReader["Company"]);
                    _mCompany = MyEncryption.Decrypt(_mCompany, "123654", true);
                    _mAddress = Convert.ToString(myReader["Address"]);
                    _mTel = Convert.ToString(myReader["Tel"]);
                    _mFax = Convert.ToString(myReader["Fax"]);
                    _mWebSite = Convert.ToString(myReader["WebSite"]);
                    _mEmail = Convert.ToString(myReader["Email"]);
                    _mTax = Convert.ToString(myReader["Tax"]);
                    _mLicence = Convert.ToString(myReader["Licence"]);
                    if (!myReader.IsDBNull(myReader.GetOrdinal("Photo")))
                    {
                        if (myReader["Photo"] != Convert.DBNull)
                        {
                            var vImage = (byte[])myReader["Photo"];
                            if (vImage.Length != 2)
                            {
                                var ms = new MemoryStream(vImage);
                                _mPhoto = Image.FromStream(ms);
                            }
                            if (vImage.Length == 2)
                            {
                                _mPhoto = null;
                            }
                        }

                    }
                    result = true;
                }
                myReader.Close();
                mySql.Close();
            }
            return result;
        }

        public static string GetInfo()
        {
            return Get(MyEncryption.Encrypt("ERP01", "123654", true));
            
        }

       
		#endregion
		
		#region Add
        

		public static bool Insert(
            SqlTransaction myTransaction,
			string Company_Id,
			string Company,
			string Address,
			string Tel,
			string Fax,
			string WebSite,
			string Email,
			string Tax,
			string Licence,
			object Photo)
		{
			string[] myPara={
			"@Company_Id",
			"@Company",
			"@Address",
			"@Tel",
			"@Fax",
			"@WebSite",
			"@Email",
			"@Tax",
			"@Licence",
			"@Photo"};
			object[] myValue={
			Company_Id,
			Company,
			Address,
			Tel,
			Fax,
			WebSite,
			Email,
			Tax,
			Licence,
			Photo};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, "SYS_COMPANY_Insert", myPara, myValue) == "OK" ? true : false;
		}
		
		#endregion
		
		#region Update

        public static bool Update()
        {
            return Update(
            _mCompanyId,
            _mCompany,
            _mAddress,
            _mTel,
            _mFax,
            _mWebSite,
            _mEmail,
            _mTax,
            _mLicence,
            _mPhoto);
        }
        public static bool Update(
        string Company_Id,
        string Company,
        string Address,
        string Tel,
        string Fax,
        string WebSite,
        string Email,
        string Tax,
        string Licence,
        object Photo)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.Error += DispError;
            if (mySql.Open() != "OK") return false;
            if (
            Update(
            mySql.Connection,
            Company_Id,
            Company,
            Address,
            Tel,
            Fax,
            WebSite,
            Email,
            Tax,
            Licence,
            Photo)
            )
            {
                mySql.Close();
                return true;
            }
            return false;
        }

        public static bool Update(
            SqlConnection myConnection,
            string Company_Id,
            string Company,
            string Address,
            string Tel,
            string Fax,
            string WebSite,
            string Email,
            string Tax,
            string Licence,
            object Photo)
        {
            string[] myPara ={
			"@Company_Id",
			"@Company",
			"@Address",
			"@Tel",
			"@Fax",
			"@WebSite",
			"@Email",
			"@Tax",
			"@Licence"};
            object[] myValue ={
			Company_Id,
			Company,
			Address,
			Tel,
			Fax,
			WebSite,
			Email,
			Tax,
			Licence};
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text; 
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(
                myConnection, "UPDATE [SYS_COMPANY] SET [Company] = @Company, [Address] = @Address, [Tel] = @Tel, [Fax] = @Fax, [WebSite] = @WebSite, [Email] = @Email, [Tax] = @Tax, [Licence] = @Licence Where  [Company_Id] = @Company_Id", myPara, myValue) == "OK" ? true : false;
        }
		#endregion
		
		#region Delete
        
       	public static bool Delete(
			SqlTransaction myTransaction,
			string Company_Id)
		{
			string[] myPara={"@Company_Id"};
			object[] myValue={Company_Id};
			SqlHelper mySql=new SqlHelper();
			mySql.Error += DispError;
			return mySql.ExecuteNonQuery(myTransaction,"SYS_COMPANY_Delete",myPara,myValue)=="OK"?true:false;
		}
		#endregion
		
		#region GetList

        private static void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Th�ng B�o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
		#endregion

        public static bool UpdateSysOption
        (
            SqlTransaction myTransaction,
            string OptionName,
            bool optionValue 
        )
        {
            string[] myPara = { "@OptionName", "@OptionValue" };
            object[] myValue = { OptionName, optionValue };

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            string sql = @"UPDATE SYS_OPTION
                            SET    [System]      = @OptionValue
                            WHERE  Option_ID     = @OptionName";
            mySql.Error += DispError;
            return mySql.ExecuteNonQuery(myTransaction, sql, myPara, myValue) == "OK" ? true : false;
        }

        public static string GetSysOption(string OptionName)
        {
            var result = "";
            string[] myPara = { "@OptionName" };
            object[] myValue = { OptionName };
            var mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;
            string sql = @"SELECT so.[System] AS OptionValue
                            FROM   SYS_OPTION AS so
                            WHERE  Option_ID = @OptionName ";

            var myReader = mySql.ExecuteReader(sql, myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    _optionValue = Convert.ToBoolean(myReader["OptionValue"]); 
                    result = "OK";
                }
                myReader.Close();
                mySql.Close();
            }
            return result;
        }

		
	}
}
