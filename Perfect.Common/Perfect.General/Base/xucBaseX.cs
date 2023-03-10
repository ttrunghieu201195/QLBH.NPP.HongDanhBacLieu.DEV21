using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Perfect.Common;
using Perfect.ERP;

namespace Perfect.Common
{
    public partial class xucBaseX : xucBase
    {
		public event ButtonClickEventHander CloseClick;

        public event ButtonClickEventHander SimpleClick;

        public delegate void SimpleEventHander(object sender);

        public event SimpleEventHander Simple;

        private void RaiseSimpleEventHander()
        {
            if (Simple != null) Simple(this);
        }
        public delegate void ExpandEventHander(object sender);

        public event ExpandEventHander Expand;

        private void RaiseExpandEventHander()
        {
            if (Expand != null) Expand(this);
        }

        private void RaiseCloseClickEventHander()
        {
            if (CloseClick != null) CloseClick(this);
        }

        private void RaiseSimpleClickEventHander()
        {
            if (SimpleClick != null) SimpleClick(this);
        }
	
        protected string m_Inward_ID = string.Empty;
        protected  Actions m_Status = new Actions();
        protected bool m_Simple = false;
        
        public Actions Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }

        protected virtual void F1Execute()
        {

        }

        protected virtual void F2Execute()
        {

        }

        protected virtual void F3Execute()
        {
            
        }

        protected virtual void F4Execute()
        {

        }
        protected virtual void F5Execute()
        {

        }
        protected virtual void F6Execute()
        {

        }
        protected virtual void F7Execute()
        {

        }
        protected virtual void F8Execute()
        {

        }
        protected virtual void F9Execute()
        {

        }
        protected virtual void F10Execute()
        {

        }
        protected virtual void F11Execute()
        {

        }
        protected virtual void F12Execute()
        {

        }

        protected virtual void EscapeExecute()
        {

        }


        protected override bool ProcessDialogKey(Keys keyData)
       { 
            switch (keyData)
            {
                case Keys.Alt | Keys.D:
                    MessageBox.Show("You are stupid");
                    return true;

                // some more cases...  

                case Keys.F1:
                    //ucToolBar_HelpClick(ucBar);
                    F11Execute();
                    return true;
                case Keys.F3:
                    F3Execute();
                    return true;
                case Keys.F4:
                    F4Execute();
                    return true;
                case Keys.F5:
                    F5Execute();
                    return true;
                case Keys.F6:
                    F9Execute();
                    return true;
                case Keys.F7:
                    F7Execute();
                    return true;
                case Keys.F8:
                    F8Execute();
                    return true;
                case Keys.F9:
                    F9Execute();
                    return true;
                case Keys.F11:
                    F11Execute();
                    return true;
                case Keys.F12:
                    F12Execute();
                    return true;

                case Keys.Control | Keys.N:
                    btnAdd_Click(btnAdd, EventArgs.Empty);
                    return true;
                case Keys.Control | Keys.T:
                    btnAdd_Click(btnAdd, EventArgs.Empty);
                    return true;

                case Keys.Control | Keys.S:
                    btnSave_Click(btnSave,EventArgs.Empty);
                    return true;
                case Keys.Control | Keys.W:
                    btnSave_Click(btnSave, EventArgs.Empty);
                    return true;
                case Keys.F2:
                    btnSave_Click(btnSave, EventArgs.Empty);
                    return true;

                case Keys.Control |Keys.Shift| Keys.S:
                    btnSaveNew_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Control | Keys.Shift | Keys.W:
                    btnSaveNew_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Shift|Keys.F2:
                    btnSaveNew_Click(this, EventArgs.Empty);
                    return true;

                case Keys.Control | Keys.P:
                    btnPrint_Click(btnPrint, EventArgs.Empty);
                    return true;             


                case Keys.Escape:
                    btnCancle_Click(btnCancle, EventArgs.Empty);
                    EscapeExecute();
                    return true;

                case Keys.Alt | Keys.X:
                    if (ParentForm!=null) ParentForm.Close();
                    return true;

                case Keys.F10:
                    F10Execute();
                    if (ParentForm != null) ParentForm.Close();
                    return true;
            }
            return false;
        }

        public virtual void Lock(bool ReadOnly)
        { 

        }

        public virtual void UnLock(bool ReadOnly)
        {

        }

        public xucBaseX()
        {
            InitializeComponent();
            Init();   
            
        }

        public virtual void Init()
        { 

        }

        public virtual string uc_Save()
        {
            //string Result = string.Empty;
            //return Result;
            return string.Empty;
        }

        public virtual string uc_Update()
        {
            //string Result = string.Empty;
            // return Result;
            return string.Empty;
        }

        public virtual string uc_Change()
        {
            // string Result = string.Empty;
            // return Result;
            return string.Empty;
        }

        public virtual string uc_Delete()
        {
            // string Result = string.Empty;
            //return Result;
            return string.Empty;

        }

        public virtual bool Check()
        {
            return true;
        }

        public virtual string Save()
        {          
           
            if (!Check()) return "";

            //if (clsOption.System.IsQuestion)
            //{
            //    if (VnMessageBox.Question("Bạn có muốn lưu lại không?", "Thông báo") == DialogResult.No) return;
            //}
            if (m_Status == Actions.Add)
            {
               return uc_Save();
            }
            else if (m_Status == Actions.Update)
            {
                uc_Update();
            }
            else if (m_Status == Actions.Change)
            {
                uc_Change();
            }
           // txtID.Focus();
            return "";
        }

        public virtual void Print()
        {

        }

        

        public virtual void Add()
        { 

        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            m_Status = Actions.Add;            
            
            //STOCK_INWARD cls = new STOCK_INWARD();
            //m_Inward_ID = cls.NewID();   
            Add();
        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.ImageIndex == btnSaveNew.ImageIndex)
            {
                if (Save() == "OK")
                {
                    btnAdd_Click(btnAdd, e);
                }
            }
            else
            {
                Save();    
            }
            
        }

        protected virtual void btnCancle_Click(object sender, EventArgs e)
        {
            m_Status = Actions.None;
            Lock(false);
        }

        protected virtual void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
            m_Status = Actions.None;
        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            if (ParentForm!=null) ParentForm.Close() ;
        }

        protected virtual void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (Save() == "OK")
            {
                btnAdd_Click(btnAdd, e);
            }
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            ////RaiseSimpleClickEventHander();
            //if (!m_Simple)
            //{
            //    RaiseSimpleEventHander();
            //    m_Simple = true;
            //    btnSimple.Text = "Mở rộng";
            //    return;
            //}
            //m_Simple = false;
            //btnSimple.Text = "Đơn giản";
            //RaiseExpandEventHander();
        }

        public virtual void MakerInterface()
        {
            CONTROL_FORMAT cf = new CONTROL_FORMAT();
            

            for (int i = 0; i < plButtom.Controls.Count; i++)
            {
                if (plButtom.Controls[i].Text != "")
                {
                    cf.Insert(Guid.NewGuid().ToString(), "xucBaseX", plButtom.Controls[i].Name, "VN", plButtom.Controls[i].Text, "", true);
                }
            }
        }

        public virtual void SaveInterface()
        {
            CONTROL_FORMAT.Save("xucBaseX", "EN");
        }

        public virtual void SetInterface()
        {
            DataTable dt = CONTROL_FORMAT.Load("xucBaseX");
            CONTROL_FORMAT.ContainerChangeLanguage(plButtom, ref dt);            

        }

        public virtual void SetData(string id)
        {
        }

        public virtual void ProductAdd(object item)
        {
            
        }

        public virtual void ProviderSelected(object item)
        {
            
        }

        public virtual void CustomerSelected(object item)
        {

        }

        public object GetCellValue(RowClickEventArgs e, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
            DevExpress.XtraGrid.Columns.GridColumn Col = new DevExpress.XtraGrid.Columns.GridColumn();

            if (e.ColumnIndex != -1)
            {
                Col = view.Columns[e.ColumnIndex];

            }
            else
            {
                Col = view.Columns[e.FieldName];
            }
            Result = view.GetRowCellValue(e.RowIndex, Col);
            // if (Result == null | e.RowIndex > gbList.RowCount) VnMessageBox.Error("Không thể lấy thông tin.", "Thông báo");
            return Result;
        }

        public object GetCellValue(int RowIndex, int ColumIndex, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, ColumIndex),view);
            return Result;
        }

        public object GetCellValue(int RowIndex, string FieldName, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, FieldName),view);
            return Result;
        }


        public object GetCellValue(int RowIndex, GridColumn Column, DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView view)
        {
            object Result = null;
            Result = GetCellValue(new RowClickEventArgs(RowIndex, Column.FieldName), view);
            return Result;
        }



       

       protected virtual void bbiDeleteRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiDeleteSeletect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiDeleteAllCell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           
       }

       protected virtual void bbiSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiProductDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiSaveHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiRestoreHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void biiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           btnAdd_Click(sender,e);
       }

       protected virtual void biiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           btnSave_Click(sender,e);
           btnSave.Tag = bbiSave.Caption;
           btnSave.ImageIndex = bbiSave.ImageIndex;

       }

       protected virtual void bbiSaveNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           btnSaveNew_Click(sender,e);
           btnSave.Tag = btnSaveNew.Caption;
           btnSave.ImageIndex = btnSaveNew.ImageIndex;
       }

       protected virtual void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           btnPrint_Click(sender,e);
       }

       protected virtual void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           btnClose_Click(sender,e);
       }

       protected virtual void bbiRestoreTemp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiSaveTemp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       protected virtual void bbiInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

       }

       public void DisableMenu(bool disable)
       {
           bbiDeleteAllCell.Enabled = !disable;
           bbiDeleteRow.Enabled = !disable;
           bbiDeleteSeletect.Enabled = !disable;
           bbiSelectAll.Enabled = !disable;
           bbiProduct.Enabled = !disable;
           bbiSaveTemp.Enabled = !disable;
           //bbiRestoreTemp.Enabled = !disable;
           bbiSaveHistory.Enabled = !disable;
          // bbiSave.Enabled = !disable;
           //btnSave.Enabled = !disable;
           //btnSaveNew.Enabled =!disable;
       }

    }
}
