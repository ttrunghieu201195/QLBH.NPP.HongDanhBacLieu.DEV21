using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary.Barcode
{
    public partial class xfmPriceOptions : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ItemPriceToPrintArg(int _id);
        public event ItemPriceToPrintArg PriceToPrint;

        private int PriceType = 0;
        public xfmPriceOptions()
        {
            InitializeComponent();
            colNumID.Visible = false;
            treeList1.ExpandAll();
        }

        private void RaisePrice(int _id)
        {
            if (PriceToPrint != null) PriceToPrint(_id);
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            PriceType = Convert.ToInt32(e.Node["NumID"].ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RaisePrice(PriceType);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RaisePrice(-99);
            Close();
        }

        private void xfmPriceOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}