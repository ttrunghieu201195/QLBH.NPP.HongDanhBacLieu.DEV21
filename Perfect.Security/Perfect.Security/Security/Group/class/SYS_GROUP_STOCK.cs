using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Perfect.Data.Helper;

namespace Perfect.Security
{
    public class SYS_GROUP_STOCK
    {
        #region Init
        private string m_GroupID = "";
        private string m_StockID = "";
        private bool m_Active = false;

        public SYS_GROUP_STOCK()
        {

        }

        public SYS_GROUP_STOCK(string GroupID, string StockID, bool Active)
        {
            m_GroupID = GroupID;
            m_StockID = StockID;
            m_Active = Active;
        }
        #endregion

        #region Properties
        public string GroupID
        {
            get
            {
                return m_GroupID;
            }
            set
            {
                m_GroupID = value;
            }
        }
        public string Stock_ID
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
                return "Class SYS_GROUP_STOCK";
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

        public string Get()
        {
            return Get(m_GroupID, m_StockID);
        }
        public string Get(SqlTransaction myTransaction)
        {
            return Get(myTransaction, m_GroupID, m_StockID);
        }
        public string Get(string GroupID, string StockID)
        {
            string Result = "";
            string[] myPara = { "@GroupID", "@StockID" };
            object[] myValue = { GroupID, StockID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader(Query_Get, myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_GroupID = Convert.ToString(myReader["GroupID"]);
                    m_StockID = Convert.ToString(myReader["StockID"]);
                    m_Active = Convert.ToBoolean(myReader["Active"]);
                    Result = "OK";
                }
                myReader.Close();
                mySql.Close();
                myReader = null;
            }
            return Result;
        }
        
        public string Get(SqlTransaction myTransaction, string GroupID, string StockID)
        {
            string Result = "";
            string[] myPara = { "@GroupID", "@StockID" };
            object[] myValue = { GroupID, StockID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            SqlDataReader myReader = mySql.ExecuteReader(myTransaction, Query_Get, myPara, myValue);
            if (myReader != null)
            {
                while (myReader.Read())
                {
                    m_GroupID = Convert.ToString(myReader["GroupID"]);
                    m_StockID = Convert.ToString(myReader["StockID"]);
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
            return Insert(m_GroupID, m_StockID, m_Active);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            return Insert(myTransaction, m_GroupID, m_StockID, m_Active);
        }

        public string Insert(string GroupID, string StockID, bool Active)
        {
            string[] myPara = { "@GroupID", "@StockID", "@Active" };
            object[] myValue = { GroupID, StockID, Active };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(Query_Insert, myPara, myValue);
        }

        public string Insert(SqlTransaction myTransaction, string GroupID, string StockID, bool Active)
        {
            string[] myPara = { "@GroupID", "@StockID", "@Active" };
            object[] myValue = { GroupID, StockID, Active };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction, Query_Insert, myPara, myValue);
        }
        #endregion

        #region Delete
        public string Delete()
        {
            return Delete(m_GroupID, m_StockID);
        }

        public string Delete(SqlTransaction myTransaction)
        {
            return Delete(myTransaction, m_GroupID, m_StockID);
        }

        public string Delete(string GroupID, string StockID)
        {
            string[] myPara = { "@GroupID", "@StockID" };
            object[] myValue = { GroupID, StockID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(Query_Delete, myPara, myValue);
        }

        //extra crisis
        public string DeleteByGroup(string GroupID)
        {
            string[] myPara = { "@GroupID" };
            object[] myValue = { GroupID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(Query_DeleteByGroup, myPara, myValue);
        }
        public string DeleteByStock(string StockID)
        {
            string[] myPara = { "@StockID" };
            object[] myValue = { StockID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(Query_DeleteByStock, myPara, myValue);
        }
        //

        public string Delete(SqlTransaction myTransaction, string GroupID, string StockID)
        {
            string[] myPara = { "@GroupID", "@StockID" };
            object[] myValue = { GroupID, StockID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteNonQuery(myTransaction, Query_Delete, myPara, myValue);
        }
        #endregion

        #region GetList

        public DataTable GetList()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(Query_GetList);
        }

        public DataTable GetListInit(string GroupID)
        {
            #region Query
            string myQuery = @"SELECT f.GroupID,
       f.StockID,
       s.Stock_Name AS StockName,
       s.[Address],
       f.[Active]
FROM   (
           SELECT ISNULL(a.GroupID, b.GroupID) AS GroupID,
                  ISNULL(a.StockID, b.StockID) AS StockID,
                  ISNULL(a.[Active], b.[Active]) AS [Active]
           FROM   (
                      SELECT *
                      FROM   SYS_GROUP_STOCK sgs
                      WHERE  sgs.GroupID = @GroupID
                  )a
                  FULL OUTER JOIN (
                           SELECT @GroupID AS GroupID,
                                  s.Stock_ID AS StockID,
                                  CAST(0 AS BIT) AS [Active]
                           FROM   STOCK s
                       )b
                       ON  a.GroupID = b.GroupID
                       AND a.StockID = b.StockID
       )f
       INNER JOIN STOCK s
            ON  f.StockID = s.Stock_ID";
            #endregion

            string[] myPara = { "@GroupID" };
            object[] myValue = { GroupID };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            return mySql.ExecuteDataTable(myQuery, myPara, myValue);
        }
        
        #endregion

        #region Query
        private string Query_Get
        {
            get { return @"SELECT * FROM SYS_GROUP_STOCK sgs WHERE sgs.GroupID = @GroupID AND sgs.StockID = @StockID"; }
        }

        private string Query_GetList
        {
            get { return @"SELECT * FROM SYS_GROUP_STOCK sgs"; }
        }

        private string Query_Insert
        {
            get
            {
                return @"INSERT INTO SYS_GROUP_STOCK
                        (
                            GroupID,
                            StockID,
                            [Active]
                        )
                        VALUES
                        (
                            @GroupID,
                            @StockID,
                            @Active
                        )";
            }
        }

        private string Query_Update
        {
            get
            {
                return @"UPDATE SYS_GROUP_STOCK
                        SET    [Active]      = @Active
                        WHERE  GroupID      = @GroupID
                               AND StockID  = @StockID";
            }
        }

        private string Query_Delete
        {
            get
            {
                return @"DELETE FROM SYS_GROUP_STOCK
                        WHERE  GroupID      = @GroupID
                               AND StockID  = @StockID";
            }
        }

        private string Query_DeleteByGroup
        {
            get
            {
                return @"DELETE FROM SYS_GROUP_STOCK WHERE GroupID = @GroupID";
            }
        }

        private string Query_DeleteByStock
        {
            get
            {
                return @"DELETE FROM SYS_GROUP_STOCK WHERE StockID = @StockID";
            }
        }
        #endregion
    }
}
