using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Inventory.Core.Common.Forms
{
    public partial class xfmPrintOptionsOutward : DevExpress.XtraEditors.XtraForm
    {
        public delegate void OptionsSelectedEventArg(int option);
        public event OptionsSelectedEventArg OptionsSelected;

        private int m_Options = 0;
        public xfmPrintOptionsOutward()
        {
            InitializeComponent();
            ControlBox = false;
            Text = "Tùy Chọn In Phiếu Xuất";

            treeOptions.ExpandAll();
        }

        private void RaiseOptionsSelected(int _opt)
        {
            if (OptionsSelected != null) OptionsSelected(_opt);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RaiseOptionsSelected(m_Options);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RaiseOptionsSelected(0);
            Close();
        }

        private void treeOptions_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            m_Options = Convert.ToInt32(e.Node[colID]);
        }
    }
}