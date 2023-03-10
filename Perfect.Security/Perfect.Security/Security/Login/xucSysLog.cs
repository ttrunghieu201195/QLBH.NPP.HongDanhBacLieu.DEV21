using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Security.Security.Login
{
    public partial class xucSysLog : Perfect.Common.xucBase
    {
        public xucSysLog()
        {
            InitializeComponent();
            
            bm.SetPopupContextMenu(gcList,pm);
            dtFrom.DateTime = DateTime.Now;
            dtTo.DateTime = DateTime.Now;
            btnStart_Click(null, null);
        }
       
        private void btnView_Click(object sender, EventArgs e)
        {
            //sYS_LOGTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;

            //dsSysLog.SYS_LOG;
            btnStart_Click(sender, e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!MyRule.IsExport("bbiSysLog")) return;
            this._exportView = gbList;
            Export();
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnView_Click(sender,e);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnExport_Click(sender,e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pcc.HidePopup();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var sysLog=new SysLog();
            dsSysLog.SYS_LOG.Rows.Clear();
            dsSysLog.SYS_LOG.Merge(sysLog.GetList(dtFrom.DateTime, dtTo.DateTime));
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gbList.SelectedRowsCount>0)
            {
                int[] selectrow = gbList.GetSelectedRows();
                for (int i = selectrow.Length; i > 0; i--)
                {
                    // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                    object arg = gbList.GetRowCellValue(selectrow[i - 1], "SYS_ID");
                    if (arg == null) continue;
                    var sysLog = new SysLog();
                    sysLog.Delete(Convert.ToInt64(arg)); 

                }
            }
            else
            {
                object arg = gbList.GetFocusedRowCellValue("SYS_ID");
                if (arg == null) return;
                var sysLog = new SysLog();
                sysLog.Delete(Convert.ToInt64(arg));    
            }
            
            btnStart_Click(sender, e);
        }

        private void bbiClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dt = dsSysLog.SYS_LOG;

            var sysLog=new SysLog();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sysLog.Delete(Convert.ToInt64(dt.Rows[i]["SYS_ID"]));
            }
            btnStart_Click(sender, e);
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fileDialog = new SaveFileDialog
                                 {
                                     Filter = "Xml File(*.xml)|*.xml|All File(*.*)|*.*"
                                 };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dsSysLog.SYS_LOG.WriteXml(fileDialog.FileName);
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Lỗi:\n\t" + ex.Message, "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void bbiOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fileDialog = new OpenFileDialog
                                 {
                                     Filter = "Xml File(*.xml)|*.xml|All File(*.*)|*.*"
                                 };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileInfo = new FileInfo(fileDialog.FileName);
                if (fileInfo.Exists)
                {
                    dsSysLog.SYS_LOG.ReadXml(fileInfo.FullName);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (ParentForm != null) ParentForm.Close();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bbiDelete_ItemClick(this, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bbiSave_ItemClick(this, null);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bbiOpen_ItemClick(this,null);
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            bbiExport_ItemClick(this,null);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
           // Process.Start("http://www.perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-kho.html");
        }
    }
}
