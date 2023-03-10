using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Perfect.ERP;
using Perfect.Common;
using Perfect.Common.Report;

namespace Perfect.Inventory.Report
{
    public partial class xfmReportManagers : DevExpress.XtraEditors.XtraForm
    {
        private string _reportId;
        private string _reportName;

        public xfmReportManagers()
        {
            InitializeComponent();
           // SYS_OPTION.ReportLanguage = "EN";
            
            this.rEPORTTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            this.rEPORTTableAdapter.Fill(this.dsReportManager.REPORT, SYS_OPTION.ReportLanguage);

            if (CODE.TypeSoft == 1)
            {
                dsReportManager.REPORT.Rows.RemoveAt(11);
                dsReportManager.REPORT.Rows.RemoveAt(10);
                dsReportManager.REPORT.Rows.RemoveAt(9);
                dsReportManager.REPORT.Rows.RemoveAt(8);
                dsReportManager.REPORT.Rows.RemoveAt(7);
                dsReportManager.REPORT.Rows.RemoveAt(3);
            }

            tlReport.ExpandAll();
            colReport_Name.Caption = (SYS_OPTION.Language == "EN" ? "Report" : colReport_Name.Caption);
            //CONTROL_FORMAT.Save("REPORT");
            bm.SetPopupContextMenu(this, pm);
            Init();
        }

        protected void Init()
        {
            //STOCK a = new STOCK();
            //a.AddCombo(cbxStock);
            //PRODUCT b = new PRODUCT();
           // b.AddComboAll(cbxProduct); 

            btnPreview.Text = (SYS_OPTION.Language == "EN" ? "Preview" : btnPreview.Text);
            btnPrint.Text = (SYS_OPTION.Language == "EN" ? "Print" : btnPrint.Text);

            dtFrom.DateTime = new DateTime(clsLogin.LoginDate.Year, clsLogin.LoginDate.Month,1);
            dtTo.DateTime = dtFrom.DateTime.AddMonths(1).AddDays(-1);

            dtFrom1.DateTime = dtFrom.DateTime;
            dtTo1.DateTime = dtTo.DateTime;

            STOCK stock = new STOCK();

            DataTable dt = stock.GetList();
            if (dt.Rows.Count == 0) return;
            
            GridColumn col1 = cbxStock.Properties.View.Columns.AddField("Stock_ID");
            col1.VisibleIndex = 0;
            col1.Width = 80;
            col1.Caption = "Mã kho";
            col1.OptionsColumn.FixedWidth = true;
            GridColumn col2 = cbxStock.Properties.View.Columns.AddField("Stock_Name");
            col2.VisibleIndex = 1;
            col2.Caption = "Tên kho";
            col2.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            col2.OptionsColumn.FixedWidth = true;
            col2.Width = 200;


            GridColumn col4 = txtStock1.Properties.View.Columns.AddField("Stock_ID");
            col4.VisibleIndex = 0;
            col4.Width = 80;
            col4.Caption = "Mã kho";
            col4.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            col4.OptionsColumn.FixedWidth = true;
            GridColumn col5 = txtStock1.Properties.View.Columns.AddField("Stock_Name");
            col5.VisibleIndex = 1;
            col5.Caption = "Tên kho";
            col5.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            col5.OptionsColumn.FixedWidth = true;
            col5.Width = 200;




            cbxStock.Properties.DataSource = dt;
            cbxStock.Properties.ValueMember = "Stock_ID";
            cbxStock.Properties.DisplayMember = "Stock_Name";

            txtStock1.Properties.DataSource = dt;
            txtStock1.Properties.ValueMember = "Stock_ID";
            txtStock1.Properties.DisplayMember = "Stock_Name";

            if (dt.Rows.Count > 0)
            {
                cbxStock.EditValue = dt.Rows[0]["Stock_ID"];
            }

          
        }

        private void RunReport(string key, string mame,bool previewer)
        {
            //this.Enabled = false;
            Options.SetWaitDialogCaption("Đang nạp dữ liệu...");
            Cursor.Current = Cursors.WaitCursor;
            xucBaseReportControls uc=null;
            lblTitle.Text = mame.ToUpper();

            if (plMain.Controls.Count > 0) plMain.Controls.Clear();

            if (key == "RD0000001")
            {
                if (SYS_USER_RULE.Get(clsLogin.Group, "bbiStock_Card") != "OK") return;
                if (!SYS_USER_RULE.AllowAccess)
                {
                    SYS_USER_RULE.Notify();
                    return;
                }

                uc = new xucStockCards();
                uc.ID = key;
                //uc.Action(dtFrom.DateTime,dtTo.DateTime,cbxStock.SelectedValue.ToString(),cbxProduct.EditValue.ToString(),previewer);
                uc.Dock = DockStyle.Fill;
                //uc.Title = mame;
                uc.ID = key;
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000002")
            {
                if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryLeeder") != "OK") return;
                if (!SYS_USER_RULE.AllowAccess)
                {
                    SYS_USER_RULE.Notify();
                    return;
                }
                
                uc = new xucInvetoryLedgers();
                uc.Dock = DockStyle.Fill;
                //uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000003")
            {

                uc = new xucInvetoryQuantitys();
                uc.Dock = DockStyle.Fill;
                
               // uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                ((xucInvetoryQuantitys)uc).Part = 1;    
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000004")
            {
                uc = new xucInventorySummarys();
                uc.Dock = DockStyle.Fill;
                //uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                ((xucInventorySummarys)uc).Part = 1; 
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000005")
            {
                uc = new xucInventoryReports();
                uc.Dock = DockStyle.Fill;
                //uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                //uc.Title = mame;
                uc.ID = key;
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000006")
            {
                uc = new xucInventoryDetaiReports();
                uc.Dock = DockStyle.Fill;
                //uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                plMain.Controls.Add(uc);
            }

            else if (key == "RD0000007")
            {
                if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailOverLimit") != "OK") return;
                if (!SYS_USER_RULE.AllowAccess)
                {
                    SYS_USER_RULE.Notify();
                    return;
                }

                uc = new xucInventoryDetail_OrverLimits();
                uc.Dock = DockStyle.Fill;
               // uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                plMain.Controls.Add(uc);
            }

            else if (key == "RD0000008")
            {

                uc = new xucInventoryDetail_Olds();
                uc.Dock = DockStyle.Fill;
                //uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                plMain.Controls.Add(uc);
            }

            else if (key == "RD0000009")
            {
                if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailOver") != "OK") return;
                if (!SYS_USER_RULE.AllowAccess)
                {
                    SYS_USER_RULE.Notify();
                    return;
                }
                uc = new xucInventoryOvers();
                uc.Dock = DockStyle.Fill;
               // uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000010")
            {
                uc = new xucStockCardDNs();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
               // uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000011")
            {
                if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                if (!SYS_USER_RULE.AllowAccess)
                {
                    SYS_USER_RULE.Notify();
                    return;
                }

                uc = new xucInventoryBelowers();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000027")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucSummarys();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                ((xucSummarys)uc).Part = 1;   
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000028")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucSumTranIn();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                ((xucSumTranIn) uc).StockName = cbxStock.Text;
                plMain.Controls.Add(uc);
                //return;
            }
            else if (key == "RD0000029")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucSumTranOut();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;

                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000031")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucInwardDetailList();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                //((xucSumTranIn)uc).StockName = cbxStock.Text;
                plMain.Controls.Add(uc);
                //return;
            }
            else if (key == "RD0000033")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucOutwardDetailList();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                //((xucSumTranIn)uc).StockName = cbxStock.Text;
                plMain.Controls.Add(uc);
                //return;
            }
            else if (key == "RD0000035")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucTransferDetailList();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                //((xucSumTranIn)uc).StockName = cbxStock.Text;
                plMain.Controls.Add(uc);
                //return;
            }
            else if (key == "RD0000037")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucAdjustDetailList();
                uc.Dock = DockStyle.Fill;
                uc.ID = key;
                //((xucSumTranIn)uc).StockName = cbxStock.Text;
                plMain.Controls.Add(uc);
                //return;
            }
            else if (key == "RD0000038")
            {

                uc = new xucInvetoryQuantitys();
                uc.Dock = DockStyle.Fill;

                // uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                ((xucInvetoryQuantitys)uc).Part = 2;
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000039")
            {
                uc = new xucInventorySummarys();
                uc.Dock = DockStyle.Fill;
                //uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.SelectedValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
                uc.ID = key;
                ((xucInventorySummarys)uc).Part = 2;    
                plMain.Controls.Add(uc);
            }
            else if (key == "RD0000040")
            {
                //if (SYS_USER_RULE.Get(clsLogin.Group, "bbiInventoryDetailBelow") != "OK") return;
                //if (!SYS_USER_RULE.AllowAccess)
                //{
                //    SYS_USER_RULE.Notify();
                //    return;
                //}

                uc = new xucSummarys();
                uc.Dock = DockStyle.Fill;
                ((xucSummarys)uc).Part = 2;     
                uc.ID = key;

                plMain.Controls.Add(uc);
            
            }

            if (uc != null)
                uc.Action(dtFrom.DateTime, dtTo.DateTime, cbxStock.EditValue.ToString(), cbxProduct.EditValue.ToString(), previewer);
            Options.SetWaitDialogCaption(("Hoàn tất."));
            Cursor.Current = Cursors.Default;
            Options.Close();
            //this.Enabled = true;
        }

        private void tlReport_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                _reportId = e.Node.GetValue("Report_ID").ToString();
                //MessageBox.Show(_reportId.ToString());
                _reportName = e.Node.GetDisplayText("Report_Name").ToUpper();
                lblTitle.Text = _reportName;
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            RunReport(_reportId,_reportName,true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xfmReportManagers_Load(object sender, EventArgs e)
        {
            pRODUCTTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            this.pRODUCTTableAdapter.Fill(dsPRODUCT.PRODUCT);
            dsPRODUCT.PRODUCT.AddPRODUCTRow("All", "Tất cả");

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RunReport(_reportId, _reportName, false);
        }

        private void tlReport_DoubleClick(object sender, EventArgs e)
        {
            RunReport(_reportId, _reportName, true);
        }

        public void SetData(string key)
        {
            //colReport_Name.Caption = (SYS_OPTION.Language == "EN" ? "Report" : colReport_Name.Caption);
            //this.rEPORTTableAdapter.Fill(this.dsReportManager.REPORT, SYS_OPTION.Language);

            //if (PerfectSolutions.Bin.RegisterSystem.Type > 1)
            //{
            //    dsReportManager.REPORT.Rows.RemoveAt(11);
            //    dsReportManager.REPORT.Rows.RemoveAt(10);
            //    dsReportManager.REPORT.Rows.RemoveAt(9);
            //    dsReportManager.REPORT.Rows.RemoveAt(8);
            //    dsReportManager.REPORT.Rows.RemoveAt(7);
            //    dsReportManager.REPORT.Rows.RemoveAt(3);
            //}

            //tlReport.ExpandAll();

            REPORT REPORT = new REPORT();
            REPORT.Get(key, SYS_OPTION.Language);
            RunReport(key, REPORT.Title,true);
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPreview_Click(sender,e);
        }

        private void bbiPrinted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPrint_Click(sender,e);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPreview_Click(sender,e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pcc.HidePopup();
        }

        private void txtStock1_EditValueChanged(object sender, EventArgs e)
        {
            cbxStock.EditValue = txtStock1.EditValue;
        }

        private void txtProduct1_EditValueChanged(object sender, EventArgs e)
        {
            cbxProduct.EditValue = txtProduct1.EditValue;
        }

        private void dtFrom1_EditValueChanged(object sender, EventArgs e)
        {
            dtFrom.DateTime = dtFrom1.DateTime;
        }

        private void dtTo1_EditValueChanged(object sender, EventArgs e)
        {
            dtTo.DateTime = dtTo1.DateTime;
        }
    }
}