using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;

namespace Perfect.Common
{
    public partial class xfmBase : XtraForm
    {
        public event ButtonClickEventHander Expanded;
        public event ButtonClickEventHander AddClick;
        public delegate void SendIDEventHander(string ID);

        protected bool Simple = true;

        public event SendIDEventHander SendID;



        protected void RaiseExpandedEventHander()
        {
            if (Expanded != null) Expanded(this);
        }

        protected void RaiseSendIDEventHander(string id)
        {
            if (SendID != null) SendID(id);
        }

        protected void RaiseAddClickEventHander()
        {
            if (AddClick != null) AddClick(this);
        }


        public xfmBase()
        {
            InitializeComponent();
        }
    }
}