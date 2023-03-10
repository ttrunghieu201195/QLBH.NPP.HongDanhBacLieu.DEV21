using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Data.Helper;
using DevExpress.XtraTreeList.Nodes;
using Perfect.ERP;
using Perfect.Common;

namespace Perfect.Security
{
    public partial class xucPermision : xucBase
    {
        public delegate void SavedEventHander(object sender);

        public event SavedEventHander Saved;

        public void RaiseSavedEventHander()
        {
            if (Saved != null) Saved(this);
        }

        public xucPermision()
        {
            InitializeComponent();
            
            btnSave.Text = SysOption.Language == "EN" ? "Save" : btnSave.Text;
            btnClose.Text = SysOption.Language == "EN" ? "Close" : btnClose.Text;
            btnExpandAll.Text = SysOption.Language == "EN" ? "Expand All" : btnExpandAll.Text;
            btnCollapseAll.Text = SysOption.Language == "EN" ? "Collapse All" : btnCollapseAll.Text;
            colObject_Name.Caption = SysOption.Language == "EN" ? "Function" : colObject_Name.Caption;
            colActive.Caption = SysOption.Language == "EN" ? "All" : colActive.Caption;
            colAllowAccess.Caption = SysOption.Language == "EN" ? "Access" : colAllowAccess.Caption;
            colAllowAdd.Caption = SysOption.Language == "EN" ? "Add" : colAllowAdd.Caption;
            colAllowEdit.Caption = SysOption.Language == "EN" ? "Edit" : colAllowEdit.Caption;
            colAllowDelete.Caption = SysOption.Language == "EN" ? "Delete" : colAllowDelete.Caption;
            colAllowPrint.Caption = SysOption.Language == "EN" ? "Print" : colAllowPrint.Caption;
            colAllowExport.Caption = SysOption.Language == "EN" ? "ExportClick" : colAllowExport.Caption;
            colAllowImport.Caption = SysOption.Language == "EN" ? "Import" : colAllowImport.Caption;
            //bm.SetPopupContextMenu(this, pm);
        }
        public void SetData1(string ID, DevExpress.XtraEditors.GroupControl groupcontrol  , DevExpress.XtraGrid.GridControl  grocontrol)
        {
            _roleId = ID;
            if (!MyRule.IsAccess("bbiPermission"))
            {
                groupcontrol.Visible = false;
                grocontrol.Dock = DockStyle.Fill;

            }
            SysLog.Insert("Phân Quyền Người Dùng", "Xem", ID);
            permisionTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            permisionTableAdapter.Fill(dsPermision.Permision, ID, SysOption.Language, "%" + Options.SoftId + "%");
        }
        public void SetData(string ID)
        {
            _roleId = ID;
            if (!MyRule.IsAccess("bbiPermission")) return;            
            SysLog.Insert("Phân Quyền Người Dùng", "Xem", ID);
            permisionTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            permisionTableAdapter.Fill(dsPermision.Permision, ID, SysOption.Language, "%" + Options.SoftId + "%");
        }
        private string _roleId;
        public string Role_ID
        {
            set { this._roleId = value; }
        }
        private void tlPermision_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            //MessageBox.Show(e.Column.FieldName);
            if (_roleId == "admin")
            {
                XtraMessageBox.Show("Nhóm người dùng này không được thay đổi", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetData("admin");
                return;
            }

            if (!MyRule.IsEdit("bbiPermission")) return;


            Cursor.Current = Cursors.WaitCursor;
            this.Enabled = false;

            #region MyRegion
            if (e.Column.FieldName == "Active")
            {

                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colActive)) == false)
                    {
                        e.Node.SetValue(colActive, false);
                        e.Node.ParentNode.SetValue(colActive, false);
                        return;
                    }
                }
                e.Node.SetValue(colActive, e.Value);

                if (Convert.ToBoolean(e.Value) == true)
                {
                    e.Node.SetValue(colAllowAdd, true);
                    Recheck("AllowAdd", e.Node, true);
                    e.Node.SetValue(colAllowAccess, true);
                    Recheck("AllowAccess", e.Node, true);
                    e.Node.SetValue(colAllowDelete, true);
                    Recheck("AllowDelete", e.Node, true);
                    e.Node.SetValue(colAllowEdit, true);
                    Recheck("AllowEdit", e.Node, true);
                    e.Node.SetValue(colAllowExport, true);
                    Recheck("AllowExport", e.Node, true);
                    e.Node.SetValue(colAllowImport, true);
                    Recheck("AllowImport", e.Node, true);
                    e.Node.SetValue(colAllowPrint, true);
                    Recheck("AllowPrint", e.Node, true);

                }
                else
                {
                    e.Node.SetValue(colAllowAdd, false);
                    Recheck("AllowAdd", e.Node, false);
                    e.Node.SetValue(colAllowAccess, false);
                    Recheck("AllowAccess", e.Node, false);
                    e.Node.SetValue(colAllowDelete, false);
                    Recheck("AllowDelete", e.Node, false);
                    e.Node.SetValue(colAllowEdit, false);
                    Recheck("AllowEdit", e.Node, false);
                    e.Node.SetValue(colAllowExport, false);
                    Recheck("AllowExport", e.Node, false);
                    e.Node.SetValue(colAllowImport, false);
                    Recheck("AllowImport", e.Node, false);
                    e.Node.SetValue(colAllowPrint, false);
                    Recheck("AllowPrint", e.Node, false);
                }

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colActive, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colActive, true);
                            Recheck("Active", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colActive, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colActive, false);
                            Recheck("Active", e.Node.Nodes[i], false);
                        }
                    }
                }

            }
            #endregion

            Recheck(e);
            this.Enabled = true;
            Cursor.Current = Cursors.Default;

        }

        void Recheck(DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

            #region AllowAdd
            if (e.Column.FieldName == "AllowAdd")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowAdd)) == false)
                    {
                        e.Node.SetValue(colAllowAdd, false);
                        e.Node.ParentNode.SetValue(colAllowAdd, false);
                        return;
                    }

                }

                e.Node.SetValue(colAllowAdd, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colAllowAccess, true);
                        Recheck("AllowAccess", e.Node, true);
                        e.Node.SetValue(colAllowAdd, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowAdd, true);
                            Recheck("AllowAdd", e.Node.Nodes[i], true);

                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowAdd, false);
                        e.Node.SetValue(colActive, false);

                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowAdd, false);
                            Recheck("AllowAdd", e.Node.Nodes[i], false);
                        }
                    }

                }
            }
            #endregion

            #region AllowEdit
            else if (e.Column.FieldName == "AllowEdit")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowEdit)) == false)
                    {
                        e.Node.SetValue(colAllowEdit, false);
                        e.Node.ParentNode.SetValue(colAllowEdit, false);
                        return;
                    }


                }

                e.Node.SetValue(colAllowEdit, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colAllowAccess, true);
                        Recheck("AllowAccess", e.Node, true);
                        e.Node.SetValue(colAllowEdit, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowEdit, true);
                            Recheck("AllowEdit", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowEdit, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowEdit, false);
                            Recheck("AllowEdit", e.Node.Nodes[i], false);
                        }
                    }

                }
            }
            #endregion

            #region AllowDelete
            else if (e.Column.FieldName == "AllowDelete")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowDelete)) == false)
                    {
                        e.Node.SetValue(colAllowDelete, false);
                        e.Node.ParentNode.SetValue(colAllowDelete, false);
                        return;
                    }

                }

                e.Node.SetValue(colAllowDelete, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {

                        e.Node.SetValue(colAllowAccess, true);
                        Recheck("AllowAccess", e.Node, true);
                        e.Node.SetValue(colAllowDelete, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowDelete, true);
                            Recheck("AllowDelete", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowDelete, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowDelete, false);
                            Recheck("AllowDelete", e.Node.Nodes[i], false);
                        }
                    }

                }
            }
            #endregion

            #region AllowAccess
            else if (e.Column.FieldName == "AllowAccess")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowAccess)) == false)
                    {
                        e.Node.SetValue(colAllowAccess, false);
                        e.Node.ParentNode.SetValue(colAllowAccess, false);
                        return;
                    }

                }

                e.Node.SetValue(colAllowAccess, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colAllowAccess, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowAccess, true);
                            Recheck("AllowAccess", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowAccess, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowAccess, false);
                            Recheck("AllowAccess", e.Node.Nodes[i], false);
                        }
                    }

                }
            }
            #endregion

            #region AllowPrint
            else if (e.Column.FieldName == "AllowPrint")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowPrint)) == false)
                    {
                        e.Node.SetValue(colAllowPrint, false);
                        e.Node.ParentNode.SetValue(colAllowPrint, false);
                        return;
                    }

                }

                e.Node.SetValue(colAllowPrint, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colAllowAccess, true);
                        Recheck("AllowAccess", e.Node, true);
                        e.Node.SetValue(colAllowPrint, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowPrint, true);
                            Recheck("AllowPrint", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowPrint, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowPrint, false);
                            Recheck("AllowPrint", e.Node.Nodes[i], false);
                        }
                    }

                }
            }
            #endregion

            #region AlllowExport
            else if (e.Column.FieldName == "AllowExport")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowExport)) == false)
                    {
                        e.Node.SetValue(colAllowExport, false);
                        e.Node.ParentNode.SetValue(colAllowExport, false);
                        return;
                    }

                }

                e.Node.SetValue(colAllowExport, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colAllowAccess, true);
                        Recheck("AllowAccess", e.Node, true);
                        e.Node.SetValue(colAllowExport, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowExport, true);
                            Recheck("AllowExport", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowExport, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowExport, false);
                            Recheck("AllowExport", e.Node.Nodes[i], false);
                        }
                    }
                }
            }
            #endregion

            #region AllowImport
            else if (e.Column.FieldName == "AllowImport")
            {
                if (e.Node.ParentNode != null)
                {
                    if (Convert.ToBoolean(e.Node.ParentNode.GetValue(colAllowImport)) == false)
                    {
                        e.Node.SetValue(colAllowImport, false);
                        e.Node.ParentNode.SetValue(colAllowImport, false);
                        return;
                    }
                }

                e.Node.SetValue(colAllowImport, e.Value);

                if (e.Node.HasChildren)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        e.Node.SetValue(colAllowAccess, true);
                        Recheck("AllowAccess", e.Node, true);
                        e.Node.SetValue(colAllowImport, true);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowImport, true);
                            Recheck("AllowImport", e.Node.Nodes[i], true);
                        }
                    }
                    else
                    {
                        e.Node.SetValue(colAllowImport, false);
                        e.Node.SetValue(colActive, false);
                        for (int i = 0; i < e.Node.Nodes.Count; i++)
                        {
                            e.Node.Nodes[i].SetValue(colAllowImport, false);
                            Recheck("AllowImport", e.Node.Nodes[i], false);
                        }
                    }
                }
            }
            #endregion

        }

        void Recheck(string FieldName, TreeListNode node, object value)
        {

            #region MyRegion
            if (FieldName == "Active")
            {
                if (node.HasChildren)
                {
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colActive, value);
                        Recheck("Active", node.Nodes[i], value);
                    }
                }
            }
            #endregion

            #region MyRegion
            if (FieldName == "AllowAdd")
            {
                if (node.HasChildren)
                {
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowAdd, value);
                        Recheck("AllowAdd", node.Nodes[i], value);
                    }
                }
            }
            #endregion

            #region MyRegion
            else if (FieldName == "AllowEdit")
            {

                if (node.HasChildren)
                {
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowEdit, value);
                        Recheck("AllowEdit", node.Nodes[i], value);
                    }


                }
            }
            #endregion

            #region MyRegion
            else if (FieldName == "AllowDelete")
            {
                if (node.HasChildren)
                {

                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowDelete, value);
                        Recheck("AllowDelete", node.Nodes[i], value);
                    }

                }
            }
            #endregion

            #region MyRegion
            else if (FieldName == "AllowAccess")
            {

                if (node.HasChildren)
                {

                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowAccess, value);
                        Recheck("AllowAccess", node.Nodes[i], value);
                    }


                }
            }
            #endregion

            #region MyRegion
            else if (FieldName == "AllowPrint")
            {
                if (node.HasChildren)
                {

                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowPrint, value);
                        Recheck("AllowPrint", node.Nodes[i], value);
                    }
                }
            }
            #endregion

            #region MyRegion
            else if (FieldName == "AllowExport")
            {

                if (node.HasChildren)
                {

                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowExport, value);
                        Recheck("AllowExport", node.Nodes[i], value);
                    }

                }
            }
            #endregion

            #region MyRegion
            else if (FieldName == "AllowImport")
            {
                if (node.HasChildren)
                {
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        node.Nodes[i].SetValue(colAllowImport, value);
                        Recheck("AllowImport", node.Nodes[i], value);
                    }
                }
            }
            #endregion

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RaiseSavedEventHander();
        }

        public string Save()
        {
            if (_roleId == "admin")
            {
                XtraMessageBox.Show("Nhóm người dùng này không được thay đổi", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetData("admin");
                return "";
            }

            string Result = "";

            MyRule.Check("bbiPermission");
            if (!MyRule.AllowEdit | !MyRule.AllowAdd)
            {
                MyRule.Notify();
                return "";
            }

            SysLog.Insert("Phân Quyền Người Dùng", "Cập Nhật", _roleId);

            SqlHelper myHelper = new SqlHelper();
            Result = myHelper.Open();
            if (Result != "OK")
            {
                XtraMessageBox.Show("Không kết nối được máy chủ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Result;
            }

            for (int i = 0; i < dsPermision.Permision.Rows.Count; i++)
            {
                if (dsPermision.Permision.Rows[i].RowState != DataRowState.Modified) continue;

                Result = MyRule.Update
                    (
                    myHelper.Connection,
                    _roleId, //dsPermision.Permision.Rows[i]["Goup_ID"].ToString(),
                    dsPermision.Permision.Rows[i]["Object_ID"].ToString(),
                    dsPermision.Permision.Rows[i]["Rule_ID"].ToString(),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowAdd"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowDelete"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowEdit"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowAccess"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowPrint"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowExport"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["AllowImport"]),
                    Convert.ToBoolean(dsPermision.Permision.Rows[i]["Active"])
                    );

            }

            myHelper.Close();

            if (Result == "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu đã được lưu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return Result;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            tlPermision.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            tlPermision.CollapseAll();
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetData(_roleId);
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void bbiExpand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tlPermision.ExpandAll();
        }

        private void bbiSimple_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tlPermision.CollapseAll();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tlPermision_DoubleClick(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.WindowState = this.ParentForm.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (ParentForm != null)
                {
                    ParentForm.Close();
                }
            }

            return false;
        }


    }
}


