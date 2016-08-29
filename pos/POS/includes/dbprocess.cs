using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using POS.Helpers;
using POS.config;
namespace POS.includes
{
    public class dbprocess:Connection
    {
        protected SqlDataReader setDataReader(string _sql)
        {
            SqlCommand cmd = new SqlCommand(_sql, conn, transac);
            cmd.CommandTimeout = 30;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            return reader;
        }
        protected SqlDataReader execStoreProc(string _sp, Dictionary<string, object> _params = null)
        {
            SqlCommand cmd = new SqlCommand(_sp, conn,transac);
            cmd.CommandTimeout = 30;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (var item in _params.EmptyIfNull())
            {
                cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            return reader;

        }
    }
}
