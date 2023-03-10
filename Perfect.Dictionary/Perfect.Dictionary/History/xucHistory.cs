using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Data.Helper;
using System.Data.SqlTypes;

namespace Perfect.Dictionary.History
{
    public partial class XucHistory : xucBase

    {
        string _Title = "";
      

        public delegate void InventoryShowEventHander(object sender,PRODUCT item);
        
        public event InventoryShowEventHander InventoryShow;
        
        private void RaiseInventoryShowEventHander( PRODUCT item)
        {
            if (InventoryShow != null) InventoryShow(this, item);
        }


        public event ButtonClickEventHander CloseClick;

        public delegate void ViewClick(string Id,string status);

        public event ViewClick View;

        public void RaiseViewClickEventHandle(string Id,string status)
        {
            if (View != null) View(Id,status);
        }

        public void RaiseCloseClickEventHandle()
        {
            if (CloseClick != null) CloseClick(this);
        }

        public XucHistory()
        {
            InitializeComponent();
            bm.SetPopupContextMenu(this, pm);
            SysLog.Insert("Lịch Sử Hàng Hoá", "Xem");
          

            dsHistory.REFTYPE.AddREFTYPERow(0, "Đầu Kỳ");
            dsHistory.REFTYPE.AddREFTYPERow(1, "Nhập Kho");
            dsHistory.REFTYPE.AddREFTYPERow(2, "Xuất Kho");
            dsHistory.REFTYPE.AddREFTYPERow(3, "Lắp Ráp");
            dsHistory.REFTYPE.AddREFTYPERow(4, "Tháo Gỡ");
            dsHistory.REFTYPE.AddREFTYPERow(5, "Kiểm Kê");
            dsHistory.REFTYPE.AddREFTYPERow(6, "Xuất và Đóng Gói");
            dsHistory.REFTYPE.AddREFTYPERow(7, "Đóng Gói Bán Thành Phẩm");
            dsHistory.REFTYPE.AddREFTYPERow(8, "Đóng Gói Thành Phẩm");
            dsHistory.REFTYPE.AddREFTYPERow(9, "Chuyển Kho");
            dsHistory.REFTYPE.AddREFTYPERow(10, "Quản Lý Kho");
            //
            dsHistory.REFTYPE.AddREFTYPERow(20, "Quản Lý Bán Hàng");
            dsHistory.REFTYPE.AddREFTYPERow(21, "Phiếu Bán Hàng");
            dsHistory.REFTYPE.AddREFTYPERow(22, "Phiếu Bán Lẻ");
            dsHistory.REFTYPE.AddREFTYPERow(23, "Phiếu Mua Hàng");

            //
            dsHistory.REFTYPE.AddREFTYPERow(30, "Quản Lý Công Nợ");
            dsHistory.REFTYPE.AddREFTYPERow(31, "Số Dư Công Nợ Khách Hàng");
            dsHistory.REFTYPE.AddREFTYPERow(32, "Số Dư Công Nợ Nhà Phân Phối");
            dsHistory.REFTYPE.AddREFTYPERow(33, "Số Dư Công Nợ Nhân Viên");
            dsHistory.REFTYPE.AddREFTYPERow(34, "Số Dư Quỹ");
            dsHistory.REFTYPE.AddREFTYPERow(35, "Phiếu Thu Tiền Nợ Khách Hàng");
            dsHistory.REFTYPE.AddREFTYPERow(36, "Phiếu Chi Tiền Nợ Nhà Phân Phối");
            //
            dsHistory.REFTYPE.AddREFTYPERow(40, "Quản Lý Quỹ");
            dsHistory.REFTYPE.AddREFTYPERow(41, "Phiếu Thu");
            dsHistory.REFTYPE.AddREFTYPERow(42, "Phiếu Chi");

            StockInit();
            FormatColumns(rpStock, "Stock_ID", 1, 0, "Mã Kho");
            FormatColumns(rpStock, "Stock_Name", 0, 0, "Tên Kho");
            SetData(txtProductID.Text, txtProductName.Text);

        }

        void StockInit()
        {
            sTOCKTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
        }
           

        private void BtViewClick(object sender, EventArgs e)
        {
           
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData(txtProductID.Text,txtProductName.Text);
            DoHide();
        }

        public void SetData(string productID,string productName)
        {

            #region query

            string sql = "/************************************************************ \n"
           + " * Code formatted by SoftTree SQL Assistant © v6.0.70 \n"
           + " * Time: 9/25/2012 4:13:51 PM \n"
           + " ************************************************************/ \n"
           + " \n"
           + "--DECLARE @StockID VARCHAR(100) \n"
           + "--DECLARE @FromDate DATETIME \n"
           + "--DECLARE @ToDate DATETIME \n"
           + " \n"
           + "--SET @StockID = 'K000001'               \n"
           + "--SET @FromDate = '1/1/2000' \n"
           + "--SET @ToDate = '12/28/2015' \n"
           + " \n"
           + "DECLARE @DetailTb TABLE( \n"
           + "            ID BIGINT NULL, \n"
           + "            RefNo VARCHAR(100) NULL, \n"
           + "            TempRefDate DATETIME NULL, \n"
           + "            RefDate DATETIME NULL, \n"
           + "            RefType INT NULL, \n"
           + "            RefStatus INT NULL, \n"
           + "            Stock_ID VARCHAR(20) NULL, \n"
           + "            Product_ID VARCHAR(20) NULL, \n"
           + "            Unit NVARCHAR(50) NULL, \n"
           + "            Quantity MONEY NULL, \n"
           + "            Price MONEY NULL, \n"
           + "            Amount MONEY NULL, \n"
           + "            AVG_Price MONEY NULL, \n"
           + "            AVG_Amount MONEY NULL, \n"
           + "            RealQuantity MONEY NULL, \n"
           + "            E_Quantity MONEY NULL, \n"
           + "            E_Amount MONEY NULL, \n"
           + "            Sorted BIGINT NULL, \n"
           + "            RefSorted BIGINT NULL \n"
           + "        ) \n"
           + " \n"
           + "DECLARE @ID BIGINT \n"
           + "DECLARE @RefNo VARCHAR(100) \n"
           + "DECLARE @TempRefDate DATETIME \n"
           + "DECLARE @RefDate DATETIME \n"
           + "DECLARE @RefType INT \n"
           + "DECLARE @RefStatus BIGINT \n"
           + "DECLARE @Stock_ID VARCHAR(200) \n"
           + "DECLARE @Product_ID VARCHAR(250) \n"
           + "DECLARE @Unit VARCHAR(100) \n"
           + "DECLARE @Quantity MONEY \n"
           + "DECLARE @Price MONEY \n"
           + "DECLARE @Sorted BIGINT \n"
           + "DECLARE @RefSorted BIGINT \n"
           + " \n"
           + " \n"
           + "-- khai bao bien tam \n"
           + "DECLARE @ProductID_Temp VARCHAR(250) \n"
           + "DECLARE @StockID_Temp VARCHAR(250) \n"
           + "DECLARE @E_Amount MONEY \n"
           + "DECLARE @E_Quantity MONEY \n"
           + "DECLARE @Pre_E_Quantity MONEY \n"
           + "DECLARE @E_UnitPrice MONEY \n"
           + " \n"
           + "SET @ProductID_Temp = '' \n"
           + "SET @StockID_Temp = '' \n"
           + "SET @E_Amount = 0 \n"
           + "SET @E_Quantity = 0 \n"
           + "SET @Pre_E_Quantity = 0 \n"
           + "SET @E_UnitPrice = 0 \n"
           + " \n"
           + "-- ket thuc khai bao bien tam \n"
           + " \n"
           + "DECLARE @getInventoryDetail CURSOR                   \n"
           + "SET @getInventoryDetail =                   CURSOR FOR \n"
           + " \n"
           + "/* \n"
           + "SELECT id.ID, \n"
           + "       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate, \n"
           + "       id.RefStatus, \n"
           + "       id.Stock_ID, \n"
           + "       id.Product_ID, \n"
           + "       id.Unit, \n"
           + "       id.Price, \n"
           + "       id.Quantity, \n"
           + "       id.Sorted \n"
           + "FROM   INVENTORY_DETAIL id \n"
           + "WHERE  id.Stock_ID = @StockID \n"
           + "       --AND id.Product_ID = 'HH000301' \n"
           + "ORDER BY \n"
           + "       id.Product_ID, \n"
           + "       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC, \n"
           + "       id.Sorted ASC \n"
           + "*/ \n"
           + " \n"
           + "SELECT IN_DETAIL.*, \n"
           + "       tr.Sorted AS RefSorted \n"
           + "FROM   ( \n"
           + "           SELECT id.ID, \n"
           + "                  id.RefNo, \n"
           + "                  CAST(-53690 AS DATETIME) AS TempRefDate, \n"
           + "                  DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate, \n"
           + "                  id.RefType, \n"
           + "                  id.RefStatus, \n"
           + "                  id.Stock_ID, \n"
           + "                  id.Product_ID, \n"
           + "                  id.Unit, \n"
           + "                  id.Quantity, \n"
           + "                  id.Price, \n"
           + "                  id.Sorted \n"
           + "           FROM   INVENTORY_DETAIL id \n"
           + "           WHERE  --id.Stock_ID = @StockID AND  \n"
           + "                  id.RefType = 0 \n"
           + "           --ORDER BY \n"
           + "           --       id.Product_ID, \n"
           + "           --       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC, \n"
           + "           --       id.Sorted ASC \n"
           + "           UNION ALL \n"
           + "            \n"
           + "           SELECT id.ID, \n"
           + "                  id.RefNo, \n"
           + "                  DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS TempRefDate, \n"
           + "                  DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) AS RefDate, \n"
           + "                  id.RefType, \n"
           + "                  id.RefStatus, \n"
           + "                  id.Stock_ID, \n"
           + "                  id.Product_ID, \n"
           + "                  id.Unit, \n"
           + "                  id.Quantity, \n"
           + "                  id.Price, \n"
           + "                  id.Sorted \n"
           + "           FROM   INVENTORY_DETAIL id \n"
           + "           WHERE  --id.Stock_ID = @StockID AND  \n"
           + "                  id.RefType != 0 \n"
           + "                  --ORDER BY \n"
           + "                  --       id.Product_ID, \n"
           + "                  --       DATEADD(dd, DATEDIFF(d, 0, id.RefDate), 0) ASC, \n"
           + "                  --       id.Sorted ASC \n"
           + "       )IN_DETAIL \n"
           + "       LEFT OUTER JOIN TRANS_REF tr \n"
           + "            ON  IN_DETAIL.RefNo = tr.RefID \n"
           + "            AND IN_DETAIL.RefType = tr.RefType \n"
           + "ORDER BY \n"
           + "       IN_DETAIL.Product_ID, \n"
           + "       IN_DETAIL.Stock_ID, \n"
           + "       IN_DETAIL.TempRefDate ASC, \n"
           + "       IN_DETAIL.RefDate ASC, \n"
           + "       tr.Sorted ASC, \n"
           + "       IN_DETAIL.Sorted ASC \n"
           + " \n"
           + "OPEN @getInventoryDetail \n"
           + "FETCH NEXT \n"
           + "FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType, @RefStatus,  \n"
           + "@Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted \n"
           + "WHILE @@FETCH_STATUS = 0 \n"
           + "BEGIN \n"
           + "    IF ( \n"
           + "           @ProductID_Temp = @Product_ID \n"
           + "           AND @StockID_Temp = @Stock_ID \n"
           + "       ) \n"
           + "    BEGIN \n"
           + "        SET @Pre_E_Quantity = @E_Quantity \n"
           + "         \n"
           + "        SET @E_Quantity = @E_Quantity + CASE  \n"
           + "                                             WHEN @RefStatus = 1 THEN @Quantity \n"
           + "                                             ELSE (@Quantity * -1) \n"
           + "                                        END \n"
           + "         \n"
           + "        --        IF (@E_Quantity <= 0) \n"
           + "        --        BEGIN \n"
           + "        --            SET @E_UnitPrice = ( \n"
           + "        --                    CASE \n"
           + "        --                         WHEN @RefStatus = 1 THEN @Price \n"
           + "        --                         ELSE ( \n"
           + "        --                                  CASE \n"
           + "        --                                       WHEN @Pre_E_Quantity = 0 THEN 0 \n"
           + "        --                                       ELSE @E_Amount / @Pre_E_Quantity \n"
           + "        --                                  END \n"
           + "        --                              ) \n"
           + "        --                    END \n"
           + "        --                ) \n"
           + "        -- \n"
           + "        --            SET @E_Amount = 0 \n"
           + "        --        END \n"
           + "        --        ELSE \n"
           + "        BEGIN \n"
           + "        	IF (@RefStatus = 1) \n"
           + "        	BEGIN \n"
           + "        	    SET @E_Amount = @E_Amount + (@Price * @Quantity) \n"
           + "        	    SET @E_UnitPrice = @Price \n"
           + "        	END \n"
           + "        	ELSE \n"
           + "        	BEGIN \n"
           + "        	    SET @E_UnitPrice = CASE  \n"
           + "        	                            WHEN @Pre_E_Quantity <= 0 THEN 0 \n"
           + "        	                            ELSE (@E_Amount / @Pre_E_Quantity) \n"
           + "        	                       END \n"
           + "        	     \n"
           + "        	    SET @E_Amount = @E_Amount -(@Quantity * @E_UnitPrice) \n"
           + "        	END \n"
           + "        END \n"
           + "    END \n"
           + "    ELSE \n"
           + "    BEGIN \n"
           + "        SET @E_Amount = 0 \n"
           + "        SET @E_Quantity = CASE  \n"
           + "                               WHEN @RefStatus = 1 THEN @Quantity \n"
           + "                               ELSE (@Quantity * -1) \n"
           + "                          END \n"
           + "         \n"
           + "        IF (@E_Quantity <= 0) \n"
           + "        BEGIN \n"
           + "            SET @E_Amount = 0 \n"
           + "            SET @E_UnitPrice = 0 \n"
           + "        END \n"
           + "        ELSE \n"
           + "        BEGIN \n"
           + "            IF (@RefStatus = 1) \n"
           + "            BEGIN \n"
           + "                SET @E_Amount = @E_Amount + (@Price * @Quantity) \n"
           + "                SET @E_UnitPrice = @Price \n"
           + "            END \n"
           + "        END \n"
           + "    END \n"
           + "    SET @ProductID_Temp = @Product_ID \n"
           + "    SET @StockID_Temp = @Stock_ID \n"
           + "     \n"
           + "    --    PRINT @Product_ID + ' --- ' + CAST(@E_Quantity AS VARCHAR(100)) + ' --- ' + \n"
           + "    --    CAST(@Quantity AS VARCHAR(100)) + ' --- ' + CAST(@RefStatus AS VARCHAR(5)) + \n"
           + "    --    ' --- ' + CAST(@E_Amount AS VARCHAR(100)) + ' --- ' + CAST(@E_UnitPrice AS VARCHAR(100)) \n"
           + "     \n"
           + "    INSERT INTO @DetailTb \n"
           + "      ( \n"
           + "        ID, \n"
           + "        RefNo, \n"
           + "        TempRefDate, \n"
           + "        RefDate, \n"
           + "        RefType, \n"
           + "        RefStatus, \n"
           + "        Stock_ID, \n"
           + "        Product_ID, \n"
           + "        Unit, \n"
           + "        Quantity, \n"
           + "        Price, \n"
           + "        Amount, \n"
           + "        AVG_Price, \n"
           + "        AVG_Amount, \n"
           + "        RealQuantity, \n"
           + "        E_Quantity, \n"
           + "        E_Amount, \n"
           + "        Sorted, \n"
           + "        RefSorted \n"
           + "      ) \n"
           + "    VALUES \n"
           + "      ( \n"
           + "        @ID, \n"
           + "        @RefNo, \n"
           + "        @TempRefDate, \n"
           + "        @RefDate, \n"
           + "        @RefType, \n"
           + "        @RefStatus, \n"
           + "        @Stock_ID, \n"
           + "        @Product_ID, \n"
           + "        @Unit, \n"
           + "        @Quantity, \n"
           + "        @Price, \n"
           + "        (@Price * @Quantity), \n"
           + "        @E_UnitPrice, \n"
           + "        (@E_UnitPrice * @Quantity), \n"
           + "        CASE  \n"
           + "             WHEN @RefStatus = 1 THEN @Quantity \n"
           + "             ELSE (@Quantity * -1) \n"
           + "        END, \n"
           + "        @E_Quantity, \n"
           + "        @E_Amount, \n"
           + "        @Sorted, \n"
           + "        @RefSorted \n"
           + "      ) \n"
           + "     \n"
           + "    FETCH NEXT \n"
           + "    FROM @getInventoryDetail INTO @ID, @RefNo, @TempRefDate, @RefDate, @RefType,  \n"
           + "    @RefStatus,  \n"
           + "    @Stock_ID, @Product_ID, @Unit, @Quantity, @Price, @Sorted, @RefSorted \n"
           + "END \n"
           + " \n"
           + "CLOSE @getInventoryDetail \n"
           + "DEALLOCATE @getInventoryDetail \n"
           + " \n"
           + "SELECT dt.ID, \n"
           + "       dt.RefNo, \n"
           + "       dt.TempRefDate, \n"
           + "       dt.RefDate, \n"
           + "       dt.RefType, \n"
           + "       dt.RefStatus, \n"
           + "       dt.Stock_ID, \n"
           + "       s.Stock_Name, \n"
           + "       dt.Product_ID, \n"
           + "       p.Product_Name, \n"
           + "       dt.Unit, \n"
           + "       u.Unit_Name, \n"
           + "       dt.Quantity, \n"
           + "       dt.Price, \n"
           + "       dt.Amount, \n"
           + "       dt.AVG_Price, \n"
           + "       dt.AVG_Amount, \n"
           + "       dt.RealQuantity, \n"
           + "       dt.E_Quantity, \n"
           + "       dt.E_Amount, \n"
           + "       dt.Sorted, \n"
           + "       dt.RefSorted \n"
           + "FROM   @DetailTb dt \n"
           + "       LEFT OUTER JOIN PRODUCT p \n"
           + "            ON  dt.Product_ID = p.Product_ID \n"
           + "       LEFT OUTER JOIN UNIT u \n"
           + "            ON  u.Unit_ID = dt.Unit \n"
           + "       LEFT OUTER JOIN STOCK s \n"
           + "            ON  dt.Stock_ID = s.Stock_ID \n"
           + "WHERE  dt.Product_ID LIKE N'%" + productID + "%' \n"
           + "       AND p.Product_Name LIKE N'%" + productName + "%' \n"
           + "ORDER BY \n"
           + "       dt.Product_ID, \n"
           + "       dt.Stock_ID, \n"
           + "       dt.TempRefDate ASC, \n"
           + "       dt.RefDate ASC, \n"
           + "       dt.RefSorted ASC, \n"
           + "       dt.Sorted ASC \n"
           + "";

            #endregion

            //" WHERE     (INVENTORY_DETAIL.Product_ID LIKE N'%" + productid + "%') AND (PRODUCT.Product_Name LIKE N'%" + productName + "%') ";

            //pRODUCT_HistoryTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            //pRODUCT_HistoryTableAdapter.ClearBeforeFill = true;
            //pRODUCT_HistoryTableAdapter.Fill(dsHistory.PRODUCT_History, "%" + productID + "%", "%" + productName + "%");

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;
            dsHistory.Product_History_Dynamic.Clear();

            dsHistory.Product_History_Dynamic.Merge(mySql.ExecuteDataTable(sql));
            
            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            RaiseCloseClickEventHandle();
        }

        private void gbList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gcList_Click(object sender, EventArgs e)
        {
            


        }

        public object GetCellValue(int rowIndex, string fieldName)
        {
            object result = GetCellValue(new RowClickEventArgs(rowIndex, fieldName));
            return result;
        }

        public object GetCellValue(int rowIndex, int columIndex)
        {
            object result = GetCellValue(new RowClickEventArgs(rowIndex, columIndex));
            return result;
        }

        public object GetCellValue(RowClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var Col = new GridColumn();

            if (e.ColumnIndex != -1)
            {
                Col = view.Columns[e.ColumnIndex];

            }
            else
            {
                Col = view.Columns[e.FieldName];
            }
            object result = view.GetRowCellValue(e.RowIndex, Col);
            // if (Result == null | e.RowIndex > gbList.RowCount) XtraMessageBox.Show("Không thể lấy thông tin.", "Thông báo");
            return result;
        }

        private void menuView_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);

            string status;
            object arg = GetCellValue(ex.RowIndex, "ID");
            status = GetCellValue(ex.RowIndex, "Loai").ToString();
            if (arg == null) return;

            RaiseViewClickEventHandle(arg.ToString(),status);
        }

        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtViewClick(btView, EventArgs.Empty);
            }
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtViewClick(btView, EventArgs.Empty);
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtViewClick(btView,e);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _exportView = gbList;
            Export();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();
        }
        
        private void bbiInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //Get Object 
            object arg = null;
            arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());

            RaiseInventoryShowEventHander(product);
        }

        private void BbiProductDetailItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (arg == null) return;
            var product = new PRODUCT();
            product.Get(arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        private void DisableMenu(bool disable)
        {
            bbiPrint.Enabled = !disable;
            bbiExport.Enabled = !disable;
            bbiProduct.Enabled = !disable;
        }

        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            DisableMenu(false);
            if (gbList.RowCount == 0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            //Get Object 
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            bbiProduct.Enabled = true;
            if (arg == null)
            {
                bbiProduct.Enabled = false;
                return;
            }
           
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

    }
}
