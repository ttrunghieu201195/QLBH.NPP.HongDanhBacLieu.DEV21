using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Perfect.Dictionary.Product._502.TS
{
    public partial class xfmProUnit : DevExpress.XtraEditors.XtraForm
    {
        xucProUnit ProUnit = new xucProUnit();
       
        public xfmProUnit()
        {
            InitializeComponent();
            Init();
        }

        public xfmProUnit(string id,string unit)
        {
            
            InitializeComponent();
            Init();
            ProUnit.SetData(id,unit);
           
        }
 

        public delegate void SaveEventHander(DataTable dt);
        public event SaveEventHander Save;
        public void RaiseSaveEventHander(DataTable dt)
        {
            if (Save != null)
            {
                Save(dt);
            }
        }

       
        private void Init()
        {
            ProUnit.Dock = DockStyle.Fill;
            Controls.Add(ProUnit);
            ProUnit.Cancel += new xucProUnit.ClickCancelEventHander(ProUnit_Cancel);
            ProUnit.Save += new xucProUnit.ClickSaveEventHander(ProUnit_Save);
        }

        void ProUnit_Save(DataTable dt)
        {
            RaiseSaveEventHander(dt);
            this.Close();
            
        }

        void ProUnit_Cancel()
        {
           this.Close();
        }
    }
}