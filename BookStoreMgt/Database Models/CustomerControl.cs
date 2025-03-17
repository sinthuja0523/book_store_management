using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMgt.Database_Models
{
    internal class CustomerControl
    {

        public DataTable showBooks()
        {
            CustomerQueries bookQuery = new CustomerQueries();
            DataTable data = new DataTable();
            data = bookQuery.showData();
            return data;
        }

    }
}
