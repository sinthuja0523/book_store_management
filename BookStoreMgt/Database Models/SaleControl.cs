using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BookStoreMgt.Database_Models
{
    class SaleControl
    {
        BookQueries BookQueries = new BookQueries();
        SalesQueries SalesQueries = new SalesQueries();

        public DataTable showSearchSale(string isbn)
        {
            BookQueries query = new BookQueries();
            DataTable data = new DataTable();
            data = query.showDataSearch(isbn);
            return data;
        }
        public string insertNewSale(string isbn, string title, string author, string year, string editora, string genre, string amount, string price)
        {
            string result = BookQueries.insertNewBook(isbn, title, author, Convert.ToInt32(year), editora, genre, Convert.ToInt32(amount), Convert.ToDecimal(price));
            return result;
        }
    }
}
