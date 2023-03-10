using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary.Product;
using Perfect.Dictionary.Product.DS.dsPRODUCTTableAdapters;
using Perfect.Dictionary.Product._502.TS;
using Perfect.ERP;
using RowClickEventArgs = Perfect.Common.RowClickEventArgs;

namespace Perfect.Dictionary
{
    public partial class xucItemA : xucBaseBasicB
    {
        #region Delegates

        public delegate void ItemSelectedEventHander(object sender, PRODUCT item);

        #endregion

        private readonly RepositoryItemGridLookUpEdit _rpVat = new RepositoryItemGridLookUpEdit();
        private xfmChangeProduct _changeProduct;
        private string _currentId;


        private xfmGroupChanged _groupChanged; //=new xfmGroupChanged();
        private xfmItemAdd _itemAdd;

        private xfmMergeProduct _mergeProduct;
        private xfmProUnit _xfmProUnit;

        public xucItemA()
        {
            InitializeComponent();
            if (ParentForm != null) dm.Form = ParentForm;
            Init();
            ucToolBar.bm.SetPopupContextMenu(gcList, ucToolBar.pm);
            ucToolBar.bbiHistory.Visibility = BarItemVisibility.Always;
            ucToolBar.bbiUtils.Visibility = BarItemVisibility.Always;
            ucToolBar.bbiGroup.Visibility = BarItemVisibility.Always;
            ucToolBar.bbiMerge.Visibility = BarItemVisibility.Always;
            ucToolBar.bbiChangeId.Visibility = BarItemVisibility.Always;
            ucToolBar.bbiEditUnitConvret.Visibility = BarItemVisibility.Always;
        }

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(PRODUCT item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }

        protected override void MergeChanged()
        {
            if (_mergeProduct == null)
            {
                _mergeProduct = new xfmMergeProduct();
                _mergeProduct.FormClosing += MergeProductFormClosing;
                _mergeProduct.MergeChanged += MergeProductMergeChanged;
            }
            _mergeProduct.ShowDialog();
        }

        protected override void IdChanged()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;

            if (_changeProduct == null)
            {
                _changeProduct = new xfmChangeProduct();
                _changeProduct.FormClosing += ChangeProductFormClosing;
                _changeProduct.IdChanged += ChangeProductIdChanged;
                _changeProduct.setData(arg.ToString());
                _currentId = arg.ToString();
            }

            _changeProduct.ShowDialog();
        }

        protected override void EditUnitConvert()
        {
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            object arg2 = gbList.GetFocusedRowCellValue("Unit_ID");
            if (arg == null) return;
            if (arg2 == null) return;

            if (_xfmProUnit == null)
            {
                _xfmProUnit = new xfmProUnit(arg.ToString(), arg2.ToString());
                _xfmProUnit.FormClosing += XfmProUnitFormClosing;
            }
            _xfmProUnit.ShowDialog();
        }

        private void XfmProUnitFormClosing(object sender, FormClosingEventArgs e)
        {
            _xfmProUnit = null;
        }


        private void ChangeProductIdChanged(object sender, string id)
        {
            var cls = new PRODUCT();

            var mySql = new SqlHelper();
            if (mySql.Start() != "OK")
            {
                XtraMessageBox.Show("Không thể kết nối đến máy chủ!", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                mySql.RollBack();
                return;
            }

            string result = cls.ChangeId(mySql.Transaction, _currentId, id);

            if (result != "OK")
            {
                mySql.RollBack();
                MessageBox.Show(@"Hàng hóa này không thay đổi mã được." + result, @"Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            mySql.Commit();

            SysLog.Insert("Quản Lý Hàng Hoá", "Thay đổi mã hàng");
            ReLoad();
            return;
        }

        private void ChangeProductFormClosing(object sender, FormClosingEventArgs e)
        {
            _changeProduct = null;
        }

        private void MergeProductMergeChanged(object sender, string id)
        {
            int[] selectedRows = gbList.GetSelectedRows();

            var cls = new PRODUCT();

            for (int i = selectedRows.Length; i > 0; i--)
            {
                object arg = gbList.GetRowCellValue(selectedRows[i - 1], "Product_ID");
                if (arg == null) continue;
                if (arg.ToString() == id) continue;

                var mySql = new SqlHelper();
                if (mySql.Start() != "OK")
                {
                    XtraMessageBox.Show("Không thể kết nối đến máy chủ!", "Thông Báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    return;
                }

                string result = cls.Update(mySql.Transaction, arg.ToString(), id);

                if (result != "OK")
                {
                    mySql.RollBack();
                    MessageBox.Show(@"Hàng hóa này không gộp được." + result, @"Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    continue;
                }
                mySql.Commit();
            }


            SysLog.Insert("Quản Lý Hàng Hoá", "Gộp hàng hóa");

            ReLoad();
            return;
        }

        private void MergeProductFormClosing(object sender, FormClosingEventArgs e)
        {
            _mergeProduct = null;
        }

        protected override void GroupChange()
        {
            if (_groupChanged == null)
            {
                _groupChanged = new xfmGroupChanged();
                _groupChanged.FormClosing += GroupChangedFormClosing;
                _groupChanged.GroupChanged += GroupChangedGroupChanged;
            }

            _groupChanged.Show(this);
        }

        private void GroupChangedFormClosing(object sender, FormClosingEventArgs e)
        {
            _groupChanged = null;
        }

        private void GroupChangedGroupChanged(object sender, string id)
        {
            if (GroupChanging(id) == "OK")
            {
                GroupInit();
            }
        }

        private string GroupChanging(string id)
        {
            int[] selectedRows = gbList.GetSelectedRows();

            var cls = new PRODUCT();

            var mySql = new SqlHelper();
            if (mySql.Open() != "OK")
            {
                XtraMessageBox.Show("Không thể kết nối đến máy chủ!", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return "Không thể kết nối đến máy chủ!";
            }


            for (int i = selectedRows.Length; i > 0; i--)
            {
                object arg = gbList.GetRowCellValue(selectedRows[i - 1], "Product_ID");
                if (arg == null) continue;
                string result = cls.Update(mySql.Connection, arg.ToString(), id);
                if (result == "OK") continue;
                MessageBox.Show(@"Hàng hóa này không thay đổi được nhóm." + result, @"Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                continue;
            }

            {
                object arg = gbList.GetFocusedRowCellValue("Product_ID");
                if (arg == null) return "";
                SetWaitDialogCaption("Đang xóa...");
                string result = cls.Update(mySql.Connection, arg.ToString(), id);

                if (result != "OK")
                {
                    mySql.Close();
                    MessageBox.Show(@"Hàng hóa này không thay đổi được nhóm." + result, @"Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "Hàng hóa này không thay đổi được nhóm";
                }
            }

            SysLog.Insert("Quản Lý Hàng Hoá", "Thay Đổi Nhóm");
            mySql.Close();
            ReLoad();
            return "OK";
        }


        private void Init()
        {
            ucToolBar.bbiImport.Visibility = BarItemVisibility.Always;
            MyRule.Check("bbiMaterial");
            //ucToolBar.bbiPrint.Visibility = MyRule.Printed;
            ucToolBar.bbiPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ucToolBar.bbiExport.Visibility = MyRule.Exported;
            ucToolBar.bbiAdd.Visibility = MyRule.Added;
            ucToolBar.bbiDelete.Visibility = MyRule.Deleted;
            ucToolBar.bbiEdit.Visibility = MyRule.Edited;

            RibbonBar.Add.Visibility = MyRule.Added;
            RibbonBar.Change.Visibility = MyRule.Edited;
            RibbonBar.Delete.Visibility = MyRule.Deleted;
            RibbonBar.Print.Visibility = MyRule.Printed;
            RibbonBar.Export.Visibility = MyRule.Exported;
            RibbonBar.Import.Visibility = MyRule.Imported;


            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(0, "Hàng Hoá", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(1, "Công Cụ", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(2, "Dịch Vụ", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(3, "Bán Thành Phẩm", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(4, "Thành Phẩm", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(5, "Vật Tư", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(6, "Nguyên Liệu", -1);
            dsPRODUCT.PRODUCTType.AddPRODUCTTypeRow(7, "Sản Phẩm Lắp Ráp", -1);


            FormatColumns(rpType, "NAME", 0, 0, "Tính Chất");


            var dtVat = new DataTable();
            dtVat.Columns.Add("Vat_ID", typeof (double));
            dtVat.Columns.Add("Vat_Name", typeof (string));
            dtVat.Rows.Add(new object[] {-1, "Không thuế"});
            dtVat.Rows.Add(new object[] {0, "Không thuế"});
            dtVat.Rows.Add(new object[] {1, "0%"});
            dtVat.Rows.Add(new object[] {2, "5%"});
            dtVat.Rows.Add(new object[] {3, "10%"});
            dtVat.Rows.Add(new object[] {4, "10%x50%"});

            _rpVat.DataSource = dtVat;
            _rpVat.DisplayMember = "Vat_Name";
            _rpVat.ValueMember = "Vat_ID";
            _rpVat.PopupFilterMode = PopupFilterMode.Contains;
            _rpVat.BestFitMode = BestFitMode.BestFitResizePopup;
        }


        private void GroupInit()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu nhóm hàng...");
            pRODUCT_GROUPCTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCT_GROUPCTableAdapter.Fill(dsPRODUCTGROUP.PRODUCT_GROUPC);
            DataRow dr = dsPRODUCTGROUP.PRODUCT_GROUPC.NewPRODUCT_GROUPCRow();

            dr["ProductGroup_ID"] = "All";
            dr["ProductGroup_Name"] = "Tất Cả";
            dr["ParentID"] = "";
            dsPRODUCTGROUP.PRODUCT_GROUPC.Rows.InsertAt(dr, 0);
            DoHide();
        }

        public override void ReLoad()
        {
            //CreateWaitDialog();
            SetWaitDialogCaption("Đang nạp dữ liệu...");

            var adapter = new PRODUCTByFULLTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsPRODUCT.PRODUCTByFULL);
            SetWaitDialogCaption("Đang nạp cấu hình...");
            
            gbList.ClearColumnsFilter();
            SetWaitDialogCaption("Đã xong...");
            DoHide();
        }

        protected override void Add()
        {
            if (!MyRule.IsAdd("bbiMaterial")) return;

            // xfmItemAdd frm = new xfmItemAdd(Actions.Add);
            // frm.Added += new xfmItemAdd.AddedEventHander(frm_Added);
            // frm.ShowDialog();

            if (_itemAdd == null)
            {
                _itemAdd = new xfmItemAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Add();
            //if (!_itemAdd.Visible) 
            _itemAdd.ShowDialog();
        }

        private void ItemAddUpdated(object sender, PRODUCT item)
        {
            ReLoad();
        }

        private void ItemAddAdded(object sender, PRODUCT item)
        {
            ReLoad();
        }

        private void ItemAddFormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            _itemAdd = null;
        }


        public override void Change()
        {
            if (!MyRule.IsAccess("bbiMaterial")) return;
            var product = new PRODUCT();

            object arg = gbList.GetFocusedRowCellValue("Product_ID");

            if (arg == null) return;

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (product.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DoHide();

            if (_itemAdd == null)
            {
                _itemAdd = new xfmItemAdd();
                _itemAdd.Added += ItemAddAdded;
                _itemAdd.Updated += ItemAddUpdated;
                _itemAdd.FormClosing += ItemAddFormClosing;
            }
            _itemAdd.Change(product);
            if (!_itemAdd.Visible) _itemAdd.ShowDialog();
        }

        public override void Delete()
        {
            if (!MyRule.IsDelete("bbiMaterial")) return;

            string result;
            bool deleted = false;


            //Delete many rows
            int[] selectedRows = gbList.GetSelectedRows();


            if (
                XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No) return;


            //CreateWaitDialog();
            SetWaitDialogCaption("Đang xóa...");

            var cls = new PRODUCT();
            var productUnit = new PRODUCT_UNIT();
            for (int i = selectedRows.Length; i > 0; i--)
            {
                deleted = true;
                // ageBox.Show(GetCellValue(temp[i - 1], 0).ToString() + "  " + GetCellValue(temp[i - 1], 2).ToString());
                object arg = gbList.GetRowCellValue(selectedRows[i - 1], "Product_ID");

                if (arg == null) continue;

                SysLog.Insert("Quản Lý Hàng Hoá", "Xoá", arg.ToString());

                result = cls.Delete(arg.ToString());

                if (result == "OK")
                {
                    result = productUnit.Delete(arg.ToString()) ? "OK" : "Error";
                    if (result == "OK")
                    {
                        gbList.DeleteRow(selectedRows[i - 1]);
                    }
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    }
                }
            }

            DoHide();

            //Delete one row
            if (!deleted)
            {
                if (dsPRODUCT.PRODUCTByFULL.Rows.Count == 0) return;

                //GetRow will Deleted          


                //Get Object 
                object arg = gbList.GetFocusedRowCellValue("Product_ID");
                if (arg == null) return;

                SysLog.Insert("Quản Lý Hàng Hoá", "Xoá", arg.ToString());

                //CreateWaitDialog();
                SetWaitDialogCaption("Đang xóa...");

                result = cls.Delete(arg.ToString());

                if (result == "OK")
                {
                    result = productUnit.Delete(arg.ToString()) ? "OK" : "Error";
                    if (result == "OK")
                    {
                        gbList.DeleteRow(gbList.FocusedRowHandle);
                    }
                }
                else
                {
                    if (result != "OK")
                    {
                        MessageBox.Show(@"Thông tin không được xóa" + result, @"Thông báo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                    }
                }
                DoHide();
            }
        }

        protected override void Print()
        {
            if (!MyRule.IsPrint("bbiMaterial")) return;


            SysLog.Insert("Quản Lý Hàng Hoá", "In");
            gcList.ShowPrintPreview();
            base.Print();
        }

        protected override bool ExportPermision()
        {
            _exportView = gbList;


            if (!MyRule.IsExport("bbiMaterial")) return false;

            SysLog.Insert("Quản Lý Hàng Hoá", "Xuất");
            return base.ExportPermision();
        }

        public override void Import()
        {
            //if (CODE.TypeSoft < 2)
            //{
            //    CODE.Notify();
            //    return;
            //}


            if (!MyRule.IsImport("bbiMaterial")) return;


            var frm = new xfmItemImport();
            frm.Show(ParentForm);
        }

        public override void SetSearch(RowClickEventArgs e)
        {
            if (!_search) return;

            var product = new PRODUCT();

            object arg = gbList.GetRowCellValue(m_RowClickEventArgs.RowIndex, "Product_ID");

            if (arg == null) return;

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang kiểm tra dữ liệu....");

            if (product.Get(arg.ToString()) != "OK")
            {
                DoHide();
                XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DoHide();

            RaiseItemSelectedEventHander(product);
        }

        

        protected override void SetMenu(RowClickEventArgs e)
        {
            object arg = gbList.GetRowCellValue(gbList.FocusedRowHandle, "Product_ID");
            DisableMenu(false);
            if (arg == null)
            {
                DisableMenu(true);
                return;
            }
            base.SetMenu(e);
        }

        protected virtual void SaveLayout(string name)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Layout"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Layout");
            }
            try
            {
                gbList.SaveLayoutToXml(Application.StartupPath + "\\Layout\\" + name + ".xml");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

      

        private void GbListCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle == GridControl.InvalidRowHandle)
            {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);

                Rectangle r = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), r);
                r.Height--;
                r.Width--;
                e.Graphics.DrawRectangle(Pens.Blue, r);
            }

            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void GbListRowCellClick(object sender, RowCellClickEventArgs e)
        {
            var ex = new RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            // m_RowClickEventArgs = ex;
            ItemSelectd(ex);
            SetMenu(ex);
            SetSearch(ex);
        }


        private void GbListMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoShowMenu(gbList.CalcHitInfo(new Point(e.X, e.Y)));
            SetMenu(null);
        }

        private void GbListKeyDown(object sender, KeyEventArgs e)
        {
            UcListListKeyDown(e);
            if (e.KeyCode == Keys.Delete)
            {
                if (gbList.RowCount == 0) return;
                Delete();
                SetMenu(null);
            }
        }

        private void GbListDoubleClick(object sender, EventArgs e)
        {
            //m_RowClickEventArgs = ex;
            if (gbList.RowCount == 0) return;
            // RaiseRowDoubleClickEventHander(ex);
            Change();
        }

        private void UcListListKeyDown(KeyEventArgs key)
        {
          
            if (key.KeyCode == Keys.F2)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            if (key.KeyCode == Keys.Control | key.KeyCode == Keys.E)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            if (key.KeyCode == Keys.Enter)
            {
                if (gbList.RowCount == 0) return;
                Change();
                return;
            }
            if (key.KeyCode == Keys.F5)
            {
                ReLoad();
                return;
            }
            if (key.KeyCode == Keys.Control | key.KeyCode == Keys.N)
            {
                Add();
                return;
            }
            if (key.KeyCode == Keys.Control | key.KeyCode == Keys.T)
            {
                Add();
                return;
            }
        }

        private void DoShowMenu(GridHitInfo hi)
        {
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                GridViewMenu menu = new GridViewColumnButtonMenu(gbList);
                menu.Init(hi);
                menu.Show(hi.HitPoint);
            }
        }

        private void GbListLayout(object sender, EventArgs e)
        {
            SaveLayout("xucItemA");
        }

        protected override void Clear()
        {
            gbList.SelectAll();
            Delete();
            //base.Clear();
        }


        private void GcListLayout(object sender, LayoutEventArgs e)
        {
            SaveLayout("xucItemA");
        }

        protected override void History()
        {
            //Get Object 
            object arg = gbList.GetFocusedRowCellValue("Product_ID");
            if (arg == null) return;
            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(arg.ToString(), "");
            xfmHistory.ShowDialog(this);
        }

        protected override void Copy()
        {
            gbList.CopyToClipboard();
        }
    }
}