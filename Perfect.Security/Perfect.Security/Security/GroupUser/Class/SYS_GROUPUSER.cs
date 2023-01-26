using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Perfect.Utils.Lib;
using Perfect.Data.Helper;



namespace Perfect.Security.Security.GroupUser.Class
{
    public class SYS_GROUPUSER
    {
        #region Init
        private string m_UserID;
        private string m_UserName;
        private string m_Password;
        private string m_Group_ID;
        private string m_Description;
        private string m_PartID;
        private bool m_Active;
        public SYS_GROUPUSER()
        {
            //
            // TODO: Add constructor logic here
            //
            m_UserID = "";
            m_UserName = "";
            m_Password = "";
            m_Group_ID = "";
            m_Description = "";
            m_PartID = "";
            m_Active = true;
        }
        public SYS_GROUPUSER(string UserID, string UserName, string Password, string Group_ID, string PartID, bool Active)
        {
            //
            // TODO: Add constructor logic here
            //
            m_UserID = UserID;
            m_UserName = UserName;
            m_Password = Password;
            m_Group_ID = Group_ID;
            m_PartID = PartID;
            m_Description = Description;
            m_Active = Active;
        }
        #endregion

        #region Property
        public string UserID
        {
            get
            {
                return m_UserID;
            }
            set
            {
                m_UserID = value;
            }
        }
        public string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
            }
        }
        public string Password
        {
            get
            {
                return m_Password;
            }
            set
            {
                m_Password = value;
            }
        }
        public string Group_ID
        {
            get
            {
                return m_Group_ID;
            }
            set
            {
                m_Group_ID = value;
            }
        }
        public string PartID
        {
            get
            {
                return m_PartID;
            }
            set
            {
                m_PartID = value;
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
                return "Class SYS_GROUPUSER";
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
            return SqlHelper.GenCode("SYS_USER", "UserID", "VT");
        }
        public Boolean Exist(string UserID)
        {
            Boolean Result = false;
            string[] myPara = { "@UserID" };
            object[] myValue = { UserID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("SYS_USER_Get", myPara, myValue);
            if (myReader != null)
            {
                Result = myReader.HasRows;
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
        public string Get(string UserID)
        {
            string Result = "";
            string[] myPara = { "@UserID" };
            object[] myValue = { UserID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader("SYS_USER_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_UserID = Convert.ToString(myReader["UserID"]);
                    m_UserName = Convert.ToString(myReader["UserName"]);
                    m_Password = Convert.ToString(myReader["Password"]);
                    m_Group_ID = Convert.ToString(myReader["Group_ID"]);
                    m_PartID = Convert.ToString(myReader["PartID"]);
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
        public string Get(SqlConnection myConnection, string UserID)
        {
            string Result = "";
            string[] myPara = { "@UserID" };
            object[] myValue = { UserID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myConnection, "SYS_USER_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_UserID = Convert.ToString(myReader["UserID"]);
                    m_UserName = Convert.ToString(myReader["UserName"]);
                    m_Password = Convert.ToString(myReader["Password"]);
                    m_Group_ID = Convert.ToString(myReader["Group_ID"]);
                    m_PartID = Convert.ToString(myReader["PartID"]);
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
        public string Get(SqlTransaction myTransaction, string UserID)
        {
            string Result = "";
            string[] myPara = { "@UserID" };
            object[] myValue = { UserID };
            SqlHelper mySql = new SqlHelper();
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, "SYS_USER_Get", myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_UserID = Convert.ToString(myReader["UserID"]);
                    m_UserName = Convert.ToString(myReader["UserName"]);
                    m_Password = Convert.ToString(myReader["Password"]);
                    m_Group_ID = Convert.ToString(myReader["Group_ID"]);
                    m_PartID = Convert.ToString(myReader["PartID"]);
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

        #region GetList
        public DataTable Get_List(string UserID)
        {
            string[] mypara = {"@UserID"};
            object [] myvalue = {UserID};
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("SYS_USER_Get1",mypara ,myvalue );
        }
        public DataTable Get_List2(string Group_ID)
        {
            if (Group_ID == null) throw new ArgumentNullException("Group_ID");
            string[] mypara = { "@Group_ID" };
            object[] myvalue = { Group_ID  };
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("SYS_USER_GetGroupID", mypara , myvalue);
        }
        public DataTable Get_List_Permision (string Group_ID)
        {
            string[] mypara = { "@Group_ID" };
            object[] myvalue = { Group_ID };
            SqlHelper mysql = new SqlHelper();
            return mysql.ExecuteDataTable("SYS_USER_RULE_Get1", mypara, myvalue);
        }
        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            return mySql.ExecuteDataTable("SYS_USER_GetList");
        }
        #endregion

        #region Insert Combo

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo,GetList(), "SYS_GROUPName", "SYS_GROUPID");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dt = new DataTable();
        //    dt =GetList();
        //    DataRow b = dt.NewRow();
        //    b["SYS_GROUPID"] = "All";
        //    b["SYS_GROUPName"] = "Tất cả";
        //    dt.Rows.InsertAt(b, 0);
        //    MyLib.TableToComboBox(combo,dt, "SYS_GROUPName", "SYS_GROUPID");
        //}
        #endregion
    }
}
