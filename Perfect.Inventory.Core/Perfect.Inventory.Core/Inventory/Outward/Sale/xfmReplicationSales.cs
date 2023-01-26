using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.ERP;
using Perfect.Data.Helper;

namespace Perfect.Dictionary.Product
{
    public partial class xfmReplicationSales : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ReplicationEventHander(object sender, 
           string SaleID, DateTime RefDate, string Description, string CustomerID);
        public event ReplicationEventHander ReplicationSales;

        private void RaiseReplicationSales(string SaleID, DateTime RefDate, string Description, string CustomerID)
        {
            ReplicationEventHander changed = ReplicationSales;
            if (changed != null) changed(this, SaleID, RefDate, Description, CustomerID);
        }

        public xfmReplicationSales()
        {
            InitializeComponent();

            nOTESTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            nOTESTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.NOTES);

            cUSTOMERTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cUSTOMERTableAdapter.Fill(dsCUSTOMERS.CUSTOMER);

            txtCreatedDate.DateTime = MyLogin.LoginDate;
            txtCreatedDate.Focus();

            var cls = new STOCK_OUTWARD();
            txtSaleID.Text = cls.CreateKey("BH_" + MyLogin.Account + "_");
            txtSaleID.Properties.ReadOnly = false;

        } 
          

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtCustomer.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn thông tin Khách hàng","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCustomer.Focus();

                return;
            }

            RaiseReplicationSales(
                txtSaleID.Text,
                txtCreatedDate.DateTime, 
                (txtStatus.EditValue ?? "").ToString(),
                (txtCustomer.EditValue ?? "").ToString()
                );

            Close();
        }

    }
}