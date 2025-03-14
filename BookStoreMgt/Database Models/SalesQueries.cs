using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMgt.Database_Models
{
    internal class SalesQueries
    {

        private ConnectionSQLserver conn = new ConnectionSQLserver();
        SqlCommand command;

        public string insertNewSale(int customer_id, string purchased_date_time)
        {
            string result = "";
            try
            {
                string query = "insert into tbl_sales(customer_id, purchased_date_time)" +
                    "values ('" + customer_id + "','" + purchased_date_time +  ")";
                conn.openDB();
                command = new SqlCommand(query, conn.conn);
                int i = command.ExecuteNonQuery();
                conn.closeDB();
                if (i > 0)
                {
                    result = "sucess";
                    return result;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }
}
