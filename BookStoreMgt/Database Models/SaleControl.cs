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
        public string insertNewSale(List<(int bookId, int quantity, decimal price)> books, List<(string? name, string? email, string? phone)>? customer_details)
        {
            string result = SalesQueries.insertNewSale(books, customer_details);
            return result;
        }

    }
}
