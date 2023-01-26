using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Common
{
    public partial class xucBaseDetailX : DevExpress.XtraEditors.XtraUserControl
    {
        
        DataTable dt = new DataTable();

        public DataTable Data
            {
                get{ return dt;}
                set { dt = value; }

            }

        public xucBaseDetailX()
        {
            InitializeComponent();
            gcList.DataSource = dt;
        }

        public void Clear()
        {
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
        }
    }
}
