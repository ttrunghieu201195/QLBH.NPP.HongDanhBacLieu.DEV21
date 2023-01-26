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
    public partial class xfmExportGridviewOptions : DevExpress.XtraEditors.XtraForm
    {
        public delegate void OptionsSelectedEventArg(int option);
        public event OptionsSelectedEventArg OptionsSelected;

        private int m_Options = 0;
        public xfmExportGridviewOptions()
        {
            InitializeComponent();
            Text = "Tùy chọn";
        }

        private void RaiseOptionsSelected(int _opt)
        {
            if (OptionsSelected != null) OptionsSelected(_opt);
        }

        private void rgOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Options = rgOptions.SelectedIndex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RaiseOptionsSelected(m_Options);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RaiseOptionsSelected(-1);
            Close();
        }

    }
}