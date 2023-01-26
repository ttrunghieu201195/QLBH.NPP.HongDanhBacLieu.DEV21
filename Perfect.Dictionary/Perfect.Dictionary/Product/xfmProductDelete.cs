using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary.Product
{
    public partial class xfmProductDelete : DevExpress.XtraEditors.XtraForm
    {
        public xfmProductDelete()
        {
            InitializeComponent();
        }

        private void xfmProductDelete_Load(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            // TODO: This line of code loads data into the 'dsProductDel.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.dsProductDel.PRODUCT);
            this.stocK_INWARD_DETAILTableAdapter.Fill(this.dsProductDel.STOCK_INWARD_DETAIL);
            this.inventorY_DETAILTableAdapter.Fill(this.dsProductDel.INVENTORY_DETAIL);
            this.stocK_OUTWARD_DETAILTableAdapter.Fill(this.dsProductDel.STOCK_OUTWARD_DETAIL);
            
            

        }

        
    }
}