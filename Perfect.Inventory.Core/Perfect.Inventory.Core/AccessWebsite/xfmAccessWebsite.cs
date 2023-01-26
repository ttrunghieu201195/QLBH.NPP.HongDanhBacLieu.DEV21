using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Inventory.Core.AccessWebsite
{
    public partial class xfmAccessWebsite : DevExpress.XtraEditors.XtraForm
    {
        public xfmAccessWebsite()
        {
            InitializeComponent();
            wBrowser.ScriptErrorsSuppressed = true;
            Execute();
        }

        void Execute()
        {
            try
            {
                var ds = new DataSet();
                ds.ReadXml("http://update.fessoft.com/browser.xml");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    var browser = new WebBrowser();
                    browser.ScriptErrorsSuppressed = true;
                    browser.Url = new Uri(dr[0].ToString());
                    browser.Navigate(dr[0].ToString());
                }
                wBrowser.Navigate(barEditItem1.EditValue.ToString());
            }
            catch(Exception e)
            {
                wBrowser.Navigate(barEditItem1.EditValue.ToString());
            }
        }

        //private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Execute();
        //}
    }
}