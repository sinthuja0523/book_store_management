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
        CustomerQueries bookQuery = new CustomerQueries();
        public DataTable showBooks()
        {
            CustomerQueries bookQuery = new CustomerQueries();
            DataTable data = new DataTable();
            data = bookQuery.showData();
            return data;
        }
        public string deleteDataControl(string isbn)
        {
            string result = bookQuery.deleteData(isbn);
            return result;
        }
        public string updateDataControl(string id, string name, string email, string phone)
        {
            string str = bookQuery.updateData(Convert.ToInt32(id), name, email, phone);
            return str;
        }
        public int getCustomersCount()
        {
            int result = bookQuery.getCustomersCount();
            return result;
        }

    }
}
