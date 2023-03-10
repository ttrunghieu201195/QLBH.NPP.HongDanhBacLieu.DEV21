using System.Windows.Forms;
using System.Diagnostics;

namespace Perfect.Common
{
    public partial class xucBaseB : xucBase
    {
        protected bool m_Simple;
        
        
        protected override bool ProcessDialogKey(Keys keyData)
       { 
            switch (keyData)
            {
                case Keys.Alt | Keys.D:
                    //MessageBox.Show("You are stupid");
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
                    ucToolBar_AddClick(this);
                    return true;
                case Keys.Control | Keys.T:
                    ucToolBar_AddClick(this);
                    return true;

                case Keys.Control | Keys.S:
                    ucToolBar_SaveClick(this);
                    return true;
                case Keys.Control | Keys.W:
                    ucToolBar_SaveClick(this);
                    return true;
                case Keys.F2:
                    ucToolBar_SaveClick(this);
                    return true;

                case Keys.Control |Keys.Shift| Keys.S:
                    ucToolBar_SaveNewClick(this);
                    return true;
                case Keys.Control | Keys.Shift | Keys.W:
                    ucToolBar_SaveNewClick(this);
                    return true;
                case Keys.Shift|Keys.F2:
                    ucToolBar_SaveNewClick(this);
                    return true;
                case Keys.Control | Keys.P:
                    ucToolBar_PrintClick(this);
                    return true;        
                case Keys.Escape:
                    EscapeExecute();
                    return true;

                case Keys.Alt | Keys.X:
                    if (ParentForm != null) ParentForm.Close();
                    return true;

                case Keys.F10:
                    F10Execute();
                    if (ParentForm != null) ParentForm.Close();
                    return true;
            }
            NotSave = true;
            Bar.Bar.bbiSaveM.Enabled = true;
            return false;
        }

        public virtual void DisableControl(bool disable)
        { 

        }
        
        public xucBaseB()
        {
            InitializeComponent();
            Init();   
            
        }

        public xucBarB Bar { get { return ucBarB; } }

        

        public virtual void Init()
        {
            ucBarB.AddClick += ucToolBar_AddClick;
            ucBarB.SaveClick += ucToolBar_SaveClick;
            ucBarB.SaveNewClick += ucToolBar_SaveNewClick;
            ucBarB.CancleClick += ucToolBar_CancleClick;
            ucBarB.PrintClick += ucToolBar_PrintClick;
            ucBarB.CloseClick += ucToolBar_CloseClick;
            ucBarB.DeleteClick += ucToolBar_DeleteClick;
            ucBarB.ClearClick += ucToolBar_ClearClick;
            ucBarB.ProductDetailClick += ucToolBar_ProductDetailClick;
            ucBarB.HistoryClick += ucToolBar_HistoryClick;
            ucBarB.SearchClick += ucToolBar_SearchClick;
            ucBarB.InventoryClick += ucToolBar_InventoryClick;
            ucBarB.SaveDataTempClick += ucToolBar_SaveTempClick;
            ucBarB.RestoreDataTempClick += ucToolBar_RestoreTempClick;
            ucBarB.SaveDataToFileClick += ucToolBar_SaveToFileClick;
            ucBarB.ReadDataFromFileClick += ucToolBar_ReadFromFileClick;
            ucBarB.SelectAllClick += ucToolBar_SelectAllClick;
            ucBarB.ExportClick += ucToolBar_ExportClick;
            ucBarB.SaveDataByIdClick += ucToolBar_SaveDataByIDClick;
            ucBarB.ReadDataByIdClick += ucToolBar_ReadDataByIDClick;
            ucBarB.CopyClick += ucBarB_CopyClick;
            ucBarB.SaveLayoutClick += ucBarB_SaveLayoutClick;
            ucBarB.ReadLayoutClick += ucBarB_ReadLayoutClick;
            ucBarB.RefreshClick += ucBarB_RefreshClick;
            ucBarB.HelpClick += ucBarB_HelpClick;
        }

        void ucBarB_HelpClick(object sender)
        {
            //throw new NotImplementedException();
            Process.Start("http://www.perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-doanh-nghiep-perfect.erp.htm");
        }

        protected new virtual void Help()
        {}


        protected new virtual void Refresh()
        {
            
        }

        void ucBarB_RefreshClick(object sender)
        {
            Refresh();
        }

        void ucBarB_ReadLayoutClick(object sender)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Xml File(*.xml)|*.xml|All File(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ReadLayout(fileDialog.FileName);
            }
        }

        void ucBarB_SaveLayoutClick(object sender)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Xml File(*.xml)|*.xml|All File(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveLayout(fileDialog.FileName);
            }
        }

        public virtual void Copy()
        { } 

        void ucBarB_CopyClick(object sender)
        {
            Copy();
        }

        public virtual void ReadDataByID()
        { } 

        void ucToolBar_ReadDataByIDClick(object sender)
        {
            ReadDataByID();
        }

        public virtual void SaveDataByID()
        { } 
        
        void ucToolBar_SaveDataByIDClick(object sender)
        {
            SaveDataByID();
        }

        void ucToolBar_ExportClick(object sender)
        {
            Export();
        }

        public virtual void SelectAll()
        { } 
        
        void ucToolBar_SelectAllClick(object sender)
        {
            SelectAll();
        }

        public virtual void ReadLayout(string name)
        { } 
       

        public virtual void SaveLayout(string name)
        { } 

        public virtual void ReadFromFile(string name)
        {
            
        } 

        void ucToolBar_ReadFromFileClick(object sender)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Xml File(*.xml)|*.xml|All File(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ReadFromFile(fileDialog.FileName);
            }
        }

        public virtual void SaveToFile(string name)
        { } 

        void ucToolBar_SaveToFileClick(object sender)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Xml File(*.xml)|*.xml|All File(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(fileDialog.FileName);
            }
        }

        public virtual void RestoreTemp()
        { }

        void ucToolBar_RestoreTempClick(object sender)
        {
            RestoreTemp();
        }

        public virtual void SaveTemp()
        { }

        void ucToolBar_SaveTempClick(object sender)
        {
            SaveTemp();
        }

        public virtual void Inventory()
        { }

        void ucToolBar_InventoryClick(object sender)
        {
            Inventory();
        }

        public virtual void Search()
        {}

        void ucToolBar_SearchClick(object sender)
        {
            Search();
        }

        public virtual void History()
        {
        }

        void ucToolBar_HistoryClick(object sender)
        {
            History();
        }

        public virtual void ProductDetail() { }

        void ucToolBar_ProductDetailClick(object sender)
        {
            ProductDetail();
        }
        
        void ucToolBar_ClearClick(object sender)
        {
            DeleteAll();
            //Clear();
        }

        public virtual void DeleteAll() { }

        public virtual void DeleteSelected(){}

        void ucToolBar_DeleteClick(object sender)
        {
            DeleteSelected();
        }

        void ucToolBar_CloseClick(object sender)
        {
            if (ParentForm!=null) ParentForm.Close();
        }

        void ucToolBar_PrintClick(object sender)
        {
            Print();
            //m_Status = Actions.None;
        }

        public virtual void Cancel()
        {
            m_Status = Actions.None;
            Cursor.Current = Cursors.Default;
            DisableControl(false);
            NotSave = false;
        }

        void ucToolBar_CancleClick(object sender)
        {
            Cancel();
        }

        void ucToolBar_SaveNewClick(object sender)
        {
            if (Save() == "OK")
            {
                ucToolBar_AddClick(sender);
            }
        }

        void ucToolBar_SaveClick(object sender)
        {
            if (Bar.Bar.bbiSave.ImageIndex == Bar.Bar.bbiSaveNew.ImageIndex)
            {
                if (Save() == "OK")
                {
                    ucToolBar_AddClick(sender);
                }
            }
            else
            {
                Save();
            }
        }

        void ucToolBar_AddClick(object sender)
        {
            Clear();
            Add();
        }

        

        #region User function
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

        #endregion
        
        public virtual void MakerInterface()
        {
            //CONTROL_FORMAT cf = new CONTROL_FORMAT();
            

            //for (int i = 0; i < plButtom.Controls.Count; i++)
            //{
            //    if (plButtom.Controls[i].Text != "")
            //    {
            //        cf.Insert(Guid.NewGuid().ToString(), "xucBaseX", plButtom.Controls[i].Name, "VN", plButtom.Controls[i].Text, "", true);
            //    }
            //}
        }

        public virtual void SaveInterface()
        {
            //CONTROL_FORMAT.Save("xucBaseX", "EN");
        }

        public virtual void SetInterface()
        {
            //DataTable dt = CONTROL_FORMAT.Load("xucBaseX");
            //CONTROL_FORMAT.ContainerChangeLanguage(plButtom, ref dt);            

        }

        public virtual void SetData(string id)
        {

        }

        public virtual void Mirror(string id)
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
        
        public void DisableMenu(bool disable)
       {
           Bar.Bar.bbiDeleteAll.Enabled = !disable;
           Bar.Bar.bbiDelete.Enabled = !disable;
           Bar.Bar.bbiSelectAll.Enabled = !disable;
           Bar.Bar.bbiProduct.Enabled = !disable;
           //Bar.Bar.bbiBackup.Enabled = !disable;
           Bar.Bar.bbiSaveTemp.Enabled = !disable;
           Bar.Bar.bbiSaveToFile.Enabled = !disable;
           //bbiRestoreTemp.Enabled = !disable;
           //ucBar.bbiSaveHistory.Enabled = !disable;
          // bbiSave.Enabled = !disable;
           //btnSave.Enabled = !disable;
           //btnSaveNew.Enabled =!disable;
       }

    }
}
