using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Perfect.ERP;
using Perfect.Inventory.Core.Inventory.Inventory;
using Perfect.Inventory.Core.Inventory.Inventory.Dates;
using Perfect.Inventory.Core.Inventory.Inventory.Details;
using Perfect.Inventory.Core.Inventory.Inventory.Details.TS;
using Perfect.Inventory.Core.Inventory.Inventory.Summary;
using Perfect.Inventory.Core.Inventory.StockCard;
using Perfect.Inventory.Core.Inventory.DetailProductBook;

namespace Perfect.Inventory.Core.Inventory.Report
{
    public partial class XfmReports : XtraForm
    {
        private xucCustomerProduct _customerProduct;
        private xucProductCustomer _productCustomer;
        private xucDetailAllStock _xucDetailAllStock;
        private XucInventoryByGroup _xucInventoryByGroup;
        private xucInventoryDetail _xucInventoryDetail;
        private xucInventoryRevenue _xucInventoryRevenue;
        private xucInventorySummary _xucInventorySummary;
        private xucSummaryDate _xucSummaryDate;
        private xucSummaryQuantity _xucSummaryQuantity;

        public XfmReports()
        {
            InitializeComponent();
            niInventorySummaryAVGUnitPrice.Visible = false;
        }


        private void XfmReportManagersLoad(object sender, EventArgs e)
        {
        }

        private xucInventoryDetailWithAVGPrice _xucInventoryDetailWithAVGPrice;

        private void NiInventoryAverageLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //if (!MyRule.IsAccess("bbiReport")) return;
            //plMain.Controls.Clear();
            //plMain.Text = @"Tồn Kho Tổng Hợ";
            //if (_xucInventoryDetail == null)
            //{
            //    _xucInventoryDetail = new xucInventoryDetail { Dock = DockStyle.Fill };
            //}
            //plMain.Controls.Add(_xucInventoryDetail);

            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Tồn Kho Tổng Hợp";
            if (_xucInventoryDetailWithAVGPrice == null)
            {
                _xucInventoryDetailWithAVGPrice = new xucInventoryDetailWithAVGPrice { Dock = DockStyle.Fill };
            }
            plMain.Controls.Add(_xucInventoryDetailWithAVGPrice);


        }

        
        private void NiInventorySumaryLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;

            plMain.Controls.Clear();
            plMain.Text = @"Tổng Hợp Tồn Số Lượng & Giá Trị";
            if (_xucInventorySummary == null)
            {
                _xucInventorySummary = new xucInventorySummary {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_xucInventorySummary);
        }

        // private xucInventoryLedger _xucInventoryLedger;

        private void NiInventoryLedgerLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //if (!MyRule.IsAccess("bbiReport")) return;
            //plMain.Controls.Clear();
            //plMain.Text = "Sổ Chi Tiết Vật Tư";
            //if (_xucInventoryLedger == null)
            //{
            //    _xucInventoryLedger = new xucInventoryLedger();
            //    _xucInventoryLedger.Dock = DockStyle.Fill;
            //}
            //plMain.Controls.Add(_xucInventoryLedger);
        }

        //private XucInventoryCard _xucInventoryCard;

        private xucStockCard _xucStockCard;

        private void NiStockCardLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Thẻ Kho";
            if (_xucStockCard == null)
            {
                _xucStockCard = new xucStockCard();
            }
            _xucStockCard.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucStockCard);
        }

        private void NiInventoryQuantitySummaryLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Tổng Hợp Tồn Số Lượng";
            if (_xucSummaryQuantity == null)
            {
                _xucSummaryQuantity = new xucSummaryQuantity {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_xucSummaryQuantity);
        }

        private void NiInventoryAllStockLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Tồn Kho Theo Nhiều Kho";
            if (_xucDetailAllStock == null)
            {
                _xucDetailAllStock = new xucDetailAllStock {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_xucDetailAllStock);
        }

        private void NiTotalLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Báo Cáo Tổng Hợp";
            if (_xucInventoryRevenue == null)
            {
                _xucInventoryRevenue = new xucInventoryRevenue {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_xucInventoryRevenue);
        }

        private void NiInventoryDateSummaryLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Tổng Hợp Tồn Kho Số Lượng Theo Ngày";
            if (_xucSummaryDate == null)
            {
                _xucSummaryDate = new xucSummaryDate {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_xucSummaryDate);
        }

        private void NiCustomerProductLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Bảng kê xuất kho theo khách hàng và hàng hóa";
            if (_customerProduct == null)
            {
                _customerProduct = new xucCustomerProduct {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_customerProduct);
        }

        private void NiProductCustomerLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Bảng kê xuất kho theo hàng hóa và khách hàng";
            if (_productCustomer == null)
            {
                _productCustomer = new xucProductCustomer {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_productCustomer);
        }

        private void NiInventoryByGroupLinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Tồn kho theo kho và nhóm hàng";
            if (_xucInventoryByGroup == null)
            {
                _xucInventoryByGroup = new XucInventoryByGroup {Dock = DockStyle.Fill};
            }
            plMain.Controls.Add(_xucInventoryByGroup);
        }

        private void NiInventoryExceedLimitLinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void NiInventoryLowerlimitLinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private void NiInventoryOrderLinkClicked(object sender, NavBarLinkEventArgs e)
        {

        }

        private xucInventorySummaryWithAVGUnitPrice _xucInventorySummaryWithAVGUnitPrice;

        private void niInventorySummaryAVGUnitPrice_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Bảng tổng hợp hàng hóa";
            if (_xucInventorySummaryWithAVGUnitPrice == null)
            {
                _xucInventorySummaryWithAVGUnitPrice = new xucInventorySummaryWithAVGUnitPrice { Dock = DockStyle.Fill };
            }
            plMain.Controls.Add(_xucInventorySummaryWithAVGUnitPrice);
        }

        private xucDetailProduct _xucDetailProduct;
        private void niDetailProductBook_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (!MyRule.IsAccess("bbiReport")) return;
            plMain.Controls.Clear();
            plMain.Text = @"Sổ chi tiết hàng hóa";
            if (_xucDetailProduct == null)
            {
                _xucDetailProduct = new xucDetailProduct { Dock = DockStyle.Fill };
            }
            plMain.Controls.Add(_xucDetailProduct);

        }
    }
}