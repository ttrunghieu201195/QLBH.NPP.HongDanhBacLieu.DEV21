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
    public partial class xfmItemSearch : DevExpress.XtraEditors.XtraForm
    {
        public xfmItemSearch()
        {
            InitializeComponent();
        }

        private void xfmItemSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSearch.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.dsSearch.PRODUCT);

        }

        private void btView_Click(object sender, EventArgs e)
        {
            dsSearch.PRODUCT.DefaultView.RowFilter = "Product_ID like '%" + txtProductID.Text +
                                                     "%' and Product_Name like '%" + txtProductName.Text + "%'";
        }
    }
}