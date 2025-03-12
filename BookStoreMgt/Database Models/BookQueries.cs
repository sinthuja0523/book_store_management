﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
// using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace BookStoreMgt
{
    public class BookQueries
    {
        private ConnectionSQLserver conn = new ConnectionSQLserver();
        SqlDataReader read;
        DataTable dataTable = new DataTable();
        SqlCommand command;

        /*
        public DataTable showData()
        {
            try
            {
                conn.openDB();
                string query = "SELECT * FROM books_stoke";
                command = new SqlCeCommand(query, conn.objConnection);
                read = command.ExecuteReader();
                dataTable.Load(read);
                conn.closeDB();
                return dataTable;
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
        */

        /*

        public DataTable showDataSearch(string isbn)
        {
            try
            {
                conn.openDB();
                string query = "SELECT * FROM books_stoke WHERE book_isbn = '" + isbn + "'";
                command = new SqlCeCommand(query, conn.objConnection);
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

        */

        

        public bool checkISBN(string v)
        {
            bool exists = false;
            try
            {
                conn.openDB();
                string query = "SELECT * FROM tbl_books WHERE isbn = '"+v+"'";
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

        

        public string insertNewBook(string isbn, string title, string author, int year, string editora, string genre, int amount, decimal price)
        {
            string result="";
            try
            {
                string query = "insert into tbl_books(isbn, title, author, published_year, editor, genre, stock_quantity, price)" +
                    "values ('" + isbn + "','" + title + "', '" + author + "', " + year + ", '" + editora + "', '" + genre + "', " + amount + ", " + price + ")";
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
            catch(Exception e)
            {
                throw e;
            }
            return result;
        }

        

        public string updateData(int id,string isbn, string title, string author, int year, string editora, string genre, int amount, decimal price)
        {
            string result= "";
            try
            {
                string query = "UPDATE books_stoke SET book_title=@title, book_author=@author, book_year=@year, book_editora=@editora, book_genre=@genre, book_amount=@amount, book_price=@price WHERE book_id = @id AND book_isbn=@isbn";
                conn.openDB();
                command = new SqlCommand(query, conn.conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@isbn",isbn);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@editora", editora);
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@price", price);

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
                MessageBox.Show("Erro: "+e.ToString());
            }
            return result;
            
        }

        /*
        public string deleteData(string isbn)
        {
            string result = "";
            try
            {
                string query = "DELETE FROM books_stoke WHERE book_isbn = @isbn";
                conn.openDB();
                command = new SqlCeCommand(query, conn.objConnection);
                command.Parameters.AddWithValue("@isbn",isbn);
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
                MessageBox.Show("Error: "+e.ToString());
            }

            return result;
        } */
    }
}


