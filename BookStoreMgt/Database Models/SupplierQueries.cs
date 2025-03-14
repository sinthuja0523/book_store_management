using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMgt.Database_Models
{
    internal class SupplierQueries
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
                string query = "SELECT * FROM tbl_suppliers";
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

        public bool checkTP(int v)
        {
            bool exists = false;
            try
            {
                conn.openDB();
                string query = "SELECT * FROM tbl_suppliers WHERE contact_number = '" + v + "'";
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn.conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                conn.closeDB();

                if (dataTable.Rows.Count == 0)
                {
                    exists = false;
                }
                else
                {
                    exists = true;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error has ocurred" + e);
            }
            return exists;
        }

        public string insertSupplier(string name, int contact_number, string email, string address)
        {
            string result = "";
            try
            {
                string query = "insert into tbl_suppliers (name, contact_number, email, address)" +
                    "values ('" + name + "','" + contact_number + "', '" + email + "','" + address + "')";
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

        public string updateSupplier(int id, string name, int contact_number, string email, string address)
        {
            string result = "";
            try
            {
                string query = "UPDATE tbl_suppliers SET name=@name, contact_number=@contact_number, email=@email, address=@address WHERE supplier_id = @id AND contact_number=@contact_number";
                conn.openDB();
                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@contact_number", contact_number);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);

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
                MessageBox.Show("Erro: " + e.ToString());
            }
            return result;

        }
    }
}
