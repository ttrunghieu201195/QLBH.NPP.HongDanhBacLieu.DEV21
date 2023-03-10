using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.General;
using Perfect.ERP;
using DevExpress.XtraGrid.Views.Base;

namespace Perfect.SALES
{
    public partial class xucBasicListX : xucBase
    {
        protected string Type = "General";
        public delegate void SendIDEventHander(object sender, string ID);
        BaseView exportView;
        string _Title = "";

        public string Title
        {
            set { _Title = value; }
        }

        public xucBasicListX()
        {
            InitializeComponent();
            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtTo.Value = dtFrom.Value.AddMonths(1).AddDays(-1);
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
            CONTROL_FORMAT.Save("xucBasicListX","EN");
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
                SendID(this,ID);
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
            Export();
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
            if (e.KeyCode== Keys.Enter)
            {
                btnEdit_Click(btnEdit, e);
            }
            else if (e.KeyCode== Keys.Delete)
            {
                btnDelete_Click(sender,EventArgs.Empty);
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
                plDetail.Visible = false;
                Type = "Detail";
                Reload();
                return;
            }
            plDetail.Visible = true;
            Type = "General";
            Reload();
        }

        public virtual void Export()
        {
            SaveFileDialog sDlg = new SaveFileDialog();
            sDlg.Filter = "Microsoft Excel Data (*.xls)|*.xls|Microsoft Excel (*.xls)|*.xls|PDF(*.pdf)|*.pdf|Rich Text Format(*.rtf)|*.rtf|Webpage (*.htm)|*.htm";
            sDlg.ShowDialog();
            gridBand1.Caption = _Title;
            if (sDlg.FileName != null)
            {
                try
                {
                    //btnExports.Enabled = false;

                    if (sDlg.FilterIndex == 1)
                    {
                        ExportToEx(sDlg.FileName, "xlsOld");
                    }
                    else if (sDlg.FilterIndex == 2)
                    {
                        ExportToEx(sDlg.FileName, "xls");
                    }
                    else if (sDlg.FilterIndex == 3)
                    {
                        ExportToEx(sDlg.FileName, "pdf");
                    }
                    else if (sDlg.FilterIndex == 4)
                    {
                        ExportToEx(sDlg.FileName, "rtf");
                    }
                    else if (sDlg.FilterIndex == 5)
                    {
                        ExportToEx(sDlg.FileName, "htm");
                    }
                    //VnMessageBox.Info("Kết xuất thành công.");
                }
                catch (System.Exception ex)
                {
                    //VnMessageBox.Error(ex.Message);
                    EndExport();
                }
                //btnExports.Enabled = true;
            }
        }

        protected virtual void StartExport()
        {
            //if (this != null) MenuForm.Update();
            progressForm = new ProgressForm(this);
            progressForm.Show();
            progressForm.Refresh();
        }

        private void ExportToEx(String filename, string ext)
        {
            StartExport();
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            exportView = gbList;
            DevExpress.XtraPrinting.IPrintingSystem ps = DevExpress.XtraPrinting.PrintHelper.GetCurrentPS();
            ps.AfterChange += new DevExpress.XtraPrinting.ChangeEventHandler(Export_ProgressEx);
            if (ext == "rtf") exportView.ExportToRtf(filename);
            if (ext == "pdf") exportView.ExportToPdf(filename);
            if (ext == "mht") exportView.ExportToMht(filename);
            if (ext == "htm") exportView.ExportToHtml(filename);
            if (ext == "txt") exportView.ExportToText(filename);
            if (ext == "xls") exportView.ExportToXls(filename);
            if (ext == "xlsOld") exportView.ExportToExcelOld(filename);
            ps.AfterChange -= new DevExpress.XtraPrinting.ChangeEventHandler(Export_ProgressEx);
            Cursor.Current = currentCursor;
            EndExport();
        }

        protected virtual void EndExport()
        {
            progressForm.Dispose();
            progressForm = null;
        }

        protected virtual void Export_ProgressEx(object sender, DevExpress.XtraPrinting.ChangeEventArgs e)
        {
            if (e.EventName == DevExpress.XtraPrinting.SR.ProgressPositionChanged)
            {
                int pos = (int)e.ValueOf(DevExpress.XtraPrinting.SR.ProgressPosition);
                progressForm.SetProgressValue(pos);
            }
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
            DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view = gbList;
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
           double qty = 0.0;
           double amt = 0.0;

            if (chxDetail.Checked)
            {
                
                for (int i = 0; i < gbList.RowCount; i++)
                {
                    qty += Convert.ToDouble(gbList.GetRowCellValue(i, "Quantity")==DBNull.Value?0:gbList.GetRowCellValue(i, "Quantity"));
                    amt += Convert.ToDouble(gbList.GetRowCellValue(i, "Amount") == DBNull.Value ? 0 : gbList.GetRowCellValue(i, "Amount"));
                }
                txtQuantity.Value = Convert.ToDecimal(qty);
                txtAmount.Value = Convert.ToDecimal(amt);

                return;
            }

            for (int i = 0; i < dgvDetail.Rows.Count; i++)
           {
               qty += Convert.ToDouble(dgvDetail["Quantity", i].Value);
               amt += Convert.ToDouble(dgvDetail["Amount", i].Value);
           }
           txtQuantity.Value = Convert.ToDecimal(qty);
           txtAmount.Value = Convert.ToDecimal(amt);
        }
    }
}
