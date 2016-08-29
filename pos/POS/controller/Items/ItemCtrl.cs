
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.XtraGrid.Views.Grid;

using POS.views;
using POS.includes;
using POS.Helpers;
using POS.model.Item;
using POS.model.Order;

using POS.controller.Order;
namespace POS.controller.Items
{
    class ItemCtrl
    {
        frmItems frmItems;
        frmpos frmPos;
        public bool isSuccess { get; set; }
        public ItemCtrl(frmItems _frmItems)
        {
            frmItems = _frmItems;

            var gcItems  = frmItems.gcItems;
            var items = Item00.detailByNameget();
            GridHelper.setData(gcItems,items);

            frmItems.Show();
        }
        public ItemCtrl(frmpos _frmPos)
        {
            frmPos = _frmPos;
            frmItems item = new frmItems(frmPos);
        }
        public void itemGet(string _item) 
        {
            var gcItems = frmItems.gcItems;
            var items = Item00.detailByNameget(_item);
            GridHelper.setData(gcItems, items);

        }
        public bool orderInsert()
        {
            GridView grid = frmItems.gvItems as GridView;
            var param = new Dictionary<string,object>();
            var item00id = (int)grid.GetRowCellValue(grid.FocusedRowHandle, grid.Columns["item00id"]);
            
            param.Add("@order00id",Order00.getOrderId());
            param.Add("@item00id",item00id);
            param.Add("@qty",1);
            param.Add("@price00id", 1);

            Order01.insertOrder(param);
            frmItems.Close();
            isSuccess = true;
            return true;
        }
    }
}
    