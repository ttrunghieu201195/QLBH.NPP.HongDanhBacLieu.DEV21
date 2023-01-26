using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;

namespace Perfect.Dictionary
{
    public partial class xfmCar : DevExpress.XtraEditors.XtraForm
    {
        public xfmCar()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ucList.ReLoad();
            ucList.CloseClick += new Perfect.Common.ButtonClickEventHander(ucList_CloseClick);
            Text = (SysOption.Language == "EN" ? "Car" : Text);
        }

        void ucList_CloseClick(object sender)
        {
            Close();
        }
    }
}