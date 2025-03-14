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

        public string insertNewSale(List<(int bookId, int quantity, decimal price)> books)
        {
            string result = "";
            try
            {
                DateTime purchasedDateTime = DateTime.Now;
                string query = "insert into tbl_sales (customer_id) values (@customer_id);" +
                   "SELECT SCOPE_IDENTITY()";
                conn.openDB();
                object value = (object)DBNull.Value;
                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@customer_id", value);

                int salesId = Convert.ToInt32(command.ExecuteScalar());

                List<int> bookIds = new List<int> { 9, 8 };
                List<int> quantities = new List<int> { 2, 1 };

                foreach (var book in books)
                {
                    string salesBookQuery = "INSERT INTO tbl_sales_books (sales_id, book_id, quantity,total_price) VALUES (@sales_id, @book_id, @quantity, @total_price)";
                    SqlCommand salesBookCommand = new SqlCommand(salesBookQuery, conn.conn);
                    salesBookCommand.Parameters.AddWithValue("@sales_id", salesId);
                    salesBookCommand.Parameters.AddWithValue("@book_id", book.bookId);
                    salesBookCommand.Parameters.AddWithValue("@quantity", book.quantity);
                    salesBookCommand.Parameters.AddWithValue("@total_price", book.quantity * book.price);

                    salesBookCommand.ExecuteNonQuery();
                }
                conn.closeDB();
                if (salesId > 0)
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
