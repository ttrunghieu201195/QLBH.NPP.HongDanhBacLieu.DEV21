using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.Common;
using Perfect.Dictionary.Employee;
using Perfect.Inventory.Core.Inventory.Packet.UI;
using Perfect.Inventory.Core.Sale.Transfer;
using Perfect.Dictionary;
using Perfect.ERP;

namespace Perfect.Inventory
{
    

    public partial class xfmPacket : xfmBase
    {
        private xucPacketA _ucPacketA;
        public xfmPacket()
        {
            InitializeComponent();
            ReadLayout();
            niPackBTP_LinkClicked(this, null);
        }

        //public void SetPart(PerfectPart part)
        //{
        //    _ucPacketA.Part = part;
        //    if (part==PerfectPart.SaleNormal)
        //    {
        //        Text = "Xuất Kho";
        //    }
        //    else
        //    {
        //        Text = "Xuất Kho & Đóng Gói";
        //    }

        //    //_ucPacketA.Init();
        //}
       
        private void xfmSale_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
           
            if (_ucPacketA != null)
            {
                if (_ucPacketA.NotSave)
                {
                    System.Windows.Forms.DialogResult result = XtraMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có muốn lưu lại không?", "Thông Báo",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        _ucPacketA.Save();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

                }

                if (File.Exists(Application.StartupPath + "\\Data\\STOCK_TRANSFER_PACK" + _ucPacketA.Part + ".xml"))
                {
                    File.Delete(Application.StartupPath + "\\Data\\STOCK_TRANSFER_PACK" + _ucPacketA.Part + ".xml");
                }
            }
            

            if (_ucPacketB != null)
            {
                if (_ucPacketB.NotSave)
                {
                    System.Windows.Forms.DialogResult result = XtraMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có muốn lưu lại không?", "Thông Báo",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        _ucPacketB.Save();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

                }

                if (File.Exists(Application.StartupPath + "\\Data\\STOCK_TRANSFER_PACK" + _ucPacketB.Part + ".xml"))
                {
                    File.Delete(Application.StartupPath + "\\Data\\STOCK_TRANSFER_PACK" + _ucPacketB.Part + ".xml");
                }
            }
        
         }

        private void niPackBTP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucPacketA == null)
            {
                _ucPacketA = new xucPacketA(EnumRefType.TransferPack1);
                _ucPacketA.Part = EnumRefType.TransferPack1;
                //_ucPacketA.LoadDefaultProduct(PerfectPart.TransferPack1);
                _ucPacketA.Add();
            }
            _ucPacketA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucPacketA);
            plMain.Text = "Đóng Gói Bán Thành Phẩm";
        }


        private void dplPacket_Layout(object sender, LayoutEventArgs e)
        {
            SaveLayout();
        }

        void SaveLayout()
        {
            try
            {
                dm.SaveLayoutToXml(Application.StartupPath + "\\Layout\\PacketDM.xml");
                dm.SaveToXml(Application.StartupPath + "\\Layout\\PacketPanel.xml");
            }
            catch (Exception)
            {
            }

        }

        void ReadLayout()
        {
            if (File.Exists(Application.StartupPath + "\\Layout\\PacketDM.xml"))
            {
                dm.RestoreLayoutFromXml(Application.StartupPath + "\\Layout\\PacketDM.xml");
            }

            if (File.Exists(Application.StartupPath + "\\Layout\\PacketPanel.xml"))
            {
                dm.RestoreFromXml(Application.StartupPath + "\\Layout\\PacketPanel.xml");
            }
        }

        private xucPacketA _ucPacketB;
        private void niPacketTP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucPacketB == null)
            {
                _ucPacketB = new xucPacketA(EnumRefType.TransferPack2);
                _ucPacketB.Part = EnumRefType.TransferPack2;
                //_ucPacketA.LoadDefaultProduct(PerfectPart.TransferPack2);
                _ucPacketB.Add();
            }
            _ucPacketB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_ucPacketB);
            plMain.Text = "Đóng Gói Thành Phẩm";
        }

        private xucPacketList _xucPacketListA;

        private void niList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucPacketListA == null)
            {
                _xucPacketListA = new xucPacketList(ListType.General);
                _xucPacketListA.ListStyle = ListType.General;
                _xucPacketListA.SendId += _xucOutwardListA_SendId;
                _xucPacketListA.AddNewClick += _xucOutwardListA_AddNewClick;
                _xucPacketListA.Reload();
            }
            _xucPacketListA.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucPacketListA);
            plMain.Text = "Bảng Kê Đóng Gói Theo Chứng Từ";
        }

        void _xucOutwardListA_AddNewClick(object sender)
        {
            //kiem tra thuoc phieu dong goi nao
            if (((xucPacketList)sender).Part == EnumRefType.TransferPack1)
            {
                niPackBTP_LinkClicked(this, null);
                _ucPacketA.Add();
            }
            else
            {
                niPacketTP_LinkClicked(this, null);
                _ucPacketB.Add();
            }
        }

        void _xucOutwardListA_SendId(object sender, string id)
        {
            //kiem tra thuoc phieu dong goi nao
            if (((xucPacketList)sender).Part == EnumRefType.TransferPack1)
            {
                niPackBTP_LinkClicked(this, null);
                _ucPacketA.SetData(id);
            }
            else
            {
                niPacketTP_LinkClicked(this, null);
                _ucPacketB.SetData(id);
            }
        }


        private Core.Inventory.Packet.UI.xucDetailListA _xucPacketListB;

        private void nvgDetailList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucPacketListB == null)
            {
                _xucPacketListB = new Core.Inventory.Packet.UI.xucDetailListA(9);
                _xucPacketListB.SendId += new xucBasicListL3.SendIdEventHander(_xucPacketListB_SendId);
                _xucPacketListB.AddNewClick += new ButtonClickEventHander(_xucPacketListB_AddNewClick);
                _xucPacketListB.Reload();
            }
            _xucPacketListB.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucPacketListB);
            plMain.Text = "Bảng Kê Đóng Gói Theo Hàng Nhập";
        }

        void _xucPacketListB_AddNewClick(object sender)
        {
            if (((Core.Inventory.Packet.UI.xucDetailListA)sender).Part == EnumRefType.TransferPack1)
            {
                niPackBTP_LinkClicked(this, null);
                _ucPacketA.Add();
            }
            else
            {
                niPacketTP_LinkClicked(this, null);
                _ucPacketB.Add();
            }
        }

        void _xucPacketListB_SendId(object sender, string id)
        {
            if (((Core.Inventory.Packet.UI.xucDetailListA)sender).Part == EnumRefType.TransferPack1)
            {
                niPackBTP_LinkClicked(this, null);
                _ucPacketA.SetData(id);
            }
            else
            {
                niPacketTP_LinkClicked(this, null);
                _ucPacketB.SetData(id);
            }
        }

        private Core.Inventory.Packet.UI.xucDetailListA _xucPacketListC;

        private void niMerrialList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            nvgDictionary.Visible = false;
            plMain.Controls.Clear();
            if (_xucPacketListC == null)
            {
                _xucPacketListC = new Core.Inventory.Packet.UI.xucDetailListA(8);
                _xucPacketListC.ListStyle = ListType.Merrial;
                _xucPacketListC.SendId += _xucPacketListB_SendId;
                _xucPacketListC.AddNewClick += _xucPacketListB_AddNewClick;
                _xucPacketListC.Reload();
            }
            _xucPacketListC.Dock = DockStyle.Fill;
            plMain.Controls.Add(_xucPacketListC);
            plMain.Text = "Bảng Kê Đóng Gói Theo Hàng Xuất";
        }

        private void niProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfmItemAdd xfmItemAdd = new xfmItemAdd(Actions.Add);
            xfmItemAdd.Added += new xfmItemAdd.AddedEventHander(xfmItemAdd_Added);
            xfmItemAdd.Show(this);
        }

        void xfmItemAdd_Added(object sender, PRODUCT Item)
        {
            if (_ucPacketA != null)
            {
                _ucPacketA.Product_Init();
                _ucPacketA.ProductAdd(Item);
            }

            if (_ucPacketB != null)
            {
                _ucPacketB.Product_Init();
                _ucPacketB.ProductAdd(Item);
            }

        }

        private void niEmployee_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XfmEmployeeAdd xfmEmployeeAdd = new XfmEmployeeAdd(Actions.Add);
            xfmEmployeeAdd.Added += new XfmEmployeeAdd.AddedEventHander(xfmEmployeeAdd_Added);
            xfmEmployeeAdd.Show(this);
        }

        void xfmEmployeeAdd_Added(object sender, EMPLOYEE Item)
        {
            if (_ucPacketA != null)
            {
                _ucPacketA.Customer_Init();
                _ucPacketA.SetEmployee(Item);
            }

            if (_ucPacketB != null)
            {
                _ucPacketB.Customer_Init();
                _ucPacketB.SetEmployee(Item);
            }
        }

        private void niStock_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xfmStockAdd xfmStockAdd = new xfmStockAdd(Actions.Add);
            xfmStockAdd.Added += new xfmStockAdd.AddedEventHander(xfmStockAdd_Added);
            xfmStockAdd.Show(this);

        }

        void xfmStockAdd_Added(object sender, STOCK Item)
        {
            if (_ucPacketA != null)
            {
                _ucPacketA.Stock_Init();
                _ucPacketA.SetStock(Item);
            }

            if (_ucPacketB != null)
            {
                _ucPacketB.Stock_Init();
                _ucPacketB.SetStock(Item);
            }
        }

        private void xfmPacket_Activated(object sender, EventArgs e)
        {
            if (_ucPacketA != null) _ucPacketA.Updated();
            if (_ucPacketB != null) _ucPacketB.Updated();
        }
    }
}