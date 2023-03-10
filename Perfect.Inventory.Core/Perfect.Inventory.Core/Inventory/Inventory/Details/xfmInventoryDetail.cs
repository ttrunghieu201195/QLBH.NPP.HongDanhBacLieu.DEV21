using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Inventory.Details.TS;

namespace Perfect.Inventory
{
    public partial class xfmInventoryDetail : XtraForm
    {

        xucInventoryDetail ucDetail = new xucInventoryDetail();
        xucInventorySummarys ucSummarys = new xucInventorySummarys();
        xucInventoryDetailBFC ucDetailBFC = new xucInventoryDetailBFC();
        
        private int _index = 0;

        public xfmInventoryDetail()
        {
            InitializeComponent();
            //ucDetailBFC.Dock = DockStyle.Fill;
            ucDetail.Dock = DockStyle.Fill;
            //ucSummarys.Dock = DockStyle.Fill;
            Controls.Clear();

            //if (CODE.TypeSoft==302)
            //{
            //    Controls.Add(ucDetailBFC);
            //}
            //else
            //{
            //    Controls.Add(ucDetail);   
            //}

            Controls.Add(ucDetail);   
           

        }


        public void SetData(string product_id, string product_name)
        {
            ucDetail.SetData(product_id, product_name);
        }

        //private void btnDetail_Click(object sender, EventArgs e)
        //{
        //    if (_index==0) return;
        //    if (ucDetail==null)
        //    {
        //        ucDetail=new xucInventoryDetail();
        //    }
        //    plMain.Controls.Clear();
        //    ucDetail.SetColumns(0);
        //    ucDetail.Dock = DockStyle.Fill;
        //    plMain.Controls.Add(ucDetail);
        //    ucDetail.Reload();
        //    Abort();
        //    _index = 0;
        //   // btnDetail.Enabled = false;
        //}

        //void Abort()
        //{
        //    switch (_index)
        //    {
        //        case 0:
        //            btnDetail.Checked = false;
        //            break;
        //        case 1:
        //            btnSummary.Checked = false;
        //            break;
        //        case 2:
        //            btnLimit.Checked = false;
        //            break;
        //        case 3:
        //            btnBatch.Checked = false;
        //            break;
        //    }
        //}

        //private void btnSummary_Click(object sender, EventArgs e)
        //{
        //    if (_index == 1) return;
        //    if (ucSummarys == null)
        //    {
        //        ucSummarys = new xucInventorySummarys();
        //    }
        //    plMain.Controls.Clear();
        //    ucSummarys.Dock = DockStyle.Fill;
        //    plMain.Controls.Add(ucSummarys);
        //    ucSummarys.Reload();
        //    Abort();
        //    _index = 1;
        //    //btnSummary.Enabled = false;
        //}

        //private void btnLimit_Click(object sender, EventArgs e)
        //{
        //    if (_index == 2) return;
        //    if (ucDetail == null)
        //    {
        //        ucDetail = new xucInventoryDetail();
        //    }
        //    ucDetail.Dock = DockStyle.Fill;
        //    ucDetail.SetColumns(1);
        //    plMain.Controls.Clear();
        //    plMain.Controls.Add(ucDetail);
        //    ucDetail.Reload();
        //    Abort();
        //    _index = 2;
        //   // btnLimit.Enabled = false;
        //}

        //private void btnBatch_Click(object sender, EventArgs e)
        //{
        //    if (_index == 3) return;
        //    if (ucDetail == null)
        //    {
        //        ucDetail = new xucInventoryDetail();
        //    }
        //    plMain.Controls.Clear();
        //    ucDetail.Dock = DockStyle.Fill;
        //    ucDetail.SetColumns(2);
        //    plMain.Controls.Add(ucDetail);
        //    ucDetail.Reload();
        //    Abort();
        //    _index = 3;
        //   // btnBatch.Enabled = false;
        //}

        //private void btnBatch2_Click(object sender, EventArgs e)
        //{
        //    if (_index == 4) return;
        //    if (ucDetail == null)
        //    {
        //        ucDetail = new xucInventoryDetail();
        //    }
        //    plMain.Controls.Clear();
        //    ucDetail.Dock = DockStyle.Fill;
        //    ucDetail.SetColumns(3);
        //    plMain.Controls.Add(ucDetail);
        //    ucDetail.Reload();
        //    Abort();
        //    _index = 4;
        //}

        //private void btnDetail_MouseHover(object sender, EventArgs e)
        //{
        //    lblMessage.Text = "Tồn kho chi tiết";
        //}

        //private void btnSummary_MouseHover(object sender, EventArgs e)
        //{
        //    lblMessage.Text = "Tồn kho tổng hợp";
        //}

        //private void btnLimit_MouseHover(object sender, EventArgs e)
        //{
        //    lblMessage.Text = "Tồn kho theo hạn sử dụng";
        //}

        //private void btnBatch_MouseHover(object sender, EventArgs e)
        //{
        //    lblMessage.Text = "Tồn kho theo lô";
        //}

        //private void btnBatch2_MouseHover(object sender, EventArgs e)
        //{
        //    lblMessage.Text = "Tồn kho theo lô và hạn sử dụng";
        //}

    }
}