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
    public partial class xucInventoryDetail : xucDetailList
    {
        public xucInventoryDetail()
        {
            InitializeComponent();
            Init();
        }

        private new void Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");

            //StockInit();
            Bar.All = true;
            Bar.Stock_Init();
            Bar.IsFrom = false;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            DoHide();
            Cursor.Current = Cursors.Default;
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

            if (!MyRule.IsAccess("bbiInventory")) return;
            if (Bar.Stock == "")
            {
                return;
            }

            gbList.Columns[colStock_Name.FieldName].OptionsColumn.AllowGroup = Bar.Stock == "All"
                                                                                   ? DefaultBoolean.True
                                                                                   : DefaultBoolean.False;

      
            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = System.Data.CommandType.Text;
            string query = "";

            #region query
            if (Bar.Stock == "All")
                query = @"

SELECT B.Stock_ID,
       s.Stock_Name,
       B.Product_ID,
       p.Product_Name,
       B.Quantity                     AS InventoryTotal,
       ----
       CASE 
            WHEN pu.UnitConvert IS NULL THEN NULL
            ELSE pu.UnitConvert
       END                            AS ConvertValues,
       ----
       CASE 
            WHEN pu.UnitConvert IS NULL THEN B.Quantity
            ELSE B.Quantity % pu.UnitConvert
       END                            AS Quantity,
       u.Unit_Name                    AS Unit,
       ------
       CASE 
            WHEN pu.UnitConvert IS NULL THEN NULL
            ELSE (B.Quantity -(B.Quantity % pu.UnitConvert)) / pu.UnitConvert
       END                            AS QuantityConvert,
       CASE 
            WHEN pu.UnitConvert IS NULL THEN NULL
            ELSE uu.Unit_Name
       END                            AS UnitConvert,
       pg.ProductGroup_Name,
       p.[Active]
FROM   (
           SELECT A.Stock_ID,
                  A.Product_ID,
                  A.Unit,
                  SUM(
                      CASE 
                           WHEN A.RefStatus = 1 THEN A.Quantity
                           WHEN A.RefStatus = 3 THEN A.Quantity
                           ELSE A.Quantity * -1
                      END
                  )  AS Quantity
           FROM   (
                      SELECT id.Stock_ID,
                             id.Product_ID,
                             CASE 
                                  WHEN pu.Unit_ID IS NULL THEN id.Unit
                                  ELSE pu.Unit_ID
                             END  AS Unit,
                             id.RefStatus,
                             CASE 
                                  WHEN pu.UnitConvert IS NULL THEN id.Quantity
                                  ELSE id.Quantity * pu.UnitConvert
                             END  AS Quantity
                      FROM   (
                      			-- Nhập kho
                                 SELECT sid1.Stock_ID,
                                        sid1.Product_ID,
                                        CAST(1 AS SMALLINT) AS RefStatus,
                                        sid1.Unit,
                                        sid1.Quantity
                                 FROM   STOCK_INWARD_DETAIL AS sid1 

                                 -- Xuất kho
                                 UNION ALL
                                 SELECT sod.Stock_ID,
                                        sod.Product_ID,
                                        CAST(2 AS SMALLINT) AS RefStatus,
                                        sod.Unit,
                                        sod.Quantity
                                 FROM   STOCK_OUTWARD_DETAIL AS sod 

                                 -------------------------------------------
                                 -- Chuyển kho
                                 -------------------------------------------
                                 -- Nhập chuyển kho
                                 UNION ALL
                                 SELECT std.InStock AS Stock_ID,
                                        std.Product_ID,
                                        CAST(1 AS SMALLINT) AS RefStatus,
                                        std.Unit,
                                        std.Quantity
                                 FROM   STOCK_TRANSFER_DETAIL AS std 
								 -- Xuất chuyển kho
                                 UNION ALL
                                 SELECT std.OutStock AS Stock_ID,
                                        std.Product_ID,
                                        CAST(2 AS SMALLINT) AS RefStatus,
                                        std.Unit,
                                        std.Quantity
                                 FROM   STOCK_TRANSFER_DETAIL AS std 		
 					 							 
								 -------------------------------------------
                                 -- KIỂM KÊ
                                 -------------------------------------------
                                 UNION ALL
                                 SELECT std.Stock_ID,
                                        std.Product_ID,
                                        CAST(3 AS SMALLINT) AS RefStatus,
                                        std.Unit,
                                        std.QtyDiff AS Quantity
                                 FROM   ADJUSTMENT_DETAIL AS std      
                             
                      ) AS id
                             LEFT JOIN PRODUCT_UNIT AS pu
                                  ON  pu.Product_ID = id.Product_ID
                                  AND id.Unit = pu.UnitConvert_ID 
                  )     A
           GROUP BY
                  A.Stock_ID,
                  A.Product_ID,
                  A.Unit
       )B
       LEFT JOIN PRODUCT_UNIT         AS pu
            ON  pu.Product_ID = B.Product_ID
            AND pu.Unit_ID = B.Unit
       LEFT OUTER JOIN UNIT           AS u
            ON  u.Unit_ID = B.Unit
       LEFT OUTER JOIN UNIT           AS uu
            ON  uu.Unit_ID = pu.UnitConvert_ID
       LEFT JOIN STOCK                AS s
            ON  s.Stock_ID = B.Stock_ID
       LEFT OUTER JOIN PRODUCT        AS p
            ON  p.Product_ID = B.Product_ID
       LEFT OUTER JOIN PRODUCT_GROUP  AS pg
            ON  pg.ProductGroup_ID = p.Product_Group_ID
ORDER BY
       B.Product_ID
       
";
            else
                query = @"

SELECT B.Stock_ID,
       s.Stock_Name,
       B.Product_ID,
       p.Product_Name,
       B.Quantity                     AS InventoryTotal,
       ----
       CASE 
            WHEN pu.UnitConvert IS NULL THEN NULL
            ELSE pu.UnitConvert
       END                            AS ConvertValues,
       ----
       CASE 
            WHEN pu.UnitConvert IS NULL THEN B.Quantity
            ELSE B.Quantity % pu.UnitConvert
       END                            AS Quantity,
       u.Unit_Name                    AS Unit,
       ------
       CASE 
            WHEN pu.UnitConvert IS NULL THEN NULL
            ELSE (B.Quantity -(B.Quantity % pu.UnitConvert)) / pu.UnitConvert
       END                            AS QuantityConvert,
       CASE 
            WHEN pu.UnitConvert IS NULL THEN NULL
            ELSE uu.Unit_Name
       END                            AS UnitConvert,
       pg.ProductGroup_Name,
       p.[Active]
FROM   (
           SELECT A.Stock_ID,
                  A.Product_ID,
                  A.Unit,
                  SUM(
                      CASE 
                           WHEN A.RefStatus = 1 THEN A.Quantity
                           WHEN A.RefStatus = 3 THEN A.Quantity
                           ELSE A.Quantity * -1
                      END
                  )  AS Quantity
           FROM   (
                      SELECT id.Stock_ID,
                             id.Product_ID,
                             CASE 
                                  WHEN pu.Unit_ID IS NULL THEN id.Unit
                                  ELSE pu.Unit_ID
                             END  AS Unit,
                             id.RefStatus,
                             CASE 
                                  WHEN pu.UnitConvert IS NULL THEN id.Quantity
                                  ELSE id.Quantity * pu.UnitConvert
                             END  AS Quantity
                      FROM   (
                      			-- Nhập kho
                                 SELECT sid1.Stock_ID,
                                        sid1.Product_ID,
                                        CAST(1 AS SMALLINT) AS RefStatus,
                                        sid1.Unit,
                                        sid1.Quantity
                                 FROM   STOCK_INWARD_DETAIL AS sid1
                                 WHERE  sid1.Stock_ID = @Stock_ID
                                 -- Xuất kho
                                 UNION ALL
                                 SELECT sod.Stock_ID,
                                        sod.Product_ID,
                                        CAST(2 AS SMALLINT) AS RefStatus,
                                        sod.Unit,
                                        sod.Quantity
                                 FROM   STOCK_OUTWARD_DETAIL AS sod
                                 WHERE  sod.Stock_ID = @Stock_ID
                                 -------------------------------------------
                                 -- Chuyển kho
                                 -------------------------------------------
                                 -- Nhập chuyển kho
                                 UNION ALL
                                 SELECT std.InStock AS Stock_ID,
                                        std.Product_ID,
                                        CAST(1 AS SMALLINT) AS RefStatus,
                                        std.Unit,
                                        std.Quantity
                                 FROM   STOCK_TRANSFER_DETAIL AS std
                                 WHERE  std.InStock = @Stock_ID
								 -- Xuất chuyển kho
                                 UNION ALL
                                 SELECT std.OutStock AS Stock_ID,
                                        std.Product_ID,
                                        CAST(2 AS SMALLINT) AS RefStatus,
                                        std.Unit,
                                        std.Quantity
                                 FROM   STOCK_TRANSFER_DETAIL AS std		
                                 WHERE  std.OutStock = @Stock_ID				 					 							 
								 -------------------------------------------
                                 -- KIỂM KÊ
                                 -------------------------------------------
                                 UNION ALL
                                 SELECT std.Stock_ID,
                                        std.Product_ID,
                                        CAST(3 AS SMALLINT) AS RefStatus,
                                        std.Unit,
                                        std.QtyDiff AS Quantity
                                 FROM   ADJUSTMENT_DETAIL AS std                             
								 WHERE  std.Stock_ID = @Stock_ID
                             
                      ) AS id
                             LEFT JOIN PRODUCT_UNIT AS pu
                                  ON  pu.Product_ID = id.Product_ID
                                  AND id.Unit = pu.UnitConvert_ID 
                  )     A
           GROUP BY
                  A.Stock_ID,
                  A.Product_ID,
                  A.Unit
       )B
       LEFT JOIN PRODUCT_UNIT         AS pu
            ON  pu.Product_ID = B.Product_ID
            AND pu.Unit_ID = B.Unit
       LEFT OUTER JOIN UNIT           AS u
            ON  u.Unit_ID = B.Unit
       LEFT OUTER JOIN UNIT           AS uu
            ON  uu.Unit_ID = pu.UnitConvert_ID
       LEFT JOIN STOCK                AS s
            ON  s.Stock_ID = B.Stock_ID
       LEFT OUTER JOIN PRODUCT        AS p
            ON  p.Product_ID = B.Product_ID
       LEFT OUTER JOIN PRODUCT_GROUP  AS pg
            ON  pg.ProductGroup_ID = p.Product_Group_ID
ORDER BY
       B.Product_ID
       
";
            #endregion

            dsInventory.INVENTORY_DETAIL.Clear();
            string[] myParams = { "@Stock_ID" };
            object[] myValues = { Bar.Stock };
            System.Data.DataTable dt = mySql.ExecuteDataTable(query, myParams, myValues);

            
            dsInventory.INVENTORY_DETAIL.Merge(dt);
            Cursor.Current = Cursors.Default;
            gbList.BestFitColumns();
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
            SetWaitDialogCaption("Đang nạp dữ liệu...");

            if (!MyRule.IsPrint("bbiInventory")) return;

            SysLog.Insert("Tồn Kho", "In");

            if (dsInventory.INVENTORY_DETAIL.Rows.Count == 0)
            {
                DoHide();
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var rpt = new rptInventory(0, "RD0000006", dsInventory.INVENTORY_DETAIL, "TỒN KHO", "",
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
            if (dsInventory.INVENTORY_GetFull.Rows.Count == 0)
            {
                DisableMenu(true);
                return;
            }
            AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle,
                                           view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle,
                                           view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            object arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);
            Bar.Bar.bbiProduct.Enabled = true;
            if (arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
        }

        private void GbListCustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                double amount = 0.0;
                double quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount +=
                        Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value
                                             ? 0
                                             : gbList.GetRowCellValue(i, "Amount"));
                    quantity +=
                        Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value
                                             ? 0
                                             : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = amount/quantity;
            }
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