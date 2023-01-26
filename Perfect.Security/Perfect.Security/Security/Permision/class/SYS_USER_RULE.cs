using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.Security;
using Perfect.Data.Helper;
using Perfect.Security.Security.Login;
using Perfect.Utils.Lib;
using ComboBox=System.Windows.Forms.ComboBox;

namespace Perfect.ERP
{
	/// <summary>
	/// Project: 
	/// Generated Class for Table : SYS_USER_RULE.
	/// Date: 5/7/2009
	/// Author: 
	/// </summary>
    public static class MyRule
	{
		#region Init
        private static string m_Goup_ID;
        private static string m_Object_ID;
        private static string m_Rule_ID;
        private static bool m_AllowAdd;
        private static bool m_AllowDelete;
        private static bool m_AllowEdit;
        private static bool m_AllowAccess;
        private static bool m_AllowPrint;
        private static bool m_AllowExport;
        private static bool m_AllowImport;
        private static bool m_Active;

        //public SYS_USER_RULE()
        //{
        //    //
        //    // TODO: Add constructor logic here
        //    //
        //     m_Goup_ID="";
        //     m_Object_ID="";
        //     m_Rule_ID="";
        //     m_AllowAdd=true;
        //     m_AllowDelete=true;
        //     m_AllowEdit=true;
        //     m_AllowAccess=true;
        //     m_AllowPrint=true;
        //     m_AllowExport=true;
        //     m_AllowImport=true;
        //     m_Active=true;
        //}
        //public SYS_USER_RULE(string Goup_ID,string Object_ID,string Rule_ID,bool AllowAdd,bool AllowDelete,bool AllowEdit,bool AllowAccess,bool AllowPrint,bool AllowExport,bool AllowImport,bool Active)
        //{
        //    //
        //    // TODO: Add constructor logic here
        //    //
        //     m_Goup_ID=Goup_ID;
        //     m_Object_ID=Object_ID;
        //     m_Rule_ID=Rule_ID;
        //     m_AllowAdd=AllowAdd;
        //     m_AllowDelete=AllowDelete;
        //     m_AllowEdit=AllowEdit;
        //     m_AllowAccess=AllowAccess;
        //     m_AllowPrint=AllowPrint;
        //     m_AllowExport=AllowExport;
        //     m_AllowImport=AllowImport;
        //     m_Active=Active;
        //}
		#endregion
		
		#region Property
        public static string Goup_ID
		{
			get
			{
				return m_Goup_ID;
			}
			set
			{
				m_Goup_ID = value;
			}
		}
        public static string Object_ID
		{
			get
			{
				return m_Object_ID;
			}
			set
			{
				m_Object_ID = value;
			}
		}
        public static string Rule_ID
		{
			get
			{
				return m_Rule_ID;
			}
			set
			{
				m_Rule_ID = value;
			}
		}
        public static bool AllowAdd
		{
			get
			{
				return m_AllowAdd;
			}
			set
			{
				m_AllowAdd = value;
			}
		}

        public static BarItemVisibility Added
	    {
            get
            {
                if (m_AllowAdd)
                    return BarItemVisibility.Always;
                else
                {
                    return BarItemVisibility.Never;
                }
            }
           
	    }


        public static bool AllowDelete
		{
			get
			{
				return m_AllowDelete;
			}
			set
			{
				m_AllowDelete = value;
			}
		}
        public static BarItemVisibility Deleted
        {
            get
            {
                if (m_AllowDelete)
                    return BarItemVisibility.Always;
                else
                {
                    return BarItemVisibility.Never;
                }
            }

        }

        public static bool AllowEdit
		{
			get
			{
				return m_AllowEdit;
			}
			set
			{
				m_AllowEdit = value;
			}
		}
        public static BarItemVisibility Edited
        {
            get
            {
                if (m_AllowEdit)
                    return BarItemVisibility.Always;
                else
                {
                    return BarItemVisibility.Never;
                }
            }

        }

        public static bool AllowAccess
		{
			get
			{
				return m_AllowAccess;
			}
			set
			{
				m_AllowAccess = value;
			}
		}
        public static BarItemVisibility Accessed
        {
            get
            {
                if (m_AllowAccess)
                    return BarItemVisibility.Always;
                return BarItemVisibility.Never;
            }
        }

        public static bool AllowPrint
		{
			get
			{
				return m_AllowPrint;
			}
			set
			{
				m_AllowPrint = value;
			}
		}
        public static BarItemVisibility Printed
        {
            get
            {
                if (m_AllowPrint)
                    return BarItemVisibility.Always;
                return BarItemVisibility.Never;
            }
        }
        public static bool AllowExport
		{
			get
			{
				return m_AllowExport;
			}
			set
			{
				m_AllowExport = value;
			}
		}
        public static BarItemVisibility Exported
        {
            get
            {
                if (m_AllowExport)
                    return BarItemVisibility.Always;
                return BarItemVisibility.Never;
            }
        }
        public static bool AllowImport
		{
			get
			{
				return m_AllowImport;
			}
			set
			{
				m_AllowImport = value;
			}
		}

        public static BarItemVisibility Imported
        {
            get
            {
                if (m_AllowImport)
                    return BarItemVisibility.Always;
                return BarItemVisibility.Never;
            }
        }
        public static bool Active
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
        public static string ProductName
		{
			get
			{
				return "Class SYS_USER_RULE";
			}
		}
        public static string ProductVersion
		{
			get
			{
				return "1.0.0.0";
			}
		}
		public static string Copyright
		{
			get
			{
				return "Công Ty Phần Mềm Hoàn Hảo";
			}
		}
		#endregion
		
		#region Get
        public static string NewID()
		{
			return SqlHelper.GenCode("SYS_USER_RULE","SYS_USER_RULEID","");
		}

		public static string CreateKey()
		{
			return CreateKey("");
		}

		public static string CreateKey(string key)
		{
			return SqlHelper.GenCode(key);
		}

		public static string CreateKey(SqlTransaction myTransaction,string key)
		{
			return SqlHelper.GenCode(myTransaction,key);
		}

		public static string CreateKey(SqlTransaction myTransaction)
		{
			return SqlHelper.GenCode(myTransaction,"");
		}

		public static Boolean Exist()
		{
			return Exist(m_Goup_ID,m_Object_ID);
		}

		public static Boolean Exist(SqlTransaction myTransaction)
		{
			return Exist(myTransaction,m_Goup_ID,m_Object_ID);
		}
        public static Boolean Exist(string Goup_ID, string Object_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_USER_RULE_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				mySql.Close();
				myReader = null;
			}
			return Result;
		}

		public static Boolean Exist(SqlTransaction myTransaction,string Goup_ID,string Object_ID)
		{
			Boolean Result=false;
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SYS_USER_RULE_Get",myPara,myValue);
			if (myReader !=null)
			{
					Result= myReader.HasRows;
				myReader.Close();
				myReader = null;
			}
			return Result;
		}

		public static string Get()
		{
			return Get(Goup_ID,Object_ID);
		}



		public static string Get(SqlConnection myConnection)
		{
			return Get(myConnection,Goup_ID,Object_ID);
		}



		public static string Get(SqlTransaction myTransaction)
		{
			return Get(myTransaction,Goup_ID,Object_ID);
		}

        
        public static bool Check(EnumRule rule,string myObject)
        {
            string result = Get(MyLogin.RoleId, myObject);//truy vấn người truy nhập
            if (result!="OK")
            {
                //Notify();
                return false;
            }
            switch (rule)
            {
                case EnumRule.AllowAccess:
                    return AllowAccess;
                case EnumRule.AllowAdd:
                    return AllowAdd;
                case EnumRule.AllowDelete:
                    return AllowDelete;
                case EnumRule.AllowEdit:
                    return AllowEdit;
                case EnumRule.AllowPrint:
                    return AllowPrint;
                case EnumRule.AllowExport:
                    return AllowExport;
                case EnumRule.AllowImport:
                    return AllowImport;
                default:
                    return true;
            }
            
        }

        public static bool Check(string myObject)
	    {
            return Check(EnumRule.All,myObject);
	    }

        public static bool IsAdd(string myObject) 
        {
            return Check(EnumRule.AllowAdd, myObject);
        }

        public static bool IsAccess(string myObject)
        {
            return Check(EnumRule.AllowAccess, myObject);
        }

        public static bool IsDelete(string myObject)
        {
            return Check(EnumRule.AllowDelete, myObject);
        }

        public static bool IsEdit(string myObject)
        {
            return Check(EnumRule.AllowEdit, myObject);
        }

        public static bool IsPrint(string myObject)
        {
            return Check(EnumRule.AllowPrint, myObject);
        }

        public static bool IsImport(string myObject)
        {
            return Check(EnumRule.AllowImport, myObject);
        }

        public static bool IsExport(string myObject)
        {
            return Check(EnumRule.AllowExport, myObject);
        }

        public static bool IsAdmin()
        {
            xfmIsAdmin  xf=new xfmIsAdmin();
            xf.ShowDialog();
            return xfmIsAdmin.isAdmin;
        }


		public static string Get(string Goup_ID,string Object_ID)
		{
			string Result="";
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader("SYS_USER_RULE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Goup_ID =Convert.ToString(myReader["Goup_ID"]);
						m_Object_ID =Convert.ToString(myReader["Object_ID"]);
						m_Rule_ID =Convert.ToString(myReader["Rule_ID"]);
						m_AllowAdd =Convert.ToBoolean(myReader["AllowAdd"]);
						m_AllowDelete =Convert.ToBoolean(myReader["AllowDelete"]);
						m_AllowEdit =Convert.ToBoolean(myReader["AllowEdit"]);
						m_AllowAccess =Convert.ToBoolean(myReader["AllowAccess"]);
						m_AllowPrint =Convert.ToBoolean(myReader["AllowPrint"]);
						m_AllowExport =Convert.ToBoolean(myReader["AllowExport"]);
						m_AllowImport =Convert.ToBoolean(myReader["AllowImport"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Goup_ID =Convert.ToString(myReader["Goup_ID"]==DBNull.Value?"":myReader["Goup_ID"] );
						m_Object_ID =Convert.ToString(myReader["Object_ID"]==DBNull.Value?"":myReader["Object_ID"] );
						m_Rule_ID =Convert.ToString(myReader["Rule_ID"]==DBNull.Value?"":myReader["Rule_ID"] );
						m_AllowAdd =Convert.ToBoolean(myReader["AllowAdd"]==DBNull.Value?true:myReader["AllowAdd"] );
						m_AllowDelete =Convert.ToBoolean(myReader["AllowDelete"]==DBNull.Value?true:myReader["AllowDelete"] );
						m_AllowEdit =Convert.ToBoolean(myReader["AllowEdit"]==DBNull.Value?true:myReader["AllowEdit"] );
						m_AllowAccess =Convert.ToBoolean(myReader["AllowAccess"]==DBNull.Value?true:myReader["AllowAccess"] );
						m_AllowPrint =Convert.ToBoolean(myReader["AllowPrint"]==DBNull.Value?true:myReader["AllowPrint"] );
						m_AllowExport =Convert.ToBoolean(myReader["AllowExport"]==DBNull.Value?true:myReader["AllowExport"] );
						m_AllowImport =Convert.ToBoolean(myReader["AllowImport"]==DBNull.Value?true:myReader["AllowImport"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
						#endif
						Result="OK";
				}
				myReader.Close();
				myReader = null;
			}
				mySql.Close();
			return Result;
		}

        public static string Get(SqlConnection myConnection, string Goup_ID, string Object_ID)
		{
			string Result="";
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myConnection,"SYS_USER_RULE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Goup_ID =Convert.ToString(myReader["Goup_ID"]);
						m_Object_ID =Convert.ToString(myReader["Object_ID"]);
						m_Rule_ID =Convert.ToString(myReader["Rule_ID"]);
						m_AllowAdd =Convert.ToBoolean(myReader["AllowAdd"]);
						m_AllowDelete =Convert.ToBoolean(myReader["AllowDelete"]);
						m_AllowEdit =Convert.ToBoolean(myReader["AllowEdit"]);
						m_AllowAccess =Convert.ToBoolean(myReader["AllowAccess"]);
						m_AllowPrint =Convert.ToBoolean(myReader["AllowPrint"]);
						m_AllowExport =Convert.ToBoolean(myReader["AllowExport"]);
						m_AllowImport =Convert.ToBoolean(myReader["AllowImport"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Goup_ID =Convert.ToString(myReader["Goup_ID"]==DBNull.Value?"":myReader["Goup_ID"] );
						m_Object_ID =Convert.ToString(myReader["Object_ID"]==DBNull.Value?"":myReader["Object_ID"] );
						m_Rule_ID =Convert.ToString(myReader["Rule_ID"]==DBNull.Value?"":myReader["Rule_ID"] );
						m_AllowAdd =Convert.ToBoolean(myReader["AllowAdd"]==DBNull.Value?true:myReader["AllowAdd"] );
						m_AllowDelete =Convert.ToBoolean(myReader["AllowDelete"]==DBNull.Value?true:myReader["AllowDelete"] );
						m_AllowEdit =Convert.ToBoolean(myReader["AllowEdit"]==DBNull.Value?true:myReader["AllowEdit"] );
						m_AllowAccess =Convert.ToBoolean(myReader["AllowAccess"]==DBNull.Value?true:myReader["AllowAccess"] );
						m_AllowPrint =Convert.ToBoolean(myReader["AllowPrint"]==DBNull.Value?true:myReader["AllowPrint"] );
						m_AllowExport =Convert.ToBoolean(myReader["AllowExport"]==DBNull.Value?true:myReader["AllowExport"] );
						m_AllowImport =Convert.ToBoolean(myReader["AllowImport"]==DBNull.Value?true:myReader["AllowImport"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
						#endif
						Result="OK";
				}
				myReader.Close();
				myReader = null;
			}
			return Result;
		}

        public static string Get(SqlTransaction myTransaction, string Goup_ID, string Object_ID)
		{
			string Result="";
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			SqlDataReader myReader=mySql.ExecuteReader(myTransaction,"SYS_USER_RULE_Get",myPara,myValue);
			if (myReader !=null)
			{
				while (myReader.Read())
				{
						#if DEBUG
						m_Goup_ID =Convert.ToString(myReader["Goup_ID"]);
						m_Object_ID =Convert.ToString(myReader["Object_ID"]);
						m_Rule_ID =Convert.ToString(myReader["Rule_ID"]);
						m_AllowAdd =Convert.ToBoolean(myReader["AllowAdd"]);
						m_AllowDelete =Convert.ToBoolean(myReader["AllowDelete"]);
						m_AllowEdit =Convert.ToBoolean(myReader["AllowEdit"]);
						m_AllowAccess =Convert.ToBoolean(myReader["AllowAccess"]);
						m_AllowPrint =Convert.ToBoolean(myReader["AllowPrint"]);
						m_AllowExport =Convert.ToBoolean(myReader["AllowExport"]);
						m_AllowImport =Convert.ToBoolean(myReader["AllowImport"]);
						m_Active =Convert.ToBoolean(myReader["Active"]);
						#else
						m_Goup_ID =Convert.ToString(myReader["Goup_ID"]==DBNull.Value?"":myReader["Goup_ID"] );
						m_Object_ID =Convert.ToString(myReader["Object_ID"]==DBNull.Value?"":myReader["Object_ID"] );
						m_Rule_ID =Convert.ToString(myReader["Rule_ID"]==DBNull.Value?"":myReader["Rule_ID"] );
						m_AllowAdd =Convert.ToBoolean(myReader["AllowAdd"]==DBNull.Value?true:myReader["AllowAdd"] );
						m_AllowDelete =Convert.ToBoolean(myReader["AllowDelete"]==DBNull.Value?true:myReader["AllowDelete"] );
						m_AllowEdit =Convert.ToBoolean(myReader["AllowEdit"]==DBNull.Value?true:myReader["AllowEdit"] );
						m_AllowAccess =Convert.ToBoolean(myReader["AllowAccess"]==DBNull.Value?true:myReader["AllowAccess"] );
						m_AllowPrint =Convert.ToBoolean(myReader["AllowPrint"]==DBNull.Value?true:myReader["AllowPrint"] );
						m_AllowExport =Convert.ToBoolean(myReader["AllowExport"]==DBNull.Value?true:myReader["AllowExport"] );
						m_AllowImport =Convert.ToBoolean(myReader["AllowImport"]==DBNull.Value?true:myReader["AllowImport"] );
						m_Active =Convert.ToBoolean(myReader["Active"]==DBNull.Value?true:myReader["Active"] );
						#endif
						Result="OK";
				}
				myReader.Close();
				myReader = null;
			}
			return Result;
		}
		#endregion
		
		#region Add
        public static string Insert()
		{
			return Insert(m_Goup_ID,m_Object_ID,m_Rule_ID,m_AllowAdd,m_AllowDelete,m_AllowEdit,m_AllowAccess,m_AllowPrint,m_AllowExport,m_AllowImport,m_Active);
		}
        public static string Insert(SqlTransaction myTransaction)
		{
			return Insert(myTransaction,m_Goup_ID,m_Object_ID,m_Rule_ID,m_AllowAdd,m_AllowDelete,m_AllowEdit,m_AllowAccess,m_AllowPrint,m_AllowExport,m_AllowImport,m_Active);
		}
		public static string Insert(SqlConnection myConnection)
		{
			return Insert(myConnection,m_Goup_ID,m_Object_ID,m_Rule_ID,m_AllowAdd,m_AllowDelete,m_AllowEdit,m_AllowAccess,m_AllowPrint,m_AllowExport,m_AllowImport,m_Active);
		}
        public static string Insert(string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
		{
			string[] myPara={"@Goup_ID","@Object_ID","@Rule_ID","@AllowAdd","@AllowDelete","@AllowEdit","@AllowAccess","@AllowPrint","@AllowExport","@AllowImport","@Active"};
			object[] myValue={Goup_ID,Object_ID,Rule_ID,AllowAdd,AllowDelete,AllowEdit,AllowAccess,AllowPrint,AllowExport,AllowImport,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_USER_RULE_Insert",myPara,myValue);
		}
        public static string Insert(SqlConnection myConnection, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
		{
			string[] myPara={"@Goup_ID","@Object_ID","@Rule_ID","@AllowAdd","@AllowDelete","@AllowEdit","@AllowAccess","@AllowPrint","@AllowExport","@AllowImport","@Active"};
			object[] myValue={Goup_ID,Object_ID,Rule_ID,AllowAdd,AllowDelete,AllowEdit,AllowAccess,AllowPrint,AllowExport,AllowImport,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_USER_RULE_Insert",myPara,myValue);
		}
        public static string Insert(SqlTransaction myTransaction, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
		{
			string[] myPara={"@Goup_ID","@Object_ID","@Rule_ID","@AllowAdd","@AllowDelete","@AllowEdit","@AllowAccess","@AllowPrint","@AllowExport","@AllowImport","@Active"};
			object[] myValue={Goup_ID,Object_ID,Rule_ID,AllowAdd,AllowDelete,AllowEdit,AllowAccess,AllowPrint,AllowExport,AllowImport,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_USER_RULE_Insert",myPara,myValue);
		}
		#endregion
		
		#region Update
        public static string Update()
		{
			return Update(m_Goup_ID,m_Object_ID,m_Rule_ID,m_AllowAdd,m_AllowDelete,m_AllowEdit,m_AllowAccess,m_AllowPrint,m_AllowExport,m_AllowImport,m_Active);
		}
		public static string Update(SqlConnection myConnection)
		{
			return Update(myConnection,m_Goup_ID,m_Object_ID,m_Rule_ID,m_AllowAdd,m_AllowDelete,m_AllowEdit,m_AllowAccess,m_AllowPrint,m_AllowExport,m_AllowImport,m_Active);
		}
		public static string Update(SqlTransaction myTransaction)
		{
			return Update(myTransaction,m_Goup_ID,m_Object_ID,m_Rule_ID,m_AllowAdd,m_AllowDelete,m_AllowEdit,m_AllowAccess,m_AllowPrint,m_AllowExport,m_AllowImport,m_Active);
		}
        public static string Update(string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
		{
			string[] myPara={"@Goup_ID","@Object_ID","@Rule_ID","@AllowAdd","@AllowDelete","@AllowEdit","@AllowAccess","@AllowPrint","@AllowExport","@AllowImport","@Active"};
			object[] myValue={Goup_ID,Object_ID,Rule_ID,AllowAdd,AllowDelete,AllowEdit,AllowAccess,AllowPrint,AllowExport,AllowImport,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_USER_RULE_Update",myPara,myValue);
		}
        public static string Update(SqlConnection myConnection, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
		{
			string[] myPara={"@Goup_ID","@Object_ID","@Rule_ID","@AllowAdd","@AllowDelete","@AllowEdit","@AllowAccess","@AllowPrint","@AllowExport","@AllowImport","@Active"};
			object[] myValue={Goup_ID,Object_ID,Rule_ID,AllowAdd,AllowDelete,AllowEdit,AllowAccess,AllowPrint,AllowExport,AllowImport,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_USER_RULE_Update",myPara,myValue);
		}
        public static string Update(SqlTransaction myTransaction, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
		{
			string[] myPara={"@Goup_ID","@Object_ID","@Rule_ID","@AllowAdd","@AllowDelete","@AllowEdit","@AllowAccess","@AllowPrint","@AllowExport","@AllowImport","@Active"};
			object[] myValue={Goup_ID,Object_ID,Rule_ID,AllowAdd,AllowDelete,AllowEdit,AllowAccess,AllowPrint,AllowExport,AllowImport,Active};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_USER_RULE_Update",myPara,myValue);
		}
		#endregion
		
		#region Delete
        public static string Delete()
		{
			return Delete(m_Goup_ID,m_Object_ID);
		}
		public static string Delete(SqlConnection myConnection)
		{
			return Delete(myConnection,m_Goup_ID,m_Object_ID);
		}
		public static string Delete(SqlTransaction myTransaction)
		{
			return Delete(m_Goup_ID,m_Object_ID);
		}
        public static string Delete(string Goup_ID, string Object_ID)
		{
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery("SYS_USER_RULE_Delete",myPara,myValue);
		}
        public static string Delete(SqlConnection myConnection, string Goup_ID, string Object_ID)
		{
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myConnection,"SYS_USER_RULE_Delete",myPara,myValue);
		}
        public static string Delete(SqlTransaction myTransaction, string Goup_ID, string Object_ID)
		{
			string[] myPara={"@Goup_ID","@Object_ID"};
			object[] myValue={Goup_ID,Object_ID};
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteNonQuery(myTransaction,"SYS_USER_RULE_Delete",myPara,myValue);
		}
		#endregion
		
		#region GetList

        public static DataTable GetList()
		{
			SqlHelper mySql=new SqlHelper();
			return mySql.ExecuteDataTable("SYS_USER_RULE_GetList");
		}

        public static void Notify()
        {
            XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Notify(IWin32Window sender)
        {
            XtraMessageBox.Show(sender, MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }




        

	    #endregion
		
		#region Insert Combo

        public static void AddCombo(ComboBox combo)
		{
			MyLib.TableToComboBox(combo,GetList(), "SYS_USER_RULEName", "SYS_USER_RULEID");
		}

        public static void AddComboAll(ComboBox combo)
		{
			DataTable dt = new DataTable();
			dt =GetList();
			DataRow b = dt.NewRow();
			b["SYS_USER_RULEID"] = "All";
			b["SYS_USER_RULEName"] = "Tất cả";
			dt.Rows.InsertAt(b, 0);
			MyLib.TableToComboBox(combo,dt, "SYS_USER_RULEName", "SYS_USER_RULEID");
		}
		#endregion

        public enum EnumRule
        {
            All,
            AllowAccess,
            AllowAdd,
            AllowDelete,
            AllowEdit,
            AllowPrint,
            AllowExport,
            AllowImport
        }
	}
}
