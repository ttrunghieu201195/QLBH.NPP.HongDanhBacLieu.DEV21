using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Sale.Core.REICEIPT
{
    public partial class xfmReceiptOptions : DevExpress.XtraEditors.XtraForm
    {
        public delegate void MyOptions(int _chosen);
        public event MyOptions OptionsChosen;
        private int _Index = 0;
        public xfmReceiptOptions()
        {
            InitializeComponent();
            treeOptions.ExpandAll();
        }

        private void RaiseOption(int _type)
        {
            if (OptionsChosen != null)
                OptionsChosen(_type);
        }

        private void treeOptions_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            _Index = Convert.ToInt32(e.Node[colID]);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RaiseOption(_Index);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RaiseOption(0);
            Close();
        }
    }
}