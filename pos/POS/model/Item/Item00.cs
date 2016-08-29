using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using POS.includes;
namespace POS.model.Item
{
    class Item00:dbprocess
    {
        public DataTable get() 
        {
            DataTable dt = new DataTable();
            openConn();
            dt.Load(setDataReader("sp_Item00DetailGet"));
            return dt;
        }
        #region DataProcess
        
        #endregion
        #region Retrieve
        public static DataTable detailget() {
            Item00 item = new Item00();
            return item.get();
        }
        public static DataTable detailByNameget(string _name="")
        {
            Item00 item = new Item00();
            DataTable dt = new DataTable();
            item.openConn();

            var param = new Dictionary<string, object>();
            param.Add("@itemName", _name);
            dt.Load(item.execStoreProc("sp_Item00ByNameGet",param));
            return dt;
        }
        #endregion
    }
}
