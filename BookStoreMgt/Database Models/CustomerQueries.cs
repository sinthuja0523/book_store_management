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

        public string updateData(int id, string name, string email, string phone)
        {
            string result = "";
            try
            {
                string query = "UPDATE tbl_customers SET name=@name, email=@email, phone=@phone WHERE customer_id = @id";
                conn.openDB();
                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);

                command.CommandType = CommandType.Text;
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
                MessageBox.Show("Error: " + e.ToString());
            }
            return result;

        }

        public string deleteData(string customer_id)
        {
            string result = "";
            try
            {
                string query = "DELETE FROM tbl_customers WHERE customer_id = @customer_id";
                conn.openDB();
                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.CommandType = CommandType.Text;
                int i = command.ExecuteNonQuery();
                conn.closeDB();
                command.Parameters.Clear();

                if (i > 0)
                {
                    result = "sucess";
                    return result;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }

            return result;
        }
    }
}
