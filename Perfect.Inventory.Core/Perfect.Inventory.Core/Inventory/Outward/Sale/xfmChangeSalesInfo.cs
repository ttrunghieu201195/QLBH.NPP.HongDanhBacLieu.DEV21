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
    public partial class xfmChangeInfo : DevExpress.XtraEditors.XtraForm
    {
        public delegate void IdChangedEventHander(object sender, DateTime RefDate, string Description, string CarNumber);
        public event IdChangedEventHander IdChanged;

        private void RaiseGroupChanged(DateTime RefDate, string Description, string CarNumber)
        {
            IdChangedEventHander changed = IdChanged;
            if (changed != null) changed(this,RefDate,Description, CarNumber);
        }

        public xfmChangeInfo()
        {
            InitializeComponent();

            nOTESTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            nOTESTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.NOTES);

            cARSTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            cARSTableAdapter.Fill(dsSTOCK_OUTWARD_DETAIL.CARS);

            txtCreatedDate.DateTime = MyLogin.LoginDate;
            txtCreatedDate.Focus();


        }

         
       
         

        private void xfmGroupChanged_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RaiseGroupChanged(txtCreatedDate.DateTime, 
                (txtStatus.EditValue ?? "").ToString(), 
                (txtCarNumber.EditValue ?? "").ToString());
            Close();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void xfmChangeInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSTOCK_OUTWARD_DETAIL.NOTES' table. You can move, or remove it, as needed.
            this.nOTESTableAdapter.Fill(this.dsSTOCK_OUTWARD_DETAIL.NOTES);

        }
    }
}