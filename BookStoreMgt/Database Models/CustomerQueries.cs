using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMgt.Database_Models
{
    internal class CustomerQueries
    {
        private ConnectionSQLserver conn = new ConnectionSQLserver();
        SqlDataReader read;
        DataTable dataTable = new DataTable();
        SqlCommand command;


        public DataTable showData()
        {
            try
            {
                conn.openDB();
                string query = "SELECT * FROM tbl_customers";
                command = new SqlCommand(query, conn.conn);
                read = command.ExecuteReader();
                dataTable.Load(read);
                conn.closeDB();
                return dataTable;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
