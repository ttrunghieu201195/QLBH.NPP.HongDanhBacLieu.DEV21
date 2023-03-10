using System;
using DevExpress.XtraEditors;
//using RowClickEventArgs = Perfect.Common.Class.RowClickEventArgs;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;

namespace Perfect.Common.Base
{
    public partial class xucBasicListSearchProduct : xucBase
    {
        #region Delegates

        #endregion

        private ListType _listType = ListType.General;

        protected RowClickEventArgs RowClick = new RowClickEventArgs();


        public xucBasicListSearchProduct()
        {
            InitializeComponent();
        }

        public DateTime From
        {
            get { return Bar.From; }
            private set { Bar.From = value; }
        }

        public DateTime To
        {
            get { return Bar.To; }
            private set { Bar.To = value; }
        }

        public ListType ListStyle
        {
            get { return _listType; }
            set { _listType = value; }
        }

        public void Init()
        {
            //CreateWaitDialog();

            Bar.ViewClick += UcToolBarViewClick;
            Bar.ExportClick += UcToolBarExportClick;
            Bar.PrintClick += UcToolBarPrintClick;
            Bar.EditClick += UcToolBarEditClick;
            Bar.DeleteClick += UcToolBarDeleteClick;
            Bar.AddClick += UcToolBarAddClick;
            Bar.DetailClick += UcToolBarDetailClick;
            Bar.HelpClick += ucToolBar_HelpClick;
            Bar.CloseClick += UcToolBarCloseClick;
            Bar.ProductDetailClick += UcToolBarProductDetailClick;
            Bar.HistoryClick += UcToolBarHistoryClick;
            Bar.InventoryClick += UcToolBarInventoryClick;
            Bar.DetailHistoryClick += UcToolBarDetailHistoryClick;
            Bar.DetailInventoryClick += UcToolBarDetailInventoryClick;
            Bar.DetailProductClick += UcToolBarDetailProductClick;
            Bar.CopyClick += UcToolBarCopyClick;
            Bar.MirrorClick += UcToolBarMirrorClick;
            Bar.StockChanged += Bar_StockChanged;
            //Bar.CustomColumnClick += Bar_CustomColumnClick;
            DisableMenu(true);
            From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            To = From.AddMonths(1).AddDays(-1);

            Bar.ShowProduct();

            DoHide();
        }

        public void Bar_StockChanged(object sender, object value)
        {
            Reload();
        }

        void Bar_CustomColumnClick(object sender)
        {
            CustomColumn();
        }

        protected void CustomColumn()
        { }

        public void Mirror()
        {
        }

        void UcToolBarMirrorClick(object sender)
        {
            Mirror();
        }

        void UcToolBarCopyClick(object sender)
        {
            Copy();
        }

        protected void Copy()
        {
            
        }

        void UcToolBarDetailProductClick(object sender)
        {
            DetailProduct();
        }

        void UcToolBarDetailInventoryClick(object sender)
        {
            DetailInventory();
        }

        public void DetailProduct()
        {
        }

        public void DetailInventory()
        {
        }

        public void DetailHistory()
        {
        }

        void UcToolBarDetailHistoryClick(object sender)
        {
            DetailHistory();
        }

        public virtual void Inventory()
        {
        }

        private void UcToolBarInventoryClick(object sender)
        {
            Inventory();
        }

        private void UcToolBarHistoryClick(object sender)
        {
            History();
        }

        public virtual void ProductDetail()
        {
        }

        public virtual void History()
        {
        }

        private void UcToolBarProductDetailClick(object sender)
        {
            ProductDetail();
        }

        

        private void UcToolBarCloseClick(object sender)
        {
            if (ParentForm != null) ParentForm.Close();
        }

        private void ucToolBar_HelpClick(object sender)
        {
        }

        public virtual void Detail()
        {
        }

        private void UcToolBarDetailClick(object sender)
        {
            Detail();
        }

        private void UcToolBarAddClick(object sender)
        {
            RaiseAddNewClickEventHander();
        }

        private void UcToolBarDeleteClick(object sender)
        {
            Delete();
        }

        private void UcToolBarEditClick(object sender)
        {
            Edit();
        }

        private void UcToolBarPrintClick(object sender)
        {
            Print();
        }

        private void UcToolBarExportClick(object sender)
        {
         
            Export();
        }

        private void UcToolBarViewClick(object sender)
        {
           
            Reload();
        }

        
        

       

        protected virtual void Print()
        {
            XtraMessageBox.Show("Don't support.");
        }

        public virtual void Reload()
        {
        }

        public virtual void Delete()
        {
        }

        public virtual void Edit()
        {
        }

       

        public void DisableMenu(bool disable)
        {
            Bar.Bar.bbiCopy.Enabled = !disable;
            //Bar.Bar.bbiEdit.Enabled = !disable;
            Bar.Bar.bbiPrint.Enabled = !disable;
            //Bar.Bar.bbiDelete.Enabled = !disable;
            Bar.Bar.bbiExport.Enabled = !disable;
            Bar.Bar.bbiProduct.Enabled = !disable;
            //Bar.Bar.bbiDetail.Enabled = !disable;
            //Bar.Bar.bbiDetails.Enabled = !disable;
            //Bar.Bar.bbiEdit.Enabled = !disable;
            //Bar.Bar.bbiDelete.Enabled = !disable;
            //Bar.Bar.bbiPrint.Enabled = !disable;
            //Bar.Bar.bbiExport.Enabled = !disable;
            //Bar.Bar.bbiCopy.Enabled = !disable;
            //Bar.Bar.bbiMirror.Enabled = !disable;
            //Bar.Bar.bbiDetailProduct.Enabled = !disable;
            //Bar.Bar.bbiDetail.Enabled = !disable;
            
            
        }

        
       

        #region User function

        public event ButtonClickEventHander AddNewClick;

        protected void RaiseAddNewClickEventHander()
        {
            if (AddNewClick != null)
            {
                AddNewClick(this);
            }
        }

        protected override bool ExportPermision()
        {
            return true;
        }

        #endregion

      
    }
}