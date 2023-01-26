using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Common.DS;
using Perfect.Common.DS.dsLayoutTableAdapters;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;
using Perfect.Common;

namespace Perfect.ERP
{
    /// <summary>
    /// Project: 
    /// Generated Class for Table : CONTROL_FORMAT.
    /// Date: 5/8/2009
    /// Author: 
    /// </summary>
    public class CONTROL_FORMAT
    {
        #region Init
        private string m_Control_Format_Id;
        private string m_Form_Id;
        private string m_Control_Id;
        private string m_Language_Id;
        private string m_Caption;
        private string m_Description;
        private long m_Order;
        private bool m_Active;
        public CONTROL_FORMAT()
        {
            //
            // TODO: Add constructor logic here
            //
            m_Control_Format_Id = System.Guid.NewGuid().ToString();
            m_Form_Id = "";
            m_Control_Id = "";
            m_Language_Id = "";
            m_Caption = "";
            m_Description = "";
            m_Order = 0;
            m_Active = true;
        }
        public CONTROL_FORMAT(string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, long Order, bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_Control_Format_Id = Control_Format_Id;
            m_Form_Id = Form_Id;
            m_Control_Id = Control_Id;
            m_Language_Id = Language_Id;
            m_Caption = Caption;
            m_Description = Description;
            m_Order = Order;
            m_Active = Active;
        }
        #endregion

        #region Property
        public string Control_Format_Id
        {
            get
            {
                return m_Control_Format_Id;
            }
            set
            {
                m_Control_Format_Id = value;
            }
        }
        public string Form_Id
        {
            get
            {
                return m_Form_Id;
            }
            set
            {
                m_Form_Id = value;
            }
        }
        public string Control_Id
        {
            get
            {
                return m_Control_Id;
            }
            set
            {
                m_Control_Id = value;
            }
        }
        public string Language_Id
        {
            get
            {
                return m_Language_Id;
            }
            set
            {
                m_Language_Id = value;
            }
        }
        public string Caption
        {
            get
            {
                return m_Caption;
            }
            set
            {
                m_Caption = value;
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
        public long Order
        {
            get
            {
                return m_Order;
            }
            set
            {
                m_Order = value;
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
        public string ProductName
        {
            get
            {
                return "Class CONTROL_FORMAT";
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
            return SqlHelper.GenCode("CONTROL_FORMAT", "CONTROL_FORMATID", "");
        }
        public Boolean Exist(string Control_Format_Id)
        {
            Boolean Result = false;
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CONTROL_FORMAT_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string Get(string Control_Format_Id)
        {
            string Result = "";
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CONTROL_FORMAT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Control_Format_Id = Convert.ToString(myReader["Control_Format_Id"]);
                    m_Form_Id = Convert.ToString(myReader["Form_Id"]);
                    m_Control_Id = Convert.ToString(myReader["Control_Id"]);
                    m_Language_Id = Convert.ToString(myReader["Language_Id"]);
                    m_Caption = Convert.ToString(myReader["Caption"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Order = Convert.ToInt64(myReader["Order"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string Get(string Form_Id, string Control_Id)
        {
            string Result = "";
            string[] myPara ={ "@Form_Id", "@Control_Id" };
            object[] myValue ={ Form_Id, Control_Id };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CONTROL_FORMAT_Get_By_Control", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Control_Format_Id = Convert.ToString(myReader["Control_Format_Id"]);
                    m_Form_Id = Convert.ToString(myReader["Form_Id"]);
                    m_Control_Id = Convert.ToString(myReader["Control_Id"]);
                    m_Language_Id = Convert.ToString(myReader["Language_Id"]);
                    m_Caption = Convert.ToString(myReader["Caption"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Order = Convert.ToInt64(myReader["Order"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }

        public string Get(SqlConnection myConnection, string Control_Format_Id)
        {
            string Result = "";
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "CONTROL_FORMAT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Control_Format_Id = Convert.ToString(myReader["Control_Format_Id"]);
                    m_Form_Id = Convert.ToString(myReader["Form_Id"]);
                    m_Control_Id = Convert.ToString(myReader["Control_Id"]);
                    m_Language_Id = Convert.ToString(myReader["Language_Id"]);
                    m_Caption = Convert.ToString(myReader["Caption"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Order = Convert.ToInt64(myReader["Order"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
        public string Get(SqlTransaction myTransaction, string Control_Format_Id)
        {
            string Result = "";
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "CONTROL_FORMAT_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Control_Format_Id = Convert.ToString(myReader["Control_Format_Id"]);
                    m_Form_Id = Convert.ToString(myReader["Form_Id"]);
                    m_Control_Id = Convert.ToString(myReader["Control_Id"]);
                    m_Language_Id = Convert.ToString(myReader["Language_Id"]);
                    m_Caption = Convert.ToString(myReader["Caption"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Order = Convert.ToInt64(myReader["Order"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
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
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ m_Control_Format_Id, m_Form_Id, m_Control_Id, m_Language_Id, m_Caption, m_Description, m_Order, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CONTROL_FORMAT_Insert", myPara, myValue);
        }
        public string Insert(SqlTransaction myTransaction)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ m_Control_Format_Id, m_Form_Id, m_Control_Id, m_Language_Id, m_Caption, m_Description, m_Order, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CONTROL_FORMAT_Insert", myPara, myValue);
        }
        public string Insert(string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, bool Active)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Active" };
            object[] myValue ={ Control_Format_Id, Form_Id, Control_Id, Language_Id, Caption, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CONTROL_FORMAT_Insert", myPara, myValue);
        }
        public string Insert(SqlConnection myConnection, string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, long Order, bool Active)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ Control_Format_Id, Form_Id, Control_Id, Language_Id, Caption, Description, Order, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myConnection, "CONTROL_FORMAT_Insert", myPara, myValue);
        }
        public string Insert(SqlTransaction myTransaction, string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, long Order, bool Active)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ Control_Format_Id, Form_Id, Control_Id, Language_Id, Caption, Description, Order, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CONTROL_FORMAT_Insert", myPara, myValue);
        }
        #endregion

        #region Update
        public string Update()
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ m_Control_Format_Id, m_Form_Id, m_Control_Id, m_Language_Id, m_Caption, m_Description, m_Order, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CONTROL_FORMAT_Update", myPara, myValue);
        }
        public string Update(string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, long Order, bool Active)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ Control_Format_Id, Form_Id, Control_Id, Language_Id, Caption, Description, Order, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CONTROL_FORMAT_Update", myPara, myValue);
        }
        public string Update(SqlConnection myConnection, string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, long Order, bool Active)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ Control_Format_Id, Form_Id, Control_Id, Language_Id, Caption, Description, Order, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myConnection, "CONTROL_FORMAT_Update", myPara, myValue);
        }
        public string Update(SqlTransaction myTransaction, string Control_Format_Id, string Form_Id, string Control_Id, string Language_Id, string Caption, string Description, long Order, bool Active)
        {
            string[] myPara ={ "@Control_Format_Id", "@Form_Id", "@Control_Id", "@Language_Id", "@Caption", "@Description", "@Order", "@Active" };
            object[] myValue ={ Control_Format_Id, Form_Id, Control_Id, Language_Id, Caption, Description, Order, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CONTROL_FORMAT_Update", myPara, myValue);
        }
        #endregion

        #region Delete
        public string Delete()
        {
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ m_Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CONTROL_FORMAT_Delete", myPara, myValue);
        }
        public string Delete(string Control_Format_Id)
        {
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CONTROL_FORMAT_Delete", myPara, myValue);
        }
        public string Delete(SqlConnection myConnection, string Control_Format_Id)
        {
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myConnection, "CONTROL_FORMAT_Delete", myPara, myValue);
        }
        public string Delete(SqlTransaction myTransaction, string Control_Format_Id)
        {
            string[] myPara ={ "@Control_Format_Id" };
            object[] myValue ={ Control_Format_Id };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CONTROL_FORMAT_Delete", myPara, myValue);
        }
        #endregion

        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("CONTROL_FORMAT_GetList");
        }
        #endregion

        #region Insert Combo

        public void AddCombo(ComboBox combo)
        {
            MyLib.TableToComboBox(combo, GetList(), "CONTROL_FORMATName", "CONTROL_FORMATID");
        }

        public void AddComboAll(ComboBox combo)
        {
            DataTable dt = new DataTable();
            dt = GetList();
            DataRow b = dt.NewRow();
            b["CONTROL_FORMATID"] = "All";
            b["CONTROL_FORMATName"] = "Tất cả";
            dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "CONTROL_FORMATName", "CONTROL_FORMATID");
        }
        #endregion

        public static void Save(string formId)
        {
            Save(formId,SYS_OPTION.Language);
        }

        public static void Save(string formId, string languageId)
        {

            dsLayout ds = new dsLayout();
            Perfect.Common.DS.dsLayoutTableAdapters.CONTROL_FormTableAdapter da = new Perfect.Common.DS.dsLayoutTableAdapters.CONTROL_FormTableAdapter();
            da.Connection.ConnectionString = SqlHelper.ConnectString;
            da.Fill(ds.CONTROL_Form, formId, languageId);
            ds.WriteXml(Application.StartupPath + "\\Layout\\" + languageId + "\\" + formId + ".xml");
        }

        public static DataTable Load(string formId)
        {
            return Load(SYS_OPTION.Language, formId);
        }

        public static DataTable ContainerChangeLanguage(Control ctl, ref DataTable dt)
        {
            if (dt == null) return null;

            for (int j = 0; j < ctl.Controls.Count; j++)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    
                    if (ctl.Controls[j].Name == dt.Rows[i]["Control_Id"].ToString())
                    {
                        ctl.Controls[j].Text = dt.Rows[i]["Caption"].ToString();
                        dt.Rows.RemoveAt(i);
                        break;
                    }
                    i++;

                }

            }

            return dt;
        }

        public static DataTable ControlChangeLanguage(Control ctl, ref DataTable dt)
        {
            if (dt == null) return null;

            int i = 0;
            while (i < dt.Rows.Count)
            {
                
                if (ctl.Name == dt.Rows[i]["Control_Id"].ToString())
                {
                    ctl.Text = dt.Rows[i]["Caption"].ToString();
                    dt.Rows.RemoveAt(i);
                    break;
                }
                i++;

            }

            return dt;
        }

        public static DataTable Load(string formId,string language)
        {
            var ds = new dsLayout();
            if (!System.IO.File.Exists(Application.StartupPath + "\\Layout\\" + language + "\\" + formId + ".xml")) return null;
            ds.ReadXml(Application.StartupPath + "\\Layout\\" + language + "\\" + formId + ".xml");
            return ds.CONTROL_Form;
        }
    }
}
