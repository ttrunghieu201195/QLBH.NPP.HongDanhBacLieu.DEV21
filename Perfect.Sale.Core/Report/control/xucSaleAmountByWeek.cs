using Perfect.Data.Helper;
using Perfect.ERP;
using DevExpress.XtraBars;

namespace Perfect.Sale.Core.Report.control
{
    public partial class XucSaleAmountByWeek : Perfect.Common.xucBasicListL3
    {
        public XucSaleAmountByWeek()
        {
            InitializeComponent();

            Init();
        }


        private new void Init()
        {
            base.Init();

            Bar.Bar.bbiHelp.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiDelete.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiSave.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiEdit.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiPrint.Visibility = BarItemVisibility.Never;
            Bar.Bar.bbiAdd.Visibility = BarItemVisibility.Never;
            Bar.Bar.bm.SetPopupContextMenu(gcList, Bar.Bar.pm);
        }

        public override void Reload()
        {

            SysLog.Insert("Doanh Thu Theo Tuan", "Xem");
            sALE_SaleAmountByWeekTableAdapter.Connection.ConnectionString = SqlHelper.ConnectString;
            sALE_SaleAmountByWeekTableAdapter.Fill(dsSaleAmountByWeek.SALE_SaleAmountByWeek, Bar.From, Bar.To);

        }
        

    }
}
