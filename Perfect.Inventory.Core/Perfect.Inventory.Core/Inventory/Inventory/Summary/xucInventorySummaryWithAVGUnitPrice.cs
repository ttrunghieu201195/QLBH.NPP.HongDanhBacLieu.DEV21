using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Inventory.Summary.DS.dsSummaryTableAdapters;
using Perfect.Inventory.Report.Report;
using Perfect.Net.Info;
using Strings=Microsoft.VisualBasic.Strings;
using Perfect.Data.Helper;
using Perfect.Inventory.Core.Class;
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    public partial class xucInventorySummaryWithAVGUnitPrice : xucDetailList
    {
        public xucInventorySummaryWithAVGUnitPrice()
        {
            InitializeComponent();
            //Init();
            Bar.Stock_Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        private void Init()
        {
            base.Init();
            //CreateWaitDialog();
            //SetWaitDialogCaption("Đang nạp dữ liệu...");
            //Stock_Init();
            //DoHide();
        }

        //public void Stock_Init()
        //{
        //    var adapter = new STOCKTableAdapter();
        //    adapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
        //    adapter.Fill(dsSTOCK.STOCK);
        //}

        //public void Unit_Init()
        //{
        //    var adapter = new UNITTableAdapter();
        //    adapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
        //    adapter.Fill(dsUnit.UNIT);
        //}
   
        public override void Reload()
        {
            
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xem");
            SetData(Bar.Id,Bar.Text);
            DoHide();
            Cursor.Current = Cursors.Default;
            
        }

        public void SetData(string product_id,string product_name)
        {

            //if (MyRule.IsAccess("bbiInventorySummary")) return;
            if (!MyRule.AllowAccess)
            {
                MyRule.Notify();
                return;
            }


            if (Bar.Stock=="")
            {
               
                return;
            }

            #region query

            string sql =
                "--           DECLARE @StockID VARCHAR(100)  \n"
           + "--           DECLARE @FromDate DATETIME  \n"
           + "--           DECLARE @ToDate DATETIME  \n"
           + "--             \n"
           + "--           SET @StockID = 'K000001'                \n"
           + "--           SET @FromDate = '9/1/2012'  \n"
           + "--           SET @ToDate = '9/30/2012'  \n"
           + "             \n"
           + "           DECLARE @DetailTb TABLE(  \n"
           + "                       ID BIGINT NULL,  \n"
           + "                       RefNo VARCHAR(100) NULL,  \n"
           + "                       TempRefDate DATETIME NULL,  \n"
           + "                       RefDate DATETIME NULL,  \n"
           + "                       RefType INT NULL,  \n"
           + "                       RefStatus INT NULL,  \n"
           + "                       Stock_ID VARCHAR(20) NULL,  \n"
           + "                       Product_ID VARCHAR(20) NULL,  \n"
           + "                       Unit NVARCHAR(50) NULL,  \n"
           + "                       Quantity MONEY NULL,  \n"
           + "                       Price MONEY NULL,  \n"
           + "                       Amount MONEY NULL,  \n"
           + "                       AVG_Price MONEY NULL,  \n"
           + "                       AVG_Amount MONEY NULL,  \n"
           + "                       RealQuantity MONEY NULL,  \n"
           + "                       E_Quantity MONEY NULL,  \n"
           + "                       E_Amount MONEY NULL,  \n"
           + "                       Sorted BIGINT NULL,  \n"
           + "                       RefSorted BIGINT NULL  \n"
           + "                   )  \n"
           + "             \n"
           + "           DECLARE @ID BIGINT  \n"
           + "           DECLARE @RefNo VARCHAR(100)  \n"
           + "           DECLARE @TempRefDate DATETIME  \n"
           + "           DECLARE @RefDate DATETIME  \n"
           + "           DECLARE @RefType INT  \n"
           + "           DECLARE @RefStatus BIGINT  \n"
           + "           DECLARE @Stock_ID VARCHAR(200)  \n"
           + "           DECLARE @Product_ID VARCHAR(250)  \n"
           + "           DECLARE @Unit VARCHAR(100)  \n"
           + "           DECLARE @Quantity MONEY  \n"
           + "           DECLARE @Price MONEY  \n"
           + "           DECLARE @Sorted BIGINT  \n"
           + "           DECLARE @RefSorted BIGINT  \n"
           + "             \n"
           + "             \n"
           + "           -- khai bao bien tam  \n"
           + "           DECLARE @ProductID_Temp VARCHAR(250)  \n"
           + "           DECLARE @E_Amount MONEY  \n"
           + "           DECLARE @E_Quantity MONEY  \n"
           + "           DECLARE @Pre_E_Quantity MONEY  \n"
           + "           DECLARE @E_UnitPrice MONEY  \n"
           + "             \n"
           + "           SET @ProductID_Temp = ''  \n"
           + "           SET @E_Amount = 0  \n"
           + "           SET @E_Quantity = 0  \n"
           + "           SET @Pre_E_Quantity = 0  \n"
           + "           SET @E_UnitPrice = 0  \n"
           + "             \n"
           + "           -- ket thuc khai bao bien tam  \n"
           + "             \n"
           + "           DECLARE @getInventoryDetail CURSOR                  \n"
           + "           SET @getInventoryDetail =                 CURSOR FOR  \n"
           + "             \n"
           + "           /*  \n"
           + "           SELECT id.ID,  \n"
           + "                  DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate,  \n"
           + "                  id.RefStatus,  \n"
           + "                  id.Stock_ID,  \n"
           + "                  id.Product_ID,  \n"
           + "                  id.Unit,  \n"
           + "                  id.Price,  \n"
           + "                  id.Quantity,  \n"
           + "                  id.Sorted  \n"
           + "           FROM   INVENTORY_DETAIL id  \n"
           + "           WHERE  id.Stock_ID = @StockID  \n"
           + "                  --AND id.Product_ID = 'HH000301'  \n"
           + "           ORDER BY  \n"
           + "                  id.Product_ID,  \n"
           + "                  DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC,  \n"
           + "                  id.Sorted ASC  \n"
           + "           */  \n"
           + "             \n"
           + "           SELECT IN_DETAIL.*,  \n"
           + "                  tr.Sorted AS RefSorted  \n"
           + "           FROM   (  \n"
           + "                      SELECT id.ID,  \n"
           + "                             id.RefNo,  \n"
           + "                             CAST(-53690 AS DATETIME) AS TempRefDate,  \n"
           + "                             DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate,  \n"
           + "                             id.RefType,  \n"
           + "                             id.RefStatus,  \n"
           + "                             id.Stock_ID,  \n"
           + "                             id.Product_ID,  \n"
           + "                             id.Unit,  \n"
           + "                             id.Quantity,  \n"
           + "                             id.Price,  \n"
           + "                             id.Sorted  \n"
           + "                      FROM   INVENTORY_DETAIL id  \n"
           + "                      WHERE  id.Stock_ID = @StockID  \n"
           + "                             AND id.RefType = 0  \n"
           + "                      --ORDER BY  \n"
           + "                      --       id.Product_ID,  \n"
           + "                      --       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC,  \n"
           + "                      --       id.Sorted ASC  \n"
           + "                      UNION ALL  \n"
           + "                        \n"
           + "                      SELECT id.ID,  \n"
           + "                             id.RefNo,  \n"
           + "                             DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS TempRefDate,  \n"
           + "                             DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate,  \n"
           + "                             id.RefType,  \n"
           + "                             id.RefStatus,  \n"
           + "                             id.Stock_ID,  \n"
           + "                             id.Product_ID,  \n"
           + "                             id.Unit,  \n"
           + "                             id.Quantity,  \n"
           + "                             id.Price,  \n"
           + "                             id.Sorted  \n"
           + "                      FROM   INVENTORY_DETAIL id  \n"
           + "                      WHERE  id.Stock_ID = @StockID  \n"
           + "                             AND id.RefType != 0  \n"
           + "                                 --ORDER BY  \n"
           + "                                 --       id.Product_ID,  \n"
           + "                                 --       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC,  \n"
           + "                                 --       id.Sorted ASC  \n"
           + "                  )IN_DETAIL  \n"
           + "                  LEFT OUTER JOIN TRANS_REF tr  \n"
           + "                       ON  IN_DETAIL.RefNo = tr.RefID  \n"
           + "                       AND IN_DETAIL.RefType = tr.RefType  \n"
           + "           ORDER BY  \n"
           + "                  IN_DETAIL.Product_ID,  \n"
           + "                  IN_DETAIL.TempRefDate ASC,  \n"
           + "                  IN_DETAIL.RefDate ASC,  \n"
           + "                  tr.Sorted ASC,  \n"
           + "                  IN_DETAIL.Sorted ASC  \n"
           + "             \n"
           + "           OPEN @getInventoryDetail  \n"
           + "           FETCH NEXT  \n"
           + "           FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType, @RefStatus,   \n"
           + "           @Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted  \n"
           + "           WHILE @@FETCH_STATUS = 0  \n"
           + "           BEGIN  \n"
           + "               IF (@ProductID_Temp = @Product_ID)  \n"
           + "               BEGIN  \n"
           + "                   SET @Pre_E_Quantity = @E_Quantity  \n"
           + "                     \n"
           + "                   SET @E_Quantity = @E_Quantity + CASE   \n"
           + "                                                        WHEN @RefStatus = 1 THEN @Quantity  \n"
           + "                                                        ELSE (@Quantity * -1)  \n"
           + "                                                   END  \n"
           + "                     \n"
           + "                   --        IF (@E_Quantity <= 0)  \n"
           + "                   --        BEGIN  \n"
           + "                   --            SET @E_UnitPrice = (  \n"
           + "                   --                    CASE  \n"
           + "                   --                         WHEN @RefStatus = 1 THEN @Price  \n"
           + "                   --                         ELSE (  \n"
           + "                   --                                  CASE  \n"
           + "                   --                                       WHEN @Pre_E_Quantity = 0 THEN 0  \n"
           + "                   --                                       ELSE @E_Amount / @Pre_E_Quantity  \n"
           + "                   --                                  END  \n"
           + "                   --                              )  \n"
           + "                   --                    END  \n"
           + "                   --                )  \n"
           + "                   --  \n"
           + "                   --            SET @E_Amount = 0  \n"
           + "                   --        END  \n"
           + "                   --        ELSE  \n"
           + "                   BEGIN  \n"
           + "                   	IF (@RefStatus = 1)  \n"
           + "                   	BEGIN \n"
           + "                   		IF (@E_Quantity = 0) \n"
           + "                   		BEGIN \n"
           + "                   			SET @E_Amount = 0 \n"
           + "                   		END  \n"
           + "                   		ELSE \n"
           + "                   			BEGIN \n"
           + "                   				SET @E_Amount = @E_Amount + (@Price * @Quantity)  \n"
           + "                   			END \n"
           + "                   	    SET @E_UnitPrice = @Price  \n"
           + "                   	END  \n"
           + "                   	ELSE  \n"
           + "                   	BEGIN  \n"
           + "                   	    SET @E_UnitPrice = CASE   \n"
           + "                   	                            WHEN @Pre_E_Quantity <= 0 THEN 0  \n"
           + "                   	                            ELSE (@E_Amount / @Pre_E_Quantity)  \n"
           + "                   	                       END  \n"
           + "                   	     \n"
           + "                   	    IF (@E_Quantity = 0) \n"
           + "                   		BEGIN \n"
           + "                   			SET @E_Amount = 0 \n"
           + "                   		END  \n"
           + "                   		ELSE \n"
           + "                   			BEGIN \n"
           + "                   				SET @E_Amount = @E_Amount -(@Quantity * @E_UnitPrice) \n"
           + "                   			END \n"
           + "                   	END \n"
           + "                   	  \n"
           + "                   END  \n"
           + "               END  \n"
           + "               ELSE  \n"
           + "               BEGIN  \n"
           + "                   SET @E_Amount = 0  \n"
           + "                   SET @E_Quantity = CASE   \n"
           + "                                          WHEN @RefStatus = 1 THEN @Quantity  \n"
           + "                                          ELSE (@Quantity * -1)  \n"
           + "                                     END  \n"
           + "                     \n"
           + "                   IF (@E_Quantity <= 0)  \n"
           + "                   BEGIN  \n"
           + "                       SET @E_Amount = 0  \n"
           + "                       SET @E_UnitPrice = 0  \n"
           + "                   END  \n"
           + "                   ELSE  \n"
           + "                   BEGIN  \n"
           + "                       IF (@RefStatus = 1)  \n"
           + "                       BEGIN  \n"
           + "                           SET @E_Amount = @E_Amount + (@Price * @Quantity)  \n"
           + "                           SET @E_UnitPrice = @Price  \n"
           + "                       END  \n"
           + "                   END  \n"
           + "               END  \n"
           + "               SET @ProductID_Temp = @Product_ID  \n"
           + "                 \n"
           + "               --    PRINT @Product_ID + ' --- ' + CAST(@E_Quantity AS VARCHAR(100)) + ' --- ' +  \n"
           + "               --    CAST(@Quantity AS VARCHAR(100)) + ' --- ' + CAST(@RefStatus AS VARCHAR(5)) +  \n"
           + "               --    ' --- ' + CAST(@E_Amount AS VARCHAR(100)) + ' --- ' + CAST(@E_UnitPrice AS VARCHAR(100))  \n"
           + "                 \n"
           + "               INSERT INTO @DetailTb  \n"
           + "                 (  \n"
           + "                   ID,  \n"
           + "                   RefNo,  \n"
           + "                   TempRefDate,  \n"
           + "                   RefDate,  \n"
           + "                   RefType,  \n"
           + "                   RefStatus,  \n"
           + "                   Stock_ID,  \n"
           + "                   Product_ID,  \n"
           + "                   Unit,  \n"
           + "                   Quantity,  \n"
           + "                   Price,  \n"
           + "                   Amount,  \n"
           + "                   AVG_Price,  \n"
           + "                   AVG_Amount,  \n"
           + "                   RealQuantity,  \n"
           + "                   E_Quantity,  \n"
           + "                   E_Amount,  \n"
           + "                   Sorted,  \n"
           + "                   RefSorted  \n"
           + "                 )  \n"
           + "               VALUES  \n"
           + "                 (  \n"
           + "                   @ID,  \n"
           + "                   @RefNo,  \n"
           + "                   @TempRefDate,  \n"
           + "                   @RefDate,  \n"
           + "                   @RefType,  \n"
           + "                   @RefStatus,  \n"
           + "                   @Stock_ID,  \n"
           + "                   @Product_ID,  \n"
           + "                   @Unit,  \n"
           + "                   @Quantity,  \n"
           + "                   @Price,  \n"
           + "                   (@Price * @Quantity),  \n"
           + "                   @E_UnitPrice,  \n"
           + "                   (@E_UnitPrice * @Quantity),  \n"
           + "                   CASE   \n"
           + "                        WHEN @RefStatus = 1 THEN @Quantity  \n"
           + "                        ELSE (@Quantity * -1)  \n"
           + "                   END,  \n"
           + "                   @E_Quantity,  \n"
           + "                   @E_Amount,  \n"
           + "                   @Sorted,  \n"
           + "                   @RefSorted  \n"
           + "                 )  \n"
           + "                 \n"
           + "               FETCH NEXT  \n"
           + "               FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType,   \n"
           + "               @RefStatus,   \n"
           + "               @Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted  \n"
           + "           END  \n"
           + "             \n"
           + "           CLOSE @getInventoryDetail  \n"
           + "           DEALLOCATE @getInventoryDetail  \n"
           + "             \n"
           + "--           SELECT dt.ID,  \n"
           + "--                  dt.RefNo,  \n"
           + "--                  dt.TempRefDate,  \n"
           + "--                  dt.RefDate,  \n"
           + "--                  dt.RefType,  \n"
           + "--                  dt.RefStatus,  \n"
           + "--                  dt.Stock_ID,  \n"
           + "--                  dt.Product_ID,  \n"
           + "--                  dt.Unit,  \n"
           + "--                  dt.Quantity,  \n"
           + "--                  dt.Price,  \n"
           + "--                  dt.Amount,  \n"
           + "--                  dt.AVG_Price,  \n"
           + "--                  dt.AVG_Amount,  \n"
           + "--                  dt.RealQuantity,  \n"
           + "--                  dt.E_Quantity,  \n"
           + "--                  dt.E_Amount,  \n"
           + "--                  dt.Sorted,  \n"
           + "--                  dt.RefSorted  \n"
           + "--           FROM   @DetailTb dt  \n"
           + "--                  --WHERE dt.Product_ID = 'HH000223'  \n"
           + "--           ORDER BY  \n"
           + "--                  dt.Product_ID,  \n"
           + "--                  dt.TempRefDate ASC,  \n"
           + "--                  dt.RefDate ASC,  \n"
           + "--                  dt.RefSorted ASC,  \n"
           + "--                  dt.Sorted ASC \n"
           + " SELECT EP.Product_ID AS ProductID, \n"
           + "       p.Product_Name AS ProductName, \n"
           + "       u.Unit_Name, \n"
           + "       EP.Stock_ID AS StockID, \n"
           + "       s.Stock_Name, \n"
           + "       p.Product_Group_ID AS ProductGroupID, \n"
           + "       pg.ProductGroup_Name, \n"
           + "       EP.OpenQuantity, \n"
           + "       EP.OpenAmount, \n"
           + "       EP.OpenAVGAmount, \n"
           + "       EP.TotalQuantityInward AS InQuantity, \n"
           + "       EP.TotalAmountInward AS InAmount, \n"
           + "       EP.TotalAVGAmountInward AS InAVGAmount, \n"
           + "       EP.TotalQuantityOutward AS OutQuantity, \n"
           + "       EP.TotalAmountOutward AS OutAmount, \n"
           + "       EP.TotalAVGAmountOutward AS OutAVGAmount, \n"
           + "       ( \n"
           + "           EP.OpenQuantity + EP.TotalQuantityInward - EP.TotalQuantityOutward \n"
           + "       ) AS OnhandQuantity, \n"
           + "       ( \n"
           + "           EP.OpenAmount + EP.TotalAmountInward - EP.TotalAmountOutward \n"
           + "       ) AS CloseAmount, \n"
           + "       ( \n"
           + "           EP.OpenAVGAmount + EP.TotalAVGAmountInward -  \n"
           + "           EP.TotalAVGAmountOutward \n"
           + "       ) AS CloseAVGAmount \n"
           + "       --       CASE \n"
           + "       --            WHEN ( \n"
           + "       --                     EP.OpenQuantity + EP.TotalQuantityInward - EP.TotalQuantityOutward \n"
           + "       --                 ) <= 0 THEN 0 \n"
           + "       --            ELSE ( \n"
           + "       --                     CASE \n"
           + "       --                          WHEN ( \n"
           + "       --                                   EP.OpenAVGAmount + EP.TotalAVGAmountInward - \n"
           + "       --                                   EP.TotalAVGAmountOutward \n"
           + "       --                               ) <= 0 THEN 0 \n"
           + "       --                          ELSE ( \n"
           + "       --                                   EP.OpenAVGAmount + EP.TotalAVGAmountInward - \n"
           + "       --                                   EP.TotalAVGAmountOutward \n"
           + "       --                               ) \n"
           + "       --                     END \n"
           + "       --                 ) \n"
           + "       --       END AS CloseAVGAmount \n"
           + "FROM   ( \n"
           + "           SELECT CASE  \n"
           + "                       WHEN IP.Product_ID IS NULL THEN FP.Product_ID \n"
           + "                       ELSE IP.Product_ID \n"
           + "                  END AS Product_ID, \n"
           + "                  CASE  \n"
           + "                       WHEN IP.Stock_ID IS NULL THEN FP.Stock_ID \n"
           + "                       ELSE IP.Stock_ID \n"
           + "                  END AS Stock_ID, \n"
           + "                  CASE  \n"
           + "                       WHEN IP.Unit IS NULL THEN FP.Unit \n"
           + "                       ELSE IP.Unit \n"
           + "                  END AS Unit, \n"
           + "                  CASE  \n"
           + "                       WHEN FP.OpenQuantity IS NULL THEN 0 \n"
           + "                       ELSE FP.OpenQuantity \n"
           + "                  END AS OpenQuantity, \n"
           + "                  CASE  \n"
           + "                       WHEN FP.OpenAmount IS NULL THEN 0 \n"
           + "                       ELSE FP.OpenAmount \n"
           + "                  END AS OpenAmount, \n"
           + "                  CASE  \n"
           + "                       WHEN FP.OpenAVGAmount IS NULL THEN 0 \n"
           + "                       ELSE FP.OpenAVGAmount \n"
           + "                  END AS OpenAVGAmount, \n"
           + "           CASE  \n"
           + "                WHEN IP.TotalQuantityInward IS NULL THEN 0 \n"
           + "                ELSE IP.TotalQuantityInward \n"
           + "           END AS TotalQuantityInward, \n"
           + "           CASE  \n"
           + "                WHEN IP.TotalAmountInward IS NULL THEN 0 \n"
           + "                ELSE IP.TotalAmountInward \n"
           + "           END AS TotalAmountInward, \n"
           + "           CASE  \n"
           + "                WHEN IP.TotalAVGAmountInward IS NULL THEN 0 \n"
           + "                ELSE IP.TotalAVGAmountInward \n"
           + "           END AS TotalAVGAmountInward, \n"
           + "           CASE  \n"
           + "                WHEN IP.TotalQuantityOutward IS NULL THEN 0 \n"
           + "                ELSE IP.TotalQuantityOutward \n"
           + "           END AS TotalQuantityOutward, \n"
           + "           CASE  \n"
           + "                WHEN IP.TotalAmountOutward IS NULL THEN 0 \n"
           + "                ELSE IP.TotalAmountOutward \n"
           + "           END AS TotalAmountOutward, \n"
           + "           CASE  \n"
           + "                WHEN IP.TotalAVGAmountOutward IS NULL THEN 0 \n"
           + "                ELSE IP.TotalAVGAmountOutward \n"
           + "           END AS TotalAVGAmountOutward \n"
           + "            \n"
           + "           FROM ( \n"
           + "               SELECT a.Product_ID, \n"
           + "                      a.Stock_ID, \n"
           + "                      a.Unit, \n"
           + "                      SUM(a.Inward) AS TotalQuantityInward, \n"
           + "                      SUM(a.AmountInward) AS TotalAmountInward, \n"
           + "                      SUM(a.AVGAmountInward) AS TotalAVGAmountInward, \n"
           + "                      SUM(a.Outward) AS TotalQuantityOutward, \n"
           + "                      SUM(a.AmountOutward) AS TotalAmountOutward, \n"
           + "                      SUM(a.AVGAmountOutward) AS TotalAVGAmountOutward \n"
           + "               FROM   ( \n"
           + "                          SELECT id.Product_ID, \n"
           + "                                 id.Stock_ID, \n"
           + "                                 id.RefStatus, \n"
           + "                                 id.Unit, \n"
           + "                                 CASE id.RefStatus \n"
           + "                                      WHEN 1 THEN id.Quantity \n"
           + "                                      ELSE 0 \n"
           + "                                 END AS Inward, \n"
           + "                                 CASE id.RefStatus \n"
           + "                                      WHEN 1 THEN (id.Price * id.Quantity) \n"
           + "                                      ELSE 0 \n"
           + "                                 END AS AmountInward, \n"
           + "                                 CASE id.RefStatus \n"
           + "                                      WHEN 1 THEN (id.AVG_Amount) \n"
           + "                                      ELSE 0 \n"
           + "                                 END AS AVGAmountInward, \n"
           + "                                 CASE id.RefStatus \n"
           + "                                      WHEN 2 THEN id.Quantity \n"
           + "                                      ELSE 0 \n"
           + "                                 END AS Outward, \n"
           + "                                 CASE id.RefStatus \n"
           + "                                      WHEN 2 THEN (id.Price * id.Quantity) \n"
           + "                                      ELSE 0 \n"
           + "                                 END AS AmountOutward, \n"
           + "                                 CASE id.RefStatus \n"
           + "                                      WHEN 2 THEN (id.AVG_Amount) \n"
           + "                                      ELSE 0 \n"
           + "                                 END AS AVGAmountOutward \n"
           + "                          FROM   @DetailTb id \n"
           + "                          WHERE  DATEDIFF(DAY, @FromDate, id.RefDate) >= 0 \n"
           + "                                 AND DATEDIFF(DAY, @ToDate, id.RefDate) <= 0 \n"
           + "                                 AND id.RefType != 0 \n"
           + "                                 AND id.Stock_ID = @StockID \n"
           + "                      )a \n"
           + "               GROUP BY \n"
           + "                      a.Product_ID, \n"
           + "                      a.Stock_ID, \n"
           + "                      a.Unit \n"
           + "           ) IP \n"
           + "           FULL OUTER JOIN ( \n"
           + "               SELECT b.Product_ID, \n"
           + "                      b.Unit, \n"
           + "                      b.Stock_ID, \n"
           + "                      SUM(b.RealQuantity) AS OpenQuantity, \n"
           + "                      SUM(b.RealAmount) AS OpenAmount, \n"
           + "                      SUM(b.RealAVGAmount) AS OpenAVGAmount \n"
           + "               FROM   ( \n"
           + "                          SELECT id1.Product_ID, \n"
           + "                                 id1.Stock_ID, \n"
           + "                                 id1.RefStatus, \n"
           + "                                 id1.Unit, \n"
           + "                                 CASE id1.RefStatus \n"
           + "                                      WHEN 1 THEN id1.Quantity \n"
           + "                                      ELSE (id1.Quantity * -1) \n"
           + "                                 END AS RealQuantity, \n"
           + "                                 CASE id1.RefStatus \n"
           + "                                      WHEN 1 THEN (id1.Price * id1.Quantity) \n"
           + "                                      ELSE ((id1.Price * id1.Quantity) * -1) \n"
           + "                                 END AS RealAmount, \n"
           + "                                 CASE id1.RefStatus \n"
           + "                                      WHEN 1 THEN (id1.AVG_Amount) \n"
           + "                                      ELSE (id1.AVG_Amount * -1) \n"
           + "                                 END AS RealAVGAmount \n"
           + "                          FROM   @DetailTb id1 \n"
           + "                          WHERE  ( \n"
           + "                                     DATEDIFF(DAY, @FromDate, id1.RefDate) \n"
           + "                                     < 0 \n"
           + "                                     OR id1.RefType = 0 \n"
           + "                                 ) \n"
           + "                                 AND id1.Stock_ID = @StockID \n"
           + "                      )b \n"
           + "               GROUP BY \n"
           + "                      b.Product_ID, \n"
           + "                      b.Stock_ID, \n"
           + "                      b.Unit \n"
           + "           ) FP \n"
           + "           ON IP.Product_ID = FP.Product_ID \n"
           + "           AND IP.Unit = FP.Unit \n"
           + "       ) EP \n"
           + "       LEFT OUTER JOIN PRODUCT p \n"
           + "            ON  EP.Product_ID = p.Product_ID \n"
           + "       LEFT OUTER JOIN STOCK s \n"
           + "            ON  EP.Stock_ID = s.Stock_ID \n"
           + "       LEFT OUTER JOIN UNIT u \n"
           + "            ON  EP.Unit = u.Unit_ID \n"
           + "       LEFT OUTER JOIN PRODUCT_GROUP pg \n"
           + "            ON  pg.ProductGroup_ID = p.Product_Group_ID";

            #endregion query

            string[] myPara = { "@StockID", "@FromDate", "@ToDate" };
            object[] myValue = { Bar.Stock, Bar.From, Bar.To };
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;
            dsSummary.INVENTORY_DETAIL_SUMMARY_WITH_AVG_UNIT_PRICE.Clear();
            dsSummary.INVENTORY_DETAIL_SUMMARY_WITH_AVG_UNIT_PRICE.Merge(mySql.ExecuteDataTable(sql, myPara, myValue));

        }

        public override void Print()
        {
            //if (!MyRule.IsPrint("bbiInventorySummary")) return;

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";
            SysLog.Insert("Tồn Kho (XNT)", "In");

            if (dsSummary.INVENTORY_DETAIL_SUMMARY_WITH_AVG_UNIT_PRICE.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rpt = new rptInventorySummaryWithAVGUnitPrice(dsSummary.INVENTORY_DETAIL_SUMMARY_WITH_AVG_UNIT_PRICE, "RD0000027", "Tổng Hợp Xuất - Nhập", from + Strings.Format(Bar.From, "dd/MM/yyyy") + to + Strings.Format(Bar.To, "dd/MM/yyyy"), gbList.ActiveFilterString);

            rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xuất");
            DoHide();
            return true;

        }

        public void DisableMenu(bool disable)
        {
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
        }
        
        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if(dsSummary.INVENTORY_DETAIL_SUMMARY_WITH_AVG_UNIT_PRICE.Rows.Count==0)
            {
                DisableMenu(true);
                return;
            }
        }

        private void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

        }
       

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        public override void Copy()
        {
            gbList.CopyToClipboard();
        }
    }
}
