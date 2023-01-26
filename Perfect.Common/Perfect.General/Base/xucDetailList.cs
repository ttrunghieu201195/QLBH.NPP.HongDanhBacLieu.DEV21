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
    public partial class xucDetailList : xucBase
    {
        public xucDetailList()
        {
            InitializeComponent();
            Init();
            
        }


        public void Init()
        {
            ucBar.ViewChangedClick += new ButtonClickEventHander(ucBar_ViewChangedClick);
            ucBar.ViewClick += new ButtonClickEventHander(ucBar_ViewClick);
            ucBar.ExportClick += new ButtonClickEventHander(ucBar_ExportClick);
            ucBar.PrintClick += new ButtonClickEventHander(ucBar_PrintClick);
            ucBar.HistoryClick += new ButtonClickEventHander(ucBar_HistoryClick);
            ucBar.ProductDetailClick += new ButtonClickEventHander(ucBar_ProductDetailClick);
            ucBar.CopyClick += new ButtonClickEventHander(ucBar_CopyClick);
            ucBar.StockChanged += new xucBaseBarD.StockChangedEventHander(ucBar_StockChanged);    
            ucBar.From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ucBar.To = ucBar.From.AddMonths(1).AddDays(-1);
            
        }

        protected virtual void StockChanged(object value)
        {
            Reload();
        }

        void ucBar_StockChanged(object sender, object value)
        {
            //throw new NotImplementedException();
            StockChanged(value);
        }

        void ucBar_CopyClick(object sender)
        {
            Copy();
        }

        void ucBar_ProductDetailClick(object sender)
        {
            ProductDetail();
        }

        void ucBar_HistoryClick(object sender)
        {
            History();
        }

        void ucBar_PrintClick(object sender)
        {
            Print();
        }

        void ucBar_ExportClick(object sender)
        {   
            Export();   
        }

        void ucBar_ViewClick(object sender)
        {
            Reload();
        }

        public virtual void Reload(){}


        public virtual void Copy() { }

        public virtual void Print() { }

        public virtual void History() { }

        public virtual void ProductDetail() { }

        void ucBar_ViewChangedClick(object sender)
        {
            Reload();
        }

        protected xucBaseBarD Bar
        {
            get { return ucBar; }
        }
    }
}
