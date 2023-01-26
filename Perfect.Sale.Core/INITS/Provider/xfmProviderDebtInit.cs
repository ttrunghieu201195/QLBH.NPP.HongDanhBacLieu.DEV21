using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Sale.Core.INITS.Provider.UI;

namespace Perfect.Sale.Core
{
    public partial class xfmProviderDebtInit : DevExpress.XtraEditors.XtraForm
    {
        public xfmProviderDebtInit()
        {
            InitializeComponent();
            ucDebt.Init();
            ucDebt.CloseClick += new XucProviderDebtInit.CloseClickEventHander(ucDebt_CloseClick);
        }

        void ucDebt_CloseClick(object sender)
        {
            Close();
        }
    }
}