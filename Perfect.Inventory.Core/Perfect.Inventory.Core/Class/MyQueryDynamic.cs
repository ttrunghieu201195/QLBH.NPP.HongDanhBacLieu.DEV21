using System;
using System.Collections.Generic;
using System.Text;

namespace Perfect.Inventory.Core.Class
{
    public class MyQueryDynamic
    {

        public static string BaseQuery()
        {

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
           + "--                  dt.Sorted ASC \n";

            return sql;
        
        }

        /*
         --           DECLARE @StockID VARCHAR(100) 
--           DECLARE @FromDate DATETIME 
--           DECLARE @ToDate DATETIME 
--            
--           SET @StockID = 'K000001'               
--           SET @FromDate = '9/1/2012' 
--           SET @ToDate = '9/30/2012' 
            
           DECLARE @DetailTb TABLE( 
                       ID BIGINT NULL, 
                       RefNo VARCHAR(100) NULL, 
                       TempRefDate DATETIME NULL, 
                       RefDate DATETIME NULL, 
                       RefType INT NULL, 
                       RefStatus INT NULL, 
                       Stock_ID VARCHAR(20) NULL, 
                       Product_ID VARCHAR(20) NULL, 
                       Unit NVARCHAR(50) NULL, 
                       Quantity MONEY NULL, 
                       Price MONEY NULL, 
                       Amount MONEY NULL, 
                       AVG_Price MONEY NULL, 
                       AVG_Amount MONEY NULL, 
                       RealQuantity MONEY NULL, 
                       E_Quantity MONEY NULL, 
                       E_Amount MONEY NULL, 
                       Sorted BIGINT NULL, 
                       RefSorted BIGINT NULL 
                   ) 
            
           DECLARE @ID BIGINT 
           DECLARE @RefNo VARCHAR(100) 
           DECLARE @TempRefDate DATETIME 
           DECLARE @RefDate DATETIME 
           DECLARE @RefType INT 
           DECLARE @RefStatus BIGINT 
           DECLARE @Stock_ID VARCHAR(200) 
           DECLARE @Product_ID VARCHAR(250) 
           DECLARE @Unit VARCHAR(100) 
           DECLARE @Quantity MONEY 
           DECLARE @Price MONEY 
           DECLARE @Sorted BIGINT 
           DECLARE @RefSorted BIGINT 
            
            
           -- khai bao bien tam 
           DECLARE @ProductID_Temp VARCHAR(250) 
           DECLARE @E_Amount MONEY 
           DECLARE @E_Quantity MONEY 
           DECLARE @Pre_E_Quantity MONEY 
           DECLARE @E_UnitPrice MONEY 
            
           SET @ProductID_Temp = '' 
           SET @E_Amount = 0 
           SET @E_Quantity = 0 
           SET @Pre_E_Quantity = 0 
           SET @E_UnitPrice = 0 
            
           -- ket thuc khai bao bien tam 
            
           DECLARE @getInventoryDetail CURSOR                 
           SET @getInventoryDetail =                 CURSOR FOR 
            
           SELECT IN_DETAIL.*, 
                  tr.Sorted AS RefSorted 
           FROM   ( 
                      SELECT id.ID, 
                             id.RefNo, 
                             CAST(-53690 AS DATETIME) AS TempRefDate, 
                             DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate, 
                             id.RefType, 
                             id.RefStatus, 
                             id.Stock_ID, 
                             id.Product_ID, 
                             id.Unit, 
                             id.Quantity, 
                             id.Price, 
                             id.Sorted 
                      FROM   INVENTORY_DETAIL id 
                      WHERE  id.Stock_ID = @StockID 
                             AND id.RefType = 0 
                      --ORDER BY 
                      --       id.Product_ID, 
                      --       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC, 
                      --       id.Sorted ASC 
                      UNION ALL 
                       
                      SELECT id.ID, 
                             id.RefNo, 
                             DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS TempRefDate, 
                             DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate, 
                             id.RefType, 
                             id.RefStatus, 
                             id.Stock_ID, 
                             id.Product_ID, 
                             id.Unit, 
                             id.Quantity, 
                             id.Price, 
                             id.Sorted 
                      FROM   INVENTORY_DETAIL id 
                      WHERE  id.Stock_ID = @StockID 
                             AND id.RefType != 0 
                                 --ORDER BY 
                                 --       id.Product_ID, 
                                 --       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC, 
                                 --       id.Sorted ASC 
                  )IN_DETAIL 
                  LEFT OUTER JOIN TRANS_REF tr 
                       ON  IN_DETAIL.RefNo = tr.RefID 
                       AND IN_DETAIL.RefType = tr.RefType 
           ORDER BY 
                  IN_DETAIL.Product_ID, 
                  IN_DETAIL.TempRefDate ASC, 
                  IN_DETAIL.RefDate ASC, 
                  tr.Sorted ASC, 
                  IN_DETAIL.Sorted ASC 
            
           OPEN @getInventoryDetail 
           FETCH NEXT 
           FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType, @RefStatus,  
           @Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted 
           WHILE @@FETCH_STATUS = 0 
           BEGIN 
               IF (@ProductID_Temp = @Product_ID) 
               BEGIN 
                   SET @Pre_E_Quantity = @E_Quantity 
                    
                   SET @E_Quantity = @E_Quantity + CASE  
                                                        WHEN @RefStatus = 1 THEN @Quantity 
                                                        ELSE (@Quantity * -1) 
                                                   END 
                    
                   --        IF (@E_Quantity <= 0) 
                   --        BEGIN 
                   --            SET @E_UnitPrice = ( 
                   --                    CASE 
                   --                         WHEN @RefStatus = 1 THEN @Price 
                   --                         ELSE ( 
                   --                                  CASE 
                   --                                       WHEN @Pre_E_Quantity = 0 THEN 0 
                   --                                       ELSE @E_Amount / @Pre_E_Quantity 
                   --                                  END 
                   --                              ) 
                   --                    END 
                   --                ) 
                   -- 
                   --            SET @E_Amount = 0 
                   --        END 
                   --        ELSE 
                   BEGIN 
                   	IF (@RefStatus = 1) 
                   	BEGIN
                   		IF (@E_Quantity = 0)
                   		BEGIN
                   			SET @E_Amount = 0
                   		END 
                   		ELSE
                   			BEGIN
                   				SET @E_Amount = @E_Amount + (@Price * @Quantity) 
                   			END
                   	    SET @E_UnitPrice = @Price 
                   	END 
                   	ELSE 
                   	BEGIN 
                   	    SET @E_UnitPrice = CASE  
                   	                            WHEN @Pre_E_Quantity <= 0 THEN 0 
                   	                            ELSE (@E_Amount / @Pre_E_Quantity) 
                   	                       END 
                   	    
                   	    IF (@E_Quantity = 0)
                   		BEGIN
                   			SET @E_Amount = 0
                   		END 
                   		ELSE
                   			BEGIN
                   				SET @E_Amount = @E_Amount -(@Quantity * @E_UnitPrice)
                   			END
                   	END
                   	 
                   END 
               END 
               ELSE 
               BEGIN 
                   SET @E_Amount = 0 
                   SET @E_Quantity = CASE  
                                          WHEN @RefStatus = 1 THEN @Quantity 
                                          ELSE (@Quantity * -1) 
                                     END 
                    
                   IF (@E_Quantity <= 0) 
                   BEGIN 
                       SET @E_Amount = 0 
                       SET @E_UnitPrice = 0 
                   END 
                   ELSE 
                   BEGIN 
                       IF (@RefStatus = 1) 
                       BEGIN 
                           SET @E_Amount = @E_Amount + (@Price * @Quantity) 
                           SET @E_UnitPrice = @Price 
                       END 
                   END 
               END 
               SET @ProductID_Temp = @Product_ID 
                
               --    PRINT @Product_ID + ' --- ' + CAST(@E_Quantity AS VARCHAR(100)) + ' --- ' + 
               --    CAST(@Quantity AS VARCHAR(100)) + ' --- ' + CAST(@RefStatus AS VARCHAR(5)) + 
               --    ' --- ' + CAST(@E_Amount AS VARCHAR(100)) + ' --- ' + CAST(@E_UnitPrice AS VARCHAR(100)) 
                
               INSERT INTO @DetailTb 
                 ( 
                   ID, 
                   RefNo, 
                   TempRefDate, 
                   RefDate, 
                   RefType, 
                   RefStatus, 
                   Stock_ID, 
                   Product_ID, 
                   Unit, 
                   Quantity, 
                   Price, 
                   Amount, 
                   AVG_Price, 
                   AVG_Amount, 
                   RealQuantity, 
                   E_Quantity, 
                   E_Amount, 
                   Sorted, 
                   RefSorted 
                 ) 
               VALUES 
                 ( 
                   @ID, 
                   @RefNo, 
                   @TempRefDate, 
                   @RefDate, 
                   @RefType, 
                   @RefStatus, 
                   @Stock_ID, 
                   @Product_ID, 
                   @Unit, 
                   @Quantity, 
                   @Price, 
                   (@Price * @Quantity), 
                   @E_UnitPrice, 
                   (@E_UnitPrice * @Quantity), 
                   CASE  
                        WHEN @RefStatus = 1 THEN @Quantity 
                        ELSE (@Quantity * -1) 
                   END, 
                   @E_Quantity, 
                   @E_Amount, 
                   @Sorted, 
                   @RefSorted 
                 ) 
                
               FETCH NEXT 
               FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType,  
               @RefStatus,  
               @Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted 
           END 
            
           CLOSE @getInventoryDetail 
           DEALLOCATE @getInventoryDetail 
            
--           SELECT dt.ID, 
--                  dt.RefNo, 
--                  dt.TempRefDate, 
--                  dt.RefDate, 
--                  dt.RefType, 
--                  dt.RefStatus, 
--                  dt.Stock_ID, 
--                  dt.Product_ID, 
--                  dt.Unit, 
--                  dt.Quantity, 
--                  dt.Price, 
--                  dt.Amount, 
--                  dt.AVG_Price, 
--                  dt.AVG_Amount, 
--                  dt.RealQuantity, 
--                  dt.E_Quantity, 
--                  dt.E_Amount, 
--                  dt.Sorted, 
--                  dt.RefSorted 
--           FROM   @DetailTb dt 
--           ORDER BY 
--                  dt.Product_ID, 
--                  dt.TempRefDate ASC, 
--                  dt.RefDate ASC, 
--                  dt.RefSorted ASC, 
--                  dt.Sorted ASC 
         */

    }
}
