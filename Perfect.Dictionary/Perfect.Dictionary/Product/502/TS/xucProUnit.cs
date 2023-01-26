using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Perfect.ERP;
using Perfect.Data.Helper;

namespace Perfect.Dictionary.Product._502.TS
{
    public partial class xucProUnit : Perfect.Common.xucBase
    {
        public xucProUnit()
        {
            InitializeComponent();
            initUnit();
        }

        private string status = "New";
        private string _id;
        private string _unit;
        public void SetData(string id,string unit)
        {

            pRODUCT_UNITTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            pRODUCT_UNITTableAdapter.ClearBeforeFill = true;
            pRODUCT_UNITTableAdapter.Fill(dsProUnit.PRODUCT_UNIT, id);
            status = "Edit";
            _id = id;
            _unit = unit;
        }

        public delegate void ClickSaveEventHander(DataTable dt);

        public delegate void ClickCancelEventHander();

        public event ClickSaveEventHander Save;
        public event ClickCancelEventHander Cancel;

        public void RaiseClickSaveEventHander(DataTable dt)
        {
            if(Save != null)
            {
                Save(dt);
            }
        }
        public void RaiseClickCancelEventHander()
        {
            if (Cancel != null)
            {
                Cancel();
            }
        }

        void initUnit()
        {
            uNITTableAdapter.Connection.ConnectionString = Perfect.Data.Helper.SqlHelper.ConnectString;
            uNITTableAdapter.ClearBeforeFill = true;
            uNITTableAdapter.Fill(dsUnit.UNIT);

            FormatColumns(glkUnit, "Unit_ID", 0, 20, "Mã");
            FormatColumns(glkUnit, "Unit_Name", 1, 20, "Đơn Vị");

            colUnit_ID.OptionsColumn.AllowEdit = false;
            //colUnit_ID.OptionsColumn.ReadOnly = true;

            
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PRODUCT_UNIT productUnit = new PRODUCT_UNIT();
            SqlHelper sql = new SqlHelper();
            string result = "Error";
            if (status == "New")
            {
                RaiseClickSaveEventHander(dsProUnit.PRODUCT_UNIT);
            }
            else
            {
                sql.Start();
                Perfect.Common.clsOption.SetWaitDialogCaption("Ðang thực hiện cập nhật dữ liệu");

                for (int i = 0; i < dsProUnit.PRODUCT_UNIT.Rows.Count; i++)
                {
                    if (dsProUnit.PRODUCT_UNIT.Rows[i].RowState == DataRowState.Deleted)
                    {
                        string[] myPara = { "@Product_ID", "@Unit_ID", "@UnitConvert_ID" };
                        object[] myValue = { _id, dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID", DataRowVersion.Original].ToString(), dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID", DataRowVersion.Original].ToString() };
                        sql.CommandType = CommandType.Text;
                        result = sql.ExecuteNonQuery(sql.Transaction, "DELETE FROM PRODUCT_UNIT WHERE Product_ID = @Product_ID AND Unit_ID = @Unit_ID AND UnitConvert_ID = @UnitConvert_ID ", myPara, myValue);
                        if (result != "OK")
                        {
                            Perfect.Common.clsOption.DoHide();
                            sql.RollBack();
                            XtraMessageBox.Show("Không thể cập nhật dữ liệu này", "Thông Báo", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (dsProUnit.PRODUCT_UNIT.Rows[i].RowState == DataRowState.Modified)
                    {

                        if (!productUnit.Update(sql.Transaction, _id,
                                           dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID"] == DBNull.Value
                                               ? "kg"
                                               : dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID"].ToString(),
                                           dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID"] == DBNull.Value
                                               ? "kg"
                                               : dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID"].ToString(),
                                           Convert.ToDecimal(dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert"] ==
                                                             DBNull.Value
                                                                 ? 0
                                                                 : dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert"]), 0))
                        {
                            Perfect.Common.clsOption.DoHide();
                            sql.RollBack();
                            XtraMessageBox.Show("Không thể cập nhật dữ liệu này", "Thông Báo", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (dsProUnit.PRODUCT_UNIT.Rows[i].RowState == DataRowState.Added)
                    {

                        if (!productUnit.Insert(sql.Transaction, _id,
                                           dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID"] == DBNull.Value
                                               ? "kg"
                                               : dsProUnit.PRODUCT_UNIT.Rows[i]["Unit_ID"].ToString(),
                                           dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID"] == DBNull.Value
                                               ? "kg"
                                               : dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert_ID"].ToString(),
                                           Convert.ToDecimal(dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert"] ==
                                                             DBNull.Value
                                                                 ? 0
                                                                 : dsProUnit.PRODUCT_UNIT.Rows[i]["UnitConvert"]), 0))
                        {
                            Perfect.Common.clsOption.DoHide();
                            sql.RollBack();
                            XtraMessageBox.Show("Không thể cập nhật dữ liệu này", "Thông Báo", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            return;
                        }

                    }


                }

                if (sql.Commit() == "OK")
                {
                    Perfect.Common.clsOption.SetWaitDialogCaption("Ðã hoàn thành");
                    Perfect.Common.clsOption.DoHide();
                    XtraMessageBox.Show("Ðã cập nhật bảng quy đổi đơn vị", "Thông Báo", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    RaiseClickCancelEventHander();
                }
                else
                {
                    return;
                }
            }

        }


        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RaiseClickCancelEventHander();
        }

        private void gdList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                
                gdList.DeleteSelectedRows();

                //gdList.DeleteRow(gdList.FocusedRowHandle);
            }
            
        }
        Column m_Column;
        public enum Column
        {
            None = 0,
            Lock = 1,
            UnitConvert_ID = 2,
            UnitConvert = 3,
            Unit_ID = 4

        }

        private void gdList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gdList.UpdateCurrentRow();
            m_Column = Column.None;
            if (m_Column == Column.Lock) return;
            if (m_Column == Column.None)
            {
                if (e.Column.FieldName == "UnitConvert_ID")
                {
                    m_Column = Column.UnitConvert_ID;
                }
                else if (e.Column.FieldName == "UnitConvert")
                {
                    m_Column = Column.UnitConvert;
                }
                else if (e.Column.FieldName == "Unit_ID")
                {
                    m_Column = Column.Unit_ID;
                }

            }

            switch (m_Column)
            {
                case Column.None:
                    return;
                case  Column.UnitConvert_ID :
                    {
                        gdList.SetRowCellValue(e.RowHandle, "Unit_ID",_unit);
                        break;
                    }
                case Column.UnitConvert:
                    {
                        gdList.SetRowCellValue(e.RowHandle, "Unit_ID", _unit);
                        break;
                    }
            }


        }

       

        
    }
}
