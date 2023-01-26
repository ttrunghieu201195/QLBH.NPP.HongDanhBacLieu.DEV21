using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Perfect.Common;
using Perfect.Data.Helper;
using Perfect.Dictionary.Product.DS.dsPRODUCTTableAdapters;
using Perfect.Dictionary.Product._502.TS;
using Perfect.Dictionary.Product._502.TS.DS;
using Perfect.Dictionary.ProductGroup;
using Perfect.Dictionary.Provider.DS.dsPROVIDERTableAdapters;
using Perfect.Dictionary.Stock.DS.dsSTOCKTableAdapters;
using Perfect.ERP;
using Perfect.Dictionary.CustomerGroup;

namespace Perfect.Dictionary
{
    public partial class XucItemAdd : xucBase
    {
        #region Delegates

        public delegate void SuccessEventHander(object sender, PRODUCT e);

        #endregion

        private readonly dsProUnit _dsProUnit = new dsProUnit();
        private Actions _mStatus;

        private CloseOrNew m_CloseOrNew;

        public XucItemAdd()
        {
            InitializeComponent();
            Init();
        }

        public Actions Status
        {
            get { return _mStatus; }
            set { _mStatus = value; }
        }

        public CloseOrNew IsClose
        {
            get { return m_CloseOrNew; }
            set { m_CloseOrNew = value; }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            SetSize();
        }

        private void SetSize()
        {
            if (ParentForm != null)
            {
                Dock = DockStyle.Fill;
                ParentForm.Size = new Size(Width + 10, Height + 35);
            }
        }

        private void Updated()
        {
            Cursor.Current = Cursors.WaitCursor;
            IndustryInit();
            ProductBrandInit();
            UnitInit();
            ProductGroup();
            StockInit();
            ProviderInit();
            ProductInit();
            Cursor.Current = Cursors.Default;
        }

        private void IndustryInit()
        {
            iNDUSTRYTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            iNDUSTRYTableAdapter.Fill(dsIndustry.INDUSTRY);
        }

        private void ProductBrandInit()
        {
            pRODUCT_BRANDTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCT_BRANDTableAdapter.Fill(dsUNIT.PRODUCT_BRAND);
        }

        private void UnitInit()
        {
            uNITTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            SetWaitDialogCaption("Đang nạp đơn vị tính...");
            uNITTableAdapter.Fill(dsUNIT.UNIT);

            if (cbxUnit.Text == "")
            {
                if (dsUNIT.UNIT.Rows.Count > 0) cbxUnit.EditValue = dsUNIT.UNIT.Rows[0]["Unit_ID"];
            }
            DoHide();
            cbxUnit.EditValue = @"kg";
        }

        private void ProductInit()
        {
            var adapter = new PRODUCTTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsProduct.PRODUCT);
        }

        private void ProductGroup()
        {
            pRODUCT_GROUPTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCT_GROUPTableAdapter.Fill(dsPRODUCTGROUP.PRODUCT_GROUP);
            if (cbxGroup.Text == "")
            {
                if (dsPRODUCTGROUP.PRODUCT_GROUP.Rows.Count > 0)
                    cbxGroup.EditValue = dsPRODUCTGROUP.PRODUCT_GROUP.Rows[0]["ProductGroup_ID"];
            }
        }

        private void StockInit()
        {
            var adapter = new STOCKTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsSTOCK.STOCK);
            if (txtStock.Text == "")
            {
                if (dsSTOCK.STOCK.Rows.Count > 0) txtStock.EditValue = dsSTOCK.STOCK.Rows[0]["Stock_ID"];
            }
        }

        private void ProviderInit()
        {
            var adapter = new PROVIDERTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            adapter.Fill(dsPROVIDER.PROVIDER);
            if (cbxProvider.Text == "")
            {
                if (dsPROVIDER.PROVIDER.Rows.Count > 0)
                    cbxProvider.EditValue = dsPROVIDER.PROVIDER.Rows[0]["Customer_ID"];
            }
        }


        private void Init()
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            Updated();
            var adapter = new PRODUCTTableAdapter
                              {
                                  Connection = {ConnectionString = SqlHelper.ConnectString}
                              };
            SetValue(adapter.GetData());
            txtBonus.Value = 0;
            txtStock.Focus();
            DoHide();
        }

        public event ButtonClickEventHander CancelClick;
        public event ButtonClickEventHander SaveClick;
        public event SuccessEventHander Success;

        private void RaiseSaveClickEventHander()
        {
            if (SaveClick != null) SaveClick(this);
        }

        private void RaiseCancelClickEventHander()
        {
            if (CancelClick != null) CancelClick(this);
        }

        private void RaiseSuccessEventHander(PRODUCT e)
        {
            if (Success != null) Success(this, e);
        }

        public void SetData(PRODUCT item)
        {
            SetWaitDialogCaption("Đang nạp dữ liệu...");
            if (Status == Actions.Update) txtID.Properties.ReadOnly = true;

            txtNAME.Text = item.Product_Name;
            txtID.Text = item.Product_ID;
            cbxProductType.SelectedIndex = item.Product_Type_ID;
            txtBarcode.Text = item.Barcode;
            txtMinStock.Value = Convert.ToDecimal(item.MinStock);
            txtOrigin.Text = item.Origin;
            txtQuantity.Value = Convert.ToDecimal(item.Quantity);

            #region query

            /*
            string sql = "SELECT COUNT(id.Product_ID) AS Has_Product \n"
           + "FROM   INVENTORY_DETAIL id \n"
           + "WHERE  id.Product_ID = @Product_ID";

            SqlHelper mySql = new SqlHelper();
            mySql.CommandType = CommandType.Text;

            string[] myPara = { "@Product_ID" };
            object[] myValue = { item.Product_ID };
            int count = 0;
            count = Convert.ToInt32(mySql.ExecuteScalar(sql, myPara, myValue));

            if (count > 0)
            {
                cbxUnit.Properties.ReadOnly = true;
            }
            else
            {
                cbxUnit.Properties.ReadOnly = false;
            }
            */
            #endregion

            cbxUnit.EditValue = item.Unit;
            chkActive.Checked = item.Active;

            cbxGroup.EditValue = item.Product_Group_ID;
            txtOrg_Price.Value = Convert.ToDecimal(item.Org_Price);
            txtSale_Price.Value = Convert.ToDecimal(item.Sale_Price);
            txtRetail_Price.Value = Convert.ToDecimal(item.Retail_Price);
            txtPriceSales.Value = Convert.ToDecimal(item.Quantity);

            cbxProvider.EditValue = item.Customer_ID;
            txtStock.EditValue = item.Provider_ID;

            txtBonus.Value = Convert.ToDecimal(item.VAT_ID);
            txtTrongTam1.Text = item.TrongTam01;
            txtTrongTam2.Text = item.TrongTam02;
            txtTrongTam3.Text = item.TrongTam03;

            txtNote1.Text = item.GhiChu01;
            txtNote2.Text = item.GhiChu02;
            txtNote3.Text = item.GhiChu03;

            txtIndustry.EditValue = item.Size;
            txtProductBrand.EditValue = item.Color;
            chkIsWeb.Checked = Convert.ToBoolean(item.Expiry);

            picPhoto.Image = item.Photo;
            item.GetByStore(item.Product_ID);
            txtQuantity.Value = Convert.ToDecimal(item.Quantity);
            txtDepth.Value = Convert.ToDecimal(item.Depth);

            txtThickness.Value = Convert.ToDecimal(item.Thickness);
            DoHide();
        }

        public virtual void Clear()
        {
            txtID.Text = "";
            txtNAME.Text = "";
            txtMinStock.Value = 0;
            txtQuantity.Value = 0;
            txtOrigin.Text = "";
            txtDepth.Value = 0;

            txtTrongTam1.Text = "";
            txtTrongTam2.Text = "";
            txtTrongTam3.Text = "";

            txtNote1.Text = "";
            txtNote2.Text = "";
            txtNote3.Text = "";

            txtProductBrand.EditValue = null;
            chkIsWeb.Checked = true;

            picPhoto.Image = null;
        }

        public void SetData(string ID)
        {
            txtID.Text = ID;
        }

        public void SetGroup(string id)
        {
            cbxGroup.EditValue = id;
        }

        private bool Check()
        {
            if (txtID.ErrorText != string.Empty | txtID.Text == string.Empty)
            {
                XtraMessageBox.Show("Mã Hàng Hóa không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }
            if (txtNAME.ErrorText != string.Empty | txtNAME.Text == string.Empty)
            {
                XtraMessageBox.Show("Tên Hàng Hóa không được bỏ trống.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtNAME.Focus();
                return false;
            }


            if (cbxGroup.Text == "")
            {
                XtraMessageBox.Show("Chưa chọn nhóm hàng hóa.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                cbxGroup.Focus();
                return false;
            }

            if (cbxUnit.Text == "")
            {
                XtraMessageBox.Show("Chưa chọn đơn vị hàng hóa.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                cbxUnit.Focus();
                return false;
            }

            if (txtStock.Text == "")
            {
                XtraMessageBox.Show("Lỗi:\n\tChưa chọn kho hàng.", "Thông Báo", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        public virtual string Save()
        {
            RaiseSaveClickEventHander();

            #region Kiem tra

            if (!Check()) return "Lỗi";

            #endregion

            //if (clsOption.System.IsQuestion)
            //{
            //    if (XtraMessageBox.Show("Bạn có muốn lưu lại không?", "Thông báo") == DialogResult.No) return;
            //}
            if (_mStatus == Actions.Add)
            {
                return uc_Save();
            }
            if (_mStatus == Actions.Update)
            {
                return UcUpdate();
            }
            if (_mStatus == Actions.Change)
            {
                return uc_Change();
            }
            txtID.Focus();
            return "";
        }

        public virtual void Change()
        {
        }

        public virtual void Delete()
        {
            uc_Delete();
        }

        public virtual void ReLoad()
        {
        }


        private string uc_Save()
        {
            if (!MyRule.IsAdd("bbiMaterial")) return "";

            SysLog.Insert("Quản Lý Hàng Hoá", "Thêm", txtID.Text);

            //CreateWaitDialog();
            SetWaitDialogCaption("Đang lưu...");

            var mySql = new SqlHelper();
            string result = mySql.Start();
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            var cls = new PRODUCT(
                txtID.Text,
                txtNAME.Text,
                cbxProductType.SelectedIndex,
                0,
                cbxGroup.EditValue.ToString(),
                txtStock.EditValue.ToString(),
                txtOrigin.Text,
                txtBarcode.Text,
                cbxUnit.EditValue.ToString(),
                "",
                1,
                Convert.ToDouble(txtOrg_Price.Value),
                Convert.ToDouble(txtSale_Price.Value),
                Convert.ToDouble(txtRetail_Price.Value),
                Convert.ToDouble(txtPriceSales.Value),
                0.0,
                0.0,
                0,
                Convert.ToDouble(txtBonus.Value),
                0.0,
                0.0,
                0.0,
                (cbxProvider.EditValue ?? "").ToString(),
                cbxProvider.Text,
                0,
                Convert.ToDouble(txtMinStock.Value),
                0,
                0,
                0,
                "",

                (txtProductBrand.EditValue ?? "").ToString(), // ProductBrand
                chkIsWeb.Checked, // IsWeb

                0,
                0,
                SysOption.Batch,
                Convert.ToDouble(txtDepth.Value),
                0,
                0,
                Convert.ToDouble(txtThickness.Value),
                (txtIndustry.EditValue ??"").ToString(),
                MyLogin.UserId,
                chkActive.Checked,
                txtTrongTam1.Text.Trim(),
                txtTrongTam2.Text.Trim(),
                txtTrongTam3.Text.Trim(),
                txtNote1.Text.Trim(),
                txtNote2.Text.Trim(),
                txtNote3.Text.Trim()
                );

            result = cls.Insert(mySql.Transaction);
            SetWaitDialogCaption("lưu xong...");
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            result = cls.Update(mySql.Transaction, txtID.Text, picPhoto.Image);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                return result;
            }
            result = ProUnitSave(mySql, txtID.Text);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                return result;
            }

            mySql.Commit();

            RaiseSuccessEventHander(cls);
            SetWaitDialogCaption("Hoàn thành...");
            DoHide();
            return result;
        }

        private string ProUnitSave(SqlHelper sql, string proid)
        {
            string result = "OK";
            var cls = new PRODUCT_UNIT();
            for (int i = 0; i < _dsProUnit.PRODUCT_UNIT.Rows.Count; i++)
            {
                if (cls.Insert(sql.Transaction, proid,
                               _dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID"] == DBNull.Value
                                   ? "kg"
                                   : _dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID"].ToString(),
                               _dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID"] == DBNull.Value
                                   ? "kg"
                                   : _dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID"].ToString(),
                               Convert.ToDecimal(_dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert"] == DBNull.Value
                                                     ? 0
                                                     : _dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert"]), 0))
                {
                    result = sql.Result;
                }
                else
                {
                    result = sql.Result;
                    sql.RollBack();
                }
            }
            return result;
        }

        private string UcUpdate()
        {
            if (!MyRule.IsEdit("bbiMaterial")) return "";

            SysLog.Insert("Quản Lý Hàng Hoá", "Cập Nhật", txtID.Text);
            SetWaitDialogCaption("Đang lưu...");
            var mySql = new SqlHelper();
            string result = mySql.Start();
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }
            var cls = new PRODUCT(
                txtID.Text,
                txtNAME.Text,
                cbxProductType.SelectedIndex,
                0,
                cbxGroup.EditValue.ToString(),
                txtStock.EditValue.ToString(),
                txtOrigin.Text,
                txtBarcode.Text,
                cbxUnit.EditValue.ToString(),
                "",
                1,
                Convert.ToDouble(txtOrg_Price.Value),
                Convert.ToDouble(txtSale_Price.Value),
                Convert.ToDouble(txtRetail_Price.Value),
                Convert.ToDouble(txtPriceSales.Value),
                0.0,
                0.0,
                0,
                Convert.ToDouble(txtBonus.Value),
                0.0,
                0.0,
                0.0,
                cbxProvider.EditValue == null ? "" : cbxProvider.EditValue.ToString(),
                cbxProvider.Text,
                0,
                Convert.ToDouble(txtMinStock.Value),
                0,
                0,
                0,
                "",

                (txtProductBrand.EditValue ?? "").ToString(), // ProductBrand Color
                chkIsWeb.Checked, // IsWeb Expiry

                0,
                0,
                SysOption.Batch,
                Convert.ToDouble(txtDepth.Value),
                0,
                0,
                Convert.ToDouble(txtThickness.Value),
                (txtIndustry.EditValue ?? "").ToString(),
                MyLogin.UserId,
                chkActive.Checked,
                txtTrongTam1.Text.Trim(),
                txtTrongTam2.Text.Trim(),
                txtTrongTam3.Text.Trim(),
                txtNote1.Text.Trim(),
                txtNote2.Text.Trim(),
                txtNote3.Text.Trim());

            result = cls.Update(mySql.Transaction);

            if (result != "OK")
            {
                mySql.RollBack();
                XtraMessageBox.Show(result, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DoHide();
                return result;
            }


            result = cls.Update(mySql.Transaction, txtID.Text, picPhoto.Image);
            if (result != "OK")
            {
                mySql.RollBack();
                DoHide();
                return result;
            }
            mySql.Commit();
            RaiseSuccessEventHander(cls);
            SetWaitDialogCaption("Hoàn thành...");
            DoHide();
            return result;
        }

        private string uc_Change()
        {
            string result = string.Empty;
            return result;
        }

        private string uc_Delete()
        {
            string Result = string.Empty;
            var cls = new PRODUCT();
            cls.Product_ID = txtID.Text;
            Result = cls.Delete();
            if (Result == "OK") RaiseSuccessEventHander(cls);
            return Result;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            m_CloseOrNew = CloseOrNew.Close;
            Save();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            RaiseCancelClickEventHander();
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSaveClick(sender, e);
            }
        }

        private void BtnCancelKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnCancelClick(sender, e);
            }
        }

        private void BtnSaveNewClick(object sender, EventArgs e)
        {
            m_CloseOrNew = CloseOrNew.New;
            if (Save() == "OK")
            {
                Add();
            }
        }

        public void Add()
        {
            Updated();
            txtID.Properties.ReadOnly = false;
            _mStatus = Actions.Add;
            var product = new PRODUCT();
            txtID.Text = SqlHelper.GenCodeExceptCharTheEnd("PRODUCT", "Product_ID", "HH");
            txtNAME.Focus();

            chkActive.Checked = true;
            cbxUnit.Properties.ReadOnly = false;
        }

        private void CbxUnitEditValueChanged(object sender, EventArgs e)
        {
        }

        private void CbxGroupPropertiesButtonClick(object sender,
                                                   ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var productGroupAdd = new XfmProductGroupAdd(Actions.Add);
                productGroupAdd.Added += ProductGroupAddAdded;
                productGroupAdd.ShowDialog();
            }
        }

        private void ProductGroupAddAdded(object sender, PRODUCT_GROUP item)
        {
            ProductGroup();
            cbxGroup.EditValue = item.ProductGroup_ID;
        }

        private void CbxUnitPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var unitAdd = new xfmUnitAdd(Actions.Add);
                unitAdd.Added += UnitAddAdded;
                unitAdd.ShowDialog();
            }
            else if (e.Button.Tag.ToString() == "Convert")
            {
                var proUnit = new xfmProUnit();
                proUnit.Save += ProUnitSave;
                proUnit.ShowDialog();
            }
        }

        private void ProUnitSave(DataTable dt)
        {
            _dsProUnit.PRODUCT_UNIT.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                _dsProUnit.PRODUCT_UNIT.ImportRow(dr);
            }
        }

        private void UnitAddAdded(object sender, UNIT item)
        {
            UnitInit();
            cbxUnit.EditValue = item.Unit_ID;
        }

        private void TxtStockPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var stockAdd = new xfmStockAdd(Actions.Add);
                stockAdd.Added += StockAddAdded;
                stockAdd.ShowDialog();
            }
        }

        private void StockAddAdded(object sender, STOCK item)
        {
            StockInit();
            txtStock.EditValue = item.Stock_ID;
        }

        private void CbxProviderPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var providerAdd = new xfmProviderAdd(Actions.Add);
                providerAdd.Added += ProviderAddAdded;
                providerAdd.ShowDialog();
            }
        }

        private void ProviderAddAdded(object sender, PROVIDER item)
        {
            ProviderInit();
            cbxProvider.EditValue = item.Customer_ID;
        }

        protected virtual void SetValue(DataTable data, string fieldName)
        {
            if (data != null)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    txtNAME.Properties.Items.Add(data.Rows[i][fieldName]);
                }
            }
        }

        protected virtual void SetValue(DataTable data)
        {
            if (data != null)
            {
                if (data.Columns.Count == 0) return;

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    txtNAME.Properties.Items.Add(data.Rows[i][0]);
                }
            }
        }

        protected virtual void TxtNameMouseClick(object sender, MouseEventArgs e)
        {
            //txtNAME.ShowPopup();
        }

        private void BtnHistoryClick(object sender, EventArgs e)
        {
            var xfmHistory = new xfmHistory();
            xfmHistory.SetData(txtID.Text, "");
            xfmHistory.ShowDialog(this);
        }

        private void RpTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            txtMinStock.Enabled = true;
            txtStock.Enabled = true;
            txtBarcode.Enabled = true;
            if (cbxProductType.SelectedIndex == 2)
            {
                txtMinStock.Enabled = false;
                txtStock.Enabled = false;
                txtBarcode.Enabled = false;
            }
        }

        private void TxtStockKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                cbxGroup.Focus();
            }
        }

        private void CbxGroupKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtID.Focus();
            }
        }

        private void TxtBarcodeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtNAME.Focus();
            }
        }

        private void TxtIDKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtBarcode.Focus();
            }
        }

        private void TxtNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                cbxUnit.Focus();
            }
        }

        private void CbxUnitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtOrigin.Focus();
            }
        }

        private void TxtOriginKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtBonus.Focus();
            }
        }

        private void CbxVatKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtMinStock.Focus();
            }
        }

        private void TxtMinStockKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                cbxProvider.Focus();
            }
        }

        private void CbxProviderKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtOrg_Price.Focus();
            }
        }

        private void TxtOrgPriceKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtSale_Price.Focus();
            }
        }

        private void TxtSalePriceKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtRetail_Price.Focus();
            }
        }

        private void TxtRetailPriceKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                btnSaveNew.Focus();
            }
        }

        private void BtnSaveNewKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                uc_Save();
            }
        }

        #region CUSTOMERID

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextEdit) sender;
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                var product = new PRODUCT();
                if (_mStatus == Actions.Add)
                {
                    if (product.Exist(txt.Text))
                    {
                        Err.SetError(txt, "Mã đã tồn tại.");
                        txt.Focus();
                    }
                    //else
                    //{
                    //    txtCUSTOMERNAME.Focus();
                    //}
                }
            }
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            var txt = (TextEdit) sender;
            if (txt.ErrorText != string.Empty) Err.SetError(txt, string.Empty);
            if (_mStatus == Actions.Add)
            {
                var product = new PRODUCT();
                if (product.Exist(txt.Text))
                {
                    Err.SetError(txt, "Mã đã tồn tại.");
                    txt.Focus();
                }
            }
            txtBarcode.Text = txt.Text;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            var txt = (TextEdit) sender;
            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
                //txt.Focus();
            }
        }

        #endregion

        #region txtAccountName

        private void txtNAME_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            //{
            //    txtAddress.Focus();
            //}

            //ProcessDialogKey(e.KeyData);
        }

        private void txtNAME_Leave(object sender, EventArgs e)
        {
            var txt = (TextEdit) sender;
            if (txt.Text == string.Empty)
            {
                Err.SetError(txt, "Ô này không được rỗng.");
                //txt.Focus();
            }
            if (txtID.Text == "")
            {
                txtID.Text = GenerateCode(txtNAME.Text);
            }
        }

        public string GenerateCode(string studentName)
        {
            string code = "";
            string[] words = studentName.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    code += word.Substring(0, 1);
                }
            }
            return code;
        }

        private void TxtNameEditValueChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void gcInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picPhoto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProductBrand_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var xfm = new xfmProductBrandAdd(Actions.Add);
                xfm.Added += new xfmProductBrandAdd.AddedEventHander(xfm_Added);
                xfm.ShowDialog();
            }
        }

        void xfm_Added(object sender, PRODUCT_BRAND item)
        {
            ProductBrandInit();
            txtProductBrand.EditValue = item.ID;
        }

        private void gridLookUpEdit1_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Tag.ToString() == "Add")
            {
                var xfm = new xfmIndustryAdd(Actions.Add);
                xfm.Added += new xfmIndustryAdd.AddedEventHander(xfm_Added);
                xfm.ShowDialog();
            }
        }

        void xfm_Added(object sender, INDUSTRY Item)
        {
            IndustryInit();
            txtIndustry.EditValue = Item.ID;
        }

    }
}