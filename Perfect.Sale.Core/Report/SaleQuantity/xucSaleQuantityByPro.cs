using System;
using System.Windows.Forms;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using DevExpress.XtraBars;
using System.Data;
using DevExpress.XtraReports.UI;

namespace Perfect.Sale.Core.Report.SaleQuantity
{
    public partial class xucSaleQuantityByPro : xucBasicListL3
    {
        public xucSaleQuantityByPro(ListType style)
        {
            InitializeComponent();
            //Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            if (style == ListType.Detail)
            {
                DetailView();
            }
            Init();
        }

        private new void Init()
        {
            base.Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            //EmpInit();
            //Reload();
        }

        public override void Reload()
        {
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            string[] myPara = { "@FromDate", "@ToDate", "@StockID" };
            object[] myValue = { Bar.From, Bar.To, "All" };

            #region query old
            /*
            string query = @"SELECT rs.ProductID AS [MaSP],
       rs.ProductName AS [TenSP],
       rs.Unit,
       rs.Unit_Name AS [DVT],
       rs.StockID,
       rs.Stock_Name,
       rs.OutQuantity AS [TotalQtySold],
       rs.OutAmount AS [TriGiaNhap],
       rs.OutAmountReal AS [DoanhSoBan],
       rs.OutAmountReal - rs.OutAmount AS [LoiNhuan],
       rs.Active,
       rs.ActiveInt
FROM   (
           SELECT EP.Product_ID AS ProductID,
                  p.Product_Name AS ProductName,
                  p.[Active],
                  CAST(p.[Active] AS INT) AS ActiveInt,
                  p.Unit,
                  u.Unit_Name,
                  EP.Stock_ID AS StockID,
                  s.Stock_Name,
                  p.Product_Group_ID AS ProductGroupID,
                  pg.ProductGroup_Name,
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
                  EP.OutAmount AS OutAmountReal,
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
                             (EE.OpenQuantity + EE.TotalQuantityInward) AS 
                             TotalOpIQuantity,
                             (EE.OpenAmount + EE.TotalAmountInward) AS 
                             TotalOpIAmount,
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
                                             WHEN IP.TotalQuantityInward IS NULL THEN 
                                                  0
                                             ELSE IP.TotalQuantityInward
                                        END AS TotalQuantityInward,
                                        CASE 
                                             WHEN IP.TotalAmountInward IS NULL THEN 
                                                  0
                                             ELSE IP.TotalAmountInward
                                        END AS TotalAmountInward,
                                        CASE 
                                             WHEN IP.TotalQuantityOutward IS 
                                                  NULL THEN 0
                                             ELSE IP.TotalQuantityOutward
                                        END AS TotalQuantityOutward,
                                        CASE 
                                             WHEN IP.TotalAmountOutward IS NULL THEN 
                                                  0
                                             ELSE IP.TotalAmountOutward
                                        END AS TotalAmountOutward
                                 FROM   (
                                            SELECT a.Product_ID,
                                                   a.Stock_ID,
                                                   SUM(a.Inward) AS 
                                                   TotalQuantityInward,
                                                   SUM(a.AmountInward) AS 
                                                   TotalAmountInward,
                                                   SUM(a.Outward) AS 
                                                   TotalQuantityOutward,
                                                   SUM(a.AmountOutward) AS 
                                                   TotalAmountOutward
                                            FROM   (
                                                       SELECT id.Product_ID,
                                                              id.Stock_ID,
                                                              id.RefStatus,
                                                              CASE id.RefStatus
                                                                   WHEN 1 THEN 
                                                                        id.Quantity
                                                                   ELSE 0
                                                              END AS Inward,
                                                              CASE id.RefStatus
                                                                   WHEN 1 THEN (id.Price * id.Quantity)
                                                                   ELSE 0
                                                              END AS 
                                                              AmountInward,
                                                              CASE id.RefStatus
                                                                   WHEN 2 THEN 
                                                                        id.Quantity
                                                                   ELSE 0
                                                              END AS Outward,
                                                              CASE id.RefStatus
                                                                   WHEN 2 THEN (id.Price * id.Quantity)
                                                                   ELSE 0
                                                              END AS 
                                                              AmountOutward
                                                       FROM   INVENTORY_DETAIL 
                                                              id
                                                       WHERE  DATEDIFF(DAY, @FromDate, id.RefDate) 
                                                              >= 0
                                                              AND DATEDIFF(DAY, @ToDate, id.RefDate) 
                                                                  <= 0
                                                              AND id.RefType != 
                                                                  0
                                                              AND (
                                                                      id.Stock_ID 
                                                                      = @Stock_Id
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
                                                   )a
                                            GROUP BY
                                                   a.Product_ID,
                                                   a.Stock_ID
                                        ) IP
                                        FULL OUTER JOIN (
                                                 SELECT b.Product_ID,
                                                        b.Stock_ID,
                                                        SUM(b.RealQuantity) AS 
                                                        OpenQuantity,
                                                        SUM(b.RealAmount) AS 
                                                        OpenAmount
                                                 FROM   (
                                                            SELECT id1.Product_ID,
                                                                   id1.Stock_ID,
                                                                   id1.RefStatus,
                                                                   CASE id1.RefStatus
                                                                        WHEN 1 THEN 
                                                                             id1.Quantity
                                                                        ELSE (id1.Quantity * - 1)
                                                                   END AS 
                                                                   RealQuantity,
                                                                   CASE id1.RefStatus
                                                                        WHEN 1 THEN (p.Price * id1.Quantity)
                                                                        ELSE ((p.Price * id1.Quantity) * - 1)
                                                                   END AS 
                                                                   RealAmount
                                                            FROM   
                                                                   INVENTORY_DETAIL 
                                                                   id1
                                                                   LEFT JOIN (
                                                                            SELECT 
                                                                                   AA.Product_ID,
                                                                                   CASE 
                                                                                        WHEN 
                                                                                             SUM(AA.Quantity) 
                                                                                             IS 
                                                                                             NULL
                                                                            OR 
                                                                               SUM(AA.Quantity) 
                                                                               =
                                                                               0 
                                                                               THEN 
                                                                               0
                                                                               ELSE 
                                                                               SUM(AA.Amount) 
                                                                               /
                                                                               SUM(AA.Quantity) 
                                                                               END 
                                                                               AS 
                                                                               Price
                                                                               FROM (
                                                                                   SELECT 
                                                                                          id2.Product_ID,
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
                                                                               )
                                                                               AA
                                                                               GROUP 
                                                                               BY
                                                                               AA.Product_ID
                                                                        ) P
                                                                        ON  id1.Product_ID = 
                                                                            P.Product_ID
                                                            WHERE  (
                                                                       DATEDIFF(DAY, @FromDate, id1.RefDate) 
                                                                       < 0
                                                                       OR id1.RefType 
                                                                          =
                                                                          0
                                                                   )
                                                                   AND (
                                                                           id1.Stock_ID 
                                                                           = @Stock_Id
                                                                           OR 1 
                                                                              = CASE 
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
                       ON  pg.ProductGroup_ID = p.Product_Group_ID
       )rs";
             */
            #endregion

            #region query new
            string sql = @"SELECT EP.Product_ID AS ProductID,
       p.Product_Name AS ProductName,
       p.Unit,
       u.Unit_Name,
       p.Product_Group_ID AS ProductGroupID,
       pg.ProductGroup_Name,
       EP.Stock_ID AS StockID,
       s.Stock_Name,
       EP.OpenQuantity,
       EP.OpenQuantity * EP.UnitPrice_INTI_AVG AS OpenAmount,
       EP.IN_Quantity AS InQuantity,
       EP.IN_Amount AS InAmount,
       EP.OUT_Quantity * EP.UnitPrice_AVG AS OutAmount,
       EP.OUT_Amount AS OutAmountReal,
       EP.OUT_Quantity AS OutQuantity,
       (EP.OpenQuantity + Ep.IN_Quantity - EP.OUT_Quantity) AS TotalIOQuantity,
       (EP.OpenQuantity + Ep.IN_Quantity - EP.OUT_Quantity) * EP.UnitPrice_AVG AS TotalIOAmount,
       EP.OUT_Amount - (EP.OUT_Quantity * EP.UnitPrice_AVG) AS ProfitAmount,
       EP.UnitPrice_AVG AS AVGPrice
FROM   (
           SELECT TEMP_1.Product_ID,
                  TEMP_1.Stock_ID,
                  TEMP_1.IN_INIT_Quantity - TEMP_1.OUT_INIT_Quantity AS OpenQuantity,
                  TEMP_1.IN_Quantity,
                  TEMP_1.OUT_Quantity,
                  TEMP_1.OUT_Amount,
                  TEMP_1.IN_INIT_Amount,
                  TEMP_1.IN_Amount,
                  CASE 
                       WHEN (IN_INIT_Quantity) = 0 THEN 0
                       ELSE TEMP_1.IN_INIT_Amount / (IN_INIT_Quantity)
                  END AS UnitPrice_INTI_AVG,
                  CASE 
                       WHEN (TEMP_1.IN_INIT_Quantity + TEMP_1.IN_Quantity) 
                            = 0 THEN 0
                       ELSE (TEMP_1.IN_INIT_Amount + TEMP_1.IN_Amount) 
                            / (TEMP_1.IN_INIT_Quantity + TEMP_1.IN_Quantity)
                  END AS UnitPrice_AVG
           FROM   (
                      SELECT id.Product_ID,
                             id.Stock_ID,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 1
                                 AND (DATEDIFF(DAY, @FromDate, id.RefDate) < 0 OR id.RefType = 0) 
                                     THEN 
                                     id.Quantity 
                                     ELSE 0 
                                     END
                             ) AS IN_INIT_Quantity,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 2
                                 AND (DATEDIFF(DAY, @FromDate, id.RefDate) < 0) 
                                     THEN id.Quantity 
                                     ELSE 0 
                                     END
                             ) AS OUT_INIT_Quantity,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 1
                                 AND DATEDIFF(DAY, @FromDate, id.RefDate) 
                                     >= 0
                                 AND DATEDIFF(DAY, @ToDate, id.RefDate) 
                                     <= 0
                                 AND id.RefType != 0 THEN id.Quantity 
                                     ELSE 0 
                                     END
                             ) AS IN_Quantity,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 2 AND id.RefType = 2
                                 AND DATEDIFF(DAY, @FromDate, id.RefDate) 
                                     >= 0
                                 AND DATEDIFF(DAY, @ToDate, id.RefDate) 
                                     <= 0 
                                     THEN id.Quantity 
                                     ELSE 0 
                                     END
                             ) AS OUT_Quantity,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 2 AND id.RefType = 2
                                 AND DATEDIFF(DAY, @FromDate, id.RefDate) 
                                     >= 0
                                 AND DATEDIFF(DAY, @ToDate, id.RefDate) 
                                     <= 0 
                                     THEN (id.Price * id.Quantity)
                                     ELSE 0 
                                     END
                             ) AS OUT_Amount,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 1
                                 AND (DATEDIFF(DAY, @FromDate, id.RefDate) < 0 OR id.RefType = 0) 
                                     THEN (id.Price * id.Quantity) 
                                     ELSE 0 
                                     END
                             ) AS IN_INIT_Amount,
                             SUM(
                                 CASE 
                                      WHEN id.RefStatus = 1
                                 AND (
                                         DATEDIFF(DAY, @FromDate, id.RefDate) 
                                         >=
                                         0
                                         AND DATEDIFF(DAY, @ToDate, id.RefDate) 
                                             <= 0
                                         AND id.RefType != 0
                                     ) THEN (id.Price * id.Quantity) 
                                     ELSE 0 
                                     END
                             ) AS IN_Amount
                      FROM   INVENTORY_DETAIL id
                      WHERE  (
                                 id.Stock_ID = @StockID
                                 OR 1 = CASE 
                                             WHEN @StockID = 'All' THEN 1
                                             ELSE 0
                                        END
                             )
                             AND (DATEDIFF(DAY, @ToDate, id.RefDate) <= 0 OR id.RefType = 0)
                      GROUP BY
                             id.Product_ID,
                             id.Stock_ID
                  )TEMP_1
           WHERE TEMP_1.OUT_Quantity <> 0
       )EP
       LEFT OUTER JOIN PRODUCT p
            ON  EP.Product_ID = p.Product_ID
       LEFT OUTER JOIN UNIT u
            ON  u.Unit_ID = p.Unit
       LEFT OUTER JOIN PRODUCT_GROUP pg
            ON  pg.ProductGroup_ID = p.Product_Group_ID
       LEFT OUTER JOIN STOCK s
            ON  s.Stock_ID = EP.Stock_ID
ORDER BY
       EP.Product_ID";
            #endregion

            DataTable dt = mySql.ExecuteDataTable(sql, myPara, myValue);
            dsSaleQuantity.SaleByProduct.Clear();
            dsSaleQuantity.SaleByProduct.Merge(dt);

            gbList.ExpandAllGroups();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            SysLog.Insert("Báo cáo bán hàng theo theo hàng hóa", "Xuất");
            return true;
        }

        private void GbListCustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
        
        protected override void Print()
        {
            

            //string from = SysOption.Language == "VN" ? "Từ " : "From ";
            //string to = SysOption.Language == "VN" ? " đến " : " to ";
            SysLog.Insert("Báo Cáo Lợi Nhuận", "In");
            rptSaleQuantityByEmp rpt = new rptSaleQuantityByEmp(dsSaleQuantity,
                @"Báo Cáo Lợi Nhuận", "");
            rpt.ShowPreview();

        }
        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(gbList.RowCount == 0 ? true : false);
            //DisableMenu(false);
            //if (gbList.RowCount == 0)
            //{
            //    DisableMenu(true);
            //    return;
            //}

            //object arg = gbList.GetFocusedRowCellValue("MaSP");
            //Bar.Bar.bbiProduct.Enabled = false;
            //if (arg != null)
            //{
            //    Bar.Bar.bbiProduct.Enabled = true;
            //}
        }


    }
}