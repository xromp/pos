using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
namespace POS.config
{
    public class Connection
    {
        public SqlConnection conn;
        public SqlTransaction transac;
        public Connection()
        { 
            string connstr= "Data Source=XROMP\\DEV;Initial Catalog=A;Integrated Security=True";
            conn = new SqlConnection(connstr);
        }

        public void openConn() {
            conn.Close();
            conn.Open();
            //transac = conn.BeginTransaction();
        }
        public void closeConn(){
            transac.Commit();
            conn.Close();
        }
        public void errorTransac() {
            transac.Rollback();
            conn.Close();
        }
    }
}
