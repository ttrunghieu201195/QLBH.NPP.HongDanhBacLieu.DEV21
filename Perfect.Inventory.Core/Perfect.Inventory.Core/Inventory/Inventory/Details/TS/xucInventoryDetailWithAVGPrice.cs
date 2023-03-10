using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary;
using Perfect.ERP;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Report;
using Perfect.Net.Info;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;

namespace Perfect.Inventory.Core.Inventory.Inventory.Details.TS
{
    public partial class xucInventoryDetailWithAVGPrice : xucDetailList
    {
        public xucInventoryDetailWithAVGPrice()
        {
            InitializeComponent();
            Init();
        }

        private new void Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");

            StockInit();
            UnitInit();
            Bar.All = true;
            Bar.Stock_Init();
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            DoHide();
            Cursor.Current = Cursors.Default;
        }


        private void StockInit()
        {
            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsSTOCK.STOCK);
        }

        private void UnitInit()
        {
            var adapter = new UNITTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsUnit.UNIT);
        }


        protected override void StockChanged(object value)
        {
            Reload();
        }

        public override void Reload()
        {
            Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData(Bar.Id, Bar.Text);
            DoHide();
            Cursor.Current = Cursors.Default;
            Enabled = true;
        }

        public void SetData(string productID, string productName)
        {
            Cursor.Current = Cursors.WaitCursor;
            SysLog.Insert("Tồn Kho", "Xem");

            if (!MyRule.IsAccess("bbiInventory")) return;
            if (Bar.Stock == "")
            {
                return;
            }

            //gbList.Columns[colStock_Name.FieldName].OptionsColumn.AllowGroup = Bar.Stock == "All"
            //                                                                       ? DefaultBoolean.True
            //                                                                       : DefaultBoolean.False;

            if (Bar.Stock == "All")
            {
                colStock_Name.OptionsColumn.AllowGroup = DefaultBoolean.True;
                colStock_Name.GroupIndex = 0;
            }
            else
            {
                colStock_Name.OptionsColumn.AllowGroup = DefaultBoolean.False;
                colStock_Name.GroupIndex = -1;
            
            }
            



            //iNVENTORYTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //iNVENTORYTableAdapter.Fill(dsInventory.INVENTORY_GetFull, Bar.Stock, "%" + productID + "%",
            //                           "%" + productName + "%", false);

            #region query

            string sql = @"DECLARE @DetailTb TABLE( 
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
           DECLARE @StockID_Temp VARCHAR(250) 
           DECLARE @E_Amount MONEY  
           DECLARE @E_Quantity MONEY  
           DECLARE @Pre_E_Quantity MONEY  
           DECLARE @E_UnitPrice MONEY  
                        
           SET @ProductID_Temp = '' 
           SET @StockID_Temp = '' 
           SET @E_Amount = 0  
           SET @E_Quantity = 0  
           SET @Pre_E_Quantity = 0  
           SET @E_UnitPrice = 0  
                        
                      -- ket thuc khai bao bien tam  
                        
           DECLARE @getInventoryDetail CURSOR  
            
           IF (@StockID = 'All') 
           BEGIN 
               SET @getInventoryDetail =  CURSOR FOR  
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
                          WHERE  --id.Stock_ID = @StockID 
                                 --       AND  
                                 id.RefType = 0  
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
                          WHERE  --id.Stock_ID = @StockID 
                                 --       AND  
                                 id.RefType != 0 
                      )IN_DETAIL 
                      LEFT OUTER JOIN TRANS_REF tr 
                           ON  IN_DETAIL.RefNo = tr.RefID 
                           AND IN_DETAIL.RefType = tr.RefType 
               ORDER BY 
                      IN_DETAIL.Product_ID, 
                      IN_DETAIL.Stock_ID, 
                      IN_DETAIL.TempRefDate ASC, 
                      IN_DETAIL.RefDate ASC, 
                      tr.Sorted ASC, 
                      IN_DETAIL.Sorted ASC 
           END 
           ELSE 
           BEGIN 
               SET @getInventoryDetail =  CURSOR FOR  
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
                      )IN_DETAIL 
                      LEFT OUTER JOIN TRANS_REF tr 
                           ON  IN_DETAIL.RefNo = tr.RefID 
                           AND IN_DETAIL.RefType = tr.RefType 
               ORDER BY 
                      IN_DETAIL.Product_ID, 
                      IN_DETAIL.Stock_ID, 
                      IN_DETAIL.TempRefDate ASC, 
                      IN_DETAIL.RefDate ASC, 
                      tr.Sorted ASC, 
                      IN_DETAIL.Sorted ASC 
           END 
                      OPEN @getInventoryDetail  
                      FETCH NEXT  
                      FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType,  
           @RefStatus,   
                      @Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted  
           WHILE @@FETCH_STATUS = 0 
           BEGIN 
               IF ( 
                      @ProductID_Temp = @Product_ID 
                      AND @StockID_Temp = @Stock_ID 
                  ) 
               BEGIN 
                   SET @Pre_E_Quantity = @E_Quantity  
                    
                   SET @E_Quantity = @E_Quantity + CASE  
                                                        WHEN @RefStatus = 1 THEN @Quantity 
                                                        ELSE (@Quantity * -1) 
                                                   END  
                    

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
               SET @StockID_Temp = @Stock_ID 
                
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
            
           SELECT INVEN.Product_ID, 
                  p.Product_Name, 
                  p.Unit, 
                  (SELECT u.Unit_Name FROM UNIT u WHERE u.Unit_ID = p.Unit) AS [Unit_Name],
                  INVEN.Stock_ID, 
                  s.Stock_Name, 
                  pg.ProductGroup_ID, 
                  pg.ProductGroup_Name, 
                  INVEN.Quantity, 
                  CASE  
                       WHEN INVEN.Quantity <= 0 THEN 0 
                       ELSE ( 
                                CASE  
                                     WHEN INVEN.AVGAmount < 0 THEN 0 
                                     ELSE INVEN.AVGAmount / INVEN.Quantity 
                                END 
                            ) 
                  END AS AVGUnitPrice, 
                  CASE  
                       WHEN INVEN.Quantity <= 0 THEN 0 
                       ELSE ( 
                                CASE  
                                     WHEN INVEN.AVGAmount < 0 THEN 0 
                                     ELSE INVEN.AVGAmount 
                                END 
                            ) 
                  END AS AVGAmount,
                  p.[Active],
                  CAST(p.[Active] AS INT) AS [ActiveInt] 
           FROM   ( 
                      SELECT INVEN_TEMP.Product_ID, 
                             INVEN_TEMP.Stock_ID, 
                             SUM(INVEN_TEMP.RealQuantity) AS Quantity, 
                             SUM(INVEN_TEMP.RealAVGAmount) AS AVGAmount 
                      FROM   ( 
                                 SELECT dt.Product_ID, 
                                        dt.Unit, 
                                        dt.Stock_ID, 
                                        CASE  
                                             WHEN dt.RefStatus = 1 THEN dt.Quantity 
                                             ELSE (dt.Quantity * -1) 
                                        END AS RealQuantity, 
                                        CASE  
                                             WHEN dt.RefStatus = 1 THEN dt.AVG_Amount 
                                             ELSE (dt.AVG_Amount * -1) 
                                        END AS RealAVGAmount 
                                 FROM   @DetailTb dt 
                             )INVEN_TEMP 
                      GROUP BY 
                             INVEN_TEMP.Product_ID, 
                             INVEN_TEMP.Stock_ID 
                  )INVEN 
                  LEFT OUTER JOIN PRODUCT p 
                       ON  p.Product_ID = INVEN.Product_ID 
                  LEFT OUTER JOIN STOCK s 
                       ON  s.Stock_ID = INVEN.Stock_ID 
                  LEFT OUTER JOIN PRODUCT_GROUP pg 
                       ON  pg.ProductGroup_ID = p.Product_Group_ID";
            #endregion

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;

            string[] myPara = { "@StockID" };
            object[] myValue = { Bar.Stock };

            dsInventory.INVENTORY_DYNAMIC_AVGPRICE.Clear();
            dsInventory.INVENTORY_DYNAMIC_AVGPRICE.Merge(mySql.ExecuteDataTable(sql, myPara, myValue));

            Cursor.Current = Cursors.Default;
        }

        public override void Print()
        {
            //if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) ||
            //    string.IsNullOrEmpty(MyInfo.Tel))
            //{
            //    XtraMessageBox.Show(
            //        "Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.",
            //        "Thông báo", MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //    return;
            //}
            //SetWaitDialogCaption("Đang nạp dữ liệu...");

            if (!MyRule.IsPrint("bbiInventory")) return;

            SysLog.Insert("Tồn Kho", "In");

            if (dsInventory.INVENTORY_DYNAMIC_AVGPRICE.Rows.Count == 0)
            {
                DoHide();
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var rpt = new rptInventoryAVGPrice(0, "RD0000006", dsInventory.INVENTORY_DYNAMIC_AVGPRICE, "TỒN KHO", "",
                                       gbList.ActiveFilterString);
            rpt.ShowRibbonPreview();

            DoHide();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventory"))
            {
                return false;
            }


            SysLog.Insert("Tồn Kho", "Xuất");

            return base.ExportPermision();
        }


        public override void ProductDetail()
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);


            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
        }

        private void DisableMenu(bool disable)
        {
            Bar.Bar.bbiPrint.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            //if (dsInventory.INVENTORY_GetFull.Rows.Count == 0)
            //{
            //    DisableMenu(true);
            //    return;
            //}
            //AdvBandedGridView view = gbList;
            //var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
            //                               view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
            //                               view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);
            //Bar.Bar.bbiProduct.Enabled = true;
            //if (arg == null)
            //{
            //    Bar.Bar.bbiProduct.Enabled = false;
            //    return;
            //}
        }

        private void GbListCustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            //if (e.SummaryProcess == CustomSummaryProcess.Start)
            //{
            //    double amount = 0.0;
            //    double quantity = 0.0;
            //    for (int i = 0; i < gbList.RowCount; i++)
            //    {
            //        amount +=
            //            Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
            //                                 ? 0
            //                                 : gbList.GetRowCellValue(i, "Amount"));
            //        quantity +=
            //            Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
            //                                 ? 0
            //                                 : gbList.GetRowCellValue(i, "Quantity"));
            //    }

            //    e.TotalValue = amount/quantity;
            //}
        }

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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