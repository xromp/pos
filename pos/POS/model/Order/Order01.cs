using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using POS.includes;
namespace POS.model.Order
{
  class Order01:dbprocess
  {
      int order00id;
      public Order01() { 
      
      } 
      public Order01(int _order00id)
      {
          order00id = _order00id;
      }
      public DataTable orderByOrderIdGet() 
      {
          DataTable dt = new DataTable();
          openConn();

          var dict = new Dictionary<string, object>();
          dict.Add("@order00id", order00id);

          dt.Load(execStoreProc("sp_Order01ByOrderGet",dict));
          return dt;
      }
      #region DataProcess
      // including tables that can be afftected
      public static void insertOrder(Dictionary<string,object> _param) {
          Order01 order = new Order01();
          var param = _param;
          order.openConn();
          order.execStoreProc("sp_Order01Insert", param);
      }
      #endregion
      #region Retrieve
      /// <summary>
      /// Parameters are not just only by Order00id
      /// </summary>
      /// <param name="_obj">Order00id,user00id,machine00id</param>
      /// <returns></returns>
      public static DataTable getOrder(int _order00id)
      {
          Order01 order = new Order01(_order00id);
          return order.orderByOrderIdGet();

      }
      #endregion
  }
}
