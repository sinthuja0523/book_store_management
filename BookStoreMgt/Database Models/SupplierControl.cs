using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMgt.Database_Models
{
    internal class SupplierControl
    {
        public SupplierControl() { }
        
        SupplierQueries supplierQueries = new SupplierQueries();
        public DataTable showSuppliers()
        {
            SupplierQueries supplierQueries1 = new SupplierQueries();
            DataTable data = new DataTable();
            data = supplierQueries1.showData();
            return data;
        }
        public bool checkTPNo(int tp_no) {
            if (supplierQueries.checkTP(tp_no) == false)
            {
                // ainda não existe no banco de dados
                return false;
            }
            else
            {
                //Existe no banco de dados
                return true;
            }
        }
        public string insertSupplierControl(string name, int contact_number, string email, string address)
        {
            string result = supplierQueries.insertSupplier(name,contact_number,email,address);
            return result;
        }
        public string updateSupplierControl(string id, string name, int contact_number, string email, string address)
        {
            string str = supplierQueries.updateSupplier(Convert.ToInt32(id),name, contact_number,email,address);
            return str;
        }
        public string deleteSupplierControl(int contact_number)
        {
            string result = supplierQueries.deleteSupplier(contact_number);
            return result;
        }
    }
}
