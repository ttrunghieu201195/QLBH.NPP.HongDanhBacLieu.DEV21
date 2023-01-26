using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Inventory
{
    public partial class xfmSearch : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ViewClick(string Id,string status);

        public event ViewClick View;

        public void RaiseViewClickEventHandle(string Id, string status)
        {
            if (View != null) View(Id,status);
        }



        public xfmSearch()
        {
            InitializeComponent();
            xucSearch.CloseClick += new Perfect.Common.ButtonClickEventHander(xucSearch_CloseClick);
            xucSearch.View += new xucSearch.ViewClick(xucSearch_View);
            xucSearch.Init();
        }

        void xucSearch_View(string Id, string status)
        {
            RaiseViewClickEventHandle(Id,status);
        }

        void xucSearch_CloseClick(object sender)
        {
            Close();
        }
    }
}