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

namespace Perfect.Inventory.Core.Inventory.CarryForward
{
    public class CARRY_FORWARD
    {
        public CARRY_FORWARD()
        {

        }

        public DataTable GetCurrentInventory(DateTime BeginDate)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            #region Execute
            string sql = @"SELECT EP.Product_ID AS ProductID,
       p.Product_Name AS ProductName,
       p.[Active],
       CAST(p.[Active] AS INT) AS ActiveInt,
       p.Unit,
       u.Unit_Name,
       EP.Stock_ID AS StockID,
       s.Stock_Name,
       p.Product_Group_ID AS ProductGroupID,
       pg.ProductGroup_Name,
       p.Org_Price,
       CASE 
            WHEN EP.TotalOpIQuantity = 0 THEN 0
            ELSE (EP.TotalOpIAmount / EP.TotalOpIQuantity)
       END AS [AVGPrice],
       EP.OpenQuantity,
       EP.OpenAmount,
       EP.InQuantity,
       EP.InAmount,
       EP.OutQuantity,
       EP.OutQuantity * ROUND(
           (
               CASE 
                    WHEN EP.TotalOpIQuantity = 0 THEN 0
                    ELSE (EP.TotalOpIAmount / EP.TotalOpIQuantity)
               END
           ),
           2
       ) AS [OutAmount],
       --EP.OutAmount,
       EP.TotalIOQuantity,
       ROUND(
           EP.TotalIOQuantity * (
               CASE 
                    WHEN EP.TotalOpIQuantity = 0 THEN 0
                    ELSE (EP.TotalOpIAmount / EP.TotalOpIQuantity)
               END
           ),
           2
       ) AS TotalIOAmount,
       EP.OutAmount - ROUND(
           EP.OutQuantity * (
               CASE 
                    WHEN EP.TotalOpIQuantity = 0 THEN 0
                    ELSE (EP.TotalOpIAmount / EP.TotalOpIQuantity)
               END
           ),
           2
       ) AS ProfitAmount
FROM   (
           SELECT EE.Product_ID,
                  EE.Stock_ID,
                  EE.OpenQuantity,
                  EE.OpenAmount,
                  EE.TotalQuantityInward AS InQuantity,
                  EE.TotalAmountInward AS InAmount,
                  EE.TotalQuantityOutward AS OutQuantity,
                  EE.TotalAmountOutward AS OutAmount,
                  (EE.OpenQuantity + EE.TotalQuantityInward) AS TotalOpIQuantity,
                  (EE.OpenAmount + EE.TotalAmountInward) AS TotalOpIAmount,
                  (
                      EE.OpenQuantity + EE.TotalQuantityInward - EE.TotalQuantityOutward
                  ) AS TotalIOQuantity
           FROM   (
                      SELECT CASE 
                                  WHEN IP.Product_ID IS NULL THEN FP.Product_ID
                                  ELSE IP.Product_ID
                             END AS Product_ID,
                             CASE 
                                  WHEN IP.Stock_ID IS NULL THEN FP.Stock_ID
                                  ELSE IP.Stock_ID
                             END AS Stock_ID,
                             CASE 
                                  WHEN FP.OpenQuantity IS NULL THEN 0
                                  ELSE FP.OpenQuantity
                             END AS OpenQuantity,
                             CASE 
                                  WHEN FP.OpenAmount IS NULL THEN 0
                                  ELSE FP.OpenAmount
                             END AS OpenAmount,
                             CASE 
                                  WHEN IP.TotalQuantityInward IS NULL THEN 0
                                  ELSE IP.TotalQuantityInward
                             END AS TotalQuantityInward,
                             CASE 
                                  WHEN IP.TotalAmountInward IS NULL THEN 0
                                  ELSE IP.TotalAmountInward
                             END AS TotalAmountInward,
                             CASE 
                                  WHEN IP.TotalQuantityOutward IS NULL THEN 0
                                  ELSE IP.TotalQuantityOutward
                             END AS TotalQuantityOutward,
                             CASE 
                                  WHEN IP.TotalAmountOutward IS NULL THEN 0
                                  ELSE IP.TotalAmountOutward
                             END AS TotalAmountOutward
                      FROM   (
                                 SELECT a.Product_ID,
                                        a.Stock_ID,
                                        SUM(a.Inward) AS TotalQuantityInward,
                                        SUM(a.AmountInward) AS TotalAmountInward,
                                        SUM(a.Outward) AS TotalQuantityOutward,
                                        SUM(a.AmountOutward) AS 
                                        TotalAmountOutward
                                 FROM   (
                                            SELECT id.Product_ID,
                                                   id.Stock_ID,
                                                   id.RefStatus,
                                                   CASE id.RefStatus
                                                        WHEN 1 THEN id.Quantity
                                                        ELSE 0
                                                   END AS Inward,
                                                   CASE id.RefStatus
                                                        WHEN 1 THEN (id.Price * id.Quantity)
                                                        ELSE 0
                                                   END AS AmountInward,
                                                   CASE id.RefStatus
                                                        WHEN 2 THEN id.Quantity
                                                        ELSE 0
                                                   END AS Outward,
                                                   CASE id.RefStatus
                                                        WHEN 2 THEN (id.Price * id.Quantity)
                                                        ELSE 0
                                                   END AS AmountOutward
                                            FROM   INVENTORY_DETAIL id
                                            WHERE  DATEDIFF(DAY, @FromDate, id.RefDate) 
                                                   >= 0
                                                   AND DATEDIFF(DAY, @ToDate, id.RefDate) 
                                                       <= 0
                                                   AND id.RefType != 0
                                                   AND (
                                                           id.Stock_ID = @Stock_Id
                                                           OR 1 = CASE 
                                                                       WHEN @Stock_Id 
                                                                            =
                                                                            'All' THEN 
                                                                            1
                                                                       ELSE 0
                                                                  END
                                                       )
                                        )a
                                 GROUP BY
                                        a.Product_ID,
                                        a.Stock_ID
                             ) IP
                             FULL OUTER JOIN (
                                      SELECT b.Product_ID,
                                             b.Stock_ID,
                                             SUM(b.RealQuantity) AS OpenQuantity,
                                             SUM(b.RealAmount) AS OpenAmount
                                      FROM   (
                                                 SELECT id1.Product_ID,
                                                        id1.Stock_ID,
                                                        id1.RefStatus,
                                                        CASE id1.RefStatus
                                                             WHEN 1 THEN id1.Quantity
                                                             ELSE (id1.Quantity * -1)
                                                        END AS RealQuantity,
                                                        CASE id1.RefStatus
                                                             WHEN 1 THEN (p.Price * id1.Quantity)
                                                             ELSE ((p.Price * id1.Quantity) * -1)
                                                        END AS RealAmount
                                                 FROM   INVENTORY_DETAIL id1
                                                        LEFT JOIN (
                                                                 SELECT AA.Product_ID,
																		AA.Stock_ID,
                                                                        CASE 
                                                                             WHEN 
                                                                                  SUM(AA.Quantity) 
                                                                                  IS 
                                                                                  NULL
                                                                 OR SUM(AA.Quantity) 
                                                                    = 0 THEN 0
                                                                    ELSE SUM(AA.Amount) 
                                                                    / SUM(AA.Quantity) 
                                                                    END AS 
                                                                    Price
                                                                    FROM (
                                                                        SELECT 
                                                                               id2.Product_ID,
                                                                               id2.Stock_ID,
                                                                               id2.Quantity,
                                                                               (id2.Quantity * id2.Price) AS 
                                                                               Amount
                                                                        FROM   
                                                                               INVENTORY_DETAIL 
                                                                               id2
                                                                        WHERE  (
                                                                                   DATEDIFF(DAY, @FromDate, id2.RefDate) 
                                                                                   <
                                                                                   0
                                                                                   OR 
                                                                                      id2.RefType 
                                                                                      =
                                                                                      0
                                                                               )
                                                                               AND 
                                                                                   id2.RefType 
                                                                                   <
                                                                                   >
                                                                                   2
                                                                    )AA
                                                                    GROUP BY
                                                                    AA.Product_ID,
                                                                    AA.Stock_ID
                                                             ) P
                                                             ON  id1.Product_ID = 
                                                                 P.Product_ID
                                                 WHERE  (
                                                            DATEDIFF(DAY, @FromDate, id1.RefDate) 
                                                            < 0
                                                            OR id1.RefType =
                                                               0
                                                        )
                                                        AND (
                                                                id1.Stock_ID = @Stock_Id
                                                                OR 1 = CASE 
                                                                            WHEN 
                                                                                 @Stock_Id 
                                                                                 =
                                                                                 'All' THEN 
                                                                                 1
                                                                            ELSE 
                                                                                 0
                                                                       END
                                                            )
                                             )b
                                      GROUP BY
                                             b.Product_ID,
                                             b.Stock_ID
                                  ) FP
                                  ON  IP.Product_ID = FP.Product_ID AND IP.Stock_ID = FP.Stock_ID
                  )EE
       ) EP
       LEFT OUTER JOIN PRODUCT p
            ON  EP.Product_ID = p.Product_ID
       LEFT OUTER JOIN STOCK s
            ON  EP.Stock_ID = s.Stock_ID
       LEFT OUTER JOIN UNIT u
            ON  u.Unit_ID = p.Unit
       LEFT OUTER JOIN PRODUCT_GROUP pg
            ON  pg.ProductGroup_ID = p.Product_Group_ID";
            #endregion

            DateTime FromDate = BeginDate.AddDays(BeginDate.Day * -1 + 1);
            DateTime ToDate = FromDate.AddMonths(1).AddDays(-1);
            string[] myParams = { "@FromDate", "@ToDate", "@Stock_Id" };
            object[] myValues = { FromDate, ToDate, "All" };
            return mySql.ExecuteDataTable(sql, myParams, myValues);
        }

        public DataTable GetCurrentListDebt(int RefType, DateTime BeginDate)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            string sql = @"SELECT d.CustomerID,
       SUM(d.Balance) AS DebtAmount
FROM   DEBT d
WHERE  d.Balance <> 0
       AND d.RefType = @RefType
       AND DATEDIFF(DAY, d.RefDate, @BeginDate) >=0
GROUP BY
       d.CustomerID";

            string[] myParams = { "@BeginDate", "@RefType" };
            object[] myValues = { BeginDate, RefType };
            return mySql.ExecuteDataTable(sql, myParams, myValues);
        }

        public DataTable GetListCustomerReceiptInvoice(DateTime BeginDate)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            string sql = @"SELECT cr.ID,
       cr.RefID,
       cr.RefDate,
       cr.RefType,
       cr.Amount,
       cr.Description,
       c.Customer_ID,
       c.CustomerName,
       cr.RefOrgNo
FROM   CUSTOMER_RECEIPT cr
       INNER JOIN CUSTOMER c
            ON  cr.CustomerID = c.Customer_ID
WHERE  DATEDIFF(DAY, @BeginDate, cr.RefDate) <= 0
ORDER BY
       cr.Sorted";

            string[] myParams = { "@BeginDate" };
            object[] myValues = { BeginDate };
            return mySql.ExecuteDataTable(sql, myParams, myValues);
        }

        public DataTable GetListProviderReceiptInvoice(DateTime BeginDate)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            string sql = @"SELECT pp.RefDate,
       pp.RefID,
       p.CustomerName,
       p.Customer_ID,
       pp.Amount,
       pp.Discount,
       pp.Description,
       pp.RefType,
       pp.ID,
       pp.RefOrgNo
FROM   PROVIDER_PAYMENT pp
       LEFT OUTER JOIN PROVIDER p
            ON  pp.CustomerID = p.Customer_ID
WHERE  DATEDIFF(DAY, @BeginDate, pp.RefDate) <= 0
ORDER BY
       pp.Sorted";

            string[] myParams = { "@BeginDate" };
            object[] myValues = { BeginDate };
            return mySql.ExecuteDataTable(sql, myParams, myValues);
        }

        public void ExecuteDelete(DateTime BeginDate)
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            #region Query
            string sql = @"      
/*
* ****************************Debt Delete****************************
*/
-- Stage 1_1
DELETE 
FROM   CUSTOMER_RECEIPT_DETAIL
WHERE  ReceiptID IN (SELECT cr.ID
                     FROM   CUSTOMER_RECEIPT cr
                     WHERE  DATEDIFF(DAY, cr.RefDate, @ToDate) >= 0)
       
DELETE 
FROM   PROVIDER_PAYMENT_DETAIL
WHERE  PaymentID IN (SELECT pp.ID
                     FROM   PROVIDER_PAYMENT pp
                     WHERE  DATEDIFF(DAY, pp.RefDate, @ToDate) >= 0)
       
-- Stage 1_2
DELETE 
FROM   TRANS_DEBT
WHERE  RefDetailNo IN (SELECT cr.ID
                       FROM   CUSTOMER_RECEIPT cr
                       WHERE  DATEDIFF(DAY, cr.RefDate, @ToDate) >= 0
                      UNION
                      SELECT pp.ID
                      FROM   PROVIDER_PAYMENT pp
                      WHERE  DATEDIFF(DAY, pp.RefDate, @ToDate) >= 0)
       
-- Stage 2_1
DELETE 
FROM   CUSTOMER_RECEIPT
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
-- Stage 2_2
DELETE 
FROM   PROVIDER_PAYMENT
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
-- Stage 2_3
DELETE 
FROM   DEBT
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
/* 
* **************************** Debt Clear ****************************
*/

/*
* ****************************Inventory Delete****************************
*/
-- Stage 3_1
DELETE 
FROM   INVENTORY_DETAIL
WHERE  RefDetailNo IN (SELECT sod.ID
                       FROM   STOCK_OUTWARD_DETAIL sod
                              LEFT OUTER JOIN STOCK_OUTWARD so
                                   ON  sod.Outward_ID = so.ID
                       WHERE  DATEDIFF(DAY, so.RefDate, @ToDate) >= 0
                      UNION
                      SELECT sid1.ID
                      FROM   STOCK_INWARD_DETAIL sid1
                             LEFT OUTER JOIN STOCK_INWARD si
                                  ON  sid1.Inward_ID = si.ID
                      WHERE  DATEDIFF(DAY, si.RefDate, @ToDate) >= 0
                      UNION
                      SELECT std.ID
                      FROM   STOCK_TRANSFER_DETAIL std
                             LEFT OUTER JOIN STOCK_TRANSFER st
                                  ON  std.Transfer_ID = st.ID
                      WHERE  DATEDIFF(DAY, st.RefDate, @ToDate) >= 0)
       
--Stage 3_2
DELETE 
FROM   INVENTORY
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
-- Stage 3_3
DELETE 
FROM   STOCK_OUTWARD_DETAIL
WHERE  Outward_ID IN (SELECT so.ID
                      FROM   STOCK_OUTWARD so
                      WHERE  DATEDIFF(DAY, so.RefDate, @ToDate) >= 0)
       
DELETE 
FROM   STOCK_INWARD_DETAIL
WHERE  Inward_ID IN (SELECT si.ID
                     FROM   STOCK_INWARD si
                     WHERE  DATEDIFF(DAY, si.RefDate, @ToDate) >= 0)

DELETE 
FROM   STOCK_TRANSFER_DETAIL
WHERE  Transfer_ID IN (SELECT st.ID
                       FROM   STOCK_TRANSFER st
                       WHERE  DATEDIFF(DAY, st.RefDate, @ToDate) >= 0)
       
-- Stage 3_4
DELETE 
FROM   STOCK_OUTWARD
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
DELETE 
FROM   STOCK_INWARD
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
DELETE 
FROM   STOCK_TRANSFER
WHERE  DATEDIFF(DAY, RefDate, @ToDate) >= 0
       
/*
* ****************************Inventory Clear****************************
*/
DELETE 
FROM   SYS_LOG
WHERE  DATEDIFF(DAY, Created, @ToDate) >= 0";
            #endregion

            string[] myParams = { "@ToDate" };
            object[] myValues = { BeginDate };
            mySql.ExecuteNonQuery(sql, myParams, myValues);
        }
    }
}
