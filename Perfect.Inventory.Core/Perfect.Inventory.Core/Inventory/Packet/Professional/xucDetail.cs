using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.Inventory.Core.Common.DS.dsSTOCKTableAdapters;
using Perfect.Inventory.Core.Common.DS.dsUnitTableAdapters;
using Perfect.Inventory.Core.Inventory.Inward.dsSTOCK_INWARD_DETAILTableAdapters;
using Perfect.Inventory.Core.Inventory.Outward.dsSTOCK_OUTWARD_DETAILTableAdapters;
using Perfect.Inventory.Core.Inventory.Transfer.dsSTOCK_TRANSFER_DETAILTableAdapters;
using STOCK_TRANSFER_DETAILTableAdapter=
    Perfect.Inventory.Core.Inventory.Packet.DS.dsPACKETTableAdapters.STOCK_TRANSFER_DETAILTableAdapter;

namespace Perfect.Inventory.Core.Inventory.Packet
{
    public partial class xucDetail : xucBase
    {
        public xucDetail()
        {
            InitializeComponent();
            
        }

        public void SetData(string ID,int refType)
        {
            var adapter=new STOCK_TRANSFER_DETAILTableAdapter();
            adapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            adapter.Fill(dsPACKET.STOCK_TRANSFER_DETAIL, ID, refType);

        }

        
    }
}
