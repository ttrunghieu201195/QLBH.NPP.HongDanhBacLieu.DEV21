using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using Perfect.ERP;
using Perfect.Data.Helper;

namespace Perfect.Common
{
    public partial class xucBaseListB : xucBase
    {
        protected ListType Type = ListType.General;
        protected RowClickEventArgs m_RowClick = new RowClickEventArgs();
        public delegate void SendIDEventHander(object sender, string ID);
        BaseView exportView;
        string _Title = "";

        public string Title
        {
            set { _Title = value; }
        }

        public xucBaseListB()
        {
            InitializeComponent();
            dtFrom.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtTo.DateTime = dtFrom.DateTime.AddMonths(1).AddDays(-1);
            bm.SetPopupContextMenu(this, pm);
        }

        public void Stock_Init()
        {
            sTOCKTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sTOCKTableAdapter.Fill(dsSTOCK.STOCK);
        }

        public void Product_Init()
        {
            pRODUCTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCTTableAdapter.Fill(dsPRODUCT.PRODUCT);
        }

        public void Unit_Init()
        {
            uNITTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            uNITTableAdapter.Fill(dsUNIT.UNIT);
        }

        public void Init()
        {
            Stock_Init();
            Product_Init();
            Unit_Init();

            FormatColumns(rpgProduct, "Product_ID", 0, 100, "Mã Hàng");
            FormatColumns(rpgProduct, "Product_Name", 1, 200, "Mã Hàng");

            FormatColumns(rpUnit, "Unit_ID", 1, 100, "Mã");
            FormatColumns(rpUnit, "Unit_Name", 0, 200, "Đơn Vị");

            FormatColumns(rpProductName, "Product_ID", 1, 100, "Mã Hàng");
            FormatColumns(rpProductName, "Product_Name", 0, 200, "Hàng Hoá");


            //FormatColumns(rpToStock, "Stock_ID", 1, 100, "Mã");
            //FormatColumns(rpToStock, "Stock_Name", 0, 200, "Kho Hàng");

            FormatColumns(rpgStock, "Stock_ID", 1, 100, "Mã");
            FormatColumns(rpgStock, "Stock_Name", 0, 200, "Kho Hàng");
        }

        protected virtual void MakerInterface()
        {
            CONTROL_FORMAT cf = new CONTROL_FORMAT();
            for (int i = 0; i < plTop.Controls.Count; i++)
            {
                if (plTop.Controls[i].Text != "")
                {
                    cf.Insert(Guid.NewGuid().ToString(), "xucBasicListX", plTop.Controls[i].Name, "EN", plTop.Controls[i].Text, "", true);
                }
            }

            for (int i = 0; i < plButtom.Controls.Count; i++)
            {
                if (plButtom.Controls[i].Text != "")
                {
                    cf.Insert(Guid.NewGuid().ToString(), "xucBasicListX", plButtom.Controls[i].Name, "EN", plButtom.Controls[i].Text, "", true);
                }
            }
        }

        protected virtual void SaveInterface()
        {
            CONTROL_FORMAT.Save("xucBasicListX", "EN");
        }

        protected virtual void SetInterface()
        {
            DataTable dt = CONTROL_FORMAT.Load("xucBasicListX");

            CONTROL_FORMAT.ContainerChangeLanguage(plTop, ref dt);
            CONTROL_FORMAT.ContainerChangeLanguage(plButtom, ref dt);
        }

        public event SendIDEventHander SendID;

        public event ButtonClickEventHander AddNewClick;

        public event ButtonClickEventHander CloseClick;

        protected void RaiseSendIDEventHander(string ID)
        {
            if (SendID != null)
            {
                SendID(this, ID);
            }
        }

        protected void RaiseAddNewClickEventHander()
        {
            if (AddNewClick != null)
            {
                AddNewClick(this);
            }
        }

        private void RaiseCloseClickEventHander()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }

        protected virtual void btnView_Click(object sender, EventArgs e)
        {
            Reload();
        }

        protected virtual bool ExportPermision()
        {
            return true;
        }

        protected virtual void btnExport_Click(object sender, EventArgs e)
        {
            if (!ExportPermision()) return;
            Export(gbList);
        }

        protected virtual void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        protected virtual void gbList_Click(object sender, EventArgs e)
        {

        }

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(btnEdit, e);
        }

        protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEdit_Click(btnEdit, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, EventArgs.Empty);
            }
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            RaiseAddNewClickEventHander();
        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDetail_Print_Click(object sender, EventArgs e)
        {

        }

        protected virtual void List_Init(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {

        }

        protected virtual void List_Init_Detail(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {

        }

        protected virtual void List_Init_General(DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView dt)
        {

        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            //RaiseCloseClickEventHander();
            this.ParentForm.Close();
        }

        private void chxDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (chxDetail.Checked)
            {
                gcDetail.Visible = false;
                Type = ListType.Detail;
                Reload();
                return;
            }
            gcDetail.Visible = true;
            Type = ListType.General;
            Reload();
        }
        
        protected virtual void Print()
        {
            XtraMessageBox.Show("Don't support.");
        }

        public virtual void Reload()
        {

        }

        public object GetCellValue(RowClickEventArgs e)
        {
            object Result = null;
            AdvBandedGridView view = gbList;

            DevExpress.XtraGrid.Columns.GridColumn Col = new DevExpress.XtraGrid.Columns.GridColumn();

            if (e.ColumnIndex != -1)
            {
                Col = view.Columns[e.ColumnIndex];

            }
            else
            {
                Col = view.Columns[e.FieldName];
            }
            Result = view.GetRowCellValue(e.RowIndex, Col);

            // if (Result == null | e.RowIndex > gbList.RowCount) VnMessageBox.Error("Không thể lấy thông tin.", "Thông báo");
            return Result;
        }

        public object GetCellValue(int RowIndex, int ColumIndex)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex));
            return Result;
        }

        public object GetCellValue(int RowIndex, string FieldName)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName));
            return Result;
        }

        protected void Total()
        {
            //double qty = 0.0;
            //double amt = 0.0;

            // if (chxDetail.Checked)
            // {

            //     for (int i = 0; i < gbList.RowCount; i++)
            //     {
            //         qty += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity")==DBNull.Value?0:gbList.GetRowCellValue(i, "Quantity"));
            //         amt += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
            //     }
            //     txtQuantity.Value = Convert.ToDecimal(qty);
            //     txtAmount.Value = Convert.ToDecimal(amt);

            //     return;
            // }

            // for (int i = 0; i < dgvDetail.Rows.Count; i++)
            //{
            //    qty += Convert.ToDouble(dgvDetail["Quantity", i].Value);
            //    amt += Convert.ToDouble(dgvDetail["Amount", i].Value);
            //}
            //txtQuantity.Value = Convert.ToDecimal(qty);
            //txtAmount.Value = Convert.ToDecimal(amt);
        }

        protected virtual void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        protected virtual void bbiCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        protected virtual void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        protected virtual void bbiPrinted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPrint_Click(sender, e);
        }

        protected virtual void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnView_Click(sender, e);
        }

        protected virtual void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnExport_Click(sender, e);

        }

        protected virtual void bbiViewDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbList_Click(gbList, e);
        }

        protected virtual void gbList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //gbList_Click(gbList, e);
        }

        protected virtual void gbList_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //gbList_Click(gbList, e);
        }

        protected virtual void gbList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // gbList_Click(gbList, e);
        }

        protected virtual void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnClose_Click(sender, e);
        }

        protected virtual void gbList_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {

            }
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
            RowClickEventArgs ex = new RowClickEventArgs(view == null ? -1 : view.FocusedRowHandle, view.FocusedColumn == null ? -1 : view.FocusedColumn.ColumnHandle, view.FocusedColumn == null ? "" : view.FocusedColumn.FieldName);
            m_RowClick = ex;
            //string result = string.Empty;

        }
    }
}
