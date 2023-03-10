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
using DevExpress.XtraReports.UI;

namespace Perfect.Inventory.Core.Inventory.Inventory
{
    public partial class xucInventorySummary : xucDetailList
    {
        public xucInventorySummary()
        {
            InitializeComponent();
            Init();
            Bar.All = true;
            Bar.Stock_Init();
            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        private new void Init()
        {
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetWaitDialogCaption("Đang nạp danh sách đơn vị tính...");
            Unit_Init();
            SetWaitDialogCaption("Đang nạp danh sách kho hàng...");
            Stock_Init();
            DoHide();
        }

        public void Stock_Init()
        {
            var adapter = new STOCKTableAdapter();
            adapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsSTOCK.STOCK);
        }

        public void Unit_Init()
        {
            var adapter = new UNITTableAdapter();
            adapter.Connection.ConnectionString = Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsUnit.UNIT);
        }
   
        public override void Reload()
        {
            
            Cursor.Current = Cursors.WaitCursor;
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SetData(Bar.Id,Bar.Text);
            DoHide();
            Cursor.Current = Cursors.Default;
            
        }

        public void SetData(string product_id, string product_name)
        {
           

            if (Bar.Stock == "")return;
           
            #region Execute
           

            #region query old
            /*
            sql = @"SELECT EP.Product_ID AS ProductID,
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
                                                   AND (id.Stock_ID = @Stock_Id OR 1 = CASE WHEN @Stock_Id = 'All' THEN 1 ELSE 0 END)
                                                   
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
                                                                    AA.Product_ID
                                                             ) P
                                                             ON  id1.Product_ID = 
                                                                 P.Product_ID
                                                 WHERE  (
                                                            DATEDIFF(DAY, @FromDate, id1.RefDate) 
                                                            < 0
                                                            OR id1.RefType =
                                                               0
                                                        )
                                                        AND (id1.Stock_ID = @Stock_Id OR 1 = CASE WHEN @Stock_Id = 'All' THEN 1 ELSE 0 END)
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
            ON  pg.ProductGroup_ID = p.Product_Group_ID  ";
            */
            #endregion

            #region query new
            string sql = @"

SELECT EP.Product_ID AS ProductID,
       p.Product_Name AS ProductName, 
       p.Unit,
       u.Unit_Name, 
       pg.ProductGroup_Name,
       EP.Stock_ID AS StockID,
       s.Stock_Name,

       EP.OpenQuantity,
       ROUND(EP.OpenQuantity * EP.UnitPrice_INTI_AVG,0) AS OpenAmount,

       EP.IN_Quantity AS InQuantity,
       ROUND(EP.IN_Amount,0) AS InAmount,
       
       ROUND(EP.OUT_Quantity * EP.UnitPrice_AVG,0) AS OutAmount,
       ROUND(EP.OUT_Amount,0) AS OutAmountReal,
       
       EP.OUT_Quantity AS OutQuantity,
       ROUND(EP.OpenQuantity + Ep.IN_Quantity - EP.OUT_Quantity,0) AS TotalIOQuantity,
       
       ROUND((EP.OpenQuantity + Ep.IN_Quantity - EP.OUT_Quantity) * EP.UnitPrice_AVG,0 )AS TotalIOAmount,
       ROUND(EP.OUT_Amount - (EP.OUT_Quantity * EP.UnitPrice_AVG),0) AS ProfitAmount,
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
                                      WHEN id.RefStatus = 2
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
                                      WHEN id.RefStatus = 2
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
       EP.Product_ID
";
            #endregion
 
            

            string[] myParams = { "@FromDate", "@ToDate", "@StockID" };
            object[] myValues = { Bar.From, Bar.To, Bar.Stock };

            SqlHelper mySql = new SqlHelper();
            //mySql.CommandType = System.Data.CommandType.Text;
            //System.Data.DataTable dt = mySql.ExecuteDataTable(sql, myParams, myValues);

            mySql.CommandType = System.Data.CommandType.StoredProcedure;
            System.Data.DataTable dt = mySql.ExecuteDataTable("usp_INVENTORY_SUMMARY", myParams, myValues);

            dsSummary.INVENTORY_DETAIL_SUMMARY.Clear();
            dsSummary.INVENTORY_DETAIL_SUMMARY.Merge(dt);

            gbList.BestFitColumns();

            #endregion
        }

        public void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].FieldName)
                {
                    case "Stock_Date":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language=="VN") dt.Columns[i].Caption = "Ngày";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Limit":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.DateTime.FormatString;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Visible = SysOption.Batch;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "HSD";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Product_ID":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Mã hàng";
                        dt.Columns[i].Width =80;
                        break;
                    case "Product_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Hàng hóa";
                        dt.Columns[i].Width = 170;
                        break;
                    case "Unit":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Đơn vị";
                        dt.Columns[i].Width = 100;
                        break;
                    case "ProductGroup_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Nhóm";
                        dt.Columns[i].Width = 150;
                        break;
                    case "Stock_Name":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Kho";
                        dt.Columns[i].Width = 120;
                        break;
                    case "Batch":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].Visible = SysOption.Batch;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Lô";
                        dt.Columns[i].Width = 120;
                        break;

                    case "Quantity":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;
                      
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Số lượng";
                        dt.Columns[i].Width = 80;
                        break;
                    case "UnitPrice":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                       // dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Đơn giá";
                        dt.Columns[i].Width = 80;
                        break;
                    case "Amount":
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                      //  dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                        
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        dt.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        dt.Columns[i].DisplayFormat.FormatString = clsOption.Number.FormatString;

                        if (SysOption.Language == "VN") dt.Columns[i].Caption = "Thành tiền";
                        dt.Columns[i].Width = 80;
                        break;
                    default:
                        dt.Columns[i].Visible = false;
                        break;
                }
            }
        }

        public override void Print()
        {
            if (string.IsNullOrEmpty(MyInfo.Company) || string.IsNullOrEmpty(MyInfo.Address) || string.IsNullOrEmpty(MyInfo.Tel))
            {
                XtraMessageBox.Show("Thông tin đơn vị sử dụng phần mềm chưa nhập đầy đủ. \n\nVui lòng in phiếu này lại sau.", "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }
            if (!MyRule.IsPrint("bbiInventorySummary")) return;

            string from = SysOption.Language == "VN" ? "Từ " : "From ";
            string to = SysOption.Language == "VN" ? " đến " : " to ";
            SysLog.Insert("Tồn Kho (XNT)", "In");

            if (dsSummary.INVENTORY_DETAIL_SUMMARY.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rpt = new rptSummary(dsSummary.INVENTORY_DETAIL_SUMMARY, "RD0000027","Tổng Hợp Xuất Nhập Tồn",from + Strings.Format(Bar.From, "dd/MM/yyyy") + to + Strings.Format(Bar.To, "dd/MM/yyyy"),gbList.ActiveFilterString);

            rpt.ShowPreview();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;
            if (!MyRule.IsExport("bbiInventorySummary")) return false;
            CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            SysLog.Insert("Tồn Kho (XNT)", "Xuất");
            DoHide();
            return base.ExportPermision();

        }

        public override void ProductDetail()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
          
            //Get Object 
            object Arg;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());
            var xfmItemAdd = new xfmItemAdd(Actions.Update, product);
            // xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.ShowDialog();
        }

        public override void History()
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
           
            //Get Object 
            object Arg ;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            if (Arg == null) return;
            var product = new PRODUCT();
            product.Get(Arg.ToString());

            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(product.Product_ID, "");
            xfmHistory.ShowDialog(this);
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
            if(dsSummary.INVENTORY_DETAIL_SUMMARY.Rows.Count==0)
            {
                DisableMenu(true);
                return;
            }

            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            var ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
   
            //Get Object 
            object Arg ;
            Arg = GetCellValue(ex.RowIndex, "Product_ID", gbList);

            Bar.Bar.bbiProduct.Enabled = true;
            if (Arg == null)
            {
                Bar.Bar.bbiProduct.Enabled = false;
                return;
            }
            //PRODUCT product = new PRODUCT();
            //product.Get(Arg.ToString());
        }

        private void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                //e.TotalValue = Convert.ToDouble(colQuantity.SummaryItem.SummaryValue) == 0 ? 0 : Convert.ToDouble(colAmount.SummaryItem.SummaryValue) /
                 //            Convert.ToDouble(colQuantity.SummaryItem.SummaryValue);

                double amount = 0.0;
                double Quantity = 0.0;
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    amount += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                    Quantity += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Quantity"));
                }

                e.TotalValue = amount/Quantity;
            }
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
