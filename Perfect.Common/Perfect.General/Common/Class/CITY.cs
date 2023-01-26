using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;

namespace Perfect.ERP
{
    /// <summary>
    /// Project: 
    /// Generated Class for Table : CITY.
    /// Date: 2/11/2009
    /// Author: 
    /// </summary>
    public class CITY
    {
        #region Init
        private string m_Province_ID;
        private string m_Province_Name;
        private string m_ACN;
        private string m_Description;
        private bool m_Active;
        public CITY()
        {
            //
            // TODO: Add constructor logic here
            //
            m_Province_ID = "";
            m_Province_Name = "";
            m_ACN = "";
            m_Description = "";
            m_Active = true;
        }
        public CITY(string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_Province_ID = Province_ID;
            m_Province_Name = Province_Name;
            m_ACN = ACN;
            m_Description = Description;
            m_Active = Active;
        }
        #endregion

        #region Property
        public string Province_ID
        {
            get
            {
                return m_Province_ID;
            }
            set
            {
                m_Province_ID = value;
            }
        }
        public string Province_Name
        {
            get
            {
                return m_Province_Name;
            }
            set
            {
                m_Province_Name = value;
            }
        }
        public string ACN
        {
            get
            {
                return m_ACN;
            }
            set
            {
                m_ACN = value;
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
        public string ProductName
        {
            get
            {
                return "Class CITY";
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
            return SqlHelper.GenCode("CITY", "CITY_ID", "");
        }
        public Boolean Exist(string Province_ID)
        {
            Boolean Result = false;
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CITY_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
        public string Get(string Province_ID)
        {
            string Result = "";
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("CITY_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Province_ID = Convert.ToString(myReader["Province_ID"]);
                    m_Province_Name = Convert.ToString(myReader["Province_Name"]);
                    m_ACN = Convert.ToString(myReader["ACN"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
        public string Get(SqlConnection myConnection, string Province_ID)
        {
            string Result = "";
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "CITY_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Province_ID = Convert.ToString(myReader["Province_ID"]);
                    m_Province_Name = Convert.ToString(myReader["Province_Name"]);
                    m_ACN = Convert.ToString(myReader["ACN"]);
                    m_Description = Convert.ToString(myReader["Description"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
        public string Get(SqlTransaction myTransaction, string Province_ID)
        {
            string Result = "";
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "CITY_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_Province_ID = Convert.ToString(myReader["Province_ID"]);
                    m_Province_Name = Convert.ToString(myReader["Province_Name"]);
                    m_ACN = Convert.ToString(myReader["ACN"]);
                    m_Description = Convert.ToString(myReader["Description"]);
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
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ m_Province_ID, m_Province_Name, m_ACN, m_Description, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CITY_Insert", myPara, myValue);
        }
        public string Insert(SqlTransaction myTransaction)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ m_Province_ID, m_Province_Name, m_ACN, m_Description, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CITY_Insert", myPara, myValue);
        }
        public string Insert(string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ Province_ID, Province_Name, ACN, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CITY_Insert", myPara, myValue);
        }
        public string Insert(SqlConnection myConnection, string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ Province_ID, Province_Name, ACN, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myConnection, "CITY_Insert", myPara, myValue);
        }
        public string Insert(SqlTransaction myTransaction, string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ Province_ID, Province_Name, ACN, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CITY_Insert", myPara, myValue);
        }
        #endregion

        #region Update
        public string Update()
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ m_Province_ID, m_Province_Name, m_ACN, m_Description, m_Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CITY_Update", myPara, myValue);
        }
        public string Update(string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ Province_ID, Province_Name, ACN, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CITY_Update", myPara, myValue);
        }
        public string Update(SqlConnection myConnection, string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ Province_ID, Province_Name, ACN, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myConnection, "CITY_Update", myPara, myValue);
        }
        public string Update(SqlTransaction myTransaction, string Province_ID, string Province_Name, string ACN, string Description, bool Active)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name", "@ACN", "@Description", "@Active" };
            object[] myValue ={ Province_ID, Province_Name, ACN, Description, Active };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CITY_Update", myPara, myValue);
        }
        #endregion

        #region Delete
        public string Delete()
        {
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ m_Province_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CITY_Delete", myPara, myValue);
        }
        public string Delete(string Province_ID)
        {
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery("CITY_Delete", myPara, myValue);
        }
        public string Delete(SqlConnection myConnection, string Province_ID)
        {
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myConnection, "CITY_Delete", myPara, myValue);
        }
        public string Delete(SqlTransaction myTransaction, string Province_ID)
        {
            string[] myPara ={ "@Province_ID" };
            object[] myValue ={ Province_ID };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteNonQuery(myTransaction, "CITY_Delete", myPara, myValue);
        }
        #endregion

        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("CITY_GetList");
        }
        public DataTable Search(string ID, string Name)
        {
            string[] myPara ={ "@Province_ID", "@Province_Name" };
            object[] myValue ={ "%" + ID + "%", "%" + Name + "%" };
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("CITY_Search", myPara, myValue);
        }
        #endregion

        #region Insert Combo

        public void AddCombo(ComboBox combo)
        {
            MyLib.TableToComboBox(combo, GetList(), "Province_Name", "Province_ID");
        }

        public void AddComboAll(ComboBox combo)
        {
            DataTable dt = new DataTable();
            dt = GetList();
            DataRow b = dt.NewRow();
            b["Province_ID"] = "All";
            b["Province_Name"] = "Tất cả";
            dt.Rows.InsertAt(b, 0);
            MyLib.TableToComboBox(combo, dt, "Province_Name", "Province_ID");
        }

        public void AddLookUpEdit(DevExpress.XtraEditors.LookUpEdit Lue)
        {
            
            Lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Province_ID", 120, "Mã"));
            Lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Province_Name", 200, "Tỉnh thành"));
            Lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACN", 120, "Mã vùng"));
            Lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 200, "Ghi chú"));
            Lue.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Active", 100, "Kích hoạt"));
            Lue.Properties.DataSource = GetList();
            Lue.Properties.DisplayMember = "Province_Name";
            Lue.Properties.ValueMember = "Province_ID";



            //for (int i = 0; i < Lue.Properties.Columns.Count; i++)
            //{
            //    switch (Lue.Properties.Columns[i].FieldName)
            //    {
            //        case "Province_ID":
            //            Lue.Properties.Columns[i].Caption = "Mã";
            //            Lue.Properties.Columns[i].Width = 70;
            //            break;
            //        case "Province_Name":
            //            Lue.Properties.Columns[i].Caption = "Tỉnh thành";
            //            Lue.Properties.Columns[i].Width = 150;
            //            break;
            //        case "Description":
            //            Lue.Properties.Columns[i].Caption = "Ghi chú";
            //            Lue.Properties.Columns[i].Width = 150;
            //            break;
            //        case "Active":
            //            Lue.Properties.Columns[i].Caption = "Kích hoạt";
            //            Lue.Properties.Columns[i].Width = 50;
            //            break;

            //        default:
            //            Lue.Properties.Columns[i].Visible = false;
            //            break;
            //    }
            //}
        }

        #endregion

    }
}
