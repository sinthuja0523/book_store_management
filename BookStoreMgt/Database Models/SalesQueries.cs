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

        public string insertNewSale(List<(int bookId, int quantity, decimal price)> books, List<(string? name, string? email, string? phone)>? customer_details)
        {
            string result = "";
            try
            {
                DateTime purchasedDateTime = DateTime.Now;

                conn.openDB();

                string CustomerQuery = "insert into tbl_customers (name,email,phone) values (@name,@email,@phone);" + "SELECT SCOPE_IDENTITY()";
                SqlCommand customerCommand = new SqlCommand(CustomerQuery, conn.conn);
                customerCommand.Parameters.AddWithValue("@name", customer_details[0].name);
                customerCommand.Parameters.AddWithValue("@email", customer_details[0].email);
                customerCommand.Parameters.AddWithValue("@phone", customer_details[0].phone);

                int? customerId = Convert.ToInt32(customerCommand.ExecuteScalar());
                MessageBox.Show(customerId.ToString());

                string query = "insert into tbl_sales (customer_id) values (@customer_id);" + "SELECT SCOPE_IDENTITY()";
                
                object value = (object)DBNull.Value;
                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@customer_id", customerId!=null? customerId : value);

                int salesId = Convert.ToInt32(command.ExecuteScalar());

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
                // INSERT CUSTOMER DETAILS

                
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
