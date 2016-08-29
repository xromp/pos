using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using POS.includes;
using POS.Helpers;
namespace POS.model.Order
{
    class Order00 : dbprocess
    {
        int order00id;
        public DataTable get()
        {
            DataTable dt = new DataTable();
            openConn();
            dt.Load(setDataReader("sp_Order00Get"));
            return dt;
        }
        public DataRow getOrder00id()
        {
            DataTable dt = new DataTable();
            var dict = new Dictionary<string, object>();
            dict.Add("@order00id", Order00.getOrderId());

            openConn();
            dt.Load(execStoreProc("sp_Order00Get",dict));

            var r = dt.AsEnumerable().FirstOrDefault();
            return r;// how can this be return null
        }

        #region DataProcess
            // including tables that can be afftected
        public void getNewOrder() 
        {
            DataTable dt = new DataTable();
            openConn();

            var param = new Dictionary<string, object>();
            param.Add("@customer00id", 1);
            param.Add("@machine00id", GlobalVar.machineid);
            param.Add("@user00id", GlobalVar.userid);

            dt.Load(execStoreProc("sp_order00Insert", param));
        }
        #endregion
        #region Retrieve        
        public DataTable getOrder() {
            return get();

        }
        public int getOrderId() 
        {
            DataTable dt = new DataTable();
            openConn();

            var param = new Dictionary<string, object>();
            param.Add("@machine00id",GlobalVar.machineid);
            param.Add("@user00id", GlobalVar.userid);
            dt.Load(execStoreProc("sp_Order00IdGet", param));

            DataRow orderid = dt.AsEnumerable().FirstOrDefault();
            return orderid.GetValue<int>("order00id").GetValueOrDefault();
        }
        #endregion
    }
}
