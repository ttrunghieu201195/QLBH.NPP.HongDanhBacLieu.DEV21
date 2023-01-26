using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;
using Perfect.Utils.Lib;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : PRODUCT_BUILD.
	/// Date: 5/21/2009
	/// Author: 
	/// </summary>
	public class PRODUCT_BUILD
	{
		#region Init
		private string m_ProductID;
		private string m_BuildID;
		private double m_Quantity;
		private double m_Price;
		private double m_Amount;
		public PRODUCT_BUILD()
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ProductID="";
			 m_BuildID="";
			 m_Quantity=0.0;
			 m_Price=0.0;
			 m_Amount=0.0;
		}
		public PRODUCT_BUILD(string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			//
			// TODO: Add constructor logic here
			//
			 m_ProductID=ProductID;
			 m_BuildID=BuildID;
			 m_Quantity=Quantity;
			 m_Price=Price;
			 m_Amount=Amount;
		}
		#endregion
		
		#region Property
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
		public string BuildID
		{
			get
			{
				return m_BuildID;
			}
			set
			{
				m_BuildID = value;
			}
		}
		public double Quantity
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
		public double Price
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
		public double Amount
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
		public string ProductName
		{
			get
			{
				return "Class PRODUCT_BUILD";
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
			return SqlHelper.GenCode("PRODUCT_BUILD","PRODUCT_BUILDID","");
		}
		public Boolean Exist(string ProductID,string BuildID)
		{
			Boolean Result=false;
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_BUILD_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(string ProductID,string BuildID)
		{
			string Result="";
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("PRODUCT_BUILD_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ProductID =Convert.ToString(myReader["ProductID"]);
						m_BuildID =Convert.ToString(myReader["BuildID"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_Price =Convert.ToSingle(myReader["Price"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlConnection myConnection,string ProductID,string BuildID)
		{
			string Result="";
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"PRODUCT_BUILD_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ProductID =Convert.ToString(myReader["ProductID"]);
						m_BuildID =Convert.ToString(myReader["BuildID"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_Price =Convert.ToSingle(myReader["Price"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		public string Get(SqlTransaction myTransaction,string ProductID,string BuildID)
		{
			string Result="";
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"PRODUCT_BUILD_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						m_ProductID =Convert.ToString(myReader["ProductID"]);
						m_BuildID =Convert.ToString(myReader["BuildID"]);
						m_Quantity =Convert.ToSingle(myReader["Quantity"]);
						m_Price =Convert.ToSingle(myReader["Price"]);
						m_Amount =Convert.ToSingle(myReader["Amount"]);
						Result="OK";
				}
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}
		#endregion
		
		#region Add
		public string Insert()
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={m_ProductID,m_BuildID,m_Quantity,m_Price,m_Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_BUILD_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={m_ProductID,m_BuildID,m_Quantity,m_Price,m_Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_BUILD_Insert",myPara,myValue);
		}
		public string Insert(string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={ProductID,BuildID,Quantity,Price,Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_BUILD_Insert",myPara,myValue);
		}
		public string Insert(SqlConnection myConnection,string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={ProductID,BuildID,Quantity,Price,Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_BUILD_Insert",myPara,myValue);
		}
		public string Insert(SqlTransaction myTransaction,string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={ProductID,BuildID,Quantity,Price,Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_BUILD_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
		public string Update()
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={m_ProductID,m_BuildID,m_Quantity,m_Price,m_Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_BUILD_Update",myPara,myValue);
		}
		public string Update(string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={ProductID,BuildID,Quantity,Price,Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_BUILD_Update",myPara,myValue);
		}
		public string Update(SqlConnection myConnection,string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={ProductID,BuildID,Quantity,Price,Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_BUILD_Update",myPara,myValue);
		}
		public string Update(SqlTransaction myTransaction,string ProductID,string BuildID,double Quantity,double Price,double Amount)
		{
			string[] myPara={"@ProductID","@BuildID","@Quantity","@Price","@Amount"};
			object[] myValue={ProductID,BuildID,Quantity,Price,Amount};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_BUILD_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
		public string Delete()
		{
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={m_ProductID,m_BuildID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_BUILD_Delete",myPara,myValue);
		}
		public string Delete(string ProductID,string BuildID)
		{
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("PRODUCT_BUILD_Delete",myPara,myValue);
		}
		public string Delete(SqlConnection myConnection,string ProductID,string BuildID)
		{
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"PRODUCT_BUILD_Delete",myPara,myValue);
		}
		public string Delete(SqlTransaction myTransaction,string ProductID,string BuildID)
		{
			string[] myPara={"@ProductID","@BuildID"};
			object[] myValue={ProductID,BuildID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"PRODUCT_BUILD_Delete",myPara,myValue);
		}

        public string Delete(SqlTransaction myTransaction, string BuildID)
        {
            string[] myPara ={  "@BuildID" };
            object[] myValue ={  BuildID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "PRODUCT_BUILD_Delete_Product", myPara, myValue);
        }

        public string Delete( string BuildID)
        {
            string[] myPara ={ "@BuildID" };
            object[] myValue ={ BuildID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery( "PRODUCT_BUILD_Delete_Product", myPara, myValue);
        }


		#endregion
		
		#region GetList
		
		public DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("PRODUCT_BUILD_GetList");
		}

        public DataTable GetList(string Product_ID)
        {
            string[] myPara ={ "@Product_ID" };
            object[] myValue ={ Product_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("PRODUCT_BUILD_GetList_Product",myPara,myValue);
        }

        public DataTable GetListBuild(string BuildID)
        {
            string[] myPara = { "@BuildID" };
            object[] myValue = {BuildID};
            SqlHelper sqlHelper = new SqlHelper();
            return sqlHelper.ExecuteDataTable("PRODUCT_BUILD_Get_By_ID", myPara, myValue);
        }


		#endregion
		
		#region Insert Combo
		
		public void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "PRODUCT_BUILDName", "PRODUCT_BUILDID");
		}
		
		public void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["PRODUCT_BUILDID"] = "All";
			b["PRODUCT_BUILDName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "PRODUCT_BUILDName", "PRODUCT_BUILDID");
		}
		#endregion
		
	}
}
