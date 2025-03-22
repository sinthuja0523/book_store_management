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

        public int getSalesCount() {
            conn.openDB();
            string query = "SELECT COUNT(*) FROM tbl_sales";
            command = new SqlCommand(query, conn.conn);
            int totalSales = Convert.ToInt32(command.ExecuteScalar());
            conn.closeDB();
            return totalSales;

        }

        public string insertNewSale(List<(int bookId, int quantity, decimal price)> books, List<(string? name, string? phone, string? address, string? age)>? customer_details)
        {
            string result = "";
            try
            {
                conn.openDB();
                DateTime purchasedDateTime = DateTime.Now;

               // int converted_age = Convert.ToInt32(customer_details[0].age);
                //string CustomerQuery = "insert into tbl_customers (name,phone,address,age) values (@name,@phone,@address, @age);" + "SELECT SCOPE_IDENTITY()";
                //SqlCommand customerCommand = new SqlCommand(CustomerQuery, conn.conn);
                //customerCommand.Parameters.AddWithValue("@name", customer_details[0].name);
                //customerCommand.Parameters.AddWithValue("@phone", customer_details[0].phone);
                //customerCommand.Parameters.AddWithValue("@address", customer_details[0].address);
                //customerCommand.Parameters.AddWithValue("@age", converted_age);
                //int? customerId = Convert.ToInt32(customerCommand.ExecuteScalar());
                //MessageBox.Show(customerId.ToString());

                int? customerId = insertCustomerDetails(customer_details);

                string query = "insert into tbl_sales (customer_id) values (@customer_id);" + "SELECT SCOPE_IDENTITY()";
                
                object value = (object)DBNull.Value;

                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@customer_id", customerId!=-1? customerId : value);

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

        public int insertCustomerDetails(List<(string? name, string? phone, string? address, string? age)>? customer_details)
        {
            int customerID = -1;
            try
            {
               

                if (customer_details.Count == 0) {
                    return -1;
                }

                int converted_age = Convert.ToInt32(customer_details[0].age);
               
                string CustomerQuery = "insert into tbl_customers (name,phone,address,age) values (@name,@phone,@address, @age);" + "SELECT SCOPE_IDENTITY()";
                SqlCommand customerCommand = new SqlCommand(CustomerQuery, conn.conn);
                customerCommand.Parameters.AddWithValue("@name", customer_details[0].name);
                customerCommand.Parameters.AddWithValue("@phone", customer_details[0].phone);
                customerCommand.Parameters.AddWithValue("@address", customer_details[0].address);
                customerCommand.Parameters.AddWithValue("@age", converted_age);

                customerID = Convert.ToInt32(customerCommand.ExecuteScalar());

               

            }
            catch (Exception e)
            {
                throw e;
            }
            return customerID;
        }
    }
}
