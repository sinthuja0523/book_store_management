using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Data.SqlServerCe;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;

namespace BookStoreMgt
{
    class ConnectionSQLserver
    {
        //string startPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        //string conSTR = Path.Combine(startPath, "bookstoreDB.sdf");
        //public SqlCeConnection objConnection = new SqlCeConnection("Data Source ="+Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "bookstoreDB.sdf"));
        //public SqlCeConnection objConnection = new SqlCeConnection(ConfigurationManager.ConnectionStrings["bookstoreDB"].ToString().Trim());

        // public SqlCeConnection objConnection = new SqlCeConnection("Data Source = bookstoreDB.sdf");
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-L5BDKBP;Initial Catalog=book_store;Integrated Security=True;TrustServerCertificate=True");
        public ConnectionSQLserver()
        {
            
        }

        public SqlConnection openDB()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return conn;
        }

        public void closeDB()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
