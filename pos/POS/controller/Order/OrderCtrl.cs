using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using DevExpress.XtraGrid.Views.Grid;

using POS.model.Order;
using POS.model.Item;
using POS.controller.Items;
using POS.includes;
using POS.Helpers;
namespace POS.controller.Order
{
    class OrderCtrl:Order00
    {
        frmpos frmpos;
        public OrderCtrl(frmpos _frmpos) {
            frmpos = _frmpos;
        }
        public void open() 
        {
            frmpos.Show();
        }
        public void load() 
        {
            // Load Grid
            var gcItems = frmpos.gcOrder;
            var order = Order01.getOrder(getOrderId());
            GridHelper.setData(gcItems, order);

            // Refresh Labels
            frmpos.lblOrderId.Text = getOrderId().ToString();
            frmpos.lblOrderTotAmt.Text = "999.000";
        }
        public void insert(object _grid) {
            var param = new Dictionary<string,object>();
            var gv = _grid as GridView;
            string desc = (string)gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns["barcode"]);
            
            param.Add("@order00id",1);
            param.Add("@item00id",1);
            param.Add("@qty",1);
            param.Add("@price00id", 1);

            Order01.insertOrder(param);
        }
        public void itemGet() 
        {
            ItemCtrl item = new ItemCtrl(frmpos);
        }
        public void newOrder() 
        {
            Order00.getNewOrder();
            load();
        }
        public int? findOrderid()
        {
            //Order00 order = new Order00(3);
            //var orderlist = order.getOrder00id().FirstOrDefault();
            //return order.getOrder00id().GetValue<int?>("customer00id");
            //return order.getOrder00id().Field<int?>("customer00id");
            return null;
        }

    }
}
