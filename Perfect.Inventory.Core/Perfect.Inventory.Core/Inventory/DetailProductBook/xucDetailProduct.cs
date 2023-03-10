using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using Perfect.Data.Helper;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Inventory.Core.Inventory.DetailProductBook.Report;
using Perfect.Inventory.Core.Class;
using DevExpress.XtraReports.UI;
//using Perfect.Inventory.Core.Inventory.Report.Report;

namespace Perfect.Inventory.Core.Inventory.DetailProductBook
{
    public partial class xucDetailProduct : xucDetailList
    {
        public xucDetailProduct()
        {
            InitializeComponent();
            Init();
            Bar.Stock_Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            //Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        private void Init()
        {
            
        }

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
            if (Bar.Stock=="")
            {
                return;
            }

            #region query

            string sql = "--           DECLARE @StockID VARCHAR(100)  \n"
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
           + "           SELECT *  \n"
           + "           FROM   (  \n"
           + "                      SELECT id.ID,  \n"
           + "                             id.RefNo,  \n"
           + "                             id.RefDate,  \n"
           + "                             --id.RefDetailNo,  \n"
           + "                             id.RefType,  \n"
           + "                             id.RefStatus,  \n"
           + "                             --id.StoreID,  \n"
           + "                             id.Stock_ID,  \n"
           + "                             id.Product_ID,  \n"
           + "                             p.Product_Name,  \n"
           + "                             --id.Customer_ID,  \n"
           + "                             --id.Employee_ID,  \n"
           + "                             id.Unit,  \n"
           + "                             u.Unit_Name,  \n"
           + "                             id.Price,  \n"
           + "                             id.Quantity,  \n"
           + "                             id.AVG_Price,  \n"
           + "                             id.AVG_Amount,  \n"
           + "                             b.[Description],  \n"
           + "                             id.Sorted,  \n"
           + "                             CASE   \n"
           + "                                  WHEN id.RefType = '1' AND id.RefStatus = '1' THEN id.Quantity  \n"
           + "                                  WHEN id.RefType = '9' AND id.RefStatus = '1' THEN id.Quantity \n"
           + "                                  ELSE NULL  \n"
           + "                             END AS SoLuongNhapHang,  \n"
           + "                             CASE   \n"
           + "                                  WHEN id.RefType = '1' AND id.RefStatus = '1' THEN (id.AVG_Amount)  \n"
           + "                                  WHEN id.RefType = '9' AND id.RefStatus = '1' THEN (id.AVG_Amount) \n"
           + "                                  ELSE NULL  \n"
           + "                             END AS ThanhTienNhapHang,  \n"
           + "                             CASE \n"
           + "                                  WHEN id.RefType = '2' AND id.RefStatus = '2' THEN id.Quantity \n"
           + "                                  WHEN id.RefType = '9' AND id.RefStatus = '2' THEN id.Quantity \n"
           + "                                  ELSE NULL  \n"
           + "                             END AS SoLuongXuatHang,  \n"
           + "                             CASE   \n"
           + "                                  WHEN id.RefType = '2' AND id.RefStatus = '2' THEN (id.AVG_Amount) \n"
           + "                                  WHEN id.RefType = '9' AND id.RefStatus = '2' THEN (id.AVG_Amount) \n"
           + "                                  ELSE NULL  \n"
           + "                             END AS ThanhTienXuatHang,  \n"
           + "                             CASE  \n"
           + "                             WHEN id.RefType = '9' AND id.RefStatus = '2' THEN 0 - id.E_Quantity \n"
           + "                                  ELSE id.E_Quantity  \n"
           + "                             END AS SoLuongTonCuoi,--CAST(NULL AS MONEY) AS SoLuongTonCuoi,  \n"
           + "                             CASE  \n"
           + "                             WHEN id.RefType = '9' AND id.RefStatus = '2' THEN 0 - id.E_Amount \n"
           + "                                  ELSE id.E_Amount  \n"
           + "                             END AS ThanhTienTonCuoi,--CAST(NULL AS MONEY) AS ThanhTienTonCuoi,  \n"
           + "                             CAST(NULL AS MONEY) AS SoLuongTonDau,  \n"
           + "                             CAST(NULL AS MONEY) AS ThanhTienTonDau,  \n"
           + "                             CASE id.RefStatus  \n"
           + "                                  WHEN 1 THEN id.Quantity  \n"
           + "                                  ELSE (id.Quantity * -1)  \n"
           + "                             END AS RealTempQuantity,  \n"
           + "                             CASE id.RefStatus  \n"
           + "                                  WHEN 1 THEN id.AVG_Amount  \n"
           + "                                  ELSE (id.AVG_Amount * -1)  \n"
           + "                             END AS RealTempAmount  \n"
           + "                      FROM   @DetailTb id  \n"
           + "                             LEFT OUTER JOIN (  \n"
           + "                                      SELECT si.ID,  \n"
           + "                                             si.[Description],  \n"
           + "                                             si.RefType  \n"
           + "                                      FROM   STOCK_INWARD si  \n"
           + "                                      WHERE  DATEDIFF(DAY, @FromDate, si.RefDate) >= 0  \n"
           + "                                             AND DATEDIFF(DAY, @ToDate, si.RefDate) <= 0  \n"
           + "                                      UNION  \n"
           + "                                      SELECT so.ID,  \n"
           + "                                             so.[Description],  \n"
           + "                                             so.RefType  \n"
           + "                                      FROM   STOCK_OUTWARD so  \n"
           + "                                      WHERE  DATEDIFF(DAY, @FromDate, so.RefDate) >= 0  \n"
           + "                                             AND DATEDIFF(DAY, @ToDate, so.RefDate) <= 0  \n"
           + "                                      UNION  \n"
           + "                                      SELECT st.ID,  \n"
           + "                                             st.[Description],  \n"
           + "                                             st.RefType  \n"
           + "                                      FROM   STOCK_TRANSFER st  \n"
           + "                                      WHERE  DATEDIFF(DAY, @FromDate, st.RefDate) >= 0  \n"
           + "                                             AND DATEDIFF(DAY, @ToDate, st.RefDate) <= 0  \n"
           + "                                  ) b  \n"
           + "                                  ON  b.ID = id.RefNo  \n"
           + "                                  AND b.RefType = id.RefType  \n"
           + "                             LEFT OUTER JOIN PRODUCT p  \n"
           + "                                  ON  p.Product_ID = id.Product_ID  \n"
           + "                             LEFT OUTER JOIN UNIT u  \n"
           + "                                  ON  id.Unit = u.Unit_ID  \n"
           + "                      WHERE  id.Stock_ID = @StockId  \n"
           + "                             AND DATEDIFF(DAY, @FromDate, id.RefDate) >= 0  \n"
           + "                             AND DATEDIFF(DAY, @ToDate, id.RefDate) <= 0  \n"
           + "                             AND id.RefType != 0  \n"
           + "                        \n"
           + "                      UNION  \n"
           + "                        \n"
           + "                      SELECT CAST(NULL AS BIGINT) AS ID,  \n"
           + "                             CAST(NULL AS VARCHAR) AS RefNo,  \n"
           + "                             CAST(NULL AS DATETIME) AS RefDate,  \n"
           + "                             --CAST(NULL AS UNIQUEIDENTIFIER) AS RefDetailNo,  \n"
           + "                             CAST(NULL AS INT) AS RefType,  \n"
           + "                             CAST(NULL AS INT) AS RefStatus,  \n"
           + "                             --CAST(NULL AS BIGINT) AS StoreID,  \n"
           + "                             a.Stock_ID,  \n"
           + "                             a.Product_ID,  \n"
           + "                             p.Product_Name,  \n"
           + "                             --'' AS Customer_ID,  \n"
           + "                             --'' AS Employee_ID,  \n"
           + "                             a.Unit,  \n"
           + "                             u.Unit_Name,  \n"
           + "                             CAST(NULL AS MONEY) AS Price,  \n"
           + "                             a.RealQuantity AS Quantity,  \n"
           + "                             CASE a.RealQuantity  \n"
           + "                                  WHEN 0 THEN 0  \n"
           + "                                  ELSE (a.RealAmount / a.RealQuantity)  \n"
           + "                             END AS AVG_Price,  \n"
           + "                             a.RealAmount AS AVG_Amount,  \n"
           + "                             N'Tồn đầu kỳ' AS [Description],  \n"
           + "                             CAST(NULL AS BIGINT) AS Sorted,  \n"
           + "                             CAST(NULL AS MONEY) AS SoLuongNhapHang,  \n"
           + "                             CAST(NULL AS MONEY) AS ThanhTienNhapHang,  \n"
           + "                             CAST(NULL AS MONEY) AS SoLuongXuatHang,  \n"
           + "                             CAST(NULL AS MONEY) AS ThanhTienXuatHang,  \n"
           + "                             a.RealQuantity AS SoLuongTonCuoi, --CAST(NULL AS MONEY) AS SoLuongTonCuoi,  \n"
           + "                             a.RealAmount AS ThanhTienTonCuoi,--CAST(NULL AS MONEY) AS ThanhTienTonCuoi,  \n"
           + "                             a.RealQuantity AS SoLuongTonDau,  \n"
           + "                             a.RealAmount AS ThanhTienTonDau,  \n"
           + "                             a.RealQuantity AS RealTempQuantity,  \n"
           + "                             a.RealAmount AS RealTempAmount  \n"
           + "                      FROM   (  \n"
           + "                                 SELECT id.Stock_ID,  \n"
           + "                                        id.Product_ID,  \n"
           + "                                        id.Unit,  \n"
           + "                                        SUM(  \n"
           + "                                            CASE id.RefStatus  \n"
           + "                                                 WHEN 1 THEN id.Quantity  \n"
           + "                                                 ELSE (id.Quantity * -1)  \n"
           + "                                            END  \n"
           + "                                        ) AS RealQuantity,  \n"
           + "                                        SUM(  \n"
           + "                                            CASE id.RefStatus  \n"
           + "                                                 WHEN 1 THEN id.AVG_Amount  \n"
           + "                                                 ELSE (id.AVG_Amount * -1)  \n"
           + "                                            END  \n"
           + "                                        ) AS RealAmount  \n"
           + "                                 FROM   @DetailTb id  \n"
           + "                                 WHERE  id.Stock_ID = @StockId  \n"
           + "                                        AND (DATEDIFF(DAY, @FromDate, id.RefDate) < 0 OR id.RefType = 0)  \n"
           + "                                 GROUP BY  \n"
           + "                                        id.Stock_ID,  \n"
           + "                                        id.Product_ID,  \n"
           + "                                        id.Unit  \n"
           + "                             )a  \n"
           + "                             LEFT OUTER JOIN PRODUCT p  \n"
           + "                                  ON  p.Product_ID = a.Product_ID  \n"
           + "                             LEFT OUTER JOIN UNIT u  \n"
           + "                                  ON  a.Unit = u.Unit_ID  \n"
           + "                      GROUP BY  \n"
           + "                             a.Stock_ID,  \n"
           + "                             a.Product_ID,  \n"
           + "                             a.Unit,  \n"
           + "                             a.RealQuantity,  \n"
           + "                             p.Product_Name,  \n"
           + "                             a.RealAmount,  \n"
           + "                             u.Unit_Name  \n"
           + "                  )f  \n"
           + "           ORDER BY  \n"
           + "                  f.Product_ID,  \n"
           + "                  f.RefDate";

            #endregion

            /*
             --SET  = 'K000001'              
--SET  = '1/1/2000'
--SET  = '12/28/2012'
             */

            string[] myPara = { "@StockID", "@FromDate", "@ToDate" };
            object[] myValue = { Bar.Stock, Bar.From, Bar.To };

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;
            dsDetailProduct.Detail_Product_By_Date.Clear();
            dsDetailProduct.Detail_Product_By_Date.Merge(mySql.ExecuteDataTable(sql, myPara, myValue));

            //dETAIL_PRODUCT_BY_DATE_NEWTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //dETAIL_PRODUCT_BY_DATE_NEWTableAdapter.ClearBeforeFill = true;
            //if(cbAll.Checked)
            //{
            //    dETAIL_PRODUCT_BY_DATE_NEWTableAdapter.Fill(dsReportDetailProduct.DETAIL_PRODUCT_BY_DATE_NEW, Bar.Stock,
            //                                            Bar.From, Bar.To);    
            //}
            //else
            //{
            //    dETAIL_PRODUCT_BY_DATE_NEWTableAdapter.FillBy(dsReportDetailProduct.DETAIL_PRODUCT_BY_DATE_NEW, Bar.Stock,
            //                                            Bar.From, Bar.To);    
            //}
        }
        public override void Print()
        {
            DataTable dt = new DataTable();
            dt = dsDetailProduct.Detail_Product_By_Date.Copy();
            dt.Clear();

            int rowCount = gbList.RowCount;

            for(int i=0;i<rowCount;i++)
            {
                if(gbList.IsDataRow(i))
                {
                    DataRow dr = dt.NewRow();

                    dr["ID"] = gbList.GetRowCellValue(i, "ID");
                    dr["RefNo"] = gbList.GetRowCellValue(i, "RefNo");
                    dr["RefDate"] = gbList.GetRowCellValue(i, "RefDate");
                    //dr["RefDetailNo"] = gbList.GetRowCellValue(i, "RefDetailNo");
                    dr["RefType"] = gbList.GetRowCellValue(i, "RefType");
                    dr["RefStatus"] = gbList.GetRowCellValue(i, "RefStatus");
                    //dr["StoreID"] = gbList.GetRowCellValue(i, "StoreID");
                    dr["Stock_ID"] = gbList.GetRowCellValue(i, "Stock_ID");
                    dr["Product_ID"] = gbList.GetRowCellValue(i, "Product_ID");
                    dr["Product_Name"] = gbList.GetRowCellValue(i, "Product_Name");
                    //dr["Customer_ID"] = gbList.GetRowCellValue(i, "Customer_ID");
                    //dr["Employee_ID"] = gbList.GetRowCellValue(i, "Employee_ID");
                    dr["Unit"] = gbList.GetRowCellValue(i, "Unit");
                    dr["Price"] = gbList.GetRowCellValue(i, "Price");
                    dr["Quantity"] = gbList.GetRowCellValue(i, "Quantity");
                    dr["AVG_Price"] = gbList.GetRowCellValue(i, "AVG_Price");
                    dr["AVG_Amount"] = gbList.GetRowCellValue(i, "AVG_Amount");

                    dr["Description"] = gbList.GetRowCellValue(i, "Description");
                    dr["Sorted"] = gbList.GetRowCellValue(i, "Sorted");
                    dr["SoLuongNhapHang"] = gbList.GetRowCellValue(i, "SoLuongNhapHang");
                    dr["ThanhTienNhapHang"] = gbList.GetRowCellValue(i, "ThanhTienNhapHang");
                    dr["SoLuongXuatHang"] = gbList.GetRowCellValue(i, "SoLuongXuatHang");
                    dr["ThanhTienXuatHang"] = gbList.GetRowCellValue(i, "ThanhTienXuatHang");
                    dr["SoLuongTonCuoi"] = gbList.GetRowCellValue(i, "SoLuongTonCuoi");
                    dr["ThanhTienTonCuoi"] = gbList.GetRowCellValue(i, "ThanhTienTonCuoi");
                    dr["SoLuongTonDau"] = gbList.GetRowCellValue(i, "SoLuongTonDau");
                    dr["ThanhTienTonDau"] = gbList.GetRowCellValue(i, "ThanhTienTonDau");

                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
            }
            var rpt = new rptReportDetailProduct(dt, "", "Sổ Chi Tiết Hàng Hóa",
                                                 " Tên Kho: " + Bar.StockText + "     Từ: " + String.Format("{0:dd/MM/yyyy}", Bar.From) + " đến " +
                                                 String.Format("{0:dd/MM/yyyy}", Bar.To));
            rpt.ShowPreview();

        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            DoHide();
            return base.ExportPermision();

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
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }
        }

        private void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            
            if (e.IsTotalSummary && e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                if (e.Item == colSoLuongTonCuoi.SummaryItem)
                {
                    e.TotalValue = Convert.ToDecimal(colSoLuongTonDau.SummaryItem.SummaryValue)
                        + Convert.ToDecimal(colSoLuongNhapHang.SummaryItem.SummaryValue)
                        - Convert.ToDecimal(colSoLuongXuatHang.SummaryItem.SummaryValue)
                        ;
                }

                if (e.Item == colThanhTienTonCuoi.SummaryItem)
                {
                    e.TotalValue = Convert.ToDecimal(colThanhTienTonDau.SummaryItem.SummaryValue)
                        + Convert.ToDecimal(colThanhTienNhapHang.SummaryItem.SummaryValue)
                        - Convert.ToDecimal(colThanhTienXuatHang.SummaryItem.SummaryValue)
                        ;
                }
            }

            //if (e.IsGroupSummary && e.SummaryProcess == CustomSummaryProcess.Calculate)
            //{
            //    if ((e.Item as GridSummaryItem).FieldName == "SoLuongTonCuoi")
            //    {
            //        //e.TotalValue = Convert.ToDecimal(e.TotalValue) + Convert.ToDecimal(e.GetValue("SoLuongTonDau") == DBNull.Value ? 0 : e.GetValue("SoLuongTonDau"))
            //        //    + Convert.ToDecimal(e.GetValue("SoLuongNhapHang") == DBNull.Value ? 0 : e.GetValue("SoLuongNhapHang"))
            //        //    - Convert.ToDecimal(e.GetValue("SoLuongXuatHang") == DBNull.Value ? 0 : e.GetValue("SoLuongXuatHang"))
            //        //    ;
            //        e.TotalValue = Convert.ToDecimal(100);
            //        //e.GetGroupSummary(e.GroupRowHandle, gbList.GroupSummary[0])
            //    }
            //    //if ((e.Item as GridSummaryItem).FieldName == "ThanhTienTonCuoi")
            //    //{
            //    //    e.TotalValue = Convert.ToDecimal(e.TotalValue) + Convert.ToDecimal(e.GetValue("ThanhTienTonDau") == DBNull.Value ? 0 : e.GetValue("ThanhTienTonDau"))
            //    //        + Convert.ToDecimal(e.GetValue("ThanhTienNhapHang") == DBNull.Value ? 0 : e.GetValue("ThanhTienNhapHang"))
            //    //        - Convert.ToDecimal(e.GetValue("ThanhTienXuatHang") == DBNull.Value ? 0 : e.GetValue("ThanhTienXuatHang"))
            //    //        ;
            //    //}
            //}
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

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbAll.Checked)
            //{
            //    dETAIL_PRODUCT_BY_DATE_NEWTableAdapter.Fill(dsReportDetailProduct.DETAIL_PRODUCT_BY_DATE_NEW, Bar.Stock,
            //                                            Bar.From, Bar.To);
            //}
            //else
            //{
            //    dETAIL_PRODUCT_BY_DATE_NEWTableAdapter.FillBy(dsReportDetailProduct.DETAIL_PRODUCT_BY_DATE_NEW, Bar.Stock,
            //                                            Bar.From, Bar.To);
            //}
        }

    }
}
