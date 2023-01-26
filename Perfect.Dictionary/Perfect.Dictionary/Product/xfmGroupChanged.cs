using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.Dictionary.ProductGroup;
using Perfect.ERP;

namespace Perfect.Dictionary.Product
{
    public partial class xfmGroupChanged : DevExpress.XtraEditors.XtraForm
    {
        public delegate void GroupChangedEventHander(object sender, string id);
        public event GroupChangedEventHander GroupChanged;

        private void RaiseGroupChanged(string id)
        {
            GroupChangedEventHander changed = GroupChanged;
            if (changed != null) changed(this,id);
        }

        public xfmGroupChanged()
        {
            InitializeComponent();
        }

        private void cbxGroup_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                XfmProductGroupAdd productGroupAdd = new XfmProductGroupAdd(Actions.Add);
                productGroupAdd.Added += new XfmProductGroupAdd.AddedEventHander(productGroupAdd_Added);
                productGroupAdd.ShowDialog();
            }
        }

        void productGroupAdd_Added(object sender, PRODUCT_GROUP Item)
        {
            Product_Group();
            cbxGroup.EditValue = Item.ProductGroup_ID;
        }

        private void xfmGroupChanged_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPRODUCTGROUP.PRODUCT_GROUP' table. You can move, or remove it, as needed.
          //  this.pRODUCT_GROUPTableAdapter.Fill(this.dsPRODUCTGROUP.PRODUCT_GROUP);
            Product_Group();
        }

        void Product_Group()
        {
            pRODUCT_GROUPTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            pRODUCT_GROUPTableAdapter.Fill(dsPRODUCTGROUP.PRODUCT_GROUP);
            if (cbxGroup.Text == "")
            {
                if (dsPRODUCTGROUP.PRODUCT_GROUP.Rows.Count > 0) cbxGroup.EditValue = dsPRODUCTGROUP.PRODUCT_GROUP.Rows[0]["ProductGroup_ID"];

            }
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
            if (cbxGroup.EditValue==null)return;
            string id = cbxGroup.EditValue.ToString();
            RaiseGroupChanged(id);
            Close();
        }
    }
}