using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Inventory.Core.Inventory.Inventory.Revenue
{
    public partial class xfmInventoryRevenue : DevExpress.XtraEditors.XtraForm
    {
        public xfmInventoryRevenue()
        {
            InitializeComponent();
            xucInventoryRevenue uc=new xucInventoryRevenue();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}