using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors.Controls;
using Perfect.ERP;
using Perfect.Data.Helper;
using Perfect.Common;

namespace Perfect.Dictionary.UI.UBarcode
{
    public partial class XucBaseBarcode : xucBase
    {
        #region Delegates

        public delegate void ItemSelectedEventHander(object sender, Barcode item);

        #endregion

        private int _action;

        private TypeAdd _execType;
        private Int32 _barcodeType = 1;


        public XucBaseBarcode(Int32 barcodeType)
        {
            InitializeComponent();
            Init();
            _execType = new TypeAdd();
            _execType = TypeAdd.Add;
            _barcodeType = barcodeType;
            txtProduct_ID.Focus();
        }

        [DisplayName(@"Action")]
        [Category("Data")]
        public int Action
        {
            set { _action = value; }
        }

        [DisplayName(@"Execute")]
        [Category("Data")]
        public TypeAdd ExecType
        {
            get { return _execType; }
            set { _execType = value; }
        }

        [DisplayName(@"Item")]
        [Category("Data")]
        public Barcode Item { get; set; }

        public event ItemSelectedEventHander ItemSelected;

        private void RaiseItemSelectedEventHander(Barcode item)
        {
            if (ItemSelected != null) ItemSelected(this, item);
        }


        public void ProductInit()
        {
            pRODUCTTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            pRODUCTTableAdapter.Fill(dsPRODUCT.PRODUCT);
        }

        private void TxtCustomerNamePropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                var xfmItemAdd = new xfmItemAdd(Actions.Add);
                xfmItemAdd.Added += XfmItemAddAdded;
                xfmItemAdd.ShowDialog();
            }
        }

        private void XfmItemAddAdded(object sender, PRODUCT Item)
        {
            ProductInit();
        }

        private void TxtProductIdKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetWaitDialogCaption("Đang kiểm tra dữ liệu...");
                var product = new PRODUCT();
                if (product.Get(txtProduct_ID.Text) == "OK")
                {
                    SetWaitDialogCaption("Đang thực hiện thêm dữ liệu dữ liệu...");
                    txtProductName.EditValue = product.Product_ID;
                    txtQuantity.Value = txtQuantity.Value == 0 ? 1 : txtQuantity.Value;

                    txtPrice.Value = Convert.ToDecimal(_barcodeType == 1 ? product.Org_Price : product.Sale_Price);
                    var item = new Barcode(product.Product_ID, txtQuantity.Value, txtPrice.Value, txtAmount.Value,
                                           product, ExecType);
                    RaiseItemSelectedEventHander(item);
                }
                txtProduct_ID.Text = "";
                DoHide();
            }
        }

        private void TxtProductNameEditValueChanged(object sender, EventArgs e)
        {
            if (txtProductName.EditValue == null | txtProductName.Text == "") return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu...");
            var product = new PRODUCT();
            if (product.Get(txtProductName.EditValue.ToString()) == "OK")
            {
                SetWaitDialogCaption("Đang thực hiện thêm dữ liệu dữ liệu...");
                txtQuantity.Value = txtQuantity.Value == 0 ? 1 : txtQuantity.Value;
                txtPrice.Value = Convert.ToDecimal(product.Sale_Price);
            }
            DoHide();
        }

        private void TxtProductIdDoubleClick(object sender, EventArgs e)
        {
            txtProduct_ID.Text = "";
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (txtProductName.EditValue == null | txtProductName.Text == "") return;
            SetWaitDialogCaption("Đang kiểm tra dữ liệu...");
            var product = new PRODUCT();
            if (product.Get(txtProductName.EditValue.ToString()) == "OK")
            {
                SetWaitDialogCaption("Đang thực hiện thêm dữ liệu dữ liệu...");
                var item = new Barcode(product.Product_ID, txtQuantity.Value, txtPrice.Value, txtAmount.Value, product,
                                       ExecType);
                RaiseItemSelectedEventHander(item);
            }
            DoHide();
        }


        public void Init()
        {
            //CreateWaitDialog();
            //SetWaitDialogCaption("Đang kiểm tra dữ liệu...");
            ProductInit();
            //DoHide();
        }

        private void CbxActionSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAction.SelectedIndex == 0)
            {
                _execType = TypeAdd.Duplicate;
            }
            else if (cbxAction.SelectedIndex == 1)
            {
                _execType = TypeAdd.Replace;
            }
            else if (cbxAction.SelectedIndex == 2)
            {
                _execType = TypeAdd.Add;
            }
            else if (cbxAction.SelectedIndex == 3)
            {
                _execType = TypeAdd.Single;
            }
        }

        private void CbxActionPropertiesButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                string html = "<B>Thêm Dòng Mới:</B> Cho phép thêm dòng hàng hoá mới vào lưới khi thực hiện lệnh. ";
                html +=
                    "<B>Thay Thế:</B> Cho phép thay thế dòng hàng hoá trên lưới nếu tồn tại bằng thông tin những thông tin mới. Ngược lại thì thêm vào..";
                html += "<b>Công Thêm:</b> Cho phép cộng thêm số lượng mới trên dòng hàng hoá mới nếu tồn tại.";
                html += "<b>Kiểm Tra Tồn:</b> Không chép thêm dòng hàng hoá vào nếu tồn tại.";
                alc.BeforeFormShow += alc_BeforeFormShow;
                alc.Show(ParentForm, "Trợ Giúp", html);
                alc.FormClosing += alc_FormClosing;
            }
        }

        private void alc_FormClosing(object sender, AlertFormClosingEventArgs e)
        {
            e.AlertForm.Size = new Size(250, 100);
        }

        private void alc_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            e.AlertForm.Size = new Size(250, 175);
            // MessageBox.Show(e.AlertForm.Size.Width.ToString(), e.AlertForm.Size.Height.ToString());
        }

        protected override void OnFirstLoad()
        {
            ProductInit();
            base.OnFirstLoad();
        }

        public void Calculator()
        {
        }

        private void TxtQuantityEditValueChanged(object sender, EventArgs e)
        {
            txtAmount.Value = txtQuantity.Value*txtPrice.Value;
        }

        private void TxtPriceEditValueChanged(object sender, EventArgs e)
        {
            txtAmount.Value = txtQuantity.Value*txtPrice.Value;
        }

        private void TxtAmountEditValueChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Value != 0)
            {
                if (txtPrice.Value == 0)
                {
                    txtPrice.Value = txtAmount.Value;
                    txtQuantity.Value = 1;
                }
                else
                {
                    txtQuantity.Value = txtAmount.Value / txtPrice.Value;
                }
            }
            else
            {
                if (txtPrice.Value == 0)
                {
                    txtPrice.Value = txtAmount.Value;
                    txtQuantity.Value = 1;
                }
                else
                {
                    txtPrice.Value = txtAmount.Value/txtQuantity.Value;
                }
            }
        }

        private void BtnAddKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int) Keys.Enter )
            {
                if (txtProductName.EditValue == null | txtProductName.Text == "") return;
                SetWaitDialogCaption("Đang kiểm tra dữ liệu...");
                var product = new PRODUCT();
                if (product.Get(txtProductName.EditValue.ToString()) == "OK")
                {
                    SetWaitDialogCaption("Đang thực hiện thêm dữ liệu dữ liệu...");
                    var item = new Barcode(product.Product_ID, txtQuantity.Value, txtPrice.Value, txtAmount.Value, product,
                                           ExecType);
                    RaiseItemSelectedEventHander(item);
                }
                DoHide();
            }
        }
    }

    public class Barcode
    {
        public Barcode(string id, double quantity, double price, double amount, PRODUCT item, xucBase.TypeAdd action)
        {
            Id = id;
            this.Quantity = quantity;
            this.Price = price;
            this.Amount = amount;
            this.Action = action;
            this.Item = item;
        }


        public Barcode(string id, decimal quantity, decimal price, decimal amount, PRODUCT item, xucBase.TypeAdd action)
        {
            Id = id;
            this.Quantity = Convert.ToDouble(quantity);
            this.Price = Convert.ToDouble(price);
            this.Amount = Convert.ToDouble(amount);
            this.Action = action;
            this.Item = item;
        }

        public Barcode()
        {
            Id = "";
            Quantity = 0.0;
            Price = 0.0;
            Amount = 0.0;
            Action = 0.0;
            Item = new PRODUCT();
        }

        [DisplayName(@"Item")]
        [Category("Data")]
        public PRODUCT Item { get; set; }

        [DisplayName(@"Action")]
        [Category("Data")]
        public xucBase.TypeAdd Action { get; set; }

        [DisplayName(@"Amount")]
        [Category("Data")]
        public double Amount { get; set; }

        [DisplayName(@"Barcode")]
        [Category("Data")]
        public string Id { get; set; }

        [DisplayName(@"Price")]
        [Category("Data")]
        public double Price { get; set; }

        [DisplayName(@"Quantity")]
        [Category("Data")]
        public double Quantity { get; set; }
    }
    
}

